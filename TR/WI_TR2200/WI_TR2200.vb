Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR2200
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        'g_list.SelectRow = True

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
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

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@ot_no", "XXX")
        'p.Add("@ot_gu", "XXX")

        Me.Open("wi_tr2200_head", p)

        p.Add("@ot_no", "XXX")
        Me.Open("wi_tr2200_body", p)
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Sub find_Clear()
        find_cs_nm.Text = ""
        find_cur_cd.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_cur_cd", find_cur_cd.Text)

        Me.Open("wi_tr2200_list", p)
    End Sub

    Private Sub find_Clear2()
        find_cs_nm2.Text = ""

        p.Clear()
        p.Add("@find_from2", find_from2.Text)
        p.Add("@find_to2", find_to2.Text)
        p.Add("@find_cs_nm2", "XXX")

        Me.Open("wi_tr2200_rq_ot", p)
    End Sub

    Private Function Check_acgu() As String
        p.Clear()
        p.Add("@ot_no", ot_no.Text)
        p.Add("@ot_gu", ot_gu.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr220_ac_gu", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts
    End Function

    Private Function Saves() As Boolean

        If Check_acgu() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 전표입니다.")
            Return False
        End If

        If Wf_Check() <> 0 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                ac_gu.Text = "S"
            Else
                Return False
            End If

            g_list.Open()
            g_list2.Open()
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If Check_acgu() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 전표입니다.")
            Return False
        End If

        If Wf_Check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()

            p.Add("@ot_no", ot_no.Text)
            p.Add("@ot_gu", ot_gu.Text)
            p.Add("@ac_gu", "C")
            p.Add("@sebal_gu", "Y")

            '전표발생후 넣는다
            p.Add("@slno", "")
            p.Add("@sebal_no", "")

            p.Add("@singo_no", singo_no.Text)
            p.Add("@singo_nm", singo_nm.Text)
            p.Add("@hs_no", hs_no.Text)
            p.Add("@singo_dt", singo_dt.Text)
            p.Add("@kwase_amtw", kwase_amtw.Text)
            ' p.Add("@kwase_amts", kwase_amts.Text)
            ' p.Add("@usd_rate", usd_rate.Text)
            ' p.Add("@han_amt", han_amt.Text)
            p.Add("@rate", rate.Text)
            p.Add("@bl_dt", bl_dt.Text)
            p.Add("@ODGU_CD", odgu_cd.Text)
            p.Add("@FILE_NM", file_nm.Text)

            Me.Open("wi_tr2200_confirm", p)

            ac_gu.Text = "C"

            Me.Clear()
            g_list.Open()
            g_list2.Open()
        End If

        Return True

    End Function

    Private Function DeConFrim() As Boolean

        '상태값 CHECK
        If Check_acgu() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If Wf_De_Check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()

            p.Add("@ot_no", ot_no.Text)
            p.Add("@ot_gu", ot_gu.Text)
            p.Add("@ac_gu", "S")
            p.Add("@sebal_gu", "N")
            p.Add("@tax_no", tax_no.Text)

            Me.Open("wi_tr2200_deconfirm", p)

            p.Clear()

            p.Add("@ot_no", g_list.Text("OT_NO", g_list.RowIndex))
            Me.Open("wi_tr2200_head", p)

            p.Add("@ot_no", g_list.Text("OT_NO", g_list.RowIndex))
            Me.Open("wi_tr2200_body", p)

            tax_no.Text = ""

            g_list.Open()
            g_list2.Open()
        End If

        Return True

    End Function

    Private Function Del() As Boolean
        '삭제는 필요 없을 듯
    End Function

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub btn_find2_Click(sender As System.Object, e As System.EventArgs) Handles btn_find2.Click
        g_list2.Open()
    End Sub

    Private Sub btn_cancel2_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel2.Click
        find_Clear2()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()

        p.Add("@ot_no", g_list.Text("OT_NO", g_list.RowIndex))
        Me.Open("wi_tr2200_head", p)

        p.Add("@ot_no", g_list.Text("OT_NO", g_list.RowIndex))
        Me.Open("wi_tr2200_body", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub g_list2_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list2.DoubleClick
        'find_list2()
        p.Clear()

        p.Add("@ot_no", g_list2.Text("OT_NO", g_list2.RowIndex))
        Me.Open("wi_tr2200_head", p)

        p.Add("@ot_no", g_list2.Text("OT_NO", g_list2.RowIndex))
        Me.Open("wi_tr2200_body", p)

        If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub find_list2()
        Me.Clear()

        p.Clear()
        p.Add("@ot_no", g_list2.Text("OT_NO", g_list2.RowIndex))
        p.Add("@ot_gu", g_list2.Text("OT_GU", g_list2.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2200_set_head", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                ot_no.Text = ToStr(dRow("ot_no"))
                ot_gu.Text = ToStr(dRow("ot_gu"))
                cs_cd.Text = ToStr(dRow("cs_cd"))
                cs_nm.Text = ToStr(dRow("cs_nm"))
                cur_cd.Text = ToStr(dRow("cur_cd"))
                rate.Text = ToDec(dRow("rate"))
                ac_gu.Text = ToStr(dRow("ac_gu"))
                ot_amt.Text = ToDec(dRow("ot_amt"))
                invoice_dt.Text = ToDateStr(dRow("invoice_dt"))
                odgu_cd.Text = ToStr(dRow("odgu_cd"))
            Next
        End If

        Me.ot_list()
    End Sub

    'Private Sub ot_no_TextChanged(sender As Object, oldValue As String) Handles ot_no.TextChanged
    '    If ac_gu.Text = "S" Then
    '        Me.ot_list()
    '    End If
    'End Sub

    Private Sub ot_list()
        p.Clear()
        p.Add("@ot_no", g_list2.Text("OT_NO", g_list2.RowIndex))
        p.Add("@ot_gu", g_list2.Text("OT_GU", g_list2.RowIndex))

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2200_set_body", p)
        If Not IsEmpty(dSet) Then
            With g_body
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("GD_CD", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("OT_NO", iRow) = ToStr(dRow("OT_NO"))
                    .Text("OT_GU", iRow) = ToStr(dRow("OT_GU"))
                    .Text("SEQ", iRow) = ToDec(dRow("SEQ"))
                    .Text("OD_NO", iRow) = ToStr(dRow("OD_NO"))
                    .Text("OD_SEQ", iRow) = ToDec(dRow("OD_SEQ"))
                    .Text("GD_CD", iRow) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", iRow) = ToStr(dRow("GD_NM"))
                    .Text("SPEC", iRow) = ToStr(dRow("SPEC"))
                    .Text("UNIT_CD", iRow) = ToStr(dRow("UNIT_CD"))
                    .Text("OT_QTY", iRow) = ToDec(dRow("OT_QTY"))
                    .Text("OT_PRI", iRow) = ToDec(dRow("OT_PRI"))
                    .Text("OT_AMT", iRow) = ToDec(dRow("OT_AMT"))

                    iRow += 1
                Next
            End With
        End If
    End Sub

    Private Sub rate_TextChanged(sender As System.Object, oldValue As System.String) Handles rate.TextChanged
        '환율 변경시 body won_amt 금액 변경
        Dim ld_kwaseamtw As Decimal

        ld_kwaseamtw = 0
        With g_body
            For i As Integer = 0 To .RowCount - 1
                .Text("WON_AMT", i) = Math.Ceiling(ToDec(rate.Text) * .ToDec("OT_AMT", i))
                ld_kwaseamtw += Math.Ceiling(ToDec(rate.Text) * .ToDec("OT_AMT", i))
            Next
        End With

        kwase_amtw.Text = ld_kwaseamtw

    End Sub

    Private Sub g_body_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged

        Dim sum_amt As Double

        If ColumnName = "WON_AMT" Then

            With g_body
                '.UpdateRow()
                For i As Integer = 0 To .RowCount - 1
                    sum_amt = sum_amt + .ToDec("WON_AMT", i)
                Next
            End With

            kwase_amtw.Text = sum_amt
        End If
    End Sub

    Private Sub Setitem_Rate()
        p.Clear()
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@BL_DT", bl_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2200_set_rate", p)
        Dim ld_rate As Decimal

        If Not IsEmpty(dSet) Then
            ld_rate = DataValue(dSet)
        Else
            ld_rate = 1
        End If

        rate.Text = ld_rate
    End Sub

    Private Sub bl_dt_TextChanged(sender As Object, e As System.EventArgs) Handles bl_dt.TextChanged
        Me.Setitem_Rate()
    End Sub

    Private Function Wf_Check() As Integer
        Dim ls_singono, ls_odgucd, ls_filenm As String
        Dim ld_singodt, ld_bldt, ls_rate As String
        Dim ld_kwaseamts, ld_usdrate, ld_hanamt As String

        ls_singono = singo_no.Text
        ld_singodt = singo_dt.Text
        ld_bldt = bl_dt.Text
        ' ld_kwaseamts = kwase_amts.Text
        'ld_usdrate = usd_rate.Text
        ' ld_hanamt = han_amt.Text
        ls_odgucd = odgu_cd.Text
        ls_filenm = file_nm.Text
        ls_rate = rate.Text

        If ls_odgucd = "03" Then
            If ls_singono = Nothing Then
                MsgBox("[신고번호] 항목은 필수 입력필드 입니다")
                Return 1
            End If
        ElseIf ls_odgucd = "04" Then
            If ls_filenm = Nothing Then
                MsgBox("[서류명] 항목은 필수 입력필드 입니다")
                Return 1
            End If
        ElseIf ls_odgucd = "02" Then
            If ls_singono = Nothing Then
                MsgBox("[신고번호] 항목은 필수 입력필드 입니다")
                Return 1
            End If
        End If

        If ld_singodt = Nothing Then
            MsgBox("[신고일] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        If ld_bldt = Nothing Then
            MsgBox("[선적일] 항목은 필수 입력필드 입니다")
            Return 1
        End If

        ' If ld_kwaseamts = Nothing Then
        ' MsgBox("[달러금액] 항목은 필수 입력필드 입니다")
        ' Return 1
        ' End If

        'If ld_usdrate = Nothing Then
        ' MsgBox("[달러환율] 항목은 필수 입력필드 입니다")
        ' Return 1
        ' End If

        'If ld_hanamt = Nothing Then
        'MsgBox("[원화금액] 항목은 필수 입력필드 입니다")
        ' Return 1
        'End If

        If ls_rate = 1 Then
            MsgBox("해당 선적일의 환율을 확인하세요")
            Return 1
        End If

        Return 0
    End Function

    Private Function Wf_De_Check() As Integer
        p.Clear()
        p.Add("@ot_no", ot_no.Text)

        Me.Open("wi_tr2200_de_chk", p)

        Dim dSet As DataSet = Me.WorkSet("wi_tr2200_de_chk").DataSet
        Dim ls_chk As String = "Y"
        Dim ls_docno As String = ""
        Dim ls_taxno As String = ""

        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                Try
                    ls_chk = ToStr(dRow("CHK"))
                    ls_docno = ToStr(dRow("DOC_NO"))
                    ls_taxno = ToStr(dRow("TAX_NO"))
                Catch ex As Exception
                    MessageError(ex, , "Display()")
                End Try

                iRow += 1
            Next
        End If

        If ls_chk = "N" Then
            MsgBox("해당 Invoice No. 로 생성된 회계전표가 있습니다.")
            Return 1
        Else
            tax_no.Text = ls_taxno
        End If

        Return 0
    End Function
End Class
