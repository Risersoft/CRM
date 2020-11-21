Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmRepairUnitModel
    Inherits clsFormDataModel
    Dim myVueInspBy, myVueAttendBy, myVueSpare, myVueService As clsViewModel, sql As String

    Protected Overrides Sub InitViews()
        myVueInspBy = Me.GetViewModel("InspBy")
        myVueAttendBy = Me.GetViewModel("AttendBy")
        myVueSpare = Me.GetViewModel("Spare")
        myVueService = Me.GetViewModel("Service")
        myView = Me.GetViewModel("RepUnitItem")
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "Select statusnum, statustext from status where statustype='ru' order by statusnum"
        Me.AddLookupField("RUStatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "ru").TableName)

        sql = "Select statusnum, statustext from status where statustype='ji' order by statusnum"
        Me.AddLookupField("JInspStatusNum", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "JINSP").TableName)

        sql = "Select itemunitid, unitname from itemunits order by unitname"
        Me.AddLookupField("itemunitid", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "unit").TableName)
        Me.AddLookupField("ComboUnit2", "unit")
    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean
        Dim str1 As String

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from repairunit where repairunitid = " & prepIDX
        Me.InitData(sql, "workorderid", oView, prepMode, prepIDX, strXML)

        sql = "Select distinct itemid, isETO, etodescripattribid, etotechdescripattribid, etosku2attribid, itemunitid, itemname, itemunitid2 from slslistworo() where workorderid = " & myUtils.cValTN(myRow("workorderid"))
        myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "unit1")

        sql = myContext.SQL.Join2(myContext.SQL.Join2(myContext.SQL.Join1("soperson", "persparty", "perspartyid"), "persons", "persparty", "personid"), "party", "persparty", "partyid")
        myVueInspBy.MainGrid.QuickConf("Select sopersonid,repairunitid, soperson.perspartyid, persons.FullName, Party.PartyName from " & sql & " where soperson.repairunitid = " & frmIDX, True, "1-1", True, "Inspected By")
        myVueInspBy.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""sopersonid"" TABLE=""soperson""><COL KEY=""repairunitid,persPartyid""/></BAND>", EnumEditType.acCommandOnly)

        myVueAttendBy.MainGrid.QuickConf("Select SOPersonID,repairunitid, sle.UserID, sle.FullName from SOPerson as iw inner join genListUser() as sle on sle.UserID = iw.AttendedByID where iw.repairunitid = " & frmIDX, True, , , "Attended By")
        myVueAttendBy.MainGrid.PrepEdit("<BAND INDEX=""0"" IDFIELD=""SOPersonID"" TABLE=""SOPerson""><COL KEY=""repairunitid""/><COL KEY=""UserID"" FIELD=""AttendedByID""/></BAND>", EnumEditType.acCommandOnly)

        myView.Mode = EnumViewMode.acSelectM : myView.MultiSelect = True
        myView.MainGrid.QuickConf("select RepairUnitItemID,repairunitid,RepairItemID, QtyOK,QtyMiss,QtyDamage,QtyEst,QtyAct,RepairItemID as Unit,Amount,Remark from RepairUnitItem where repairunitid = %frmidx%", True, "4-1-1-1-1-1-1-1-3", True)
        myContext.Data.ReverseTick(myView.MainGrid.myDS.Tables(0), "Select RepairItemID, RepairItemID as unit from RepairItem", "RepairItemID")
        myView.MainGrid.PrepEdit("<BAND IDFIELD=""RepairUnitItemID"" TABLE=""RepairUnitItem"" INDEX=""0""><COL KEY=""RepairItemID"" LOOKUPSQL=""Select RepairItemID,RepairItemName from RepairItem"" CAPTION=""Item""/><COL KEY=""Unit"" LOOKUPSQL=""Select RepairItemID,UnitName from RepairItem"" SKIP=""True""/><COL KEY=""QtyOK,QtyMiss,QtyDamage,QtyEst,QtyAct,Remark,Amount,repairunitid""/></BAND>", EnumEditType.acCommandAndEdit)

        myVueSpare.MainGrid.MainConf("headfactor") = 2
        myVueSpare.MainGrid.QuickConf("select sospareid, pidunitid, repairunitid,SpareName,TransType,ValuationClass,HSN_SC,Qty,ItemUnitID,UnitPrice,Freight,TotalWt,BillingLot from sospare where repairunitid = " & frmIDX, True, "4-1-2-1-1-1-1-1-1-1", True)
        sql = "Select Class from AccountClass where ClassType = 'M' and ClassSubType in ('S','B')"
        Dim sql1 As String = "Select Code, Code + ' | ' + Description from HSNsac where Ty = 'G' Order By Code"
        str1 = "<BAND IDFIELD=""sospareid"" TABLE=""sospare"" INDEX=""0""><COL KEY=""repairunitid,pidunitid,SpareName,qty,unitprice,freight,totalwt""/><COL KEY=""ValuationClass"" LOOKUPSQL=""" & sql & """/><COL KEY=""TransType"" VLIST=""ST|FG""/><COL KEY=""BillingLot"" CAPTION=""Billing"" VLIST=""0;Qty|1;Lot""/><COL KEY=""HSN_SC"" WFACTOR=""2"" CAPTION=""HSN Code"" LOOKUPSQL=""" & sql1 & """/><COL KEY=""ItemUnitID"" CAPTION=""Unit Name"" LOOKUPSQL=""Select ItemUnitID,UnitName from ItemUnits""/></BAND>"
        myVueSpare.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        myVueService.MainGrid.MainConf("headfactor") = 2
        myVueService.MainGrid.QuickConf("select soserviceid, pidunitid, repairunitid,ServiceName,ServiceType,ValuationClass,HSN_SC, Qty,ItemUnitID,UnitPrice from soservice where repairunitid = " & frmIDX, True, "4-2-2-1-1-1-1", True)
        sql = "Select Class from AccountClass where ClassType = 'S' and ClassSubType in ('S','B')"
        sql1 = "Select Code, Code + ' | ' + Description from HSNsac where Ty = 'S' Order By Code"
        str1 = "<BAND IDFIELD=""soserviceid"" TABLE=""soservice"" INDEX=""0""><COL KEY=""repairunitid,pidunitid,ServiceName,qty,unitprice""/><COL KEY=""ValuationClass"" LOOKUPSQL=""" & sql & """/><COL KEY=""HSN_SC"" WFACTOR=""2"" CAPTION=""HSN Code"" LOOKUPSQL=""" & sql1 & """/><COL KEY=""ItemUnitID"" CAPTION=""Unit Name"" LOOKUPSQL=""Select ItemUnitID,UnitName from ItemUnits""/><COL KEY=""SERVICETYPE""" & myFuncsBase.strGridConfEnd("wo", "servicetype", "") & "</BAND>"
        myVueService.MainGrid.PrepEdit(str1, EnumEditType.acCommandAndEdit)

        If dsCombo.Tables("unit1").Select.Length > 0 Then
            Dim rWO As DataRow = dsCombo.Tables("unit1").Rows(0)
            Me.DatasetCollection.Add("var", myPIDU.LoadItemVarData(myContext, myUtils.cValTN(rWO("itemid")), "repairunitid", frmIDX))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function GenerateParamsModel(vwState As clsViewState, SelectionKey As String, Params As List(Of clsSQLParam)) As clsViewModel
        Dim oRet As clsProcOutput = myContext.SQL.ValidateSQLParams(Params), Model As clsViewModel = Nothing, eConf As New clsBandConf()
        If oRet.Success Then
            Select Case SelectionKey.Trim.ToLower
                Case "repairunit"
                    Dim strf1 As String = myContext.SQL.PopulateSQLParams("UserID not in (@UserIDcsv)", Params)
                    eConf.QuickConf2("Select UserID, FullName from genListUser() where " & myUtils.CombineWhere(False, "isdeleted=0", "(insaleslist=1 or inqualitylist=1)", strf1))
                    eConf("currview") = "listUserhelp"
                    Model = myContext.Provider.GenerateSelectionModel(vwState, "<SYS ID=""USERID""/>", True, eConf)
            End Select
            Return Model
        End If
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()

        If Me.SelectedRow("RUStatusNum") Is Nothing Then Me.AddError("RUStatusNum", "Select a status")
        Me.myVueSpare.MainGrid.CheckValid("SpareName,qty,transtype", , "Spares", "<CHECK COND=""Qty>0"" MSG=""Quantity should be greater than 0""/>")
        Me.myVueService.MainGrid.CheckValid("ServiceName,servicetype,qty", , "Services", "<CHECK COND=""Qty>0"" MSG=""Quantity should be greater than 0""/>")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim str1 As String = ""
        VSave = False
        If Me.Validate Then
            Dim repairunitDescrip As String = myRow("DescripWO").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "repairunitid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from repairunit where repairunitid = " & frmIDX)
                frmIDX = myRow("repairunitid")

                If myUtils.cStrTN(myRow("codenum")).Trim.Length > 0 Then str1 = myRow("codenum") Else str1 = "NIL"
                Dim nr1 As DataRow = myPIDU.SavePIDUnitID(myContext, myRow.Row, "repairunitid", frmIDX, "", str1)
                Dim oProc As New clsPIDUnitProc(myContext)
                oProc.UpdateProductionStatus(nr1("pidunitid"))
                Me.DatasetCollection.AddUpd("var", myPIDU.SavePIDUnitETO(myContext, nr1, dsCombo.Tables("unit1").Rows(0), myRow.Row, myUtils.cValTN(myRow("totalqty")), myUtils.cValTN(myRow("totalqty2"))))

                Dim str2 As String = "repairunitid=" & frmIDX
                Me.myVueInspBy.MainGrid.SaveChanges(, str2)
                Me.myVueAttendBy.MainGrid.SaveChanges(, str2)
                Me.myView.MainGrid.SaveChanges(, str2)
                Me.myVueSpare.MainGrid.SaveChanges(, str2 & ",pidunitid=" & nr1("pidunitid"))
                Me.myVueService.MainGrid.SaveChanges(, str2 & ",pidunitid=" & nr1("pidunitid"))

                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(repairunitDescrip, frmIDX)
                VSave = True
            Catch ex As Exception
                myContext.Provider.dbConn.RollBackTransaction(repairunitDescrip, ex.Message)
                Me.AddError("", ex.Message)
            End Try
        End If
    End Function
End Class
