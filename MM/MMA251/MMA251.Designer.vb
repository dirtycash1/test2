<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMA251
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
        Me.sh_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.po_emp = New Frame7.eText()
        Me.go_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.po_no = New Frame7.eText()
        Me.po_dt = New Frame7.eDate()
        Me.union_yn = New Frame7.eText()
        Me.po_dept_nm = New Frame7.eText()
        Me.po_nm = New Frame7.eText()
        Me.po_rid = New Frame7.eText()
        Me.dlv_dt = New Frame7.eDate()
        Me.po_dept = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.chk_show = New Frame7.eCheck()
        Me.pset_bc = New Frame7.eCombo()
        Me.bs_cd = New Frame7.eText()
        Me.bs_fax = New Frame7.eText()
        Me.bs_tel = New Frame7.eText()
        Me.ceo_nm = New Frame7.eText()
        Me.addr = New Frame7.eText()
        Me.bs_nm = New Frame7.eText()
        Me.fax = New Frame7.eText()
        Me.tel = New Frame7.eText()
        Me.di_bc = New Frame7.eCombo()
        Me.rmks = New Frame7.eText()
        Me.urg_bc = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.po_kd = New Frame7.eCombo()
        Me.po_fac = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.stat_bc = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_price = New DevExpress.XtraEditors.SimpleButton()
        Me.po_bc = New Frame7.eCombo()
        Me.in_wh = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f_itm_nm = New Frame7.eText()
        Me.f_po_fr = New Frame7.eDate()
        Me.f_po_to = New Frame7.eDate()
        Me.f_cust_cd = New Frame7.eText()
        Me.f_itm_bc = New Frame7.eCombo()
        Me.part_spec = New Frame7.eText()
        Me.f_cust_nm = New Frame7.eText()
        Me.btn_mov = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_srh = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1364, 516)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel3.Controls.Add(Me.sh_gw)
        Me.EPanel3.Controls.Add(Me.po_emp)
        Me.EPanel3.Controls.Add(Me.go_gw)
        Me.EPanel3.Controls.Add(Me.po_no)
        Me.EPanel3.Controls.Add(Me.po_dt)
        Me.EPanel3.Controls.Add(Me.union_yn)
        Me.EPanel3.Controls.Add(Me.po_dept_nm)
        Me.EPanel3.Controls.Add(Me.po_nm)
        Me.EPanel3.Controls.Add(Me.po_rid)
        Me.EPanel3.Controls.Add(Me.dlv_dt)
        Me.EPanel3.Controls.Add(Me.po_dept)
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1364, 80)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     발주정보"
        '
        'sh_gw
        '
        Me.sh_gw.Location = New System.Drawing.Point(900, 28)
        Me.sh_gw.Name = "sh_gw"
        Me.sh_gw.Size = New System.Drawing.Size(112, 45)
        Me.sh_gw.TabIndex = 104
        Me.sh_gw.Text = "결재조회"
        '
        'po_emp
        '
        Me.po_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_emp.Location = New System.Drawing.Point(1195, 54)
        Me.po_emp.Name = "po_emp"
        Me.po_emp.Size = New System.Drawing.Size(48, 21)
        Me.po_emp.TabIndex = 103
        Me.po_emp.Title = "po_emp"
        '
        'go_gw
        '
        Me.go_gw.Location = New System.Drawing.Point(782, 28)
        Me.go_gw.Name = "go_gw"
        Me.go_gw.Size = New System.Drawing.Size(112, 45)
        Me.go_gw.TabIndex = 102
        Me.go_gw.Text = "결재상신"
        '
        'po_no
        '
        Me.po_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_no.Location = New System.Drawing.Point(12, 28)
        Me.po_no.Name = "po_no"
        Me.po_no.Size = New System.Drawing.Size(240, 21)
        Me.po_no.TabIndex = 9
        Me.po_no.Title = "발주번호"
        '
        'po_dt
        '
        Me.po_dt.Location = New System.Drawing.Point(12, 52)
        Me.po_dt.Name = "po_dt"
        Me.po_dt.Size = New System.Drawing.Size(240, 21)
        Me.po_dt.TabIndex = 5
        Me.po_dt.Title = "발주일자"
        '
        'union_yn
        '
        Me.union_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.union_yn.Location = New System.Drawing.Point(1029, 28)
        Me.union_yn.Name = "union_yn"
        Me.union_yn.Size = New System.Drawing.Size(88, 21)
        Me.union_yn.TabIndex = 98
        Me.union_yn.Title = "union_yn"
        '
        'po_dept_nm
        '
        Me.po_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept_nm.Location = New System.Drawing.Point(268, 52)
        Me.po_dept_nm.Name = "po_dept_nm"
        Me.po_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_dept_nm.TabIndex = 20
        Me.po_dept_nm.Title = "po_dept_nm"
        '
        'po_nm
        '
        Me.po_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_nm.Location = New System.Drawing.Point(520, 52)
        Me.po_nm.Name = "po_nm"
        Me.po_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_nm.TabIndex = 16
        Me.po_nm.Title = "po_nm"
        '
        'po_rid
        '
        Me.po_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_rid.Location = New System.Drawing.Point(1157, 24)
        Me.po_rid.Name = "po_rid"
        Me.po_rid.Size = New System.Drawing.Size(48, 21)
        Me.po_rid.TabIndex = 13
        Me.po_rid.Title = "po_rid"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(268, 28)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 17
        Me.dlv_dt.Title = "납기일자"
        '
        'po_dept
        '
        Me.po_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept.Location = New System.Drawing.Point(1133, 48)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(100, 21)
        Me.po_dept.TabIndex = 21
        Me.po_dept.Title = "po_dept"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.chk_show)
        Me.EPanel1.Controls.Add(Me.pset_bc)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.bs_fax)
        Me.EPanel1.Controls.Add(Me.bs_tel)
        Me.EPanel1.Controls.Add(Me.ceo_nm)
        Me.EPanel1.Controls.Add(Me.addr)
        Me.EPanel1.Controls.Add(Me.bs_nm)
        Me.EPanel1.Controls.Add(Me.fax)
        Me.EPanel1.Controls.Add(Me.tel)
        Me.EPanel1.Controls.Add(Me.di_bc)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.urg_bc)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.po_kd)
        Me.EPanel1.Controls.Add(Me.po_fac)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.btn_price)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1364, 107)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "검색"
        '
        'chk_show
        '
        Me.chk_show.Caption = ""
        Me.chk_show.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_show.Location = New System.Drawing.Point(782, 80)
        Me.chk_show.Name = "chk_show"
        Me.chk_show.Size = New System.Drawing.Size(145, 21)
        Me.chk_show.TabIndex = 118
        Me.chk_show.Title = "발주내역 조회"
        '
        'pset_bc
        '
        Me.pset_bc.Location = New System.Drawing.Point(520, 56)
        Me.pset_bc.Name = "pset_bc"
        Me.pset_bc.Size = New System.Drawing.Size(240, 21)
        Me.pset_bc.TabIndex = 117
        Me.pset_bc.Title = "pset_bc"
        '
        'bs_cd
        '
        Me.bs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bs_cd.Location = New System.Drawing.Point(1236, 11)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(100, 21)
        Me.bs_cd.TabIndex = 116
        Me.bs_cd.Title = "bs_cd"
        '
        'bs_fax
        '
        Me.bs_fax.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bs_fax.Location = New System.Drawing.Point(1236, 80)
        Me.bs_fax.Name = "bs_fax"
        Me.bs_fax.Size = New System.Drawing.Size(100, 21)
        Me.bs_fax.TabIndex = 115
        Me.bs_fax.Title = "bs_fax"
        '
        'bs_tel
        '
        Me.bs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bs_tel.Location = New System.Drawing.Point(1154, 80)
        Me.bs_tel.Name = "bs_tel"
        Me.bs_tel.Size = New System.Drawing.Size(100, 21)
        Me.bs_tel.TabIndex = 114
        Me.bs_tel.Title = "bs_tel"
        '
        'ceo_nm
        '
        Me.ceo_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceo_nm.Location = New System.Drawing.Point(1154, 56)
        Me.ceo_nm.Name = "ceo_nm"
        Me.ceo_nm.Size = New System.Drawing.Size(100, 21)
        Me.ceo_nm.TabIndex = 113
        Me.ceo_nm.Title = "ceo_nm"
        '
        'addr
        '
        Me.addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr.Location = New System.Drawing.Point(1154, 32)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(100, 21)
        Me.addr.TabIndex = 112
        Me.addr.Title = "addr"
        '
        'bs_nm
        '
        Me.bs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bs_nm.Location = New System.Drawing.Point(1154, 11)
        Me.bs_nm.Name = "bs_nm"
        Me.bs_nm.Size = New System.Drawing.Size(100, 21)
        Me.bs_nm.TabIndex = 109
        Me.bs_nm.Title = "bs_nm"
        '
        'fax
        '
        Me.fax.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fax.Location = New System.Drawing.Point(1005, 35)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(100, 21)
        Me.fax.TabIndex = 111
        Me.fax.Title = "fax"
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tel.Location = New System.Drawing.Point(1005, 8)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(100, 21)
        Me.tel.TabIndex = 110
        Me.tel.Title = "tel"
        '
        'di_bc
        '
        Me.di_bc.Location = New System.Drawing.Point(268, 32)
        Me.di_bc.Name = "di_bc"
        Me.di_bc.Size = New System.Drawing.Size(240, 21)
        Me.di_bc.TabIndex = 22
        Me.di_bc.Title = "내외자"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(12, 80)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(496, 21)
        Me.rmks.TabIndex = 18
        Me.rmks.Title = "비고"
        '
        'urg_bc
        '
        Me.urg_bc.Location = New System.Drawing.Point(12, 56)
        Me.urg_bc.Name = "urg_bc"
        Me.urg_bc.Size = New System.Drawing.Size(240, 21)
        Me.urg_bc.TabIndex = 50
        Me.urg_bc.Title = "긴급구분"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(268, 56)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 23
        Me.cury_bc.Title = "통화"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 15
        Me.cust_cd.Title = "매입업체"
        '
        'po_kd
        '
        Me.po_kd.Location = New System.Drawing.Point(12, 32)
        Me.po_kd.Name = "po_kd"
        Me.po_kd.Size = New System.Drawing.Size(240, 21)
        Me.po_kd.TabIndex = 3
        Me.po_kd.Title = "발주유형"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(520, 8)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 19
        Me.po_fac.Title = "발주공장"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(256, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 14
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(913, 11)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(45, 21)
        Me.stat_bc.TabIndex = 100
        Me.stat_bc.Title = "상태"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(520, 32)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 11
        Me.in_fac.Title = "입고공장"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(782, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 24)
        Me.SimpleButton1.TabIndex = 48
        Me.SimpleButton1.Text = "품목가져오기"
        '
        'btn_price
        '
        Me.btn_price.Location = New System.Drawing.Point(782, 38)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(112, 24)
        Me.btn_price.TabIndex = 49
        Me.btn_price.Text = "최근단가 적용"
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(520, 80)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(240, 21)
        Me.po_bc.TabIndex = 3
        Me.po_bc.Title = "po_bc"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(913, 41)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(65, 21)
        Me.in_wh.TabIndex = 10
        Me.in_wh.Title = "입고창고"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1364, 320)
        Me.SplitContainer2.SplitterDistance = 494
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.SplitContainer3)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(494, 320)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     발주조회"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_po_fr)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_po_to)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_cust_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.part_spec)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_cust_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_mov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_srh)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(490, 295)
        Me.SplitContainer3.SplitterDistance = 103
        Me.SplitContainer3.TabIndex = 2
        '
        'f_itm_nm
        '
        Me.f_itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_itm_nm.Location = New System.Drawing.Point(8, 52)
        Me.f_itm_nm.Name = "f_itm_nm"
        Me.f_itm_nm.Size = New System.Drawing.Size(309, 21)
        Me.f_itm_nm.TabIndex = 13
        Me.f_itm_nm.Title = "품명/규격"
        Me.f_itm_nm.TitleWidth = 90
        '
        'f_po_fr
        '
        Me.f_po_fr.Location = New System.Drawing.Point(8, 28)
        Me.f_po_fr.Name = "f_po_fr"
        Me.f_po_fr.Size = New System.Drawing.Size(200, 21)
        Me.f_po_fr.TabIndex = 34
        Me.f_po_fr.Title = "의뢰기간"
        Me.f_po_fr.TitleWidth = 90
        '
        'f_po_to
        '
        Me.f_po_to.Location = New System.Drawing.Point(117, 28)
        Me.f_po_to.Name = "f_po_to"
        Me.f_po_to.Size = New System.Drawing.Size(200, 21)
        Me.f_po_to.TabIndex = 34
        Me.f_po_to.Title = ""
        Me.f_po_to.TitleWidth = 90
        '
        'f_cust_cd
        '
        Me.f_cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_cd.Location = New System.Drawing.Point(8, 4)
        Me.f_cust_cd.Name = "f_cust_cd"
        Me.f_cust_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_cust_cd.TabIndex = 17
        Me.f_cust_cd.Title = "거래처"
        Me.f_cust_cd.TitleWidth = 90
        '
        'f_itm_bc
        '
        Me.f_itm_bc.Location = New System.Drawing.Point(8, 76)
        Me.f_itm_bc.Name = "f_itm_bc"
        Me.f_itm_bc.Size = New System.Drawing.Size(200, 21)
        Me.f_itm_bc.TabIndex = 18
        Me.f_itm_bc.Title = "품목구분"
        Me.f_itm_bc.TitleWidth = 90
        '
        'part_spec
        '
        Me.part_spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.part_spec.Location = New System.Drawing.Point(231, 52)
        Me.part_spec.Name = "part_spec"
        Me.part_spec.Size = New System.Drawing.Size(251, 21)
        Me.part_spec.TabIndex = 13
        Me.part_spec.Title = "품목명"
        Me.part_spec.TitleWidth = 90
        '
        'f_cust_nm
        '
        Me.f_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_nm.Location = New System.Drawing.Point(209, 4)
        Me.f_cust_nm.Name = "f_cust_nm"
        Me.f_cust_nm.Size = New System.Drawing.Size(273, 21)
        Me.f_cust_nm.TabIndex = 14
        Me.f_cust_nm.Title = "거래처"
        Me.f_cust_nm.TitleWidth = 0
        '
        'btn_mov
        '
        Me.btn_mov.Location = New System.Drawing.Point(295, 74)
        Me.btn_mov.Name = "btn_mov"
        Me.btn_mov.Size = New System.Drawing.Size(62, 23)
        Me.btn_mov.TabIndex = 20
        Me.btn_mov.Text = "적용"
        '
        'btn_srh
        '
        Me.btn_srh.Location = New System.Drawing.Point(231, 74)
        Me.btn_srh.Name = "btn_srh"
        Me.btn_srh.Size = New System.Drawing.Size(58, 23)
        Me.btn_srh.TabIndex = 19
        Me.btn_srh.Text = "검색"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(490, 188)
        Me.g20.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(866, 320)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     구매발주 상세 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(862, 295)
        Me.g10.TabIndex = 2
        '
        'MMA251
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMA251"
        Me.Size = New System.Drawing.Size(1374, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents po_kd As Frame7.eCombo
    Friend WithEvents po_dt As Frame7.eDate
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents po_no As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents po_nm As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents po_rid As Frame7.eText
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents di_bc As Frame7.eCombo
    Friend WithEvents po_dept As Frame7.eText
    Friend WithEvents po_dept_nm As Frame7.eText
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents btn_price As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents urg_bc As Frame7.eCombo
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents po_bc As Frame7.eCombo
    Friend WithEvents union_yn As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents sh_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents po_emp As Frame7.eText
    Friend WithEvents go_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bs_cd As Frame7.eText
    Friend WithEvents bs_fax As Frame7.eText
    Friend WithEvents bs_tel As Frame7.eText
    Friend WithEvents ceo_nm As Frame7.eText
    Friend WithEvents addr As Frame7.eText
    Friend WithEvents bs_nm As Frame7.eText
    Friend WithEvents fax As Frame7.eText
    Friend WithEvents tel As Frame7.eText
    Friend WithEvents pset_bc As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_itm_nm As Frame7.eText
    Friend WithEvents f_po_fr As Frame7.eDate
    Friend WithEvents f_po_to As Frame7.eDate
    Friend WithEvents f_cust_cd As Frame7.eText
    Friend WithEvents f_itm_bc As Frame7.eCombo
    Friend WithEvents part_spec As Frame7.eText
    Friend WithEvents f_cust_nm As Frame7.eText
    Friend WithEvents btn_mov As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_srh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents chk_show As Frame7.eCheck

End Class
