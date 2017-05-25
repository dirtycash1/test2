Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class PAB200
    Private Sub PAB200_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim monthstr As Date
        monthstr = mon.Text
        to_mon.Text = DateAdd(DateInterval.Month, -1, monthstr)

    End Sub

    Private Sub fr_mon_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mon.TextChanged
        Dim monthstr As Date
        monthstr = mon.Text
        to_mon.Text = DateAdd(DateInterval.Month, -1, monthstr)
    End Sub
End Class
