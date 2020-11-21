Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmCopySOModel
    Inherits clsFormDataModel
    Dim NewCustomerID As Integer, NewLoINum, NewPONum As String, NewLoiDate, NewPODate As Date, oRet As clsProcOutput, myViewWO As clsViewModel

    Protected Overrides Sub InitViews()
        myViewWO = Me.GetViewModel("WO")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim Sql As String = "select customerid, CustDescrip, partyid from slsListCustomer() order by partyname"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, Sql), "Cust").TableName)
        Me.AddLookupField("NewCustomerID", "Cust")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        Dim Sql As String = "Select *, 0 as NewSalesOrderID from SalesOrder where SalesOrderID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        myViewWO.Mode = EnumViewMode.acSelectM : myViewWO.MultiSelect = True
        Sql = "select workorderid, salesorderid, WOType, WONum, WODate, '' as NewWONum, convert(datetime,null) as NewWODate, ItemID, ItemID as ItemID2, DescripWO, TotalQty from Workorder where SalesOrderID = %frmIDX%"
        myViewWO.MainGrid.MainConf("FormatXML") = "<COL KEY=""ItemID"" CAPTION=""ItemCode"" LOOKUPSQL=""Select ItemID, ItemCode from items where acceptwo=1""/><COL KEY=""ItemID2"" CAPTION=""ItemName"" LOOKUPSQL=""Select ItemID, ItemName from items where acceptwo=1""/>)"
        myViewWO.MainGrid.QuickConf(Sql, True, "1-1.5-1.5-1.5-1.5-1-1-1-1")
        Dim str1 As String = "<BAND INDEX=""0"" IDFIELD=""workorderid"" TABLE=""workorder""><COL KEY=""NewWONum,NewWODate""/></BAND>"
        myViewWO.MainGrid.PrepEdit(str1, EnumEditType.acEditOnly)


        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean

        Me.InitError()

        oRet = myContext.SQL.ValidateSQLParams(Me.ClientParams)
        If oRet.Success Then
            NewCustomerID = myContext.SQL.ParamValue("@NewCustomerID", ClientParams)
            NewLoINum = myContext.SQL.ParamValue("@NewLoINum", ClientParams)
            NewLoiDate = myContext.SQL.ParamValue("@NewLoiDate", ClientParams)
            NewPONum = myContext.SQL.ParamValue("@NewPONum", ClientParams)
            NewPODate = myContext.SQL.ParamValue("@NewPODate", ClientParams)

            If NewCustomerID = 0 Then Me.AddError("NewCustomerID", "Please Select Customer")
            If NewLoINum.Trim.Length = 0 Then Me.AddError("NewLoINum", "Please Enter LoI No.")
            If NewPONum.Trim.Length = 0 Then Me.AddError("NewPONum", "Please Enter PO. No.")

        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim oProc As New SalesOrderProc(myContext)

        VSave = False
        If Me.Validate Then
            oRet = oProc.Copy(frmIDX, NewCustomerID, NewLoINum, NewLoiDate, NewPONum, NewPODate, myViewWO.MainGrid.myDS.Tables(0))
            If oRet.Success Then
                myRow("NewSalesOrderID") = oRet.ID
                frmMode = EnumfrmMode.acEditM
                VSave = True
            Else
                Me.AddError("", oRet.Message)
            End If
        End If

    End Function
End Class
