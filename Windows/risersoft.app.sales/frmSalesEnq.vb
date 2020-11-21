Imports Infragistics.Win.UltraWinGrid
Imports System.Windows.Forms
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmSalesEnq
    Inherits frmMax
    Dim myVueTerm As New clsWinView, myVueBG As New clsWinView, myVueDoc As New clsWinView, dvCamp, dvEmp, dvDivision As DataView

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim str As String
        Me.FormPrepared = False
        Dim objModel As frmSalesEnqModel = Me.InitData("frmSalesEnqModel", oView, prepMode, prepIDX, strXML)

        If Me.BindModel(objModel, oView) Then
            dvCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_CampusID,, 2)

            str = "<STRWIDTH>0-1-1</STRWIDTH><COLHEADERS>TRUE</COLHEADERS>"
            myWinSQL.AssignCmb(Me.dsCombo, "Persons", "", Me.cmb_AddressToID, str)
            myWinSQL.AssignCmb(Me.dsCombo, "Persons", "", Me.cmb_SentByID, str)

            dvEmp = myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_HandledByID,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "Status", "", Me.cmb_StatusNum)
            myWinSQL.AssignCmb(Me.dsCombo, "DispMode", "", Me.cmb_DispMode)
            myWinSQL.AssignCmb(Me.dsCombo, "Region", "", Me.cmb_RegionID)
            myWinSQL.AssignCmb(Me.dsCombo, "Region", "", Me.cmb_EURegionID)

            myWinSQL.AssignCmb(Me.dsCombo, "proj", "", Me.cmb_ProjectID)
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ConsultantID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ContractorID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_EndUserID)

            Me.cmb_Priority.ValueList = Me.Model.ValueLists("Priority").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "EnqType", "", Me.cmb_EnqType)

            dvDivision = myWinSQL.AssignCmb(Me.dsCombo, "Division", "", Me.cmb_DivisionID, "<STRWIDTH>0-1-2</STRWIDTH>", 2)
            dvDivision.RowFilter = Me.Controller.AppModel.strFilterDBAppUser(Me.Controller, Me.fRow, "DivisionID")

            If frmMode = EnumfrmMode.acAddM Then
            Else
                Me.txt_NumParts.Text = myUtils.cValTN(myRow("numparts"))
            End If

            HandleParts(Nothing, Nothing)
            myWinApp.DelNonRelevant(Me.dsCombo.Tables("User"), "isdeleted=1", "UserID='" & myUtils.cStrTN(myRow("HandledByID")) & "'")
            risersoft.app.mxform.myFuncs.RefreshPartyCombo = False

            HandleDate(myUtils.cDateTN(myRow("EnqDate"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("SEItem"))
            myVueTerm.PrepEdit(Me.Model.GridViews("TETerms"))
            myVueTerm.mainGrid.HighlightRows()
            myVueBG.PrepEdit(Me.Model.GridViews("BGCust"), , Me.btnDelBG)
            myVueDoc.PrepEdit(Me.Model.GridViews("TEDoc"), Me.btnAddDoc, Me.btnDelDoc)
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        Me.myVueTerm.SetGrid(Me.UltraGridTerm)
        Me.myVueBG.SetGrid(Me.UltraGridBG)
        Me.myVueDoc.SetGrid(Me.UltraGridDoc)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Private Sub reProj()
        Dim ds As New DataSet
        ds = Me.LoadData("Project")
        myUtils.ReplaceRows(Me.dsCombo, ds.Tables(0), "proj")
    End Sub

    Private Sub reParty()
        Dim ds As New DataSet
        ds = Me.LoadData("Party")
        myUtils.ReplaceRows(Me.dsCombo, ds.Tables(1), "Cust")
        myUtils.ReplaceRows(Me.dsCombo, ds.Tables(0), "Party")
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
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

    Private Sub HandleParts(ByVal sender As Object, ByVal e As EventArgs) Handles txt_NumParts.Leave
        Dim i As Integer, prev As Object
        Dim ctl As Control, cmb As Infragistics.Win.UltraWinEditors.UltraComboEditor

        i = Val(Me.txt_NumParts.Text)
        If Me.cmb_TechPart.Items.Count <> i OrElse Me.cmb_TechPart.Items.Count = 0 Then
            For Each ctl In Me.GroupBox1.Controls
                If TypeOf ctl Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    cmb = CType(ctl, Infragistics.Win.UltraWinEditors.UltraComboEditor)
                    prev = cmb.Value
                    cmb.Items.Clear()
                    If i > 0 AndAlso i < 4 Then
                        If i > 0 Then cmb.Items.Add(1, "Part - I")
                        If i > 1 Then cmb.Items.Add(2, "Part - II")
                        If i > 2 Then cmb.Items.Add(3, "Part - III")
                    End If
                    cmb.Value = Nothing
                    If cmb.Items.Contains(prev) Then cmb.Value = prev
                End If
            Next
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultant.Click, btnContractor.Click, btnSelAddTo.Click, btnSelSentBy.Click, btnAddBG.Click, btnEditBG.Click, btnEndUser.Click
        Dim btn As Infragistics.Win.Misc.UltraButton = CType(sender, Infragistics.Win.Misc.UltraButton), Params As New List(Of clsSQLParam)
        Dim rr() As DataRow, frm As frmBG

        Select Case LCase(btn.Name)
            Case "btncontractor"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_ContractorID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)
            Case "btnenduser"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_EndUserID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)
            Case "btnconsultant"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_ConsultantID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)

            Case "btnseladdto"
                rr = Me.AdvancedSelect("<SYS ID=""perspartyid""/>", Params)
                If Not rr Is Nothing Then Me.cmb_AddressToID.Value = rr(0)("perspartyid")
            Case "btnselsentby"
                rr = Me.AdvancedSelect("<SYS ID=""perspartyid""/>", Params)
                If Not rr Is Nothing Then Me.cmb_SentByID.Value = rr(0)("perspartyid")
            Case "btneditbg"
                frm = New frmBG
                If frm.PrepForm(Me.myVueBG, EnumfrmMode.acEditM, "") Then frm.ShowDialog()
            Case "btnaddbg"
                frm = New frmBG
                If frm.PrepForm(Me.myVueBG, EnumfrmMode.acAddM, "") Then frm.ShowDialog()
        End Select

    End Sub

    Private Sub btnAddRat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRat.Click
        Dim oRet As clsProcOutput = Nothing
        Dim f As New frmSalesEnqItem
        If frmMode = EnumfrmMode.acAddM Then
            MsgBox("You need to save first", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        Else
            If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS SalesEnqID=""" & myUtils.cValTN(frmIDX) & """/>") Then
                If f.ShowDialog = DialogResult.OK Then
                    oRet = Me.GenerateIDOutput("slsenqitem", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnEditRat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRat.Click
        Dim oRet As clsProcOutput = Nothing
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            Dim f As New frmSalesEnqItem
            If f.PrepForm(myView, EnumfrmMode.acEditM, myView.ContextRow.CellValue("SalesEnqItemID")) Then
                If f.ShowDialog = DialogResult.OK Then
                    oRet = Me.GenerateIDOutput("slsenqitem", frmIDX)
                    If oRet.Success Then
                        Me.UpdateViewData(myView, oRet)
                    Else
                        MsgBox(oRet.Message, MsgBoxStyle.Information, myWinApp.Vars("appname"))
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub frmTE_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If risersoft.app.mxform.myFuncs.RefreshPartyCombo Then
            'refresh Party list
            Me.reParty()
            risersoft.app.mxform.myFuncs.RefreshPartyCombo = False
        End If
    End Sub

    Private Sub btnAddProj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProj.Click
        Dim f As New frmProject

        If f.PrepForm(myView, EnumfrmMode.acAddM, "") Then
            f.ShowDialog()
            Me.reProj()
        End If
    End Sub

    Private Sub btnSelProj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelProj.Click
        Dim rr() As DataRow
        rr = Me.Controller.AdvancedSelect("<SYS ID=""projectid""/>", False)
        If rr Is Nothing Then
            If MsgBox("Do you want to remove selection?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                Me.cmb_ProjectID.Value = DBNull.Value
            End If
        Else
            Me.cmb_ProjectID.Value = rr(0)("projectid")
        End If

    End Sub
    Private Sub FreezeProjFields()
        Me.PanelEU.BackColor = Me.PanelEU.Parent.BackColor

        If Not Me.cmb_ProjectID.SelectedRow Is Nothing Then
            Me.PanelEU.Enabled = False
            Me.cmb_EndUserID.Value = Me.cmb_ProjectID.SelectedRow.Cells("enduserid").Value
            Me.cmb_EURegionID.Value = Me.cmb_ProjectID.SelectedRow.Cells("euregionid").Value
            Me.cmb_Priority.Value = Me.cmb_ProjectID.SelectedRow.Cells("priority").Value
        Else
            Me.PanelEU.Enabled = True
        End If

    End Sub

    Private Sub cmb_ProjectID_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ProjectID.ValueChanged
        Me.FreezeProjFields()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not Me.cmb_ProjectID.SelectedRow Is Nothing Then
            Dim f As New frmProject
            If f.PrepForm(myView, EnumfrmMode.acEditM, Me.cmb_ProjectID.Value) Then
                f.ShowDialog()
                Me.reProj()
            End If
        End If
    End Sub

    Private Sub dt_EnqDate_Leave(sender As Object, e As EventArgs) Handles dt_EnqDate.Leave, dt_EnqDate.AfterCloseUp
        HandleDate(dt_EnqDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvCamp.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "CampusID")
        dvEmp.RowFilter = risersoft.app.mxform.myFuncs.FilterTimeDependent(dated, "JoinDate", "LeaveDate", 0)
    End Sub
End Class
