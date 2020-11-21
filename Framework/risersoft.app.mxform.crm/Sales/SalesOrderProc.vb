Imports risersoft.shared
Imports risersoft.app.mxent

Public Class SalesOrderProc
    Inherits clsVouchProcBase

    Public Overrides Function LoadVouch(VouchID As Integer) As DataTable
        Dim dic As clsCollecString(Of String) = Me.dicLoadVouch(VouchID)
        Dim ds1 As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        Return ds1.Tables(0)
    End Function

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
    End Sub

    Protected Overrides Function dicLoadVouch(SalesOrderID As Integer) As clsCollecString(Of String)
        Dim str1 As String = "SalesOrderID=" & SalesOrderID
        Dim str2 As String = "WorkOrderID In (Select WorkOrderID from WorkOrder where SalesOrderID=" & SalesOrderID & ")"

        Dim dic1 As New clsCollecString(Of String)
        dic1.Add("so", "Select * from SalesOrder where " & str1)
        dic1.Add("wo", "Select * from WorkOrder where " & str1)
        dic1.Add("soc", "Select * from SOCommTerm where " & str1)
        dic1.Add("sod", "Select * from SODocSubmit where " & str1)
        dic1.Add("sob", "Select * from BGCustomer where " & str1)
        dic1.Add("sop", "Select * from soperson where " & str1)
        dic1.Add("sot", "Select * from SoTransport where " & str1)
        dic1.Add("sov", "Select * from SalesOrderValue where " & str1)

        dic1.Add("wod", "Select * from wodelsched where " & str2)
        dic1.Add("dd", "Select * from DocsDue where " & str2)
        dic1.Add("ttr", "Select * from TypeTestReq where " & str2)
        dic1.Add("sp", "Select * from sospare where " & str2)
        dic1.Add("srv", "Select * from soservice where " & str2)
        dic1.Add("fit", "Select * from fittingreq where " & str2)

        Return dic1
    End Function

    Public Function Copy(SalesOrderID As Integer, NewCustID As Integer, NewLOINum As String, NewLOIDate As DateTime, NewPONum As String, NewPODate As DateTime, dtWO As DataTable) As clsProcOutput
        Dim NewSalesOrderID As Integer, oRet As New clsProcOutput
        myContext.Provider.dbConn.BeginTransaction(myContext, "frmCopySOModel", EnumfrmMode.acAddM, "SalesOrderID")
        Try
            Dim dic As clsCollecString(Of String) = Me.dicLoadVouch(0)
            Dim ds1 As DataSet = Me.LoadVouch(SalesOrderID).DataSet
            Dim ds2 As DataSet = Me.LoadVouch(0).DataSet

            For Each rSO As DataRow In ds1.Tables("so").Select
                'single run loop
                Dim nr1 As DataRow = myUtils.CopyOneRow(rSO, ds2.Tables("so"))
                nr1("LoINum") = NewLOINum
                nr1("LOIDate") = NewLOIDate
                nr1("PONum") = NewPONum
                nr1("PODate") = NewPODate
                nr1("CustomerID") = NewCustID

                myContext.Provider.objSQLHelper.SaveResults(nr1.Table, dic(nr1.Table.TableName))
                NewSalesOrderID = nr1("SalesOrderID")


                Me.CopyTables(ds1, ds2, "SalesOrderID", SalesOrderID, NewSalesOrderID, dic, "soc,sod,sob,sop,sot,sov")

                myContext.Data.DeleteNotIncluded(ds1.Tables("wo"), myContext.Data.IDTable(dtWO, "WorkOrderID", "sysincl=1"), "WorkOrderID")
                For Each rWO As DataRow In ds1.Tables("wo").Select("SalesOrderID=" & SalesOrderID)
                    For Each rdtwo As DataRow In dtWO.Select("WorkOrderID=" & rWO("WorkOrderID"))
                        rWO("WONum") = rdtwo("NewWONum")
                        rWO("WODate") = rdtwo("NewWODate")
                    Next

                    Dim nr2 As DataRow = myUtils.CopyOneRow(rWO, ds2.Tables("wo"))
                    nr2("SalesOrderID") = NewSalesOrderID

                    myContext.Provider.objSQLHelper.SaveResults(ds2.Tables("wo"), dic("wo"))

                    Me.CopyTables(ds1, ds2, "WorkOrderID", rWO("WorkOrderID"), nr2("WorkOrderID"), dic, "wod,dd,ttr,sp,srv,fit")
                    myPIDU.SavePIDUnitID(myContext, nr2, "WorkOrderID", nr2("WorkOrderID"), "", nr2("WONum"))
                Next
                Exit For
            Next

            myContext.Provider.dbConn.CommitTransaction(NewLOINum, NewSalesOrderID)
            oRet.ID = NewSalesOrderID
        Catch ex As Exception
            oRet.AddError(ex.Message)
            myContext.Provider.dbConn.RollBackTransaction(NewLOINum, ex.Message)
        End Try
        Return oRet
    End Function
End Class