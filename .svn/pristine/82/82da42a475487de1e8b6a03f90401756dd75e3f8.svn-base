Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRA120



    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me.Open()

            Case MenuType.Save

            Case MenuType.New
                but1.Text = but.Properties.Items(but.SelectedIndex).Value

                If but1.Text = "0" Then

                    g10.BringToFront()
                    Me.Open("hra120_g10")

                Else
                    EPanel3.Text = "일자"
                    g20.BringToFront()
                    Me.Open("hra120_g20")

                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub but_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but.SelectedIndexChanged
        but1.Text = but.Properties.Items(but.SelectedIndex).Value

        If but1.Text = "0" Then

            g10.BringToFront()
            Me.Open("hra120_g10")

        Else
            EPanel3.Text = "일자"
            g20.BringToFront()
            Me.Open("hra120_g20")

        End If

    End Sub


    Private Sub work_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles work_but.Click
        If MessageYesNo(work_dt.Text + " ← 해당일자 데이터를 삭제 후 데이터를 가져옵니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@work_dt", work_dt.Text)

        Me.OpenDataSet("HRA120_Work", p)
        Me.Open()
    End Sub

End Class
