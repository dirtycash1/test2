Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAM210

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me.Open("gad100_g20")
                'Me.Open("gad100_g30")
                ' Me.Open("gad200_g10")
                MyBase.MenuButton_Click(mty)
            Case MenuType.Save

                If Me.Save("gam210_g10") Then
                    Me.Open("gam210_g10")

                End If

            Case MenuType.New
                'bs_cd.Text = ""
                'work_bc.Text = ""
                MyBase.MenuButton_Click(mty)
            Case MenuType.Print
                Me.Print()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Private Sub Print()
        'Dim p As OpenParameters = New OpenParameters
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@work_bc", work_bc.Text)
        'p.Add("@fr_dt", fr_dt.Text)
        'p.Add("@to_dt", to_dt.Text)
        'p.Add("@dept_cd", dept_cd.Text)
        'p.Add("@emp_no", emp_no.Text)
        'p.Add("@emp_nm", emp_nm.Text)

        'GAM2001.ReportView.LoadView("GAM2001", "", "gad100_print", p)

    End Sub




    'Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

    '    Dim p As OpenParameters = New OpenParameters

    '    p.Add("@co_cd", co_cd.Text)
    '    p.Add("@bs_cd", bs_cd.Text)
    '    p.Add("@fr_dt", fr_dt.Text)
    '    p.Add("@to_dt", to_dt.Text)
    '    p.Add("@emp_no", g10.Text("emp_no"))

    '    Me.Open("gad100_g10", p)

    'End Sub


    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

    '    If ColumnName = "late_hr" Or ColumnName = "off_hr" Or ColumnName = "out_hr" Then
    '        If g10.Text("dt_bc") = "GA120100" Then
    '            g10.Text("t1_hr") = 8 - g10.ToDec("late_hr") - g10.ToDec("off_hr") - g10.ToDec("out_hr")
    '        Else
    '            g10.Text("t1_hr") = 4 - g10.ToDec("late_hr") - g10.ToDec("off_hr") - g10.ToDec("out_hr")
    '        End If

    '    End If

    'End Sub


    Private Sub btn_access_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_access.Click


        If Me.Save("gam210_g10") Then
            Me.Open("gam210_g10")

        End If

        'If MessageYesNo(std_dt.Text + " ← 해당일자의 데이터를 삭제 후 생성합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        'Dim p As OpenParameters = New OpenParameters

        ''p.Add("@bs_cd", bs_cd.Text)
        ''p.Add("@dept_cd", dept_cd.Text)
        ''p.Add("@emp_no", emp_no.Text)
        ''p.Add("@emp_nm", emp_nm.Text)
        'p.Add("@std_dt", std_dt.Text)
        ''p.Add("@work_bc", work_bc.Text)

        'Me.OpenDataSet("GAD100_Work", p)

        'Me.Open("gad100_g10")
    End Sub
End Class
