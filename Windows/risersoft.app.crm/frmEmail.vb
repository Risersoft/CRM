Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmEmail
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmEmailModel = Me.InitData("frmEmailModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            myWinSQL.AssignCmb(Me.dsCombo, "Template", "", Me.cmb_EmailTemplateID)
            myWinSQL.AssignCmb(Me.dsCombo, "Email", "", Me.cmb_OutBoundEmailID)
            myWinSQL.AssignCmb(Me.dsCombo, "Parent", "", Me.cmb_PIDValue,,, 1)
            Me.cmb_PIDField.ValueList = Me.Model.ValueLists("PIDField").ComboList

            Me.CtlRTFMailBox.HTMLText = myUtils.cStrTN(myRow("Contenthtml"))

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
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            myRow("Contenthtml") = Me.CtlRTFMailBox.HTMLText
            myRow("Content") = Me.CtlRTFMailBox.PlainText
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

    Private Sub btnSelectTo_Click(sender As Object, e As EventArgs) Handles btnSelectTo.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PersIDCSV", myUtils.MakeCSV(",", "0", myUtils.cStrTN(myRow("ToAddrsIDS"))), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("email", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim strNameCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToAddrsName")), myUtils.MakeCSV(rr, "FullName"))
            Dim strEmailCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToAddrsEmail")), myUtils.MakeCSV(rr, "Email"))
            Dim strIDCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("ToAddrsIDS")), myUtils.MakeCSV(rr, "PersonID"))
            Dim strToCSV As String = txt_ToAddrs.Value
            For Each r1 As DataRow In rr
                strToCSV = myUtils.MakeCSV(";", strToCSV, r1("fullname") & "<" & r1("email") & ">")
            Next

            txt_ToAddrs.Value = strToCSV
            myRow("ToAddrsName") = strNameCSV
            myRow("ToAddrsEmail") = strEmailCSV
            myRow("ToAddrsIDS") = strIDCSV

        End If
    End Sub

    Private Sub btnClearTO_Click(sender As Object, e As EventArgs) Handles btnClearTO.Click
        myRow("ToAddrs") = DBNull.Value
        myRow("ToAddrsName") = DBNull.Value
        myRow("ToAddrsEmail") = DBNull.Value
        myRow("ToAddrsIDS") = DBNull.Value
        txt_ToAddrs.Value = ""
    End Sub

    Private Sub btnSelectCc_Click(sender As Object, e As EventArgs) Handles btnSelectCc.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PersIDCSV", myUtils.MakeCSV(",", "0", myUtils.cStrTN(myRow("CCAddrsID"))), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("email", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim strNameCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("CCAddrsName")), myUtils.MakeCSV(rr, "FullName"))
            Dim strEmailCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("CCAddrsEmail")), myUtils.MakeCSV(rr, "Email"))
            Dim strIDCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("CCAddrsID")), myUtils.MakeCSV(rr, "PersonID"))
            Dim strCcCSV As String = txt_CCAddrs.Value
            For Each r1 As DataRow In rr
                strCcCSV = myUtils.MakeCSV(";", strCcCSV, r1("fullname") & "<" & r1("email") & ">")
            Next

            txt_CCAddrs.Value = strCcCSV
            myRow("CCAddrsName") = strNameCSV
            myRow("CCAddrsEmail") = strEmailCSV
            myRow("CCAddrsID") = strIDCSV

        End If
    End Sub

    Private Sub btnClearCC_Click(sender As Object, e As EventArgs) Handles btnClearCC.Click
        myRow("CCAddrs") = DBNull.Value
        myRow("CCAddrsName") = DBNull.Value
        myRow("CCAddrsEmail") = DBNull.Value
        myRow("CCAddrsID") = DBNull.Value
        txt_CCAddrs.Value = ""
    End Sub

    Private Sub btnSelectBcc_Click(sender As Object, e As EventArgs) Handles btnSelectBcc.Click
        Dim Params As New List(Of clsSQLParam)
        Params.Add(New clsSQLParam("@PersIDCSV", myUtils.MakeCSV(",", "0", myUtils.cStrTN(myRow("BCCAddrsID"))), GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("email", Params)
        If Not rr Is Nothing AndAlso rr.Length > 0 Then
            Dim strNameCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("BCCAddrsName")), myUtils.MakeCSV(rr, "FullName"))
            Dim strEmailCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("BCCAddrsEmail")), myUtils.MakeCSV(rr, "Email"))
            Dim strIDCSV = myUtils.MakeCSV(",", myUtils.cStrTN(myRow("BCCAddrsID")), myUtils.MakeCSV(rr, "PersonID"))
            Dim strBccCSV As String = txt_BCCAddrs.Value
            For Each r1 As DataRow In rr
                strBccCSV = myUtils.MakeCSV(";", strBccCSV, r1("fullname") & "<" & r1("email") & ">")
            Next

            txt_BCCAddrs.Value = strBccCSV
            myRow("BCCAddrsName") = strNameCSV
            myRow("BCCAddrsEmail") = strEmailCSV
            myRow("BCCAddrsID") = strIDCSV

        End If
    End Sub

    Private Sub btnClearBCC_Click(sender As Object, e As EventArgs) Handles btnClearBCC.Click
        myRow("BCCAddrs") = DBNull.Value
        myRow("BCCAddrsName") = DBNull.Value
        myRow("BCCAddrsEmail") = DBNull.Value
        myRow("BCCAddrsID") = DBNull.Value
        txt_BCCAddrs.Value = ""
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

    Private Sub btnDeleteEmail_Click(sender As Object, e As EventArgs) Handles btnDeleteEmail.Click
        If MsgBox("Are you sure you want to delete this Email", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

    Private Sub cmb_OutBoundEmailID_Leave(sender As Object, e As EventArgs) Handles cmb_OutBoundEmailID.Leave, cmb_OutBoundEmailID.AfterCloseUp
        If Not myUtils.NullNot(cmb_OutBoundEmailID.Value) Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_OutBoundEmailID.SelectedRow)
            txt_FromName.Value = r1("FromName")
            txt_FromAddr.Value = r1("FromAddr")
            myRow("FromName") = txt_FromName.Value
            myRow("FromAddr") = txt_FromAddr.Value
        End If
    End Sub

    Private Sub cmb_EmailTemplateID_Leave(sender As Object, e As EventArgs) Handles cmb_EmailTemplateID.Leave, cmb_EmailTemplateID.AfterCloseUp
        If Not myUtils.NullNot(cmb_EmailTemplateID.Value) Then
            Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(Me.cmb_EmailTemplateID.SelectedRow)
            Me.CtlRTFMailBox.RTFText = r1("Content")
            myRow("Content") = Me.CtlRTFMailBox.PlainText
            'myRow("Contentrtf") = Me.CtlRTFMailBox.RTFText
            myRow("Contenthtml") = Me.CtlRTFMailBox.HTMLText
        End If
    End Sub

End Class