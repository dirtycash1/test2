Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SUP100
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        no_amt_yn.Text = 0
        Me.Open()
    End Sub
    Private Sub no_amt_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles no_amt_yn.CheckedChanged
        '  no_amt_yn.Text = 1
    End Sub
End Class
