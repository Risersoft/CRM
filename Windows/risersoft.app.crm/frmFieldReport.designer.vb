<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmFieldReport
    Inherits frmMax

#Region " Windows Form Designer generated code "
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_AttendedByID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_DefectDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents CtlUpLoad1 As ctlUpLoad
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_InstDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.dt_SupplyDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ReportNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_ReportDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_AttendDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Place = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_ProdSerialID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblPS = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_AttendedByID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_DefectDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.CtlUpLoad1 = New risersoft.[shared].win.ctlUpLoad()
        Me.UEGB_ItemList = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UEGB_ItemDetail = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGridItemList = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dt_InstDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_SupplyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ReportNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_AttendDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Place, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_AttendedByID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DefectDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_ItemList.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UEGB_ItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_ItemDetail.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.UltraGridItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 484)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(848, 30)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(584, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(672, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 30)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(760, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel8)
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.dt_InstDate)
        Me.Panel1.Controls.Add(Me.dt_SupplyDate)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.txt_ReportNum)
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.dt_ReportDate)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.dt_AttendDate)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.txt_Place)
        Me.Panel1.Controls.Add(Me.cmb_ProdSerialID)
        Me.Panel1.Controls.Add(Me.lblPS)
        Me.Panel1.Controls.Add(Me.cmb_AttendedByID)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.dt_DefectDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 95)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel8
        '
        Me.UltraLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance4
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(642, 40)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel8.TabIndex = 17
        Me.UltraLabel8.Text = "Inst Date"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance5
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(409, 40)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel7.TabIndex = 16
        Me.UltraLabel7.Text = "Supply Date"
        '
        'dt_InstDate
        '
        Me.dt_InstDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_InstDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_InstDate.Location = New System.Drawing.Point(696, 37)
        Me.dt_InstDate.Name = "dt_InstDate"
        Me.dt_InstDate.NullText = "Not Defined"
        Me.dt_InstDate.Size = New System.Drawing.Size(144, 21)
        Me.dt_InstDate.TabIndex = 15
        '
        'dt_SupplyDate
        '
        Me.dt_SupplyDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_SupplyDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_SupplyDate.Location = New System.Drawing.Point(476, 37)
        Me.dt_SupplyDate.Name = "dt_SupplyDate"
        Me.dt_SupplyDate.NullText = "Not Defined"
        Me.dt_SupplyDate.Size = New System.Drawing.Size(144, 21)
        Me.dt_SupplyDate.TabIndex = 14
        '
        'UltraLabel5
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance6
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(219, 11)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(59, 14)
        Me.UltraLabel5.TabIndex = 13
        Me.UltraLabel5.Text = "Report No."
        '
        'txt_ReportNum
        '
        Me.txt_ReportNum.Location = New System.Drawing.Point(281, 8)
        Me.txt_ReportNum.Name = "txt_ReportNum"
        Me.txt_ReportNum.Size = New System.Drawing.Size(118, 21)
        Me.txt_ReportNum.TabIndex = 12
        '
        'UltraLabel4
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance7
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(9, 11)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel4.TabIndex = 11
        Me.UltraLabel4.Text = "Report Date"
        '
        'dt_ReportDate
        '
        Me.dt_ReportDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_ReportDate.Location = New System.Drawing.Point(77, 8)
        Me.dt_ReportDate.Name = "dt_ReportDate"
        Me.dt_ReportDate.NullText = "Not Defined"
        Me.dt_ReportDate.Size = New System.Drawing.Size(138, 21)
        Me.dt_ReportDate.TabIndex = 10
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance8
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(627, 11)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "Attend Date"
        '
        'dt_AttendDate
        '
        Me.dt_AttendDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_AttendDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_AttendDate.Location = New System.Drawing.Point(696, 8)
        Me.dt_AttendDate.Name = "dt_AttendDate"
        Me.dt_AttendDate.NullText = "Not Defined"
        Me.dt_AttendDate.Size = New System.Drawing.Size(144, 21)
        Me.dt_AttendDate.TabIndex = 5
        '
        'UltraLabel6
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance9
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(440, 69)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel6.TabIndex = 8
        Me.UltraLabel6.Text = "Place"
        '
        'txt_Place
        '
        Me.txt_Place.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Place.Location = New System.Drawing.Point(476, 66)
        Me.txt_Place.Name = "txt_Place"
        Me.txt_Place.Size = New System.Drawing.Size(364, 21)
        Me.txt_Place.TabIndex = 9
        '
        'cmb_ProdSerialID
        '
        Me.cmb_ProdSerialID.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_ProdSerialID.Location = New System.Drawing.Point(77, 36)
        Me.cmb_ProdSerialID.Name = "cmb_ProdSerialID"
        Me.cmb_ProdSerialID.Size = New System.Drawing.Size(322, 22)
        Me.cmb_ProdSerialID.TabIndex = 1
        '
        'lblPS
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.lblPS.Appearance = Appearance10
        Me.lblPS.AutoSize = True
        Me.lblPS.Location = New System.Drawing.Point(18, 40)
        Me.lblPS.Name = "lblPS"
        Me.lblPS.Size = New System.Drawing.Size(54, 14)
        Me.lblPS.TabIndex = 0
        Me.lblPS.Text = "Serial No."
        '
        'cmb_AttendedByID
        '
        Me.cmb_AttendedByID.Location = New System.Drawing.Point(77, 65)
        Me.cmb_AttendedByID.Name = "cmb_AttendedByID"
        Me.cmb_AttendedByID.Size = New System.Drawing.Size(322, 22)
        Me.cmb_AttendedByID.TabIndex = 7
        '
        'UltraLabel1
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 69)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Attend User"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance12
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(409, 11)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Defect Date"
        '
        'dt_DefectDate
        '
        Me.dt_DefectDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_DefectDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_DefectDate.Location = New System.Drawing.Point(476, 8)
        Me.dt_DefectDate.Name = "dt_DefectDate"
        Me.dt_DefectDate.NullText = "Not Defined"
        Me.dt_DefectDate.Size = New System.Drawing.Size(144, 21)
        Me.dt_DefectDate.TabIndex = 3
        '
        'CtlUpLoad1
        '
        Me.CtlUpLoad1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CtlUpLoad1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlUpLoad1.Location = New System.Drawing.Point(0, 450)
        Me.CtlUpLoad1.Name = "CtlUpLoad1"
        Me.CtlUpLoad1.Size = New System.Drawing.Size(848, 34)
        Me.CtlUpLoad1.TabIndex = 2
        '
        'UEGB_ItemList
        '
        Me.UEGB_ItemList.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UEGB_ItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UEGB_ItemList.ExpandedSize = New System.Drawing.Size(848, 355)
        Me.UEGB_ItemList.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UEGB_ItemList.HeaderClickAction = Infragistics.Win.Misc.GroupBoxHeaderClickAction.None
        Me.UEGB_ItemList.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UEGB_ItemList.Location = New System.Drawing.Point(0, 95)
        Me.UEGB_ItemList.Name = "UEGB_ItemList"
        Me.UEGB_ItemList.Size = New System.Drawing.Size(848, 355)
        Me.UEGB_ItemList.TabIndex = 1
        Me.UEGB_ItemList.Text = "Item List"
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraPanel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UEGB_ItemDetail)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(842, 336)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UEGB_ItemDetail
        '
        Me.UEGB_ItemDetail.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UEGB_ItemDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UEGB_ItemDetail.ExpandedSize = New System.Drawing.Size(842, 171)
        Me.UEGB_ItemDetail.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UEGB_ItemDetail.HeaderClickAction = Infragistics.Win.Misc.GroupBoxHeaderClickAction.None
        Me.UEGB_ItemDetail.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UEGB_ItemDetail.Location = New System.Drawing.Point(0, 165)
        Me.UEGB_ItemDetail.Name = "UEGB_ItemDetail"
        Me.UEGB_ItemDetail.Size = New System.Drawing.Size(842, 171)
        Me.UEGB_ItemDetail.TabIndex = 0
        Me.UEGB_ItemDetail.Text = "Item Details"
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(836, 152)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraGridItemList)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.UltraPanel1)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(842, 165)
        Me.UltraPanel2.TabIndex = 55
        '
        'UltraGridItemList
        '
        Me.UltraGridItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridItemList.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridItemList.Name = "UltraGridItemList"
        Me.UltraGridItemList.Size = New System.Drawing.Size(842, 140)
        Me.UltraGridItemList.TabIndex = 0
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnDel)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnAdd)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 140)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(842, 25)
        Me.UltraPanel1.TabIndex = 52
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDel.Location = New System.Drawing.Point(70, 0)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 25)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 25)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add New"
        '
        'frmFieldReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Field Report"
        Me.ClientSize = New System.Drawing.Size(848, 514)
        Me.Controls.Add(Me.UEGB_ItemList)
        Me.Controls.Add(Me.CtlUpLoad1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmFieldReport"
        Me.Text = "Field Report"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dt_InstDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_SupplyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ReportNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_AttendDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Place, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_AttendedByID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DefectDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_ItemList.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UEGB_ItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_ItemDetail.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.UltraGridItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_ProdSerialID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblPS As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UEGB_ItemList As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UEGB_ItemDetail As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGridItemList As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Place As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_AttendDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_ReportDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ReportNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_InstDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_SupplyDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor

#End Region
End Class

