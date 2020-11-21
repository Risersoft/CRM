Public Class frmFieldReportItem
    Inherits frmMax
    Friend fMat As frmFieldReport
    Dim dv As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        myWinSQL.AssignCmb(NewModel.dsCombo, "Status", "", Me.cmb_StatusNum)
        myWinSQL.AssignCmb(NewModel.dsCombo, "NCCat", "", Me.ComboCatID)
        dv = myWinSQL.AssignCmb(NewModel.dsCombo, "NCSubCat", "", Me.cmb_ProdNCCatID, , True)

        Return True
    End Function

    Public Overloads Function PrepForm(ByVal r1 As DataRow) As Boolean
        Me.FormPrepared = False
        If Me.BindData(r1) Then

            CheckFilter()
            If myUtils.IsInList(myUtils.cValTN(myRow("ProdNCCatId")), 0) Then ComboCatID.Value = DBNull.Value Else ComboCatID.Value = cmb_ProdNCCatID.SelectedRow.Cells("NCCat").Value
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.txt_Findings.Text.Trim.Length = 0 Then WinFormUtils.AddError(Me.txt_Findings, "Enter Findings")
        If myUtils.cValTN(Me.cmb_ProdNCCatID.Value) = 0 Then WinFormUtils.AddError(Me.cmb_ProdNCCatID, "Select NC Category")

        If Me.CanSave Then
            cm.EndCurrentEdit()
            VSave = True
        End If
    End Function

    Private Sub ComboCatID_Leave(sender As Object, e As EventArgs) Handles ComboCatID.Leave, ComboCatID.AfterCloseUp
        FilterSubCat(myUtils.cStrTN(ComboCatID.Text))
    End Sub

    Private Sub CheckFilter()
        Dim rr() As DataRow = dv.Table.Select("ProdNCCatId = " & myUtils.cValTN(myRow("ProdNCCatId")))
        If rr.Length = 1 Then
            FilterSubCat(rr(0)("NCCat"))
            Me.ComboCatID.Value = rr(0)("NCCat")
            Me.cmb_ProdNCCatID.Value = myUtils.cValTN(myRow("ProdNCCatId"))
        Else
            FilterSubCat("")
        End If
    End Sub

    Private Sub FilterSubCat(ByVal Cat As String)
        If Not dv Is Nothing Then
            If Cat.Trim.Length = 0 Then dv.RowFilter = "NCCat = ''" Else dv.RowFilter = "NCCat = '" & myUtils.cStrTN(Cat) & "'"
        End If
    End Sub
End Class