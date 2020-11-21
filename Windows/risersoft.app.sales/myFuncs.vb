Imports ut = Infragistics.Win.UltraWinTree
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors

Public Class myFuncs
    Inherits risersoft.app.shared.myFuncs
    Shared DomEMailAdd As String = "ajay.kohli@kanohar.com"
    Shared IntlEMailAdd As String = "vivek.singhal@kanohar.com"

    Friend Shared Sub CalcDescrip(ItemRow As DataRow, f As frmAttribValue, rForm As DataRow)
        If myUtils.cBoolTN(ItemRow("iseto")) Then
            rForm("descripwo") = f.AttribValue(CInt(myUtils.cValTN(ItemRow("etodescripattribid"))))
            rForm("descriptech") = f.AttribValue(CInt(myUtils.cValTN(ItemRow("etotechdescripattribid"))))
        Else
            rForm("descripwo") = ItemRow("itemname")
            rForm("descriptech") = ItemRow("itemname")
        End If

    End Sub
    Friend Shared Sub CalcDescrip(ItemCombo As UltraCombo, f As frmAttribValue, rForm As DataRow)
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(ItemCombo.SelectedRow)
        myFuncs.CalcDescrip(r1, f, rForm)
    End Sub
    Friend Shared Function CalcQty2(ItemCombo As UltraCombo, f As frmAttribValue, qty1 As Decimal, ETOSKU2AttribID As Integer) As Decimal
        Dim r1 As DataRow = win.myWinUtils.DataRowFromGridRow(ItemCombo.SelectedRow)
        Return myFuncs.CalcQty2(r1, f, qty1, ETOSKU2AttribID)
    End Function
    Friend Shared Function CalcQty2(r1 As DataRow, f As frmAttribValue, qty1 As Decimal, ETOSKU2AttribID As Integer) As Decimal
        Dim qty2 As Decimal = 0, fac As Decimal
        If Not r1 Is Nothing Then
            fac = myUtils.cValTN(f.AttribValue(ETOSKU2AttribID))
            qty2 = qty1 * fac
        End If
        Return qty2
    End Function

    Friend Shared Sub SetQty2(rItem As DataRow, f As frmAttribValue, txt_TotalQty As UltraTextEditor, txt_TotalQty2 As UltraTextEditor)
        If (Not rItem Is Nothing) AndAlso myUtils.cStrTN(rItem("unitname2")).Trim.Length > 0 Then
            If myUtils.cValTN(rItem("etosku2attribid")) > 0 Then
                txt_TotalQty2.Text = myFuncs.CalcQty2(rItem, f, myUtils.cValTN(txt_TotalQty.Text), myUtils.cValTN(rItem("etosku2attribid")))
                txt_TotalQty2.ReadOnly = True
            Else
                txt_TotalQty2.ReadOnly = False
            End If
        Else
            txt_TotalQty2.Value = DBNull.Value
            txt_TotalQty2.ReadOnly = False
        End If

    End Sub
    Friend Shared Sub SetQty2(ItemCombo As UltraCombo, f As frmAttribValue, txt_TotalQty As UltraTextEditor, txt_TotalQty2 As UltraTextEditor)
        Dim rItem As DataRow = win.myWinUtils.DataRowFromGridRow(ItemCombo.SelectedRow)
        myFuncs.SetQty2(rItem, f, txt_TotalQty, txt_TotalQty2)
    End Sub

End Class






