Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WI_PR1131
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '    'Me.Open()
                '    'Open_Form()
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
        'Clear()

        If g_body.RowCount <= 0 Then g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        Me.BIAmt()

        If g_body.RowCount <= 0 Then
            MsgBox("공정을 확인하세요.!")
            Return False
        End If

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '전표채번..

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
            End If

            stts.Text = "S"
        End If

        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@job_no", job_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1131_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Function Check_deconfirm() As String
        p.Clear()
        p.Add("@job_no", job_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1131_deconfirm", p)
        Dim stts As String = "N"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        job_no.CodeNo = "WI_PR1110"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        job_no.CodeDateField = job_dt

    End Sub

    Private Function Del() As Boolean

        If job_no.Text = Nothing Then
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
            p.Add("@job_no", job_no.Text)

            Me.Open("WI_PR1131_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If job_no.Text = Nothing Then
            Max_NO()  '전표채번..

        End If

        Me.BIAmt()

        If g_body.RowCount <= 0 Then
            MsgBox("공정을 확인하세요.!")
            Return False
        End If

        If MyBase.Save() Then
            'MyBase.OpenTrigger("wi_sa1120_list")
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("WI_PR1131_confirm")

            p.Clear()
            p.Add("@job_no", job_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1131_confirm", p)

            stts.Text = "C"
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If job_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "C" Then
            MsgBox("확인된 자료가 아닙니다.!")
            Return False
        End If

        If Check_deconfirm() = "Y" Then
            MsgBox("생산실적이 등록된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@job_no", job_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1131_confirm", p)

            stts.Text = "S"
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
        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        p.Clear()
        p.Add("@job_no", "XXX")

        Me.Open("WI_PR1131_head", p)
        Me.Open("WI_PR1131_body", p)

        If g_body.RowCount <= 0 Then g_body.AddNewRow()

        hot_cd.Focus()

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
        p.Add("@find_gd_nm", "XXX")
        p.Add("@find_stts", find_stts.Text)

        Me.Open("WI_PR1131_list", p)
    End Sub

    Private Sub BIAmt()
        Dim sum_amt As Double

        With g_body
            .UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("BI_AMT", i)
            Next
        End With

        'bi_amt.Text = sum_amt
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        g_list.Open()
    End Sub

    'Private Sub rate_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles Rate.TextChanged
    '    won_amt.Text = bal_amt.ToDec * Rate.ToDec
    'End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        p.Clear()
        p.Add("@job_no", g_list.Text("job_no", g_list.RowIndex))

        Me.Open("WI_PR1131_head", p)
        Me.Open("WI_PR1131_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.find_Clear()

    End Sub



    Private Sub g_list_DoubleClick1(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@job_no", g_list.Text("JOB_NO", g_list.RowIndex))

        Me.Open("WI_PR1131_head", p)
        Me.Open("WI_PR1131_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click1(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        find_Clear()

    End Sub

    Private Sub btn_find_Click1(sender As Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub popUP(s As String)
        p.Clear()
        p.Add("@hot_cd", s)

        If s = "" Then Exit Sub

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1131_hot_cd", p)
        Dim nm_cd As String = "", nm_nm As String = ""
        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            hot_cd.Text = ""
            gd_cd.Text = ""
            gd_nm.Text = ""
            spec.Text = ""

            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            nm_cd = ToStr(dRow("nm_cd"))
            nm_nm = ToStr(dRow("nm_nm"))
        Next

        '----------------------------------------------------------------------------
        Dim popup As New WH_CO1201_F
        'Dim p As String()

        'If g_body.ColumnIndex <> 1 Then Exit Sub

        popup.InitPopup(nm_cd, nm_nm, "")

        If popup.ShowDialog() = DialogResult.OK Then

            If popup.ActiveControl.Tag IsNot Nothing Then
                Dim pReturn As eGrid = popup.ActiveControl.Tag
                Dim ll_row As Integer
                ll_row = pReturn.RowIndex

                gd_cd.Text = pReturn.Text("GD_CD", ll_row)
                'g_body.Text("GD_NM") = pReturn.Text("GD_NM", ll_row)
                'g_body.Text("SPEC") = pReturn.Text("SPEC", ll_row)
                'g_body.Text("UNIT_CD") = pReturn.Text("UNIT_CD", ll_row)

                '''멀티 선택시 ..
                'For i = 0 To pReturn.RowCount - 1
                '    'If pReturn.Text("CHK", i) = "1" Then
                '    'g_body.AddNewRow()

                '    g_body.Text("GD_CD") = pReturn.Text("GD_CD", i)
                '    g_body.Text("GD_NM") = pReturn.Text("GD_NM", i)
                '    g_body.Text("SPEC") = pReturn.Text("SPEC", i)
                '    g_body.Text("UNIT_CD") = pReturn.Text("UNIT_CD", i)

                '    ll_row = ll_row + 1

                '    g_body.InsertNewRow(ll_row)
                '    'End If
                'Next

                'g_body.DeleteRow(ll_row)


            Else
                ' 결과 파라미터가 없는경우
            End If

        Else
        End If
    End Sub

    Private Sub hot_cd_TextChanged(sender As Object, oldValue As String) Handles hot_cd.TextChanged
        Try
            Me.popUP(hot_cd.Text)
        Catch ex As Exception

        End Try

        job_qty.Focus()

    End Sub

End Class
