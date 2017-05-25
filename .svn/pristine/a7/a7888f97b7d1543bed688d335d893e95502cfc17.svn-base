Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDY310

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

End Class
