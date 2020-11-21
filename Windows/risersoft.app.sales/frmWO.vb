Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports Infragistics.Win.UltraWinGrid

Public Class frmWO
    Inherits frmMax
    Dim WithEvents ItemCodeSys As New clsCodeSystem
    Dim myVueSpare As New clsWinView, myVueTT As New clsWinView, myVueTF As New clsWinView, myVueDoc As New clsWinView
    Dim myVueService As New clsWinView, myVueRateList As New clsWinView, myVueCampus As New clsWinView
    Dim pCode As String, f As frmAttribValue, dvMatDep, dvDivision
    Dim oSort, oSort1 As clsWinSortParent

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmWOModel = Me.InitData("frmWOModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_MatDepID,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "Status", "", Me.cmb_StatusNum)
            myWinSQL.AssignCmb(Me.dsCombo, "PaymentStage", "", Me.cmb_DSPaymentStageID)
            myWinSQL.AssignCmb(Me.dsCombo, "PaymentStage", "", Me.cmb_DSPaymentStageID_Ref)
            myWinSQL.AssignCmb(Me.dsCombo, "wotype", "", Me.cmb_WOType)
            myWinSQL.AssignCmb(Me.dsCombo, "HsnSac", "", Me.cmb_hsn_sc)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ConsigneeID)

            dvDivision = myWinSQL.AssignCmb(Me.dsCombo, "Division", "", Me.cmb_DivisionID, "<STRWIDTH>0-1-2</STRWIDTH>", 2)
            dvDivision.RowFilter = Me.Controller.AppModel.strFilterDBAppUser(Me.Controller, Me.fRow, "DivisionID")

            Me.cmb_SuperChType.ValueList = Me.Model.ValueLists("superchtype").ComboList
            Me.cmb_DSPeriodType.ValueList = Me.Model.ValueLists("periodtype").ComboList
            Me.cmb_DSperiodType_2.ValueList = Me.Model.ValueLists("periodtype").ComboList
            Me.cmb_DSCompPeriodType.ValueList = Me.Model.ValueLists("periodtype").ComboList
            Me.cmb_DSCompRateType.ValueList = Me.Model.ValueLists("numtype").ComboList
            Me.cmb_DSAtLeastType.ValueList = Me.Model.ValueLists("numtype").ComboList
            If myUtils.cStrTN(myRow("wotype")).Trim.Length = 0 Then myRow("wotype") = "SW"

            Me.PrepType()       'sets pcode, required for handlecombo

            ItemCodeSys.SetConf(Me.dsCombo.Tables("items"), Me.cmb_ItemID, Me.ComboName, Me.ComboUnit, Me.ComboUnit2)
            Me.cmb_ItemID.Value = myRow("itemid")
            Me.ItemCodeSys.HandleCombo(Me.cmb_ItemID) 'to remake the fittings views after save.
            Me.FormPrepared = True

            HandleDate(myUtils.cDateTN(myRow("WoDate"), DateTime.MinValue))
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("DelSched"), Me.btnAddNew, Me.btnDelete)
            myVueSpare.PrepEdit(Me.Model.GridViews("spare"))
            myVueService.PrepEdit(Me.Model.GridViews("service"))
            myVueTT.PrepEdit(Me.Model.GridViews("tt"), Me.btnAddTT, Me.btnDelTT)
            myVueTF.PrepEdit(Me.Model.GridViews("tf"))
            myVueDoc.PrepEdit(Me.Model.GridViews("doc"), Me.btnAddDoc, Me.btnDelDoc)
            myVueRateList.PrepEdit(Me.Model.GridViews("rate"))
            myVueCampus.PrepEdit(Me.Model.GridViews("campus"))

            oSort = New clsWinSortParent(myVueService, Me.btnUpSRV, Me.btnDownSRV, Me.btnIndentSRV, Me.btnOutdentSRV, Nothing, "SoServiceID", "PSoServiceID", "SortIndex", "FullSortIndex")
            oSort.reSort()

            oSort1 = New clsWinSortParent(myVueSpare, Me.btnUPSpare, Me.btnDownSpare, Me.btnIndentSpare, Me.btnOutdentSpare, Nothing, "SoSpareID", "PSoSpareID", "SortIndex", "FullSortIndex")
            oSort1.reSort()
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        Me.myView.SetGrid(Me.UltraGridDel)
        myVueSpare.SetGrid(Me.UltraGridSpare)
        myVueTT.SetGrid(Me.UltraGridTT)
        myVueTF.SetGrid(Me.UltraGridTF)
        myVueDoc.SetGrid(Me.UltraGridDoc)
        myVueRateList.SetGrid(Me.UltraGridRate)
        myVueService.SetGrid(Me.UltraGridSvc)
        myVueCampus.SetGrid(Me.UltraGridCampus)

        f = New frmAttribValue
        f.AddtoTab(Me.UltraTabControl1, "eto", True)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub
    Private Sub ItemCodeSys_ItemChanged() Handles ItemCodeSys.ItemChanged
        If myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "re") Then
            f.SetupForm(Me, "itemid", Me.cmb_ItemID.Value, "IEI", "workorderid", frmIDX, pCode)
        Else
            f.SetupForm(Me, "itemid", Me.cmb_ItemID.Value, "IEI", "pidunititemvarid", myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), pCode)
        End If
        myFuncs.SetQty2(Me.cmb_ItemID, f, Me.txt_TotalQty, Me.txt_TotalQty2)

        If Not IsNothing(cmb_ItemID.SelectedRow) Then cmb_hsn_sc.Value = myUtils.cStrTN(cmb_ItemID.SelectedRow.Cells("HSN_SC").Value)
        Select Case myUtils.cStrTN(myRow("wotype")).Trim.ToLower
            Case "re"

                Dim str1 As String = "itemid=" & myUtils.cValTN(Me.cmb_ItemID.Value)
                myUtils.DeleteRows(myVueRateList.mainGrid.myDS.Tables(0).Select("Not (" & str1 & ")"))
                For Each r1 As DataRow In Me.dsCombo.Tables("repairitem").Select(str1)
                    Dim rr() As DataRow = myVueRateList.mainGrid.myDS.Tables(0).Select("repairitemid=" & r1("repairitemid"))
                    If rr.Length = 0 Then
                        Dim nr As DataRow = myUtils.CopyOneRow(r1, myVueRateList.mainGrid.myDS.Tables(0))
                        nr("unit") = nr("repairitemid")
                    End If
                Next
            Case "sw"
                Me.AddRemove1.InitFittings(Me.dsCombo.Tables("fittingmaster"), Me.dsForm.Tables("fitting"), Me.cmb_ItemID.Value, "fittingreqid")
        End Select
    End Sub

    Private Sub PrepType()
        Me.btnEditTF.Visible = False
        Me.btnAddTF.Visible = False
        Me.btnDelTF.Visible = False
        Me.btnEditSerial.Visible = False

        Select Case myUtils.cStrTN(myRow("wotype")).Trim.ToLower
            Case "sw"
                Me.UltraPanelQty.Visible = True
                Me.UltraTabControl1.Tabs("ratelist").Visible = False
                Me.UltraTabControl1.Tabs("TF").Visible = True
                Me.UltraTabControl1.Tabs("SP").Visible = True
                Me.UltraTabControl1.Tabs("SVC").Visible = True
                Me.UltraTabControl1.Tabs("sites").Visible = False
                Me.UltraTabControl3.Tabs(1).Selected = True
                Me.lblNum.Text = "Work Order No."
                Me.lblDate.Text = "W.O. Date"
                Me.Text = "Work Order"
                Me.lblFreight.Text = "Freight (per unit)"
                pCode = "IsReqWONew"
                Me.btnEditTF.Visible = True
                AddHandler Me.btnEditTF.Click, AddressOf btn_Click
            Case "re"
                Me.btnEditSerial.Visible = True
                Me.UltraPanelQty.Visible = True
                Me.UltraTabControl1.Tabs("fittings").Visible = False
                Me.UltraTabControl1.Tabs("TF").Visible = True
                Me.UltraTabControl1.Tabs("SP").Visible = False
                Me.UltraTabControl1.Tabs("SVC").Visible = False
                Me.UltraTabControl1.Tabs("sites").Visible = False
                Me.UltraTabControl3.Tabs(0).Selected = True
                Me.lblNum.Text = "Repair Order No."
                Me.lblDate.Text = "R.O. Date"
                Me.Text = "Repair Order"
                Me.lblFreight.Text = "To and Fro Freight (per unit)"
                Me.lblFreight.AutoSize = True
                pCode = "IsReqWORep"
                Me.btnAddTF.Visible = True
                Me.btnEditTF.Visible = True
                Me.btnDelTF.Visible = True
                AddHandler Me.btnEditTF.Click, AddressOf btn_Click
                AddHandler Me.btnAddTF.Click, AddressOf btn_Click
                AddHandler Me.btnDelTF.Click, AddressOf btn_Click
            Case "sp"
                Me.UltraPanelQty.Visible = False
                Me.UltraTabControl1.Tabs("fittings").Visible = False
                Me.UltraTabControl1.Tabs("ratelist").Visible = False
                Me.UltraTabControl1.Tabs("sites").Visible = False
                Me.UltraTabControl1.Tabs("TF").Visible = False
                Me.UltraTabControl1.Tabs("SP").Visible = True
                Me.UltraTabControl1.Tabs("SVC").Visible = True
                Me.UltraTabControl1.Tabs("typetests").Visible = False
                Me.UltraTabControl3.Visible = False
                Me.lblNum.Text = "Spare Order No."
                Me.lblDate.Text = "SP.O. Date"
                Me.Text = "Spare Order"
                Me.lblFreight.Text = "Freight (per unit)"
                pCode = "IsReqWORep"
            Case "pr"
                Me.UltraPanelQty.Visible = True
                Me.UltraTabControl1.Tabs("fittings").Visible = False
                Me.UltraTabControl1.Tabs("ratelist").Visible = False
                Me.UltraTabControl1.Tabs("TF").Visible = False
                Me.UltraTabControl1.Tabs("SP").Visible = True
                Me.UltraTabControl1.Tabs("SVC").Visible = True
                Me.UltraTabControl1.Tabs("typetests").Visible = False
                Me.UltraTabControl1.Tabs("sites").Visible = True
                Me.UltraTabControl3.Visible = False
                Me.lblNum.Text = "Project Order No."
                Me.lblDate.Text = "PR.O. Date"
                Me.Text = "Project Order"
                Me.lblFreight.Text = "Freight (per unit)"
                pCode = "IsReqWORep"

        End Select
        ReCallOrderGrid()
    End Sub

    Private Sub ReCallOrderGrid()
        If myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "PR") Then myVueSpare.mainGrid.MainConf("HIDECOLS") = "IsNotBilled,MainSupplyPart"
        If myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "RE", "SP") Then myVueSpare.mainGrid.MainConf("HIDECOLS") = "MainSupplyPart,BillingLot"
        If myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "SW") Then myVueSpare.mainGrid.MainConf("HIDECOLS") = "BillingLot"
        If risersoft.app.mxform.myFuncs.IsCRMApp(Me.Controller) Then myVueSpare.mainGrid.MainConf("HIDECOLS") = "ValuationClass"

        myVueSpare.mainGrid.Genwidth(True)

        Dim Sql As String = "Select Class from AccountClass where ClassType = 'M' and ClassSubType in ('S','B')"
        Dim sql1 As String = "Select Code, Code + ' | ' + Description from HSNsac where Ty = 'G' Order By Code"
        Dim str1 As String = "<BAND IDFIELD=""sospareid"" TABLE=""sospare"" INDEX=""0""><COL KEY=""workorderid,pidunitid,freight,PSoSpareID,SortIndex,FullSortIndex""/><COL KEY=""ProductCode"" CAPTION=""Product Code""/><COL KEY=""totalwt"" CAPTION=""Total WT""/><COL KEY=""unitprice"" CAPTION=""Unit Price""/><COL KEY=""SpareName"" CAPTION=""Spare Name""/><COL KEY=""BOQNum"" CAPTION=""BOQ Num""/><COL KEY=""QtyBOQ"" CAPTION=""Qty BOQ""/><COL KEY=""Qty"" CAPTION=""Qty Actual""/><COL KEY=""ValuationClass"" CAPTION=""Valuation Class"" LOOKUPSQL=""" & Sql & """/><COL KEY=""TransType"" CAPTION=""Trans Type"" VLIST=""ST|FG""/><COL KEY=""BillingLot"" CAPTION=""Billing"" VLIST=""0;Qty|1;Lot""/><COL KEY=""HSN_SC"" WFACTOR=""2"" CAPTION=""HSN Code"" LOOKUPSQL=""" & sql1 & """/><COL KEY=""ItemUnitID"" CAPTION=""Unit Name"" LOOKUPSQL=""Select ItemUnitID,UnitName from ItemUnits""/><COL KEY=""FullBOQNum"" CAPTION=""Full BOQ"" NOEDIT=""True""/><COL KEY=""InvoiceSuffix"" CAPTION=""Invoice Suffix""/><COL KEY=""IsNotBilled"" CAPTION=""Billing Type"" VLIST=""False;Billed|True;NotBilled""/><COL KEY=""MainSupplyPart"" CAPTION=""Supply Type"" VLIST=""False;Separate|True;Part Of Main""/></BAND>"
        myVueSpare.mainGrid.PrepEdit(str1)
    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
        VSave = False
        If Me.ValidateData() AndAlso f.ValidateData Then
            reCalcQty2()
            cm.EndCurrentEdit()
            myFuncs.CalcDescrip(Me.cmb_ItemID, f, myRow.Row)
            If myUtils.IsInList(myRow("wotype"), "sw") Then
                Me.AddRemove1.UpdateTable(Me.dsForm.Tables("fitting"))
            ElseIf myUtils.IsInList(myRow("wotype"), "sp") Then
                myRow("descripwo") = "Spares for " & myRow("descripwo")
            End If
            If Me.SaveModel() Then
                If myUtils.IsInList(myRow("wotype"), "re") Then
                    f.VSave(frmIDX, True)
                Else
                    f.VSave(myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), True)
                End If
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnSelect_Click(sender As Object, e As EventArgs)
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@invoiceidcsv", "12,13", GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("invoice", Params)
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As frmMax, str1 As String = ""
        Select Case myUtils.cStrTN(myRow("wotype")).Trim.ToLower
            Case "sw"
                f = New frmProdSerial
                str1 = "prodserialid"
            Case "re"
                f = New frmRepairUnit
                str1 = "repairunitid"
        End Select
        If Not f Is Nothing Then
            Select Case LCase(sender.name)
                Case Me.btnEditTF.Name.ToLower
                    myVueTF.ContextRow = myVueTF.mainGrid.ActiveRow
                    If Not myVueTF.ContextRow Is Nothing Then

                        If f.PrepForm(myVueTF, EnumfrmMode.acEditM, myVueTF.ContextRow.CellValue(str1)) Then If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.myVueTF.RefreshGrid()
                    End If
                Case Me.btnAddTF.Name.ToLower
                    If Me.frmMode = EnumfrmMode.acEditM Then
                        If f.PrepForm(myVueTF, EnumfrmMode.acAddM, "", "<PARAMS WORKORDERID=""" & frmIDX & """/>") Then If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.myVueTF.RefreshGrid()
                    Else
                        MsgBox("You will have to save first to add T/F", MsgBoxStyle.OkOnly, myWinApp.Vars("appname"))
                    End If
            End Select

        End If
    End Sub

    Private Sub ChangeDelTab()
        Me.UltraTabControl2.Tabs(CInt(myUtils.cValTN((Me.cmb_DelSchedType.Value)))).Selected = True
    End Sub

    Private Sub btnAddHSN_Click(sender As Object, e As EventArgs) Handles btnAddHSN.Click
        Dim f As New frmHsnSac
        If f.PrepForm(myView, EnumfrmMode.acAddM, "") Then
            f.ShowDialog()
            If Not IsNothing(f.myRow) Then
                Dim nr As DataRow = myUtils.CopyOneRow(f.myRow.Row, dsCombo.Tables("HsnSac"))
                nr("Description") = f.myRow.Row("Code") & "-" & f.myRow.Row("Description")
                cmb_hsn_sc.Value = myUtils.cStrTN(f.myRow.Row("Code"))
            End If
        End If
    End Sub

    Private Sub cmb_DelSchedType_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_DelSchedType.ValueChanged
        ChangeDelTab()
    End Sub

    Private Sub btnAddCampus_Click(sender As Object, e As EventArgs) Handles btnAddCampus.Click
        If Me.VSave Then
            Dim dtSO As DataTable = Me.Model.DatasetCollection("so").Tables(0)
            Dim dt1 As DataTable = Me.GenerateIDOutput("pidunit", frmIDX).Data.Tables(0)
            If dt1.Rows.Count > 0 Then
                Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueCampus, "add", GetType(frmCampus), "campusid", "<PARAMS PIDUnitID=""" & myUtils.cValTN(dt1.Rows(0)("PIDUnitID")) & """ COMPANYID=""" & dtSO.Rows(0)("companyid") & """/>")
                If Not nr Is Nothing Then myVueCampus.RefreshGrid()
            End If
        End If
    End Sub

    Private Sub btnEditCampus_Click(sender As Object, e As EventArgs) Handles btnEditCampus.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myVueCampus, "edit", GetType(frmCampus), "campusid", "")
        If Not nr Is Nothing Then myVueCampus.RefreshGrid()
    End Sub

    Private Sub txt_TotalQty_Leave(sender As Object, e As EventArgs) Handles txt_TotalQty.Leave
        reCalcQty2()
    End Sub

    Private Sub reCalcQty2()
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_ItemID.SelectedRow)
        If Not r1 Is Nothing Then
            If myUtils.cStrTN(r1("unitname2")).Trim.Length > 0 AndAlso myUtils.cValTN(r1("etosku2attribid")) > 0 Then
                Me.txt_TotalQty2.Text = myFuncs.CalcQty2(Me.cmb_ItemID, f, myUtils.cValTN(Me.txt_TotalQty.Text), myUtils.cValTN(r1("etosku2attribid")))
            End If
        End If
    End Sub

    Private Sub dt_WODate_Leave(sender As Object, e As EventArgs) Handles dt_WODate.Leave, dt_WODate.AfterCloseUp
        HandleDate(dt_WODate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub

    Private Sub btnEditSerial_Click(sender As Object, e As EventArgs) Handles btnEditSerial.Click
        Dim f As New frmProdSerial
        If Not f Is Nothing Then
            myVueTF.ContextRow = myVueTF.mainGrid.ActiveRow
            If Not myVueTF.ContextRow Is Nothing Then
                Dim dt1 As DataTable = Me.GenerateIDOutput("prodserialid", myVueTF.ContextRow.CellValue("RepairUnitID")).Data.Tables(0)
                If dt1.Rows.Count > 0 Then
                    If f.PrepForm(myVueTF, EnumfrmMode.acEditM, myUtils.cValTN(dt1.Rows(0)("prodserialid"))) Then If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then Me.myVueTF.RefreshGrid()
                End If
            End If
        End If
    End Sub

    Private Sub btnAddSibSRV_Click(sender As Object, e As EventArgs) Handles btnAddSibSRV.Click
        Dim gr As UltraGridRow
        Dim rr1() As DataRow = myVueService.mainGrid.myDS.Tables(0).Select("PSoServiceID is NULL", " SortIndex desc")
        gr = myVueService.mainGrid.ButtonAction("add")
        If rr1.Length > 0 Then
            gr.Cells("SortIndex").Value = myUtils.cValTN(rr1(0)("SortIndex")) + 1
            gr.Cells("FullSortIndex").Value = myUtils.cValTN(rr1(0)("FullSortIndex")) + 1
        Else
            gr.Cells("SortIndex").Value = 1
            gr.Cells("FullSortIndex").Value = 1
        End If
        oSort.SetSortIndex("PSoServiceID")
        oSort.SetFullBOQ()
    End Sub

    Private Sub btnAddChildSRV_Click(sender As Object, e As EventArgs) Handles btnAddChildSRV.Click
        myVueService.ContextRow = myVueService.mainGrid.ActiveRow
        If (Not myVueService.ContextRow Is Nothing) Then
            If myUtils.cValTN(myVueService.ContextRow.CellValue("Qty")) = 0 AndAlso myUtils.cValTN(myVueService.ContextRow.CellValue("ItemUnitID")) = 0 AndAlso myUtils.IsInList(myUtils.cStrTN(myVueService.ContextRow.CellValue("HSN_SC")), "") AndAlso myUtils.cValTN(myVueService.ContextRow.CellValue("UnitPrice")) = 0 AndAlso myUtils.IsInList(myUtils.cStrTN(myVueService.ContextRow.CellValue("ServiceType")), "") AndAlso myUtils.IsInList(myUtils.cStrTN(myVueService.ContextRow.CellValue("ValuationClass")), "") Then

                Dim gr As UltraGridRow
                Dim rr1() As DataRow = myVueService.mainGrid.myDS.Tables(0).Select("PSoServiceID = " & myUtils.cValTN(myVueService.ContextRow.CellValue("SoServiceID")) & "", " SortIndex desc")
                gr = myVueService.mainGrid.ButtonAction("add")
                gr.Cells("PSoServiceID").Value = myUtils.cValTN(myVueService.ContextRow.CellValue("SoServiceID"))

                If rr1.Length > 0 Then
                    gr.Cells("SortIndex").Value = myUtils.cValTN(rr1(0)("SortIndex")) + 1
                Else
                    gr.Cells("SortIndex").Value = 1
                End If
                oSort.SetSortIndex("PSoServiceID")
                oSort.SetFullBOQ()
            Else
                MsgBox("First remove data (Qty, Unit, HSN, Unit Price, Valuation Class and Service Type) from parent row then add child.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnDelSRV_Click(sender As Object, e As EventArgs) Handles btnDelSRV.Click
        oSort.Delete()
        oSort.SetFullBOQ()
    End Sub

    Private Sub btnAddSibSpare_Click(sender As Object, e As EventArgs) Handles btnAddSibSpare.Click
        Dim gr As UltraGridRow
        Dim rr1() As DataRow = myVueSpare.mainGrid.myDS.Tables(0).Select("PSoSpareID is NULL", " SortIndex desc")
        gr = myVueSpare.mainGrid.ButtonAction("add")
        If rr1.Length > 0 Then
            gr.Cells("SortIndex").Value = myUtils.cValTN(rr1(0)("SortIndex")) + 1
            gr.Cells("FullSortIndex").Value = myUtils.cValTN(rr1(0)("FullSortIndex")) + 1
        Else
            gr.Cells("SortIndex").Value = 1
            gr.Cells("FullSortIndex").Value = 1
        End If
        oSort1.SetSortIndex("PSoSpareID")
        oSort1.SetFullBOQ()
    End Sub

    Private Sub btnAddChildSpare_Click(sender As Object, e As EventArgs) Handles btnAddChildSpare.Click
        myVueSpare.ContextRow = myVueSpare.mainGrid.ActiveRow
        If (Not myVueSpare.ContextRow Is Nothing) Then
            If myUtils.cValTN(myVueSpare.ContextRow.CellValue("Qty")) = 0 AndAlso myUtils.cValTN(myVueSpare.ContextRow.CellValue("ItemUnitID")) = 0 AndAlso myUtils.IsInList(myUtils.cStrTN(myVueSpare.ContextRow.CellValue("HSN_SC")), "") AndAlso myUtils.cValTN(myVueSpare.ContextRow.CellValue("UnitPrice")) = 0 AndAlso myUtils.IsInList(myUtils.cStrTN(myVueSpare.ContextRow.CellValue("TransType")), "") AndAlso myUtils.IsInList(myUtils.cStrTN(myVueSpare.ContextRow.CellValue("ValuationClass")), "") Then
                Dim gr As UltraGridRow
                Dim rr1() As DataRow = myVueSpare.mainGrid.myDS.Tables(0).Select("PSoSpareID = " & myUtils.cValTN(myVueSpare.ContextRow.CellValue("SoSpareID")) & "", " SortIndex desc")
                gr = myVueSpare.mainGrid.ButtonAction("add")
                gr.Cells("PSoSpareID").Value = myUtils.cValTN(myVueSpare.ContextRow.CellValue("SoSpareID"))

                If rr1.Length > 0 Then
                    gr.Cells("SortIndex").Value = myUtils.cValTN(rr1(0)("SortIndex")) + 1
                Else
                    gr.Cells("SortIndex").Value = 1
                End If
                If Not myUtils.IsInList(myUtils.cStrTN(myVueSpare.ContextRow.CellValue("IsNotBilled")), "") Then
                    gr.Cells("IsNotBilled").Value = myUtils.cBoolTN(myVueSpare.ContextRow.CellValue("IsNotBilled"))
                End If

                If Not myUtils.IsInList(myUtils.cStrTN(myVueSpare.ContextRow.CellValue("MainSupplyPart")), "") Then
                    gr.Cells("MainSupplyPart").Value = myUtils.cBoolTN(myVueSpare.ContextRow.CellValue("MainSupplyPart"))
                End If

                oSort1.SetSortIndex("PSoSpareID")
                oSort1.SetFullBOQ()
            Else
                MsgBox("First remove data (Qty, Unit, HSN, Unit Price, Valuation Class and Trans Type) from parent row then add child.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub

    Private Sub btnDelSpare_Click(sender As Object, e As EventArgs) Handles btnDelSpare.Click
        oSort1.Delete()
        oSort1.SetFullBOQ()
    End Sub

    Private Sub UltraGridSvc_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridSvc.AfterCellUpdate
        oSort.SetFullBOQ()
    End Sub

    Private Sub UltraGridSpare_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridSpare.AfterCellUpdate
        oSort1.SetFullBOQ()
    End Sub
End Class
