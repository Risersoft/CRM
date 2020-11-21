Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmCopyTE
    Inherits frmMax
    Dim myVueRat As New clsWinView
    Dim oProc As New clsSalesEnqProc(Me.Controller)

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmCopyTEModel = Me.InitData("frmCopyTEModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Party", "", Me.comb_NewCustomerID)

            myWinSQL.AssignCmb(Me.dsCombo, "EnqType", "", Me.cmb_EnqType)
            myWinSQL.AssignCmb(Me.dsCombo, "EnqType", "", Me.comb_NewEnqType)

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myVueRat.PrepEdit(Me.Model.GridViews("Rat"))
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
        Me.Model.ClientParams.Add(New clsSQLParam("@NewEnqRefNum", "'" & Me.text_NewEnqRefNum.Value & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewEnqDate", Me.date_NewEnqDate.Value, GetType(Date), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewEnqType", "'" & Me.comb_NewEnqType.Value & "'", GetType(String), False))

        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Me.BXML = "<BROWSE KEY=""sls.tenq"" ID=""" & myUtils.cValTN(myRow("NewSalesEnqID")) & """/>"
                Return True
            End If
        Else
            Me.SetError()
        End If
            Me.Refresh()
    End Function
End Class

