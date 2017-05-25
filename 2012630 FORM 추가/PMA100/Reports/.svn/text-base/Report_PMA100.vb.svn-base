Public Class Report_PMA100

    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

    End Sub

    Public Sub SetDataBinding(ByRef data As Data.DataSet)
        Me.DataSource = data

        totalCount.Text = data.Tables(0).Rows.Count
        print_dt.Text = Date.Today.ToString("yyyy-MM-dd")
    End Sub
End Class