Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmOpportunityModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Team")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select UserID, UserName from genlistuser() where insaleslist=1 and isdeleted=0 order by fullname"
        Me.AddLookupField("AssignUserID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        sql = "Select TeamID, Name from Team order by Name"
        Me.AddLookupField("AssignTeamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Team").TableName)

        sql = "Select CustomerID, PartyName from slsListCustomer() order by PartyName"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Customer").TableName)

        sql = "Select CampaignID, Name from Campaign order by CampaignID"
        Me.AddLookupField("CampaignID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campaign").TableName)

        Dim vlist As New clsValueList
        vlist.Add("Existing Business", "Existing Business")
        vlist.Add("New Business", "New Business")
        Me.ValueLists.Add("Opportunity", vlist)
        Me.AddLookupField("OpportunityType", "Opportunity")

        Dim vlist1 As New clsValueList
        vlist1.Add("Cold Call", "Cold Call")
        vlist1.Add("Existing Customer", "Existing Customer")
        vlist1.Add("Self generated", "Self generated")
        vlist1.Add("Employee", "Employee")
        vlist1.Add("Partner", "Partner")
        vlist1.Add("Public Relations", "Public Relations")
        vlist1.Add("Direct Mail", "Direct Mail")
        vlist1.Add("Conference", "Conference")
        vlist1.Add("Trade Show", "Trade Show")
        vlist1.Add("Website", "Website")
        vlist1.Add("World of Mouth", "World of Mouth")
        vlist1.Add("Email", "Email")
        vlist1.Add("Campaign", "Campaign")
        vlist1.Add("Other", "Other")
        vlist1.Add("Hubspot", "Hubspot")
        Me.ValueLists.Add("LeadSource", vlist1)
        Me.AddLookupField("LeadSource", "LeadSource")

        Dim vlist2 As New clsValueList
        vlist2.Add("Rupee", "INR")
        vlist2.Add("Dollar", "U.S. Dollar:$")
        Me.ValueLists.Add("Currency", vlist2)
        Me.AddLookupField("Currency", "Currency")

        Dim vlist3 As New clsValueList
        vlist3.Add("Prospecting", "Prospecting")
        vlist3.Add("Qualification", "Qualification")
        vlist3.Add("Needs Analysis", "Needs Analysis")
        vlist3.Add("Value Proposition", "Value Proposition")
        vlist3.Add("Id. decision makers", "Id. decision makers")
        vlist3.Add("Perception analysis", "Perception analysis")
        vlist3.Add("Proposal/price quote", "Proposal/price quote")
        vlist3.Add("Negotiation/Review", "Negotiation/Review")
        vlist3.Add("Closed won", "Closed won")
        vlist3.Add("Closed lost", "Closed lost")
        vlist3.Add("Other", "Other")
        Me.ValueLists.Add("Stage", vlist3)
        Me.AddLookupField("SalesStage", "Stage")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from Opportunity Where OpportunityID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        Dim dic As New clsCollecString(Of String)
        dic.Add("Team", "select * from UserSet where UserSetID = " & myUtils.cValTN(myRow("AssignUserSetID")) & "")
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        str1 = Replace(myUtils.MakeCSV(ds.Tables("Team").Select(), "UserSetList", ", ", "'00000000-0000-0000-0000-000000000000'", True), ",", "','")

        sql = "select UserID, UserName from genListUser() where insaleslist=1 and isdeleted=0 and UserID in (" & str1 & ")"
        myView.MainGrid.MainConf("FORMATXML") = "<COL KEY=""UserName"" CAPTION=""Users""/>"
        myView.MainGrid.QuickConf(sql, True, "1", True)
        Dim str2 As String = "<BAND TABLE=""User"" IDFIELD=""UserID"" INDEX=""0""><COL KEY=""UserName""/></BAND>"
        Me.myView.MainGrid.PrepEdit(str2, EnumEditType.acCommandOnly)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function


    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Opportunity Name")
        If Me.SelectedRow("CustomerID") Is Nothing Then Me.AddError("CustomerID", "Please Select Customer Name")
        If myUtils.NullNot(myRow("Amount")) Then Me.AddError("Amount", "Please Enter Amount")
        If myUtils.NullNot(myRow("DateClosed")) Then Me.AddError("DateClosed", "Please Select Date Closed")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select OpportunityID from Opportunity left Join userset on Opportunity.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, Opportunity.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim OpportunityDescrip As String = " Name: " & myUtils.cStrTN(myRow("Name")) & ", OpportunityType: " & myUtils.cStrTN(myRow("OpportunityType"))
                Try
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "OpportunityID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    ' myView.MainGrid.SaveChanges(, "OpportunityID=" & frmIDX)
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("OpportunityID")
                    myContext.Provider.dbConn.CommitTransaction(OpportunityDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(OpportunityDescrip, ex.Message)
                    Me.AddError("", ex.Message)
                End Try
            End If
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "assignuser"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in ('@AssignUserID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "assignteam"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("TeamID not in ('@AssignTeamID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""TeamID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "userset"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in (@UserIDcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", True,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "customer"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("CustomerID not in (@CustomerID)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""CustomerID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "campaign"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select CampaignID, Name from Campaign where CampaignID not in (@CampaignID) order by CampaignID", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = False
                    Model.MainGrid.QuickConf(sql, True, "1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

            End Select
        End If
        Return Model
    End Function


    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "opportunity"
                        Dim sql As String = "Select * from Opportunity Where OpportunityID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update Opportunity set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where OpportunityID =" & ID
                            myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                        End If
                End Select
            ElseIf oRet.WarningCount = 0 Then
                oRet.AddWarning("Are you sure ?")
            End If
        Catch ex As Exception
            oRet.AddException(ex)
        End Try
        Return oRet
    End Function

End Class
