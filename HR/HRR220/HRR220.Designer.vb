<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRR220
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
        Me.e_high_bc = New Frame7.eCombo()
        Me.e_dept_nm = New Frame7.eText()
        Me.step_sq = New Frame7.eCombo()
        Me.term_bc = New Frame7.eCombo()
        Me.f_emp_no = New Frame7.eText()
        Me.f_emp_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.duty_bc = New Frame7.eCombo()
        Me.hire_dt = New Frame7.eDate()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.itm_kd = New Frame7.eCombo()
        Me.EPanel4 = New Frame7.ePanel()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.e_dsc = New Frame7.eMemo()
        Me.ECheck5 = New Frame7.eCheck()
        Me.ECheck4 = New Frame7.eCheck()
        Me.ECheck3 = New Frame7.eCheck()
        Me.ECheck2 = New Frame7.eCheck()
        Me.c_qty = New Frame7.eText()
        Me.d_sum = New Frame7.eText()
        Me.b_sum = New Frame7.eText()
        Me.d_qty = New Frame7.eText()
        Me.a_sum = New Frame7.eText()
        Me.e_pnt = New Frame7.eText()
        Me.b_qty = New Frame7.eText()
        Me.a_qty = New Frame7.eText()
        Me.c_sum = New Frame7.eText()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.e1_dsc = New Frame7.eMemo()
        Me.e1_emp_nm = New Frame7.eText()
        Me.e1_pnt = New Frame7.eText()
        Me.e2_dsc = New Frame7.eMemo()
        Me.e2_emp_nm = New Frame7.eText()
        Me.e2_pnt = New Frame7.eText()
        Me.itm_cnt = New Frame7.eText()
        Me.chk_cnt = New Frame7.eText()
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
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 687)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.eval_year)
        Me.EPanel1.Controls.Add(Me.e_high_bc)
        Me.EPanel1.Controls.Add(Me.e_dept_nm)
        Me.EPanel1.Controls.Add(Me.step_sq)
        Me.EPanel1.Controls.Add(Me.term_bc)
        Me.EPanel1.Controls.Add(Me.f_emp_no)
        Me.EPanel1.Controls.Add(Me.f_emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     평가자 정보"
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
        Me.eval_year.TabIndex = 5
        Me.eval_year.Title = "기준년도"
        '
        'e_high_bc
        '
        Me.e_high_bc.Location = New System.Drawing.Point(776, 52)
        Me.e_high_bc.Name = "e_high_bc"
        Me.e_high_bc.Size = New System.Drawing.Size(240, 21)
        Me.e_high_bc.TabIndex = 8
        Me.e_high_bc.Title = "평가자(직위)"
        '
        'e_dept_nm
        '
        Me.e_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e_dept_nm.Location = New System.Drawing.Point(776, 28)
        Me.e_dept_nm.Name = "e_dept_nm"
        Me.e_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.e_dept_nm.TabIndex = 4
        Me.e_dept_nm.Title = "평가자(부서명)"
        '
        'step_sq
        '
        Me.step_sq.Location = New System.Drawing.Point(260, 52)
        Me.step_sq.Name = "step_sq"
        Me.step_sq.Size = New System.Drawing.Size(240, 21)
        Me.step_sq.TabIndex = 6
        Me.step_sq.Title = "평가차수"
        '
        'term_bc
        '
        Me.term_bc.Location = New System.Drawing.Point(260, 28)
        Me.term_bc.Name = "term_bc"
        Me.term_bc.Size = New System.Drawing.Size(240, 21)
        Me.term_bc.TabIndex = 2
        Me.term_bc.Title = "평가주기"
        '
        'f_emp_no
        '
        Me.f_emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_no.Location = New System.Drawing.Point(516, 28)
        Me.f_emp_no.Name = "f_emp_no"
        Me.f_emp_no.Size = New System.Drawing.Size(240, 21)
        Me.f_emp_no.TabIndex = 3
        Me.f_emp_no.Title = "평가자(사번)"
        '
        'f_emp_nm
        '
        Me.f_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_nm.Location = New System.Drawing.Point(516, 52)
        Me.f_emp_nm.Name = "f_emp_nm"
        Me.f_emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_emp_nm.TabIndex = 7
        Me.f_emp_nm.Title = "평가자명"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 602)
        Me.SplitContainer2.SplitterDistance = 247
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(247, 602)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     평가대상자 List"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(243, 577)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(931, 602)
        Me.SplitContainer3.SplitterDistance = 76
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.emp_no)
        Me.EPanel3.Controls.Add(Me.emp_nm)
        Me.EPanel3.Controls.Add(Me.itm_cnt)
        Me.EPanel3.Controls.Add(Me.duty_bc)
        Me.EPanel3.Controls.Add(Me.chk_cnt)
        Me.EPanel3.Controls.Add(Me.hire_dt)
        Me.EPanel3.Controls.Add(Me.dept_cd)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.itm_kd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(931, 76)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     직무수행능력평가_A형_대상자정보"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(8, 28)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 10
        Me.emp_no.Title = "대상자(사번)"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(132, 28)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 11
        '
        'duty_bc
        '
        Me.duty_bc.Location = New System.Drawing.Point(388, 52)
        Me.duty_bc.Name = "duty_bc"
        Me.duty_bc.Size = New System.Drawing.Size(240, 21)
        Me.duty_bc.TabIndex = 15
        Me.duty_bc.Title = "직책"
        '
        'hire_dt
        '
        Me.hire_dt.Location = New System.Drawing.Point(388, 28)
        Me.hire_dt.Name = "hire_dt"
        Me.hire_dt.Size = New System.Drawing.Size(240, 21)
        Me.hire_dt.TabIndex = 12
        Me.hire_dt.Title = "입사일자"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(8, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 13
        Me.dept_cd.Title = "대상자(소속부서)"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(132, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 14
        '
        'itm_kd
        '
        Me.itm_kd.Location = New System.Drawing.Point(388, 104)
        Me.itm_kd.Name = "itm_kd"
        Me.itm_kd.Size = New System.Drawing.Size(240, 21)
        Me.itm_kd.TabIndex = 9
        Me.itm_kd.Title = "고과구분"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.SplitContainer4)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(931, 522)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     직무수행능력평가_A형_등록 ( 범례 : A - 4.6점, B - 4점, C - 3.6점, D - 3.2점 )"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer4.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.g20)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer4.Size = New System.Drawing.Size(927, 497)
        Me.SplitContainer4.SplitterDistance = 226
        Me.SplitContainer4.TabIndex = 24
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(927, 226)
        Me.g20.TabIndex = 3
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.e_dsc)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ECheck5)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ECheck4)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ECheck3)
        Me.SplitContainer5.Panel1.Controls.Add(Me.ECheck2)
        Me.SplitContainer5.Panel1.Controls.Add(Me.c_qty)
        Me.SplitContainer5.Panel1.Controls.Add(Me.d_sum)
        Me.SplitContainer5.Panel1.Controls.Add(Me.b_sum)
        Me.SplitContainer5.Panel1.Controls.Add(Me.d_qty)
        Me.SplitContainer5.Panel1.Controls.Add(Me.a_sum)
        Me.SplitContainer5.Panel1.Controls.Add(Me.e_pnt)
        Me.SplitContainer5.Panel1.Controls.Add(Me.b_qty)
        Me.SplitContainer5.Panel1.Controls.Add(Me.a_qty)
        Me.SplitContainer5.Panel1.Controls.Add(Me.c_sum)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Panel2MinSize = 1
        Me.SplitContainer5.Size = New System.Drawing.Size(927, 267)
        Me.SplitContainer5.SplitterDistance = 103
        Me.SplitContainer5.TabIndex = 25
        '
        'e_dsc
        '
        Me.e_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e_dsc.Location = New System.Drawing.Point(8, 59)
        Me.e_dsc.Name = "e_dsc"
        Me.e_dsc.Size = New System.Drawing.Size(744, 35)
        Me.e_dsc.TabIndex = 28
        Me.e_dsc.Title = "평가자 의견"
        Me.e_dsc.TitleWidth = 90
        '
        'ECheck5
        '
        Me.ECheck5.Caption = ""
        Me.ECheck5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck5.Location = New System.Drawing.Point(364, 32)
        Me.ECheck5.Name = "ECheck5"
        Me.ECheck5.Size = New System.Drawing.Size(70, 21)
        Me.ECheck5.TabIndex = 27
        Me.ECheck5.Title = " 개 X 3.2 ="
        Me.ECheck5.TitleWidth = 700
        '
        'ECheck4
        '
        Me.ECheck4.Caption = ""
        Me.ECheck4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck4.Location = New System.Drawing.Point(112, 32)
        Me.ECheck4.Name = "ECheck4"
        Me.ECheck4.Size = New System.Drawing.Size(70, 21)
        Me.ECheck4.TabIndex = 26
        Me.ECheck4.Title = " 개 X 3.6 ="
        Me.ECheck4.TitleWidth = 700
        '
        'ECheck3
        '
        Me.ECheck3.Caption = ""
        Me.ECheck3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck3.Location = New System.Drawing.Point(364, 8)
        Me.ECheck3.Name = "ECheck3"
        Me.ECheck3.Size = New System.Drawing.Size(70, 21)
        Me.ECheck3.TabIndex = 25
        Me.ECheck3.Title = " 개 X 4.0 ="
        Me.ECheck3.TitleWidth = 700
        '
        'ECheck2
        '
        Me.ECheck2.Caption = ""
        Me.ECheck2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck2.Location = New System.Drawing.Point(112, 8)
        Me.ECheck2.Name = "ECheck2"
        Me.ECheck2.Size = New System.Drawing.Size(70, 21)
        Me.ECheck2.TabIndex = 24
        Me.ECheck2.Title = " 개 X 4.6 ="
        Me.ECheck2.TitleWidth = 700
        '
        'c_qty
        '
        Me.c_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_qty.Location = New System.Drawing.Point(8, 32)
        Me.c_qty.Name = "c_qty"
        Me.c_qty.Size = New System.Drawing.Size(100, 21)
        Me.c_qty.TabIndex = 14
        Me.c_qty.Title = "C"
        Me.c_qty.TitleAlign = Frame7.Alignment.Center
        Me.c_qty.TitleWidth = 50
        '
        'd_sum
        '
        Me.d_sum.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_sum.Location = New System.Drawing.Point(436, 32)
        Me.d_sum.Name = "d_sum"
        Me.d_sum.Size = New System.Drawing.Size(50, 21)
        Me.d_sum.TabIndex = 22
        Me.d_sum.Title = "d_sum"
        Me.d_sum.TitleWidth = 0
        '
        'b_sum
        '
        Me.b_sum.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.b_sum.Location = New System.Drawing.Point(436, 8)
        Me.b_sum.Name = "b_sum"
        Me.b_sum.Size = New System.Drawing.Size(50, 21)
        Me.b_sum.TabIndex = 19
        Me.b_sum.Title = "b_sum"
        Me.b_sum.TitleWidth = 0
        '
        'd_qty
        '
        Me.d_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_qty.Location = New System.Drawing.Point(260, 32)
        Me.d_qty.Name = "d_qty"
        Me.d_qty.Size = New System.Drawing.Size(100, 21)
        Me.d_qty.TabIndex = 20
        Me.d_qty.Title = "D"
        Me.d_qty.TitleAlign = Frame7.Alignment.Center
        Me.d_qty.TitleWidth = 50
        '
        'a_sum
        '
        Me.a_sum.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.a_sum.Location = New System.Drawing.Point(188, 8)
        Me.a_sum.Name = "a_sum"
        Me.a_sum.Size = New System.Drawing.Size(50, 21)
        Me.a_sum.TabIndex = 13
        Me.a_sum.Title = "a_sum"
        Me.a_sum.TitleWidth = 0
        '
        'e_pnt
        '
        Me.e_pnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e_pnt.Location = New System.Drawing.Point(500, 32)
        Me.e_pnt.Name = "e_pnt"
        Me.e_pnt.Size = New System.Drawing.Size(100, 21)
        Me.e_pnt.TabIndex = 23
        Me.e_pnt.Title = "평점"
        Me.e_pnt.TitleWidth = 50
        '
        'b_qty
        '
        Me.b_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.b_qty.Location = New System.Drawing.Point(260, 8)
        Me.b_qty.Name = "b_qty"
        Me.b_qty.Size = New System.Drawing.Size(100, 21)
        Me.b_qty.TabIndex = 17
        Me.b_qty.Title = "B"
        Me.b_qty.TitleAlign = Frame7.Alignment.Center
        Me.b_qty.TitleWidth = 50
        '
        'a_qty
        '
        Me.a_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.a_qty.Location = New System.Drawing.Point(8, 8)
        Me.a_qty.Name = "a_qty"
        Me.a_qty.Size = New System.Drawing.Size(100, 21)
        Me.a_qty.TabIndex = 10
        Me.a_qty.Title = "A"
        Me.a_qty.TitleAlign = Frame7.Alignment.Center
        Me.a_qty.TitleWidth = 50
        '
        'c_sum
        '
        Me.c_sum.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_sum.Location = New System.Drawing.Point(188, 32)
        Me.c_sum.Name = "c_sum"
        Me.c_sum.Size = New System.Drawing.Size(50, 21)
        Me.c_sum.TabIndex = 16
        Me.c_sum.Title = "c_sum"
        Me.c_sum.TitleWidth = 0
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.e1_dsc)
        Me.SplitContainer6.Panel1.Controls.Add(Me.e1_emp_nm)
        Me.SplitContainer6.Panel1.Controls.Add(Me.e1_pnt)
        Me.SplitContainer6.Panel1MinSize = 2
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.e2_dsc)
        Me.SplitContainer6.Panel2.Controls.Add(Me.e2_emp_nm)
        Me.SplitContainer6.Panel2.Controls.Add(Me.e2_pnt)
        Me.SplitContainer6.Size = New System.Drawing.Size(927, 160)
        Me.SplitContainer6.SplitterDistance = 79
        Me.SplitContainer6.TabIndex = 0
        '
        'e1_dsc
        '
        Me.e1_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e1_dsc.Location = New System.Drawing.Point(8, 35)
        Me.e1_dsc.Name = "e1_dsc"
        Me.e1_dsc.Size = New System.Drawing.Size(744, 35)
        Me.e1_dsc.TabIndex = 28
        Me.e1_dsc.Title = "1차 평가자 의견"
        Me.e1_dsc.TitleWidth = 90
        '
        'e1_emp_nm
        '
        Me.e1_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e1_emp_nm.Location = New System.Drawing.Point(238, 8)
        Me.e1_emp_nm.Name = "e1_emp_nm"
        Me.e1_emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.e1_emp_nm.TabIndex = 26
        Me.e1_emp_nm.Title = "1차 평가자명"
        '
        'e1_pnt
        '
        Me.e1_pnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e1_pnt.Location = New System.Drawing.Point(8, 8)
        Me.e1_pnt.Name = "e1_pnt"
        Me.e1_pnt.Size = New System.Drawing.Size(164, 21)
        Me.e1_pnt.TabIndex = 25
        Me.e1_pnt.Title = "1차 평점"
        Me.e1_pnt.TitleWidth = 90
        '
        'e2_dsc
        '
        Me.e2_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e2_dsc.Location = New System.Drawing.Point(8, 33)
        Me.e2_dsc.Name = "e2_dsc"
        Me.e2_dsc.Size = New System.Drawing.Size(744, 35)
        Me.e2_dsc.TabIndex = 28
        Me.e2_dsc.Title = "2차 평가자 의견"
        Me.e2_dsc.TitleWidth = 90
        '
        'e2_emp_nm
        '
        Me.e2_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e2_emp_nm.Location = New System.Drawing.Point(238, 8)
        Me.e2_emp_nm.Name = "e2_emp_nm"
        Me.e2_emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.e2_emp_nm.TabIndex = 27
        Me.e2_emp_nm.Title = "2차 평가자명"
        '
        'e2_pnt
        '
        Me.e2_pnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.e2_pnt.Location = New System.Drawing.Point(8, 8)
        Me.e2_pnt.Name = "e2_pnt"
        Me.e2_pnt.Size = New System.Drawing.Size(164, 21)
        Me.e2_pnt.TabIndex = 27
        Me.e2_pnt.Title = "2차 평점"
        Me.e2_pnt.TitleWidth = 90
        '
        'itm_cnt
        '
        Me.itm_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cnt.Location = New System.Drawing.Point(634, 28)
        Me.itm_cnt.Name = "itm_cnt"
        Me.itm_cnt.Size = New System.Drawing.Size(240, 21)
        Me.itm_cnt.TabIndex = 16
        Me.itm_cnt.Title = "총문항수"
        '
        'chk_cnt
        '
        Me.chk_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_cnt.Location = New System.Drawing.Point(634, 50)
        Me.chk_cnt.Name = "chk_cnt"
        Me.chk_cnt.Size = New System.Drawing.Size(240, 21)
        Me.chk_cnt.TabIndex = 16
        Me.chk_cnt.Title = "총 답항수"
        '
        'HRR220
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRR220"
        Me.Size = New System.Drawing.Size(1182, 687)
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents eval_year As Frame7.eDate
    Friend WithEvents term_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents f_emp_no As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents duty_bc As Frame7.eCombo
    Friend WithEvents hire_dt As Frame7.eDate
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents itm_kd As Frame7.eCombo
    Friend WithEvents step_sq As Frame7.eCombo
    Friend WithEvents f_emp_nm As Frame7.eText
    Friend WithEvents e_dept_nm As Frame7.eText
    Friend WithEvents e_high_bc As Frame7.eCombo
    Friend WithEvents d_sum As Frame7.eText
    Friend WithEvents a_sum As Frame7.eText
    Friend WithEvents c_sum As Frame7.eText
    Friend WithEvents b_sum As Frame7.eText
    Friend WithEvents a_qty As Frame7.eText
    Friend WithEvents e_pnt As Frame7.eText
    Friend WithEvents c_qty As Frame7.eText
    Friend WithEvents b_qty As Frame7.eText
    Friend WithEvents d_qty As Frame7.eText
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents e1_emp_nm As Frame7.eText
    Friend WithEvents e1_pnt As Frame7.eText
    Friend WithEvents e2_emp_nm As Frame7.eText
    Friend WithEvents e2_pnt As Frame7.eText
    Friend WithEvents ECheck3 As Frame7.eCheck
    Friend WithEvents ECheck2 As Frame7.eCheck
    Friend WithEvents ECheck5 As Frame7.eCheck
    Friend WithEvents ECheck4 As Frame7.eCheck
    Friend WithEvents e_dsc As Frame7.eMemo
    Friend WithEvents e1_dsc As Frame7.eMemo
    Friend WithEvents e2_dsc As Frame7.eMemo
    Friend WithEvents itm_cnt As Frame7.eText
    Friend WithEvents chk_cnt As Frame7.eText

End Class
