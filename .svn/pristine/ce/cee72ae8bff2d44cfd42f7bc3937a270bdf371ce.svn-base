Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraCharts

Public Class ESH100
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim P As New OpenParameters
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            P.Add("@div_cd", div_cd.Text)
            P.Add("@base_month", base_month.Text)
            dSet = Me.OpenDataSet("ESH100_Query1", P)
            dRows = dSet.Tables(0).Rows
            Dim value As Double = 0
            For Each dRow In dRows
                If ToStr(dRow("vales")) = "" Then
                    value = 0
                Else
                    value = dRow("vales")
                End If
            Next
            ArcScaleComponent4.Value = value
            SimpleButton1.Text = CStr(value) & "(백만원)"

            '월별인건비
            sbchart(ChartControl1.Series(0), "ESH100_Query3", P, "인원수")
            sbchart(ChartControl2.Series(0), "ESH100_Query2", P, "인건비")
            sbchart(ChartControl3.Series(0), "ESH100_Query6", P, "성별 분포")
            sbchart(ChartControl4.Series(0), "ESH100_Query4", P, "직위별 분포")
            sbchart(ChartControl5.Series(0), "ESH100_Query5", P, "학력별 분포")
        Catch ex As Exception
        End Try
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Try
                    Dim P As New OpenParameters
                    Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
                    P.Add("@div_cd", div_cd.Text)
                    P.Add("@base_month", base_month.Text)
                    dSet = Me.OpenDataSet("ESH100_Query1", P)
                    dRows = dSet.Tables(0).Rows
                    Dim value As Double = 0
                    For Each dRow In dRows
                        If ToStr(dRow("vales")) = "" Then
                            value = 0
                        Else
                            value = dRow("vales")
                        End If
                    Next
                    ArcScaleComponent4.Value = value
                    SimpleButton1.Text = CStr(value) & "(백만원)"

                    '월별인건비

                    sbchart(ChartControl1.Series(0), "ESH100_Query3", P, "인원수")
                    sbchart(ChartControl2.Series(0), "ESH100_Query2", P, "인건비")
                    sbchart(ChartControl3.Series(0), "ESH100_Query6", P, "성별 분포")
                    sbchart(ChartControl4.Series(0), "ESH100_Query4", P, "직위별 분포")
                    sbchart(ChartControl5.Series(0), "ESH100_Query5", P, "학력별 분포")
                Catch ex As Exception
                End Try
        End Select

    End Sub

    Private Sub ESH100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim P As New OpenParameters
            P.Add("@div_cd", div_cd.Text)
            P.Add("@base_month", base_month.Text)
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            dSet = Me.OpenDataSet("ESH100_Query", P)
            dRows = dSet.Tables(0).Rows
            Dim value As Double = 0
            For Each dRow In dRows
                If ToStr(dRow("vales")) = "" Then
                    value = 0
                Else
                    value = dRow("vales")
                End If
            Next
            ArcScaleComponent5.Value = value
            SimpleButton3.Text = CStr(value) & "(명)"
            P.Add("@div_cd", div_cd.Text)
            P.Add("@base_month", base_month.Text)
            dSet = Me.OpenDataSet("ESH100_Query1", P)
            dRows = dSet.Tables(0).Rows
            value = 0
            For Each dRow In dRows
                If ToStr(dRow("vales")) = "" Then
                    value = 0
                Else
                    value = dRow("vales")
                End If
            Next
            ArcScaleComponent4.Value = value
            SimpleButton1.Text = CStr(value) & "(백만원)"
            '월별인건비
            sbchart(ChartControl1.Series(0), "ESH100_Query3", P, "인원수")
            sbchart(ChartControl2.Series(0), "ESH100_Query2", P, "인건비")
            sbchart(ChartControl3.Series(0), "ESH100_Query6", P, "성별 분포")
            sbchart(ChartControl4.Series(0), "ESH100_Query4", P, "직위별 분포")
            sbchart(ChartControl5.Series(0), "ESH100_Query5", P, "학력별 분포")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub sbchart(ByVal Series As Series, ByVal WorkSetCode As String, ByVal P As OpenParameters, ByVal series_Name As String)
        Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
        dSet = Me.OpenDataSet(WorkSetCode, P)
        dRows = dSet.Tables(0).Rows
        Series.Points.Clear()
        Series.Name = series_Name
        For Each dRow In dRows
            Dim value As Double = 0
            If ToStr(dRow("vales")) = "" Then
                value = 0
            Else
                value = dRow("vales")
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
                value = dRow("Amt")
            End If
            Dim point As New SeriesPoint(ToStr(dRow("code")), value)
            Series.Points.Add(point)
        Next
    End Sub
  
End Class
