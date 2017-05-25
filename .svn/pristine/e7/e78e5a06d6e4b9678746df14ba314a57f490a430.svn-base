Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAT100

    Private Sub FAT100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.Open

            '    Me.Open_Form()

            '    'Case MenuType.New

            Case MenuType.Save
                If Not Me.Save() Then
                    Me.Open()
                End If
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
