<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmRepairUnit
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
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblFreight As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridRepItems As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dt_JInspecDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_JInspStatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_EcoLimit As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_MBDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_MBPage As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_MBNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_EstimateNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_BillBasedOnActual As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridInsp = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnDelPers = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPers = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelEmp = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddEmp = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboUnit2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_TotalQty2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_TotalQty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_Weight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_RUStatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_serialNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_CodeNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Year = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Make = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cmb_BillBasedOnActual = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dt_JInspecDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_JInspStatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_EcoLimit = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dt_MBDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txt_MBPage = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_MBNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_EstimateNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblFreight = New System.Windows.Forms.Label()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridRepItems = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSpare = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSpare = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSvc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDelService = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddService = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridInsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalQty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RUStatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_serialNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CodeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.cmb_BillBasedOnActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_JInspecDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_JInspStatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EcoLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_MBDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MBPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MBNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EstimateNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGridRepItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridInsp)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel11)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(760, 168)
        '
        'UltraGridInsp
        '
        Me.UltraGridInsp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridInsp.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridInsp.Name = "UltraGridInsp"
        Me.UltraGridInsp.Size = New System.Drawing.Size(760, 144)
        Me.UltraGridInsp.TabIndex = 0
        Me.UltraGridInsp.Text = "Joint Inspection By"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.btnDelPers)
        Me.Panel11.Controls.Add(Me.btnAddPers)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 144)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(760, 24)
        Me.Panel11.TabIndex = 24
        '
        'btnDelPers
        '
        Me.btnDelPers.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelPers.Location = New System.Drawing.Point(101, 0)
        Me.btnDelPers.Name = "btnDelPers"
        Me.btnDelPers.Size = New System.Drawing.Size(72, 24)
        Me.btnDelPers.TabIndex = 1
        Me.btnDelPers.Text = "Delete"
        '
        'btnAddPers
        '
        Me.btnAddPers.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddPers.Location = New System.Drawing.Point(0, 0)
        Me.btnAddPers.Name = "btnAddPers"
        Me.btnAddPers.Size = New System.Drawing.Size(101, 24)
        Me.btnAddPers.TabIndex = 0
        Me.btnAddPers.Text = "Add"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl6.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(760, 168)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(760, 144)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "Joint Inspection By"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDelEmp)
        Me.Panel1.Controls.Add(Me.btnAddEmp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 24)
        Me.Panel1.TabIndex = 26
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelEmp.Location = New System.Drawing.Point(101, 0)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(72, 24)
        Me.btnDelEmp.TabIndex = 1
        Me.btnDelEmp.Text = "Delete"
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddEmp.Location = New System.Drawing.Point(0, 0)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(101, 24)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.Text = "Add"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(764, 353)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboUnit2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_TotalQty2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label20)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboUnit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_TotalQty)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label19)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Weight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmb_RUStatusNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_serialNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_CodeNum)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Year)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_Make)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 353)
        Me.SplitContainer1.SplitterDistance = 450
        Me.SplitContainer1.TabIndex = 0
        '
        'ComboUnit2
        '
        Me.ComboUnit2.DataMember = "Items"
        Me.ComboUnit2.DisplayMember = "UnitName2"
        Me.ComboUnit2.Location = New System.Drawing.Point(158, 273)
        Me.ComboUnit2.MaxDropDownItems = 15
        Me.ComboUnit2.Name = "ComboUnit2"
        Me.ComboUnit2.ReadOnly = True
        Me.ComboUnit2.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit2.TabIndex = 17
        Me.ComboUnit2.Text = "UltraCombo3"
        Me.ComboUnit2.ValueMember = "ItemID"
        '
        'txt_TotalQty2
        '
        Me.txt_TotalQty2.Location = New System.Drawing.Point(94, 273)
        Me.txt_TotalQty2.Name = "txt_TotalQty2"
        Me.txt_TotalQty2.ReadOnly = True
        Me.txt_TotalQty2.Size = New System.Drawing.Size(56, 21)
        Me.txt_TotalQty2.TabIndex = 16
        Me.txt_TotalQty2.Text = "UltraTextEditor17"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(1, 273)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Total Qty 2"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit
        '
        Me.ComboUnit.DataMember = "Items"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Location = New System.Drawing.Point(158, 246)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(72, 22)
        Me.ComboUnit.TabIndex = 14
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "ItemID"
        '
        'txt_TotalQty
        '
        Me.txt_TotalQty.Location = New System.Drawing.Point(94, 246)
        Me.txt_TotalQty.Name = "txt_TotalQty"
        Me.txt_TotalQty.ReadOnly = True
        Me.txt_TotalQty.Size = New System.Drawing.Size(56, 21)
        Me.txt_TotalQty.TabIndex = 13
        Me.txt_TotalQty.Text = "UltraTextEditor17"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(1, 246)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Total Qty"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(94, 219)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.Size = New System.Drawing.Size(136, 21)
        Me.txt_Weight.TabIndex = 11
        Me.txt_Weight.Text = "UltraTextEditor12"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(33, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Weight"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(13, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Repair Status"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_RUStatusNum
        '
        Me.cmb_RUStatusNum.DataMember = "Items"
        Me.cmb_RUStatusNum.DisplayMember = "ItemName"
        Me.cmb_RUStatusNum.Location = New System.Drawing.Point(13, 39)
        Me.cmb_RUStatusNum.MaxDropDownItems = 15
        Me.cmb_RUStatusNum.Name = "cmb_RUStatusNum"
        Me.cmb_RUStatusNum.Size = New System.Drawing.Size(288, 22)
        Me.cmb_RUStatusNum.TabIndex = 1
        Me.cmb_RUStatusNum.Text = "UltraCombo1"
        Me.cmb_RUStatusNum.ValueMember = "ItemID"
        '
        'txt_serialNum
        '
        Me.txt_serialNum.Location = New System.Drawing.Point(94, 183)
        Me.txt_serialNum.Name = "txt_serialNum"
        Me.txt_serialNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_serialNum.TabIndex = 9
        Me.txt_serialNum.Text = "UltraTextEditor12"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 40)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Original Serial No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CodeNum
        '
        Me.txt_CodeNum.Location = New System.Drawing.Point(94, 143)
        Me.txt_CodeNum.Name = "txt_CodeNum"
        Me.txt_CodeNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_CodeNum.TabIndex = 7
        Me.txt_CodeNum.Text = "UltraTextEditor12"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(33, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Code No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Year
        '
        Me.txt_Year.Location = New System.Drawing.Point(94, 111)
        Me.txt_Year.Name = "txt_Year"
        Me.txt_Year.Size = New System.Drawing.Size(136, 21)
        Me.txt_Year.TabIndex = 5
        Me.txt_Year.Text = "UltraTextEditor12"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Year"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Make
        '
        Me.txt_Make.Location = New System.Drawing.Point(94, 79)
        Me.txt_Make.Name = "txt_Make"
        Me.txt_Make.Size = New System.Drawing.Size(136, 21)
        Me.txt_Make.TabIndex = 3
        Me.txt_Make.Text = "UltraTextEditor12"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Make"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl4.Controls.Add(Me.Panel10)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(764, 353)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 159)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl2.SelectedTabAppearance = Appearance1
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.UltraTabControl2.Size = New System.Drawing.Size(764, 194)
        Me.UltraTabControl2.TabIndex = 1
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Inspected By"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Attended By"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab5, UltraTab6})
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(760, 168)
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.cmb_BillBasedOnActual)
        Me.Panel10.Controls.Add(Me.dt_JInspecDate)
        Me.Panel10.Controls.Add(Me.Label14)
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.cmb_JInspStatusNum)
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Controls.Add(Me.txt_EcoLimit)
        Me.Panel10.Controls.Add(Me.Label11)
        Me.Panel10.Controls.Add(Me.dt_MBDate)
        Me.Panel10.Controls.Add(Me.lblRef)
        Me.Panel10.Controls.Add(Me.txt_MBPage)
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.txt_MBNum)
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Controls.Add(Me.txt_EstimateNum)
        Me.Panel10.Controls.Add(Me.lblFreight)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(764, 159)
        Me.Panel10.TabIndex = 0
        '
        'cmb_BillBasedOnActual
        '
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Estimate"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Actual"
        Me.cmb_BillBasedOnActual.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_BillBasedOnActual.Location = New System.Drawing.Point(336, 80)
        Me.cmb_BillBasedOnActual.Name = "cmb_BillBasedOnActual"
        Me.cmb_BillBasedOnActual.Size = New System.Drawing.Size(176, 21)
        Me.cmb_BillBasedOnActual.TabIndex = 11
        Me.cmb_BillBasedOnActual.Text = "Try"
        '
        'dt_JInspecDate
        '
        Me.dt_JInspecDate.DateTime = New Date(2015, 3, 27, 0, 0, 0, 0)
        Me.dt_JInspecDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_JInspecDate.Location = New System.Drawing.Point(384, 127)
        Me.dt_JInspecDate.Name = "dt_JInspecDate"
        Me.dt_JInspecDate.NullText = "Not Defined"
        Me.dt_JInspecDate.Size = New System.Drawing.Size(152, 21)
        Me.dt_JInspecDate.TabIndex = 15
        Me.dt_JInspecDate.Value = New Date(2015, 3, 27, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(384, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Joint Inspection Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(88, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Joint Inspection Status"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_JInspStatusNum
        '
        Me.cmb_JInspStatusNum.DataMember = "Items"
        Me.cmb_JInspStatusNum.DisplayMember = "ItemName"
        Me.cmb_JInspStatusNum.Location = New System.Drawing.Point(88, 127)
        Me.cmb_JInspStatusNum.MaxDropDownItems = 15
        Me.cmb_JInspStatusNum.Name = "cmb_JInspStatusNum"
        Me.cmb_JInspStatusNum.Size = New System.Drawing.Size(288, 22)
        Me.cmb_JInspStatusNum.TabIndex = 13
        Me.cmb_JInspStatusNum.Text = "UltraCombo1"
        Me.cmb_JInspStatusNum.ValueMember = "ItemID"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(248, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Bill based On"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EcoLimit
        '
        Me.txt_EcoLimit.Location = New System.Drawing.Point(336, 48)
        Me.txt_EcoLimit.Name = "txt_EcoLimit"
        Me.txt_EcoLimit.Size = New System.Drawing.Size(136, 21)
        Me.txt_EcoLimit.TabIndex = 7
        Me.txt_EcoLimit.Text = "UltraTextEditor13"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(240, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 24)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Economical Limit"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_MBDate
        '
        Me.dt_MBDate.DateTime = New Date(2015, 3, 27, 0, 0, 0, 0)
        Me.dt_MBDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_MBDate.Location = New System.Drawing.Point(328, 16)
        Me.dt_MBDate.Name = "dt_MBDate"
        Me.dt_MBDate.NullText = "Not Defined"
        Me.dt_MBDate.Size = New System.Drawing.Size(152, 21)
        Me.dt_MBDate.TabIndex = 3
        Me.dt_MBDate.Value = New Date(2015, 3, 27, 0, 0, 0, 0)
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(232, 16)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(80, 16)
        Me.lblRef.TabIndex = 2
        Me.lblRef.Text = "MB Date"
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MBPage
        '
        Me.txt_MBPage.Location = New System.Drawing.Point(88, 48)
        Me.txt_MBPage.Name = "txt_MBPage"
        Me.txt_MBPage.Size = New System.Drawing.Size(136, 21)
        Me.txt_MBPage.TabIndex = 5
        Me.txt_MBPage.Text = "UltraTextEditor13"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "MB Page"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MBNum
        '
        Me.txt_MBNum.Location = New System.Drawing.Point(88, 16)
        Me.txt_MBNum.Name = "txt_MBNum"
        Me.txt_MBNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_MBNum.TabIndex = 1
        Me.txt_MBNum.Text = "UltraTextEditor13"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "MB No."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EstimateNum
        '
        Me.txt_EstimateNum.Location = New System.Drawing.Point(88, 80)
        Me.txt_EstimateNum.Name = "txt_EstimateNum"
        Me.txt_EstimateNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_EstimateNum.TabIndex = 9
        Me.txt_EstimateNum.Text = "UltraTextEditor13"
        '
        'lblFreight
        '
        Me.lblFreight.Location = New System.Drawing.Point(8, 80)
        Me.lblFreight.Name = "lblFreight"
        Me.lblFreight.Size = New System.Drawing.Size(72, 16)
        Me.lblFreight.TabIndex = 8
        Me.lblFreight.Text = "Estimate No."
        Me.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridRepItems)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(764, 353)
        '
        'UltraGridRepItems
        '
        Me.UltraGridRepItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRepItems.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridRepItems.Name = "UltraGridRepItems"
        Me.UltraGridRepItems.Size = New System.Drawing.Size(764, 353)
        Me.UltraGridRepItems.TabIndex = 0
        Me.UltraGridRepItems.Text = "Repair Items"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGridSpare)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(764, 353)
        '
        'UltraGridSpare
        '
        Me.UltraGridSpare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpare.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSpare.Name = "UltraGridSpare"
        Me.UltraGridSpare.Size = New System.Drawing.Size(764, 324)
        Me.UltraGridSpare.TabIndex = 0
        Me.UltraGridSpare.Text = "Delivery Schedule"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelSpare)
        Me.Panel5.Controls.Add(Me.btnAddSpare)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 324)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(764, 29)
        Me.Panel5.TabIndex = 1
        '
        'btnDelSpare
        '
        Me.btnDelSpare.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelSpare.Location = New System.Drawing.Point(622, 0)
        Me.btnDelSpare.Name = "btnDelSpare"
        Me.btnDelSpare.Size = New System.Drawing.Size(70, 29)
        Me.btnDelSpare.TabIndex = 0
        Me.btnDelSpare.Text = "Delete"
        '
        'btnAddSpare
        '
        Me.btnAddSpare.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddSpare.Location = New System.Drawing.Point(692, 0)
        Me.btnAddSpare.Name = "btnAddSpare"
        Me.btnAddSpare.Size = New System.Drawing.Size(72, 29)
        Me.btnAddSpare.TabIndex = 1
        Me.btnAddSpare.Text = "Add New"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGridSvc)
        Me.UltraTabPageControl7.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(764, 353)
        '
        'UltraGridSvc
        '
        Me.UltraGridSvc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSvc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSvc.Name = "UltraGridSvc"
        Me.UltraGridSvc.Size = New System.Drawing.Size(764, 323)
        Me.UltraGridSvc.TabIndex = 0
        Me.UltraGridSvc.Text = "Delivery Schedule"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnDelService)
        Me.Panel9.Controls.Add(Me.btnAddService)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 323)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(764, 30)
        Me.Panel9.TabIndex = 1
        '
        'btnDelService
        '
        Me.btnDelService.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelService.Location = New System.Drawing.Point(622, 0)
        Me.btnDelService.Name = "btnDelService"
        Me.btnDelService.Size = New System.Drawing.Size(70, 30)
        Me.btnDelService.TabIndex = 0
        Me.btnDelService.Text = "Delete"
        '
        'btnAddService
        '
        Me.btnAddService.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddService.Location = New System.Drawing.Point(692, 0)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(72, 30)
        Me.btnAddService.TabIndex = 1
        Me.btnAddService.Text = "Add New"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance5.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance5
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(768, 379)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab7.TabPage = Me.UltraTabPageControl2
        UltraTab7.Text = "Product"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Estimate / Joint Inspection"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Rate List"
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Materials"
        UltraTab4.TabPage = Me.UltraTabPageControl7
        UltraTab4.Text = "Services"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab2, UltraTab3, UltraTab1, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(764, 353)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 379)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(768, 42)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(504, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(592, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 42)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(680, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'frmRepairUnit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Repair"
        Me.ClientSize = New System.Drawing.Size(768, 421)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRepairUnit"
        Me.Text = "Repair"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridInsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalQty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RUStatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_serialNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CodeNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.cmb_BillBasedOnActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_JInspecDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_JInspStatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EcoLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_MBDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MBPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MBNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EstimateNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGridRepItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGridSvc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txt_Weight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_RUStatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_serialNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_CodeNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Year As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Make As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_TotalQty2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_TotalQty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridInsp As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents btnDelPers As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPers As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelEmp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddEmp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSpare As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDelSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridSvc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnDelService As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddService As Infragistics.Win.Misc.UltraButton

#End Region
End Class

