Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmInvoiceSaleCRM
    Inherits frmMax
    Friend fItem As frmInvoiceItemCRM
    Dim oSort As clsWinSortIV, dvSerialType, dvDivision, dvCamp, dvDelCamp, dvDelToCamp, dvGSTSubTyp As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Public Sub InitForm()
        myView.SetGrid(UltraGridItemList)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        Me.AddUEGB(Me.UEGB_Header, 3, Me.UEGB_ItemList.Name)
        Me.AddUEGB(Me.UEGB_ItemList, 2, Me.UEGB_Header.Name)
        Me.AddUEGB(Me.UEGB_ItemDetail, 1)

        fItem = New frmInvoiceItemCRM
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me
        fItem.InvItemType = ""
        fItem.InvFICO = True

        fItem.Enabled = False
        txt_InvoiceNum.ReadOnly = True
        AddHandler fItem.ChildCalling, AddressOf OnChildCalling
    End Sub

    Public Sub OnChildCalling(sender As Object, e As EventArgs)
        If (Not IsNothing(myRow)) AndAlso myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceTypeCode")), "IR") Then
            If myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then CalcPostBalance(myUtils.cValTN(myRow("AmountTot")))
        End If
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmInvoiceSaleCRMModel = Me.InitData("frmInvoiceSaleCRMModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            PanelAddSP.Visible = myUtils.cBoolTN(myRow("HasBOQRef"))
            PanelAddSerial.Visible = Not myUtils.cBoolTN(myRow("HasBOQRef"))

            If myUtils.cValTN(myRow("CDNInvoiceID")) > 0 Then
                SetOrgInvoiceNum()
            ElseIf myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then
                SetOrgInvoiceNumIR()
            End If

            If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then lblSalesOrder.Text = Me.GenerateIDOutput("salesorderdescrip", myUtils.cValTN(myRow("SalesOrderID"))).Description
            If myView.mainGrid.myDv.Table.Select.Length > 0 Then
                ReadOnlyCtl(True)
            End If

            SOBtnDisabled()

            If myUtils.cBoolTN(myWinSQL2.ParamValue("@Status", Me.Model.ModelParams)) Then
                btnSave.Enabled = False
                btnOK.Enabled = False
            End If
            fItem.UltraTabControl1.Tabs("Details").Selected = True
            HideCtlApp(myFuncs.ProgramName(Me.Controller))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Private Sub SOBtnDisabled()
        Dim rr() As DataRow = Me.dsForm.Tables("InvoiceItem").Select("SOSpareID > 0 or SOServiceID > 0")
        Dim rr1() As DataRow = Me.dsForm.Tables("ProdSerialItem").Select()
        If ((Not rr Is Nothing) AndAlso (rr.Length > 0)) OrElse ((Not rr1 Is Nothing) AndAlso (rr1.Length > 0)) Then
            btnSelectSO.Enabled = False
            btnRemoveSO.Enabled = False
        Else
            btnSelectSO.Enabled = True
            btnRemoveSO.Enabled = True
        End If
    End Sub

    Private Sub HideCtlApp(ProductName As String)
        UltraTabControl1.Tabs("SO").Visible = Not myUtils.IsInList(myUtils.cStrTN(ProductName), "BooksNirvana")
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ItemList"))

            dvCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_campusid,, 2)
            dvDelCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_DeliveryCampusID,, 2)
            dvDelToCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_ProjectCampusID,, 2)

            If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
                If myUtils.cValTN(myWinSQL2.ParamValue("@ProjectID", Me.Model.ModelParams)) > 0 Then
                    dvDelToCamp.RowFilter = "ProjectID = " & myUtils.cValTN(myWinSQL2.ParamValue("@ProjectID", Me.Model.ModelParams)) & ""
                Else
                    dvDelToCamp.RowFilter = "SalesOrderID = " & myUtils.cValTN(myRow("SalesOrderID")) & ""
                End If
            End If


            myWinSQL.AssignCmb(Me.dsCombo, "Customer", "", Me.cmb_CustomerID)
            dvSerialType = myWinSQL.AssignCmb(Me.dsCombo, "SubSerialType", "", Me.cmb_SubSerialType, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ConsigneeID)
            myWinSQL.AssignCmb(Me.dsCombo, "TaxInvoiceType", "", Me.cmb_TaxInvoiceType)

            myWinSQL.AssignCmb(Me.dsCombo, "InvoiceTypeCode", "", Me.cmb_InvoiceTypeCode)
            myWinSQL.AssignCmb(Me.dsCombo, "BillOf", "", Me.cmb_BillOf)
            dvDivision = myWinSQL.AssignCmb(Me.dsCombo, "Division", "", Me.cmb_DivisionID, , 2)

            myWinSQL.AssignCmb(Me.dsCombo, "POS", "", Me.cmb_POSTaxAreaID)

            fItem.BindModel(NewModel)
            fItem.fSoItemSelect.InitPanel(myUtils.cValTN(myRow("SalesOrderID")), 0, Me.fItem, Me, NewModel)


            oSort = New clsWinSortIV(myView, Me.btnUp, Me.btnDown, Me.btnLeft, Me.btnRight, Me.btnRenumber, "SortIndex", "SubSortIndex", "SerialNum", myRow.Row, "SubSerialType")
            If myUtils.cBoolTN(myRow("HasBOQRef")) Then
                oSort.PopulateSerialNum("")
            Else
                oSort.renumber()
            End If

            WinFormUtils.ValidateComboValue(cmb_BillOf, myUtils.cStrTN(myRow("BillOf")))
            WinFormUtils.ValidateComboValue(cmb_ConsigneeID, myUtils.cValTN(myRow("ConsigneeID")))
            myRow("POSTaxAreaID") = HandleConsigneeID()
            WinFormUtils.ValidateComboValue(cmb_InvoiceTypeCode, myUtils.cStrTN(myRow("InvoiceTypeCode")))

            WinFormUtils.ValidateComboValue(cmb_campusid, myUtils.cValTN(myRow("campusid")))
            WinFormUtils.ValidateComboValue(cmb_CustomerID, myUtils.cValTN(myRow("CustomerID")))
            WinFormUtils.ValidateComboValue(cmb_DivisionID, myUtils.cValTN(myRow("DivisionID")))

            HandleInvoiceType(myUtils.cStrTN(myRow("InvoiceTypeCode")))
            HandleBillOf(myUtils.cStrTN(myRow("BillOf")))
            HandleDate(myUtils.cDateTN(myRow("InvoiceDate"), DateTime.MinValue))
            HandleCampus()

            Return True
        End If
        Return False
    End Function

    Private Sub SetOrgInvoiceNum()
        If myUtils.cValTN(myRow("CDNInvoiceID")) > 0 OrElse myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then
            Dim dtCDNInv As DataTable = Me.Model.DatasetCollection("CDNInv").Tables(0)
            If Not IsNothing(dtCDNInv) AndAlso dtCDNInv.Rows.Count > 0 Then
                lblOrgInvNo.Text = myUtils.cStrTN(dtCDNInv.Rows(0)("InvoiceNum"))
                lblOrgInvDate.Text = dtCDNInv.Rows(0)("InvoiceDate")
            End If
        End If
    End Sub

    Private Sub SetOrgInvoiceNumIR()
        If myUtils.cValTN(myRow("CDNInvoiceID")) > 0 OrElse myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then
            Dim dtCDNInv As DataTable = Me.Model.DatasetCollection("CDNInv").Tables(0)
            If Not IsNothing(dtCDNInv) AndAlso dtCDNInv.Rows.Count > 0 Then
                lblOrgInvNo.Text = myUtils.cStrTN(dtCDNInv.Rows(0)("InvoiceNum"))
                lblOrgInvDate.Text = dtCDNInv.Rows(0)("InvoiceDate")
                txtPreBal.Value = myUtils.cValTN(dtCDNInv.Rows(0)("PreBalance"))
                CalcPostBalance(myUtils.cValTN(myRow("AmountTot")))
            End If
        End If
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()

        If (myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave) AndAlso Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub cmb_InvoiceTypeCode_Leave(sender As Object, e As EventArgs) Handles cmb_InvoiceTypeCode.Leave, cmb_InvoiceTypeCode.AfterCloseUp
        HandleInvoiceType(myUtils.cStrTN(cmb_InvoiceTypeCode.Value))
    End Sub

    Private Sub HandleInvoiceType(InvoiceTypeCode As String)
        cmb_BillOf.ReadOnly = myUtils.IsInList(myUtils.cStrTN(InvoiceTypeCode), "PF", "IR")
        UltraPanelOrgInv.Visible = Not myUtils.IsInList(myUtils.cStrTN(InvoiceTypeCode), "PF")
        PanelPreBal.Visible = myUtils.IsInList(myUtils.cStrTN(InvoiceTypeCode), "IR")

        If myUtils.IsInList(myUtils.cStrTN(InvoiceTypeCode), "PF") Then
            myRow("BillOf") = "C"
            cmb_BillOf.Value = "C"
            HandleBillOf(myUtils.cStrTN(myRow("BillOf")))
        ElseIf myUtils.IsInList(myUtils.cStrTN(InvoiceTypeCode), "IR") Then
            myRow("BillOf") = "P"
            cmb_BillOf.Value = "P"
            HandleBillOf(myUtils.cStrTN(myRow("BillOf")))
            btnSelectOrg.Text = "Select Base Invoice"
        End If
        EnableBtn()
    End Sub

    Private Sub cmb_BillOf_Leave(sender As Object, e As EventArgs) Handles cmb_BillOf.Leave, cmb_BillOf.AfterCloseUp
        HandleBillOf(myUtils.cStrTN(cmb_BillOf.Value))
        EnableBtn()
    End Sub

    Private Sub HandleBillOf(BillOf As String)
        If myUtils.IsInList(myUtils.cStrTN(BillOf), "P") Then
            txt_InvoiceNum.ReadOnly = False
        Else
            If myUtils.cBoolTN(myRow("DocNumManual")) Then
                txt_InvoiceNum.ReadOnly = False
            Else
                txt_InvoiceNum.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub cmb_campusid_Leave(sender As Object, e As EventArgs) Handles cmb_campusid.Leave, cmb_campusid.AfterCloseUp
        EnableBtn()
        HandleCampus()
    End Sub

    Private Sub ReadOnlyCtl(Enable As Boolean)
        cmb_InvoiceTypeCode.ReadOnly = Enable
        cmb_campusid.ReadOnly = Enable
        cmb_CustomerID.ReadOnly = Enable
        cmb_BillOf.ReadOnly = Enable
    End Sub

    Private Sub EnableBtn()
        If Not IsNothing(cmb_campusid.SelectedRow) AndAlso (Not IsNothing(cmb_CustomerID.SelectedRow)) AndAlso (Not IsNothing(cmb_InvoiceTypeCode.SelectedRow)) AndAlso Not IsNothing(cmb_BillOf.SelectedRow) Then
            PanelAddSerial.Enabled = True
        Else
            PanelAddSerial.Enabled = False
        End If
    End Sub

    Private Sub HandleCampus()
        dvDivision.RowFilter = myCommonUtils.FilterDivision(Me.Controller, Me.fRow, cmb_campusid, Nothing)
        If frmMode = EnumfrmMode.acAddM AndAlso cmb_DivisionID.Rows.Count = 1 Then cmb_DivisionID.Value = myUtils.cValTN(cmb_DivisionID.Rows(0).Cells("DivisionID").Value)
        If cmb_DivisionID.SelectedRow Is Nothing Then cmb_DivisionID.Value = DBNull.Value
    End Sub

    Private Sub dt_InvoiceDate_Leave(sender As Object, e As EventArgs) Handles dt_InvoiceDate.Leave, dt_InvoiceDate.AfterCloseUp
        HandleDate(dt_InvoiceDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvCamp.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "CampusID", 12)
    End Sub

    Private Sub cmb_CustomerID_Leave(sender As Object, e As EventArgs) Handles cmb_CustomerID.Leave, cmb_CustomerID.AfterCloseUp
        EnableBtn()
    End Sub

    Private Sub cmb_ConsigneeID_Leave(sender As Object, e As EventArgs) Handles cmb_ConsigneeID.Leave, cmb_ConsigneeID.AfterCloseUp
        Me.cmb_POSTaxAreaID.Value = HandleConsigneeID()
        EnableBtn()
    End Sub

    Private Function HandleConsigneeID() As Integer
        Dim POSTaxAreaID As Integer
        If myUtils.cValTN(cmb_ConsigneeID.Value) > 0 Then
            POSTaxAreaID = myUtils.cValTN(cmb_ConsigneeID.SelectedRow.Cells("TaxAreaID").Value)
            cmb_POSTaxAreaID.ReadOnly = True
        Else
            POSTaxAreaID = myUtils.cValTN(myRow("POSTaxAreaID"))
            cmb_POSTaxAreaID.ReadOnly = False
        End If
        Return POSTaxAreaID
    End Function

    Private Sub cmb_POSTaxAreaID_Leave(sender As Object, e As EventArgs) Handles cmb_POSTaxAreaID.Leave, cmb_POSTaxAreaID.AfterCloseUp
        EnableBtn()
    End Sub

    Private Sub btnSelectOrg_Click(sender As Object, e As EventArgs) Handles btnSelectOrg.Click
        If myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceTypeCode")), "IR") Then
            GetOrigInvIR()
        Else
            GetOrigInvCDN()
        End If
    End Sub

    Private Sub GetOrigInvIR()
        If myUtils.cValTN(cmb_campusid.Value) > 0 AndAlso myUtils.cValTN(cmb_CustomerID.Value) > 0 AndAlso myUtils.cValTN(cmb_DivisionID.Value) > 0 Then
            cm.EndCurrentEdit()
            Dim Params, Params2 As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@CustomerID", myUtils.cValTN(myRow("CustomerID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@CampusID", myUtils.cValTN(myRow("CampusID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@DivisionID", myUtils.cValTN(myRow("DivisionID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@InvoiceDate", Format(myRow("InvoiceDate"), "yyyy-MMM-dd"), GetType(Date), False))
            Dim rr1() As DataRow = Me.AdvancedSelect("orginvir", Params)

            If (Not IsNothing(rr1)) AndAlso rr1.Length > 0 Then
                Dim rr2() As DataRow = Me.PopulateDataRows("generateprebal", rr1, Params2)
                If (Not IsNothing(rr2)) AndAlso rr2.Length > 0 Then
                    myRow("ReverseInvoiceID") = myUtils.cValTN(rr2(0)("InvoiceID"))
                    lblOrgInvNo.Text = myUtils.cStrTN(rr2(0)("InvoiceNum"))
                    lblOrgInvDate.Text = myUtils.cStrTN(Format(rr2(0)("InvoiceDate"), "dd-MMM-yyyy"))
                    txtPreBal.Value = myUtils.cValTN(rr2(0)("PreBalance"))

                    If myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then CalcPostBalance(myUtils.cValTN(myRow("AmountTot")))
                End If
            End If
        End If
    End Sub

    Private Sub GetOrigInvCDN()
        If myUtils.cValTN(cmb_campusid.Value) > 0 AndAlso myUtils.cValTN(cmb_CustomerID.Value) > 0 AndAlso myUtils.cValTN(cmb_DivisionID.Value) > 0 Then
            cm.EndCurrentEdit()
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@CustomerID", myUtils.cValTN(myRow("CustomerID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@CampusID", myUtils.cValTN(myRow("CampusID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@DivisionID", myUtils.cValTN(myRow("DivisionID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
            Params.Add(New clsSQLParam("@InvoiceDate", Format(myRow("InvoiceDate"), "yyyy-MMM-dd"), GetType(Date), False))
            Dim rr1() As DataRow = Me.AdvancedSelect("invoice", Params)
            If (Not IsNothing(rr1)) AndAlso rr1.Length > 0 Then
                myRow("CDNInvoiceID") = myUtils.cValTN(rr1(0)("InvoiceID"))
                myRow("SalesOrderID") = myUtils.cValTN(rr1(0)("SalesOrderID"))
                lblOrgInvNo.Text = myUtils.cStrTN(rr1(0)("InvoiceNum"))
                lblOrgInvDate.Text = myUtils.cStrTN(Format(rr1(0)("InvoiceDate"), "dd-MMM-yyyy"))
            End If
        End If
    End Sub

    Private Sub UltraGridItemList_AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridItemList.AfterRowActivate
        Me.InitError()
        myView.mainGrid.myGrid.UpdateData()

        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
        fItem.PrepForm(r1)
        fItem.Enabled = True
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(sender As Object, e As CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAddSerial_Click(sender As Object, e As EventArgs) Handles btnAddSerial.Click
        Dim gr As UltraGridRow
        If myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave Then
            gr = myView.mainGrid.myGrid.DisplayLayout.Bands(0).AddNew()
            gr.Cells("SortIndex").Value = myUtils.MaxVal(myView.mainGrid.myDv.Table, "SortIndex") + 1

            myView.mainGrid.UpdateData()
            oSort.renumber()

            If myView.mainGrid.myDv.Table.Select.Length > 0 Then ReadOnlyCtl(True)

            fItem.Focus()
        End If
    End Sub

    Private Sub btnAddSubSerial_Click(sender As Object, e As EventArgs) Handles btnAddSubSerial.Click
        Dim gr, gr2 As UltraGridRow

        gr = myView.mainGrid.myGrid.ActiveRow
        If gr Is Nothing Then
            MsgBox("Select a Serial No.", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        Else
            If myView.mainGrid.myDv.Count = 0 OrElse fItem.VSave Then
                gr2 = myView.mainGrid.myGrid.DisplayLayout.Bands(0).AddNew()
                gr2.Cells("SortIndex").Value = gr.Cells("SortIndex").Value
                gr2.Cells("SubSortIndex").Value = myUtils.MaxVal(myView.mainGrid.myDv.Table.Select("SortIndex=" & gr.Cells("SortIndex").Value), "SubSortIndex") + 1
                gr2.RefreshSortPosition()

                myView.mainGrid.UpdateData()
                oSort.renumber()

                fItem.dvInvItemType.RowFilter = "CodeWord in ('IST', 'PIS', 'PIC')"

                If myView.mainGrid.myDv.Table.Select.Length > 0 Then ReadOnlyCtl(True)
                fItem.Focus()
            End If
        End If
    End Sub

    Private Sub btnDelItem_Click(sender As Object, e As EventArgs) Handles btnDelItem.Click
        myView.mainGrid.ButtonAction("del")
        If myView.mainGrid.myDv.Table.Select.Length = 0 Then
            fItem.FormPrepared = False
            ReadOnlyCtl(False)
            fItem.Enabled = False
        End If
        oSort.renumber()
    End Sub

    Private Sub btnSelectSO_Click(sender As Object, e As EventArgs) Handles btnSelectSO.Click
        cm.EndCurrentEdit()
        If Not cmb_campusid.SelectedRow Is Nothing Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@MainPartyID", myUtils.cValTN(cmb_CustomerID.SelectedRow.Cells("MainPartyID").Value), GetType(Integer), False))
            Params.Add(New clsSQLParam("@CompanyId", myUtils.cValTN(cmb_campusid.SelectedRow.Cells("CompanyId").Value), GetType(Integer), False))
            Params.Add(New clsSQLParam("@InvoiceDate", Format(dt_InvoiceDate.Value, "dd-MMM-yyyy"), GetType(DateTime), False))
            Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
            Dim rr1() As DataRow = Me.AdvancedSelect("salesorder", Params)
            If Not rr1 Is Nothing AndAlso rr1.Length > 0 Then
                myRow("SalesOrderID") = myUtils.cValTN(rr1(0)("SalesOrderID"))
                lblSalesOrder.Text = "Sales Order :- " & myUtils.cStrTN(rr1(0)("OrderNum")) & " Date - " & Format(rr1(0)("OrderDate"), "dd-MMM-yyyy")
            End If
        End If
    End Sub

    Private Sub btnRemoveSO_Click(sender As Object, e As EventArgs) Handles btnRemoveSO.Click
        myRow("SalesOrderID") = DBNull.Value
        lblSalesOrder.Text = "Select Sales Order"
    End Sub

    Private Sub BtnAddServices_Click(sender As Object, e As EventArgs) Handles BtnAddServices.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@salesorderid", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@soserviceid", myUtils.MakeCSV(dsForm.Tables("InvoiceItem").Select, "soserviceid"), GetType(Integer), True))
        If myUtils.cValTN(myRow("ProjectCampusID")) > 0 Then Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(cmb_ProjectCampusID.SelectedRow.Cells("PidUnitID").Value), GetType(Integer), False))
        Dim rr() As DataRow = Me.AdvancedSelect("addservices", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim SoServiceIDCSV As String = myUtils.MakeCSV(dsForm.Tables("InvoiceItem").Select, "SoServiceID")
            Dim GetSoServiceIDCSV As String = myCommonUtils.GetChildWithParent(rr(0).Table, rr(0).Table, "SoServiceID", "pSoServiceID")

            For Each r1 As DataRow In rr(0).Table.Select("SoServiceID Not in (" & myUtils.cStrTN(SoServiceIDCSV) & ") and SoServiceID in (" & myUtils.cStrTN(GetSoServiceIDCSV) & ")", "FullSortIndex")
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, myView.mainGrid.myDv.Table)
                r2("Description") = myUtils.cStrTN(r1("ServiceName"))
                r2("QtySOService") = myUtils.cValTN(r1("Qty"))
                SetRowColumn(r1, r2, "S")
                myCommonUtils.SetSortSubSort(r2, myView.mainGrid.myDv.Table, "SoServiceID", "SoSpareID")

                myView.mainGrid.UpdateData()
                oSort.reSort()
                oSort.PopulateSerialNum("")
            Next
        End If
    End Sub

    Private Sub btnAddSpares_Click(sender As Object, e As EventArgs) Handles btnAddSpares.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@salesorderid", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
        Params.Add(New clsSQLParam("@sospareid", myUtils.MakeCSV(dsForm.Tables("InvoiceItem").Select("QtyRate > 0"), "sospareid"), GetType(Integer), True))
        If myUtils.cValTN(myRow("ProjectCampusID")) > 0 Then Params.Add(New clsSQLParam("@PidUnitID", myUtils.cValTN(cmb_ProjectCampusID.SelectedRow.Cells("PidUnitID").Value), GetType(Integer), False))

        Dim rr() As DataRow = Me.AdvancedSelect("addspares", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim SoSpareIDCSV As String = myUtils.MakeCSV(dsForm.Tables("InvoiceItem").Select, "SoSpareID")
            Dim GetSoSpareIDCSV As String = myCommonUtils.GetChildWithParent(rr(0).Table, rr(0).Table, "SoSpareID", "pSoSpareID")

            For Each r1 As DataRow In rr(0).Table.Select("SoSpareID Not in (" & myUtils.cStrTN(SoSpareIDCSV) & ") and SoSpareID in (" & myUtils.cStrTN(GetSoSpareIDCSV) & ")", "FullSortIndex")
                Dim r2 As DataRow = myUtils.CopyOneRow(r1, myView.mainGrid.myDv.Table)
                r2("Description") = myUtils.cStrTN(r1("SpareName"))
                r2("QtySOSpare") = myUtils.cValTN(r1("Qty"))
                SetRowColumn(r1, r2, "M")
                myCommonUtils.SetSortSubSort(r2, myView.mainGrid.myDv.Table, "SoSpareID", "SoServiceID")

                myView.mainGrid.UpdateData()
                oSort.reSort()
                oSort.PopulateSerialNum("")
            Next
        End If
    End Sub

    Private Sub SetRowColumn(r1 As DataRow, r2 As DataRow, ClassType As String)
        If myUtils.cValTN(r1("Qty")) = 0 Then
            r2("InvoiceItemType") = "IGT"
            r2("SortIndex") = DBNull.Value
            r2("SubSortIndex") = DBNull.Value
        Else
            r2("InvoiceItemType") = "IST"
            r2("ClassType") = ClassType
            r2("QtyRate") = myUtils.cValTN(r1("Qty"))
            r2("SortIndex") = DBNull.Value
            r2("SubSortIndex") = DBNull.Value
        End If
    End Sub

    Private Sub btnDelSP_Click(sender As Object, e As EventArgs) Handles btnDelSP.Click
        If Not IsNothing(myView.mainGrid.myGrid.ActiveRow) Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(MyBase.myView.mainGrid.myGrid.ActiveRow)
            If myUtils.cValTN(r1("SOSpareID")) > 0 Then
                myCommonUtils.DeleteChildWithParent(myView, "SOSpareID", "PSoSpareID")
                myCommonUtils.ReSetIndexField(myView.mainGrid.myDv.Table, "SOSpareID", "PSoSpareID", "SubSortIndex")
            Else
                myCommonUtils.DeleteChildWithParent(myView, "SOServiceID", "PSOServiceID")
                myCommonUtils.ReSetIndexField(myView.mainGrid.myDv.Table, "SOServiceID", "PSOServiceID", "SubSortIndex")
            End If
            oSort.PopulateSerialNum("")
        End If
    End Sub

    Private Sub CalcPostBalance(AmountTot As Decimal)
        txt_PostBalance.Value = myUtils.cValTN(txtPreBal.Value) - AmountTot
    End Sub
End Class