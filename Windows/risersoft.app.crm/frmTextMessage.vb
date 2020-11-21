Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmTextMessage
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTextMessageModel = Me.InitData("frmTextMessageModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            myWinSQL.AssignCmb(Me.dsCombo, "FromNum", "", Me.cmb_OutBoundSMSID)
            myWinSQL.AssignCmb(Me.dsCombo, "Parent", "", Me.cmb_PIDValue,,, 1)
            Me.cmb_PIDField.ValueList = Me.Model.ValueLists("PIDField").ComboList

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
            If Me.CanSave() Then
                If Me.SaveModel() Then
                    Return True
                End If
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

    Private Sub btnSelectToNum_Click(sender As Object, e As EventArgs) Handles btnSelectToNum.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PersIDCSV", myUtils.MakeCSV(",", "0", myUtils.cStrTN(myRow("ToID"))), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("tonumber", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim strNameCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToName")), myUtils.MakeCSV(rr, "FullName"))
            Dim strNumberCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToNumber")), myUtils.MakeCSV(rr, "PrPhone"))
            Dim strIDCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToID")), myUtils.MakeCSV(rr, "PersonID"))
            Dim strToCSV As String = txt_ToDescription.Value
            For Each r1 As DataRow In rr
                strToCSV = myUtils.MakeCSV(",", strToCSV, r1("fullname") & "<" & r1("PrPhone") & ">")
            Next

            txt_ToDescription.Value = strToCSV
            myRow("ToName") = strNameCSV
            myRow("ToNumber") = strNumberCSV
            myRow("ToID") = strIDCSV

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

    Private Sub btnDeleteMessage_Click(sender As Object, e As EventArgs) Handles btnDeleteMessage.Click
        If MsgBox("Are you sure you want to delete this Text Message", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

    Private Sub cmb_OutBoundSMSID_Leave(sender As Object, e As EventArgs) Handles cmb_OutBoundSMSID.Leave, cmb_OutBoundSMSID.AfterCloseUp
        If Not myUtils.NullNot(cmb_OutBoundSMSID.Value) Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_OutBoundSMSID.SelectedRow)
            Dim str1 As String = r1("Name") + "<" + r1("FromNumber") + ">"
            txt_FromNumber.Value = str1
            myRow("FromNumber") = r1("FromNumber")
        End If
    End Sub

End Class
