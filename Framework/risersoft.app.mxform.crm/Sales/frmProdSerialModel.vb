Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProdSerialModel
    Inherits clsFormDataModel
    Dim sql As String

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "Select statusnum, statustext from status where statustype='PS' order by statusnum"
        Me.AddLookupField("statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "PS").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from ProdSerial where ProdSerialID = " & prepIDX
        Me.InitData(sql, "workorderid", oView, prepMode, prepIDX, strXML)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("StatusNum") Is Nothing Then Me.AddError("StatusNum", "Select a status")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim ProdDescrip As String = " Transformer Serial No: " & myUtils.cStrTN(myRow("ProdSerialNum"))
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "ProdSerialID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from ProdSerial where ProdSerialID = " & frmIDX)
                frmIDX = myRow("ProdSerialID")

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(ProdDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(ProdDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
    End Function

End Class
