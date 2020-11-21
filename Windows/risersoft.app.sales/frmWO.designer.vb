<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmWO
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents dt_WODate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_ProdFileDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_MatDepID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_IsInsured As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_TotalQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_WONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_ItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ComboName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents AddRemove1 As AddRemove
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_TPICharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_TPIApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_StackingCharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_StackingApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_SuperChType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_SuperCharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_SuperApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Freight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblFreight As System.Windows.Forms.Label
    Friend WithEvents txt_UnitPrice As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_ClarifyComm As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_ClarifyTech As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_EnClSpec As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridSpare As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridTF As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_DelSchedType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_DSPaymentStageID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_DSPeriodType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_DSPeriodNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_DSPaymentStageID_Ref As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_DSCompPeriodType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_DSCompPeriodNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_DSCompRateType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_DSCompRate As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_DSAtLeastType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_DSAtLeast As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_DSperiodType_2 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_DSPeriodNum_2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DSCustom As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridDel As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddNew As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl3 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_RepInspJoint As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_RepInspStage As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chk_ApproveGTP As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_ApproveDwG As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_ApproveQAP As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_ApproveTTR As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chk_InspecFinal As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_InspecStage As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents btnDelTT As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddTT As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridTT As Infragistics.Win.UltraWinGrid.UltraGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_RepInspJoint = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_RepInspStage = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_InspecFinal = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_InspecStage = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chk_ApproveTTR = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_ApproveQAP = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_ApproveGTP = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_ApproveDwG = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_DSPaymentStageID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_DSPeriodType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_DSPeriodNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_DSPaymentStageID_Ref = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_DSCompPeriodType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_DSCompPeriodNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_DSCompRateType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_DSCompRate = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_DSAtLeastType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_DSAtLeast = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_DSperiodType_2 = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_DSPeriodNum_2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DSCustom = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.lblDate = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNum = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ProductCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_InvDescrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAddHSN = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_hsn_sc = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.dt_completedon = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraPanelQty = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_BOQNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_TotalQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ComboUnit2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_TotalQty2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_DivisionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_WOType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_ProjectName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.dt_WODate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.dt_ProdFileDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_MatDepID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chk_IsInsured = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_WONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ComboName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.AddRemove1 = New risersoft.[shared].win.AddRemove()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridRate = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridCampus = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnEditCampus = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelCampus = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddCampus = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_GPClauseWO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_TPICharges = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_TPIApp = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_StackingCharges = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_StackingApp = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cmb_SuperChType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_SuperCharges = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_SuperApp = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_Freight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblFreight = New System.Windows.Forms.Label()
        Me.txt_UnitPrice = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGridDel = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelete = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddNew = New Infragistics.Win.Misc.UltraButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_DelSchedType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabPageControl20 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_DeliveryTo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_ConsigneePrefix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmb_ConsigneeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ClarifyComm = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_ClarifyTech = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_EnClSpec = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.UltraGridSpare = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDownSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnUPSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnOutdentSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnIndentSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddChildSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSibSpare = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSvc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDownSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnUpSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnOutdentSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnIndentSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddChildSRV = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSibSRV = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UltraGridTF = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnEditSerial = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditTF = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelTF = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTF = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.UltraGridTT = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.btnDelTT = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTT = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.chk_RepInspJoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_RepInspStage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl16.SuspendLayout()
        CType(Me.chk_InspecFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_InspecStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ApproveTTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ApproveQAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ApproveGTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ApproveDwG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.cmb_DSPaymentStageID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DSPeriodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DSPeriodNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.cmb_DSPaymentStageID_Ref, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DSCompPeriodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DSCompPeriodNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DSCompRateType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DSCompRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DSAtLeastType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DSAtLeast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DSperiodType_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DSPeriodNum_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.txt_DSCustom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_ProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InvDescrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_hsn_sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_completedon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanelQty.ClientArea.SuspendLayout()
        Me.UltraPanelQty.SuspendLayout()
        CType(Me.txt_BOQNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalQty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_WOType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl3.SuspendLayout()
        CType(Me.dt_WODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ProdFileDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsInsured, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl17.SuspendLayout()
        CType(Me.UltraGridRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl19.SuspendLayout()
        CType(Me.UltraGridCampus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.txt_GPClauseWO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TPICharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_TPIApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StackingCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_StackingApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SuperChType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SuperCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_SuperApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Freight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGridDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        CType(Me.cmb_DelSchedType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl20.SuspendLayout()
        CType(Me.txt_DeliveryTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ConsigneePrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ConsigneeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ClarifyComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ClarifyTech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EnClSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl18.SuspendLayout()
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.UltraGridTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.UltraTabPageControl15.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.chk_RepInspJoint)
        Me.UltraTabPageControl7.Controls.Add(Me.chk_RepInspStage)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(200, 184)
        '
        'chk_RepInspJoint
        '
        Me.chk_RepInspJoint.Location = New System.Drawing.Point(16, 88)
        Me.chk_RepInspJoint.Name = "chk_RepInspJoint"
        Me.chk_RepInspJoint.Size = New System.Drawing.Size(152, 24)
        Me.chk_RepInspJoint.TabIndex = 1
        Me.chk_RepInspJoint.Text = "Require Joint Inspection"
        '
        'chk_RepInspStage
        '
        Me.chk_RepInspStage.Location = New System.Drawing.Point(16, 56)
        Me.chk_RepInspStage.Name = "chk_RepInspStage"
        Me.chk_RepInspStage.Size = New System.Drawing.Size(152, 24)
        Me.chk_RepInspStage.TabIndex = 0
        Me.chk_RepInspStage.Text = "Require Stage Inspection"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.chk_InspecFinal)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_InspecStage)
        Me.UltraTabPageControl16.Controls.Add(Me.PictureBox1)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_ApproveTTR)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_ApproveQAP)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_ApproveGTP)
        Me.UltraTabPageControl16.Controls.Add(Me.chk_ApproveDwG)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(200, 184)
        '
        'chk_InspecFinal
        '
        Me.chk_InspecFinal.Location = New System.Drawing.Point(8, 160)
        Me.chk_InspecFinal.Name = "chk_InspecFinal"
        Me.chk_InspecFinal.Size = New System.Drawing.Size(152, 24)
        Me.chk_InspecFinal.TabIndex = 5
        Me.chk_InspecFinal.Text = "Final Inspection"
        '
        'chk_InspecStage
        '
        Me.chk_InspecStage.Location = New System.Drawing.Point(8, 136)
        Me.chk_InspecStage.Name = "chk_InspecStage"
        Me.chk_InspecStage.Size = New System.Drawing.Size(152, 24)
        Me.chk_InspecStage.TabIndex = 4
        Me.chk_InspecStage.Text = "Stage Inspection"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(8, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 2)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'chk_ApproveTTR
        '
        Me.chk_ApproveTTR.Location = New System.Drawing.Point(8, 88)
        Me.chk_ApproveTTR.Name = "chk_ApproveTTR"
        Me.chk_ApproveTTR.Size = New System.Drawing.Size(152, 24)
        Me.chk_ApproveTTR.TabIndex = 3
        Me.chk_ApproveTTR.Text = "Type Test Reports"
        '
        'chk_ApproveQAP
        '
        Me.chk_ApproveQAP.Location = New System.Drawing.Point(8, 64)
        Me.chk_ApproveQAP.Name = "chk_ApproveQAP"
        Me.chk_ApproveQAP.Size = New System.Drawing.Size(152, 24)
        Me.chk_ApproveQAP.TabIndex = 2
        Me.chk_ApproveQAP.Text = "Approval of QAP"
        '
        'chk_ApproveGTP
        '
        Me.chk_ApproveGTP.Location = New System.Drawing.Point(8, 40)
        Me.chk_ApproveGTP.Name = "chk_ApproveGTP"
        Me.chk_ApproveGTP.Size = New System.Drawing.Size(152, 24)
        Me.chk_ApproveGTP.TabIndex = 1
        Me.chk_ApproveGTP.Text = "Approval of GTP"
        '
        'chk_ApproveDwG
        '
        Me.chk_ApproveDwG.Location = New System.Drawing.Point(8, 16)
        Me.chk_ApproveDwG.Name = "chk_ApproveDwG"
        Me.chk_ApproveDwG.Size = New System.Drawing.Size(152, 24)
        Me.chk_ApproveDwG.TabIndex = 0
        Me.chk_ApproveDwG.Text = "Approval of Drawings"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(368, 272)
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.cmb_DSPaymentStageID)
        Me.UltraTabPageControl8.Controls.Add(Me.Label3)
        Me.UltraTabPageControl8.Controls.Add(Me.cmb_DSPeriodType)
        Me.UltraTabPageControl8.Controls.Add(Me.txt_DSPeriodNum)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(368, 272)
        '
        'cmb_DSPaymentStageID
        '
        Me.cmb_DSPaymentStageID.DataMember = "Items"
        Me.cmb_DSPaymentStageID.DisplayMember = "ItemName"
        Me.cmb_DSPaymentStageID.Location = New System.Drawing.Point(8, 136)
        Me.cmb_DSPaymentStageID.MaxDropDownItems = 15
        Me.cmb_DSPaymentStageID.Name = "cmb_DSPaymentStageID"
        Me.cmb_DSPaymentStageID.Size = New System.Drawing.Size(352, 22)
        Me.cmb_DSPaymentStageID.TabIndex = 3
        Me.cmb_DSPaymentStageID.Text = "UltraCombo1"
        Me.cmb_DSPaymentStageID.ValueMember = "ItemID"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "From"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_DSPeriodType
        '
        Me.cmb_DSPeriodType.Location = New System.Drawing.Point(176, 64)
        Me.cmb_DSPeriodType.Name = "cmb_DSPeriodType"
        Me.cmb_DSPeriodType.Size = New System.Drawing.Size(168, 21)
        Me.cmb_DSPeriodType.TabIndex = 1
        Me.cmb_DSPeriodType.Text = "UltraComboEditor2"
        '
        'txt_DSPeriodNum
        '
        Me.txt_DSPeriodNum.Location = New System.Drawing.Point(40, 64)
        Me.txt_DSPeriodNum.Name = "txt_DSPeriodNum"
        Me.txt_DSPeriodNum.Size = New System.Drawing.Size(128, 21)
        Me.txt_DSPeriodNum.TabIndex = 0
        Me.txt_DSPeriodNum.Text = "UltraTextEditor2"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.cmb_DSPaymentStageID_Ref)
        Me.UltraTabPageControl9.Controls.Add(Me.Label10)
        Me.UltraTabPageControl9.Controls.Add(Me.cmb_DSCompPeriodType)
        Me.UltraTabPageControl9.Controls.Add(Me.txt_DSCompPeriodNum)
        Me.UltraTabPageControl9.Controls.Add(Me.Label9)
        Me.UltraTabPageControl9.Controls.Add(Me.cmb_DSCompRateType)
        Me.UltraTabPageControl9.Controls.Add(Me.txt_DSCompRate)
        Me.UltraTabPageControl9.Controls.Add(Me.Label8)
        Me.UltraTabPageControl9.Controls.Add(Me.Label7)
        Me.UltraTabPageControl9.Controls.Add(Me.Label6)
        Me.UltraTabPageControl9.Controls.Add(Me.cmb_DSAtLeastType)
        Me.UltraTabPageControl9.Controls.Add(Me.txt_DSAtLeast)
        Me.UltraTabPageControl9.Controls.Add(Me.Label5)
        Me.UltraTabPageControl9.Controls.Add(Me.cmb_DSperiodType_2)
        Me.UltraTabPageControl9.Controls.Add(Me.txt_DSPeriodNum_2)
        Me.UltraTabPageControl9.Controls.Add(Me.Label4)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(368, 272)
        '
        'cmb_DSPaymentStageID_Ref
        '
        Me.cmb_DSPaymentStageID_Ref.DataMember = "Items"
        Me.cmb_DSPaymentStageID_Ref.DisplayMember = "ItemName"
        Me.cmb_DSPaymentStageID_Ref.Location = New System.Drawing.Point(72, 136)
        Me.cmb_DSPaymentStageID_Ref.MaxDropDownItems = 15
        Me.cmb_DSPaymentStageID_Ref.Name = "cmb_DSPaymentStageID_Ref"
        Me.cmb_DSPaymentStageID_Ref.Size = New System.Drawing.Size(288, 22)
        Me.cmb_DSPaymentStageID_Ref.TabIndex = 8
        Me.cmb_DSPaymentStageID_Ref.Text = "UltraCombo1"
        Me.cmb_DSPaymentStageID_Ref.ValueMember = "ItemID"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "thereafter"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_DSCompPeriodType
        '
        Me.cmb_DSCompPeriodType.Location = New System.Drawing.Point(128, 216)
        Me.cmb_DSCompPeriodType.Name = "cmb_DSCompPeriodType"
        Me.cmb_DSCompPeriodType.Size = New System.Drawing.Size(72, 21)
        Me.cmb_DSCompPeriodType.TabIndex = 14
        Me.cmb_DSCompPeriodType.Text = "UltraComboEditor8"
        '
        'txt_DSCompPeriodNum
        '
        Me.txt_DSCompPeriodNum.Location = New System.Drawing.Point(72, 216)
        Me.txt_DSCompPeriodNum.Name = "txt_DSCompPeriodNum"
        Me.txt_DSCompPeriodNum.Size = New System.Drawing.Size(48, 21)
        Me.txt_DSCompPeriodNum.TabIndex = 13
        Me.txt_DSCompPeriodNum.Text = "UltraTextEditor6"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "per"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_DSCompRateType
        '
        Me.cmb_DSCompRateType.Location = New System.Drawing.Point(200, 176)
        Me.cmb_DSCompRateType.Name = "cmb_DSCompRateType"
        Me.cmb_DSCompRateType.Size = New System.Drawing.Size(48, 21)
        Me.cmb_DSCompRateType.TabIndex = 11
        Me.cmb_DSCompRateType.Text = "UltraComboEditor7"
        '
        'txt_DSCompRate
        '
        Me.txt_DSCompRate.Location = New System.Drawing.Point(144, 176)
        Me.txt_DSCompRate.Name = "txt_DSCompRate"
        Me.txt_DSCompRate.Size = New System.Drawing.Size(48, 21)
        Me.txt_DSCompRate.TabIndex = 10
        Me.txt_DSCompRate.Text = "UltraTextEditor5"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(32, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "and completion at"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "from"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(208, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "of the ordered quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_DSAtLeastType
        '
        Me.cmb_DSAtLeastType.Location = New System.Drawing.Point(160, 96)
        Me.cmb_DSAtLeastType.Name = "cmb_DSAtLeastType"
        Me.cmb_DSAtLeastType.Size = New System.Drawing.Size(48, 21)
        Me.cmb_DSAtLeastType.TabIndex = 5
        Me.cmb_DSAtLeastType.Text = "UltraComboEditor5"
        '
        'txt_DSAtLeast
        '
        Me.txt_DSAtLeast.Location = New System.Drawing.Point(104, 96)
        Me.txt_DSAtLeast.Name = "txt_DSAtLeast"
        Me.txt_DSAtLeast.Size = New System.Drawing.Size(48, 21)
        Me.txt_DSAtLeast.TabIndex = 4
        Me.txt_DSAtLeast.Text = "UltraTextEditor4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "with at least"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_DSperiodType_2
        '
        Me.cmb_DSperiodType_2.Location = New System.Drawing.Point(192, 48)
        Me.cmb_DSperiodType_2.Name = "cmb_DSperiodType_2"
        Me.cmb_DSperiodType_2.Size = New System.Drawing.Size(128, 21)
        Me.cmb_DSperiodType_2.TabIndex = 2
        Me.cmb_DSperiodType_2.Text = "UltraComboEditor4"
        '
        'txt_DSPeriodNum_2
        '
        Me.txt_DSPeriodNum_2.Location = New System.Drawing.Point(136, 48)
        Me.txt_DSPeriodNum_2.Name = "txt_DSPeriodNum_2"
        Me.txt_DSPeriodNum_2.Size = New System.Drawing.Size(48, 21)
        Me.txt_DSPeriodNum_2.TabIndex = 1
        Me.txt_DSPeriodNum_2.Text = "UltraTextEditor3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Commencement In"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.txt_DSCustom)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(368, 272)
        '
        'txt_DSCustom
        '
        Me.txt_DSCustom.Location = New System.Drawing.Point(16, 56)
        Me.txt_DSCustom.Multiline = True
        Me.txt_DSCustom.Name = "txt_DSCustom"
        Me.txt_DSCustom.Size = New System.Drawing.Size(320, 208)
        Me.txt_DSCustom.TabIndex = 0
        Me.txt_DSCustom.Text = "UltraTextEditor7"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.lblDate)
        Me.UltraTabPageControl1.Controls.Add(Me.lblNum)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel15)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel14)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel13)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ProductCode)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_InvDescrip)
        Me.UltraTabPageControl1.Controls.Add(Me.btnAddHSN)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_hsn_sc)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_completedon)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraPanelQty)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_DivisionID)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_WOType)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_ProjectName)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraTabControl3)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_WODate)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_ProdFileDate)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_StatusNum)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_MatDepID)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsInsured)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_WONum)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ItemID)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboName)
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(950, 431)
        '
        'lblDate
        '
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.lblDate.Appearance = Appearance1
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(401, 51)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(57, 14)
        Me.lblDate.TabIndex = 49
        Me.lblDate.Text = "W.O. Date"
        '
        'lblNum
        '
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.TextHAlignAsString = "Right"
        Appearance2.TextVAlignAsString = "Middle"
        Me.lblNum.Appearance = Appearance2
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(45, 51)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(83, 14)
        Me.lblNum.TabIndex = 48
        Me.lblNum.Text = "Work Order No."
        '
        'UltraLabel15
        '
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.TextHAlignAsString = "Right"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance3
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(68, 104)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel15.TabIndex = 47
        Me.UltraLabel15.Text = "Item Name"
        '
        'UltraLabel14
        '
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.TextHAlignAsString = "Right"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance4
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(72, 78)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel14.TabIndex = 46
        Me.UltraLabel14.Text = "Item Code"
        '
        'UltraLabel13
        '
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.TextHAlignAsString = "Right"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance5
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(414, 24)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel13.TabIndex = 45
        Me.UltraLabel13.Text = "Division"
        '
        'UltraLabel10
        '
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.TextHAlignAsString = "Right"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance6
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(79, 220)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel10.TabIndex = 44
        Me.UltraLabel10.Text = "HSN No."
        '
        'UltraLabel9
        '
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.TextHAlignAsString = "Right"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance7
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(399, 299)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel9.TabIndex = 43
        Me.UltraLabel9.Text = "Completed On"
        '
        'UltraLabel7
        '
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.TextHAlignAsString = "Right"
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance8
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(43, 273)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel7.TabIndex = 42
        Me.UltraLabel7.Text = "Handled by Unit"
        '
        'UltraLabel6
        '
        Appearance9.FontData.SizeInPoints = 8.25!
        Appearance9.TextHAlignAsString = "Right"
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance9
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(369, 272)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(107, 14)
        Me.UltraLabel6.TabIndex = 41
        Me.UltraLabel6.Text = "Production File Date"
        '
        'UltraLabel5
        '
        Appearance10.FontData.SizeInPoints = 8.25!
        Appearance10.TextHAlignAsString = "Right"
        Appearance10.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance10
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(55, 246)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel5.TabIndex = 40
        Me.UltraLabel5.Text = "Project Name"
        '
        'UltraLabel4
        '
        Appearance11.FontData.SizeInPoints = 8.25!
        Appearance11.TextHAlignAsString = "Right"
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance11
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(92, 298)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel4.TabIndex = 39
        Me.UltraLabel4.Text = "Status"
        '
        'UltraLabel3
        '
        Appearance12.FontData.SizeInPoints = 8.25!
        Appearance12.TextHAlignAsString = "Right"
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance12
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(10, 25)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(118, 14)
        Me.UltraLabel3.TabIndex = 38
        Me.UltraLabel3.Text = "Sales Order Item Type"
        '
        'UltraLabel1
        '
        Appearance13.FontData.SizeInPoints = 8.25!
        Appearance13.TextHAlignAsString = "Right"
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance13
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(55, 326)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel1.TabIndex = 37
        Me.UltraLabel1.Text = "Product Code"
        '
        'txt_ProductCode
        '
        Me.txt_ProductCode.Location = New System.Drawing.Point(131, 323)
        Me.txt_ProductCode.Name = "txt_ProductCode"
        Me.txt_ProductCode.Size = New System.Drawing.Size(230, 21)
        Me.txt_ProductCode.TabIndex = 13
        Me.txt_ProductCode.Text = "UltraTextEditor1"
        '
        'UltraLabel2
        '
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.TextHAlignAsString = "Right"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance14
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(28, 353)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(100, 14)
        Me.UltraLabel2.TabIndex = 35
        Me.UltraLabel2.Text = "Invoice Description"
        '
        'txt_InvDescrip
        '
        Me.txt_InvDescrip.Location = New System.Drawing.Point(131, 350)
        Me.txt_InvDescrip.Multiline = True
        Me.txt_InvDescrip.Name = "txt_InvDescrip"
        Me.txt_InvDescrip.Size = New System.Drawing.Size(530, 78)
        Me.txt_InvDescrip.TabIndex = 14
        Me.txt_InvDescrip.Text = "UltraTextEditor1"
        '
        'btnAddHSN
        '
        Me.btnAddHSN.Location = New System.Drawing.Point(661, 215)
        Me.btnAddHSN.Name = "btnAddHSN"
        Me.btnAddHSN.Size = New System.Drawing.Size(70, 25)
        Me.btnAddHSN.TabIndex = 33
        Me.btnAddHSN.Text = "Add HSN"
        '
        'cmb_hsn_sc
        '
        Me.cmb_hsn_sc.DropDownWidth = 500
        Me.cmb_hsn_sc.Location = New System.Drawing.Point(131, 216)
        Me.cmb_hsn_sc.Name = "cmb_hsn_sc"
        Me.cmb_hsn_sc.Size = New System.Drawing.Size(530, 22)
        Me.cmb_hsn_sc.TabIndex = 7
        '
        'dt_completedon
        '
        Me.dt_completedon.FormatString = "dddd dd MMM yyyy"
        Me.dt_completedon.Location = New System.Drawing.Point(479, 296)
        Me.dt_completedon.Name = "dt_completedon"
        Me.dt_completedon.NullText = "Not Defined"
        Me.dt_completedon.Size = New System.Drawing.Size(182, 21)
        Me.dt_completedon.TabIndex = 12
        '
        'UltraPanelQty
        '
        '
        'UltraPanelQty.ClientArea
        '
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.UltraLabel12)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.UltraLabel11)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.txt_BOQNum)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.UltraLabel8)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.txt_TotalQty)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.ComboUnit)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.ComboUnit2)
        Me.UltraPanelQty.ClientArea.Controls.Add(Me.txt_TotalQty2)
        Me.UltraPanelQty.Location = New System.Drawing.Point(17, 127)
        Me.UltraPanelQty.Name = "UltraPanelQty"
        Me.UltraPanelQty.Size = New System.Drawing.Size(262, 85)
        Me.UltraPanelQty.TabIndex = 6
        '
        'UltraLabel12
        '
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.TextHAlignAsString = "Right"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance15
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(55, 63)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel12.TabIndex = 47
        Me.UltraLabel12.Text = "BOQ Num"
        '
        'UltraLabel11
        '
        Appearance16.FontData.SizeInPoints = 8.25!
        Appearance16.TextHAlignAsString = "Right"
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance16
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(51, 35)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel11.TabIndex = 46
        Me.UltraLabel11.Text = "Total Qty 2"
        '
        'txt_BOQNum
        '
        Me.txt_BOQNum.Location = New System.Drawing.Point(114, 60)
        Me.txt_BOQNum.Name = "txt_BOQNum"
        Me.txt_BOQNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_BOQNum.TabIndex = 4
        Me.txt_BOQNum.Text = "UltraTextEditor12"
        '
        'UltraLabel8
        '
        Appearance17.FontData.SizeInPoints = 8.25!
        Appearance17.TextHAlignAsString = "Right"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance17
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(61, 8)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel8.TabIndex = 45
        Me.UltraLabel8.Text = "Total Qty"
        '
        'txt_TotalQty
        '
        Me.txt_TotalQty.Location = New System.Drawing.Point(114, 5)
        Me.txt_TotalQty.Name = "txt_TotalQty"
        Me.txt_TotalQty.Size = New System.Drawing.Size(56, 21)
        Me.txt_TotalQty.TabIndex = 0
        Me.txt_TotalQty.Text = "UltraTextEditor17"
        '
        'ComboUnit
        '
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit.Appearance = Appearance18
        Me.ComboUnit.DataMember = "Items"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Location = New System.Drawing.Point(178, 5)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit.TabIndex = 1
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "ItemID"
        '
        'ComboUnit2
        '
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit2.Appearance = Appearance19
        Me.ComboUnit2.DataMember = "Items"
        Me.ComboUnit2.DisplayMember = "UnitName2"
        Me.ComboUnit2.Location = New System.Drawing.Point(178, 32)
        Me.ComboUnit2.MaxDropDownItems = 15
        Me.ComboUnit2.Name = "ComboUnit2"
        Me.ComboUnit2.ReadOnly = True
        Me.ComboUnit2.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit2.TabIndex = 3
        Me.ComboUnit2.Text = "UltraCombo3"
        Me.ComboUnit2.ValueMember = "ItemID"
        '
        'txt_TotalQty2
        '
        Me.txt_TotalQty2.Location = New System.Drawing.Point(114, 32)
        Me.txt_TotalQty2.Name = "txt_TotalQty2"
        Me.txt_TotalQty2.Size = New System.Drawing.Size(56, 21)
        Me.txt_TotalQty2.TabIndex = 2
        Me.txt_TotalQty2.Text = "UltraTextEditor17"
        '
        'cmb_DivisionID
        '
        Me.cmb_DivisionID.Location = New System.Drawing.Point(461, 21)
        Me.cmb_DivisionID.Name = "cmb_DivisionID"
        Me.cmb_DivisionID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_DivisionID.TabIndex = 1
        Me.cmb_DivisionID.Text = "UltraCombo4"
        '
        'cmb_WOType
        '
        Me.cmb_WOType.DataMember = "Items"
        Me.cmb_WOType.DisplayMember = "ItemCode"
        Me.cmb_WOType.Location = New System.Drawing.Point(131, 21)
        Me.cmb_WOType.MaxDropDownItems = 15
        Me.cmb_WOType.Name = "cmb_WOType"
        Me.cmb_WOType.ReadOnly = True
        Me.cmb_WOType.Size = New System.Drawing.Size(230, 22)
        Me.cmb_WOType.TabIndex = 0
        Me.cmb_WOType.Text = "UltraCombo2"
        Me.cmb_WOType.ValueMember = "ItemID"
        '
        'txt_ProjectName
        '
        Me.txt_ProjectName.Location = New System.Drawing.Point(131, 243)
        Me.txt_ProjectName.Name = "txt_ProjectName"
        Me.txt_ProjectName.Size = New System.Drawing.Size(530, 21)
        Me.txt_ProjectName.TabIndex = 8
        Me.txt_ProjectName.Text = "UltraTextEditor1"
        '
        'UltraTabControl3
        '
        Me.UltraTabControl3.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl3.Controls.Add(Me.UltraTabPageControl16)
        Me.UltraTabControl3.Location = New System.Drawing.Point(740, 3)
        Me.UltraTabControl3.Name = "UltraTabControl3"
        Me.UltraTabControl3.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl3.Size = New System.Drawing.Size(200, 184)
        Me.UltraTabControl3.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl3.TabIndex = 25
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl16
        UltraTab2.Text = "tab2"
        Me.UltraTabControl3.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(200, 184)
        '
        'dt_WODate
        '
        Me.dt_WODate.FormatString = "dddd dd MMM yyyy"
        Me.dt_WODate.Location = New System.Drawing.Point(461, 48)
        Me.dt_WODate.Name = "dt_WODate"
        Me.dt_WODate.NullText = "Not Defined"
        Me.dt_WODate.Size = New System.Drawing.Size(200, 21)
        Me.dt_WODate.TabIndex = 3
        '
        'dt_ProdFileDate
        '
        Me.dt_ProdFileDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ProdFileDate.Location = New System.Drawing.Point(479, 269)
        Me.dt_ProdFileDate.Name = "dt_ProdFileDate"
        Me.dt_ProdFileDate.NullText = "Not Defined"
        Me.dt_ProdFileDate.Size = New System.Drawing.Size(182, 21)
        Me.dt_ProdFileDate.TabIndex = 10
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(131, 295)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(230, 22)
        Me.cmb_StatusNum.TabIndex = 11
        Me.cmb_StatusNum.Text = "UltraCombo5"
        '
        'cmb_MatDepID
        '
        Me.cmb_MatDepID.Location = New System.Drawing.Point(131, 269)
        Me.cmb_MatDepID.Name = "cmb_MatDepID"
        Me.cmb_MatDepID.Size = New System.Drawing.Size(230, 22)
        Me.cmb_MatDepID.TabIndex = 9
        Me.cmb_MatDepID.Text = "UltraCombo4"
        '
        'chk_IsInsured
        '
        Me.chk_IsInsured.Location = New System.Drawing.Point(285, 160)
        Me.chk_IsInsured.Name = "chk_IsInsured"
        Me.chk_IsInsured.Size = New System.Drawing.Size(151, 24)
        Me.chk_IsInsured.TabIndex = 6
        Me.chk_IsInsured.Text = "Supply is Insured"
        '
        'txt_WONum
        '
        Me.txt_WONum.Location = New System.Drawing.Point(131, 48)
        Me.txt_WONum.Name = "txt_WONum"
        Me.txt_WONum.Size = New System.Drawing.Size(230, 21)
        Me.txt_WONum.TabIndex = 2
        Me.txt_WONum.Text = "UltraTextEditor1"
        '
        'cmb_ItemID
        '
        Me.cmb_ItemID.DataMember = "Items"
        Me.cmb_ItemID.DisplayMember = "ItemCode"
        Me.cmb_ItemID.Location = New System.Drawing.Point(131, 74)
        Me.cmb_ItemID.MaxDropDownItems = 15
        Me.cmb_ItemID.Name = "cmb_ItemID"
        Me.cmb_ItemID.Size = New System.Drawing.Size(230, 22)
        Me.cmb_ItemID.TabIndex = 4
        Me.cmb_ItemID.Text = "UltraCombo2"
        Me.cmb_ItemID.ValueMember = "ItemID"
        '
        'ComboName
        '
        Me.ComboName.DataMember = "Items"
        Me.ComboName.DisplayMember = "ItemName"
        Me.ComboName.Location = New System.Drawing.Point(131, 101)
        Me.ComboName.MaxDropDownItems = 15
        Me.ComboName.Name = "ComboName"
        Me.ComboName.Size = New System.Drawing.Size(530, 22)
        Me.ComboName.TabIndex = 5
        Me.ComboName.Text = "UltraCombo1"
        Me.ComboName.ValueMember = "ItemID"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(950, 431)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.AddRemove1)
        Me.UltraTabPageControl3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(950, 431)
        '
        'AddRemove1
        '
        Me.AddRemove1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddRemove1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemove1.Location = New System.Drawing.Point(0, 0)
        Me.AddRemove1.Mode = 1
        Me.AddRemove1.Name = "AddRemove1"
        Me.AddRemove1.Size = New System.Drawing.Size(950, 431)
        Me.AddRemove1.TabIndex = 0
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.UltraGridRate)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(950, 431)
        '
        'UltraGridRate
        '
        Me.UltraGridRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRate.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridRate.Name = "UltraGridRate"
        Me.UltraGridRate.Size = New System.Drawing.Size(950, 431)
        Me.UltraGridRate.TabIndex = 0
        Me.UltraGridRate.Text = "Repair Rate List"
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.UltraGridCampus)
        Me.UltraTabPageControl19.Controls.Add(Me.Panel13)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(950, 431)
        '
        'UltraGridCampus
        '
        Me.UltraGridCampus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridCampus.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridCampus.Name = "UltraGridCampus"
        Me.UltraGridCampus.Size = New System.Drawing.Size(950, 401)
        Me.UltraGridCampus.TabIndex = 0
        Me.UltraGridCampus.Text = "Product Serials"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.btnEditCampus)
        Me.Panel13.Controls.Add(Me.btnDelCampus)
        Me.Panel13.Controls.Add(Me.btnAddCampus)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 401)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(950, 30)
        Me.Panel13.TabIndex = 1
        '
        'btnEditCampus
        '
        Me.btnEditCampus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditCampus.Location = New System.Drawing.Point(736, 0)
        Me.btnEditCampus.Name = "btnEditCampus"
        Me.btnEditCampus.Size = New System.Drawing.Size(72, 30)
        Me.btnEditCampus.TabIndex = 0
        Me.btnEditCampus.Text = "Edit"
        '
        'btnDelCampus
        '
        Me.btnDelCampus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelCampus.Location = New System.Drawing.Point(808, 0)
        Me.btnDelCampus.Name = "btnDelCampus"
        Me.btnDelCampus.Size = New System.Drawing.Size(70, 30)
        Me.btnDelCampus.TabIndex = 1
        Me.btnDelCampus.Text = "Delete"
        '
        'btnAddCampus
        '
        Me.btnAddCampus.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddCampus.Location = New System.Drawing.Point(878, 0)
        Me.btnAddCampus.Name = "btnAddCampus"
        Me.btnAddCampus.Size = New System.Drawing.Size(72, 30)
        Me.btnAddCampus.TabIndex = 2
        Me.btnAddCampus.Text = "Add New"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Label29)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_GPClauseWO)
        Me.UltraTabPageControl4.Controls.Add(Me.Label18)
        Me.UltraTabPageControl4.Controls.Add(Me.Label17)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_TPICharges)
        Me.UltraTabPageControl4.Controls.Add(Me.chk_TPIApp)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_StackingCharges)
        Me.UltraTabPageControl4.Controls.Add(Me.chk_StackingApp)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_SuperChType)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_SuperCharges)
        Me.UltraTabPageControl4.Controls.Add(Me.chk_SuperApp)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Freight)
        Me.UltraTabPageControl4.Controls.Add(Me.lblFreight)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_UnitPrice)
        Me.UltraTabPageControl4.Controls.Add(Me.Label15)
        Me.UltraTabPageControl4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(950, 431)
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(104, 320)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 48)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Guarantee Period Clause"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_GPClauseWO
        '
        Me.txt_GPClauseWO.AcceptsReturn = True
        Me.txt_GPClauseWO.Location = New System.Drawing.Point(224, 320)
        Me.txt_GPClauseWO.Multiline = True
        Me.txt_GPClauseWO.Name = "txt_GPClauseWO"
        Me.txt_GPClauseWO.Size = New System.Drawing.Size(424, 48)
        Me.txt_GPClauseWO.TabIndex = 14
        Me.txt_GPClauseWO.Text = "UltraTextEditor3"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(368, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "per Unit"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(368, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "per Unit"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TPICharges
        '
        Me.txt_TPICharges.Location = New System.Drawing.Point(224, 264)
        Me.txt_TPICharges.Name = "txt_TPICharges"
        Me.txt_TPICharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_TPICharges.TabIndex = 11
        Me.txt_TPICharges.Text = "UltraTextEditor16"
        '
        'chk_TPIApp
        '
        Me.chk_TPIApp.Location = New System.Drawing.Point(128, 248)
        Me.chk_TPIApp.Name = "chk_TPIApp"
        Me.chk_TPIApp.Size = New System.Drawing.Size(88, 48)
        Me.chk_TPIApp.TabIndex = 10
        Me.chk_TPIApp.Text = "Third Party Inspection Charges"
        '
        'txt_StackingCharges
        '
        Me.txt_StackingCharges.Location = New System.Drawing.Point(224, 208)
        Me.txt_StackingCharges.Name = "txt_StackingCharges"
        Me.txt_StackingCharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_StackingCharges.TabIndex = 8
        Me.txt_StackingCharges.Text = "UltraTextEditor15"
        '
        'chk_StackingApp
        '
        Me.chk_StackingApp.Location = New System.Drawing.Point(128, 192)
        Me.chk_StackingApp.Name = "chk_StackingApp"
        Me.chk_StackingApp.Size = New System.Drawing.Size(88, 48)
        Me.chk_StackingApp.TabIndex = 7
        Me.chk_StackingApp.Text = "Stacking and Unloading Charges"
        '
        'cmb_SuperChType
        '
        Me.cmb_SuperChType.Location = New System.Drawing.Point(368, 152)
        Me.cmb_SuperChType.Name = "cmb_SuperChType"
        Me.cmb_SuperChType.Size = New System.Drawing.Size(64, 21)
        Me.cmb_SuperChType.TabIndex = 6
        Me.cmb_SuperChType.Text = "UltraComboEditor9"
        '
        'txt_SuperCharges
        '
        Me.txt_SuperCharges.Location = New System.Drawing.Point(224, 152)
        Me.txt_SuperCharges.Name = "txt_SuperCharges"
        Me.txt_SuperCharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_SuperCharges.TabIndex = 5
        Me.txt_SuperCharges.Text = "UltraTextEditor14"
        '
        'chk_SuperApp
        '
        Me.chk_SuperApp.Location = New System.Drawing.Point(128, 136)
        Me.chk_SuperApp.Name = "chk_SuperApp"
        Me.chk_SuperApp.Size = New System.Drawing.Size(80, 48)
        Me.chk_SuperApp.TabIndex = 4
        Me.chk_SuperApp.Text = "Supervision Charges"
        '
        'txt_Freight
        '
        Me.txt_Freight.Location = New System.Drawing.Point(224, 104)
        Me.txt_Freight.Name = "txt_Freight"
        Me.txt_Freight.Size = New System.Drawing.Size(136, 21)
        Me.txt_Freight.TabIndex = 3
        Me.txt_Freight.Text = "UltraTextEditor13"
        '
        'lblFreight
        '
        Me.lblFreight.Location = New System.Drawing.Point(104, 104)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(120, 16)
        Me.lblFreight.TabIndex = 2
        Me.lblFreight.Text = "Freight"
        Me.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_UnitPrice
        '
        Me.txt_UnitPrice.Location = New System.Drawing.Point(224, 64)
        Me.txt_UnitPrice.Name = "txt_UnitPrice"
        Me.txt_UnitPrice.Size = New System.Drawing.Size(136, 21)
        Me.txt_UnitPrice.TabIndex = 1
        Me.txt_UnitPrice.Text = "UltraTextEditor12"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(104, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Unit Price (Ex-Works)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel12)
        Me.UltraTabPageControl5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(950, 431)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridDel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(368, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 431)
        Me.Panel2.TabIndex = 9
        '
        'UltraGridDel
        '
        Me.UltraGridDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDel.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDel.Name = "UltraGridDel"
        Me.UltraGridDel.Size = New System.Drawing.Size(582, 383)
        Me.UltraGridDel.TabIndex = 0
        Me.UltraGridDel.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnAddNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 383)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(582, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(362, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(70, 24)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.Location = New System.Drawing.Point(458, 16)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(72, 24)
        Me.btnAddNew.TabIndex = 1
        Me.btnAddNew.Text = "Add New"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.UltraTabControl2)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Controls.Add(Me.cmb_DelSchedType)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(368, 431)
        Me.Panel12.TabIndex = 0
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl10)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl11)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 159)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(368, 272)
        Me.UltraTabControl2.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.UltraTabControl2.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl11
        UltraTab3.Text = "None"
        UltraTab4.TabPage = Me.UltraTabPageControl8
        UltraTab4.Text = "Simple"
        UltraTab5.TabPage = Me.UltraTabPageControl9
        UltraTab5.Text = "Complex"
        UltraTab6.TabPage = Me.UltraTabPageControl10
        UltraTab6.Text = "Custom"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(368, 272)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Delivery Clause"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_DelSchedType
        '
        Me.cmb_DelSchedType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem1.DataValue = "0"
        ValueListItem1.DisplayText = "None"
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "Simple"
        ValueListItem3.DataValue = "2"
        ValueListItem3.DisplayText = "Complex"
        ValueListItem4.DataValue = "3"
        ValueListItem4.DisplayText = "Custom"
        Me.cmb_DelSchedType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4})
        Me.cmb_DelSchedType.Location = New System.Drawing.Point(152, 32)
        Me.cmb_DelSchedType.Name = "cmb_DelSchedType"
        Me.cmb_DelSchedType.Size = New System.Drawing.Size(168, 21)
        Me.cmb_DelSchedType.TabIndex = 1
        '
        'UltraTabPageControl20
        '
        Me.UltraTabPageControl20.Controls.Add(Me.txt_DeliveryTo)
        Me.UltraTabPageControl20.Controls.Add(Me.Label30)
        Me.UltraTabPageControl20.Controls.Add(Me.txt_ConsigneePrefix)
        Me.UltraTabPageControl20.Controls.Add(Me.Label31)
        Me.UltraTabPageControl20.Controls.Add(Me.cmb_ConsigneeID)
        Me.UltraTabPageControl20.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl20.Name = "UltraTabPageControl20"
        Me.UltraTabPageControl20.Size = New System.Drawing.Size(950, 431)
        '
        'txt_DeliveryTo
        '
        Me.txt_DeliveryTo.Location = New System.Drawing.Point(25, 180)
        Me.txt_DeliveryTo.Multiline = True
        Me.txt_DeliveryTo.Name = "txt_DeliveryTo"
        Me.txt_DeliveryTo.Size = New System.Drawing.Size(432, 72)
        Me.txt_DeliveryTo.TabIndex = 16
        Me.txt_DeliveryTo.Text = "UltraTextEditor3"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(28, 162)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 14)
        Me.Label30.TabIndex = 15
        Me.Label30.Text = "Ship To"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ConsigneePrefix
        '
        Me.txt_ConsigneePrefix.AcceptsReturn = True
        Me.txt_ConsigneePrefix.Location = New System.Drawing.Point(25, 38)
        Me.txt_ConsigneePrefix.Multiline = True
        Me.txt_ConsigneePrefix.Name = "txt_ConsigneePrefix"
        Me.txt_ConsigneePrefix.Size = New System.Drawing.Size(432, 64)
        Me.txt_ConsigneePrefix.TabIndex = 13
        Me.txt_ConsigneePrefix.Text = "UltraTextEditor2"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label31.Location = New System.Drawing.Point(29, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(94, 14)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Consignee (Bill to)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_ConsigneeID
        '
        Me.cmb_ConsigneeID.Location = New System.Drawing.Point(25, 115)
        Me.cmb_ConsigneeID.Name = "cmb_ConsigneeID"
        Me.cmb_ConsigneeID.Size = New System.Drawing.Size(432, 22)
        Me.cmb_ConsigneeID.TabIndex = 14
        Me.cmb_ConsigneeID.Text = "UltraCombo3"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Label14)
        Me.UltraTabPageControl6.Controls.Add(Me.txt_Remark)
        Me.UltraTabPageControl6.Controls.Add(Me.Label13)
        Me.UltraTabPageControl6.Controls.Add(Me.txt_ClarifyComm)
        Me.UltraTabPageControl6.Controls.Add(Me.Label12)
        Me.UltraTabPageControl6.Controls.Add(Me.txt_ClarifyTech)
        Me.UltraTabPageControl6.Controls.Add(Me.Label11)
        Me.UltraTabPageControl6.Controls.Add(Me.txt_EnClSpec)
        Me.UltraTabPageControl6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(950, 431)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(63, 305)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 56)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Remarks"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(175, 305)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(488, 56)
        Me.txt_Remark.TabIndex = 7
        Me.txt_Remark.Text = "UltraTextEditor11"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(63, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 56)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Commercial Clarifications Required, if any"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ClarifyComm
        '
        Me.txt_ClarifyComm.AcceptsReturn = True
        Me.txt_ClarifyComm.Location = New System.Drawing.Point(175, 214)
        Me.txt_ClarifyComm.Multiline = True
        Me.txt_ClarifyComm.Name = "txt_ClarifyComm"
        Me.txt_ClarifyComm.Size = New System.Drawing.Size(488, 56)
        Me.txt_ClarifyComm.TabIndex = 5
        Me.txt_ClarifyComm.Text = "UltraTextEditor10"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(63, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 56)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Technical Clarifications Required, if any"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ClarifyTech
        '
        Me.txt_ClarifyTech.AcceptsReturn = True
        Me.txt_ClarifyTech.Location = New System.Drawing.Point(175, 134)
        Me.txt_ClarifyTech.Multiline = True
        Me.txt_ClarifyTech.Name = "txt_ClarifyTech"
        Me.txt_ClarifyTech.Size = New System.Drawing.Size(488, 56)
        Me.txt_ClarifyTech.TabIndex = 3
        Me.txt_ClarifyTech.Text = "UltraTextEditor9"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(63, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 56)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Customer / Our Specifications Enclosed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EnClSpec
        '
        Me.txt_EnClSpec.AcceptsReturn = True
        Me.txt_EnClSpec.Location = New System.Drawing.Point(175, 54)
        Me.txt_EnClSpec.Multiline = True
        Me.txt_EnClSpec.Name = "txt_EnClSpec"
        Me.txt_EnClSpec.Size = New System.Drawing.Size(488, 56)
        Me.txt_EnClSpec.TabIndex = 1
        Me.txt_EnClSpec.Text = "UltraTextEditor8"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.Panel4)
        Me.UltraTabPageControl12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(950, 431)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.UltraGridSpare)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(950, 431)
        Me.Panel4.TabIndex = 8
        '
        'UltraGridSpare
        '
        Me.UltraGridSpare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpare.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSpare.Name = "UltraGridSpare"
        Me.UltraGridSpare.Size = New System.Drawing.Size(950, 401)
        Me.UltraGridSpare.TabIndex = 0
        Me.UltraGridSpare.Text = "Delivery Schedule"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDownSpare)
        Me.Panel5.Controls.Add(Me.btnUPSpare)
        Me.Panel5.Controls.Add(Me.btnOutdentSpare)
        Me.Panel5.Controls.Add(Me.btnIndentSpare)
        Me.Panel5.Controls.Add(Me.btnDelSpare)
        Me.Panel5.Controls.Add(Me.btnAddChildSpare)
        Me.Panel5.Controls.Add(Me.btnAddSibSpare)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 401)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(950, 30)
        Me.Panel5.TabIndex = 1
        '
        'btnDownSpare
        '
        Me.btnDownSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDownSpare.Location = New System.Drawing.Point(456, 0)
        Me.btnDownSpare.Name = "btnDownSpare"
        Me.btnDownSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnDownSpare.TabIndex = 30
        Me.btnDownSpare.Text = "Move Down"
        '
        'btnUPSpare
        '
        Me.btnUPSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUPSpare.Location = New System.Drawing.Point(380, 0)
        Me.btnUPSpare.Name = "btnUPSpare"
        Me.btnUPSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnUPSpare.TabIndex = 29
        Me.btnUPSpare.Text = "Move Up"
        '
        'btnOutdentSpare
        '
        Me.btnOutdentSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOutdentSpare.Location = New System.Drawing.Point(304, 0)
        Me.btnOutdentSpare.Name = "btnOutdentSpare"
        Me.btnOutdentSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnOutdentSpare.TabIndex = 28
        Me.btnOutdentSpare.Text = "Outdent"
        '
        'btnIndentSpare
        '
        Me.btnIndentSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIndentSpare.Location = New System.Drawing.Point(228, 0)
        Me.btnIndentSpare.Name = "btnIndentSpare"
        Me.btnIndentSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnIndentSpare.TabIndex = 27
        Me.btnIndentSpare.Text = "Indent"
        '
        'btnDelSpare
        '
        Me.btnDelSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelSpare.Location = New System.Drawing.Point(152, 0)
        Me.btnDelSpare.Name = "btnDelSpare"
        Me.btnDelSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnDelSpare.TabIndex = 26
        Me.btnDelSpare.Text = "Delete"
        '
        'btnAddChildSpare
        '
        Me.btnAddChildSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddChildSpare.Location = New System.Drawing.Point(76, 0)
        Me.btnAddChildSpare.Name = "btnAddChildSpare"
        Me.btnAddChildSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnAddChildSpare.TabIndex = 25
        Me.btnAddChildSpare.Text = "Add Child"
        '
        'btnAddSibSpare
        '
        Me.btnAddSibSpare.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSibSpare.Location = New System.Drawing.Point(0, 0)
        Me.btnAddSibSpare.Name = "btnAddSibSpare"
        Me.btnAddSibSpare.Size = New System.Drawing.Size(76, 30)
        Me.btnAddSibSpare.TabIndex = 24
        Me.btnAddSibSpare.Text = "Add Sibling"
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.UltraGridSvc)
        Me.UltraTabPageControl18.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(950, 431)
        '
        'UltraGridSvc
        '
        Me.UltraGridSvc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSvc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSvc.Name = "UltraGridSvc"
        Me.UltraGridSvc.Size = New System.Drawing.Size(950, 401)
        Me.UltraGridSvc.TabIndex = 0
        Me.UltraGridSvc.Text = "Delivery Schedule"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnDownSRV)
        Me.Panel9.Controls.Add(Me.btnUpSRV)
        Me.Panel9.Controls.Add(Me.btnOutdentSRV)
        Me.Panel9.Controls.Add(Me.btnIndentSRV)
        Me.Panel9.Controls.Add(Me.btnDelSRV)
        Me.Panel9.Controls.Add(Me.btnAddChildSRV)
        Me.Panel9.Controls.Add(Me.btnAddSibSRV)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 401)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(950, 30)
        Me.Panel9.TabIndex = 1
        '
        'btnDownSRV
        '
        Me.btnDownSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDownSRV.Location = New System.Drawing.Point(456, 0)
        Me.btnDownSRV.Name = "btnDownSRV"
        Me.btnDownSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnDownSRV.TabIndex = 23
        Me.btnDownSRV.Text = "Move Down"
        '
        'btnUpSRV
        '
        Me.btnUpSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpSRV.Location = New System.Drawing.Point(380, 0)
        Me.btnUpSRV.Name = "btnUpSRV"
        Me.btnUpSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnUpSRV.TabIndex = 22
        Me.btnUpSRV.Text = "Move Up"
        '
        'btnOutdentSRV
        '
        Me.btnOutdentSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOutdentSRV.Location = New System.Drawing.Point(304, 0)
        Me.btnOutdentSRV.Name = "btnOutdentSRV"
        Me.btnOutdentSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnOutdentSRV.TabIndex = 21
        Me.btnOutdentSRV.Text = "Outdent"
        '
        'btnIndentSRV
        '
        Me.btnIndentSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIndentSRV.Location = New System.Drawing.Point(228, 0)
        Me.btnIndentSRV.Name = "btnIndentSRV"
        Me.btnIndentSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnIndentSRV.TabIndex = 20
        Me.btnIndentSRV.Text = "Indent"
        '
        'btnDelSRV
        '
        Me.btnDelSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelSRV.Location = New System.Drawing.Point(152, 0)
        Me.btnDelSRV.Name = "btnDelSRV"
        Me.btnDelSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnDelSRV.TabIndex = 19
        Me.btnDelSRV.Text = "Delete"
        '
        'btnAddChildSRV
        '
        Me.btnAddChildSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddChildSRV.Location = New System.Drawing.Point(76, 0)
        Me.btnAddChildSRV.Name = "btnAddChildSRV"
        Me.btnAddChildSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnAddChildSRV.TabIndex = 18
        Me.btnAddChildSRV.Text = "Add Child"
        '
        'btnAddSibSRV
        '
        Me.btnAddSibSRV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSibSRV.Location = New System.Drawing.Point(0, 0)
        Me.btnAddSibSRV.Name = "btnAddSibSRV"
        Me.btnAddSibSRV.Size = New System.Drawing.Size(76, 30)
        Me.btnAddSibSRV.TabIndex = 1
        Me.btnAddSibSRV.Text = "Add Sibling"
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(950, 431)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.UltraGridTF)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(950, 431)
        Me.Panel6.TabIndex = 8
        '
        'UltraGridTF
        '
        Me.UltraGridTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTF.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTF.Name = "UltraGridTF"
        Me.UltraGridTF.Size = New System.Drawing.Size(950, 401)
        Me.UltraGridTF.TabIndex = 0
        Me.UltraGridTF.Text = "Product Serials"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnEditSerial)
        Me.Panel7.Controls.Add(Me.btnEditTF)
        Me.Panel7.Controls.Add(Me.btnDelTF)
        Me.Panel7.Controls.Add(Me.btnAddTF)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 401)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(950, 30)
        Me.Panel7.TabIndex = 1
        '
        'btnEditSerial
        '
        Me.btnEditSerial.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditSerial.Location = New System.Drawing.Point(664, 0)
        Me.btnEditSerial.Name = "btnEditSerial"
        Me.btnEditSerial.Size = New System.Drawing.Size(72, 30)
        Me.btnEditSerial.TabIndex = 3
        Me.btnEditSerial.Text = "Edit Serial"
        '
        'btnEditTF
        '
        Me.btnEditTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditTF.Location = New System.Drawing.Point(736, 0)
        Me.btnEditTF.Name = "btnEditTF"
        Me.btnEditTF.Size = New System.Drawing.Size(72, 30)
        Me.btnEditTF.TabIndex = 0
        Me.btnEditTF.Text = "Edit"
        Me.btnEditTF.Visible = False
        '
        'btnDelTF
        '
        Me.btnDelTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelTF.Location = New System.Drawing.Point(808, 0)
        Me.btnDelTF.Name = "btnDelTF"
        Me.btnDelTF.Size = New System.Drawing.Size(70, 30)
        Me.btnDelTF.TabIndex = 1
        Me.btnDelTF.Text = "Delete"
        '
        'btnAddTF
        '
        Me.btnAddTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddTF.Location = New System.Drawing.Point(878, 0)
        Me.btnAddTF.Name = "btnAddTF"
        Me.btnAddTF.Size = New System.Drawing.Size(72, 30)
        Me.btnAddTF.TabIndex = 2
        Me.btnAddTF.Text = "Add New"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(950, 431)
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel14)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(950, 431)
        Me.Panel8.TabIndex = 8
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.UltraGridTT)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(950, 431)
        Me.Panel14.TabIndex = 1
        '
        'UltraGridTT
        '
        Me.UltraGridTT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTT.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTT.Name = "UltraGridTT"
        Me.UltraGridTT.Size = New System.Drawing.Size(950, 383)
        Me.UltraGridTT.TabIndex = 0
        Me.UltraGridTT.Text = "Type Tests"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.btnDelTT)
        Me.Panel16.Controls.Add(Me.btnAddTT)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(0, 383)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(950, 48)
        Me.Panel16.TabIndex = 1
        Me.Panel16.Visible = False
        '
        'btnDelTT
        '
        Me.btnDelTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelTT.Location = New System.Drawing.Point(770, 8)
        Me.btnDelTT.Name = "btnDelTT"
        Me.btnDelTT.Size = New System.Drawing.Size(70, 24)
        Me.btnDelTT.TabIndex = 0
        Me.btnDelTT.Text = "Delete"
        '
        'btnAddTT
        '
        Me.btnAddTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTT.Location = New System.Drawing.Point(850, 8)
        Me.btnAddTT.Name = "btnAddTT"
        Me.btnAddTT.Size = New System.Drawing.Size(72, 24)
        Me.btnAddTT.TabIndex = 1
        Me.btnAddTT.Text = "Add New"
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.Panel10)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(950, 431)
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.UltraGridDoc)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(950, 431)
        Me.Panel10.TabIndex = 8
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(950, 383)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Delivery Schedule"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.btnDelDoc)
        Me.Panel11.Controls.Add(Me.btnAddDoc)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 383)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(950, 48)
        Me.Panel11.TabIndex = 1
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Location = New System.Drawing.Point(773, 16)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Location = New System.Drawing.Point(869, 16)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 1
        Me.btnAddDoc.Text = "Add New"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnSave
        '
        Appearance20.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance20
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(690, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 45)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance21.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance21
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(778, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance22.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance22
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(866, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 45)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(950, 431)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl12)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl15)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl17)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl18)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl20)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance23.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance23
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(954, 457)
        Me.UltraTabControl1.TabIndex = 0
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        UltraTab7.TabPage = Me.UltraTabPageControl1
        UltraTab7.Text = "General"
        UltraTab8.Key = "eto"
        UltraTab8.TabPage = Me.UltraTabPageControl2
        UltraTab8.Text = "Parameters"
        UltraTab9.Key = "fittings"
        UltraTab9.TabPage = Me.UltraTabPageControl3
        UltraTab9.Text = "Fittings"
        UltraTab17.Key = "ratelist"
        UltraTab17.TabPage = Me.UltraTabPageControl17
        UltraTab17.Text = "Rate List"
        UltraTab19.Key = "sites"
        UltraTab19.TabPage = Me.UltraTabPageControl19
        UltraTab19.Text = "Sites"
        UltraTab10.TabPage = Me.UltraTabPageControl4
        UltraTab10.Text = "Charges"
        UltraTab11.TabPage = Me.UltraTabPageControl5
        UltraTab11.Text = "Delivery"
        UltraTab20.TabPage = Me.UltraTabPageControl20
        UltraTab20.Text = "Consignee"
        UltraTab12.TabPage = Me.UltraTabPageControl6
        UltraTab12.Text = "Clarifications"
        UltraTab13.Key = "SP"
        UltraTab13.TabPage = Me.UltraTabPageControl12
        UltraTab13.Text = "Spares"
        UltraTab18.Key = "SVC"
        UltraTab18.TabPage = Me.UltraTabPageControl18
        UltraTab18.Text = "Services"
        UltraTab14.Key = "TF"
        UltraTab14.TabPage = Me.UltraTabPageControl13
        UltraTab14.Text = "Serial Nos."
        UltraTab15.Key = "typetests"
        UltraTab15.TabPage = Me.UltraTabPageControl14
        UltraTab15.Text = "Type Tests"
        UltraTab16.TabPage = Me.UltraTabPageControl15
        UltraTab16.Text = "Documents"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8, UltraTab9, UltraTab17, UltraTab19, UltraTab10, UltraTab11, UltraTab20, UltraTab12, UltraTab13, UltraTab18, UltraTab14, UltraTab15, UltraTab16})
        '
        'frmWO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Work Order"
        Me.ClientSize = New System.Drawing.Size(954, 502)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmWO"
        Me.Text = "Work Order"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.chk_RepInspJoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_RepInspStage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl16.ResumeLayout(False)
        CType(Me.chk_InspecFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_InspecStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ApproveTTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ApproveQAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ApproveGTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ApproveDwG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.UltraTabPageControl8.PerformLayout()
        CType(Me.cmb_DSPaymentStageID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DSPeriodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DSPeriodNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        Me.UltraTabPageControl9.PerformLayout()
        CType(Me.cmb_DSPaymentStageID_Ref, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DSCompPeriodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DSCompPeriodNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DSCompRateType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DSCompRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DSAtLeastType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DSAtLeast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DSperiodType_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DSPeriodNum_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        Me.UltraTabPageControl10.PerformLayout()
        CType(Me.txt_DSCustom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_ProductCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InvDescrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_hsn_sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_completedon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanelQty.ClientArea.ResumeLayout(False)
        Me.UltraPanelQty.ClientArea.PerformLayout()
        Me.UltraPanelQty.ResumeLayout(False)
        CType(Me.txt_BOQNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalQty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_WOType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl3.ResumeLayout(False)
        CType(Me.dt_WODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ProdFileDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsInsured, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl17.ResumeLayout(False)
        CType(Me.UltraGridRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl19.ResumeLayout(False)
        CType(Me.UltraGridCampus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.txt_GPClauseWO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TPICharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_TPIApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StackingCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_StackingApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SuperChType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SuperCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_SuperApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Freight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        CType(Me.cmb_DelSchedType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl20.ResumeLayout(False)
        Me.UltraTabPageControl20.PerformLayout()
        CType(Me.txt_DeliveryTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ConsigneePrefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ConsigneeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.UltraTabPageControl6.PerformLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ClarifyComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ClarifyTech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EnClSpec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl18.ResumeLayout(False)
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.UltraGridTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.UltraTabPageControl15.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_ProjectName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_WOType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridRate As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSvc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnAddSibSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridCampus As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents btnEditCampus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelCampus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddCampus As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ComboUnit2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_TotalQty2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_DivisionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraPanelQty As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents dt_completedon As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents txt_GPClauseWO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_BOQNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnEditSerial As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_hsn_sc As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnAddHSN As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDownSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUpSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOutdentSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIndentSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddChildSRV As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDownSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUPSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOutdentSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnIndentSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddChildSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSibSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl20 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_DeliveryTo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents txt_ConsigneePrefix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label31 As Windows.Forms.Label
    Friend WithEvents cmb_ConsigneeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_InvDescrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ProductCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDate As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNum As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel

#End Region
End Class

