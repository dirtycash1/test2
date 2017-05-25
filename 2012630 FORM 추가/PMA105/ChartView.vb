Imports DevExpress.XtraCharts

Public Class ChartView

    Public Sub New(ByRef dataRows As Data.DataRowCollection)

        ' This call is required by the designer.
        InitializeComponent()

        SetChartControl(dataRows)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SetChartControl(ByRef dataRows As Data.DataRowCollection)

        Dim diagram As XYDiagram = CType(ChartControl.Diagram, XYDiagram)
        diagram.AxisY.ConstantLines(0).AxisValue = DateTime.Today

        ChartControl.Titles(0).Text = dataRows(0)("project_nm") + "진행현황"

        Dim count = dataRows.Count

        Dim total_result_SeriesPoints As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint()
        Dim plan_SeriesPoints() As DevExpress.XtraCharts.SeriesPoint

        Dim result_SeriesPointList As System.Collections.Generic.List(Of DevExpress.XtraCharts.SeriesPoint) =
                                        New System.Collections.Generic.List(Of DevExpress.XtraCharts.SeriesPoint)
        Dim result_RowDataRateList As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)
        Dim result_SeriesPoints() As DevExpress.XtraCharts.SeriesPoint

        Dim result_TextAnnotation() As DevExpress.XtraCharts.TextAnnotation

        ReDim plan_SeriesPoints(count - 1)

        '실행일은 Null일수 있음.
        For i = 0 To count - 1 Step 1

            plan_SeriesPoints(i) = CreateSeriesPoint(dataRows(i)("pso_nm"), dataRows(i)("plan_mindt"), dataRows(i)("plan_maxdt"), 0)
            'plan_TextAnnotation(i) = CreateTextAnnotation(ChartControl.Series(0).SeriesID, plan_SeriesPoints(i).SeriesPointID, dataRows(i)("rate"))
            '전체진행율
            If i = 0 Then
                ChartControl.Series(0).Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {CreateSeriesPoint("총진행율", dataRows(i)("total_plan_mindt"), dataRows(i)("total_plan_maxdt"), 0)})

                If dataRows(i)("total_work_mindt") Is DBNull.Value OrElse dataRows(i)("total_work_maxdt") Is DBNull.Value Then
                    Continue For
                End If
                total_result_SeriesPoints = CreateSeriesPoint("총진행율", dataRows(i)("total_work_mindt"), dataRows(i)("total_work_maxdt"), 0)
                ChartControl.Series(1).Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {total_result_SeriesPoints})
            End If

            If dataRows(i)("work_mindt") Is DBNull.Value OrElse dataRows(i)("work_maxdt") Is DBNull.Value Then
                Continue For
            End If

            result_SeriesPointList.Add(CreateSeriesPoint(dataRows(i)("pso_nm"), dataRows(i)("work_mindt"), dataRows(i)("work_maxdt"), 0))
            result_RowDataRateList.Add(dataRows(i)("rate"))
        Next

        count = result_SeriesPointList.Count
        ReDim result_SeriesPoints(count - 1)
        ReDim result_TextAnnotation(count - 1)

        For i = 0 To count - 1 Step 1
            result_SeriesPoints(i) = result_SeriesPointList(i)
        Next

        ChartControl.Series(0).Points.AddRange(plan_SeriesPoints)
        ChartControl.Series(1).Points.AddRange(result_SeriesPoints)

        If total_result_SeriesPoints.IsEmpty = False Then
            ChartControl.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {CreateTextAnnotation(total_result_SeriesPoints, dataRows(0)("total_rate"))})
        End If

        For i = 0 To count - 1 Step 1
            result_TextAnnotation(i) = CreateTextAnnotation(result_SeriesPoints(i), result_RowDataRateList(i))
        Next

        ChartControl.AnnotationRepository.AddRange(result_TextAnnotation)

        'plan_SeriesPoints(1).Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(0)})
    End Sub


    Private Function CreateSeriesPoint(ByVal title As String, ByVal value1 As DateTime, ByVal value2 As DateTime,
                                       ByVal isTaskLink As Boolean) As DevExpress.XtraCharts.SeriesPoint
        Dim seriesPoint As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(title, New Object() {CType(value1, Object), CType(value2, Object)}, 0)

        If isTaskLink Then
            seriesPoint.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(0)})
        End If

        Return seriesPoint
    End Function


    Private Function CreateTextAnnotation(ByVal seriesPoint As SeriesPoint, ByVal value As String) As DevExpress.XtraCharts.TextAnnotation

        Dim textAnnotation As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        ' Dim seriesPointAnchorPoint As DevExpress.XtraCharts.SeriesPointAnchorPoint = New DevExpress.XtraCharts.SeriesPointAnchorPoint(seriesPoint)
        Dim relativePosition As DevExpress.XtraCharts.RelativePosition = New DevExpress.XtraCharts.RelativePosition()

        relativePosition.Angle = 100.0R
        relativePosition.ConnectorLength = 20.0R

        textAnnotation.AnchorPoint = New SeriesPointAnchorPoint(seriesPoint)
        textAnnotation.ShapePosition = relativePosition

        textAnnotation.Text = value
        textAnnotation.BackColor = Color.Transparent
        Return textAnnotation

    End Function

    Private Sub ChartControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartControl.DoubleClick
        Me.Close()
    End Sub
End Class