<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmIO
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
    Friend WithEvents dt_OrderDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents ComboUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_Qty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_OrderNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_ItemID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents CmbItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents AddRemove1 As AddRemove
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridTF As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnEditTF As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
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
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.cmb_DivisionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ComboUnit2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_Qty2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmb_CompanyID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dt_OrderDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.ComboUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_Qty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_OrderNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_ItemID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.CmbItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.AddRemove1 = New risersoft.[shared].win.AddRemove()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.UltraGridTF = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnEditTF = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.UltraGridTT = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.btnDelTT = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddTT = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.cmb_MatDepID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OrderNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraTabPageControl13.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.UltraGridTF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl14.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_MatDepID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label2)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_DivisionID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label27)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboUnit2)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Qty2)
        Me.UltraTabPageControl1.Controls.Add(Me.Label20)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_CompanyID)
        Me.UltraTabPageControl1.Controls.Add(Me.Label24)
        Me.UltraTabPageControl1.Controls.Add(Me.dt_OrderDate)
        Me.UltraTabPageControl1.Controls.Add(Me.Label22)
        Me.UltraTabPageControl1.Controls.Add(Me.lblDate)
        Me.UltraTabPageControl1.Controls.Add(Me.lblNum)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboUnit)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_Qty)
        Me.UltraTabPageControl1.Controls.Add(Me.Label19)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_OrderNum)
        Me.UltraTabPageControl1.Controls.Add(Me.Label1)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ItemID)
        Me.UltraTabPageControl1.Controls.Add(Me.CmbItemName)
        Me.UltraTabPageControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(851, 431)
        '
        'cmb_DivisionID
        '
        Me.cmb_DivisionID.Location = New System.Drawing.Point(168, 252)
        Me.cmb_DivisionID.Name = "cmb_DivisionID"
        Me.cmb_DivisionID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_DivisionID.TabIndex = 29
        Me.cmb_DivisionID.Text = "UltraCombo4"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(48, 255)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 16)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Division"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit2
        '
        Appearance1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit2.Appearance = Appearance1
        Me.ComboUnit2.DataMember = "Items"
        Me.ComboUnit2.DisplayMember = "UnitName2"
        Me.ComboUnit2.Location = New System.Drawing.Point(265, 195)
        Me.ComboUnit2.MaxDropDownItems = 15
        Me.ComboUnit2.Name = "ComboUnit2"
        Me.ComboUnit2.ReadOnly = True
        Me.ComboUnit2.Size = New System.Drawing.Size(103, 22)
        Me.ComboUnit2.TabIndex = 13
        Me.ComboUnit2.Text = "UltraCombo3"
        Me.ComboUnit2.ValueMember = "ItemID"
        '
        'txt_Qty2
        '
        Me.txt_Qty2.Location = New System.Drawing.Point(168, 195)
        Me.txt_Qty2.Name = "txt_Qty2"
        Me.txt_Qty2.Size = New System.Drawing.Size(91, 21)
        Me.txt_Qty2.TabIndex = 12
        Me.txt_Qty2.Text = "UltraTextEditor17"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(127, 198)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 14)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Qty 2"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CompanyID
        '
        Me.cmb_CompanyID.Location = New System.Drawing.Point(168, 224)
        Me.cmb_CompanyID.Name = "cmb_CompanyID"
        Me.cmb_CompanyID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_CompanyID.TabIndex = 15
        Me.cmb_CompanyID.Text = "UltraCombo4"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(108, 228)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 14)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Company"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_OrderDate
        '
        Me.dt_OrderDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_OrderDate.Location = New System.Drawing.Point(168, 78)
        Me.dt_OrderDate.Name = "dt_OrderDate"
        Me.dt_OrderDate.NullText = "Not Defined"
        Me.dt_OrderDate.Size = New System.Drawing.Size(200, 21)
        Me.dt_OrderDate.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(106, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 14)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Item Code"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblDate.Location = New System.Drawing.Point(100, 81)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(60, 14)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Order Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(106, 52)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(54, 14)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Order No."
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboUnit
        '
        Appearance2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboUnit.Appearance = Appearance2
        Me.ComboUnit.DataMember = "Items"
        Me.ComboUnit.DisplayMember = "UnitName"
        Me.ComboUnit.Location = New System.Drawing.Point(265, 167)
        Me.ComboUnit.MaxDropDownItems = 15
        Me.ComboUnit.Name = "ComboUnit"
        Me.ComboUnit.ReadOnly = True
        Me.ComboUnit.Size = New System.Drawing.Size(103, 22)
        Me.ComboUnit.TabIndex = 10
        Me.ComboUnit.Text = "UltraCombo3"
        Me.ComboUnit.ValueMember = "ItemID"
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(168, 167)
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(91, 21)
        Me.txt_Qty.TabIndex = 9
        Me.txt_Qty.Text = "UltraTextEditor17"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(136, 170)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 14)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Qty"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_OrderNum
        '
        Me.txt_OrderNum.Location = New System.Drawing.Point(168, 49)
        Me.txt_OrderNum.Name = "txt_OrderNum"
        Me.txt_OrderNum.Size = New System.Drawing.Size(200, 21)
        Me.txt_OrderNum.TabIndex = 1
        Me.txt_OrderNum.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(104, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Item Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ItemID
        '
        Me.cmb_ItemID.DataMember = "Items"
        Me.cmb_ItemID.DisplayMember = "ItemCode"
        Me.cmb_ItemID.LimitToList = True
        Me.cmb_ItemID.Location = New System.Drawing.Point(168, 107)
        Me.cmb_ItemID.MaxDropDownItems = 15
        Me.cmb_ItemID.Name = "cmb_ItemID"
        Me.cmb_ItemID.Size = New System.Drawing.Size(200, 22)
        Me.cmb_ItemID.TabIndex = 5
        Me.cmb_ItemID.Text = "UltraCombo2"
        Me.cmb_ItemID.ValueMember = "ItemID"
        '
        'CmbItemName
        '
        Me.CmbItemName.DataMember = "Items"
        Me.CmbItemName.DisplayMember = "ItemName"
        Me.CmbItemName.LimitToList = True
        Me.CmbItemName.Location = New System.Drawing.Point(168, 137)
        Me.CmbItemName.MaxDropDownItems = 15
        Me.CmbItemName.Name = "CmbItemName"
        Me.CmbItemName.Size = New System.Drawing.Size(476, 22)
        Me.CmbItemName.TabIndex = 7
        Me.CmbItemName.Text = "UltraCombo1"
        Me.CmbItemName.ValueMember = "ItemID"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(851, 431)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.AddRemove1)
        Me.UltraTabPageControl3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(851, 431)
        '
        'AddRemove1
        '
        Me.AddRemove1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddRemove1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemove1.Location = New System.Drawing.Point(0, 0)
        Me.AddRemove1.Mode = 1
        Me.AddRemove1.Name = "AddRemove1"
        Me.AddRemove1.Size = New System.Drawing.Size(851, 431)
        Me.AddRemove1.TabIndex = 0
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(851, 431)
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.UltraGridTF)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(851, 431)
        Me.Panel6.TabIndex = 8
        '
        'UltraGridTF
        '
        Me.UltraGridTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTF.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTF.Name = "UltraGridTF"
        Me.UltraGridTF.Size = New System.Drawing.Size(851, 401)
        Me.UltraGridTF.TabIndex = 0
        Me.UltraGridTF.Text = "Product Serials"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnEditTF)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 401)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(851, 30)
        Me.Panel7.TabIndex = 1
        '
        'btnEditTF
        '
        Me.btnEditTF.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditTF.Location = New System.Drawing.Point(779, 0)
        Me.btnEditTF.Name = "btnEditTF"
        Me.btnEditTF.Size = New System.Drawing.Size(72, 30)
        Me.btnEditTF.TabIndex = 0
        Me.btnEditTF.Text = "Edit"
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.Panel8)
        Me.UltraTabPageControl14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(851, 431)
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel14)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(851, 431)
        Me.Panel8.TabIndex = 8
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.UltraGridTT)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(851, 431)
        Me.Panel14.TabIndex = 1
        '
        'UltraGridTT
        '
        Me.UltraGridTT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTT.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTT.Name = "UltraGridTT"
        Me.UltraGridTT.Size = New System.Drawing.Size(851, 401)
        Me.UltraGridTT.TabIndex = 0
        Me.UltraGridTT.Text = "Type Tests"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.btnDelTT)
        Me.Panel16.Controls.Add(Me.btnAddTT)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(0, 401)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(851, 30)
        Me.Panel16.TabIndex = 1
        Me.Panel16.Visible = False
        '
        'btnDelTT
        '
        Me.btnDelTT.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelTT.Location = New System.Drawing.Point(709, 0)
        Me.btnDelTT.Name = "btnDelTT"
        Me.btnDelTT.Size = New System.Drawing.Size(70, 30)
        Me.btnDelTT.TabIndex = 0
        Me.btnDelTT.Text = "Delete"
        '
        'btnAddTT
        '
        Me.btnAddTT.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddTT.Location = New System.Drawing.Point(779, 0)
        Me.btnAddTT.Name = "btnAddTT"
        Me.btnAddTT.Size = New System.Drawing.Size(72, 30)
        Me.btnAddTT.TabIndex = 1
        Me.btnAddTT.Text = "Add New"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnSave
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(591, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 45)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(679, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(767, 0)
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
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(851, 431)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl13)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl14)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance6.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance6
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(855, 457)
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
        UltraTab14.Key = "TF"
        UltraTab14.TabPage = Me.UltraTabPageControl13
        UltraTab14.Text = "Serial Nos."
        UltraTab15.Key = "typetests"
        UltraTab15.TabPage = Me.UltraTabPageControl14
        UltraTab15.Text = "Type Tests"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab7, UltraTab8, UltraTab9, UltraTab14, UltraTab15})
        '
        'cmb_MatDepID
        '
        Me.cmb_MatDepID.Location = New System.Drawing.Point(168, 280)
        Me.cmb_MatDepID.Name = "cmb_MatDepID"
        Me.cmb_MatDepID.Size = New System.Drawing.Size(472, 22)
        Me.cmb_MatDepID.TabIndex = 31
        Me.cmb_MatDepID.Text = "UltraCombo4"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(48, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Handled by Unit"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmIO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Internal Order"
        Me.ClientSize = New System.Drawing.Size(855, 502)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmIO"
        Me.Text = "Internal Order"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.cmb_DivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OrderNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ItemID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbItemName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl13.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.UltraGridTF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl14.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        CType(Me.UltraGridTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.cmb_MatDepID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_CompanyID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ComboUnit2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_Qty2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmb_DivisionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents cmb_MatDepID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As Windows.Forms.Label

#End Region
End Class

