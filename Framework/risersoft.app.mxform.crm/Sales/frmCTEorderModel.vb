Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmCTEorderModel
    Inherits clsFormDataModel
    Dim poNum As String, poDate As String, newCustID As Integer, oRet As clsProcOutput, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("EnqItem")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "select customerid, CustDescrip, partyid from slsListCustomer() order by partyname"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Cust").TableName)

        Me.AddLookupField("NewCustID", "Cust")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
      
        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            sql = "Select *, 0 as salesorderid from SalesEnq where SalesEnqID = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
            myView.MainGrid.MainConf("headfactor") = 2
            myView.MainGrid.QuickConf("select SalesEnqItemID,DescripWO,QtyTBQ,'' as WONum, convert(datetime,Null) as [WODate], 0 as [Qty],convert(int,null) as matdepid from slsListEnqItem() where SalesEnqID = " & frmIDX, True, "0-3-1-2-2-1-1.5", True, "Items")
            myUtils.ChangeAll(myView.MainGrid.myDS.Tables(0).Select, "sysincl=1")
            myView.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""WONum,WODate,Qty""/><COL KEY=""matdepid"" CAPTION=""Dep"" LOOKUPSQL=""select matdepid, depname from depsmat where acceptswo=1""/></BAND>", EnumEditType.acCommandAndEdit)

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()

        oRet = myContext.SQL.ValidateSQLParams(Me.ClientParams)
        If oRet.Success Then
            poNum = myContext.SQL.ParamValue("@PONum", ClientParams)
            poDate = myContext.SQL.ParamValue("@PODate", ClientParams)
            newCustID = myContext.SQL.ParamValue("@NewCustID", ClientParams)

            If newCustID = 0 Then Me.AddError("NewCustID", "Select a customer")
            If poNum.Trim.Length = 0 Then Me.AddError("PONum", "Enter a PO Number")
            If myUtils.NullNot(poDate) Then Me.AddError("podate", "Enter PO Date")
            If Me.myView.MainGrid.myDS.Tables(0).Select("sysincl=1").Length = 0 Then Me.AddError("", "Select an item")
            Me.myView.MainGrid.CheckValid("WONum,WODate,Qty,MatDepID", "sysincl=1")
        Else
            Me.AddError("", oRet.Message)
        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim oProc As New clsSalesEnqProc(myContext)
        VSave = False

        If Me.Validate Then
            oRet = oProc.ConvertOrder(frmIDX, poNum, poDate, newCustID, myView.MainGrid.myDS.Tables(0))
            If oRet.Success Then
                myRow("SalesOrderID") = oRet.ID
                frmMode = EnumfrmMode.acEditM
                VSave = True
            Else
                Me.AddError("", oRet.Message)
            End If

        End If
    End Function

End Class
