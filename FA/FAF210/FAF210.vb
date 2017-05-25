Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAF210

    Private Sub chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk.CheckedChanged

        If g10.RowCount >= 0 Then

            g10.StopOpenEvent = True

            g10.CheckRows("chk", chk.Checked)

            g10.StopOpenEvent = False

        End If

    End Sub

    Private Sub btn_plan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plan.Click

        If Me.Save() Then
            '저장후 원래 Row위치로 가게
            Dim cd As String = g10.Text("ent_id")
            g10.Open()
            g10.Find("ent_id=" + cd)

        End If

    End Sub

End Class
