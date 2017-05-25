Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAP750


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save
                If Me.Save("pap750_g10") Then
                    Me.Open("pap750_g10")
                End If

                If Me.Save("pap750_g20") Then
                    Me.Open("pap750_g20")
                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()
        If work_bc.Text = "HR160100" Then
            g10.BringToFront()
            Me.Open("pap750_g10")
        Else
            g20.BringToFront()
            Me.Open("pap750_g20")
        End If

    End Sub

    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click
        If MessageYesNo("기존 데이터 삭제 후 제 계산 합니다. 계속 진행 하겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@std_year", std_year.Text)
        p.Add("@work_bc", work_bc.Text)

        Me.OpenDataSet("PAP750_Work", p)

        Open_Form()
    End Sub


End Class
