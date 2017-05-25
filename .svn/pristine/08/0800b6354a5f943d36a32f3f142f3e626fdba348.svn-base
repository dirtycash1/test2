Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LET500
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

                'Case MenuType.New


            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub



    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click

        If MessageYesNo(std_mon.Text + " ← 해당월 데이터를 삭제 후 데이터를 집계 합니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@std_mon", std_mon.Text)

        Me.OpenDataSet("LET500_Work", p)

        Me.Open()
    End Sub

End Class
