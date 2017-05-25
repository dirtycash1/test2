Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAC760

    Private Sub FAB101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Print
                Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region " Print "
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@bs_cd", co_cd.Text)
        p.Add("@mon_bc", mon_bc.Text)
        p.Add("@tax_year", tax_year.Text)
        System7.ReportView.LoadView("fac760", "", "fac760_Print", p) '내국신용장,구매확인서 전자발급명세서
    End Sub
#End Region
End Class
