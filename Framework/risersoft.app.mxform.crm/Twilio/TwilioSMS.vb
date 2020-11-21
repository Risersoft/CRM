Imports System
Imports System.IO
Imports risersoft.shared
Imports risersoft.shared.portable.Models.Publisher
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account

Public Class TwilioSMS
    Public Shared Function sendSMS(cred As PublisherCredInfo, strTo As String, strBody As String) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            ' Find your Account Sid and Auth Token at twilio.com/user/account
            Dim AccountSid As String = cred.SecurityId ' "ACf7f763f7e196e5e9d75263480b057327"
            Dim AuthToken As String = cred.AuthToken ' "87ffc83a789b9af0fb673b5930a57ecd"
            TwilioClient.Init(AccountSid, AuthToken)
            Dim strFrom As String = "+" & cred.FromNumber ' "+16692315980"


            Dim message
            message = MessageResource.Create(
           body:=strBody,
           from:=New Twilio.Types.PhoneNumber(strFrom),
           to:=New Twilio.Types.PhoneNumber(strTo)
           )


            Trace.WriteLine(message.Sid)
            oRet.Description = message.Sid


            'https://github.com/twilio/twilio-csharp/issues/126
            'If Not message.RestException Is Nothing Then
            '    Dim msgError As String = message.RestException.Message
            '    Trace.WriteLine(msgError)
            'End If
        Catch ex As Exception
            oRet.AddException(ex)
            Trace.WriteLine(ex.Message)
        End Try
        Return oRet
    End Function


End Class
