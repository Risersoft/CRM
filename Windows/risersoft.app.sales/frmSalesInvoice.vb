Imports risersoft.app.mxform
Public Class frmSalesInvoice
    Inherits frmMax
    Dim myViewPay, myViewDoc, myViewForms, myViewSpare, myViewService, myViewAddSpare, myViewAddSerial As New clsWinView
    Dim dvProjectSite As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.InitForm()
    End Sub

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridSerial)
        Me.myViewSpare.SetGrid(Me.UltraGridSpare)
        Me.myViewService.SetGrid(Me.UltraGridService)
        Me.myViewDoc.SetGrid(Me.UltraGridDoc)
        Me.myViewPay.SetGrid(Me.UltraGridPay)
        Me.myViewForms.SetGrid(Me.UltraGridForms)
        Me.myViewAddSerial.SetGrid(Me.UltraGridAddSerial)
        Me.myViewAddSpare.SetGrid(Me.UltraGridAddSpares)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim dtSO As DataTable

        Me.FormPrepared = False
        Dim objModel As frmSalesInvoiceModel = Me.InitData("frmSalesInvoiceModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Status", "", Me.cmb_StatusNum)
            myWinSQL.AssignCmb(Me.dsCombo, "Customer", "", Me.cmb_CustomerID, , 1)
            myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_deliverycampusid)
            myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_campusid)

            dvProjectSite = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_ProjectCampusID,, 2)
            ProjectSiteFilter()


            dtSO = Me.Model.DatasetCollection("SalesOrder").Tables(0)
            If Not dtSO Is Nothing AndAlso dtSO.Rows.Count > 0 Then
                If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
                    Dim r1 As DataRow = dtSO.Rows(0)
                    txtSONum.Text = myUtils.cStrTN(r1("OrderNum"))
                    dtOrderDate.Value = myUtils.cStrTN(r1("OrderDate"))

                End If
            End If

            If myUtils.IsInList(myUtils.cStrTN(myRow("InvoiceTypeCode")), "PF", "FD", "FC") OrElse myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
                cmb_ProjectCampusID.Visible = True
                lblProjectCampusID.Visible = True
            Else
                cmb_ProjectCampusID.Visible = False
                lblProjectCampusID.Visible = False
            End If
            Me.FormPrepared = True
        End If

        If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then lblSalesOrder.Text = Me.GenerateIDOutput("salesorderdescrip", myUtils.cValTN(myRow("SalesOrderID"))).Description
        SOBtnDisabled()

        Return Me.FormPrepared
    End Function

    Private Sub ProjectSiteFilter()
        If myUtils.cValTN(myRow("SalesOrderID")) > 0 Then
            If myUtils.cValTN(myWinSQL2.ParamValue("@ProjectID", Me.Model.ModelParams)) > 0 Then
                dvProjectSite.RowFilter = "ProjectID = " & myUtils.cValTN(myWinSQL2.ParamValue("@ProjectID", Me.Model.ModelParams)) & ""
            Else
                dvProjectSite.RowFilter = "SalesOrderID = " & myUtils.cValTN(myRow("SalesOrderID")) & ""
            End If
        Else
            dvProjectSite.RowFilter = ""
        End If
    End Sub

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean

        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("SerialItem"))
            myViewPay.PrepEdit(Me.Model.GridViews("Pay"))
            myViewDoc.PrepEdit(Me.Model.GridViews("Doc"), , Me.btnDelDoc)
            myViewForms.PrepEdit(Me.Model.GridViews("Forms"), btnAddForms, btnDelForms)
            myViewSpare.PrepEdit(Me.Model.GridViews("Spare"))
            myViewService.PrepEdit(Me.Model.GridViews("Service"))
            myViewAddSpare.PrepEdit(Me.Model.GridViews("AddSpare"))
            myViewAddSerial.PrepEdit(Me.Model.GridViews("AddSerial"))
            Return True
        End If

        Return False
    End Function

    Public Overrides Function VSave() As Boolean

        Me.InitError()
        VSave = False
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

    Private Sub btnAddDoc_Click(sender As Object, e As EventArgs) Handles btnAddDoc.Click, btnEditDoc.Click
        Dim btn As Infragistics.Win.Misc.UltraButton = CType(sender, Infragistics.Win.Misc.UltraButton)
        Select Case LCase(btn.Name)
            Case "btneditdoc"
                Dim f As New frmDocDue
                If f.PrepForm(myViewDoc, EnumfrmMode.acEditM, "") Then f.ShowDialog()
            Case "btnadddoc"
                Dim f As New frmDocDue
                If f.PrepForm(myViewDoc, EnumfrmMode.acAddM, "") Then f.ShowDialog()
        End Select
    End Sub

    Private Sub btnAddSerial_Click(sender As Object, e As EventArgs) Handles btnAddSerial.Click

        Dim Params As New List(Of clsSQLParam)
        Dim Str1 As String = myUtils.MakeCSV(myViewAddSerial.mainGrid.myDS.Tables(0).Select(), "ProdSerialID")
        Params.Add(New clsSQLParam("@ProdSerialID", Str1, GetType(Integer), True))
        Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
        Dim rr() As DataRow = Me.AdvancedSelect("ProdSerial", Params)

        If (Not rr Is Nothing) AndAlso (rr.Length > 0) Then
            For Each r2 As DataRow In rr
                Dim r3 As DataRow = myUtils.CopyOneRow(r2, myViewAddSerial.mainGrid.myDS.Tables(0))
            Next
        End If

    End Sub

    Private Sub btnAddSpares_Click(sender As Object, e As EventArgs) Handles btnAddSpares.Click
        Dim Params As New List(Of clsSQLParam)

        Dim Str1 As String = myUtils.MakeCSV(myViewAddSpare.mainGrid.myDS.Tables(0).Select(), "SOSpareID")
        Params.Add(New clsSQLParam("@SOSpareID", Str1, GetType(Integer), True))
        Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
        Dim rr() As DataRow = Me.AdvancedSelect("SOSpare", Params)

        If (Not rr Is Nothing) AndAlso (rr.Length > 0) Then
            For Each r2 As DataRow In rr
                Dim r3 As DataRow = myUtils.CopyOneRow(r2, myViewAddSpare.mainGrid.myDS.Tables(0))
            Next
        End If

    End Sub

    Private Sub btnDelSerial_Click(sender As Object, e As EventArgs) Handles btnDelSerial.Click
        myViewAddSerial.mainGrid.ButtonAction("Del")
    End Sub

    Private Sub btnDelSpares_Click(sender As Object, e As EventArgs) Handles btnDelSpares.Click
        myViewAddSpare.mainGrid.ButtonAction("Del")
    End Sub

    Private Sub btnSelectSO_Click(sender As Object, e As EventArgs) Handles btnSelectSO.Click
        cm.EndCurrentEdit()
        If Not cmb_campusid.SelectedRow Is Nothing Then
            Dim Params As New List(Of clsSQLParam)
            Params.Add(New clsSQLParam("@MainPartyID", myUtils.cValTN(cmb_CustomerID.SelectedRow.Cells("MainPartyID").Value), GetType(Integer), False))
            Params.Add(New clsSQLParam("@CompanyId", myUtils.cValTN(cmb_campusid.SelectedRow.Cells("CompanyId").Value), GetType(Integer), False))
            Params.Add(New clsSQLParam("@InvoiceDate", Format(dt_InvoiceDate.Value, "dd-MMM-yyyy"), GetType(DateTime), False))
            Params.Add(New clsSQLParam("@SalesOrderID", myUtils.cValTN(myRow("SalesOrderID")), GetType(Integer), False))
            Dim rr1() As DataRow = Me.AdvancedSelect("salesorder", Params)
            If Not rr1 Is Nothing AndAlso rr1.Length > 0 Then
                myRow("SalesOrderID") = myUtils.cValTN(rr1(0)("SalesOrderID"))
                lblSalesOrder.Text = "Sales Order :- " & myUtils.cStrTN(rr1(0)("OrderNum")) & " Date - " & Format(rr1(0)("OrderDate"), "dd-MMM-yyyy")
            End If

            ProjectSiteFilter()
        End If
    End Sub

    Private Sub btnRemoveSO_Click(sender As Object, e As EventArgs) Handles btnRemoveSO.Click
        myRow("SalesOrderID") = DBNull.Value
        lblSalesOrder.Text = "Select Sales Order"

        ProjectSiteFilter()
    End Sub

    Private Sub SOBtnDisabled()
        Dim rr() As DataRow = myView.mainGrid.myDS.Tables(0).Select()
        Dim rr1() As DataRow = myViewSpare.mainGrid.myDS.Tables(0).Select()
        Dim rr2() As DataRow = myViewService.mainGrid.myDS.Tables(0).Select()

        If ((Not rr Is Nothing) AndAlso (rr.Length > 0)) OrElse ((Not rr1 Is Nothing) AndAlso (rr1.Length > 0)) OrElse ((Not rr2 Is Nothing) AndAlso (rr2.Length > 0)) Then
            btnSelectSO.Enabled = False
            btnRemoveSO.Enabled = False
        Else
            btnSelectSO.Enabled = True
            btnRemoveSO.Enabled = True
        End If
    End Sub
End Class

