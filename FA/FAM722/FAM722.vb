Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM722

    Private Sub bud_yearmm_TextChanged(sender As System.Object, e As System.EventArgs) Handles bud_yearmm.TextChanged
        bud_year.Text = Mid(bud_yearmm.Text, 1, 4)
        bud_mon.Text = Mid(bud_yearmm.Text, 6, 2)
    End Sub

    Private Sub btn_amt_Click(sender As System.Object, e As System.EventArgs) Handles btn_amt.Click

        Dim Row_I As Integer

        With g10
            For Row_I = 0 To .RowCount - 1
                If .ToDec("bud1_mamt", Row_I) > 0 Then

                    g10.Text("bud2_mamt", Row_I) = .ToDec("bud1_mamt", Row_I)
                End If
            Next
        End With
    End Sub
End Class
