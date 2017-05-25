Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAY110
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                g10.BringToFront()

                'Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

                'Case MenuType.New


                'Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click
        If MessageYesNo(std_year.Text + " ← 해당 기준년 데이터를 삭제 후  제 계산합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@std_year", std_year.Text)
        p.Add("@dept_cd", dept_cd.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@pay_bc", pay_bc.Text)
        p.Add("@work_bc", work_bc.Text)

        Me.OpenDataSet("GAY110_Work", p)

        Me.Open()


    End Sub
    Private Sub but2_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2_work.Click

        If MessageYesNo(std_year.Text + " ← 해당 기준년 데이터를 삭제 후  제 계산합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@std_year", std_year.Text)
        p.Add("@dept_cd", dept_cd.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@pay_bc", pay_bc.Text)
        p.Add("@work_bc", work_bc.Text)

        Me.OpenDataSet("GAY110_Work1", p)

        Me.Open()


    End Sub

    Private Sub chk_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yn.CheckedChanged
        g10.CheckRows("pay_yn", chk_yn.Checked)
    End Sub

    Private Sub but_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_pay.Click
        If MessageYesNo("급여에 반영 하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Me.Open()
        End If
    End Sub

    Private Sub detail_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detail_yn.CheckedChanged

        g10.ColumnVisible("m1") = Not detail_yn.Checked
        g10.ColumnVisible("m2") = Not detail_yn.Checked
        g10.ColumnVisible("m3") = Not detail_yn.Checked
        g10.ColumnVisible("m4") = Not detail_yn.Checked
        g10.ColumnVisible("m5") = Not detail_yn.Checked
        g10.ColumnVisible("m6") = Not detail_yn.Checked
        g10.ColumnVisible("m7") = Not detail_yn.Checked
        g10.ColumnVisible("m8") = Not detail_yn.Checked
        g10.ColumnVisible("m9") = Not detail_yn.Checked
        g10.ColumnVisible("m10") = Not detail_yn.Checked
        g10.ColumnVisible("m11") = Not detail_yn.Checked
        g10.ColumnVisible("m12") = Not detail_yn.Checked

        g20.ColumnVisible("m1") = Not detail_yn.Checked
        g20.ColumnVisible("m2") = Not detail_yn.Checked
        g20.ColumnVisible("m3") = Not detail_yn.Checked
        g20.ColumnVisible("m4") = Not detail_yn.Checked
        g20.ColumnVisible("m5") = Not detail_yn.Checked
        g20.ColumnVisible("m6") = Not detail_yn.Checked
        g20.ColumnVisible("m7") = Not detail_yn.Checked
        g20.ColumnVisible("m8") = Not detail_yn.Checked
        g20.ColumnVisible("m9") = Not detail_yn.Checked
        g20.ColumnVisible("m10") = Not detail_yn.Checked
        g20.ColumnVisible("m11") = Not detail_yn.Checked
        g20.ColumnVisible("m12") = Not detail_yn.Checked

        Me.Open()

         
    End Sub


    Private Sub GAY110_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        XtraTabControl1.SelectedTabPageIndex = 1
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
End Class
