Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts

Public Class ESL100
    Private ColStart As Integer = 0, ChartType As Boolean = True 'True:V / False:H
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        ColStart = g10.ColumnCount
        Open_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New

            Case MenuType.Open
                Open_Form()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Init_Title()
            Dim dSet As DataSet = OpenDataSet("esl100_g10")
            If Not IsEmpty(dSet) Then g10.DataSet = dSet
            ChartCall2()
            ChartCall1(dSet.Tables(1).Rows)
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frdt As Date = ToFirstDate(std_dt.Text), todt As Date = std_dt.Text, stddt As Date
        Dim arr(1, 0) As String, inx As Integer = 0, Dt As String = ""
        stddt = DateAdd(DateInterval.Day, -1, frdt)
        Do While stddt < todt
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다
            stddt = DateAdd(DateInterval.Day, 1, stddt)
            Dt = Microsoft.VisualBasic.Day(stddt)
            arr(0, inx) = Dt           'FieldName 으로 사용된다
            arr(1, inx) = Dt & "일"           'Title로 사용된다
            inx += 1
        Loop

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "amt")

        'Master 부분
        g10.GridColumn("ty").IsMasterKey = True
        g10.GridColumn("tot_amt").IsMasterData = True

        'Detail 부분
        g10.GridColumn("dt").IsDetailKey = True
        g10.GridColumn("amt").IsDetailData = True

    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

#Region " 2. char "
    Private Sub ChartCall1(GetDataRows As DataRowCollection)
        'If ToStr(g10.Text("cust_nm")) <> "소계" Then
        chart1.Series.Clear()
        If GetDataRows.Count <= 0 Then Exit Sub

        chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        If SplitContainer2.Orientation = Orientation.Vertical Then
            Me.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart1.Legend.EquallySpacedItems = False
            Me.chart1.Legend.Margins.Bottom = 30
            Me.chart1.Legend.Margins.Top = 11
            Me.chart1.Legend.Font = New System.Drawing.Font("Tahoma", 8.0!)
            ChartType = True
        Else
            Me.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
            Me.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
            Me.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
            Me.chart1.Legend.EquallySpacedItems = False
            Me.chart1.Legend.Margins.Bottom = 5
            Me.chart1.Legend.Margins.Top = 5
            Me.chart1.Legend.Font = New System.Drawing.Font("Tahoma", 10.0!)
            ChartType = False
        End If

        AddSeir2(chart1, GetDataRows.Item(0).Item("cap1"), ToDec(GetDataRows.Item(0).Item("s_amt1")), , True) '내수
        AddSeir2(chart1, GetDataRows.Item(0).Item("cap1"), ToDec(GetDataRows.Item(0).Item("s_amt2")), False, True) '수출
        AddSeir2(chart1, GetDataRows.Item(0).Item("cap2"), ToDec(GetDataRows.Item(0).Item("p_amt")))
        AddSeir2(chart1, GetDataRows.Item(0).Item("cap3"), ToDec(GetDataRows.Item(0).Item("mp_amt")))
        AddSeir2(chart1, GetDataRows.Item(0).Item("cap4"), g10.ToDec("tot_amt"))

        AddSeir(chart1, "", ToDec(GetDataRows.Item(0).Item("s_amt")), True)
        AddSeir(chart1, "", 0)
        AddSeir(chart1, "", 0)
        AddSeir(chart1, "", 0)
    End Sub

    Private Sub AddSeir2(GetChart As DevExpress.XtraCharts.ChartControl, GetTitle As String, GetVal As Double, _
                         Optional LegendShow As Boolean = True, _
                         Optional ColorMarge As Boolean = False)

        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.SideBySideStackedBar)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.ShowInLegend = LegendShow

        'Dim view As ISupportStackedGroup = TryCast(Series.View, ISupportStackedGroup)
        'view.StackedGroup = GetTitle

        Dim SideBySideStackedBarSeriesView As DevExpress.XtraCharts.SideBySideStackedBarSeriesView = Series.View
        SideBySideStackedBarSeriesView.Shadow.Visible = True
        SideBySideStackedBarSeriesView.StackedGroupSerializable = GetTitle

        If ColorMarge Then
            SideBySideStackedBarSeriesView.Border.Color = System.Drawing.Color.Blue
            If LegendShow = False Then
                SideBySideStackedBarSeriesView.Color = System.Drawing.Color.CornflowerBlue
            Else
                SideBySideStackedBarSeriesView.Color = System.Drawing.Color.RoyalBlue
            End If
            SideBySideStackedBarSeriesView.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        End If

        If SplitContainer2.Orientation = Orientation.Vertical Then
            Series.Label.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Else
            Series.Label.Font = New System.Drawing.Font("Tahoma", 10.0!)
        End If

        Series.Name = GetTitle
        GetChart.Series.Add(Series)
        Dim point As New SeriesPoint("A", GetVal)
        Series.Points.Add(point)

    End Sub

    Private Sub AddSeir(GetChart As DevExpress.XtraCharts.ChartControl, GetTitle As String, GetVal As Double, Optional SeriesLabel As Boolean = False)

        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Bar)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Dim SideBySideBarSeriesView As DevExpress.XtraCharts.SideBySideBarSeriesView = Series.View
        SideBySideBarSeriesView.Shadow.Visible = False
        SideBySideBarSeriesView.Border.Visible = False
        SideBySideBarSeriesView.Color = System.Drawing.Color.Transparent
        SideBySideBarSeriesView.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid

        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Dim SideBySideBarSeriesLabel As DevExpress.XtraCharts.SideBySideBarSeriesLabel = Series.Label
        SideBySideBarSeriesLabel.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top
        Series.ShowInLegend = False
        Series.Label.Visible = SeriesLabel
        If SeriesLabel Then
            SideBySideBarSeriesLabel.LineColor = System.Drawing.Color.RoyalBlue
            SideBySideBarSeriesLabel.Border.Color = System.Drawing.Color.RoyalBlue
            SideBySideBarSeriesLabel.TextColor = System.Drawing.Color.RoyalBlue
        End If
        'Dim PaneAnchorPoint As DevExpress.XtraCharts.PaneAnchorPoint = New DevExpress.XtraCharts.PaneAnchorPoint()
        'PaneAnchorPoint.AxisXCoordinate.AxisValueSerializable = "A"
        'PaneAnchorPoint.AxisYCoordinate.AxisValueSerializable = GetVal
        'Dim FreePosition1 As DevExpress.XtraCharts.FreePosition = New DevExpress.XtraCharts.FreePosition()
        'FreePosition1.DockTargetName = "Default Pane"
        'FreePosition1.InnerIndents.Left = 0
        'FreePosition1.InnerIndents.Top = 0

        'Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        'TextAnnotation1.AnchorPoint = PaneAnchorPoint1
        'TextAnnotation1.Name = "Text Annotation 1"

        'TextAnnotation1.ShapePosition = FreePosition1
        'Me.chart1.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
        'TextAnnotation1.Visible = False

        If SplitContainer2.Orientation = Orientation.Vertical Then
            Series.Label.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Else
            Series.Label.Font = New System.Drawing.Font("Tahoma", 10.0!)
        End If

        Series.Name = GetTitle
        GetChart.Series.Add(Series)
        Dim point As New SeriesPoint("A", GetVal)
        Series.Points.Add(point)

    End Sub

    Private Sub ChartCall2()
        chart2.Series.Clear()
        If g10.RowCount <= 0 Then Exit Sub

        Dim Col As Integer

        Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
        Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series.PointOptions.ValueNumericOptions.Precision = 0
        Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Series.ArgumentDataMember = "Name"
        'sr.ValueDataMembers[0] = "CurrentDose"
        Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
        Series.Label.ResolveOverlappingMinIndent = 5
        Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
        Dim LineSeriesView As DevExpress.XtraCharts.LineSeriesView = Series.View
        LineSeriesView.Shadow.Visible = True
        LineSeriesView.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        If SplitContainer2.Orientation = Orientation.Vertical Then
            LineSeriesView.LineMarkerOptions.Size = 15
            LineSeriesView.LineStyle.Thickness = 3
        Else
            LineSeriesView.LineMarkerOptions.Size = 10
            LineSeriesView.LineStyle.Thickness = 2
        End If

        LineSeriesView.Shadow.Visible = True

        Series.Name = ""
        chart2.Series.Add(Series)
        chart2.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default

        Dim XyDiagram As DevExpress.XtraCharts.XYDiagram = chart2.Diagram
        XyDiagram.AxisX.GridLines.Visible = True
        XyDiagram.AxisX.Interlaced = True
        XyDiagram.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram.AxisX.Range.SideMarginsEnabled = True
        XyDiagram.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram.AxisY.Range.SideMarginsEnabled = True
        XyDiagram.AxisY.VisibleInPanesSerializable = "-1"

        For Col = ColStart To g10.ColumnCount - 1
            Dim value As Double = 0
            If ToStr(g10.Text(Col)) = "" Then
                value = 0
            Else
                value = Int(g10.Text(Col))
            End If
            Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
            Series.Points.Add(point)
        Next
        'ChartCall2()
    End Sub
#End Region

    Private Sub Chart1Legend()

        If SplitContainer2.Orientation = Orientation.Horizontal Then
            Me.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.RightOutside
            Me.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Top
            Me.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.TopToBottom
            Me.chart1.Legend.EquallySpacedItems = False
            Me.chart1.Legend.Margins.Bottom = 5
            Me.chart1.Legend.Margins.Top = 5
            Me.chart1.Legend.Font = New System.Drawing.Font("Tahoma", 10.0!)

            For Col As Integer = 0 To Me.chart1.Series.Count - 1
                'Me.chart1.Series(Col).PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
                Me.chart1.Series(Col).Label.Font = New System.Drawing.Font("Tahoma", 10.0!)
                'Dim SideBySideBarSeriesLabel As DevExpress.XtraCharts.SideBySideBarSeriesLabel = Me.chart1.Series(Col).Label
                'SideBySideBarSeriesLabel.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
            Next

            Dim LineSeriesView As DevExpress.XtraCharts.LineSeriesView = chart2.Series(0).View
            LineSeriesView.LineMarkerOptions.Size = 10
            LineSeriesView.LineStyle.Thickness = 2
            ChartType = False
        Else

            Me.chart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart1.Legend.EquallySpacedItems = False
            Me.chart1.Legend.Margins.Bottom = 30
            Me.chart1.Legend.Margins.Top = 11
            Me.chart1.Legend.Font = New System.Drawing.Font("Tahoma", 8.0!)

            For Col As Integer = 0 To Me.chart1.Series.Count - 1
                Me.chart1.Series(Col).Label.Font = New System.Drawing.Font("Tahoma", 8.0!)
                'Dim SideBySideBarSeriesLabel As DevExpress.XtraCharts.SideBySideBarSeriesLabel = Me.chart1.Series(Col).Label
                'SideBySideBarSeriesLabel.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
            Next

            Dim LineSeriesView As DevExpress.XtraCharts.LineSeriesView = chart2.Series(0).View
            LineSeriesView.LineMarkerOptions.Size = 15
            LineSeriesView.LineStyle.Thickness = 3

            ChartType = True
        End If


    End Sub

    Private Sub chart_SizeChanged(sender As Object, e As System.EventArgs) Handles chart1.SizeChanged
        ' ChartType As Boolean 'True:V / False:H
        If (SplitContainer2.Orientation = Orientation.Horizontal And ChartType) Or _
            (SplitContainer2.Orientation = Orientation.Vertical And ChartType = False) Then
            Chart1Legend()
        End If
    End Sub
End Class
