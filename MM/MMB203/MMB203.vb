Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MMB203
    Private temp_dlv As Integer = 0
    Dim p As New OpenParameters

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'g10.ColumnVisible("cust_nm") = Me.IsManager
        'cust_cd.ReadOnly = Not Me.IsManager


        lot_save.Enabled = False

        g10.SelectRow = True

        SplitContainer3.Panel2Collapsed = True

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me._Open()

            Case MenuType.Save

                'If MessageYesNo("화면(하단) <입고현황및취소> 자료만 '<삭제> or <저장>' 가능합니다." + vbLf +
                '                "입고처리는 <(가)입고처리> 버튼으로 진행하세요. " + vbLf +
                '                "저장 하시겠습니까?") <> MsgBoxResult.Yes Then
                '    Exit Sub
                'End If
                If MessageYesNo("입고현황및취소 삭제는 하단 [저장] 버튼을 클릭하세요" + vbLf +
                                "입고처리는 [(가)입고처리] 버튼으로 진행하세요." + vbLf +
                                "계속 진행하시겠습니까?.") <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub


    Private Sub _Open()

        '특별권한자가 아니면 업체코드는 필수 검색조건
        'If Not Me.IsManager Then
        '    If Not CheckRequired(cust_cd) Then
        '        Exit Sub
        '    End If
        'End If

        Dim poNo As String = g10.Text("po_no")
        Dim poSq As String = g10.Text("po_sq")

        MyBase.Open()

        Dim find(1) As String
        find(0) = "po_no=" + poNo
        find(1) = "po_sq=" + poSq

        g10.Find(find)

    End Sub

    Public Sub Open2(ByVal poNo As String, ByVal podt As String, ByVal dibc As String)
        po_no.Text = poNo
        po_fr.Text = podt
        dir_bc.Text = dibc
        Me.Open()
    End Sub


    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True


        If ColumnName = "chk" Then


            If Value = "1" Then
                'g30.Text("dlv_qty") = g10.Text("rem_qty")
                'g30.Text("dlv_up") = g10.Text("po_up")
                g10.Text("dlv_qty") = g10.Text("rem_qty")

                If g10.ToDec("dlv_qty") < 0 Then
                    g10.Text("dlv_qty") = "0"
                End If

            Else
                g10.Text("dlv_qty") = ""
            End If

        End If

        If ColumnName = "dlv_qty" Then

            g10.Text("chk") = IIf(Value = "", "0", "1")

        End If


        m_StopEvent = False

    End Sub

    Private Sub g20_AddedRow(sender As Object, RowIndex As Integer) Handles g20.AddedRow
        g20.Text("dlv_dt", RowIndex) = g20.Text("dlv_dt", RowIndex - 1)
        g20.Text("dlv_no", RowIndex) = g20.Text("dlv_no", RowIndex - 1)
        g20.Text("itm_id", RowIndex) = g20.Text("itm_id", RowIndex - 1)
        g20.Text("itm_cd", RowIndex) = g20.Text("itm_cd", RowIndex - 1)
        g20.Text("itm_nm", RowIndex) = g20.Text("itm_nm", RowIndex - 1)
        g20.Text("spec", RowIndex) = g20.Text("spec", RowIndex - 1)
        g20.Text("mng_no", RowIndex) = g20.Text("mng_no", RowIndex - 1)
        g20.Text("di_bc", RowIndex) = g20.Text("di_bc", RowIndex - 1)
        g20.Text("use_bc", RowIndex) = g20.Text("use_bc", RowIndex - 1)
        g20.Text("dlv_um", RowIndex) = g20.Text("dlv_um", RowIndex - 1)
        g20.Text("dlv_up", RowIndex) = g20.Text("dlv_up", RowIndex - 1)
        g20.Text("cury_bc", RowIndex) = g20.Text("cury_bc", RowIndex - 1)
        g20.Text("unit_qty", RowIndex) = g20.Text("unit_qty", RowIndex - 1)
        g20.Text("ex_rt", RowIndex) = g20.Text("ex_rt", RowIndex - 1)
        g20.Text("um_bc", RowIndex) = g20.Text("um_bc", RowIndex - 1)
        g20.Text("dlv_amt", RowIndex) = g20.Text("dlv_amt", RowIndex - 1)
        g20.Text("in_up", RowIndex) = g20.Text("in_up", RowIndex - 1)
        g20.Text("po_no", RowIndex) = g20.Text("po_no", RowIndex - 1)
        g20.Text("po_sq", RowIndex) = g20.Text("po_sq", RowIndex - 1)
        g20.Text("bl_mngno", RowIndex) = g20.Text("bl_mngno", RowIndex - 1)
        g20.Text("bl_sq", RowIndex) = g20.Text("bl_sq", RowIndex - 1)
        g20.Text("in_fac", RowIndex) = g20.Text("in_fac", RowIndex - 1)
        g20.Text("in_wh", RowIndex) = g20.Text("in_wh", RowIndex - 1)
        g20.Text("req_no", RowIndex) = g20.Text("req_no", RowIndex - 1)
        g20.Text("in_wh", RowIndex) = g20.Text("in_wh", RowIndex - 1)
        g20.Text("req_sq", RowIndex) = g20.Text("req_sq", RowIndex - 1)
        g20.Text("bl_sq", RowIndex) = g20.Text("bl_sq", RowIndex - 1)
        g20.Text("in_fac", RowIndex) = g20.Text("in_fac", RowIndex - 1)
        g20.Text("in_wh", RowIndex) = g20.Text("in_wh", RowIndex - 1)
        g20.Text("bl_mngno", RowIndex) = g20.Text("bl_mngno", RowIndex - 1)
        g20.Text("in_wh", RowIndex) = g20.Text("in_wh", RowIndex - 1)
        g20.Text("cust_cd", RowIndex) = g20.Text("cust_cd", RowIndex - 1)
    End Sub


    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged

        If m_StopEvent = True Then Exit Sub

        m_StopEvent = True

        With g20

            If ColumnName = "cury_bc" Then '통화에 따른 환율 넣기
                Dim dSet As DataSet

                Dim p As New OpenParameters
                p.Add("@std_dt", std_dt.Text)
                p.Add("@cury_bc", .Text("cury_bc"))

                dSet = Me.OpenDataSet("mmb_ex_rt", p)

                If Not IsEmpty(dSet) Then
                    If .Text("cury_bc") = "BC400JPY" Then
                        .Text("ex_rt") = dSet.Tables(0).Rows(0)(1).ToString() '환율 JPY(100)
                        .Text("ex_rt") = .ToDec("ex_rt") / 100
                    Else
                        .Text("ex_rt") = dSet.Tables(0).Rows(0)(1).ToString() '환율
                    End If

                Else
                    If .Text("di_bc") = "MM060100" And .Text("cury_bc") <> "BC400KRW" Then
                        '    MessageInfo("내자(국내 원화 구매) 인 경우에는 통화는 원화입니다.")
                        'Else
                        MessageInfo("해당 날짜에 등록된 환율이 없습니다. 먼저 환율가져오기를 실행해 주세요.")
                    End If
                End If

                For i As Integer = 0 To .RowCount - 1
                    If .IsDataRow(i) Then
                        .RowIndex = i
                        .Text("in_up") = .ToDec("dlv_up") * .ToDec("ex_rt")
                    End If
                Next

            End If

            If ColumnName = "dlv_up" Then
                .Text("in_up") = .ToDec("dlv_up") * .ToDec("ex_rt")
            End If


        End With

        m_StopEvent = False

    End Sub


    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        '필드 텍스트 항목 필수값 줄때
        'If Not CheckRequired(in_fac, in_wh, dlv_dt) Then
        '    Exit Sub
        'End If


        If g10.Text("chk") = "1" And g10.Text("lot_yn") <> "1" Then

            If g10.Text("in_fac") = "" Then
                MsgBox("입고공장을 선택하세요. 일괄선택은 검색항목의 입고공장(일괄)로 적용합니다")
                Exit Sub
            End If

            If g10.Text("in_wh") = "" Then
                MsgBox("입고창고를 선택하세요. 일괄선택은 검색항목의 입고창고(일괄)로 적용합니다")
                Exit Sub
            End If

            If Me.Save(g10.WorkSet) Then
                Me._Open()
                sms_sand()
            End If

        End If


        If g10.Text("lot_yn") = "1" And g10.Text("chk") = "1" Then

            If g10.Text("in_fac") = "" Then
                MsgBox("입고공장을 선택하세요. 일괄선택은 검색항목의 입고공장(일괄)로 적용합니다")
                Exit Sub
            End If

            If g10.Text("in_wh") = "" Then
                MsgBox("입고창고를 선택하세요. 일괄선택은 검색항목의 입고창고(일괄)로 적용합니다")
                Exit Sub
            End If

            lot_chk.Text = "1"

            lot_save.Enabled = True

            Dim b As Integer = 0
            For k = 0 To g10.RowCount - 1
                If g10.Text("chk", k) = "1" Then
                    b = b + 1
                End If
            Next
            If b > 1 Then
                MsgBox("Lot별 입고는 1개의 품목만 선택 가능하며" + vbLf +
                       "<마우스> 커서 위치와 <선택> 칼럼 체크(V) 위치가 동일해야 합니다" + vbLf +
                       "<조회> 버튼을 클릭하면 선택위치를 초기화 합니다")
                Exit Sub
            End If

            If g10.RowCount - 1 >= 0 Then
                Dim i As Integer
                Dim a As Integer
                a = 0

                For i = 0 To g10.RowCount - 1
                    If g10.Text("lot_yn", i) = "1" Then
                        a = a + 1
                    End If
                Next

                If a = 0 Then
                    MsgBox("입고될 항목이 없습니다.")
                    Exit Sub
                Else
                    'dlv_no.Text = ""
                    sms_sand()
                    MyBase.Open("mmb203_g30")

                    Dim x As Integer

                    For x = 0 To g10.RowCount - 1
                        If g10.Text("lot_yn", x) = "1" And g10.Text("chk", x) = "1" And g10.ToDec("rem_qty", x) > 0 Then
                            g30.AddNewRow()

                            g30.Text("dlv_qty") = g10.Text("dlv_qty", x)
                            g30.Text("dlv_up") = g10.Text("po_up", x)
                            g30.Text("in_fac") = g10.Text("in_fac", x)
                            g30.Text("in_wh") = g10.Text("in_wh", x)
                            'temp_dlv = g10.ToDec("dlv_tot", x) - g10.ToDec("rtn_qty", x) + g10.ToDec("re_qty", x)
                            temp_dlv = g10.ToDec("dlv_tot", x) + g10.ToDec("dlv_qty", x)

                        End If
                    Next
                End If
            End If

            'Else

            '    If Me.Save(g10.WorkSet) Then
            '        Me._Open()
            '    End If

        End If


    End Sub

    Private Sub sms_sand()
        If MessageYesNo("SMS 전송 할까요? 의뢰자 : " + g10.Text("k2") + ", 핸드폰 : " + g10.Text("mob") + "입니다") = MsgBoxResult.No Then
            Exit Sub
        Else
            sms()

        End If
    End Sub
    Private Sub save1()
        p.Add("@po_no", g10.Text("po_no"))
        p.Add("@k2", g10.Text("k2"))
        p.Add("@mob", g10.Text("mob"))
        p.Add("@itm_cd", g10.Text("itm_cd"))
        p.Add("@itm_nm", g10.Text("itm_nm"))
        p.Add("@cust_nm", g10.Text("cust_nm"))
        p.Add("@po_dt", g10.Text("po_dt"))
        p.Add("@dlv_dt2", g10.Text("dlv_dt2"))
        p.Add("@po_up2", g10.Text("po_up2"))
        p.Add("@dlv_qty", g10.Text("dlv_qty"))

        Me.Open("mmb203_save1", p)
    End Sub
    Private Sub sms()
        'Dim param_nm As String
        ' Dim param_mo As String
        Dim param_array1(0 To g10.RowCount) As String
        Dim param_array2(0 To g10.RowCount) As String
        'For i2 As Integer = 0 To g10.RowCount - 1
        '    g10.RowIndex = i2
        '    param_array1(i2) = g10.Text("part_nm")
        '    param_array2(i2) = g10.Text("mobile")
        'Next



        Dim MySQL_CS As String = "Server=192.168.2.19;" & _
            "Database=naonekp;Uid=ekpnaon;Pwd=@skdhs!;"
        Dim SQL As String


        ' For i As Integer = 0 To g10.RowCount - 1

        ''param_nm = param_array1(i)
        ''param_mo = param_array2(i)

        'If g10.Text("CHK") = "0" Then

        SQL = "INSERT INTO uds_msg (MSG_TYPE, CMID, REQUEST_TIME, DEST_PHONE, SEND_PHONE, MSG_BODY ) VALUES ("
        SQL = SQL & " 0, date_format(now() ,  '%Y%m%d%H%i%s'), now(), '" + g10.Text("mob") + "', '0316128519', '" + g10.Text("itm_nm") + " 이 입고 되었습니다~!');"


        Dim db = New MySqlConnection(MySQL_CS)
        db.Open()
        Dim COMM = New MySqlCommand(SQL, db)
        COMM.ExecuteNonQuery()

        db.Close()
        save1()
        'End If
    End Sub
    Private Sub lot_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lot_save.Click

        If Me.Save(g30.WorkSet) Then
            Me._Open()
            lot_chk.Text = ""
        End If

    End Sub




    Private Sub opt_show_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles opt_show.TextChanged
        Me._Open()
    End Sub

    Private Sub lot_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lot_chk.CheckedChanged
        If lot_chk.Text = "1" Then
            SplitContainer3.Panel2Collapsed = False
            lot_save.Enabled = True
            btn_save.Enabled = False
        Else
            SplitContainer3.Panel2Collapsed = True
            lot_save.Enabled = False
            btn_save.Enabled = True
        End If
    End Sub

    Private Sub g30_AddedRow(sender As Object, RowIndex As Integer) Handles g30.AddedRow
        Dim tot_dlv As Integer = 0


        g30.Text("dlv_up", RowIndex) = g30.Text("dlv_up", RowIndex - 1)
        g30.Text("in_fac", RowIndex) = g30.Text("in_fac", RowIndex - 1)
        g30.Text("in_wh", RowIndex) = g30.Text("in_wh", RowIndex - 1)

        If temp_dlv > 0 Then
            For i = 0 To g30.RowIndex - 1
                tot_dlv = tot_dlv + g30.ToDec("dlv_qty", i)

            Next

            If temp_dlv < tot_dlv Then
                MessageInfo("입고량을 초과하였습니다.")
                g30.DeleteSelectedRows()
                Exit Sub
            End If
            If RowIndex > 0 Then
                g30.Text("dlv_qty", RowIndex) = temp_dlv - tot_dlv
            End If
        End If
    End Sub

    Private Sub in_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_fac", i) = in_fac.Text
            'g10.Text("in_wh", i) = in_wh.Text
        Next
    End Sub

    Private Sub in_wh_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_wh.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_wh", i) = in_wh.Text
        Next
    End Sub

    Private Sub dir_bc_TextChanging(sender As Object, e As System.EventArgs) Handles dir_bc.TextChanging
        If dir_bc.Text = "MM060100" Then ' 내자인 경우
            std_dt.Enabled = False
            cury_bc.Enabled = False
            ex_rt.Enabled = False
        Else
            std_dt.Enabled = True
            cury_bc.Enabled = True
            ex_rt.Enabled = True
        End If
    End Sub

    Private Sub cury_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cury_bc.TextChanged
        GetExchRt()

    End Sub

    'g20 항목의 환율적용일이 바뀌면 환율을 자동으로 끌어온다
    '환율 구하는 데이타셋
    Private Sub GetExchRt()

        Dim p As New OpenParameters
        Dim Rt As Decimal

        p.Add("@std_dt", std_dt.Text)
        p.Add("@cury_bc", cury_bc.Text)

        Dim dSet As DataSet = OpenDataSet("mmb_ex_rt", p)

        If Not IsEmpty(dSet) Then
            If cury_bc.Text = "BC400JPY" Then
                Rt = DataValue(dSet, "ttm_rt") / 100 '환율 JPY(100)
            Else
                Rt = DataValue(dSet, "ttm_rt")
            End If
        Else
            Rt = "1"
        End If

        ex_rt.Text = Rt

    End Sub

    Private Sub ex_rt_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles ex_rt.TextChanged

        With g30
            For i As Integer = 0 To .RowCount - 1
                If .IsDataRow(i) Then
                    .RowIndex = i
                    .Text("ex_rt") = ex_rt.ToDec
                    .Text("cury_bc") = cury_bc.Text
                    .Text("in_up") = .ToDec("dlv_up") * .ToDec("ex_rt")

                End If
            Next
        End With

    End Sub


    Private Sub dlv_save_Click(sender As Object, e As System.EventArgs) Handles dlv_save.Click

        If MyBase.Save(g20.WorkSet) Then
            Me._Open()
        End If

    End Sub

    Private Sub po_chk_CheckedChanged(sender As Object, e As System.EventArgs) Handles po_chk.CheckedChanged
        MyBase.Open()
    End Sub

End Class
