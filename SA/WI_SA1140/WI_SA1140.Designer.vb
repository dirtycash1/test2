<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1140
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
        Me.find_stts = New Frame7.eCombo()
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
        Me.ship_cs_cd = New Frame7.eText()
        Me.ship_cs_nm = New Frame7.eText()
        Me.deli_nm = New Frame7.eCombo()
        Me.in_psnm = New Frame7.eText()
        Me.in_pscd = New Frame7.eText()
        Me.od_gu = New Frame7.eCombo()
        Me.pl_cd = New Frame7.eText()
        Me.but_prt = New DevExpress.XtraEditors.SimpleButton()
        Me.sal_tel = New Frame7.eText()
        Me.sal_cust = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.sal_cust_nm = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.sum_amt = New Frame7.eText()
        Me.vat_amt = New Frame7.eText()
        Me.od_no = New Frame7.eText()
        Me.deli_place = New Frame7.eText()
        Me.cs_addr = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.cs_tel = New Frame7.eText()
        Me.wh_cd = New Frame7.eCombo()
        Me.rate = New Frame7.eText()
        Me.cur_cd = New Frame7.eCombo()
        Me.nacs_cd = New Frame7.eText()
        Me.ot_amt = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.ot_dt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.ot_no = New Frame7.eText()
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
        Me.spc_1.Size = New System.Drawing.Size(1550, 611)
        Me.spc_1.SplitterDistance = 400
        Me.spc_1.TabIndex = 3
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(400, 611)
        Me.tab1.TabIndex = 49
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1, Me.tp2})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer1)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(393, 581)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(393, 581)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.find_to)
        Me.Panel2.Controls.Add(Me.find_from)
        Me.Panel2.Controls.Add(Me.find_cs_nm)
        Me.Panel2.Controls.Add(Me.find_stts)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 190)
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
        Me.Panel1.Size = New System.Drawing.Size(393, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(299, 0)
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
        Me.find_cs_nm.Location = New System.Drawing.Point(25, 54)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm.TabIndex = 48
        Me.find_cs_nm.TableName = "find_paymenterm_cd"
        Me.find_cs_nm.Title = "거래처명"
        Me.find_cs_nm.TitleWidth = 60
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(25, 78)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(159, 21)
        Me.find_stts.TabIndex = 49
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 60
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(393, 387)
        Me.g_list.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.SplitContainer4)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(393, 581)
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
        Me.SplitContainer4.Size = New System.Drawing.Size(393, 581)
        Me.SplitContainer4.SplitterDistance = 190
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
        Me.Panel3.Size = New System.Drawing.Size(393, 190)
        Me.Panel3.TabIndex = 0
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
        Me.Panel4.Size = New System.Drawing.Size(393, 41)
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
        Me.find_visible2.Location = New System.Drawing.Point(299, 0)
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
        Me.g_list2.Size = New System.Drawing.Size(393, 387)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1146, 611)
        Me.SplitContainer2.SplitterDistance = 198
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.ship_cs_cd)
        Me.ep_head.Controls.Add(Me.ship_cs_nm)
        Me.ep_head.Controls.Add(Me.deli_nm)
        Me.ep_head.Controls.Add(Me.in_psnm)
        Me.ep_head.Controls.Add(Me.in_pscd)
        Me.ep_head.Controls.Add(Me.od_gu)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.but_prt)
        Me.ep_head.Controls.Add(Me.sal_tel)
        Me.ep_head.Controls.Add(Me.sal_cust)
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.sal_cust_nm)
        Me.ep_head.Controls.Add(Me.stts1)
        Me.ep_head.Controls.Add(Me.sum_amt)
        Me.ep_head.Controls.Add(Me.vat_amt)
        Me.ep_head.Controls.Add(Me.od_no)
        Me.ep_head.Controls.Add(Me.deli_place)
        Me.ep_head.Controls.Add(Me.cs_addr)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.cs_tel)
        Me.ep_head.Controls.Add(Me.wh_cd)
        Me.ep_head.Controls.Add(Me.rate)
        Me.ep_head.Controls.Add(Me.cur_cd)
        Me.ep_head.Controls.Add(Me.nacs_cd)
        Me.ep_head.Controls.Add(Me.ot_amt)
        Me.ep_head.Controls.Add(Me.cs_cd)
        Me.ep_head.Controls.Add(Me.ot_dt)
        Me.ep_head.Controls.Add(Me.cs_nm)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.ot_no)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(1146, 198)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     구매품가입고등록"
        '
        'ship_cs_cd
        '
        Me.ship_cs_cd.ColumnName = "find_paymenterm_cd"
        Me.ship_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_cs_cd.Location = New System.Drawing.Point(19, 137)
        Me.ship_cs_cd.Name = "ship_cs_cd"
        Me.ship_cs_cd.Size = New System.Drawing.Size(182, 21)
        Me.ship_cs_cd.TabIndex = 109
        Me.ship_cs_cd.TableName = "find_paymenterm_cd"
        Me.ship_cs_cd.Title = "배송거래처"
        Me.ship_cs_cd.TitleWidth = 98
        '
        'ship_cs_nm
        '
        Me.ship_cs_nm.ColumnName = "find_stts"
        Me.ship_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_cs_nm.Location = New System.Drawing.Point(203, 137)
        Me.ship_cs_nm.Name = "ship_cs_nm"
        Me.ship_cs_nm.Size = New System.Drawing.Size(179, 21)
        Me.ship_cs_nm.TabIndex = 110
        Me.ship_cs_nm.TableName = "find_stts"
        Me.ship_cs_nm.Title = "매출거래처명"
        Me.ship_cs_nm.TitleWidth = 0
        '
        'deli_nm
        '
        Me.deli_nm.Location = New System.Drawing.Point(832, 113)
        Me.deli_nm.Name = "deli_nm"
        Me.deli_nm.Size = New System.Drawing.Size(215, 21)
        Me.deli_nm.TabIndex = 108
        Me.deli_nm.Title = "나우/용마 구분"
        Me.deli_nm.TitleWidth = 80
        '
        'in_psnm
        '
        Me.in_psnm.ColumnName = "find_stts"
        Me.in_psnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_psnm.Location = New System.Drawing.Point(980, 89)
        Me.in_psnm.Name = "in_psnm"
        Me.in_psnm.Size = New System.Drawing.Size(67, 21)
        Me.in_psnm.TabIndex = 79
        Me.in_psnm.TableName = "find_stts"
        Me.in_psnm.Title = "cs_nm"
        Me.in_psnm.TitleWidth = 0
        '
        'in_pscd
        '
        Me.in_pscd.ColumnName = "find_paymenterm_cd"
        Me.in_pscd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_pscd.Location = New System.Drawing.Point(832, 89)
        Me.in_pscd.Name = "in_pscd"
        Me.in_pscd.Size = New System.Drawing.Size(142, 21)
        Me.in_pscd.TabIndex = 78
        Me.in_pscd.TableName = "find_paymenterm_cd"
        Me.in_pscd.Title = "출하자"
        Me.in_pscd.TitleWidth = 80
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(832, 41)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(215, 21)
        Me.od_gu.TabIndex = 77
        Me.od_gu.Title = "수주유형"
        Me.od_gu.TitleWidth = 80
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_paymenterm_cd"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(638, 243)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(135, 21)
        Me.pl_cd.TabIndex = 74
        Me.pl_cd.TableName = "find_paymenterm_cd"
        Me.pl_cd.Title = "부서코드"
        Me.pl_cd.TitleWidth = 60
        '
        'but_prt
        '
        Me.but_prt.Location = New System.Drawing.Point(832, 144)
        Me.but_prt.Name = "but_prt"
        Me.but_prt.Size = New System.Drawing.Size(96, 44)
        Me.but_prt.TabIndex = 76
        Me.but_prt.Text = "거래명세서출력"
        '
        'sal_tel
        '
        Me.sal_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_tel.Location = New System.Drawing.Point(399, 89)
        Me.sal_tel.Name = "sal_tel"
        Me.sal_tel.Size = New System.Drawing.Size(240, 21)
        Me.sal_tel.TabIndex = 75
        Me.sal_tel.Title = "매출처전화번호"
        Me.sal_tel.TitleWidth = 95
        '
        'sal_cust
        '
        Me.sal_cust.ColumnName = "find_paymenterm_cd"
        Me.sal_cust.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust.Location = New System.Drawing.Point(19, 89)
        Me.sal_cust.Name = "sal_cust"
        Me.sal_cust.Size = New System.Drawing.Size(182, 21)
        Me.sal_cust.TabIndex = 71
        Me.sal_cust.TableName = "find_paymenterm_cd"
        Me.sal_cust.Title = "매출거래처"
        Me.sal_cust.TitleWidth = 98
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(19, 161)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(620, 21)
        Me.remk.TabIndex = 70
        Me.remk.Title = "특기사항"
        Me.remk.TitleWidth = 98
        '
        'sal_cust_nm
        '
        Me.sal_cust_nm.ColumnName = "find_stts"
        Me.sal_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust_nm.Location = New System.Drawing.Point(203, 89)
        Me.sal_cust_nm.Name = "sal_cust_nm"
        Me.sal_cust_nm.Size = New System.Drawing.Size(179, 21)
        Me.sal_cust_nm.TabIndex = 72
        Me.sal_cust_nm.TableName = "find_stts"
        Me.sal_cust_nm.Title = "매출거래처명"
        Me.sal_cust_nm.TitleWidth = 0
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(652, 89)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(169, 21)
        Me.stts1.TabIndex = 73
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 60
        '
        'sum_amt
        '
        Me.sum_amt.ColumnName = "find_paymenterm_cd"
        Me.sum_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sum_amt.Location = New System.Drawing.Point(652, 161)
        Me.sum_amt.Name = "sum_amt"
        Me.sum_amt.Size = New System.Drawing.Size(169, 21)
        Me.sum_amt.TabIndex = 69
        Me.sum_amt.TableName = "find_paymenterm_cd"
        Me.sum_amt.Title = "합계금액"
        Me.sum_amt.TitleWidth = 60
        '
        'vat_amt
        '
        Me.vat_amt.ColumnName = "find_paymenterm_cd"
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(652, 137)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(169, 21)
        Me.vat_amt.TabIndex = 68
        Me.vat_amt.TableName = "find_paymenterm_cd"
        Me.vat_amt.Title = "부가세"
        Me.vat_amt.TitleWidth = 60
        '
        'od_no
        '
        Me.od_no.ColumnName = "find_paymenterm_cd"
        Me.od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_no.Location = New System.Drawing.Point(832, 65)
        Me.od_no.Name = "od_no"
        Me.od_no.Size = New System.Drawing.Size(215, 21)
        Me.od_no.TabIndex = 63
        Me.od_no.TableName = "find_paymenterm_cd"
        Me.od_no.Title = "수주번호"
        Me.od_no.TitleWidth = 80
        '
        'deli_place
        '
        Me.deli_place.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deli_place.Location = New System.Drawing.Point(970, 140)
        Me.deli_place.Name = "deli_place"
        Me.deli_place.Size = New System.Drawing.Size(215, 21)
        Me.deli_place.TabIndex = 67
        Me.deli_place.Title = "배송처"
        Me.deli_place.TitleWidth = 98
        Me.deli_place.Visible = False
        '
        'cs_addr
        '
        Me.cs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_addr.Location = New System.Drawing.Point(19, 113)
        Me.cs_addr.Name = "cs_addr"
        Me.cs_addr.Size = New System.Drawing.Size(620, 21)
        Me.cs_addr.TabIndex = 65
        Me.cs_addr.Title = "주소"
        Me.cs_addr.TitleWidth = 98
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(509, 41)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(130, 21)
        Me.sa_cd.TabIndex = 62
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 40
        '
        'cs_tel
        '
        Me.cs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_tel.Location = New System.Drawing.Point(399, 65)
        Me.cs_tel.Name = "cs_tel"
        Me.cs_tel.Size = New System.Drawing.Size(240, 21)
        Me.cs_tel.TabIndex = 66
        Me.cs_tel.Title = "거래처전화번호"
        Me.cs_tel.TitleWidth = 95
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(652, 65)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(169, 21)
        Me.wh_cd.TabIndex = 64
        Me.wh_cd.Title = "출하창고"
        Me.wh_cd.TitleWidth = 60
        '
        'rate
        '
        Me.rate.ColumnName = "find_paymenterm_cd"
        Me.rate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rate.Location = New System.Drawing.Point(59, 237)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(175, 21)
        Me.rate.TabIndex = 58
        Me.rate.TableName = "find_paymenterm_cd"
        Me.rate.Title = "rate"
        Me.rate.TitleWidth = 50
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(489, 237)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(130, 21)
        Me.cur_cd.TabIndex = 57
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 40
        '
        'nacs_cd
        '
        Me.nacs_cd.ColumnName = "find_paymenterm_cd"
        Me.nacs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_cd.Location = New System.Drawing.Point(754, 219)
        Me.nacs_cd.Name = "nacs_cd"
        Me.nacs_cd.Size = New System.Drawing.Size(182, 21)
        Me.nacs_cd.TabIndex = 59
        Me.nacs_cd.TableName = "find_paymenterm_cd"
        Me.nacs_cd.Title = "납품처"
        Me.nacs_cd.TitleWidth = 98
        '
        'ot_amt
        '
        Me.ot_amt.ColumnName = "find_paymenterm_cd"
        Me.ot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_amt.Location = New System.Drawing.Point(652, 113)
        Me.ot_amt.Name = "ot_amt"
        Me.ot_amt.Size = New System.Drawing.Size(169, 21)
        Me.ot_amt.TabIndex = 56
        Me.ot_amt.TableName = "find_paymenterm_cd"
        Me.ot_amt.Title = "공급가액"
        Me.ot_amt.TitleWidth = 60
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(19, 65)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(182, 21)
        Me.cs_cd.TabIndex = 51
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'ot_dt
        '
        Me.ot_dt.Location = New System.Drawing.Point(652, 41)
        Me.ot_dt.Name = "ot_dt"
        Me.ot_dt.Size = New System.Drawing.Size(169, 21)
        Me.ot_dt.TabIndex = 49
        Me.ot_dt.Title = "출하일자"
        Me.ot_dt.TitleWidth = 60
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(203, 65)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(179, 21)
        Me.cs_nm.TabIndex = 52
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(247, 41)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(135, 21)
        Me.ps_cd.TabIndex = 21
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "출하자"
        Me.ps_cd.TitleWidth = 60
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "ps_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(383, 41)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 20
        Me.ps_nm.TableName = "ps_nm"
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'ot_no
        '
        Me.ot_no.ColumnName = "find_paymenterm_cd"
        Me.ot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_no.Location = New System.Drawing.Point(19, 41)
        Me.ot_no.Name = "ot_no"
        Me.ot_no.Size = New System.Drawing.Size(215, 21)
        Me.ot_no.TabIndex = 1
        Me.ot_no.TableName = "find_paymenterm_cd"
        Me.ot_no.Title = "출하번호"
        Me.ot_no.TitleWidth = 98
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(1146, 409)
        Me.g_body.TabIndex = 0
        Me.g_body.TabStop = False
        '
        'WI_SA1140
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1140"
        Me.Size = New System.Drawing.Size(1550, 611)
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
    Friend WithEvents find_stts As Frame7.eCombo
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
    Friend WithEvents ot_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ot_dt As Frame7.eDate
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents ot_amt As Frame7.eText
    Friend WithEvents rate As Frame7.eText
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents nacs_cd As Frame7.eText
    Friend WithEvents deli_place As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents od_no As Frame7.eText
    Friend WithEvents cs_tel As Frame7.eText
    Friend WithEvents cs_addr As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents sum_amt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents sal_cust_nm As Frame7.eText
    Friend WithEvents sal_cust As Frame7.eText
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents sal_tel As Frame7.eText
    Friend WithEvents but_prt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents od_gu As Frame7.eCombo
    Friend WithEvents in_psnm As Frame7.eText
    Friend WithEvents in_pscd As Frame7.eText
    Friend WithEvents deli_nm As Frame7.eCombo
    Friend WithEvents ship_cs_cd As Frame7.eText
    Friend WithEvents ship_cs_nm As Frame7.eText

End Class
