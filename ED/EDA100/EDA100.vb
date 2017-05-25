Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class EDA100

    Private Sub g_body_ButtonPressed(sender As Object, columnName As String) Handles g10.ButtonPressed


        Dim pp As OpenParameters = New OpenParameters
        pp.Add("@ed_nm", g10.Text("ed_nm"))
        pp.Add("@ed_lotno", g10.Text("ED_LOTNO"))
        Select Case g10.Text("ED_STH")
            Case "ED101100"
                System7.ReportView.LoadView("EDA100", "", "EDA100_print", pp, )
            Case "ED101200"
                System7.ReportView.LoadView("EDA100RS", "", "EDA100_print", pp, )
            Case "ED101300"
                System7.ReportView.LoadView("EDA100R1", "", "EDA100_print", pp, )
            Case "ED101400"
                System7.ReportView.LoadView("EDA100R2", "", "EDA100_print", pp, )
        End Select
        'If g10.Text("ED_STH") <> "ED101200" Then
        'Else
        'End If
           

    End Sub
End Class
