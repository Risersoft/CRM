<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmInspec
    Inherits frmMax
    
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myView.SetGrid(Me.UltraGrid1)
        myVueAttEmp.SetGrid(Me.UltraGrid3)
        myVueInspBy.SetGrid(Me.UltraGrid2)
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
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_OfferDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_SalesOrderID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Purpose As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_inspectype As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_DaysReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_OfferNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_CallDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_EnCl As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_InspecDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_ReportDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_UptoDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_Tests As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Actions As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents arbit As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_CampusID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents UltraGridDoc As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnEditDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelEmp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddEmp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelPers As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddPers As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_SalesOrderID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_EnCl = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_CallDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_OfferNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Purpose = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_inspectype = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_OfferDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_DaysReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.arbit = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.btnDelEmp = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddEmp = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelPers = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddPers = New Infragistics.Win.Misc.UltraButton()
        Me.txt_Actions = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Tests = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_CampusID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_UptoDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_InspecDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dt_ReportDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
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
        CType(Me.txt_EnCl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CallDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OfferNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_inspectype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_OfferDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DaysReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.arbit.SuspendLayout()
        CType(Me.txt_Actions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Tests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CampusID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_UptoDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InspecDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ReportDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
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
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(668, 395)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(368, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(300, 395)
        Me.UltraGrid1.TabIndex = 1
        Me.UltraGrid1.Text = "Serial Nos."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_SalesOrderID)
        Me.Panel1.Controls.Add(Me.txt_EnCl)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dt_CallDate)
        Me.Panel1.Controls.Add(Me.txt_OfferNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UltraTextEditor2)
        Me.Panel1.Controls.Add(Me.txt_Purpose)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmb_inspectype)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dt_OfferDate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_DaysReq)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.cmb_StatusNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 395)
        Me.Panel1.TabIndex = 0
        '
        'txt_SalesOrderID
        '
        Me.txt_SalesOrderID.Location = New System.Drawing.Point(96, 344)
        Me.txt_SalesOrderID.Name = "txt_SalesOrderID"
        Me.txt_SalesOrderID.Size = New System.Drawing.Size(64, 21)
        Me.txt_SalesOrderID.TabIndex = 16
        Me.txt_SalesOrderID.Text = "salesorderid"
        Me.txt_SalesOrderID.Visible = False
        '
        'txt_EnCl
        '
        Me.txt_EnCl.Location = New System.Drawing.Point(96, 272)
        Me.txt_EnCl.Multiline = True
        Me.txt_EnCl.Name = "txt_EnCl"
        Me.txt_EnCl.Size = New System.Drawing.Size(264, 64)
        Me.txt_EnCl.TabIndex = 15
        Me.txt_EnCl.Text = "UltraTextEditor3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Encl."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Call Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CallDate
        '
        Me.dt_CallDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CallDate.Location = New System.Drawing.Point(96, 160)
        Me.dt_CallDate.Name = "dt_CallDate"
        Me.dt_CallDate.NullText = "Not Defined"
        Me.dt_CallDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_CallDate.TabIndex = 9
        '
        'txt_OfferNum
        '
        Me.txt_OfferNum.Location = New System.Drawing.Point(96, 96)
        Me.txt_OfferNum.Name = "txt_OfferNum"
        Me.txt_OfferNum.Size = New System.Drawing.Size(256, 21)
        Me.txt_OfferNum.TabIndex = 5
        Me.txt_OfferNum.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Offer No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.Location = New System.Drawing.Point(96, 96)
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(256, 21)
        Me.UltraTextEditor2.TabIndex = 65
        Me.UltraTextEditor2.Text = "UltraTextEditor1"
        '
        'txt_Purpose
        '
        Me.txt_Purpose.Location = New System.Drawing.Point(96, 64)
        Me.txt_Purpose.Name = "txt_Purpose"
        Me.txt_Purpose.Size = New System.Drawing.Size(256, 21)
        Me.txt_Purpose.TabIndex = 3
        Me.txt_Purpose.Text = "UltraTextEditor1"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 28)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Inspection Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_inspectype
        '
        Me.cmb_inspectype.Location = New System.Drawing.Point(96, 24)
        Me.cmb_inspectype.Name = "cmb_inspectype"
        Me.cmb_inspectype.Size = New System.Drawing.Size(168, 22)
        Me.cmb_inspectype.TabIndex = 1
        Me.cmb_inspectype.Text = "UltraCombo3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(32, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Offer Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_OfferDate
        '
        Me.dt_OfferDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_OfferDate.Location = New System.Drawing.Point(96, 128)
        Me.dt_OfferDate.Name = "dt_OfferDate"
        Me.dt_OfferDate.NullText = "Not Defined"
        Me.dt_OfferDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_OfferDate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(24, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "No. of Days Required"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DaysReq
        '
        Me.txt_DaysReq.Location = New System.Drawing.Point(96, 192)
        Me.txt_DaysReq.Name = "txt_DaysReq"
        Me.txt_DaysReq.Size = New System.Drawing.Size(64, 21)
        Me.txt_DaysReq.TabIndex = 11
        Me.txt_DaysReq.Text = "UltraTextEditor2"
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(8, 64)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(80, 16)
        Me.lblRef.TabIndex = 2
        Me.lblRef.Text = "Purpose"
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(8, 240)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(80, 16)
        Me.lblNum.TabIndex = 12
        Me.lblNum.Text = "Status"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(96, 240)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(264, 22)
        Me.cmb_StatusNum.TabIndex = 13
        Me.cmb_StatusNum.Text = "UltraCombo3"
        '
        'arbit
        '
        Me.arbit.Controls.Add(Me.btnDelEmp)
        Me.arbit.Controls.Add(Me.btnAddEmp)
        Me.arbit.Controls.Add(Me.btnDelPers)
        Me.arbit.Controls.Add(Me.btnAddPers)
        Me.arbit.Controls.Add(Me.txt_Actions)
        Me.arbit.Controls.Add(Me.Label12)
        Me.arbit.Controls.Add(Me.txt_Tests)
        Me.arbit.Controls.Add(Me.Label11)
        Me.arbit.Controls.Add(Me.Label10)
        Me.arbit.Controls.Add(Me.cmb_CampusID)
        Me.arbit.Controls.Add(Me.Label9)
        Me.arbit.Controls.Add(Me.dt_UptoDate)
        Me.arbit.Controls.Add(Me.Label4)
        Me.arbit.Controls.Add(Me.dt_InspecDate)
        Me.arbit.Controls.Add(Me.Label5)
        Me.arbit.Controls.Add(Me.dt_ReportDate)
        Me.arbit.Controls.Add(Me.UltraGrid3)
        Me.arbit.Controls.Add(Me.UltraGrid2)
        Me.arbit.Location = New System.Drawing.Point(1, 23)
        Me.arbit.Name = "arbit"
        Me.arbit.Size = New System.Drawing.Size(668, 395)
        '
        'btnDelEmp
        '
        Me.btnDelEmp.Location = New System.Drawing.Point(96, 312)
        Me.btnDelEmp.Name = "btnDelEmp"
        Me.btnDelEmp.Size = New System.Drawing.Size(72, 24)
        Me.btnDelEmp.TabIndex = 15
        Me.btnDelEmp.Text = "Delete"
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Location = New System.Drawing.Point(8, 312)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(72, 24)
        Me.btnAddEmp.TabIndex = 14
        Me.btnAddEmp.Text = "Add"
        '
        'btnDelPers
        '
        Me.btnDelPers.Location = New System.Drawing.Point(584, 152)
        Me.btnDelPers.Name = "btnDelPers"
        Me.btnDelPers.Size = New System.Drawing.Size(72, 24)
        Me.btnDelPers.TabIndex = 10
        Me.btnDelPers.Text = "Delete"
        '
        'btnAddPers
        '
        Me.btnAddPers.Location = New System.Drawing.Point(584, 120)
        Me.btnAddPers.Name = "btnAddPers"
        Me.btnAddPers.Size = New System.Drawing.Size(72, 24)
        Me.btnAddPers.TabIndex = 9
        Me.btnAddPers.Text = "Add"
        '
        'txt_Actions
        '
        Me.txt_Actions.AcceptsReturn = True
        Me.txt_Actions.Location = New System.Drawing.Point(112, 352)
        Me.txt_Actions.Multiline = True
        Me.txt_Actions.Name = "txt_Actions"
        Me.txt_Actions.Size = New System.Drawing.Size(512, 40)
        Me.txt_Actions.TabIndex = 17
        Me.txt_Actions.Text = "UltraTextEditor5"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(8, 352)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 40)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Actions to be taken, if any"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_Tests
        '
        Me.txt_Tests.AcceptsReturn = True
        Me.txt_Tests.Location = New System.Drawing.Point(360, 240)
        Me.txt_Tests.Multiline = True
        Me.txt_Tests.Name = "txt_Tests"
        Me.txt_Tests.Size = New System.Drawing.Size(264, 64)
        Me.txt_Tests.TabIndex = 13
        Me.txt_Tests.Text = "UltraTextEditor4"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(360, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Tests Carried Out"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(282, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Campus"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CampusID
        '
        Me.cmb_CampusID.Location = New System.Drawing.Point(331, 51)
        Me.cmb_CampusID.Name = "cmb_CampusID"
        Me.cmb_CampusID.Size = New System.Drawing.Size(324, 22)
        Me.cmb_CampusID.TabIndex = 3
        Me.cmb_CampusID.Text = "UltraCombo3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(300, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "upto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_UptoDate
        '
        Me.dt_UptoDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_UptoDate.Location = New System.Drawing.Point(331, 19)
        Me.dt_UptoDate.Name = "dt_UptoDate"
        Me.dt_UptoDate.NullText = "Not Defined"
        Me.dt_UptoDate.Size = New System.Drawing.Size(124, 21)
        Me.dt_UptoDate.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Inspection Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_InspecDate
        '
        Me.dt_InspecDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_InspecDate.Location = New System.Drawing.Point(98, 19)
        Me.dt_InspecDate.Name = "dt_InspecDate"
        Me.dt_InspecDate.NullText = "Not Defined"
        Me.dt_InspecDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_InspecDate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(31, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Report Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ReportDate
        '
        Me.dt_ReportDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ReportDate.Location = New System.Drawing.Point(98, 52)
        Me.dt_ReportDate.Name = "dt_ReportDate"
        Me.dt_ReportDate.NullText = "Not Defined"
        Me.dt_ReportDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_ReportDate.TabIndex = 1
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Location = New System.Drawing.Point(8, 224)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(336, 80)
        Me.UltraGrid3.TabIndex = 11
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Location = New System.Drawing.Point(8, 88)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(568, 120)
        Me.UltraGrid2.TabIndex = 8
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(668, 395)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraGridDoc)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 395)
        Me.Panel2.TabIndex = 8
        '
        'UltraGridDoc
        '
        Me.UltraGridDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridDoc.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridDoc.Name = "UltraGridDoc"
        Me.UltraGridDoc.Size = New System.Drawing.Size(668, 347)
        Me.UltraGridDoc.TabIndex = 0
        Me.UltraGridDoc.Text = "Delivery Schedule"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditDoc)
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 347)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(668, 48)
        Me.Panel3.TabIndex = 1
        '
        'btnEditDoc
        '
        Me.btnEditDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDoc.Location = New System.Drawing.Point(496, 16)
        Me.btnEditDoc.Name = "btnEditDoc"
        Me.btnEditDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnEditDoc.TabIndex = 1
        Me.btnEditDoc.Text = "Edit"
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Location = New System.Drawing.Point(400, 16)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Location = New System.Drawing.Point(584, 16)
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
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance1
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(672, 421)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Basic"
        UltraTab2.TabPage = Me.arbit
        UltraTab2.Text = "Info"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Documents"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(668, 395)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 421)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(672, 48)
        Me.Panel4.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Location = New System.Drawing.Point(376, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Location = New System.Drawing.Point(472, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Location = New System.Drawing.Point(568, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'frmInspec
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Inspection"
        Me.ClientSize = New System.Drawing.Size(672, 469)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmInspec"
        Me.Text = "Inspection"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_SalesOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EnCl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CallDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OfferNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_inspectype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_OfferDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DaysReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.arbit.ResumeLayout(False)
        Me.arbit.PerformLayout()
        CType(Me.txt_Actions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Tests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CampusID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_UptoDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InspecDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ReportDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraGridDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class

