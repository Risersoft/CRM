Imports risersoft.app.shared
Imports ug = Infragistics.Win.UltraWinGrid

Public Class frmInvoiceItemCRM
    Inherits frmMax
    Friend dvInvItemType As DataView
    Friend InvFICO As Boolean = False
    Dim dvUnits As DataView
    Public WithEvents fSoItemSelect As frmSOItemSelect, fMat As frmMax, InvItemType As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        fSoItemSelect = New frmSOItemSelect
        fSoItemSelect.AddtoTab(Me.UltraTabControl1, "accass", True)

    End Sub

    Private Sub CellUpdated(sender As Object, rChildElem As DataRow)
        If (Not IsNothing(myRow)) Then
            Me.OnFinished()
        End If
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        dvInvItemType = myWinSQL.AssignCmb(NewModel.dsCombo, "InvoiceItemType", "", Me.cmb_InvoiceItemType, , True)
        dvUnits = myWinSQL.AssignCmb(NewModel.dsCombo, "Units", "", Me.cmb_ItemUnitID,, 2)
        Return True
    End Function

    Public Overloads Function PrepForm(ByVal r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r1) Then
            fSoItemSelect.HandleItem()

            If myUtils.cValTN(fMat.myRow("SalesOrderID")) > 0 Then
                If Not IsNothing(fSoItemSelect.myView.mainGrid.myDv) Then fSoItemSelect.myView.mainGrid.myDv.RowFilter = "InvoiceItemID = " & myUtils.cValTN(myRow("InvoiceItemID"))
            Else
                If Not IsNothing(fSoItemSelect.myVueFA.mainGrid.myDv) Then fSoItemSelect.myVueFA.mainGrid.myDv.RowFilter = "InvoiceItemID = " & myUtils.cValTN(myRow("InvoiceItemID"))
            End If

            If myUtils.IsInList(myUtils.cStrTN(fMat.myRow("InvoiceTypeCode")), "IR") Then myRow("ReturnFY") = "C"

            If myRow("SubSortIndex").ToString.Length > 0 Then
                dvInvItemType.RowFilter = "CodeWord in ('IST', 'PIS', 'PIC'" & InvItemType & ")"
            Else
                dvInvItemType.RowFilter = "CodeWord in ('IGT', 'IGS', 'GHC','IST', 'PIS', 'PIC'" & InvItemType & ")"
            End If
            HandleInvoiceType(myUtils.cStrTN(myRow("InvoiceItemType")))

            Dim ExistCSV As String = myUtils.MakeCSV(myRow.Row.Table.Select("SortIndex = " & myUtils.cValTN(myRow("SortIndex")) & " and SubSortIndex is Not NULL"), "SubSortIndex")
            If myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceItemType")), "IGT", "IGS", "GHC") AndAlso ExistCSV.Length > 0 AndAlso ExistCSV <> 0 Then
                cmb_InvoiceItemType.ReadOnly = True
            End If

            If fMat.dsForm.Tables.Contains("ODNoteAdd") Then
                Dim rr1() As DataRow = fMat.dsForm.Tables("ODNoteAdd").Select()
                If rr1.Length > 0 Then
                    WinFormUtils.SetReadOnly(Me, True)
                End If
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False

        If IsNothing(myRow) Then
            WinFormUtils.AddError(Me.cmb_InvoiceItemType, "Please Generate Transaction")
            Exit Function
        End If

        If myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceItemType")), "GHC", "IST", "ISP") AndAlso myUtils.cValTN(Me.txt_QtyRate.Text) <= 0 Then WinFormUtils.AddError(txt_QtyRate, "Enter Qty")
        If myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceItemType")), "GHC", "IST", "ISP") AndAlso IsNothing(Me.cmb_ItemUnitID.SelectedRow) Then WinFormUtils.AddError(cmb_ItemUnitID, "Select Unit")
        If myUtils.NullNot(Me.cmb_InvoiceItemType.Value) Then WinFormUtils.AddError(Me.cmb_InvoiceItemType, "Select Invoice Item Type")
        If InvFICO = True AndAlso myUtils.cStrTN(Me.txt_Description.Text).Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Description, "Enter Description")

        If Me.CanSave Then
            cm.EndCurrentEdit()
            VSave = True
        End If
    End Function

    Private Sub cmb_InvoiceItemType_Leave(sender As Object, e As EventArgs) Handles cmb_InvoiceItemType.Leave, cmb_InvoiceItemType.AfterCloseUp
        fSoItemSelect.HandleItem()
        HandleInvoiceType(myUtils.cStrTN(cmb_InvoiceItemType.Value))
    End Sub

    Private Sub HandleInvoiceType(InvoiceItemType As String)
        ReadOnlyCtl(InvoiceItemType, "")
        UltraTabControl1.Tabs("AccAss").Visible = False
        If myUtils.IsInList(myUtils.cStrTN(InvoiceItemType), "PIC", "PIS", "IGT") Then
            NullCtl()
            If myUtils.IsInList(myUtils.cStrTN(InvoiceItemType), "PIC") Then myRow("SerialNum") = DBNull.Value
        ElseIf myUtils.IsInList(myUtils.cStrTN(InvoiceItemType), "IST", "ISP") Then
            Dim rr1() As DataRow = fMat.myView.mainGrid.myDv.Table.Select("SortIndex=" & myUtils.cValTN(myRow("SortIndex")) & " and SubSortIndex is Null ")
            If rr1.Length > 0 Then
                If myUtils.IsInList(myUtils.cStrTN(rr1(0)("InvoiceItemType")), "IGS", "GHC") Then
                    ReadOnlyCtl(InvoiceItemType, myUtils.cStrTN(rr1(0)("InvoiceItemType")))
                    If myUtils.IsInList(myUtils.cStrTN(rr1(0)("InvoiceItemType")), "IGS") Then
                    End If
                End If
            End If
            UltraTabControl1.Tabs("AccAss").Visible = True
        End If
    End Sub

    Private Sub ReadOnlyCtl(InvoiceItemType As String, PInvoiceItemType As String)
        cmb_InvoiceItemType.ReadOnly = fSoItemSelect.SelectionCount > 0
        txt_QtyRate.ReadOnly = fSoItemSelect.SelectionCount > 0 OrElse myUtils.IsInList(myUtils.cStrTN(InvoiceItemType), "PIC", "PIS", "IGT", "IGS")
        cmb_ItemUnitID.ReadOnly = fSoItemSelect.SelectionCount > 0 OrElse myUtils.IsInList(myUtils.cStrTN(InvoiceItemType), "PIC", "PIS", "IGT", "IGS")
    End Sub

    Private Sub NullCtl()
        txt_QtyRate.Value = DBNull.Value
        cmb_ItemUnitID.Value = DBNull.Value
    End Sub

    Private Sub fSoItemSelect_ItemAdded(sender As Object, e As System.EventArgs) Handles fSoItemSelect.ItemAdded
        ReadOnlyCtl("", "")
    End Sub

    Private Sub fSoItemSelect_ItemDeleted(sender As Object, e As System.EventArgs) Handles fSoItemSelect.ItemDeleted
        If fSoItemSelect.SelectionCount = 0 Then
            ReadOnlyCtl("", "")
        End If
    End Sub
End Class