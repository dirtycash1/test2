Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAR104

    Private Sub PAR104_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.New_Form()

            Case MenuType.Save

                If Me.Save() Then
                    Me.New_Form()
                End If

            Case MenuType.New

                Me.New_Form()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("PAR104_g10")

    End Sub



End Class
