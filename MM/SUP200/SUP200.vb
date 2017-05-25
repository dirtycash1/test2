Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SUP200
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open()

        If g10.RowCount = 0 Then
            MenuButton_Click(MenuType.New)
        End If

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open()

                'Case MenuType.Save

                'Case MenuType.New


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


End Class
