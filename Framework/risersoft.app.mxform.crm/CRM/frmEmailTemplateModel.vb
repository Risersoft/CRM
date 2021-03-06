﻿Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.shared.cloud
Imports risersoft.app.mxengg
Imports System.Configuration
Imports System.IO

<DataContract>
Public Class frmEmailTemplateModel
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

        Dim vlist As New clsValueList
        vlist.Add("crmListLead", "Lead")
        vlist.Add("crmListSalesCase", "SalesCase")
        vlist.Add("crmListOpportunity", "Opportunity")
        vlist.Add("crmListCampaign", "Campaign")
        vlist.Add("slsListCustomer", "Customer")
        vlist.Add("genListPersParty", "Person")
        Me.ValueLists.Add("Var", vlist)
        Me.AddLookupField("Var", "Var")

        sql = "select Table_Name,COLUMN_NAME From INFORMATION_SCHEMA.ROUTINE_COLUMNS where Table_Name in ('crmlistlead','crmListSalesCase','crmListOpportunity','crmListCampaign', 'slsListCustomer', 'genListPersParty')"
        myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Info")


    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from EmailTemplate Where EmailTemplateID = " & prepIDX
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
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Name")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            'myRow("contenthtml") = BucketUtility.Base64Decode(myUtils.cStrTN(myRow("contenthtml")))

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select EmailTemplateID from EmailTemplate left Join userset on EmailTemplate.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID,  EmailTemplate.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim EmailDescrip As String = " Name: " & myUtils.cStrTN(myRow("Name")) & ", Subject: " & myUtils.cStrTN(myRow("Subject"))
                Try

                    myRow("ContentHtml") = BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("ContentHtml")))
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "EmailTemplateID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    'myView.MainGrid.SaveChanges(, "EmailTemplateID=" & frmIDX)
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("EmailTemplateID")
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

            End Select
        End If
        Return Model
    End Function


    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "emailtemplate"
                        Dim sql As String = "Select * from EmailTemplate Where EmailTemplateID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update EmailTemplate set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where EmailTemplateID =" & ID
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

End Class
