Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView

Public Class FAC900

    Private Sub FAC900_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '  but1.Text = but.Properties.Items(but.SelectedIndex).Value
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New

                tax_year.Text = Now().Year

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()

        Me.Open("fac900_g10")
        Print()
    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@tax_year", tax_year.Text)
        p.Add("@Mon_bc", mon_bc.Text)
        p.Add("@print_ty", "1")


        System7.ReportView.LoadView("FAC900", "", "fac900_print", p, CrystalReportViewer, True) '
    End Sub


End Class
