Imports Frame7
Imports Base7
Imports Base7.Shared

Imports Base7.Parameter

Public Class PAB115


    Private Sub PAB101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open("pab115_g10")

        If Me.IsManager = True Then
            emp_no.Enabled = True
        Else
            emp_no.Enabled = False
        End If

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open("pab115_g10")


            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New


            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@pay_bc", g10.Text("pay_bc"))
        p.Add("@pay_sq", g10.Text("pay_sq"))
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@dept_cd", "")
        p.Add("@duty1_bc", "")
        p.Add("@duty2_bc", "")
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@kind_bc", "")

        System7.ReportView.LoadView("PAB115", "", "pab115_print", p, CrystalReportViewer, True)


    End Sub


    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Me.Print()
    End Sub

End Class
