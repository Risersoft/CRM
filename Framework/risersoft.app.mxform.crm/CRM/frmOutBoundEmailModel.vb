Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmOutBoundEmailModel
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
        Me.AddLookupField("UserID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        sql = "Select TeamID, Name from Team order by Name"
        Me.AddLookupField("AssignTeamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Team").TableName)

        Dim vlist As New clsValueList
        vlist.Add("gmail", "gmail")
        vlist.Add("yahop", "yahoo")
        vlist.Add("other", "other")
        Me.ValueLists.Add("Provider", vlist)
        Me.AddLookupField("MailSmtpType", "Provider")

        Dim vlist1 As New clsValueList
        vlist1.Add("SMTP", "SMTP")
        vlist1.Add("API", "API")
        Me.ValueLists.Add("Type", vlist1)
        Me.AddLookupField("Type", "Type")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from OutBoundEmail Where OutBoundEmailID = " & prepIDX
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
        'If Me.SelectedRow("UserID") Is Nothing Then Me.AddError("UserID", "Please select Assigned to User")
        If myUtils.cStrTN(myRow("FromName")).Trim.Length = 0 Then Me.AddError("FromName", "Enter From Name")
        If myUtils.cStrTN(myRow("FromAddr")).Trim.Length = 0 Then Me.AddError("FromAddr", "Enter From Address")
        If myUtils.cStrTN(myRow("MailSmtpServer")).Trim.Length = 0 Then Me.AddError("MailSmtpServer", "Enter SMTP Mail Server")
        If myUtils.cStrTN(myRow("MailSmtpPort")).Trim.Length = 0 Then Me.AddError("MailSmtpPort", "Enter SMTP Port")
        If myUtils.cStrTN(myRow("MailSmtpUser")).Trim.Length = 0 Then Me.AddError("MailSmtpUser", "Enter Email Address")
        If myUtils.cStrTN(myRow("MailSmtpPass")).Trim.Length = 0 Then Me.AddError("MailSmtpPass", "Enter Password")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select OutBoundEmailID from OutBoundEmail left Join userset on OutBoundEmail.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', UserID, OutBoundEmail.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim EmailDescrip As String = " Name: " & myUtils.cStrTN(myRow("FromName")) & ", FromAddress: " & myUtils.cStrTN(myRow("FromAddr"))
                Try
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("UserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "OutBoundEmailID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    'myView.MainGrid.SaveChanges(, "OutBoundEmailID=" & frmIDX)
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("OutBoundEmailID")
                    myContext.Provider.dbConn.CommitTransaction(EmailDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(EmailDescrip, ex.Message)
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
                Case "user"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in ('@UserID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "assignteam"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("TeamID not in ('@AssignTeamID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""TeamID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "userset"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in (@UserIDcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", True,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

            End Select
        End If
        Return Model
    End Function


    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "outboundemail"
                        Dim sql As String = "Select * from OutBoundEmail Where OutBoundEmailID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update OutBoundEmail set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where OutBoundEmailID =" & ID
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

