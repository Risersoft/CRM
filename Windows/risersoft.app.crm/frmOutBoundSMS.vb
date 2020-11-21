Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmOutBoundSMS
    Inherits frmMax

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmOutBoundSMSModel = Me.InitData("frmOutBoundSMSModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_UserID)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
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

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim Params As New List(Of clsSQLParam), rr() As DataRow
        If myUtils.NullNot(myRow("UserID")) Then
            Dim str1 As String = "00000000-0000-0000-0000-000000000000"
            Params.Add(New clsSQLParam("@UserID", str1, GetType(Guid), True))
        Else
            Params.Add(New clsSQLParam("@UserID", myUtils.cStrTN(cmb_UserID.Value), GetType(Guid), True))
        End If
        rr = Me.AdvancedSelect("user", Params)
        If (Not rr Is Nothing) AndAlso rr.Length > 0 Then
            cmb_UserID.Value = Guid.Parse(myUtils.cStrTN(rr(0)("UserID")))
        End If
    End Sub

    Private Sub btnClearUser_Click(sender As Object, e As EventArgs) Handles btnClearUser.Click
        myRow("UserID") = DBNull.Value
        cmb_UserID.Value = ""
    End Sub

    Private Sub btnDeleteSMS_Click(sender As Object, e As EventArgs) Handles btnDeleteSMS.Click
        If MsgBox("Are you sure you want to delete this OutBoundSMS", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

End Class
