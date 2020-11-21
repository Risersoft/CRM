Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports risersoft.app.mxengg
Imports System.IO
Imports risersoft.shared.cloud
Imports System.Configuration

<DataContract>
Public Class frmEmailMarketingModel
    Inherits clsFormDataModel

    Dim myVueProspect As clsViewModel
    Dim myVueEmail As clsViewModel ' Added for Email on 29/apr

    Protected Overrides Sub InitViews()
        myVueProspect = Me.GetViewModel("Prospect")
        myVueEmail = Me.GetViewModel("Email") ' Added for Email on 29/apr
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select EmailTemplateID, Name from EmailTemplate order by EmailTemplateID"
        Me.AddLookupField("TemplateID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Template").TableName)

        sql = "Select OutBoundEmailID, FromName from OutBoundEmail order by OutBoundEmailID"
        Me.AddLookupField("OutBoundEmailID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "OutBound").TableName)

        sql = "Select InBoundEmailID, FromName from InBoundEmail order by InBoundEmailID"
        Me.AddLookupField("InBoundEmailID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "InBound").TableName)

        Dim vlist1 As New clsValueList
        vlist1.Add("Planning", "Planning")
        vlist1.Add("Active", "Active")
        vlist1.Add("Inactive", "Inactive")
        vlist1.Add("Complete", "Complete")
        vlist1.Add("In queue", "In queue")
        vlist1.Add("Sending", "Sending")
        Me.ValueLists.Add("Status", vlist1)
        Me.AddLookupField("Status", "Status")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from EmailMarketing Where EmailMarketingID = " & prepIDX
        Me.InitData(sql, "CampaignID", oView, prepMode, prepIDX, strXML)

        sql = "select psp.ProspectListID, ProspectListParentID, 'EmailMarketingID' as PIDField," & frmIDX & " as PIDValue, Name, Description, UserSetName from crmlistprospectlist() as psp  inner Join  ProspectlistParent as pp on psp.ProspectListID=pp.ProspectListID where PIDField = 'EmailMarketingID' and PIDValue = " & frmIDX & ""
        myVueProspect.MainGrid.QuickConf(sql, True, "1-1-1", True, "Prospects")
        Dim str3 As String = "<BAND TABLE=""ProspectListParent"" IDFIELD=""ProspectListParentID"" INDEX=""0""><COL KEY=""ProspectListID, PIDField, PIDValue""/></BAND>"
        Me.myVueProspect.MainGrid.PrepEdit(str3, EnumEditType.acCommandOnly)

        'For web use (email table )
        sql = "select EmailID,EmailTemplateID,Name,PIDField, PIDValue,Content,ContentHtml,FromName,ToAddrs,ToAddrsIDS,ToAddrsName,ToAddrsEmail,Type,RawSource,OutBoundEmailID,EmailMessageId,AttachmentJson,EmailMarketingID from Email where EmailMarketingID = " & frmIDX & ""
        Me.myVueEmail.MainGrid.QuickConf(sql, True, "1", True, "Email")
        Dim str1 As String = "<BAND INDEX=""0"" IDFIELD=""EmailID"" TABLE=""Email""><COL KEY=""EmailTemplateID,Name, PIDField, PIDValue,Content,ContentHtml,FromName,ToAddrs,ToAddrsIDS,ToAddrsName,ToAddrsEmail,Type,RawSource,OutBoundEmailID,EmailMessageId,AttachmentJson,EmailMarketingID""/></BAND>"
        Me.myVueEmail.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)


        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Name")
        If myUtils.cStrTN(myRow("FromName")).Trim.Length = 0 Then Me.AddError("FromName", "Enter FromName")
        If myUtils.NullNot(myRow("SDate")) Then Me.AddError("SDate", "Please Select Start Date")
        If Me.SelectedRow("TemplateID") Is Nothing Then Me.AddError("TemplateID", "Please Select Email Template")
        If Me.SelectedItem("Status") Is Nothing Then Me.AddError("Status", "Please Select Status")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then


            If Me.CanSave Then
                Dim EmailDescrip As String = myUtils.cStrTN(myRow("Name"))
                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "EmailMarketingID", frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    If myVueProspect.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myVueProspect.MainGrid.SaveChanges(, "PIDValue=" & frmIDX)
                    End If
                    '29/apr for web use only
                    If Me.myVueEmail.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        Dim PData As New clsProcOutput
                        For Each r1 As DataRow In Me.myVueEmail.MainGrid.myDS.Tables(0).Select
                            r1.Item("ContentHtml") = BucketUtility.TryBase64Decode((r1.Item("ContentHtml")))
                            r1.Item("Content") = BucketUtility.TryBase64Decode(r1.Item("Content"))
                            If IsDBNull(r1.Item("EmailID")) Then
                                If r1.Item("PIDField") = "LeadID" Then
                                    Dim sql1 As String = "Select LeadID, Email1,Email2 from Lead where LeadID=" & r1.Item("PIDValue")
                                    PData.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
                                    For Each row As DataRow In PData.Data.Tables(0).Select
                                        If Not (IsDBNull(row.Item("Email1")) And IsDBNull(row.Item("Email2"))) Then
                                            Dim Email1 As String = row.Item("Email1").ToString()
                                            Dim Email2 As String = row.Item("Email2").ToString()
                                            r1.Item("ToAddrsEmail") = Email1 & "," & Email2
                                        End If
                                    Next
                                    If IsDBNull(r1.Item("ToAddrsEmail")) Then
                                        myVueEmail.MainGrid.myDS.Tables(0).Rows.Remove(r1)
                                    End If

                                ElseIf r1.Item("PIDField") = "CustomerID" Then
                                    Dim sql1 As String = "Select CustomerID, PartyName, SelCity, SelPhNum from slslistCustomer() where CustomerID= " & r1.Item("PIDValue")
                                    PData.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
                                    myVueEmail.MainGrid.myDS.Tables(0).Rows.Remove(r1)

                                ElseIf r1.Item("PIDField") = "PersonID" Then
                                    Dim sql1 As String = "Select PersonID, FullName, Email, PrPhone from genlistPersons() where PersonID=" & r1.Item("PIDValue")
                                    PData.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
                                    For Each row As DataRow In PData.Data.Tables(0).Select
                                        r1.Item("ToAddrsEmail") = row.Item("Email")
                                    Next
                                    If IsDBNull(r1.Item("ToAddrsEmail")) Then
                                        myVueEmail.MainGrid.myDS.Tables(0).Rows.Remove(r1)
                                    End If
                                ElseIf r1.Item("PIDField") = "UserID" Then
                                    Dim sql1 As String = "Select UserID, UserName from genlistUser() where UserID=" & r1.Item("PIDValue")
                                    PData.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql1)
                                    For Each row As DataRow In PData.Data.Tables(0).Select
                                        r1.Item("ToAddrsEmail") = row.Item("UserName")
                                    Next
                                    If IsDBNull(r1.Item("ToAddrsEmail")) Then
                                        myVueEmail.MainGrid.myDS.Tables(0).Rows.Remove(r1)
                                    End If
                                End If
                            End If
                        Next
                        Me.myVueEmail.MainGrid.SaveChanges(, "EmailMarketingID=" & frmIDX)
                    End If
                    'end
                    frmMode = EnumfrmMode.acEditM
                    frmIDX = myRow("EmailMarketingID")
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
                Case "prospect"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select ProspectListID, Name, Description, UserSetName from crmlistprospectlist() where ProspectlistID not in (@ProsIDcsv)", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf(sql, True, "1-1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)


            End Select
        End If
        Return Model
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Dim PData As New clsProcOutput
        If myVueProspect.ContextRow Is Nothing Then
            Select Case dataKey.Trim.ToLower
                Case "delprospect"
                    Dim Sql As String = "delete from ProspectListParent where ProspectListParentID = " & myUtils.cValTN(ID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, Sql)
            End Select
        End If

        Select Case dataKey.Trim.ToLower
            Case "template"
                Dim sql As String = "Select EmailTemplateID, Subject, Content, ContentHtml,AttachmentJson from EmailTemplate where EmailTemplateID=" & ID
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "prospectlistitem"
                Dim sql As String = "Select ProspectListID,IDField, IDValue,IDValue2 from ProspectListItem"
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

            Case "campaign"
                Dim sql As String = "select psp.ProspectListID, psp.ProspectListParentID, psp.PIDField, psp.PIDValue,pp.IDField,pp.IDValue,pp.IDValue2 from ProspectListParent as psp inner Join  ProspectListItem as pp on psp.ProspectListID=pp.ProspectListID where PIDField = 'CampaignID' and PIDValue=" & myUtils.cValTN(ID)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
           'Email Send 
            Case "email"
                Dim sql As String = "Select EmailID,PIDField,PIDValue, FromName, Name, ToAddrsName, ToAddrsEmail, CCAddrsName, CCAddrsEmail, BCCAddrsName, BCCAddrsEmail,ContentHtml,AttachmentJson from Email where EmailMarketingID=" & myUtils.cValTN(ID)

                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

                For Each row As DataRow In oRet.Data.Tables(0).Select
                    Dim r = row
                    'download blob files
                    If Not IsDBNull(row.Item("AttachmentJson")) Then
                        Dim Attachments As String = row.Item("AttachmentJson").ToString()
                        Dim Filenames As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(Attachments)

                        Dim files_name As String = downloadedfiles(Filenames).Result.ToString()
                        row.Item("AttachmentJson") = files_name
                    End If
                    oRet.Description = MailgunMail.SendMail(myContext, row).Content.ToString()
                    Dim deserial As Object = JsonConvert.DeserializeObject(Of Object)(oRet.Description)
                    Dim IDval As String = deserial("id")
                    If Not String.IsNullOrEmpty(IDval) Then
                        Dim EmailMessID As String = IDval.Substring(1, IDval.Length - 2)
                        Dim emailId = row.Item("EmailID")
                        Dim sql1 As String = "update Email set EmailMessageId= '" & EmailMessID & "', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailID =" & emailId
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                    Else
                        Dim Message As String = deserial("message").ToString()
                        Dim emailId = row.Item("EmailID")
                        Dim sql2 As String = "update Email set ProviderMessage= '" & Message & "',Status='Error', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailID =" & emailId
                        myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql2)
                    End If
                Next

            Case "track"
                Dim sql As String = "Select Name, ToAddrsName, ToAddrsEmail,CCAddrsName, CCAddrsEmail, BCCAddrsName, BCCAddrsEmail, LastUpdated,EmailMessageId from Email where EmailMarketingID=" & myUtils.cValTN(ID)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)

                Dim Index As Integer = 0
                Dim count = oRet.Data.Tables(0).Rows.Count
                Dim Arr(count) As TrackResponseInfo
                For Each row As DataRow In oRet.Data.Tables(0).Select
                    If Not IsDBNull(row.Item("EmailMessageId")) Then
                        Dim strToAddr As String = row.Item("EmailMessageId").ToString()
                        oRet.Description = MailgunMail.EmailTrack(myContext, strToAddr).Content.ToString()
                        oRet.JsonData = JsonConvert.DeserializeObject(Of TrackResponseInfo)(oRet.Description)
                        Arr(Index) = oRet.JsonData
                        Index = Index + 1
                    End If
                Next
                oRet.JsonData = Arr


        End Select
        Return oRet
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "emailm"
                        Dim sql As String = "Select * from EmailMarketing Where EmailMarketingID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update EmailMarketing set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailMarketingID =" & ID
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
