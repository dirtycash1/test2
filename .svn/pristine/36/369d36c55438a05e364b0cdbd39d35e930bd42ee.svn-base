Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts

Public Class EIS100

    Private Sub EIS100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        sbchart(Chart.Series(0), "EIS100_Query", P, "매       출       액")
        sbchart(Chart.Series(1), "EIS100_Query1", P, "매   출   원     가")
        sbchart(Chart.Series(2), "EIS100_Query2", P, "매  출  총  이  익")
        sbchart(Chart.Series(3), "EIS100_Query3", P, "순       이       익")
        sbchart(Chart1.Series(0), "EIS100_Query4", P, "매출액추세비율")
        sbchart(Chart1.Series(1), "EIS100_Query5", P, "순이익추세비율")
    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = dRow("Amt")
            Dim point As New SeriesPoint(ToStr(dRow("base_year")), value)
            Series.Points.Add(point)
        Next
    End Sub
End Class
