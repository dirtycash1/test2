<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRA300
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.f_hire_dt = New Frame7.eDate()
        Me.bs_cd = New Frame7.eCombo()
        Me.work_kd = New Frame7.eCheckCombo()
        Me.f_duty_bc = New Frame7.eCombo()
        Me.f_dept_cd = New Frame7.eText()
        Me.f_emp_no = New Frame7.eText()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage12 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabPage13 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.ePivotGrid()
        Me.XtraTabPage14 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage15 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
        Me.XtraTabPage16 = New DevExpress.XtraTab.XtraTabPage()
        Me.g60 = New Frame7.ePivotGrid()
        Me.XtraTabPage17 = New DevExpress.XtraTab.XtraTabPage()
        Me.g70 = New Frame7.eGrid()
        Me.XtraTabPage18 = New DevExpress.XtraTab.XtraTabPage()
        Me.g80 = New Frame7.eGrid()
        Me.XtraTabPage19 = New DevExpress.XtraTab.XtraTabPage()
        Me.g90 = New Frame7.ePivotGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage12.SuspendLayout()
        Me.XtraTabPage13.SuspendLayout()
        Me.XtraTabPage14.SuspendLayout()
        Me.XtraTabPage15.SuspendLayout()
        Me.XtraTabPage16.SuspendLayout()
        Me.XtraTabPage17.SuspendLayout()
        Me.XtraTabPage18.SuspendLayout()
        Me.XtraTabPage19.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 66
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_hire_dt)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.work_kd)
        Me.EPanel1.Controls.Add(Me.f_duty_bc)
        Me.EPanel1.Controls.Add(Me.f_dept_cd)
        Me.EPanel1.Controls.Add(Me.f_emp_no)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 66)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색조건"
        '
        'f_hire_dt
        '
        Me.f_hire_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_hire_dt.Location = New System.Drawing.Point(256, 28)
        Me.f_hire_dt.Name = "f_hire_dt"
        Me.f_hire_dt.Size = New System.Drawing.Size(230, 21)
        Me.f_hire_dt.TabIndex = 89
        Me.f_hire_dt.Title = "기준일"
        Me.f_hire_dt.TitleWidth = 108
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(220, 21)
        Me.bs_cd.TabIndex = 2
        Me.bs_cd.Title = " 사업장"
        Me.bs_cd.TitleWidth = 98
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(515, 28)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(240, 21)
        Me.work_kd.TabIndex = 92
        Me.work_kd.Title = "근무직 유형"
        '
        'f_duty_bc
        '
        Me.f_duty_bc.Location = New System.Drawing.Point(536, 124)
        Me.f_duty_bc.Name = "f_duty_bc"
        Me.f_duty_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_duty_bc.TabIndex = 88
        Me.f_duty_bc.Title = "직책"
        '
        'f_dept_cd
        '
        Me.f_dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_dept_cd.Location = New System.Drawing.Point(276, 100)
        Me.f_dept_cd.Name = "f_dept_cd"
        Me.f_dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_dept_cd.TabIndex = 3
        Me.f_dept_cd.Title = "부서코드"
        '
        'f_emp_no
        '
        Me.f_emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_no.Location = New System.Drawing.Point(276, 124)
        Me.f_emp_no.Name = "f_emp_no"
        Me.f_emp_no.Size = New System.Drawing.Size(240, 21)
        Me.f_emp_no.TabIndex = 9
        Me.f_emp_no.Title = "사번"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(774, 28)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 92
        Me.stat_bc.Title = "근무상태"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage12
        Me.XtraTabControl2.Size = New System.Drawing.Size(1050, 566)
        Me.XtraTabControl2.TabIndex = 5
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage12, Me.XtraTabPage13, Me.XtraTabPage14, Me.XtraTabPage15, Me.XtraTabPage16, Me.XtraTabPage17, Me.XtraTabPage18, Me.XtraTabPage19})
        '
        'XtraTabPage12
        '
        Me.XtraTabPage12.Controls.Add(Me.g10)
        Me.XtraTabPage12.Name = "XtraTabPage12"
        Me.XtraTabPage12.Size = New System.Drawing.Size(1043, 536)
        Me.XtraTabPage12.Text = "인원현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1043, 536)
        Me.g10.TabIndex = 3
        '
        'XtraTabPage13
        '
        Me.XtraTabPage13.Controls.Add(Me.g20)
        Me.XtraTabPage13.Name = "XtraTabPage13"
        Me.XtraTabPage13.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage13.Text = "직위별현황"
        '
        'g20
        '
        Me.g20.AllowAddRows = False
        Me.g20.AllowDeleteRows = False
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.Size = New System.Drawing.Size(1043, 546)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage14
        '
        Me.XtraTabPage14.Controls.Add(Me.g30)
        Me.XtraTabPage14.Name = "XtraTabPage14"
        Me.XtraTabPage14.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage14.Text = "인원분포도"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(1043, 546)
        Me.g30.TabIndex = 3
        '
        'XtraTabPage15
        '
        Me.XtraTabPage15.Controls.Add(Me.g50)
        Me.XtraTabPage15.Name = "XtraTabPage15"
        Me.XtraTabPage15.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage15.Text = "근속년수별현황"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RecordNavigator = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(1043, 546)
        Me.g50.TabIndex = 3
        '
        'XtraTabPage16
        '
        Me.XtraTabPage16.Controls.Add(Me.g60)
        Me.XtraTabPage16.Name = "XtraTabPage16"
        Me.XtraTabPage16.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage16.Text = "평균연령"
        '
        'g60
        '
        Me.g60.AllowAddRows = False
        Me.g60.AllowDeleteRows = False
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(0, 0)
        Me.g60.Name = "g60"
        Me.g60.Size = New System.Drawing.Size(1043, 546)
        Me.g60.TabIndex = 0
        '
        'XtraTabPage17
        '
        Me.XtraTabPage17.Controls.Add(Me.g70)
        Me.XtraTabPage17.Name = "XtraTabPage17"
        Me.XtraTabPage17.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage17.Text = "학력분포도"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Name = "g70"
        Me.g70.ReadOnly = False
        Me.g70.RecordNavigator = False
        Me.g70.RowHeight = -1
        Me.g70.Size = New System.Drawing.Size(1043, 546)
        Me.g70.TabIndex = 3
        '
        'XtraTabPage18
        '
        Me.XtraTabPage18.Controls.Add(Me.g80)
        Me.XtraTabPage18.Name = "XtraTabPage18"
        Me.XtraTabPage18.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage18.Text = "병력분포도"
        '
        'g80
        '
        Me.g80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g80.Location = New System.Drawing.Point(0, 0)
        Me.g80.Name = "g80"
        Me.g80.ReadOnly = False
        Me.g80.RecordNavigator = False
        Me.g80.RowHeight = -1
        Me.g80.Size = New System.Drawing.Size(1043, 546)
        Me.g80.TabIndex = 3
        '
        'XtraTabPage19
        '
        Me.XtraTabPage19.Controls.Add(Me.g90)
        Me.XtraTabPage19.Name = "XtraTabPage19"
        Me.XtraTabPage19.Size = New System.Drawing.Size(1043, 546)
        Me.XtraTabPage19.Text = "평균근속"
        '
        'g90
        '
        Me.g90.AllowAddRows = False
        Me.g90.AllowDeleteRows = False
        Me.g90.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g90.Location = New System.Drawing.Point(0, 0)
        Me.g90.Name = "g90"
        Me.g90.Size = New System.Drawing.Size(1043, 546)
        Me.g90.TabIndex = 1
        '
        'HRA300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRA300"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage12.ResumeLayout(False)
        Me.XtraTabPage13.ResumeLayout(False)
        Me.XtraTabPage14.ResumeLayout(False)
        Me.XtraTabPage15.ResumeLayout(False)
        Me.XtraTabPage16.ResumeLayout(False)
        Me.XtraTabPage17.ResumeLayout(False)
        Me.XtraTabPage18.ResumeLayout(False)
        Me.XtraTabPage19.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage12 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents XtraTabPage13 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.ePivotGrid
    Friend WithEvents XtraTabPage14 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents XtraTabPage15 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents XtraTabPage16 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g60 As Frame7.ePivotGrid
    Friend WithEvents XtraTabPage17 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g70 As Frame7.eGrid
    Friend WithEvents XtraTabPage18 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g80 As Frame7.eGrid
    Friend WithEvents XtraTabPage19 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g90 As Frame7.ePivotGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents f_duty_bc As Frame7.eCombo
    Friend WithEvents f_dept_cd As Frame7.eText
    Friend WithEvents f_emp_no As Frame7.eText
    Friend WithEvents f_hire_dt As Frame7.eDate
    Friend WithEvents work_kd As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo

End Class
