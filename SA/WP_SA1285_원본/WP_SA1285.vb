Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_SA1285

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Print

                Me.Print()

                'Case MenuType.Save

                'Me.save_Form()

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        Dim p2 As OpenParameters = New OpenParameters

        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@ps_cd", ps_cd.Text)

        p2.Add("@fr_dt", fr_dt.Text)
        p2.Add("@to_dt", to_dt.Text)
        'p2.Add("@cs_cd", cs_cd.Text)


        'System7.ReportView.LoadView("WP_SA1285", "", "wp_sa1285_print", p)
        System7.ReportView.LoadView("WP_SA1285", "", "wp_sa1285_print", p, Nothing, True, 1, "sub", "wp_sa1285_print2", p2)




    End Sub
End Class
