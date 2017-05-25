Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESF120

    Private Sub ESF120_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.RowHeight = 50
        Dim P As New OpenParameters
        P.Add("@div_cd", div_cd.Text)
        P.Add("@base_month", base_month.Text)
        sbchart(Chart1.Series(0), "ESF120_Query", P, "전월")
        sbchart1(Chart1.Series(1), "ESF120_Query", P, "당월")
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Dim P As New OpenParameters
                P.Add("@div_cd", div_cd.Text)
                P.Add("@base_month", base_month.Text)
                sbchart(Chart1.Series(0), "ESF120_Query", P, "전월")
                sbchart1(Chart1.Series(1), "ESF120_Query", P, "당월")
                Me.Open()
        End Select

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
            Dim point As New SeriesPoint(ToStr(dRow("grp_nm2")), value)
            Series.Points.Add(point)
        Next
    End Sub

    Public Sub sbchart1(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        Series.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("Amt1")) = "" Then
                value = 0
            Else
                value = dRow("Amt1")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("grp_nm2")), value)
            Series.Points.Add(point)
        Next
    End Sub
End Class
