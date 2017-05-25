Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FMP600

    Private Sub fma101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MyBase.Open()

        g10.RecordNavigator = True
        

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                MyBase.Open()



            Case MenuType.New

                MyBase.Open()



            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
   
    Private Sub work_btn_Click(sender As System.Object, e As System.EventArgs) Handles work_btn.Click
        If MessageYesNo("작업하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Open("fmp600_work")
        g10.Open()
    End Sub

End Class
