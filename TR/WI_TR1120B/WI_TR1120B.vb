Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR1120B
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open


                Me.Open()

                'g10.AutoSize = True
                g10.RowAutoHeight = True


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
End Class
