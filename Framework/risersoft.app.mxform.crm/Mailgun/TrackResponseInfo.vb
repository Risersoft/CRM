Imports Newtonsoft.Json

Partial Public Class TrackResponseInfo
    Public Property Items As List(Of Item)
    Public Property Paging As Paging
End Class

Partial Public Class Item
    Public Property Severity As String
    Public Property Tags As List(Of Object)
    Public Property Id As String
    Public Property Geolocation As Geolocation
    <JsonProperty("Client-Info")>
    Public Property ClientInfo As ClientInfo
    Public Property Envelope As Envelope
    Public Property DeliveryStatus As DeliveryStatus
    Public Property Campaigns As List(Of Object)
    Public Property Reason As String
    Public Property UserVariables As UserVariables
    Public Property Flags As Flags
    Public Property Timestamp As Double
    Public Property Message As Message
    Public Property Recipient As String
    Public Property [Event] As String
End Class

Partial Public Class Geolocation
    Public Property Country As String
    Public Property Region As String
    Public Property City As String
End Class


Partial Public Class ClientInfo
    <JsonProperty("Device-type")>
    Public Property Devicetype As String
    <JsonProperty("Client-os")>
    Public Property Clientos As String
    <JsonProperty("Client-type")>
    Public Property Clienttype As String
    <JsonProperty("Client-name")>
    Public Property Clientname As String
    <JsonProperty("User-agent")>
    Public Property Useragent As String
End Class

Partial Public Class DeliveryStatus
    Public Property Code As Long
    Public Property Message As String
    Public Property RetrySeconds As Long
    Public Property Description As String
End Class

Partial Public Class Envelope
    Public Property Sender As String
    Public Property Transport As String
End Class

Partial Public Class Flags
    Public Property IsAuthenticated As Boolean
    Public Property IsTestMode As Boolean
End Class

Partial Public Class Message
    Public Property Headers As Headers
    Public Property Attachments As List(Of Object)
    Public Property Recipients As List(Of String)
    Public Property Size As Long
End Class

Partial Public Class Headers
    Public Property [To] As String
    Public Property MessageId As String
    Public Property From As String
    Public Property Subject As String
End Class

Partial Public Class UserVariables
End Class

Partial Public Class Paging
    Public Property [Next] As Uri
    Public Property Previous As Uri
End Class
