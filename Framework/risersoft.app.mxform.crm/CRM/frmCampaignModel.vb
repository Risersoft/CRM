Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmCampaignModel
    Inherits clsFormDataModel

    Dim myVueProspect As clsViewModel
    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Team")
        myVueProspect = Me.GetViewModel("Prospect")
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

        Dim vlist As New clsValueList
        vlist.Add("TELE", "Telesales")
        vlist.Add("MAIL", "Mail")
        vlist.Add("EMAIL", "Email")
        vlist.Add("PRINT", "Print")
        vlist.Add("WEB", "Web")
        vlist.Add("RADIO", "Radio")
        vlist.Add("TV", "Television")
        vlist.Add("NEWS", "Newsletter")
        Me.ValueLists.Add("CampaignType", vlist)
        Me.AddLookupField("CampaignType", "CampaignType")

        Dim vlist1 As New clsValueList
        vlist1.Add("Planning", "Planning")
        vlist1.Add("Active", "Active")
        vlist1.Add("Inactive", "Inactive")
        vlist1.Add("Complete", "Complete")
        vlist1.Add("In queue", "In queue")
        vlist1.Add("Sending", "Sending")
        Me.ValueLists.Add("Status", vlist1)
        Me.AddLookupField("Status", "Status")

        Dim vlist2 As New clsValueList
        vlist2.Add("Rupee", "INR")
        vlist2.Add("Dollar", "U.S. Dollar:$")
        Me.ValueLists.Add("CurrencyCode", vlist2)
        Me.AddLookupField("CurrencyCode", "CurrencyCode")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from Campaign Where CampaignID = " & prepIDX
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

        sql = "select psp.ProspectListID, ProspectListParentID, 'CampaignID' as PIDField," & frmIDX & " as PIDValue, Name, Description, UserSetName from crmlistprospectlist() as psp  inner Join  ProspectlistParent as pp on psp.ProspectListID=pp.ProspectListID where PIDField = 'CampaignID' and PIDValue = " & frmIDX & ""
        myVueProspect.MainGrid.QuickConf(sql, True, "1-1-1", True, "Prospects")
        Dim str3 As String = "<BAND TABLE=""ProspectListParent"" IDFIELD=""ProspectListParentID"" INDEX=""0""><COL KEY=""ProspectListID, PIDField, PIDValue""/></BAND>"
        Me.myVueProspect.MainGrid.PrepEdit(str3, EnumEditType.acCommandOnly)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function


    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.NullNot(myRow("CurrencyCode")) Then Me.AddError("CurrencyCode", "Please select Currency")
        If Me.SelectedItem("CampaignType") Is Nothing Then Me.AddError("CampaignType", "Please select Campaign Type")
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Name")
        If myUtils.NullNot(myRow("EDate")) Then Me.AddError("EDate", "Please Select End Date")
        If Me.SelectedItem("Status") Is Nothing Then Me.AddError("Status", "Please Select Status")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select CampaignID from Campaign left Join userset on Campaign.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, Campaign.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim CampaignDescrip As String = myUtils.cStrTN(myRow("Name"))
                Try
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "CampaignID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    ' myView.MainGrid.SaveChanges(, "CampaignID=" & frmIDX)
                    If myVueProspect.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myVueProspect.MainGrid.SaveChanges(, "PIDValue=" & frmIDX)
                    End If
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("CampaignID")
                    myContext.Provider.dbConn.CommitTransaction(CampaignDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(CampaignDescrip, ex.Message)
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

                Case "prospect"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select ProspectListID, Name, Description, UserSetName from crmlistprospectlist() where ProspectlistID not in (@ProsIDcsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf(sql, True, "1-1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)
                    Model.myCMain.strView = "Select Prospect"
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        If myVueProspect.ContextRow Is Nothing Then
            Select Case dataKey.Trim.ToLower
                Case "delprospect"
                    Dim Sql As String = "delete from ProspectListParent where ProspectListParentID = " & myUtils.cValTN(ID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
            End Select
        End If
        Return oRet
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "campaign"
                        Dim sql As String = "Select * from Campaign Where CampaignID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update Campaign set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where CampaignID =" & ID
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

