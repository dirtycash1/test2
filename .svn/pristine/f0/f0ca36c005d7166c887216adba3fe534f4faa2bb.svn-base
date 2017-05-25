Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRR240

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Open()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
      
                If Me.Save() Then

                    Me.Open()
                End If


            Case MenuType.New

                emp_no.Text = ""
                emp_nm.Text = ""
                dept_cd.Text = ""
                Me.Open()

                'Case MenuType.Print

                '    Me.print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click

        If MessageYesNo(eval_year.Text + " ← 기준년도 표준편차를 다시 계산 합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@eval_year", eval_year.Text)
        p.Add("@term_bc", term_bc.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@dept_cd", dept_cd.Text)

        Me.OpenDataSet("HRR240_Work", p)

        Me.Open()
    End Sub


    Private Sub but_work1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work1.Click
        If MessageYesNo(eval_year.Text + " ← 기준년도 최종 등급를 다시 계산 합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@eval_year", eval_year.Text)
        p.Add("@term_bc", term_bc.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@dept_cd", dept_cd.Text)

        Me.OpenDataSet("HRR240_Work1", p)

        Me.Open()
    End Sub

    Private Sub but_work2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work2.Click
        If MessageYesNo(eval_year.Text + " ← 기준년도 평가주기 고과평가 삭제 후 반영합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@eval_year", eval_year.Text)
        p.Add("@term_bc", term_bc.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@dept_cd", dept_cd.Text)
       
        Me.OpenDataSet("HRR240_Work2", p)
    End Sub
End Class
