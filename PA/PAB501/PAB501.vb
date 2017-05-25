Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class PAB501

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.New_Form()
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()

                End If
            Case MenuType.New

                pay_bc.Text = ""
                pd_bc.Text = ""
                emp_no.Text = ""

                Me.New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()

        MyBase.Open("pab501_g10")


    End Sub

End Class
