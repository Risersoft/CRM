Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxform.gst

<DataContract>
Public Class frmInvoiceSaleCRMModel
    Inherits clsFormDataModel
    Dim PPFinal As Boolean = False
    Dim myViewSerialSO, myViewFASO As clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ItemList")
        myViewSerialSO = Me.GetViewModel("SerialSO")
        myViewFASO = Me.GetViewModel("FASO")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select CampusID, DispName, Camp.CompanyID, TaxAreaCode, DivisionCodeList, WODate, Camp.CompletedOn, TaxAreaID, GstRegID, Camp.SalesOrderID, PidUnitID,CampusCode,ProjectID from mmlistCampus() as Camp Left join SalesOrder on Camp.SalesOrderID = SalesOrder.SalesOrderID  Order by DispName"
        Me.AddLookupField("CampusID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campus").TableName)
        Me.AddLookupField("deliverycampusid", "Campus")
        Me.AddLookupField("ProjectCampusID", "Campus")

        sql = "SELECT  CustomerID, CustDescrip, CustomerClass, GSTIN,TaxAreaCode, TaxAreaID, MainPartyID FROM  slsListCustomer() Order By PartyName"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Customer").TableName)

        sql = myFuncsBase.CodeWordSQL("Document", "SerialType", "")
        Me.AddLookupField("SubSerialType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "SubSerialType").TableName)

        sql = "Select PartyID, PartyName, TaxAreaID from Party order by PartyName"
        Me.AddLookupField("ConsigneeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)

        sql = myFuncsBase.CodeWordSQL("Invoice", "TaxType", "")
        Me.AddLookupField("TaxInvoiceType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "TaxInvoiceType").TableName)

        sql = myFuncsBase.CodeWordSQL("Invoice", "InvoiceType", "CodeWord in ('PF','FD','FC')")
        Me.AddLookupField("InvoiceTypeCode", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "InvoiceTypeCode").TableName)

        sql = myFuncsBase.CodeWordSQL("Invoice", "BillOf", "")
        Me.AddLookupField("BillOf", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BillOf").TableName)

        sql = "Select Divisionid, DivisionCode from Division order by DivisionCode"
        Me.AddLookupField("DivisionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)


        sql = "select TaxAreaID, Descrip,TaxAreaCode from TaxArea Order by Descrip"
        Me.AddLookupField("POSTaxAreaID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "POS").TableName)

        '----------------Item---------------

        sql = "Select CodeWord, DescripShort from CodeWords where CodeClass = 'Invoice' and CodeType = 'ItemType'  Order By DescripShort"
        Me.AddLookupField("InvoiceItem", "InvoiceItemType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "InvoiceItemType").TableName)

        sql = "Select ItemUnitID, UnitName from ItemUnits"
        Me.AddLookupField("InvoiceItem", "ItemUnitID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Units").TableName)

        sql = "Select * from systemoptions"
        myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "options")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String, objIVProcFico As New clsIVProcFICO("IS", myContext)

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select *,  0.00 as PostBalance  from Invoice Where InvoiceID = " & prepIDX
        Me.InitData(sql, "SalesOrderID,InvoiceTypeCode,HasBOQRef", oView, prepMode, prepIDX, strXML)

        If frmMode = EnumfrmMode.acAddM Then
            myRow("InvoiceDate") = Now.Date
            myRow("PostingDate") = Now.Date
        Else
            Dim rPostPeriod As DataRow = objIVProcFico.oMasterFICO.rPostPeriod(myUtils.cValTN(myRow("PostPeriodID")))
            If Not IsNothing(rPostPeriod) Then
                PPFinal = myUtils.cBoolTN(rPostPeriod("IsFinal"))
            End If
        End If


        Me.BindDataTable(myUtils.cValTN(prepIDX))
        objIVProcFico.LoadVouch(myUtils.cValTN(myRow("InvoiceID")))

        If myUtils.cBoolTN(myRow("HasBOQRef")) = False Then myView.MainGrid.MainConf("HIDECOLS") = "BOQNum, FullBOQNum"
        myView.MainGrid.BindGridData(Me.dsForm, 1)
        myView.MainGrid.QuickConf("", True, "1-1-1-2-1-1-1")
        Dim str1 As String = "<BAND INDEX = ""0"" TABLE = ""InvoiceItem"" IDFIELD=""InvoiceItemID""><COL KEY ="" InvoiceItemID, InvoiceID, SOSpareID, SOServiceID, QtySOService, QtySOSpare, VarNum, PIDUnitID, ItemID, SerialNum, ClassType, TransType, ValuationClass, PriceSlabID, POSerialNum, RNPrevRate, QtyPrev, QtyPO, PPSubType, AmountBasic, InvoiceItemType, SortIndex, SubSortIndex, BasicRate, Description, AmountTot, AmountWV,ReturnFY,HSN_SC,ItemUnitID""/><COL  NOEDIT=""TRUE"" KEY=""QtyRate"" CAPTION=""Qty""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
            If frmMode = EnumfrmMode.acAddM Then myRow("InvoiceTypeCode") = "PF"

            Dim dtPS As DataTable = dsForm.Tables("ProdSerialItem")

            myViewSerialSO.MainGrid.BindGridData(dsForm, dtPS.DataSet.Tables.IndexOf(dtPS))
            myViewSerialSO.MainGrid.QuickConf("", True, "1-1-1")
            str1 = "<BAND INDEX = ""0"" TABLE = ""ProdSerialItem"" IDFIELD=""ProdSerialItemID""><COL KEY ="" ProdSerialID, InvoiceItemID, ODNoteItemID ""/></BAND>"
            myViewSerialSO.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

            sql = "Select SOSpareID, SpareName, PIDInfo from slsListSOSpares() where SalesOrderID = " & myUtils.cValTN(myRow("SalesOrderID"))
            Me.AddLookupField("ODNoteSpare", "SoSpareID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "SOSpare").TableName)
            Me.AddLookupField("ODNoteSpare", "PIDInfoSp", "SOSpare")

            sql = "Select SOServiceID, ServiceName, PIDInfo from slsListSOService() Where SalesOrderID = " & myUtils.cValTN(myRow("SalesOrderID"))
            Me.AddLookupField("ODNoteSpare", "SoServiceID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "SOService").TableName)
            Me.AddLookupField("ODNoteSpare", "PIDInfoSvc", "SOService")
        End If

        Dim dtFA As DataTable = dsForm.Tables("FixedAssetItem")
        myViewFASO.MainGrid.BindGridData(dsForm, dtFA.DataSet.Tables.IndexOf(dtFA))
        myViewFASO.MainGrid.QuickConf("", True, "2-1-1")
        str1 = "<BAND INDEX = ""0"" TABLE = ""FixedAssetItem"" IDFIELD=""FixedAssetItemID""><COL KEY ="" FixedAssetID, InvoiceItemID, PaymentItemTransID, Qty ""/><COL KEY=""AMOUNT"" NOEDIT=""True""/></BAND>"
        myViewFASO.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        If myUtils.cValTN(myRow("CDNInvoiceID")) > 0 Then
            Me.AddDataSet("CDNInv", "Select * from Invoice where InvoiceID = " & myUtils.cValTN(myRow("CDNInvoiceID")))
        ElseIf myUtils.cValTN(myRow("ReverseInvoiceID")) > 0 Then
            Me.AddDataSet("CDNInv", "Select *, 0.00 as PostBalance from Invoice where InvoiceID = " & myUtils.cValTN(myRow("ReverseInvoiceID")))
            objIVProcFico.PopulatePreBalanceDue(Me.DatasetCollection("CDNInv").Tables(0).Rows(0))
        End If

        Me.ModelParams.Add(New clsSQLParam("@Status", myFuncs.CheckStatus(myContext, "InvoiceID", myUtils.cValTN(myRow("InvoiceID"))), GetType(Boolean), False))

        sql = "Select ProjectID from SalesOrder where SalesOrderID  = " & myUtils.cValTN(myRow("SalesOrderID")) & ""
        Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        If dt1.Rows.Count > 0 Then
            Me.ModelParams.Add(New clsSQLParam("@ProjectID", myUtils.cValTN(dt1.Rows(0)("ProjectID")), GetType(Integer), False))
        End If

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Private Sub BindDataTable(ByVal InvoiceID As Integer)
        Dim ds As DataSet, Sql1, Sql2, Sql3, Sql As String

        Sql1 = " Select InvoiceItemID, InvoiceID, SOSpareID,PSospareID, SoServiceID,PSoServiceID, VarNum, ItemUnitID, PIDUnitID, ItemID, PriceSlabID, TaxCredit,ReturnFY, POSerialNum, RNPrevRate, QtyPrev, QtyPO, PPSubType, AmountBasic, QtySOService, QtySOSpare, BasicRate,InvoiceItemType,HSN_SC, ClassType, TransType, ValuationClass, SortIndex, SubSortIndex, BOQNum, FullBOQNum, SerialNum, Description, QtyRate, AmountTot, AmountWV  from AccListInvoiceItem()  Where InvoiceId = " & InvoiceID & ""
        Sql2 = " Select ProdSerialItemID, ProdSerialItem.ProdSerialID, InvoiceItemID, ProdSerialNum, WOInfo, LotNum from ProdSerialItem Inner join ProdSerial on ProdSerialItem.ProdSerialID = ProdSerial.ProdSerialID Inner join ProdLots on ProdSerial.ProdLotID = ProdLots.ProdLotID Inner join PIDUnit on ProdLots.PIDUnitID = PIDUnit .PIDUnitID  Where InvoiceItemID in (select InvoiceItemID from InvoiceItem where InvoiceID = " & InvoiceID & ")"
        Sql3 = "Select FixedAssetItemID, FixedAssetID, InvoiceItemID, EntryType, AssetName, AssetNumber, Qty, Amount from accListFixedAssetItem() Where InvoiceItemID in (Select InvoiceItemID from InvoiceItem where InvoiceID = " & InvoiceID & ") "

        Sql = Sql1 & ";" & Sql2 & ";" & Sql3
        ds = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)

        myUtils.AddTable(Me.dsForm, ds, "InvoiceItem", 0)
        myUtils.AddTable(Me.dsForm, ds, "ProdSerialItem", 1)
        myUtils.AddTable(Me.dsForm, ds, "FixedAssetItem", 2)


        myContext.Tables.SetAuto(Me.dsForm.Tables("InvoiceItem"), Me.dsForm.Tables("ProdSerialItem"), "InvoiceItemID", "_ProdSerialItem")
        myContext.Tables.SetAuto(Me.dsForm.Tables("InvoiceItem"), Me.dsForm.Tables("FixedAssetItem"), "InvoiceItemID", "_FixedAssetItem")
    End Sub

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If Me.SelectedRow("CampusId") Is Nothing Then Me.AddError("CampusId", "Please select Campus")
        If Me.SelectedRow("CustomerID") Is Nothing Then Me.AddError("CustomerID", "Please select Customer")
        If Me.SelectedRow("BillOf") Is Nothing Then Me.AddError("BillOf", "Please select BillOf")
        If Me.SelectedRow("DivisionID") Is Nothing Then Me.AddError("DivisionID", "Please Select Division")

        If myUtils.IsInList(myUtils.cStrTN(Me.myRow("BillOf")), "P") Then
            If myRow("InvoiceNum").ToString.Trim.Length = 0 Then Me.AddError("InvoiceNum", "Enter Invoice No.")
        End If

        If myUtils.IsInList(myUtils.cStrTN(Me.myRow("InvoiceTypeCode")), "FD", "FC") Then
            If myUtils.cValTN(myRow("CDNInvoiceID")) = 0 Then Me.AddError("", "Please Select Original Invoice")
        End If

        If Not Me.SelectedRow("CampusID") Is Nothing Then
            myFuncs.ValidPostPeriod(myContext, Me, myUtils.cValTN(Me.SelectedRow("CampusID")("CompanyID")), Me.myRow("PostingDate"), PPFinal)
        End If
        If myUtils.cValTN(myRow("PostPeriodId")) = 0 Then Me.AddError("PostingDate", "Please Select Valid Post Period")

        If myRow("PostingDate") < myRow("InvoiceDate") Then Me.AddError("PostingDate", "Posting Date can not be less then Invoice Date.")

        If myRow("PostingDate") > Now.Date Then Me.AddError("PostingDate", "Please Select Valid Posting Date.")
        If myRow("InvoiceDate") > Now.Date Then Me.AddError("InvoiceDate", "Please Select Valid Invoice Date.")

        If myUtils.cValTN(myRow("ConsigneeID")) > 0 Then
            myRow("POSTaxAreaID") = myUtils.cValTN(Me.SelectedRow("ConsigneeID")("TaxAreaID"))
        Else
            If myUtils.cValTN(myRow("POSTaxAreaID")) = 0 AndAlso Not Me.SelectedRow("CustomerID") Is Nothing Then myRow("POSTaxAreaID") = myUtils.cValTN(Me.SelectedRow("CustomerID")("TaxAreaID"))
        End If


        If (Not Me.SelectedRow("DeliveryCampusID") Is Nothing) AndAlso (myUtils.cValTN(SelectedRow("DeliveryCampusID")("SalesOrderID"))) > 0 Then
            If myUtils.cValTN(SelectedRow("DeliveryCampusID")("SalesOrderID")) <> myUtils.cValTN(myRow("SalesOrderID")) Then Me.AddError("", "Please Select Correct Sales Order")
        End If

        If Me.SelectedRow("POSTaxAreaID") Is Nothing Then Me.AddError("POSTaxAreaID", "Please select Place of Supply.")

        If myUtils.cBoolTN(myRow("HasBOQRef")) Then
            For Each r1 As DataRow In myView.MainGrid.myDV.Table.Select("Isnull(QtyRate,0) = 0")
                Dim rr1() As DataRow = myView.MainGrid.myDV.Table.Select("PSoSpareID = " & myUtils.cValTN(r1("SoSpareID")) & "")
                If Not IsNothing(rr1) AndAlso rr1.Length = 0 Then
                    Me.AddError(myView.Key, r1, 0, "", "", "Atleast one child is required.")
                End If
            Next
        End If

        If myUtils.IsInList(myUtils.cStrTN(Me.myRow("InvoiceTypeCode")), "IR") AndAlso myUtils.cValTN(myRow("PostBalance")) < 0 Then Me.AddError("PostBalance", "Post Balance can not be less then Zero.")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim Oret As clsProcOutput
        VSave = False

        If Me.Validate Then
            If myFuncs.CheckStatus(myContext, "InvoiceID", myUtils.cValTN(myRow("InvoiceID"))) Then
                Me.AddError("InvoiceNum", "Accounting entry passed. Invoice can't be update.")
            End If

            If (Not myUtils.IsInList(myUtils.cStrTN(Me.myRow("InvoiceTypeCode")), "IR")) AndAlso myFuncs.CheckPayment(myContext, myUtils.cValTN(myRow("InvoiceID"))) Then
                Me.AddError("", "Payment done. Not allow to edit")
            End If


            Dim objIVProcFico As New clsIVProcFICO("IS", myContext)
            objIVProcFico.LoadVouch(myUtils.cValTN(myRow("InvoiceID")))

            If Me.SelectedRow("CampusID") Is Nothing OrElse objIVProcFico.IsVouchDateAfterFinStart(myUtils.cValTN(Me.SelectedRow("CampusID")("CompanyID")), myRow("PostingDate")) = False Then
                Me.AddError("PostingDate", "Posting Date can not be less then Company Start Date.")
            End If

            myRow("DocType") = objIVProcFico.DocType
            myRow("TY") = myFuncs.SetTY(dsForm.Tables("InvoiceItem"))
            If objIVProcFico.GetInvoiceTypeID(myRow.Row) = False Then Me.AddError("", "Combination Not Available")

            objIVProcFico.GenerateVoucherDelta(myRow.Row.Table, dsForm.Tables("InvoiceItem"))
            Oret = objIVProcFico.CheckBalance()
            If Not Oret.Success Then Me.AddError("", Oret.Message)


            Oret = objIVProcFico.CheckSOBalance(myRow.Row, dsForm.Tables("InvoiceItem"), dsForm.Tables("ProdSerialItem"))
            If Not Oret.Success Then Me.AddError("", Oret.Message)

            Oret = objIVProcFico.CheckChildren(Me.dsForm.Tables("InvoiceItem"))
            If Oret.Success = False Then Me.AddError("", Oret.Message)


            If Me.CanSave Then
                If myRow("BillOf") = "C" Then
                    Dim DocNumSysType As String = myFuncs.GetDocNumSysType(myContext, myUtils.cValTN(myRow("InvoiceTypeID")))
                    Dim ObjVouch As New clsVoucherNum(myContext)
                    ObjVouch.GetNewSerialNo("InvoiceID", DocNumSysType, myRow.Row)
                End If

                myRow("AmountTot") = myContext.Tables.GetColSum(dsForm.Tables("InvoiceItem").Select, "AmountTot")
                myRow("AmountWV") = myContext.Tables.GetColSum(dsForm.Tables("InvoiceItem").Select, "AmountWV")

                Dim r1 As DataRow = myContext.CommonData.FinRow(myRow("PostingDate"))
                If Not myUtils.NullNot(r1) Then
                    myRow("uniquekey") = myFuncs.CalcUniqueKey(myRow("DocType"), Me.SelectedRow("campusid")("campuscode"), r1, myRow("invoicenum"), myUtils.cValTN(myRow("isamendment")))
                End If

                Dim InvoiceSaleDescrip As String = myRow("InvoiceNum").ToString & " Dt. " & Format(myRow("InvoiceDate"), "dd-MMM-yyyy")
                Try
                    myContext.CommonData.GetDatasetFYComp(False)
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "InvoiceID", frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from Invoice Where InvoiceID = " & frmIDX)
                    frmIDX = myRow("InvoiceID")

                    myUtils.ChangeAll(dsForm.Tables("InvoiceItem").Select, "InvoiceID=" & frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("InvoiceItem"), "Select InvoiceItemID, InvoiceID, SOSpareID, VarNum, PIDUnitID, ItemID, SerialNum, ClassType, TransType, ValuationClass, PriceSlabID, POSerialNum, RNPrevRate, QtyPrev, QtyPO, QtySOService, QtySOSpare, PPSubType, AmountBasic, InvoiceItemType, SortIndex, SubSortIndex, Description, QtyRate,  BasicRate, AmountTot, AmountWV,ReturnFY,HSN_SC,ItemUnitID,TaxCredit from InvoiceItem")

                    myUtils.ChangeAll(dsForm.Tables("FixedAssetItem").Select, "EntryType=I")
                    myContext.Provider.objSQLHelper.SaveResults(dsForm.Tables("FixedAssetItem"), "Select FixedAssetItemID, FixedAssetID, InvoiceItemID, EntryType, Qty, Amount from FixedAssetItem", True)


                    Oret = objIVProcFico.HandleWorkflowState(myRow.Row)
                    If Oret.Success Then
                        frmMode = EnumfrmMode.acEditM
                        myContext.Provider.dbConn.CommitTransaction(InvoiceSaleDescrip, frmIDX)
                        VSave = True
                    Else
                        myContext.Provider.dbConn.RollBackTransaction(InvoiceSaleDescrip, Oret.Message)
                        Me.AddError("", Oret.Message)
                    End If
                Catch e As Exception
                    myContext.Provider.dbConn.RollBackTransaction(InvoiceSaleDescrip, e.Message)
                    Me.AddException("", e)
                End Try
            End If
        End If
    End Function

    Private Sub ChangeColRowwise(dt As DataTable)
        For Each r1 In dt.Select
            r1("PIDValue") = r1("InvoiceItemID")
        Next
    End Sub

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "salesorderdescrip"
                Dim sql As String = "Select OrderNum, OrderDate  from SalesOrder  where SalesOrderID = " & myUtils.cValTN(frmIDX)
                Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt2.Rows.Count > 0 Then oRet.Description = "Sales Order :- " & myUtils.cStrTN(dt2.Rows(0)("OrderNum")) & " Date - " & Format(dt2.Rows(0)("OrderDate"), "dd-MMM-yyyy")
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "serials"
                    Dim Sql As String = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ProdSerialID""/>", True, , "<MODROW><SQLWHERE2>" & Sql & "</SQLWHERE2></MODROW>")
                Case "spares"
                    Dim Sql As String = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid and TransType = @transtype", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOSpareID""/>", False, , "<MODROW><SQLWHERE2>" & Sql & "</SQLWHERE2></MODROW>")
                Case "services"
                    Dim Sql As String = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOServiceID""/>", False, , "<MODROW><SQLWHERE2>" & Sql & "</SQLWHERE2></MODROW>")
                Case "sofixedasset"
                    Dim TransType As String = myUtils.cStrTN(myContext.SQL.ParamValue("@transtype", Params))
                    Dim ValuationClass As String = myUtils.cStrTN(myContext.SQL.ParamValue("@valuationclass", Params))
                    Dim NewFixedAssetIDcsv As String = myUtils.cStrTN(myContext.SQL.ParamValue("@newfixedassetcsv", Params))
                    Dim OldFixedAssetIDcsv As String = myUtils.cStrTN(myContext.SQL.ParamValue("@oldfixedassetcsv", Params))
                    Dim oAssetProc As New clsFixedAssetProc(myContext)
                    Dim strXML As String = oAssetProc.ModRowXML(TransType, ValuationClass, NewFixedAssetIDcsv, OldFixedAssetIDcsv)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""FIXEDASSETID""/>", True, , strXML)
                Case "invoice"
                    Dim InvoiceDate As Date = myContext.SQL.ParamValue("@InvoiceDate", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Dim SalesOrderID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SalesOrderID", Params))
                    Dim sql1 As String = ""
                    If SalesOrderID > 0 Then
                        sql1 = myContext.SQL.PopulateSQLParams("isNull(SalesOrderID, 0) = (@SalesOrderID) and DocType = 'IS' and InvoiceTypeCode in ('PF', 'PM') and CustomerID = (@CustomerID) and CampusID = (@CampusID) and DivisionID = (@DivisionID) and InvoiceDate <= '" & Format(InvoiceDate, "dd-MMM-yyyy") & "'", Params)
                    Else
                        sql1 = myContext.SQL.PopulateSQLParams("DocType = 'IS' and InvoiceTypeCode in ('PF', 'PM','OF') and CustomerID = (@CustomerID) and CampusID = (@CampusID) and DivisionID = (@DivisionID) and InvoiceDate <= '" & Format(InvoiceDate, "dd-MMM-yyyy") & "'", Params)
                    End If

                    Dim Sql As String = "SELECT InvoiceID, SalesOrderID, InvoiceNum, InvoiceDate, AmountTot  From Invoice where " & sql1
                    Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
                    Model.MainGrid.BindGridData(ds, 0)
                    Model.MainGrid.QuickConf("", True, "1-1-1")
                Case "addspares"
                    Dim Str1, Str2, str3 As String
                    If myContext.SQL.Exists(Params, "@PidUnitID") Then
                        Str1 = "IsNull(PidUnitID, 0) = " & myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params)) & ""
                    Else
                        Str1 = ""
                    End If

                    Str2 = myContext.SQL.PopulateSQLParams("SOSpareID Not In (@sospareid) And isnull(BillingLot,0) = 0", Params)
                    str3 = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid", Params)
                    Dim sql As String = myUtils.CombineWhere(False, Str1, Str2, str3)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOSpareID""/>", True, , "<MODROW><SQLWHERE2>" & sql & "</SQLWHERE2></MODROW>")
                Case "addservices"
                    Dim Str1, Str2, str3 As String
                    If myContext.SQL.Exists(Params, "@PidUnitID") Then
                        Str1 = "IsNull(PidUnitID, 0) = " & myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params)) & ""
                    Else
                        Str1 = ""
                    End If

                    Str2 = myContext.SQL.PopulateSQLParams("SOServiceID Not In (@soserviceid)", Params)
                    str3 = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid", Params)
                    Dim sql As String = myUtils.CombineWhere(False, Str1, Str2, str3)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOServiceID""/>", True, , "<MODROW><SQLWHERE2>" & sql & "</SQLWHERE2></MODROW>")
                Case "salesorder"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("MainPartyID = @MainPartyID and CompanyID = @CompanyId and SalesOrderID Not in (@SalesOrderID) and (isnull(OrderDate,'3099-Jan-01') <= '@InvoiceDate' or isnull(LOIDate,'3099-Jan-01') <= '@InvoiceDate')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SalesOrderID""/>", False, , "<MODROW><SQLWHERE2>" & XMLUtils.ReplaceSpecialChars(sql) & "</SQLWHERE2></MODROW>")
                Case "orginvir"
                    Dim InvoiceDate As Date = myContext.SQL.ParamValue("@InvoiceDate", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Dim SalesOrderID As Integer = myUtils.cValTN(myContext.SQL.ParamValue("@SalesOrderID", Params))
                    Dim sql1 As String = ""
                    If SalesOrderID > 0 Then
                        sql1 = myContext.SQL.PopulateSQLParams("isNull(SalesOrderID, 0) = (@SalesOrderID) and DocType = 'IS' and InvoiceTypeCode in ('PF', 'PM') and CustomerID = (@CustomerID) and CampusID = (@CampusID) and DivisionID = (@DivisionID) and InvoiceDate <= '" & Format(InvoiceDate, "dd-MMM-yyyy") & "'", Params)
                    Else
                        sql1 = myContext.SQL.PopulateSQLParams("DocType = 'IS' and InvoiceTypeCode in ('PF', 'PM','OF') and CustomerID = (@CustomerID) and CampusID = (@CampusID) and DivisionID = (@DivisionID) and InvoiceDate <= '" & Format(InvoiceDate, "dd-MMM-yyyy") & "'", Params)
                    End If

                    Dim Sql As String = "SELECT InvoiceID, SalesOrderID,openamountretained,openamountwo,openamountpaid,wctamount,TDSAmount, 0.00 as PostBalance, InvoiceNum, InvoiceDate, AmountTot  From Invoice where " & sql1
                    Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql)
                    Model.MainGrid.BindGridData(ds, 0)
                    Model.MainGrid.QuickConf("", True, "1-1-1")
            End Select
        End If
        Return Model
    End Function

    Public Overrides Sub PopulateData(DataKey As String, dt As DataTable, Params As List(Of clsSQLParam))
        Dim objIVProcFico As New clsIVProcFICO("IS", myContext)
        Select Case DataKey.Trim.ToLower
            Case "generateprebal"
                objIVProcFico.PopulatePreBalanceDue(dt.Rows(0))
        End Select
    End Sub
End Class
