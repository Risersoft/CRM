<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdSerial
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Weight As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_ProdSerialNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_ECSchedule = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_CommissionedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_ErectedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_UnloadedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_DispatchedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.txt_InstallationSite = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Weight = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_ProdSerialNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ECSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CommissionedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ErectedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_UnloadedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_DispatchedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InstallationSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ProdSerialNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Remark)
        Me.UltraTabPageControl2.Controls.Add(Me.Label9)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_ECSchedule)
        Me.UltraTabPageControl2.Controls.Add(Me.Label6)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_CommissionedOn)
        Me.UltraTabPageControl2.Controls.Add(Me.Label3)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_ErectedOn)
        Me.UltraTabPageControl2.Controls.Add(Me.Label4)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_UnloadedOn)
        Me.UltraTabPageControl2.Controls.Add(Me.Label2)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_DispatchedOn)
        Me.UltraTabPageControl2.Controls.Add(Me.lblRef)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_InstallationSite)
        Me.UltraTabPageControl2.Controls.Add(Me.Label1)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_Weight)
        Me.UltraTabPageControl2.Controls.Add(Me.Label8)
        Me.UltraTabPageControl2.Controls.Add(Me.Label7)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_StatusNum)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_ProdSerialNum)
        Me.UltraTabPageControl2.Controls.Add(Me.Label5)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(636, 347)
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(197, 297)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(288, 37)
        Me.txt_Remark.TabIndex = 19
        Me.txt_Remark.Text = "UltraTextEditor12"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(67, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Remark"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ECSchedule
        '
        Me.txt_ECSchedule.AcceptsReturn = True
        Me.txt_ECSchedule.Location = New System.Drawing.Point(197, 254)
        Me.txt_ECSchedule.Multiline = True
        Me.txt_ECSchedule.Name = "txt_ECSchedule"
        Me.txt_ECSchedule.Size = New System.Drawing.Size(288, 37)
        Me.txt_ECSchedule.TabIndex = 17
        Me.txt_ECSchedule.Text = "UltraTextEditor12"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(67, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "E&&C Schedule"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CommissionedOn
        '
        Me.dt_CommissionedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_CommissionedOn.Location = New System.Drawing.Point(197, 218)
        Me.dt_CommissionedOn.Name = "dt_CommissionedOn"
        Me.dt_CommissionedOn.NullText = "Not Defined"
        Me.dt_CommissionedOn.Size = New System.Drawing.Size(152, 21)
        Me.dt_CommissionedOn.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(70, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Commissioned On"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_ErectedOn
        '
        Me.dt_ErectedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_ErectedOn.Location = New System.Drawing.Point(197, 191)
        Me.dt_ErectedOn.Name = "dt_ErectedOn"
        Me.dt_ErectedOn.NullText = "Not Defined"
        Me.dt_ErectedOn.Size = New System.Drawing.Size(152, 21)
        Me.dt_ErectedOn.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(109, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Erected On"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_UnloadedOn
        '
        Me.dt_UnloadedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_UnloadedOn.Location = New System.Drawing.Point(197, 164)
        Me.dt_UnloadedOn.Name = "dt_UnloadedOn"
        Me.dt_UnloadedOn.NullText = "Not Defined"
        Me.dt_UnloadedOn.Size = New System.Drawing.Size(152, 21)
        Me.dt_UnloadedOn.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(109, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Unloaded On"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_DispatchedOn
        '
        Me.dt_DispatchedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_DispatchedOn.Location = New System.Drawing.Point(197, 137)
        Me.dt_DispatchedOn.Name = "dt_DispatchedOn"
        Me.dt_DispatchedOn.NullText = "Not Defined"
        Me.dt_DispatchedOn.Size = New System.Drawing.Size(152, 21)
        Me.dt_DispatchedOn.TabIndex = 9
        '
        'lblRef
        '
        Me.lblRef.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblRef.Location = New System.Drawing.Point(109, 137)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(80, 16)
        Me.lblRef.TabIndex = 8
        Me.lblRef.Text = "Dispatched On"
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_InstallationSite
        '
        Me.txt_InstallationSite.Location = New System.Drawing.Point(197, 110)
        Me.txt_InstallationSite.Name = "txt_InstallationSite"
        Me.txt_InstallationSite.Size = New System.Drawing.Size(179, 21)
        Me.txt_InstallationSite.TabIndex = 7
        Me.txt_InstallationSite.Text = "UltraTextEditor12"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(67, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Installation Site"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Weight
        '
        Me.txt_Weight.Location = New System.Drawing.Point(197, 69)
        Me.txt_Weight.Name = "txt_Weight"
        Me.txt_Weight.ReadOnly = True
        Me.txt_Weight.Size = New System.Drawing.Size(136, 21)
        Me.txt_Weight.TabIndex = 5
        Me.txt_Weight.Text = "UltraTextEditor12"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(133, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Weight"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(45, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Production Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.DataMember = "Items"
        Me.cmb_StatusNum.DisplayMember = "ItemName"
        Me.cmb_StatusNum.Location = New System.Drawing.Point(197, 41)
        Me.cmb_StatusNum.MaxDropDownItems = 15
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(288, 22)
        Me.cmb_StatusNum.TabIndex = 3
        Me.cmb_StatusNum.Text = "UltraCombo1"
        Me.cmb_StatusNum.ValueMember = "ItemID"
        '
        'txt_ProdSerialNum
        '
        Me.txt_ProdSerialNum.Location = New System.Drawing.Point(197, 12)
        Me.txt_ProdSerialNum.Name = "txt_ProdSerialNum"
        Me.txt_ProdSerialNum.ReadOnly = True
        Me.txt_ProdSerialNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_ProdSerialNum.TabIndex = 1
        Me.txt_ProdSerialNum.Text = "UltraTextEditor12"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(117, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Serial No."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance1.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance1
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(640, 373)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Product"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(636, 347)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 373)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 48)
        Me.Panel4.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Location = New System.Drawing.Point(352, 8)
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
        Me.btnCancel.Location = New System.Drawing.Point(448, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(544, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'frmProdSerial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Transformer Serial"
        Me.ClientSize = New System.Drawing.Size(640, 421)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProdSerial"
        Me.Text = "Transformer Serial"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ECSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CommissionedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ErectedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_UnloadedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_DispatchedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InstallationSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Weight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ProdSerialNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_InstallationSite As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_CommissionedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_ErectedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_UnloadedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_DispatchedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_ECSchedule As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label

#End Region
End Class

