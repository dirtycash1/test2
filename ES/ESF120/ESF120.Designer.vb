<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESF120
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
        Dim RadarDiagram1 As DevExpress.XtraCharts.RadarDiagram = New DevExpress.XtraCharts.RadarDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RadarPointSeriesLabel1 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
        Dim RadarLineSeriesView1 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim RadarPointSeriesLabel2 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
        Dim RadarLineSeriesView2 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Dim RadarPointSeriesLabel3 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
        Dim RadarLineSeriesView3 As DevExpress.XtraCharts.RadarLineSeriesView = New DevExpress.XtraCharts.RadarLineSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.div_cd = New Frame7.eCombo()
        Me.base_month = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Chart1 = New DevExpress.XtraCharts.ChartControl()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarPointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarPointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RadarLineSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(971, 681)
        Me.SplitContainer1.SplitterDistance = 51
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.base_month)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(971, 51)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색조건"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(8, 24)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(316, 21)
        Me.div_cd.TabIndex = 2
        '
        'base_month
        '
        Me.base_month.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.base_month.Format = "yyyy"
        Me.base_month.Location = New System.Drawing.Point(336, 24)
        Me.base_month.Name = "base_month"
        Me.base_month.Size = New System.Drawing.Size(236, 21)
        Me.base_month.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(971, 626)
        Me.SplitContainer2.SplitterDistance = 546
        Me.SplitContainer2.TabIndex = 0
        '
        'Chart1
        '
        Me.Chart1.AppearanceName = "Light"
        RadarDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        RadarDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        RadarDiagram1.AxisY.Range.SideMarginsEnabled = True
        RadarDiagram1.AxisY.Tickmarks.Length = 10
        RadarDiagram1.AxisY.Tickmarks.Thickness = 5
        RadarDiagram1.Shadow.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        RadarDiagram1.StartAngleInDegrees = 150.0R
        Me.Chart1.Diagram = RadarDiagram1
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.PaletteName = "Nature Colors"
        RadarPointSeriesLabel1.LineVisible = True
        Series1.Label = RadarPointSeriesLabel1
        Series1.Name = "Series 1"
        Series1.View = RadarLineSeriesView1
        RadarPointSeriesLabel2.LineVisible = True
        Series2.Label = RadarPointSeriesLabel2
        Series2.Name = "Series 2"
        Series2.View = RadarLineSeriesView2
        Me.Chart1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2}
        RadarPointSeriesLabel3.LineVisible = True
        Me.Chart1.SeriesTemplate.Label = RadarPointSeriesLabel3
        Me.Chart1.SeriesTemplate.View = RadarLineSeriesView3
        Me.Chart1.Size = New System.Drawing.Size(546, 626)
        Me.Chart1.TabIndex = 1
        ChartTitle1.Alignment = System.Drawing.StringAlignment.Near
        ChartTitle1.Text = "재무 비율분석"
        ChartTitle1.TextColor = System.Drawing.Color.Black
        Me.Chart1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(421, 626)
        Me.g10.TabIndex = 0
        '
        'ESF120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ESF120"
        Me.Size = New System.Drawing.Size(971, 681)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(RadarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarPointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarPointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarPointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RadarLineSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents base_month As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Chart1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents g10 As Frame7.eGrid

End Class
