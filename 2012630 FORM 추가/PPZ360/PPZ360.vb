Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPZ360

    Private Sub PPZ360_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.NewForm()
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

    Public Overrides Sub NewForm()
        fa_no.Text = "zz"

        MyBase.Open()
        g10.AddNewRow()

        fa_no.Text = ""
    End Sub

End Class
