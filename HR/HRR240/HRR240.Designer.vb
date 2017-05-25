<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRR240
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
        Me.but_work1 = New DevExpress.XtraEditors.SimpleButton()
        Me.co_cd = New Frame7.eCombo()
        Me.eval_year = New Frame7.eDate()
        Me.eval_bc = New Frame7.eCheckCombo()
        Me.dept_cd = New Frame7.eText()
        Me.term_bc = New Frame7.eCombo()
        Me.but_work = New DevExpress.XtraEditors.SimpleButton()
        Me.emp_no = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.but_work2 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1146, 702)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.but_work2)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.eval_year)
        Me.EPanel1.Controls.Add(Me.eval_bc)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.but_work1)
        Me.EPanel1.Controls.Add(Me.term_bc)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.but_work)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1146, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'but_work1
        '
        Me.but_work1.Location = New System.Drawing.Point(648, 52)
        Me.but_work1.Name = "but_work1"
        Me.but_work1.Size = New System.Drawing.Size(112, 21)
        Me.but_work1.TabIndex = 22
        Me.but_work1.Text = "등급 계산"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 1
        Me.co_cd.Title = "법인"
        '
        'eval_year
        '
        Me.eval_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.eval_year.Format = "yyyy"
        Me.eval_year.Location = New System.Drawing.Point(8, 52)
        Me.eval_year.Name = "eval_year"
        Me.eval_year.Size = New System.Drawing.Size(240, 21)
        Me.eval_year.TabIndex = 2
        Me.eval_year.Title = "기준년도"
        '
        'eval_bc
        '
        Me.eval_bc.Location = New System.Drawing.Point(264, 28)
        Me.eval_bc.Name = "eval_bc"
        Me.eval_bc.Size = New System.Drawing.Size(240, 21)
        Me.eval_bc.TabIndex = 21
        Me.eval_bc.Title = "고과집계구분"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(264, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 19
        Me.dept_cd.Title = "부서"
        '
        'term_bc
        '
        Me.term_bc.Location = New System.Drawing.Point(8, 76)
        Me.term_bc.Name = "term_bc"
        Me.term_bc.Size = New System.Drawing.Size(240, 21)
        Me.term_bc.TabIndex = 3
        Me.term_bc.Title = "평가주기"
        '
        'but_work
        '
        Me.but_work.Location = New System.Drawing.Point(648, 28)
        Me.but_work.Name = "but_work"
        Me.but_work.Size = New System.Drawing.Size(112, 21)
        Me.but_work.TabIndex = 20
        Me.but_work.Text = "표준편차 계산"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(264, 76)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 7
        Me.emp_no.Title = "사번"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(392, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 18
        Me.dept_nm.Title = "평가자(부서명)"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(392, 76)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 10
        Me.emp_nm.Title = "사원명(%)"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1146, 594)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     전체평가등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1142, 569)
        Me.g10.TabIndex = 2
        '
        'but_work2
        '
        Me.but_work2.Location = New System.Drawing.Point(648, 76)
        Me.but_work2.Name = "but_work2"
        Me.but_work2.Size = New System.Drawing.Size(112, 21)
        Me.but_work2.TabIndex = 23
        Me.but_work2.Text = "인사정보반영"
        '
        'HRR240
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRR240"
        Me.Size = New System.Drawing.Size(1146, 702)
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
    Friend WithEvents eval_year As Frame7.eDate
    Friend WithEvents term_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents but_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eval_bc As Frame7.eCheckCombo
    Friend WithEvents but_work1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_work2 As DevExpress.XtraEditors.SimpleButton

End Class
