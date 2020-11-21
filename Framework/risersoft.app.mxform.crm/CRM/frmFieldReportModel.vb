Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.shared.cloud
Imports System.Configuration
Imports System.IO

<DataContract>
Public Class frmFieldReportModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ItemList")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "Select UserID, FullName from genListUser() where (InSalesList = 1 or InQualityList = 1) order by FullName"
        Me.AddLookupField("AttendedByID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        '-------------NC Item--------------
        sql = "Select StatusNum,statusText from Status where StatusType='NC' order by StatusNum"
        Me.AddLookupField("StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = "Select Distinct NCCat as NCCat1, NCCat from ProdNCCat order by NCCat"
        Me.AddLookupField("NCCat", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "NCCat").TableName)

        sql = "Select ProdNCCatId, NCSubCat, NCCat from ProdNCCat order by NCSubCat"
        Me.AddLookupField("ProdNCCatId", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "NCSubCat").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim Sql As String
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Sql = "Select * from FieldReport Where FieldReportId=" & myUtils.cValTN(prepIDX)
        Me.InitData(Sql, "PIDUnitID", oView, prepMode, prepIDX, strXML)

        If frmMode = EnumfrmMode.acAddM Then
            myRow("ReportDate") = Now.Date
            myRow("DefectDate") = Now.Date
            myRow("AttendDate") = Now.Date
        End If

        Sql = "Select ProdSerialID,ProdSerialnum,DispatchedOn,CommissionedOn from PlnListProdSerial() where PidUnitId=" & myUtils.cValTN(myRow("PidUnitId")) & " order by ProdSerialNum"
        Me.AddLookupField("ProdSerialID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Serial").TableName)


        myView.MainGrid.QuickConf("Select FieldReportItemID,FieldReportID, Findings, ProdNCCatID, EstimatedReasons, ActionTaken,Suggestions, PrevenAction,StatusNum from FieldReportItem  where FieldReportId=" & myUtils.cValTN(frmIDX), True, "2-2-1-2-2-2-1", True, "Items")
        myView.MainGrid.PrepEdit("<BAND TABLE=""FieldReportItem"" IDFIELD=""FieldReportItemID""  INDEX=""0""><COL KEY=""FieldReportID,Findings, EstimatedReasons, ActionTaken,Suggestions, PrevenAction""/><COL NOEDIT=""True"" KEY=""ProdNCCatId"" LOOKUPSQL=""select ProdNCCatId, NCCat + '-' + NCSubCat as Cat from ProdNCCat order by ProdNCCatId"" CAPTION=""Category""></COL><COL NOEDIT=""True"" KEY=""StatusNum"" LOOKUPSQL=""Select StatusNum,StatusText from Status Where StatusType = 'NC'"" CAPTION=""Status""/></BAND>", EnumEditType.acCommandOnly)
        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If myUtils.cStrTN((Me.myRow("Place"))).Trim.Length = 0 Then Me.AddError("Place", "Please Enter Place")
        If Me.SelectedRow("AttendedByID") Is Nothing Then Me.AddError("AttendedByID", "Please Select User")
        If Me.myView.MainGrid.myDS.Tables(0).Select.Length = 0 Then Me.AddError("", "Please Enter Some Transactions")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim FieldReportDescrip As String = " Field Report No: " & myRow("ReportNum").ToString & " Dt. " & Format(myRow("ReportDate"), "dd-MMM-yyyy") & " Place: " & myRow("Place").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "FieldReportID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from FieldReport where FieldReportID = " & frmIDX & "")
                frmIDX = myRow("FieldReportID")

                Me.myView.MainGrid.SaveChanges(, "FieldReportID=" & frmIDX)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(FieldReportDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(FieldReportDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function


    Public Overrides Function GenerateParamsOutput(dataKey As String, Params As List(Of clsSQLParam)) As clsProcOutput

        Dim filenames As String = myUtils.cStrTN(myContext.SQL.ParamValue("@filename", Params))
        Dim frmid As String = myUtils.cStrTN(myContext.SQL.ParamValue("@frid", Params))

        Dim _NewFileName = "/NC" + "\NC_" + "_" + frmid + "" + Path.GetExtension(filenames)


        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "sas"
                Dim provider As New clsBlobFileProvider(myContext)

                Dim oRet2 = provider.CreateUploadUri(ConfigurationManager.AppSettings("StorageContainerName"), _NewFileName, "") '.Result

                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString, .flName = _NewFileName}
                Else

                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If


            Case "download"

                Dim sql As String = String.Empty

                sql = "select PDFSource from FieldReport where FieldReportID='" + frmid.ToString + "'"
                Dim dsfileName = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Dim filename As String = dsfileName.Tables(0).Rows(0).Item("PDFSource").ToString()
                Dim provider As New clsBlobFileProvider(myContext)
                Dim oRet2 = provider.GetDownloadUri(ConfigurationManager.AppSettings("StorageContainerName"), filename)
                ' Dim oRet2 = provider.CreateUploadUri(ConfigurationManager.AppSettings("nc"), _NewFileName, "")
                If oRet2.Success Then
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message, .Data = oRet2.Result.Uri.ToString, .flName = _NewFileName}
                Else
                    'oRet.AddError("Cannot Create")
                    oRet.JsonData = New With {.status = 200, .success = oRet.Success, .message = oRet.Message} '"Unable to upload file."
                End If

        End Select

        Return oRet
    End Function


    '<Authorize> <HostActionFilter> <HttpGet> <ActionName("Downloads")>
    'Public Async Function DownloadFile(id As Guid, fileId As String) As Task(Of JsonResult)
    '    Dim fileProvider As New clsBlobFileProvider(Me.myWebController)
    '    Dim result As New JsonResult()
    '    If Await Me.myWebController.CheckInitModel(Me.myWebController.AppInfo, True) Then
    '        Try
    '            Dim sql As String = String.Empty
    '            If fileId = "err" Then
    '                sql = "select ErrorFileURL as FileURL from ImportFile where ImportFileId='" + id.ToString + "'"
    '            ElseIf fileId = "apitask" Then
    '                sql = "select FileName as FileURL from ApiTask where ApiTaskID='" + id.ToString + "'"
    '            Else
    '                sql = "select FileName as FileURL from ImportFile where ImportFileId='" + id.ToString + "'"
    '            End If
    '            Dim dsfileName = myWebController.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
    '            Dim FileUrl2 = fileProvider.GetDownloadUri(ConfigurationManager.AppSettings("StorageContainerName"), dsfileName(0)("FileURL"))
    '            result.Data = New With {.status = 200, .success = True, .message = "", .data = FileUrl2.Result.Uri().ToString()}
    '        Catch ex As Exception
    '            result.Data = New With {.status = HttpStatusCode.InternalServerError, .message = ex.Message, .success = False}
    '        End Try
    '        result.JsonRequestBehavior = JsonRequestBehavior.AllowGet
    '    End If
    '    Return result
    'End Function

End Class
