Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions
Imports System.Math

Public Class WI_CO1531

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            ' Case MenuType.Open

            ' Me.Open_Form()

            'Case MenuType.Save

            'Me.save_Form()

            'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

End Class
