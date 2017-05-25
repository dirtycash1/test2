Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAP500


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.Save("pap500_g20")

                'Case MenuType.New
                'Case MenuType.New


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()
        If work_bc.Text = "HR160100" Then
            g10.BringToFront()
            Me.Open("pap500_g10")
        Else
            g20.BringToFront()
            Me.Open("pap500_g20")
        End If

    End Sub


    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click
        If MessageYesNo("  기존 급여 인상안이 삭제 후 제 계산 합니다. 계속 진행 하겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@std_year", std_year.Text)
        p.Add("@rank_bc", rank_bc.Text)
        p.Add("@step_bc", step_bc.Text)
        p.Add("@work_bc", work_bc.Text)


        Me.OpenDataSet("PAP500_Work", p)

        Open_Form()
    End Sub
  

End Class
