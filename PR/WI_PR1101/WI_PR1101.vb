Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1101
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

        g_body.AddNewRow()
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        '20160202 smk 중지코드 여부 확인
        p.Clear()
        p.Add("@gd_cd", gd_cd.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_pr1122_stop_yn", p)
        If Not IsEmpty(dSet) Then
            Dim iRow As Integer = 0
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                If ToStr(dRow("stop_yn")) = "1" Then '중지코드 일때
                    MsgBox("해당 품목은 중지코드 입니다. 생산지시를 내릴수 없습니다.")

                Else '중지코드가 아닐때 <그냥저장>

                    If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
                        Exit Function
                    Else

                        Max_NO()  '전표채번..

                        If MyBase.Save() Then
                            If g_body.RowCount <= 0 Then
                                p.Clear()
                                p.Add("@plan_no", plan_no.Text)

                                Me.Open("WI_PR1101_body", p)
                            End If
                            'MyBase.OpenTrigger("wi_sa1120_list")
                        End If

                        stts.Text = "S"
                    End If

                End If
            Next
        End If


        '    '160204smk막음 (위로올림)
        'If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
        '    Exit Function
        'Else

        '    Max_NO()  '전표채번..

        '    If MyBase.Save() Then
        '        If g_body.RowCount <= 0 Then
        '            p.Clear()
        '            p.Add("@plan_no", plan_no.Text)

        '            Me.Open("WI_PR1101_body", p)
        '        End If
        '        'MyBase.OpenTrigger("wi_sa1120_list")
        '    End If

        '    stts.Text = "S"
        'End If





            '거래처 체크
            If Not Me.Check_CsCd() Then
                Return False
            End If

            Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@plan_no", plan_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1101_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' p/o 번호 채번
        plan_no.CodeNo = "WI_PR1100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        plan_no.CodeDateField = plan_dt

    End Sub

    Private Function Del() As Boolean

        If plan_no.Text = Nothing Then
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
            p.Add("@plan_no", plan_no.Text)

            Me.Open("WI_PR1101_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If plan_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("확인된 자료입니다.!")
            Return False
        End If

        'If Not Me.qty_check() Then Return False

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("wi_ku1120_confirm")

            p.Clear()
            p.Add("@plan_no", plan_no.Text)
            p.Add("@stts", "C")

            Me.Open("WI_PR1101_confirm", p)

            Me.Clear()

            g_list.Open()
        End If

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If plan_no.Text = Nothing Then
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
            p.Add("@plan_no", plan_no.Text)
            p.Add("@stts", "S")

            Me.Open("WI_PR1101_confirm", p)

            p.Clear()
            p.Add("@plan_no", plan_no.Text)

            Me.Open("WI_PR1101_head", p)
            Me.Open("WI_PR1101_body", p)
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

    Private Function Check_deconfirm() As String
        p.Clear()
        p.Add("@PLAN_NO", plan_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("WI_PR1101_deconfirm", p)
        Dim stts As String = "N"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    'Private Function qty_check() As Boolean
    '    Dim mate_qty As Decimal

    '    With g_body
    '        .UpdateRow()
    '        For i As Integer = 0 To .RowCount - 1
    '            mate_qty = mate_qty + .ToDec("MATE_QTY", i)
    '        Next
    '    End With

    '    If stock_qty.ToDec < mate_qty Then
    '        MsgBox("약품재고보다 투입량이 많습니다.!")
    '        Return False

    '    End If

    '    Return True

    'End Function

    Private Sub Clear()
        p.Clear()
        p.Add("@plan_no", "XXX")

        Me.Open("WI_PR1101_head", p)
        Me.Open("WI_PR1101_body", p)
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
        p.Add("@find_cs_nm", "XXX")
        'p.Add("@find_stts", find_stts.Text)

        Me.Open("WI_PR1101_list", p)
    End Sub

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    'Private Sub rate_TextChanged(ByVal sender As Object, ByVal oldValue As String)
    '    won_amt.Text = chul_amt.ToDec * Rate.ToDec
    'End Sub

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        p.Clear()
        p.Add("@plan_no", g_list.Text("PLAN_NO", g_list.RowIndex))

        Me.Open("WI_PR1101_head", p)
        Me.Open("WI_PR1101_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()

    End Sub

    Private Sub gd_cd_TextChanged(sender As Object, oldValue As String) Handles gd_cd.TextChanged
        If g_body.RowCount > 0 Then Me.Clear()

    End Sub

    Private Sub mc_cd_TextChanged(sender As Object, e As System.EventArgs) Handles mc_cd.TextChanged
        If g_body.RowCount > 0 Then Me.Clear()
    End Sub
End Class
