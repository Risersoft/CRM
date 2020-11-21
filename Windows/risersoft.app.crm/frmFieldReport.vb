Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform

Public Class frmFieldReport
    Inherits frmMax
    Friend fItem As frmFieldReportItem

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.initForm()
    End Sub

    Public Sub initForm()
        myView.SetGrid(UltraGridItemList)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        fItem = New frmFieldReportItem
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me

        fItem.Enabled = False
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmFieldReportModel = Me.InitData("frmFieldReportModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AttendedByID)
            myWinSQL.AssignCmb(Me.dsCombo, "Serial", "", Me.cmb_ProdSerialID)

            fItem.BindModel(objModel)

            If myUtils.cValTN(myRow("PidUnitId")) = 0 Then
                Me.cmb_ProdSerialID.Visible = False
                Me.lblPS.Visible = False
                Me.Text = "Field Report - General"
            Else
                Me.Text = "Field Report - Work Order"
            End If

            InitUpLoad()

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

     Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ItemList"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False

        cm.EndCurrentEdit()
        If (myView.mainGrid.myDS.Tables(0).Select.Length = 0 OrElse fItem.VSave) AndAlso Me.ValidateData() Then
            myRow("PdfOwnerPass") = Me.CtlUpLoad1.EncryptPassword
            myRow("PdfSource") = Me.CtlUpLoad1.FilePath
            If Me.SaveModel() Then
                InitUpLoad()
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub InitUpLoad()
        Me.CtlUpLoad1.InitExt(frmMode, "NC" & myRow("FieldReportId") & "." & "pdf", myUtils.cStrTN(myRow("PdfSource")), myUtils.cStrTN(myRow("PdfOwnerPass")), "/NC", "pdf", "nc")
    End Sub

    Private Sub UltraGridItemList_AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridItemList.AfterRowActivate
        Me.InitError()
        myView.mainGrid.myGrid.UpdateData()
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        If fItem.PrepForm(r1) Then
            fItem.Enabled = True
        End If
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(sender As Object, e As ComponentModel.CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If myView.mainGrid.myDS.Tables(0).Select.Length = 0 OrElse fItem.VSave Then
            Dim gr As UltraGridRow
            gr = myView.mainGrid.ButtonAction("add")
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("del")

        If myView.mainGrid.myDS.Tables(0).Select.Length = 0 Then
            fItem.FormPrepared = False

            fItem.Enabled = False
        End If
    End Sub

    Private Sub cmb_AttendedByID_Leave(sender As Object, e As EventArgs) Handles cmb_AttendedByID.Leave, cmb_AttendedByID.AfterCloseUp
        If Not IsNothing(cmb_ProdSerialID.SelectedRow) Then
            myRow("SupplyDate") = cmb_ProdSerialID.SelectedRow.Cells("DispatchedOn").Value
            myRow("InstDate") = cmb_ProdSerialID.SelectedRow.Cells("CommissionedOn").Value
        End If
    End Sub
End Class