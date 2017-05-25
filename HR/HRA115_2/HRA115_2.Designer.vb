<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRA115_2
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.bs_cd = New Frame7.eCheckCombo()
        Me.rank_bc = New Frame7.eCheckCombo()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.work_bc = New Frame7.eCheckCombo()
        Me.to_age = New Frame7.eText()
        Me.hcap_ty = New Frame7.eOptionBox()
        Me.fr_age = New Frame7.eText()
        Me.school_bc = New Frame7.eCheckCombo()
        Me.spc_ty = New Frame7.eOptionBox()
        Me.nat_ty = New Frame7.eOptionBox()
        Me.work_kd = New Frame7.eCheckCombo()
        Me.hire_bc = New Frame7.eCheckCombo()
        Me.pay_kd = New Frame7.eCheckCombo()
        Me.pro_fr = New Frame7.eDate()
        Me.entr_bc = New Frame7.eCheckCombo()
        Me.to_year = New Frame7.eText()
        Me.duty_bc = New Frame7.eCheckCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.pro_to = New Frame7.eDate()
        Me.fr_year = New Frame7.eText()
        Me.app_dt = New Frame7.eDate()
        Me.step_bc = New Frame7.eCheckCombo()
        Me.high_bc = New Frame7.eCheckCombo()
        Me.dept_cd = New Frame7.eText()
        Me.work_bs = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.t_retr_dt = New Frame7.eDate()
        Me.t_hire_dt = New Frame7.eDate()
        Me.emp_nm = New Frame7.eText()
        Me.retr_dt = New Frame7.eDate()
        Me.hire_dt = New Frame7.eDate()
        Me.g10 = New Frame7.eGrid()
        Me.fac_cd = New Frame7.eCombo()
        Me.work2_bc = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1342, 522)
        Me.SplitContainer1.SplitterDistance = 229
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.work2_bc)
        Me.EPanel3.Controls.Add(Me.fac_cd)
        Me.EPanel3.Controls.Add(Me.bs_cd)
        Me.EPanel3.Controls.Add(Me.rank_bc)
        Me.EPanel3.Controls.Add(Me.work_bc)
        Me.EPanel3.Controls.Add(Me.to_age)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Controls.Add(Me.hcap_ty)
        Me.EPanel3.Controls.Add(Me.fr_age)
        Me.EPanel3.Controls.Add(Me.school_bc)
        Me.EPanel3.Controls.Add(Me.spc_ty)
        Me.EPanel3.Controls.Add(Me.nat_ty)
        Me.EPanel3.Controls.Add(Me.work_kd)
        Me.EPanel3.Controls.Add(Me.hire_bc)
        Me.EPanel3.Controls.Add(Me.pay_kd)
        Me.EPanel3.Controls.Add(Me.pro_fr)
        Me.EPanel3.Controls.Add(Me.entr_bc)
        Me.EPanel3.Controls.Add(Me.to_year)
        Me.EPanel3.Controls.Add(Me.duty_bc)
        Me.EPanel3.Controls.Add(Me.co_cd)
        Me.EPanel3.Controls.Add(Me.pro_to)
        Me.EPanel3.Controls.Add(Me.fr_year)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.app_dt)
        Me.EPanel3.Controls.Add(Me.step_bc)
        Me.EPanel3.Controls.Add(Me.high_bc)
        Me.EPanel3.Controls.Add(Me.work_bs)
        Me.EPanel3.Controls.Add(Me.t_retr_dt)
        Me.EPanel3.Controls.Add(Me.dept_cd)
        Me.EPanel3.Controls.Add(Me.t_hire_dt)
        Me.EPanel3.Controls.Add(Me.emp_no)
        Me.EPanel3.Controls.Add(Me.retr_dt)
        Me.EPanel3.Controls.Add(Me.hire_dt)
        Me.EPanel3.Controls.Add(Me.emp_nm)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1342, 229)
        Me.EPanel3.TabIndex = 63
        Me.EPanel3.Text = "     사원정보"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 129
        Me.bs_cd.Title = "사업장"
        '
        'rank_bc
        '
        Me.rank_bc.Location = New System.Drawing.Point(260, 172)
        Me.rank_bc.Name = "rank_bc"
        Me.rank_bc.Size = New System.Drawing.Size(240, 21)
        Me.rank_bc.TabIndex = 115
        Me.rank_bc.Title = "직급"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(260, 197)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 115
        Me.stat_bc.Title = "근무상태"
        '
        'work_bc
        '
        Me.work_bc.Location = New System.Drawing.Point(260, 76)
        Me.work_bc.Name = "work_bc"
        Me.work_bc.Size = New System.Drawing.Size(240, 21)
        Me.work_bc.TabIndex = 121
        Me.work_bc.Title = "근무직구분"
        '
        'to_age
        '
        Me.to_age.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_age.Location = New System.Drawing.Point(940, 76)
        Me.to_age.Name = "to_age"
        Me.to_age.Size = New System.Drawing.Size(56, 21)
        Me.to_age.TabIndex = 128
        Me.to_age.Title = "연령(to)"
        Me.to_age.TitleWidth = 0
        '
        'hcap_ty
        '
        Me.hcap_ty.Location = New System.Drawing.Point(1012, 28)
        Me.hcap_ty.Name = "hcap_ty"
        Me.hcap_ty.SelectedIndex = -1
        Me.hcap_ty.Size = New System.Drawing.Size(240, 24)
        Me.hcap_ty.TabIndex = 130
        Me.hcap_ty.Title = "장애여부"
        Me.hcap_ty.TitleWidth = 98
        '
        'fr_age
        '
        Me.fr_age.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_age.Location = New System.Drawing.Point(756, 76)
        Me.fr_age.Name = "fr_age"
        Me.fr_age.Size = New System.Drawing.Size(180, 21)
        Me.fr_age.TabIndex = 127
        Me.fr_age.Title = "연령(fr)"
        '
        'school_bc
        '
        Me.school_bc.Location = New System.Drawing.Point(756, 28)
        Me.school_bc.Name = "school_bc"
        Me.school_bc.Size = New System.Drawing.Size(240, 21)
        Me.school_bc.TabIndex = 114
        Me.school_bc.Title = "학력"
        '
        'spc_ty
        '
        Me.spc_ty.Location = New System.Drawing.Point(1012, 56)
        Me.spc_ty.Name = "spc_ty"
        Me.spc_ty.SelectedIndex = -1
        Me.spc_ty.Size = New System.Drawing.Size(240, 24)
        Me.spc_ty.TabIndex = 130
        Me.spc_ty.Title = "병력특례"
        Me.spc_ty.TitleWidth = 98
        '
        'nat_ty
        '
        Me.nat_ty.Location = New System.Drawing.Point(1012, 84)
        Me.nat_ty.Name = "nat_ty"
        Me.nat_ty.SelectedIndex = -1
        Me.nat_ty.Size = New System.Drawing.Size(240, 24)
        Me.nat_ty.TabIndex = 130
        Me.nat_ty.Title = "외국인"
        Me.nat_ty.TitleWidth = 98
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(260, 52)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(240, 21)
        Me.work_kd.TabIndex = 121
        Me.work_kd.Title = "근무직유형"
        '
        'hire_bc
        '
        Me.hire_bc.Location = New System.Drawing.Point(508, 28)
        Me.hire_bc.Name = "hire_bc"
        Me.hire_bc.Size = New System.Drawing.Size(240, 21)
        Me.hire_bc.TabIndex = 121
        Me.hire_bc.Title = "입사구분"
        '
        'pay_kd
        '
        Me.pay_kd.Location = New System.Drawing.Point(260, 100)
        Me.pay_kd.Name = "pay_kd"
        Me.pay_kd.Size = New System.Drawing.Size(240, 21)
        Me.pay_kd.TabIndex = 121
        Me.pay_kd.Title = "급여형태"
        '
        'pro_fr
        '
        Me.pro_fr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pro_fr.Location = New System.Drawing.Point(508, 148)
        Me.pro_fr.Name = "pro_fr"
        Me.pro_fr.Size = New System.Drawing.Size(240, 21)
        Me.pro_fr.TabIndex = 120
        Me.pro_fr.Title = "수습일자"
        '
        'entr_bc
        '
        Me.entr_bc.Location = New System.Drawing.Point(260, 28)
        Me.entr_bc.Name = "entr_bc"
        Me.entr_bc.Size = New System.Drawing.Size(240, 21)
        Me.entr_bc.TabIndex = 121
        Me.entr_bc.Title = "사원구분"
        '
        'to_year
        '
        Me.to_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_year.Location = New System.Drawing.Point(940, 52)
        Me.to_year.Name = "to_year"
        Me.to_year.Size = New System.Drawing.Size(56, 21)
        Me.to_year.TabIndex = 125
        Me.to_year.Title = "근속년(to)"
        Me.to_year.TitleWidth = 0
        '
        'duty_bc
        '
        Me.duty_bc.Location = New System.Drawing.Point(260, 148)
        Me.duty_bc.Name = "duty_bc"
        Me.duty_bc.Size = New System.Drawing.Size(240, 21)
        Me.duty_bc.TabIndex = 121
        Me.duty_bc.Title = "직책"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 110
        Me.co_cd.Title = "법인"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(8, 149)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 80
        Me.dept_nm.Title = "부서명(*)"
        '
        'pro_to
        '
        Me.pro_to.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pro_to.Location = New System.Drawing.Point(508, 172)
        Me.pro_to.Name = "pro_to"
        Me.pro_to.Size = New System.Drawing.Size(240, 21)
        Me.pro_to.TabIndex = 120
        Me.pro_to.Title = ""
        '
        'fr_year
        '
        Me.fr_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_year.Location = New System.Drawing.Point(756, 52)
        Me.fr_year.Name = "fr_year"
        Me.fr_year.Size = New System.Drawing.Size(180, 21)
        Me.fr_year.TabIndex = 123
        Me.fr_year.Title = "근속년(fr)"
        '
        'app_dt
        '
        Me.app_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.app_dt.Location = New System.Drawing.Point(508, 196)
        Me.app_dt.Name = "app_dt"
        Me.app_dt.Size = New System.Drawing.Size(240, 21)
        Me.app_dt.TabIndex = 120
        Me.app_dt.Title = "기준일근무자"
        '
        'step_bc
        '
        Me.step_bc.Location = New System.Drawing.Point(756, 100)
        Me.step_bc.Name = "step_bc"
        Me.step_bc.Size = New System.Drawing.Size(240, 21)
        Me.step_bc.TabIndex = 113
        Me.step_bc.Title = "호봉"
        '
        'high_bc
        '
        Me.high_bc.Location = New System.Drawing.Point(260, 124)
        Me.high_bc.Name = "high_bc"
        Me.high_bc.Size = New System.Drawing.Size(240, 21)
        Me.high_bc.TabIndex = 111
        Me.high_bc.Title = "직위"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(8, 125)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 109
        Me.dept_cd.Title = "부서코드(*)"
        '
        'work_bs
        '
        Me.work_bs.Location = New System.Drawing.Point(8, 76)
        Me.work_bs.Name = "work_bs"
        Me.work_bs.Size = New System.Drawing.Size(240, 21)
        Me.work_bs.TabIndex = 105
        Me.work_bs.Title = "근무사업장"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(8, 173)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 108
        Me.emp_no.Title = "사번(*)"
        '
        't_retr_dt
        '
        Me.t_retr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.t_retr_dt.Location = New System.Drawing.Point(508, 124)
        Me.t_retr_dt.Name = "t_retr_dt"
        Me.t_retr_dt.Size = New System.Drawing.Size(240, 21)
        Me.t_retr_dt.TabIndex = 99
        Me.t_retr_dt.Title = ""
        '
        't_hire_dt
        '
        Me.t_hire_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.t_hire_dt.Location = New System.Drawing.Point(508, 76)
        Me.t_hire_dt.Name = "t_hire_dt"
        Me.t_hire_dt.Size = New System.Drawing.Size(240, 21)
        Me.t_hire_dt.TabIndex = 98
        Me.t_hire_dt.Title = ""
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(8, 197)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 63
        Me.emp_nm.Title = "성명(*)"
        '
        'retr_dt
        '
        Me.retr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.retr_dt.Location = New System.Drawing.Point(508, 100)
        Me.retr_dt.Name = "retr_dt"
        Me.retr_dt.Size = New System.Drawing.Size(240, 21)
        Me.retr_dt.TabIndex = 92
        Me.retr_dt.Title = "퇴사일자"
        '
        'hire_dt
        '
        Me.hire_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.hire_dt.Location = New System.Drawing.Point(508, 52)
        Me.hire_dt.Name = "hire_dt"
        Me.hire_dt.Size = New System.Drawing.Size(240, 21)
        Me.hire_dt.TabIndex = 69
        Me.hire_dt.Title = "입사일자"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1342, 289)
        Me.g10.TabIndex = 0
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 101)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 131
        Me.fac_cd.Title = "근무공장"
        '
        'work2_bc
        '
        Me.work2_bc.Location = New System.Drawing.Point(756, 125)
        Me.work2_bc.Name = "work2_bc"
        Me.work2_bc.Size = New System.Drawing.Size(240, 21)
        Me.work2_bc.TabIndex = 132
        Me.work2_bc.Title = "근무유형"
        '
        'HRA115_2
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRA115_2"
        Me.Size = New System.Drawing.Size(1342, 522)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents retr_dt As Frame7.eDate
    Friend WithEvents hire_dt As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents t_hire_dt As Frame7.eDate
    Friend WithEvents t_retr_dt As Frame7.eDate
    Friend WithEvents work_bs As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents school_bc As Frame7.eCheckCombo
    Friend WithEvents step_bc As Frame7.eCheckCombo
    Friend WithEvents high_bc As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo
    Friend WithEvents pro_fr As Frame7.eDate
    Friend WithEvents pro_to As Frame7.eDate
    Friend WithEvents work_bc As Frame7.eCheckCombo
    Friend WithEvents hire_bc As Frame7.eCheckCombo
    Friend WithEvents entr_bc As Frame7.eCheckCombo
    Friend WithEvents work_kd As Frame7.eCheckCombo
    Friend WithEvents pay_kd As Frame7.eCheckCombo
    Friend WithEvents duty_bc As Frame7.eCheckCombo
    Friend WithEvents to_year As Frame7.eText
    Friend WithEvents fr_year As Frame7.eText
    Friend WithEvents to_age As Frame7.eText
    Friend WithEvents fr_age As Frame7.eText
    Friend WithEvents app_dt As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCheckCombo
    Friend WithEvents rank_bc As Frame7.eCheckCombo
    Friend WithEvents hcap_ty As Frame7.eOptionBox
    Friend WithEvents spc_ty As Frame7.eOptionBox
    Friend WithEvents nat_ty As Frame7.eOptionBox
    Friend WithEvents work2_bc As Frame7.eCombo
    Friend WithEvents fac_cd As Frame7.eCombo

End Class
