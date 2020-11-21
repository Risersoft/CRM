<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmCTEorder
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myView.SetGrid(Me.UltraGridRat)
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
    Friend WithEvents txt_EnqRefNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_EnqDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraGridRat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents comb_NewCustID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents text_PONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents date_podate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblNoRef As System.Windows.Forms.Label
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOk = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmb_EnqType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_EnqRefNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_EnqDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_PONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_podate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblNoRef = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comb_NewCustID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraGridRat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_EnqType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EnqRefNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_EnqDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.text_PONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date_podate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comb_NewCustID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 389)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(432, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOk.Appearance = Appearance2
        Me.btnOk.Location = New System.Drawing.Point(528, 8)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 32)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.cmb_EnqType)
        Me.Panel1.Controls.Add(Me.txt_EnqRefNum)
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
        Me.Panel1.Size = New System.Drawing.Size(640, 96)
        Me.Panel1.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label33.Location = New System.Drawing.Point(44, 5)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(76, 24)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Enquiry Type"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EnqType
        '
        Me.cmb_EnqType.Location = New System.Drawing.Point(122, 6)
        Me.cmb_EnqType.Name = "cmb_EnqType"
        Me.cmb_EnqType.Size = New System.Drawing.Size(192, 22)
        Me.cmb_EnqType.TabIndex = 1
        Me.cmb_EnqType.Text = "UltraCombo3"
        '
        'txt_EnqRefNum
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.ItalicAsString = "False"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.FontData.StrikeoutAsString = "False"
        Appearance3.FontData.UnderlineAsString = "False"
        Me.txt_EnqRefNum.Appearance = Appearance3
        Me.txt_EnqRefNum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EnqRefNum.Location = New System.Drawing.Point(124, 62)
        Me.txt_EnqRefNum.Name = "txt_EnqRefNum"
        Me.txt_EnqRefNum.Size = New System.Drawing.Size(451, 21)
        Me.txt_EnqRefNum.TabIndex = 7
        Me.txt_EnqRefNum.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(359, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dated"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_EnqDate
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.dt_EnqDate.Appearance = Appearance4
        Me.dt_EnqDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_EnqDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_EnqDate.Location = New System.Drawing.Point(407, 8)
        Me.dt_EnqDate.Name = "dt_EnqDate"
        Me.dt_EnqDate.NullText = "Not Defined"
        Me.dt_EnqDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_EnqDate.TabIndex = 3
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(20, 62)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(96, 16)
        Me.lblRef.TabIndex = 6
        Me.lblRef.Text = "Enquiry Ref. No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(20, 34)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(96, 16)
        Me.lblNum.TabIndex = 4
        Me.lblNum.Text = "Customer"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Appearance5.FontData.Name = "Arial"
        Me.cmb_CustomerID.Appearance = Appearance5
        Me.cmb_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_CustomerID.Location = New System.Drawing.Point(124, 34)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.Size = New System.Drawing.Size(451, 22)
        Me.cmb_CustomerID.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.text_PONum)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.date_podate)
        Me.Panel2.Controls.Add(Me.lblNoRef)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.comb_NewCustID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 96)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(280, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "O R D E R"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_PONum
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.text_PONum.Appearance = Appearance6
        Me.text_PONum.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_PONum.Location = New System.Drawing.Point(124, 62)
        Me.text_PONum.Name = "text_PONum"
        Me.text_PONum.Size = New System.Drawing.Size(256, 21)
        Me.text_PONum.TabIndex = 4
        Me.text_PONum.Text = "UltraTextEditor1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(404, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dated"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'date_podate
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.date_podate.Appearance = Appearance7
        Me.date_podate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_podate.FormatString = "dddd dd MMM yyyy"
        Me.date_podate.Location = New System.Drawing.Point(452, 62)
        Me.date_podate.Name = "date_podate"
        Me.date_podate.NullText = "Not Defined"
        Me.date_podate.Size = New System.Drawing.Size(168, 21)
        Me.date_podate.TabIndex = 6
        '
        'lblNoRef
        '
        Me.lblNoRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNoRef.Location = New System.Drawing.Point(20, 62)
        Me.lblNoRef.Name = "lblNoRef"
        Me.lblNoRef.Size = New System.Drawing.Size(96, 16)
        Me.lblNoRef.TabIndex = 3
        Me.lblNoRef.Text = "PO No."
        Me.lblNoRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(20, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'comb_NewCustID
        '
        Appearance8.FontData.Name = "Arial"
        Me.comb_NewCustID.Appearance = Appearance8
        Me.comb_NewCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_NewCustID.Location = New System.Drawing.Point(124, 32)
        Me.comb_NewCustID.Name = "comb_NewCustID"
        Me.comb_NewCustID.Size = New System.Drawing.Size(451, 22)
        Me.comb_NewCustID.TabIndex = 2
        '
        'UltraGridRat
        '
        Me.UltraGridRat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRat.Location = New System.Drawing.Point(0, 192)
        Me.UltraGridRat.Name = "UltraGridRat"
        Me.UltraGridRat.Size = New System.Drawing.Size(640, 197)
        Me.UltraGridRat.TabIndex = 2
        Me.UltraGridRat.Text = "Ratings"
        '
        'frmCTEorder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Convert Enquiry to Order"
        Me.ClientSize = New System.Drawing.Size(640, 437)
        Me.Controls.Add(Me.UltraGridRat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCTEorder"
        Me.Text = "Convert Enquiry to Order"
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
        CType(Me.text_PONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date_podate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comb_NewCustID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmb_EnqType As Infragistics.Win.UltraWinGrid.UltraCombo

#End Region
End Class

