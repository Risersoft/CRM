Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmWOModel
    Inherits clsFormDataModel
    Dim myVueSpare, myVueTT, myVueTF, myVueDoc, myVueRateList, myVueService, myVueCampus As clsViewModel
    Dim strDel As String, strMsg1 As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("DelSched")
        myVueSpare = Me.GetViewModel("Spare")
        myVueService = Me.GetViewModel("Service")
        myVueTT = Me.GetViewModel("TT")
        myVueTF = Me.GetViewModel("TF")
        myVueDoc = Me.GetViewModel("Doc")
        myVueRateList = Me.GetViewModel("Rate")
        myVueCampus = Me.GetViewModel("Campus")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub
    Private Sub InitForm()
        Dim sql As String

        sql = "select itemid, itemcode, itemname,unitname,unitname2, IsETO, ETODescripAttribID, ETOTechDescripAttribID, ETOSKU2AttribID, itemunitid, itemunitid2, HSN_SC from invlistitems() where acceptwo=1 order by itemname"
        Me.AddLookupField("ItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

        sql = "select matdepid, depname, WODate,CompletedOn from mmListDepsMat() where acceptswo=1 order by depname"
        Me.AddLookupField("MatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Deps").TableName)

        sql = "select statusnum, statustext, (select FieldValue  from StatusField SFW where SFW.StatusNum = status.StatusNum and SFW.TenantID = status.TenantID and SFW.StatusType = 'WO' and  SFW.FieldName = 'InOrderPos') AS [InOrderPos] from status where statustype='wo' order by statusnum"
        Me.AddLookupField("StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = "SELECT PaymentStageID, StageDescrip from PaymentStage"
        Me.AddLookupField("DSPaymentStageID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PaymentStage").TableName)

        sql = myFuncsBase.CodeWordSQL("wo", "wotype", "")
        Me.AddLookupField("WOType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "wotype").TableName)

        sql = "select Divisionid, DivisionCode, DivisionName from Division order by DivisionCode"
        Me.AddLookupField("DivisionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)

        Me.ValueLists.Add("periodtype", myContext.SQL.dicPeriodType)
        Me.ValueLists.Add("numtype", myContext.SQL.dicNumType)
        Me.ValueLists.Add("superchtype", myContext.SQL.VListFromDic(myContext.SQL.dicFromString("Per Unit|Per Day")))


        ' Me.AddLookupField("DSPeriodType", "PeriodType")
        ' Me.AddLookupField("DSCompPeriodType", "PeriodType")
        ' Me.AddLookupField("DSCompRateType", "NumType")
        ' Me.AddLookupField("DSAtLeastType", "NumType")
        Me.AddLookupField("DSPeriodType", "periodtype")
        Me.AddLookupField("DSCompPeriodType", "periodtype")
        Me.AddLookupField("DSCompRateType", "numtype")
        Me.AddLookupField("DSAtLeastType", "numtype")

        sql = "Select Code, Code + '-' + Description as Description, Ty from HSNsac Where Ty = 'G' Order By Code"
        Me.AddLookupField("hsn_sc", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "HsnSac").TableName)

        sql = "select partyid, partyname, TaxAreaID from genlistparty() order by partyname"
        Me.AddLookupField("ConsigneeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1, sql1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from workorder where workorderid = " & prepIDX
        Me.InitData(sql, "salesorderid,wotype", oView, prepMode, prepIDX, strXML)

        myView.MainGrid.QuickConf("Select * from wodelsched where workorderid=" & frmIDX, True, "0-1-2", True, "Delivery Schedule")
        str1 = "<BAND INDEX=""0"" TABLE=""wodelsched"" IDFIELD=""wodelschedid"" ><COL KEY=""workorderid,Qty,DueDate""/></BAND> "
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        sql = "select docnameid,Docname,Doctype from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid,docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("select duedocid,workorderid,Prefix,docnameid,Postfix,NumCopies,DocNumber,DocDetails from docsdue where workorderid = " & frmIDX, True, "1-4-1-1-1-3", True)
        str1 = "<BAND IDFIELD=""duedocid"" TABLE=""DocsDue"" INDEX=""0""><COL CAPTION=""Name"" KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """><OVERRIDE><STRWIDTH>0-1-1</STRWIDTH></OVERRIDE></COL><COL KEY=""prefix,postfix,numcopies,docnumber,docdetails,workorderid""/></BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        myVueTT.MainGrid.MainConf("headfactor") = 2 : myVueTT.MainGrid.MainConf("autorowht") = True
        myVueTT.Mode = EnumViewMode.acSelectM : myVueTT.MultiSelect = True
        sql = "select TypeTestReqID,workorderid, typetestmaster.strtypespecaddl, TypeTestReq.TypeTestID, TypeTestReq.ForOneUnit, Charges, TTType,TestDate,DoWePay, AcceptReport,CustWitness,Failed,Waived,ProdSerialID from TypeTestReq inner join typetestmaster on TypeTestReq.TypeTestID = typetestmaster.TypeTestID where workorderid = %frmidx%"
        myVueTT.MainGrid.MainConf("formatxml") = "<COL KEY=""strtypespecaddl"" CAPTION=""Cat""/>"
        myVueTT.MainGrid.QuickConf(sql, True, "1-4.5-2-2-1-1.5-1-1-1-1-1-3", True)
        sql = "select TypeTestID,testname from typetestmaster order by testname"
        str1 = "<BAND IDFIELD=""TypeTestReqID"" TABLE=""TypeTestReq"" INDEX=""0""><COL KEY=""workorderid""/><COL KEY=""ForOneUnit"" CAPTION=""Quantum"" VLIST=""False;Each Unit|True;One Unit"" DEFAULTVALUE=""True""/><COL CAPTION=""Test"" KEY=""TypeTestID"" NOEDIT=""True"" LOOKUPSQL=""" & sql & """/><COL KEY=""dowepay"" CAPTION=""Do WePay""/><COL KEY=""custwitness"" CAPTION=""Cust. Witness""/><COL KEY=""testdate"" CAPTION=""Date""/><COL KEY=""AcceptReport"" CAPTION=""Accept Report""/><COL KEY=""failed,waived"" DEFAULTVALUE=""False""/><COL KEY=""Charges""/><COL KEY=""ProdSerialID"" CAPTION=""Serial"" LOOKUPSQL=""select prodserialid,prodserialnum from plnListProdSerial() where workorderid = " & frmIDX & """/><COL KEY=""TTTYpe"" CAPTION=""Type""/></BAND>"
        myVueTT.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myContext.Data.ReverseTick(myVueTT.MainGrid.myDS.Tables(0), "select strtypespecaddl, TypeTestID, foroneunit from typetestmaster where typespecaddl<4 order by TypeTestID", "TypeTestID")

        myVueSpare.MainGrid.MainConf("headfactor") = 2
        myVueSpare.MainGrid.QuickConf("select pidunitid,workorderid, 0 as OldSoSpareId,SoSpareId,PSoSpareID, SortIndex,FullSortIndex,BOQNum, FullBOQNum, ProductCode, SpareName, InvoiceSuffix,TransType,ValuationClass,HSN_SC, QtyBOQ,Qty, (Qty - dbo.fncBalQtySp(SoSpareID,'" & Format(Now, "dd-MMM-yyyy") & "')) as BilledQty,ItemUnitID,UnitPrice,Freight,TotalWt,BillingLot, IsNotBilled, MainSupplyPart from sospare where workorderid = " & frmIDX & " Order By SortIndex, FullSortIndex", True, "1-1-1.2-4-2-1-2-1-1-1-1-1-1-1.1-1-1-1-1", True)
        sql = "Select Class from AccountClass where ClassType = 'M' and ClassSubType in ('S','B')"
        sql1 = "Select Code, Code + ' | ' + Description from HSNsac where Ty = 'G' Order By Code"
        str1 = "<BAND IDFIELD=""sospareid"" TABLE=""sospare"" INDEX=""0""><COL KEY=""workorderid,pidunitid,freight,PSoSpareID,SortIndex,FullSortIndex""/><COL KEY=""ProductCode"" CAPTION=""Product Code""/><COL KEY=""totalwt"" CAPTION=""Total WT""/><COL KEY=""unitprice"" CAPTION=""Unit Price""/><COL KEY=""SpareName"" CAPTION=""Spare Name""/><COL KEY=""BOQNum"" CAPTION=""BOQ Num""/><COL KEY=""QtyBOQ"" CAPTION=""Qty BOQ""/><COL KEY=""Qty"" CAPTION=""Qty Actual""/><COL KEY=""ValuationClass"" CAPTION=""Valuation Class"" LOOKUPSQL=""" & sql & """/><COL KEY=""TransType"" CAPTION=""Trans Type"" VLIST=""ST|FG""/><COL KEY=""BillingLot"" CAPTION=""Billing"" VLIST=""0;Qty|1;Lot""/><COL KEY=""HSN_SC"" WFACTOR=""2"" CAPTION=""HSN Code"" LOOKUPSQL=""" & sql1 & """/><COL KEY=""ItemUnitID"" CAPTION=""Unit Name"" LOOKUPSQL=""Select ItemUnitID,UnitName from ItemUnits""/><COL KEY=""FullBOQNum"" CAPTION=""Full BOQ"" NOEDIT=""True""/><COL KEY=""InvoiceSuffix"" CAPTION=""Invoice Suffix""/><COL KEY=""IsNotBilled"" CAPTION=""Billing Type"" VLIST=""False;Billed|True;NotBilled""/><COL KEY=""MainSupplyPart"" CAPTION=""Supply Type"" VLIST=""False;Separate|True;Part Of Main""/></BAND>"
        myVueSpare.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myContext.Tables.SetAuto(myVueSpare.MainGrid.myDS.Tables(0), Nothing, "SoSpareID", "_SoSpareID")

        If risersoft.app.mxform.myFuncs.IsCRMApp(myContext) Then myVueService.MainGrid.MainConf("HIDECOLS") = "ValuationClass"
        myVueService.MainGrid.MainConf("headfactor") = 2
        myVueService.MainGrid.QuickConf("select pidunitid,workorderid, 0 as OldSoServiceId, SoServiceId,PSoServiceID, SortIndex,FullSortIndex, BOQNum, FullBOQNum, ProductCode,ServiceName, InvoiceSuffix,ServiceType,ValuationClass,HSN_SC,QtyBOQ, Qty, (Qty - dbo.fncBalQtyService(SOServiceID,'" & Format(Now, "dd-MMM-yyyy") & "')) as BilledQty,ItemUnitID,UnitPrice from soservice where workorderid = " & frmIDX & " Order By SortIndex, FullSortIndex", True, "1-1-1.2-4-2-2-2-1-1-1-.8-1-1", True)
        sql = "Select Class from AccountClass where ClassType = 'S' and ClassSubType in ('S','B')"
        sql1 = "Select Code, Code + ' | ' + Description from HSNsac where Ty = 'S' Order By Code"
        str1 = "<BAND IDFIELD=""soserviceid"" TABLE=""soservice"" INDEX=""0""><COL KEY=""workorderid,pidunitid,PSoServiceID,SortIndex,FullSortIndex""/><COL KEY=""ProductCode"" CAPTION=""Product Code""/><COL KEY=""unitprice"" CAPTION=""Unit Price""/><COL KEY=""ServiceName"" CAPTION=""Service Name""/><COL KEY=""BOQNum"" CAPTION=""BOQ Num""/><COL KEY=""QtyBOQ"" CAPTION=""Qty BOQ""/><COL KEY=""Qty"" CAPTION=""Qty Actual""/><COL KEY=""ValuationClass"" CAPTION=""Valuation Class"" LOOKUPSQL=""" & sql & """/><COL KEY=""HSN_SC"" WFACTOR=""2"" CAPTION=""HSN Code"" LOOKUPSQL=""" & sql1 & """/><COL KEY=""ItemUnitID"" CAPTION=""Unit Name"" LOOKUPSQL=""Select ItemUnitID,UnitName from ItemUnits""/><COL KEY=""FullBOQNum"" CAPTION=""Full BOQ"" NOEDIT=""True""/><COL KEY=""SERVICETYPE""" & myFuncsBase.strGridConfEnd("wo", "servicetype", "") & "/><COL KEY=""InvoiceSuffix"" CAPTION=""Invoice Suffix""/></BAND>"
        myVueService.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myContext.Tables.SetAuto(myVueService.MainGrid.myDS.Tables(0), Nothing, "SoServiceID", "_SoServiceID")

        Select Case myUtils.cStrTN(myRow("wotype")).Trim.ToLower
            Case "sw"
                myVueTF.MainGrid.MainConf("formatxml") = myVueTF.MainGrid.ProcessFormatXML("<COL KEY=""statusnum"" LOOKUPSQL=""Select statusnum, statustext from status where statustype='PS' order by statusnum"" CAPTION=""Status""/>")
                myVueTF.MainGrid.QuickConf("select prodserialid, DispatchedOn,workorderid,ProdSerialNum,Weight,StatusNum from plnListProdSerial() where workorderid = " & frmIDX, True, "0-3-1-3", True)
                strMsg1 = "Work Order"

            Case "re"
                myVueTF.MainGrid.QuickConf("Select * from slslistrepairunit() where workorderid=" & frmIDX, True, "2-1-1-2-2-2-2")
                strMsg1 = "Repair Order"

                myContext.Data.AddSQLTable(Me.dsCombo, "Select * from repairitem", "repairitem")
                myVueRateList.MainGrid.QuickConf("select RepairItemRateid, itemid, workorderid, RepairItemID, Rate, repairitemid as Unit from slsListRepairItemRate() where workorderid = " & frmIDX, True, "4-1-1", True)
                myVueRateList.MainGrid.MainConf("FormatXML") = "<COL KEY=""Unit"" NOEDIT=""True"" LOOKUPSQL=""Select RepairItemid, ' per ' + Unitname as Unit from RepairItem""/>"
                myVueRateList.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""RepairItemRateid"" TABLE=""RepairItemRate""><COL KEY=""RepairItemid"" LOOKUPSQL=""Select RepairItemid,RepairItemname from RepairItem"" NOEDIT=""True"" CAPTION=""Item Name""/><COL KEY=""RATE,WorkOrderID""/></BAND>", EnumEditType.acCommandAndEdit)
            Case "sp"
                strMsg1 = "Spare Order"
            Case "pr"
                strMsg1 = "Project Order"
                myVueCampus.MainGrid.QuickConf("select campusid, DispName, CampusType from mmListCampus() Where WorkOrderID = %frmIDX%", True, "3-1", , "Campus")

        End Select

        '---codesys handlecombo in last so that all views and dataviews are ready. for example myvueratelist.maingrid.mydv
        If frmMode = EnumfrmMode.acAddM Then
            If Me.dsCombo.Tables("items").Rows.Count = 1 Then myRow("itemid") = Me.dsCombo.Tables("items").Rows(0)("itemid")
            myRow("delschedtype") = 0
        End If

        myContext.Data.AddSQLTable(Me.dsForm, "select fittingreqid, workorderid, isstandard, fittingid from fittingreq where workorderid = " & frmIDX, "fitting")
        myContext.Data.AddSQLTable(Me.dsCombo, "select fittingid, itemid, isstandard,fittingname from FittingMaster", "fittingmaster")

        If myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "pr", "sp", "sw") Then
            Me.DatasetCollection.Add("var", myPIDU.LoadItemVarData(myContext, myUtils.cValTN(myRow("itemid")), "workorderid", frmIDX))
        End If
        Me.AddDataSet("so", "select * from slsListOrder() where salesorderid = " & myUtils.cValTN(myRow("salesorderid")))

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean

        Me.InitError()
        If myUtils.cStrTN(myRow("wonum")).Trim.Length = 0 Then Me.AddError("WONum", "Please enter a " & strMsg1 & " number")
        If myUtils.NullNot(myRow("WODate")) Then Me.AddError("WODate", "Please enter a " & strMsg1 & " Date")
        If Me.SelectedRow("StatusNum") Is Nothing Then Me.AddError("StatusNum", "Select a status")
        If Me.SelectedRow("itemid") Is Nothing Then Me.AddError("ItemID", "Select an Item")
        If (Not myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "pr")) AndAlso Me.SelectedRow("MatDepiD") Is Nothing Then Me.AddError("MatDepID", "Select a Department")
        If Not GiveNetClause() Then Me.AddError("", "Correct the delivery clause")

        If Me.SelectedRow("DivisionID") Is Nothing Then Me.AddError("DivisionID", "Select a Division")
        If (Not myUtils.IsInList(myUtils.cStrTN(myRow("wotype")), "pr")) AndAlso Me.SelectedRow("Hsn_sc") Is Nothing Then Me.AddError("HSN_SC", "Select HSN Code")

        Me.myVueDoc.MainGrid.CheckValid("docnameid")
        Me.myVueTT.MainGrid.CheckValid("typetestid")
        myView.MainGrid.CheckValid("quantity,duedate")
        myVueRateList.MainGrid.CheckValid("Rate", "sysincl=1")

        For Each r1 As DataRow In myVueSpare.MainGrid.myDS.Tables(0).Select()
            Dim rr1() As DataRow = myVueSpare.MainGrid.myDS.Tables(0).Select("PSoSpareID = " & myUtils.cValTN(r1("SoSpareID")) & "")
            If Not IsNothing(rr1) AndAlso rr1.Length = 0 Then
                If myUtils.cStrTN(r1("SpareName")) = "" Or (risersoft.app.mxform.myFuncs.IsCRMApp(myContext) = False AndAlso myUtils.cStrTN(r1("ValuationClass")) = "") Or myUtils.cStrTN(r1("TransType")) = "" Or myUtils.cStrTN(r1("HSN_SC")) = "" Or myUtils.cValTN(r1("Qty")) = 0 Or myUtils.cValTN(r1("QtyBOQ")) = 0 Or myUtils.cValTN(r1("ItemUnitID")) = 0 Then
                    Me.AddError(myVueSpare.Key, r1, 0, "", "", "Invalid Data For Spare.")
                End If

                If myUtils.cValTN(r1("Qty")) < myUtils.cValTN(r1("BilledQty")) Then
                    Me.AddError(myVueSpare.Key, r1, 0, "", "", "Actual Qty Can not be lees then Billed Qty.")
                End If
            Else
                If myUtils.cStrTN(r1("SpareName")) = "" Or (risersoft.app.mxform.myFuncs.IsCRMApp(myContext) = False AndAlso myUtils.cStrTN(r1("ValuationClass")) <> "") Or myUtils.cStrTN(r1("TransType")) <> "" Or myUtils.cStrTN(r1("HSN_SC")) <> "" Or myUtils.cValTN(r1("Qty")) <> 0 Or myUtils.cValTN(r1("QtyBOQ")) <> 0 Or myUtils.cValTN(r1("ItemUnitID")) <> 0 Then
                    Me.AddError(myVueSpare.Key, r1, 0, "", "", "Invalid Data For Spare.")
                End If
            End If
        Next

        If Not IsNothing(Me.SelectedRow("StatusNum")) Then
            If myUtils.cBoolTN(Me.SelectedRow("StatusNum")("InOrderPos")) = True Then
                If Not myUtils.NullNot(myRow("CompletedOn")) Then Me.AddError("CompletedOn", "CompletedOn Date Should be Blank because it is in order position as per status")
            Else
                If myUtils.NullNot(myRow("CompletedOn")) Then Me.AddError("CompletedOn", "Please Select Completed On Date")

                If myUtils.IsInList(myUtils.cStrTN(myRow("WoType")), "SW", "RE") Then
                    If myVueTF.MainGrid.myDS.Tables(0).Select("DispatchedOn is not null").Length > 0 AndAlso myVueTF.MainGrid.myDS.Tables(0).Compute("max(DispatchedOn)", "") > myRow("CompletedOn") Then
                        Me.AddError("CompletedOn", "CompletedOn Date Should be Greater then DispatchedOn Date")
                    End If
                End If
            End If
        End If

        For Each r2 As DataRow In myVueService.MainGrid.myDS.Tables(0).Select()
            Dim rr1() As DataRow = myVueService.MainGrid.myDS.Tables(0).Select("PSoServiceID = " & myUtils.cValTN(r2("SoServiceID")) & "")
            If Not IsNothing(rr1) AndAlso rr1.Length = 0 Then
                If myUtils.cStrTN(r2("ServiceName")) = "" Or (risersoft.app.mxform.myFuncs.IsCRMApp(myContext) = False AndAlso myUtils.cStrTN(r2("ValuationClass")) = "") Or myUtils.cStrTN(r2("ServiceType")) = "" Or myUtils.cStrTN(r2("HSN_SC")) = "" Or myUtils.cValTN(r2("Qty")) = 0 Or myUtils.cValTN(r2("QtyBOQ")) = 0 Or myUtils.cValTN(r2("ItemUnitID")) = 0 Then
                    Me.AddError(myVueService.Key, r2, 0, "", "", "Invalid Data For Service.")
                End If

                If myUtils.cValTN(r2("Qty")) < myUtils.cValTN(r2("BilledQty")) Then
                    Me.AddError(myVueService.Key, r2, 0, "", "", "Actual Qty Can not be lees then Billed Qty.")
                End If
            Else
                If myUtils.cStrTN(r2("ServiceName")) = "" Or (risersoft.app.mxform.myFuncs.IsCRMApp(myContext) = False AndAlso myUtils.cStrTN(r2("ValuationClass")) <> "") Or myUtils.cStrTN(r2("ServiceType")) <> "" Or myUtils.cStrTN(r2("HSN_SC")) <> "" Or myUtils.cValTN(r2("Qty")) <> 0 Or myUtils.cValTN(r2("QtyBOQ")) <> 0 Or myUtils.cValTN(r2("ItemUnitID")) <> 0 Then
                    Me.AddError(myVueService.Key, r2, 0, "", "", "Invalid Data For Service.")
                End If
            End If
        Next

        If risersoft.app.mxform.myFuncs.IsCRMApp(myContext) = False Then
            Dim sql As String = "Select Class,TransTypeCSV  from AccountClass where ClassType = 'M' and ClassSubType in ('S','B')"
            Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            For Each r1 As DataRow In myVueSpare.MainGrid.myDS.Tables(0).Select("Qty > 0")
                Dim rr1() As DataRow = ds.Tables(0).Select("Class = '" & myUtils.cStrTN(r1("ValuationClass")) & "' and TransTypeCSV Like '%" & myUtils.cStrTN(r1("TransType")) & "%'")
                If rr1.Length = 0 Then
                    Me.AddError(myVueSpare.Key, r1, 0, "", "", "Please select valid Valuation Class.")
                End If
            Next
        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim str1 As String = ""
        VSave = False

        If Me.Validate Then
            Dim WODescrip As String = " Work Order No: " & myRow("WONum").ToString & ", Dt. " & Format(myRow("WODate"), "dd-MMM-yyyy")
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "workorderid", frmIDX)
                myRow("dsnetclause") = strDel
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from workorder where workorderid = " & frmIDX)
                frmIDX = myRow("workorderid")

                Dim oProc As New clsPIDUnitProc(myContext)
                If myUtils.IsInList(myRow("wotype"), "pr", "sw", "sp") Then
                    Dim nr1 As DataRow = myPIDU.SavePIDUnitID(myContext, myRow.Row, "workorderid", frmIDX, "", myUtils.cStrTN(myRow("wonum")))
                    Me.DatasetCollection.AddUpd("var", myPIDU.SavePIDUnitETO(myContext, nr1, Me.SelectedRow("itemid"), myRow.Row, myUtils.cValTN(myRow("totalqty")), myUtils.cValTN(myRow("totalqty2"))))
                    str1 = "pidunitid=" & nr1("pidunitid")
                    oProc.UpdateProductionStatus(nr1("pidunitid"))
                ElseIf myUtils.IsInList(myRow("wotype"), "re") Then
                    oProc.UpdateProductionStatusRO(frmIDX)

                End If

                Dim str2 As String = "workorderid=" & frmIDX
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                Me.myVueTT.MainGrid.SaveChanges(, str2)

                myUtils.CopyCol(myVueSpare.MainGrid.myDS.Tables(0), "SoSpareID", "OldSoSpareID")
                Me.myVueSpare.MainGrid.SaveChanges(, myUtils.MakeCSV(",", str1, str2))
                If UpdateParentID(myVueSpare, "SoSpareID", "PSoSpareID", "OldSoSpareID") Then
                    Me.myVueSpare.MainGrid.SaveChanges(, myUtils.MakeCSV(",", str1, str2))
                End If


                myUtils.CopyCol(myVueService.MainGrid.myDS.Tables(0), "SoServiceID", "OldSoServiceID")
                Me.myVueService.MainGrid.SaveChanges(, myUtils.MakeCSV(",", str1, str2))
                If UpdateParentID(myVueService, "SoServiceID", "PSoServiceID", "OldSoServiceID") Then
                    Me.myVueService.MainGrid.SaveChanges(, myUtils.MakeCSV(",", str1, str2))
                End If

                Me.myView.MainGrid.SaveChanges(, str2)
                Select Case myUtils.cStrTN(myRow("wotype")).Trim.ToLower
                    Case "sw"
                        myUtils.ChangeAll(Me.dsForm.Tables("fitting").Select, str2)
                        myContext.Provider.objSQLHelper.SaveResults(Me.dsForm.Tables("fitting"), "Select fittingreqid, workorderid, isstandard, fittingid from fittingreq where workorderid = " & frmIDX)
                    Case "re"
                        Me.myVueRateList.MainGrid.SaveChanges(, "workorderid=" & frmIDX)
                End Select

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(WODescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(WODescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Private Function UpdateParentID(oView1 As clsViewModel, ID As String, PID As String, OldID As String) As Boolean
        Dim UpdateID As Boolean = False
        For Each r1 As DataRow In oView1.MainGrid.myDS.Tables(0).Select()
            For Each r2 As DataRow In oView1.MainGrid.myDS.Tables(0).Select(PID & " = " & myUtils.cValTN(r1(OldID)))
                r2(PID) = r1(ID)
                UpdateID = True
            Next
        Next
        Return UpdateID
    End Function

    Private Function GiveNetClause() As Boolean
        Dim str As String, goAhead As Boolean
        str = ""
        goAhead = False
        Select Case myUtils.cValTN(myRow("DelSchedType"))
            Case 1
                If (Me.SelectedItem("DSPeriodType") Is Nothing) Then
                    Me.AddError("DSPeriodType", "Complete Period Type")
                ElseIf (Me.SelectedRow("DSPaymentStageID") Is Nothing) Then
                    Me.AddError("DSPaymentStageID", "Complete Payment Stage")
                Else
                    str = myUtils.cValTN(myRow("DSPeriodNum")) & " " & Me.SelectedItem("DSPeriodType").DisplayText & " from " & Me.SelectedRow("DSPaymentStageID")(1)
                    goAhead = True
                End If
            Case 2
                If (Me.SelectedItem("DSAtLeastType") Is Nothing) Then
                ElseIf (Me.SelectedItem("DSCompPeriodType") Is Nothing) Then
                    Me.AddError("DSCompPeriodType", "Complete Completion Period Type")
                ElseIf (Me.SelectedItem("DSCompRateType") Is Nothing) Then
                    Me.AddError("DSCompRateType", "Complete Completion Rate Type")
                ElseIf (Me.SelectedItem("DSPaymentStageID") Is Nothing) Then
                    Me.AddError("DSPaymentStageID", "Complete Payment Stage")
                ElseIf (Me.SelectedItem("DSperiodType") Is Nothing) Then
                    Me.AddError("DSPeriodType", "Complete Period Type")
                Else
                    str = "Commencement in " & myUtils.cValTN(myRow("DSPeriodNum")) & " " & Me.SelectedItem("DSperiodType").DisplayText &
                    " with at least " & myUtils.cValTN(myRow("DSAtLeast")) & " " & Me.SelectedItem("DSAtLeastType").DisplayText & " of the ordered qty from " &
                    Me.SelectedRow("DSPaymentStageID")(1) & " and completion @" & myUtils.cValTN(myRow("DSCompRate")) & " " & Me.SelectedItem("DSCompRateType").DisplayText & " per " &
                    myUtils.cValTN(myRow("DSCompPeriodNum")) & " " & Me.SelectedItem("DSCompPeriodType").DisplayText & " thereafter"
                    goAhead = True
                End If
            Case 3
                str = myUtils.cStrTN(myRow("DSCustom"))
                goAhead = True
            Case Else
                str = ""
                goAhead = True
        End Select
        strDel = str
        GiveNetClause = goAhead
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), Model As clsViewModel
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "invoice"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("invoiceid in (@invoiceidcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""INVOICEID""/>", True, , "<MODROW><SQLWHERE2>" & sql & "</SQLWHERE2></MODROW>")
            End Select
            Return Model
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "prodserialid"
                Dim sql As String = "Select * from plnListProdSerial() where RepairUnitID = " & myUtils.cValTN(frmIDX)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            Case "pidunit"
                Dim sql As String = "select * from PIDUnit where WorkOrderID = " & myUtils.cValTN(frmIDX)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet
    End Function
End Class
