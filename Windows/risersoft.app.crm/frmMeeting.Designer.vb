Imports risersoft.app.mxent
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMeeting
    Inherits frmMax

#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        Me.InitForm()
    End Sub

    ' Form overrides dispose to clean up the component list.
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_IsReminder = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_ReminderTime = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_SMSReminderTime = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_EmailReminderTime = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.checkedListBoxWeeklyDays = New System.Windows.Forms.CheckedListBox()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_RepeatUntil = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmb_RepeatType = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_RepeatCount = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_RepeatInterval = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGridEmpSalary = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGridEmpSalBen = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraPanel4 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Description = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_DurationMinutes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_DurationHours = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_AllDayEvent = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.dt_sdate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Location = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_Status = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txt_Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_PIDField = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_PIDValue = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UEGB_Assign = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGridTeam = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_AssignTeamID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnClearTeam = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnAssignTeam = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPanel6 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnAddTeam = New Infragistics.Win.Misc.UltraButton()
        Me.btnDeleteTeam = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_AssignUserID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnAssignUser = New Infragistics.Win.Misc.UltraButton()
        Me.btnClearUser = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPanel5 = New Infragistics.Win.Misc.UltraPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnEditLicense = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddLicense = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridLicense = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnDelPartner = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPartner = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridPartner = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel8 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDelGroup = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddGroup = New Infragistics.Win.Misc.UltraButton()
        Me.UltraPanel7 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDelUser = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddUser = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGridUser = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnGenerate = New Infragistics.Win.Misc.UltraButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_DataBaseName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ServerName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_AdminDbPwd = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_SAConnectionstring = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_AdminDbUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_StorageAccount = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGridDatabase = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnDeleteMeeting = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.chk_IsReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ReminderTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_SMSReminderTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EmailReminderTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.dt_RepeatUntil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RepeatType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RepeatCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RepeatInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraGridEmpSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraGridEmpSalBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.UltraPanel4.ClientArea.SuspendLayout()
        Me.UltraPanel4.SuspendLayout()
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DurationMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DurationHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_AllDayEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_sdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PIDField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PIDValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_Assign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_Assign.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.UltraGridTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_AssignTeamID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel6.ClientArea.SuspendLayout()
        Me.UltraPanel6.SuspendLayout()
        CType(Me.cmb_AssignUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel5.SuspendLayout()
        CType(Me.UltraGridLicense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridPartner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel8.SuspendLayout()
        Me.UltraPanel7.SuspendLayout()
        CType(Me.UltraGridGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DataBaseName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AdminDbPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SAConnectionstring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AdminDbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StorageAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.chk_IsReminder)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_ReminderTime)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel23)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_SMSReminderTime)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel24)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_EmailReminderTime)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(400, 151)
        '
        'chk_IsReminder
        '
        Me.chk_IsReminder.Location = New System.Drawing.Point(124, 27)
        Me.chk_IsReminder.Name = "chk_IsReminder"
        Me.chk_IsReminder.Size = New System.Drawing.Size(17, 24)
        Me.chk_IsReminder.TabIndex = 268
        '
        'UltraLabel5
        '
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance1
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(65, 32)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel5.TabIndex = 267
        Me.UltraLabel5.Text = "Reminder"
        '
        'cmb_ReminderTime
        '
        Me.cmb_ReminderTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ValueListItem9.DataValue = False
        ValueListItem9.DisplayText = "Salary"
        ValueListItem10.DataValue = True
        ValueListItem10.DisplayText = "Wage"
        Me.cmb_ReminderTime.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem9, ValueListItem10})
        Me.cmb_ReminderTime.Location = New System.Drawing.Point(145, 29)
        Me.cmb_ReminderTime.Name = "cmb_ReminderTime"
        Me.cmb_ReminderTime.Size = New System.Drawing.Size(122, 21)
        Me.cmb_ReminderTime.TabIndex = 266
        Me.cmb_ReminderTime.Text = "UltraComboEditor9"
        '
        'UltraLabel23
        '
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.TextHAlignAsString = "Right"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance2
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(30, 85)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(109, 14)
        Me.UltraLabel23.TabIndex = 241
        Me.UltraLabel23.Text = "SMS Reminder Time"
        '
        'cmb_SMSReminderTime
        '
        Me.cmb_SMSReminderTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ValueListItem1.DataValue = False
        ValueListItem1.DisplayText = "Salary"
        ValueListItem2.DataValue = True
        ValueListItem2.DisplayText = "Wage"
        Me.cmb_SMSReminderTime.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.cmb_SMSReminderTime.Location = New System.Drawing.Point(144, 83)
        Me.cmb_SMSReminderTime.Name = "cmb_SMSReminderTime"
        Me.cmb_SMSReminderTime.Size = New System.Drawing.Size(142, 21)
        Me.cmb_SMSReminderTime.TabIndex = 240
        Me.cmb_SMSReminderTime.Text = "UltraComboEditor9"
        '
        'UltraLabel24
        '
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.TextHAlignAsString = "Right"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance3
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(27, 58)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(113, 14)
        Me.UltraLabel24.TabIndex = 239
        Me.UltraLabel24.Text = "Email Reminder Time"
        '
        'cmb_EmailReminderTime
        '
        Me.cmb_EmailReminderTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ValueListItem11.DataValue = False
        ValueListItem11.DisplayText = "Salary"
        ValueListItem12.DataValue = True
        ValueListItem12.DisplayText = "Wage"
        Me.cmb_EmailReminderTime.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem11, ValueListItem12})
        Me.cmb_EmailReminderTime.Location = New System.Drawing.Point(144, 56)
        Me.cmb_EmailReminderTime.Name = "cmb_EmailReminderTime"
        Me.cmb_EmailReminderTime.Size = New System.Drawing.Size(142, 21)
        Me.cmb_EmailReminderTime.TabIndex = 238
        Me.cmb_EmailReminderTime.Text = "UltraComboEditor9"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.checkedListBoxWeeklyDays)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel22)
        Me.UltraTabPageControl4.Controls.Add(Me.dt_RepeatUntil)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_RepeatType)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel11)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel12)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel20)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel21)
        Me.UltraTabPageControl4.Controls.Add(Me.Label1)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_RepeatCount)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_RepeatInterval)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(400, 151)
        '
        'checkedListBoxWeeklyDays
        '
        Me.checkedListBoxWeeklyDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkedListBoxWeeklyDays.FormattingEnabled = True
        Me.checkedListBoxWeeklyDays.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.checkedListBoxWeeklyDays.Location = New System.Drawing.Point(285, 31)
        Me.checkedListBoxWeeklyDays.Name = "checkedListBoxWeeklyDays"
        Me.checkedListBoxWeeklyDays.Size = New System.Drawing.Size(104, 109)
        Me.checkedListBoxWeeklyDays.TabIndex = 241
        '
        'UltraLabel22
        '
        Me.UltraLabel22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.TextHAlignAsString = "Right"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance4
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(288, 11)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(94, 14)
        Me.UltraLabel22.TabIndex = 240
        Me.UltraLabel22.Text = "Days of the Week"
        '
        'dt_RepeatUntil
        '
        Me.dt_RepeatUntil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.dt_RepeatUntil.Appearance = Appearance5
        Me.dt_RepeatUntil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_RepeatUntil.FormatString = "dddd dd MMM yyyy"
        Me.dt_RepeatUntil.Location = New System.Drawing.Point(78, 46)
        Me.dt_RepeatUntil.Name = "dt_RepeatUntil"
        Me.dt_RepeatUntil.NullText = "Not Defined"
        Me.dt_RepeatUntil.Size = New System.Drawing.Size(144, 21)
        Me.dt_RepeatUntil.TabIndex = 153
        '
        'cmb_RepeatType
        '
        Me.cmb_RepeatType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ValueListItem3.DataValue = False
        ValueListItem3.DisplayText = "Salary"
        ValueListItem4.DataValue = True
        ValueListItem4.DisplayText = "Wage"
        Me.cmb_RepeatType.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.cmb_RepeatType.Location = New System.Drawing.Point(78, 20)
        Me.cmb_RepeatType.Name = "cmb_RepeatType"
        Me.cmb_RepeatType.Size = New System.Drawing.Size(143, 21)
        Me.cmb_RepeatType.TabIndex = 152
        Me.cmb_RepeatType.Text = "UltraComboEditor9"
        '
        'UltraLabel11
        '
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.TextHAlignAsString = "Right"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance6
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(5, 49)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel11.TabIndex = 150
        Me.UltraLabel11.Text = "Repeat Until"
        '
        'UltraLabel12
        '
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.TextHAlignAsString = "Right"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance7
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(21, 96)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel12.TabIndex = 149
        Me.UltraLabel12.Text = "End After"
        '
        'UltraLabel20
        '
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.TextHAlignAsString = "Right"
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance8
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(30, 74)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel20.TabIndex = 148
        Me.UltraLabel20.Text = "Interval"
        '
        'UltraLabel21
        '
        Appearance9.FontData.SizeInPoints = 8.25!
        Appearance9.TextHAlignAsString = "Right"
        Appearance9.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance9
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(4, 24)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel21.TabIndex = 147
        Me.UltraLabel21.Text = "Repeat Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "occurrences"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RepeatCount
        '
        Me.txt_RepeatCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance10.FontData.BoldAsString = "False"
        Me.txt_RepeatCount.Appearance = Appearance10
        Me.txt_RepeatCount.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_RepeatCount.Location = New System.Drawing.Point(78, 95)
        Me.txt_RepeatCount.Name = "txt_RepeatCount"
        Me.txt_RepeatCount.Size = New System.Drawing.Size(122, 17)
        Me.txt_RepeatCount.TabIndex = 145
        Me.txt_RepeatCount.Text = "UltraTextEditor2"
        '
        'txt_RepeatInterval
        '
        Me.txt_RepeatInterval.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.FontData.BoldAsString = "False"
        Me.txt_RepeatInterval.Appearance = Appearance11
        Me.txt_RepeatInterval.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_RepeatInterval.Location = New System.Drawing.Point(78, 73)
        Me.txt_RepeatInterval.Name = "txt_RepeatInterval"
        Me.txt_RepeatInterval.Size = New System.Drawing.Size(144, 17)
        Me.txt_RepeatInterval.TabIndex = 144
        Me.txt_RepeatInterval.Text = "UltraTextEditor2"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteMeeting)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 401)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 39)
        Me.Panel4.TabIndex = 5
        '
        'btnSave
        '
        Appearance13.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance13
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(547, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 39)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance14
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(635, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance15.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance15
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(723, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 39)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 356)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 326)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 30)
        Me.Panel3.TabIndex = 1
        '
        'UltraGridEmpSalary
        '
        Me.UltraGridEmpSalary.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridEmpSalary.Name = "UltraGridEmpSalary"
        Me.UltraGridEmpSalary.Size = New System.Drawing.Size(550, 80)
        Me.UltraGridEmpSalary.TabIndex = 0
        '
        'UltraPanel2
        '
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 325)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(744, 31)
        Me.UltraPanel2.TabIndex = 0
        '
        'UltraPanel1
        '
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(744, 325)
        Me.UltraPanel1.TabIndex = 0
        '
        'UltraGridEmpSalBen
        '
        Me.UltraGridEmpSalBen.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridEmpSalBen.Name = "UltraGridEmpSalBen"
        Me.UltraGridEmpSalBen.Size = New System.Drawing.Size(550, 80)
        Me.UltraGridEmpSalBen.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 401)
        Me.Panel1.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraTabControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraPanel4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UEGB_Assign)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 401)
        Me.SplitContainer1.SplitterDistance = 404
        Me.SplitContainer1.TabIndex = 35
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 224)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance16.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance16
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(404, 177)
        Me.UltraTabControl1.TabIndex = 151
        Me.UltraTabControl1.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.MultiRowAutoSize
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Reminder"
        UltraTab7.TabPage = Me.UltraTabPageControl4
        UltraTab7.Text = "Recurrence"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab7})
        Me.UltraTabControl1.TabsPerRow = 5
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(400, 151)
        '
        'UltraPanel4
        '
        '
        'UltraPanel4.ClientArea
        '
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel25)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.txt_Description)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel6)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel10)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.txt_DurationMinutes)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.txt_DurationHours)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.chk_AllDayEvent)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.dt_sdate)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel2)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.txt_Location)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel9)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel3)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.UltraLabel4)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.cmb_Status)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.txt_Name)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.cmb_PIDField)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.cmb_PIDValue)
        Me.UltraPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel4.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel4.Name = "UltraPanel4"
        Me.UltraPanel4.Size = New System.Drawing.Size(404, 224)
        Me.UltraPanel4.TabIndex = 150
        '
        'UltraLabel25
        '
        Appearance17.FontData.SizeInPoints = 8.25!
        Appearance17.TextHAlignAsString = "Right"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance17
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Location = New System.Drawing.Point(25, 170)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel25.TabIndex = 283
        Me.UltraLabel25.Text = "Description"
        '
        'txt_Description
        '
        Me.txt_Description.AcceptsReturn = True
        Me.txt_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Description.Location = New System.Drawing.Point(89, 169)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(295, 47)
        Me.txt_Description.TabIndex = 282
        Me.txt_Description.Text = "UltraTextEditor3"
        '
        'UltraLabel6
        '
        Appearance18.FontData.SizeInPoints = 8.25!
        Appearance18.TextHAlignAsString = "Right"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance18
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(221, 147)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel6.TabIndex = 281
        Me.UltraLabel6.Text = "(hours/minutes)"
        '
        'UltraLabel10
        '
        Appearance19.FontData.SizeInPoints = 8.25!
        Appearance19.TextHAlignAsString = "Right"
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance19
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(39, 146)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel10.TabIndex = 280
        Me.UltraLabel10.Text = "Duration"
        '
        'txt_DurationMinutes
        '
        Appearance20.FontData.BoldAsString = "False"
        Me.txt_DurationMinutes.Appearance = Appearance20
        Me.txt_DurationMinutes.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_DurationMinutes.Location = New System.Drawing.Point(145, 145)
        Me.txt_DurationMinutes.Name = "txt_DurationMinutes"
        Me.txt_DurationMinutes.Size = New System.Drawing.Size(73, 17)
        Me.txt_DurationMinutes.TabIndex = 279
        Me.txt_DurationMinutes.Text = "UltraTextEditor2"
        '
        'txt_DurationHours
        '
        Appearance21.FontData.BoldAsString = "False"
        Me.txt_DurationHours.Appearance = Appearance21
        Me.txt_DurationHours.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_DurationHours.Location = New System.Drawing.Point(89, 145)
        Me.txt_DurationHours.Name = "txt_DurationHours"
        Me.txt_DurationHours.Size = New System.Drawing.Size(53, 17)
        Me.txt_DurationHours.TabIndex = 278
        Me.txt_DurationHours.Text = "UltraTextEditor2"
        '
        'chk_AllDayEvent
        '
        Me.chk_AllDayEvent.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chk_AllDayEvent.Location = New System.Drawing.Point(308, 143)
        Me.chk_AllDayEvent.Name = "chk_AllDayEvent"
        Me.chk_AllDayEvent.Size = New System.Drawing.Size(60, 19)
        Me.chk_AllDayEvent.TabIndex = 277
        Me.chk_AllDayEvent.Text = "All Day"
        '
        'dt_sdate
        '
        Me.dt_sdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_sdate.FormatString = "dd MMM yyyy hh:mm"
        Me.dt_sdate.Location = New System.Drawing.Point(89, 118)
        Me.dt_sdate.MaskInput = "{LOC}dd/mm/yyyy hh:mm"
        Me.dt_sdate.Name = "dt_sdate"
        Me.dt_sdate.Size = New System.Drawing.Size(179, 21)
        Me.dt_sdate.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.dt_sdate.SpinWrap = True
        Me.dt_sdate.TabIndex = 276
        '
        'UltraLabel2
        '
        Appearance22.FontData.SizeInPoints = 8.25!
        Appearance22.TextHAlignAsString = "Right"
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance22
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(41, 65)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel2.TabIndex = 275
        Me.UltraLabel2.Text = "Location"
        '
        'txt_Location
        '
        Me.txt_Location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance23.FontData.BoldAsString = "False"
        Me.txt_Location.Appearance = Appearance23
        Me.txt_Location.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Location.Location = New System.Drawing.Point(91, 64)
        Me.txt_Location.Name = "txt_Location"
        Me.txt_Location.Size = New System.Drawing.Size(263, 17)
        Me.txt_Location.TabIndex = 274
        Me.txt_Location.Text = "UltraTextEditor2"
        '
        'UltraLabel9
        '
        Appearance24.FontData.SizeInPoints = 8.25!
        Appearance24.TextHAlignAsString = "Right"
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance24
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(51, 91)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel9.TabIndex = 273
        Me.UltraLabel9.Text = "Status"
        '
        'UltraLabel3
        '
        Appearance25.FontData.SizeInPoints = 8.25!
        Appearance25.TextHAlignAsString = "Right"
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance25
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(8, 120)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(78, 14)
        Me.UltraLabel3.TabIndex = 272
        Me.UltraLabel3.Text = "Date and Time"
        '
        'UltraLabel4
        '
        Appearance26.FontData.SizeInPoints = 8.25!
        Appearance26.TextHAlignAsString = "Right"
        Appearance26.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance26
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(46, 42)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 14)
        Me.UltraLabel4.TabIndex = 271
        Me.UltraLabel4.Text = "Subject"
        '
        'cmb_Status
        '
        Me.cmb_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ValueListItem15.DataValue = False
        ValueListItem15.DisplayText = "Salary"
        ValueListItem16.DataValue = True
        ValueListItem16.DisplayText = "Wage"
        Me.cmb_Status.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem15, ValueListItem16})
        Me.cmb_Status.Location = New System.Drawing.Point(90, 89)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(122, 21)
        Me.cmb_Status.TabIndex = 270
        Me.cmb_Status.Text = "UltraComboEditor9"
        '
        'txt_Name
        '
        Me.txt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance27.FontData.BoldAsString = "False"
        Me.txt_Name.Appearance = Appearance27
        Me.txt_Name.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Name.Location = New System.Drawing.Point(91, 41)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(263, 17)
        Me.txt_Name.TabIndex = 269
        Me.txt_Name.Text = "UltraTextEditor2"
        '
        'cmb_PIDField
        '
        ValueListItem13.DataValue = False
        ValueListItem13.DisplayText = "Salary"
        ValueListItem14.DataValue = True
        ValueListItem14.DisplayText = "Wage"
        Me.cmb_PIDField.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14})
        Me.cmb_PIDField.Location = New System.Drawing.Point(24, 12)
        Me.cmb_PIDField.Name = "cmb_PIDField"
        Me.cmb_PIDField.ReadOnly = True
        Me.cmb_PIDField.Size = New System.Drawing.Size(122, 21)
        Me.cmb_PIDField.TabIndex = 268
        Me.cmb_PIDField.UseAppStyling = False
        '
        'cmb_PIDValue
        '
        Me.cmb_PIDValue.DisplayMember = "IDInfo"
        Me.cmb_PIDValue.Location = New System.Drawing.Point(152, 12)
        Me.cmb_PIDValue.Name = "cmb_PIDValue"
        Me.cmb_PIDValue.ReadOnly = True
        Me.cmb_PIDValue.Size = New System.Drawing.Size(142, 22)
        Me.cmb_PIDValue.TabIndex = 267
        Me.cmb_PIDValue.ValueMember = "IDValue"
        '
        'UEGB_Assign
        '
        Me.UEGB_Assign.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UEGB_Assign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UEGB_Assign.ExpandedSize = New System.Drawing.Size(403, 401)
        Me.UEGB_Assign.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UEGB_Assign.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UEGB_Assign.Location = New System.Drawing.Point(0, 0)
        Me.UEGB_Assign.Name = "UEGB_Assign"
        Me.UEGB_Assign.Size = New System.Drawing.Size(403, 401)
        Me.UEGB_Assign.TabIndex = 233
        Me.UEGB_Assign.Text = "Assignment"
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel19)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel18)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cmb_AssignTeamID)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnClearTeam)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnAssignTeam)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel6)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.cmb_AssignUserID)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnAssignUser)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.btnClearUser)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel5)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(397, 382)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraPanel3
        '
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.UltraGridTeam)
        Me.UltraPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel3.Location = New System.Drawing.Point(0, 83)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(397, 272)
        Me.UltraPanel3.TabIndex = 237
        '
        'UltraGridTeam
        '
        Appearance28.BackColor = System.Drawing.SystemColors.Window
        Appearance28.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGridTeam.DisplayLayout.Appearance = Appearance28
        Me.UltraGridTeam.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGridTeam.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance29.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridTeam.DisplayLayout.GroupByBox.Appearance = Appearance29
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridTeam.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance30
        Me.UltraGridTeam.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance31.BackColor2 = System.Drawing.SystemColors.Control
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGridTeam.DisplayLayout.GroupByBox.PromptAppearance = Appearance31
        Me.UltraGridTeam.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGridTeam.DisplayLayout.MaxRowScrollRegions = 1
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGridTeam.DisplayLayout.Override.ActiveCellAppearance = Appearance32
        Appearance33.BackColor = System.Drawing.SystemColors.Highlight
        Appearance33.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGridTeam.DisplayLayout.Override.ActiveRowAppearance = Appearance33
        Me.UltraGridTeam.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGridTeam.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGridTeam.DisplayLayout.Override.CardAreaAppearance = Appearance34
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Appearance35.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGridTeam.DisplayLayout.Override.CellAppearance = Appearance35
        Me.UltraGridTeam.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGridTeam.DisplayLayout.Override.CellPadding = 0
        Appearance36.BackColor = System.Drawing.SystemColors.Control
        Appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGridTeam.DisplayLayout.Override.GroupByRowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Left"
        Me.UltraGridTeam.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.UltraGridTeam.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGridTeam.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.UltraGridTeam.DisplayLayout.Override.RowAppearance = Appearance38
        Me.UltraGridTeam.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGridTeam.DisplayLayout.Override.TemplateAddRowAppearance = Appearance39
        Me.UltraGridTeam.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGridTeam.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGridTeam.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGridTeam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTeam.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridTeam.Name = "UltraGridTeam"
        Me.UltraGridTeam.Size = New System.Drawing.Size(397, 272)
        Me.UltraGridTeam.TabIndex = 145
        Me.UltraGridTeam.Text = "UltraGrid1"
        '
        'UltraLabel19
        '
        Appearance40.FontData.SizeInPoints = 8.25!
        Appearance40.TextHAlignAsString = "Right"
        Appearance40.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance40
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(3, 38)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel19.TabIndex = 236
        Me.UltraLabel19.Text = "Team:"
        '
        'UltraLabel18
        '
        Appearance41.FontData.SizeInPoints = 8.25!
        Appearance41.TextHAlignAsString = "Right"
        Appearance41.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance41
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(3, 3)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel18.TabIndex = 235
        Me.UltraLabel18.Text = "User:"
        '
        'cmb_AssignTeamID
        '
        Me.cmb_AssignTeamID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_AssignTeamID.Location = New System.Drawing.Point(79, 53)
        Me.cmb_AssignTeamID.Name = "cmb_AssignTeamID"
        Me.cmb_AssignTeamID.ReadOnly = True
        Me.cmb_AssignTeamID.Size = New System.Drawing.Size(158, 22)
        Me.cmb_AssignTeamID.TabIndex = 232
        '
        'btnClearTeam
        '
        Me.btnClearTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearTeam.Location = New System.Drawing.Point(299, 53)
        Me.btnClearTeam.Name = "btnClearTeam"
        Me.btnClearTeam.Size = New System.Drawing.Size(58, 22)
        Me.btnClearTeam.TabIndex = 234
        Me.btnClearTeam.Text = "Clear"
        '
        'UltraLabel17
        '
        Appearance42.FontData.SizeInPoints = 8.25!
        Appearance42.TextHAlignAsString = "Right"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance42
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(4, 56)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel17.TabIndex = 231
        Me.UltraLabel17.Text = "Assigned To"
        '
        'btnAssignTeam
        '
        Me.btnAssignTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignTeam.Location = New System.Drawing.Point(240, 53)
        Me.btnAssignTeam.Name = "btnAssignTeam"
        Me.btnAssignTeam.Size = New System.Drawing.Size(58, 22)
        Me.btnAssignTeam.TabIndex = 233
        Me.btnAssignTeam.Text = "Select"
        '
        'UltraPanel6
        '
        '
        'UltraPanel6.ClientArea
        '
        Me.UltraPanel6.ClientArea.Controls.Add(Me.btnAddTeam)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.btnDeleteTeam)
        Me.UltraPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel6.Location = New System.Drawing.Point(0, 355)
        Me.UltraPanel6.Name = "UltraPanel6"
        Me.UltraPanel6.Size = New System.Drawing.Size(397, 27)
        Me.UltraPanel6.TabIndex = 145
        '
        'btnAddTeam
        '
        Me.btnAddTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTeam.Location = New System.Drawing.Point(273, 0)
        Me.btnAddTeam.Name = "btnAddTeam"
        Me.btnAddTeam.Size = New System.Drawing.Size(62, 27)
        Me.btnAddTeam.TabIndex = 0
        Me.btnAddTeam.Text = "Add"
        '
        'btnDeleteTeam
        '
        Me.btnDeleteTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteTeam.Location = New System.Drawing.Point(335, 0)
        Me.btnDeleteTeam.Name = "btnDeleteTeam"
        Me.btnDeleteTeam.Size = New System.Drawing.Size(62, 27)
        Me.btnDeleteTeam.TabIndex = 1
        Me.btnDeleteTeam.Text = "Delete"
        '
        'UltraLabel1
        '
        Appearance43.FontData.SizeInPoints = 8.25!
        Appearance43.TextHAlignAsString = "Right"
        Appearance43.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance43
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel1.TabIndex = 92
        Me.UltraLabel1.Text = "Assigned To"
        '
        'cmb_AssignUserID
        '
        Me.cmb_AssignUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_AssignUserID.Location = New System.Drawing.Point(79, 19)
        Me.cmb_AssignUserID.Name = "cmb_AssignUserID"
        Me.cmb_AssignUserID.ReadOnly = True
        Me.cmb_AssignUserID.Size = New System.Drawing.Size(156, 22)
        Me.cmb_AssignUserID.TabIndex = 93
        '
        'btnAssignUser
        '
        Me.btnAssignUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssignUser.Location = New System.Drawing.Point(240, 20)
        Me.btnAssignUser.Name = "btnAssignUser"
        Me.btnAssignUser.Size = New System.Drawing.Size(58, 20)
        Me.btnAssignUser.TabIndex = 94
        Me.btnAssignUser.Text = "Select"
        '
        'btnClearUser
        '
        Me.btnClearUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearUser.Location = New System.Drawing.Point(299, 20)
        Me.btnClearUser.Name = "btnClearUser"
        Me.btnClearUser.Size = New System.Drawing.Size(58, 20)
        Me.btnClearUser.TabIndex = 95
        Me.btnClearUser.Text = "Clear"
        '
        'UltraPanel5
        '
        Me.UltraPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel5.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel5.Name = "UltraPanel5"
        Me.UltraPanel5.Size = New System.Drawing.Size(397, 83)
        Me.UltraPanel5.TabIndex = 149
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel10.Location = New System.Drawing.Point(0, 131)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(401, 30)
        Me.Panel10.TabIndex = 3
        '
        'btnEditLicense
        '
        Me.btnEditLicense.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditLicense.Location = New System.Drawing.Point(328, 0)
        Me.btnEditLicense.Name = "btnEditLicense"
        Me.btnEditLicense.Size = New System.Drawing.Size(73, 30)
        Me.btnEditLicense.TabIndex = 3
        '
        'btnAddLicense
        '
        Me.btnAddLicense.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddLicense.Location = New System.Drawing.Point(258, 0)
        Me.btnAddLicense.Name = "btnAddLicense"
        Me.btnAddLicense.Size = New System.Drawing.Size(70, 30)
        Me.btnAddLicense.TabIndex = 2
        '
        'UltraGridLicense
        '
        Me.UltraGridLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridLicense.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridLicense.Name = "UltraGridLicense"
        Me.UltraGridLicense.Size = New System.Drawing.Size(401, 131)
        Me.UltraGridLicense.TabIndex = 5
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 131)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(401, 30)
        Me.Panel9.TabIndex = 2
        '
        'btnDelPartner
        '
        Me.btnDelPartner.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelPartner.Location = New System.Drawing.Point(328, 0)
        Me.btnDelPartner.Name = "btnDelPartner"
        Me.btnDelPartner.Size = New System.Drawing.Size(73, 30)
        Me.btnDelPartner.TabIndex = 3
        '
        'btnAddPartner
        '
        Me.btnAddPartner.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddPartner.Location = New System.Drawing.Point(258, 0)
        Me.btnAddPartner.Name = "btnAddPartner"
        Me.btnAddPartner.Size = New System.Drawing.Size(70, 30)
        Me.btnAddPartner.TabIndex = 2
        '
        'UltraGridPartner
        '
        Me.UltraGridPartner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPartner.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridPartner.Name = "UltraGridPartner"
        Me.UltraGridPartner.Size = New System.Drawing.Size(401, 131)
        Me.UltraGridPartner.TabIndex = 4
        '
        'UltraPanel8
        '
        Me.UltraPanel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel8.Location = New System.Drawing.Point(0, 130)
        Me.UltraPanel8.Name = "UltraPanel8"
        Me.UltraPanel8.Size = New System.Drawing.Size(401, 31)
        Me.UltraPanel8.TabIndex = 0
        '
        'btnDelGroup
        '
        Me.btnDelGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelGroup.Location = New System.Drawing.Point(328, 0)
        Me.btnDelGroup.Name = "btnDelGroup"
        Me.btnDelGroup.Size = New System.Drawing.Size(73, 31)
        Me.btnDelGroup.TabIndex = 1
        '
        'btnAddGroup
        '
        Me.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddGroup.Location = New System.Drawing.Point(258, 0)
        Me.btnAddGroup.Name = "btnAddGroup"
        Me.btnAddGroup.Size = New System.Drawing.Size(70, 31)
        Me.btnAddGroup.TabIndex = 0
        '
        'UltraPanel7
        '
        Me.UltraPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel7.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel7.Name = "UltraPanel7"
        Me.UltraPanel7.Size = New System.Drawing.Size(401, 130)
        Me.UltraPanel7.TabIndex = 0
        '
        'UltraGridGroup
        '
        Me.UltraGridGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridGroup.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridGroup.Name = "UltraGridGroup"
        Me.UltraGridGroup.Size = New System.Drawing.Size(401, 130)
        Me.UltraGridGroup.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(401, 161)
        Me.Panel5.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 131)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(401, 30)
        Me.Panel6.TabIndex = 1
        '
        'btnDelUser
        '
        Me.btnDelUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDelUser.Location = New System.Drawing.Point(328, 0)
        Me.btnDelUser.Name = "btnDelUser"
        Me.btnDelUser.Size = New System.Drawing.Size(73, 30)
        Me.btnDelUser.TabIndex = 3
        '
        'btnAddUser
        '
        Me.btnAddUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddUser.Location = New System.Drawing.Point(258, 0)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(70, 30)
        Me.btnAddUser.TabIndex = 2
        '
        'UltraGridUser
        '
        Me.UltraGridUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridUser.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridUser.Name = "UltraGridUser"
        Me.UltraGridUser.Size = New System.Drawing.Size(401, 131)
        Me.UltraGridUser.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 131)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(401, 30)
        Me.Panel8.TabIndex = 3
        '
        'btnGenerate
        '
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerate.Location = New System.Drawing.Point(0, 0)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(70, 30)
        Me.btnGenerate.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(401, 98)
        Me.Panel7.TabIndex = 6
        '
        'UltraLabel8
        '
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(49, 11)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel8.TabIndex = 48
        '
        'txt_DataBaseName
        '
        Appearance44.FontData.BoldAsString = "False"
        Me.txt_DataBaseName.Appearance = Appearance44
        Me.txt_DataBaseName.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_DataBaseName.Location = New System.Drawing.Point(123, 31)
        Me.txt_DataBaseName.Name = "txt_DataBaseName"
        Me.txt_DataBaseName.Size = New System.Drawing.Size(240, 17)
        Me.txt_DataBaseName.TabIndex = 51
        Me.txt_DataBaseName.Text = "UltraTextEditor2"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(34, 32)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(86, 14)
        Me.UltraLabel7.TabIndex = 50
        '
        'txt_ServerName
        '
        Appearance45.FontData.BoldAsString = "False"
        Me.txt_ServerName.Appearance = Appearance45
        Me.txt_ServerName.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_ServerName.Location = New System.Drawing.Point(123, 10)
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.Size = New System.Drawing.Size(240, 17)
        Me.txt_ServerName.TabIndex = 49
        Me.txt_ServerName.Text = "UltraTextEditor2"
        '
        'UltraLabel14
        '
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(7, 76)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(112, 14)
        Me.UltraLabel14.TabIndex = 52
        '
        'txt_AdminDbPwd
        '
        Appearance46.FontData.BoldAsString = "False"
        Me.txt_AdminDbPwd.Appearance = Appearance46
        Me.txt_AdminDbPwd.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_AdminDbPwd.Location = New System.Drawing.Point(522, 32)
        Me.txt_AdminDbPwd.Name = "txt_AdminDbPwd"
        Me.txt_AdminDbPwd.Size = New System.Drawing.Size(240, 17)
        Me.txt_AdminDbPwd.TabIndex = 55
        Me.txt_AdminDbPwd.Text = "UltraTextEditor2"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(378, 32)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(141, 14)
        Me.UltraLabel13.TabIndex = 54
        '
        'txt_SAConnectionstring
        '
        Appearance47.FontData.BoldAsString = "False"
        Me.txt_SAConnectionstring.Appearance = Appearance47
        Me.txt_SAConnectionstring.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_SAConnectionstring.Location = New System.Drawing.Point(122, 74)
        Me.txt_SAConnectionstring.Name = "txt_SAConnectionstring"
        Me.txt_SAConnectionstring.Size = New System.Drawing.Size(639, 17)
        Me.txt_SAConnectionstring.TabIndex = 53
        Me.txt_SAConnectionstring.Text = "UltraTextEditor2"
        '
        'txt_AdminDbUser
        '
        Appearance48.FontData.BoldAsString = "False"
        Me.txt_AdminDbUser.Appearance = Appearance48
        Me.txt_AdminDbUser.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_AdminDbUser.Location = New System.Drawing.Point(521, 9)
        Me.txt_AdminDbUser.Name = "txt_AdminDbUser"
        Me.txt_AdminDbUser.Size = New System.Drawing.Size(240, 17)
        Me.txt_AdminDbUser.TabIndex = 57
        Me.txt_AdminDbUser.Text = "UltraTextEditor2"
        '
        'UltraLabel15
        '
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(403, 10)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(115, 14)
        Me.UltraLabel15.TabIndex = 56
        '
        'txt_StorageAccount
        '
        Appearance49.FontData.BoldAsString = "False"
        Me.txt_StorageAccount.Appearance = Appearance49
        Me.txt_StorageAccount.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_StorageAccount.Location = New System.Drawing.Point(123, 52)
        Me.txt_StorageAccount.Name = "txt_StorageAccount"
        Me.txt_StorageAccount.Size = New System.Drawing.Size(240, 17)
        Me.txt_StorageAccount.TabIndex = 59
        Me.txt_StorageAccount.Text = "UltraTextEditor2"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(32, 53)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(88, 14)
        Me.UltraLabel16.TabIndex = 58
        '
        'UltraGridDatabase
        '
        Me.UltraGridDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDatabase.Location = New System.Drawing.Point(0, 98)
        Me.UltraGridDatabase.Name = "UltraGridDatabase"
        Me.UltraGridDatabase.Size = New System.Drawing.Size(401, 33)
        Me.UltraGridDatabase.TabIndex = 5
        '
        'btnDeleteMeeting
        '
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance12.FontData.BoldAsString = "True"
        Me.btnDeleteMeeting.Appearance = Appearance12
        Me.btnDeleteMeeting.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteMeeting.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteMeeting.Name = "btnDeleteMeeting"
        Me.btnDeleteMeeting.Size = New System.Drawing.Size(88, 39)
        Me.btnDeleteMeeting.TabIndex = 7
        Me.btnDeleteMeeting.Text = "Delete Meeting"
        Me.btnDeleteMeeting.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frmMeeting
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.Caption = "Call"
        Me.ClientSize = New System.Drawing.Size(811, 440)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMeeting"
        Me.Text = "Call"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.chk_IsReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ReminderTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_SMSReminderTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EmailReminderTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.dt_RepeatUntil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RepeatType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RepeatCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RepeatInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraGridEmpSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraGridEmpSalBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.PerformLayout()
        Me.UltraPanel4.ResumeLayout(False)
        CType(Me.txt_Description, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DurationMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DurationHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_AllDayEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_sdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PIDField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PIDValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_Assign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_Assign.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.UltraGridTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_AssignTeamID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel6.ClientArea.ResumeLayout(False)
        Me.UltraPanel6.ResumeLayout(False)
        CType(Me.cmb_AssignUserID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel5.ResumeLayout(False)
        CType(Me.UltraGridLicense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridPartner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel8.ResumeLayout(False)
        Me.UltraPanel7.ResumeLayout(False)
        CType(Me.UltraGridGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DataBaseName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ServerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AdminDbPwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SAConnectionstring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AdminDbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StorageAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents btnAddNew As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEdit As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridEmpSalary As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGridEmpSalBen As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents UEGB_Assign As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_AssignTeamID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnClearTeam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnAssignTeam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPanel6 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnAddTeam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDeleteTeam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_AssignUserID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnAssignUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnClearUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPanel5 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGridTeam As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel4 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel10 As Windows.Forms.Panel
    Friend WithEvents btnEditLicense As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddLicense As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridLicense As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents btnDelPartner As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPartner As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridPartner As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel8 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDelGroup As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddGroup As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraPanel7 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraGridGroup As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents btnDelUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridUser As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Friend WithEvents btnGenerate As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel7 As Windows.Forms.Panel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DataBaseName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ServerName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_AdminDbPwd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_SAConnectionstring As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_AdminDbUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_StorageAccount As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridDatabase As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dt_RepeatUntil As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmb_RepeatType As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txt_RepeatCount As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_RepeatInterval As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents checkedListBoxWeeklyDays As Windows.Forms.CheckedListBox
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chk_IsReminder As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ReminderTime As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_SMSReminderTime As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_EmailReminderTime As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents cmb_PIDField As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_PIDValue As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dt_sdate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Location As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Status As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_DurationMinutes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_DurationHours As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_AllDayEvent As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Description As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnDeleteMeeting As Infragistics.Win.Misc.UltraButton

#End Region
End Class
