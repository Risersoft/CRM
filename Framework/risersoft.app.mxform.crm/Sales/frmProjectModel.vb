Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmProjectModel
    Inherits clsFormDataModel
    Dim sql As String

    Protected Overrides Sub InitViews()
    End Sub

    Public Sub New(context As IProviderContext)
        MyBase.New(context)
        Me.InitViews()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        sql = "select partyid, partyname from genListPersParty() order by partyname"
        Me.AddLookupField("EndUserID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "Party").TableName)

        Me.AddLookupField("ProjectWonByID", "Party")

        sql = "Select regionid,region from region order by regionid"
        Me.AddLookupField("RegionID", myUtils.AddTable(Me.dsCombo, myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql), "region").TableName)

        Me.AddLookupField("EURegionID", "region")

        Dim lst As New List(Of String)
        lst.Add("High")
        lst.Add("Medium")
        lst.Add("Low")

        Me.ValueLists.Add("Priority", myContext.SQL.VListFromList(lst))
        Me.AddLookupField("Priority", "Priority")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "Select * from projects where projectid = " & prepIDX
        Me.InitData(sql, "salesenqid", oView, prepMode, prepIDX, strXML) 'salesenqid added here only to get reference in web app
        ' Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

        Me.FormPrepared = True

        Return Me.FormPrepared
    End Function

    Public Overrides Function Validate() As Boolean
        Me.InitError()
        If myUtils.cStrTN(myRow("ProjectName")).Trim.Length = 0 Then Me.AddError("ProjectName", "Enter a Project Name")

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        VSave = False

        If Me.Validate Then
            Dim projectDescrip As String = myRow("ProjectName").ToString
            Try
                myContext.Provider.dbConn.BeginTransaction(myContext, Me.Name, Me.frmMode.ToString, "projectid", frmIDX)
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, "Select * from Projects where projectid = " & frmIDX)
                frmIDX = myRow("projectid")
                frmMode = EnumfrmMode.acEditM
                myContext.Provider.dbConn.CommitTransaction(projectDescrip, frmIDX)
                VSave = True
            Catch e As Exception
                myContext.Provider.dbConn.RollBackTransaction(projectDescrip, e.Message)
                Me.AddException("", e)
            End Try
        End If
    End Function

End Class
