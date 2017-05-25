<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESF130
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
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel5 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView5 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.std_dtt = New Frame7.eDate()
        Me.std_dtf = New Frame7.eDate()
        Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(840, 414)
        Me.SplitContainer1.SplitterDistance = 49
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.std_dtt)
        Me.EPanel1.Controls.Add(Me.std_dtf)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(840, 49)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'std_dtt
        '
        Me.std_dtt.Location = New System.Drawing.Point(248, 24)
        Me.std_dtt.Name = "std_dtt"
        Me.std_dtt.Size = New System.Drawing.Size(144, 21)
        Me.std_dtt.TabIndex = 3
        Me.std_dtt.Title = "  ~"
        Me.std_dtt.TitleWidth = 30
        '
        'std_dtf
        '
        Me.std_dtf.Location = New System.Drawing.Point(4, 24)
        Me.std_dtf.Name = "std_dtf"
        Me.std_dtf.Size = New System.Drawing.Size(240, 21)
        Me.std_dtf.TabIndex = 2
        '
        'Chart1
        '
        Me.Chart1.AppearanceName = "Chameleon"
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.EnableAxisXZooming = True
        XyDiagram1.EnableAxisYZooming = True
        XyDiagram1.PaneDistance = 4
        Me.Chart1.Diagram = XyDiagram1
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1.Legend.TextOffset = 5
        Me.Chart1.Legend.VerticalIndent = 5
        Me.Chart1.Location = New System.Drawing.Point(2, 23)
        Me.Chart1.Name = "Chart1"
        PointSeriesLabel1.LineVisible = True
        Series1.Label = PointSeriesLabel1
        Series1.Name = "USD"
        Series1.View = LineSeriesView1
        PointSeriesLabel2.LineVisible = True
        Series2.Label = PointSeriesLabel2
        Series2.Name = "JPY"
        Series2.View = LineSeriesView2
        PointSeriesLabel3.LineVisible = True
        Series3.Label = PointSeriesLabel3
        Series3.Name = "CNY"
        Series3.View = LineSeriesView3
        PointSeriesLabel4.LineVisible = True
        Series4.Label = PointSeriesLabel4
        Series4.Name = "EUR"
        Series4.View = LineSeriesView4
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4}
        PointSeriesLabel5.LineVisible = True
        Me.Chart1.SeriesTemplate.Label = PointSeriesLabel5
        Me.Chart1.SeriesTemplate.View = LineSeriesView5
        Me.Chart1.SideBySideBarDistanceVariable = 0.1R
        Me.Chart1.Size = New System.Drawing.Size(836, 336)
        Me.Chart1.TabIndex = 4
        ChartTitle1.Text = "환율 변동 현황"
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.Chart1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(840, 361)
        Me.EPanel2.TabIndex = 5
        Me.EPanel2.Text = "     환율"
        '
        'ESF130
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ESF130"
        Me.Size = New System.Drawing.Size(840, 414)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents std_dtt As Frame7.eDate
    Friend WithEvents std_dtf As Frame7.eDate
    Friend WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents EPanel2 As Frame7.ePanel

End Class
