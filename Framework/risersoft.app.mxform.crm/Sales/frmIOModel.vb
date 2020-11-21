Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmIOModel
    Inherits clsFormDataModel
    Dim myVueTF As clsViewModel
    Dim dvDivision As DataView

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("TT")
        myVueTF = Me.GetViewModel("TF")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        Dim sql As String

        sql = "select itemid, itemcode, itemname,unitname,unitname2, IsETO, ETODescripAttribID, ETOTechDescripAttribID, ETOSKU2AttribID, itemunitid, itemunitid2 from invlistitems() where acceptwo=1 order by itemname"
        Me.AddLookupField("ItemID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Items").TableName)

        sql = "Select CompanyID, CompName  from Company  Order by CompName"
        Me.AddLookupField("CompanyID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Company").TableName)

        sql = "select Divisionid, DivisionCode, DivisionName, CompanyID from Division order by DivisionCode"
        Me.AddLookupField("DivisionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Division").TableName)

        sql = "select matdepid, depname, WODate,CompletedOn,CompanyID from mmListDepsMat() where acceptswo=1 order by depname"
        Me.AddLookupField("MatDepID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Deps").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from InternalOrder where InternalOrderID = " & prepIDX
        Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        If frmMode = EnumfrmMode.acAddM Then myRow("OrderDate") = Now.Date

        myView.MainGrid.MainConf("headfactor") = 2 : myView.MainGrid.MainConf("autorowht") = True
        myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
        sql = "select TypeTestReqID,InternalOrderID, typetestmaster.strtypespecaddl, TypeTestReq.TypeTestID, TypeTestReq.ForOneUnit, Charges, TTType,TestDate,DoWePay, AcceptReport,CustWitness,Failed,Waived,ProdSerialID from TypeTestReq inner join typetestmaster on TypeTestReq.TypeTestID = typetestmaster.TypeTestID where InternalOrderID = %frmidx%"
        myView.MainGrid.MainConf("formatxml") = "<COL KEY=""strtypespecaddl"" CAPTION=""Cat""/>"
        myView.MainGrid.QuickConf(sql, True, "1-4.5-2-2-1-1.5-1-1-1-1-1-3", True)
        sql = "select TypeTestID,testname from typetestmaster order by testname"
        str1 = "<BAND IDFIELD=""TypeTestReqID"" TABLE=""TypeTestReq"" INDEX=""0""><COL KEY=""InternalOrderID""/><COL KEY=""ForOneUnit"" CAPTION=""Quantum"" VLIST=""False;Each Unit|True;One Unit"" DEFAULTVALUE=""True""/><COL CAPTION=""Test"" KEY=""TypeTestID"" NOEDIT=""True"" LOOKUPSQL=""" & sql & """/><COL KEY=""dowepay"" CAPTION=""Do WePay""/><COL KEY=""custwitness"" CAPTION=""Cust. Witness""/><COL KEY=""testdate"" CAPTION=""Date""/><COL KEY=""AcceptReport"" CAPTION=""Accept Report""/><COL KEY=""failed,waived"" DEFAULTVALUE=""False""/><COL KEY=""Charges""/><COL KEY=""ProdSerialID"" CAPTION=""Serial"" LOOKUPSQL=""select prodserialid,prodserialnum from plnListProdSerial() where InternalOrderID = " & frmIDX & """/><COL KEY=""TTTYpe"" CAPTION=""Type""/></BAND>"
        myView.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)
        myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), "select strtypespecaddl, TypeTestID, foroneunit from typetestmaster where typespecaddl<4 order by TypeTestID", "TypeTestID")

        myVueTF.MainGrid.MainConf("formatxml") = "<COL KEY=""statusnum"" LOOKUPSQL=""Select statusnum, statustext from status where statustype='PS' order by statusnum"" CAPTION=""Status""/>"
        myVueTF.MainGrid.QuickConf("select prodserialid,InternalOrderID,ProdSerialNum,Weight,StatusNum from plnListProdSerial() where InternalOrderID = " & frmIDX, True, "0-3-1-3", True)

        '---codesys handlecombo in last so that all views and dataviews are ready. for example myvueratelist.maingrid.mydv
        If frmMode = EnumfrmMode.acAddM Then
            If Me.dsCombo.Tables("items").Rows.Count = 1 Then myRow("itemid") = Me.dsCombo.Tables("items").Rows(0)("itemid")
        End If

        myContext.Data.AddSQLTable(Me.dsForm, "select fittingreqid, internalorderid, isstandard, fittingid from fittingreq where internalorderid = " & frmIDX, "fitting")
        myContext.Data.AddSQLTable(Me.dsCombo, "select fittingid, itemid, isstandard,fittingname from FittingMaster", "fittingmaster")
        Me.DatasetCollection.Add("var", myPIDU.LoadItemVarData(myContext, myUtils.cValTN(myRow("itemid")), "internalorderid", frmIDX))

        Me.FormPrepared = True
        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("OrderNum")).Trim.Length = 0 Then Me.AddError("OrderNum", "Please enter a Internal Order Number")
        If myUtils.NullNot(myRow("OrderDate")) Then Me.AddError("OrderDate", "Please enter a Internal Order Date")
        If Me.SelectedRow("ItemId") Is Nothing Then Me.AddError("ItemID", "Select an Item")
        If Me.SelectedRow("CompanyID") Is Nothing Then Me.AddError("CompanyID", "Please Select Company")
        If myUtils.cValTN(myRow("Qty")) <= 0 Then Me.AddError("Qty", "Please Enter Quantity")
        Me.myView.MainGrid.CheckValid("TypeTestId")
        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim IODescrip As String = " Internal Order No: " & myRow("OrderNum").ToString & " Dt. " & Format(myRow("OrderDate"), "dd-MMM-yyyy")
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "InternalOrderID", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from InternalOrder where InternalOrderID = " & frmIDX)
                frmIDX = myRow("InternalOrderID")
                frmMode = EnumfrmMode.acEditM
                Dim nr1 As DataRow = myPIDU.SavePIDUnitID(myContext, myRow.Row, "InternalOrderID", frmIDX, "", myUtils.cStrTN(myRow("OrderNum")))
                Dim oProc As New clsPIDUnitProc(myContext)
                oProc.UpdateProductionStatus(nr1("pidunitid"))
                Me.DatasetCollection.AddUpd("var", myPIDU.SavePIDUnitETO(myContext, nr1, Me.SelectedRow("ItemId"), myRow.Row, myUtils.cValTN(myRow("Qty")), myUtils.cValTN(myRow("Qty2"))))

                Dim str2 As String = "InternalOrderID=" & frmIDX
                Me.myView.MainGrid.SaveChanges(, str2)
                myUtils.ChangeAll(Me.dsForm.Tables("fitting").Select, str2)
                myContext.Provider.objSQLHelper.SaveResults(Me.dsForm.Tables("fitting"), "Select fittingreqid, internalorderid, isstandard, fittingid from fittingreq where internalorderid = " & frmIDX)
                VSave = True

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(IODescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(IODescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function
End Class
