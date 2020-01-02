<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCV160
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.o_cust_cd = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.o_biz_no = New Frame7.eText()
        Me.o_use_yn = New Frame7.eCheck()
        Me.btn_open = New DevExpress.XtraEditors.SimpleButton()
        Me.o_cust_nm = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.cust_cd = New Frame7.eText()
        Me.cust_enm = New Frame7.eText()
        Me.addr_prt = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.fr_dt = New Frame7.eDate()
        Me.pay_bc = New Frame7.eCombo()
        Me.day_bc = New Frame7.eCombo()
        Me.size_bc = New Frame7.eCombo()
        Me.credit_bc = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.lv_bc = New Frame7.eCombo()
        Me.emp_cnt = New Frame7.eText()
        Me.sales_amt = New Frame7.eText()
        Me.items = New Frame7.eText()
        Me.acct_yn = New Frame7.eCheck()
        Me.co_no = New Frame7.eText()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.tel = New Frame7.eText()
        Me.fax = New Frame7.eText()
        Me.zip_cd = New Frame7.eText()
        Me.addr1 = New Frame7.eText()
        Me.homepage = New Frame7.eText()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.check = New DevExpress.XtraEditors.SimpleButton()
        Me.email = New Frame7.eText()
        Me.cury_bc = New Frame7.eCombo()
        Me.esero = New Frame7.eText()
        Me.prt_nm = New Frame7.eText()
        Me.nat_cd = New Frame7.eCombo()
        Me.biz_no = New Frame7.eText()
        Me.ceo_nm = New Frame7.eText()
        Me.biz_type = New Frame7.eText()
        Me.cust_bc = New Frame7.eCombo()
        Me.use_yn = New Frame7.eCheck()
        Me.acct_nm = New Frame7.eText()
        Me.acct_no = New Frame7.eText()
        Me.biz_kind = New Frame7.eText()
        Me.cust_kd = New Frame7.eCombo()
        Me.bank_nm = New Frame7.eText()
        Me.bank_cd = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(976, 636)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(261, 636)
        Me.SplitContainer2.SplitterDistance = 136
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_cust_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.o_biz_no)
        Me.EPanel1.Controls.Add(Me.o_use_yn)
        Me.EPanel1.Controls.Add(Me.btn_open)
        Me.EPanel1.Controls.Add(Me.o_cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(261, 136)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'o_cust_cd
        '
        Me.o_cust_cd.Location = New System.Drawing.Point(12, 32)
        Me.o_cust_cd.Name = "o_cust_cd"
        Me.o_cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_cust_cd.TabIndex = 2
        Me.o_cust_cd.Title = "거래처코드(%)"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(272, 40)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 12
        Me.co_cd.Title = "법인"
        '
        'o_biz_no
        '
        Me.o_biz_no.Location = New System.Drawing.Point(12, 80)
        Me.o_biz_no.Name = "o_biz_no"
        Me.o_biz_no.Size = New System.Drawing.Size(240, 21)
        Me.o_biz_no.TabIndex = 4
        Me.o_biz_no.Title = "사업자번호(%)"
        '
        'o_use_yn
        '
        Me.o_use_yn.Caption = ""
        Me.o_use_yn.Location = New System.Drawing.Point(12, 104)
        Me.o_use_yn.Name = "o_use_yn"
        Me.o_use_yn.Size = New System.Drawing.Size(152, 21)
        Me.o_use_yn.TabIndex = 7
        Me.o_use_yn.Title = "거래여부"
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(188, 104)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(64, 24)
        Me.btn_open.TabIndex = 19
        Me.btn_open.Text = "OPEN"
        '
        'o_cust_nm
        '
        Me.o_cust_nm.Location = New System.Drawing.Point(12, 56)
        Me.o_cust_nm.Name = "o_cust_nm"
        Me.o_cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.o_cust_nm.TabIndex = 3
        Me.o_cust_nm.Title = "거래처명(%)"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(261, 496)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(711, 636)
        Me.SplitContainer3.SplitterDistance = 55
        Me.SplitContainer3.TabIndex = 0
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel2)
        Me.SplitContainer4.Panel2Collapsed = True
        Me.SplitContainer4.Size = New System.Drawing.Size(711, 636)
        Me.SplitContainer4.SplitterDistance = 55
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.cust_cd)
        Me.EPanel2.Controls.Add(Me.cust_enm)
        Me.EPanel2.Controls.Add(Me.addr_prt)
        Me.EPanel2.Controls.Add(Me.cust_nm)
        Me.EPanel2.Controls.Add(Me.XtraTabControl2)
        Me.EPanel2.Controls.Add(Me.check)
        Me.EPanel2.Controls.Add(Me.email)
        Me.EPanel2.Controls.Add(Me.cury_bc)
        Me.EPanel2.Controls.Add(Me.esero)
        Me.EPanel2.Controls.Add(Me.prt_nm)
        Me.EPanel2.Controls.Add(Me.nat_cd)
        Me.EPanel2.Controls.Add(Me.biz_no)
        Me.EPanel2.Controls.Add(Me.ceo_nm)
        Me.EPanel2.Controls.Add(Me.biz_type)
        Me.EPanel2.Controls.Add(Me.cust_bc)
        Me.EPanel2.Controls.Add(Me.use_yn)
        Me.EPanel2.Controls.Add(Me.acct_no)
        Me.EPanel2.Controls.Add(Me.biz_kind)
        Me.EPanel2.Controls.Add(Me.acct_nm)
        Me.EPanel2.Controls.Add(Me.cust_kd)
        Me.EPanel2.Controls.Add(Me.bank_nm)
        Me.EPanel2.Controls.Add(Me.bank_cd)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(711, 636)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     거래처정보"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(12, 32)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 5
        Me.cust_cd.Title = "거래처코드"
        '
        'cust_enm
        '
        Me.cust_enm.Location = New System.Drawing.Point(12, 104)
        Me.cust_enm.Name = "cust_enm"
        Me.cust_enm.Size = New System.Drawing.Size(364, 21)
        Me.cust_enm.TabIndex = 8
        Me.cust_enm.Title = "거래처명(영문)"
        '
        'addr_prt
        '
        Me.addr_prt.Location = New System.Drawing.Point(12, 232)
        Me.addr_prt.Name = "addr_prt"
        Me.addr_prt.Size = New System.Drawing.Size(364, 21)
        Me.addr_prt.TabIndex = 42
        Me.addr_prt.Title = "주소(인쇄)"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(12, 56)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(364, 21)
        Me.cust_nm.TabIndex = 6
        Me.cust_nm.Title = "거래처명(한글)"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Location = New System.Drawing.Point(4, 264)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(707, 368)
        Me.XtraTabControl2.TabIndex = 43
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage5, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.fr_dt)
        Me.XtraTabPage2.Controls.Add(Me.pay_bc)
        Me.XtraTabPage2.Controls.Add(Me.day_bc)
        Me.XtraTabPage2.Controls.Add(Me.size_bc)
        Me.XtraTabPage2.Controls.Add(Me.credit_bc)
        Me.XtraTabPage2.Controls.Add(Me.to_dt)
        Me.XtraTabPage2.Controls.Add(Me.lv_bc)
        Me.XtraTabPage2.Controls.Add(Me.emp_cnt)
        Me.XtraTabPage2.Controls.Add(Me.sales_amt)
        Me.XtraTabPage2.Controls.Add(Me.items)
        Me.XtraTabPage2.Controls.Add(Me.acct_yn)
        Me.XtraTabPage2.Controls.Add(Me.co_no)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(700, 338)
        Me.XtraTabPage2.Text = "기타정보"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(268, 80)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "거래개시일"
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(268, 56)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(240, 21)
        Me.pay_bc.TabIndex = 46
        Me.pay_bc.Title = "지급구분"
        '
        'day_bc
        '
        Me.day_bc.Location = New System.Drawing.Point(268, 32)
        Me.day_bc.Name = "day_bc"
        Me.day_bc.Size = New System.Drawing.Size(240, 21)
        Me.day_bc.TabIndex = 46
        Me.day_bc.Title = "전기지급일자"
        '
        'size_bc
        '
        Me.size_bc.Location = New System.Drawing.Point(8, 80)
        Me.size_bc.Name = "size_bc"
        Me.size_bc.Size = New System.Drawing.Size(240, 21)
        Me.size_bc.TabIndex = 46
        Me.size_bc.Title = "기업규모"
        '
        'credit_bc
        '
        Me.credit_bc.Location = New System.Drawing.Point(8, 56)
        Me.credit_bc.Name = "credit_bc"
        Me.credit_bc.Size = New System.Drawing.Size(240, 21)
        Me.credit_bc.TabIndex = 46
        Me.credit_bc.Title = "신용등급"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(268, 104)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 48
        Me.to_dt.Title = "거래종료일"
        '
        'lv_bc
        '
        Me.lv_bc.Location = New System.Drawing.Point(8, 32)
        Me.lv_bc.Name = "lv_bc"
        Me.lv_bc.Size = New System.Drawing.Size(240, 21)
        Me.lv_bc.TabIndex = 45
        Me.lv_bc.Title = "중요도"
        '
        'emp_cnt
        '
        Me.emp_cnt.Location = New System.Drawing.Point(8, 128)
        Me.emp_cnt.Name = "emp_cnt"
        Me.emp_cnt.Size = New System.Drawing.Size(240, 21)
        Me.emp_cnt.TabIndex = 33
        Me.emp_cnt.Title = "종업원수"
        '
        'sales_amt
        '
        Me.sales_amt.Location = New System.Drawing.Point(8, 104)
        Me.sales_amt.Name = "sales_amt"
        Me.sales_amt.Size = New System.Drawing.Size(240, 21)
        Me.sales_amt.TabIndex = 33
        Me.sales_amt.Title = "매출액"
        '
        'items
        '
        Me.items.Location = New System.Drawing.Point(8, 152)
        Me.items.Name = "items"
        Me.items.Size = New System.Drawing.Size(500, 21)
        Me.items.TabIndex = 35
        Me.items.Title = "거래품목"
        '
        'acct_yn
        '
        Me.acct_yn.Caption = ""
        Me.acct_yn.Location = New System.Drawing.Point(268, 8)
        Me.acct_yn.Name = "acct_yn"
        Me.acct_yn.Size = New System.Drawing.Size(164, 21)
        Me.acct_yn.TabIndex = 9
        Me.acct_yn.Title = "계좌개설여부"
        '
        'co_no
        '
        Me.co_no.Location = New System.Drawing.Point(8, 8)
        Me.co_no.Name = "co_no"
        Me.co_no.Size = New System.Drawing.Size(240, 21)
        Me.co_no.TabIndex = 14
        Me.co_no.Title = "법인번호"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.tel)
        Me.XtraTabPage5.Controls.Add(Me.fax)
        Me.XtraTabPage5.Controls.Add(Me.zip_cd)
        Me.XtraTabPage5.Controls.Add(Me.addr1)
        Me.XtraTabPage5.Controls.Add(Me.homepage)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(700, 338)
        Me.XtraTabPage5.Text = "소재정보"
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(8, 8)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(272, 21)
        Me.tel.TabIndex = 41
        Me.tel.Title = "Tel"
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(8, 32)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(272, 21)
        Me.fax.TabIndex = 42
        Me.fax.Title = "Fax"
        '
        'zip_cd
        '
        Me.zip_cd.Location = New System.Drawing.Point(8, 88)
        Me.zip_cd.Name = "zip_cd"
        Me.zip_cd.Size = New System.Drawing.Size(272, 21)
        Me.zip_cd.TabIndex = 33
        Me.zip_cd.Title = "우편번호"
        '
        'addr1
        '
        Me.addr1.Location = New System.Drawing.Point(8, 112)
        Me.addr1.Name = "addr1"
        Me.addr1.Size = New System.Drawing.Size(532, 21)
        Me.addr1.TabIndex = 35
        Me.addr1.Title = "주소"
        '
        'homepage
        '
        Me.homepage.Location = New System.Drawing.Point(8, 56)
        Me.homepage.Name = "homepage"
        Me.homepage.Size = New System.Drawing.Size(272, 21)
        Me.homepage.TabIndex = 44
        Me.homepage.Title = "HomePage"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g20)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(700, 338)
        Me.XtraTabPage3.Text = "변경이력"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(700, 338)
        Me.g20.TabIndex = 3
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.g30)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(700, 338)
        Me.XtraTabPage4.Text = "명함정보"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(700, 338)
        Me.g30.TabIndex = 4
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(292, 132)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(80, 24)
        Me.check.TabIndex = 20
        Me.check.Text = "중복 Check"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(396, 232)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(248, 21)
        Me.email.TabIndex = 43
        Me.email.Title = "E-Mail"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(396, 56)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(248, 21)
        Me.cury_bc.TabIndex = 24
        Me.cury_bc.Title = "결제통화"
        '
        'esero
        '
        Me.esero.Location = New System.Drawing.Point(396, 208)
        Me.esero.Name = "esero"
        Me.esero.Size = New System.Drawing.Size(248, 21)
        Me.esero.TabIndex = 33
        Me.esero.Title = "전자계산서담당자"
        '
        'prt_nm
        '
        Me.prt_nm.Location = New System.Drawing.Point(12, 80)
        Me.prt_nm.Name = "prt_nm"
        Me.prt_nm.Size = New System.Drawing.Size(364, 21)
        Me.prt_nm.TabIndex = 7
        Me.prt_nm.Title = "거래처명(인쇄)"
        '
        'nat_cd
        '
        Me.nat_cd.Location = New System.Drawing.Point(396, 32)
        Me.nat_cd.Name = "nat_cd"
        Me.nat_cd.Size = New System.Drawing.Size(248, 21)
        Me.nat_cd.TabIndex = 23
        Me.nat_cd.Title = "소재국가"
        '
        'biz_no
        '
        Me.biz_no.Location = New System.Drawing.Point(12, 136)
        Me.biz_no.Name = "biz_no"
        Me.biz_no.Size = New System.Drawing.Size(240, 21)
        Me.biz_no.TabIndex = 14
        Me.biz_no.Title = "사업자번호"
        '
        'ceo_nm
        '
        Me.ceo_nm.Location = New System.Drawing.Point(12, 160)
        Me.ceo_nm.Name = "ceo_nm"
        Me.ceo_nm.Size = New System.Drawing.Size(240, 21)
        Me.ceo_nm.TabIndex = 15
        Me.ceo_nm.Title = "대표자명"
        '
        'biz_type
        '
        Me.biz_type.Location = New System.Drawing.Point(12, 184)
        Me.biz_type.Name = "biz_type"
        Me.biz_type.Size = New System.Drawing.Size(364, 21)
        Me.biz_type.TabIndex = 16
        Me.biz_type.Title = "업태"
        '
        'cust_bc
        '
        Me.cust_bc.Location = New System.Drawing.Point(396, 80)
        Me.cust_bc.Name = "cust_bc"
        Me.cust_bc.Size = New System.Drawing.Size(248, 21)
        Me.cust_bc.TabIndex = 12
        Me.cust_bc.Title = "거래처구분"
        '
        'use_yn
        '
        Me.use_yn.Caption = ""
        Me.use_yn.Location = New System.Drawing.Point(272, 32)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(112, 21)
        Me.use_yn.TabIndex = 9
        Me.use_yn.Title = "사용여부"
        Me.use_yn.TitleWidth = 88
        '
        'acct_nm
        '
        Me.acct_nm.Location = New System.Drawing.Point(396, 160)
        Me.acct_nm.Name = "acct_nm"
        Me.acct_nm.Size = New System.Drawing.Size(248, 21)
        Me.acct_nm.TabIndex = 30
        Me.acct_nm.Title = "예금주"
        '
        'acct_no
        '
        Me.acct_no.Location = New System.Drawing.Point(396, 184)
        Me.acct_no.Name = "acct_no"
        Me.acct_no.Size = New System.Drawing.Size(248, 21)
        Me.acct_no.TabIndex = 41
        Me.acct_no.Title = "계좌번호"
        '
        'biz_kind
        '
        Me.biz_kind.Location = New System.Drawing.Point(12, 208)
        Me.biz_kind.Name = "biz_kind"
        Me.biz_kind.Size = New System.Drawing.Size(364, 21)
        Me.biz_kind.TabIndex = 17
        Me.biz_kind.Title = "업종"
        '
        'cust_kd
        '
        Me.cust_kd.Location = New System.Drawing.Point(396, 104)
        Me.cust_kd.Name = "cust_kd"
        Me.cust_kd.Size = New System.Drawing.Size(248, 21)
        Me.cust_kd.TabIndex = 13
        Me.cust_kd.Title = "거래처형태"
        '
        'bank_nm
        '
        Me.bank_nm.Location = New System.Drawing.Point(396, 136)
        Me.bank_nm.Name = "bank_nm"
        Me.bank_nm.Size = New System.Drawing.Size(248, 21)
        Me.bank_nm.TabIndex = 30
        Me.bank_nm.Title = "은행"
        '
        'bank_cd
        '
        Me.bank_cd.Location = New System.Drawing.Point(648, 136)
        Me.bank_cd.Name = "bank_cd"
        Me.bank_cd.Size = New System.Drawing.Size(60, 21)
        Me.bank_cd.TabIndex = 30
        Me.bank_cd.Title = "bank_cd"
        '
        'BCV160
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCV160"
        Me.Size = New System.Drawing.Size(1494, 767)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents o_biz_no As Frame7.eText
    Friend WithEvents o_cust_nm As Frame7.eText
    Friend WithEvents o_cust_cd As Frame7.eText
    Friend WithEvents o_use_yn As Frame7.eCheck
    Friend WithEvents btn_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents cust_enm As Frame7.eText
    Friend WithEvents prt_nm As Frame7.eText
    Friend WithEvents use_yn As Frame7.eCheck
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents check As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents biz_kind As Frame7.eText
    Friend WithEvents biz_type As Frame7.eText
    Friend WithEvents ceo_nm As Frame7.eText
    Friend WithEvents biz_no As Frame7.eText
    Friend WithEvents cust_kd As Frame7.eCombo
    Friend WithEvents cust_bc As Frame7.eCombo
    Friend WithEvents acct_no As Frame7.eText
    Friend WithEvents addr1 As Frame7.eText
    Friend WithEvents zip_cd As Frame7.eText
    Friend WithEvents acct_nm As Frame7.eText
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents nat_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents addr_prt As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents credit_bc As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents lv_bc As Frame7.eCombo
    Friend WithEvents tel As Frame7.eText
    Friend WithEvents fax As Frame7.eText
    Friend WithEvents homepage As Frame7.eText
    Friend WithEvents email As Frame7.eText
    Friend WithEvents esero As Frame7.eText
    Friend WithEvents emp_cnt As Frame7.eText
    Friend WithEvents sales_amt As Frame7.eText
    Friend WithEvents items As Frame7.eText
    Friend WithEvents acct_yn As Frame7.eCheck
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents size_bc As Frame7.eCombo
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents day_bc As Frame7.eCombo
    Friend WithEvents co_no As Frame7.eText
    Friend WithEvents bank_nm As Frame7.eText
    Friend WithEvents bank_cd As Frame7.eText

End Class
