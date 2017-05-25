Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions
Imports System.Math

Public Class WI_CO1530

    'Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
    '    Me.New_Form()

    'End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                '    'Open_Form()
            

                'Case MenuType.New
                'New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

End Class
