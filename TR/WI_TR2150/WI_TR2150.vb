Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR2150
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

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

            Case MenuType.New

                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        g_body.AddNewRow()
    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@bi_no", "XXX")

        Me.Open("wi_tr2150_head", p)
        Me.Open("wi_tr2150_body", p)

        'Wf_Set_Bicd()
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.delete_row()

        If wf_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                stts.Text = "S"

                g_list.Open()
            End If
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean
        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.delete_row()

        If wf_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@bi_no", bi_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr2150_confirm", p)

            p.Clear()
            p.Add("@bi_no", bi_no.Text)
            p.Add("@bi_dt", bi_dt.Text)
            p.Add("@ps_cd", ps_cd.Text)

            Me.Open("wi_tr2150_insert_actr1000", p)

            p.Clear()
            p.Add("@bi_no", bi_no.Text)

            Me.Open("wi_tr2150_head", p)
            Me.Open("wi_tr2150_body", p)

            g_list.Open()
        End If

        Return True

    End Function

    Private Function DeConFrim() As Boolean
        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인처리된 전표만 확인취소가 가능합니다.")
            Return False
        End If

        Me.wf_check()

        If wf_de_check() <> 0 Then
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            p.Clear()
            p.Add("@bi_no", bi_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr2150_deconfirm", p)

            p.Clear()
            p.Add("@bi_no", bi_no.Text)

            Me.Open("wi_tr2150_head", p)
            Me.Open("wi_tr2150_body", p)

            g_list.Open()
        End If

        Return True
    End Function

    Private Function Del() As Boolean
        If bi_no.Text = Nothing Then
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
            p.Add("@bi_no", bi_no.Text)
            p.Add("@stts", "D")

            Me.Open("wi_tr2150_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@bi_no", bi_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2150_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' od_no 번호 채번
        bi_no.CodeNo = "WI_TR2150"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        bi_no.CodeDateField = bi_dt
    End Sub

    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_stts.Text = "%"

        'p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_tr2150_list", p)

    End Sub

    Private Sub wf_amt(gu As Integer, row As Integer)
        Dim ls_vgu, ls_include_yn As String
        Dim ld_amt, ld_amt1 As Decimal

        If gu = 1 Then
            ls_vgu = g_body.Text("VAT_GU", row)
            If ls_vgu = "Y" Then
                g_body.Text("BI_AMT1", row) = Math.Truncate(g_body.ToDec("BI_AMT", row) / 10)
            End If
        End If
        ld_amt = 0
        For i As Integer = 0 To g_body.RowCount - 1
            ls_include_yn = g_body.Text("INCLUDE_YN")

            If ls_include_yn <> "N" Then
                ld_amt += g_body.ToDec("BI_AMT", i)
            End If

            ld_amt1 += g_body.ToDec("BI_AMT1", i)
        Next

        bi_amt.Text = ld_amt
        bi_amt1.Text = ld_amt1
        bi_hap.Text = ld_amt + ld_amt1
    End Sub

    Private Function wf_check() As Integer

        Dim ls_bicd, ls_include_yn As String
        Dim ld_biamt, ld_biamt1, ld_sum1, ld_misuamt, ld_daecheamt, ld_sum As Decimal

        ld_sum1 = 0

        ld_misuamt = ToDec(misu_amt.Text)
        ld_daecheamt = ToDec(daeche_amt.Text)

        ld_sum = ld_misuamt + ld_daecheamt

        For i As Integer = 0 To g_body.RowCount - 1

            ls_bicd = g_body.Text("BI_CD", i)
            ld_biamt = g_body.ToDec("BI_AMT", i)
            ld_biamt1 = g_body.ToDec("BI_AMT1", i)
            ls_include_yn = g_body.Text("INCLUDE_YN")

            If ls_include_yn = "N" Then
                ld_biamt = 0
            End If

            ld_sum1 += ld_biamt + ld_biamt1

        Next

        misu_amt.Text = ld_sum1

        'If ld_sum <> ld_sum1 Then
        '    MsgBox("(선급금대체 + 미지급금) 과 (금액 + 세액) 이 같아야합니다.)")
        '    Return 1
        'End If

        If g_body.RowCount <= 0 Then
            MsgBox("등록할 내역이 없습니다.")
            Return 1
        End If

        Me.wf_amt(0, 0)

    End Function

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_body_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body.CellValueChanged

        If ColumnName = "BI_AMT" Then

            Me.wf_amt(1, RowIndex)

        ElseIf ColumnName = "BI_AMT1" Then

            Me.wf_amt(0, RowIndex)
        End If

    End Sub

    Private Sub g_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g_list.DoubleClick

        Dim p As New OpenParameters

        p.Add("@bi_no", g_list.Text("BI_NO", g_list.RowIndex))
        Me.Open("wi_tr2150_head", p)
        Me.Open("wi_tr2150_body", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

    End Sub

    Private Sub Wf_Set_Bicd()

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2150_set_bicd", p)

        If Not IsEmpty(dSet) Then
            With g_body
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("BI_CD", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("BI_CD", iRow) = ToStr(dRow("BI_CD"))
                    .Text("BI_NM", iRow) = ToStr(dRow("BI_NM"))
                    .Text("VAT_GU", iRow) = ToStr(dRow("VAT_GU"))
                    .Text("INCLUDE_YN", iRow) = ToStr(dRow("INCLUDE_YN"))

                    iRow += 1
                Next
            End With
        End If
    End Sub

    Private Sub delete_row()
        Dim ld_biamt, ld_biamt1 As Decimal

        g_body.RowIndex = 0

        For i As Integer = 0 To g_body.RowCount + 1
            ld_biamt = g_body.ToDec("BI_AMT", i)
            ld_biamt1 = g_body.ToDec("BI_AMT1", i)

            If (ld_biamt + ld_biamt1) = 0 Then
                g_body.DeleteRow(i)
            End If
        Next
    End Sub

    Private Function wf_de_check() As Integer
        p.Clear()
        p.Add("@bi_no", bi_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2150_de_chk", p)
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
