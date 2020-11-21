Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmSalesEnqItemModel
    Inherits clsFormDataModel
    Dim myVueSpare, myVueTT, myVueCQ, myVueDoc, myVueService As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myVueSpare = Me.GetViewModel("Spare")
        myVueCQ = Me.GetViewModel("CQ")
        myVueTT = Me.GetViewModel("TT")
        myVueDoc = Me.GetViewModel("Doc")
        myVueService = Me.GetViewModel("Service")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "select MatDepID, DepName, WODate,CompletedOn from mmListDepsMat() where acceptswo=1 order by depname"
        Me.AddLookupField("MatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Deps").TableName)

        Dim lst As New List(Of String)
        lst.Add("Per Unit")
        lst.Add("Per Day")
        Me.ValueLists.Add("SuperChType", myContext.SQL.VListFromList(lst))
        Me.AddLookupField("SuperChType", "SuperChType")

        sql = "select itemid, itemcode, itemname,unitname,unitname2, IsETO, ETODescripAttribID, ETOTechDescripAttribID, ETOSKU2AttribID, itemunitid, itemunitid2 from invlistitems() where acceptwo=1 order by itemname"
        Me.AddLookupField("itemid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from salesenqitem where salesenqitemid = " & prepIDX
        Me.InitData(sql, "salesenqid", oView, prepMode, prepIDX, strXML)

        Dim dic As New clsCollecString(Of String)
        dic.Add("SalesEnq", "Select * from salesenq where salesenqid = " & myUtils.cValTN(myRow("salesenqid")))
        Me.AddDataSet("SalesEnq", dic)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("select TEDocSubmitID,salesenqitemid,docnameid, PageNum, ClauseNum, AsPerTender, ToBeQuoted,CustFormat,SendTyp,Remark from tedocsubmit where salesenqitemid = " & frmIDX, True, "0-5-1-1-3-3-1-1-3", True)
        myVueDoc.MainGrid.MainConf("FORMATXML") = myVueDoc.MainGrid.MapColXML(0, False, "custformat|Customer Format", "sendtyp|Send Typical", "docnameid|Document")
        str1 = "<BAND IDFIELD=""TEDocSubmitid"" TABLE=""tedocsubmit"" INDEX=""0""><COL KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """><OVERRIDE><STRWIDTH>0-1-1</STRWIDTH></OVERRIDE></COL><COL KEY=""sendtyp,CustFormat"" DEFAULTVALUE=""False""/><COL KEY=""AsPerTender,ToBeQuoted,PageNum,ClauseNum,Remark,salesenqitemid""/></BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        sql = "select TypeTestID,testname from TypeTestMaster order by testname"
        myVueTT.MainGrid.MainConf("headfactor") = 2
        myVueTT.MainGrid.QuickConf("select TypeTestreqid,salesenqitemid,TypeTestID, PageNum, ClauseNum, Charges, TTType,DoWePay, AcceptReport,OnlyReport,ActualRating from TypeTestReq where salesenqitemid = " & frmIDX, True, "0-5-1-1-1-1-1-1-1-3", True)
        str1 = "<BAND IDFIELD=""typetestreqid"" TABLE=""TypeTestReq"" INDEX=""0""><COL CAPTION=""Test"" KEY=""TypeTestID"" LOOKUPSQL=""" & sql & """/><COL KEY=""dowpay,acceptreport,onlyreport"" DEFAULTVALUE=""False""/><COL KEY=""PageNum,ClauseNum,Charges,salesenqitemid""/><COL KEY=""ActualRating"" BIGTEXT=""TRUE""/><COL KEY=""TTTYpe"" CAPTION=""Type"" VLIST=""LV|HV|Both|N.A.""/></BAND>"
        myVueTT.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueSpare.MainGrid.MainConf("headfactor") = 2
        myVueSpare.MainGrid.QuickConf("select sospareid, salesenqitemid,pidunitid,SpareName,TransType,Qty,UnitName,UnitPrice,Freight,TotalWt,BillingLot from sospare where salesenqitemid = " & frmIDX, True, "4-1-1-1-1-1-1-1", True)
        str1 = "<BAND IDFIELD=""sospareid"" TABLE=""sospare"" INDEX=""0""><COL KEY=""salesenqitemid,SpareName,qty,unitname,unitprice,freight,totalwt""/><COL KEY=""TransType"" VLIST=""ST|FG"" NOEDIT=""True""/><COL KEY=""BillingLot"" CAPTION=""Billing"" VLIST=""0;Qty|1;Lot""/></BAND>"
        myVueSpare.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueService.MainGrid.MainConf("headfactor") = 2
        myVueService.MainGrid.QuickConf("select soserviceid,salesenqitemid,pidunitid,ServiceName,ServiceType, Qty,UnitName,UnitPrice from soservice where salesenqitemid = " & frmIDX, True, "4-2-1-1-1", True)
        str1 = "<BAND IDFIELD=""soserviceid"" TABLE=""soservice"" INDEX=""0""><COL KEY=""salesenqitemid,ServiceName,qty,unitname,unitprice""/><COL KEY=""SERVICETYPE""" & myFuncsBase.strGridConfEnd("wo", "servicetype", "") & "</BAND>"
        myVueService.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        myVueCQ.MainGrid.QuickConf("select tecompquoteid,salesenqitemid,supplierid,QtyQuote,QtyGot,Rate,Position from tecompquote where salesenqitemid = " & frmIDX, True, "0-4-1-1-1-1")
        str1 = "<BAND IDFIELD=""tecompquoteid"" TABLE=""tecompquote"" INDEX=""0""><COL KEY=""qtyquote,salesenqitemid,qtygot,rate,position""/><COL KEY=""supplierid"" LOOKUPSQL=""select partyid,partyname from genlistparty() where iscompetitor=1 order by partyname"" CAPTION=""Supplier""/></BAND>"
        myVueCQ.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)


        myContext.Data.AddSQLTable(Me.dsForm, "select fittingreqid, salesenqitemid, isstandard, fittingid from fittingreq where salesenqitemid = " & frmIDX, "fitting")
        myContext.Data.AddSQLTable(Me.dsCombo, "select fittingid, itemid, isstandard,fittingname from FittingMaster", "fittingmaster")
        Me.DatasetCollection.Add("var", myPIDU.LoadItemVarData(myContext, myUtils.cValTN(myRow("itemid")), "salesenqitemid", frmIDX))

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean

        Me.InitError()
        If Me.SelectedRow("ItemID") Is Nothing Then Me.AddError("ItemID", "Select an Item")
        Me.myVueDoc.MainGrid.CheckValid("docnameid")
        Me.myVueTT.MainGrid.CheckValid("TypeTestID")
        Me.myVueSpare.MainGrid.CheckValid("SpareName,qty")
        Me.myVueCQ.MainGrid.CheckValid("supplierid")
        Me.myVueService.MainGrid.CheckValid("ServiceName,servicetype,qty", , "Services", "<CHECK COND=""Qty>0"" MSG=""Quantity should be greater than 0""/>")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim str2 As String, rTE As DataRow

        VSave = False

        If Me.Validate Then
            Dim salesenqitemDescrip As String = myRow("DescripWO").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "salesenqitemid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from salesenqitem where salesenqitemid = " & frmIDX)
                frmIDX = myRow("salesenqitemid")
                rTE = Me.DatasetCollection("SalesEnq").Tables("SalesEnq").Rows(0)

                Dim nr1 As DataRow = myPIDU.SavePIDUnitID(myContext, myRow.Row, "salesenqitemid", myRow("salesenqitemid"), rTE("enqtype"), myUtils.Coalesce(myUtils.cStrTN(myRow("enqitemrefnum")), rTE("enqrefnum")))
                Me.DatasetCollection.AddUpd("var", myPIDU.SavePIDUnitETO(myContext, nr1, Me.SelectedRow("itemid"), myRow.Row, myUtils.cValTN(myRow("qtyapt")), myUtils.cValTN(myRow("qtyapt2"))))

                sql = "update projects set mainteid=(select top 1 SalesEnqID from slsListEnq() " &
                      " where (slsListEnq.projectid = projects.projectid and slsListEnq.iscompleted=0) group by projectid, SalesEnqID order by sum(qtyapt) desc)"
                myContext.Provider.objSQLHelper.ExecuteNonQuery(CommandType.Text, sql)

                str2 = "salesenqitemid=" & frmIDX
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                Me.myVueTT.MainGrid.SaveChanges(, str2)
                Me.myVueSpare.MainGrid.SaveChanges(, myUtils.MakeCSV(",", "pidunitid=" & nr1("pidunitid"), str2, "TRANSTYPE=ST"))
                Me.myVueService.MainGrid.SaveChanges(, str2 & ",pidunitid=" & nr1("pidunitid"))
                Me.myVueCQ.MainGrid.SaveChanges(, str2)

                myUtils.ChangeAll(Me.dsForm.Tables("fitting").Select, str2)
                myContext.Provider.objSQLHelper.SaveResults(Me.dsForm.Tables("fitting"), "Select fittingreqid, salesenqitemid, isstandard, fittingid from fittingreq where salesenqitemid = " & frmIDX)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(salesenqitemDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(salesenqitemDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
