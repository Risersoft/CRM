Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmSalesEnqItem
    Inherits frmMax
    Dim myVueSpare, myVueTT, myVueCQ, myVueDoc, myVueService As New clsWinView
    Dim WithEvents ItemCodeSys As New clsCodeSystem, f As frmAttribValue, pCode As String
    Dim dvMatDep As DataView

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim rTE As DataRow
        Me.FormPrepared = False
        Dim objModel As frmSalesEnqItemModel = Me.InitData("frmSalesEnqItemModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            rTE = Me.Model.DatasetCollection("SalesEnq").Tables(0).Rows(0)
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_MatDepID,, 2)

            HandleDate(myUtils.cDateTN(rTE("EnqDate"), DateTime.MinValue))

            Me.cmb_SuperChType.ValueList = Me.Model.ValueLists("SuperChType").ComboList
            ItemCodeSys.SetConf(dsCombo.Tables("Items"), Me.cmb_ItemID, Me.ComboName, Me.ComboUnit, Me.ComboUnit2)

            Me.chk_IsRepair.Checked = (myUtils.cStrTN(rTE("wotype")) = "RE")
            If (frmMode = EnumfrmMode.acAddM) AndAlso Me.cmb_ItemID.Rows.Count = 1 Then myRow("itemid") = Me.cmb_ItemID.Rows(0).Cells(Me.cmb_ItemID.ValueMember).Value
            If Me.chk_IsRepair.Checked Then pCode = "IsReqEnqRep" Else pCode = "IsReqEnqLong"
            If (myUtils.cBoolTN(rTE("quickte"))) AndAlso (Not Me.chk_IsRepair.Checked) Then pCode = "IsReqEnqShort"
            Me.cmb_ItemID.Value = myRow("itemid")
            Me.ItemCodeSys.HandleCombo(Me.cmb_ItemID)

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myVueSpare.PrepEdit(Me.Model.GridViews("Spare"), Me.btnAddSpare, Me.btnDelSpare)
            myVueCQ.PrepEdit(Me.Model.GridViews("CQ"), Me.btnAddCQ, Me.btnDelCQ)
            myVueTT.PrepEdit(Me.Model.GridViews("TT"), Me.btnAddTT, Me.btnDelTT)
            myVueDoc.PrepEdit(Me.Model.GridViews("Doc"), Me.btnAddDoc, Me.btnDelDoc)
            myVueService.PrepEdit(Me.Model.GridViews("Service"), Me.btnAddService, Me.btnDelService)
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()

        myVueSpare.SetGrid(Me.UltraGridSpare)
        myVueCQ.SetGrid(Me.UltraGridCQ)
        myVueTT.SetGrid(Me.UltraGridTT)
        myVueDoc.SetGrid(Me.UltraGridDoc)
        myVueService.SetGrid(Me.UltraGridSvc)

        f = New frmAttribValue
        f.AddtoTab(Me.UltraTabControl1, "eto", True)
        f.UltraPanelSave.Visible = False
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub

    Private Sub ItemCodeSys_ItemChanged() Handles ItemCodeSys.ItemChanged
        f.SetupForm(Me, "itemid", myUtils.cValTN(Me.cmb_ItemID.Value), "IEI", "pidunititemvarid", myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), pCode)
        myFuncs.SetQty2(Me.cmb_ItemID, f, Me.txt_QtyAPT, Me.txt_QtyAPT2)
        If Not Me.chk_IsRepair.Checked Then Me.AddRemove1.InitFittings(Me.dsCombo.Tables("fittingmaster"), Me.dsForm.Tables("fitting"), myUtils.cValTN(Me.cmb_ItemID.Value), "fittingreqid")
    End Sub

    Public Overrides Function VSAve() As Boolean

        Me.InitError()
        VSAve = False
        If Me.ValidateData() AndAlso f.ValidateData Then
            reCalcQty2()
            cm.EndCurrentEdit()

            If Not Me.chk_IsRepair.Checked Then Me.AddRemove1.UpdateTable(Me.dsForm.Tables("fitting"))
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

    Private Sub txt_QtyAPT_Leave(sender As Object, e As EventArgs) Handles txt_QtyAPT.Leave
        Me.reCalcQty2()
    End Sub

    Private Sub reCalcQty2()
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_ItemID.SelectedRow)
        If myUtils.cStrTN(r1("unitname2")).Trim.Length > 0 AndAlso myUtils.cValTN(r1("etosku2attribid")) > 0 Then
            Me.txt_QtyAPT2.Text = myFuncs.CalcQty2(Me.cmb_ItemID, f, myUtils.cValTN(Me.txt_QtyAPT.Text), myUtils.cValTN(r1("etosku2attribid")))
        End If
        If myUtils.cValTN(Me.txt_QtyAPT2.Text) > 0 Then
            Me.txt_QtyExp2.Text = Format(myUtils.cValTN(Me.txt_QtyExp.Text) / myUtils.cValTN(Me.txt_QtyAPT.Text) * myUtils.cValTN(Me.txt_QtyAPT2.Text), "0.##")
            Me.txt_QtyTBQ2.Text = Format(myUtils.cValTN(Me.txt_QtyTBQ.Text) / myUtils.cValTN(Me.txt_QtyAPT.Text) * myUtils.cValTN(Me.txt_QtyAPT2.Text), "0.##")
        Else
            Me.txt_QtyExp2.Value = DBNull.Value
            Me.txt_QtyTBQ2.Value = DBNull.Value
        End If
    End Sub

    Private Sub txt_QtyTBQ_Leave(sender As Object, e As EventArgs) Handles txt_QtyTBQ.Leave
        Me.reCalcQty2()
    End Sub

    Private Sub txt_QtyExp_Leave(sender As Object, e As EventArgs) Handles txt_QtyExp.Leave
        Me.reCalcQty2()
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class
