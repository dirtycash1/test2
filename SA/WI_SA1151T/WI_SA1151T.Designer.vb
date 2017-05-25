<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1151T
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
        Me.RRT_DT = New Frame7.eDate()
        Me.tax_no = New Frame7.eText()
        Me.singo_no = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.won_amt = New Frame7.eText()
        Me.rate = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.cur_cd = New Frame7.eCombo()
        Me.ot_no = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.rt_amt = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.wh_cd = New Frame7.eCombo()
        Me.od_gu = New Frame7.eCombo()
        Me.rt_dt = New Frame7.eDate()
        Me.rt_no = New Frame7.eText()
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
        Me.spc_1.Size = New System.Drawing.Size(1350, 558)
        Me.spc_1.SplitterDistance = 380
        Me.spc_1.TabIndex = 3
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(380, 558)
        Me.tab1.TabIndex = 49
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1, Me.tp2})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer1)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(373, 528)
        Me.tp1.Text = "검색 조건"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(373, 528)
        Me.SplitContainer1.SplitterDistance = 172
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
        Me.Panel2.Size = New System.Drawing.Size(373, 172)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(279, 0)
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
        Me.g_list.Size = New System.Drawing.Size(373, 352)
        Me.g_list.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.SplitContainer4)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(373, 528)
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
        Me.SplitContainer4.Panel2.Controls.Add(Me.g_list2)
        Me.SplitContainer4.Size = New System.Drawing.Size(373, 528)
        Me.SplitContainer4.SplitterDistance = 172
        Me.SplitContainer4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.find_to2)
        Me.Panel3.Controls.Add(Me.find_from2)
        Me.Panel3.Controls.Add(Me.find_cs_nm2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 172)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel2)
        Me.Panel4.Controls.Add(Me.btn_find2)
        Me.Panel4.Controls.Add(Me.find_visible2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 131)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(373, 41)
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
        Me.find_visible2.Location = New System.Drawing.Point(279, 0)
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
        Me.find_from2.Title = "기간"
        Me.find_from2.TitleWidth = 60
        '
        'find_cs_nm2
        '
        Me.find_cs_nm2.ColumnName = "find_paymenterm_cd"
        Me.find_cs_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm2.Location = New System.Drawing.Point(25, 58)
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
        Me.g_list2.Size = New System.Drawing.Size(373, 352)
        Me.g_list2.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer2.Size = New System.Drawing.Size(966, 558)
        Me.SplitContainer2.SplitterDistance = 141
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.RRT_DT)
        Me.ep_head.Controls.Add(Me.tax_no)
        Me.ep_head.Controls.Add(Me.singo_no)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.won_amt)
        Me.ep_head.Controls.Add(Me.rate)
        Me.ep_head.Controls.Add(Me.stts1)
        Me.ep_head.Controls.Add(Me.cur_cd)
        Me.ep_head.Controls.Add(Me.ot_no)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.rt_amt)
        Me.ep_head.Controls.Add(Me.cs_nm)
        Me.ep_head.Controls.Add(Me.cs_cd)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.wh_cd)
        Me.ep_head.Controls.Add(Me.od_gu)
        Me.ep_head.Controls.Add(Me.rt_dt)
        Me.ep_head.Controls.Add(Me.rt_no)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(966, 141)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     반품등록(수출)"
        '
        'RRT_DT
        '
        Me.RRT_DT.Location = New System.Drawing.Point(386, 138)
        Me.RRT_DT.Name = "RRT_DT"
        Me.RRT_DT.Size = New System.Drawing.Size(194, 21)
        Me.RRT_DT.TabIndex = 100
        Me.RRT_DT.Title = "반품요청일자"
        Me.RRT_DT.TitleWidth = 85
        '
        'tax_no
        '
        Me.tax_no.ColumnName = "find_paymenterm_cd"
        Me.tax_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_no.Location = New System.Drawing.Point(706, 169)
        Me.tax_no.Name = "tax_no"
        Me.tax_no.Size = New System.Drawing.Size(215, 21)
        Me.tax_no.TabIndex = 99
        Me.tax_no.TableName = "find_paymenterm_cd"
        Me.tax_no.Title = "fac100번호"
        Me.tax_no.TitleWidth = 98
        Me.tax_no.Visible = False
        '
        'singo_no
        '
        Me.singo_no.ColumnName = "find_paymenterm_cd"
        Me.singo_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.singo_no.Location = New System.Drawing.Point(247, 57)
        Me.singo_no.Name = "singo_no"
        Me.singo_no.Size = New System.Drawing.Size(273, 21)
        Me.singo_no.TabIndex = 98
        Me.singo_no.TableName = "find_paymenterm_cd"
        Me.singo_no.Title = "수입신고필증번호"
        Me.singo_no.TitleWidth = 100
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(256, 199)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(240, 21)
        Me.pl_cd.TabIndex = 96
        Me.pl_cd.Title = "부서코드"
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(19, 107)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(671, 21)
        Me.remk.TabIndex = 95
        Me.remk.Title = "비고"
        Me.remk.TitleWidth = 98
        '
        'won_amt
        '
        Me.won_amt.ColumnName = "find_paymenterm_cd"
        Me.won_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.won_amt.Location = New System.Drawing.Point(706, 82)
        Me.won_amt.Name = "won_amt"
        Me.won_amt.Size = New System.Drawing.Size(194, 21)
        Me.won_amt.TabIndex = 94
        Me.won_amt.TableName = "find_paymenterm_cd"
        Me.won_amt.Title = "원화금액"
        Me.won_amt.TitleWidth = 85
        '
        'rate
        '
        Me.rate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rate.Location = New System.Drawing.Point(528, 82)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(162, 21)
        Me.rate.TabIndex = 93
        Me.rate.Title = "환율"
        Me.rate.TitleWidth = 60
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(706, 107)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(194, 21)
        Me.stts1.TabIndex = 97
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 85
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(528, 57)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(162, 21)
        Me.cur_cd.TabIndex = 90
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 60
        '
        'ot_no
        '
        Me.ot_no.ColumnName = "find_paymenterm_cd"
        Me.ot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_no.Location = New System.Drawing.Point(520, 199)
        Me.ot_no.Name = "ot_no"
        Me.ot_no.Size = New System.Drawing.Size(215, 21)
        Me.ot_no.TabIndex = 85
        Me.ot_no.TableName = "find_paymenterm_cd"
        Me.ot_no.Title = "출하번호"
        Me.ot_no.TitleWidth = 98
        Me.ot_no.Visible = False
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(528, 32)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(162, 21)
        Me.sa_cd.TabIndex = 84
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 60
        '
        'rt_amt
        '
        Me.rt_amt.ColumnName = "find_paymenterm_cd"
        Me.rt_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_amt.Location = New System.Drawing.Point(706, 57)
        Me.rt_amt.Name = "rt_amt"
        Me.rt_amt.Size = New System.Drawing.Size(194, 21)
        Me.rt_amt.TabIndex = 75
        Me.rt_amt.TableName = "find_paymenterm_cd"
        Me.rt_amt.Title = "반품금액"
        Me.rt_amt.TitleWidth = 85
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(236, 82)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(284, 21)
        Me.cs_nm.TabIndex = 71
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(19, 82)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(215, 21)
        Me.cs_cd.TabIndex = 70
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(247, 32)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(168, 21)
        Me.ps_cd.TabIndex = 47
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 100
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(416, 32)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 46
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(19, 57)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(215, 21)
        Me.wh_cd.TabIndex = 45
        Me.wh_cd.Title = "창고"
        Me.wh_cd.TitleWidth = 98
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(19, 199)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(215, 21)
        Me.od_gu.TabIndex = 44
        Me.od_gu.Title = "구분"
        Me.od_gu.TitleWidth = 98
        '
        'rt_dt
        '
        Me.rt_dt.Location = New System.Drawing.Point(706, 32)
        Me.rt_dt.Name = "rt_dt"
        Me.rt_dt.Size = New System.Drawing.Size(194, 21)
        Me.rt_dt.TabIndex = 43
        Me.rt_dt.Title = "반품승인일자"
        Me.rt_dt.TitleWidth = 85
        '
        'rt_no
        '
        Me.rt_no.ColumnName = "find_paymenterm_cd"
        Me.rt_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_no.Location = New System.Drawing.Point(19, 32)
        Me.rt_no.Name = "rt_no"
        Me.rt_no.Size = New System.Drawing.Size(215, 21)
        Me.rt_no.TabIndex = 6
        Me.rt_no.TableName = "find_paymenterm_cd"
        Me.rt_no.Title = "반품번호"
        Me.rt_no.TitleWidth = 98
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(966, 413)
        Me.g_body.TabIndex = 0
        Me.g_body.TabStop = False
        '
        'WI_SA1151T
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1151T"
        Me.Size = New System.Drawing.Size(1350, 558)
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
    Friend WithEvents rt_no As Frame7.eText
    Friend WithEvents rt_dt As Frame7.eDate
    Friend WithEvents od_gu As Frame7.eCombo
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents rt_amt As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents ot_no As Frame7.eText
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents won_amt As Frame7.eText
    Friend WithEvents rate As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents singo_no As Frame7.eText
    Friend WithEvents tax_no As Frame7.eText
    Friend WithEvents RRT_DT As Frame7.eDate

End Class
