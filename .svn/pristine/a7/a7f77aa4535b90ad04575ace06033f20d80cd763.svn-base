Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAB850

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fr_year.Enabled = False
    End Sub

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        Me.Open("fab850_work")

        Me.Open()

    End Sub

    Private Sub to_year_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles to_year.TextChanged
        If to_year.Text = "" Then
            fr_year.Text = ""
        Else
            fr_year.Text = (ToDec(to_year.Text) - 1).ToString
        End If
    End Sub

End Class
