Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESF100

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    Me.Open()

    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Dim P As New OpenParameters
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "0")
                P.Add("@unit_bc", unit_bc.Text)
                sbchart(Chart.Series(0), "ESF100_Query", P, "매       출       액")
                sbchart(Chart.Series(1), "ESF100_Query1", P, "매   출   원     가")
                sbchart(Chart.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
                sbchart(Chart.Series(3), "ESF100_Query3", P, "순       이       익")
                sbchart(Chart1.Series(0), "ESF100_Query4", P, "매출액추세비율")
                sbchart(Chart1.Series(1), "ESF100_Query5", P, "순이익추세비율")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "1")
                P.Add("@unit_bc", unit_bc.Text)
                sbchart(Chart2.Series(0), "ESF100_Query", P, "매       출       액")
                sbchart(Chart2.Series(1), "ESF100_Query1", P, "매   출   원     가")
                sbchart(Chart2.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
                sbchart(Chart2.Series(3), "ESF100_Query3", P, "순       이       익")
                sbchart(Chart3.Series(0), "ESF100_Query4", P, "매출액추세비율")
                sbchart(Chart3.Series(1), "ESF100_Query5", P, "순이익추세비율")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "2")
                P.Add("@unit_bc", unit_bc.Text)
                sbchart(Chart4.Series(0), "ESF100_Query", P, "매       출       액")
                sbchart(Chart4.Series(1), "ESF100_Query1", P, "매   출   원     가")
                sbchart(Chart4.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
                sbchart(Chart4.Series(3), "ESF100_Query3", P, "순       이       익")
                sbchart(Chart5.Series(0), "ESF100_Query4", P, "매출액추세비율")
                sbchart(Chart5.Series(1), "ESF100_Query5", P, "순이익추세비율")
        End Select

    End Sub

    Private Sub ESF100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "0")
        P.Add("@unit_bc", unit_bc.Text)
        sbchart(Chart.Series(0), "ESF100_Query", P, "매       출       액")
        sbchart(Chart.Series(1), "ESF100_Query1", P, "매   출   원     가")
        sbchart(Chart.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
        sbchart(Chart.Series(3), "ESF100_Query3", P, "순       이       익")
        sbchart(Chart1.Series(0), "ESF100_Query4", P, "매출액추세비율")
        sbchart(Chart1.Series(1), "ESF100_Query5", P, "순이익추세비율")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "1")
        P.Add("@unit_bc", unit_bc.Text)
        sbchart(Chart2.Series(0), "ESF100_Query", P, "매       출       액")
        sbchart(Chart2.Series(1), "ESF100_Query1", P, "매   출   원     가")
        sbchart(Chart2.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
        sbchart(Chart2.Series(3), "ESF100_Query3", P, "순       이       익")
        sbchart(Chart3.Series(0), "ESF100_Query4", P, "매출액추세비율")
        sbchart(Chart3.Series(1), "ESF100_Query5", P, "순이익추세비율")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "2")
        P.Add("@unit_bc", unit_bc.Text)
        sbchart(Chart4.Series(0), "ESF100_Query", P, "매       출       액")
        sbchart(Chart4.Series(1), "ESF100_Query1", P, "매   출   원     가")
        sbchart(Chart4.Series(2), "ESF100_Query2", P, "매  출  총  이  익")
        sbchart(Chart4.Series(3), "ESF100_Query3", P, "순       이       익")
        sbchart(Chart5.Series(0), "ESF100_Query4", P, "매출액추세비율")
        sbchart(Chart5.Series(1), "ESF100_Query5", P, "순이익추세비율")
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
                value = dRow("Amt")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next

    End Sub

End Class
