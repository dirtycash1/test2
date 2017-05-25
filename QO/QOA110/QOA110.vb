Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math
Imports System.Data
Imports DevExpress.XtraCharts

Public Class QOA110

    Private Sub QOA100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '   chk1.SetValue("1", "")
        '   chk2.SetValue("1", "")
        '  chart1.Series.Clear()
        ' Chart2.Series.Clear()
        chart1.Visible = False
        Chart2.Visible = False
    End Sub

    Private Sub OpenChart(ByVal ItmId As String)
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@itm_id", ItmId)

            Dim dSet1 As DataSet = Me.OpenDataSet("qoa110_chart", param)
            'Dim dSet2 As DataSet = Me.OpenDataSet("ESK410_tab1_chart2", param)


            'Me.Chart_Item(Chart1, dSet1.Tables(0), "sub_nm", "sub_rat")
            ' g10.DataSource = dSet1.Tables(0)
            chart1.Visible = True
            Chart2.Visible = True

            sbchart(chart1.Series(0), dSet1.Tables(0))
            sbchart_Wt(Chart2.Series(0), dSet1.Tables(0))

        Catch
            'ChartControl1.Series.Clear()
        End Try
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick


        Call OpenChart(g10.Text("itm_id"))
        itmcd.Text = g10.Text("itm_cd")
        itmNm.Text = g10.Text("itm_nm")



    End Sub

    Public Sub sbchart(ByVal Series As DevExpress.XtraCharts.Series, ByVal dt As DataTable)
        Dim dRows As DataRowCollection, dRow As DataRow
        dRows = dt.Rows


        Series.Points.Clear()
        Series.Name = "구성비율"

        Series.DataSource = dt


        For Each dRow In dRows

            Dim value As Double = 0



            If dRow("sub_rat") = 0 Then
                Continue For
            End If
            If ToStr(dRow("sub_rat")) = "" Then
                value = 0
            Else
                value = dRow("sub_rat")
            End If


            Dim point As New SeriesPoint(ToStr(dRow("sub_nm")), value)
            
            Series.Points.Add(point)


        Next
    End Sub
    Public Sub sbchart_Wt(ByVal Series As DevExpress.XtraCharts.Series, ByVal dt As DataTable)
        Dim dRows As DataRowCollection, dRow As DataRow
        dRows = dt.Rows


        Series.Points.Clear()
        Series.Name = "구성함량"

        Series.DataSource = dt


        For Each dRow In dRows

            Dim value As Double = 0



            If dRow("sub_wgt") = 0 Then
                Continue For
            End If
            If ToStr(dRow("sub_wgt")) = "" Then
                value = 0
            Else
                value = dRow("sub_wgt")
            End If


            Dim point As New SeriesPoint(ToStr(dRow("sub_nm")), value)

            Series.Points.Add(point)


        Next
    End Sub

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
End Class

