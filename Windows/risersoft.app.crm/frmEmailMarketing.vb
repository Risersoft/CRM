Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmEmailMarketing
    Inherits frmMax
    Dim myVueProspect As New clsWinView

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        myVueProspect.SetGrid(Me.UltraGridProspect)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmEmailMarketingModel = Me.InitData("frmEmailMarketingModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            Me.cmb_Status.ValueList = Me.Model.ValueLists("Status").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "Template", "", Me.cmb_TemplateID)
            myWinSQL.AssignCmb(Me.dsCombo, "OutBound", "", Me.cmb_OutBoundEmailID)
            myWinSQL.AssignCmb(Me.dsCombo, "InBound", "", Me.cmb_InBoundEmailID)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myVueProspect.PrepEdit(Me.Model.GridViews("Prospect"))
            Return True
        End If
        Return False
    End Function

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

    Private Sub btnAddProspect_Click(sender As Object, e As EventArgs) Handles btnAddProspect.Click
        If Me.frmMode = EnumfrmMode.acEditM Then
            Dim Params As New List(Of clsSQLParam)
            Dim str1 As String = myUtils.MakeCSV(myVueProspect.mainGrid.myDS.Tables(0).Select, "ProspectListID")
            Params.Add(New clsSQLParam("@ProsIDcsv", str1, GetType(Integer), True))
            Dim rr() As DataRow = Me.AdvancedSelect("prospect", Params)
            If Not IsNothing(rr) Then
                For Each r1 As DataRow In rr
                    Dim r2 As DataRow = myUtils.CopyOneRow(r1, myVueProspect.mainGrid.myDS.Tables(0))
                    r2("PIDField") = "EmailMarketingID"
                    r2("PIDValue") = myRow("EmailMarketingID")
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

    Private Sub chk_AllProspectList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllProspectList.CheckedChanged
        If myUtils.cBoolTN(Me.chk_AllProspectList.Checked) Then
            Me.btnAddProspect.Enabled = False
            Me.btnDelProspect.Enabled = False
        Else
            Me.btnAddProspect.Enabled = True
            Me.btnDelProspect.Enabled = True

        End If
    End Sub

    Private Sub btnDeleteEmailMarket_Click(sender As Object, e As EventArgs) Handles btnDeleteEmailMarket.Click
        If MsgBox("Are you sure you want to delete this Email Marketing", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
            myRow("isDeleted") = 1
            WinFormUtils.ButtonAction(Me, "btnOK")
        End If
    End Sub

End Class
