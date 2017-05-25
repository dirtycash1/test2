Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRR220

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 폼 로드시 1차 2차 평가 점수/ 의견을 숨김
        Me.SplitContainer6.Visible = False
        ' 폼 로드시 1차 2차 등급 숨김
        g20.ColumnVisible("rate1") = False
        g20.ColumnVisible("rate2") = False

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()
                Me.g20_open()
                ' MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save

                If g20.RowCount - 1 >= 0 Then

                    Dim i As Integer

                    For i = 0 To g20.RowCount - 1

                        If g20.Text("a1", i) <> "1" And g20.Text("a2", i) <> "1" And g20.Text("a3", i) <> "1" And g20.Text("a4", i) <> "1" Then

                            Select Case MessageYesNoCancel("평가되지 않은 항목이 있습니다. 저장하시겠습니까?", "확인")
                                Case MsgBoxResult.Yes
                                    If Me.Save() Then
                                        Dim saveID As String = g10.Text("emp_no")
                                        Me.Open()
                                        g10.Find("emp_no=" + saveID)
                                        Me.g20_open()
                                    End If
                                    Exit Sub
                                Case MsgBoxResult.No
                                    Exit Sub
                                Case MsgBoxResult.Cancel
                                    Exit Sub
                            End Select

                        End If
                    Next

                End If

                If Me.Save() Then
                    Dim saveID As String = g10.Text("emp_no")
                    Me.Open()
                    g10.Find("emp_no=" + saveID)
                    Me.g20_open()
                End If
                'If Me.Save() Then
                '    Me.Open("hrr220_f10")
                'End If
            Case MenuType.New
                f_emp_no.Text = ""
                Me.Open()
                Me.g20_open()
                'Case MenuType.Print
                '    Me.print()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Public Sub _Open()
        If step_sq.Text = "1" Then
            ' 1차 고과자 평가시 1차 점수/1차 의견/ 2차 점수 / 2차 의견 / 1차 평가등급/ 2차 평가등급 숨김
            Me.SplitContainer6.Visible = False
            g20.ColumnVisible("rate1") = False
            g20.ColumnVisible("rate2") = False
            Me.Open()
            Me.g20_open()
            step_sq.Text = "1"
        End If

        If step_sq.Text = "2" Then
            ' 1차 고과자 평가시 1차 점수/1차 의견/ / 1차 평가등급 보임    2차 점수 / 2차 의견/ 2차 평가등급 숨김 

            Me.SplitContainer6.Visible = True
            Me.SplitContainer6.Panel2Collapsed = True
            g20.ColumnVisible("rate1") = True
            g20.ColumnVisible("rate2") = False
            Me.Open()
            Me.g20_open()
            step_sq.Text = "2"

        End If

        If step_sq.Text = "3" Then
            ' 1차 고과자 평가시 1차 점수/1차 의견/ / 1차 평가등급 보임    2차 점수 / 2차 의견/ 2차 평가등급 숨김 

            Me.SplitContainer6.Visible = True
            Me.SplitContainer6.Panel2Collapsed = False
            g20.ColumnVisible("rate1") = True
            g20.ColumnVisible("rate2") = True
            Me.Open()
            Me.g20_open()
            step_sq.Text = "3"
        End If

    End Sub

    'Private Sub step_sq_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles step_sq.TextChanged

    '    If step_sq.Text = "1" Then
    '        ' 1차 고과자 평가시 1차 점수/1차 의견/ 2차 점수 / 2차 의견 / 1차 평가등급/ 2차 평가등급 숨김
    '        'Me.Open("hrr220_f10")
    '        Me.SplitContainer6.Visible = False
    '        g20.ColumnVisible("rate1") = False
    '        g20.ColumnVisible("rate2") = False
    '        '    Me.Open()
    '        'Me.Open("hrr220_f10")
    '        Me.Open("hrr220_g10")
    '        Me.Open("hrr220_g20")
    '        step_sq.Text = "1"
    '    End If

    '    If step_sq.Text = "2" Then
    '        ' 1차 고과자 평가시 1차 점수/1차 의견/ / 1차 평가등급 보임    2차 점수 / 2차 의견/ 2차 평가등급 숨김 
    '        'Me.Open("hrr220_f10")
    '        Me.SplitContainer6.Visible = True
    '        Me.SplitContainer6.Panel2Collapsed = True
    '        g20.ColumnVisible("rate1") = True
    '        g20.ColumnVisible("rate2") = False
    '        'Me.Open()
    '        'Me.Open("hrr220_f10")
    '        Me.Open("hrr220_g10")
    '        Me.Open("hrr220_g20")
    '        step_sq.Text = "2"

    '    End If

    '    If step_sq.Text = "3" Then
    '        ' 1차 고과자 평가시 1차 점수/1차 의견/ / 1차 평가등급 보임    2차 점수 / 2차 의견/ 2차 평가등급 숨김 
    '        ' Me.Open("hrr220_f10")
    '        Me.SplitContainer6.Visible = True
    '        Me.SplitContainer6.Panel2Collapsed = False
    '        g20.ColumnVisible("rate1") = True
    '        g20.ColumnVisible("rate2") = True
    '        'Me.Open()
    '        'Me.Open("hrr220_f10")
    '        Me.Open("hrr220_g10")
    '        Me.Open("hrr220_g20")
    '        step_sq.Text = "3"
    '    End If
    'End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If g10.RowCount <= 0 Then
            MsgBox("해당차수에 평가 대상자가 없습니다.")
        Else
            Me.g20_open()
        End If
    End Sub

    Public Sub g20_open()

        With g20

            If .RowCount - 1 >= 0 Then
                itm_cnt.Text = .RowCount
            End If

            Dim i As Integer
            Dim chk As Integer
            chk = 0

            For i = 0 To .RowCount - 1

                If .Text("a1", i) = "1" Or .Text("a2", i) = "1" Or .Text("a3", i) = "1" Or .Text("a4", i) = "1" Then
                    chk += 1
                End If

            Next

            chk_cnt.Text = chk

        End With

    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged

        If ColumnName = "a1" Or ColumnName = "a2" Or ColumnName = "a3" Or ColumnName = "a4" Then
            With g20
                If .RowCount - 1 >= 0 Then
                    Dim i As Integer
                    Dim chk As Integer
                    chk_cnt.Text = 0
                    For i = 0 To .RowCount - 1
                        If .Text("a1", i) = "1" Or .Text("a2", i) = "1" Or .Text("a3", i) = "1" Or .Text("a4", i) = "1" Then
                            chk += 1
                        End If
                    Next
                    chk_cnt.Text = chk
                End If
            End With
        End If
    End Sub


End Class

