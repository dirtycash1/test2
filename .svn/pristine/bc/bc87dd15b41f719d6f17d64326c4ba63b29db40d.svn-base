Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAY101
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Save

                If Me.Save("gay100_g10") Then
                    Me.Open("gay100_g10")
                End If

            Case MenuType.New


            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

End Class
