Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_TR1120

    Public chk As Boolean
    Public il_seq, il_buseq, il_preseq, il_prebuseq As Integer
    Dim stts As String
    Dim p As New OpenParameters


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Clear()

        chk = True
        g_list.SelectRow = True
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
        p.Add("@od_no", "XXX")

        Me.Open("wi_tr1120_head", p)
        Me.Open("wi_tr1120_body02", p)
        Me.Open("wi_tr1120_body", p)
        Me.Open("wi_tr1120_body_01_temp", p)

    End Sub

    Private Sub New_Form()
        Me.Open()
        od_no.Text = ""
        Me.OpenTrigger("wi_tr1120_list")
        g_body.AddNewRow()
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False

        End If
    End Sub


    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@od_no", od_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1120_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' od_no 번호 채번
        od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then

            End If
        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("wi_ku1120_confirm")

            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr1120_confirm", p)
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr1120_confirm", p)
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        If od_no.Text = Nothing Then
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
            p.Add("@od_no", od_no.Text)

            Me.Open("wi_tr1120_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function


    '제품의 금액 변경시 HEAD 의 수주금액을 변경한다.
    Private Sub g_body_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        With g_body

            If ColumnName = "OD_AMT" Then
                Me.SumAmt()
            End If

        End With

    End Sub
    '제품 등록된 금액을 합해서 HEAD 수주금액에 넣는다.
    Private Sub SumAmt()
        Dim sum_amt As Double

        With g_body

            '.UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("OD_AMT", i)
                'sum_vat = sum_vat + .ToDec("so_vat", i)
            Next
        End With

        od_amt.Text = sum_amt

    End Sub



    '제품의 줄이 변경시 
    Private Sub g_body_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g_body.AfterMoveRow


        Dim g_body_seq As Integer
        Dim ls_gdcd As String
        Dim p1 As New OpenParameters
        chk = False


        g_body_seq = g_body.ToDec("SEQ", g_body.RowIndex)

        'g_body_01 reset을 시킨다.
        p1.Add("@od_no", od_no.Text)
        p1.Add("@seq", 99999)
        Me.Open("wi_tr1120_body_01", p1)


        For i As Integer = 0 To g_body_01_temp.RowCount - 1
            ls_gdcd = g_body_01_temp.Text("GD_CD", i)

            If ls_gdcd = "" Then

                g_body_01_temp.DeleteRow(i)

            End If
        Next


        '전체 포장리스트를 dataset에 넣는다.
        Dim dSet As DataSet = Me.WorkSet("wi_tr1120_body_01_temp").DataSet

        If Not IsEmpty(dSet) Then
            With g_body_01
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                For Each dRow In dRows



                    Try
                        If g_body_seq = dRow("seq") Then
                            '줄추가
                            .AddNewRow()
                            '줄추가 줄
                            .RowIndex = iRow

                            .Text("OD_NO", iRow) = ToStr(dRow("od_no"))
                            .Text("SEQ", iRow) = ToDec(dRow("seq"))
                            .Text("BU_SESQ", iRow) = ToDec(dRow("bu_seq"))
                            .Text("GD_CD", iRow) = ToStr(dRow("gd_cd"))
                            .Text("GD_NM", iRow) = ToStr(dRow("gd_nm"))
                            .Text("SPEC", iRow) = ToStr(dRow("spec"))
                            .Text("QTY", iRow) = ToStr(dRow("qty"))
                        End If
                    Catch ex As Exception
                        MessageError(ex, , "Display()")
                    End Try



                    iRow += 1
                Next

            End With
        End If

        chk = True
    End Sub

    '수주찾기 리스트에서 더블 클릭시
    Private Sub g_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g_list.DoubleClick
        '더블클릭시 head, body를 조회한다.

        Dim p2 As New OpenParameters

        chk = False

        p2.Add("@od_no", g_list.Text("OD_NO", g_list.RowIndex))
        Me.Open("wi_tr1120_head", p2)
        Me.Open("wi_tr1120_body02", p2)
        Me.Open("wi_tr1120_body", p2)
        Me.Open("wi_tr1120_body_01_temp", p2)

        'g_body 의 첫줄을 g_body_01를 검색하다.
        g_body_AfterMoveRow(sender, 1, 1)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)


  

        chk = True
    End Sub


    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_od_no.Text = ""
        find_stts.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_od_no", find_od_no.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_tr1120_list", p)




    End Sub
    '수주 찾기 조회
    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        '찾기 리스트를 조회 한다.

        g_list.Open()

    End Sub
    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub


    Private Sub g_body_01_Change(RowIndex As System.Int32)

        Dim ls_gdcd, ls_gdnm, ls_spec As String
        Dim ll_seq, ll_buseq As Integer
        Dim ld_qty As Decimal


        If RowIndex >= 0 And chk = True Then

            ll_seq = g_body_01.ToDec("SEQ", RowIndex)
            ll_buseq = g_body_01.ToDec("BU_SEQ", RowIndex)
            ls_gdcd = g_body_01.Text("GD_CD", RowIndex)
            ls_gdnm = g_body_01.Text("GD_NM", RowIndex)
            ls_spec = g_body_01.Text("SPEC", RowIndex)
            ld_qty = g_body_01.ToDec("QTY", RowIndex)

            With g_body_01_temp

                For i As Integer = 0 To .RowCount - 1
                    If .Text("BU_SEQ", i) <> "" Then


                        If ll_seq = .Text("SEQ", i) And ll_buseq = .Text("BU_SEQ", i) Then


                            .Text("GD_CD", i) = ls_gdcd
                            .Text("GD_NM", i) = ls_gdnm
                            .Text("SPEC", i) = ls_spec
                            .Text("QTY", i) = ld_qty

                        End If

                    End If

                Next
            End With
        End If
    End Sub


    Private Sub g_body_01_BeforeMoveRow(sender As System.Object, RowIndex As System.Int32, ByRef AllowMove As System.Boolean) Handles g_body_01.BeforeMoveRow
        '데이타(이동)
        'chk = True
        If RowIndex < 0 Then
            Return
        End If


        g_body_01_Change(RowIndex)
    End Sub

    Private Sub g_body_01_Leave(sender As System.Object, e As System.EventArgs) Handles g_body_01.Leave
        '데이타(이동)
        'chk = True

        'g_body_01_Change(g_body_01.RowIndex)
        '이벤트 발생시 변경된 값에 대해 변경값을 가지고 오는게 아니라 이전값을 가져온다.
        'g_body_01_BeforeMoveRow(sender, g_body_01.RowIndex, True)
    End Sub

    Private Sub g_body_01_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles g_body_01.KeyDown
        chk = True
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '포장재 줄추가, 삭제 처리 
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub g_body_01_temp_rowInsert(a_seq As Integer, a_buseq As Integer)
        Dim ll_rowcount As Integer 'g_body_01_temp 의 줄수
        'g_body_01_temp 줄추가를 해준다.
        g_body_01_temp.AddNewRow()
        ll_rowcount = g_body_01_temp.RowCount

        g_body_01.Text("SEQ", ll_rowcount) = a_seq
        g_body_01_temp.Text("SEQ", ll_rowcount) = a_seq
        g_body_01_temp.Text("BU_SEQ", ll_rowcount) = a_buseq
    End Sub

    Private Sub g_body_01_InsertedRow(sender As System.Object, RowIndex As System.Int32) Handles g_body_01.InsertedRow
        Dim ll_seq, ll_buseq As Integer

        '품목코드의 seq 번호를 가져온다.
        ll_seq = g_body.ToDec("SEQ", g_body.RowIndex)
        '포장의 bu_seq를 가져온다.
        ll_buseq = g_body_01.ToDec("BU_SEQ", RowIndex)

        'g_body_01_temp grid에 seq, bu_seq를 넣어준다.
        g_body_01_temp_rowInsert(ll_seq, ll_buseq)



  
    End Sub


    Private Sub g_body_01_AddedRow(sender As System.Object, RowIndex As System.Int32) Handles g_body_01.AddedRow
        Dim ll_seq, ll_buseq As Integer

        '찾기시 g_body_01_temp 에서 데이타 를 가져올때 처리되므로 return 한다.
        If chk = False Then
            Return
        End If

        '품목코드의 seq 번호를 가져온다.
        ll_seq = g_body.ToDec("SEQ", g_body.RowIndex)
        '포장의 bu_seq를 가져온다.
        ll_buseq = g_body_01.ToDec("BU_SEQ", RowIndex)

        g_body_01_temp_rowInsert(ll_seq, ll_buseq)
    End Sub






    Private Sub g_body_01_DeletedRow(sender As System.Object, RowIndex As System.Int32) Handles g_body_01.DeletedRow
        With g_body_01_temp

            Dim ll_cnt As Integer
            Dim ll_seq = g_body.ToDec("SEQ", g_body.RowIndex)
            'Dim ll_buseq As Integer

            For i As Integer = 0 To .RowCount - 1
                'If .Text("BU_SEQ", i) <> "" Then
                ll_cnt = 0

                If ll_seq = .ToDec("SEQ", i) Then
                    For j As Integer = 0 To g_body_01.RowCount - 1
                        If g_body_01.ToDec("BU_SEQ", j) = .ToDec("BU_SEQ", i) Then
                            ll_cnt = ll_cnt + 1
                        End If
                    Next

                    If ll_cnt = 0 Then
                        .DeleteRow(i)
                    End If
                End If
                


            Next
        End With
    End Sub




    Private Sub g_body_01_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g_body_01.AfterMoveRow
        If g_body_01.RowIndex < 0 Then
            Return
        End If

        If g_body_01.Text("SEQ", g_body_01.RowIndex) = "" Then
            Return
        End If
        If g_body_01.Text("BU_SEQ", g_body_01.RowIndex) = "" Then
            Return
        End If

    End Sub



    Private Sub g_body_DeletedRow(sender As System.Object, RowIndex As System.Int32) Handles g_body.DeletedRow

        Dim ll_seq, ll_cnt As Integer


        With g_body_01_temp

            For i As Integer = 0 To .RowCount - 1

                ll_seq = .ToDec("SEQ", i)
                ll_cnt = 0

                For j As Integer = 0 To g_body.RowCount - 1
                    If ll_seq = g_body.ToDec("SEQ", j) Then
                        ll_cnt = ll_cnt + 1
                    End If
                Next

                If ll_cnt <= 0 Then
                    .DeleteRow(i)
                End If

            Next

        End With

    End Sub



    Private Sub g_body_01_temp_LostFocus(sender As Object, e As System.EventArgs) Handles g_body_01_temp.LostFocus
        g_body_01_Change(g_body_01.RowIndex)
    End Sub

    Private Sub g_body_01_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g_body_01.CellValueChanged
        If chk = True And (ColumnName = "GD_CD" Or ColumnName = "QTY") Then

            g_body_01_Change(RowIndex)

        End If
    End Sub



End Class

