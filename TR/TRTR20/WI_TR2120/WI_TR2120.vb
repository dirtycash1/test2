Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_TR2120

    Dim stts As String
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Clear()

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
        p.Add("@ilc_no", "XXX")

        Me.Open("wi_tr2120_head", p)
        Me.Open("wi_tr2120_body", p)

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
        p.Add("@ilc_no", ilc_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr2120_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' od_no 번호 채번
        ilc_no.CodeNo = "WI_TR2120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ilc_no.CodeDateField = sl_dt
    End Sub

    Private Sub lc_Amt()
        Dim sum_amt As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("LC_AMT", i)
            Next
        End With

        lc_amt1.Text = sum_amt

    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        '수주번호가 없는것을 줄삭제 한다.
        With g_body

            For i As Integer = 0 To .RowCount - 1
                If .Text("OD_NO", i) = Nothing Then
                    .DeleteRow(i)
                End If
            Next

        End With

        If g_body.RowCount <= 0 Then

            MsgBox("L/C 할 품목이 없습니다!")
            Return False

        End If

        '금액합계 HEAD 에 넣는다.
        lc_Amt()

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

        If ilc_no.Text = Nothing Then
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
            p.Add("@ilc_no", ilc_no.Text)
            p.Add("@stts", "C")

            Me.Open("wi_tr2120_confirm", p)
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If ilc_no.Text = Nothing Then
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
            p.Add("@ilc_no", ilc_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr2120_confirm", p)
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        If ilc_no.Text = Nothing Then
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
            p.Add("@ilc_no", ilc_no.Text)

            Me.Open("wi_tr2120_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        '거래처 변경시 g_body 전체 줄삭제
        g_body.DeleteAll()

    End Sub

    Private Sub cur_cd_TextChanged(sender As System.Object, e As System.EventArgs) Handles cur_cd.TextChanged
        '화폐 변경시 g_body 전체 줄삭제
        g_body.DeleteAll()
    End Sub



    '''''''''''''''''''''''''''''''''''''''''''''
    '수주번호 입력시 거래처와 화폐 입력을 체크한다.
    '''''''''''''''''''''''''''''''''''''''''''''
    Private Function od_no_SelectChk() As Boolean
        '수주번호 선택시 거래처와 화폐를 입력되어있어야 한다.
        If cs_cd.Text = Nothing Then
            MsgBox("거래처를 입력하세요.!")
            Return False
        End If
        If cur_cd.Text = Nothing Then
            MsgBox("회폐를 입력하세요.!")
            Return False
        End If
    End Function

    Private Sub g_body_AddedRow(sender As Object, RowIndex As Integer) Handles g_body.AddedRow
        od_no_SelectChk()
    End Sub

    Private Sub g_body_Click(sender As System.Object, e As System.EventArgs) Handles g_body.Click
        od_no_SelectChk()
    End Sub

    Private Sub g_body_InsertedRow(sender As Object, RowIndex As Integer) Handles g_body.InsertedRow
        od_no_SelectChk()
    End Sub

    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_cur_cd.Text = "%"
        find_stts.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_cur_cd", find_cur_cd.Text)
        p.Add("@find_stts", find_stts.Text)

        Me.Open("wi_tr2120_list", p)

    End Sub
    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub

    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick


        p.Add("@ilc_no", g_list.Text("ILC_NO", g_list.RowIndex))
        Me.Open("wi_tr2120_head", p)
        Me.Open("wi_tr2120_body", p)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub


End Class
