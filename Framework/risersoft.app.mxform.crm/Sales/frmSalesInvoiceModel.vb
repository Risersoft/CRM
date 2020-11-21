Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSalesInvoiceModel
    Inherits clsFormDataModel
    Dim myViewPay, myViewDoc, myViewForms, myViewSpare, myViewService, myViewAddSpare, myViewAddSerial As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SerialItem")
        myViewPay = Me.GetViewModel("Pay")
        myViewDoc = Me.GetViewModel("Doc")
        myViewForms = Me.GetViewModel("Forms")
        myViewSpare = Me.GetViewModel("Spare")
        myViewService = Me.GetViewModel("Service")
        myViewAddSpare = Me.GetViewModel("AddSpare")
        myViewAddSerial = Me.GetViewModel("AddSerial")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "Select StatusNum, StatusText from Status Where StatusType = 'IS' Order by StatusNum"
        Me.AddLookupField("StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = "SELECT  Customer.CustomerID, Party.PartyName, Customer.CustomerClass, MainPartyID FROM  Customer INNER JOIN Party ON Customer.PartyID = Party.PartyID Order By Party.PartyName"
        Me.AddLookupField("CustomerID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Customer").TableName)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        Me.AddLookupField("docnameid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "DOC").TableName)

        sql = "select StatusNum,statustext from status where statustype='DOC' order by statusnum"
        Me.AddLookupField("doc.StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BG2").TableName)

        sql = "Select CampusID, DispName, Camp.CompanyID, DivisionCodeList, WODate, Camp.CompletedOn, TaxAreaID, GstRegID, Camp.SalesOrderID, PidUnitID, CampusCode, ProjectID from mmlistCampus() as Camp Left join SalesOrder on Camp.SalesOrderID = SalesOrder.SalesOrderID  Order by DispName"
        Me.AddLookupField("CampusID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campus").TableName)
        Me.AddLookupField("Deliverycampusid", "Campus")
        Me.AddLookupField("ProjectCampusID", "Campus")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acEditM Then
            sql = "Select * from Invoice where InvoiceID = " & prepIDX
            Me.InitData(sql, "SalesOrderID,DocType", oView, prepMode, prepIDX)

            sql = "Select ProdSerialItemID, ProdSerialItem.ProdSerialID, InvoiceItemID,  ProdSerialNum, WOInfo, LotNum from ProdSerialItem Inner join plnListProdSerial() on ProdSerialItem.ProdSerialID = plnListProdSerial.ProdSerialID  Where InvoiceItemID in (select InvoiceItemID from InvoiceItem where InvoiceID = " & frmIDX & ")"
            myView.MainGrid.QuickConf(sql, True, "1-1-1", True)

            sql = "Select SOSpareID,SpareName,Sum(Qty) as Qty from slsListSOSpareItem() Where SOSpareID in (select SOSpareID from accListInvoiceItem() where InvoiceID = " & frmIDX & ") Group By SOSpareID,SpareName"
            myViewSpare.MainGrid.QuickConf(sql, True, "1-1", True)

            sql = "Select SOServiceID,ServiceName, Qty from slsListSOService() Where SOServiceID in (select SOServiceID from accListInvoiceItem() where InvoiceID = " & frmIDX & ")"
            myViewService.MainGrid.QuickConf(sql, True, "1-1", True)

            sql = "Select ProdSerialItemID, ProdSerialItem.ProdSerialID, AddInvoiceID,  ProdSerialNum, WOInfo, LotNum from ProdSerialItem Inner join plnListProdSerial() on ProdSerialItem.ProdSerialID = plnListProdSerial.ProdSerialID  Where AddInvoiceID = " & frmIDX
            myViewAddSerial.MainGrid.QuickConf(sql, True, "1-1-1", True)

            sql = "Select SoSpareItemID, SOSpareID, AddInvoiceID,SpareName,Sum(Qty) as Qty from slsListSOSpareItem() Where AddInvoiceID = " & frmIDX & " Group By SOSpareID,SpareName,AddInvoiceID,SoSpareItemID"
            myViewAddSpare.MainGrid.QuickConf(sql, True, "1-1", True)

            sql = "Select VouchNum, Dated, PaymentMode, AmountTotPay, NewAmount, BalanceAmount from accListPaymentItem() where InvoiceID = " & frmIDX
            myViewPay.MainGrid.QuickConf(sql, True, "1-1-1-1-1-1", True)

            sql = "Select STFormID, InvoiceID, STFormMasterID, STFormNum, STFormDate, FormGiveTake, STFormOK, STFormValue, Remark from STForm  Where InvoiceID = " & frmIDX
            myViewForms.MainGrid.QuickConf(sql, True, "1-1-1-1-1-1", True)
            sql = "Select STFormMasterID, STFormName from STFormMaster"
            str1 = "<BAND IDFIELD=""STFormID"" TABLE=""STForm"" INDEX=""0""><COL KEY=""STFormID, InvoiceID, STFormNum, STFormDate, STFormValue, STFormOK, Remark""/><COL KEY=""STFormMasterID"" LOOKUPSQL=""" & sql & """/><COL KEY=""FormGiveTake"" VLIST=""G|T""/></BAND>"
            myViewForms.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

            myViewDoc.MainGrid.MainConf("headfactor") = 2
            sql = "Select DueDocID, InvoiceID, Prefix, DocNameID, Postfix, DocNumber, DocDate, NumCopies, DocDetails, StatusNum, CompletionLetter, CompletionDate, Remark from docsdue where InvoiceID = " & frmIDX
            myViewDoc.MainGrid.QuickConf(sql, True, "1-1-1-1-1-1-1-1-1-1-1", True)
            sql = "Select DocNameId, DocName, DocType from DocMaster inner join DocType on DocMaster.DocTypeId = DocType.DocTypeId order by DocType.DocTypeId, DocName"
            str1 = "<BAND IDFIELD=""DueDocID"" TABLE=""DocsDue"" INDEX=""0""><COL KEY=""DueDocID, InvoiceID, Prefix, Postfix, DocNumber, DocDate, NumCopies, DocDetails, CompletionLetter, CompletionDate, Remark""/><COL KEY=""DocNameID"" LOOKUPSQL=""" & sql & """/><COL KEY=""StatusNum"" LOOKUPSQL=""Select StatusNum, StatusText from Status Where StatusType = 'DOC' Order by StatusNum""/></BAND>"
            myViewDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

            Dim dic As New clsCollecString(Of String)
            dic.Add("SalesOrder", "Select * from SalesOrder where SalesOrderID = " & myUtils.cValTN(myRow("SalesOrderID")) & "")
            Me.AddDataSet("SalesOrder", dic)

            sql = "Select ProjectID from SalesOrder where SalesOrderID  = " & myUtils.cValTN(myRow("SalesOrderID")) & ""
            Dim dt1 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            If dt1.Rows.Count > 0 Then
                Me.ModelParams.Add(New clsSQLParam("@ProjectID", myUtils.cValTN(dt1.Rows(0)("ProjectID")), GetType(Integer), False))
            End If

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If (Not Me.SelectedRow("DeliveryCampusID") Is Nothing) AndAlso (myUtils.cValTN(SelectedRow("DeliveryCampusID")("SalesOrderID"))) > 0 Then
            If myUtils.cValTN(SelectedRow("DeliveryCampusID")("SalesOrderID")) <> myUtils.cValTN(myRow("SalesOrderID")) Then Me.AddError("", "Please Select Correct Sales Order")
        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim InvoiceDescrip As String = " Sales Invoice No: " & myRow("InvoiceNum").ToString & " Dt. " & Format(myRow("InvoiceDate"), "dd-MMM-yyyy")
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "InvoiceID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from Invoice where InvoiceID  = " & frmIDX)
                frmIDX = myRow("InvoiceID")

                Me.myViewDoc.MainGrid.SaveChanges(, "InvoiceID = " & frmIDX)
                Me.myViewForms.MainGrid.SaveChanges(, "InvoiceID = " & frmIDX)

                myUtils.ChangeAll(myViewAddSerial.MainGrid.myDS.Tables(0).Select, "AddInvoiceID=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myViewAddSerial.MainGrid.myDS.Tables(0), "Select ProdSerialItemID, ProdSerialID,AddInvoiceID from ProdSerialItem")

                myUtils.ChangeAll(myViewAddSpare.MainGrid.myDS.Tables(0).Select, "AddInvoiceID=" & frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myViewAddSpare.MainGrid.myDS.Tables(0), "Select SOSpareItemID,SOSpareID,AddInvoiceID,Qty from SOSpareItem")

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(InvoiceDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(InvoiceDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

    Public Overrides Function GenerateIDOutput(dataKey As String, frmIDX As Integer) As clsProcOutput
        Dim oRet As New clsProcOutput
        Select Case dataKey.Trim.ToLower
            Case "salesorderdescrip"
                Dim sql As String = "Select OrderNum, OrderDate  from SalesOrder  where SalesOrderID = " & myUtils.cValTN(frmIDX)
                Dim dt2 As DataTable = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt2.Rows.Count > 0 Then oRet.Description = "Sales Order :- " & myUtils.cStrTN(dt2.Rows(0)("OrderNum")) & " Date - " & Format(dt2.Rows(0)("OrderDate"), "dd-MMM-yyyy")
        End Select
        Return oRet
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), Model As clsViewModel = Nothing
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "prodserial"
                    Dim strf1 As String = myContext.SQL.PopulateSQLParams("SalesOrderID = @SalesOrderID  and ProdSerialID not in (@ProdSerialID)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""ProdSerialID""/>", True)

                Case "sospare"
                    Dim strf1 As String = myContext.SQL.PopulateSQLParams("SalesOrderID = @SalesOrderID and SOSpareID not in (@SOSpareID)", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SOSpareID""/>", True)

                Case "salesorder"
                    Dim sql As String = myContext.SQL.PopulateSQLParams("MainPartyID = @MainPartyID and CompanyID = @CompanyId and SalesOrderID Not in (@SalesOrderID) and (isnull(OrderDate,'3099-Jan-01') <= '@InvoiceDate' or isnull(LOIDate,'3099-Jan-01') <= '@InvoiceDate')", Params)
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""SalesOrderID""/>", False, , "<MODROW><SQLWHERE2>" & XMLUtils.ReplaceSpecialChars(sql) & "</SQLWHERE2></MODROW>")
            End Select
        End If
        Return Model
    End Function
End Class
