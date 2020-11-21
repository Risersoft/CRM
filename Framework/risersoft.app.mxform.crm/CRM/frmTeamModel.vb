Imports risersoft.shared
Imports risersoft.app.mxent
Imports Infragistics.Win
Imports System.Runtime.Serialization

<DataContract>
Public Class frmTeamModel
    Inherits clsFormDataModel

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("Member")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1, sql As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from Team where TeamID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        sql = "Select TeamMembershipID, TeamID, UserID, ImplicitAssign, ExplicitAssign from TeamMembership where TeamID = " & frmIDX & ""
        myView.MainGrid.QuickConf(sql, True, "1-0.5-0.5", True)
        str1 = "<BAND INDEX=""0"" TABLE=""TeamMembership"" IDFIELD=""TeamMembershipID""><COL KEY=""UserID "" LOOKUPSQL = ""Select UserID, UserName from Users"" CAPTION = ""Users""/><COL KEY="" TeamID, ImplicitAssign, ExplicitAssign""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Team Name")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        If Me.Validate Then
            If Me.CanSave Then
                Dim TeamDescrip As String = " Name: " & myUtils.cStrTN(myRow("Name")) & ", Description: " & myUtils.cStrTN(myRow("Description"))
                Try
                    myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "TeamID", frmIDX)
                    myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
                    frmIDX = myRow("TeamID")
                    frmMode = EnumfrmMode.acEditM
                    myView.MainGrid.SaveChanges(, "TeamID=" & frmIDX)

                    myContext.Provider.dbConn.CommitTransaction(TeamDescrip, frmIDX)
                    VSave = True
                Catch e As Exception
                    myContext.Provider.dbConn.RollBackTransaction(TeamDescrip, e.Message)
                    Me.AddException("", e)
                End Try
            End If
        End If
        Return VSave
    End Function

    Public Overrides Function DeleteEntity(EntityKey As String, ID As Integer, AcceptWarning As Boolean) As clsProcOutput
        Dim oRet As New clsProcOutput
        Try
            If AcceptWarning Then
                Select Case EntityKey.Trim.ToLower
                    Case "team"
                        Dim sql As String = "Select * from Team Where TeamID =" & ID
                        Dim dt As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                        If dt.Rows.Count > 0 Then
                            Dim sql1 As String = "update Team set IsDeleted= 'true', ModifiedByID='" & myContext.Police.UniqueUserID & "', LastUpdated='" & DateTime.Now & "'  where TeamID =" & ID
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


End Class

