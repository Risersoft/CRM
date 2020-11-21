<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutBoundSMS
    Inherits frmMax

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call


        Me.InitForm()
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_FromNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnClearUser = New Infragistics.Win.Misc.UltraButton()
        Me.btnUser = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_UserID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDeleteSMS = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FromNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_UserID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraLabel2
        '
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.TextHAlignAsString = "Right"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(11, 48)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel2.TabIndex = 234
        Me.UltraLabel2.Text = "From Number:"
        '
        'txt_FromNumber
        '
        Me.txt_FromNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "False"
        Me.txt_FromNumber.Appearance = Appearance2
        Me.txt_FromNumber.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_FromNumber.Location = New System.Drawing.Point(97, 47)
        Me.txt_FromNumber.Name = "txt_FromNumber"
        Me.txt_FromNumber.Size = New System.Drawing.Size(261, 17)
        Me.txt_FromNumber.TabIndex = 233
        Me.txt_FromNumber.Text = "UltraTextEditor2"
        '
        'UltraLabel1
        '
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.TextHAlignAsString = "Right"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(51, 22)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel1.TabIndex = 236
        Me.UltraLabel1.Text = "Name:"
        '
        'txt_Name
        '
        Me.txt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "False"
        Me.txt_Name.Appearance = Appearance4
        Me.txt_Name.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Name.Location = New System.Drawing.Point(97, 21)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(261, 17)
        Me.txt_Name.TabIndex = 235
        Me.txt_Name.Text = "UltraTextEditor2"
        '
        'btnClearUser
        '
        Me.btnClearUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearUser.Location = New System.Drawing.Point(304, 74)
        Me.btnClearUser.Name = "btnClearUser"
        Me.btnClearUser.Size = New System.Drawing.Size(58, 26)
        Me.btnClearUser.TabIndex = 247
        Me.btnClearUser.Text = "Clear"
        '
        'btnUser
        '
        Me.btnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUser.Location = New System.Drawing.Point(244, 74)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(58, 26)
        Me.btnUser.TabIndex = 246
        Me.btnUser.Text = "Select"
        '
        'UltraLabel5
        '
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.TextHAlignAsString = "Right"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance5
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(55, 79)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel5.TabIndex = 244
        Me.UltraLabel5.Text = "User:"
        '
        'cmb_UserID
        '
        Me.cmb_UserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_UserID.Location = New System.Drawing.Point(96, 76)
        Me.cmb_UserID.Name = "cmb_UserID"
        Me.cmb_UserID.ReadOnly = True
        Me.cmb_UserID.Size = New System.Drawing.Size(144, 22)
        Me.cmb_UserID.TabIndex = 245
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnDeleteSMS)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 120)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(462, 44)
        Me.Panel4.TabIndex = 248
        '
        'btnDeleteSMS
        '
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance6.FontData.BoldAsString = "True"
        Me.btnDeleteSMS.Appearance = Appearance6
        Me.btnDeleteSMS.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDeleteSMS.Location = New System.Drawing.Point(0, 0)
        Me.btnDeleteSMS.Name = "btnDeleteSMS"
        Me.btnDeleteSMS.Size = New System.Drawing.Size(88, 44)
        Me.btnDeleteSMS.TabIndex = 6
        Me.btnDeleteSMS.Text = "Delete SMS"
        Me.btnDeleteSMS.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnSave
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance7
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(198, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 44)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Appearance8.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance8
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(286, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 44)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Appearance9.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance9
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(374, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 44)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_FromNumber)
        Me.Panel1.Controls.Add(Me.txt_Name)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.UltraLabel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 164)
        Me.Panel1.TabIndex = 249
        '
        'frmOutBoundSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Caption = "OutBound SMS"
        Me.ClientSize = New System.Drawing.Size(462, 164)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnClearUser)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.cmb_UserID)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmOutBoundSMS"
        Me.Text = "OutBound SMS"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FromNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_UserID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_FromNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnClearUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnUser As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_UserID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnDeleteSMS As Infragistics.Win.Misc.UltraButton
End Class
