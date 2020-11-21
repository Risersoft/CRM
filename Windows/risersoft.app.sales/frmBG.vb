Imports risersoft.shared.Extensions
Imports Infragistics.Win.UltraWinGrid
Public Class frmBG
    Inherits frmMax

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim fO As frmMax, str1 As String

        Me.FormPrepared = False
        If Me.GetSoftData(oView, prepMode, prepIDX) Then
            Me.PanelTF.Visible = False
            fO = pView.fParentWin

            If myRow.Row.Table.Columns.Contains("salesorderid") AndAlso fO.frmMode = EnumfrmMode.acEditM Then
                If myUtils.cBoolTN(fO.myRow("bgperunit")) Then
                    str1 = "<OVERRIDE><STRWIDTH>0-1-0.5-1</STRWIDTH></OVERRIDE>"
                    myWinSQL.AssignCmb(fO.dsCombo, "ProdSerial", "", Me.cmb_ProdSerialID, str1)
                    If Me.cmb_ProdSerialID.Rows.Count > 0 Then Me.PanelTF.Visible = True
                End If
            End If

            myWinSQL.AssignCmb(fO.dsCombo, "BGType", "", Me.cmb_BGTypeid)
            myWinSQL.AssignCmb(fO.dsCombo, "StatusBG", "", Me.cmb_StatusNum)
            Me.cmb_BGTypeid.Value = myRow("BGTypeid")

            Me.cmb_BGMode.ValueList = fO.Model.ValueLists("BGMode").ComboList
            Me.cmb_PeriodType.ValueList = fO.Model.ValueLists("periodtype").ComboList
            Me.cmb_PeriodType2.ValueList = fO.Model.ValueLists("periodtype").ComboList

            Me.handle_cmb_BGTypeid(Nothing, Nothing)
            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError()
        If myUtils.NullNot(Me.cmb_BGTypeid.Value) Then WinFormUtils.AddError(Me.cmb_BGTypeid, "Select a BG Type")
        If Me.CanSave Then
            Me.SaveSoftData()
            VSave = True
        End If

    End Function

    Private Sub handle_cmb_BGTypeid(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BGTypeid.Leave, cmb_BGTypeid.AfterCloseUp

        Me.lblStart.Text = ""
        Me.lblStart2.Text = ""
        Me.GroupBox2.Visible = True
        If (myUtils.cValTN(Me.cmb_BGTypeid.Value) > 0) AndAlso (myUtils.cValTN(Me.cmb_BGTypeid.Value) > 0) Then
            Me.lblStart.Text = Me.cmb_BGTypeid.SelectedRow.Cells("periodstart").Value.ToString
            Me.lblStart2.Text = Me.cmb_BGTypeid.SelectedRow.Cells("periodstart2").Value.ToString
            If Trim(Me.lblStart2.Text) = "" Then Me.GroupBox2.Visible = False
        End If

    End Sub

End Class
