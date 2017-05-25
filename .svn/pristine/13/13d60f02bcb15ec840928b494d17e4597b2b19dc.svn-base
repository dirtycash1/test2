Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC780


    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty

            Case MenuType.Print
                Me.Print()

            Case Else

                MyBase.MenuButton_Click(ty)

        End Select

    End Sub


    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@tax_year", tax_year.Text)
        p.Add("@mon_bc", mon_bc.Text)

        System7.ReportView.LoadView("fac780", "", "fac780_g10", p) '전표

    End Sub


End Class
