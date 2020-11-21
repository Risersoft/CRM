Imports risersoft.app.mxform

Public Class frmInspec
    Inherits frmMax
    Dim myVueAttEmp, myVueInspBy, myVueDoc As New clsWinView, dvCamp As DataView

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmInspecModel = Me.InitData("frmInspecModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Status", "", Me.cmb_StatusNum)
            dvCamp = myWinSQL.AssignCmb(Me.dsCombo, "Campus", "", Me.cmb_CampusID,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "InspecType", "", Me.cmb_inspectype)
            HandleDate(myUtils.cDateTN(myRow("InspecDate"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then

            myView.PrepEdit(Me.Model.GridViews("SerialItem"))
            myView.mainGrid.HighlightRows()
            myVueInspBy.mainGrid.PrepEntSelect("<SYS ID=""PERSPARTYID""/>", Me.btnDelPers, Me.btnAddPers)
            myVueInspBy.PrepEdit(Me.Model.GridViews("InspBy"))
            myVueAttEmp.PrepEdit(Me.Model.GridViews("AttUser"), , Me.btnDelEmp)
            myVueDoc.PrepEdit(Me.Model.GridViews("Doc"), , Me.btnDelDoc)

            Return True
        End If

        Return False
    End Function

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim Params As New List(Of clsSQLParam)

        Dim str1 As String = myUtils.MakeCSV(myVueAttEmp.mainGrid.myDS.Tables(0).Select, "UserID")
        Params.Add(New clsSQLParam("@UserIDcsv", str1, GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("AttendBy", Params)

        If Not IsNothing(rr) Then
            For Each r2 As DataRow In rr
                Dim r3 As DataRow = myUtils.CopyOneRow(r2, myVueAttEmp.mainGrid.myDS.Tables(0))
            Next
        End If
    End Sub

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGrid1)
        myVueAttEmp.SetGrid(Me.UltraGrid3)
        myVueInspBy.SetGrid(Me.UltraGrid2)
        myVueDoc.SetGrid(Me.UltraGridDoc)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function VSave() As Boolean

        Me.InitError() : WinFormUtils.InitTabBacks(Me.UltraTabControl1)
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

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click, btnEditDoc.Click
        Dim btn As Infragistics.Win.Misc.UltraButton = CType(sender, Infragistics.Win.Misc.UltraButton)

        Select Case LCase(btn.Name)
            Case "btneditdoc"
                Dim f As New frmDocDue
                If f.PrepForm(myVueDoc, EnumfrmMode.acEditM, "") Then f.ShowDialog()
            Case "btnadddoc"
                Dim f As New frmDocDue
                If f.PrepForm(myVueDoc, EnumfrmMode.acAddM, "") Then f.ShowDialog()
        End Select
    End Sub

    Private Sub dt_InspecDate_Leave(sender As Object, e As EventArgs) Handles dt_InspecDate.Leave, dt_InspecDate.AfterCloseUp
        HandleDate(dt_InspecDate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvCamp.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "CampusID")
    End Sub
End Class
