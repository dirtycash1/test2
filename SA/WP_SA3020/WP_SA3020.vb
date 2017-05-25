Imports Frame7
Imports Base7
Imports Base7.Shared

Imports Base7.Parameter

Public Class WP_SA3020


    Private Sub WP_SA3020_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open("WP_SA3020_g10")


    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open("WP_SA3020_g10")


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

        p.Add("@std_dt", std_dt.Text)
        p.Add("@cust_cd", g10.Text("cs_cd"))
       
        System7.ReportView.LoadView("WP_SA3020", "", "WP_SA3020_print", p, CrystalReportViewer, True)


    End Sub


    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Me.Print()
    End Sub

End Class
