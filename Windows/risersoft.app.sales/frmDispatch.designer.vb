<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmDispatch
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myView.SetGrid(Me.UltraGrid1)
        myVueSpare.SetGrid(Me.UltraGridSpare)
        myVueDoc.SetGrid(Me.UltraGridDoc)
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents arbit As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txt_SalesOrderID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_FreightPaid As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_DeliveryTo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_DispDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_RefDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_ConsigneePrefix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_RefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_ConsigneeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chk_InsureTransit As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_insureStorageDays As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_AttendantReq As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Urgency As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_UrgencyRemark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridSpare As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnEditDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents checkInsureStorage As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConsignee = New Infragistics.Win.Misc.UltraButton()
        Me.txt_SalesOrderID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_POSTaxAreaID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chk_FreightPaid = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txt_DeliveryTo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_DispDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_RefDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_ConsigneePrefix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txt_RefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_ConsigneeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.arbit = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_UrgencyRemark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_Urgency = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_AttendantReq = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_insureStorageDays = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.checkInsureStorage = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.chk_InsureTransit = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridSpare = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.PanelAddSP = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDelSP = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSpares = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEditDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_SalesOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_POSTaxAreaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_FreightPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DeliveryTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DispDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_RefDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ConsigneePrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_RefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ConsigneeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.arbit.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_UrgencyRemark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Urgency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chk_AttendantReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_insureStorageDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkInsureStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_InsureTransit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAddSP.ClientArea.SuspendLayout()
        Me.PanelAddSP.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(756, 401)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(456, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(300, 401)
        Me.UltraGrid1.TabIndex = 1
        Me.UltraGrid1.Text = "Serial Nos."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnConsignee)
        Me.Panel1.Controls.Add(Me.txt_SalesOrderID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmb_POSTaxAreaID)
        Me.Panel1.Controls.Add(Me.chk_FreightPaid)
        Me.Panel1.Controls.Add(Me.txt_DeliveryTo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dt_DispDate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dt_RefDate)
        Me.Panel1.Controls.Add(Me.txt_ConsigneePrefix)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.txt_RefNum)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.cmb_ConsigneeID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 401)
        Me.Panel1.TabIndex = 0
        '
        'btnConsignee
        '
        Me.btnConsignee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsignee.Location = New System.Drawing.Point(374, 368)
        Me.btnConsignee.Name = "btnConsignee"
        Me.btnConsignee.Size = New System.Drawing.Size(74, 26)
        Me.btnConsignee.TabIndex = 15
        Me.btnConsignee.Text = "Consignee"
        '
        'txt_SalesOrderID
        '
        Me.txt_SalesOrderID.Location = New System.Drawing.Point(15, 373)
        Me.txt_SalesOrderID.Name = "txt_SalesOrderID"
        Me.txt_SalesOrderID.Size = New System.Drawing.Size(78, 21)
        Me.txt_SalesOrderID.TabIndex = 12
        Me.txt_SalesOrderID.Text = "salesorderid"
        Me.txt_SalesOrderID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(50, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Place of Supply"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_POSTaxAreaID
        '
        Appearance1.FontData.BoldAsString = "False"
        Me.cmb_POSTaxAreaID.Appearance = Appearance1
        Me.cmb_POSTaxAreaID.Location = New System.Drawing.Point(136, 227)
        Me.cmb_POSTaxAreaID.Name = "cmb_POSTaxAreaID"
        Me.cmb_POSTaxAreaID.Size = New System.Drawing.Size(312, 22)
        Me.cmb_POSTaxAreaID.TabIndex = 13
        Me.cmb_POSTaxAreaID.Text = "UltraCombo5"
        '
        'chk_FreightPaid
        '
        Me.chk_FreightPaid.Location = New System.Drawing.Point(136, 90)
        Me.chk_FreightPaid.Name = "chk_FreightPaid"
        Me.chk_FreightPaid.Size = New System.Drawing.Size(168, 24)
        Me.chk_FreightPaid.TabIndex = 7
        Me.chk_FreightPaid.Text = "Freight Is Paid"
        '
        'txt_DeliveryTo
        '
        Me.txt_DeliveryTo.Location = New System.Drawing.Point(16, 280)
        Me.txt_DeliveryTo.Multiline = True
        Me.txt_DeliveryTo.Name = "txt_DeliveryTo"
        Me.txt_DeliveryTo.Size = New System.Drawing.Size(432, 72)
        Me.txt_DeliveryTo.TabIndex = 11
        Me.txt_DeliveryTo.Text = "UltraTextEditor3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(19, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ship To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(1, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Requested Dispatch Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_DispDate
        '
        Me.dt_DispDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_DispDate.Location = New System.Drawing.Point(136, 65)
        Me.dt_DispDate.Name = "dt_DispDate"
        Me.dt_DispDate.NullText = "Not Defined"
        Me.dt_DispDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_DispDate.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(20, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Dispatch Advice Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_RefDate
        '
        Me.dt_RefDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_RefDate.Location = New System.Drawing.Point(136, 38)
        Me.dt_RefDate.Name = "dt_RefDate"
        Me.dt_RefDate.NullText = "Not Defined"
        Me.dt_RefDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_RefDate.TabIndex = 3
        '
        'txt_ConsigneePrefix
        '
        Me.txt_ConsigneePrefix.AcceptsReturn = True
        Me.txt_ConsigneePrefix.Location = New System.Drawing.Point(16, 125)
        Me.txt_ConsigneePrefix.Multiline = True
        Me.txt_ConsigneePrefix.Name = "txt_ConsigneePrefix"
        Me.txt_ConsigneePrefix.Size = New System.Drawing.Size(432, 64)
        Me.txt_ConsigneePrefix.TabIndex = 8
        Me.txt_ConsigneePrefix.Text = "UltraTextEditor2"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(26, 14)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(104, 14)
        Me.lblRef.TabIndex = 0
        Me.lblRef.Text = "Dispatch Advice No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_RefNum
        '
        Me.txt_RefNum.Location = New System.Drawing.Point(136, 11)
        Me.txt_RefNum.Name = "txt_RefNum"
        Me.txt_RefNum.Size = New System.Drawing.Size(256, 21)
        Me.txt_RefNum.TabIndex = 1
        Me.txt_RefNum.Text = "UltraTextEditor1"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(20, 108)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(94, 14)
        Me.lblNum.TabIndex = 6
        Me.lblNum.Text = "Consignee (Bill to)"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_ConsigneeID
        '
        Me.cmb_ConsigneeID.Location = New System.Drawing.Point(16, 197)
        Me.cmb_ConsigneeID.Name = "cmb_ConsigneeID"
        Me.cmb_ConsigneeID.Size = New System.Drawing.Size(432, 22)
        Me.cmb_ConsigneeID.TabIndex = 9
        Me.cmb_ConsigneeID.Text = "UltraCombo3"
        '
        'arbit
        '
        Me.arbit.Controls.Add(Me.GroupBox2)
        Me.arbit.Controls.Add(Me.GroupBox1)
        Me.arbit.Location = New System.Drawing.Point(-10000, -10000)
        Me.arbit.Name = "arbit"
        Me.arbit.Size = New System.Drawing.Size(756, 401)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_UrgencyRemark)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chk_Urgency)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Urgency"
        '
        'txt_UrgencyRemark
        '
        Me.txt_UrgencyRemark.Location = New System.Drawing.Point(24, 120)
        Me.txt_UrgencyRemark.Multiline = True
        Me.txt_UrgencyRemark.Name = "txt_UrgencyRemark"
        Me.txt_UrgencyRemark.Size = New System.Drawing.Size(192, 72)
        Me.txt_UrgencyRemark.TabIndex = 2
        Me.txt_UrgencyRemark.Text = "UltraTextEditor3"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Remark for Urgency if any"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_Urgency
        '
        Me.chk_Urgency.Location = New System.Drawing.Point(24, 48)
        Me.chk_Urgency.Name = "chk_Urgency"
        Me.chk_Urgency.Size = New System.Drawing.Size(168, 24)
        Me.chk_Urgency.TabIndex = 0
        Me.chk_Urgency.Text = "Mark Dispatch as urgent"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_AttendantReq)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_insureStorageDays)
        Me.GroupBox1.Controls.Add(Me.checkInsureStorage)
        Me.GroupBox1.Controls.Add(Me.chk_InsureTransit)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 248)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insurance"
        '
        'chk_AttendantReq
        '
        Me.chk_AttendantReq.Location = New System.Drawing.Point(24, 168)
        Me.chk_AttendantReq.Name = "chk_AttendantReq"
        Me.chk_AttendantReq.Size = New System.Drawing.Size(192, 24)
        Me.chk_AttendantReq.TabIndex = 4
        Me.chk_AttendantReq.Text = "Attendant Required with vehicle"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(104, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Days"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_insureStorageDays
        '
        Me.txt_insureStorageDays.Location = New System.Drawing.Point(48, 128)
        Me.txt_insureStorageDays.Name = "txt_insureStorageDays"
        Me.txt_insureStorageDays.Size = New System.Drawing.Size(56, 21)
        Me.txt_insureStorageDays.TabIndex = 2
        Me.txt_insureStorageDays.Text = "UltraTextEditor1"
        '
        'checkInsureStorage
        '
        Me.checkInsureStorage.Location = New System.Drawing.Point(24, 96)
        Me.checkInsureStorage.Name = "checkInsureStorage"
        Me.checkInsureStorage.Size = New System.Drawing.Size(168, 24)
        Me.checkInsureStorage.TabIndex = 1
        Me.checkInsureStorage.Text = "Storage Insurance Required"
        '
        'chk_InsureTransit
        '
        Me.chk_InsureTransit.Location = New System.Drawing.Point(24, 48)
        Me.chk_InsureTransit.Name = "chk_InsureTransit"
        Me.chk_InsureTransit.Size = New System.Drawing.Size(168, 24)
        Me.chk_InsureTransit.TabIndex = 0
        Me.chk_InsureTransit.Text = "Transit Insurance Required"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridSpare)
        Me.UltraTabPageControl2.Controls.Add(Me.PanelAddSP)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(756, 401)
        '
        'UltraGridSpare
        '
        Me.UltraGridSpare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpare.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSpare.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSpare.Name = "UltraGridSpare"
        Me.UltraGridSpare.Size = New System.Drawing.Size(756, 370)
        Me.UltraGridSpare.TabIndex = 0
        Me.UltraGridSpare.Text = "Spares"
        '
        'PanelAddSP
        '
        '
        'PanelAddSP.ClientArea
        '
        Me.PanelAddSP.ClientArea.Controls.Add(Me.btnDelSP)
        Me.PanelAddSP.ClientArea.Controls.Add(Me.btnAddSpares)
        Me.PanelAddSP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAddSP.Location = New System.Drawing.Point(0, 370)
        Me.PanelAddSP.Name = "PanelAddSP"
        Me.PanelAddSP.Size = New System.Drawing.Size(756, 31)
        Me.PanelAddSP.TabIndex = 54
        '
        'btnDelSP
        '
        Me.btnDelSP.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelSP.Location = New System.Drawing.Point(84, 0)
        Me.btnDelSP.Name = "btnDelSP"
        Me.btnDelSP.Size = New System.Drawing.Size(84, 31)
        Me.btnDelSP.TabIndex = 12
        Me.btnDelSP.Text = "&Delete"
        '
        'btnAddSpares
        '
        Me.btnAddSpares.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSpares.Location = New System.Drawing.Point(0, 0)
        Me.btnAddSpares.Name = "btnAddSpares"
        Me.btnAddSpares.Size = New System.Drawing.Size(84, 31)
        Me.btnAddSpares.TabIndex = 10
        Me.btnAddSpares.Text = "Add Spares"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(756, 401)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridDoc)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(756, 401)
        Me.Panel2.TabIndex = 14
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(756, 353)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditDoc)
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 353)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(756, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnEditDoc
        '
        Me.btnEditDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDoc.Location = New System.Drawing.Point(576, 16)
        Me.btnEditDoc.Name = "btnEditDoc"
        Me.btnEditDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnEditDoc.TabIndex = 1
        Me.btnEditDoc.Text = "Edit"
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Location = New System.Drawing.Point(480, 16)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Location = New System.Drawing.Point(664, 16)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 2
        Me.btnAddDoc.Text = "Add New"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.arbit)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance2.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance2
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(760, 427)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.TabPage = Me.arbit
        UltraTab2.Text = "Requirement"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Spares"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Documents"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(756, 401)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 427)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(760, 42)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(496, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(584, 0)
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
        Me.btnOK.Location = New System.Drawing.Point(672, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 42)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'frmDispatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Dispatch"
        Me.ClientSize = New System.Drawing.Size(760, 469)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDispatch"
        Me.Text = "Dispatch"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_SalesOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_POSTaxAreaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_FreightPaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DeliveryTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DispDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_RefDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ConsigneePrefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_RefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ConsigneeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.arbit.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_UrgencyRemark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Urgency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chk_AttendantReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_insureStorageDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkInsureStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_InsureTransit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAddSP.ClientArea.ResumeLayout(False)
        Me.PanelAddSP.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents cmb_POSTaxAreaID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnConsignee As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PanelAddSP As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDelSP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSpares As Infragistics.Win.Misc.UltraButton

#End Region
End Class

