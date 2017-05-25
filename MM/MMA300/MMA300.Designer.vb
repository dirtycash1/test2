<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMA300
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
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.tab1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tp2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.f_cs_nm = New Frame7.eText()
        Me.f_emp_nm = New Frame7.eText()
        Me.find_r_dept_nm = New Frame7.eText()
        Me.find_cs_cd = New Frame7.eText()
        Me.find_stts = New Frame7.eCombo()
        Me.find_t_nm = New Frame7.eText()
        Me.find_r_emp = New Frame7.eText()
        Me.find_r_dept = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.t_gu = New Frame7.eCombo()
        Me.stts = New Frame7.eCombo()
        Me.d_emp = New Frame7.eText()
        Me.d_emp_nm = New Frame7.eText()
        Me.r_no = New Frame7.eText()
        Me.d_dept = New Frame7.eText()
        Me.r_dt = New Frame7.eDate()
        Me.d_dept_nm = New Frame7.eText()
        Me.t_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.r_dept_nm = New Frame7.eText()
        Me.r_emp = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.r_dept = New Frame7.eText()
        Me.r_gu = New Frame7.eCombo()
        Me.EText2 = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.tab1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1383, 611)
        Me.spc_1.SplitterDistance = 302
        Me.spc_1.TabIndex = 10
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp2
        Me.tab1.Size = New System.Drawing.Size(302, 611)
        Me.tab1.TabIndex = 50
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp2})
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.SplitContainer4)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(295, 581)
        Me.tp2.Text = "등록할 자료"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer4.Size = New System.Drawing.Size(295, 581)
        Me.SplitContainer4.SplitterDistance = 237
        Me.SplitContainer4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.f_cs_nm)
        Me.Panel3.Controls.Add(Me.f_emp_nm)
        Me.Panel3.Controls.Add(Me.find_r_dept_nm)
        Me.Panel3.Controls.Add(Me.find_cs_cd)
        Me.Panel3.Controls.Add(Me.find_stts)
        Me.Panel3.Controls.Add(Me.find_t_nm)
        Me.Panel3.Controls.Add(Me.find_r_emp)
        Me.Panel3.Controls.Add(Me.find_r_dept)
        Me.Panel3.Controls.Add(Me.from_dt)
        Me.Panel3.Controls.Add(Me.to_dt)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(295, 237)
        Me.Panel3.TabIndex = 0
        '
        'f_cs_nm
        '
        Me.f_cs_nm.ColumnName = "pl_nm"
        Me.f_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cs_nm.Location = New System.Drawing.Point(177, 97)
        Me.f_cs_nm.Name = "f_cs_nm"
        Me.f_cs_nm.Size = New System.Drawing.Size(110, 21)
        Me.f_cs_nm.TabIndex = 135
        Me.f_cs_nm.TableName = "pl_nm"
        Me.f_cs_nm.Title = "거래처명(찾기)"
        Me.f_cs_nm.TitleWidth = 0
        '
        'f_emp_nm
        '
        Me.f_emp_nm.ColumnName = "pl_nm"
        Me.f_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_emp_nm.Location = New System.Drawing.Point(177, 70)
        Me.f_emp_nm.Name = "f_emp_nm"
        Me.f_emp_nm.Size = New System.Drawing.Size(110, 21)
        Me.f_emp_nm.TabIndex = 134
        Me.f_emp_nm.TableName = "pl_nm"
        Me.f_emp_nm.Title = "외뢰자명(찾기)"
        Me.f_emp_nm.TitleWidth = 0
        '
        'find_r_dept_nm
        '
        Me.find_r_dept_nm.ColumnName = "pl_nm"
        Me.find_r_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_r_dept_nm.Location = New System.Drawing.Point(177, 43)
        Me.find_r_dept_nm.Name = "find_r_dept_nm"
        Me.find_r_dept_nm.Size = New System.Drawing.Size(110, 21)
        Me.find_r_dept_nm.TabIndex = 133
        Me.find_r_dept_nm.TableName = "pl_nm"
        Me.find_r_dept_nm.Title = "의뢰부서명"
        Me.find_r_dept_nm.TitleWidth = 0
        '
        'find_cs_cd
        '
        Me.find_cs_cd.ColumnName = "ps_cd"
        Me.find_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_cd.Location = New System.Drawing.Point(16, 97)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(155, 21)
        Me.find_cs_cd.TabIndex = 132
        Me.find_cs_cd.TableName = "ps_cd"
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 60
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(16, 150)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(168, 21)
        Me.find_stts.TabIndex = 131
        Me.find_stts.Title = "진행상태"
        Me.find_stts.TitleWidth = 60
        '
        'find_t_nm
        '
        Me.find_t_nm.ColumnName = "ps_cd"
        Me.find_t_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_t_nm.Location = New System.Drawing.Point(16, 123)
        Me.find_t_nm.Name = "find_t_nm"
        Me.find_t_nm.Size = New System.Drawing.Size(168, 21)
        Me.find_t_nm.TabIndex = 124
        Me.find_t_nm.TableName = "ps_cd"
        Me.find_t_nm.Title = "테스트명"
        Me.find_t_nm.TitleWidth = 60
        '
        'find_r_emp
        '
        Me.find_r_emp.ColumnName = "ps_cd"
        Me.find_r_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_r_emp.Location = New System.Drawing.Point(16, 70)
        Me.find_r_emp.Name = "find_r_emp"
        Me.find_r_emp.Size = New System.Drawing.Size(155, 21)
        Me.find_r_emp.TabIndex = 123
        Me.find_r_emp.TableName = "ps_cd"
        Me.find_r_emp.Title = "의뢰자"
        Me.find_r_emp.TitleWidth = 60
        '
        'find_r_dept
        '
        Me.find_r_dept.ColumnName = "ps_cd"
        Me.find_r_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_r_dept.Location = New System.Drawing.Point(16, 43)
        Me.find_r_dept.Name = "find_r_dept"
        Me.find_r_dept.Size = New System.Drawing.Size(155, 21)
        Me.find_r_dept.TabIndex = 107
        Me.find_r_dept.TableName = "ps_cd"
        Me.find_r_dept.Title = "의뢰부서"
        Me.find_r_dept.TitleWidth = 60
        '
        'from_dt
        '
        Me.from_dt.ColumnName = "plan_dt"
        Me.from_dt.Location = New System.Drawing.Point(16, 16)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(155, 21)
        Me.from_dt.TabIndex = 105
        Me.from_dt.TableName = "plan_dt"
        Me.from_dt.Title = "의뢰일자"
        Me.from_dt.TitleWidth = 60
        '
        'to_dt
        '
        Me.to_dt.ColumnName = "plan_dt"
        Me.to_dt.Location = New System.Drawing.Point(177, 16)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(110, 21)
        Me.to_dt.TabIndex = 106
        Me.to_dt.TableName = "plan_dt"
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel)
        Me.Panel4.Controls.Add(Me.btn_find)
        Me.Panel4.Controls.Add(Me.find_visible)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 196)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(295, 41)
        Me.Panel4.TabIndex = 2
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(98, 6)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 27)
        Me.btn_cancel.TabIndex = 72
        Me.btn_cancel.Text = "취   소"
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(10, 6)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(72, 27)
        Me.btn_find.TabIndex = 71
        Me.btn_find.Text = "검   색"
        '
        'find_visible
        '
        Me.find_visible.AutoSize = True
        Me.find_visible.Checked = True
        Me.find_visible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.find_visible.Dock = System.Windows.Forms.DockStyle.Right
        Me.find_visible.Location = New System.Drawing.Point(201, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(92, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(295, 340)
        Me.g_list.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1077, 611)
        Me.SplitContainer2.SplitterDistance = 403
        Me.SplitContainer2.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1077, 403)
        Me.SplitContainer1.SplitterDistance = 169
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.t_gu)
        Me.EPanel2.Controls.Add(Me.stts)
        Me.EPanel2.Controls.Add(Me.d_emp)
        Me.EPanel2.Controls.Add(Me.d_emp_nm)
        Me.EPanel2.Controls.Add(Me.r_no)
        Me.EPanel2.Controls.Add(Me.d_dept)
        Me.EPanel2.Controls.Add(Me.r_dt)
        Me.EPanel2.Controls.Add(Me.d_dept_nm)
        Me.EPanel2.Controls.Add(Me.t_nm)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.r_dept_nm)
        Me.EPanel2.Controls.Add(Me.r_emp)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.r_dept)
        Me.EPanel2.Controls.Add(Me.r_gu)
        Me.EPanel2.Controls.Add(Me.EText2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1077, 169)
        Me.EPanel2.TabIndex = 124
        Me.EPanel2.Text = "     PairSourcing 이력관리"
        '
        't_gu
        '
        Me.t_gu.Location = New System.Drawing.Point(17, 126)
        Me.t_gu.Name = "t_gu"
        Me.t_gu.Size = New System.Drawing.Size(224, 21)
        Me.t_gu.TabIndex = 131
        Me.t_gu.Title = "테스트구분"
        Me.t_gu.TitleWidth = 90
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(680, 98)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(192, 21)
        Me.stts.TabIndex = 130
        Me.stts.Title = "진행상태"
        Me.stts.TitleWidth = 80
        '
        'd_emp
        '
        Me.d_emp.ColumnName = "ps_cd"
        Me.d_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_emp.Location = New System.Drawing.Point(680, 70)
        Me.d_emp.Name = "d_emp"
        Me.d_emp.Size = New System.Drawing.Size(176, 21)
        Me.d_emp.TabIndex = 126
        Me.d_emp.TableName = "ps_cd"
        Me.d_emp.Title = "등록자"
        Me.d_emp.TitleWidth = 80
        '
        'd_emp_nm
        '
        Me.d_emp_nm.ColumnName = "pl_nm"
        Me.d_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_emp_nm.Location = New System.Drawing.Point(862, 70)
        Me.d_emp_nm.Name = "d_emp_nm"
        Me.d_emp_nm.Size = New System.Drawing.Size(115, 21)
        Me.d_emp_nm.TabIndex = 127
        Me.d_emp_nm.TableName = "pl_nm"
        Me.d_emp_nm.Title = "등록자명"
        Me.d_emp_nm.TitleWidth = 0
        '
        'r_no
        '
        Me.r_no.ColumnName = "ps_cd"
        Me.r_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_no.Location = New System.Drawing.Point(17, 41)
        Me.r_no.Name = "r_no"
        Me.r_no.Size = New System.Drawing.Size(224, 21)
        Me.r_no.TabIndex = 132
        Me.r_no.TableName = "ps_cd"
        Me.r_no.Title = "관리번호"
        Me.r_no.TitleWidth = 90
        '
        'd_dept
        '
        Me.d_dept.ColumnName = "ps_cd"
        Me.d_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_dept.Location = New System.Drawing.Point(680, 41)
        Me.d_dept.Name = "d_dept"
        Me.d_dept.Size = New System.Drawing.Size(176, 21)
        Me.d_dept.TabIndex = 124
        Me.d_dept.TableName = "ps_cd"
        Me.d_dept.Title = "등록부서"
        Me.d_dept.TitleWidth = 80
        '
        'r_dt
        '
        Me.r_dt.ColumnName = "plan_dt"
        Me.r_dt.Location = New System.Drawing.Point(17, 70)
        Me.r_dt.Name = "r_dt"
        Me.r_dt.Size = New System.Drawing.Size(224, 21)
        Me.r_dt.TabIndex = 103
        Me.r_dt.TableName = "plan_dt"
        Me.r_dt.Title = "의뢰일자"
        Me.r_dt.TitleWidth = 90
        '
        'd_dept_nm
        '
        Me.d_dept_nm.ColumnName = "pl_nm"
        Me.d_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d_dept_nm.Location = New System.Drawing.Point(862, 41)
        Me.d_dept_nm.Name = "d_dept_nm"
        Me.d_dept_nm.Size = New System.Drawing.Size(115, 21)
        Me.d_dept_nm.TabIndex = 125
        Me.d_dept_nm.TableName = "pl_nm"
        Me.d_dept_nm.Title = "등록부서명"
        Me.d_dept_nm.TitleWidth = 0
        '
        't_nm
        '
        Me.t_nm.ColumnName = "ps_cd"
        Me.t_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.t_nm.Location = New System.Drawing.Point(17, 98)
        Me.t_nm.Name = "t_nm"
        Me.t_nm.Size = New System.Drawing.Size(224, 21)
        Me.t_nm.TabIndex = 100
        Me.t_nm.TableName = "ps_cd"
        Me.t_nm.Title = "테스트명"
        Me.t_nm.TitleWidth = 90
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "ps_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(306, 98)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(176, 21)
        Me.cs_cd.TabIndex = 128
        Me.cs_cd.TableName = "ps_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 90
        '
        'r_dept_nm
        '
        Me.r_dept_nm.ColumnName = "pl_nm"
        Me.r_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_dept_nm.Location = New System.Drawing.Point(488, 41)
        Me.r_dept_nm.Name = "r_dept_nm"
        Me.r_dept_nm.Size = New System.Drawing.Size(115, 21)
        Me.r_dept_nm.TabIndex = 91
        Me.r_dept_nm.TableName = "pl_nm"
        Me.r_dept_nm.Title = "의뢰부서명"
        Me.r_dept_nm.TitleWidth = 0
        '
        'r_emp
        '
        Me.r_emp.ColumnName = "ps_cd"
        Me.r_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_emp.Location = New System.Drawing.Point(306, 70)
        Me.r_emp.Name = "r_emp"
        Me.r_emp.Size = New System.Drawing.Size(176, 21)
        Me.r_emp.TabIndex = 122
        Me.r_emp.TableName = "ps_cd"
        Me.r_emp.Title = "의뢰자"
        Me.r_emp.TitleWidth = 90
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "pl_nm"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(488, 98)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(115, 21)
        Me.cs_nm.TabIndex = 129
        Me.cs_nm.TableName = "pl_nm"
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 0
        '
        'r_dept
        '
        Me.r_dept.ColumnName = "ps_cd"
        Me.r_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_dept.Location = New System.Drawing.Point(306, 41)
        Me.r_dept.Name = "r_dept"
        Me.r_dept.Size = New System.Drawing.Size(176, 21)
        Me.r_dept.TabIndex = 90
        Me.r_dept.TableName = "ps_cd"
        Me.r_dept.Title = "의뢰부서"
        Me.r_dept.TitleWidth = 90
        '
        'r_gu
        '
        Me.r_gu.Location = New System.Drawing.Point(680, 126)
        Me.r_gu.Name = "r_gu"
        Me.r_gu.Size = New System.Drawing.Size(192, 21)
        Me.r_gu.TabIndex = 119
        Me.r_gu.Title = "의뢰구분"
        Me.r_gu.TitleWidth = 80
        '
        'EText2
        '
        Me.EText2.ColumnName = "pl_nm"
        Me.EText2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText2.Location = New System.Drawing.Point(488, 70)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(115, 21)
        Me.EText2.TabIndex = 123
        Me.EText2.TableName = "pl_nm"
        Me.EText2.Title = "의뢰자명"
        Me.EText2.TitleWidth = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1077, 230)
        Me.g10.TabIndex = 1
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage6
        Me.XtraTabControl2.Size = New System.Drawing.Size(1077, 204)
        Me.XtraTabControl2.TabIndex = 54
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage6, Me.XtraTabPage7})
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.g20)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1070, 174)
        Me.XtraTabPage6.Text = "세부사항"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1070, 174)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.g30)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1070, 174)
        Me.XtraTabPage7.Text = "관련 문서"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(1070, 174)
        Me.g30.TabIndex = 2
        '
        'MMA300
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "MMA300"
        Me.Size = New System.Drawing.Size(1383, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents find_t_nm As Frame7.eText
    Friend WithEvents find_r_emp As Frame7.eText
    Friend WithEvents find_r_dept As Frame7.eText
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents r_dept_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents t_gu As Frame7.eCombo
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents d_emp As Frame7.eText
    Friend WithEvents d_emp_nm As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents d_dept As Frame7.eText
    Friend WithEvents d_dept_nm As Frame7.eText
    Friend WithEvents r_emp As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents r_no As Frame7.eText
    Friend WithEvents r_dept As Frame7.eText
    Friend WithEvents r_dt As Frame7.eDate
    Friend WithEvents r_gu As Frame7.eCombo
    Friend WithEvents t_nm As Frame7.eText
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents find_r_dept_nm As Frame7.eText
    Friend WithEvents f_emp_nm As Frame7.eText
    Friend WithEvents f_cs_nm As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid

End Class
