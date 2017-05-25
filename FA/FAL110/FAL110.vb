Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAL110

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Open()
    'End Sub

    Private Sub no_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_yn.CheckedChanged
        g20.Open()
    End Sub

End Class
