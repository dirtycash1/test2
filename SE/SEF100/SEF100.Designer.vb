<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEF100
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.bs_f_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.f_high_bc = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.f_duty_bc = New Frame7.eCombo()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_out = New DevExpress.XtraEditors.SimpleButton()
        Me.wh_cd = New Frame7.eCombo()
        Me.bank_cd = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.amt = New Frame7.eText()
        Me.ex_rt = New Frame7.eText()
        Me.ship_dt = New Frame7.eDate()
        Me.famt = New Frame7.eText()
        Me.invo_no = New Frame7.eText()
        Me.home = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.fr_bc = New Frame7.eCombo()
        Me.po_no = New Frame7.eText()
        Me.bl_no = New Frame7.eText()
        Me.note_no = New Frame7.eText()
        Me.loc_dt = New Frame7.eDate()
        Me.to_bc = New Frame7.eCombo()
        Me.bs_cd = New Frame7.eCombo()
        Me.end_dt = New Frame7.eDate()
        Me.amt_bc = New Frame7.eCombo()
        Me.pay_bc = New Frame7.eCombo()
        Me.file_no = New Frame7.eText()
        Me.day_bc = New Frame7.eCombo()
        Me.open_dt = New Frame7.eDate()
        Me.work_ty = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1044, 556)
        Me.SplitContainer1.SplitterDistance = 257
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(257, 556)
        Me.SplitContainer3.SplitterDistance = 104
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_f_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.f_high_bc)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.f_duty_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(257, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'bs_f_cd
        '
        Me.bs_f_cd.Location = New System.Drawing.Point(12, 28)
        Me.bs_f_cd.Name = "bs_f_cd"
        Me.bs_f_cd.Size = New System.Drawing.Size(230, 21)
        Me.bs_f_cd.TabIndex = 91
        Me.bs_f_cd.Title = "사업장"
        Me.bs_f_cd.TitleWidth = 110
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 52)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(230, 21)
        Me.fr_dt.TabIndex = 90
        Me.fr_dt.Title = "개설일"
        Me.fr_dt.TitleWidth = 110
        '
        'f_high_bc
        '
        Me.f_high_bc.Location = New System.Drawing.Point(536, 100)
        Me.f_high_bc.Name = "f_high_bc"
        Me.f_high_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_high_bc.TabIndex = 89
        Me.f_high_bc.Title = "직위"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(124, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(118, 21)
        Me.to_dt.TabIndex = 90
        Me.to_dt.Title = "개설일"
        Me.to_dt.TitleWidth = 0
        '
        'f_duty_bc
        '
        Me.f_duty_bc.Location = New System.Drawing.Point(536, 124)
        Me.f_duty_bc.Name = "f_duty_bc"
        Me.f_duty_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_duty_bc.TabIndex = 88
        Me.f_duty_bc.Title = "직책"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g10)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(257, 448)
        Me.EPanel4.TabIndex = 3
        Me.EPanel4.Text = "     수출 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(253, 423)
        Me.g10.TabIndex = 2
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
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(783, 556)
        Me.SplitContainer2.SplitterDistance = 251
        Me.SplitContainer2.TabIndex = 65
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.Panel2)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(783, 251)
        Me.EPanel3.TabIndex = 63
        Me.EPanel3.Text = "     수출 Master 정보"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.btn_out)
        Me.Panel2.Controls.Add(Me.wh_cd)
        Me.Panel2.Controls.Add(Me.bank_cd)
        Me.Panel2.Controls.Add(Me.cury_bc)
        Me.Panel2.Controls.Add(Me.fac_cd)
        Me.Panel2.Controls.Add(Me.cust_nm)
        Me.Panel2.Controls.Add(Me.amt)
        Me.Panel2.Controls.Add(Me.ex_rt)
        Me.Panel2.Controls.Add(Me.ship_dt)
        Me.Panel2.Controls.Add(Me.famt)
        Me.Panel2.Controls.Add(Me.invo_no)
        Me.Panel2.Controls.Add(Me.home)
        Me.Panel2.Controls.Add(Me.cust_cd)
        Me.Panel2.Controls.Add(Me.fr_bc)
        Me.Panel2.Controls.Add(Me.po_no)
        Me.Panel2.Controls.Add(Me.bl_no)
        Me.Panel2.Controls.Add(Me.note_no)
        Me.Panel2.Controls.Add(Me.loc_dt)
        Me.Panel2.Controls.Add(Me.to_bc)
        Me.Panel2.Controls.Add(Me.bs_cd)
        Me.Panel2.Controls.Add(Me.end_dt)
        Me.Panel2.Controls.Add(Me.amt_bc)
        Me.Panel2.Controls.Add(Me.pay_bc)
        Me.Panel2.Controls.Add(Me.file_no)
        Me.Panel2.Controls.Add(Me.day_bc)
        Me.Panel2.Controls.Add(Me.open_dt)
        Me.Panel2.Controls.Add(Me.work_ty)
        Me.Panel2.Controls.Add(Me.dept_cd)
        Me.Panel2.Controls.Add(Me.dept_nm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 226)
        Me.Panel2.TabIndex = 3
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(600, 196)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 24)
        Me.btn_cancel.TabIndex = 112
        Me.btn_cancel.Text = "출고취소"
        '
        'btn_out
        '
        Me.btn_out.Location = New System.Drawing.Point(488, 196)
        Me.btn_out.Name = "btn_out"
        Me.btn_out.Size = New System.Drawing.Size(100, 24)
        Me.btn_out.TabIndex = 112
        Me.btn_out.Text = "출고처리"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(704, 144)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(60, 21)
        Me.wh_cd.TabIndex = 110
        Me.wh_cd.Title = "출고창고"
        Me.wh_cd.TitleWidth = 108
        '
        'bank_cd
        '
        Me.bank_cd.Location = New System.Drawing.Point(488, 56)
        Me.bank_cd.Name = "bank_cd"
        Me.bank_cd.Size = New System.Drawing.Size(230, 21)
        Me.bank_cd.TabIndex = 105
        Me.bank_cd.Title = "bank_cd"
        Me.bank_cd.TitleWidth = 108
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(488, 80)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(230, 21)
        Me.cury_bc.TabIndex = 105
        Me.cury_bc.Title = "통화"
        Me.cury_bc.TitleWidth = 108
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(704, 120)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(60, 21)
        Me.fac_cd.TabIndex = 111
        Me.fac_cd.Title = "출고공장"
        Me.fac_cd.TitleWidth = 108
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(480, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(238, 21)
        Me.cust_nm.TabIndex = 104
        Me.cust_nm.Title = "거래처"
        Me.cust_nm.TitleWidth = 0
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.amt.Location = New System.Drawing.Point(488, 152)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(230, 21)
        Me.amt.TabIndex = 103
        Me.amt.Title = "원화"
        Me.amt.TitleWidth = 108
        '
        'ex_rt
        '
        Me.ex_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ex_rt.Location = New System.Drawing.Point(488, 128)
        Me.ex_rt.Name = "ex_rt"
        Me.ex_rt.Size = New System.Drawing.Size(230, 21)
        Me.ex_rt.TabIndex = 102
        Me.ex_rt.Title = "환율"
        Me.ex_rt.TitleWidth = 108
        '
        'ship_dt
        '
        Me.ship_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_dt.Location = New System.Drawing.Point(8, 104)
        Me.ship_dt.Name = "ship_dt"
        Me.ship_dt.Size = New System.Drawing.Size(230, 21)
        Me.ship_dt.TabIndex = 100
        Me.ship_dt.Title = "선적일자"
        Me.ship_dt.TitleWidth = 108
        '
        'famt
        '
        Me.famt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.famt.Location = New System.Drawing.Point(488, 104)
        Me.famt.Name = "famt"
        Me.famt.Size = New System.Drawing.Size(230, 21)
        Me.famt.TabIndex = 99
        Me.famt.Title = "외화"
        Me.famt.TitleWidth = 108
        '
        'invo_no
        '
        Me.invo_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.invo_no.Location = New System.Drawing.Point(8, 128)
        Me.invo_no.Name = "invo_no"
        Me.invo_no.Size = New System.Drawing.Size(230, 21)
        Me.invo_no.TabIndex = 63
        Me.invo_no.Title = "Invoice번호"
        Me.invo_no.TitleWidth = 108
        '
        'home
        '
        Me.home.Location = New System.Drawing.Point(248, 176)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(230, 21)
        Me.home.TabIndex = 89
        Me.home.Title = "원산지"
        Me.home.TitleWidth = 108
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(248, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(230, 21)
        Me.cust_cd.TabIndex = 67
        Me.cust_cd.Title = "거래처"
        Me.cust_cd.TitleWidth = 108
        '
        'fr_bc
        '
        Me.fr_bc.Location = New System.Drawing.Point(248, 128)
        Me.fr_bc.Name = "fr_bc"
        Me.fr_bc.Size = New System.Drawing.Size(230, 21)
        Me.fr_bc.TabIndex = 83
        Me.fr_bc.Title = "선적항"
        Me.fr_bc.TitleWidth = 108
        '
        'po_no
        '
        Me.po_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_no.Location = New System.Drawing.Point(8, 200)
        Me.po_no.Name = "po_no"
        Me.po_no.Size = New System.Drawing.Size(230, 21)
        Me.po_no.TabIndex = 65
        Me.po_no.Title = "고객PO번호"
        Me.po_no.TitleWidth = 108
        '
        'bl_no
        '
        Me.bl_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bl_no.Location = New System.Drawing.Point(8, 176)
        Me.bl_no.Name = "bl_no"
        Me.bl_no.Size = New System.Drawing.Size(230, 21)
        Me.bl_no.TabIndex = 65
        Me.bl_no.Title = "B/L번호"
        Me.bl_no.TitleWidth = 108
        '
        'note_no
        '
        Me.note_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.note_no.Location = New System.Drawing.Point(8, 152)
        Me.note_no.Name = "note_no"
        Me.note_no.Size = New System.Drawing.Size(230, 21)
        Me.note_no.TabIndex = 64
        Me.note_no.Title = "신고번호"
        Me.note_no.TitleWidth = 108
        '
        'loc_dt
        '
        Me.loc_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loc_dt.Location = New System.Drawing.Point(8, 80)
        Me.loc_dt.Name = "loc_dt"
        Me.loc_dt.Size = New System.Drawing.Size(230, 21)
        Me.loc_dt.TabIndex = 92
        Me.loc_dt.Title = "통관신고일"
        Me.loc_dt.TitleWidth = 108
        '
        'to_bc
        '
        Me.to_bc.Location = New System.Drawing.Point(248, 152)
        Me.to_bc.Name = "to_bc"
        Me.to_bc.Size = New System.Drawing.Size(230, 21)
        Me.to_bc.TabIndex = 81
        Me.to_bc.Title = "도착항"
        Me.to_bc.TitleWidth = 108
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(248, 32)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(230, 21)
        Me.bs_cd.TabIndex = 84
        Me.bs_cd.Title = "사업장"
        Me.bs_cd.TitleWidth = 108
        '
        'end_dt
        '
        Me.end_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_dt.Location = New System.Drawing.Point(8, 56)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(230, 21)
        Me.end_dt.TabIndex = 70
        Me.end_dt.Title = "유효일자"
        Me.end_dt.TitleWidth = 108
        '
        'amt_bc
        '
        Me.amt_bc.Location = New System.Drawing.Point(248, 56)
        Me.amt_bc.Name = "amt_bc"
        Me.amt_bc.Size = New System.Drawing.Size(230, 21)
        Me.amt_bc.TabIndex = 85
        Me.amt_bc.Title = "가격조건"
        Me.amt_bc.TitleWidth = 108
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(248, 80)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(230, 21)
        Me.pay_bc.TabIndex = 86
        Me.pay_bc.Title = "결재방식"
        Me.pay_bc.TitleWidth = 108
        '
        'file_no
        '
        Me.file_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file_no.Location = New System.Drawing.Point(8, 8)
        Me.file_no.Name = "file_no"
        Me.file_no.Size = New System.Drawing.Size(230, 21)
        Me.file_no.TabIndex = 66
        Me.file_no.Title = "File No"
        Me.file_no.TitleWidth = 108
        '
        'day_bc
        '
        Me.day_bc.Location = New System.Drawing.Point(248, 104)
        Me.day_bc.Name = "day_bc"
        Me.day_bc.Size = New System.Drawing.Size(230, 21)
        Me.day_bc.TabIndex = 82
        Me.day_bc.Title = "결재조건"
        Me.day_bc.TitleWidth = 108
        '
        'open_dt
        '
        Me.open_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.open_dt.Location = New System.Drawing.Point(8, 32)
        Me.open_dt.Name = "open_dt"
        Me.open_dt.Size = New System.Drawing.Size(230, 21)
        Me.open_dt.TabIndex = 69
        Me.open_dt.Title = "개설일자"
        Me.open_dt.TitleWidth = 108
        '
        'work_ty
        '
        Me.work_ty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_ty.Location = New System.Drawing.Point(720, 192)
        Me.work_ty.Name = "work_ty"
        Me.work_ty.Size = New System.Drawing.Size(52, 21)
        Me.work_ty.TabIndex = 79
        Me.work_ty.Title = "work_ty"
        Me.work_ty.TitleWidth = 108
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(712, 172)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(56, 21)
        Me.dept_cd.TabIndex = 79
        Me.dept_cd.Title = "dept_cd"
        Me.dept_cd.TitleWidth = 108
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(488, 32)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(230, 21)
        Me.dept_nm.TabIndex = 79
        Me.dept_nm.Title = "담당부서"
        Me.dept_nm.TitleWidth = 108
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(783, 301)
        Me.EPanel2.TabIndex = 3
        Me.EPanel2.Text = "     수출상세 현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(779, 276)
        Me.g20.TabIndex = 2
        '
        'SEF100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SEF100"
        Me.Size = New System.Drawing.Size(1115, 596)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_high_bc As Frame7.eCombo
    Friend WithEvents f_duty_bc As Frame7.eCombo
    Friend WithEvents bs_f_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents amt As Frame7.eText
    Friend WithEvents ex_rt As Frame7.eText
    Friend WithEvents ship_dt As Frame7.eDate
    Friend WithEvents famt As Frame7.eText
    Friend WithEvents invo_no As Frame7.eText
    Friend WithEvents home As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents fr_bc As Frame7.eCombo
    Friend WithEvents bl_no As Frame7.eText
    Friend WithEvents note_no As Frame7.eText
    Friend WithEvents loc_dt As Frame7.eDate
    Friend WithEvents to_bc As Frame7.eCombo
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents end_dt As Frame7.eDate
    Friend WithEvents amt_bc As Frame7.eCombo
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents file_no As Frame7.eText
    Friend WithEvents day_bc As Frame7.eCombo
    Friend WithEvents open_dt As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents btn_out As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents bank_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents work_ty As Frame7.eText
    Friend WithEvents po_no As Frame7.eText

End Class
