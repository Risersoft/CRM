Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmOpportunity
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmOpportunityModel = Me.InitData("frmOpportunityModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            myWinSQL.AssignCmb(Me.dsCombo, "Customer", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Campaign", "", Me.cmb_CampaignID)
            Me.cmb_OpportunityType.ValueList = Me.Model.ValueLists("Opportunity").ComboList
            Me.cmb_LeadSource.ValueList = Me.Model.ValueLists("LeadSource").ComboList
            Me.cmb_Currency.ValueList = Me.Model.ValueLists("Currency").ComboList
            Me.cmb_SalesStage.ValueList = Me.Model.ValueLists("Stage").ComboList

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

    Private Sub btnSelectAcc_Click(sender As Object, e As EventArgs) Handles btnSelectAcc.Click
        Dim Params As New List(Of clsSQLParam), rr() As DataRow
        Params.Add(New clsSQLParam("@CustomerID", myUtils.cValTN(cmb_CustomerID.Value), GetType(Integer), True))

        rr = Me.AdvancedSelect("customer", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cmb_CustomerID.Value = myUtils.cValTN(rr(0)("CustomerID"))
        End If
    End Sub

    Private Sub btnClearAccount_Click(sender As Object, e As EventArgs) Handles btnClearAccount.Click
        myRow("CustomerID") = DBNull.Value
        cmb_CustomerID.Value = ""
    End Sub

    Private Sub btnSelectCamp_Click(sender As Object, e As EventArgs) Handles btnSelectCamp.Click
        Dim Params As New List(Of clsSQLParam), rr() As DataRow
        Params.Add(New clsSQLParam("@CampaignID", myUtils.cValTN(cmb_CampaignID.Value), GetType(Integer), True))

        rr = Me.AdvancedSelect("campaign", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cmb_CampaignID.Value = myUtils.cValTN(rr(0)("CampaignID"))
        End If
    End Sub

    Private Sub btnClearCamp_Click(sender As Object, e As EventArgs) Handles btnClearCamp.Click
        myRow("CampaignID") = DBNull.Value
        cmb_CampaignID.Value = ""
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

    Private Sub btnDeleteOpportunity_Click(sender As Object, e As EventArgs) Handles btnDeleteOpportunity.Click
        If MsgBox("Are you sure you want to delete this Opportunity", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

End Class

