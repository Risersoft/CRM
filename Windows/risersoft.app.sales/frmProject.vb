Imports Infragistics.Win.UltraWinGrid
Imports we = Infragistics.Win.UltraWinEditors
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmProject
    Inherits frmMax

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmProjectModel = Me.InitData("frmProjectModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_EndUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ProjectWonByID)
            myWinSQL.AssignCmb(Me.dsCombo, "region", "", Me.cmb_RegionID)
            myWinSQL.AssignCmb(Me.dsCombo, "region", "", Me.cmb_EURegionID)
            Me.cmb_Priority.ValueList = Me.Model.ValueLists("Priority").ComboList

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

    Private Sub InitForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()

    End Function

End Class

