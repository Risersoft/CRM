Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmInspecModel
    Inherits clsFormDataModel
    Dim myVueAttEmp, myVueInspBy, myVueDoc As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myView = Me.GetViewModel("SerialItem")
        myVueAttEmp = Me.GetViewModel("AttUser")
        myVueInspBy = Me.GetViewModel("InspBy")
        myVueDoc = Me.GetViewModel("Doc")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()

        sql = "Select campusid, dispname, WODate, CompletedOn from mmlistCampus() order by dispname"
        Me.AddLookupField("campusid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Campus").TableName)

        sql = "select StatusNum, statustext from status where statustype='ins' order by statusnum"
        Me.AddLookupField("StatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Status").TableName)

        sql = myFuncsBase.CodeWordSQL("inspection", "type", "")
        Me.AddLookupField("InspecType", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "InspecType").TableName)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        Me.AddLookupField("docnameid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "DOC").TableName)

        sql = "select statusnum,statustext from status where statustype='DOC' order by statusnum"
        Me.AddLookupField("doc.statusnum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "BG2").TableName)

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from inspection where inspectionid = " & prepIDX
        Me.InitData(sql, "salesorderid", oView, prepMode, prepIDX, strXML)

        myVueInspBy.MainGrid.QuickConf("Select SOPersonID, inspectionid, perspartyid, FullName, PartyName from slsListSOPerson() where inspectionid = " & frmIDX, True, "1-1", True, "Inspected By")
        myVueInspBy.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""SOPersonID"" TABLE=""SOPerson""><COL KEY=""inspectionid""/><COL KEY=""perspartyid""/></BAND>", EnumEditType.acCommandOnly)

        myVueAttEmp.MainGrid.QuickConf("select SOPersonID, InspectionID, UserID, FullName from slslistSOUser() where InspectionID = " & frmIDX, True, , , "Attended By")
        myVueAttEmp.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""SOPersonID"" TABLE=""SOPerson""><COL KEY=""inspectionid""/><COL KEY=""UserID"" FIELD=""AttendUserID""/></BAND>", EnumEditType.acCommandOnly)

        myView.MultiSelect = True : myView.Mode = EnumViewMode.acSelectM
        myView.MainGrid.QuickConf("select inspectionid,ProdSerialItemID,ProdSerialID,ProdSerialNum,DescripWO from slsListJoinInspWO() where inspectionid = %frmidx%", True, "1-1-2", True, "Serial Nos.")
        myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), "select * from plnListProdSerial() where salesorderid=" & myRow("salesorderid"), "ProdSerialID")
        myView.MainGrid.PrepEdit("<BAND INDEX=""0"" TABLE=""ProdSerialItem"" IDFIELD=""ProdSerialItemID""><COL KEY=""INSPECTIONID,ProdSerialID""/></BAND>", EnumEditType.acCommandOnly)

        sql = "select docnameid, DocName, DocType from docmaster inner join doctype on docmaster.doctypeid = doctype.doctypeid order by doctype.doctypeid, docname"
        myVueDoc.MainGrid.MainConf("headfactor") = 2
        myVueDoc.MainGrid.QuickConf("select inspectionid,duedocid,remark,numcopies,completionletter,completiondate,Prefix,docnameid,Postfix,DocNumber,DocDate,DocDetails,Statusnum from docsdue where inspectionid = " & frmIDX, True, "1-3-1-1-1-1-2", True)
        myVueDoc.MainGrid.MainConf("FormatXML") = "<COL KEY=""docnameid"" WFACTOR=""2"" LOOKUPSQL=""" & sql & """ CAPTION=""Document""/><COL KEY=""statusnum"" CAPTION=""Status"" LOOKUPSQL=""select statusnum,statustext from status where statustype='DOC' order by statusnum"" WFACTOR=""2""/>"""
        str1 = "<BAND INDEX=""0"" IDFIELD=""duedocid"" TABLE=""DOCSDUE"">" & myVueDoc.MainGrid.BuildBandEditXML(0) & "</BAND>"
        myVueDoc.MainGrid.PrepEdit(str1, EnumEditType.acCommandOnly)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), Model As clsViewModel = Nothing, eConf As New clsBandConf()

        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "attendby"
                    Dim strf1 As String = myContext.SQL.PopulateSQLParams("UserID not in (@UserIDcsv)", Params)
                    eConf.QuickConf2("Select UserID, fullname from genListUser() where " & myUtils.CombineWhere(False, "isdeleted=0", "(insaleslist=1 or inqualitylist=1)", strf1))
                    eConf("currview") = "listemphelp"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""USERID""/>", True, eConf)
            End Select
        End If
        Return Model
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If Me.SelectedRow("StatusNum") Is Nothing Then Me.AddError("StatusNum", "Select a status")
        If Me.SelectedRow("InspecType") Is Nothing Then Me.AddError("InspecType", "Select an inspection type")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim InspecTypeDescrip As String = Me.SelectedRow("InspecType")("Descrip")
            Dim StatusNumDescrip As String = Me.SelectedRow("StatusNum")("StatusText")
            Dim InspecDescrip As String = " Inspection Status: " & StatusNumDescrip & ", InspectionType: " & InspecTypeDescrip
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "inspectionid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from inspection where inspectionid  = " & frmIDX)
                frmIDX = myRow("inspectionid")

                Dim str2 As String = "inspectionid=" & frmIDX
                Me.myVueDoc.MainGrid.SaveChanges(, str2)
                Me.myView.MainGrid.SaveChanges(, str2)
                Me.myVueAttEmp.MainGrid.SaveChanges(, str2)
                Me.myVueInspBy.MainGrid.SaveChanges(, str2)

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(InspecDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(InspecDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
    End Function
End Class
