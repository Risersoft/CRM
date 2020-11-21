Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.app.mxengg

'Imports Newtonsoft.Json
Imports risersoft.shared.cloud
Imports System.Configuration
Imports System.IO
Imports System.Web
Imports Microsoft.Azure

<DataContract>
Public Class frmEmailModel
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
        'added ContentHtml in DSCombo EmailTemp 27-3-20
        'sql = "Select EmailTemplateID, Name, Content, ContentHtml from EmailTemplate order by EmailTemplateID"
        sql = "Select EmailTemplateID, Name, Content from EmailTemplate order by EmailTemplateID"
        Me.AddLookupField("EmailTemplateID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Template").TableName)

        sql = "Select OutBoundEmailID, Name, FromName, FromAddr from OutBoundEmail order by OutBoundEmailID"
        Me.AddLookupField("OutBoundEmailID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Email").TableName)

        Dim vlist As New clsValueList
        vlist.Add("LeadID", "Lead")
        vlist.Add("SalesCaseID", "SalesCase")
        vlist.Add("OpportunityID", "Opportunity")
        vlist.Add("CampaignID", "Campaign")
        vlist.Add("CustomerID", "Customer")
        vlist.Add("PersonID", "Person")
        Me.ValueLists.Add("PIDField", vlist)
        Me.AddLookupField("PIDField", "PIDField")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from Email Where EmailID = " & prepIDX
        Me.InitData(sql, "IDValue,IDField", oView, prepMode, prepIDX, strXML)
        myRow("Type") = "OUT"

        If frmMode = EnumfrmMode.acAddM Then
            myRow("pidfield") = Me.vBag("idfield")
            myRow("pidvalue") = Me.vBag("idvalue")
        End If

        Dim rParent = myFuncs.GetParentRow(myContext, myRow("pidfield"), myRow("pidvalue"))
        myUtils.AddTable(Me.dsCombo, rParent.Table, "Parent")

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
        If Me.SelectedRow("OutBoundEmailID") Is Nothing Then Me.AddError("OutBoundEmailID", "Please Select OutBoundEmail")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select EmailID from Email left Join userset on Email.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, Email.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim EmailDescrip As String = myUtils.cStrTN(myRow("Name"))
                Try
                    'for web use only
                    myRow("ContentHtml") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("ContentHtml")))
                    myRow("ToAddrs") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("ToAddrs")))
                    myRow("CCAddrs") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("CCAddrs")))
                    myRow("BCCAddrs") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("BCCAddrs")))

                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "EmailID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    'myView.MainGrid.SaveChanges(, "EmailID=" & frmIDX)
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("EmailID")
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
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), Model As clsViewModel = Nothing, eConf As New clsBandConf()

        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "assignuser"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in ('@AssignUserID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID= ""UserID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "assignteam"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("TeamID not in ('@AssignTeamID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""TeamID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "userset"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID Not In (@UserIDcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", True,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "email"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select PersonID, Email, FullName from genListPersons() where PersonID Not in (@PersIDCSV) and Email <> ''", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf(sql, True, "1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

            End Select
        End If
        Return Model
    End Function

    'Email send and track  
    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "email"
                Dim sql As String = "Select EmailID, FromName, Name, ToAddrsName, ToAddrsEmail, CCAddrsName, CCAddrsEmail, BCCAddrsName, BCCAddrsEmail,ContentHtml,AttachmentJson from Email where EmailID=" & myUtils.cValTN(ID)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Dim row As DataRow = oRet.Data.Tables(0).Rows(0)
                'getting file url from blob storage
                If Not IsDBNull(row.Item("AttachmentJson")) Then
                    Dim Attachments As String = row.Item("AttachmentJson").ToString()
                    If Not String.Equals(Attachments,"[]") Then
                        Dim Filenames As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Attachments)
                        Dim files_name As String = downloadedfiles(Filenames).Result.ToString()
                        row.Item("AttachmentJson") = files_name
                    End If
                End If


                oRet.Description = MailgunMail.SendMail(myContext, row).Content.ToString()
                Dim deserial As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(oRet.Description)
                Dim IDval As String = deserial("id")
                If Not String.IsNullOrEmpty(IDval) Then
                    Dim EmailMessID As String = IDval.Substring(1, IDval.Length - 2)
                    Dim emailId = row.Item("EmailID")
                    Dim sql1 As String = "update Email set EmailMessageId= '" & EmailMessID & "', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailID =" & myUtils.cValTN(ID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                Else
                    Dim Message As String = deserial("message").ToString()
                    Dim emailId = row.Item("EmailID")
                    Dim sql2 As String = "update Email set ProviderMessage= '" & Message & "',Status='Error', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailID =" & myUtils.cValTN(ID)

                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql2)
                End If

            Case "track"
                Dim sql As String = "Select Name, ToAddrsName, ToAddrsEmail,CCAddrsName, CCAddrsEmail, BCCAddrsName, BCCAddrsEmail, LastUpdated,EmailMessageId from Email where EmailID=" & myUtils.cValTN(ID)

                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Dim strToAddr As String = oRet.Data.Tables(0).Rows(0).Item("EmailMessageId").ToString()
                oRet.Description = MailgunMail.EmailTrack(myContext, strToAddr).Content.ToString()
                oRet.JsonData = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TrackResponseInfo)(oRet.Description)
            Case "template"
                Dim sql As String = "Select EmailTemplateID, Subject, Content, ContentHtml from EmailTemplate where EmailTemplateID=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        End Select
        Return oRet
    End Function

    ' Blob storage

    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput
        Dim _NewFileName As String = myUtils.cStrTN(myContext.SQL.ParamValue("@filename", Params))
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "sas"
                Dim OrigFileName = Path.GetFileNameWithoutExtension(_NewFileName)
                _NewFileName = OrigFileName + "--" + Guid.NewGuid.ToString + Path.GetExtension(_NewFileName)
                Dim provider As New clsBlobFileProvider(myContext)
                Dim container = myPathUtils.GetContainerName(myContext)
                Dim oRet2 = provider.CreateUploadUri(container, _NewFileName, "")
                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString, .flName = _NewFileName}
                Else
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If
            Case "download"
                Dim provider As New clsBlobFileProvider(myContext)
                Dim container = myPathUtils.GetContainerName(myContext)
                Dim oRet2 = provider.GetDownloadUri(container, _NewFileName)
                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString}
                Else
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If
        End Select
        Return oRet
    End Function


    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "email"
                        Dim sql As String = "Select * from Email Where EmailID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update Email set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailID =" & ID
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

    'Downloaded files from url
    Public Async Function downloadedfiles(Filenames As Object) As Task(Of String)
        Dim directoryPath = myContext.App.objAppExtender.MapPath(".\App_Data\DownloadedBlob")
        Dim files_name As String
        Dim localPath As String
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        Dim provider As New clsBlobFileProvider(myContext)
        For Each item As Object In Filenames
            Dim oRet2 = Await provider.GetDownloadUriAsync(ConfigurationManager.AppSettings("StorageContainerName"), item("blobname").ToString())
            If oRet2.Success Then
                Dim filepath As String = oRet2.Result.Uri.ToString()
                Dim strFilePath = System.IO.Path.Combine(directoryPath, oRet2.Result.BlobName.ToString())
                Dim client = myContext.App.objAppExtender.FileProviderClient(myContext, myPathUtils.GetContainerName(myContext))
                localPath = Await client.DownloadHttpFile(filepath, strFilePath)
                If String.IsNullOrEmpty(files_name) Then
                    files_name = item("blobname").ToString()
                Else
                    files_name = files_name + "," + item("blobname").ToString()
                End If
            End If
        Next
        Return files_name
    End Function


End Class

