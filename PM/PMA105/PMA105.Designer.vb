<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMA105
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.prj_bc = New Frame7.eCheckCombo()
        Me.prj_cd = New Frame7.eText()
        Me.btn_DMA340 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.ChartControl = New DevExpress.XtraCharts.ChartControl()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 57
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.prj_cd)
        Me.EPanel1.Controls.Add(Me.prj_bc)
        Me.EPanel1.Controls.Add(Me.btn_DMA340)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 57)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     Project 조회"
        '
        'prj_bc
        '
        Me.prj_bc.Location = New System.Drawing.Point(256, 28)
        Me.prj_bc.Name = "prj_bc"
        Me.prj_bc.Size = New System.Drawing.Size(272, 21)
        Me.prj_bc.TabIndex = 8
        Me.prj_bc.Title = "Project 구분"
        '
        'prj_cd
        '
        Me.prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_cd.Location = New System.Drawing.Point(12, 28)
        Me.prj_cd.Name = "prj_cd"
        Me.prj_cd.Size = New System.Drawing.Size(232, 21)
        Me.prj_cd.TabIndex = 2
        Me.prj_cd.Title = "Project명(%)"
        Me.prj_cd.TitleWidth = 90
        '
        'btn_DMA340
        '
        Me.btn_DMA340.Location = New System.Drawing.Point(860, 28)
        Me.btn_DMA340.Name = "btn_DMA340"
        Me.btn_DMA340.Size = New System.Drawing.Size(142, 23)
        Me.btn_DMA340.TabIndex = 6
        Me.btn_DMA340.Text = "APQP 진행현황 조회"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1000, 629)
        Me.SplitContainer2.SplitterDistance = 333
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(333, 629)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Project List"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(329, 604)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.ChartControl)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(663, 629)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     Project 진행 현황"
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
        Me.ChartControl.Location = New System.Drawing.Point(2, 23)
        Me.ChartControl.Name = "ChartControl"
        RangeBarSeriesLabel1.Position = DevExpress.XtraCharts.RangeBarLabelPosition.Center
        RangeBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        RangeBarSeriesLabel1.Visible = False
        Series1.Label = RangeBarSeriesLabel1
        Series1.Name = "Planned"
        Series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        OverlappedGanttSeriesView1.Shadow.Visible = True
        Series1.View = OverlappedGanttSeriesView1
        RangeBarSeriesLabel2.Position = DevExpress.XtraCharts.RangeBarLabelPosition.Center
        RangeBarSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        RangeBarSeriesLabel2.Visible = False
        Series2.Label = RangeBarSeriesLabel2
        Series2.Name = "Completed"
        Series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
        OverlappedGanttSeriesView2.BarWidth = 0.3R
        OverlappedGanttSeriesView2.Shadow.Visible = True
        Series2.View = OverlappedGanttSeriesView2
        Me.ChartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        Me.ChartControl.SeriesTemplate.Label = RangeBarSeriesLabel3
        Me.ChartControl.SeriesTemplate.View = OverlappedGanttSeriesView3
        Me.ChartControl.Size = New System.Drawing.Size(659, 604)
        Me.ChartControl.TabIndex = 0
        ChartTitle1.Text = "Project 진행현황"
        ChartTitle1.TextColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(536, 28)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(272, 21)
        Me.stat_bc.TabIndex = 8
        Me.stat_bc.Title = "stat_bc"
        '
        'PMA105
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMA105"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents prj_cd As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ChartControl As DevExpress.XtraCharts.ChartControl
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents btn_DMA340 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents prj_bc As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo

End Class
