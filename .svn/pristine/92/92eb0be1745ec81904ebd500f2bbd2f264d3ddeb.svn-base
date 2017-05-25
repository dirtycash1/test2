Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRR301

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

                Me.Open()

                'Case MenuType.Print

                '    Me.print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


   
End Class
