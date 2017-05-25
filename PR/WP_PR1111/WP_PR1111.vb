Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_PR1111

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

    Private Sub btn_prt_Click(sender As System.Object, e As System.EventArgs) Handles btn_prt.Click
        With g10
            If .RowCount - 1 >= 0 Then
                If .CheckedRows("chk") = 0 Then
                    Exit Sub
                Else
                    Dim tb As DataTable, drow As DataRow
                    Dim dset As DataSet = Me.OpenDataSet("wp_pr1111_temp")

                    tb = dset.Tables(0)

                    .UpdateRow()
                    tb.BeginLoadData()
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("chk", i) Then
                            drow = tb.NewRow()
                            drow("job_no") = .Text("pr_no", i)
                            drow("gd_cd") = .Text("gd_cd", i)
                            tb.Rows.Add(drow)
                        End If
                    Next
                    tb.EndLoadData()


                    MyBase.Save("wp_pr1111_temp")

                    Dim p As OpenParameters = New OpenParameters

                    p.Add("@fr_dt", fr_dt.Text)
                    p.Add("@to_dt", to_dt.Text)
                    p.Add("@daytime_gu", daytime_gu.Text)

                    System7.ReportView.LoadView("WP_PR1111", "", "WP_PR1111_Print", p)


                    Exit Sub
                End If
            Else
                Exit Sub
            End If


        End With
    End Sub

    Private Sub btn_prt2_Click(sender As Object, e As EventArgs) Handles btn_prt2.Click
        With g10
            If .RowCount - 1 >= 0 Then
                If .CheckedRows("chk") = 0 Then
                    Exit Sub
                Else
                    Dim tb As DataTable, drow As DataRow
                    Dim dset As DataSet = Me.OpenDataSet("wp_pr1111_temp")

                    tb = dset.Tables(0)

                    .UpdateRow()
                    tb.BeginLoadData()
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("chk", i) Then
                            drow = tb.NewRow()
                            drow("job_no") = .Text("pr_no", i)
                            drow("gd_cd") = .Text("gd_cd", i)
                            tb.Rows.Add(drow)
                        End If
                    Next
                    tb.EndLoadData()


                    MyBase.Save("wp_pr1111_temp")

                    Dim p As OpenParameters = New OpenParameters

                    p.Add("@fr_dt", fr_dt.Text)
                    p.Add("@to_dt", to_dt.Text)
                    p.Add("@daytime_gu", daytime_gu.Text)

                    System7.ReportView.LoadView("WP_PR1111_2", "", "WP_PR1111_Print2", p)


                    Exit Sub
                End If
            Else
                Exit Sub
            End If


        End With
    End Sub
End Class
