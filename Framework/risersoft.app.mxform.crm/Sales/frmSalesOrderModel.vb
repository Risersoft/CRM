Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSalesOrderModel
    Inherits clsFormDataModel
    Dim myVueInsp, myVuePay, myVueBG, myVueDoc, myVueAdv, myVueComm, myViewTrns, myViewSOVal As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("WO")
        myVueAdv = Me.GetViewModel("Adv")
        myVueComm = Me.GetViewModel("SOComm")
        myVueDoc = Me.GetViewModel("SODoc")
        myVueBG = Me.GetViewModel("BGCust")
        myVueInsp = Me.GetViewModel("Insp")
        myVuePay = Me.GetViewModel("SOPay")
        myViewTrns = Me.GetViewModel("Trns")
        myViewSOVal = Me.GetViewModel("SOVal")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "select customerid, CustDescrip, partyid from slsListCustomer() order by partyname"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Cust").TableName)

        Me.AddLookupField("PaymentAuthID", "Cust")
        sql = "Select CompanyID, CompName from Company Order by CompName"
        Me.AddLookupField("CompanyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Company").TableName)

        sql = "select partyid, partyname from genlistparty() order by partyname"
        Me.AddLookupField("ConsultantID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)

        Me.AddLookupField("ContractorID", "Party")
        Me.AddLookupField("EndUserID", "Party")
        Me.AddLookupField("insAuthID", "Party")

        sql = "select vendorid, partyname from purListVendor() where vendortype='CA' order by partyname"
        Me.AddLookupField("CommAgentID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "VendorCA").TableName)

        sql = "select vendorid, partyname from purListVendor() where vendortype='JP' order by partyname"
        Me.AddLookupField("JVPartnerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "VendorJP").TableName)

        sql = "select perspartyid, FullName,Party from genListPersParty() where partytype='C' order by fullname"
        Me.AddLookupField("SendAcceptID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Persons").TableName)

        Me.AddLookupField("SendApproveID", "Persons")

        sql = "Select UserID, fullname, isdeleted, JoinDate, LeaveDate from genlistUser() where insaleslist=1 order by fullname"
        Me.AddLookupField("HandledByID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        sql = "Select regionid, region from region order by regionid"
        Me.AddLookupField("RegionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Region").TableName)

        sql = myFuncsBase.CodeWordSQL("Calendar", "PeriodType", "")
        Me.AddLookupField("PenaltyPeriodType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PenaltyPeriodType").TableName)

        Dim lst As New List(Of String)
        lst.Add("Extra @4% against Form-3D")
        lst.Add("Extra @3% against Form-C")
        lst.Add("Extra @4% against Form-D")
        lst.Add("Extra @2.5% against Form-3B")
        lst.Add("Extra @10% without Form")
        lst.Add("Exemption against submission of Form-H")
        lst.Add("VAT @ 4%")

        Me.ValueLists.Add("STClause", myContext.SQL.VListFromList(lst))
        Me.AddLookupField("STClause", "STClause")

        sql = "select BGTypeid, bgname,periodstart,periodstart2 from BGType order by BGTypeid"
        Me.AddLookupField("BGTypeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BGType").TableName)

        sql = "select statusnum,statustext from status where statustype='BG' order by statusnum"
        Me.AddLookupField("statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "StatusBG").TableName)

        Dim lst1 As New List(Of String)
        lst1.Add("BG")
        lst1.Add("Draft")
        lst1.Add("STDR")

        Me.ValueLists.Add("BGMode", myContext.SQL.VListFromList(lst1))
        Me.AddLookupField("BGMode", "BGMode")

        Me.ValueLists.Add("periodtype", myContext.SQL.dicPeriodType)
        Me.AddLookupField("periodtype", "periodtype")

        sql = "Select ProjectID, ProjectName, CompletedOn from Projects Order By ProjectName"
        Me.AddLookupField("ProjectID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Project").TableName)

        sql = "select Divisionid, DivisionCode, DivisionName from Division order by DivisionCode"
        Me.AddLookupField("DivisionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from salesorder where salesorderid = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)


        Dim sql2 = "select salesenqid, enqrefnum, enqdate from SalesEnq where salesenqid  = " & myUtils.cValTN(myRow("salesenqid"))
        Me.AddDataSet("enq", sql2)


        'Require for FrmBG
        sql = "select ProdSerialID, ProdSerialNum, DescripWO, WONum from plnListProdSerial() where SalesOrderid = " & frmIDX
        Me.AddLookupField("ProdSerialID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "ProdSerial").TableName)

        myView.MainGrid.MainConf("FormatXML") = "<COL KEY=""ItemID"" CAPTION=""ItemCode"" LOOKUPSQL=""Select ItemID, ItemCode from items where acceptwo=1""/><COL KEY=""ItemID2"" CAPTION=""ItemName"" LOOKUPSQL=""Select ItemID, ItemName from items where acceptwo=1""/><COL KEY=""WOType""" & myFuncs.strGridConfEnd("wo", "wotype", "")
        myView.MainGrid.QuickConf("select workorderid, salesorderid, WOType, WONum, WODate, ItemID, ItemID as ItemID2, DescripWO, TotalQty from Workorder where SalesOrderID = %frmIDX%", True, "1-1-1-1-2-2-1")

        myVueAdv.MainGrid.QuickConf("Select paymentitemid,salesorderid,Amount,PayDate,PayBy,Remark from slslistadv() where salesorderid = " & frmIDX, True, "1.5-1.5-1.5-3", True)

        myVueComm.MainGrid.QuickConf("Select SOCommTermid, salesorderid, perValue,'% after' as term,orderStatusNum,payMode,paytext,PayDate,Amount,Remark from SOCommTerm where salesorderid = " & frmIDX, True, "1-1.5-4-1.5-1.5-1.5-1.5-3", True)
        str1 = "<BAND IDFIELD=""SOCommTermid"" TABLE=""SOCommTerm"" INDEX=""0""><COL KEY=""salesorderid""/><COL KEY=""paymode""" & myFuncs.strGridConfEnd("payment", "mode", "") & "<COL KEY=""orderStatusNum"" LOOKUPSQL=""select paymentstageid,StageDescrip from PaymentStage order by PaymentStageID""/><COL KEY=""perValue,paytext,paydate,amount,remark""/><COL KEY=""term"" SKIP=""True"" DEFAULTVALUE="" % after ""/></BAND>"
        myVueComm.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myVueComm.MainGrid.MainConf("FormatXML") = myVueComm.MainGrid.BlankHeaderXML(0, "perValue|term|orderStatusNum") & myVueComm.MainGrid.MapColXML(0, False, "paymode|Payment Mode", "PayText|No.")

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("select SODocSubmitid,salesorderid,docnameid, OnOrder,beforeinspec,afterinspec,beforedisp,afterdisp,oninvoice,CustFormat,isapproved,IsRecd,Remark from SODocSubmit where salesorderid = " & frmIDX, True, "5-1-1-1-1-1-1-1-1-1-3", True)
        myVueDoc.MainGrid.MainConf("FORMATXML") = myVueDoc.MainGrid.MapColXML(0, False, "custformat|Customer Format", "oninvoice|On Invoice", "isrecd|Is Recd", "docnameid|Document", "onorder|On Order", "beforeinspec|Before Inspection", "afterinspec|After Inspection", "beforedisp|Before Dispatch", "afterdisp|After Dispatch", "isapproved|Is Approved")
        str1 = "<BAND IDFIELD=""SODocSubmitid"" TABLE=""SODocSubmit"" INDEX=""0""><COL KEY=""salesorderid""/><COL KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """><OVERRIDE><STRWIDTH>0-1-1</STRWIDTH></OVERRIDE></COL><COL KEY=""onorder,beforeinspec,afterinspec,beforedisp,afterdisp,OnInvoice,isapproved,IsRecd,CustFormat"" DEFAULTVALUE=""False""/><COL KEY=""Remark""/></BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueBG.MainGrid.MainConf("headfactor") = 2
        myVueBG.MainGrid.QuickConf("select BGCustomerid,salesorderid,ProdSerialID, pervalue,periodtype, periodnum,pervalue2,periodtype2,periodnum2,BGTypeid, BGMode, BGNum, BGDate, BGValue, ValidUpto, ReleaseDate,statusnum,ClaimPeriod,Remark from BGCustomer where salesorderid = " & frmIDX, True, "3-1-1-1-1-1-1-3-1", True, "")
        myVueBG.MainGrid.MainConf("FormatXML") = "<COL KEY=""BGTypeid"" LOOKUPSQL=""select BGTypeid,bgname from BGType order by BGTypeid"" CAPTION=""BG Type""/><COL KEY=""bgmode"" CAPTION=""BG Mode"" VLIST=""Draft|STDR|BG""/><COL KEY=""statusnum"" LOOKUPSQL=""Select statusnum, statustext from status where statustype='BG' order by statusnum"" CAPTION=""BG Status""/>"
        str1 = "<BAND INDEX=""0"" IDFIELD=""BGCustomerid"" TABLE=""BGCustomer"">" & myVueBG.MainGrid.BuildBandEditXML(0) & "</BAND>"
        myVueBG.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        myVueInsp.MainGrid.QuickConf("select sopersonid, salesorderid, perspartyid, FullName, PartyName from slsListSOPerson() where SalesOrderID = " & frmIDX, True, "1-1", , "Send Inspection Call Copies To")
        myVueInsp.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""sopersonid"" TABLE=""soperson""><COL KEY=""salesorderid""/><COL KEY=""perspartyid""/></BAND>", EnumEditType.acCommandAndEdit)

        str1 = "<BAND INDEX=""0"" IDFIELD=""SOPayTermID"" TABLE=""SOPayTerm""><COL KEY=""paymode""" & myFuncs.strGridConfEnd("payment", "mode", "") & "<COL KEY=""periodtype"" VLIST=""PERIOD""/><COL KEY=""PaymentStageID"" LOOKUPSQL=""select PaymentStageID,stagedescrip from PaymentStage order by PaymentStageID""/><COL KEY=""perValue,periodnum,remark,salesorderid""/><COL KEY=""term"" SKIP=""True"" DEFAULTVALUE="" % within ""/><COL KEY=""term2"" SKIP=""True"" DEFAULTVALUE="" from ""/></BAND>"
        myVuePay.MainGrid.QuickConf("select SOPayTermID,salesorderid, perValue,'% within' as term,periodnum,periodtype, ' from ' as term2, PaymentStageID, paymode, Remark from SOPayTerm where salesorderid = " & frmIDX, True, "1-3-1-2-1-4-2-3", False, "Payment Terms")
        myVuePay.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myVuePay.MainGrid.MainConf("FormatXML") = myVuePay.MainGrid.BlankHeaderXML(0, "Remark", False) & myVuePay.MainGrid.MapColXML(0, False, "paymode|Payment Mode")


        myViewTrns.MainGrid.QuickConf("Select SOTransportID,SalesOrderID,TransporterID,CampusID,FromHere,IsDone,TransDate,Place,NumTrans,IsInsured,Freight,DidWePay from SoTransport where salesorderid = " & frmIDX, True, "2.5-1.5-1-1-1.5-1.5-1.5-1-1-1", True)
        str1 = "<BAND IDFIELD=""SoTransportID"" TABLE=""SoTransport"" INDEX=""0""><COL KEY=""SOTransportID,SalesOrderID,FromHere,IsDone,TransDate,Place,NumTrans,IsInsured,Freight,DidWePay""/><COL KEY=""TransporterID"" LOOKUPSQL=""SELECT  VendorID, VendorName FROM  PurListVendor() where VendorType = 'TR' Order By VendorName"" CAPTION=""Transporter""/><COL KEY=""CampusID"" LOOKUPSQL=""Select CampusID, DispName from Campus order by DispName"" CAPTION=""Campus""/></BAND>"
        myViewTrns.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        myViewSOVal.MainGrid.QuickConf("Select SalesOrderValueID,SalesOrderID,Portion,POValue, PVValue, HasPV from SalesOrderValue where salesorderid = " & frmIDX, True, "3-1-1-1", True)
        str1 = "<BAND IDFIELD=""SalesOrderValueID"" TABLE=""SalesOrderValue"" INDEX=""0""><COL KEY=""SalesOrderValueID,SalesOrderID""/><COL  NOEDIT=""TRUE"" KEY=""Portion""/><COL KEY=""POValue"" CAPTION=""PO Value""/><COL KEY=""PVValue"" CAPTION=""PV Value""/><COL KEY=""HasPV"" CAPTION=""PV"" VLIST=""True;Variable|False;Firm""/></BAND>"
        myViewSOVal.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        For Each str As String In New String() {"Supply", "Service", "Civil", "Freight", "ETC"}
            Dim rr1() As DataRow = myViewSOVal.MainGrid.myDS.Tables(0).Select("Portion = '" & myUtils.cStrTN(str) & "'")
            If rr1.Length = 0 Then
                Dim r2 As DataRow = myContext.Tables.AddNewRow(myViewSOVal.MainGrid.myDS.Tables(0))
                r2("Portion") = myUtils.cStrTN(str)
            End If
        Next

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If Me.SelectedRow("CustomerID") Is Nothing Then Me.AddError("CustomerID", "Select a Customer")
        If Me.SelectedRow("CompanyID") Is Nothing Then Me.AddError("CompanyID", "Select a Company")
        If Me.SelectedRow("HandledByID") Is Nothing Then Me.AddError("HandledByID", "Select an Handled By")
        If Me.SelectedRow("DivisionID") Is Nothing Then Me.AddError("DivisionID", "Please Select Division")
        If myUtils.cStrTN(myRow("PONum")).Trim.Length = 0 AndAlso myUtils.cStrTN(myRow("LoINum")).Trim.Length = 0 Then Me.AddError("LoINum", "Enter a PO No. or LoI No.")
        If myUtils.NullNot(myRow("LoIDate")) AndAlso myUtils.NullNot(myRow("PODate")) Then Me.AddError("LOIDate", "Enter a LoI Date or PO Date")
        If myUtils.cValTN(myRow("TotalValue")) = 0 Then Me.AddError("TotalValue", "Please enter Total Value (Ex Works).")


        Me.myVueBG.MainGrid.CheckValid("BGTypeID")
        Me.myVueComm.MainGrid.CheckValid("perValue,orderStatusNum")
        Me.myVueDoc.MainGrid.CheckValid("docnameid")
        Me.myVuePay.MainGrid.CheckValid("perValue,periodnum,periodtype, PaymentStageID")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            Dim SalesOrderDescrip As String = If(myUtils.NullNot(myRow("PONum")), myUtils.cStrTN(myRow("LoiNum")), myUtils.cStrTN(myRow("PONum"))) &
                ", Dt. " & If(myUtils.NullNot(myRow("PODate")), Format(myRow("LoiDate"), "dd-MMM-yyyy"), Format(myRow("PODate"), "dd-MMM-yyyy"))

            Dim rr() As DataRow = myViewSOVal.MainGrid.myDS.Tables(0).Select("HasPV = 1")
            If (Not IsNothing(rr)) AndAlso rr.Length > 0 Then
                myRow("HasPV") = 1
            Else
                myRow("HasPV") = 0
            End If

            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "salesorderid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from salesorder where salesorderid = " & frmIDX)
                frmIDX = myRow("salesorderid")

                Dim str2 As String = "salesorderid=" & frmIDX
                Me.myVueAdv.MainGrid.SaveChanges(, str2)
                Me.myVueBG.MainGrid.SaveChanges(, str2)
                Me.myVueComm.MainGrid.SaveChanges(, str2)
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                Me.myVueInsp.MainGrid.SaveChanges(, str2)
                Me.myVuePay.MainGrid.SaveChanges(, str2)
                Me.myViewTrns.MainGrid.SaveChanges(, str2)
                Me.myViewSOVal.MainGrid.SaveChanges(, str2)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(SalesOrderDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(SalesOrderDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
        Return VSave
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "btnseltenderno"
                    Dim Sql1 As String = "select salesenqid,enqrefnum, enqdate,projectname from salesenq"
                    Model = New clsViewModel(vwState, myContext)
                    Model.MainGrid.QuickConf(Sql1, True, "1-1-1")
                    Model.myCMain.strView = "Select Enquiry"

                    'Dim str1 As String = "<BAND IDFIELD=""PurItemID"" TABLE=""PurItems"" INDEX=""0""><COL KEY=""Qty""/></BAND>"
                    'Model.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)
            End Select
        End If
        Return Model
    End Function
End Class
