Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR2170
    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

            Case MenuType.Save
                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
                If Not DeConFrim() Then Exit Sub

            Case MenuType.Find
                Me.Find()

            Case MenuType.Delete
                If Not Del() Then Exit Sub

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 자료입니다.!")
            Return False
        End If

        'If Me.wf_check("0") Then
        '    Return False
        'End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                stts1.Text = "S"
            End If
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@IP_NO", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' 전표 번호 채번
        ip_no.CodeNo = "WI_TR2170"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ip_no.CodeDateField = ip_dt
    End Sub

    Private Function Del() As Boolean

        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@IP_NO", ip_no.Text)
            p.Add("@STTS", "D")

            Me.Open("wi_tr2170_delete", p)

            p.Clear()
            p.Add("@ip_no", "XXX")

            Me.Open("wi_tr2170_head", p)
            Me.Open("wi_tr2170_body", p)
            Me.Open("wi_tr2170_body2", p)
            Me.Open("wi_tr2170_body3", p)

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean
        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 자료입니다.!")
            Return False
        End If

        'If Me.wf_check("1") Then
        '    Return False
        'End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@IP_NO", ip_no.Text)
            p.Add("@STTS", "C")

            Me.Open("wi_TR2170_confirm", p)

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@ip_dt", ip_dt.Text)
            p.Add("@ps_cd", ps_cd.Text)

            Me.Open("wi_tr2170_insert_actr1000", p)

            p.Clear()
            p.Add("@ip_no", "XXX")

            Me.Open("wi_tr2170_head", p)
            Me.Open("wi_tr2170_body", p)
            Me.Open("wi_tr2170_body2", p)
            Me.Open("wi_tr2170_body3", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If Check_Stts() = "S" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@IP_NO", ip_no.Text)
            p.Add("@STTS", "S")

            Me.Open("wi_tr2170_confirm", p)

            p.Clear()
            p.Add("@ip_no", ip_no.Text)

            Me.Open("wi_tr2170_head", p)
            Me.Open("wi_tr2170_body", p)
            Me.Open("wi_tr2170_body2", p)
            Me.Open("wi_tr2170_body3", p)
        End If

        Return True
    End Function

    Private Function Check_CsCd() As Boolean
        Try
            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function

    Private Sub Clear()
        p.Clear()
        p.Add("@ip_no", "XXX")

        Me.Open("wi_tr2170_head", p)
        Me.Open("wi_tr2170_body", p)
        Me.Open("wi_tr2170_body2", p)
        Me.Open("wi_tr2170_body3", p)

        g_body.InsertNewRow(0)
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False

        End If
    End Sub

    Private Sub find_Clear()
        p.Clear()
        p.Add("@FIND_FROM", find_from.Text)
        p.Add("@FIND_TO", find_to.Text)
        p.Add("@FIND_CS_NM", "XXX")
        p.Add("@FIND_STTS", find_stts.Text)

        Me.Open("wi_tr2170_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@ip_no", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_tr2170_head", p)
        Me.Open("wi_tr2170_body", p)
        Me.Open("wi_tr2170_body2", p)
        Me.Open("wi_tr2170_body3", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        If cur_cd.Text <> "" Then
            Me.wf_setitemdw1(cs_cd.Text, cur_cd.Text)
            Me.wf_setitemdw2(cs_cd.Text, cur_cd.Text)
        End If
    End Sub

    Private Sub cur_cd_TextChanged(sender As Object, e As System.EventArgs) Handles cur_cd.TextChanged
        If cs_cd.Text <> "" Then
            Me.wf_setitemdw1(cs_cd.Text, cur_cd.Text)
            Me.wf_setitemdw2(cs_cd.Text, cur_cd.Text)
        End If

        Me.Setitem_Rate()
    End Sub

    Private Sub wf_setitemdw1(a_cscd As String, a_curcd As String)

        g_body2.DeleteAll()

        p.Clear()
        p.Add("@CUR_CD", a_curcd)
        p.Add("@CS_CD", a_cscd)

        Me.Open("wi_tr2170_misu", p)

        Dim dSet As DataSet = Me.WorkSet("wi_tr2170_misu").DataSet

        If Not IsEmpty(dSet) Then
            With g_body2
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                For Each dRow In dRows
                    Try
                        '줄추가
                        .AddNewRow()
                        '줄추가 줄
                        .RowIndex = iRow

                        .Text("INV_NO", iRow) = ToStr(dRow("OT_NO"))
                        .Text("CUR_CD", iRow) = a_curcd
                        .Text("RATE", iRow) = ToDec(dRow("RATE"))
                        .Text("INV_AMT", iRow) = ToDec(dRow("OT_AMT"))
                        .Text("INV_AMTW", iRow) = ToDec(dRow("KWASE_AMTW"))
                        .Text("IN_AMT", iRow) = ToDec(dRow("IN_AMT"))
                        .Text("SUB_AMT", iRow) = ToDec(dRow("OT_AMT")) - ToDec(dRow("IN_AMT"))

                    Catch ex As Exception
                        MessageError(ex, , "Display()")
                    End Try
                    iRow += 1
                Next
            End With
        End If

        If g_body2.RowCount <= 0 Then
            MsgBox("미수금내역이 없습니다!")
        End If
    End Sub

    Private Sub wf_setitemdw2(a_cscd As String, a_curcd As String)

        g_body3.DeleteAll()

        p.Clear()
        p.Add("@CUR_CD", a_curcd)
        p.Add("@CS_CD", a_cscd)
        Me.Open("wi_tr2170_odno_ip", p)

        Dim dSet As DataSet = Me.WorkSet("wi_tr2170_odno_ip").DataSet

        If Not IsEmpty(dSet) Then
            With g_body3
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                For Each dRow In dRows
                    Try
                        '줄추가
                        .AddNewRow()
                        '줄추가 줄
                        .RowIndex = iRow

                        .Text("INV_NO", iRow) = ToStr(dRow("OT_NO"))
                        .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                        .Text("OD_AMT", iRow) = ToDec(dRow("OD_AMT"))
                        .Text("IN_AMT", iRow) = ToDec(dRow("IN_AMT"))
                        .Text("SUB_AMT", iRow) = ToDec(dRow("OD_AMT")) - ToDec(dRow("IN_AMT"))
                        '.Text("FILE_NO", iRow) = ToStr(dRow("FILE_NO"))
                    Catch ex As Exception
                        MessageError(ex, , "Display()")
                    End Try

                    iRow += 1
                Next
            End With
        End If

        If g_body3.RowCount <= 0 Then
            MsgBox("수주번호별 수금 내역이 없습니다!")
        End If
    End Sub

    Private Sub rate_TextChanged(sender As Object, oldValue As String) Handles rate.TextChanged
        wf_rate()
    End Sub

    Private Sub ip_dt_TextChanged(sender As Object, e As System.EventArgs) Handles ip_dt.TextChanged
        Me.Setitem_Rate()
    End Sub

    Private Sub wf_rate()
        Dim ld_rate As Decimal = ToDec(rate.Text)

        If g_body.RowCount() > 0 Then
            For i As Integer = 0 To g_body.RowCount - 1
                g_body.Text("RATE", i) = ld_rate
                g_body.Text("WON_AMT", i) = Math.Round(ld_rate * g_body.ToDec("IP_AMT", i), 0)
            Next
        End If

        Me.IPAMT()
    End Sub

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        If ColumnName = "IP_AMT" Then
            g_body.Text("WON_AMT") = Math.Round(g_body.ToDec("IP_AMT") * g_body.ToDec("RATE"))

            Me.IPAMT()
            Me.Set_Ipamt()
        End If
    End Sub

    Private Sub g_body2_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body2.CellValueChanged
        If ColumnName = "IP_AMT" Then
            g_body2.Text("WON_AMT") = Math.Round(g_body2.ToDec("IP_AMT") * g_body2.ToDec("RATE"))
        End If
    End Sub

    Private Sub wf_set_body(a_row As Integer, a_ipgu As String)
        Dim ls_ipgu As String = ""

        ls_ipgu = a_ipgu

        p.Clear()
        p.Add("@IPGU_CD", ls_ipgu)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170_ipgu", p)

        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            iRow = a_row

            For Each dRow In dRows
                g_body.Text("AC_CD", iRow) = ToStr(dRow("AC_CD"))
                g_body.Text("AC_CD1", iRow) = ToStr(dRow("AC_CD1"))
                g_body.Text("ACKI_NM", iRow) = ToStr(dRow("ACKI_NM"))
                g_body.Text("AC_NO", iRow) = ToStr(dRow("AC_NO"))
                g_body.Text("AC_NM", iRow) = ToStr(dRow("AC_NM"))
            Next
        End If
    End Sub

    Private Sub g_body_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanging
        If ColumnName = "IP_GU" Then
            Dim ls_ipgu As String = ""

            ls_ipgu = Value

            wf_set_body(RowIndex, ls_ipgu)
        End If
    End Sub

    Private Sub IPAMT()
        Dim ip_amt1, won_amt1 As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                ip_amt1 = ip_amt1 + .ToDec("IP_AMT", i)
                won_amt1 = won_amt1 + .ToDec("WON_AMT", i)
            Next
        End With

        tot_amt.Text = ip_amt1
        won_amt.Text = won_amt1
    End Sub

    Private Sub Set_Ipamt()
        Dim ld_tot As Decimal = 0
        Dim ld_rate As Decimal = 1
        Dim ld_rmamt As Decimal = 0
        Dim ld_tot1 As Decimal = 0
        Dim ld_rmamt1 As Decimal = 0

        g_body.UpdateRow()

        For i As Integer = 0 To g_body.RowCount - 1
            ld_tot = ld_tot + g_body.ToDec("IP_AMT", i)
            ld_tot1 = ld_tot1 + g_body.ToDec("IP_AMT", i)
        Next

        g_body2.UpdateRow()

        For A As Integer = 0 To g_body2.RowCount - 1
            ld_rate = g_body2.ToDec("RATE")
            ld_rmamt = g_body2.ToDec("INV_AMT") - g_body2.ToDec("IN_AMT")

            If ld_tot > ld_rmamt Then
                g_body2.Text("IP_AMT", A) = ld_rmamt
                'g_body2.Text("WON_AMT", A) = Truncating(ld_rmamt * ld_rate, 0)
                g_body2.Text("WON_AMT", A) = Rounding(ld_rmamt * ld_rate, 0)

                ld_tot -= ld_rmamt
            Else
                g_body2.Text("IP_AMT", A) = ld_tot
                g_body2.Text("WON_AMT", A) = Rounding(ld_tot * ld_rate, 0)

                ld_tot = 0
            End If
        Next

        g_body3.UpdateRow()

        For b As Integer = 0 To g_body3.RowCount - 1
            ld_rmamt1 = g_body3.ToDec("OD_AMT") - g_body3.ToDec("IN_AMT")

            If ld_tot1 > ld_rmamt1 Then
                g_body3.Text("IP_AMT", b) = ld_rmamt1

                ld_tot1 -= ld_rmamt1
            Else
                g_body3.Text("IP_AMT", b) = ld_tot1

                ld_tot1 = 0
            End If
        Next
    End Sub

    Private Sub g_body3_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body3.CellValueChanged
        Dim ls_invno, ls_invno1 As String
        Dim ld_ipamt As Decimal = 0

        If ColumnName = "IP_AMT" Then
            ls_invno = g_body3.Text("INV_NO", g_body3.RowIndex)
            ld_ipamt = g_body3.Text("IP_AMT", g_body3.RowIndex)

            For b As Integer = 0 To g_body2.RowCount - 1
                ls_invno1 = g_body2.Text("INV_NO", b)

                If ls_invno = ls_invno1 Then
                    g_body2.Text("IP_AMT", b) = ld_ipamt
                End If
            Next
        End If
    End Sub

    Private Function wf_check(a_gu As Integer) As Integer
        Dim ls_ipdt As String = ip_dt.Text
        Dim ld_rate As Decimal = ToDec(rate.Text)

        Dim ls_pscd As String = ps_cd.Text
        Dim ls_cscd As String = cs_cd.Text
        Dim ls_curcd As String = cur_cd.Text
        Dim ls_ipno As String = ip_no.Text
        Dim ls_acgu1 As String = ac_gu.Text

        Dim ls_ipgu, ls_accd, ls_acgu, ls_body_cscd, ls_acno As String
        Dim ld_iamt As Decimal = 0
        Dim i As Integer = 0

        Dim ls_otgu As String = ""
        Dim ls_ivno As String = ""
        Dim ld_vamts As Decimal = 0
        Dim ld_vamtw As Decimal = 0
        Dim ld_pamts As Decimal = 0
        Dim ld_pamtw As Decimal = 0
        Dim ld_namts As Decimal = 0
        Dim ld_namtw As Decimal = 0
        Dim ld_samt As Decimal = 0
        Dim ld_pamt As Decimal = 0

        For i = 0 To g_body.RowCount - 1
            ls_ipgu = g_body.Text("IP_GU", i)
            ls_accd = g_body.Text("AC_CD", i)
            ls_acgu = g_body.Text("AC_GU", i)
            ls_acno = g_body.Text("AC_NO", i)
            ld_iamt = g_body.ToDec("WON_AMT", i)
            ls_body_cscd = g_body.Text("CS_CD", i)

            '    If ls_accd = "" Then
            '        MsgBox("입급구분을 선택하십시오.")
            '        g_body.DeleteRow(i)
            '        i = i - 1
            '        'Return False
            '    Else
            '        If ls_ipgu = "" Then
            '            MsgBox("입급구분을 선택하십시오.")
            '            Return False
            '        End If

            '        If ls_ipgu = "03" Or ls_ipgu = "09" Or ls_ipgu = "10" Or ls_ipgu = "12" Then
            '            MsgBox("계좌번호를 확인하십시오.")
            '            Return False
            '        End If

            '        If ld_iamt = "" Or ld_iamt = 0 Then
            '            MsgBox("원화금액을 확인하십시오.")
            '            Return False
            '        End If
            '    End If
        Next

        If g_body.RowCount <= 0 Then
            MsgBox("저장할 항목이 없습니다.")
            Return 1
        End If

        For i = 0 To g_body2.RowCount - 1
            ls_otgu = g_body2.Text("OT_GU", i)
            ls_ivno = g_body2.Text("INV_NO", i)
            ld_vamts = g_body2.ToDec("INV_AMT", i)
            ld_vamtw = g_body2.ToDec("INV_AMTW", i)
            ld_pamts = g_body2.ToDec("IP_AMT", i)
            ld_pamtw = g_body2.ToDec("WON_AMT", i)

            If ld_pamts = 0 Then
                g_body2.DeleteRow(i)
                i = i - 1
            Else
                ls_otgu = "O"

                If ls_otgu <> "S" Then
                    p.Clear()
                    p.Add("@INV_NO", ls_ivno)

                    Me.Open("wi_tr2170_misu_chk", p)

                    Dim dSet As DataSet = Me.WorkSet("wi_tr2170_misu_chk").DataSet

                    If Not IsEmpty(dSet) Then

                        Dim iRow As Integer = 0
                        Dim dRow As DataRow, dRows As DataRowCollection
                        dRows = dSet.Tables(0).Rows

                        For Each dRow In dRows

                            Try

                                ld_namts = ToStr(dRow("IP_AMT"))
                                ld_namtw = ToDec(dRow("WON_AMT"))

                            Catch ex As Exception
                                MessageError(ex, , "Display()")
                            End Try

                            iRow += 1
                        Next

                        g_body2.Text("IN_AMT", i) = ld_namts

                        If ld_pamts > (ld_vamts - ld_namts) Then
                            MsgBox("미수금액을 초과하였습니다.")
                            Return False
                        End If

                        ld_samt += ld_pamts
                    End If

                    ld_pamt += ld_pamts
                End If

            End If
        Next

        Dim ls_invno5 As String = ""
        Dim ls_odno5 As String = ""
        Dim ld_odamt5 As Decimal = 0
        Dim ld_wonamt5 As Decimal = 0
        Dim ld_ipamt5 As Decimal = 0
        Dim ld_suminamt5 As Decimal = 0
        Dim ld_sumwonamt5 As Decimal = 0

        For k As Integer = 0 To g_body3.RowCount - 1
            ls_invno5 = g_body3.Text("INV_NO", k)
            ls_odno5 = g_body3.Text("OD_NO", k)
            ld_odamt5 = g_body3.ToDec("OD_AMT", k)
            ld_wonamt5 = g_body3.ToDec("WON_AMT", k)
            ld_ipamt5 = g_body3.Text("IP_AMT", k)

            If ld_iamt = 0 Then
                g_body3.DeleteRow(k)
                k = k - 1
            Else
                p.Clear()
                p.Add("@INV_NO", ls_invno5)
                p.Add("@OD_NO", ls_odno5)
                p.Add("@IP_NO", ls_ipno)

                Me.Open("wi_tr2170_misu_chk1", p)

                Dim dSet As DataSet = Me.WorkSet("wi_tr2170_misu_chk1").DataSet

                If Not IsEmpty(dSet) Then

                    Dim iRow As Integer = 0
                    Dim dRow As DataRow, dRows As DataRowCollection
                    dRows = dSet.Tables(0).Rows

                    For Each dRow In dRows

                        Try

                            ld_suminamt5 = ToStr(dRow("IP_AMT"))
                            ld_sumwonamt5 = ToDec(dRow("WON_AMT"))

                        Catch ex As Exception
                            MessageError(ex, , "Display()")
                        End Try

                        iRow += 1
                    Next
                End If

                If ld_ipamt5 > (ld_odamt5 - ld_suminamt5) Then
                    MsgBox("수주 :" + ls_odno5 + " 의 미수금액을 초과하였습니다.")
                    Return False
                End If

            End If
        Next

        If g_body2.RowCount <= 0 Then
            MsgBox("저장할 항목이 없습니다.")
            Return False
        End If

        If g_body3.RowCount <= 0 Then
            MsgBox("저장할 항목이 없습니다.")
            Return False
        End If

        Dim ld_samt1 As Decimal = g_body.ToDec("TOT_IP", 1)
        Dim ld_wamt1 As Decimal = g_body.ToDec("TOT_WON", 1)
        Dim ld_samt2 As Decimal = g_body2.ToDec("TOT_IP", 1)
        Dim ld_wamt2 As Decimal = g_body2.ToDec("TOT_WON", 1)

        If ld_samt1 <> ld_samt2 Then
            MsgBox("수금금액의 합계가 일치하지 않습니다.")
            Return False
        End If

        'If a_gu = 1 And (ld_wamt1 <> ld_wamt2) Then
        '    If MessageYesNo("원화금액의 합계가 일치하지 않습니다. 외환손익으로 처리하시겠습니까?") = MsgBoxResult.No Then
        '        Return False
        '    End If
        'End If

        Return True
    End Function

    Private Sub Setitem_Rate()
        p.Clear()
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@IP_DT", ip_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170_set_rate", p)
        Dim ld_rate As Decimal

        If Not IsEmpty(dSet) Then
            ld_rate = DataValue(dSet)
        Else
            ld_rate = 1
        End If

        rate.Text = ld_rate
    End Sub
End Class
