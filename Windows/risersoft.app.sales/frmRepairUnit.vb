Imports risersoft.app.shared
Imports risersoft.app.mxent
Imports risersoft.app.mxform

Public Class frmRepairUnit
    Inherits frmMax
    Dim myVueInspBy, myVueAttendBy, myVueSpare, myVueService As New clsWinView
    Dim f As frmAttribValue, rWO As DataRow

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim pCode As String = "IsReqRepUnit"
        Me.FormPrepared = False
        Dim objModel As frmRepairUnitModel = Me.InitData("frmRepairUnitModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then
            myWinSQL.AssignCmb(Me.dsCombo, "ru", "", Me.cmb_RUStatusNum)
            myWinSQL.AssignCmb(Me.dsCombo, "JINSP", "", Me.cmb_JInspStatusNum)
            myWinSQL.AssignCmb(Me.dsCombo, "unit", "", Me.ComboUnit)
            myWinSQL.AssignCmb(Me.dsCombo, "unit", "", Me.ComboUnit2)
            myRow("totalqty") = 1
            If dsCombo.Tables("unit1").Select.Length > 0 Then
                rWO = dsCombo.Tables("unit1").Rows(0)
                Me.ComboUnit.Value = rWO("itemunitid")
                Me.ComboUnit2.Value = rWO("itemunitid2")
                f.SetupForm(Me, "itemid", rWO("itemid"), "IEI", "pidunititemvarid", myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), pCode)
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("RepUnitItem"))
            myView.mainGrid.HighlightRows()
            myVueService.PrepEdit(Me.Model.GridViews("Service"), Me.btnAddService, Me.btnDelService)
            myVueSpare.PrepEdit(Me.Model.GridViews("Spare"), Me.btnAddSpare, Me.btnDelSpare)
            myVueAttendBy.PrepEdit(Me.Model.GridViews("AttendBy"), , Me.btnDelEmp)
            myVueInspBy.mainGrid.PrepEntSelect("<SYS ID=""PERSPARTYID""/>", Me.btnDelPers, Me.btnAddPers)
            myVueInspBy.PrepEdit(Me.Model.GridViews("InspBy"))
            Return True
        End If
        Return False
    End Function

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim Params As New List(Of clsSQLParam)
        Dim str1 As String = myUtils.MakeCSV(myVueAttendBy.mainGrid.myDS.Tables(0).Select, "UserID")
        Params.Add(New clsSQLParam("@UserIDcsv", str1, GetType(Integer), True))
        Dim rr() As DataRow = Me.AdvancedSelect("repairunit", Params)

        If Not IsNothing(rr) Then
            For Each r2 As DataRow In rr
                Dim r3 As DataRow = myUtils.CopyOneRow(r2, myVueAttendBy.mainGrid.myDS.Tables(0))
            Next
        End If
    End Sub

    Private Sub InitForm()
        myView.SetGrid(Me.UltraGridRepItems)
        myVueInspBy.SetGrid(Me.UltraGridInsp)
        myVueAttendBy.SetGrid(Me.UltraGrid1)
        myVueSpare.SetGrid(Me.UltraGridSpare)
        myVueService.SetGrid(Me.UltraGridSvc)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        f = New frmAttribValue
        f.AddToPanel(Me.SplitContainer1.Panel1, True, System.Windows.Forms.DockStyle.Fill)
        f.UltraPanelSave.Visible = False
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If Me.ValidateData() AndAlso f.ValidateData Then
            Me.reCalcQty2()
            cm.EndCurrentEdit()
            myFuncs.CalcDescrip(rWO, f, myRow.Row)
            If Me.SaveModel() Then
                f.VSave(myPIDU.GetPIDUnitItemVarID(Me.Model.DatasetCollection("var")), True)
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub reCalcQty2()
        If (myUtils.cValTN(rWO("itemunitid2")) > 0) AndAlso (myUtils.cValTN(rWO("etosku2attribid")) > 0) Then
            Me.txt_TotalQty2.Text = myFuncs.CalcQty2(rWO, f, myUtils.cValTN(Me.txt_TotalQty.Text), myUtils.cValTN(rWO("etosku2attribid")))
        End If
    End Sub
End Class

