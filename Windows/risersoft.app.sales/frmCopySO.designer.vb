<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmCopySO
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        myViewWO.SetGrid(Me.UltraGridRat)
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UltraGridRat As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents comb_NewCustomerID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOk As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOk = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_LoINum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_PODate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt_LoiDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.cmb_CustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_NewLoINum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_NewPODate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_NewPONum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_NewLoiDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comb_NewCustomerID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraGridRat = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_LoINum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_PODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_LoiDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_NewLoINum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_NewPODate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NewPONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_NewLoiDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comb_NewCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOk)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 386)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 36)
        Me.Panel4.TabIndex = 3
        '
        'btnCancel
        '
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(464, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 36)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOk.Appearance = Appearance2
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Location = New System.Drawing.Point(552, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 36)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_LoINum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dt_PODate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_PONum)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dt_LoiDate)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.Label5)
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
        'txt_LoINum
        '
        Me.txt_LoINum.Location = New System.Drawing.Point(114, 61)
        Me.txt_LoINum.Name = "txt_LoINum"
        Me.txt_LoINum.Size = New System.Drawing.Size(256, 21)
        Me.txt_LoINum.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(394, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Dated"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_PODate
        '
        Me.dt_PODate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_PODate.FormatString = "dddd dd MMM yyyy"
        Me.dt_PODate.Location = New System.Drawing.Point(442, 90)
        Me.dt_PODate.Name = "dt_PODate"
        Me.dt_PODate.NullText = "Not Defined"
        Me.dt_PODate.Size = New System.Drawing.Size(168, 21)
        Me.dt_PODate.TabIndex = 16
        Me.dt_PODate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Order No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PONum
        '
        Me.txt_PONum.Location = New System.Drawing.Point(114, 90)
        Me.txt_PONum.Name = "txt_PONum"
        Me.txt_PONum.Size = New System.Drawing.Size(256, 21)
        Me.txt_PONum.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(394, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Dated"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_LoiDate
        '
        Me.dt_LoiDate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_LoiDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_LoiDate.Location = New System.Drawing.Point(442, 61)
        Me.dt_LoiDate.Name = "dt_LoiDate"
        Me.dt_LoiDate.NullText = "Not Defined"
        Me.dt_LoiDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_LoiDate.TabIndex = 12
        Me.dt_LoiDate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(10, 61)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(96, 16)
        Me.lblRef.TabIndex = 9
        Me.lblRef.Text = "LoI No."
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(277, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "OLD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(75, 33)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(96, 16)
        Me.lblNum.TabIndex = 1
        Me.lblNum.Text = "Customer"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_CustomerID
        '
        Appearance3.FontData.Name = "Arial"
        Me.cmb_CustomerID.Appearance = Appearance3
        Me.cmb_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_CustomerID.Location = New System.Drawing.Point(179, 31)
        Me.cmb_CustomerID.Name = "cmb_CustomerID"
        Me.cmb_CustomerID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_CustomerID.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_NewLoINum)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dt_NewPODate)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_NewPONum)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.dt_NewLoiDate)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.comb_NewCustomerID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 118)
        Me.Panel2.TabIndex = 1
        '
        'txt_NewLoINum
        '
        Me.txt_NewLoINum.Location = New System.Drawing.Point(114, 59)
        Me.txt_NewLoINum.Name = "txt_NewLoINum"
        Me.txt_NewLoINum.Size = New System.Drawing.Size(256, 21)
        Me.txt_NewLoINum.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(394, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Dated"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_NewPODate
        '
        Me.dt_NewPODate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_NewPODate.FormatString = "dddd dd MMM yyyy"
        Me.dt_NewPODate.Location = New System.Drawing.Point(442, 88)
        Me.dt_NewPODate.Name = "dt_NewPODate"
        Me.dt_NewPODate.NullText = "Not Defined"
        Me.dt_NewPODate.Size = New System.Drawing.Size(168, 21)
        Me.dt_NewPODate.TabIndex = 16
        Me.dt_NewPODate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(10, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Order No."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NewPONum
        '
        Me.txt_NewPONum.Location = New System.Drawing.Point(114, 88)
        Me.txt_NewPONum.Name = "txt_NewPONum"
        Me.txt_NewPONum.Size = New System.Drawing.Size(256, 21)
        Me.txt_NewPONum.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(394, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Dated"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_NewLoiDate
        '
        Me.dt_NewLoiDate.DateTime = New Date(2014, 10, 19, 0, 0, 0, 0)
        Me.dt_NewLoiDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_NewLoiDate.Location = New System.Drawing.Point(442, 59)
        Me.dt_NewLoiDate.Name = "dt_NewLoiDate"
        Me.dt_NewLoiDate.NullText = "Not Defined"
        Me.dt_NewLoiDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_NewLoiDate.TabIndex = 12
        Me.dt_NewLoiDate.Value = New Date(2014, 10, 19, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(10, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "LoI No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(277, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NEW"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(75, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'comb_NewCustomerID
        '
        Appearance4.FontData.Name = "Arial"
        Me.comb_NewCustomerID.Appearance = Appearance4
        Me.comb_NewCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_NewCustomerID.Location = New System.Drawing.Point(179, 28)
        Me.comb_NewCustomerID.Name = "comb_NewCustomerID"
        Me.comb_NewCustomerID.Size = New System.Drawing.Size(360, 22)
        Me.comb_NewCustomerID.TabIndex = 2
        '
        'UltraGridRat
        '
        Me.UltraGridRat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridRat.Location = New System.Drawing.Point(0, 236)
        Me.UltraGridRat.Name = "UltraGridRat"
        Me.UltraGridRat.Size = New System.Drawing.Size(640, 150)
        Me.UltraGridRat.TabIndex = 2
        Me.UltraGridRat.Text = "Ratings"
        '
        'frmCopySO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Copy Sales Order"
        Me.ClientSize = New System.Drawing.Size(640, 422)
        Me.Controls.Add(Me.UltraGridRat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCopySO"
        Me.Text = "Copy Sales Order"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_LoINum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_PODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_LoiDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_CustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_NewLoINum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_NewPODate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NewPONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_NewLoiDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comb_NewCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridRat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_LoINum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents dt_PODate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_PONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents dt_LoiDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRef As Windows.Forms.Label
    Friend WithEvents txt_NewLoINum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents dt_NewPODate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txt_NewPONum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents dt_NewLoiDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label10 As Windows.Forms.Label

#End Region
End Class

