Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESF110

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Dim P As New OpenParameters
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "0")
                sbchart(Chart1.Series(0), "ESF110_Query", P, "매 출 원 가")
                sbchart(Chart1.Series(1), "ESF110_Query1", P, "판매관리비")
                sbchart(Chart1.Series(2), "ESF110_Query2", P, "매 출 이 익")
                sbchart(Chart1.Series(3), "ESF110_Query3", P, "영 업 이 익")
                sbchart(Chart1.Series(4), "ESF110_Query4", P, "영업외수익")
                sbchart(Chart1.Series(5), "ESF110_Query5", P, "영업외비용")
                sbchart(Chart1.Series(6), "ESF110_Query6", P, "경 상 이 익")
                sbchart(Chart1.Series(7), "ESF110_Query7", P, "당기순이익")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "1")
                sbchart(Chart2.Series(0), "ESF110_Query", P, "매 출 원 가")
                sbchart(Chart2.Series(1), "ESF110_Query1", P, "판매관리비")
                sbchart(Chart2.Series(2), "ESF110_Query2", P, "매 출 이 익")
                sbchart(Chart2.Series(3), "ESF110_Query3", P, "영 업 이 익")
                sbchart(Chart2.Series(4), "ESF110_Query4", P, "영업외수익")
                sbchart(Chart2.Series(5), "ESF110_Query5", P, "영업외비용")
                sbchart(Chart2.Series(6), "ESF110_Query6", P, "경 상 이 익")
                sbchart(Chart2.Series(7), "ESF110_Query7", P, "당기순이익")

                P.Clear()
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_year", base_year.Text)
                P.Add("@gubn", "2")
                sbchart(Chart3.Series(0), "ESF110_Query", P, "매 출 원 가")
                sbchart(Chart3.Series(1), "ESF110_Query1", P, "판매관리비")
                sbchart(Chart3.Series(2), "ESF110_Query2", P, "매 출 이 익")
                sbchart(Chart3.Series(3), "ESF110_Query3", P, "영 업 이 익")
                sbchart(Chart3.Series(4), "ESF110_Query4", P, "영업외수익")
                sbchart(Chart3.Series(5), "ESF110_Query5", P, "영업외비용")
                sbchart(Chart3.Series(6), "ESF110_Query6", P, "경 상 이 익")
                sbchart(Chart3.Series(7), "ESF110_Query7", P, "당기순이익")
        End Select

    End Sub

    Private Sub ESF110_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "0")
        sbchart(Chart1.Series(0), "ESF110_Query", P, "매 출 원 가")
        sbchart(Chart1.Series(1), "ESF110_Query1", P, "판매관리비")
        sbchart(Chart1.Series(2), "ESF110_Query2", P, "매 출 이 익")
        sbchart(Chart1.Series(3), "ESF110_Query3", P, "영 업 이 익")
        sbchart(Chart1.Series(4), "ESF110_Query4", P, "영업외수익")
        sbchart(Chart1.Series(5), "ESF110_Query5", P, "영업외비용")
        sbchart(Chart1.Series(6), "ESF110_Query6", P, "경 상 이 익")
        sbchart(Chart1.Series(7), "ESF110_Query7", P, "당기순이익")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "1")
        sbchart(Chart2.Series(0), "ESF110_Query", P, "매 출 원 가")
        sbchart(Chart2.Series(1), "ESF110_Query1", P, "판매관리비")
        sbchart(Chart2.Series(2), "ESF110_Query2", P, "매 출 이 익")
        sbchart(Chart2.Series(3), "ESF110_Query3", P, "영 업 이 익")
        sbchart(Chart2.Series(4), "ESF110_Query4", P, "영업외수익")
        sbchart(Chart2.Series(5), "ESF110_Query5", P, "영업외비용")
        sbchart(Chart2.Series(6), "ESF110_Query6", P, "경 상 이 익")
        sbchart(Chart2.Series(7), "ESF110_Query7", P, "당기순이익")

        P.Clear()
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_year", base_year.Text)
        P.Add("@gubn", "2")
        sbchart(Chart3.Series(0), "ESF110_Query", P, "매 출 원 가")
        sbchart(Chart3.Series(1), "ESF110_Query1", P, "판매관리비")
        sbchart(Chart3.Series(2), "ESF110_Query2", P, "매 출 이 익")
        sbchart(Chart3.Series(3), "ESF110_Query3", P, "영 업 이 익")
        sbchart(Chart3.Series(4), "ESF110_Query4", P, "영업외수익")
        sbchart(Chart3.Series(5), "ESF110_Query5", P, "영업외비용")
        sbchart(Chart3.Series(6), "ESF110_Query6", P, "경 상 이 익")
        sbchart(Chart3.Series(7), "ESF110_Query7", P, "당기순이익")
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
