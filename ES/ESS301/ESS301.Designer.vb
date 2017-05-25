<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESS301
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
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.std_mon = New Frame7.eDate()
        Me.wek = New Frame7.eCheckCombo()
        Me.fac_cd = New Frame7.eCheckCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Chart2 = New DevExpress.XtraCharts.ChartControl()
        Me.g10 = New Frame7.eGrid()
        Me.unit_bc = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1113, 727)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.unit_bc)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Controls.Add(Me.std_mon)
        Me.EPanel1.Controls.Add(Me.wek)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1113, 78)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     검색조건"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(252, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "co_cd"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(544, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "(단위 : EA)"
        '
        'std_mon
        '
        Me.std_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_mon.Format = "yyyy-MM"
        Me.std_mon.Location = New System.Drawing.Point(293, 28)
        Me.std_mon.Name = "std_mon"
        Me.std_mon.Size = New System.Drawing.Size(236, 21)
        Me.std_mon.TabIndex = 3
        Me.std_mon.Title = "std_mon"
        '
        'wek
        '
        Me.wek.Location = New System.Drawing.Point(547, 52)
        Me.wek.Name = "wek"
        Me.wek.Size = New System.Drawing.Size(435, 21)
        Me.wek.TabIndex = 7
        Me.wek.Title = "주차"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(521, 21)
        Me.fac_cd.TabIndex = 7
        Me.fac_cd.Title = "공장"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.XtraTabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1113, 645)
        Me.SplitContainer2.SplitterDistance = 430
        Me.SplitContainer2.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1113, 430)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Chart1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1106, 400)
        Me.XtraTabPage1.Text = "공장별"
        '
        'Chart1
        '
        Me.Chart1.AppearanceName = "Chameleon"
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram1.AxisY.NumericOptions.Precision = 0
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.PaneDistance = 4
        Me.Chart1.Diagram = XyDiagram1
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1.Legend.TextOffset = 5
        Me.Chart1.Legend.VerticalIndent = 5
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        PointSeriesLabel1.LineVisible = True
        Series1.Label = PointSeriesLabel1
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.ValueNumericOptions.Precision = 0
        Series1.PointOptions = PointOptions1
        Series1.View = LineSeriesView1
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        PointSeriesLabel2.LineVisible = True
        Me.Chart1.SeriesTemplate.Label = PointSeriesLabel2
        Me.Chart1.SeriesTemplate.View = LineSeriesView2
        Me.Chart1.SideBySideBarDistanceVariable = 0.1R
        Me.Chart1.Size = New System.Drawing.Size(1106, 400)
        Me.Chart1.TabIndex = 4
        ChartTitle1.Text = "MAKER"
        ChartTitle1.Visible = False
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Chart2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1106, 400)
        Me.XtraTabPage2.Text = "Maker별"
        '
        'Chart2
        '
        Me.Chart2.AppearanceName = "Chameleon"
        XyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisX.Range.SideMarginsEnabled = True
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        XyDiagram2.AxisY.NumericOptions.Precision = 0
        XyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram2.AxisY.Range.SideMarginsEnabled = True
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram2.PaneDistance = 4
        Me.Chart2.Diagram = XyDiagram2
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart2.Legend.TextOffset = 5
        Me.Chart2.Legend.VerticalIndent = 5
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        PointSeriesLabel3.LineVisible = True
        Series2.Label = PointSeriesLabel3
        Series2.View = LineSeriesView3
        Me.Chart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2}
        PointSeriesLabel4.LineVisible = True
        Me.Chart2.SeriesTemplate.Label = PointSeriesLabel4
        Me.Chart2.SeriesTemplate.View = LineSeriesView4
        Me.Chart2.SideBySideBarDistanceVariable = 0.1R
        Me.Chart2.Size = New System.Drawing.Size(1106, 400)
        Me.Chart2.TabIndex = 5
        ChartTitle2.Text = "공장별"
        Me.Chart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1113, 211)
        Me.g10.TabIndex = 0
        '
        'unit_bc
        '
        Me.unit_bc.Location = New System.Drawing.Point(547, 28)
        Me.unit_bc.Name = "unit_bc"
        Me.unit_bc.Size = New System.Drawing.Size(240, 21)
        Me.unit_bc.TabIndex = 8
        Me.unit_bc.Title = "unit_bc"
        '
        'ESS301
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ESS301"
        Me.Size = New System.Drawing.Size(1113, 727)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents std_mon As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Chart2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wek As Frame7.eCheckCombo
    Friend WithEvents fac_cd As Frame7.eCheckCombo
    Friend WithEvents unit_bc As Frame7.eCombo

End Class
