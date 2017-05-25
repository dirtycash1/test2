Public Class CAW100

    Private Sub cmdproc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdproc.Click
        If Me.Save() Then
            Me.Open()
        End If
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        For row = 0 To g10.RowCount - 1
            g10.Text("chk", row) = "1"
        Next
    End Sub

    Private Sub CAW100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

End Class
