Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmProspectList
    Inherits frmMax

    Dim myVueAcc, myVuePers, myVueLead, myVueUser As New clsWinView

    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
        Me.myVueAcc.SetGrid(Me.UltraGridAccount)
        Me.myVuePers.SetGrid(Me.UltraGridPerson)
        Me.myVueLead.SetGrid(Me.UltraGridLead)
        Me.myVueUser.SetGrid(Me.UltraGridUser)

    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmProspectListModel = Me.InitData("frmProspectListModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            myWinSQL.AssignCmb(Me.dsCombo, "ListType", "", Me.cmb_ListType)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("Team"),, btnDeleteTeam)
            myVueAcc.PrepEdit(Me.Model.GridViews("Account"))
            myVuePers.PrepEdit(Me.Model.GridViews("Person"))
            myVueLead.PrepEdit(Me.Model.GridViews("Lead"))
            myVueUser.PrepEdit(Me.Model.GridViews("User"))

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

    Private Sub btnAddProspect_Click(sender As Object, e As EventArgs) Handles btnAddProspect.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim Params As New List(Of clsSQLParam)

            Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
                Case "account"
                    Params.Add(New clsSQLParam("@AccIDCsv", myUtils.MakeCSV(myVueAcc.mainGrid.myDS.Tables(0).Select, "CustomerID"), GetType(Integer), True))
                    Dim rr() As DataRow = Me.AdvancedSelect("account", Params)
                    If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                        For Each r1 As DataRow In rr
                            Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueAcc.mainGrid.myDS.Tables(0))
                            r2("IDField") = "CustomerID"
                            r2("IDValue") = r1("CustomerID")
                            r2("Partyname") = r1("Partyname")
                            r2("SelCity") = r1("SelCity")
                            r2("SelPhNum") = r1("SelPhNum")

                        Next
                    End If

                Case "person"
                    Params.Add(New clsSQLParam("@PersIDCsv", myUtils.MakeCSV(myVuePers.mainGrid.myDS.Tables(0).Select, "PersonID"), GetType(Integer), False))
                    Dim rr() As DataRow = Me.AdvancedSelect("person", Params)
                    If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                        For Each r1 As DataRow In rr
                            Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVuePers.mainGrid.myDS.Tables(0))
                            r2("IDField") = "PersonID"
                            r2("IDValue") = r1("PersonID")
                            r2("FullName") = r1("FullName")
                            r2("Email") = r1("Email")
                            r2("PrPhone") = r1("PrPhone")

                        Next
                    End If

                Case "lead"
                    Params.Add(New clsSQLParam("@LeadIDCsv", myUtils.MakeCSV(myVueLead.mainGrid.myDS.Tables(0).Select, "LeadID"), GetType(Integer), False))
                    Dim rr() As DataRow = Me.AdvancedSelect("lead", Params)
                    If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                        For Each r1 As DataRow In rr
                            Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueLead.mainGrid.myDS.Tables(0))
                            r2("IDField") = "LeadID"
                            r2("IDValue") = r1("LeadID")
                            r2("Name") = r1("Name")
                            r2("Title") = r1("Title")
                            r2("Email1") = r1("Email1")
                            r2("PhoneMobile") = r1("PhoneMobile")

                        Next
                    End If

                Case "user"
                    Dim str1 As String = myUtils.MakeCSV(myVueUser.mainGrid.myDS.Tables(0).Select, "UserID", ",", "'00000000-0000-0000-0000-000000000000'", True)
                    Params.Add(New clsSQLParam("@UserIDCsv", str1, GetType(Guid), True))
                    Dim rr() As DataRow = Me.AdvancedSelect("user", Params)
                    If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
                        For Each r1 As DataRow In rr
                            Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueUser.mainGrid.myDS.Tables(0))
                            r2("IDField") = "UserID"
                            r2("IDValue2") = r1("UserID")
                            r2("UserName") = r1("UserName")

                        Next
                    End If

            End Select
        Else
            MsgBox("You need to save first before proceeding ..", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If

    End Sub

    Private Sub btnDelProspect_Click(sender As Object, e As EventArgs) Handles btnDelProspect.Click

        Select Case Me.UltraTabControl1.SelectedTab.Key.Trim.ToLower
            Case "account"
                myVueAcc.mainGrid.ButtonAction("del")
            Case "person"
                myVuePers.mainGrid.ButtonAction("del")
            Case "lead"
                myVueLead.mainGrid.ButtonAction("del")
            Case "user"
                myVueUser.mainGrid.ButtonAction("del")
        End Select

    End Sub

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

    Private Sub btnDeleteProspect_Click(sender As Object, e As EventArgs) Handles btnDeleteProspect.Click
        If MsgBox("Are you sure you want to delete this Prospect List", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
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

End Class

