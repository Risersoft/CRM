<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSalesEnqItem
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
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddRemove1 As AddRemove
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_ItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_TPICharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_TPIApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_StackingCharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_StackingApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cmb_SuperChType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_SuperCharges As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_SuperApp As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_Freight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_UnitPrice As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ComboName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblFreight As System.Windows.Forms.Label
    Friend WithEvents txt_SalesEnqID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblUpto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TypicalGA As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridSpare As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridTT As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridCQ As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelTT As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddTT As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelCQ As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddCQ As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_QtyTBQ As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_QtyAPT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_IsRepair As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_FinalPrice As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_MatDepID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_QtyExp2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_QtyTBQ2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ComboUnit2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_QtyAPT2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_DesRemarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_InSalesOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_QtyExp = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dt_InDesignOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_DesignRef = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_MatDepID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chk_IsRepair = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_TypicalGA = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_QtyTBQ = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_SalesEnqID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_QtyAPT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_ItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ComboName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.AddRemove1 = New risersoft.[shared].win.AddRemove()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_FinalPrice = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUpto = New System.Windows.Forms.Label()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UltraGridSpare = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnDelSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSpare = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSvc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnDelService = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddService = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGridTT = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelTT = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTT = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.UltraGridCQ = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDelCQ = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddCQ = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.txt_EnqItemRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_QtyExp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyTBQ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyAPT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DesRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InSalesOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyExp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InDesignOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DesignRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_IsRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TypicalGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyTBQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SalesEnqID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QtyAPT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.txt_FinalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel6.SuspendLayout()
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl8.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.UltraGridCQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_EnqItemRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.txt_EnqItemRefNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label11)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyExp2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyTBQ2)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboUnit2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyAPT2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_DesRemarks)
        Me.UltraTabPageControl1.Controls.Add(Me.Label10)
        Me.UltraTabPageControl1.Controls.Add(Me.Label9)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_InSalesOn)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyExp)
        Me.UltraTabPageControl1.Controls.Add(Me.Label8)
        Me.UltraTabPageControl1.Controls.Add(Me.Label7)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_InDesignOn)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_DesignRef)
        Me.UltraTabPageControl1.Controls.Add(Me.Label6)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_MatDepID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label24)
        Me.UltraTabPageControl1.Controls.Add(Me.chk_IsRepair)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Remark)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_TypicalGA)
        Me.UltraTabPageControl1.Controls.Add(Me.Label3)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyTBQ)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_SalesEnqID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label22)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboUnit)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_QtyAPT)
        Me.UltraTabPageControl1.Controls.Add(Me.Label19)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ItemID)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboName)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(672, 405)
        '
        'txt_QtyExp2
        '
        Me.txt_QtyExp2.Location = New System.Drawing.Point(323, 148)
        Me.txt_QtyExp2.Name = "txt_QtyExp2"
        Me.txt_QtyExp2.ReadOnly = True
        Me.txt_QtyExp2.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyExp2.TabIndex = 16
        Me.txt_QtyExp2.Text = "UltraTextEditor17"
        '
        'txt_QtyTBQ2
        '
        Me.txt_QtyTBQ2.Location = New System.Drawing.Point(323, 121)
        Me.txt_QtyTBQ2.Name = "txt_QtyTBQ2"
        Me.txt_QtyTBQ2.ReadOnly = True
        Me.txt_QtyTBQ2.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyTBQ2.TabIndex = 13
        Me.txt_QtyTBQ2.Text = "UltraTextEditor17"
        '
        'ComboUnit2
        '
        Me.ComboUnit2.DataMember = "Items"
        Me.ComboUnit2.DisplayMember = "UnitName2"
        Me.ComboUnit2.Location = New System.Drawing.Point(387, 95)
        Me.ComboUnit2.MaxDropDownItems = 15
        Me.ComboUnit2.Name = "ComboUnit2"
        Me.ComboUnit2.ReadOnly = True
        Me.ComboUnit2.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit2.TabIndex = 10
        Me.ComboUnit2.Text = "UltraCombo3"
        Me.ComboUnit2.ValueMember = "ItemID"
        '
        'txt_QtyAPT2
        '
        Me.txt_QtyAPT2.Location = New System.Drawing.Point(323, 95)
        Me.txt_QtyAPT2.Name = "txt_QtyAPT2"
        Me.txt_QtyAPT2.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyAPT2.TabIndex = 9
        Me.txt_QtyAPT2.Text = "UltraTextEditor17"
        '
        'txt_DesRemarks
        '
        Me.txt_DesRemarks.AcceptsReturn = True
        Me.txt_DesRemarks.Location = New System.Drawing.Point(181, 354)
        Me.txt_DesRemarks.Multiline = True
        Me.txt_DesRemarks.Name = "txt_DesRemarks"
        Me.txt_DesRemarks.Size = New System.Drawing.Size(424, 44)
        Me.txt_DesRemarks.TabIndex = 30
        Me.txt_DesRemarks.Text = "UltraTextEditor12"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(53, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Remarks for Design"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(360, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Returned On"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_InSalesOn
        '
        Me.dt_InSalesOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_InSalesOn.Location = New System.Drawing.Point(452, 231)
        Me.dt_InSalesOn.Name = "dt_InSalesOn"
        Me.dt_InSalesOn.NullText = "Not Defined"
        Me.dt_InSalesOn.Size = New System.Drawing.Size(153, 21)
        Me.dt_InSalesOn.TabIndex = 24
        '
        'txt_QtyExp
        '
        Me.txt_QtyExp.Location = New System.Drawing.Point(181, 149)
        Me.txt_QtyExp.Name = "txt_QtyExp"
        Me.txt_QtyExp.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyExp.TabIndex = 15
        Me.txt_QtyExp.Text = "UltraTextEditor17"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(98, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Qty Expected"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(46, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Given in Design On"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_InDesignOn
        '
        Me.dt_InDesignOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_InDesignOn.Location = New System.Drawing.Point(181, 231)
        Me.dt_InDesignOn.Name = "dt_InDesignOn"
        Me.dt_InDesignOn.NullText = "Not Defined"
        Me.dt_InDesignOn.Size = New System.Drawing.Size(151, 21)
        Me.dt_InDesignOn.TabIndex = 22
        '
        'txt_DesignRef
        '
        Me.txt_DesignRef.Location = New System.Drawing.Point(181, 204)
        Me.txt_DesignRef.Name = "txt_DesignRef"
        Me.txt_DesignRef.Size = New System.Drawing.Size(424, 21)
        Me.txt_DesignRef.TabIndex = 20
        Me.txt_DesignRef.Text = "UltraTextEditor17"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(53, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Design File Reference"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_MatDepID
        '
        Me.cmb_MatDepID.Location = New System.Drawing.Point(181, 176)
        Me.cmb_MatDepID.Name = "cmb_MatDepID"
        Me.cmb_MatDepID.Size = New System.Drawing.Size(198, 22)
        Me.cmb_MatDepID.TabIndex = 18
        Me.cmb_MatDepID.Text = "UltraCombo4"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(61, 179)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 16)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Intended for Unit"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_IsRepair
        '
        Me.chk_IsRepair.Location = New System.Drawing.Point(387, 13)
        Me.chk_IsRepair.Name = "chk_IsRepair"
        Me.chk_IsRepair.Size = New System.Drawing.Size(120, 24)
        Me.chk_IsRepair.TabIndex = 5
        Me.chk_IsRepair.Text = "New / Repair"
        Me.chk_IsRepair.Visible = False
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(181, 304)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(424, 44)
        Me.txt_Remark.TabIndex = 28
        Me.txt_Remark.Text = "UltraTextEditor12"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(53, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Remarks"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_TypicalGA
        '
        Me.txt_TypicalGA.AcceptsReturn = True
        Me.txt_TypicalGA.Location = New System.Drawing.Point(181, 258)
        Me.txt_TypicalGA.Multiline = True
        Me.txt_TypicalGA.Name = "txt_TypicalGA"
        Me.txt_TypicalGA.Size = New System.Drawing.Size(424, 40)
        Me.txt_TypicalGA.TabIndex = 26
        Me.txt_TypicalGA.Text = "Typical GA"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(53, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Typical GA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_QtyTBQ
        '
        Me.txt_QtyTBQ.Location = New System.Drawing.Point(181, 122)
        Me.txt_QtyTBQ.Name = "txt_QtyTBQ"
        Me.txt_QtyTBQ.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyTBQ.TabIndex = 12
        Me.txt_QtyTBQ.Text = "UltraTextEditor17"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(53, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Qty To be Quoted"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_SalesEnqID
        '
        Me.txt_SalesEnqID.Location = New System.Drawing.Point(387, 41)
        Me.txt_SalesEnqID.Name = "txt_SalesEnqID"
        Me.txt_SalesEnqID.Size = New System.Drawing.Size(68, 21)
        Me.txt_SalesEnqID.TabIndex = 2
        Me.txt_SalesEnqID.Text = "ENquiryID"
        Me.txt_SalesEnqID.Visible = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(61, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Item Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit
        '
        Me.ComboUnit.DataMember = "Items"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Location = New System.Drawing.Point(245, 95)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit.TabIndex = 8
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "ItemID"
        '
        'txt_QtyAPT
        '
        Me.txt_QtyAPT.Location = New System.Drawing.Point(181, 95)
        Me.txt_QtyAPT.Name = "txt_QtyAPT"
        Me.txt_QtyAPT.Size = New System.Drawing.Size(56, 21)
        Me.txt_QtyAPT.TabIndex = 7
        Me.txt_QtyAPT.Text = "UltraTextEditor17"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(53, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Qty As per Enquiry"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(85, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemID
        '
        Me.cmb_ItemID.DataMember = "Items"
        Me.cmb_ItemID.DisplayMember = "ItemCode"
        Me.cmb_ItemID.Location = New System.Drawing.Point(181, 40)
        Me.cmb_ItemID.MaxDropDownItems = 15
        Me.cmb_ItemID.Name = "cmb_ItemID"
        Me.cmb_ItemID.Size = New System.Drawing.Size(198, 22)
        Me.cmb_ItemID.TabIndex = 1
        Me.cmb_ItemID.Text = "UltraCombo2"
        Me.cmb_ItemID.ValueMember = "ItemID"
        '
        'ComboName
        '
        Me.ComboName.DataMember = "Items"
        Me.ComboName.DisplayMember = "ItemName"
        Me.ComboName.Location = New System.Drawing.Point(181, 68)
        Me.ComboName.MaxDropDownItems = 15
        Me.ComboName.Name = "ComboName"
        Me.ComboName.Size = New System.Drawing.Size(360, 22)
        Me.ComboName.TabIndex = 4
        Me.ComboName.Text = "UltraCombo1"
        Me.ComboName.ValueMember = "ItemID"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(672, 405)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.AddRemove1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(672, 405)
        '
        'AddRemove1
        '
        Me.AddRemove1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddRemove1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemove1.Location = New System.Drawing.Point(0, 0)
        Me.AddRemove1.Mode = 0
        Me.AddRemove1.Name = "AddRemove1"
        Me.AddRemove1.Size = New System.Drawing.Size(672, 405)
        Me.AddRemove1.TabIndex = 0
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.txt_FinalPrice)
        Me.UltraTabPageControl4.Controls.Add(Me.Label5)
        Me.UltraTabPageControl4.Controls.Add(Me.lblUpto)
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
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(672, 405)
        '
        'txt_FinalPrice
        '
        Me.txt_FinalPrice.Location = New System.Drawing.Point(224, 72)
        Me.txt_FinalPrice.Name = "txt_FinalPrice"
        Me.txt_FinalPrice.Size = New System.Drawing.Size(136, 21)
        Me.txt_FinalPrice.TabIndex = 3
        Me.txt_FinalPrice.Text = "UltraTextEditor12"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Unit Price (Ex-Works) Final"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUpto
        '
        Me.lblUpto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpto.Location = New System.Drawing.Point(368, 104)
        Me.lblUpto.Name = "lblUpto"
        Me.lblUpto.Size = New System.Drawing.Size(120, 16)
        Me.lblUpto.TabIndex = 6
        Me.lblUpto.Text = "Upto Jhumritalaya"
        Me.lblUpto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(368, 264)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 16)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "per Unit"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(368, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "per Unit"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_TPICharges
        '
        Me.txt_TPICharges.Location = New System.Drawing.Point(224, 264)
        Me.txt_TPICharges.Name = "txt_TPICharges"
        Me.txt_TPICharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_TPICharges.TabIndex = 14
        Me.txt_TPICharges.Text = "UltraTextEditor16"
        '
        'chk_TPIApp
        '
        Me.chk_TPIApp.Location = New System.Drawing.Point(128, 248)
        Me.chk_TPIApp.Name = "chk_TPIApp"
        Me.chk_TPIApp.Size = New System.Drawing.Size(88, 48)
        Me.chk_TPIApp.TabIndex = 13
        Me.chk_TPIApp.Text = "Third Party Inspection Charges"
        '
        'txt_StackingCharges
        '
        Me.txt_StackingCharges.Location = New System.Drawing.Point(224, 208)
        Me.txt_StackingCharges.Name = "txt_StackingCharges"
        Me.txt_StackingCharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_StackingCharges.TabIndex = 11
        Me.txt_StackingCharges.Text = "UltraTextEditor15"
        '
        'chk_StackingApp
        '
        Me.chk_StackingApp.Location = New System.Drawing.Point(128, 192)
        Me.chk_StackingApp.Name = "chk_StackingApp"
        Me.chk_StackingApp.Size = New System.Drawing.Size(88, 48)
        Me.chk_StackingApp.TabIndex = 10
        Me.chk_StackingApp.Text = "Stacking and Unloading Charges"
        '
        'cmb_SuperChType
        '
        Me.cmb_SuperChType.Location = New System.Drawing.Point(368, 152)
        Me.cmb_SuperChType.Name = "cmb_SuperChType"
        Me.cmb_SuperChType.Size = New System.Drawing.Size(64, 21)
        Me.cmb_SuperChType.TabIndex = 9
        Me.cmb_SuperChType.Text = "UltraComboEditor9"
        '
        'txt_SuperCharges
        '
        Me.txt_SuperCharges.Location = New System.Drawing.Point(224, 152)
        Me.txt_SuperCharges.Name = "txt_SuperCharges"
        Me.txt_SuperCharges.Size = New System.Drawing.Size(136, 21)
        Me.txt_SuperCharges.TabIndex = 8
        Me.txt_SuperCharges.Text = "UltraTextEditor14"
        '
        'chk_SuperApp
        '
        Me.chk_SuperApp.Location = New System.Drawing.Point(128, 136)
        Me.chk_SuperApp.Name = "chk_SuperApp"
        Me.chk_SuperApp.Size = New System.Drawing.Size(80, 48)
        Me.chk_SuperApp.TabIndex = 7
        Me.chk_SuperApp.Text = "Supervision Charges"
        '
        'txt_Freight
        '
        Me.txt_Freight.Location = New System.Drawing.Point(224, 104)
        Me.txt_Freight.Name = "txt_Freight"
        Me.txt_Freight.Size = New System.Drawing.Size(136, 21)
        Me.txt_Freight.TabIndex = 5
        Me.txt_Freight.Text = "UltraTextEditor13"
        '
        'lblFreight
        '
        Me.lblFreight.Location = New System.Drawing.Point(104, 104)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(120, 16)
        Me.lblFreight.TabIndex = 4
        Me.lblFreight.Text = "Freight"
        Me.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_UnitPrice
        '
        Me.txt_UnitPrice.Location = New System.Drawing.Point(224, 40)
        Me.txt_UnitPrice.Name = "txt_UnitPrice"
        Me.txt_UnitPrice.Size = New System.Drawing.Size(136, 21)
        Me.txt_UnitPrice.TabIndex = 1
        Me.txt_UnitPrice.Text = "UltraTextEditor12"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(104, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Unit Price (Ex-Works)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(672, 405)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.UltraGridSpare)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(672, 405)
        Me.Panel6.TabIndex = 8
        '
        'UltraGridSpare
        '
        Me.UltraGridSpare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpare.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSpare.Name = "UltraGridSpare"
        Me.UltraGridSpare.Size = New System.Drawing.Size(672, 357)
        Me.UltraGridSpare.TabIndex = 0
        Me.UltraGridSpare.Text = "Delivery Schedule"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelSpare)
        Me.Panel7.Controls.Add(Me.btnAddSpare)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 357)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(672, 48)
        Me.Panel7.TabIndex = 1
        '
        'btnDelSpare
        '
        Me.btnDelSpare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelSpare.Location = New System.Drawing.Point(452, 16)
        Me.btnDelSpare.Name = "btnDelSpare"
        Me.btnDelSpare.Size = New System.Drawing.Size(70, 24)
        Me.btnDelSpare.TabIndex = 0
        Me.btnDelSpare.Text = "Delete"
        '
        'btnAddSpare
        '
        Me.btnAddSpare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSpare.Location = New System.Drawing.Point(548, 16)
        Me.btnAddSpare.Name = "btnAddSpare"
        Me.btnAddSpare.Size = New System.Drawing.Size(72, 24)
        Me.btnAddSpare.TabIndex = 1
        Me.btnAddSpare.Text = "Add New"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraGridSvc)
        Me.UltraTabPageControl9.Controls.Add(Me.Panel10)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(672, 405)
        '
        'UltraGridSvc
        '
        Me.UltraGridSvc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSvc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSvc.Name = "UltraGridSvc"
        Me.UltraGridSvc.Size = New System.Drawing.Size(672, 375)
        Me.UltraGridSvc.TabIndex = 0
        Me.UltraGridSvc.Text = "Delivery Schedule"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnDelService)
        Me.Panel10.Controls.Add(Me.btnAddService)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 375)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(672, 30)
        Me.Panel10.TabIndex = 1
        '
        'btnDelService
        '
        Me.btnDelService.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelService.Location = New System.Drawing.Point(530, 0)
        Me.btnDelService.Name = "btnDelService"
        Me.btnDelService.Size = New System.Drawing.Size(70, 30)
        Me.btnDelService.TabIndex = 0
        Me.btnDelService.Text = "Delete"
        '
        'btnAddService
        '
        Me.btnAddService.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddService.Location = New System.Drawing.Point(600, 0)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(72, 30)
        Me.btnAddService.TabIndex = 1
        Me.btnAddService.Text = "Add New"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(672, 405)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraGridDoc)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 405)
        Me.Panel1.TabIndex = 8
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(672, 357)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Delivery Schedule"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelDoc)
        Me.Panel5.Controls.Add(Me.btnAddDoc)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 357)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(672, 48)
        Me.Panel5.TabIndex = 1
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Location = New System.Drawing.Point(452, 16)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Location = New System.Drawing.Point(548, 16)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 1
        Me.btnAddDoc.Text = "Add New"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(672, 405)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridTT)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 405)
        Me.Panel2.TabIndex = 8
        '
        'UltraGridTT
        '
        Me.UltraGridTT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTT.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTT.Name = "UltraGridTT"
        Me.UltraGridTT.Size = New System.Drawing.Size(672, 357)
        Me.UltraGridTT.TabIndex = 0
        Me.UltraGridTT.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelTT)
        Me.Panel3.Controls.Add(Me.btnAddTT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnDelTT
        '
        Me.btnDelTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelTT.Location = New System.Drawing.Point(452, 16)
        Me.btnDelTT.Name = "btnDelTT"
        Me.btnDelTT.Size = New System.Drawing.Size(70, 24)
        Me.btnDelTT.TabIndex = 0
        Me.btnDelTT.Text = "Delete"
        '
        'btnAddTT
        '
        Me.btnAddTT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTT.Location = New System.Drawing.Point(548, 16)
        Me.btnAddTT.Name = "btnAddTT"
        Me.btnAddTT.Size = New System.Drawing.Size(72, 24)
        Me.btnAddTT.TabIndex = 1
        Me.btnAddTT.Text = "Add New"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(672, 405)
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.UltraGridCQ)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(672, 405)
        Me.Panel8.TabIndex = 8
        '
        'UltraGridCQ
        '
        Me.UltraGridCQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridCQ.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridCQ.Name = "UltraGridCQ"
        Me.UltraGridCQ.Size = New System.Drawing.Size(672, 357)
        Me.UltraGridCQ.TabIndex = 0
        Me.UltraGridCQ.Text = "Delivery Schedule"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnDelCQ)
        Me.Panel9.Controls.Add(Me.btnAddCQ)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 357)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(672, 48)
        Me.Panel9.TabIndex = 1
        '
        'btnDelCQ
        '
        Me.btnDelCQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelCQ.Location = New System.Drawing.Point(452, 16)
        Me.btnDelCQ.Name = "btnDelCQ"
        Me.btnDelCQ.Size = New System.Drawing.Size(70, 24)
        Me.btnDelCQ.TabIndex = 0
        Me.btnDelCQ.Text = "Delete"
        '
        'btnAddCQ
        '
        Me.btnAddCQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCQ.Location = New System.Drawing.Point(548, 16)
        Me.btnAddCQ.Name = "btnAddCQ"
        Me.btnAddCQ.Size = New System.Drawing.Size(72, 24)
        Me.btnAddCQ.TabIndex = 1
        Me.btnAddCQ.Text = "Add New"
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
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl8)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl9)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance1
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(676, 431)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "General"
        UltraTab2.Key = "eto"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Technical"
        UltraTab3.Key = "fittings"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Fittings"
        UltraTab3.Visible = False
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Charges"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Spares"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Services"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Special Documents"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Type Tests"
        UltraTab8.TabPage = Me.UltraTabPageControl8
        UltraTab8.Text = "Comparative Quotes"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab9, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(672, 405)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 431)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(676, 39)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(412, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 39)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(500, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 39)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(588, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 39)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'txt_EnqItemRefNum
        '
        Me.txt_EnqItemRefNum.Location = New System.Drawing.Point(181, 13)
        Me.txt_EnqItemRefNum.Name = "txt_EnqItemRefNum"
        Me.txt_EnqItemRefNum.Size = New System.Drawing.Size(198, 21)
        Me.txt_EnqItemRefNum.TabIndex = 32
        Me.txt_EnqItemRefNum.Text = "UltraTextEditor17"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(98, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Ref No."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSalesEnqItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Enquiry Rating"
        Me.ClientSize = New System.Drawing.Size(676, 470)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesEnqItem"
        Me.Text = "Enquiry Rating"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_QtyExp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyTBQ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyAPT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DesRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InSalesOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyExp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InDesignOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DesignRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_IsRepair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TypicalGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyTBQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SalesEnqID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QtyAPT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.txt_FinalPrice, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.Panel6.ResumeLayout(False)
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl8.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.UltraGridCQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_EnqItemRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_DesignRef As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dt_InDesignOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_QtyExp As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dt_InSalesOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_DesRemarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_QtyAPT2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_QtyExp2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_QtyTBQ2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSvc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btnDelService As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddService As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_EnqItemRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label11 As Windows.Forms.Label

#End Region
End Class

