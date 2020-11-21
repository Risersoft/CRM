<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmCopyTE
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myVueRat.SetGrid(Me.UltraGridRat)
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents cmb_CustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_EnqDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraGridRat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRef2 As System.Windows.Forms.Label
    Friend WithEvents text_NewEnqRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents date_NewEnqDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents comb_NewCustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_EnqRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOk = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_EnqType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_EnqRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_EnqDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comb_NewEnqType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_NewEnqRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_NewEnqDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comb_NewCustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraGridRat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_EnqType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EnqRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_EnqDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.comb_NewEnqType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text_NewEnqRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_NewEnqDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comb_NewCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 374)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnCancel
        '
        Appearance13.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance13
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(464, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 48)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Appearance14.FontData.BoldAsString = "True"
        Me.btnOk.Appearance = Appearance14
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(552, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 48)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmb_EnqType)
        Me.Panel1.Controls.Add(Me.txt_EnqRefNum)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dt_EnqDate)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.lblNum)
        Me.Panel1.Controls.Add(Me.cmb_CustomerID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Enabled = False
        Me.Panel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 118)
        Me.Panel1.TabIndex = 0
        '
        'cmb_EnqType
        '
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb_EnqType.DisplayLayout.Appearance = Appearance21
        Me.cmb_EnqType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb_EnqType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance22.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_EnqType.DisplayLayout.GroupByBox.Appearance = Appearance22
        Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_EnqType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance23
        Me.cmb_EnqType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance24.BackColor2 = System.Drawing.SystemColors.Control
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb_EnqType.DisplayLayout.GroupByBox.PromptAppearance = Appearance24
        Me.cmb_EnqType.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb_EnqType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb_EnqType.DisplayLayout.Override.ActiveCellAppearance = Appearance25
        Appearance26.BackColor = System.Drawing.SystemColors.Highlight
        Appearance26.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb_EnqType.DisplayLayout.Override.ActiveRowAppearance = Appearance26
        Me.cmb_EnqType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb_EnqType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_EnqType.DisplayLayout.Override.CardAreaAppearance = Appearance27
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Appearance28.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb_EnqType.DisplayLayout.Override.CellAppearance = Appearance28
        Me.cmb_EnqType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb_EnqType.DisplayLayout.Override.CellPadding = 0
        Appearance29.BackColor = System.Drawing.SystemColors.Control
        Appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance29.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb_EnqType.DisplayLayout.Override.GroupByRowAppearance = Appearance29
        Appearance30.TextHAlignAsString = "Left"
        Me.cmb_EnqType.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.cmb_EnqType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb_EnqType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.Color.Silver
        Me.cmb_EnqType.DisplayLayout.Override.RowAppearance = Appearance31
        Me.cmb_EnqType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb_EnqType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance32
        Me.cmb_EnqType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb_EnqType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb_EnqType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb_EnqType.Location = New System.Drawing.Point(121, 62)
        Me.cmb_EnqType.Name = "cmb_EnqType"
        Me.cmb_EnqType.Size = New System.Drawing.Size(167, 22)
        Me.cmb_EnqType.TabIndex = 4
        '
        'txt_EnqRefNum
        '
        Appearance15.FontData.Name = "Arial"
        Me.txt_EnqRefNum.Appearance = Appearance15
        Me.txt_EnqRefNum.Location = New System.Drawing.Point(386, 61)
        Me.txt_EnqRefNum.Name = "txt_EnqRefNum"
        Me.txt_EnqRefNum.Size = New System.Drawing.Size(247, 21)
        Me.txt_EnqRefNum.TabIndex = 6
        Me.txt_EnqRefNum.Text = "UltraTextEditor1"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enquiry Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "OLD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(72, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Dated"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_EnqDate
        '
        Appearance16.FontData.BoldAsString = "False"
        Appearance16.FontData.ItalicAsString = "False"
        Appearance16.FontData.Name = "Arial"
        Appearance16.FontData.SizeInPoints = 8.25!
        Appearance16.FontData.StrikeoutAsString = "False"
        Appearance16.FontData.UnderlineAsString = "False"
        Me.dt_EnqDate.Appearance = Appearance16
        Me.dt_EnqDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_EnqDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_EnqDate.Location = New System.Drawing.Point(120, 90)
        Me.dt_EnqDate.Name = "dt_EnqDate"
        Me.dt_EnqDate.NullText = "Not Defined"
        Me.dt_EnqDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_EnqDate.TabIndex = 8
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(287, 61)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(93, 21)
        Me.lblRef.TabIndex = 5
        Me.lblRef.Text = "Enquiry Ref. No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(82, 33)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(96, 16)
        Me.lblNum.TabIndex = 1
        Me.lblNum.Text = "Customer"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Appearance17.FontData.Name = "Arial"
        Me.cmb_CustomerID.Appearance = Appearance17
        Me.cmb_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_CustomerID.Location = New System.Drawing.Point(186, 33)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_CustomerID.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.comb_NewEnqType)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.text_NewEnqRefNum)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.date_NewEnqDate)
        Me.Panel2.Controls.Add(Me.lblRef2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.comb_NewCustomerID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 118)
        Me.Panel2.TabIndex = 1
        '
        'comb_NewEnqType
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.comb_NewEnqType.DisplayLayout.Appearance = Appearance1
        Me.comb_NewEnqType.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.comb_NewEnqType.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.comb_NewEnqType.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.comb_NewEnqType.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.comb_NewEnqType.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.comb_NewEnqType.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.comb_NewEnqType.DisplayLayout.MaxColScrollRegions = 1
        Me.comb_NewEnqType.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.comb_NewEnqType.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.comb_NewEnqType.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.comb_NewEnqType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.comb_NewEnqType.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.comb_NewEnqType.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.comb_NewEnqType.DisplayLayout.Override.CellAppearance = Appearance8
        Me.comb_NewEnqType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.comb_NewEnqType.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.comb_NewEnqType.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.comb_NewEnqType.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.comb_NewEnqType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.comb_NewEnqType.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.comb_NewEnqType.DisplayLayout.Override.RowAppearance = Appearance11
        Me.comb_NewEnqType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.comb_NewEnqType.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.comb_NewEnqType.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.comb_NewEnqType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.comb_NewEnqType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.comb_NewEnqType.Location = New System.Drawing.Point(111, 56)
        Me.comb_NewEnqType.Name = "comb_NewEnqType"
        Me.comb_NewEnqType.Size = New System.Drawing.Size(167, 22)
        Me.comb_NewEnqType.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(7, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Enquiry Type"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NEW"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_NewEnqRefNum
        '
        Appearance18.FontData.BoldAsString = "False"
        Appearance18.FontData.ItalicAsString = "False"
        Appearance18.FontData.Name = "Arial"
        Appearance18.FontData.SizeInPoints = 8.25!
        Appearance18.FontData.StrikeoutAsString = "False"
        Appearance18.FontData.UnderlineAsString = "False"
        Me.text_NewEnqRefNum.Appearance = Appearance18
        Me.text_NewEnqRefNum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_NewEnqRefNum.Location = New System.Drawing.Point(377, 56)
        Me.text_NewEnqRefNum.Name = "text_NewEnqRefNum"
        Me.text_NewEnqRefNum.Size = New System.Drawing.Size(239, 21)
        Me.text_NewEnqRefNum.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dated"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'date_NewEnqDate
        '
        Appearance19.FontData.BoldAsString = "False"
        Appearance19.FontData.ItalicAsString = "False"
        Appearance19.FontData.Name = "Arial"
        Appearance19.FontData.SizeInPoints = 8.25!
        Appearance19.FontData.StrikeoutAsString = "False"
        Appearance19.FontData.UnderlineAsString = "False"
        Me.date_NewEnqDate.Appearance = Appearance19
        Me.date_NewEnqDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_NewEnqDate.FormatString = "dddd dd MMM yyyy"
        Me.date_NewEnqDate.Location = New System.Drawing.Point(111, 87)
        Me.date_NewEnqDate.Name = "date_NewEnqDate"
        Me.date_NewEnqDate.NullText = "Not Defined"
        Me.date_NewEnqDate.Size = New System.Drawing.Size(168, 21)
        Me.date_NewEnqDate.TabIndex = 8
        '
        'lblRef2
        '
        Me.lblRef2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef2.Location = New System.Drawing.Point(287, 56)
        Me.lblRef2.Name = "lblRef2"
        Me.lblRef2.Size = New System.Drawing.Size(93, 22)
        Me.lblRef2.TabIndex = 5
        Me.lblRef2.Text = "Enquiry Ref. No."
        Me.lblRef2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(92, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'comb_NewCustomerID
        '
        Appearance20.FontData.Name = "Arial"
        Me.comb_NewCustomerID.Appearance = Appearance20
        Me.comb_NewCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_NewCustomerID.Location = New System.Drawing.Point(196, 27)
        Me.comb_NewCustomerID.Name = "comb_NewCustomerID"
        Me.comb_NewCustomerID.Size = New System.Drawing.Size(360, 22)
        Me.comb_NewCustomerID.TabIndex = 2
        '
        'UltraGridRat
        '
        Me.UltraGridRat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRat.Location = New System.Drawing.Point(0, 236)
        Me.UltraGridRat.Name = "UltraGridRat"
        Me.UltraGridRat.Size = New System.Drawing.Size(640, 138)
        Me.UltraGridRat.TabIndex = 2
        Me.UltraGridRat.Text = "Ratings"
        '
        'frmCopyTE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Copy Enquiry"
        Me.ClientSize = New System.Drawing.Size(640, 422)
        Me.Controls.Add(Me.UltraGridRat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCopyTE"
        Me.Text = "Copy Enquiry"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_EnqType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EnqRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_EnqDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.comb_NewEnqType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text_NewEnqRefNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_NewEnqDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comb_NewCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents comb_NewEnqType As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_EnqType As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class

