<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB100
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
        Me.po_fac = New Frame7.eCombo()
        Me.dlv_dt = New Frame7.eDate()
        Me.po_dept_nm = New Frame7.eText()
        Me.po_nm = New Frame7.eText()
        Me.po_dept = New Frame7.eText()
        Me.po_rid = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.chk_all = New Frame7.eCheck()
        Me.bs_cd = New Frame7.eText()
        Me.bs_fax = New Frame7.eText()
        Me.bs_tel = New Frame7.eText()
        Me.ceo_nm = New Frame7.eText()
        Me.addr = New Frame7.eText()
        Me.bs_nm = New Frame7.eText()
        Me.tel = New Frame7.eText()
        Me.pset_bc = New Frame7.eCombo()
        Me.stat_bc = New Frame7.eCombo()
        Me.di_bc = New Frame7.eCombo()
        Me.rmks = New Frame7.eText()
        Me.urg_bc = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.fax = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.in_fac = New Frame7.eCombo()
        Me.po_kd = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.in_wh = New Frame7.eCombo()
        Me.po_bc = New Frame7.eCombo()
        Me.btn_price = New DevExpress.XtraEditors.SimpleButton()
        Me.mmv_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
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
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1269, 516)
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
        Me.EPanel3.Controls.Add(Me.po_fac)
        Me.EPanel3.Controls.Add(Me.dlv_dt)
        Me.EPanel3.Controls.Add(Me.po_dept_nm)
        Me.EPanel3.Controls.Add(Me.po_nm)
        Me.EPanel3.Controls.Add(Me.po_dept)
        Me.EPanel3.Controls.Add(Me.po_rid)
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1269, 80)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     발주정보"
        '
        'sh_gw
        '
        Me.sh_gw.Location = New System.Drawing.Point(898, 28)
        Me.sh_gw.Name = "sh_gw"
        Me.sh_gw.Size = New System.Drawing.Size(112, 45)
        Me.sh_gw.TabIndex = 101
        Me.sh_gw.Text = "결재조회"
        '
        'po_emp
        '
        Me.po_emp.Location = New System.Drawing.Point(1193, 54)
        Me.po_emp.Name = "po_emp"
        Me.po_emp.Size = New System.Drawing.Size(48, 21)
        Me.po_emp.TabIndex = 100
        Me.po_emp.Title = "po_emp"
        '
        'go_gw
        '
        Me.go_gw.Location = New System.Drawing.Point(780, 28)
        Me.go_gw.Name = "go_gw"
        Me.go_gw.Size = New System.Drawing.Size(112, 45)
        Me.go_gw.TabIndex = 99
        Me.go_gw.Text = "결재상신"
        '
        'po_no
        '
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
        Me.union_yn.Location = New System.Drawing.Point(1165, 28)
        Me.union_yn.Name = "union_yn"
        Me.union_yn.Size = New System.Drawing.Size(60, 21)
        Me.union_yn.TabIndex = 98
        Me.union_yn.Title = "union_yn"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(268, 28)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 19
        Me.po_fac.Title = "발주공장"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(268, 52)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 17
        Me.dlv_dt.Title = "납기일자"
        '
        'po_dept_nm
        '
        Me.po_dept_nm.Location = New System.Drawing.Point(520, 52)
        Me.po_dept_nm.Name = "po_dept_nm"
        Me.po_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_dept_nm.TabIndex = 20
        Me.po_dept_nm.Title = "po_dept_nm"
        '
        'po_nm
        '
        Me.po_nm.Location = New System.Drawing.Point(520, 28)
        Me.po_nm.Name = "po_nm"
        Me.po_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_nm.TabIndex = 16
        Me.po_nm.Title = "po_nm"
        '
        'po_dept
        '
        Me.po_dept.Location = New System.Drawing.Point(1087, 52)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(100, 21)
        Me.po_dept.TabIndex = 21
        Me.po_dept.Title = "po_dept"
        '
        'po_rid
        '
        Me.po_rid.Location = New System.Drawing.Point(1059, 28)
        Me.po_rid.Name = "po_rid"
        Me.po_rid.Size = New System.Drawing.Size(48, 21)
        Me.po_rid.TabIndex = 13
        Me.po_rid.Title = "po_rid"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.chk_all)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.bs_fax)
        Me.EPanel1.Controls.Add(Me.bs_tel)
        Me.EPanel1.Controls.Add(Me.ceo_nm)
        Me.EPanel1.Controls.Add(Me.addr)
        Me.EPanel1.Controls.Add(Me.bs_nm)
        Me.EPanel1.Controls.Add(Me.tel)
        Me.EPanel1.Controls.Add(Me.pset_bc)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.di_bc)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.urg_bc)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.fax)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.po_kd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.Controls.Add(Me.btn_price)
        Me.EPanel1.Controls.Add(Me.mmv_btn)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1269, 107)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "검색"
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Location = New System.Drawing.Point(898, 11)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(112, 21)
        Me.chk_all.TabIndex = 109
        Me.chk_all.Title = "단가품목 전체"
        Me.chk_all.TitleWidth = 90
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(1141, 11)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(100, 21)
        Me.bs_cd.TabIndex = 108
        Me.bs_cd.Title = "bs_cd"
        '
        'bs_fax
        '
        Me.bs_fax.Location = New System.Drawing.Point(1141, 80)
        Me.bs_fax.Name = "bs_fax"
        Me.bs_fax.Size = New System.Drawing.Size(100, 21)
        Me.bs_fax.TabIndex = 107
        Me.bs_fax.Title = "bs_fax"
        '
        'bs_tel
        '
        Me.bs_tel.Location = New System.Drawing.Point(1059, 80)
        Me.bs_tel.Name = "bs_tel"
        Me.bs_tel.Size = New System.Drawing.Size(100, 21)
        Me.bs_tel.TabIndex = 106
        Me.bs_tel.Title = "bs_tel"
        '
        'ceo_nm
        '
        Me.ceo_nm.Location = New System.Drawing.Point(1059, 56)
        Me.ceo_nm.Name = "ceo_nm"
        Me.ceo_nm.Size = New System.Drawing.Size(100, 21)
        Me.ceo_nm.TabIndex = 105
        Me.ceo_nm.Title = "ceo_nm"
        '
        'addr
        '
        Me.addr.Location = New System.Drawing.Point(1059, 32)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(100, 21)
        Me.addr.TabIndex = 104
        Me.addr.Title = "addr"
        '
        'bs_nm
        '
        Me.bs_nm.Location = New System.Drawing.Point(1059, 11)
        Me.bs_nm.Name = "bs_nm"
        Me.bs_nm.Size = New System.Drawing.Size(100, 21)
        Me.bs_nm.TabIndex = 102
        Me.bs_nm.Title = "bs_nm"
        '
        'tel
        '
        Me.tel.Location = New System.Drawing.Point(1111, 32)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(26, 21)
        Me.tel.TabIndex = 102
        Me.tel.Title = "tel"
        '
        'pset_bc
        '
        Me.pset_bc.Location = New System.Drawing.Point(520, 8)
        Me.pset_bc.Name = "pset_bc"
        Me.pset_bc.Size = New System.Drawing.Size(240, 21)
        Me.pset_bc.TabIndex = 101
        Me.pset_bc.Title = "pset_bc"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(770, 81)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 100
        Me.stat_bc.Title = "상태"
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
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(780, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 24)
        Me.SimpleButton1.TabIndex = 48
        Me.SimpleButton1.Text = "품목가져오기"
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(1184, 8)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(26, 21)
        Me.fax.TabIndex = 103
        Me.fax.Title = "fax"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(12, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 15
        Me.cust_cd.Title = "매입업체"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(520, 32)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 11
        Me.in_fac.Title = "입고공장"
        '
        'po_kd
        '
        Me.po_kd.Location = New System.Drawing.Point(12, 32)
        Me.po_kd.Name = "po_kd"
        Me.po_kd.Size = New System.Drawing.Size(240, 21)
        Me.po_kd.TabIndex = 3
        Me.po_kd.Title = "발주유형"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(256, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 14
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(520, 56)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 10
        Me.in_wh.Title = "입고창고"
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(520, 80)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(240, 21)
        Me.po_bc.TabIndex = 3
        Me.po_bc.Title = "po_bc"
        '
        'btn_price
        '
        Me.btn_price.Location = New System.Drawing.Point(780, 36)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(112, 24)
        Me.btn_price.TabIndex = 49
        Me.btn_price.Text = "최근단가 적용"
        '
        'mmv_btn
        '
        Me.mmv_btn.Location = New System.Drawing.Point(898, 36)
        Me.mmv_btn.Name = "mmv_btn"
        Me.mmv_btn.Size = New System.Drawing.Size(112, 24)
        Me.mmv_btn.TabIndex = 49
        Me.mmv_btn.Text = "기준단가 저장"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1269, 320)
        Me.SplitContainer2.SplitterDistance = 1036
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1036, 320)
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
        Me.g10.Size = New System.Drawing.Size(1032, 295)
        Me.g10.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(229, 320)
        Me.EPanel4.TabIndex = 2
        Me.EPanel4.Text = "     구매발주 상세 등록"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(225, 295)
        Me.g20.TabIndex = 2
        '
        'MMB100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB100"
        Me.Size = New System.Drawing.Size(1279, 563)
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
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
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
    Friend WithEvents go_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents po_emp As Frame7.eText
    Friend WithEvents sh_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pset_bc As Frame7.eCombo
    Friend WithEvents fax As Frame7.eText
    Friend WithEvents tel As Frame7.eText
    Friend WithEvents addr As Frame7.eText
    Friend WithEvents bs_nm As Frame7.eText
    Friend WithEvents ceo_nm As Frame7.eText
    Friend WithEvents bs_fax As Frame7.eText
    Friend WithEvents bs_tel As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eText
    Friend WithEvents mmv_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid

End Class
