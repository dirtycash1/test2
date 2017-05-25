<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChartView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GanttDiagram1 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
        Dim ConstantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeBarSeriesLabel1 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim OverlappedGanttSeriesView1 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RangeBarSeriesLabel2 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim OverlappedGanttSeriesView2 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim RangeBarSeriesLabel3 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
        Dim OverlappedGanttSeriesView3 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.ChartControl = New DevExpress.XtraCharts.ChartControl()
        CType(Me.ChartControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(GanttDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl
        '
        GanttDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        GanttDiagram1.AxisX.Range.SideMarginsEnabled = True
        GanttDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        ConstantLine1.AxisValueSerializable = "08/28/2011 00:00:00.000"
        ConstantLine1.Name = "today"
        ConstantLine1.ShowInLegend = False
        GanttDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {ConstantLine1})
        GanttDiagram1.AxisY.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Month
        GanttDiagram1.AxisY.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Week
        GanttDiagram1.AxisY.Label.Angle = -30
        GanttDiagram1.AxisY.Label.Antialiasing = True
        GanttDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        GanttDiagram1.AxisY.Range.SideMarginsEnabled = True
        GanttDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl.Diagram = GanttDiagram1
        Me.ChartControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
        Me.ChartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.ChartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.ChartControl.Legend.EquallySpacedItems = False
        Me.ChartControl.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl.Name = "ChartControl"
        RangeBarSeriesLabel1.BackColor = System.Drawing.Color.Transparent
        RangeBarSeriesLabel1.Border.Color = System.Drawing.Color.Transparent
        RangeBarSeriesLabel1.Border.Visible = False
        RangeBarSeriesLabel1.Position = DevExpress.XtraCharts.RangeBarLabelPosition.Center
        RangeBarSeriesLabel1.TextColor = System.Drawing.Color.Blue
        Series1.Label = RangeBarSeriesLabel1
        Series1.Name = "Planned"
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        OverlappedGanttSeriesView1.Shadow.Visible = True
        Series1.View = OverlappedGanttSeriesView1
        RangeBarSeriesLabel2.BackColor = System.Drawing.Color.Transparent
        RangeBarSeriesLabel2.Border.Color = System.Drawing.Color.Transparent
        RangeBarSeriesLabel2.Border.Visible = False
        RangeBarSeriesLabel2.Position = DevExpress.XtraCharts.RangeBarLabelPosition.Center
        RangeBarSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        RangeBarSeriesLabel2.TextColor = System.Drawing.Color.Black
        Series2.Label = RangeBarSeriesLabel2
        Series2.Name = "Completed"
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        OverlappedGanttSeriesView2.BarWidth = 0.3R
        OverlappedGanttSeriesView2.Shadow.Visible = True
        Series2.View = OverlappedGanttSeriesView2
        Me.ChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartControl.SeriesTemplate.Label = RangeBarSeriesLabel3
        Me.ChartControl.SeriesTemplate.View = OverlappedGanttSeriesView3
        Me.ChartControl.Size = New System.Drawing.Size(840, 475)
        Me.ChartControl.TabIndex = 1
        ChartTitle1.Text = "Project 진행현황"
        ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'ChartView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 475)
        Me.Controls.Add(Me.ChartControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ChartView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Project 진행현황"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(GanttDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChartControl As DevExpress.XtraCharts.ChartControl
End Class
