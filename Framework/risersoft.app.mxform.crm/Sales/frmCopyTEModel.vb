Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmCopyTEModel
    Inherits clsFormDataModel
    Dim NewCustomerID As Integer, NewEnqRefNum, NewEnqType As String, NewEnqDate As Date, oRet As clsProcOutput, myVueRat As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myVueRat = Me.GetViewModel("Rat")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "select customerid, CustDescrip, partyid from slsListCustomer() order by partyname"
        Me.AddLookupField("customerid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)
        Me.AddLookupField("NewCustomerID", "Party")

        sql = myFuncsBase.CodeWordSQL("enq", "EnqType", "")
        Me.AddLookupField("EnqType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "EnqType").TableName)
        Me.AddLookupField("NewEnqType", "EnqType")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
    
        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select *, 0 as NewSalesEnqID from SalesEnq where SalesEnqID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        myVueRat.Mode = EnumViewMode.acSelectM : myVueRat.MultiSelect = True
        sql = "select SalesEnqItemID, SalesEnqID, ItemID, ItemID as ItemID2, DescripWO, QtyAPT, QtyTBQ, UnitPrice, Freight from SalesEnqItem where SalesEnqID = %frmIDX%"
        myVueRat.MainGrid.MainConf("FormatXML") = "<COL KEY=""ItemID"" CAPTION=""ItemCode"" LOOKUPSQL=""Select ItemID, ItemCode from items where acceptwo=1""/><COL KEY=""ItemID2"" CAPTION=""ItemName"" LOOKUPSQL=""Select ItemID, ItemName from items where acceptwo=1""/>)"
        myVueRat.MainGrid.QuickConf(sql, True, "1.5-2-2-1-1-1-1")
        Dim str1 As String = "<BAND IDFIELD=""SalesEnqItemID"" TABLE=""SalesEnqItem"" INDEX=""0"">/></BAND>"
        myVueRat.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean

        Me.InitError()
        oRet = myContext.SQL.ValidateSQLParams(Me.ClientParams)
        If oRet.Success Then
            NewCustomerID = myContext.SQL.ParamValue("@NewCustomerID", ClientParams)
            NewEnqRefNum = myContext.SQL.ParamValue("@NewEnqRefNum", ClientParams)
            NewEnqType = myContext.SQL.ParamValue("@NewEnqType", ClientParams)
            NewEnqDate = myContext.SQL.ParamValue("@NewEnqDate", ClientParams)
            If NewCustomerID = 0 Then Me.AddError("NewCustomerID", "Select a Customer")
            If NewEnqRefNum.Trim.Length = 0 Then Me.AddError("NewEnqRefNum", "Reference No.")

        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim oProc As New clsSalesEnqProc(myContext)

        VSave = False
        If Me.Validate Then
            oRet = oProc.Copy(frmIDX, NewCustomerID, NewEnqRefNum, NewEnqDate, NewEnqType, myVueRat.MainGrid.myDS.Tables(0))
            If oRet.Success Then
                myRow("NewSalesEnqID") = oRet.ID
                frmMode = EnumfrmMode.acEditM
                VSave = True
            Else
                Me.AddError("", oRet.Message)
            End If
        End If

    End Function

End Class
