<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WSDB100
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
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.cust_cd2 = New Frame7.eText()
        Me.cust_nm2 = New Frame7.eText()
        Me.union_yn = New Frame7.eText()
        Me.so_dept = New Frame7.eText()
        Me.setl_bc = New Frame7.eCombo()
        Me.cust_po = New Frame7.eText()
        Me.sal_bc = New Frame7.eCombo()
        Me.so_rid = New Frame7.eText()
        Me.pnlCopy = New Frame7.ePanel()
        Me.stat_bc = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.vat_rt = New Frame7.eText()
        Me.dlv_yard = New Frame7.eText()
        Me.de_bc = New Frame7.eCombo()
        Me.so_nm = New Frame7.eText()
        Me.mnm = New Frame7.eText()
        Me.mdt = New Frame7.eDate()
        Me.vat_bc = New Frame7.eCombo()
        Me.req_doc = New Frame7.eText()
        Me.so_amt = New Frame7.eText()
        Me.so_vat = New Frame7.eText()
        Me.nat_cd = New Frame7.eCombo()
        Me.tot_amt = New Frame7.eText()
        Me.btn_cust_items = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel3 = New Frame7.ePanel()
        Me.chk_show = New Frame7.eCheck()
        Me.btn_copy = New DevExpress.XtraEditors.SimpleButton()
        Me.so_no = New Frame7.eText()
        Me.so_dt = New Frame7.eDate()
        Me.so_bs = New Frame7.eCombo()
        Me.dlv_dt = New Frame7.eDate()
        Me.so_dept_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.pnlCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCopy.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 488)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd2)
        Me.EPanel1.Controls.Add(Me.cust_nm2)
        Me.EPanel1.Controls.Add(Me.union_yn)
        Me.EPanel1.Controls.Add(Me.so_dept)
        Me.EPanel1.Controls.Add(Me.setl_bc)
        Me.EPanel1.Controls.Add(Me.cust_po)
        Me.EPanel1.Controls.Add(Me.sal_bc)
        Me.EPanel1.Controls.Add(Me.so_rid)
        Me.EPanel1.Controls.Add(Me.pnlCopy)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1028, 196)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "검색"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 85
        Me.cust_cd.Title = "출하거래처"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(254, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(258, 21)
        Me.cust_nm.TabIndex = 84
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'cust_cd2
        '
        Me.cust_cd2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd2.Location = New System.Drawing.Point(12, 32)
        Me.cust_cd2.Name = "cust_cd2"
        Me.cust_cd2.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd2.TabIndex = 87
        Me.cust_cd2.Title = "매출거래처"
        '
        'cust_nm2
        '
        Me.cust_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm2.Location = New System.Drawing.Point(254, 32)
        Me.cust_nm2.Name = "cust_nm2"
        Me.cust_nm2.Size = New System.Drawing.Size(258, 21)
        Me.cust_nm2.TabIndex = 86
        Me.cust_nm2.Title = "출고번호"
        Me.cust_nm2.TitleWidth = 0
        '
        'union_yn
        '
        Me.union_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.union_yn.Location = New System.Drawing.Point(911, 8)
        Me.union_yn.Name = "union_yn"
        Me.union_yn.Size = New System.Drawing.Size(88, 21)
        Me.union_yn.TabIndex = 97
        Me.union_yn.Title = "union_yn"
        '
        'so_dept
        '
        Me.so_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_dept.Location = New System.Drawing.Point(770, 8)
        Me.so_dept.Name = "so_dept"
        Me.so_dept.Size = New System.Drawing.Size(72, 21)
        Me.so_dept.TabIndex = 73
        Me.so_dept.Title = "so_dept"
        '
        'setl_bc
        '
        Me.setl_bc.Location = New System.Drawing.Point(518, 32)
        Me.setl_bc.Name = "setl_bc"
        Me.setl_bc.Size = New System.Drawing.Size(240, 21)
        Me.setl_bc.TabIndex = 93
        Me.setl_bc.Title = "결재조건"
        '
        'cust_po
        '
        Me.cust_po.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_po.Location = New System.Drawing.Point(759, 32)
        Me.cust_po.Name = "cust_po"
        Me.cust_po.Size = New System.Drawing.Size(240, 21)
        Me.cust_po.TabIndex = 83
        Me.cust_po.Title = "PO No."
        '
        'sal_bc
        '
        Me.sal_bc.Location = New System.Drawing.Point(518, 8)
        Me.sal_bc.Name = "sal_bc"
        Me.sal_bc.Size = New System.Drawing.Size(240, 21)
        Me.sal_bc.TabIndex = 81
        Me.sal_bc.Title = "출하구분"
        '
        'so_rid
        '
        Me.so_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_rid.Location = New System.Drawing.Point(848, 8)
        Me.so_rid.Name = "so_rid"
        Me.so_rid.Size = New System.Drawing.Size(44, 21)
        Me.so_rid.TabIndex = 71
        Me.so_rid.Title = "so_rid"
        '
        'pnlCopy
        '
        Me.pnlCopy.Controls.Add(Me.stat_bc)
        Me.pnlCopy.Controls.Add(Me.cury_bc)
        Me.pnlCopy.Controls.Add(Me.vat_rt)
        Me.pnlCopy.Controls.Add(Me.dlv_yard)
        Me.pnlCopy.Controls.Add(Me.de_bc)
        Me.pnlCopy.Controls.Add(Me.so_nm)
        Me.pnlCopy.Controls.Add(Me.mnm)
        Me.pnlCopy.Controls.Add(Me.mdt)
        Me.pnlCopy.Controls.Add(Me.vat_bc)
        Me.pnlCopy.Controls.Add(Me.req_doc)
        Me.pnlCopy.Controls.Add(Me.so_amt)
        Me.pnlCopy.Controls.Add(Me.so_vat)
        Me.pnlCopy.Controls.Add(Me.nat_cd)
        Me.pnlCopy.Controls.Add(Me.tot_amt)
        Me.pnlCopy.Controls.Add(Me.btn_cust_items)
        Me.pnlCopy.Location = New System.Drawing.Point(0, 59)
        Me.pnlCopy.Name = "pnlCopy"
        Me.pnlCopy.Size = New System.Drawing.Size(1028, 127)
        Me.pnlCopy.TabIndex = 97
        Me.pnlCopy.Text = "     조건상세"
        Me.pnlCopy.Visible = False
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(92, 29)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 80
        Me.stat_bc.Title = "진행상태"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(92, 51)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 91
        Me.cury_bc.Title = "수주통화"
        '
        'vat_rt
        '
        Me.vat_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_rt.Location = New System.Drawing.Point(658, 73)
        Me.vat_rt.Name = "vat_rt"
        Me.vat_rt.Size = New System.Drawing.Size(100, 21)
        Me.vat_rt.TabIndex = 96
        Me.vat_rt.Title = "VAT"
        Me.vat_rt.TitleWidth = 68
        '
        'dlv_yard
        '
        Me.dlv_yard.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_yard.Location = New System.Drawing.Point(92, 163)
        Me.dlv_yard.Name = "dlv_yard"
        Me.dlv_yard.Size = New System.Drawing.Size(396, 21)
        Me.dlv_yard.TabIndex = 90
        Me.dlv_yard.Title = "도착지"
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(92, 96)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 21)
        Me.de_bc.TabIndex = 89
        Me.de_bc.Title = "지역구분"
        '
        'so_nm
        '
        Me.so_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_nm.Location = New System.Drawing.Point(364, 73)
        Me.so_nm.Name = "so_nm"
        Me.so_nm.Size = New System.Drawing.Size(240, 21)
        Me.so_nm.TabIndex = 70
        Me.so_nm.Title = "수주담당"
        '
        'mnm
        '
        Me.mnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mnm.Location = New System.Drawing.Point(364, 29)
        Me.mnm.Name = "mnm"
        Me.mnm.Size = New System.Drawing.Size(240, 21)
        Me.mnm.TabIndex = 79
        Me.mnm.Title = "등록자"
        '
        'mdt
        '
        Me.mdt.Location = New System.Drawing.Point(364, 51)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(240, 21)
        Me.mdt.TabIndex = 95
        Me.mdt.Title = "등록일"
        '
        'vat_bc
        '
        Me.vat_bc.Location = New System.Drawing.Point(658, 29)
        Me.vat_bc.Name = "vat_bc"
        Me.vat_bc.Size = New System.Drawing.Size(240, 21)
        Me.vat_bc.TabIndex = 92
        Me.vat_bc.Title = "부가세구분"
        '
        'req_doc
        '
        Me.req_doc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_doc.Location = New System.Drawing.Point(364, 96)
        Me.req_doc.Name = "req_doc"
        Me.req_doc.Size = New System.Drawing.Size(240, 21)
        Me.req_doc.TabIndex = 82
        Me.req_doc.Title = "요청서류"
        '
        'so_amt
        '
        Me.so_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_amt.Location = New System.Drawing.Point(658, 51)
        Me.so_amt.Name = "so_amt"
        Me.so_amt.Size = New System.Drawing.Size(240, 21)
        Me.so_amt.TabIndex = 91
        Me.so_amt.Title = "수주금액"
        '
        'so_vat
        '
        Me.so_vat.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_vat.Location = New System.Drawing.Point(758, 73)
        Me.so_vat.Name = "so_vat"
        Me.so_vat.Size = New System.Drawing.Size(140, 21)
        Me.so_vat.TabIndex = 92
        Me.so_vat.Title = " %"
        Me.so_vat.TitleWidth = 18
        '
        'nat_cd
        '
        Me.nat_cd.Location = New System.Drawing.Point(92, 73)
        Me.nat_cd.Name = "nat_cd"
        Me.nat_cd.Size = New System.Drawing.Size(240, 21)
        Me.nat_cd.TabIndex = 88
        Me.nat_cd.Title = "국가"
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(658, 96)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 91
        Me.tot_amt.Title = "합계"
        '
        'btn_cust_items
        '
        Me.btn_cust_items.Location = New System.Drawing.Point(911, 29)
        Me.btn_cust_items.Name = "btn_cust_items"
        Me.btn_cust_items.Size = New System.Drawing.Size(100, 24)
        Me.btn_cust_items.TabIndex = 94
        Me.btn_cust_items.Text = "품목가져오기"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.chk_show)
        Me.EPanel3.Controls.Add(Me.btn_copy)
        Me.EPanel3.Controls.Add(Me.so_no)
        Me.EPanel3.Controls.Add(Me.so_dt)
        Me.EPanel3.Controls.Add(Me.so_bs)
        Me.EPanel3.Controls.Add(Me.dlv_dt)
        Me.EPanel3.Controls.Add(Me.so_dept_nm)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1028, 80)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     수주정보"
        '
        'chk_show
        '
        Me.chk_show.Caption = ""
        Me.chk_show.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_show.Location = New System.Drawing.Point(532, 52)
        Me.chk_show.Name = "chk_show"
        Me.chk_show.Size = New System.Drawing.Size(164, 21)
        Me.chk_show.TabIndex = 142
        Me.chk_show.Title = "수주리스트"
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(800, 28)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(118, 21)
        Me.btn_copy.TabIndex = 97
        Me.btn_copy.Text = "조건 상세"
        '
        'so_no
        '
        Me.so_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_no.Location = New System.Drawing.Point(12, 28)
        Me.so_no.Name = "so_no"
        Me.so_no.Size = New System.Drawing.Size(240, 21)
        Me.so_no.TabIndex = 59
        Me.so_no.Title = "수주번호"
        '
        'so_dt
        '
        Me.so_dt.Location = New System.Drawing.Point(12, 52)
        Me.so_dt.Name = "so_dt"
        Me.so_dt.Size = New System.Drawing.Size(240, 21)
        Me.so_dt.TabIndex = 58
        Me.so_dt.Title = "수주일자"
        '
        'so_bs
        '
        Me.so_bs.Location = New System.Drawing.Point(272, 28)
        Me.so_bs.Name = "so_bs"
        Me.so_bs.Size = New System.Drawing.Size(240, 21)
        Me.so_bs.TabIndex = 57
        Me.so_bs.Title = "수주사업장"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(272, 52)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 96
        Me.dlv_dt.Title = "납기일자"
        '
        'so_dept_nm
        '
        Me.so_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.so_dept_nm.Location = New System.Drawing.Point(532, 28)
        Me.so_dept_nm.Name = "so_dept_nm"
        Me.so_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.so_dept_nm.TabIndex = 72
        Me.so_dept_nm.Title = "수주부서"
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1028, 211)
        Me.SplitContainer2.SplitterDistance = 342
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g10)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(342, 211)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     EPanel4"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(338, 186)
        Me.g10.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(682, 211)
        Me.XtraTabControl1.TabIndex = 100
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(675, 181)
        Me.XtraTabPage1.Text = "수주등록"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(675, 181)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.AutoScroll = True
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(675, 181)
        Me.XtraTabPage2.Text = "원장확인"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(675, 181)
        Me.g30.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g40)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(675, 181)
        Me.XtraTabPage3.Text = "TEST1"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(675, 181)
        Me.g40.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.g50)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(675, 181)
        Me.XtraTabPage4.Text = "TEST2"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RecordNavigator = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(675, 181)
        Me.g50.TabIndex = 2
        '
        'WSDB100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WSDB100"
        Me.Size = New System.Drawing.Size(1034, 522)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.pnlCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCopy.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents so_no As Frame7.eText
    Friend WithEvents so_dt As Frame7.eDate
    Friend WithEvents so_bs As Frame7.eCombo
    Friend WithEvents mnm As Frame7.eText
    Friend WithEvents so_dept As Frame7.eText
    Friend WithEvents so_dept_nm As Frame7.eText
    Friend WithEvents so_nm As Frame7.eText
    Friend WithEvents so_rid As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents sal_bc As Frame7.eCombo
    Friend WithEvents btn_cust_items As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents setl_bc As Frame7.eCombo
    Friend WithEvents vat_bc As Frame7.eCombo
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents dlv_yard As Frame7.eText
    Friend WithEvents de_bc As Frame7.eCombo
    Friend WithEvents nat_cd As Frame7.eCombo
    Friend WithEvents cust_cd2 As Frame7.eText
    Friend WithEvents cust_nm2 As Frame7.eText
    Friend WithEvents req_doc As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_po As Frame7.eText
    Friend WithEvents mdt As Frame7.eDate
    Friend WithEvents so_vat As Frame7.eText
    Friend WithEvents so_amt As Frame7.eText
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents vat_rt As Frame7.eText
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents union_yn As Frame7.eText
    Friend WithEvents pnlCopy As Frame7.ePanel
    Friend WithEvents btn_copy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents chk_show As Frame7.eCheck

End Class
