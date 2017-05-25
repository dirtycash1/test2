Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAR105


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New
                pay_mon.Text = Date.Now()

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()

        Me.Open("par105_g10")

    End Sub

  
End Class
