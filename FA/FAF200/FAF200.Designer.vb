<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAF200
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
        Me.components = New System.ComponentModel.Container()
        Dim DailyPrintStyle2 As DevExpress.XtraScheduler.Printing.DailyPrintStyle = New DevExpress.XtraScheduler.Printing.DailyPrintStyle()
        Dim WeeklyPrintStyle2 As DevExpress.XtraScheduler.Printing.WeeklyPrintStyle = New DevExpress.XtraScheduler.Printing.WeeklyPrintStyle()
        Dim MonthlyPrintStyle2 As DevExpress.XtraScheduler.Printing.MonthlyPrintStyle = New DevExpress.XtraScheduler.Printing.MonthlyPrintStyle()
        Dim TriFoldPrintStyle2 As DevExpress.XtraScheduler.Printing.TriFoldPrintStyle = New DevExpress.XtraScheduler.Printing.TriFoldPrintStyle()
        Dim CalendarDetailsPrintStyle2 As DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle = New DevExpress.XtraScheduler.Printing.CalendarDetailsPrintStyle()
        Dim MemoPrintStyle2 As DevExpress.XtraScheduler.Printing.MemoPrintStyle = New DevExpress.XtraScheduler.Printing.MemoPrintStyle()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler4 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.unit = New Frame7.eText()
        Me.std_mon = New Frame7.eDate()
        Me.cury = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.tot1 = New Frame7.eText()
        Me.std_dt = New Frame7.eDate()
        Me.tot2 = New Frame7.eText()
        Me.gap = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1040, 660)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.std_mon)
        Me.EPanel1.Controls.Add(Me.tot1)
        Me.EPanel1.Controls.Add(Me.tot2)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.gap)
        Me.EPanel1.Controls.Add(Me.unit)
        Me.EPanel1.Controls.Add(Me.cury)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1040, 79)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "co_cd"
        '
        'unit
        '
        Me.unit.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.unit.Location = New System.Drawing.Point(532, 52)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(160, 21)
        Me.unit.TabIndex = 5
        Me.unit.Title = "단위"
        Me.unit.TitleWidth = 60
        '
        'std_mon
        '
        Me.std_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_mon.Location = New System.Drawing.Point(8, 52)
        Me.std_mon.Name = "std_mon"
        Me.std_mon.Size = New System.Drawing.Size(240, 21)
        Me.std_mon.TabIndex = 3
        Me.std_mon.Title = "std_mon"
        '
        'cury
        '
        Me.cury.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cury.Location = New System.Drawing.Point(696, 52)
        Me.cury.Name = "cury"
        Me.cury.Size = New System.Drawing.Size(48, 21)
        Me.cury.TabIndex = 5
        Me.cury.Title = "원"
        Me.cury.TitleWidth = 60
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SchedulerControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1040, 577)
        Me.SplitContainer2.SplitterDistance = 382
        Me.SplitContainer2.TabIndex = 0
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.[Date]
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never
        Me.SchedulerControl1.PaintStyleName = "Office2003"
        MonthlyPrintStyle2.OneMonthPerPage = False
        Me.SchedulerControl1.PrintStyles.Add(DailyPrintStyle2)
        Me.SchedulerControl1.PrintStyles.Add(WeeklyPrintStyle2)
        Me.SchedulerControl1.PrintStyles.Add(MonthlyPrintStyle2)
        Me.SchedulerControl1.PrintStyles.Add(TriFoldPrintStyle2)
        Me.SchedulerControl1.PrintStyles.Add(CalendarDetailsPrintStyle2)
        Me.SchedulerControl1.PrintStyles.Add(MemoPrintStyle2)
        Me.SchedulerControl1.Size = New System.Drawing.Size(1040, 382)
        Me.SchedulerControl1.Start = New Date(2011, 3, 20, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.schedulerStorage
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.Enabled = False
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler3)
        Me.SchedulerControl1.Views.MonthView.CompressWeekend = False
        Me.SchedulerControl1.Views.MonthView.DateTimeScrollbarVisible = False
        Me.SchedulerControl1.Views.TimelineView.Enabled = False
        Me.SchedulerControl1.Views.WeekView.Enabled = False
        Me.SchedulerControl1.Views.WorkWeekView.AllDayAreaScrollBarVisible = True
        Me.SchedulerControl1.Views.WorkWeekView.Enabled = False
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler4)
        Me.SchedulerControl1.Views.WorkWeekView.TimeScale = System.TimeSpan.Parse("00:05:00")
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1040, 191)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     일 자금계획 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1036, 166)
        Me.g10.TabIndex = 2
        '
        'tot1
        '
        Me.tot1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot1.Location = New System.Drawing.Point(264, 28)
        Me.tot1.Name = "tot1"
        Me.tot1.Size = New System.Drawing.Size(160, 21)
        Me.tot1.TabIndex = 5
        Me.tot1.Title = "수입/지출"
        Me.tot1.TitleWidth = 60
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(852, 40)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(56, 21)
        Me.std_dt.TabIndex = 6
        Me.std_dt.Title = "std_dt"
        '
        'tot2
        '
        Me.tot2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot2.Location = New System.Drawing.Point(364, 28)
        Me.tot2.Name = "tot2"
        Me.tot2.Size = New System.Drawing.Size(160, 21)
        Me.tot2.TabIndex = 5
        Me.tot2.Title = "수입/지출"
        Me.tot2.TitleWidth = 60
        '
        'gap
        '
        Me.gap.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gap.Location = New System.Drawing.Point(532, 28)
        Me.gap.Name = "gap"
        Me.gap.Size = New System.Drawing.Size(160, 21)
        Me.gap.TabIndex = 5
        Me.gap.Title = "차이"
        Me.gap.TitleWidth = 60
        '
        'FAF200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAF200"
        Me.Size = New System.Drawing.Size(1071, 702)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents std_mon As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Private WithEvents schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents unit As Frame7.eText
    Friend WithEvents cury As Frame7.eText
    Friend WithEvents tot1 As Frame7.eText
    Friend WithEvents tot2 As Frame7.eText
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents gap As Frame7.eText

End Class
