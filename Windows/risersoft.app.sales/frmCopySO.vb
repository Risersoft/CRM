Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmCopySO
    Inherits frmMax
    Dim myViewWO As New clsWinView
    Dim oProc As New clsSalesEnqProc(Me.Controller)

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmCopySOModel = Me.InitData("frmCopySOModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.comb_NewCustomerID)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myViewWO.PrepEdit(Me.Model.GridViews("WO"))
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOk, Me.btnCancel, Nothing)
    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError()
        VSave = False
        Me.Model.ClientParams.Clear()
        Me.Model.ClientParams.Add(New clsSQLParam("@NewCustomerID", Me.comb_NewCustomerID.Value, GetType(Integer), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewLoINum", "'" & myUtils.cStrTN(Me.txt_NewLoINum.Value) & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewLoiDate", Me.dt_NewLoiDate.Value, GetType(Date), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewPONum", "'" & myUtils.cStrTN(Me.txt_NewPONum.Value) & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewPODate", Me.dt_NewPODate.Value, GetType(Date), False))


        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function
End Class

