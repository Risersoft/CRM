<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSalesOrder
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
       
        Me.InitForm()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_HandledByID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnContractor As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnConsultant As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEndUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_ContractorID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ConsultantID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_EndUserID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_LoINum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_AcceptClauses As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_PODate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_PONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_LoiDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_SendApproveID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_SendAcceptID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_GPClause As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ExClause As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_STClause As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnSelApprove As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelAccept As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_HasPenalty As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_PerMaxPenalty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents arbit As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_perPenalty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents chk_InspFormat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_DoWePayInspec As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_InspecFees As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_NotiPeriod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_insauthname As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_insAuthID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents chk_ReqTransIns As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_FreightByUS As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Freight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_TotalValue As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PayAuthName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_CommAgentID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_PaymentAuthID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGridInsp As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridPay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridBG As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridAdv As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridComm As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelPay As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPay As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelComm As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddComm As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_BGFormat As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_BGperUnit As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents TabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelInsp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddInsp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_RegionID As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_DivisionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmb_ProjectID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnSelTenderNo = New Infragistics.Win.Misc.UltraButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextEnqRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmb_JVPartnerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_WorkName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmb_CompanyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_RegionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_LoINum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_AcceptClauses = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_HandledByID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_PODate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_PONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_LoiDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnDelSO = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditSOItem = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSO = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRO = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPR = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddWO = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnContractor = New Infragistics.Win.Misc.UltraButton()
        Me.btnConsultant = New Infragistics.Win.Misc.UltraButton()
        Me.btnEndUser = New Infragistics.Win.Misc.UltraButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_ContractorID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ConsultantID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_EndUserID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnSelApprove = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelAccept = New Infragistics.Win.Misc.UltraButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_SendApproveID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_SendAcceptID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.UltraGridInsp = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDelInsp = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddInsp = New Infragistics.Win.Misc.UltraButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.chk_InspFormat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_DoWePayInspec = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_InspecFees = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NotiPeriod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_insauthname = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_insAuthID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.UltraGridPay = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnDelPay = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPay = New Infragistics.Win.Misc.UltraButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.chk_ReqTransIns = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_FreightByUS = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_PayAuthName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_PaymentAuthID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSOValue = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.chk_HasPV = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_Freight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_PVBaseDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_TotalValue = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.arbit = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_HasPenalty = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_STClause = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_ExClause = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_BGperUnit = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_BGFormat = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_GPClause = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_PenaltyPeriodType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_perPenalty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_PerMaxPenalty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGridBG = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEditBG = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelBG = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddBG = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UltraGridAdv = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.UltraGridComm = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnDelComm = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddComm = New Infragistics.Win.Misc.UltraButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmb_CommAgentID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridTrns = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnDelTrns = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTrns = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.DataTable1 = New System.Data.DataTable()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.TabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEnqRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_JVPartnerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WorkName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LoINum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AcceptClauses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_HandledByID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_PODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_LoiDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.cmb_ContractorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ConsultantID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.cmb_SendApproveID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SendAcceptID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.UltraGridInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.chk_InspFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_DoWePayInspec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InspecFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NotiPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_insauthname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_insAuthID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.UltraGridPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.chk_ReqTransIns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_FreightByUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PayAuthName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PaymentAuthID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.UltraGridSOValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel19.SuspendLayout()
        CType(Me.chk_HasPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Freight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_PVBaseDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.arbit.SuspendLayout()
        CType(Me.chk_HasPenalty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_STClause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ExClause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_BGperUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_BGFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GPClause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmb_PenaltyPeriodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_perPenalty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PerMaxPenalty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGridBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGridAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.UltraGridComm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.cmb_CommAgentID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraGridTrns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel13)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_DivisionID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label29)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ProjectID)
        Me.UltraTabPageControl1.Controls.Add(Me.btnSelTenderNo)
        Me.UltraTabPageControl1.Controls.Add(Me.Label28)
        Me.UltraTabPageControl1.Controls.Add(Me.TextEnqRefNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label27)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_JVPartnerID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label26)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_WorkName)
        Me.UltraTabPageControl1.Controls.Add(Me.Label25)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_CompanyID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label22)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_RegionID)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_LoINum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_AcceptClauses)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_HandledByID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_PODate)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_PONum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_LoiDate)
        Me.UltraTabPageControl1.Controls.Add(Me.lblRef)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(934, 406)
        '
        'UltraLabel13
        '
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance1
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(393, 163)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel13.TabIndex = 47
        Me.UltraLabel13.Text = "Division"
        '
        'cmb_DivisionID
        '
        Me.cmb_DivisionID.Location = New System.Drawing.Point(440, 159)
        Me.cmb_DivisionID.Name = "cmb_DivisionID"
        Me.cmb_DivisionID.Size = New System.Drawing.Size(168, 22)
        Me.cmb_DivisionID.TabIndex = 46
        Me.cmb_DivisionID.Text = "UltraCombo4"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(9, 363)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 16)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Project Name"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ProjectID
        '
        Me.cmb_ProjectID.Location = New System.Drawing.Point(112, 361)
        Me.cmb_ProjectID.Name = "cmb_ProjectID"
        Me.cmb_ProjectID.Size = New System.Drawing.Size(496, 22)
        Me.cmb_ProjectID.TabIndex = 24
        Me.cmb_ProjectID.Text = "UltraCombo3"
        '
        'btnSelTenderNo
        '
        Me.btnSelTenderNo.Location = New System.Drawing.Point(536, 332)
        Me.btnSelTenderNo.Name = "btnSelTenderNo"
        Me.btnSelTenderNo.Size = New System.Drawing.Size(72, 24)
        Me.btnSelTenderNo.TabIndex = 23
        Me.btnSelTenderNo.Text = "Select"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(8, 332)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 28)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Tender Specn. No."
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextEnqRefNum
        '
        Me.TextEnqRefNum.Location = New System.Drawing.Point(112, 333)
        Me.TextEnqRefNum.Name = "TextEnqRefNum"
        Me.TextEnqRefNum.ReadOnly = True
        Me.TextEnqRefNum.Size = New System.Drawing.Size(418, 21)
        Me.TextEnqRefNum.TabIndex = 22
        Me.TextEnqRefNum.Text = "UltraTextEditor2"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(8, 307)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 16)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Joint Venture"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_JVPartnerID
        '
        Me.cmb_JVPartnerID.Location = New System.Drawing.Point(112, 305)
        Me.cmb_JVPartnerID.Name = "cmb_JVPartnerID"
        Me.cmb_JVPartnerID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_JVPartnerID.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(8, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 16)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Name of Work"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_WorkName
        '
        Me.txt_WorkName.Location = New System.Drawing.Point(112, 131)
        Me.txt_WorkName.Name = "txt_WorkName"
        Me.txt_WorkName.Size = New System.Drawing.Size(496, 21)
        Me.txt_WorkName.TabIndex = 10
        Me.txt_WorkName.Text = "UltraTextEditor2"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(8, 159)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Company"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CompanyID
        '
        Me.cmb_CompanyID.Location = New System.Drawing.Point(112, 159)
        Me.cmb_CompanyID.Name = "cmb_CompanyID"
        Me.cmb_CompanyID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_CompanyID.TabIndex = 12
        Me.cmb_CompanyID.Text = "UltraCombo3"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(8, 277)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Region"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RegionID
        '
        Me.cmb_RegionID.Location = New System.Drawing.Point(112, 277)
        Me.cmb_RegionID.Name = "cmb_RegionID"
        Me.cmb_RegionID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_RegionID.TabIndex = 18
        Me.cmb_RegionID.Text = "UltraCombo3"
        '
        'txt_LoINum
        '
        Me.txt_LoINum.Location = New System.Drawing.Point(112, 72)
        Me.txt_LoINum.Name = "txt_LoINum"
        Me.txt_LoINum.Size = New System.Drawing.Size(256, 21)
        Me.txt_LoINum.TabIndex = 2
        Me.txt_LoINum.Text = "UltraTextEditor1"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(8, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 40)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Order Acceptance Subject To"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_AcceptClauses
        '
        Me.txt_AcceptClauses.AcceptsReturn = True
        Me.txt_AcceptClauses.Location = New System.Drawing.Point(112, 189)
        Me.txt_AcceptClauses.Multiline = True
        Me.txt_AcceptClauses.Name = "txt_AcceptClauses"
        Me.txt_AcceptClauses.Size = New System.Drawing.Size(496, 48)
        Me.txt_AcceptClauses.TabIndex = 14
        Me.txt_AcceptClauses.Text = "UltraTextEditor3"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(8, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Handled By"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_HandledByID
        '
        Me.cmb_HandledByID.Location = New System.Drawing.Point(112, 245)
        Me.cmb_HandledByID.Name = "cmb_HandledByID"
        Me.cmb_HandledByID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_HandledByID.TabIndex = 16
        Me.cmb_HandledByID.Text = "UltraCombo3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(392, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Dated"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_PODate
        '
        Me.dt_PODate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_PODate.FormatString = "dddd dd MMM yyyy"
        Me.dt_PODate.Location = New System.Drawing.Point(440, 104)
        Me.dt_PODate.Name = "dt_PODate"
        Me.dt_PODate.NullText = "Not Defined"
        Me.dt_PODate.Size = New System.Drawing.Size(168, 21)
        Me.dt_PODate.TabIndex = 8
        Me.dt_PODate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(8, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Order No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PONum
        '
        Me.txt_PONum.Location = New System.Drawing.Point(112, 104)
        Me.txt_PONum.Name = "txt_PONum"
        Me.txt_PONum.Size = New System.Drawing.Size(256, 21)
        Me.txt_PONum.TabIndex = 6
        Me.txt_PONum.Text = "UltraTextEditor2"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(392, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dated"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_LoiDate
        '
        Me.dt_LoiDate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_LoiDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_LoiDate.Location = New System.Drawing.Point(440, 72)
        Me.dt_LoiDate.Name = "dt_LoiDate"
        Me.dt_LoiDate.NullText = "Not Defined"
        Me.dt_LoiDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_LoiDate.TabIndex = 4
        Me.dt_LoiDate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(8, 72)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(96, 16)
        Me.lblRef.TabIndex = 1
        Me.lblRef.Text = "LoI No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.cmb_CustomerID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 56)
        Me.Panel1.TabIndex = 0
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(8, 16)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(96, 16)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Customer"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Me.cmb_CustomerID.Location = New System.Drawing.Point(112, 16)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.Size = New System.Drawing.Size(496, 22)
        Me.cmb_CustomerID.TabIndex = 1
        Me.cmb_CustomerID.Text = "UltraCombo3"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl11.Controls.Add(Me.Panel15)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(934, 406)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(934, 378)
        Me.UltraGrid1.TabIndex = 2
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.btnDelSO)
        Me.Panel15.Controls.Add(Me.btnEditSOItem)
        Me.Panel15.Controls.Add(Me.btnAddSO)
        Me.Panel15.Controls.Add(Me.btnAddRO)
        Me.Panel15.Controls.Add(Me.btnAddPR)
        Me.Panel15.Controls.Add(Me.btnAddWO)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel15.Location = New System.Drawing.Point(0, 378)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(934, 28)
        Me.Panel15.TabIndex = 0
        '
        'btnDelSO
        '
        Me.btnDelSO.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelSO.Location = New System.Drawing.Point(504, 0)
        Me.btnDelSO.Name = "btnDelSO"
        Me.btnDelSO.Size = New System.Drawing.Size(70, 28)
        Me.btnDelSO.TabIndex = 0
        Me.btnDelSO.Text = "Delete"
        '
        'btnEditSOItem
        '
        Me.btnEditSOItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditSOItem.Location = New System.Drawing.Point(574, 0)
        Me.btnEditSOItem.Name = "btnEditSOItem"
        Me.btnEditSOItem.Size = New System.Drawing.Size(72, 28)
        Me.btnEditSOItem.TabIndex = 1
        Me.btnEditSOItem.Text = "Edit"
        '
        'btnAddSO
        '
        Me.btnAddSO.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddSO.Location = New System.Drawing.Point(646, 0)
        Me.btnAddSO.Name = "btnAddSO"
        Me.btnAddSO.Size = New System.Drawing.Size(72, 28)
        Me.btnAddSO.TabIndex = 2
        Me.btnAddSO.Text = "Add SP"
        '
        'btnAddRO
        '
        Me.btnAddRO.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddRO.Location = New System.Drawing.Point(718, 0)
        Me.btnAddRO.Name = "btnAddRO"
        Me.btnAddRO.Size = New System.Drawing.Size(72, 28)
        Me.btnAddRO.TabIndex = 3
        Me.btnAddRO.Text = "Add RE"
        '
        'btnAddPR
        '
        Me.btnAddPR.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPR.Location = New System.Drawing.Point(790, 0)
        Me.btnAddPR.Name = "btnAddPR"
        Me.btnAddPR.Size = New System.Drawing.Size(72, 28)
        Me.btnAddPR.TabIndex = 4
        Me.btnAddPR.Text = "Add PR"
        '
        'btnAddWO
        '
        Me.btnAddWO.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddWO.Location = New System.Drawing.Point(862, 0)
        Me.btnAddWO.Name = "btnAddWO"
        Me.btnAddWO.Size = New System.Drawing.Size(72, 28)
        Me.btnAddWO.TabIndex = 5
        Me.btnAddWO.Text = "Add SW"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.btnContractor)
        Me.UltraTabPageControl2.Controls.Add(Me.btnConsultant)
        Me.UltraTabPageControl2.Controls.Add(Me.btnEndUser)
        Me.UltraTabPageControl2.Controls.Add(Me.Label13)
        Me.UltraTabPageControl2.Controls.Add(Me.Label12)
        Me.UltraTabPageControl2.Controls.Add(Me.Label11)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ContractorID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ConsultantID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_EndUserID)
        Me.UltraTabPageControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(934, 406)
        '
        'btnContractor
        '
        Me.btnContractor.Location = New System.Drawing.Point(496, 224)
        Me.btnContractor.Name = "btnContractor"
        Me.btnContractor.Size = New System.Drawing.Size(120, 24)
        Me.btnContractor.TabIndex = 11
        Me.btnContractor.Text = "Same as Customer"
        '
        'btnConsultant
        '
        Me.btnConsultant.Location = New System.Drawing.Point(496, 168)
        Me.btnConsultant.Name = "btnConsultant"
        Me.btnConsultant.Size = New System.Drawing.Size(120, 24)
        Me.btnConsultant.TabIndex = 7
        Me.btnConsultant.Text = "Same as Customer"
        '
        'btnEndUser
        '
        Me.btnEndUser.Location = New System.Drawing.Point(496, 112)
        Me.btnEndUser.Name = "btnEndUser"
        Me.btnEndUser.Size = New System.Drawing.Size(120, 24)
        Me.btnEndUser.TabIndex = 3
        Me.btnEndUser.Text = "Same as Customer"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(16, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Contractor"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(16, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Consultant"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(16, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "End User"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ContractorID
        '
        Me.cmb_ContractorID.Location = New System.Drawing.Point(120, 224)
        Me.cmb_ContractorID.Name = "cmb_ContractorID"
        Me.cmb_ContractorID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ContractorID.TabIndex = 10
        Me.cmb_ContractorID.Text = "UltraCombo5"
        '
        'cmb_ConsultantID
        '
        Me.cmb_ConsultantID.Location = New System.Drawing.Point(120, 168)
        Me.cmb_ConsultantID.Name = "cmb_ConsultantID"
        Me.cmb_ConsultantID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ConsultantID.TabIndex = 6
        Me.cmb_ConsultantID.Text = "UltraCombo2"
        '
        'cmb_EndUserID
        '
        Me.cmb_EndUserID.Location = New System.Drawing.Point(120, 112)
        Me.cmb_EndUserID.Name = "cmb_EndUserID"
        Me.cmb_EndUserID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_EndUserID.TabIndex = 2
        Me.cmb_EndUserID.Text = "UltraCombo1"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.btnSelApprove)
        Me.UltraTabPageControl5.Controls.Add(Me.btnSelAccept)
        Me.UltraTabPageControl5.Controls.Add(Me.Label24)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_SendApproveID)
        Me.UltraTabPageControl5.Controls.Add(Me.Label23)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_SendAcceptID)
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(934, 406)
        '
        'btnSelApprove
        '
        Me.btnSelApprove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelApprove.Location = New System.Drawing.Point(488, 192)
        Me.btnSelApprove.Name = "btnSelApprove"
        Me.btnSelApprove.Size = New System.Drawing.Size(72, 24)
        Me.btnSelApprove.TabIndex = 6
        Me.btnSelApprove.Text = "Select"
        '
        'btnSelAccept
        '
        Me.btnSelAccept.Location = New System.Drawing.Point(488, 120)
        Me.btnSelAccept.Name = "btnSelAccept"
        Me.btnSelAccept.Size = New System.Drawing.Size(72, 24)
        Me.btnSelAccept.TabIndex = 3
        Me.btnSelAccept.Text = "Select"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(96, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 32)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Send Documents for Approval To"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_SendApproveID
        '
        Me.cmb_SendApproveID.Location = New System.Drawing.Point(200, 160)
        Me.cmb_SendApproveID.Name = "cmb_SendApproveID"
        Me.cmb_SendApproveID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_SendApproveID.TabIndex = 5
        Me.cmb_SendApproveID.Text = "UltraCombo3"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(96, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 32)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Send Order Acceptance To"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_SendAcceptID
        '
        Me.cmb_SendAcceptID.Location = New System.Drawing.Point(200, 88)
        Me.cmb_SendAcceptID.Name = "cmb_SendAcceptID"
        Me.cmb_SendAcceptID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_SendAcceptID.TabIndex = 2
        Me.cmb_SendAcceptID.Text = "UltraCombo3"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(934, 406)
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.UltraGridInsp)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 144)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(934, 262)
        Me.Panel8.TabIndex = 14
        '
        'UltraGridInsp
        '
        Me.UltraGridInsp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridInsp.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridInsp.Name = "UltraGridInsp"
        Me.UltraGridInsp.Size = New System.Drawing.Size(934, 234)
        Me.UltraGridInsp.TabIndex = 0
        Me.UltraGridInsp.Text = "Send Inspection Copies to"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnDelInsp)
        Me.Panel9.Controls.Add(Me.btnAddInsp)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 234)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(934, 28)
        Me.Panel9.TabIndex = 1
        '
        'btnDelInsp
        '
        Me.btnDelInsp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelInsp.Location = New System.Drawing.Point(792, 0)
        Me.btnDelInsp.Name = "btnDelInsp"
        Me.btnDelInsp.Size = New System.Drawing.Size(70, 28)
        Me.btnDelInsp.TabIndex = 0
        Me.btnDelInsp.Text = "Delete"
        '
        'btnAddInsp
        '
        Me.btnAddInsp.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddInsp.Location = New System.Drawing.Point(862, 0)
        Me.btnAddInsp.Name = "btnAddInsp"
        Me.btnAddInsp.Size = New System.Drawing.Size(72, 28)
        Me.btnAddInsp.TabIndex = 1
        Me.btnAddInsp.Text = "Add New"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.chk_InspFormat)
        Me.Panel7.Controls.Add(Me.chk_DoWePayInspec)
        Me.Panel7.Controls.Add(Me.txt_InspecFees)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.txt_NotiPeriod)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.txt_insauthname)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Controls.Add(Me.cmb_insAuthID)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(934, 144)
        Me.Panel7.TabIndex = 0
        '
        'chk_InspFormat
        '
        Me.chk_InspFormat.Location = New System.Drawing.Point(334, 112)
        Me.chk_InspFormat.Name = "chk_InspFormat"
        Me.chk_InspFormat.Size = New System.Drawing.Size(168, 24)
        Me.chk_InspFormat.TabIndex = 8
        Me.chk_InspFormat.Text = "Custom Inspection Format"
        '
        'chk_DoWePayInspec
        '
        Me.chk_DoWePayInspec.Location = New System.Drawing.Point(486, 24)
        Me.chk_DoWePayInspec.Name = "chk_DoWePayInspec"
        Me.chk_DoWePayInspec.Size = New System.Drawing.Size(168, 24)
        Me.chk_DoWePayInspec.TabIndex = 2
        Me.chk_DoWePayInspec.Text = "Paid By Us"
        '
        'txt_InspecFees
        '
        Me.txt_InspecFees.Location = New System.Drawing.Point(126, 112)
        Me.txt_InspecFees.Name = "txt_InspecFees"
        Me.txt_InspecFees.Size = New System.Drawing.Size(192, 21)
        Me.txt_InspecFees.TabIndex = 7
        Me.txt_InspecFees.Text = "UltraTextEditor3"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Inspection Fees"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NotiPeriod
        '
        Me.txt_NotiPeriod.Location = New System.Drawing.Point(126, 80)
        Me.txt_NotiPeriod.Name = "txt_NotiPeriod"
        Me.txt_NotiPeriod.Size = New System.Drawing.Size(344, 21)
        Me.txt_NotiPeriod.TabIndex = 5
        Me.txt_NotiPeriod.Text = "UltraTextEditor2"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(14, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Notification Period"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_insauthname
        '
        Me.txt_insauthname.Location = New System.Drawing.Point(86, 24)
        Me.txt_insauthname.Name = "txt_insauthname"
        Me.txt_insauthname.Size = New System.Drawing.Size(384, 21)
        Me.txt_insauthname.TabIndex = 1
        Me.txt_insauthname.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inspection Authority"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_insAuthID
        '
        Me.cmb_insAuthID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_insAuthID.Location = New System.Drawing.Point(86, 48)
        Me.cmb_insAuthID.Name = "cmb_insAuthID"
        Me.cmb_insAuthID.Size = New System.Drawing.Size(384, 22)
        Me.cmb_insAuthID.TabIndex = 3
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Panel11)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel10)
        Me.UltraTabPageControl6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(934, 406)
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.UltraGridPay)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 81)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(934, 325)
        Me.Panel11.TabIndex = 14
        '
        'UltraGridPay
        '
        Me.UltraGridPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPay.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridPay.Name = "UltraGridPay"
        Me.UltraGridPay.Size = New System.Drawing.Size(934, 297)
        Me.UltraGridPay.TabIndex = 0
        Me.UltraGridPay.Text = "Payment Terms"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnDelPay)
        Me.Panel12.Controls.Add(Me.btnAddPay)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 297)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(934, 28)
        Me.Panel12.TabIndex = 1
        '
        'btnDelPay
        '
        Me.btnDelPay.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelPay.Location = New System.Drawing.Point(792, 0)
        Me.btnDelPay.Name = "btnDelPay"
        Me.btnDelPay.Size = New System.Drawing.Size(70, 28)
        Me.btnDelPay.TabIndex = 0
        Me.btnDelPay.Text = "Delete"
        '
        'btnAddPay
        '
        Me.btnAddPay.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPay.Location = New System.Drawing.Point(862, 0)
        Me.btnAddPay.Name = "btnAddPay"
        Me.btnAddPay.Size = New System.Drawing.Size(72, 28)
        Me.btnAddPay.TabIndex = 1
        Me.btnAddPay.Text = "Add New"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.chk_ReqTransIns)
        Me.Panel10.Controls.Add(Me.chk_FreightByUS)
        Me.Panel10.Controls.Add(Me.txt_PayAuthName)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.cmb_PaymentAuthID)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(934, 81)
        Me.Panel10.TabIndex = 0
        '
        'chk_ReqTransIns
        '
        Me.chk_ReqTransIns.AutoSize = True
        Me.chk_ReqTransIns.Location = New System.Drawing.Point(534, 21)
        Me.chk_ReqTransIns.Name = "chk_ReqTransIns"
        Me.chk_ReqTransIns.Size = New System.Drawing.Size(172, 17)
        Me.chk_ReqTransIns.TabIndex = 9
        Me.chk_ReqTransIns.Text = "Transport Insurance Required"
        '
        'chk_FreightByUS
        '
        Me.chk_FreightByUS.AutoSize = True
        Me.chk_FreightByUS.Location = New System.Drawing.Point(782, 21)
        Me.chk_FreightByUS.Name = "chk_FreightByUS"
        Me.chk_FreightByUS.Size = New System.Drawing.Size(77, 17)
        Me.chk_FreightByUS.TabIndex = 10
        Me.chk_FreightByUS.Text = "Paid By Us"
        '
        'txt_PayAuthName
        '
        Me.txt_PayAuthName.Location = New System.Drawing.Point(71, 17)
        Me.txt_PayAuthName.Name = "txt_PayAuthName"
        Me.txt_PayAuthName.Size = New System.Drawing.Size(344, 21)
        Me.txt_PayAuthName.TabIndex = 1
        Me.txt_PayAuthName.Text = "UltraTextEditor4"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 48)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Payment Authority"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PaymentAuthID
        '
        Me.cmb_PaymentAuthID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PaymentAuthID.Location = New System.Drawing.Point(71, 44)
        Me.cmb_PaymentAuthID.Name = "cmb_PaymentAuthID"
        Me.cmb_PaymentAuthID.Size = New System.Drawing.Size(344, 22)
        Me.cmb_PaymentAuthID.TabIndex = 2
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.UltraGridSOValue)
        Me.UltraTabPageControl12.Controls.Add(Me.Panel19)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(934, 406)
        '
        'UltraGridSOValue
        '
        Me.UltraGridSOValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSOValue.Location = New System.Drawing.Point(0, 85)
        Me.UltraGridSOValue.Name = "UltraGridSOValue"
        Me.UltraGridSOValue.Size = New System.Drawing.Size(934, 321)
        Me.UltraGridSOValue.TabIndex = 1
        Me.UltraGridSOValue.Text = "Order Value"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.chk_HasPV)
        Me.Panel19.Controls.Add(Me.txt_Freight)
        Me.Panel19.Controls.Add(Me.UltraLabel1)
        Me.Panel19.Controls.Add(Me.dt_PVBaseDate)
        Me.Panel19.Controls.Add(Me.lblDate)
        Me.Panel19.Controls.Add(Me.Label14)
        Me.Panel19.Controls.Add(Me.txt_TotalValue)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(934, 85)
        Me.Panel19.TabIndex = 2
        '
        'chk_HasPV
        '
        Me.chk_HasPV.AutoSize = True
        Me.chk_HasPV.Enabled = False
        Me.chk_HasPV.Location = New System.Drawing.Point(410, 51)
        Me.chk_HasPV.Name = "chk_HasPV"
        Me.chk_HasPV.Size = New System.Drawing.Size(36, 17)
        Me.chk_HasPV.TabIndex = 49
        Me.chk_HasPV.Text = "PV"
        '
        'txt_Freight
        '
        Me.txt_Freight.Location = New System.Drawing.Point(778, 12)
        Me.txt_Freight.Name = "txt_Freight"
        Me.txt_Freight.ReadOnly = True
        Me.txt_Freight.Size = New System.Drawing.Size(147, 21)
        Me.txt_Freight.TabIndex = 6
        Me.txt_Freight.Text = "UltraTextEditor6"
        '
        'UltraLabel1
        '
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.TextHAlignAsString = "Right"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance2
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(654, 52)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(121, 14)
        Me.UltraLabel1.TabIndex = 48
        Me.UltraLabel1.Text = "Total Value (Ex Works)"
        '
        'dt_PVBaseDate
        '
        Me.dt_PVBaseDate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_PVBaseDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_PVBaseDate.Location = New System.Drawing.Point(136, 49)
        Me.dt_PVBaseDate.Name = "dt_PVBaseDate"
        Me.dt_PVBaseDate.NullText = "Not Defined"
        Me.dt_PVBaseDate.Size = New System.Drawing.Size(160, 21)
        Me.dt_PVBaseDate.TabIndex = 8
        Me.dt_PVBaseDate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(22, 50)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(112, 16)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "PV Base Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(705, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 14)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Freight Value"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_TotalValue
        '
        Me.txt_TotalValue.Location = New System.Drawing.Point(778, 49)
        Me.txt_TotalValue.Name = "txt_TotalValue"
        Me.txt_TotalValue.ReadOnly = True
        Me.txt_TotalValue.Size = New System.Drawing.Size(147, 21)
        Me.txt_TotalValue.TabIndex = 4
        Me.txt_TotalValue.Text = "UltraTextEditor5"
        '
        'arbit
        '
        Me.arbit.Controls.Add(Me.chk_HasPenalty)
        Me.arbit.Controls.Add(Me.Label17)
        Me.arbit.Controls.Add(Me.cmb_STClause)
        Me.arbit.Controls.Add(Me.Label16)
        Me.arbit.Controls.Add(Me.txt_ExClause)
        Me.arbit.Controls.Add(Me.chk_BGperUnit)
        Me.arbit.Controls.Add(Me.chk_BGFormat)
        Me.arbit.Controls.Add(Me.Label15)
        Me.arbit.Controls.Add(Me.txt_GPClause)
        Me.arbit.Controls.Add(Me.GroupBox1)
        Me.arbit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbit.Location = New System.Drawing.Point(-10000, -10000)
        Me.arbit.Name = "arbit"
        Me.arbit.Size = New System.Drawing.Size(934, 406)
        '
        'chk_HasPenalty
        '
        Me.chk_HasPenalty.Location = New System.Drawing.Point(176, 240)
        Me.chk_HasPenalty.Name = "chk_HasPenalty"
        Me.chk_HasPenalty.Size = New System.Drawing.Size(104, 24)
        Me.chk_HasPenalty.TabIndex = 8
        Me.chk_HasPenalty.Text = "Penalty Clause"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(40, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 24)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Sales Tax Clause"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_STClause
        '
        Me.cmb_STClause.Location = New System.Drawing.Point(160, 192)
        Me.cmb_STClause.Name = "cmb_STClause"
        Me.cmb_STClause.Size = New System.Drawing.Size(328, 21)
        Me.cmb_STClause.TabIndex = 7
        Me.cmb_STClause.Text = "Try"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(40, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 24)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Excise Clause"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ExClause
        '
        Me.txt_ExClause.AcceptsReturn = True
        Me.txt_ExClause.Location = New System.Drawing.Point(160, 152)
        Me.txt_ExClause.Multiline = True
        Me.txt_ExClause.Name = "txt_ExClause"
        Me.txt_ExClause.Size = New System.Drawing.Size(424, 24)
        Me.txt_ExClause.TabIndex = 5
        Me.txt_ExClause.Text = "UltraTextEditor3"
        '
        'chk_BGperUnit
        '
        Me.chk_BGperUnit.Location = New System.Drawing.Point(344, 120)
        Me.chk_BGperUnit.Name = "chk_BGperUnit"
        Me.chk_BGperUnit.Size = New System.Drawing.Size(168, 24)
        Me.chk_BGperUnit.TabIndex = 3
        Me.chk_BGperUnit.Text = "BG Required for every Unit"
        '
        'chk_BGFormat
        '
        Me.chk_BGFormat.Location = New System.Drawing.Point(160, 120)
        Me.chk_BGFormat.Name = "chk_BGFormat"
        Me.chk_BGFormat.Size = New System.Drawing.Size(168, 24)
        Me.chk_BGFormat.TabIndex = 2
        Me.chk_BGFormat.Text = "Custom BG Format"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(40, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 48)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Guarantee Period Clause"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_GPClause
        '
        Me.txt_GPClause.AcceptsReturn = True
        Me.txt_GPClause.Location = New System.Drawing.Point(160, 64)
        Me.txt_GPClause.Multiline = True
        Me.txt_GPClause.Name = "txt_GPClause"
        Me.txt_GPClause.Size = New System.Drawing.Size(424, 48)
        Me.txt_GPClause.TabIndex = 1
        Me.txt_GPClause.Text = "UltraTextEditor3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_PenaltyPeriodType)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_perPenalty)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_PerMaxPenalty)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 64)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cmb_PenaltyPeriodType
        '
        Me.cmb_PenaltyPeriodType.Location = New System.Drawing.Point(118, 21)
        Me.cmb_PenaltyPeriodType.Name = "cmb_PenaltyPeriodType"
        Me.cmb_PenaltyPeriodType.Size = New System.Drawing.Size(108, 22)
        Me.cmb_PenaltyPeriodType.TabIndex = 2
        Me.cmb_PenaltyPeriodType.Text = "UltraCombo3"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(392, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "%"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(232, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "for a max. of"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_perPenalty
        '
        Me.txt_perPenalty.Location = New System.Drawing.Point(8, 24)
        Me.txt_perPenalty.Name = "txt_perPenalty"
        Me.txt_perPenalty.Size = New System.Drawing.Size(56, 21)
        Me.txt_perPenalty.TabIndex = 0
        Me.txt_perPenalty.Text = "UltraTextEditor1"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(72, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "% per"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PerMaxPenalty
        '
        Me.txt_PerMaxPenalty.Location = New System.Drawing.Point(304, 24)
        Me.txt_PerMaxPenalty.Name = "txt_PerMaxPenalty"
        Me.txt_PerMaxPenalty.Size = New System.Drawing.Size(88, 21)
        Me.txt_PerMaxPenalty.TabIndex = 4
        Me.txt_PerMaxPenalty.Text = "UltraTextEditor1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(934, 406)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridBG)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(934, 406)
        Me.Panel2.TabIndex = 13
        '
        'UltraGridBG
        '
        Me.UltraGridBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBG.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBG.Name = "UltraGridBG"
        Me.UltraGridBG.Size = New System.Drawing.Size(934, 378)
        Me.UltraGridBG.TabIndex = 0
        Me.UltraGridBG.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditBG)
        Me.Panel3.Controls.Add(Me.btnDelBG)
        Me.Panel3.Controls.Add(Me.btnAddBG)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(934, 28)
        Me.Panel3.TabIndex = 1
        '
        'btnEditBG
        '
        Me.btnEditBG.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditBG.Location = New System.Drawing.Point(720, 0)
        Me.btnEditBG.Name = "btnEditBG"
        Me.btnEditBG.Size = New System.Drawing.Size(72, 28)
        Me.btnEditBG.TabIndex = 0
        Me.btnEditBG.Text = "Edit"
        '
        'btnDelBG
        '
        Me.btnDelBG.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelBG.Location = New System.Drawing.Point(792, 0)
        Me.btnDelBG.Name = "btnDelBG"
        Me.btnDelBG.Size = New System.Drawing.Size(70, 28)
        Me.btnDelBG.TabIndex = 1
        Me.btnDelBG.Text = "Delete"
        '
        'btnAddBG
        '
        Me.btnAddBG.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddBG.Location = New System.Drawing.Point(862, 0)
        Me.btnAddBG.Name = "btnAddBG"
        Me.btnAddBG.Size = New System.Drawing.Size(72, 28)
        Me.btnAddBG.TabIndex = 2
        Me.btnAddBG.Text = "Add New"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(934, 406)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.UltraGridAdv)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(934, 406)
        Me.Panel5.TabIndex = 13
        '
        'UltraGridAdv
        '
        Me.UltraGridAdv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridAdv.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridAdv.Name = "UltraGridAdv"
        Me.UltraGridAdv.Size = New System.Drawing.Size(934, 406)
        Me.UltraGridAdv.TabIndex = 0
        Me.UltraGridAdv.Text = "Delivery Schedule"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Panel13)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(934, 406)
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.UltraGridDoc)
        Me.Panel13.Controls.Add(Me.Panel14)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(934, 406)
        Me.Panel13.TabIndex = 13
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(934, 378)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Document Requirements"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.btnDelDoc)
        Me.Panel14.Controls.Add(Me.btnAddDoc)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel14.Location = New System.Drawing.Point(0, 378)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(934, 28)
        Me.Panel14.TabIndex = 1
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelDoc.Location = New System.Drawing.Point(792, 0)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 28)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddDoc.Location = New System.Drawing.Point(862, 0)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 28)
        Me.btnAddDoc.TabIndex = 1
        Me.btnAddDoc.Text = "Add New"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.Panel16)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(934, 406)
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.UltraGridComm)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.Panel6)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(934, 406)
        Me.Panel16.TabIndex = 14
        '
        'UltraGridComm
        '
        Me.UltraGridComm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridComm.Location = New System.Drawing.Point(0, 55)
        Me.UltraGridComm.Name = "UltraGridComm"
        Me.UltraGridComm.Size = New System.Drawing.Size(934, 323)
        Me.UltraGridComm.TabIndex = 1
        Me.UltraGridComm.Text = "Commission Agent Payment Terms"
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.btnDelComm)
        Me.Panel17.Controls.Add(Me.btnAddComm)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 378)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(934, 28)
        Me.Panel17.TabIndex = 2
        '
        'btnDelComm
        '
        Me.btnDelComm.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelComm.Location = New System.Drawing.Point(792, 0)
        Me.btnDelComm.Name = "btnDelComm"
        Me.btnDelComm.Size = New System.Drawing.Size(70, 28)
        Me.btnDelComm.TabIndex = 0
        Me.btnDelComm.Text = "Delete"
        '
        'btnAddComm
        '
        Me.btnAddComm.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddComm.Location = New System.Drawing.Point(862, 0)
        Me.btnAddComm.Name = "btnAddComm"
        Me.btnAddComm.Size = New System.Drawing.Size(72, 28)
        Me.btnAddComm.TabIndex = 1
        Me.btnAddComm.Text = "Add New"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmb_CommAgentID)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(934, 55)
        Me.Panel6.TabIndex = 0
        '
        'cmb_CommAgentID
        '
        Me.cmb_CommAgentID.Location = New System.Drawing.Point(112, 15)
        Me.cmb_CommAgentID.Name = "cmb_CommAgentID"
        Me.cmb_CommAgentID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_CommAgentID.TabIndex = 1
        Me.cmb_CommAgentID.Text = "UltraCombo5"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(38, 7)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 40)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Commission Agent"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.UltraGridTrns)
        Me.UltraTabPageControl10.Controls.Add(Me.Panel18)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(934, 406)
        '
        'UltraGridTrns
        '
        Me.UltraGridTrns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTrns.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTrns.Name = "UltraGridTrns"
        Me.UltraGridTrns.Size = New System.Drawing.Size(934, 378)
        Me.UltraGridTrns.TabIndex = 3
        Me.UltraGridTrns.Text = "Transport"
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.btnDelTrns)
        Me.Panel18.Controls.Add(Me.btnAddTrns)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Location = New System.Drawing.Point(0, 378)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(934, 28)
        Me.Panel18.TabIndex = 2
        '
        'btnDelTrns
        '
        Me.btnDelTrns.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelTrns.Location = New System.Drawing.Point(792, 0)
        Me.btnDelTrns.Name = "btnDelTrns"
        Me.btnDelTrns.Size = New System.Drawing.Size(70, 28)
        Me.btnDelTrns.TabIndex = 1
        Me.btnDelTrns.Text = "Delete"
        '
        'btnAddTrns
        '
        Me.btnAddTrns.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddTrns.Location = New System.Drawing.Point(862, 0)
        Me.btnAddTrns.Name = "btnAddTrns"
        Me.btnAddTrns.Size = New System.Drawing.Size(72, 28)
        Me.btnAddTrns.TabIndex = 2
        Me.btnAddTrns.Text = "Add New"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 432)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(938, 42)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(674, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(762, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(850, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'DataTable1
        '
        Me.DataTable1.TableName = "Items"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(934, 406)
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl1)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl2)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl4)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.TabControl2.Controls.Add(Me.arbit)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl3)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl7)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl8)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl9)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl11)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl10)
        Me.TabControl2.Controls.Add(Me.UltraTabPageControl12)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Appearance6.FontData.BoldAsString = "True"
        Me.TabControl2.SelectedTabAppearance = Appearance6
        Me.TabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabControl2.Size = New System.Drawing.Size(938, 432)
        Me.TabControl2.TabIndex = 0
        Me.TabControl2.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.TabPage = Me.UltraTabPageControl11
        UltraTab2.Text = "Work Units"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Info"
        UltraTab4.TabPage = Me.UltraTabPageControl5
        UltraTab4.Text = "Contacts"
        UltraTab5.TabPage = Me.UltraTabPageControl4
        UltraTab5.Text = "Inspection"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Payments"
        UltraTab13.TabPage = Me.UltraTabPageControl12
        UltraTab13.Text = "Order Value"
        UltraTab7.TabPage = Me.arbit
        UltraTab7.Text = "Clauses"
        UltraTab8.TabPage = Me.UltraTabPageControl3
        UltraTab8.Text = "Bank Guarantees"
        UltraTab9.TabPage = Me.UltraTabPageControl7
        UltraTab9.Text = "Advances"
        UltraTab10.TabPage = Me.UltraTabPageControl8
        UltraTab10.Text = "Doc Requirement"
        UltraTab11.TabPage = Me.UltraTabPageControl9
        UltraTab11.Text = "Comm. Agent"
        UltraTab12.Key = "11"
        UltraTab12.TabPage = Me.UltraTabPageControl10
        UltraTab12.Text = "SO Transport"
        Me.TabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab13, UltraTab7, UltraTab8, UltraTab9, UltraTab10, UltraTab11, UltraTab12})
        Me.TabControl2.TabsPerRow = 5
        '
        'frmSalesOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Order"
        Me.ClientSize = New System.Drawing.Size(938, 474)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesOrder"
        Me.Text = "Order"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEnqRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_JVPartnerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WorkName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LoINum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AcceptClauses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_HandledByID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_PODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_LoiDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.cmb_ContractorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ConsultantID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
        CType(Me.cmb_SendApproveID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SendAcceptID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.UltraGridInsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.chk_InspFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_DoWePayInspec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InspecFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NotiPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_insauthname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_insAuthID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.UltraGridPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.chk_ReqTransIns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_FreightByUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PayAuthName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PaymentAuthID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.UltraGridSOValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.chk_HasPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Freight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_PVBaseDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.arbit.ResumeLayout(False)
        Me.arbit.PerformLayout()
        CType(Me.chk_HasPenalty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_STClause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ExClause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_BGperUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_BGFormat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GPClause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmb_PenaltyPeriodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_perPenalty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PerMaxPenalty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGridAdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        CType(Me.UltraGridComm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.cmb_CommAgentID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraGridTrns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_PVBaseDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents cmb_CustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_PenaltyPeriodType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents btnEditSOItem As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelSO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddWO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPR As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmb_CompanyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_WorkName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridTrns As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel18 As Windows.Forms.Panel
    Friend WithEvents btnDelTrns As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddTrns As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents cmb_JVPartnerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label28 As Windows.Forms.Label
    Friend WithEvents TextEnqRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnSelTenderNo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents cmb_ProjectID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_DivisionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSOValue As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_HasPV As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Panel19 As Windows.Forms.Panel

#End Region
End Class

