﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_EIS1150
    Inherits Base7.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel5 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions4 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView5 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel6 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView6 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.std_dt = New Frame7.eDate()
        Me.kijong_cd = New Frame7.eCombo()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer14 = New System.Windows.Forms.SplitContainer()
        Me.EPanel13 = New Frame7.ePanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel12 = New Frame7.ePanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.chart2_2 = New DevExpress.XtraCharts.ChartControl()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SplitContainer14.Panel1.SuspendLayout()
        Me.SplitContainer14.Panel2.SuspendLayout()
        Me.SplitContainer14.SuspendLayout()
        CType(Me.EPanel13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.EPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        CType(Me.chart2_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 58
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.kijong_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 58)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(8, 28)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 2
        Me.std_dt.Title = "기준일자"
        '
        'kijong_cd
        '
        Me.kijong_cd.Location = New System.Drawing.Point(304, 28)
        Me.kijong_cd.Name = "kijong_cd"
        Me.kijong_cd.Size = New System.Drawing.Size(240, 21)
        Me.kijong_cd.TabIndex = 6
        Me.kijong_cd.Title = "구분"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SplitContainer14)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1175, 519)
        Me.XtraTabPage2.Text = "제품군분류(월별)"
        '
        'SplitContainer14
        '
        Me.SplitContainer14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer14.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer14.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer14.Name = "SplitContainer14"
        Me.SplitContainer14.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer14.Panel1
        '
        Me.SplitContainer14.Panel1.Controls.Add(Me.EPanel12)
        '
        'SplitContainer14.Panel2
        '
        Me.SplitContainer14.Panel2.Controls.Add(Me.EPanel13)
        Me.SplitContainer14.Size = New System.Drawing.Size(1175, 519)
        Me.SplitContainer14.SplitterDistance = 271
        Me.SplitContainer14.TabIndex = 2
        '
        'EPanel13
        '
        Me.EPanel13.Controls.Add(Me.Panel12)
        Me.EPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel13.Location = New System.Drawing.Point(0, 0)
        Me.EPanel13.Name = "EPanel13"
        Me.EPanel13.Size = New System.Drawing.Size(1175, 244)
        Me.EPanel13.TabIndex = 0
        Me.EPanel13.Text = "     월별 매출 현황"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.g20)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(2, 23)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1171, 219)
        Me.Panel12.TabIndex = 2
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1171, 219)
        Me.g20.TabIndex = 0
        '
        'EPanel12
        '
        Me.EPanel12.Controls.Add(Me.Panel11)
        Me.EPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel12.Location = New System.Drawing.Point(0, 0)
        Me.EPanel12.Name = "EPanel12"
        Me.EPanel12.Size = New System.Drawing.Size(1175, 271)
        Me.EPanel12.TabIndex = 1
        Me.EPanel12.Text = "     실적추이"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.chart2_2)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(2, 23)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1171, 246)
        Me.Panel11.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1182, 549)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'chart2_2
        '
        XyDiagram2.AxisX.Label.Angle = -45
        XyDiagram2.AxisX.Label.Antialiasing = True
        XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisX.Range.SideMarginsEnabled = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram2.AxisY.NumericOptions.Precision = 0
        XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisY.Range.SideMarginsEnabled = True
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.chart2_2.Diagram = XyDiagram2
        Me.chart2_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart2_2.EmptyChartText.Font = New System.Drawing.Font("맑은 고딕", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.chart2_2.EmptyChartText.Text = "조회할 데이터가 없습니다."
        Me.chart2_2.EmptyChartText.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chart2_2.Location = New System.Drawing.Point(0, 0)
        Me.chart2_2.Name = "chart2_2"
        Me.chart2_2.PaletteName = "Metro"
        PointSeriesLabel4.LineVisible = True
        Series3.Label = PointSeriesLabel4
        Series3.Name = "Series 1"
        PointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions3.ValueNumericOptions.Precision = 0
        Series3.PointOptions = PointOptions3
        Series3.View = LineSeriesView4
        PointSeriesLabel5.LineVisible = True
        Series4.Label = PointSeriesLabel5
        Series4.Name = "Series 2"
        PointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions4.ValueNumericOptions.Precision = 0
        Series4.PointOptions = PointOptions4
        LineSeriesView5.LineMarkerOptions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView5.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LineSeriesView5.LineMarkerOptions.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
        LineSeriesView5.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Hexagon
        LineSeriesView5.LineMarkerOptions.Size = 13
        Series4.View = LineSeriesView5
        Me.chart2_2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3, Series4}
        PointSeriesLabel6.LineVisible = True
        Me.chart2_2.SeriesTemplate.Label = PointSeriesLabel6
        Me.chart2_2.SeriesTemplate.View = LineSeriesView6
        Me.chart2_2.Size = New System.Drawing.Size(1171, 246)
        Me.chart2_2.TabIndex = 5
        ChartTitle2.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ChartTitle2.Text = "제품분류별 원가 추이"
        ChartTitle2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chart2_2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'WP_EIS1150
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_EIS1150"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.SplitContainer14.Panel1.ResumeLayout(False)
        Me.SplitContainer14.Panel2.ResumeLayout(False)
        Me.SplitContainer14.ResumeLayout(False)
        CType(Me.EPanel13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.EPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel12.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart2_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents kijong_cd As Frame7.eCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer14 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel12 As Frame7.ePanel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents chart2_2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents EPanel13 As Frame7.ePanel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents g20 As Frame7.eGrid

End Class
