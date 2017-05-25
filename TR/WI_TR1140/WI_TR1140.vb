Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR1140
    Dim p As New OpenParameters
    Dim n As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Cancel

                Me.Clear()

            Case MenuType.Save

                If Not Saves() Then Exit Sub

            Case MenuType.Confirm

                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm

                If Not DeConFrim() Then Exit Sub

            Case MenuType.Find

                Me.Find()

            Case MenuType.Delete

                If Not Del() Then Exit Sub

            Case MenuType.Print

                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()

        n.Clear()
        n.Add("@ot_no", "XXX")
        n.Add("@ot_gu", "XXX")

        Me.Open("wi_tr1140_head", n)
        Me.Open("wi_tr1140_tab2", n)

        Me.Setitem_Shipper()
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Function Saves() As Boolean

        Dim ls_stts, ls_gu As String

        ls_stts = Check_Stts()
        ls_gu = gu.Text

        If ls_stts = "Y" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        ElseIf ls_stts = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If g_body.RowCount <= 0 Then
            MsgBox("저장할 사항이 없습니다!")
            Return False
        End If

        If ls_gu = "1" Then
            stts.Text = "S"
        ElseIf ls_gu = "2" Then
            stts.Text = "X"
        End If

        Me.check()

        '수량체크
        If qty_check() < 0 Then
            'MsgBox("수주 수량보다 큽니다.!")
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If MyBase.Save() Then
            End If
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        Dim ls_stts As String

        If ot_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        ls_stts = Check_Stts()

        If ls_stts = "Y" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        ElseIf ls_stts = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If g_body.RowCount <= 0 Then
            MsgBox("저장할 사항이 없습니다!")
            Return False
        End If

        Me.check()
        '수량체크
        If qty_check() < 0 Then
            MsgBox("수주 수량보다 큽니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If ls_stts = "S" Then
                stts.Text = "C"
            ElseIf ls_stts = "X" Then
                stts.Text = "Y"
            End If

            p.Clear()
            p.Add("@ot_no", ot_no.Text)
            p.Add("@ot_gu", ot_gu.Text)
            p.Add("@STTS", stts.Text)
            p.Add("@AC_GU", "S")

            Me.Open("wi_tr1140_confirm", p)

            'n.Clear()

            'n.Add("@OT_NO", ot_no.Text)
            'n.Add("@OT_GU", ot_gu.Text)

            'Me.Open("wi_tr1140_head", n)
            'Me.Open("wi_tr1140_tab2", n)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        Dim ls_stts, ls_acgu As String

        ls_stts = Check_Stts()
        ls_acgu = Check_Acgu()

        If ls_acgu = "C" Then
            MsgBox("수출신고서를 먼저 취소하십시요")
            Return False
        End If

        If ls_stts = "S" Then '상태값 CHECK
            MsgBox("확인된 데이타만 확인취소가 가능합니다.")
            Return False
        ElseIf ls_stts = "X" Then
            MsgBox("확인처리된 데이타만 확인취소가 가능합니다.")
            Return False
        End If

        Me.check()

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            If ls_stts = "C" Then
                p.Clear()
                p.Add("@ot_no", ot_no.Text)
                p.Add("@ot_gu", ot_gu.Text)
                p.Add("@stts", "S")

                Me.Open("wi_tr1140_deconfrim", p)
            ElseIf ls_stts = "Y" Then
                p.Clear()
                p.Add("@ot_no", ot_no.Text)
                p.Add("@ot_gu", ot_gu.Text)
                p.Add("@stts", "X")

                Me.Open("wi_tr1140_deconfrim", p)
            End If

            n.Clear()

            n.Add("@OT_NO", ot_no.Text)
            n.Add("@OT_GU", ot_gu.Text)

            Me.Open("wi_tr1140_head", n)
            Me.Open("wi_tr1140_tab2", n)

            g_list.Open()
        End If

        Return True
    End Function


    Private Function Del() As Boolean
        Dim ls_stts As String

        If ot_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        ls_stts = Check_Stts()

        If ls_stts = "Y" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        ElseIf ls_stts = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@ot_no", ot_no.Text)
            p.Add("@ot_gu", ot_gu.Text)

            Me.Open("wi_tr1140_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Sub Max_NO()
        ot_no.CodeNo = "WI_TR1140"
        ot_no.CodeDateField = invoice_dt
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub find_Clear()
        find_cs_nm.Text = ""
        find_stts.Text = "%"
        find_cur_cd.Text = ""

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_cur_cd", find_cur_cd.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_tr1140_list", p)
    End Sub

    Private Sub g_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g_list.DoubleClick
        n.Clear()

        n.Add("@OT_NO", g_list.Text("OT_NO", g_list.RowIndex))
        n.Add("@OT_GU", g_list.Text("OT_GU", g_list.RowIndex))

        Me.Open("wi_tr1140_head", n)
        Me.Open("wi_tr1140_tab2", n)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@ot_no", ot_no.Text)
        p.Add("@ot_gu", ot_gu.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1140_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_Acgu() As String
        p.Clear()
        p.Add("@ot_no", ot_no.Text)
        p.Add("@ot_gu", ot_gu.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1140_acgu", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        g_body.DeleteAll()

        nacs_cd.Text = cs_cd.Text
    End Sub

    Private Sub cur_cd_TextChanged(sender As System.Object, e As System.EventArgs) Handles cur_cd.TextChanged
        g_body.DeleteAll()

        Me.Setitem_Rate()
    End Sub

    Private Sub rate_TextChanged(sender As Object, oldValue As String) Handles rate.TextChanged
        Me.SumAmt()
    End Sub

    Private Sub invoice_dt_TextChanged(sender As Object, e As System.EventArgs) Handles invoice_dt.TextChanged
        Me.Setitem_Rate()
    End Sub

    Private Sub Setitem_Rate()
        p.Clear()
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@INV_DT", invoice_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1140_set_rate", p)
        Dim ld_rate As Decimal

        If Not IsEmpty(dSet) Then
            ld_rate = DataValue(dSet)
        Else
            ld_rate = 1
        End If

        'rate.Text = ld_rate
        ot_rate.Text = ld_rate
    End Sub

    Private Sub SumAmt()
        Dim sum_amt As Double
        Dim ld_rate As Decimal = ToDec(ot_rate.Text)

        With g_body
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("OT_AMT", i)
            Next
        End With

        ot_amt.Text = sum_amt
        head_wonamt.Text = sum_amt * ld_rate
    End Sub

    Private Function qty_check() As Integer

        Dim ld_hap, ld_qty, ld_preqty As Decimal
        Dim ls_odno, ls_stts As String
        Dim ll_seq As Integer

        ls_stts = stts.Text

        If ls_stts = "S" Then
            With g_body
                For i As Integer = 0 To .RowCount - 1
                    ld_hap = 0
                    ls_odno = .Text("OD_NO", i)
                    ll_seq = .ToDec("OD_SEQ", i)
                    ld_qty = .ToDec("OT_QTY", i)

                    For j As Integer = 0 To g_body.RowCount - 1
                        ld_hap = ld_qty
                        If g_body.Text("OD_NO", j) = ls_odno And g_body.ToDec("OD_SEQ", j) = ll_seq And i <> j Then
                            ld_hap += g_body.ToDec("OT_QTY", j)
                        End If
                    Next

                    p.Clear()
                    p.Add("@OD_NO", ls_odno)
                    p.Add("@OD_SEQ", ll_seq)
                    p.Add("@OT_NO", ot_no.Text)

                    Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1140_subqty_satr1121a", p)

                    If Not IsEmpty(dSet) Then ld_preqty = ToDec(DataValue(dSet))

                    If ToStr(ld_preqty) Is Nothing Then
                        ld_preqty = 0
                    End If

                    If ld_preqty < ld_hap Then
                        MsgBox("수주 수량보다 큽니다.!")
                        .Focus()
                        .FocusedFieldName = "OT_QTY"
                        .RowIndex = i
                        .EditMode()
                        Return -1
                    End If
                Next

                Return 0

            End With
        End If

        Return 0
    End Function

    Private Sub check()
        Dim ls_odno, ls_gdcd, ls_chk As String
        Dim ld_otqty, ld_otpri, ld_otamt, ld_gw, ld_otsum As Decimal
        Dim ll_boxno, ll_temp As Long
        Dim ls_stts As String

        ls_stts = stts.Text
        'ls_whcd = wh_cd.Text

        If ot_no.Text = "" Then
            Max_NO()
        End If

        With g_body

            '.UpdateRow()
            For i As Integer = 0 To .RowCount - 1

                ls_odno = .Text("OD_NO", i)
                ls_gdcd = .Text("GD_CD", i)
                ld_otqty = .ToDec("OT_QTY", i)
                ld_otpri = .ToDec("OT_PRI", i)
                ld_otamt = .ToDec("OT_AMT", i)
                ll_boxno = .ToDec("BOX_NO", i)
                ls_chk = .Text("CHK", i)

                If ls_odno Is Nothing Or ld_otqty = 0 Then

                    If ls_stts = "S" Or ls_stts = "A" Then
                        .DeleteRow(i)
                    Else
                        If ls_chk = "N" Then

                            ld_gw += .ToDec("BOX_GW", i)
                            ll_temp = ll_boxno
                            .Text("CHK", i) = "Y"

                            For j As Integer = (i + 1) To g_body.RowCount - 1
                                If g_body.ToDec("BOX_NO", j) = ll_boxno Then
                                    g_body.Text("CHK", j) = "Y"
                                End If
                            Next
                        End If

                        ld_otsum += ld_otsum + ld_otamt

                        .Text("OT_NO", i) = ot_no.Text
                        .Text("WH_CD", i) = wh_cd.Text
                    End If

                Else

                    If ls_chk = "N" Then
                        ld_gw += .ToDec("BOX_GW", i)
                        ll_temp = ll_boxno
                        .Text("CHK", i) = "Y"

                        For k As Integer = (i + 1) To g_body.RowCount - 1
                            If g_body.ToDec("BOX_NO", k) = ll_boxno Then
                                g_body.Text("CHK", k) = "Y"
                            End If
                        Next

                    End If

                    ld_otsum += ld_otsum + ld_otamt

                    .Text("OT_NO", i) = ot_no.Text
                    .Text("WH_CD", i) = wh_cd.Text

                End If


            Next

        End With

        For l As Integer = 0 To g_body.RowCount - 1
            g_body.Text("HAP_GW", l) = ld_gw
            g_body.Text("CHK", l) = "N"
        Next

        'OT_AMT 금액 넣는다.
        SumAmt()


    End Sub
    

    Private Sub b_1_Click(sender As System.Object, e As System.EventArgs) Handles b_1.Click
        If MessageYesNo("변경하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else

            p.Clear()
            p.Add("@SHIPPER", shipper.Text)
            p.Add("@CONSIGNEE", consignee.Text)
            p.Add("@APPLICANT", applicant.Text)
            p.Add("@PARTY", party.Text)
            p.Add("@TITLE", title.Text)
            p.Add("@TITLE1", title1.Text)
            p.Add("@SHIP_MARK", ship_mark.Text)
            p.Add("@P_LOADING", p_loading.Text)
            p.Add("@F_DESTINATION", f_destination.Text)
            p.Add("@VESSEL_FLIGHT", vessel_flight.Text)
            p.Add("@INVOICE_NO", invoice_no.Text)
            p.Add("@LC_NO", lc_no.Text)
            p.Add("@LC_DT", lc_dt.Text)
            p.Add("@OPEN_BANK", open_bank.Text)
            p.Add("@REMARK", remark.Text)
            p.Add("@PACKING_REMARK", packing_remark.Text)
            p.Add("@TOTAL", total.Text)
            p.Add("@INVOICE_TITLE", invoice_title.Text)
            p.Add("@PACKING_TITLE", packing_title.Text)
            p.Add("@VESSEL_NO", vessel_no.Text)
            p.Add("@SAIL_ABOUT", sail_about.Text)
            p.Add("@OT_NO", ot_no.Text)
            p.Add("@OT_GU", ot_gu.Text)

            Me.Open("wi_tr1140_head_change", p)
        End If

    End Sub

    Private Sub odNoValueChange(ColumnName As String, RowIndex As Integer, ByRef Value As Object)
        Dim ls_odno As String
        Dim ll_cnt, ll_seq, ll_row As Integer
        Dim ld_qty As Decimal

        If ColumnName <> "OD_NO" Then Exit Sub

        p.Clear()
        p.Add("@CS_CD", cs_cd.Text)
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@OD_NO", Value)
        p.Add("@SEQ", g_body.ToDec("SEQ", RowIndex))

        Me.Open("wi_tr1140_subqty2", p)

        Dim dSet As DataSet = Me.WorkSet("wi_tr1140_subqty2").DataSet

        If Not IsEmpty(dSet) Then

            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                Try
                    ll_cnt = 0

                    ll_seq = ToDec(dRow("SEQ"))
                    ls_odno = ToStr(dRow("OD_NO"))
                    ld_qty = ToDec(dRow("QTY"))

                    For j As Integer = 0 To g_body.RowCount - 1
                        If g_body.Text("OD_NO", j) = ls_odno And g_body.ToDec("SEQ", j) = ll_seq Then
                            ll_cnt = ll_cnt + 1
                            ll_row = j
                        End If
                    Next

                    If ll_cnt > 0 Then
                        'g_body.Text("OT_QTY", ll_row) = ld_qty

                        g_body.Text("OT_NO", ll_row) = ""
                        g_body.Text("GD_CD", ll_row) = ToStr(dRow("GD_CD"))
                        g_body.Text("GD_NM", ll_row) = ToStr(dRow("GD_NM"))
                        g_body.Text("OT_QTY", ll_row) = ld_qty
                        g_body.Text("OT_PRI", ll_row) = ToDec(dRow("OD_PRI"))
                        g_body.Text("OT_AMT", ll_row) = ToDec(dRow("OD_PRI")) * ld_qty
                        g_body.Text("CS_CD", ll_row) = cs_cd.Text
                        g_body.Text("NACS_CD", ll_row) = ToStr(dRow("NACS_CD"))
                        g_body.Text("UNIT_CD", ll_row) = ToStr(dRow("UNIT_CD"))
                        g_body.Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                        g_body.Text("CUR_CD", ll_row) = cur_cd.Text
                        g_body.Text("RATE", ll_row) = ToDec(dRow("RATE"))

                        g_body.Text("INSERTROW_GU", ll_row) = "N"
                    Else
                        g_body.AddNewRow()
                        ll_row = g_body.RowCount

                        g_body.Text("OT_NO", ll_row) = ""
                        g_body.Text("GD_CD", ll_row) = ToStr(dRow("GD_CD"))
                        g_body.Text("GD_NM", ll_row) = ToStr(dRow("GD_NM"))
                        g_body.Text("OT_QTY", ll_row) = ld_qty
                        g_body.Text("OT_PRI", ll_row) = ToDec(dRow("OD_PRI"))
                        g_body.Text("OT_AMT", ll_row) = ToDec(dRow("OD_PRI")) * ld_qty
                        g_body.Text("OD_NO", ll_row) = ToStr(dRow("OD_NO"))
                        g_body.Text("OD_SEQ", ll_row) = ToStr(dRow("SEQ"))
                        g_body.Text("CS_CD", ll_row) = cs_cd.Text
                        g_body.Text("NACS_CD", ll_row) = ToStr(dRow("NACS_CD"))
                        g_body.Text("SPEC", ll_row) = ToStr(dRow("SPEC"))
                        g_body.Text("UNIT_CD", ll_row) = ToStr(dRow("UNIT_CD"))
                        g_body.Text("CUR_CD", ll_row) = cur_cd.Text
                        g_body.Text("RATE", ll_row) = ToDec(dRow("RATE"))

                        g_body.Text("INSERTROW_GU", ll_row) = "N"
                    End If


                Catch ex As Exception
                    MessageError(ex, , "Display()")
                End Try


                iRow += 1
            Next


        End If


    End Sub
    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        '2013-01-23 막음
        'If ColumnName = "OD_NO" And ToStr(Value) = "" Then
        '    Exit Sub
        'Else
        '    odNoValueChange(ColumnName, RowIndex, Value)
        'End If
        ''odNoValueChange(ColumnName, RowIndex, Value)

        With g_body
            If ColumnName = "OT_QTY" Or ColumnName = "OT_PRI" Then
                .Text("OT_AMT") = .ToDec("OT_QTY") * .ToDec("OT_PRI")
                Me.SumAmt()
            End If
        End With
    End Sub

    Private Sub g_body_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g_body.DoubleClick
        Dim popup As New Form1

        If g_body.ColumnIndex <> 2 Then Exit Sub

        popup.InitPopup()

        If popup.ShowDialog() = DialogResult.OK Then
            If popup.ActiveControl.Tag IsNot Nothing Then
                Dim pReturn As eGrid = popup.ActiveControl.Tag
                Dim ll_row As Integer
                ll_row = g_body.RowIndex

                ''멀티 선택시 ..
                For i = 0 To pReturn.RowCount - 1
                    If pReturn.Text("CHK", i) = "1" Then
                        'g_body.AddNewRow()

                        g_body.Text("GD_CD") = pReturn.Text("GD_CD", i)
                        g_body.Text("GD_NM") = pReturn.Text("GD_NM", i)
                        g_body.Text("SPEC") = pReturn.Text("SPEC", i)
                        g_body.Text("UNIT_CD") = pReturn.Text("UNIT_CD", i)

                        ll_row = ll_row + 1

                        g_body.InsertNewRow(ll_row)
                    End If
                Next

                g_body.DeleteRow(ll_row)


            Else
                ' 결과 파라미터가 없는경우
            End If

        Else
        End If
    End Sub

    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters

        p.Add("@ot_no", ot_no.Text)

        Select Case but.Text
            Case "0"
                System7.ReportView.LoadView("WI_TR1140", "", "wi_tr1140_Print", p)
            Case "1"
                System7.ReportView.LoadView("WI_TR1140_P", "", "wi_tr1140_Print2", p)
        End Select
    End Sub
    '2013-01-23 막음
    'Private Sub od_no_TextChanged(sender As System.Object, oldValue As System.String) Handles od_no.TextChanged
    '    p.Clear()
    '    p.Add("@ilc_no", od_no.Text)

    '    Me.Open("wi_tr1140_odno", p)

    '    Dim dSet As DataSet = Me.WorkSet("wi_tr1140_odno").DataSet

    '    If Not IsEmpty(dSet) Then

    '        Dim iRow As Integer = 0
    '        Dim dRow As DataRow, dRows As DataRowCollection
    '        dRows = dSet.Tables(0).Rows

    '        For Each dRow In dRows
    '            Try
    '                consignee.Text = ToStr(dRow("RISK"))
    '                party.Text = ToStr(dRow("PARTY"))
    '                p_loading.Text = ToStr(dRow("P_LOADING"))
    '                f_destination.Text = ToStr(dRow("F_DESTINATION"))
    '                ship_mark.Text = ToStr(dRow("SHIP_MARK"))
    '                lc_no.Text = ToStr(dRow("LC_NO"))
    '                lc_dt.Text = ToDateStr(dRow("LC_DT"))
    '                open_bank.Text = ToStr(dRow("OPEN_BANK"))
    '                title.Text = ToStr(dRow("REMK"))
    '                total.Text = ToStr(dRow("FOB"))
    '                vessel_flight.Text = ToStr(dRow("FREIGHT"))
    '                applicant.Text = ToStr(dRow("APPLICANT"))

    '            Catch ex As Exception
    '                MessageError(ex, , "Display()")
    '            End Try

    '            iRow += 1
    '        Next
    '    End If
    'End Sub

    Private Sub Setitem_Shipper()
        p.Clear()
        p.Add("@co_cd", sa_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1140_set_shipper", p)
        Dim ls_shipper As String

        If Not IsEmpty(dSet) Then
            ls_shipper = DataValue(dSet)
        Else
            ls_shipper = ""
        End If

        shipper.Text = ls_shipper
    End Sub
    
    Private Sub b_saveas_Click(sender As Object, e As System.EventArgs) Handles b_saveas.Click
        Dim ls_otno As String

        ls_otno = ot_no.Text

        If ls_otno = "" Then
            MsgBox("복사할 전표번호를 먼저 선택하십시요.")
            Return
        Else
            ot_no.Text = ""
            invoice_dt.Text = Today
            ac_gu.Text = "S"
            ot_gu.Text = "3"
            odgu_cd.Text = "03"

            n.Clear()
            n.Add("@ot_no", "XXX")
            n.Add("@ot_gu", "XXX")

            Me.Open("wi_tr1140_tab2", n)
        End If
    End Sub


End Class
