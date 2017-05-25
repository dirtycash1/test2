<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRR250
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
        Me.co_cd = New Frame7.eCombo()
        Me.eval_year = New Frame7.eDate()
        Me.eval_bc = New Frame7.eCheckCombo()
        Me.dept_cd = New Frame7.eText()
        Me.term_bc = New Frame7.eCombo()
        Me.f_emp_no = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.f_emp_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.chk_all = New DevExpress.XtraEditors.CheckEdit()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.emp_no = New Frame7.eText()
        Me.itm_kd = New Frame7.eCombo()
        Me.ok_dsc = New Frame7.eMemo()
        Me.e3_dsc = New Frame7.eMemo()
        Me.e2_dsc = New Frame7.eMemo()
        Me.e1_dsc = New Frame7.eMemo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.chk_all.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1146, 702)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.eval_year)
        Me.EPanel1.Controls.Add(Me.eval_bc)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.term_bc)
        Me.EPanel1.Controls.Add(Me.f_emp_no)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.f_emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1146, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
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
        Me.eval_bc.Location = New System.Drawing.Point(264, 52)
        Me.eval_bc.Name = "eval_bc"
        Me.eval_bc.Size = New System.Drawing.Size(240, 21)
        Me.eval_bc.TabIndex = 21
        Me.eval_bc.Title = "고과집계구분"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(520, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 19
        Me.dept_cd.Title = "부서"
        '
        'term_bc
        '
        Me.term_bc.Location = New System.Drawing.Point(264, 28)
        Me.term_bc.Name = "term_bc"
        Me.term_bc.Size = New System.Drawing.Size(240, 21)
        Me.term_bc.TabIndex = 3
        Me.term_bc.Title = "평가주기"
        '
        'f_emp_no
        '
        Me.f_emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_no.Location = New System.Drawing.Point(520, 52)
        Me.f_emp_no.Name = "f_emp_no"
        Me.f_emp_no.Size = New System.Drawing.Size(240, 21)
        Me.f_emp_no.TabIndex = 7
        Me.f_emp_no.Title = "확인자(사번)"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(648, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 18
        Me.dept_nm.Title = "평가자(부서명)"
        '
        'f_emp_nm
        '
        Me.f_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_nm.Location = New System.Drawing.Point(648, 52)
        Me.f_emp_nm.Name = "f_emp_nm"
        Me.f_emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_emp_nm.TabIndex = 10
        Me.f_emp_nm.Title = "사원명(%)"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1146, 617)
        Me.SplitContainer2.SplitterDistance = 394
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.chk_all)
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1146, 394)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     전체평가리스트"
        '
        'chk_all
        '
        Me.chk_all.Location = New System.Drawing.Point(22, 27)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Properties.Caption = "CheckEdit1"
        Me.chk_all.Size = New System.Drawing.Size(20, 19)
        Me.chk_all.TabIndex = 49
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1142, 369)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.emp_no)
        Me.EPanel3.Controls.Add(Me.itm_kd)
        Me.EPanel3.Controls.Add(Me.ok_dsc)
        Me.EPanel3.Controls.Add(Me.e3_dsc)
        Me.EPanel3.Controls.Add(Me.e2_dsc)
        Me.EPanel3.Controls.Add(Me.e1_dsc)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1146, 219)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     평가의견"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(900, 56)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 8
        Me.emp_no.Title = "사번"
        '
        'itm_kd
        '
        Me.itm_kd.Location = New System.Drawing.Point(900, 32)
        Me.itm_kd.Name = "itm_kd"
        Me.itm_kd.Size = New System.Drawing.Size(240, 21)
        Me.itm_kd.TabIndex = 6
        Me.itm_kd.Title = "고과유형"
        '
        'ok_dsc
        '
        Me.ok_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ok_dsc.Location = New System.Drawing.Point(8, 172)
        Me.ok_dsc.Name = "ok_dsc"
        Me.ok_dsc.Size = New System.Drawing.Size(884, 42)
        Me.ok_dsc.TabIndex = 5
        Me.ok_dsc.Title = "확인자 의견"
        '
        'e3_dsc
        '
        Me.e3_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e3_dsc.Location = New System.Drawing.Point(8, 124)
        Me.e3_dsc.Name = "e3_dsc"
        Me.e3_dsc.Size = New System.Drawing.Size(884, 42)
        Me.e3_dsc.TabIndex = 4
        Me.e3_dsc.Title = "3차 평가자 의견"
        '
        'e2_dsc
        '
        Me.e2_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e2_dsc.Location = New System.Drawing.Point(8, 76)
        Me.e2_dsc.Name = "e2_dsc"
        Me.e2_dsc.Size = New System.Drawing.Size(884, 42)
        Me.e2_dsc.TabIndex = 3
        Me.e2_dsc.Title = "2차 평가자 의견"
        '
        'e1_dsc
        '
        Me.e1_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e1_dsc.Location = New System.Drawing.Point(8, 28)
        Me.e1_dsc.Name = "e1_dsc"
        Me.e1_dsc.Size = New System.Drawing.Size(884, 42)
        Me.e1_dsc.TabIndex = 2
        Me.e1_dsc.Title = "1차 평가자 의견"
        '
        'HRR250
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRR250"
        Me.Size = New System.Drawing.Size(1146, 702)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.chk_all.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents eval_year As Frame7.eDate
    Friend WithEvents term_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents f_emp_no As Frame7.eText
    Friend WithEvents f_emp_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents eval_bc As Frame7.eCheckCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents ok_dsc As Frame7.eMemo
    Friend WithEvents e3_dsc As Frame7.eMemo
    Friend WithEvents e2_dsc As Frame7.eMemo
    Friend WithEvents e1_dsc As Frame7.eMemo
    Friend WithEvents itm_kd As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents chk_all As DevExpress.XtraEditors.CheckEdit

End Class
