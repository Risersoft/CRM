Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmCampaign
    Inherits frmMax
    Dim myVueProspect As New clsWinView

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myView.SetGrid(Me.UltraGridTeam)
        myVueProspect.SetGrid(Me.UltraGridProspect)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCampaignModel = Me.InitData("frmCampaignModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_AssignUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Team", "", Me.cmb_AssignTeamID)
            Me.cmb_Status.ValueList = Me.Model.ValueLists("Status").ComboList
            Me.cmb_CampaignType.ValueList = Me.Model.ValueLists("CampaignType").ComboList
            Me.cmb_CurrencyCode.ValueList = Me.Model.ValueLists("CurrencyCode").ComboList

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Team"),, btnDeleteTeam)
            myVueProspect.PrepEdit(Me.Model.GridViews("Prospect"))
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

    Private Sub btnAddProspect_Click(sender As Object, e As EventArgs) Handles btnAddProspect.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim Params As New List(Of clsSQLParam)
            Dim str1 As String = myUtils.MakeCSV(myVueProspect.mainGrid.myDS.Tables(0).Select, "ProspectListID")
            Params.Add(New clsSQLParam("@ProsIDcsv", str1, GetType(Integer), True))
            Dim rr() As DataRow = Me.AdvancedSelect("prospect", Params)
            If Not IsNothing(rr) Then
                For Each r1 As DataRow In rr
                    Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueProspect.mainGrid.myDS.Tables(0))
                    r2("PIDField") = "CampaignID"
                    r2("PIDValue") = myRow("CampaignID")
                Next
            End If
        Else
            MsgBox("You need to save first before Add Prospects...", MsgBoxStyle.Information, myWinApp.Vars("AppName"))
        End If
    End Sub

    Private Sub btnDelProspect_Click(sender As Object, e As EventArgs) Handles btnDelProspect.Click
        myVueProspect.ContextRow = myVueProspect.mainGrid.ActiveRow
        If Not myVueProspect.ContextRow Is Nothing Then
            If myUtils.cValTN(myVueProspect.ContextRow.CellValue("ProspectListParentID")) = 0 Then
                myVueProspect.mainGrid.ButtonAction("del")
            Else
                If MsgBox("Are you sure you want to delete this Prospect", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                    Dim oRet As clsProcOutput = Me.GenerateIDOutput("delprospect", myUtils.cValTN(myVueProspect.ContextRow.CellValue("ProspectListParentID")))
                    If oRet.Success Then
                        Dim rr As DataRow() = New DataRow() {win.myWinUtils.DataRowFromGridRow(myVueProspect.mainGrid.myGrid.ActiveRow)}
                        myUtils.RemoveRows(rr)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
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

    Private Sub btnDeleteCampaign_Click(sender As Object, e As EventArgs) Handles btnDeleteCampaign.Click
        If MsgBox("Are you sure you want to delete this Campaign", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

End Class
