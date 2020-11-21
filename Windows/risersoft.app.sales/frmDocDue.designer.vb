Imports Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmDocDue
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cmb_docnameID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_DocNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_DocDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_NumCopies As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_DocDetails As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_CompletionDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Prefix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_PostFix As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_CompletionLetter As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_docnameID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_DocNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_DocDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_NumCopies = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_DocDetails = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_CompletionDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Prefix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_PostFix = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_CompletionLetter = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_docnameID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DocNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DocDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DocDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CompletionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_Prefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PostFix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CompletionLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(40, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Document"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_docnameID
        '
        Me.cmb_docnameID.DropDownWidth = 500
        Me.cmb_docnameID.Location = New System.Drawing.Point(104, 48)
        Me.cmb_docnameID.Name = "cmb_docnameID"
        Me.cmb_docnameID.Size = New System.Drawing.Size(264, 22)
        Me.cmb_docnameID.TabIndex = 3
        Me.cmb_docnameID.Text = "UltraCombo3"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(40, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Location = New System.Drawing.Point(104, 240)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(256, 22)
        Me.cmb_StatusNum.TabIndex = 15
        Me.cmb_StatusNum.Text = "UltraCombo3"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(16, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Document No."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DocNumber
        '
        Me.txt_DocNumber.AcceptsReturn = True
        Me.txt_DocNumber.Location = New System.Drawing.Point(104, 112)
        Me.txt_DocNumber.Multiline = True
        Me.txt_DocNumber.Name = "txt_DocNumber"
        Me.txt_DocNumber.Size = New System.Drawing.Size(272, 24)
        Me.txt_DocNumber.TabIndex = 7
        Me.txt_DocNumber.Text = "UltraTextEditor3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Document Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_DocDate
        '
        Me.dt_DocDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_DocDate.Location = New System.Drawing.Point(104, 144)
        Me.dt_DocDate.Name = "dt_DocDate"
        Me.dt_DocDate.NullText = "Not Defined"
        Me.dt_DocDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_DocDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(16, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. of Copies"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_NumCopies
        '
        Me.txt_NumCopies.AcceptsReturn = True
        Me.txt_NumCopies.Location = New System.Drawing.Point(104, 176)
        Me.txt_NumCopies.Multiline = True
        Me.txt_NumCopies.Name = "txt_NumCopies"
        Me.txt_NumCopies.Size = New System.Drawing.Size(272, 24)
        Me.txt_NumCopies.TabIndex = 11
        Me.txt_NumCopies.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(32, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Document Details"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_DocDetails
        '
        Me.txt_DocDetails.AcceptsReturn = True
        Me.txt_DocDetails.Location = New System.Drawing.Point(104, 208)
        Me.txt_DocDetails.Multiline = True
        Me.txt_DocDetails.Name = "txt_DocDetails"
        Me.txt_DocDetails.Size = New System.Drawing.Size(272, 24)
        Me.txt_DocDetails.TabIndex = 13
        Me.txt_DocDetails.Text = "UltraTextEditor3"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(24, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Completion Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CompletionDate
        '
        Me.dt_CompletionDate.FormatString = "dddd dd MMM yyyy"
        Me.dt_CompletionDate.Location = New System.Drawing.Point(104, 304)
        Me.dt_CompletionDate.Name = "dt_CompletionDate"
        Me.dt_CompletionDate.NullText = "Not Defined"
        Me.dt_CompletionDate.Size = New System.Drawing.Size(168, 21)
        Me.dt_CompletionDate.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 397)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(384, 48)
        Me.Panel4.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance1
        Me.btnCancel.Location = New System.Drawing.Point(176, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance2
        Me.btnOK.Location = New System.Drawing.Point(272, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(40, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Prefix"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Prefix
        '
        Me.txt_Prefix.AcceptsReturn = True
        Me.txt_Prefix.Location = New System.Drawing.Point(104, 16)
        Me.txt_Prefix.Multiline = True
        Me.txt_Prefix.Name = "txt_Prefix"
        Me.txt_Prefix.Size = New System.Drawing.Size(272, 24)
        Me.txt_Prefix.TabIndex = 1
        Me.txt_Prefix.Text = "UltraTextEditor3"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PostFix"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PostFix
        '
        Me.txt_PostFix.AcceptsReturn = True
        Me.txt_PostFix.Location = New System.Drawing.Point(104, 80)
        Me.txt_PostFix.Multiline = True
        Me.txt_PostFix.Name = "txt_PostFix"
        Me.txt_PostFix.Size = New System.Drawing.Size(272, 24)
        Me.txt_PostFix.TabIndex = 5
        Me.txt_PostFix.Text = "UltraTextEditor3"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(16, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Completion Letter"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_CompletionLetter
        '
        Me.txt_CompletionLetter.AcceptsReturn = True
        Me.txt_CompletionLetter.Location = New System.Drawing.Point(104, 272)
        Me.txt_CompletionLetter.Multiline = True
        Me.txt_CompletionLetter.Name = "txt_CompletionLetter"
        Me.txt_CompletionLetter.Size = New System.Drawing.Size(272, 24)
        Me.txt_CompletionLetter.TabIndex = 17
        Me.txt_CompletionLetter.Text = "UltraTextEditor3"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(24, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 32)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(104, 336)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(272, 56)
        Me.txt_Remark.TabIndex = 21
        Me.txt_Remark.Text = "UltraTextEditor4"
        '
        'frmDocDue
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Document"
        Me.ClientSize = New System.Drawing.Size(384, 445)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_CompletionLetter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_PostFix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Prefix)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dt_CompletionDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_DocDetails)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_NumCopies)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_DocDate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_DocNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_StatusNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_docnameID)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDocDue"
        Me.Text = "Document"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_docnameID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DocNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DocDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DocDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CompletionDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_Prefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PostFix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CompletionLetter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
End Class

