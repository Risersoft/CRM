Imports risersoft.app.mxform
Imports Infragistics.Win.UltraWinGrid

Public Class frmDispatch
    Inherits frmMax
    Dim myVueSpare As New clsWinView, myVueDoc As New clsWinView

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmDispatchModel = Me.InitData("frmDispatchModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ConsigneeID)
            myWinSQL.AssignCmb(Me.dsCombo, "POS", "", Me.cmb_POSTaxAreaID)

            If myUtils.cValTN(myRow("ConsigneeID")) > 0 Then cmb_ConsigneeID.Value = myUtils.cValTN(myRow("ConsigneeID"))
            HandleConsigneeID()

            NoEditView()

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("ProdSerialItem"))
            myView.mainGrid.HighlightRows()
            myVueSpare.PrepEdit(Me.Model.GridViews("Spare"))
            myVueSpare.mainGrid.HighlightRows()
            myVueDoc.PrepEdit(Me.Model.GridViews("Doc"), , Me.btnDelDoc)
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        myVueSpare.SetGrid(Me.UltraGridSpare)
        myVueDoc.SetGrid(Me.UltraGridDoc)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub


    Public Overrides Function VSave() As Boolean
        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click, btnEditDoc.Click
        Dim btn As Infragistics.Win.Misc.UltraButton = CType(sender, Infragistics.Win.Misc.UltraButton)

        Select Case LCase(btn.Name)
            Case "btneditdoc"
                Dim f As New frmDocDue
                If f.PrepForm(myVueDoc, EnumfrmMode.acEditM, "") Then f.ShowDialog()
            Case "btnadddoc"
                Dim f As New frmDocDue
                If f.PrepForm(myVueDoc, EnumfrmMode.acAddM, "") Then f.ShowDialog()
        End Select
    End Sub

    Private Sub cmb_ConsigneeID_Leave(sender As Object, e As EventArgs) Handles cmb_ConsigneeID.Leave, cmb_ConsigneeID.AfterCloseUp
        HandleConsigneeID()
    End Sub

    Private Sub HandleConsigneeID()
        If myUtils.cValTN(cmb_ConsigneeID.Value) > 0 Then
            Me.cmb_POSTaxAreaID.Value = myUtils.cValTN(cmb_ConsigneeID.SelectedRow.Cells("TaxAreaID").Value)
            cmb_POSTaxAreaID.ReadOnly = True
        Else
            Me.cmb_POSTaxAreaID.Value = DBNull.Value
            cmb_POSTaxAreaID.ReadOnly = False
        End If
    End Sub

    Private Sub btnConsignee_Click(sender As Object, e As EventArgs) Handles btnConsignee.Click
        If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
            Dim rr1() As DataRow = Me.AdvancedSelect("WO", Params)
            If Not rr1 Is Nothing AndAlso rr1.Length > 0 Then
                If myUtils.cValTN(rr1(0)("ConsigneeID")) > 0 Then cmb_ConsigneeID.Value = myUtils.cValTN(rr1(0)("ConsigneeID"))
                txt_ConsigneePrefix.Text = myUtils.cStrTN(rr1(0)("ConsigneePrefix"))
                txt_DeliveryTo.Text = myUtils.cStrTN(rr1(0)("DeliveryTo"))

                HandleConsigneeID()
            End If
        End If
    End Sub

    Private Sub btnAddSpares_Click(sender As Object, e As EventArgs) Handles btnAddSpares.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@salesorderid", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@sospareid", myUtils.MakeCSV(myVueSpare.mainGrid.myDv.Table.Select("Qty > 0"), "sospareid"), GetType(Integer), True))

        Dim rr() As DataRow = Me.AdvancedSelect("addspares", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim SoSpareIDCSV As String = myUtils.MakeCSV(myVueSpare.mainGrid.myDv.Table.Select, "SoSpareID")
            Dim GetSoSpareIDCSV As String = myCommonUtils.GetChildWithParent(rr(0).Table, rr(0).Table, "SoSpareID", "pSoSpareID")

            For Each r1 As DataRow In rr(0).Table.Select("SoSpareID Not in (" & myUtils.cStrTN(SoSpareIDCSV) & ") and SoSpareID in (" & myUtils.cStrTN(GetSoSpareIDCSV) & ")", "FullSortIndex")
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueSpare.mainGrid.myDv.Table)
                r2("TotalQty") = myUtils.cValTN(r1("Qty"))
                r2("Qty") = DBNull.Value

                myCommonUtils.SetSortSubSort(r2, myVueSpare.mainGrid.myDv.Table, "SoSpareID", "SoSpareID")
                NoEditView()
                myVueSpare.mainGrid.UpdateData()
            Next
        End If
    End Sub

    Private Sub NoEditView()
        For Each gr As UltraGridRow In myVueSpare.mainGrid.myGrid.Rows
            If (myUtils.NullNot(gr.Cells("TotalQty").Value)) Then gr.Activation = Activation.NoEdit
        Next
    End Sub

    Private Sub btnDelSP_Click(sender As Object, e As EventArgs) Handles btnDelSP.Click
        If Not IsNothing(myVueSpare.mainGrid.myGrid.ActiveRow) Then
            myCommonUtils.DeleteChildWithParent(myVueSpare, "SOSpareID", "PSoSpareID")
            myCommonUtils.ReSetIndexField(myVueSpare.mainGrid.myDv.Table, "SOSpareID", "PSoSpareID", "SubSortIndex")
        End If
    End Sub
End Class

