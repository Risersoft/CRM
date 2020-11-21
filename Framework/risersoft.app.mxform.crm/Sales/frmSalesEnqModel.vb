Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSalesEnqModel
    Inherits clsFormDataModel
    Dim myVueTerm, myVueBG, myVueDoc As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SEItem")
        myVueTerm = Me.GetViewModel("TETerms")
        myVueBG = Me.GetViewModel("BGCust")
        myVueDoc = Me.GetViewModel("TEDoc")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "select campusid, dispname, WODate, CompletedOn from mmlistCampus() where isnull(acceptsenq,0)=1"
        Me.AddLookupField("CampusID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campus").TableName)

        sql = "select perspartyid, FullName,PartyName from genListPersParty() where partytype='C' order by fullname"
        Me.AddLookupField("AddressToID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Persons").TableName)
        Me.AddLookupField("SentByID", "Persons")

        sql = "Select UserID, fullname,isdeleted, JoinDate, LeaveDate from genlistUser() where insaleslist=1 order by fullname"
        Me.AddLookupField("HandledByID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        sql = "Select statusnum, statustext from status where statustype='te' order by statusnum"
        Me.AddLookupField("statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = "Select regionid,region from region order by regionid"
        Me.AddLookupField("RegionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Region").TableName)
        Me.AddLookupField("EURegionID", "Region")

        sql = myFuncsBase.CodeWordSQL("Document", "DispMode", "")
        Me.AddLookupField("DispMode", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "DispMode").TableName)

        sql = myFuncsBase.CodeWordSQL("enq", "enqtype", "")
        Me.AddLookupField("enqtype", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "EnqType").TableName)

        'These three queries require here also, for getting model.
        sql = "Select projectid, ProjectName + ' - ' + isnull(Location,'') as Proj,enduserid,euregionid,priority from projects"
        Me.AddLookupField("projectid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "proj").TableName)

        sql = "select partyid, partyname from genlistparty() order by partyname"
        Me.AddLookupField("partyid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)
        Me.AddLookupField("ConsultantID", "Party")
        Me.AddLookupField("ContractorID", "Party")
        Me.AddLookupField("EndUserID", "Party")

        sql = "select customerid, CustDescrip, partyid from slsListCustomer() order by partyname"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Cust").TableName)

        Dim lst As New List(Of String)
        lst.Add("High")
        lst.Add("Medium")
        lst.Add("Low")

        Me.ValueLists.Add("Priority", myContext.SQL.VListFromList(lst))
        Me.AddLookupField("Priority", "Priority")

        sql = "select BGTypeid, bgname,periodstart,periodstart2 from BGType order by BGTypeid"
        Me.AddLookupField("BGTypeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BGType").TableName)

        sql = "select statusnum, statustext from status where statustype='BG' order by statusnum"
        Me.AddLookupField("bg.statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "StatusBG").TableName)

        Dim lst1 As New List(Of String)
        lst1.Add("BG")
        lst1.Add("Draft")
        lst1.Add("STDR")

        Me.ValueLists.Add("BGMode", myContext.SQL.VListFromList(lst1))
        Me.AddLookupField("BGMode", "BGMode")
        Me.ValueLists.Add("periodtype", myContext.SQL.dicPeriodType)
        Me.AddLookupField("periodtype", "periodtype")

        sql = "select Divisionid, DivisionCode, DivisionName from Division order by DivisionCode"
        Me.AddLookupField("DivisionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from SalesEnq where SalesEnqID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("select TEDocSubmitid, SalesEnqID, docnameid, PageNum, ClauseNum, AsPerTender, ToBeQuoted, CustFormat, SendTyp, Remark from tedocsubmit where SalesEnqID = " & frmIDX, True, "0-5-1-1-3-3-1-1-3", True)
        myVueDoc.MainGrid.MainConf("FORMATXML") = myVueDoc.MainGrid.MapColXML(0, False, "custformat|Customer Format", "sendtyp|Send Typical", "docnameid|Document")
        str1 = "<BAND IDFIELD=""TEDocSubmitid"" TABLE=""tedocsubmit"" INDEX=""0""><COL KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """><OVERRIDE><STRWIDTH>0-1-1</STRWIDTH></OVERRIDE></COL><COL KEY=""sendtyp,CustFormat"" DEFAULTVALUE=""False""/><COL KEY=""AsPerTender,ToBeQuoted,PageNum,ClauseNum,Remark,SalesEnqID""/></BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueTerm.Mode = EnumViewMode.acSelectM : myVueTerm.MultiSelect = True
        myVueTerm.MainGrid.QuickConf("select TETermsCondID,SalesEnqID, tcmasterid, PageNum, ClauseNum, AsPerTE, ToBeQuoted from TETermsCond where SalesEnqID = %frmidx%", True, "0-3-1-1-4-4", True)
        myContext.Data.ReverseTick(myVueTerm.MainGrid.myDS.Tables(0), "Select tcmasterid from tcmaster where forpcl=1", "tcmasterID")
        myVueTerm.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""PageNum,CLauseNum,AsPerTE,ToBeQuoted"" BIGTEXT=""True""/><COL KEY=""tcmasterid"" LOOKUPSQL=""Select tcmasterid, tcname from tcmaster"" SKIP=""True"" CAPTION=""Term""/></BAND>", EnumEditType.acCommandAndEdit)
        myVueTerm.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""TETermsCondID"" TABLE=""TETermsCond""><COL KEY=""SalesEnqID,tcmasterid,pagenum,clausenum,asperte,tobequoted""/></BAND>", EnumEditType.acCommandOnly)

        myVueBG.MainGrid.MainConf("headfactor") = 2
        myVueBG.MainGrid.QuickConf("select BGCustomerid,SalesEnqID, pervalue,periodtype, periodnum,pervalue2,periodtype2,periodnum2,BGTypeid, BGMode, BGNum, BGDate, BGValue, ValidUpto, ReleaseDate,statusNum,ClaimPeriod,Remark from BGCustomer where SalesEnqID = " & frmIDX, True, "3-1-1-1-1-1-1-3-1", True, "")
        myVueBG.MainGrid.MainConf("FormatXML") = "<COL KEY=""BGTypeid"" CAPTION=""BG Type"" LOOKUPSQL=""select BGTypeid,bgname from BGType order by BGTypeid""/><COL KEY=""bgmode"" CAPTION=""BG Mode"" VLIST=""Draft|STDR|BG""/><COL KEY=""statusnum"" LOOKUPSQL=""Select statusnum, statustext from status where statustype='BG' order by statusnum"" CAPTION=""BG Status""/>"
        str1 = "<BAND INDEX=""0"" IDFIELD=""BGCustomerid"" TABLE=""BGCustomer"">" & myVueBG.MainGrid.BuildBandEditXML(0) & "</BAND>"
        myVueBG.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        myView.MainGrid.MainConf("formatxml") = "<COL KEY=""ItemID"" CAPTION=""ItemCode"" LOOKUPSQL=""Select ItemID, ItemCode from items where acceptwo=1""/><COL KEY=""ItemID2"" CAPTION=""ItemName"" LOOKUPSQL=""Select ItemID, ItemName from items where acceptwo=1""/>)"
        myView.MainGrid.BindGridData(GenerateData("slsenqitem", frmIDX), 0)
        myView.MainGrid.QuickConf("", True, "1-2-2-1-1-1-1", True)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If Me.SelectedRow("CustomerID") Is Nothing Then Me.AddError("CustomerID", "Select a Customer")
        If Me.SelectedRow("CampusID") Is Nothing Then Me.AddError("CampusID", "Select a Campus")
        If Me.SelectedRow("DivisionID") Is Nothing Then Me.AddError("DivisionID", "Please Select Division")
        If Me.SelectedRow("HandledByID") Is Nothing Then Me.AddError("HandledByID", "Select an Handled By")
        If Me.SelectedRow("EnqType") Is Nothing Then Me.AddError("EnqType", "Select an Enquiry Type")
        If myUtils.cStrTN(myRow("EnqRefNum")).Trim.Length = 0 Then Me.AddError("EnqRefNum", "Enter an Enquiry Ref. No.")

        If myUtils.cStrTN(myRow("NumParts")).Length > 0 Then
            If IsNothing(myUtils.cValTN(myRow("EMDPart"))) OrElse IsNothing(myUtils.cValTN(myRow("PricePart"))) OrElse IsNothing(myUtils.cValTN(myRow("TechPart"))) OrElse IsNothing(myUtils.cValTN(myRow("CommPart"))) Then
                Me.AddError("NumParts", "Complete The Parts Config or set the no of parts as 0" & vbCrLf & "Or Put the check box off !")
            End If
        End If

        myVueDoc.MainGrid.CheckValid("docnameid")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            Dim EnqTypeDescrip As String = Me.SelectedRow("EnqType")("Descrip")
            Dim SalesEnqDescrip As String = " Sales Enquiry No: " & myRow("EnqRefNum").ToString & " Type: " & EnqTypeDescrip & ""
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "SalesEnqID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from SalesEnq where SalesEnqID = " & frmIDX)
                frmIDX = myRow("SalesEnqID")

                Dim str2 As String = "SalesEnqID=" & frmIDX
                Me.myVueBG.MainGrid.SaveChanges(, str2)
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                Me.myVueTerm.MainGrid.SaveChanges(, str2)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(SalesEnqDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(SalesEnqDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
    End Function
    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey

            Case "Party"
                sql = "select partyid, partyname from genlistparty() order by partyname; select customerid, partyname, partyid from slsListCustomer() order by partyname"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "Project"
                sql = "Select projectid, ProjectName + ' - ' + isnull(Location,'') as Proj,enduserid,euregionid,priority from projects"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "slsenqitem"
                oRet.Data = GenerateData("slsenqitem", myUtils.cValTN(frmIDX))

        End Select
        Return oRet
    End Function

    Protected Overrides Function GenerateData(DataKey As String, ID As String) As DataSet
        Dim oRet As New clsProcOutput
        Select Case DataKey.Trim.ToLower
            Case "slsenqitem"
                Dim sql As String = "select SalesEnqItemID, SalesEnqID, ItemID, ItemID as ItemID2, DescripWO, QtyAPT, QtyTBQ, UnitPrice, Freight from SalesEnqItem where SalesEnqID = " & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet.Data
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "proj"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("projectid not in ('@ProjectID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""projectid""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")
            End Select
        End If
        Return Model
    End Function


End Class
