<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_CO1200
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
        Me.dept_cd = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.bs_cd = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.work_kd = New Frame7.eCheckCombo()
        Me.std_mon = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 360)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.work_kd)
        Me.EPanel1.Controls.Add(Me.std_mon)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(936, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(528, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 5
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(112, 3)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Visible = False
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(15, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 4
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(528, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 5
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(271, 28)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(240, 21)
        Me.work_kd.TabIndex = 6
        Me.work_kd.Title = "근무직유형"
        '
        'std_mon
        '
        Me.std_mon.Location = New System.Drawing.Point(15, 52)
        Me.std_mon.Name = "std_mon"
        Me.std_mon.Size = New System.Drawing.Size(240, 21)
        Me.std_mon.TabIndex = 3
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(771, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(150, 21)
        Me.dept_nm.TabIndex = 5
        Me.dept_nm.TitleWidth = 0
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(771, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(150, 21)
        Me.emp_nm.TabIndex = 5
        Me.emp_nm.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 276)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     생일자 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 251)
        Me.g10.TabIndex = 2
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(271, 52)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 6
        Me.stat_bc.Title = "근무상태"
        '
        'WP_CO1200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_CO1200"
        Me.Size = New System.Drawing.Size(970, 392)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents std_mon As Frame7.eCombo
    Friend WithEvents work_kd As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo

End Class
