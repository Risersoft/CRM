<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSalesInvoice
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
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents arbit As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_CaseSubmit As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_PenaltyNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_PenaltyAmt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_CaseAccept As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dt_CaseReject As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Deduction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_DeductText As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridPay As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_AmountTot As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents dt_InvoiceDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_InvoiceNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_campusid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblSalesOrder = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_deliverycampusid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.PanelSO = New Infragistics.Win.Misc.UltraPanel()
        Me.btnRemoveSO = New Infragistics.Win.Misc.UltraButton()
        Me.btnSelectSO = New Infragistics.Win.Misc.UltraButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtOrderDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_AmountTot = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_InvoiceDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txt_InvoiceNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.arbit = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ChallanText = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Deduction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_DeductText = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_CaseReject = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dt_CaseAccept = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_PenaltyAmt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_CaseSubmit = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_PenaltyNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UltraGridDoc = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UltraGridPay = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridForms = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel4 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDelForms = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddForms = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGridSpare = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGridService = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UEGB_ItemList = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGridSerial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGridAddSpares = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDelSpares = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSpares = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGridAddSerial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnDelSerial = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSerial = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.lblProjectCampusID = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_ProjectCampusID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_campusid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_deliverycampusid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSO.ClientArea.SuspendLayout()
        Me.PanelSO.SuspendLayout()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AmountTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InvoiceNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.arbit.SuspendLayout()
        CType(Me.txt_ChallanText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Deduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DeductText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CaseReject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CaseAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PenaltyAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CaseSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PenaltyNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGridPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel4.ClientArea.SuspendLayout()
        Me.UltraPanel4.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.UltraGridService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_ItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_ItemList.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UltraGridSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.UltraGridAddSpares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.UltraGridAddSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_ProjectCampusID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Panel1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(763, 428)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProjectCampusID)
        Me.Panel1.Controls.Add(Me.cmb_ProjectCampusID)
        Me.Panel1.Controls.Add(Me.cmb_campusid)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Controls.Add(Me.lblSalesOrder)
        Me.Panel1.Controls.Add(Me.cmb_deliverycampusid)
        Me.Panel1.Controls.Add(Me.UltraLabel10)
        Me.Panel1.Controls.Add(Me.PanelSO)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmb_CustomerID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtOrderDate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSONum)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_AmountTot)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_StatusNum)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dt_InvoiceDate)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.txt_InvoiceNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 428)
        Me.Panel1.TabIndex = 0
        '
        'cmb_campusid
        '
        Me.cmb_campusid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_campusid.Location = New System.Drawing.Point(95, 137)
        Me.cmb_campusid.Name = "cmb_campusid"
        Me.cmb_campusid.ReadOnly = True
        Me.cmb_campusid.Size = New System.Drawing.Size(240, 22)
        Me.cmb_campusid.TabIndex = 25
        '
        'UltraLabel5
        '
        Appearance2.FontData.SizeInPoints = 8.25!
        Appearance2.TextHAlignAsString = "Right"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance2
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(7, 141)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(85, 14)
        Me.UltraLabel5.TabIndex = 24
        Me.UltraLabel5.Text = "Invoice Campus"
        '
        'lblSalesOrder
        '
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.TextHAlignAsString = "Right"
        Appearance3.TextVAlignAsString = "Middle"
        Me.lblSalesOrder.Appearance = Appearance3
        Me.lblSalesOrder.AutoSize = True
        Me.lblSalesOrder.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesOrder.Location = New System.Drawing.Point(3, 375)
        Me.lblSalesOrder.Name = "lblSalesOrder"
        Me.lblSalesOrder.Size = New System.Drawing.Size(104, 14)
        Me.lblSalesOrder.TabIndex = 21
        Me.lblSalesOrder.Text = "Select Sales Order "
        '
        'cmb_deliverycampusid
        '
        Me.cmb_deliverycampusid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_deliverycampusid.Location = New System.Drawing.Point(95, 164)
        Me.cmb_deliverycampusid.Name = "cmb_deliverycampusid"
        Me.cmb_deliverycampusid.ReadOnly = True
        Me.cmb_deliverycampusid.Size = New System.Drawing.Size(240, 22)
        Me.cmb_deliverycampusid.TabIndex = 23
        '
        'UltraLabel10
        '
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.TextHAlignAsString = "Right"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance4
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(17, 167)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(75, 14)
        Me.UltraLabel10.TabIndex = 22
        Me.UltraLabel10.Text = "Delivery From"
        '
        'PanelSO
        '
        '
        'PanelSO.ClientArea
        '
        Me.PanelSO.ClientArea.Controls.Add(Me.btnRemoveSO)
        Me.PanelSO.ClientArea.Controls.Add(Me.btnSelectSO)
        Me.PanelSO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelSO.Location = New System.Drawing.Point(0, 392)
        Me.PanelSO.Name = "PanelSO"
        Me.PanelSO.Size = New System.Drawing.Size(347, 36)
        Me.PanelSO.TabIndex = 20
        '
        'btnRemoveSO
        '
        Me.btnRemoveSO.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRemoveSO.Location = New System.Drawing.Point(76, 0)
        Me.btnRemoveSO.Name = "btnRemoveSO"
        Me.btnRemoveSO.Size = New System.Drawing.Size(86, 36)
        Me.btnRemoveSO.TabIndex = 9
        Me.btnRemoveSO.Text = "Remove Sales Order"
        '
        'btnSelectSO
        '
        Me.btnSelectSO.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelectSO.Location = New System.Drawing.Point(0, 0)
        Me.btnSelectSO.Name = "btnSelectSO"
        Me.btnSelectSO.Size = New System.Drawing.Size(76, 36)
        Me.btnSelectSO.TabIndex = 4
        Me.btnSelectSO.Text = "Select Sales Order"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(9, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Customer Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Me.cmb_CustomerID.Location = New System.Drawing.Point(95, 110)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.ReadOnly = True
        Me.cmb_CustomerID.Size = New System.Drawing.Size(240, 22)
        Me.cmb_CustomerID.TabIndex = 9
        Me.cmb_CustomerID.Text = "UltraCombo3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(32, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Order Date"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtOrderDate
        '
        Me.dtOrderDate.FormatString = "ddd dd MMM yyyy"
        Me.dtOrderDate.Location = New System.Drawing.Point(95, 84)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.NullText = "Not Defined"
        Me.dtOrderDate.ReadOnly = True
        Me.dtOrderDate.Size = New System.Drawing.Size(160, 21)
        Me.dtOrderDate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(38, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Order No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSONum
        '
        Me.txtSONum.Location = New System.Drawing.Point(95, 58)
        Me.txtSONum.Name = "txtSONum"
        Me.txtSONum.ReadOnly = True
        Me.txtSONum.Size = New System.Drawing.Size(160, 21)
        Me.txtSONum.TabIndex = 5
        Me.txtSONum.Text = "UltraTextEditor1"
        '
        'txt_Remark
        '
        Me.txt_Remark.Location = New System.Drawing.Point(95, 271)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(240, 95)
        Me.txt_Remark.TabIndex = 15
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(49, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Remark"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(24, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total Amount"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_AmountTot
        '
        Me.txt_AmountTot.Location = New System.Drawing.Point(95, 245)
        Me.txt_AmountTot.Name = "txt_AmountTot"
        Me.txt_AmountTot.ReadOnly = True
        Me.txt_AmountTot.Size = New System.Drawing.Size(160, 21)
        Me.txt_AmountTot.TabIndex = 13
        Me.txt_AmountTot.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(54, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(95, 218)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.ReadOnly = True
        Me.cmb_StatusNum.Size = New System.Drawing.Size(240, 22)
        Me.cmb_StatusNum.TabIndex = 11
        Me.cmb_StatusNum.Text = "UltraCombo3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(32, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Invoice No."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_InvoiceDate
        '
        Me.dt_InvoiceDate.FormatString = "ddd dd MMM yyyy"
        Me.dt_InvoiceDate.Location = New System.Drawing.Point(95, 32)
        Me.dt_InvoiceDate.Name = "dt_InvoiceDate"
        Me.dt_InvoiceDate.NullText = "Not Defined"
        Me.dt_InvoiceDate.ReadOnly = True
        Me.dt_InvoiceDate.Size = New System.Drawing.Size(160, 21)
        Me.dt_InvoiceDate.TabIndex = 3
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(26, 35)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(66, 14)
        Me.lblRef.TabIndex = 2
        Me.lblRef.Text = "Invoice Date"
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_InvoiceNum
        '
        Me.txt_InvoiceNum.Location = New System.Drawing.Point(95, 6)
        Me.txt_InvoiceNum.Name = "txt_InvoiceNum"
        Me.txt_InvoiceNum.ReadOnly = True
        Me.txt_InvoiceNum.Size = New System.Drawing.Size(160, 21)
        Me.txt_InvoiceNum.TabIndex = 1
        Me.txt_InvoiceNum.Text = "UltraTextEditor1"
        '
        'arbit
        '
        Me.arbit.Controls.Add(Me.Label5)
        Me.arbit.Controls.Add(Me.txt_ChallanText)
        Me.arbit.Controls.Add(Me.Label16)
        Me.arbit.Controls.Add(Me.txt_Deduction)
        Me.arbit.Controls.Add(Me.Label17)
        Me.arbit.Controls.Add(Me.txt_DeductText)
        Me.arbit.Controls.Add(Me.dt_CaseReject)
        Me.arbit.Controls.Add(Me.Label15)
        Me.arbit.Controls.Add(Me.dt_CaseAccept)
        Me.arbit.Controls.Add(Me.Label14)
        Me.arbit.Controls.Add(Me.Label13)
        Me.arbit.Controls.Add(Me.txt_PenaltyAmt)
        Me.arbit.Controls.Add(Me.Label1)
        Me.arbit.Controls.Add(Me.dt_CaseSubmit)
        Me.arbit.Controls.Add(Me.Label4)
        Me.arbit.Controls.Add(Me.txt_PenaltyNum)
        Me.arbit.Location = New System.Drawing.Point(-10000, -10000)
        Me.arbit.Name = "arbit"
        Me.arbit.Size = New System.Drawing.Size(763, 420)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(441, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Challan Text"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ChallanText
        '
        Me.txt_ChallanText.Location = New System.Drawing.Point(513, 109)
        Me.txt_ChallanText.Name = "txt_ChallanText"
        Me.txt_ChallanText.Size = New System.Drawing.Size(200, 21)
        Me.txt_ChallanText.TabIndex = 11
        Me.txt_ChallanText.Text = "UltraTextEditor1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(412, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 14)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Deduction Amount"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Deduction
        '
        Me.txt_Deduction.Location = New System.Drawing.Point(513, 77)
        Me.txt_Deduction.Name = "txt_Deduction"
        Me.txt_Deduction.Size = New System.Drawing.Size(160, 21)
        Me.txt_Deduction.TabIndex = 7
        Me.txt_Deduction.Text = "UltraTextEditor1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(380, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 14)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Deduction on Account of"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DeductText
        '
        Me.txt_DeductText.Location = New System.Drawing.Point(513, 45)
        Me.txt_DeductText.Name = "txt_DeductText"
        Me.txt_DeductText.Size = New System.Drawing.Size(200, 21)
        Me.txt_DeductText.TabIndex = 3
        Me.txt_DeductText.Text = "UltraTextEditor1"
        '
        'dt_CaseReject
        '
        Me.dt_CaseReject.FormatString = "ddd dd MMM yyyy"
        Me.dt_CaseReject.Location = New System.Drawing.Point(167, 173)
        Me.dt_CaseReject.Name = "dt_CaseReject"
        Me.dt_CaseReject.NullText = "Not Defined"
        Me.dt_CaseReject.Size = New System.Drawing.Size(152, 21)
        Me.dt_CaseReject.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(56, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 14)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Case Rejection Date"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CaseAccept
        '
        Me.dt_CaseAccept.FormatString = "ddd dd MMM yyyy"
        Me.dt_CaseAccept.Location = New System.Drawing.Point(167, 141)
        Me.dt_CaseAccept.Name = "dt_CaseAccept"
        Me.dt_CaseAccept.NullText = "Not Defined"
        Me.dt_CaseAccept.Size = New System.Drawing.Size(152, 21)
        Me.dt_CaseAccept.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(42, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 14)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Case Acceptance Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(79, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 14)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Penalty Amount"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PenaltyAmt
        '
        Me.txt_PenaltyAmt.Location = New System.Drawing.Point(167, 77)
        Me.txt_PenaltyAmt.Name = "txt_PenaltyAmt"
        Me.txt_PenaltyAmt.Size = New System.Drawing.Size(152, 21)
        Me.txt_PenaltyAmt.TabIndex = 5
        Me.txt_PenaltyAmt.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(83, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penalty Bill No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CaseSubmit
        '
        Me.dt_CaseSubmit.FormatString = "ddd dd MMM yyyy"
        Me.dt_CaseSubmit.Location = New System.Drawing.Point(167, 109)
        Me.dt_CaseSubmit.Name = "dt_CaseSubmit"
        Me.dt_CaseSubmit.NullText = "Not Defined"
        Me.dt_CaseSubmit.Size = New System.Drawing.Size(152, 21)
        Me.dt_CaseSubmit.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(45, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Case Submission Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PenaltyNum
        '
        Me.txt_PenaltyNum.Location = New System.Drawing.Point(167, 45)
        Me.txt_PenaltyNum.Name = "txt_PenaltyNum"
        Me.txt_PenaltyNum.Size = New System.Drawing.Size(152, 21)
        Me.txt_PenaltyNum.TabIndex = 1
        Me.txt_PenaltyNum.Text = "UltraTextEditor1"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(763, 420)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.UltraGridDoc)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(763, 420)
        Me.Panel5.TabIndex = 8
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(763, 392)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Documents"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnDelDoc)
        Me.Panel6.Controls.Add(Me.btnEditDoc)
        Me.Panel6.Controls.Add(Me.btnAddDoc)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 392)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(763, 28)
        Me.Panel6.TabIndex = 7
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelDoc.Location = New System.Drawing.Point(142, 0)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 28)
        Me.btnDelDoc.TabIndex = 2
        Me.btnDelDoc.Text = "Delete"
        '
        'btnEditDoc
        '
        Me.btnEditDoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEditDoc.Location = New System.Drawing.Point(72, 0)
        Me.btnEditDoc.Name = "btnEditDoc"
        Me.btnEditDoc.Size = New System.Drawing.Size(70, 28)
        Me.btnEditDoc.TabIndex = 1
        Me.btnEditDoc.Text = "Edit"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddDoc.Location = New System.Drawing.Point(0, 0)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 28)
        Me.btnAddDoc.TabIndex = 0
        Me.btnAddDoc.Text = "Add New"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(763, 420)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraGridPay)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(763, 420)
        Me.Panel3.TabIndex = 14
        '
        'UltraGridPay
        '
        Me.UltraGridPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPay.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridPay.Name = "UltraGridPay"
        Me.UltraGridPay.Size = New System.Drawing.Size(763, 420)
        Me.UltraGridPay.TabIndex = 0
        Me.UltraGridPay.Text = "Payments"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridForms)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraPanel4)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(763, 420)
        '
        'UltraGridForms
        '
        Me.UltraGridForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridForms.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridForms.Name = "UltraGridForms"
        Me.UltraGridForms.Size = New System.Drawing.Size(763, 392)
        Me.UltraGridForms.TabIndex = 0
        '
        'UltraPanel4
        '
        '
        'UltraPanel4.ClientArea
        '
        Me.UltraPanel4.ClientArea.Controls.Add(Me.btnDelForms)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.btnAddForms)
        Me.UltraPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel4.Location = New System.Drawing.Point(0, 392)
        Me.UltraPanel4.Name = "UltraPanel4"
        Me.UltraPanel4.Size = New System.Drawing.Size(763, 28)
        Me.UltraPanel4.TabIndex = 55
        '
        'btnDelForms
        '
        Me.btnDelForms.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelForms.Location = New System.Drawing.Point(70, 0)
        Me.btnDelForms.Name = "btnDelForms"
        Me.btnDelForms.Size = New System.Drawing.Size(70, 28)
        Me.btnDelForms.TabIndex = 1
        Me.btnDelForms.Text = "Delete"
        '
        'btnAddForms
        '
        Me.btnAddForms.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddForms.Location = New System.Drawing.Point(0, 0)
        Me.btnAddForms.Name = "btnAddForms"
        Me.btnAddForms.Size = New System.Drawing.Size(70, 28)
        Me.btnAddForms.TabIndex = 0
        Me.btnAddForms.Text = "Add New"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabPageControl6.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraTabPageControl6.Controls.Add(Me.UEGB_ItemList)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(763, 420)
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(763, 136)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 145)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(763, 136)
        Me.UltraExpandableGroupBox1.TabIndex = 1
        Me.UltraExpandableGroupBox1.Text = "Spare List"
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraGridSpare)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(757, 114)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UltraGridSpare
        '
        Me.UltraGridSpare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSpare.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridSpare.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSpare.Name = "UltraGridSpare"
        Me.UltraGridSpare.Size = New System.Drawing.Size(757, 114)
        Me.UltraGridSpare.TabIndex = 0
        Me.UltraGridSpare.Text = "Spares"
        '
        'UltraExpandableGroupBox4
        '
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(763, 139)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(0, 281)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(763, 139)
        Me.UltraExpandableGroupBox4.TabIndex = 2
        Me.UltraExpandableGroupBox4.Text = "Service List"
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraGridService)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(757, 117)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'UltraGridService
        '
        Me.UltraGridService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridService.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridService.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridService.Name = "UltraGridService"
        Me.UltraGridService.Size = New System.Drawing.Size(757, 117)
        Me.UltraGridService.TabIndex = 0
        Me.UltraGridService.Text = "Service"
        '
        'UEGB_ItemList
        '
        Me.UEGB_ItemList.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UEGB_ItemList.Dock = System.Windows.Forms.DockStyle.Top
        Me.UEGB_ItemList.ExpandedSize = New System.Drawing.Size(763, 145)
        Me.UEGB_ItemList.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UEGB_ItemList.Location = New System.Drawing.Point(0, 0)
        Me.UEGB_ItemList.Name = "UEGB_ItemList"
        Me.UEGB_ItemList.Size = New System.Drawing.Size(763, 145)
        Me.UEGB_ItemList.TabIndex = 0
        Me.UEGB_ItemList.Text = "Serial List"
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGridSerial)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(757, 123)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UltraGridSerial
        '
        Me.UltraGridSerial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridSerial.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridSerial.Name = "UltraGridSerial"
        Me.UltraGridSerial.Size = New System.Drawing.Size(757, 123)
        Me.UltraGridSerial.TabIndex = 0
        Me.UltraGridSerial.Text = "Serial Nos."
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(763, 420)
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(763, 215)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 205)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(763, 215)
        Me.UltraExpandableGroupBox2.TabIndex = 1
        Me.UltraExpandableGroupBox2.Text = "Spare List"
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGridAddSpares)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel2)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(757, 193)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'UltraGridAddSpares
        '
        Me.UltraGridAddSpares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridAddSpares.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGridAddSpares.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridAddSpares.Name = "UltraGridAddSpares"
        Me.UltraGridAddSpares.Size = New System.Drawing.Size(757, 165)
        Me.UltraGridAddSpares.TabIndex = 0
        Me.UltraGridAddSpares.Text = "Spares"
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.btnDelSpares)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.btnAddSpares)
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 165)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(757, 28)
        Me.UltraPanel2.TabIndex = 56
        '
        'btnDelSpares
        '
        Me.btnDelSpares.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelSpares.Location = New System.Drawing.Point(70, 0)
        Me.btnDelSpares.Name = "btnDelSpares"
        Me.btnDelSpares.Size = New System.Drawing.Size(70, 28)
        Me.btnDelSpares.TabIndex = 1
        Me.btnDelSpares.Text = "Delete"
        '
        'btnAddSpares
        '
        Me.btnAddSpares.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSpares.Location = New System.Drawing.Point(0, 0)
        Me.btnAddSpares.Name = "btnAddSpares"
        Me.btnAddSpares.Size = New System.Drawing.Size(70, 28)
        Me.btnAddSpares.TabIndex = 1
        Me.btnAddSpares.Text = "Add New"
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(763, 205)
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(763, 205)
        Me.UltraExpandableGroupBox3.TabIndex = 0
        Me.UltraExpandableGroupBox3.Text = "Serial List"
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraGridAddSerial)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraPanel1)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(757, 183)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraGridAddSerial
        '
        Me.UltraGridAddSerial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridAddSerial.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridAddSerial.Name = "UltraGridAddSerial"
        Me.UltraGridAddSerial.Size = New System.Drawing.Size(757, 155)
        Me.UltraGridAddSerial.TabIndex = 0
        Me.UltraGridAddSerial.Text = "Serial Nos."
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnDelSerial)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnAddSerial)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 155)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(757, 28)
        Me.UltraPanel1.TabIndex = 56
        '
        'btnDelSerial
        '
        Me.btnDelSerial.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelSerial.Location = New System.Drawing.Point(70, 0)
        Me.btnDelSerial.Name = "btnDelSerial"
        Me.btnDelSerial.Size = New System.Drawing.Size(70, 28)
        Me.btnDelSerial.TabIndex = 1
        Me.btnDelSerial.Text = "Delete"
        '
        'btnAddSerial
        '
        Me.btnAddSerial.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddSerial.Location = New System.Drawing.Point(0, 0)
        Me.btnAddSerial.Name = "btnAddSerial"
        Me.btnAddSerial.Size = New System.Drawing.Size(70, 28)
        Me.btnAddSerial.TabIndex = 0
        Me.btnAddSerial.Text = "Add New"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.arbit)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl7)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance5.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance5
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(767, 451)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.TabPage = Me.arbit
        UltraTab2.Text = "Penalty / Deduction"
        UltraTab4.TabPage = Me.UltraTabPageControl3
        UltraTab4.Text = "Documents"
        UltraTab5.TabPage = Me.UltraTabPageControl4
        UltraTab5.Text = "Payments"
        UltraTab6.TabPage = Me.UltraTabPageControl5
        UltraTab6.Text = "Forms"
        UltraTab7.TabPage = Me.UltraTabPageControl6
        UltraTab7.Text = "Account Assignment "
        UltraTab8.TabPage = Me.UltraTabPageControl7
        UltraTab8.Text = "Additional Assignment"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(763, 428)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 451)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(767, 36)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Appearance6.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance6
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(503, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance7
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(591, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 36)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance8
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(679, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 36)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'lblProjectCampusID
        '
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.lblProjectCampusID.Appearance = Appearance1
        Me.lblProjectCampusID.AutoSize = True
        Me.lblProjectCampusID.Location = New System.Drawing.Point(30, 194)
        Me.lblProjectCampusID.Name = "lblProjectCampusID"
        Me.lblProjectCampusID.Size = New System.Drawing.Size(62, 14)
        Me.lblProjectCampusID.TabIndex = 29
        Me.lblProjectCampusID.Text = "Project Site"
        '
        'cmb_ProjectCampusID
        '
        Me.cmb_ProjectCampusID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ProjectCampusID.Location = New System.Drawing.Point(95, 191)
        Me.cmb_ProjectCampusID.Name = "cmb_ProjectCampusID"
        Me.cmb_ProjectCampusID.Size = New System.Drawing.Size(240, 22)
        Me.cmb_ProjectCampusID.TabIndex = 28
        '
        'frmSalesInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Invoice"
        Me.ClientSize = New System.Drawing.Size(767, 487)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalesInvoice"
        Me.Text = "Invoice"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_campusid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_deliverycampusid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSO.ClientArea.ResumeLayout(False)
        Me.PanelSO.ResumeLayout(False)
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AmountTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InvoiceNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.arbit.ResumeLayout(False)
        Me.arbit.PerformLayout()
        CType(Me.txt_ChallanText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Deduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DeductText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CaseReject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CaseAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PenaltyAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CaseSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PenaltyNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGridPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel4.ClientArea.ResumeLayout(False)
        Me.UltraPanel4.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.UltraGridSpare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        CType(Me.UltraGridService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_ItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_ItemList.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UltraGridSerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.UltraGridAddSpares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.UltraGridAddSerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_ProjectCampusID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGridForms As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel4 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDelForms As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddForms As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_ChallanText As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_CustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtOrderDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGridSpare As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UEGB_ItemList As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGridSerial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGridAddSpares As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDelSpares As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSpares As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGridAddSerial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnDelSerial As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSerial As Infragistics.Win.Misc.UltraButton
    Friend WithEvents PanelSO As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnRemoveSO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSelectSO As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblSalesOrder As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_deliverycampusid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_campusid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGridService As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblProjectCampusID As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ProjectCampusID As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class

