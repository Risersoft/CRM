Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmProspectListModel
    Inherits clsFormDataModel
    Dim myVueAcc, myVuePers, myVueLead, myVueUser As New clsViewModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Team")
        myVueAcc = Me.GetViewModel("Account")
        myVuePers = Me.GetViewModel("Person")
        myVueLead = Me.GetViewModel("Lead")
        myVueUser = Me.GetViewModel("User")

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

        sql = myFuncsBase.CodeWordSQL("Prospect", "ListType", "")
        Me.AddLookupField("ListType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "ListType").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from ProspectList Where ProspectlistID = " & prepIDX
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

        sql = "Select ProspectListItemID, CustomerID, ProspectlistID, IDField, IDValue, PartyName, Selcity, SelPhNum from crmListProspectListItem() where ProspectlistID = %frmIDX% and IDField = 'CustomerID'"
        myVueAcc.MainGrid.MainConf("FORMATXML") = "<COL KEY=""SelCity"" CAPTION=""City""/><COL KEY=""SelPhNum"" CAPTION=""Phone""/>"
        myVueAcc.MainGrid.QuickConf(sql, True, "1-1-1", True)
        str1 = "<BAND INDEX = ""0"" TABLE = ""ProspectListItem"" IDFIELD=""ProspectListItemID""><COL KEY ="" ProspectlistID, IDField, IDValue""/></BAND>"
        myVueAcc.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        sql = "Select ProspectListItemID, PersonID, ProspectlistID, IDField, IDValue, FullName, Email, PrPhone from crmListProspectListItem() where ProspectlistID = %frmIDX% and IDField = 'PersonID'"
        myVuePers.MainGrid.MainConf("FORMATXML") = "<COL KEY=""PrPhone"" CAPTION=""Phone""/>"
        myVuePers.MainGrid.QuickConf(sql, True, "1-1-1", True)
        str1 = "<BAND INDEX = ""0"" TABLE = ""ProspectListItem"" IDFIELD=""ProspectListItemID""><COL KEY ="" ProspectlistID, IDField, IDValue""/></BAND>"
        myVuePers.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        sql = "Select ProspectListItemID, LeadID, ProspectlistID, IDField, IDValue, Name, Title, Email1, PhoneMobile from crmListProspectListItem() where ProspectlistID = %frmIDX% and IDField = 'LeadID'"
        myVueLead.MainGrid.MainConf("FORMATXML") = "<COL KEY=""Email1"" CAPTION=""Email""/><COL KEY=""PhoneMobile"" CAPTION=""Phone""/>"
        myVueLead.MainGrid.QuickConf(sql, True, "1-1-1-1", True)
        str1 = "<BAND INDEX = ""0"" TABLE = ""ProspectListItem"" IDFIELD=""ProspectListItemID""><COL KEY ="" ProspectlistID, IDField, IDValue""/></BAND>"
        myVueLead.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        sql = "Select ProspectListItemID, UserID, ProspectlistID, IDField, IDValue2, UserName from crmListProspectListItem() where ProspectlistID = %frmIDX% and IDField = 'UserID'"
        myVueUser.MainGrid.QuickConf(sql, True, "1", True)
        str1 = "<BAND INDEX = ""0"" TABLE = ""ProspectListItem"" IDFIELD=""ProspectListItemID""><COL KEY ="" ProspectlistID, IDField, IDValue2""/></BAND>"
        myVueUser.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)


        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function


    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Prospect Name")
        If myUtils.NullNot(myRow("ListType")) Then Me.AddError("ListType", "Please Select ProspectList Type")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select ProspectlistID from Prospectlist left Join userset on Prospectlist.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, Prospectlist.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim ProspectDescrip As String = " Name: " & myUtils.cStrTN(myRow("Name")) & ", ListType: " & myUtils.cStrTN(myRow("ListType"))
                Try
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ProspectlistID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    'myView.MainGrid.SaveChanges(, "ProspectlistID=" & frmIDX)
                    myVueAcc.MainGrid.SaveChanges(, "ProspectlistID=" & frmIDX)
                    myVuePers.MainGrid.SaveChanges(, "ProspectlistID=" & frmIDX)
                    myVueLead.MainGrid.SaveChanges(, "ProspectlistID=" & frmIDX)
                    myVueUser.MainGrid.SaveChanges(, "ProspectlistID=" & frmIDX)

                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("ProspectlistID")
                    myContext.Provider.dbConn.CommitTransaction(ProspectDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(ProspectDescrip, ex.Message)
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

                Case "account"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select CustomerID, PartyName, SelCity, SelPhNum from slslistCustomer() where CustomerID NOT IN (@AccIDCsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.MainConf("FORMATXML") = "<COL KEY=""SelCity"" CAPTION=""City""/><COL KEY=""SelPhNum"" CAPTION=""Phone""/>"
                    Model.MainGrid.QuickConf(sql, True, "1-1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

                Case "person"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select PersonID, FullName, Email, PrPhone from genlistPersons() where PersonID NOT IN (@PersIDCsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.MainConf("FORMATXML") = "<COL KEY=""PrPhone"" CAPTION=""Phone""/>"
                    Model.MainGrid.QuickConf(sql, True, "1-1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

                Case "lead"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select LeadID, Name, Title, Email1, PhoneMobile from crmlistLead() where LeadID NOT IN (@LeadIDCsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.MainConf("FORMATXML") = "<COL KEY=""Email1"" CAPTION=""Email""/><COL KEY=""PhoneMobile"" CAPTION=""Phone""/>"
                    Model.MainGrid.QuickConf(sql, True, "1-1-1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

                Case "user"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select UserID, UserName from genlistUser() where insaleslist=1 and isdeleted=0 and UserID NOT IN (@UserIDCsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
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
                    Case "prospectlist"
                        Dim sql As String = "Select * from ProspectList Where ProspectListID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update ProspectList set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where ProspectListID =" & ID
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
