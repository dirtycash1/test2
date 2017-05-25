<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_JA1165
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
        Me.tp1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.g_list = New Frame7.eGrid()
        Me.tp2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.find_bal_no2 = New Frame7.eText()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find2 = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible2 = New System.Windows.Forms.CheckBox()
        Me.find_to2 = New Frame7.eDate()
        Me.find_from2 = New Frame7.eDate()
        Me.find_cs_nm2 = New Frame7.eText()
        Me.g_list2 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.remk = New Frame7.eText()
        Me.GD_CD = New Frame7.eText()
        Me.bal_no = New Frame7.eText()
        Me.job_type = New Frame7.eCombo()
        Me.pr_qty = New Frame7.eText()
        Me.ip_dt = New Frame7.eDate()
        Me.ps_cd = New Frame7.eText()
        Me.job_qty = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.ip_no = New Frame7.eText()
        Me.TWH_CD = New Frame7.eCombo()
        Me.FWH_CD = New Frame7.eCombo()
        Me.unit_cd = New Frame7.eCombo()
        Me.sa_cd = New Frame7.eCombo()
        Me.gd_nm = New Frame7.eText()
        Me.spec = New Frame7.eText()
        Me.g_body = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ep_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 3
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(374, 611)
        Me.tab1.TabIndex = 49
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1, Me.tp2})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer1)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(367, 581)
        Me.tp1.Text = "검색 조건"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(367, 581)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.find_to)
        Me.Panel2.Controls.Add(Me.find_from)
        Me.Panel2.Controls.Add(Me.find_cs_nm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 190)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 41)
        Me.Panel1.TabIndex = 2
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
        Me.find_visible.Location = New System.Drawing.Point(273, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(92, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(187, 30)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 51
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(25, 30)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 50
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.ColumnName = "find_paymenterm_cd"
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(25, 58)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm.TabIndex = 48
        Me.find_cs_nm.TableName = "find_paymenterm_cd"
        Me.find_cs_nm.Title = "거래처명"
        Me.find_cs_nm.TitleWidth = 60
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(367, 387)
        Me.g_list.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.SplitContainer4)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(367, 581)
        Me.tp2.Text = "등록할 자료"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer4.Panel2.Controls.Add(Me.g_list2)
        Me.SplitContainer4.Size = New System.Drawing.Size(367, 581)
        Me.SplitContainer4.SplitterDistance = 190
        Me.SplitContainer4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.find_bal_no2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.find_to2)
        Me.Panel3.Controls.Add(Me.find_from2)
        Me.Panel3.Controls.Add(Me.find_cs_nm2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 190)
        Me.Panel3.TabIndex = 0
        '
        'find_bal_no2
        '
        Me.find_bal_no2.Location = New System.Drawing.Point(25, 78)
        Me.find_bal_no2.Name = "find_bal_no2"
        Me.find_bal_no2.Size = New System.Drawing.Size(273, 21)
        Me.find_bal_no2.TabIndex = 52
        Me.find_bal_no2.Title = "발주번호"
        Me.find_bal_no2.TitleWidth = 60
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel2)
        Me.Panel4.Controls.Add(Me.btn_find2)
        Me.Panel4.Controls.Add(Me.find_visible2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 41)
        Me.Panel4.TabIndex = 2
        '
        'btn_cancel2
        '
        Me.btn_cancel2.Location = New System.Drawing.Point(98, 6)
        Me.btn_cancel2.Name = "btn_cancel2"
        Me.btn_cancel2.Size = New System.Drawing.Size(72, 27)
        Me.btn_cancel2.TabIndex = 72
        Me.btn_cancel2.Text = "취   소"
        '
        'btn_find2
        '
        Me.btn_find2.Location = New System.Drawing.Point(10, 6)
        Me.btn_find2.Name = "btn_find2"
        Me.btn_find2.Size = New System.Drawing.Size(72, 27)
        Me.btn_find2.TabIndex = 71
        Me.btn_find2.Text = "검   색"
        '
        'find_visible2
        '
        Me.find_visible2.AutoSize = True
        Me.find_visible2.Checked = True
        Me.find_visible2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.find_visible2.Dock = System.Windows.Forms.DockStyle.Right
        Me.find_visible2.Location = New System.Drawing.Point(273, 0)
        Me.find_visible2.Name = "find_visible2"
        Me.find_visible2.Size = New System.Drawing.Size(92, 39)
        Me.find_visible2.TabIndex = 48
        Me.find_visible2.Text = "선택 후 숨김"
        Me.find_visible2.UseVisualStyleBackColor = True
        '
        'find_to2
        '
        Me.find_to2.Location = New System.Drawing.Point(187, 30)
        Me.find_to2.Name = "find_to2"
        Me.find_to2.Size = New System.Drawing.Size(111, 21)
        Me.find_to2.TabIndex = 51
        Me.find_to2.Title = "~"
        Me.find_to2.TitleWidth = 10
        '
        'find_from2
        '
        Me.find_from2.Location = New System.Drawing.Point(25, 30)
        Me.find_from2.Name = "find_from2"
        Me.find_from2.Size = New System.Drawing.Size(159, 21)
        Me.find_from2.TabIndex = 50
        Me.find_from2.Title = "납기기간"
        Me.find_from2.TitleWidth = 60
        '
        'find_cs_nm2
        '
        Me.find_cs_nm2.ColumnName = "find_paymenterm_cd"
        Me.find_cs_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm2.Location = New System.Drawing.Point(25, 54)
        Me.find_cs_nm2.Name = "find_cs_nm2"
        Me.find_cs_nm2.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm2.TabIndex = 48
        Me.find_cs_nm2.TableName = "find_paymenterm_cd"
        Me.find_cs_nm2.Title = "거래처명"
        Me.find_cs_nm2.TitleWidth = 60
        '
        'g_list2
        '
        Me.g_list2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list2.Location = New System.Drawing.Point(0, 0)
        Me.g_list2.Name = "g_list2"
        Me.g_list2.ReadOnly = False
        Me.g_list2.RowHeight = -1
        Me.g_list2.Size = New System.Drawing.Size(367, 387)
        Me.g_list2.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.ep_head)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 611)
        Me.SplitContainer2.SplitterDistance = 195
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.GD_CD)
        Me.ep_head.Controls.Add(Me.bal_no)
        Me.ep_head.Controls.Add(Me.job_type)
        Me.ep_head.Controls.Add(Me.pr_qty)
        Me.ep_head.Controls.Add(Me.ip_dt)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.job_qty)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.stts)
        Me.ep_head.Controls.Add(Me.ip_no)
        Me.ep_head.Controls.Add(Me.TWH_CD)
        Me.ep_head.Controls.Add(Me.FWH_CD)
        Me.ep_head.Controls.Add(Me.unit_cd)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.gd_nm)
        Me.ep_head.Controls.Add(Me.spec)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(804, 195)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     생산외주실적등록"
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(19, 161)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(553, 21)
        Me.remk.TabIndex = 134
        Me.remk.Title = "비고"
        Me.remk.TitleWidth = 85
        '
        'GD_CD
        '
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(19, 65)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(252, 21)
        Me.GD_CD.TabIndex = 131
        Me.GD_CD.Title = "제품코드"
        Me.GD_CD.TitleWidth = 85
        '
        'bal_no
        '
        Me.bal_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bal_no.Location = New System.Drawing.Point(635, 137)
        Me.bal_no.Name = "bal_no"
        Me.bal_no.Size = New System.Drawing.Size(269, 21)
        Me.bal_no.TabIndex = 135
        Me.bal_no.Title = "생산지시번호"
        Me.bal_no.TitleWidth = 90
        '
        'job_type
        '
        Me.job_type.Location = New System.Drawing.Point(303, 89)
        Me.job_type.Name = "job_type"
        Me.job_type.Size = New System.Drawing.Size(269, 21)
        Me.job_type.TabIndex = 133
        Me.job_type.Title = "생산구분"
        Me.job_type.TitleWidth = 90
        '
        'pr_qty
        '
        Me.pr_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pr_qty.Location = New System.Drawing.Point(303, 137)
        Me.pr_qty.Name = "pr_qty"
        Me.pr_qty.Size = New System.Drawing.Size(269, 21)
        Me.pr_qty.TabIndex = 132
        Me.pr_qty.Title = "실적수량"
        Me.pr_qty.TitleWidth = 90
        '
        'ip_dt
        '
        Me.ip_dt.ColumnName = "plan_dt"
        Me.ip_dt.Location = New System.Drawing.Point(635, 41)
        Me.ip_dt.Name = "ip_dt"
        Me.ip_dt.Size = New System.Drawing.Size(269, 21)
        Me.ip_dt.TabIndex = 129
        Me.ip_dt.TableName = "plan_dt"
        Me.ip_dt.Title = "외주입고일자"
        Me.ip_dt.TitleWidth = 90
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "ps_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(303, 41)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(163, 21)
        Me.ps_cd.TabIndex = 127
        Me.ps_cd.TableName = "ps_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 90
        '
        'job_qty
        '
        Me.job_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_qty.Location = New System.Drawing.Point(303, 113)
        Me.job_qty.Name = "job_qty"
        Me.job_qty.Size = New System.Drawing.Size(269, 21)
        Me.job_qty.TabIndex = 130
        Me.job_qty.Title = "지시수량"
        Me.job_qty.TitleWidth = 90
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "pl_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(470, 41)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(102, 21)
        Me.ps_nm.TabIndex = 128
        Me.ps_nm.TableName = "pl_nm"
        Me.ps_nm.Title = "부서"
        Me.ps_nm.TitleWidth = 0
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(635, 65)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(269, 21)
        Me.stts.TabIndex = 126
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 90
        '
        'ip_no
        '
        Me.ip_no.ColumnName = "find_paymenterm_cd"
        Me.ip_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ip_no.Location = New System.Drawing.Point(19, 41)
        Me.ip_no.Name = "ip_no"
        Me.ip_no.Size = New System.Drawing.Size(252, 21)
        Me.ip_no.TabIndex = 6
        Me.ip_no.TableName = "find_paymenterm_cd"
        Me.ip_no.Title = "ip_no"
        Me.ip_no.TitleWidth = 85
        '
        'TWH_CD
        '
        Me.TWH_CD.Location = New System.Drawing.Point(635, 113)
        Me.TWH_CD.Name = "TWH_CD"
        Me.TWH_CD.Size = New System.Drawing.Size(269, 21)
        Me.TWH_CD.TabIndex = 125
        Me.TWH_CD.Title = "입고창고"
        Me.TWH_CD.TitleWidth = 90
        '
        'FWH_CD
        '
        Me.FWH_CD.Location = New System.Drawing.Point(635, 89)
        Me.FWH_CD.Name = "FWH_CD"
        Me.FWH_CD.Size = New System.Drawing.Size(269, 21)
        Me.FWH_CD.TabIndex = 124
        Me.FWH_CD.Title = "출고창고"
        Me.FWH_CD.TitleWidth = 90
        '
        'unit_cd
        '
        Me.unit_cd.Location = New System.Drawing.Point(19, 137)
        Me.unit_cd.Name = "unit_cd"
        Me.unit_cd.Size = New System.Drawing.Size(252, 21)
        Me.unit_cd.TabIndex = 123
        Me.unit_cd.Title = "단위"
        Me.unit_cd.TitleWidth = 85
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(303, 65)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(269, 21)
        Me.sa_cd.TabIndex = 122
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 90
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(19, 89)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(252, 21)
        Me.gd_nm.TabIndex = 120
        Me.gd_nm.Title = "제품명"
        Me.gd_nm.TitleWidth = 85
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(19, 113)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(252, 21)
        Me.spec.TabIndex = 121
        Me.spec.Title = "규격"
        Me.spec.TitleWidth = 85
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(804, 412)
        Me.g_body.TabIndex = 0
        Me.g_body.TabStop = False
        '
        'WI_JA1165
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_JA1165"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents tp2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible2 As System.Windows.Forms.CheckBox
    Friend WithEvents find_to2 As Frame7.eDate
    Friend WithEvents find_from2 As Frame7.eDate
    Friend WithEvents find_cs_nm2 As Frame7.eText
    Friend WithEvents g_list2 As Frame7.eGrid
    Friend WithEvents find_bal_no2 As Frame7.eText
    Friend WithEvents ip_no As Frame7.eText
    Friend WithEvents TWH_CD As Frame7.eCombo
    Friend WithEvents FWH_CD As Frame7.eCombo
    Friend WithEvents unit_cd As Frame7.eCombo
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ip_dt As Frame7.eDate
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents job_qty As Frame7.eText
    Friend WithEvents pr_qty As Frame7.eText
    Friend WithEvents job_type As Frame7.eCombo
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents bal_no As Frame7.eText

End Class
