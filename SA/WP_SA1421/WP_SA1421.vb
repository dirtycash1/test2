Imports Frame7
Imports Base7
Imports Base7.Shared
Imports MySql.Data.MySqlClient


Public Class WP_SA1421

    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim param(0 To g_result.RowCount) As String
        For i2 As Integer = 0 To g_result.RowCount
            g_result.RowIndex = i2
            param(i2) = g_result.Text("LOT_NO")

        Next
    End Sub
End Class
