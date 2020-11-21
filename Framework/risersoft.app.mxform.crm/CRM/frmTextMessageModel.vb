Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
Imports risersoft.shared.cloud.common
Imports risersoft.shared.cloud
Imports System.Configuration
Imports System.IO

<DataContract>
Public Class frmTextMessageModel
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

        sql = "Select OutBoundSMSID, Name, FromNumber from OutBoundSMS order by OutBoundSMSID"
        Me.AddLookupField("OutBoundSMSID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "FromNum").TableName)

        sql = "Select PersonID, FullName + ' | ' + PrPhone from genlistPersons() order by PersonID"
        Me.AddLookupField("ToNumber", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "ToNum").TableName)

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
        sql = "Select * from TextMessage Where TextMessageID = " & prepIDX
        Me.InitData(sql, "IDValue,IDField", oView, prepMode, prepIDX, strXML)

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
        'Me.myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)
        Me.myView.MainGrid.PrepEdit(str2, EnumEditType.acCommandOnly)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function


    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("OutBoundSMSID") Is Nothing Then Me.AddError("OutBoundSMSID", "Please select From Number")
        If myUtils.NullNot(myRow("ToNumber")) Then Me.AddError("ToNumber", "Please select To Number")
        If myUtils.cStrTN(myRow("Content")).Trim.Length = 0 Then Me.AddError("Content", "Enter Message")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select TextMessageID from TextMessage left Join userset on TextMessage.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, TextMessage.CreatedByID, '00000000-0000-0000-0000-000000000000', AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim MessageDescrip As String = " Description: " & myUtils.cStrTN(myRow("ToDescription"))
                Try
                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "TextMessageID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    ' myView.MainGrid.SaveChanges(, "TextMessageID=" & frmIDX)

                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("TextMessageID")
                    myContext.Provider.dbConn.CommitTransaction(MessageDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(MessageDescrip, ex.Message)
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

                Case "tonumber"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("Select PersonID, FullName, PrPhone from genListPersons() where PersonID Not in (@PersIDCSV) and PrPhone <> ''", Params)
                    Model = New clsViewModel(vwState, myContext)
                    Model.Mode = EnumViewMode.acSelectM : Model.MultiSelect = True
                    Model.MainGrid.QuickConf(sql, True, "1-1")
                    Model.MainGrid.PrepEdit("", EnumEditType.acEditOnly)

            End Select
        End If
        Return Model
    End Function

    ' Sending Text Message
    Public Overrides Function GenerateIDOutput(dataKey As String, ID As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "message"
                Dim sql As String = "Select TextMessageID, ToNumber, Content,AttachmentJson from TextMessage where TextMessageID=" & myUtils.cValTN(ID)
                oRet.Data = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
                Dim row As DataRow = oRet.Data.Tables(0).Rows(0)
                Dim numbers = row.Item("ToNumber").ToString()
                'Dim Attachments = row.Item("AttachmentJson").ToString()
                'If Not IsDBNull(row.Item("AttachmentJson")) Then

                'End If
                'Dim Filenames() As String = Split(Attachments, ",")

                'For index As Integer = 0 To Filenames.Length - 1
                '    Dim provider As New clsBlobFileProvider(myContext)
                '    Dim oRet2 = provider.GetDownloadUri(ConfigurationManager.AppSettings("StorageContainerName"), Filenames(index))
                '    If oRet2.Success Then
                '        Filenames(index) = oRet2.Result.Uri.ToString()
                '    Else
                '        Filenames(index) = ""
                '    End If
                'Next


                Dim ArrData() As String = Split(numbers, ",")
                Dim count = ArrData.Length
                Dim ArrDetail(count) As String
                Dim SID As String = ""
                Dim cred = myContext.Controller.CalcEnv.GetCred("twilio", "sms")
                For index As Integer = 0 To ArrData.Length - 1
                    If Not String.IsNullOrEmpty(ArrData(index)) Then
                        ArrDetail(index) = TwilioSMS.sendSMS(cred, ArrData(index), row.Item("Content")).Description.ToString()
                        If Not String.IsNullOrEmpty(ArrDetail(index)) Then
                            If String.IsNullOrEmpty(SID) Then
                                SID = ArrDetail(index)
                            Else
                                SID = SID + "," + ArrDetail(index)
                            End If
                        End If
                    End If
                Next
                If Not String.IsNullOrEmpty(SID) Then
                    Dim sql1 As String = "update TextMessage set MessagesSID= '" & SID & "', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where TextMessageID =" & myUtils.cValTN(ID)
                    myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql1)
                End If

        End Select
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

