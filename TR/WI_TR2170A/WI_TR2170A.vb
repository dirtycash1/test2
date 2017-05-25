Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR2170A
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

        For i As Integer = 0 To g_body.RowCount - 1
            g_body.Text("RATE", i) = ToDec(rate.Text)
        Next

    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.IPAMT()
        Me.delete_row()

        If wf_check() = 1 Then
            Return False
        End If

        If check_misu_amt() = 1 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                stts1.Text = "S"
            End If

            g_list.Open()
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@ip_no", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170a_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ip_no.CodeNo = "WI_TR2170A"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ip_no.CodeDateField = ip_dt
    End Sub

    Private Function Del() As Boolean

        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_tr2170a_delete", p)

            '화면 다시 조회
            p.Clear()
            p.Add("@IP_NO", "XXX")

            Me.Open("wi_tr2170a_head", p)

            p.Clear()
            p.Add("@IP_NO", "XXX")

            Me.Open("wi_tr2170a_body", p)

            p.Clear()
            p.Add("@IP_NO", "XXX")

            Me.Open("wi_tr2170a_body1", p)
            '--

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
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.IPAMT()
        Me.delete_row()

        If wf_check() = 1 Then
            Return False
        End If

        If check_misu_amt() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr2170a_confirm", p)

            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@ip_dt", ip_dt.Text)
            p.Add("@ps_cd", ps_cd.Text)

            Me.Open("wi_tr2170a_insert_actr1000", p)

            '화면 다시 조회
            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_head", p)

            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_body", p)

            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_body1", p)
            '--

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If ip_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If wf_de_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@ip_no", ip_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr2170a_deconfirm", p)

            '화면 다시 조회
            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_head", p)

            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_body", p)

            p.Clear()
            p.Add("@IP_NO", ip_no.Text)

            Me.Open("wi_tr2170a_body1", p)
            '--

            g_list.Open()
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

        Me.Open("wi_tr2170a_head", p)

        p.Clear()
        p.Add("@ip_no", "XXX")

        Me.Open("wi_tr2170a_body", p)

        p.Clear()
        p.Add("@ip_no", "XXX")

        Me.Open("wi_tr2170a_body1", p)

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
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_stts", find_stts.Text)
        p.Add("@find_cs_nm", find_cs_nm.Text)

        Me.Open("wi_tr2170a_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@IP_NO", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_tr2170a_head", p)

        p.Clear()
        p.Add("@IP_NO", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_tr2170a_body", p)

        p.Clear()
        p.Add("@IP_NO", g_list.Text("IP_NO", g_list.RowIndex))

        Me.Open("wi_tr2170a_body1", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
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
        sale_amt.Text = ip_amt1
    End Sub

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        If cur_cd.Text <> "" Then
            Me.wf_setitem(cs_cd.Text, cur_cd.Text)
        End If
    End Sub

    Private Sub cur_cd_TextChanged(sender As Object, e As System.EventArgs) Handles cur_cd.TextChanged
        If cs_cd.Text <> "" Then
            Me.wf_setitem(cs_cd.Text, cur_cd.Text)
        End If

        Me.Setitem_Rate()
    End Sub

    Private Sub rate_TextChanged(sender As Object, oldValue As String) Handles rate.TextChanged
        wf_rate()
    End Sub

    Private Sub ip_dt_TextChanged(sender As Object, e As System.EventArgs) Handles ip_dt.TextChanged
        Me.Setitem_Rate()
    End Sub

    Private Sub wf_setitem(a_cscd As String, a_curcd As String)

        g_body1.DeleteAll()

        p.Clear()
        p.Add("@CUR_CD", a_curcd)
        p.Add("@CS_CD", a_cscd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170a_setitemdw3", p)

        If Not IsEmpty(dSet) Then
            With g_body1
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("OD_NO", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("CUR_CD", iRow) = ToStr(dRow("CUR_CD"))
                    .Text("OD_AMT", iRow) = ToDec(dRow("OD_AMT"))
                    .Text("IN_AMT", iRow) = ToDec(dRow("IN_AMT"))
                    .Text("SUB_AMT", iRow) = ToDec(dRow("OD_AMT")) - ToDec(dRow("IN_AMT"))
                    .Text("OT_GU", iRow) = "TR044O"
                    .Text("RATE", iRow) = ToDec(rate.Text)

                    iRow += 1
                Next
            End With
        End If

        If g_body1.RowCount <= 0 Then
            MsgBox("선수금할 내역이 없습니다!")
        End If
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

    Private Sub Setitem_Rate()
        p.Clear()
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@IP_DT", ip_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170a_set_rate", p)
        Dim ld_rate As Decimal

        If Not IsEmpty(dSet) Then
            ld_rate = DataValue(dSet)
        Else
            ld_rate = 1
        End If

        rate.Text = ld_rate
    End Sub

    Private Sub Set_Ipamt()
        Dim ld_tot As Decimal = 0
        Dim ld_rmamt As Decimal = 0

        g_body.UpdateRow()

        For i As Integer = 0 To g_body.RowCount - 1
            ld_tot = ld_tot + g_body.ToDec("IP_AMT", i)
        Next

        g_body1.UpdateRow()

        g_body1.RowIndex = 0

        For b As Integer = 0 To g_body1.RowCount + 1
            ld_rmamt = g_body1.ToDec("OD_AMT", b) - g_body1.ToDec("IN_AMT", b)

            If ld_tot > ld_rmamt Then
                g_body1.Text("IP_AMT", b) = ld_rmamt

                ld_tot -= ld_rmamt
                MsgBox(ld_tot)
            Else
                g_body1.Text("IP_AMT", b) = ld_tot

                ld_tot = 0
            End If
        Next
    End Sub

    Private Sub g_body_AddedRow(sender As Object, RowIndex As Integer) Handles g_body.AddedRow
        wf_rate()

    End Sub

    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        If ColumnName = "IP_AMT" Then
            g_body.Text("WON_AMT") = Math.Round(g_body.ToDec("IP_AMT") * g_body.ToDec("RATE"))

            Me.IPAMT()
            'Me.Set_Ipamt()
        End If
    End Sub

    Private Sub g_body1_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body1.CellValueChanged
        If ColumnName = "IP_AMT" Then
            g_body1.Text("SUB_AMT") = g_body1.ToDec("OD_AMT") - g_body1.ToDec("IN_AMT") - g_body1.ToDec("IP_AMT")
        End If
    End Sub

    Private Function wf_check() As Integer
        Dim ld_rate As Decimal = ToDec(rate.Text)
        Dim ls_ipgu, ls_acno As String
        Dim ld_ipamt, ld_sumip As Decimal
        Dim ld_ipamt1, ld_sumip1 As Decimal

        If (ld_rate = 1) Or (ld_rate = 0) Then
            MsgBox("해당 수금일자의 환율을 입력하십시요.")
            Return 1
        End If

        ld_sumip = 0
        ld_sumip1 = 0

        With g_body
            For i As Integer = 0 To g_body.RowCount - 1
                ls_ipgu = .Text("IP_GU", i)
                ls_acno = .Text("AC_NO", i)
                ld_ipamt = .ToDec("IP_AMT", i)

                If ls_ipgu = "12" Then
                    If ls_acno = "" Then
                        MsgBox("외화예금일 때 계좌번호는 필수 입력필드 입니다.")
                        .Focus()
                        .FocusedFieldName = "AC_NO"
                        .RowIndex = i
                        .EditMode()
                        Return 1
                    End If
                End If

                ld_sumip += ld_ipamt
            Next
        End With

        With g_body1
            For b As Integer = 0 To g_body1.RowCount - 1
                ld_ipamt1 = .ToDec("IP_AMT", b)

                ld_sumip1 += ld_ipamt1

                '.Text("RATE", b) = ToDec(rate.Text)
                '.Text("WON_AMT", b) = Math.Round(ToDec(rate.Text) * ld_ipamt1)

            Next
        End With

        If ld_sumip <> ld_sumip1 Then
            MsgBox("입금내역 합과 수주별선수금내역 합이 같지 않습니다.")
            Return 1
        End If

        If g_body.RowCount() <= 0 Then
            MsgBox("등록할 입금내역이 없습니다.")
            Return 1
        End If

        If g_body1.RowCount() <= 0 Then
            MsgBox("등록할 수주별선수금내역이 없습니다.")
            Return 1
        End If

        Return 0
    End Function

    Private Sub delete_row()
        Dim ld_ipamt, ld_ipamt1 As Decimal

        For i As Integer = 0 To g_body.RowCount - 1
            ld_ipamt = g_body.ToDec("IP_AMT", i)

            If ld_ipamt = 0 Then
                g_body.DeleteRow(i)
            End If
        Next

        For b As Integer = 0 To g_body1.RowCount - 1
            ld_ipamt1 = g_body1.ToDec("IP_AMT", b)

            If ld_ipamt1 = 0 Then
                g_body1.DeleteRow(b)
                'b = b - 1

                'If b = g_body1.RowCount Then Exit For
            End If
        Next
    End Sub

    Private Function check_misu_amt() As Integer
        'Dim ls_invno, ls_odno, ls_ipno As String
        'Dim ld_ipamt, ld_odamt, ld_inamt As Decimal

        'ls_ipno = ip_no.Text

        'For i As Integer = 0 To g_body1.RowCount - 1
        '    ls_invno = g_body1.Text("INV_NO", i)
        '    ls_odno = g_body1.Text("OD_NO", i)
        '    ld_ipamt = g_body1.ToDec("IP_AMT", i)
        '    ld_odamt = g_body1.ToDec("OD_AMT", i)
        '    ld_inamt = g_body1.ToDec("IN_AMT", i)

        '    If ld_odamt < (ld_inamt + ld_ipamt) Then
        '        MsgBox("미수금액을 초과하였습니다.")
        '        Return 1
        '    End If
        'Next

        Return 0
    End Function

    Private Function wf_de_check() As Integer
        p.Clear()
        p.Add("@ip_no", ip_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2170a_de_chk", p)
        Dim ls_slgu As String

        If Not IsEmpty(dSet) Then
            ls_slgu = DataValue(dSet)
        Else
            ls_slgu = "0"
        End If

        If ls_slgu = "1" Then
            MsgBox("해당 전표번호로 등록된 미승인 회계전표가 있습니다.")
            Return 1
        ElseIf ls_slgu = "2" Then
            MsgBox("해당 전표번호로 등록된 승인된 회계전표가 있습니다.")
            Return 1
        End If

        Return 0
    End Function
End Class
