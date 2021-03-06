﻿Imports risersoft.shared
Imports risersoft.shared.dal
Imports risersoft.app.mxform
Imports risersoft.app.mxform.crm
Imports risersoft.shared.cloud
Imports risersoft.app.mxent
Imports risersoft.app2.shared
Imports risersoft.app.reports.erp
Imports risersoft.chrome.winforms
Imports risersoft.shared.portable.Models.Nav
Imports System.Configuration
Imports risersoft.shared.dotnetfx
Imports Microsoft.Extensions.Logging
Imports risersoft.app.config

Public Class clsExtendAppCRM
    Inherits clsExtendRsBase
    Protected Friend mFileProvider As ICloudFileProvider, mQueueProvider As IQueueProvider
    Dim dic As clsCollecString(Of Boolean)

    Public Overrides Function GetLicProductInfo() As LicProductInfo
        Return New LicProductInfo("ncrm", 1.0, "CRMNirvana.Std")
    End Function

    Public Overrides Function AboutBox() As risersoft.shared.IForm
        Return New frmAboutBox
    End Function
    Public Overrides Function StartupAppCode() As String
        Return ""
    End Function

    Public Overrides Function ProgramName() As String
        'Return "Hisaab-Kitaab"
        Return "CRMNirvana"
    End Function

    Public Overrides Function NewDBName() As String
        Return "mxentdb"
    End Function

    Public Overrides Function fBrowser() As IMxBrowser
        Dim f As New BrowserForm
        f.MakeDownLevel()
        Return f
    End Function

    Public Overrides Function MinDBVersion() As Decimal
        Return My.Settings.MinDBVersion
    End Function

    Public Overrides Function ProgramCode() As String
        Return "mxcrm"
    End Function

    Public Overrides Function LinkLabel() As String
        'Return "http://www.alankitgsp.com"
        Return "http://www.risersoft.com/books"
    End Function
    Public Overrides Function dicMat() As clsCollecString(Of Boolean)
        'TODO: ETO=Inv, once this is implemented for Max @Kanohar
        'If dic Is Nothing Then dic = myFuncs.dicMat(False, False, False, True, True, True, True, False)
        'All value False for CRM.
        If dic Is Nothing Then dic = myFuncs.dicMat(False, False, False, False, False, False, False, False)

        Return dic
    End Function

    Public Overrides Function FileServerRequired() As Boolean
        Return False
    End Function
    Public Overrides Sub UpdateSettings(s As risersoft.shared.myAppSettings)
        s.RelateLoginPerson = True
        's.AppLoadBehaviour = EnumLoadBehaviour.acForceXML
    End Sub

    Public Overrides Function GenerateDataTable(pView As clsViewModel, conf As clsBandConf, pdclientview As String, strFilter As String) As DataTable
        Dim oGen As New clsPDCViewGenerator(pView.myContext)
        Dim dt1 As DataTable = oGen.GenerateDataTable(pView, conf, pdclientview, strFilter)
        Return dt1
    End Function
    Public Overrides Function FileProviderCode(context As IProviderContext) As String
        Dim str1 As String = ""
        If ProviderFactory.IsCloudServiceClient(context.App) Then
            str1 = "blob"
        Else
            str1 = MyBase.FileProviderCode(context)
        End If

        Return str1
    End Function
    Public Overrides Function FileProviderClient(context As IProviderContext, AppCode As String, ProviderCode As String) As clsFileProviderClientBase
        Dim provider As clsFileProviderClientBase
        Select Case ProviderCode.Trim.ToLower
            Case "blob"
                If mFileProvider Is Nothing Then mFileProvider = ProviderFactory.CreateFileProvider(context)
                provider = New clsBlobFileClient(context, AppCode, mFileProvider)
            Case Else
                provider = MyBase.FileProviderClient(context, AppCode, ProviderCode)
        End Select
        Return provider
    End Function
    Public Overrides Function QueueProvider(context As IProviderContext) As IQueueProvider
        Dim setting1 As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ServiceBus")
        If (mQueueProvider Is Nothing) AndAlso (setting1 IsNot Nothing) Then mQueueProvider = New clsAzureSBQProvider(context, setting1.ConnectionString)
        Return mQueueProvider
    End Function
    Public Overrides Function CreateDataProvider(context As clsAppController, cb As IAsyncWCFCallBack) As IAppDataProvider
        Dim Provider As IAppDataProvider = ProviderFactory.CreateDataProvider(context, cb)
        Return Provider

    End Function

    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmSalesOrderModel).Assembly, GetType(clsFormDataModel))
            Me.AddTypeAssembly(dicFormModel, GetType(frmImportFileNewModel).Assembly, GetType(clsFormDataModel))

        End If
        Return dicFormModel
    End Function
    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        If dicReportModelProvider Is Nothing Then
            dicReportModelProvider = New clsCollecString(Of Type)

            Me.AddTypeAssembly(dicReportModelProvider, GetType(accReportDataProvider).Assembly, GetType(clsReportDataProviderBase))
        End If
        Return dicReportModelProvider

    End Function
    Public Overrides Function WOTabList(oWO As clsWOInfoBase) As List(Of String)
        Dim tl As New List(Of String)
        tl.Add("params")
        tl.Add("ref")
        Return tl
    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        If dicTaskProvider Is Nothing Then
            dicTaskProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicTaskProvider, GetType(EVTaskProvider).Assembly, GetType(clsTaskProviderBase))
        End If
        Return dicTaskProvider
    End Function
    Public Overrides Function CreateLogger(context As IProviderContext) As ILogger
        Return myWinUtils2.CreateLogger(context)
    End Function
End Class
