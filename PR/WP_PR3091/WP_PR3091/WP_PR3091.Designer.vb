<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR3091
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
        Dim XyDiagram3 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel6 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions3 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim SideBySideBarSeriesLabel7 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram4 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel8 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim PointOptions4 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim Series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel9 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SideBySideBarSeriesLabel10 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim ChartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.EPanel1 = New Frame7.ePanel()
        Me.kijong_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.fr_to = New Frame7.eDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer12 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer13 = New System.Windows.Forms.SplitContainer()
        Me.EPanel8 = New Frame7.ePanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.chart1_1 = New DevExpress.XtraCharts.ChartControl()
        Me.EPanel9 = New Frame7.ePanel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.EPanel10 = New Frame7.ePanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.g10 = New Frame7.eGrid()
        Me.Chart1_2 = New DevExpress.XtraCharts.ChartControl()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer12.Panel1.SuspendLayout()
        Me.SplitContainer12.Panel2.SuspendLayout()
        Me.SplitContainer12.SuspendLayout()
        Me.SplitContainer13.Panel1.SuspendLayout()
        Me.SplitContainer13.Panel2.SuspendLayout()
        Me.SplitContainer13.SuspendLayout()
        CType(Me.EPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.chart1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.EPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.Chart1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.kijong_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.fr_to)
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1194, 58)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'kijong_cd
        '
        Me.kijong_cd.Location = New System.Drawing.Point(416, 32)
        Me.kijong_cd.Name = "kijong_cd"
        Me.kijong_cd.Size = New System.Drawing.Size(272, 21)
        Me.kijong_cd.TabIndex = 62
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(24, 32)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(180, 21)
        Me.fr_dt.TabIndex = 61
        Me.fr_dt.Title = "기준일자"
        Me.fr_dt.TitleWidth = 70
        '
        'fr_to
        '
        Me.fr_to.Location = New System.Drawing.Point(223, 32)
        Me.fr_to.Name = "fr_to"
        Me.fr_to.Size = New System.Drawing.Size(140, 21)
        Me.fr_to.TabIndex = 60
        Me.fr_to.Title = "~"
        Me.fr_to.TitleWidth = 30
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer12)
        Me.SplitContainer1.Size = New System.Drawing.Size(1194, 690)
        Me.SplitContainer1.SplitterDistance = 58
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer12
        '
        Me.SplitContainer12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer12.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer12.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer12.Name = "SplitContainer12"
        Me.SplitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer12.Panel1
        '
        Me.SplitContainer12.Panel1.Controls.Add(Me.SplitContainer13)
        '
        'SplitContainer12.Panel2
        '
        Me.SplitContainer12.Panel2.Controls.Add(Me.EPanel10)
        Me.SplitContainer12.Size = New System.Drawing.Size(1194, 628)
        Me.SplitContainer12.SplitterDistance = 380
        Me.SplitContainer12.TabIndex = 3
        '
        'SplitContainer13
        '
        Me.SplitContainer13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer13.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer13.Name = "SplitContainer13"
        '
        'SplitContainer13.Panel1
        '
        Me.SplitContainer13.Panel1.Controls.Add(Me.EPanel8)
        '
        'SplitContainer13.Panel2
        '
        Me.SplitContainer13.Panel2.Controls.Add(Me.EPanel9)
        Me.SplitContainer13.Size = New System.Drawing.Size(1194, 380)
        Me.SplitContainer13.SplitterDistance = 351
        Me.SplitContainer13.TabIndex = 0
        '
        'EPanel8
        '
        Me.EPanel8.Controls.Add(Me.Panel7)
        Me.EPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel8.Location = New System.Drawing.Point(0, 0)
        Me.EPanel8.Name = "EPanel8"
        Me.EPanel8.Size = New System.Drawing.Size(351, 380)
        Me.EPanel8.TabIndex = 0
        Me.EPanel8.Text = "     폐기유형별"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.chart1_1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(2, 23)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(347, 355)
        Me.Panel7.TabIndex = 2
        '
        'chart1_1
        '
        XyDiagram3.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3.AxisX.Range.SideMarginsEnabled = True
        XyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram3.AxisY.GridSpacing = 5.0R
        XyDiagram3.AxisY.GridSpacingAuto = False
        XyDiagram3.AxisY.MinorCount = 4
        XyDiagram3.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram3.AxisY.NumericOptions.Precision = 0
        XyDiagram3.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
        Me.chart1_1.Diagram = XyDiagram3
        Me.chart1_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart1_1.Legend.Visible = False
        Me.chart1_1.Location = New System.Drawing.Point(0, 0)
        Me.chart1_1.Name = "chart1_1"
        SideBySideBarSeriesLabel6.LineVisible = True
        Series4.Label = SideBySideBarSeriesLabel6
        Series4.Name = "폐기유형"
        PointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series4.PointOptions = PointOptions3
        Me.chart1_1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series4}
        SideBySideBarSeriesLabel7.LineVisible = True
        Me.chart1_1.SeriesTemplate.Label = SideBySideBarSeriesLabel7
        Me.chart1_1.Size = New System.Drawing.Size(347, 355)
        Me.chart1_1.TabIndex = 1
        ChartTitle3.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ChartTitle3.Text = "폐기 유형"
        ChartTitle3.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chart1_1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle3})
        '
        'EPanel9
        '
        Me.EPanel9.Controls.Add(Me.Panel8)
        Me.EPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel9.Location = New System.Drawing.Point(0, 0)
        Me.EPanel9.Name = "EPanel9"
        Me.EPanel9.Size = New System.Drawing.Size(839, 380)
        Me.EPanel9.TabIndex = 0
        Me.EPanel9.Text = "     제품별폐기유형"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Chart1_2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(2, 23)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(835, 355)
        Me.Panel8.TabIndex = 2
        '
        'EPanel10
        '
        Me.EPanel10.Controls.Add(Me.Panel9)
        Me.EPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel10.Location = New System.Drawing.Point(0, 0)
        Me.EPanel10.Name = "EPanel10"
        Me.EPanel10.Size = New System.Drawing.Size(1194, 244)
        Me.EPanel10.TabIndex = 0
        Me.EPanel10.Text = "     일별 생산실적"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.g10)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(2, 23)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1190, 219)
        Me.Panel9.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1190, 219)
        Me.g10.TabIndex = 0
        '
        'Chart1_2
        '
        XyDiagram4.AxisX.Label.Angle = -30
        XyDiagram4.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram4.AxisX.Range.SideMarginsEnabled = True
        XyDiagram4.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram4.AxisY.MinorCount = 1
        XyDiagram4.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram4.AxisY.NumericOptions.Precision = 0
        XyDiagram4.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram4.AxisY.Range.SideMarginsEnabled = True
        XyDiagram4.AxisY.VisibleInPanesSerializable = "-1"
        Me.Chart1_2.Diagram = XyDiagram4
        Me.Chart1_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1_2.Location = New System.Drawing.Point(0, 0)
        Me.Chart1_2.Name = "Chart1_2"
        SideBySideBarSeriesLabel8.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Gradient
        SideBySideBarSeriesLabel8.LineLength = 11
        SideBySideBarSeriesLabel8.LineStyle.Thickness = 2
        SideBySideBarSeriesLabel8.LineVisible = True
        Series5.Label = SideBySideBarSeriesLabel8
        Series5.Name = "D : 모양"
        PointOptions4.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        Series5.PointOptions = PointOptions4
        SideBySideBarSeriesLabel9.LineVisible = True
        Series6.Label = SideBySideBarSeriesLabel9
        Series6.Name = "J : 재료"
        Me.Chart1_2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series5, Series6}
        SideBySideBarSeriesLabel10.LineVisible = True
        Me.Chart1_2.SeriesTemplate.Label = SideBySideBarSeriesLabel10
        Me.Chart1_2.Size = New System.Drawing.Size(835, 355)
        Me.Chart1_2.TabIndex = 2
        ChartTitle4.Font = New System.Drawing.Font("맑은 고딕", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        ChartTitle4.Text = "폐기 유형"
        ChartTitle4.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Chart1_2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle4})
        '
        'WP_PR3091
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR3091"
        Me.Size = New System.Drawing.Size(1194, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer12.Panel1.ResumeLayout(False)
        Me.SplitContainer12.Panel2.ResumeLayout(False)
        Me.SplitContainer12.ResumeLayout(False)
        Me.SplitContainer13.Panel1.ResumeLayout(False)
        Me.SplitContainer13.Panel2.ResumeLayout(False)
        Me.SplitContainer13.ResumeLayout(False)
        CType(Me.EPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(XyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.EPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(XyDiagram4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kijong_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents fr_to As Frame7.eDate
    Friend WithEvents SplitContainer12 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer13 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel8 As Frame7.ePanel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents chart1_1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents EPanel9 As Frame7.ePanel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents EPanel10 As Frame7.ePanel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents Chart1_2 As DevExpress.XtraCharts.ChartControl

End Class
