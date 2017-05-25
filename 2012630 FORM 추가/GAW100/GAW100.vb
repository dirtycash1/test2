Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAW100
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
             
                Me.Open()


            Case MenuType.Save
                If Me.Save() Then

                    Me.OpenTrigger("gaw100_g10")
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

  
End Class
