Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRR200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Doc()
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Doc()
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Doc()
                    Me.Open()
                End If

            Case MenuType.New
                dept_cd.Text = ""
                itm_kd.Text = "HR600100"
                high_fr.Text = "HR15190"
                high_to.Text = "HR15198"
                Me.Doc()
                Me.Open()

            Case MenuType.Print

                Me.print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub print()
        If itm_kd.Text = "HR600100" Then
            Dim p As OpenParameters = New OpenParameters

            p.Add("@co_cd", co_cd.Text)
            p.Add("@eval_year", eval_year.Text)
            p.Add("@term_bc", term_bc.Text)
            p.Add("@itm_kd", itm_kd.Text)
            p.Add("@dept_cd", dept_cd.Text)
            p.Add("@emp_no", emp_no.Text)

            System7.ReportView.LoadView("HRR200", "", "HRR200_print", p) '근무성적평가서 출력
        Else
            Exit Sub
        End If
      
    End Sub

    Private Sub btn_emp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_emp.Click

        union_yn.Text = "1"
        If dept_cd.Text = "" Then
            MsgBox("부서를 선택해 주세요")
            Exit Sub
        End If
        Me.Doc()
        Me.Open()
        union_yn.Text = "0"

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.CheckRows("chk", chk_all.Checked)
    End Sub

    Private Sub Doc()

        If itm_kd.Text = "HR600100" Then
            g10.ColumnVisible("e1_emp") = False
            g10.ColumnVisible("e1_emp_nm") = False
            g10.ColumnVisible("e2_emp") = False
            g10.ColumnVisible("e2_emp_nm") = False
            g10.ColumnVisible("e3_emp") = False
            g10.ColumnVisible("e3_emp_nm") = False
            g10.ColumnVisible("ok_emp") = False
            g10.ColumnVisible("ok_emp_nm") = False

        Else
            g10.ColumnVisible("e1_emp") = True
            g10.ColumnVisible("e1_emp_nm") = True
            g10.ColumnVisible("e2_emp") = True
            g10.ColumnVisible("e2_emp_nm") = True
            g10.ColumnVisible("e3_emp") = True
            g10.ColumnVisible("e3_emp_nm") = True
            g10.ColumnVisible("ok_emp") = True
            g10.ColumnVisible("ok_emp_nm") = True
        End If

    End Sub

    Private Sub itm_kd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itm_kd.TextChanged
        Select Case itm_kd.Text
            Case "HR600100"       '근무성적평가서
                high_fr.Text = "HR15190"
                high_to.Text = "HR15198"
            Case "HR600300"       '고가 A형 현장사원
                high_fr.Text = "HR15198"
                high_to.Text = "HR15198"
            Case "HR600310"       '고가 B형 조장이상
                high_fr.Text = "HR15190"
                high_to.Text = "HR15196"


        End Select
    End Sub

End Class
