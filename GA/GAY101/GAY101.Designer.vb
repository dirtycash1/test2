<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAY101
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
        Me.std_year = New Frame7.eDate()
        Me.bs_cd = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.pay_bc = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.work_bc = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(837, 519)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.work_bc)
        Me.EPanel1.Controls.Add(Me.std_year)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.pay_bc)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(837, 106)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'std_year
        '
        Me.std_year.Location = New System.Drawing.Point(12, 76)
        Me.std_year.Name = "std_year"
        Me.std_year.Size = New System.Drawing.Size(240, 21)
        Me.std_year.TabIndex = 16
        Me.std_year.Title = "기준년도"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 15
        Me.bs_cd.Title = "사업장"
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(268, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 19
        Me.emp_no.Title = "사원"
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(396, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 20
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(268, 76)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(240, 21)
        Me.pay_bc.TabIndex = 21
        Me.pay_bc.Title = "급여구분"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(268, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 17
        Me.dept_cd.Title = "부서"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 13
        Me.co_cd.Title = "법인"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(396, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 18
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(837, 409)
        Me.g10.TabIndex = 0
        '
        'work_bc
        '
        Me.work_bc.Location = New System.Drawing.Point(516, 76)
        Me.work_bc.Name = "work_bc"
        Me.work_bc.Size = New System.Drawing.Size(240, 21)
        Me.work_bc.TabIndex = 22
        Me.work_bc.Title = "근무직구분"
        '
        'GAY101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GAY101"
        Me.Size = New System.Drawing.Size(837, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents std_year As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents work_bc As Frame7.eCombo

End Class
