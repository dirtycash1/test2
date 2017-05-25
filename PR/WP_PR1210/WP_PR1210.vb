Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_PR1210

    Private Sub but_prt_Click(sender As System.Object, e As System.EventArgs) Handles but_prt.Click

        With g10
            If .RowCount - 1 >= 0 Then
                If .CheckedRows("chk") = 0 Then
                    Exit Sub
                Else
                    Dim tb As DataTable, drow As DataRow
                    Dim dset As DataSet = Me.OpenDataSet("wp_pr1210_temp")

                    tb = dset.Tables(0)

                    .UpdateRow()
                    tb.BeginLoadData()
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("chk", i) Then
                            drow = tb.NewRow()
                            drow("pr_no") = .Text("pr_no", i)

                            tb.Rows.Add(drow)
                        End If
                    Next
                    tb.EndLoadData()


                    MyBase.Save("wp_pr1210_temp")


                    Dim p As OpenParameters = New OpenParameters
                     p.Add("@fr_dt", fr_dt.Text)
                    p.Add("@to_dt", to_dt.Text)

                    Dim p2 As OpenParameters = New OpenParameters

                    p2.Add("@fr_dt", fr_dt.Text)
                    p2.Add("@to_dt", to_dt.Text)

                    System7.ReportView.LoadView("WP_PR1210", "", "wp_pr1210_print", p, Nothing, True, 1, "sub", "wp_pr1210_sub_print", p2)
                    'System7.ReportView.LoadView("WP_SA1141", "", "wi_sa1141_print", p, Nothing, False, 1, "sub", "wi_sa1141_print_sub", p1) ' 바로출력
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End With
        


    End Sub

    Private Sub but_all_Click(sender As System.Object, e As System.EventArgs) Handles but_all.Click
        If g10.RowCount - 1 >= 0 Then
            Dim i As Integer
            Dim c As Integer
            c = 0
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "0" Then
                    c = c + 1
                End If
            Next
            If c = 0 Then
                For i = 0 To g10.RowCount - 1
                    g10.Text("chk", i) = "0"
                Next
            Else
                For i = 0 To g10.RowCount - 1
                    g10.Text("chk", i) = "1"
                Next
            End If
        End If
    End Sub
End Class
