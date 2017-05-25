Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMG110

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.SelectRow = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

End Class
