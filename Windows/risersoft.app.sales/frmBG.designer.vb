Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmBG
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitForm()
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_PeriodType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmb_BGTypeid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_BGMode As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_PerValue As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PeriodNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_PeriodNum2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_PeriodType2 As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_perValue2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_BGNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_BGDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_BGValue As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_ClaimPeriod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_ValidUpto As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_ReleaseDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PanelTF As System.Windows.Forms.Panel
    Friend WithEvents lblTF As System.Windows.Forms.Label
    Friend WithEvents cmb_ProdSerialID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblStart2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_BGTypeid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_BGMode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_PeriodNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_PeriodType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txt_PerValue = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_PeriodNum2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_PeriodType2 = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblStart2 = New System.Windows.Forms.Label()
        Me.txt_perValue2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_BGNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_BGDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_BGValue = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ClaimPeriod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_ValidUpto = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_ReleaseDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.PanelTF = New System.Windows.Forms.Panel()
        Me.lblTF = New System.Windows.Forms.Label()
        Me.cmb_ProdSerialID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_BGTypeid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_BGMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_PeriodNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PeriodType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PerValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_PeriodNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PeriodType2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_perValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BGNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_BGDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BGValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ClaimPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ValidUpto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ReleaseDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelTF.SuspendLayout()
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(32, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "BG Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_BGTypeid
        '
        Me.cmb_BGTypeid.Location = New System.Drawing.Point(96, 8)
        Me.cmb_BGTypeid.Name = "cmb_BGTypeid"
        Me.cmb_BGTypeid.Size = New System.Drawing.Size(160, 22)
        Me.cmb_BGTypeid.TabIndex = 1
        Me.cmb_BGTypeid.Text = "UltraCombo3"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BG Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(96, 32)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(256, 22)
        Me.cmb_StatusNum.TabIndex = 3
        Me.cmb_StatusNum.Text = "UltraCombo3"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(24, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 24)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "BG Mode"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_BGMode
        '
        Me.cmb_BGMode.Location = New System.Drawing.Point(96, 56)
        Me.cmb_BGMode.Name = "cmb_BGMode"
        Me.cmb_BGMode.Size = New System.Drawing.Size(144, 21)
        Me.cmb_BGMode.TabIndex = 5
        Me.cmb_BGMode.Text = "Try"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_PeriodNum)
        Me.GroupBox1.Controls.Add(Me.cmb_PeriodType)
        Me.GroupBox1.Controls.Add(Me.lblStart)
        Me.GroupBox1.Controls.Add(Me.txt_PerValue)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 70)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clause 1"
        '
        'txt_PeriodNum
        '
        Me.txt_PeriodNum.Location = New System.Drawing.Point(120, 16)
        Me.txt_PeriodNum.Name = "txt_PeriodNum"
        Me.txt_PeriodNum.Size = New System.Drawing.Size(56, 21)
        Me.txt_PeriodNum.TabIndex = 2
        Me.txt_PeriodNum.Text = "UltraTextEditor1"
        '
        'cmb_PeriodType
        '
        Me.cmb_PeriodType.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_PeriodType.Location = New System.Drawing.Point(184, 16)
        Me.cmb_PeriodType.Name = "cmb_PeriodType"
        Me.cmb_PeriodType.Size = New System.Drawing.Size(104, 21)
        Me.cmb_PeriodType.TabIndex = 3
        '
        'lblStart
        '
        Me.lblStart.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblStart.Location = New System.Drawing.Point(8, 48)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(272, 16)
        Me.lblStart.TabIndex = 4
        Me.lblStart.Text = "From"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_PerValue
        '
        Me.txt_PerValue.Location = New System.Drawing.Point(8, 16)
        Me.txt_PerValue.Name = "txt_PerValue"
        Me.txt_PerValue.Size = New System.Drawing.Size(56, 21)
        Me.txt_PerValue.TabIndex = 0
        Me.txt_PerValue.Text = "UltraTextEditor1"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(72, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "% till "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_PeriodNum2)
        Me.GroupBox2.Controls.Add(Me.cmb_PeriodType2)
        Me.GroupBox2.Controls.Add(Me.lblStart2)
        Me.GroupBox2.Controls.Add(Me.txt_perValue2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 70)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clause 2"
        '
        'txt_PeriodNum2
        '
        Me.txt_PeriodNum2.Location = New System.Drawing.Point(120, 16)
        Me.txt_PeriodNum2.Name = "txt_PeriodNum2"
        Me.txt_PeriodNum2.Size = New System.Drawing.Size(56, 21)
        Me.txt_PeriodNum2.TabIndex = 2
        Me.txt_PeriodNum2.Text = "UltraTextEditor1"
        '
        'cmb_PeriodType2
        '
        Me.cmb_PeriodType2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_PeriodType2.Location = New System.Drawing.Point(184, 16)
        Me.cmb_PeriodType2.Name = "cmb_PeriodType2"
        Me.cmb_PeriodType2.Size = New System.Drawing.Size(104, 21)
        Me.cmb_PeriodType2.TabIndex = 3
        '
        'lblStart2
        '
        Me.lblStart2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblStart2.Location = New System.Drawing.Point(8, 48)
        Me.lblStart2.Name = "lblStart2"
        Me.lblStart2.Size = New System.Drawing.Size(272, 16)
        Me.lblStart2.TabIndex = 4
        Me.lblStart2.Text = "From"
        Me.lblStart2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_perValue2
        '
        Me.txt_perValue2.Location = New System.Drawing.Point(8, 16)
        Me.txt_perValue2.Name = "txt_perValue2"
        Me.txt_perValue2.Size = New System.Drawing.Size(56, 21)
        Me.txt_perValue2.TabIndex = 0
        Me.txt_perValue2.Text = "UltraTextEditor1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(72, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "% till "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(16, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "BG No."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_BGNum
        '
        Me.txt_BGNum.AcceptsReturn = True
        Me.txt_BGNum.Location = New System.Drawing.Point(80, 252)
        Me.txt_BGNum.Multiline = True
        Me.txt_BGNum.Name = "txt_BGNum"
        Me.txt_BGNum.Size = New System.Drawing.Size(272, 24)
        Me.txt_BGNum.TabIndex = 10
        Me.txt_BGNum.Text = "UltraTextEditor3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(24, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "BG Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_BGDate
        '
        Me.dt_BGDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_BGDate.Location = New System.Drawing.Point(80, 284)
        Me.dt_BGDate.Name = "dt_BGDate"
        Me.dt_BGDate.NullText = "Not Defined"
        Me.dt_BGDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_BGDate.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(16, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "BG Value"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_BGValue
        '
        Me.txt_BGValue.AcceptsReturn = True
        Me.txt_BGValue.Location = New System.Drawing.Point(80, 316)
        Me.txt_BGValue.Multiline = True
        Me.txt_BGValue.Name = "txt_BGValue"
        Me.txt_BGValue.Size = New System.Drawing.Size(272, 24)
        Me.txt_BGValue.TabIndex = 14
        Me.txt_BGValue.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(16, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Claim Period"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ClaimPeriod
        '
        Me.txt_ClaimPeriod.AcceptsReturn = True
        Me.txt_ClaimPeriod.Location = New System.Drawing.Point(80, 348)
        Me.txt_ClaimPeriod.Multiline = True
        Me.txt_ClaimPeriod.Name = "txt_ClaimPeriod"
        Me.txt_ClaimPeriod.Size = New System.Drawing.Size(272, 24)
        Me.txt_ClaimPeriod.TabIndex = 16
        Me.txt_ClaimPeriod.Text = "UltraTextEditor3"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(24, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Valid Upto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ValidUpto
        '
        Me.dt_ValidUpto.FormatString = "dddd dd MMM yyyy"
        Me.dt_ValidUpto.Location = New System.Drawing.Point(80, 380)
        Me.dt_ValidUpto.Name = "dt_ValidUpto"
        Me.dt_ValidUpto.NullText = "Not Defined"
        Me.dt_ValidUpto.Size = New System.Drawing.Size(168, 21)
        Me.dt_ValidUpto.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(0, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Released On"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ReleaseDate
        '
        Me.dt_ReleaseDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ReleaseDate.Location = New System.Drawing.Point(80, 412)
        Me.dt_ReleaseDate.Name = "dt_ReleaseDate"
        Me.dt_ReleaseDate.NullText = "Not Defined"
        Me.dt_ReleaseDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_ReleaseDate.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 515)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(368, 35)
        Me.Panel4.TabIndex = 23
        '
        'btnCancel
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(192, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 35)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(280, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 35)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'PanelTF
        '
        Me.PanelTF.Controls.Add(Me.lblTF)
        Me.PanelTF.Controls.Add(Me.cmb_ProdSerialID)
        Me.PanelTF.Location = New System.Drawing.Point(8, 80)
        Me.PanelTF.Name = "PanelTF"
        Me.PanelTF.Size = New System.Drawing.Size(360, 32)
        Me.PanelTF.TabIndex = 6
        '
        'lblTF
        '
        Me.lblTF.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblTF.Location = New System.Drawing.Point(0, 8)
        Me.lblTF.Name = "lblTF"
        Me.lblTF.Size = New System.Drawing.Size(80, 16)
        Me.lblTF.TabIndex = 0
        Me.lblTF.Text = "Serial No."
        Me.lblTF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ProdSerialID
        '
        Me.cmb_ProdSerialID.Location = New System.Drawing.Point(88, 8)
        Me.cmb_ProdSerialID.Name = "cmb_ProdSerialID"
        Me.cmb_ProdSerialID.Size = New System.Drawing.Size(256, 22)
        Me.cmb_ProdSerialID.TabIndex = 1
        Me.cmb_ProdSerialID.Text = "UltraCombo3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 40)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Remark"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(80, 440)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(272, 48)
        Me.txt_Remark.TabIndex = 22
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'frmBG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Bank Guarantee"
        Me.ClientSize = New System.Drawing.Size(368, 550)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelTF)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dt_ReleaseDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dt_ValidUpto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_ClaimPeriod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_BGValue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_BGDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_BGNum)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmb_BGMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_StatusNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_BGTypeid)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBG"
        Me.Text = "Bank Guarantee"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_BGTypeid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_BGMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_PeriodNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PeriodType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PerValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_PeriodNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PeriodType2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_perValue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BGNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_BGDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BGValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ClaimPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ValidUpto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ReleaseDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.PanelTF.ResumeLayout(False)
        Me.PanelTF.PerformLayout()
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
End Class

