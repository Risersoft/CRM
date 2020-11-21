Imports System.Windows.Forms
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmSalesOrder
    Inherits frmMax
    Dim myVueInsp, myVuePay, myVueBG, myVueDoc, myVueAdv, myVueComm, myViewTrns, myViewSOVal As New clsWinView, dvEmp, dvProj, dvDivision As DataView

    Private Sub InitForm()
        Me.myView.SetGrid(Me.UltraGrid1)
        Me.myVueAdv.SetGrid(Me.UltraGridAdv)
        Me.myVueBG.SetGrid(Me.UltraGridBG)
        Me.myVueComm.SetGrid(Me.UltraGridComm)
        Me.myVueDoc.SetGrid(Me.UltraGridDoc)
        Me.myVueInsp.SetGrid(Me.UltraGridInsp)
        Me.myVuePay.SetGrid(Me.UltraGridPay)
        Me.myViewTrns.SetGrid(Me.UltraGridTrns)
        Me.myViewSOVal.SetGrid(Me.UltraGridSOValue)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False

        Dim objModel As frmSalesOrderModel = Me.InitData("frmSalesOrderModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            If frmMode = EnumfrmMode.acAddM Then If cmb_CompanyID.Rows.Count = 1 Then myRow("CompanyID") = myUtils.cValTN(cmb_CompanyID.Rows(0).Cells("CompanyID").Value)

            Me.cmb_STClause.ValueList = Me.Model.ValueLists("STClause").ComboList
            Me.chk_HasPenalty.CheckState = CheckState.Indeterminate
            If Len(myRow("perpenalty").ToString) = 0 Then Me.chk_HasPenalty.Checked = False Else Me.chk_HasPenalty.Checked = True
            myWinApp.DelNonRelevant(Me.dsCombo.Tables("User"), "isdeleted=1", "UserID='" & myUtils.cStrTN(myRow("HandledByID")) & "'")

            If Me.Model.DatasetCollection("enq").Tables(0).Rows.Count > 0 Then Me.SetEnqLabel(Me.Model.DatasetCollection("enq").Tables(0).Rows(0)) Else Me.SetEnqLabel(Nothing)

            HandleDate(myUtils.cDateTN(myRow("PODate"), DateTime.MinValue), myUtils.cDateTN(myRow("LoIDate"), DateTime.MinValue))

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("WO"))
            myVueAdv.PrepEdit(Me.Model.GridViews("Adv"))
            myVueComm.PrepEdit(Me.Model.GridViews("SOComm"), Me.btnAddComm, Me.btnDelComm)
            myVueDoc.PrepEdit(Me.Model.GridViews("SODoc"), Me.btnAddDoc, Me.btnDelDoc)
            myVueBG.PrepEdit(Me.Model.GridViews("BGCust"), , Me.btnDelBG)
            myVueInsp.mainGrid.PrepEntSelect("<SYS ID=""PERSPARTYID""/>", Me.btnDelInsp, Me.btnAddInsp)
            myVueInsp.PrepEdit(Me.Model.GridViews("Insp"))
            myVuePay.PrepEdit(Me.Model.GridViews("SOPay"), Me.btnAddPay, Me.btnDelPay)
            myViewTrns.PrepEdit(Me.Model.GridViews("Trns"), Me.btnAddTrns, Me.btnDelTrns)
            myViewSOVal.PrepEdit(Me.Model.GridViews("SOVal"))


            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_PaymentAuthID)
            myWinSQL.AssignCmb(Me.dsCombo, "Company", "", Me.cmb_CompanyID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ConsultantID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_ContractorID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_EndUserID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_insAuthID)
            myWinSQL.AssignCmb(Me.dsCombo, "VendorCA", "", Me.cmb_CommAgentID)
            myWinSQL.AssignCmb(Me.dsCombo, "VendorJP", "", Me.cmb_JVPartnerID)

            Dim str1 As String = "<STRWIDTH>0-1-1</STRWIDTH><COLHEADERS>TRUE</COLHEADERS>"
            myWinSQL.AssignCmb(Me.dsCombo, "Persons", "", Me.cmb_SendAcceptID, str1)
            myWinSQL.AssignCmb(Me.dsCombo, "Persons", "", Me.cmb_SendApproveID, str1)
            dvEmp = myWinSQL.AssignCmb(Me.dsCombo, "User", "", Me.cmb_HandledByID,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "Region", "", Me.cmb_RegionID)
            myWinSQL.AssignCmb(Me.dsCombo, "PenaltyPeriodType", "", Me.cmb_PenaltyPeriodType)
            dvProj = myWinSQL.AssignCmb(Me.dsCombo, "Project", "", Me.cmb_ProjectID,, 2)

            dvDivision = myWinSQL.AssignCmb(Me.dsCombo, "Division", "", Me.cmb_DivisionID, "<STRWIDTH>0-1-2</STRWIDTH>", 2)
            dvDivision.RowFilter = Me.Controller.AppModel.strFilterDBAppUser(Me.Controller, Me.fRow, "DivisionID")

            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Me.InitError() : WinFormUtils.InitTabBacks(Me.TabControl2)
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Me.BXML = "<BROWSE KEY=""sls.order"" ID=""" & frmIDX & """/>"
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()

    End Function
    Private Sub SetEnqLabel(r1 As DataRow)
        If r1 Is Nothing Then
            Me.TextEnqRefNum.Text = ""
        Else
            Me.TextEnqRefNum.Text = r1("enqrefnum") & " Dt. " & Format(myUtils.cStrTN(r1("enqdate")), "dd-MMM-yyyy")
        End If
    End Sub
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContractor.Click, btnConsultant.Click, btnEndUser.Click, btnSelApprove.Click, btnSelAccept.Click, btnSelTenderNo.Click, btnEditBG.Click, btnAddBG.Click
        Dim btn As Infragistics.Win.Misc.UltraButton = CType(sender, Infragistics.Win.Misc.UltraButton)
        Dim rr() As DataRow, frm As frmBG

        Select Case LCase(btn.Name)
            Case "btncontractor"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_ContractorID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)
            Case "btnenduser"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_EndUserID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)
            Case "btnconsultant"
                If Not Me.cmb_CustomerID.SelectedRow Is Nothing Then Me.cmb_ConsultantID.Value = myUtils.cValTN(Me.cmb_CustomerID.SelectedRow.Cells("partyid").Value)
            Case "btnseltenderno"
                Dim Params As New List(Of clsSQLParam)
                Dim rr1() As DataRow = Me.AdvancedSelect("btnseltenderno", Params)
                If (Not rr1 Is Nothing) AndAlso rr1.Length > 0 Then
                    myRow("salesenqid") = rr1(0)("salesenqid")
                    Me.SetEnqLabel(rr1(0))
                Else
                    myRow("salesenqid") = DBNull.Value
                    Me.SetEnqLabel(Nothing)
                End If
            Case "btnselaccept"
                rr = Me.Controller.AdvancedSelect("<SYS ID=""perspartyid""/>", False)
                If Not rr Is Nothing Then Me.cmb_SendAcceptID.Value = rr(0)("perspartyid")
            Case "btnselapprove"
                rr = Me.Controller.AdvancedSelect("<SYS ID=""perspartyid""/>", False)
                If Not rr Is Nothing Then Me.cmb_SendApproveID.Value = rr(0)("perspartyid")
            Case "btneditbg"
                frm = New frmBG
                If frm.PrepForm(Me.myVueBG, EnumfrmMode.acEditM, "") Then frm.ShowDialog()
            Case "btnaddbg"
                frm = New frmBG
                If frm.PrepForm(Me.myVueBG, EnumfrmMode.acAddM, "") Then frm.ShowDialog()
        End Select

    End Sub

    Private Sub chk_HasPenalty_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_HasPenalty.CheckedChanged
        Dim chk As Infragistics.Win.UltraWinEditors.UltraCheckEditor = CType(sender, Infragistics.Win.UltraWinEditors.UltraCheckEditor)

        If chk.Checked Then
            Me.GroupBox1.Enabled = True
        Else
            Me.GroupBox1.Enabled = False
        End If
    End Sub


    Private Sub btnAddWO_Click(sender As Object, e As EventArgs) Handles btnAddWO.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmWO), "workorderid", "<PARAMS SALESORDERID=""" & frmIDX & """ WOTYPE=""SW""/>")
            If Not nr Is Nothing Then myView.RefreshGrid()
        Else
            MsgBox("You need to save first in order to add work orders", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnAddRO_Click(sender As Object, e As EventArgs) Handles btnAddRO.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmWO), "workorderid", "<PARAMS SALESORDERID=""" & frmIDX & """ WOTYPE=""RE""/>")
            If Not nr Is Nothing Then myView.RefreshGrid()
        Else
            MsgBox("You need to save first in order to add repair orders", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnAddSO_Click(sender As Object, e As EventArgs) Handles btnAddSO.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmWO), "workorderid", "<PARAMS SALESORDERID=""" & frmIDX & """ WOTYPE=""SP""/>")
            If Not nr Is Nothing Then myView.RefreshGrid()
        Else
            MsgBox("You need to save first in order to add Spare orders", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnAddPR_Click(sender As Object, e As EventArgs) Handles btnAddPR.Click
        If frmMode = EnumfrmMode.acEditM Then
            Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "add", GetType(frmWO), "workorderid", "<PARAMS SALESORDERID=""" & frmIDX & """ WOTYPE=""PR""/>")
            If Not nr Is Nothing Then myView.RefreshGrid()
        Else
            MsgBox("You need to save first in order to add Project orders", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub

    Private Sub btnEditSOItem_Click(sender As Object, e As EventArgs) Handles btnEditSOItem.Click
        Dim nr As DataRow = WinFormUtils.ButtonActionChildForm(myView, "edit", GetType(frmWO), "workorderid", "")
        If Not nr Is Nothing Then myView.RefreshGrid()
    End Sub

    Private Sub dt_LoiDate_Leave(sender As Object, e As EventArgs) Handles dt_LoiDate.Leave, dt_LoiDate.AfterCloseUp
        HandleDate(dt_PODate.Value, dt_LoiDate.Value)
    End Sub

    Private Sub dt_PODate_Leave(sender As Object, e As EventArgs) Handles dt_PODate.Leave, dt_PODate.AfterCloseUp
        HandleDate(dt_PODate.Value, dt_LoiDate.Value)
    End Sub

    Private Sub HandleDate(PODate As Date, LOIDate As Date)
        Dim dated As Date
        If myUtils.NullNot(PODate) Then dated = LOIDate Else dated = PODate
        dvEmp.RowFilter = risersoft.app.mxform.myFuncs.FilterTimeDependent(dated, "JoinDate", "LeaveDate", 0)
        dvProj.RowFilter = "(CompletedOn Is NULL Or CompletedOn >= '" & Format(dated, "dd-MMM-yyyy") & "') "
    End Sub

    Private Sub UltraGridSOValue_AfterCellUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridSOValue.AfterCellUpdate
        Dim TotalVal As Decimal = 0
        If UltraGridSOValue.Rows.Count > 0 Then
            For Each r3 As DataRow In myViewSOVal.mainGrid.myDS.Tables(0).Select
                TotalVal = TotalVal + myUtils.cValTN(r3("PoValue")) + myUtils.cValTN(r3("PvValue"))
            Next
            txt_TotalValue.Value = TotalVal
        End If
    End Sub
End Class
