<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESD101
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
        Dim PointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PointSeriesLabel4 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions()
        Dim LineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim PointSeriesLabel5 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
        Dim LineSeriesView5 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.co_cd = New Frame7.eCombo()
        Me.std_year = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Chart2 = New DevExpress.XtraCharts.ChartControl()
        Me.g10 = New Frame7.eGrid()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.open_ty = New Frame7.eText()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.mkr_bc = New Frame7.eCheckCombo()
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
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1003, 658)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.r1)
        Me.EPanel1.Controls.Add(Me.open_ty)
        Me.EPanel1.Controls.Add(Me.r2)
        Me.EPanel1.Controls.Add(Me.mkr_bc)
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.std_year)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1003, 78)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     검색조건"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(526, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "(단위 : EA)"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(252, 21)
        Me.co_cd.TabIndex = 2
        '
        'std_year
        '
        Me.std_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_year.Location = New System.Drawing.Point(280, 28)
        Me.std_year.Name = "std_year"
        Me.std_year.Size = New System.Drawing.Size(240, 21)
        Me.std_year.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1003, 576)
        Me.SplitContainer2.SplitterDistance = 317
        Me.SplitContainer2.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1003, 317)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Chart1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(996, 287)
        Me.XtraTabPage1.Text = "MAKER별"
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
        Series1.Name = "계획"
        Series1.View = LineSeriesView1
        PointSeriesLabel2.LineVisible = True
        Series2.Label = PointSeriesLabel2
        Series2.Name = "실적"
        Series2.View = LineSeriesView2
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        PointSeriesLabel3.LineVisible = True
        Me.Chart1.SeriesTemplate.Label = PointSeriesLabel3
        Me.Chart1.SeriesTemplate.View = LineSeriesView3
        Me.Chart1.SideBySideBarDistanceVariable = 0.1R
        Me.Chart1.Size = New System.Drawing.Size(996, 287)
        Me.Chart1.TabIndex = 5
        ChartTitle1.Text = "MAKER"
        ChartTitle1.Visible = False
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Chart2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(996, 304)
        Me.XtraTabPage2.Text = "차종별"
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
        PointSeriesLabel4.LineVisible = True
        Series3.Label = PointSeriesLabel4
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions1.ValueNumericOptions.Precision = 0
        Series3.PointOptions = PointOptions1
        Series3.View = LineSeriesView4
        Me.Chart2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series3}
        PointSeriesLabel5.LineVisible = True
        Me.Chart2.SeriesTemplate.Label = PointSeriesLabel5
        Me.Chart2.SeriesTemplate.View = LineSeriesView5
        Me.Chart2.SideBySideBarDistanceVariable = 0.1R
        Me.Chart2.Size = New System.Drawing.Size(996, 304)
        Me.Chart2.TabIndex = 6
        ChartTitle2.Text = ""
        Me.Chart2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1003, 255)
        Me.g10.TabIndex = 0
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Checked = True
        Me.r1.Location = New System.Drawing.Point(130, 53)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(81, 18)
        Me.r1.TabIndex = 10
        Me.r1.TabStop = True
        Me.r1.Text = "계획+실적"
        Me.r1.UseVisualStyleBackColor = True
        '
        'open_ty
        '
        Me.open_ty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.open_ty.Location = New System.Drawing.Point(8, 51)
        Me.open_ty.Name = "open_ty"
        Me.open_ty.Size = New System.Drawing.Size(119, 21)
        Me.open_ty.TabIndex = 8
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Location = New System.Drawing.Point(222, 53)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(49, 18)
        Me.r2.TabIndex = 9
        Me.r2.Text = "실적"
        Me.r2.UseVisualStyleBackColor = True
        '
        'mkr_bc
        '
        Me.mkr_bc.Location = New System.Drawing.Point(280, 51)
        Me.mkr_bc.Name = "mkr_bc"
        Me.mkr_bc.Size = New System.Drawing.Size(452, 21)
        Me.mkr_bc.TabIndex = 11
        Me.mkr_bc.Title = "Maker"
        '
        'ESD101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ESD101"
        Me.Size = New System.Drawing.Size(1003, 658)
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
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PointSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(LineSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents std_year As Frame7.eDate
    Friend WithEvents Chart2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents r1 As System.Windows.Forms.RadioButton
    Friend WithEvents open_ty As Frame7.eText
    Friend WithEvents r2 As System.Windows.Forms.RadioButton
    Friend WithEvents mkr_bc As Frame7.eCheckCombo

End Class
