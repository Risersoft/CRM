Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmCTEorder
    Inherits frmMax

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmCTEorderModel = Me.InitData("frmCTEorderModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.comb_NewCustID)

            Me.text_PONum.Text = ""
            Me.comb_NewCustID.Text = ""
            Me.date_podate.Value = Nothing
            WinFormUtils.SetReadOnly(Me.Panel1, False)

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("EnqItem"))
            myView.mainGrid.HighlightRows()
            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridRat)
        WinFormUtils.SetButtonConf(Me.btnOk, Me.btnCancel, Nothing)

    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError()
        VSave = False
        Me.Model.ClientParams.Clear()
        Me.Model.ClientParams.Add(New clsSQLParam("@PONum", "'" & Me.text_PONum.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@PODate", Me.date_podate.Value, GetType(Date), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewCustID", myUtils.cValTN(Me.comb_NewCustID.Value), GetType(Integer), False))
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Me.BXML = "<BROWSE KEY=""sls.order"" ID=""" & myUtils.cValTN(myRow("SalesOrderID")) & """/>"
                Return True
            End If
        Else
            Me.SetError()
        End If

        Me.Refresh()
    End Function

End Class

