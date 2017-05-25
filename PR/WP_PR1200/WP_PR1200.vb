Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR1200

    Private Sub but_prt_Click(sender As System.Object, e As System.EventArgs) Handles but_prt.Click
        Dim p As OpenParameters = New OpenParameters

        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
       
        System7.ReportView.LoadView("WP_PR1200", "", "WP_PR1200_Print", p)
    End Sub
End Class
