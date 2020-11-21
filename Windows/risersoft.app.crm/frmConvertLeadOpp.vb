Public Class frmConvertLeadOpp
    Inherits frmMax

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean

        Me.FormPrepared = False
        Dim objModel As frmConvertLeadOppModel = Me.InitData("frmConvertLeadOppModel", oView, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_CustomerID)
            myWinSQL.AssignCmb(Me.dsCombo, "Cust", "", Me.cmb_NewCustID)

            Me.txt_Name.Text = ""
            Me.txt_Amount.Text = ""
            Me.txt_NextStep.Text = ""
            Me.txt_Probability.Text = ""
            Me.txt_Description.Text = ""
            Me.cmb_NewCustID.Text = ""
            Me.cmb_Currency.Text = ""
            Me.cmb_OpportunityType.Text = ""
            Me.cmb_SalesStage.Text = ""
            Me.dt_DateClosed.Value = Nothing

            WinFormUtils.SetReadOnly(Me.Panel1, False)

            Me.FormPrepared = True
        End If

        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Me.cmb_OpportunityType.ValueList = Me.Model.ValueLists("Opportunity").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "LeadSource", "", Me.cmb_LeadSource)
            Me.cmb_Currency.ValueList = Me.Model.ValueLists("Currency").ComboList
            Me.cmb_SalesStage.ValueList = Me.Model.ValueLists("Stage").ComboList

            Return True
        End If
        Return False
    End Function

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOk, Me.btnCancel, Nothing)

    End Sub
    Public Overrides Function VSave() As Boolean

        Me.InitError()
        VSave = False
        Me.Model.ClientParams.Clear()
        Me.Model.ClientParams.Add(New clsSQLParam("@Name", "'" & Me.txt_Name.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@Amount", "'" & Me.txt_Amount.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NextStep", "'" & Me.txt_NextStep.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@Probability", "'" & Me.txt_Probability.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@Description", "'" & Me.txt_Description.Text & "'", GetType(String), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@DateClosed", Me.dt_DateClosed.Value, GetType(Date), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@NewCustID", myUtils.cValTN(Me.cmb_NewCustID.Value), GetType(Integer), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@Currency", myUtils.cValTN(Me.cmb_Currency.Value), GetType(Integer), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@OpportunityType", myUtils.cValTN(Me.cmb_OpportunityType.Value), GetType(Integer), False))
        Me.Model.ClientParams.Add(New clsSQLParam("@SalesStage", myUtils.cValTN(Me.cmb_SalesStage.Value), GetType(Integer), False))
        If Me.ValidateData() Then
            cm.EndCurrentEdit()
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If

        Me.Refresh()
    End Function

End Class

