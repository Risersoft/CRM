Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmMeeting
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMeetingModel = Me.InitData("frmMeetingModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            myWinSQL.AssignCmb(Me.dsCombo, "Parent", "", Me.cmb_PIDValue,,, 1)
            Me.cmb_PIDField.ValueList = Me.Model.ValueLists("PIDField").ComboList
            Me.cmb_ReminderTime.ValueList = Me.Model.ValueLists("ReminderTime").ComboList
            Me.cmb_EmailReminderTime.ValueList = Me.Model.ValueLists("ReminderTime").ComboList
            Me.cmb_SMSReminderTime.ValueList = Me.Model.ValueLists("ReminderTime").ComboList
            Me.cmb_Status.ValueList = Me.Model.ValueLists("Status").ComboList
            Me.cmb_RepeatType.ValueList = Me.Model.ValueLists("RepeatType").ComboList

            Me.chk_IsReminder.Checked = True

            Dim str1 As String = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("RepeatDow")))
            LoadDOW(str1)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Team"),, btnDeleteTeam)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            Me.PopulateDOW()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnAssignUser_Click(sender As Object, e As EventArgs) Handles btnAssignUser.Click
        Dim Params As New List(Of clsSQLParam), rr() As DataRow
        If myUtils.NullNot(myRow("AssignUserID")) Then
            Dim str1 As String = "00000000-0000-0000-0000-000000000000"
            Params.Add(New clsSQLParam("@AssignUserID", str1, GetType(Guid), True))
        Else
            Params.Add(New clsSQLParam("@AssignUserID", myUtils.cStrTN(cmb_AssignUserID.Value), GetType(Guid), True))
        End If
        rr = Me.AdvancedSelect("assignuser", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cmb_AssignUserID.Value = Guid.Parse(myUtils.cStrTN(rr(0)("UserID")))
        End If
    End Sub

    Private Sub btnClearUser_Click(sender As Object, e As EventArgs) Handles btnClearUser.Click
        myRow("AssignUserID") = DBNull.Value
        cmb_AssignUserID.Value = ""
    End Sub

    Private Sub btnAddTeam_Click(sender As Object, e As EventArgs) Handles btnAddTeam.Click
        Dim Params As New List(Of clsSQLParam)
        Dim str1 As String = myUtils.MakeCSV(myView.mainGrid.myDS.Tables(0).Select, "UserID", ",", "'00000000-0000-0000-0000-000000000000'", True)
        Params.Add(New clsSQLParam("@UserIDcsv", str1, GetType(Guid), True))
        Dim rr() As DataRow = Me.AdvancedSelect("userset", Params)

        If Not IsNothing(rr) Then
            For Each r2 As DataRow In rr
                Dim r3 As DataRow = myUtils.CopyOneRow(r2, myView.mainGrid.myDS.Tables(0))
            Next
        End If

    End Sub

    Private Sub btnAssignTeam_Click(sender As Object, e As EventArgs) Handles btnAssignTeam.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@AssignTeamID", myUtils.cValTN(cmb_AssignTeamID.Value), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("assignteam", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cmb_AssignTeamID.Value = myUtils.cValTN(rr(0)("Teamid"))
        End If
    End Sub

    Private Sub btnClearTeam_Click(sender As Object, e As EventArgs) Handles btnClearTeam.Click
        myRow("AssignTeamID") = DBNull.Value
        cmb_AssignTeamID.Value = ""
    End Sub

    Private Sub btnDeleteMeeting_Click(sender As Object, e As EventArgs) Handles btnDeleteMeeting.Click
        If MsgBox("Are you sure you want to delete this Meeting", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

    Private Sub chk_IsReminder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_IsReminder.CheckedChanged
        If myUtils.cBoolTN(Me.chk_IsReminder.Checked) Then
            Me.cmb_ReminderTime.Visible = True
        Else
            Me.cmb_ReminderTime.Visible = False
        End If
    End Sub

    Protected Friend Sub PopulateDOW()
        Dim str1 As String = ""
        For Each item In Me.checkedListBoxWeeklyDays.CheckedItems
            str1 = myUtils.MakeCSV(",", str1, item.ToString)
        Next

        myRow("RepeatDow") = str1
    End Sub

    Protected Friend Sub LoadDOW(strCSV As String)
        Dim arr() As String = Split(strCSV, ",")

        For i As Integer = 0 To Me.checkedListBoxWeeklyDays.Items.Count - 1
            Dim item = Me.checkedListBoxWeeklyDays.Items(i)
            Me.checkedListBoxWeeklyDays.SetItemChecked(i, arr.Contains(item.ToString))
        Next

    End Sub

End Class
