Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class PAA110
    Dim sq_nm As String = ""

    Private Sub PAA110_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

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

 

    Private Sub app_work_Click(sender As System.Object, e As System.EventArgs) Handles app_work.Click


        If MessageYesNo(pay_mon.Text + "월 " + " 마감 처리 하시겠습니까? ", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("paa110_work")

        Me.Open("paa110_g10")

    End Sub

    Private Sub del_work_Click(sender As System.Object, e As System.EventArgs) Handles del_work.Click


        If MessageYesNo(pay_mon.Text + "월 " + " 마감 취소 처리 하시겠습니까? ", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("paa110_del")

        Me.Open("paa110_g10")

    End Sub
End Class
