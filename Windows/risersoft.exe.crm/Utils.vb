Imports risersoft.app.shared
Imports risersoft.shared.win
Imports risersoft.app.accounts
Imports risersoft.shared
Imports risersoft.app2.shared
Imports risersoft.shared.DotnetFx
Imports risersoft.app.mxform.crm

Public Class Utils
    Public Shared Sub Main(ByVal args() As String)
        myApp = New clsRSWinCloudApp(New clsExtendAppCRM)
        myWinApp.CheckInitConsole(args)
        Dim fMain As frmMax = AppStarter.StartWinFormApp(args)
        If Not fMain Is Nothing Then

            'TestImportLead()

            Application.Run(fMain)
        End If
    End Sub
    Private Shared Sub TestImportLead()
        Dim importer As New Import_LeadTaskProvider(myApp.Controller)
        importer.ExecuteImport("E:\CRMNirvana Import Test Files\Lead.xlsx", "info@risersoft.com", Guid.NewGuid.ToString)
    End Sub

End Class
