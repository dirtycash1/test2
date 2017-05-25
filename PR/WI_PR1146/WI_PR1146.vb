Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1146
    Private Sub g_result_ButtonPressed(sender As Object, columnName As String) Handles g_result.ButtonPressed
        Dim pp As OpenParameters = New OpenParameters
        pp.Add("@PR_NO", g_result.Text("PR_NO"))
        pp.Add("@LOT_NO", g_result.Text("LOT_NO"))
        System7.ReportView.LoadView("WI_PR1146R", "", "WI_PR1146_print", pp, )
    End Sub
End Class
