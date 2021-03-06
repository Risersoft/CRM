﻿Imports Newtonsoft.Json
Imports risersoft.shared
Imports risersoft.app.mxent
Imports risersoft.shared.dal
Imports risersoft.shared.dotnetfx

Public Class Import_LeadTaskProvider
    Inherits ImportTaskProviderFileBase

    Public Sub New(controller As clsAppController)
        MyBase.New(controller)
    End Sub

    Public Overrides Property DocType As String = "LEAD"

    Public Overrides Property TemplateName As String = "Lead"
    Public Overrides Property TemplateFunctionName As String = ""

    Public Overrides Property DocName As String = "Lead"

    Public Overrides Async Function TryImportRowGroup(provider As IAppDataProvider, objGroup As clsRowGroup, objPortion As clsPortionInfo) As Task(Of clsProcOutput)
        Dim dic As New clsCollecString(Of DataRow)
        Dim oRet = Await Me.HandleGroupData(provider, objGroup, objPortion)
        Dim info As New ImportErrorInfo()
        If oRet.WarningCount > 0 Then info.Voucher.AddWarning(Me.DocumentExistsErrorCode, oRet.WarningMessage)
        'Have a new dataset ready for data to be saved from database and copy level 1 and level 2 rows into it
        Dim dsDB = oRet.Data
        Dim rVouch = dsDB.Tables(0).Select()(0)

        If objGroup.Rows.Count > 1 Then
            oRet.AddError("Multiple Records found from Same Lead")
            info.Voucher.AddError(Me.PreValidationErrorCode, "Multiple Records found from Same Lead")
            Me.UpdateError(objGroup.Rows, info.Voucher)
        Else
            'Do the pre-operations, like getting IDs
            oRet = Me.ExecutePreValidation(provider, rVouch, dsDB.Tables("lead"), objGroup.Rows(0), objGroup)
            If oRet.Success Then

                Me.RunValidator(info, objGroup.Rows, rVouch, dsDB, "", Sub(obj, rItem)
                                                                           If rItem Is Nothing Then
                                                                               For Each kvp In dic
                                                                                   obj.AddOrUpdateRow(kvp.Value, kvp.Key)
                                                                               Next
                                                                           End If
                                                                       End Sub)
                If info.Errorcount = 0 Then
                    'If all OK, go ahead and save. If not OK, add validation errors obtained to a new error datatable with same schema as ds, but with Validation and Warning columns.
                    Dim VouchDescrip = "Lead Source " & rVouch("LeadSource") & ""
                    Try
                        provider.dbConn.BeginTransaction(myContext, Me.GetType.Name, EnumfrmMode.acAddM, "ID")

                        provider.objSQLHelper.SaveResults(dsDB.Tables("lead"), objGroup.dicSQL("lead"), dicOpInfo("lead"))

                        provider.dbConn.CommitTransaction(VouchDescrip, rVouch("LeadSource").ToString)
                    Catch ex As Exception
                        oRet.AddException(ex)
                        provider.dbConn.RollBackTransaction(VouchDescrip, ex.Message, False)
                        Dim obj = info.Voucher.AddException(Me.DatabaseTransactionErrorCode, ex)
                        Me.UpdateError(objGroup.Rows, info.Voucher)
                    End Try

                Else
                    If Not Me.ImportFileID = Guid.Empty Then
                        Dim nr = Me.CreateFileVouchRow(objPortion, rVouch, dsDB, objGroup, info, Sub(x)
                                                                                                     x("vouchnum") = rVouch("Aadhar")
                                                                                                 End Sub)
                    End If
                    oRet.AddError(info.ErrorDescripTot)
                End If

            Else
                oRet.AddError("Unforeseen error in pre validation")
                info.Voucher.AddError(Me.PreValidationErrorCode, "Unforeseen error in pre validation")
                Me.UpdateError(objGroup.Rows, info.Voucher)
            End If

        End If

        Return oRet

    End Function

    Public Overrides Function ExecutePreValidation(provider As IAppDataProvider, rVouch As DataRow, dtItems As DataTable, rXL As DataRow, objGroup As clsRowGroup) As clsProcOutput
        Dim oRet As New clsProcOutput
        'Conversion of lookup values

        Try

            rVouch("SmsOptIn") = If(rXL.Table.Columns.Contains("SmsOptIn") AndAlso
                myUtils.IsInList(myUtils.cStrTN(rXL("SmsOptIn")), "yes", "y"), "Yes", "No")

            'Title, Source, Status
            For Each str1 As String In New String() {"salutation", "leadsource", "status"}
                Dim rrPOS() As DataRow = dsMaster.Tables(str1).Select("Descrip='" & myUtils.cStrTN(rXL(str1)) & "'")
                If rrPOS.Length > 0 Then
                    rVouch(str1) = rrPOS(0)("codeword")
                Else
                    rVouch(str1) = DBNull.Value
                End If
            Next

        Catch ex As Exception
            oRet.AddException(ex)

        End Try
        Return oRet
    End Function

    Public Overrides Async Function ExecuteServer(rTask As DataRow, input As clsProcOutput) As Task(Of clsProcOutput)
        Dim Params = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(myUtils.cStrTN(rTask("infojson")))
        Dim path = Await myFuncs.DownloadIfReqd(myContext, rTask, Params("path"))
        Dim oRet = Await Me.ExecuteImport(path, myUtils.cStrTN(rTask("username")), myUtils.cStrTN(rTask("importfileid")))
        Return oRet
    End Function

    Protected Overrides Function GenerateSQL(provider As IAppDataProvider, objGroup As clsRowGroup, objPortion As clsPortionInfo) As clsCollecString(Of String)
        Dim dicSQL As New clsCollecString(Of String)
        Dim rXL = objGroup.Rows(0)
        Dim Email1 As String = myUtils.cStrTN(rXL("Email1")).Replace("'", "")
        Dim strf1 As String = myUtils.CombineWhere(False, "Email1='" & Email1 & "'")

        dicSQL.Add("lead", "select * from Lead where " & strf1 & "")

        Return dicSQL

    End Function

    Protected Overrides Function HandleGroupData(provider As IAppDataProvider, objGroup As clsRowGroup, objPortion As clsPortionInfo) As Task(Of clsProcOutput)
        Dim oRet As New clsProcOutput
        Dim rXL = objGroup.Rows(0)
        objGroup.dicSQL.Clear()
        Dim dic2 = Me.GenerateSQL(provider, objGroup, objPortion)
        dic2.CopyTo(objGroup.dicSQL)

        Dim Email1 As String = myUtils.cStrTN(rXL("Email1")).Replace("'", "")
        Dim dsDB = provider.objSQLHelper.ExecuteDataset(CommandType.Text, objGroup.dicSQL)
        Me.CheckAddOpInfo(provider, objGroup.dicSQL)

        Dim rr1() As DataRow = dsDB.Tables("lead").Select("Email1='" & Email1 & "'")

        Dim rLead As DataRow
        'Lead Import
        If rr1.Length > 0 Then
            rLead = rr1(0)
        Else
            rLead = myContext.Tables.AddNewRow(dsDB.Tables("lead"))
            rLead("LeadSourceDescrip") = rXL("LeadSourceDescrip")
            rLead("Department") = rXL("Department")
            rLead("ReferedBY") = rXL("ReferedBY")
            rLead("FirstName") = rXL("FirstName")
            rLead("LastName") = rXL("LastName")
            rLead("PhoneWork") = rXL("PhoneWork")
            rLead("PhoneMobile") = rXL("PhoneMobile")
            rLead("PhoneHome") = rXL("PhoneHome")
            rLead("PhoneOther") = rXL("PhoneOther")
            rLead("PhoneFax") = rXL("PhoneFax")
            rLead("StatusDescrip") = rXL("StatusDescrip")
            rLead("Email1") = rXL("Email1")
            rLead("Email2") = rXL("Email2")
            rLead("Website") = rXL("Website")
            rLead("PrimaryAddressStreet") = rXL("PrimaryAddressStreet")
            rLead("PrimaryAddressCity") = rXL("PrimaryAddressCity")
            rLead("PrimaryAddressState") = rXL("PrimaryAddressState")
            rLead("PrimaryAddressPostalCode") = rXL("PrimaryAddressPostalCode")
            rLead("PrimaryAddressCountry") = rXL("PrimaryAddressCountry")
            rLead("AltAddressStreet") = rXL("AltAddressStreet")
            rLead("AltAddressCity") = rXL("AltAddressCity")
            rLead("AltAddressState") = rXL("AltAddressState")
            rLead("AltAddressPostalCode") = rXL("AltAddressPostalCode")
            rLead("AltAddressCountry") = rXL("AltAddressCountry")
            rLead("AssignUserID") = rXL("AssignUserID")
            rLead("AssignTeamID") = rXL("AssignTeamID")
            rLead("AssignUserSetID") = rXL("AssignUserSetID")
            rLead("Description") = rXL("Description")
        End If


        oRet.Data = dsDB
        Return Task.FromResult(oRet)
    End Function

    Protected Overrides Function GenerateFilter() As String
        Return "isnull(leadsource,'')<>''"
    End Function

    Protected Overrides Sub PopulateErrorFile(importer As ISSGImport, ds As DataSet, dtErrorFinal As DataTable)
        MyBase.PopulateErrorFile(importer, ds, dtErrorFinal)
        'importer.CopyData("UserAssignment", ds.Tables("UserAssignment"), 1, "dd/MM/yyyy", AddressOf DateFromString)

    End Sub

    Protected Overrides Function UniqueFieldList(DocType As String, TableName As String) As List(Of String)
        Dim lst1 As New List(Of String)
        Select Case DocType.Trim.ToLower
            Case "lead"
                lst1 = New List(Of String)(New String() {"leadsource"})

        End Select
        Return lst1
    End Function

    Public Overrides Sub PopulateMaster()
        oMaster.GetDataset2(False)

        Dim dicSQL As New clsCollecString(Of String)
        dicSQL.Add("salutation", myFuncsBase.CodeWordSQL("title", "salutation", ""))
        dicSQL.Add("leadsource", myFuncsBase.CodeWordSQL("source", "leadsource", ""))
        dicSQL.Add("status", myFuncsBase.CodeWordSQL("status", "status", ""))

        dsMaster = myContext.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dicSQL)

    End Sub

    Public Overrides Sub AddRecord(info As FileImportInfo, objGroup As clsRowGroup)
        info.AddRecord(myUtils.cStrTN(objGroup.Rows(0)("leadsource")), objGroup.Rows.Count, objGroup.Output.Success)

    End Sub

    Protected Overrides Function BuildFileUrl(authority As String, rootFile As String, currFile As String) As String
        Throw New NotImplementedException()
    End Function

    'Public Overrides Function PostProcess(oRet As clsProcOutput, dtErrorList As List(Of DataTable), filePath As String, userName As String, ImpInfo As FileImportInfo) As Task
    '    oRet.Data = New DataSet
    '    For Each dt1 In dtErrorList
    '        myUtils.AddTable(oRet.Data, dt1, dt1.TableName)
    '    Next
    '    oRet.Description = JsonConvert.SerializeObject(ImpInfo)
    '    Return Task.CompletedTask
    'End Function

    Protected Overrides Function CreateData(provider As IAppDataProvider, Groups As List(Of clsRowGroup), objPortion As clsPortionInfo) As Task(Of Boolean)
        Throw New NotImplementedException()
    End Function
End Class
