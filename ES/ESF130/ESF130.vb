Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESF130
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim P As New OpenParameters
        P.Add("@std_dtf", std_dtf.Text)
        P.Add("@std_dtt", std_dtt.Text)
        sbchart(Chart1.Series(0), "ESF130_Query1", P, "USD")
        sbchart(Chart1.Series(1), "ESF130_Query2", P, "JPY")
        sbchart(Chart1.Series(2), "ESF130_Query3", P, "CNY")
        sbchart(Chart1.Series(3), "ESF130_Query4", P, "EUR")
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Dim P As New OpenParameters
                P.Add("@std_dtf", std_dtf.Text)
                P.Add("@std_dtt", std_dtt.Text)
                sbchart(Chart1.Series(0), "ESF130_Query1", P, "USD")
                sbchart(Chart1.Series(1), "ESF130_Query2", P, "JPY")
                sbchart(Chart1.Series(2), "ESF130_Query3", P, "CNY")
                sbchart(Chart1.Series(3), "ESF130_Query4", P, "EUR")
        End Select

    End Sub

    Public Sub Open2()

    End Sub

    Private Sub ESF130_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim P As New OpenParameters
        'P.Add("@std_dtf", std_dtf.Text)
        'P.Add("@std_dtt", std_dtt.Text)
        'sbchart(Chart1.Series(0), "ESF130_Query1", P, "USD")
        'sbchart(Chart1.Series(1), "ESF130_Query2", P, "JPY")
        'sbchart(Chart1.Series(2), "ESF130_Query3", P, "CNY")
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
            If ToStr(dRow("value")) = "" Then
                value = 0
            Else
                value = dRow("value")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub
End Class
