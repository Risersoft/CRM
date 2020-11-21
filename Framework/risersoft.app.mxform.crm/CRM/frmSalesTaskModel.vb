Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization

<DataContract>
Public Class frmSalesTaskModel
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

        sql = "Select UserID, UserName from genlistuser() where insaleslist=1 and isdeleted=0 order by UserName"
        Me.AddLookupField("AssignUserID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "User").TableName)

        sql = "Select TeamID, Name from Team order by Name"
        Me.AddLookupField("AssignTeamID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Team").TableName)

        sql = "Select UserID, UserName from genlistuser() where insaleslist=1 and isdeleted=0 order by UserName"
        Me.AddLookupField("ReviewUserID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Review").TableName)

        sql = "Select PersonID, FullName from genlistPersons() order by PersonID"
        Me.AddLookupField("PersonID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Person").TableName)

        Dim vlist1 As New clsValueList
        vlist1.Add("Not Started", "Not Started")
        vlist1.Add("In Progress", "In Progress")
        vlist1.Add("Completed", "Completed")
        vlist1.Add("Pending Input", "Pending Input")
        vlist1.Add("Deferred", "Deferred")
        Me.ValueLists.Add("Status", vlist1)
        Me.AddLookupField("Status", "Status")

        Dim vlist2 As New clsValueList
        vlist2.Add("High", "High")
        vlist2.Add("Medium", "Medium")
        vlist2.Add("Low", "Low")
        Me.ValueLists.Add("Priority", vlist2)
        Me.AddLookupField("Priority", "Priority")

        Dim vlist3 As New clsValueList
        vlist3.Add("LeadID", "Lead")
        vlist3.Add("SalesCaseID", "SalesCase")
        vlist3.Add("OpportunityID", "Opportunity")
        vlist3.Add("CampaignID", "Campaign")
        vlist3.Add("CustomerID", "Customer")
        vlist3.Add("PersonID", "Person")
        Me.ValueLists.Add("PIDField", vlist3)
        Me.AddLookupField("PIDField", "PIDField")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from SalesTask Where SalesTaskID = " & prepIDX
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
        Me.myView.MainGrid.PrepEdit(str2, EnumEditType.acCommandOnly)

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function


    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Subject")
        If Me.SelectedItem("Priority") Is Nothing Then Me.AddError("Priority", "Please Select Priority")
        If Me.SelectedItem("Status") Is Nothing Then Me.AddError("Status", "Please Select Status")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then

            If myRow("Status") = "CLOSE" Then
                If myUtils.NullNot(myRow("completedon")) Then myRow("completedon") = Now
            Else
                myRow("completedon") = DBNull.Value
            End If

            If frmMode = EnumfrmMode.acEditM Then
                Dim sql As String = "select SalesTaskID from SalesTask left Join userset on SalesTask.AssignUserSetID = Userset.UserSetID where dbo.fncCRMVisible('" & myContext.Police.UniqueUserID & "', AssignUserID, SalesTask.CreatedByID, ReviewUserID, AssignTeamID, UserSet.UserSetList)= 1"
                Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count = 0 Then Me.AddError("", "Don't Have Permission to Save")
            End If

            If Me.CanSave Then
                Dim TaskDescrip As String = " Name: " & myUtils.cStrTN(myRow("Name")) & ", Parent: " & myUtils.cStrTN(myRow("PIDField")) & ""
                Try
                    myRow("ContentHTML") = mxengg.BucketUtility.TryBase64Decode(myUtils.cStrTN(myRow("ContentHTML")))

                    If myView.MainGrid.myDS.Tables(0).Select.Length > 0 Then
                        myRow("AssignUserSetID") = myUtils.cValTN(myFuncs.GetUserSetID(myContext, myView.MainGrid.myDS.Tables(0)))
                    Else
                        myRow("AssignUserSetID") = DBNull.Value
                    End If

                    Dim UserIDCSV As String = myUtils.cStrTN(myFuncs.GetUserIDCSV(myContext, myUtils.cValTN(myRow("AssignTeamID")), myView.MainGrid.myDS.Tables(0), Nothing, myUtils.cStrTN(myRow("AssignUserID"))))
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "SalesTaskID", frmIDX, UserIDCSV)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)

                    'myView.MainGrid.SaveChanges(, "SalesTaskID=" & frmIDX)
                    frmMode = EnumfrmMode.acEditM

                    frmIDX = myRow("SalesTaskID")
                    myContext.Provider.dbConn.CommitTransaction(TaskDescrip, frmIDX)
                    VSave = True
                Catch ex As Exception
                    myContext.Provider.dbConn.RollBackTransaction(TaskDescrip, ex.Message)
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
                Case "assignuser"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in ('@AssignUserID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "assignteam"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("TeamID not in ('@AssignTeamID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""TeamID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "reviewuser"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in ('@ReviewUserID')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", False,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

                Case "userset"
                    Dim str1 As String = myContext.SQL.PopulateSQLParams("UserID not in (@UserIDcsv)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""UserID""/>", True,, "<MODROW><SQLWHERE2>" & str1 & "</SQLWHERE2></MODROW>")

            End Select
        End If
        Return Model
    End Function

End Class



