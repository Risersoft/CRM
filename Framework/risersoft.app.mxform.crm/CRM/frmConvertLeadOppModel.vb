
Imports risersoft.shared
Imports risersoft.app.mxent
Imports System.Runtime.Serialization
<DataContract>
Public Class frmConvertLeadOppModel
    Inherits clsFormDataModel
    Dim Name As String, Amount As String, NextStep As String, newCustID As Integer, oRet As clsProcOutput, sql As String
    Dim Probability As String, Description As String, Currency As String, OpportunityType As String, SalesStage As String, DateClosed As String

    Protected Overrides Sub InitViews()
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

        Dim vlist2 As New clsValueList
        vlist2.Add("Rupee", "INR")
        vlist2.Add("Dollar", "U.S. Dollar:$")
        Me.ValueLists.Add("Currency", vlist2)
        Me.AddLookupField("Currency", "Currency")

        Dim vlist3 As New clsValueList
        vlist3.Add("Prospecting", "Prospecting")
        vlist3.Add("Qualification", "Qualification")
        vlist3.Add("Needs Analysis", "Needs Analysis")
        vlist3.Add("Value Proposition", "Value Proposition")
        vlist3.Add("Id. decision makers", "Id. decision makers")
        vlist3.Add("Perception analysis", "Perception analysis")
        vlist3.Add("Proposal/price quote", "Proposal/price quote")
        vlist3.Add("Negotiation/Review", "Negotiation/Review")
        vlist3.Add("Closed won", "Closed won")
        vlist3.Add("Closed lost", "Closed lost")
        vlist3.Add("Other", "Other")
        Me.ValueLists.Add("Stage", vlist3)
        Me.AddLookupField("SalesStage", "Stage")

        Dim vlist As New clsValueList
        vlist.Add("Existing Business", "Existing Business")
        vlist.Add("New Business", "New Business")
        Me.ValueLists.Add("Opportunity", vlist)
        Me.AddLookupField("OpportunityType", "Opportunity")

        Dim vlist1 As New clsValueList
        vlist1.Add("Cold Call", "Cold Call")
        vlist1.Add("Existing Customer", "Existing Customer")
        vlist1.Add("Self generated", "Self generated")
        vlist1.Add("Employee", "Employee")
        vlist1.Add("Partner", "Partner")
        vlist1.Add("Public Relations", "Public Relations")
        vlist1.Add("Direct Mail", "Direct Mail")
        vlist1.Add("Conference", "Conference")
        vlist1.Add("Trade Show", "Trade Show")
        vlist1.Add("Website", "Website")
        vlist1.Add("World of Mouth", "World of Mouth")
        vlist1.Add("Email", "Email")
        vlist1.Add("Campaign", "Campaign")
        vlist1.Add("Other", "Other")
        vlist1.Add("Hubspot", "Hubspot")
        Me.ValueLists.Add("LeadSource", vlist1)
        Me.AddLookupField("LeadSource", "LeadSource")

    End Sub

    Public Overrides Function PrepForm(oView As clsViewModel, ByVal prepMode As EnumfrmMode, ByVal prepIDX As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        If frmMode = EnumfrmMode.acEditM Then
            sql = "Select * from Lead where LeadID = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)



            Me.FormPrepared = True
        End If




        Return Me.FormPrepared
    End Function
    Public Overrides Function Validate() As Boolean
        Me.InitError()


        'If myUtils.cStrTN(myRow("Name")).Trim.Length = 0 Then Me.AddError("Name", "Enter Opportunity Name")
        'If Me.SelectedRow("CustomerID") Is Nothing Then Me.AddError("CustomerID", "Please Select Customer Name")
        'If myUtils.NullNot(myRow("Amount")) Then Me.AddError("Amount", "Please Enter Amount")
        'If myUtils.NullNot(myRow("DateClosed")) Then Me.AddError("DateClosed", "Please Select Date Closed")



        oRet = myContext.SQL.ValidateSQLParams(Me.ClientParams)
        If oRet.Success Then
            Name = myContext.SQL.ParamValue("@Name", ClientParams)
            Amount = myContext.SQL.ParamValue("@Amount", ClientParams)
            Probability = myContext.SQL.ParamValue("@Probability", ClientParams)
            NextStep = myContext.SQL.ParamValue("@NextStep", ClientParams)
            Description = myContext.SQL.ParamValue("@Description", ClientParams)
            Currency = myContext.SQL.ParamValue("@Currency", ClientParams)
            OpportunityType = myContext.SQL.ParamValue("@OpportunityType", ClientParams)
            SalesStage = myContext.SQL.ParamValue("@SalesStage", ClientParams)
            DateClosed = myContext.SQL.ParamValue("@DateClosed", ClientParams)
            newCustID = myContext.SQL.ParamValue("@NewCustID", ClientParams)

            If newCustID = 0 Then Me.AddError("NewCustID", "Select a customer")
            If Name.Trim.Length = 0 Then Me.AddError("Name", "Enter a Opportunity Name")
            If myUtils.NullNot(Currency) Then Me.AddError("Currency", "Enter Currency")

        Else
            Me.AddError("", oRet.Message)
        End If

        Return Me.CanSave
    End Function

    Public Overrides Function VSave() As Boolean
        Dim oProc As New clsSalesEnqProc(myContext)
        VSave = False
        If Me.Validate Then
            oRet = Me.ConvertOrder(frmIDX, Name, Amount, NextStep, Probability, Description, DateClosed, Currency, SalesStage, OpportunityType, newCustID)
            If oRet.Success Then
                myRow("OpportunityID") = oRet.ID
                frmMode = EnumfrmMode.acEditM
                VSave = True
            Else
                Me.AddError("", oRet.Message)
            End If

        End If
    End Function

    Public Function ConvertOrder(LeadID As Integer, Name As String, Amount As String, NextStep As String, Probability As String, Description As String, DateClosed As DateTime, Currency As String, SalesStage As String, OpportunityType As String, CustomerID As Integer) As clsProcOutput
        Dim Opportunityid As Integer, oRet As New clsProcOutput
        myContext.Provider.dbConn.BeginTransaction(myContext, "frmConvertLeadOppModel", EnumfrmMode.acAddM, "opportunityid")
        Try
            sql = "select * from Lead where Leadid = " & LeadID
            Dim ds1 As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            sql = "select * from Opportunity where Opportunityid = " & Opportunityid
            Dim ds2 As DataSet = myContext.Provider.objSQLHelper.ExecuteDataset(CommandType.Text, sql)
            For Each rOpp As DataRow In ds1.Tables(0).Select
                'single run loop
                Dim r1 As DataRow = myUtils.CopyOneRow(rOpp, ds2.Tables(0))
                r1("name") = Name
                r1("Amount") = Amount
                r1("NextStep") = NextStep
                r1("Probability") = Probability
                r1("Description") = Description
                r1("DateClosed") = DateClosed
                r1("Currency") = Currency
                r1("SalesStage") = SalesStage
                r1("OpportunityType") = OpportunityType
                r1("customerid") = CustomerID
                myContext.Provider.objSQLHelper.SaveResults(r1.Table, "Select * from opportunity where 0=1")
                Opportunityid = r1("Opportunityid")
                myRow("LeadID") = r1("Opportunityid")
                myContext.Provider.objSQLHelper.SaveResults(myRow.Row.Table, sqlForm)
                Exit For
            Next
            myContext.Provider.dbConn.CommitTransaction(Name, Opportunityid)
            oRet.ID = Opportunityid
        Catch ex As Exception
            oRet.AddError(ex.Message)
            myContext.Provider.dbConn.RollBackTransaction(Name, ex.Message)
        End Try
        Return oRet
    End Function


End Class
