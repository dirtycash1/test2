Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAH100

    'Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
    '    Me.New_Form()

    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.Open

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

                'Case MenuType.Delete

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
