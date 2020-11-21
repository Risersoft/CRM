<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSalesEnq
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chk_IsRepair As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_EnqRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_IsRateContract As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents dt_EnqDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_ConsultantID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dt_RecvDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_DueDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_OpenDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_OfferDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_OfferNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_HandledByID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_ContractorID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_ccConsultant As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_cccontractor As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_QuickTE As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_NoTimeReq As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_NumCopies As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_EMDPart As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_PricePart As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_CommPart As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_TechPart As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumParts As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Part1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Part2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Part3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_AddressToID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_SentByID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_DispMode As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_FnIUpto As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Description As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_ProjectName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents btnContractor As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnConsultant As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelAddTo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelSentBy As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridTerm As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridBG As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditBG As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_RegionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnEditRat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRat As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_DesignRatWise = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_ActionReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_NoTimeReq = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_QuickTE = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_HandledByID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_OfferDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_OfferNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_OpenDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.dt_DueDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.dt_RecvDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.chk_IsRateContract = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_IsRepair = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnEditRat = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRat = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnEdit = New Infragistics.Win.Misc.UltraButton()
        Me.PanelEU = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmb_EURegionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnEndUser = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_Priority = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.chk_ccEndUser = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_EndUserID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnAddProj = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelProj = New Infragistics.Win.Misc.UltraButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmb_ProjectID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_ProjectName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnContractor = New Infragistics.Win.Misc.UltraButton()
        Me.btnConsultant = New Infragistics.Win.Misc.UltraButton()
        Me.chk_cccontractor = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_ccConsultant = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_ContractorID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_ConsultantID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_Part3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Part2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Part1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_NumParts = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_EMDPart = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_PricePart = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_CommPart = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_TechPart = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_NumCopies = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridTerm = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnSelAddTo = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelSentBy = New Infragistics.Win.Misc.UltraButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_Description = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_FnIUpto = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_DispMode = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_AddressToID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_SentByID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UltraGridBG = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnEditBG = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelBG = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddBG = New Infragistics.Win.Misc.UltraButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_RegionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_EnqDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txt_EnqRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmb_EnqType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_CampusID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_DivisionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.chk_DesignRatWise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ActionReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_NoTimeReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_QuickTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_HandledByID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OfferDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OfferNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OpenDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_RecvDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsRateContract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.PanelEU.SuspendLayout()
        CType(Me.cmb_EURegionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Priority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ccEndUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_cccontractor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ccConsultant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ContractorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ConsultantID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.txt_Part3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Part2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Part1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmb_EMDPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PricePart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CommPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TechPart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGridTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FnIUpto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DispMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_AddressToID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SentByID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGridBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_EnqDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EnqRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_EnqType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CampusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.chk_DesignRatWise)
        Me.UltraTabPageControl1.Controls.Add(Me.Label32)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ActionReq)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_NoTimeReq)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_QuickTE)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Remark)
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_StatusNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_HandledByID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_OfferDate)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_OfferNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label5)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_OpenDate)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_DueDate)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_RecvDate)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsRateContract)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsRepair)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(765, 320)
        '
        'chk_DesignRatWise
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.chk_DesignRatWise.Appearance = Appearance1
        Me.chk_DesignRatWise.Location = New System.Drawing.Point(488, 200)
        Me.chk_DesignRatWise.Name = "chk_DesignRatWise"
        Me.chk_DesignRatWise.Size = New System.Drawing.Size(144, 24)
        Me.chk_DesignRatWise.TabIndex = 18
        Me.chk_DesignRatWise.Text = "Show in Design - Rating Wise"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label32.Location = New System.Drawing.Point(16, 229)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 16)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "Action Required"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ActionReq
        '
        Me.txt_ActionReq.AcceptsReturn = True
        Me.txt_ActionReq.Location = New System.Drawing.Point(120, 229)
        Me.txt_ActionReq.Multiline = True
        Me.txt_ActionReq.Name = "txt_ActionReq"
        Me.txt_ActionReq.Size = New System.Drawing.Size(424, 39)
        Me.txt_ActionReq.TabIndex = 20
        Me.txt_ActionReq.Text = "UltraTextEditor3"
        '
        'chk_NoTimeReq
        '
        Me.chk_NoTimeReq.Location = New System.Drawing.Point(358, 73)
        Me.chk_NoTimeReq.Name = "chk_NoTimeReq"
        Me.chk_NoTimeReq.Size = New System.Drawing.Size(128, 24)
        Me.chk_NoTimeReq.TabIndex = 7
        Me.chk_NoTimeReq.Text = "Do not require time"
        '
        'chk_QuickTE
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.chk_QuickTE.Appearance = Appearance2
        Me.chk_QuickTE.Location = New System.Drawing.Point(358, 41)
        Me.chk_QuickTE.Name = "chk_QuickTE"
        Me.chk_QuickTE.Size = New System.Drawing.Size(128, 24)
        Me.chk_QuickTE.TabIndex = 4
        Me.chk_QuickTE.Text = "Quick TE"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(16, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(120, 274)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(424, 48)
        Me.txt_Remark.TabIndex = 22
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(16, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Status"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(120, 201)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(360, 22)
        Me.cmb_StatusNum.TabIndex = 17
        Me.cmb_StatusNum.Text = "UltraCombo3"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(16, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Handled By"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_HandledByID
        '
        Me.cmb_HandledByID.Location = New System.Drawing.Point(120, 169)
        Me.cmb_HandledByID.Name = "cmb_HandledByID"
        Me.cmb_HandledByID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_HandledByID.TabIndex = 15
        Me.cmb_HandledByID.Text = "UltraCombo3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(400, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Dated"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_OfferDate
        '
        Me.dt_OfferDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_OfferDate.Location = New System.Drawing.Point(448, 137)
        Me.dt_OfferDate.Name = "dt_OfferDate"
        Me.dt_OfferDate.NullText = "Not Defined"
        Me.dt_OfferDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_OfferDate.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(16, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Offer No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_OfferNum
        '
        Me.txt_OfferNum.Location = New System.Drawing.Point(120, 137)
        Me.txt_OfferNum.Name = "txt_OfferNum"
        Me.txt_OfferNum.Size = New System.Drawing.Size(256, 21)
        Me.txt_OfferNum.TabIndex = 11
        Me.txt_OfferNum.Text = "UltraTextEditor2"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(16, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Opening Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Due Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(16, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recieved On"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_OpenDate
        '
        Me.dt_OpenDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_OpenDate.Location = New System.Drawing.Point(120, 105)
        Me.dt_OpenDate.Name = "dt_OpenDate"
        Me.dt_OpenDate.NullText = "Not Defined"
        Me.dt_OpenDate.Size = New System.Drawing.Size(232, 21)
        Me.dt_OpenDate.TabIndex = 9
        '
        'dt_DueDate
        '
        Me.dt_DueDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_DueDate.Location = New System.Drawing.Point(120, 73)
        Me.dt_DueDate.Name = "dt_DueDate"
        Me.dt_DueDate.NullText = "Not Defined"
        Me.dt_DueDate.Size = New System.Drawing.Size(232, 21)
        Me.dt_DueDate.TabIndex = 6
        '
        'dt_RecvDate
        '
        Me.dt_RecvDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_RecvDate.Location = New System.Drawing.Point(120, 41)
        Me.dt_RecvDate.Name = "dt_RecvDate"
        Me.dt_RecvDate.NullText = "Not Defined"
        Me.dt_RecvDate.Size = New System.Drawing.Size(232, 21)
        Me.dt_RecvDate.TabIndex = 3
        '
        'chk_IsRateContract
        '
        Me.chk_IsRateContract.Location = New System.Drawing.Point(192, 9)
        Me.chk_IsRateContract.Name = "chk_IsRateContract"
        Me.chk_IsRateContract.Size = New System.Drawing.Size(112, 24)
        Me.chk_IsRateContract.TabIndex = 1
        Me.chk_IsRateContract.Text = "Rate Contract"
        '
        'chk_IsRepair
        '
        Me.chk_IsRepair.Location = New System.Drawing.Point(120, 9)
        Me.chk_IsRepair.Name = "chk_IsRepair"
        Me.chk_IsRepair.Size = New System.Drawing.Size(72, 24)
        Me.chk_IsRepair.TabIndex = 0
        Me.chk_IsRepair.Text = "Repair"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl8.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(765, 320)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(765, 272)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Ratings"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnEditRat)
        Me.Panel7.Controls.Add(Me.btnAddRat)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 272)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(765, 48)
        Me.Panel7.TabIndex = 1
        '
        'btnEditRat
        '
        Me.btnEditRat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditRat.Location = New System.Drawing.Point(585, 16)
        Me.btnEditRat.Name = "btnEditRat"
        Me.btnEditRat.Size = New System.Drawing.Size(72, 24)
        Me.btnEditRat.TabIndex = 0
        Me.btnEditRat.Text = "Edit"
        '
        'btnAddRat
        '
        Me.btnAddRat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRat.Location = New System.Drawing.Point(673, 16)
        Me.btnAddRat.Name = "btnAddRat"
        Me.btnAddRat.Size = New System.Drawing.Size(72, 24)
        Me.btnAddRat.TabIndex = 1
        Me.btnAddRat.Text = "Add New"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.btnEdit)
        Me.UltraTabPageControl2.Controls.Add(Me.PanelEU)
        Me.UltraTabPageControl2.Controls.Add(Me.btnAddProj)
        Me.UltraTabPageControl2.Controls.Add(Me.btnSelProj)
        Me.UltraTabPageControl2.Controls.Add(Me.Label29)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ProjectID)
        Me.UltraTabPageControl2.Controls.Add(Me.Label28)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_ProjectName)
        Me.UltraTabPageControl2.Controls.Add(Me.btnContractor)
        Me.UltraTabPageControl2.Controls.Add(Me.btnConsultant)
        Me.UltraTabPageControl2.Controls.Add(Me.chk_cccontractor)
        Me.UltraTabPageControl2.Controls.Add(Me.chk_ccConsultant)
        Me.UltraTabPageControl2.Controls.Add(Me.Label13)
        Me.UltraTabPageControl2.Controls.Add(Me.Label12)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ContractorID)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ConsultantID)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(765, 320)
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(672, 62)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 24)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        '
        'PanelEU
        '
        Me.PanelEU.Controls.Add(Me.Label31)
        Me.PanelEU.Controls.Add(Me.cmb_EURegionID)
        Me.PanelEU.Controls.Add(Me.Label30)
        Me.PanelEU.Controls.Add(Me.btnEndUser)
        Me.PanelEU.Controls.Add(Me.cmb_Priority)
        Me.PanelEU.Controls.Add(Me.chk_ccEndUser)
        Me.PanelEU.Controls.Add(Me.Label11)
        Me.PanelEU.Controls.Add(Me.cmb_EndUserID)
        Me.PanelEU.Location = New System.Drawing.Point(25, 91)
        Me.PanelEU.Name = "PanelEU"
        Me.PanelEU.Size = New System.Drawing.Size(713, 115)
        Me.PanelEU.TabIndex = 7
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label31.Location = New System.Drawing.Point(3, 45)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 24)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Region End User"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EURegionID
        '
        Me.cmb_EURegionID.Location = New System.Drawing.Point(101, 46)
        Me.cmb_EURegionID.Name = "cmb_EURegionID"
        Me.cmb_EURegionID.Size = New System.Drawing.Size(192, 22)
        Me.cmb_EURegionID.TabIndex = 5
        Me.cmb_EURegionID.Text = "UltraCombo3"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(3, 74)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 16)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Priority"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEndUser
        '
        Me.btnEndUser.Location = New System.Drawing.Point(477, 18)
        Me.btnEndUser.Name = "btnEndUser"
        Me.btnEndUser.Size = New System.Drawing.Size(120, 22)
        Me.btnEndUser.TabIndex = 2
        Me.btnEndUser.Text = "Same as Customer"
        '
        'cmb_Priority
        '
        Me.cmb_Priority.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_Priority.Location = New System.Drawing.Point(101, 74)
        Me.cmb_Priority.Name = "cmb_Priority"
        Me.cmb_Priority.Size = New System.Drawing.Size(104, 21)
        Me.cmb_Priority.TabIndex = 7
        '
        'chk_ccEndUser
        '
        Me.chk_ccEndUser.Location = New System.Drawing.Point(614, 12)
        Me.chk_ccEndUser.Name = "chk_ccEndUser"
        Me.chk_ccEndUser.Size = New System.Drawing.Size(96, 28)
        Me.chk_ccEndUser.TabIndex = 3
        Me.chk_ccEndUser.Text = "Send Copy to End User"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(3, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "End User"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EndUserID
        '
        Me.cmb_EndUserID.Location = New System.Drawing.Point(101, 18)
        Me.cmb_EndUserID.Name = "cmb_EndUserID"
        Me.cmb_EndUserID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_EndUserID.TabIndex = 1
        Me.cmb_EndUserID.Text = "UltraCombo1"
        '
        'btnAddProj
        '
        Me.btnAddProj.Location = New System.Drawing.Point(588, 62)
        Me.btnAddProj.Name = "btnAddProj"
        Me.btnAddProj.Size = New System.Drawing.Size(78, 24)
        Me.btnAddProj.TabIndex = 5
        Me.btnAddProj.Text = "Add New"
        '
        'btnSelProj
        '
        Me.btnSelProj.Location = New System.Drawing.Point(502, 63)
        Me.btnSelProj.Name = "btnSelProj"
        Me.btnSelProj.Size = New System.Drawing.Size(78, 24)
        Me.btnSelProj.TabIndex = 4
        Me.btnSelProj.Text = "Select"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(22, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "EPC Project"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ProjectID
        '
        Me.cmb_ProjectID.Location = New System.Drawing.Point(126, 63)
        Me.cmb_ProjectID.Name = "cmb_ProjectID"
        Me.cmb_ProjectID.ReadOnly = True
        Me.cmb_ProjectID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ProjectID.TabIndex = 3
        Me.cmb_ProjectID.Text = "UltraCombo1"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(22, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Project Name"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProjectName
        '
        Me.txt_ProjectName.Location = New System.Drawing.Point(126, 26)
        Me.txt_ProjectName.Name = "txt_ProjectName"
        Me.txt_ProjectName.Size = New System.Drawing.Size(360, 21)
        Me.txt_ProjectName.TabIndex = 1
        Me.txt_ProjectName.Text = "UltraTextEditor1"
        '
        'btnContractor
        '
        Me.btnContractor.Location = New System.Drawing.Point(502, 248)
        Me.btnContractor.Name = "btnContractor"
        Me.btnContractor.Size = New System.Drawing.Size(120, 24)
        Me.btnContractor.TabIndex = 14
        Me.btnContractor.Text = "Same as Customer"
        '
        'btnConsultant
        '
        Me.btnConsultant.Location = New System.Drawing.Point(502, 214)
        Me.btnConsultant.Name = "btnConsultant"
        Me.btnConsultant.Size = New System.Drawing.Size(120, 24)
        Me.btnConsultant.TabIndex = 10
        Me.btnConsultant.Text = "Same as Customer"
        '
        'chk_cccontractor
        '
        Me.chk_cccontractor.Location = New System.Drawing.Point(639, 244)
        Me.chk_cccontractor.Name = "chk_cccontractor"
        Me.chk_cccontractor.Size = New System.Drawing.Size(99, 24)
        Me.chk_cccontractor.TabIndex = 15
        Me.chk_cccontractor.Text = "Send Copy to Contractor"
        '
        'chk_ccConsultant
        '
        Me.chk_ccConsultant.Location = New System.Drawing.Point(639, 214)
        Me.chk_ccConsultant.Name = "chk_ccConsultant"
        Me.chk_ccConsultant.Size = New System.Drawing.Size(99, 24)
        Me.chk_ccConsultant.TabIndex = 11
        Me.chk_ccConsultant.Text = "Send Copy to Consultant"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(22, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Contractor"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(22, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Consultant"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ContractorID
        '
        Me.cmb_ContractorID.Location = New System.Drawing.Point(126, 248)
        Me.cmb_ContractorID.Name = "cmb_ContractorID"
        Me.cmb_ContractorID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ContractorID.TabIndex = 13
        Me.cmb_ContractorID.Text = "UltraCombo5"
        '
        'cmb_ConsultantID
        '
        Me.cmb_ConsultantID.Location = New System.Drawing.Point(126, 214)
        Me.cmb_ConsultantID.Name = "cmb_ConsultantID"
        Me.cmb_ConsultantID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ConsultantID.TabIndex = 9
        Me.cmb_ConsultantID.Text = "UltraCombo2"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Label22)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_Part3)
        Me.UltraTabPageControl3.Controls.Add(Me.Label21)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_Part2)
        Me.UltraTabPageControl3.Controls.Add(Me.Label20)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_Part1)
        Me.UltraTabPageControl3.Controls.Add(Me.Label14)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_NumParts)
        Me.UltraTabPageControl3.Controls.Add(Me.GroupBox1)
        Me.UltraTabPageControl3.Controls.Add(Me.Label15)
        Me.UltraTabPageControl3.Controls.Add(Me.txt_NumCopies)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(765, 320)
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(320, 216)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Part III"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Part3
        '
        Me.txt_Part3.Location = New System.Drawing.Point(424, 216)
        Me.txt_Part3.Name = "txt_Part3"
        Me.txt_Part3.Size = New System.Drawing.Size(192, 21)
        Me.txt_Part3.TabIndex = 10
        Me.txt_Part3.Text = "UltraTextEditor8"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(320, 184)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Part II"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Part2
        '
        Me.txt_Part2.Location = New System.Drawing.Point(424, 184)
        Me.txt_Part2.Name = "txt_Part2"
        Me.txt_Part2.Size = New System.Drawing.Size(192, 21)
        Me.txt_Part2.TabIndex = 8
        Me.txt_Part2.Text = "UltraTextEditor7"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(320, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Part I"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Part1
        '
        Me.txt_Part1.Location = New System.Drawing.Point(424, 152)
        Me.txt_Part1.Name = "txt_Part1"
        Me.txt_Part1.Size = New System.Drawing.Size(192, 21)
        Me.txt_Part1.TabIndex = 6
        Me.txt_Part1.Text = "UltraTextEditor6"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(64, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "No. of Parts"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NumParts
        '
        Me.txt_NumParts.Location = New System.Drawing.Point(144, 72)
        Me.txt_NumParts.Name = "txt_NumParts"
        Me.txt_NumParts.Size = New System.Drawing.Size(120, 21)
        Me.txt_NumParts.TabIndex = 2
        Me.txt_NumParts.Text = "UltraTextEditor4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmb_EMDPart)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmb_PricePart)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cmb_CommPart)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmb_TechPart)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(32, 176)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "EMD Part"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EMDPart
        '
        Me.cmb_EMDPart.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_EMDPart.Location = New System.Drawing.Point(136, 176)
        Me.cmb_EMDPart.Name = "cmb_EMDPart"
        Me.cmb_EMDPart.Size = New System.Drawing.Size(104, 21)
        Me.cmb_EMDPart.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(32, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Price Part"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PricePart
        '
        Me.cmb_PricePart.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_PricePart.Location = New System.Drawing.Point(136, 136)
        Me.cmb_PricePart.Name = "cmb_PricePart"
        Me.cmb_PricePart.Size = New System.Drawing.Size(104, 21)
        Me.cmb_PricePart.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(32, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Commercial Part"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CommPart
        '
        Me.cmb_CommPart.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_CommPart.Location = New System.Drawing.Point(136, 96)
        Me.cmb_CommPart.Name = "cmb_CommPart"
        Me.cmb_CommPart.Size = New System.Drawing.Size(104, 21)
        Me.cmb_CommPart.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(32, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Technical Part"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_TechPart
        '
        Me.cmb_TechPart.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_TechPart.Location = New System.Drawing.Point(136, 56)
        Me.cmb_TechPart.Name = "cmb_TechPart"
        Me.cmb_TechPart.Size = New System.Drawing.Size(104, 21)
        Me.cmb_TechPart.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(320, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "No. of Copies"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NumCopies
        '
        Me.txt_NumCopies.Location = New System.Drawing.Point(424, 72)
        Me.txt_NumCopies.Name = "txt_NumCopies"
        Me.txt_NumCopies.Size = New System.Drawing.Size(120, 21)
        Me.txt_NumCopies.TabIndex = 4
        Me.txt_NumCopies.Text = "UltraTextEditor5"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGridTerm)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(765, 320)
        '
        'UltraGridTerm
        '
        Me.UltraGridTerm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTerm.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTerm.Name = "UltraGridTerm"
        Me.UltraGridTerm.Size = New System.Drawing.Size(765, 320)
        Me.UltraGridTerm.TabIndex = 0
        Me.UltraGridTerm.Text = "Terms and Conditions"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.btnSelAddTo)
        Me.UltraTabPageControl5.Controls.Add(Me.btnSelSentBy)
        Me.UltraTabPageControl5.Controls.Add(Me.Label27)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Description)
        Me.UltraTabPageControl5.Controls.Add(Me.Label26)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_FnIUpto)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_DispMode)
        Me.UltraTabPageControl5.Controls.Add(Me.Label25)
        Me.UltraTabPageControl5.Controls.Add(Me.Label24)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_AddressToID)
        Me.UltraTabPageControl5.Controls.Add(Me.Label23)
        Me.UltraTabPageControl5.Controls.Add(Me.cmb_SentByID)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(765, 320)
        '
        'btnSelAddTo
        '
        Me.btnSelAddTo.Location = New System.Drawing.Point(488, 160)
        Me.btnSelAddTo.Name = "btnSelAddTo"
        Me.btnSelAddTo.Size = New System.Drawing.Size(72, 24)
        Me.btnSelAddTo.TabIndex = 5
        Me.btnSelAddTo.Text = "Select"
        '
        'btnSelSentBy
        '
        Me.btnSelSentBy.Location = New System.Drawing.Point(488, 88)
        Me.btnSelSentBy.Name = "btnSelSentBy"
        Me.btnSelSentBy.Size = New System.Drawing.Size(72, 24)
        Me.btnSelSentBy.TabIndex = 2
        Me.btnSelSentBy.Text = "Select"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(48, 272)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 16)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Description"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(200, 272)
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(256, 21)
        Me.txt_Description.TabIndex = 11
        Me.txt_Description.Text = "UltraTextEditor10"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(40, 232)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 16)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Freight and Insurance Upto"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_FnIUpto
        '
        Me.txt_FnIUpto.Location = New System.Drawing.Point(200, 232)
        Me.txt_FnIUpto.Name = "txt_FnIUpto"
        Me.txt_FnIUpto.Size = New System.Drawing.Size(256, 21)
        Me.txt_FnIUpto.TabIndex = 9
        Me.txt_FnIUpto.Text = "UltraTextEditor9"
        '
        'cmb_DispMode
        '
        Me.cmb_DispMode.Location = New System.Drawing.Point(200, 200)
        Me.cmb_DispMode.Name = "cmb_DispMode"
        Me.cmb_DispMode.Size = New System.Drawing.Size(200, 22)
        Me.cmb_DispMode.TabIndex = 7
        Me.cmb_DispMode.Text = "UltraCombo3"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(96, 200)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(96, 16)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Dispatch Mode"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(96, 128)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 16)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Address To"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_AddressToID
        '
        Me.cmb_AddressToID.Location = New System.Drawing.Point(200, 128)
        Me.cmb_AddressToID.Name = "cmb_AddressToID"
        Me.cmb_AddressToID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_AddressToID.TabIndex = 4
        Me.cmb_AddressToID.Text = "UltraCombo3"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(96, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Sent By"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_SentByID
        '
        Me.cmb_SentByID.Location = New System.Drawing.Point(200, 56)
        Me.cmb_SentByID.Name = "cmb_SentByID"
        Me.cmb_SentByID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_SentByID.TabIndex = 1
        Me.cmb_SentByID.Text = "UltraCombo3"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(765, 320)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridDoc)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 320)
        Me.Panel2.TabIndex = 12
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(765, 272)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Location = New System.Drawing.Point(545, 16)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Location = New System.Drawing.Point(641, 16)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 1
        Me.btnAddDoc.Text = "Add New"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(765, 320)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.UltraGridBG)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(765, 320)
        Me.Panel5.TabIndex = 12
        '
        'UltraGridBG
        '
        Me.UltraGridBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBG.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBG.Name = "UltraGridBG"
        Me.UltraGridBG.Size = New System.Drawing.Size(765, 272)
        Me.UltraGridBG.TabIndex = 0
        Me.UltraGridBG.Text = "Delivery Schedule"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnEditBG)
        Me.Panel6.Controls.Add(Me.btnDelBG)
        Me.Panel6.Controls.Add(Me.btnAddBG)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 272)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(765, 48)
        Me.Panel6.TabIndex = 1
        '
        'btnEditBG
        '
        Me.btnEditBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditBG.Location = New System.Drawing.Point(593, 16)
        Me.btnEditBG.Name = "btnEditBG"
        Me.btnEditBG.Size = New System.Drawing.Size(70, 24)
        Me.btnEditBG.TabIndex = 1
        Me.btnEditBG.Text = "Edit"
        '
        'btnDelBG
        '
        Me.btnDelBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelBG.Location = New System.Drawing.Point(513, 16)
        Me.btnDelBG.Name = "btnDelBG"
        Me.btnDelBG.Size = New System.Drawing.Size(70, 24)
        Me.btnDelBG.TabIndex = 0
        Me.btnDelBG.Text = "Delete"
        '
        'btnAddBG
        '
        Me.btnAddBG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBG.Location = New System.Drawing.Point(681, 16)
        Me.btnAddBG.Name = "btnAddBG"
        Me.btnAddBG.Size = New System.Drawing.Size(72, 24)
        Me.btnAddBG.TabIndex = 2
        Me.btnAddBG.Text = "Add New"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(482, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Region"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RegionID
        '
        Me.cmb_RegionID.Location = New System.Drawing.Point(525, 67)
        Me.cmb_RegionID.Name = "cmb_RegionID"
        Me.cmb_RegionID.Size = New System.Drawing.Size(192, 22)
        Me.cmb_RegionID.TabIndex = 3
        Me.cmb_RegionID.Text = "UltraCombo3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(63, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dated"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_EnqDate
        '
        Me.dt_EnqDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_EnqDate.Location = New System.Drawing.Point(101, 12)
        Me.dt_EnqDate.Name = "dt_EnqDate"
        Me.dt_EnqDate.NullText = "Not Defined"
        Me.dt_EnqDate.Size = New System.Drawing.Size(140, 21)
        Me.dt_EnqDate.TabIndex = 9
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(52, 98)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(46, 14)
        Me.lblRef.TabIndex = 4
        Me.lblRef.Text = "Ref. No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EnqRefNum
        '
        Me.txt_EnqRefNum.Location = New System.Drawing.Point(101, 95)
        Me.txt_EnqRefNum.Name = "txt_EnqRefNum"
        Me.txt_EnqRefNum.Size = New System.Drawing.Size(360, 21)
        Me.txt_EnqRefNum.TabIndex = 5
        Me.txt_EnqRefNum.Text = "UltraTextEditor1"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 124)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance3.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance3
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(769, 346)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.TabPage = Me.UltraTabPageControl8
        UltraTab2.Text = "Items"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Info"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Parts"
        UltraTab5.TabPage = Me.UltraTabPageControl7
        UltraTab5.Text = "Terms and Conditions"
        UltraTab6.TabPage = Me.UltraTabPageControl5
        UltraTab6.Text = "Other"
        UltraTab7.TabPage = Me.UltraTabPageControl4
        UltraTab7.Text = "Documents"
        UltraTab8.TabPage = Me.UltraTabPageControl6
        UltraTab8.Text = "Bank Guarantees"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(765, 320)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 470)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(769, 42)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance4
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(505, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance5
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(593, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance6
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(681, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel13)
        Me.Panel1.Controls.Add(Me.cmb_DivisionID)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.cmb_EnqType)
        Me.Panel1.Controls.Add(Me.cmb_CampusID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.cmb_RegionID)
        Me.Panel1.Controls.Add(Me.cmb_CustomerID)
        Me.Panel1.Controls.Add(Me.txt_EnqRefNum)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.dt_EnqDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 124)
        Me.Panel1.TabIndex = 0
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label34.Location = New System.Drawing.Point(52, 42)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(46, 14)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Campus"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label33.Location = New System.Drawing.Point(492, 98)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 14)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Type"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EnqType
        '
        Me.cmb_EnqType.Location = New System.Drawing.Point(525, 95)
        Me.cmb_EnqType.Name = "cmb_EnqType"
        Me.cmb_EnqType.Size = New System.Drawing.Size(192, 22)
        Me.cmb_EnqType.TabIndex = 7
        Me.cmb_EnqType.Text = "UltraCombo3"
        '
        'cmb_CampusID
        '
        Me.cmb_CampusID.Location = New System.Drawing.Point(101, 39)
        Me.cmb_CampusID.Name = "cmb_CampusID"
        Me.cmb_CampusID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_CampusID.TabIndex = 11
        Me.cmb_CampusID.Text = "UltraCombo3"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(45, 70)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(53, 14)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Customer"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Me.cmb_CustomerID.Location = New System.Drawing.Point(101, 67)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_CustomerID.TabIndex = 1
        Me.cmb_CustomerID.Text = "UltraCombo3"
        '
        'UltraLabel13
        '
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.TextHAlignAsString = "Right"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance7
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(478, 42)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel13.TabIndex = 49
        Me.UltraLabel13.Text = "Division"
        '
        'cmb_DivisionID
        '
        Me.cmb_DivisionID.Location = New System.Drawing.Point(525, 38)
        Me.cmb_DivisionID.Name = "cmb_DivisionID"
        Me.cmb_DivisionID.Size = New System.Drawing.Size(192, 22)
        Me.cmb_DivisionID.TabIndex = 48
        Me.cmb_DivisionID.Text = "UltraCombo4"
        '
        'frmSalesEnq
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Enquiry"
        Me.ClientSize = New System.Drawing.Size(769, 512)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesEnq"
        Me.Text = "Enquiry"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.chk_DesignRatWise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ActionReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_NoTimeReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_QuickTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_HandledByID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OfferDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OfferNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OpenDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_RecvDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsRateContract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        Me.PanelEU.ResumeLayout(False)
        Me.PanelEU.PerformLayout()
        CType(Me.cmb_EURegionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Priority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ccEndUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_cccontractor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ccConsultant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ContractorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ConsultantID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.txt_Part3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Part2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Part1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmb_EMDPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PricePart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CommPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TechPart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGridTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FnIUpto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DispMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_AddressToID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SentByID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGridBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_EnqDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EnqRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_EnqType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CampusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelProj As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmb_ProjectID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmb_Priority As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnAddProj As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents cmb_CustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_ActionReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents PanelEU As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmb_EURegionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnEndUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_ccEndUser As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_EndUserID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_DesignRatWise As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmb_EnqType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmb_CampusID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_DivisionID As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class

