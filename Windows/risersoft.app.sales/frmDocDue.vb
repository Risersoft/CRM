Imports Infragistics.Win.UltraWinGrid
Public Class frmDocDue
    Inherits frmMax

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim fO As frmMax
        Me.FormPrepared = False
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            fO = pView.fParentWin
            myWinSQL.AssignCmb(fO.dsCombo, "DOC", "", Me.cmb_docnameID, "<STRWIDTH>0-1-1</STRWIDTH>")
            myWinSQL.AssignCmb(fO.dsCombo, "BG2", "", Me.cmb_StatusNum)
            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Private Sub InitForm()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.SaveSoftData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
