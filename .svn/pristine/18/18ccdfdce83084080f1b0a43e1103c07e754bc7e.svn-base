Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts
Imports System.Data

Public Class ESF200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Dim P As New OpenParameters
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "0")
                sbchart(Chart.Series(0), "ESF200_Query", P, "매    출    액")
                sbchart(Chart.Series(1), "ESF200_Query1", P, "재    료    비")
                sbchart(Chart.Series(2), "ESF200_Query2", P, "노    무    비")
                sbchart(Chart.Series(3), "ESF200_Query3", P, "제  조  경  비")
                sbchart(Chart.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
                sbchart(Chart.Series(5), "ESF200_Query5", P, "당기제품제조원가")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "1")
                sbchart(Chart1.Series(0), "ESF200_Query", P, "매    출    액")
                sbchart(Chart1.Series(1), "ESF200_Query1", P, "재    료    비")
                sbchart(Chart1.Series(2), "ESF200_Query2", P, "노    무    비")
                sbchart(Chart1.Series(3), "ESF200_Query3", P, "제  조  경  비")
                sbchart(Chart1.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
                sbchart(Chart1.Series(5), "ESF200_Query5", P, "당기제품제조원가")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "2")
                sbchart(Chart2.Series(0), "ESF200_Query", P, "매    출    액")
                sbchart(Chart2.Series(1), "ESF200_Query1", P, "재    료    비")
                sbchart(Chart2.Series(2), "ESF200_Query2", P, "노    무    비")
                sbchart(Chart2.Series(3), "ESF200_Query3", P, "제  조  경  비")
                sbchart(Chart2.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
                sbchart(Chart2.Series(5), "ESF200_Query5", P, "당기제품제조원가")

                sbchart2(ChartControl1.Series(0), "ESF200_Query6", P, "년별")
                sbchart2(ChartControl2.Series(0), "ESF200_Query7", P, "월별")

        End Select

    End Sub

    Private Sub ESF100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "0")
        sbchart(Chart.Series(0), "ESF200_Query", P, "매    출    액")
        sbchart(Chart.Series(1), "ESF200_Query1", P, "재    료    비")
        sbchart(Chart.Series(2), "ESF200_Query2", P, "노    무    비")
        sbchart(Chart.Series(3), "ESF200_Query3", P, "제  조  경  비")
        sbchart(Chart.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
        sbchart(Chart.Series(5), "ESF200_Query5", P, "당기제품제조원가")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "1")
        sbchart(Chart1.Series(0), "ESF200_Query", P, "매    출    액")
        sbchart(Chart1.Series(1), "ESF200_Query1", P, "재    료    비")
        sbchart(Chart1.Series(2), "ESF200_Query2", P, "노    무    비")
        sbchart(Chart1.Series(3), "ESF200_Query3", P, "제  조  경  비")
        sbchart(Chart1.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
        sbchart(Chart1.Series(5), "ESF200_Query5", P, "당기제품제조원가")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "2")
        sbchart(Chart2.Series(0), "ESF200_Query", P, "매    출    액")
        sbchart(Chart2.Series(1), "ESF200_Query1", P, "재    료    비")
        sbchart(Chart2.Series(2), "ESF200_Query2", P, "노    무    비")
        sbchart(Chart2.Series(3), "ESF200_Query3", P, "제  조  경  비")
        sbchart(Chart2.Series(4), "ESF200_Query4", P, "당기 총 제조비용")
        sbchart(Chart2.Series(5), "ESF200_Query5", P, "당기제품제조원가")

        sbchart2(ChartControl1.Series(0), "ESF200_Query6", P, "년별")
        sbchart2(ChartControl2.Series(0), "ESF200_Query7", P, "월별")

    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        Series.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("Amt")) = "" Then
                value = 0
            Else
                value = dRow("Amt") / unit_bc.Text
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub

    Public Sub sbchart2(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        'Series.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        'Series.PointOptions.ValueNumericOptions.Precision = 0
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("Amt")) = "" Then
                value = 0
            Else
                value = dRow("Amt") / unit_bc.Text
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub

End Class
