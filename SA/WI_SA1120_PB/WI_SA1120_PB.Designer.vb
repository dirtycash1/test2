<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1120_PB
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.find_from = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_od_no = New Frame7.eText()
        Me.find_stts = New Frame7.eOptionBox()
        Me.g_list = New Frame7.eGrid()
        Me.SC2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.real_yn = New Frame7.eCombo()
        Me.remk2 = New Frame7.eText()
        Me.set_tmp = New Frame7.eCombo()
        Me.deli_nm = New Frame7.eCombo()
        Me.ship_nm = New Frame7.eText()
        Me.deli_date = New Frame7.eDate()
        Me.addr_deli = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.sal_cust = New Frame7.eText()
        Me.sal_cust_nm = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.od_gu = New Frame7.eCombo()
        Me.ar_cd = New Frame7.eCombo()
        Me.ps_nm = New Frame7.eText()
        Me.od_amt = New Frame7.eText()
        Me.vat_amt = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EText1 = New Frame7.eText()
        Me.EText2 = New Frame7.eText()
        Me.nacs_tel = New Frame7.eText()
        Me.sale_emp = New Frame7.eText()
        Me.cr_amt = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.cs_nm = New Frame7.eText()
        Me.cs_gu = New Frame7.eCombo()
        Me.nacs_addr = New Frame7.eText()
        Me.nacs_cd = New Frame7.eText()
        Me.cs_addr = New Frame7.eText()
        Me.nacs_nm = New Frame7.eText()
        Me.pl_nm = New Frame7.eText()
        Me.od_no = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.od_dt = New Frame7.eDate()
        Me.pl_cd = New Frame7.eText()
        Me.cs_tel = New Frame7.eText()
        Me.btn_set = New DevExpress.XtraEditors.SimpleButton()
        Me.g_body = New Frame7.eGrid()
        Me.confirm_gu = New Frame7.eText()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SC2.Panel1.SuspendLayout()
        Me.SC2.Panel2.SuspendLayout()
        Me.SC2.SuspendLayout()
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ep_head.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.spc_1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SC2)
        Me.spc_1.Size = New System.Drawing.Size(1473, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 2
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 611)
        Me.SplitContainer1.SplitterDistance = 216
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_od_no)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 216)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 41)
        Me.Panel1.TabIndex = 104
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
        Me.find_visible.Location = New System.Drawing.Point(274, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(94, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(5, 26)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(202, 21)
        Me.find_from.TabIndex = 37
        Me.find_from.Title = "수주일자"
        Me.find_from.TitleWidth = 98
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(5, 54)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(326, 21)
        Me.find_cs_nm.TabIndex = 45
        Me.find_cs_nm.Title = "거래처명"
        Me.find_cs_nm.TitleWidth = 98
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(210, 26)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(121, 21)
        Me.find_to.TabIndex = 38
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 20
        '
        'find_od_no
        '
        Me.find_od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_od_no.Location = New System.Drawing.Point(5, 81)
        Me.find_od_no.Name = "find_od_no"
        Me.find_od_no.Size = New System.Drawing.Size(326, 21)
        Me.find_od_no.TabIndex = 41
        Me.find_od_no.Title = "수주번호"
        Me.find_od_no.TitleWidth = 98
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(5, 109)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.SelectedIndex = -1
        Me.find_stts.Size = New System.Drawing.Size(326, 22)
        Me.find_stts.TabIndex = 42
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 98
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(374, 391)
        Me.g_list.TabIndex = 1
        '
        'SC2
        '
        Me.SC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SC2.Location = New System.Drawing.Point(0, 0)
        Me.SC2.Name = "SC2"
        Me.SC2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SC2.Panel1
        '
        Me.SC2.Panel1.Controls.Add(Me.ep_head)
        '
        'SC2.Panel2
        '
        Me.SC2.Panel2.Controls.Add(Me.g_body)
        Me.SC2.Panel2.Controls.Add(Me.confirm_gu)
        Me.SC2.Size = New System.Drawing.Size(1095, 611)
        Me.SC2.SplitterDistance = 224
        Me.SC2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.real_yn)
        Me.ep_head.Controls.Add(Me.remk2)
        Me.ep_head.Controls.Add(Me.set_tmp)
        Me.ep_head.Controls.Add(Me.deli_nm)
        Me.ep_head.Controls.Add(Me.ship_nm)
        Me.ep_head.Controls.Add(Me.deli_date)
        Me.ep_head.Controls.Add(Me.addr_deli)
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.sal_cust)
        Me.ep_head.Controls.Add(Me.sal_cust_nm)
        Me.ep_head.Controls.Add(Me.tot_amt)
        Me.ep_head.Controls.Add(Me.od_gu)
        Me.ep_head.Controls.Add(Me.ar_cd)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.od_amt)
        Me.ep_head.Controls.Add(Me.vat_amt)
        Me.ep_head.Controls.Add(Me.cs_cd)
        Me.ep_head.Controls.Add(Me.Panel2)
        Me.ep_head.Controls.Add(Me.nacs_tel)
        Me.ep_head.Controls.Add(Me.sale_emp)
        Me.ep_head.Controls.Add(Me.cr_amt)
        Me.ep_head.Controls.Add(Me.stts)
        Me.ep_head.Controls.Add(Me.cs_nm)
        Me.ep_head.Controls.Add(Me.cs_gu)
        Me.ep_head.Controls.Add(Me.nacs_addr)
        Me.ep_head.Controls.Add(Me.nacs_cd)
        Me.ep_head.Controls.Add(Me.cs_addr)
        Me.ep_head.Controls.Add(Me.nacs_nm)
        Me.ep_head.Controls.Add(Me.pl_nm)
        Me.ep_head.Controls.Add(Me.od_no)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.od_dt)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.cs_tel)
        Me.ep_head.Controls.Add(Me.btn_set)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(1095, 224)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     전표등록"
        '
        'real_yn
        '
        Me.real_yn.Location = New System.Drawing.Point(782, 197)
        Me.real_yn.Name = "real_yn"
        Me.real_yn.Size = New System.Drawing.Size(187, 21)
        Me.real_yn.TabIndex = 108
        Me.real_yn.Title = "실물/전산 구분"
        Me.real_yn.TitleWidth = 80
        '
        'remk2
        '
        Me.remk2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk2.Location = New System.Drawing.Point(22, 195)
        Me.remk2.Name = "remk2"
        Me.remk2.Size = New System.Drawing.Size(726, 21)
        Me.remk2.TabIndex = 106
        Me.remk2.Title = "특기사항(ERP)"
        Me.remk2.TitleWidth = 98
        '
        'set_tmp
        '
        Me.set_tmp.Location = New System.Drawing.Point(1000, 26)
        Me.set_tmp.Name = "set_tmp"
        Me.set_tmp.Size = New System.Drawing.Size(213, 21)
        Me.set_tmp.TabIndex = 80
        Me.set_tmp.Title = "템플릿"
        Me.set_tmp.TitleWidth = 80
        '
        'deli_nm
        '
        Me.deli_nm.Location = New System.Drawing.Point(782, 170)
        Me.deli_nm.Name = "deli_nm"
        Me.deli_nm.Size = New System.Drawing.Size(187, 21)
        Me.deli_nm.TabIndex = 107
        Me.deli_nm.Title = "나우/용마 구분"
        Me.deli_nm.TitleWidth = 80
        '
        'ship_nm
        '
        Me.ship_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_nm.Location = New System.Drawing.Point(22, 146)
        Me.ship_nm.Name = "ship_nm"
        Me.ship_nm.Size = New System.Drawing.Size(465, 21)
        Me.ship_nm.TabIndex = 77
        Me.ship_nm.Title = "배송지"
        Me.ship_nm.TitleWidth = 98
        '
        'deli_date
        '
        Me.deli_date.Location = New System.Drawing.Point(535, 74)
        Me.deli_date.Name = "deli_date"
        Me.deli_date.Size = New System.Drawing.Size(213, 21)
        Me.deli_date.TabIndex = 79
        Me.deli_date.Title = "배송일자"
        Me.deli_date.TitleWidth = 80
        '
        'addr_deli
        '
        Me.addr_deli.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr_deli.Location = New System.Drawing.Point(486, 146)
        Me.addr_deli.Name = "addr_deli"
        Me.addr_deli.Size = New System.Drawing.Size(18, 21)
        Me.addr_deli.TabIndex = 78
        Me.addr_deli.Title = "배송지"
        Me.addr_deli.TitleWidth = 0
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(22, 170)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(726, 21)
        Me.remk.TabIndex = 76
        Me.remk.Title = "비고"
        Me.remk.TitleWidth = 98
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(535, 26)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(213, 21)
        Me.sa_cd.TabIndex = 75
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 80
        '
        'sal_cust
        '
        Me.sal_cust.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust.Location = New System.Drawing.Point(22, 98)
        Me.sal_cust.Name = "sal_cust"
        Me.sal_cust.Size = New System.Drawing.Size(187, 21)
        Me.sal_cust.TabIndex = 67
        Me.sal_cust.Title = "매출정산거래처"
        Me.sal_cust.TitleWidth = 98
        '
        'sal_cust_nm
        '
        Me.sal_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust_nm.Location = New System.Drawing.Point(213, 98)
        Me.sal_cust_nm.Name = "sal_cust_nm"
        Me.sal_cust_nm.Size = New System.Drawing.Size(291, 21)
        Me.sal_cust_nm.TabIndex = 68
        Me.sal_cust_nm.Title = "nacs_nm"
        Me.sal_cust_nm.TitleWidth = 0
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(782, 146)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(187, 21)
        Me.tot_amt.TabIndex = 65
        Me.tot_amt.Title = "합계금액"
        Me.tot_amt.TitleWidth = 80
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(22, 50)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(206, 21)
        Me.od_gu.TabIndex = 58
        Me.od_gu.Title = "수주구분"
        Me.od_gu.TitleWidth = 98
        '
        'ar_cd
        '
        Me.ar_cd.Location = New System.Drawing.Point(535, 122)
        Me.ar_cd.Name = "ar_cd"
        Me.ar_cd.Size = New System.Drawing.Size(213, 21)
        Me.ar_cd.TabIndex = 66
        Me.ar_cd.Title = "지역분류"
        Me.ar_cd.TitleWidth = 80
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(402, 26)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(102, 21)
        Me.ps_nm.TabIndex = 56
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'od_amt
        '
        Me.od_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_amt.Location = New System.Drawing.Point(782, 98)
        Me.od_amt.Name = "od_amt"
        Me.od_amt.Size = New System.Drawing.Size(187, 21)
        Me.od_amt.TabIndex = 64
        Me.od_amt.Title = "공급가액"
        Me.od_amt.TitleWidth = 80
        '
        'vat_amt
        '
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(782, 122)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(187, 21)
        Me.vat_amt.TabIndex = 62
        Me.vat_amt.Title = "부가세"
        Me.vat_amt.TitleWidth = 80
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(22, 74)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(187, 21)
        Me.cs_cd.TabIndex = 51
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.EText1)
        Me.Panel2.Controls.Add(Me.EText2)
        Me.Panel2.Location = New System.Drawing.Point(1000, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 63)
        Me.Panel2.TabIndex = 105
        Me.Panel2.Visible = False
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(9, 7)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(162, 21)
        Me.EText1.TabIndex = 106
        Me.EText1.Title = "1Day 낱개"
        Me.EText1.TitleWidth = 80
        '
        'EText2
        '
        Me.EText2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText2.Location = New System.Drawing.Point(9, 33)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(162, 21)
        Me.EText2.TabIndex = 107
        Me.EText2.Title = "Iris 낱개"
        Me.EText2.TitleWidth = 80
        '
        'nacs_tel
        '
        Me.nacs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_tel.Location = New System.Drawing.Point(555, 230)
        Me.nacs_tel.Name = "nacs_tel"
        Me.nacs_tel.Size = New System.Drawing.Size(127, 21)
        Me.nacs_tel.TabIndex = 50
        Me.nacs_tel.Title = "nacs_nm"
        Me.nacs_tel.TitleWidth = 0
        Me.nacs_tel.Visible = False
        '
        'sale_emp
        '
        Me.sale_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_emp.Location = New System.Drawing.Point(782, 74)
        Me.sale_emp.Name = "sale_emp"
        Me.sale_emp.Size = New System.Drawing.Size(187, 21)
        Me.sale_emp.TabIndex = 61
        Me.sale_emp.Title = "영업담당자"
        Me.sale_emp.TitleWidth = 80
        '
        'cr_amt
        '
        Me.cr_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cr_amt.Location = New System.Drawing.Point(782, 50)
        Me.cr_amt.Name = "cr_amt"
        Me.cr_amt.Size = New System.Drawing.Size(187, 21)
        Me.cr_amt.TabIndex = 60
        Me.cr_amt.Title = "여신금액"
        Me.cr_amt.TitleWidth = 80
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(782, 26)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(187, 21)
        Me.stts.TabIndex = 57
        Me.stts.Title = "전표상태"
        Me.stts.TitleWidth = 80
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(213, 74)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(291, 21)
        Me.cs_nm.TabIndex = 52
        Me.cs_nm.Title = "nacs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'cs_gu
        '
        Me.cs_gu.Location = New System.Drawing.Point(265, 50)
        Me.cs_gu.Name = "cs_gu"
        Me.cs_gu.Size = New System.Drawing.Size(167, 21)
        Me.cs_gu.TabIndex = 59
        Me.cs_gu.Title = "거래구분"
        Me.cs_gu.TitleWidth = 60
        '
        'nacs_addr
        '
        Me.nacs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_addr.Location = New System.Drawing.Point(332, 230)
        Me.nacs_addr.Name = "nacs_addr"
        Me.nacs_addr.Size = New System.Drawing.Size(222, 21)
        Me.nacs_addr.TabIndex = 49
        Me.nacs_addr.Title = "nacs_nm"
        Me.nacs_addr.TitleWidth = 0
        Me.nacs_addr.Visible = False
        '
        'nacs_cd
        '
        Me.nacs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_cd.Location = New System.Drawing.Point(5, 230)
        Me.nacs_cd.Name = "nacs_cd"
        Me.nacs_cd.Size = New System.Drawing.Size(192, 21)
        Me.nacs_cd.TabIndex = 47
        Me.nacs_cd.Title = "납품처"
        Me.nacs_cd.TitleWidth = 98
        Me.nacs_cd.Visible = False
        '
        'cs_addr
        '
        Me.cs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_addr.Location = New System.Drawing.Point(22, 122)
        Me.cs_addr.Name = "cs_addr"
        Me.cs_addr.Size = New System.Drawing.Size(482, 21)
        Me.cs_addr.TabIndex = 53
        Me.cs_addr.Title = "주소"
        Me.cs_addr.TitleWidth = 98
        '
        'nacs_nm
        '
        Me.nacs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_nm.Location = New System.Drawing.Point(198, 230)
        Me.nacs_nm.Name = "nacs_nm"
        Me.nacs_nm.Size = New System.Drawing.Size(133, 21)
        Me.nacs_nm.TabIndex = 48
        Me.nacs_nm.Title = "nacs_nm"
        Me.nacs_nm.TitleWidth = 0
        Me.nacs_nm.Visible = False
        '
        'pl_nm
        '
        Me.pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_nm.Location = New System.Drawing.Point(426, 120)
        Me.pl_nm.Name = "pl_nm"
        Me.pl_nm.Size = New System.Drawing.Size(103, 21)
        Me.pl_nm.TabIndex = 46
        Me.pl_nm.Title = "pl_nm"
        Me.pl_nm.TitleWidth = 0
        '
        'od_no
        '
        Me.od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_no.Format = "00000000-0000"
        Me.od_no.Location = New System.Drawing.Point(22, 26)
        Me.od_no.Name = "od_no"
        Me.od_no.ReadOnly = True
        Me.od_no.Size = New System.Drawing.Size(206, 21)
        Me.od_no.TabIndex = 44
        Me.od_no.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.od_no.Title = "od_no"
        Me.od_no.TitleWidth = 98
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(265, 26)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(134, 21)
        Me.ps_cd.TabIndex = 44
        Me.ps_cd.Title = "ps_cd"
        Me.ps_cd.TitleWidth = 60
        '
        'od_dt
        '
        Me.od_dt.Location = New System.Drawing.Point(535, 50)
        Me.od_dt.Name = "od_dt"
        Me.od_dt.Size = New System.Drawing.Size(213, 21)
        Me.od_dt.TabIndex = 44
        Me.od_dt.Title = "od_dt"
        Me.od_dt.TitleWidth = 80
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(504, 149)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(192, 21)
        Me.pl_cd.TabIndex = 45
        Me.pl_cd.Title = "pl_cd"
        Me.pl_cd.TitleWidth = 98
        Me.pl_cd.Visible = False
        '
        'cs_tel
        '
        Me.cs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_tel.Location = New System.Drawing.Point(535, 98)
        Me.cs_tel.Name = "cs_tel"
        Me.cs_tel.Size = New System.Drawing.Size(213, 21)
        Me.cs_tel.TabIndex = 54
        Me.cs_tel.Title = "전화번호"
        Me.cs_tel.TitleWidth = 80
        '
        'btn_set
        '
        Me.btn_set.Location = New System.Drawing.Point(234, 53)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(114, 21)
        Me.btn_set.TabIndex = 73
        Me.btn_set.Text = "초도품목가져오기"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(1095, 383)
        Me.g_body.TabIndex = 0
        '
        'confirm_gu
        '
        Me.confirm_gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.confirm_gu.Location = New System.Drawing.Point(660, -3)
        Me.confirm_gu.Name = "confirm_gu"
        Me.confirm_gu.Size = New System.Drawing.Size(213, 21)
        Me.confirm_gu.TabIndex = 74
        Me.confirm_gu.Title = "접수구분"
        Me.confirm_gu.TitleWidth = 80
        '
        'WI_SA1120_PB
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1120_PB"
        Me.Size = New System.Drawing.Size(1473, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SC2.Panel1.ResumeLayout(False)
        Me.SC2.Panel2.ResumeLayout(False)
        Me.SC2.ResumeLayout(False)
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SC2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_od_no As Frame7.eText
    Friend WithEvents find_stts As Frame7.eOptionBox
    Friend WithEvents od_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents pl_nm As Frame7.eText
    Friend WithEvents od_dt As Frame7.eDate
    Friend WithEvents nacs_cd As Frame7.eText
    Friend WithEvents nacs_nm As Frame7.eText
    Friend WithEvents nacs_tel As Frame7.eText
    Friend WithEvents nacs_addr As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_tel As Frame7.eText
    Friend WithEvents cs_addr As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents od_gu As Frame7.eCombo
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents od_amt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents sale_emp As Frame7.eText
    Friend WithEvents cr_amt As Frame7.eText
    Friend WithEvents cs_gu As Frame7.eCombo
    Friend WithEvents ar_cd As Frame7.eCombo
    Friend WithEvents sal_cust_nm As Frame7.eText
    Friend WithEvents sal_cust As Frame7.eText
    Friend WithEvents btn_set As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents ship_nm As Frame7.eText
    Friend WithEvents confirm_gu As Frame7.eText
    Friend WithEvents addr_deli As Frame7.eText
    Friend WithEvents deli_date As Frame7.eDate
    Friend WithEvents set_tmp As Frame7.eCombo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents remk2 As Frame7.eText
    Friend WithEvents deli_nm As Frame7.eCombo
    Friend WithEvents real_yn As Frame7.eCombo

End Class
