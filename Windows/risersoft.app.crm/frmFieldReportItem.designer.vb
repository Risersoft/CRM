<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmFieldReportItem
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
    Friend WithEvents txt_ActionTaken As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_EstimatedReasons As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Findings As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_prevenaction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ComboCatID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ProdNCCatID As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.txt_ActionTaken = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_EstimatedReasons = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Findings = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_prevenaction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ComboCatID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_ProdNCCatID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_Suggestions = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ActionTaken, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EstimatedReasons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Findings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboCatID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdNCCatID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Suggestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_ActionTaken
        '
        Me.txt_ActionTaken.AcceptsReturn = True
        Me.txt_ActionTaken.Location = New System.Drawing.Point(117, 96)
        Me.txt_ActionTaken.Name = "txt_ActionTaken"
        Me.txt_ActionTaken.Size = New System.Drawing.Size(301, 21)
        Me.txt_ActionTaken.TabIndex = 11
        '
        'UltraLabel7
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance17
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(42, 99)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel7.TabIndex = 10
        Me.UltraLabel7.Text = "Action Taken"
        '
        'txt_EstimatedReasons
        '
        Me.txt_EstimatedReasons.AcceptsReturn = True
        Me.txt_EstimatedReasons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_EstimatedReasons.Location = New System.Drawing.Point(117, 68)
        Me.txt_EstimatedReasons.Name = "txt_EstimatedReasons"
        Me.txt_EstimatedReasons.Size = New System.Drawing.Size(713, 21)
        Me.txt_EstimatedReasons.TabIndex = 9
        '
        'UltraLabel6
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance18
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(10, 71)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(102, 14)
        Me.UltraLabel6.TabIndex = 8
        Me.UltraLabel6.Text = "Estimated Reasons"
        '
        'txt_Findings
        '
        Me.txt_Findings.AcceptsReturn = True
        Me.txt_Findings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Findings.Location = New System.Drawing.Point(117, 11)
        Me.txt_Findings.Name = "txt_Findings"
        Me.txt_Findings.Size = New System.Drawing.Size(713, 21)
        Me.txt_Findings.TabIndex = 1
        '
        'UltraLabel3
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance19
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(65, 14)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Findings"
        '
        'txt_prevenaction
        '
        Me.txt_prevenaction.AcceptsReturn = True
        Me.txt_prevenaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_prevenaction.Location = New System.Drawing.Point(522, 96)
        Me.txt_prevenaction.Name = "txt_prevenaction"
        Me.txt_prevenaction.Size = New System.Drawing.Size(308, 21)
        Me.txt_prevenaction.TabIndex = 13
        '
        'UltraLabel10
        '
        Appearance20.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance20
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(427, 99)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel10.TabIndex = 12
        Me.UltraLabel10.Text = "Preventive Action"
        '
        'UltraLabel1
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance21
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel1.Location = New System.Drawing.Point(607, 43)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Status"
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_StatusNum.Location = New System.Drawing.Point(646, 39)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(184, 22)
        Me.cmb_StatusNum.TabIndex = 7
        '
        'UltraLabel2
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance22
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(64, 42)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Category"
        '
        'ComboCatID
        '
        Me.ComboCatID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ComboCatID.Location = New System.Drawing.Point(117, 39)
        Me.ComboCatID.Name = "ComboCatID"
        Me.ComboCatID.Size = New System.Drawing.Size(188, 22)
        Me.ComboCatID.TabIndex = 3
        '
        'UltraLabel4
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance23
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(310, 43)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel4.TabIndex = 4
        Me.UltraLabel4.Text = "Sub Category"
        '
        'cmb_ProdNCCatID
        '
        Me.cmb_ProdNCCatID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_ProdNCCatID.Location = New System.Drawing.Point(386, 39)
        Me.cmb_ProdNCCatID.Name = "cmb_ProdNCCatID"
        Me.cmb_ProdNCCatID.Size = New System.Drawing.Size(195, 22)
        Me.cmb_ProdNCCatID.TabIndex = 5
        '
        'txt_Suggestions
        '
        Me.txt_Suggestions.AcceptsReturn = True
        Me.txt_Suggestions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Suggestions.Location = New System.Drawing.Point(117, 125)
        Me.txt_Suggestions.Name = "txt_Suggestions"
        Me.txt_Suggestions.Size = New System.Drawing.Size(713, 21)
        Me.txt_Suggestions.TabIndex = 15
        '
        'UltraLabel5
        '
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance24
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(45, 129)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(67, 14)
        Me.UltraLabel5.TabIndex = 14
        Me.UltraLabel5.Text = "Suggestions"
        '
        'frmFieldReportItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Field Report Details"
        Me.ClientSize = New System.Drawing.Size(835, 159)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.txt_Suggestions)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cmb_ProdNCCatID)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.ComboCatID)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.cmb_StatusNum)
        Me.Controls.Add(Me.txt_prevenaction)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.txt_Findings)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.txt_ActionTaken)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.txt_EstimatedReasons)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Name = "frmFieldReportItem"
        Me.Text = "Field Report Details"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ActionTaken, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EstimatedReasons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Findings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboCatID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdNCCatID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Suggestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Suggestions As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel

#End Region
End Class

