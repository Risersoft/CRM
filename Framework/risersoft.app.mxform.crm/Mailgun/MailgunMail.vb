Imports System
Imports System.IO
Imports risersoft.shared
Imports RestSharp
Imports RestSharp.Authenticators
Imports System.Net


Public Class MailgunMail
    'Send Email
    Public Shared Function SendMail(context As IProviderContext, row As DataRow) As IRestResponse
        Dim todata, ccdata, bccdata, attachmentdata
        'Dim strToAddr, todata, strCCAddr, ccdata, strBCCAddr, bccdata, strAttachment, attachmentdata
        Dim pathn As String = ""
        'strAttachment = row.Item("AttachmentJson")
        'strToAddr = row.Item("ToAddrsEmail")
        'strCCAddr = row.Item("CCAddrsEmail")
        'strBCCAddr = row.Item("BCCAddrsEmail")
        'For Each row As DataRow In Params.Tables(0).Rows
        If Not Equals(row.Item("AttachmentJson"), "[]") Then
            Dim directoryPath = context.App.objAppExtender.MapPath(".\App_Data\DownloadedBlob")
            attachmentdata = Split(row.Item("AttachmentJson").ToString(), ",")
            For Each dd As Object In attachmentdata
                If String.IsNullOrEmpty(pathn) Then
                    pathn = Path.Combine(directoryPath, dd.ToString())
                Else
                    pathn = pathn + "," + Path.Combine(directoryPath, dd.ToString())
                End If
            Next dd
        End If


        Dim client As RestClient = New RestClient()
        client.BaseUrl = New Uri("https://api.mailgun.net/v3")
        client.Authenticator = New HttpBasicAuthenticator("api", "06e97958be2880a5fdd82e139462c7bb-915161b7-4220ccba")
        Dim request As RestRequest = New RestRequest()
        request.AddParameter("domain", "sandbox6194e0dbe0634ba58e98586bba4a953b.mailgun.org", ParameterType.UrlSegment)
        request.Resource = "{domain}/messages"
        'request.AddParameter("from", row.Item("FromName"))
        request.AddParameter("from", row.Item("FromName") + "<mailgun@sandbox6194e0dbe0634ba58e98586bba4a953b.mailgun.org>")
        'To Recipient
        If Not IsDBNull(row.Item("ToAddrsEmail")) Then
            todata = Split(row.Item("ToAddrsEmail").ToString(), ",")
            For Each dd As Object In todata
                request.AddParameter("to", dd)
            Next dd
        End If
        'CC Recipient
        If Not IsDBNull(row.Item("CCAddrsEmail")) Then
            ccdata = Split(row.Item("CCAddrsEmail").ToString(), ",")
            For Each dd As Object In ccdata
                request.AddParameter("cc", dd)
            Next dd
        End If
        'BCC Recipient
        If Not IsDBNull(row.Item("BCCAddrsEmail")) Then
            bccdata = Split(row.Item("BCCAddrsEmail").ToString(), ",")
            For Each dd As Object In bccdata
                request.AddParameter("bcc", dd)
            Next dd
        End If
        request.AddParameter("subject", row.Item("Name"))
        request.AddParameter("html", row.Item("ContentHtml"))
        request.AddParameter("o:tracking", "yes")
        'Attachment
        If Not String.IsNullOrEmpty(pathn) Then
            attachmentdata = Split(pathn, ",")
            For Each dd As String In attachmentdata
                request.AddFile("attachment", dd.ToString(),)
            Next dd
        End If
        request.Method = Method.POST
        Return client.Execute(request)
        'Next row
    End Function

    'Email Tracking
    Public Shared Function EmailTrack(context As IProviderContext, email As String) As IRestResponse
        Dim client As RestClient = New RestClient()
        client.BaseUrl = New Uri("https://api.mailgun.net/v3")
        client.Authenticator = New HttpBasicAuthenticator("api", "06e97958be2880a5fdd82e139462c7bb-915161b7-4220ccba")
        Dim request As RestRequest = New RestRequest()
        request.AddParameter("domain", "sandbox6194e0dbe0634ba58e98586bba4a953b.mailgun.org", ParameterType.UrlSegment)
        request.Resource = "{domain}/events"
        request.AddParameter("message-id", email)
        Return client.Execute(request)

    End Function

    'Send Email
    'Public Shared Function SendMailForMarketing(row As DataRow) As IRestResponse
    '    Dim strToAddr, todata

    '    'For Each row As DataRow In Params.Tables(0).Rows
    '    'If key = "LeadID" Then
    '    '    strToAddr = Prow.Item("Email1")
    '    'ElseIf key = "PersonID" Then
    '    '    strToAddr = Prow.Item("Email")
    '    'ElseIf key = "UserID" Then
    '    '    strToAddr = row.Item("UserName")
    '    'End If
    '    strToAddr = row.Item("ToAddrsEmail")
    '    Dim client As RestClient = New RestClient()
    '    client.BaseUrl = New Uri("https://api.mailgun.net/v3")
    '    client.Authenticator = New HttpBasicAuthenticator("api", "06e97958be2880a5fdd82e139462c7bb-915161b7-4220ccba")
    '    Dim request As RestRequest = New RestRequest()
    '    request.AddParameter("domain", "sandbox6194e0dbe0634ba58e98586bba4a953b.mailgun.org", ParameterType.UrlSegment)
    '    request.Resource = "{domain}/messages"
    '    request.AddParameter("from", row.Item("FromName") + "<mailgun@sandbox6194e0dbe0634ba58e98586bba4a953b.mailgun.org>")
    '    If Not IsDBNull(strToAddr) Then
    '        todata = Split(strToAddr, ",")
    '        For Each dd As Object In todata
    '            request.AddParameter("to", dd)
    '        Next dd
    '    End If
    '    request.AddParameter("subject", row.Item("Name"))
    '    request.AddParameter("html", row.Item("ContentHtml"))
    '    request.AddParameter("attachment", row.Item("RawSource"))
    '    request.AddParameter("o:tracking", "yes")
    '    request.Method = Method.POST
    '    Return client.Execute(request)
    '    'Next row
    'End Function

End Class