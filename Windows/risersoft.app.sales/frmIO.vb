Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmIO
    Inherits frmMax
    Dim WithEvents ItemCodeSys As New clsCodeSystem
    Dim myVueTF As New clsWinView
    Dim pCode As String, f As frmAttribValue, dvMatDep, dvDivision As DataView

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridTT)
        myVueTF.SetGrid(Me.UltraGridTF)

        f = New frmAttribValue
        f.AddtoTab(Me.UltraTabControl1, "ETO", True)
        f.UltraPanelSave.Visible = False
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmIOModel = Me.InitData("frmIOModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Company", "", Me.cmb_CompanyID)
            dvDivision = myWinSQL.AssignCmb(Me.dsCombo, "Division", "", Me.cmb_DivisionID, "<STRWIDTH>0-1-2</STRWIDTH>", 2)
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_MatDepID,, 2)

            Me.ApplyCompanyFilter(myUtils.cValTN(myRow("companyid")))

            Me.PrepType()       'sets pcode, required for handlecombo


            ItemCodeSys.SetConf(Me.dsCombo.Tables("Items"), Me.cmb_ItemID, Me.CmbItemName, Me.ComboUnit, Me.ComboUnit2)
            Me.cmb_ItemID.Value = myRow("ItemId")
            Me.ItemCodeSys.HandleCombo(Me.cmb_ItemID) 'to remake the fittings views after save.
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("TT"), Me.btnAddTT, Me.btnDelTT)
            myVueTF.PrepEdit(Me.Model.GridViews("TF"))


            If frmMode = EnumfrmMode.acAddM Then If cmb_CompanyID.Rows.Count = 1 Then myRow("CompanyID") = myUtils.cValTN(cmb_CompanyID.Rows(0).Cells("CompanyID").Value)
            Return True
        End If
        Return False
    End Function

    Private Sub ItemCodeSys_ItemChanged() Handles ItemCodeSys.ItemChanged
        f.SetupForm(Me, "ItemId", Me.cmb_ItemID.Value, "IEI", "PIDUnitItemVarID", myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), pCode)
        myFuncs.SetQty2(Me.cmb_ItemID, f, Me.txt_Qty, Me.txt_Qty2)
        Me.AddRemove1.InitFittings(Me.dsCombo.Tables("fittingmaster"), Me.dsForm.Tables("fitting"), myUtils.cValTN(Me.cmb_ItemID.Value), "fittingreqid")
    End Sub

    Private Sub PrepType()
        pCode = "IsReqWONew"
        AddHandler Me.btnEditTF.Click, AddressOf btn_Click
    End Sub


    Public Overrides Function VSave() As Boolean
        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        If Me.ValidateData() AndAlso f.ValidateData Then
            reCalcQty2()
            cm.EndCurrentEdit()
            Me.AddRemove1.UpdateTable(Me.dsForm.Tables("fitting"))
            myFuncs.CalcDescrip(Me.cmb_ItemID, f, myRow.Row)
            If Me.SaveModel() Then
                f.VSave(myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), True)
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmProdSerial
        If Not f Is Nothing Then
            myVueTF.ContextRow = myVueTF.mainGrid.ActiveRow
            If Not myVueTF.ContextRow Is Nothing Then

                If f.PrepForm(myVueTF, EnumfrmMode.acEditM, myVueTF.ContextRow.CellValue("ProdSerialId")) Then If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.myVueTF.RefreshGrid()
            End If
        End If
    End Sub

    Private Sub txt_Qty_Leave(sender As Object, e As EventArgs) Handles txt_Qty.Leave
        reCalcQty2()
    End Sub

    Private Sub reCalcQty2()
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_ItemID.SelectedRow)
        If Not r1 Is Nothing Then
            If myUtils.cStrTN(r1("UnitName2")).Trim.Length > 0 AndAlso myUtils.cValTN(r1("ETOSku2AttribId")) > 0 Then
                Me.txt_Qty2.Text = myFuncs.CalcQty2(Me.cmb_ItemID, f, myUtils.cValTN(Me.txt_Qty.Text), myUtils.cValTN(r1("ETOSku2AttribId")))
            End If
        End If

    End Sub

    Private Sub cmb_CompanyID_Leave(sender As Object, e As EventArgs) Handles cmb_CompanyID.Leave, cmb_CompanyID.AfterCloseUp
        Me.ApplyCompanyFilter(Me.cmb_CompanyID.Value)
    End Sub
    Private Sub ApplyCompanyFilter(CompanyID As Integer)
        dvDivision.RowFilter = "CompanyID = " & CompanyID
        dvMatDep.RowFilter = "CompanyID = " & CompanyID
    End Sub
End Class
