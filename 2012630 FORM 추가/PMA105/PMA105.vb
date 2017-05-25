Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Imports DevExpress.XtraCharts
'Imports DevExpress.XtraGrid.Views.Grid

Public Class PMA105

    Dim chartDataRows As Data.DataRowCollection

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Open()

    End Sub

    Public Overrides Sub Open()

        MyBase.Open()

    End Sub


    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        If g10.Text("prj_cd") = "" Then
            ClearChartData()
            Return
        End If

        'Dim p As New OpenParameters
        'p.Add("@project_id", pjt_id)

        Dim chartDataSet As Data.DataSet = Me.OpenDataSet("pma105_chart")

        chartDataRows = chartDataSet.Tables(0).Rows
        SetChartControl(chartDataSet.Tables(0).Rows)
    End Sub

    Private Sub SetChartControl(ByRef dataRows As Data.DataRowCollection)
        ClearChartData()

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

    Private Sub ClearChartData()

        Dim count As Integer

        For Each series As Series In ChartControl.Series
            count = series.Points.Count
            For i = 0 To count - 1 Step 1
                series.Points.Remove(series.Points(0))
            Next
        Next

        count = ChartControl.AnnotationRepository.Count

        For i = 0 To count - 1 Step 1
            ChartControl.AnnotationRepository.Remove(ChartControl.AnnotationRepository.Item(i))
        Next

    End Sub


    'Private Function CreateRangeBarSeriesLabel() As DevExpress.XtraCharts.RangeBarSeriesLabel
    '    Dim rangeBarSeriesLabel As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
    '    rangeBarSeriesLabel.Position = DevExpress.XtraCharts.RangeBarLabelPosition.Center
    '    rangeBarSeriesLabel.TextColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    '    Return rangeBarSeriesLabel
    'End Function

    Private Function CreateSeriesPoint(ByVal title As String, ByVal value1 As DateTime, ByVal value2 As DateTime,
                                       ByVal isTaskLink As Boolean) As DevExpress.XtraCharts.SeriesPoint
        Dim seriesPoint As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint(title, New Object() {CType(value1, Object), CType(value2, Object)}, 0)

        If isTaskLink Then
            seriesPoint.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(0)})
        End If

        Return seriesPoint
    End Function

    'Private Function CreateTextAnnotation(ByVal seriesID As Integer, ByVal seriesPointID As Integer, ByVal value As String) As DevExpress.XtraCharts.TextAnnotation
    ''    Dim textAnnotation As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
    ''    Dim seriesPointAnchorPoint As DevExpress.XtraCharts.SeriesPointAnchorPoint = New DevExpress.XtraCharts.SeriesPointAnchorPoint()
    ''    Dim relativePosition As DevExpress.XtraCharts.RelativePosition = New DevExpress.XtraCharts.RelativePosition()

    ''    relativePosition.Angle = 100.0R
    ''    relativePosition.ConnectorLength = 50.0R

    ''    seriesPointAnchorPoint.SeriesID = seriesID
    ''    seriesPointAnchorPoint.SeriesPointID = seriesPointID

    ''    textAnnotation.AnchorPoint = seriesPointAnchorPoint
    ''    textAnnotation.ShapePosition = relativePosition

    ''    textAnnotation.Text = value
    ''    Return textAnnotation

    ''End Function

    Private Function CreateTextAnnotation(ByVal seriesPoint As SeriesPoint, ByVal value As String) As DevExpress.XtraCharts.TextAnnotation

        Dim textAnnotation As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        ' Dim seriesPointAnchorPoint As DevExpress.XtraCharts.SeriesPointAnchorPoint = New DevExpress.XtraCharts.SeriesPointAnchorPoint(seriesPoint)
        Dim relativePosition As DevExpress.XtraCharts.RelativePosition = New DevExpress.XtraCharts.RelativePosition()

        relativePosition.Angle = 100.0R
        relativePosition.ConnectorLength = 20.0R

        textAnnotation.AnchorPoint = New SeriesPointAnchorPoint(seriesPoint)
        textAnnotation.ShapePosition = relativePosition

        textAnnotation.Text = value
        Return textAnnotation

    End Function

    Private Sub ChartControl_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartControl.DoubleClick
        If chartDataRows Is Nothing Then
            Return
        End If

        Dim chartView As ChartView = New ChartView(chartDataRows)
        chartView.ShowDialog()
    End Sub

    'Public Sub Open2(ByVal pjt_id As String)
    '    Try
    '        Dim p As New OpenParameters
    '        p.Add("@pjt_id", pjt_id)
    '        Dim dSet As DataSet = MyBase.OpenDataSet("dma700_g10_jump", p)

    '        If dSet.Tables(0).Rows.Count = 0 Then
    '            Me.GridControl1.DataSource = Nothing
    '            ClearChartData()
    '        Else
    '            Me.GridControl1.DataSource = dSet.Tables(0)
    '            GridView_FocusedRowChanged(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub

    'Private Sub btn_DMA340_Click(sender As System.Object, e As System.EventArgs) Handles btn_DMA340.Click
    '    Dim menuName As String = "DMA340"
    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '    ctr.Open2(GridView.GetFocusedDataRow().Item("pjt_nm"), GridView.GetFocusedDataRow().Item("pjt_id"))
    'End Sub


End Class
