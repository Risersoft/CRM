Imports Infragistics.Win.UltraWinGrid
Imports we = Infragistics.Win.UltraWinEditors
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProject
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ProjectName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Location = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_RegionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_ActionReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_CompletedOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmb_EURegionID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_EndUserID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cmb_Priority = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_ProjectWonByID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_FinalBy = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ActionReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CompletedOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EURegionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Priority, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProjectWonByID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FinalBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 445)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(592, 48)
        Me.Panel4.TabIndex = 22
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance32.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance32
        Me.btnSave.Location = New System.Drawing.Point(304, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance33.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance33
        Me.btnCancel.Location = New System.Drawing.Point(400, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance34.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance34
        Me.btnOK.Location = New System.Drawing.Point(496, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'lblNum
        '
        Me.lblNum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(60, 37)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(56, 16)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Name"
        Me.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(52, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Location"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ProjectName
        '
        Appearance30.FontData.BoldAsString = "True"
        Appearance30.FontData.SizeInPoints = 11.0!
        Me.txt_ProjectName.Appearance = Appearance30
        Me.txt_ProjectName.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_ProjectName.Location = New System.Drawing.Point(124, 37)
        Me.txt_ProjectName.Name = "txt_ProjectName"
        Me.txt_ProjectName.Size = New System.Drawing.Size(456, 22)
        Me.txt_ProjectName.TabIndex = 1
        Me.txt_ProjectName.Text = "UltraTextEditor2"
        '
        'txt_Location
        '
        Me.txt_Location.Location = New System.Drawing.Point(124, 65)
        Me.txt_Location.Name = "txt_Location"
        Me.txt_Location.Size = New System.Drawing.Size(256, 21)
        Me.txt_Location.TabIndex = 3
        Me.txt_Location.Text = "UltraTextEditor2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(66, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Region"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_RegionID
        '
        Me.cmb_RegionID.Location = New System.Drawing.Point(124, 92)
        Me.cmb_RegionID.Name = "cmb_RegionID"
        Me.cmb_RegionID.Size = New System.Drawing.Size(192, 22)
        Me.cmb_RegionID.TabIndex = 5
        Me.cmb_RegionID.Text = "UltraCombo3"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label32.Location = New System.Drawing.Point(20, 177)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 16)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Action Required"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_ActionReq
        '
        Me.txt_ActionReq.AcceptsReturn = True
        Me.txt_ActionReq.Location = New System.Drawing.Point(124, 177)
        Me.txt_ActionReq.Multiline = True
        Me.txt_ActionReq.Name = "txt_ActionReq"
        Me.txt_ActionReq.Size = New System.Drawing.Size(424, 39)
        Me.txt_ActionReq.TabIndex = 11
        Me.txt_ActionReq.Text = "UltraTextEditor3"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(20, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Remark"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remark
        '
        Me.txt_Remark.AcceptsReturn = True
        Me.txt_Remark.Location = New System.Drawing.Point(124, 276)
        Me.txt_Remark.Multiline = True
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(424, 48)
        Me.txt_Remark.TabIndex = 17
        Me.txt_Remark.Text = "UltraTextEditor3"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(12, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Completed On"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_CompletedOn
        '
        Me.dt_CompletedOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_CompletedOn.Location = New System.Drawing.Point(124, 222)
        Me.dt_CompletedOn.Name = "dt_CompletedOn"
        Me.dt_CompletedOn.NullText = "Not Defined"
        Me.dt_CompletedOn.Size = New System.Drawing.Size(168, 21)
        Me.dt_CompletedOn.TabIndex = 13
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label31.Location = New System.Drawing.Point(20, 147)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 24)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Region End User"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EURegionID
        '
        Me.cmb_EURegionID.Location = New System.Drawing.Point(124, 148)
        Me.cmb_EURegionID.Name = "cmb_EURegionID"
        Me.cmb_EURegionID.Size = New System.Drawing.Size(192, 22)
        Me.cmb_EURegionID.TabIndex = 9
        Me.cmb_EURegionID.Text = "UltraCombo3"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(20, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "End User"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_EndUserID
        '
        Me.cmb_EndUserID.Location = New System.Drawing.Point(124, 120)
        Me.cmb_EndUserID.Name = "cmb_EndUserID"
        Me.cmb_EndUserID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_EndUserID.TabIndex = 7
        Me.cmb_EndUserID.Text = "UltraCombo1"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(20, 249)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "Priority"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_Priority
        '
        Me.cmb_Priority.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_Priority.Location = New System.Drawing.Point(124, 249)
        Me.cmb_Priority.Name = "cmb_Priority"
        Me.cmb_Priority.Size = New System.Drawing.Size(104, 21)
        Me.cmb_Priority.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(20, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Project Won By"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_ProjectWonByID
        '
        Me.cmb_ProjectWonByID.Location = New System.Drawing.Point(124, 330)
        Me.cmb_ProjectWonByID.Name = "cmb_ProjectWonByID"
        Me.cmb_ProjectWonByID.Size = New System.Drawing.Size(360, 22)
        Me.cmb_ProjectWonByID.TabIndex = 19
        Me.cmb_ProjectWonByID.Text = "UltraCombo1"
        '
        'txt_FinalBy
        '
        Me.txt_FinalBy.Location = New System.Drawing.Point(124, 358)
        Me.txt_FinalBy.Name = "txt_FinalBy"
        Me.txt_FinalBy.Size = New System.Drawing.Size(256, 21)
        Me.txt_FinalBy.TabIndex = 21
        Me.txt_FinalBy.Text = "UltraTextEditor2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Finalization By"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Project"
        Me.ClientSize = New System.Drawing.Size(592, 493)
        Me.Controls.Add(Me.txt_FinalBy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_ProjectWonByID)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmb_Priority)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cmb_EURegionID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_EndUserID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dt_CompletedOn)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txt_ActionReq)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Remark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_RegionID)
        Me.Controls.Add(Me.txt_Location)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_ProjectName)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProject"
        Me.Text = "Project"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_ProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_RegionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ActionReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CompletedOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EURegionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EndUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Priority, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProjectWonByID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FinalBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_ProjectName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Location As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_RegionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_ActionReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dt_CompletedOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmb_EURegionID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_EndUserID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmb_Priority As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_ProjectWonByID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txt_FinalBy As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label

#End Region
End Class

