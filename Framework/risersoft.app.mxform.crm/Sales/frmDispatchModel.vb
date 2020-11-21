Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmDispatchModel
    Inherits clsFormDataModel
    Dim myVueSpare, myVueDoc As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("ProdSerialItem")
        myVueSpare = Me.GetViewModel("Spare")
        myVueDoc = Me.GetViewModel("Doc")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "select partyid, partyname, TaxAreaID from genlistparty() order by partyname"
        Me.AddLookupField("ConsigneeID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        Me.AddLookupField("docnameid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "DOC").TableName)

        sql = "select statusnum,statustext from status where statustype='DOC' order by statusnum"
        Me.AddLookupField("statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BG2").TableName)

        sql = "select TaxAreaID, Descrip,TaxAreaCode from TaxArea Order by Descrip"
        Me.AddLookupField("POSTaxAreaID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "POS").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from dispatch where dispatchid = " & prepIDX
        Me.InitData(sql, "salesorderid", oView, prepMode, prepIDX, strXML)

        myView.MultiSelect = True : myView.Mode = EnumViewMode.acSelectM
        myView.MainGrid.QuickConf("select dispatchid, ProdSerialItemID, ProdSerialID, ProdSerialNum, WOInfo, DescripWO from slsListJoinDispWO()  where ProdSerialID is not null and DispatchID = " & frmIDX, True, "1-1-2", True, "Serial Nos.")
        myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), "select * from plnListProdSerial() where salesorderid=" & myUtils.cValTN(myRow("salesorderid")), "ProdSerialID")
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""ProdSerialItem"" IDFIELD=""ProdSerialItemID""><COL KEY=""DISPATCHID,ProdSerialID""/></BAND>", EnumEditType.acCommandOnly)

        'myVueSpare.Mode = EnumViewMode.acSelectM : myVueSpare.MultiSelect = True
        'myVueSpare.MainGrid.QuickConf("select SOSpareItemID,dispatchid, SOSpareID, SpareName,WONum, TotalQty, UnitName, Qty from slslistsospareitem() where dispatchid = %frmidx%", True, "3-1-1-1-1")
        'sql = "Select SOSpareID, SpareName, WONum, Qty as TotalQty,UnitName from slslistsospares() where salesorderid = " & myUtils.cValTN(myRow("salesorderid"))
        'myContext.Data.ReverseTick(myVueSpare.MainGrid.myDS.Tables(0), sql, "SOSpareID")
        'myVueSpare.MainGrid.PrepEdit("<BAND INDEX=""0""><COL KEY=""QTY""/></BAND>", EnumEditType.acCommandAndEdit)
        'myVueSpare.MainGrid.PrepEdit("<BAND TABLE=""SOSpareItem"" IDFIELD=""SOSpareItemID"" INDEX=""0""><COL KEY=""SOSpareID,dispatchid,qty""/></BAND>", EnumEditType.acCommandOnly)


        sql = "Select SOSpareItemID, DispatchId,SOSpareID,PSospareID, SortIndex, SubSortIndex, BOQNum, FullBOQNum, SpareName, WONum, TotalQty, UnitName, Qty from slslistsospareitem() where DispatchId = " & frmIDX
        Dim ds As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
        myVueSpare.MainGrid.BindGridData(ds, 0)
        myVueSpare.MainGrid.QuickConf("", True, "1-1-1-1-1-2-1-1-1")
        myVueSpare.MainGrid.PrepEdit("<BAND TABLE=""SOSpareItem"" IDFIELD=""SOSpareItemID"" INDEX=""0""><COL KEY=""SOSpareID,SortIndex,SubSortIndex,dispatchid,qty""/></BAND>", EnumEditType.acCommandAndEdit)


        sql = "Select docnameid, DocName, DocType from docmaster inner join doctype On docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("Select dispatchid,duedocid,remark,numcopies,completionletter,completiondate,Prefix,docnameid,Postfix,DocNumber,DocDate,DocDetails,Statusnum from docsdue where dispatchid = " & frmIDX, True, "1-3-1-1-1-1-2", True)
        myVueDoc.MainGrid.MainConf("FormatXML") = "<COL KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """ CAPTION=""Document""/><COL KEY=""statusnum"" CAPTION=""Status"" LOOKUPSQL=""Select statusnum,statustext from status where statustype='doc' order by statusnum"" WFACTOR=""2""/>"
        str1 = "<BAND INDEX=""0"" IDFIELD=""duedocid"" TABLE=""DOCSDUE"">" & myVueDoc.MainGrid.BuildBandEditXML(0) & "</BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If (myUtils.NullNot(Me.SelectedRow("ConsigneeID"))) AndAlso (myUtils.cStrTN(myRow("ConsigneePrefix")).Trim.Length = 0) Then Me.AddError("ConsigneeID", "Select a consignee or fill details")
        Me.myVueSpare.MainGrid.CheckValid("qty")
        If Me.SelectedRow("POSTaxAreaID") Is Nothing Then Me.AddError("POSTaxAreaID", "Please select Place of Supply.")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False
        Dim ConsigneeDescrip As String = ""
        If Me.Validate Then
            If Not myUtils.NullNot(Me.SelectedRow("ConsigneeID")) Then
                ConsigneeDescrip = myUtils.cStrTN(Me.SelectedRow("ConsigneeID")("partyname"))
            Else
                ConsigneeDescrip = myUtils.cStrTN(myRow("ConsigneePrefix"))
            End If

            Dim DispatchDescrip As String = " Dispatch for PartyName: " & ConsigneeDescrip & ", Dt. " & Format(myRow("DispDate"), "dd-MMM-yyyy")
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "dispatchid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from dispatch where dispatchid = " & frmIDX)
                frmIDX = myRow("dispatchid")

                Dim str2 As String = "dispatchid=" & frmIDX
                Me.myView.MainGrid.SaveChanges(, str2)
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                'Me.myVueSpare.MainGrid.SaveChanges(, str2)

                myUtils.ChangeAll(myVueSpare.MainGrid.myDV.Table.Select, str2)
                myContext.Provider.objSQLHelper.SaveResults(myVueSpare.MainGrid.myDV.Table, "Select SOSpareID,SortIndex,SubSortIndex,dispatchid,qty from SoSpareItem")

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(DispatchDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(DispatchDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim Model As clsViewModel = Nothing
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params)
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "wo"
                    Model = New clsViewModel(vwState, myContext)
                    Dim Sql As String = myContext.SQL.PopulateSQLParams("Select WorkOrderID, ConsigneeID, ConsigneePrefix, DeliveryTo, WONum, WODate,DescripWO from WorkOrder Where SalesOrderID = @SalesOrderID", Params)
                    Model.MainGrid.QuickConf(Sql, True, "1-1-2")
                Case "addspares"
                    Dim Str1, Str2, str3 As String
                    'If myContext.SQL.Exists(Params, "@PidUnitID") Then
                    '    Str1 = "IsNull(PidUnitID, 0) = " & myUtils.cValTN(myContext.SQL.ParamValue("@PidUnitID", Params)) & ""
                    'Else
                    '    Str1 = ""
                    'End If

                    Str2 = myContext.SQL.PopulateSQLParams("SOSpareID Not In (@sospareid) And isnull(BillingLot,0) = 0", Params)
                    str3 = myContext.SQL.PopulateSQLParams("SalesOrderID = @salesorderid", Params)
                    Dim sql As String = myUtils.CombineWhere(False, Str1, Str2, str3)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOSpareID""/>", True, , "<MODROW><SQLWHERE2>" & sql & "</SQLWHERE2></MODROW>")
            End Select
        End If
        Return Model
    End Function
End Class