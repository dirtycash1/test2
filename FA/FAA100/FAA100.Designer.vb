<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAA100
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAA100))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.sys_cd = New Frame7.eCombo()
        Me.btn_open = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.acc_cd4 = New Frame7.eText()
        Me.acc_nm4 = New Frame7.eText()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList()
        Me.exp_yn = New Frame7.eCheck()
        Me.mng_yn = New Frame7.eCheck()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.rec_bc = New Frame7.eCombo()
        Me.acc_cd = New Frame7.eText()
        Me.acc_bc = New Frame7.eCombo()
        Me.acc_nm = New Frame7.eText()
        Me.acc_cd2 = New Frame7.eText()
        Me.beg_dt = New Frame7.eDate()
        Me.end_dt = New Frame7.eDate()
        Me.up_cd = New Frame7.eText()
        Me.range_bc = New Frame7.eCombo()
        Me.fund_bc = New Frame7.eCombo()
        Me.budg_yn = New Frame7.eCheck()
        Me.fund_cd = New Frame7.eCombo()
        Me.rmk_yn = New Frame7.eCheck()
        Me.sum_cd = New Frame7.eCombo()
        Me.EText5 = New Frame7.eText()
        Me.btn_copy1 = New DevExpress.XtraEditors.SimpleButton()
        Me.doc_yn = New Frame7.eCheck()
        Me.btn_copy2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_copy = New DevExpress.XtraEditors.SimpleButton()
        Me.pay_yn = New Frame7.eCheck()
        Me.carry_yn = New Frame7.eCheck()
        Me.pay_bc = New Frame7.eCombo()
        Me.fund_cal_yn = New Frame7.eCheck()
        Me.pre_yn = New Frame7.eCheck()
        Me.frgn_yn = New Frame7.eCheck()
        Me.ctrl_yn = New Frame7.eCheck()
        Me.del_yn = New Frame7.eCheck()
        Me.item_yn = New Frame7.eCheck()
        Me.fund_yn = New Frame7.eCheck()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.EPanel21 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel22 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.EPanel21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel21.SuspendLayout()
        CType(Me.EPanel22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel22.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 655)
        Me.SplitContainer1.SplitterDistance = 297
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_open)
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(297, 655)
        Me.SplitContainer2.SplitterDistance = 62
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.sys_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(297, 62)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'sys_cd
        '
        Me.sys_cd.Location = New System.Drawing.Point(8, 32)
        Me.sys_cd.Name = "sys_cd"
        Me.sys_cd.Size = New System.Drawing.Size(280, 21)
        Me.sys_cd.TabIndex = 3
        Me.sys_cd.Title = "계정체계코드"
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(174, 0)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(76, 20)
        Me.btn_open.TabIndex = 19
        Me.btn_open.Text = "조  회"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage4
        Me.XtraTabControl2.Size = New System.Drawing.Size(297, 589)
        Me.XtraTabControl2.TabIndex = 25
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.g40)
        Me.XtraTabPage4.Controls.Add(Me.acc_cd4)
        Me.XtraTabPage4.Controls.Add(Me.acc_nm4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(290, 559)
        Me.XtraTabPage4.Text = "검색"
        '
        'g40
        '
        Me.g40.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g40.Location = New System.Drawing.Point(0, 60)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(290, 499)
        Me.g40.TabIndex = 4
        '
        'acc_cd4
        '
        Me.acc_cd4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd4.Location = New System.Drawing.Point(8, 8)
        Me.acc_cd4.Name = "acc_cd4"
        Me.acc_cd4.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd4.TabIndex = 0
        Me.acc_cd4.Title = "계정코드(*)"
        '
        'acc_nm4
        '
        Me.acc_nm4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_nm4.Location = New System.Drawing.Point(8, 32)
        Me.acc_nm4.Name = "acc_nm4"
        Me.acc_nm4.Size = New System.Drawing.Size(240, 21)
        Me.acc_nm4.TabIndex = 1
        Me.acc_nm4.Title = "계정명(*)"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.TreeView1)
        Me.XtraTabPage3.Controls.Add(Me.exp_yn)
        Me.XtraTabPage3.Controls.Add(Me.mng_yn)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(290, 559)
        Me.XtraTabPage3.Text = "Tree"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 60)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(290, 499)
        Me.TreeView1.TabIndex = 24
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder.png")
        Me.ImageList1.Images.SetKeyName(1, "calculator_edit.png")
        Me.ImageList1.Images.SetKeyName(2, "bullet_red.png")
        Me.ImageList1.Images.SetKeyName(3, "check_128_hot.gif")
        '
        'exp_yn
        '
        Me.exp_yn.Caption = ""
        Me.exp_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.exp_yn.Location = New System.Drawing.Point(12, 8)
        Me.exp_yn.Name = "exp_yn"
        Me.exp_yn.Size = New System.Drawing.Size(148, 21)
        Me.exp_yn.TabIndex = 4
        Me.exp_yn.Title = "Tree 확장"
        '
        'mng_yn
        '
        Me.mng_yn.Caption = ""
        Me.mng_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mng_yn.Location = New System.Drawing.Point(12, 32)
        Me.mng_yn.Name = "mng_yn"
        Me.mng_yn.Size = New System.Drawing.Size(148, 21)
        Me.mng_yn.TabIndex = 4
        Me.mng_yn.Title = "관리항목 보기"
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(723, 655)
        Me.SplitContainer3.SplitterDistance = 55
        Me.SplitContainer3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(723, 655)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(716, 625)
        Me.XtraTabPage1.Text = "계정등록"
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer4.Size = New System.Drawing.Size(716, 625)
        Me.SplitContainer4.SplitterDistance = 276
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.acc_cd)
        Me.EPanel3.Controls.Add(Me.acc_bc)
        Me.EPanel3.Controls.Add(Me.rec_bc)
        Me.EPanel3.Controls.Add(Me.acc_nm)
        Me.EPanel3.Controls.Add(Me.acc_cd2)
        Me.EPanel3.Controls.Add(Me.beg_dt)
        Me.EPanel3.Controls.Add(Me.end_dt)
        Me.EPanel3.Controls.Add(Me.up_cd)
        Me.EPanel3.Controls.Add(Me.range_bc)
        Me.EPanel3.Controls.Add(Me.fund_bc)
        Me.EPanel3.Controls.Add(Me.budg_yn)
        Me.EPanel3.Controls.Add(Me.fund_cd)
        Me.EPanel3.Controls.Add(Me.rmk_yn)
        Me.EPanel3.Controls.Add(Me.EText5)
        Me.EPanel3.Controls.Add(Me.btn_copy1)
        Me.EPanel3.Controls.Add(Me.doc_yn)
        Me.EPanel3.Controls.Add(Me.btn_copy2)
        Me.EPanel3.Controls.Add(Me.sum_cd)
        Me.EPanel3.Controls.Add(Me.btn_copy)
        Me.EPanel3.Controls.Add(Me.pay_yn)
        Me.EPanel3.Controls.Add(Me.carry_yn)
        Me.EPanel3.Controls.Add(Me.pay_bc)
        Me.EPanel3.Controls.Add(Me.fund_cal_yn)
        Me.EPanel3.Controls.Add(Me.pre_yn)
        Me.EPanel3.Controls.Add(Me.frgn_yn)
        Me.EPanel3.Controls.Add(Me.ctrl_yn)
        Me.EPanel3.Controls.Add(Me.del_yn)
        Me.EPanel3.Controls.Add(Me.item_yn)
        Me.EPanel3.Controls.Add(Me.fund_yn)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(716, 276)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     계정등록"
        '
        'rec_bc
        '
        Me.rec_bc.Location = New System.Drawing.Point(12, 124)
        Me.rec_bc.Name = "rec_bc"
        Me.rec_bc.Size = New System.Drawing.Size(240, 21)
        Me.rec_bc.TabIndex = 21
        Me.rec_bc.Title = "채권채무구분"
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd.Location = New System.Drawing.Point(12, 28)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd.TabIndex = 2
        Me.acc_cd.Title = "계정코드"
        '
        'acc_bc
        '
        Me.acc_bc.Location = New System.Drawing.Point(272, 28)
        Me.acc_bc.Name = "acc_bc"
        Me.acc_bc.Size = New System.Drawing.Size(240, 21)
        Me.acc_bc.TabIndex = 6
        Me.acc_bc.Title = "차/대 구분"
        '
        'acc_nm
        '
        Me.acc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_nm.Location = New System.Drawing.Point(12, 52)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(500, 21)
        Me.acc_nm.TabIndex = 5
        Me.acc_nm.Title = "계정명"
        '
        'acc_cd2
        '
        Me.acc_cd2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd2.Location = New System.Drawing.Point(12, 100)
        Me.acc_cd2.Name = "acc_cd2"
        Me.acc_cd2.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd2.TabIndex = 3
        Me.acc_cd2.Title = "단축코드"
        '
        'beg_dt
        '
        Me.beg_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.beg_dt.Location = New System.Drawing.Point(272, 76)
        Me.beg_dt.Name = "beg_dt"
        Me.beg_dt.Size = New System.Drawing.Size(240, 21)
        Me.beg_dt.TabIndex = 20
        Me.beg_dt.Title = "생성일"
        '
        'end_dt
        '
        Me.end_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_dt.Location = New System.Drawing.Point(272, 100)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(240, 21)
        Me.end_dt.TabIndex = 20
        Me.end_dt.Title = "종료일"
        '
        'up_cd
        '
        Me.up_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.up_cd.Location = New System.Drawing.Point(12, 76)
        Me.up_cd.Name = "up_cd"
        Me.up_cd.Size = New System.Drawing.Size(240, 21)
        Me.up_cd.TabIndex = 4
        Me.up_cd.Title = "상위코드"
        '
        'range_bc
        '
        Me.range_bc.Location = New System.Drawing.Point(560, 152)
        Me.range_bc.Name = "range_bc"
        Me.range_bc.Size = New System.Drawing.Size(240, 21)
        Me.range_bc.TabIndex = 6
        Me.range_bc.Title = "예산통제주기"
        '
        'fund_bc
        '
        Me.fund_bc.Location = New System.Drawing.Point(560, 176)
        Me.fund_bc.Name = "fund_bc"
        Me.fund_bc.Size = New System.Drawing.Size(240, 21)
        Me.fund_bc.TabIndex = 6
        Me.fund_bc.Title = "자금항목구분"
        '
        'budg_yn
        '
        Me.budg_yn.Caption = ""
        Me.budg_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.budg_yn.Location = New System.Drawing.Point(12, 152)
        Me.budg_yn.Name = "budg_yn"
        Me.budg_yn.Size = New System.Drawing.Size(152, 21)
        Me.budg_yn.TabIndex = 9
        Me.budg_yn.Title = "예산관리"
        '
        'fund_cd
        '
        Me.fund_cd.Location = New System.Drawing.Point(560, 200)
        Me.fund_cd.Name = "fund_cd"
        Me.fund_cd.Size = New System.Drawing.Size(240, 21)
        Me.fund_cd.TabIndex = 6
        Me.fund_cd.Title = "fund_cd"
        '
        'rmk_yn
        '
        Me.rmk_yn.Caption = ""
        Me.rmk_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmk_yn.Location = New System.Drawing.Point(560, 248)
        Me.rmk_yn.Name = "rmk_yn"
        Me.rmk_yn.Size = New System.Drawing.Size(152, 21)
        Me.rmk_yn.TabIndex = 14
        Me.rmk_yn.Title = "표준적요입력"
        '
        'sum_cd
        '
        Me.sum_cd.Location = New System.Drawing.Point(560, 128)
        Me.sum_cd.Name = "sum_cd"
        Me.sum_cd.Size = New System.Drawing.Size(240, 21)
        Me.sum_cd.TabIndex = 6
        Me.sum_cd.Title = "예산집계계정"
        '
        'EText5
        '
        Me.EText5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText5.Location = New System.Drawing.Point(12, 248)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(120, 21)
        Me.EText5.TabIndex = 17
        Me.EText5.Title = "관리항목복사"
        '
        'btn_copy1
        '
        Me.btn_copy1.Location = New System.Drawing.Point(133, 248)
        Me.btn_copy1.Name = "btn_copy1"
        Me.btn_copy1.Size = New System.Drawing.Size(56, 20)
        Me.btn_copy1.TabIndex = 18
        Me.btn_copy1.Text = "->"
        '
        'doc_yn
        '
        Me.doc_yn.Caption = ""
        Me.doc_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_yn.Location = New System.Drawing.Point(192, 152)
        Me.doc_yn.Name = "doc_yn"
        Me.doc_yn.Size = New System.Drawing.Size(152, 21)
        Me.doc_yn.TabIndex = 7
        Me.doc_yn.Title = "전표사용"
        '
        'btn_copy2
        '
        Me.btn_copy2.Location = New System.Drawing.Point(196, 248)
        Me.btn_copy2.Name = "btn_copy2"
        Me.btn_copy2.Size = New System.Drawing.Size(56, 20)
        Me.btn_copy2.TabIndex = 18
        Me.btn_copy2.Text = "<-"
        '
        'btn_copy
        '
        Me.btn_copy.Location = New System.Drawing.Point(392, 244)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(120, 24)
        Me.btn_copy.TabIndex = 6
        Me.btn_copy.Text = "새계정으로 복사"
        '
        'pay_yn
        '
        Me.pay_yn.Caption = ""
        Me.pay_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pay_yn.Location = New System.Drawing.Point(192, 200)
        Me.pay_yn.Name = "pay_yn"
        Me.pay_yn.Size = New System.Drawing.Size(152, 21)
        Me.pay_yn.TabIndex = 14
        Me.pay_yn.Title = "건별반제"
        '
        'carry_yn
        '
        Me.carry_yn.Caption = ""
        Me.carry_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.carry_yn.Location = New System.Drawing.Point(192, 176)
        Me.carry_yn.Name = "carry_yn"
        Me.carry_yn.Size = New System.Drawing.Size(152, 21)
        Me.carry_yn.TabIndex = 15
        Me.carry_yn.Title = "잔액관리"
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(272, 124)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(240, 21)
        Me.pay_bc.TabIndex = 6
        Me.pay_bc.Title = "pay_bc"
        '
        'fund_cal_yn
        '
        Me.fund_cal_yn.Caption = ""
        Me.fund_cal_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fund_cal_yn.Location = New System.Drawing.Point(560, 224)
        Me.fund_cal_yn.Name = "fund_cal_yn"
        Me.fund_cal_yn.Size = New System.Drawing.Size(152, 21)
        Me.fund_cal_yn.TabIndex = 14
        Me.fund_cal_yn.Title = "자금카렌다연계"
        '
        'pre_yn
        '
        Me.pre_yn.Caption = ""
        Me.pre_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pre_yn.Location = New System.Drawing.Point(12, 224)
        Me.pre_yn.Name = "pre_yn"
        Me.pre_yn.Size = New System.Drawing.Size(152, 21)
        Me.pre_yn.TabIndex = 19
        Me.pre_yn.Title = "선급비용"
        '
        'frgn_yn
        '
        Me.frgn_yn.Caption = ""
        Me.frgn_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.frgn_yn.Location = New System.Drawing.Point(12, 200)
        Me.frgn_yn.Name = "frgn_yn"
        Me.frgn_yn.Size = New System.Drawing.Size(152, 21)
        Me.frgn_yn.TabIndex = 16
        Me.frgn_yn.Title = "외화관리"
        '
        'ctrl_yn
        '
        Me.ctrl_yn.Caption = ""
        Me.ctrl_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ctrl_yn.Location = New System.Drawing.Point(12, 176)
        Me.ctrl_yn.Name = "ctrl_yn"
        Me.ctrl_yn.Size = New System.Drawing.Size(152, 21)
        Me.ctrl_yn.TabIndex = 10
        Me.ctrl_yn.Title = "예산통제"
        '
        'del_yn
        '
        Me.del_yn.Caption = ""
        Me.del_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.del_yn.Location = New System.Drawing.Point(376, 200)
        Me.del_yn.Name = "del_yn"
        Me.del_yn.Size = New System.Drawing.Size(152, 21)
        Me.del_yn.TabIndex = 13
        Me.del_yn.Title = "삭제여부"
        '
        'item_yn
        '
        Me.item_yn.Caption = ""
        Me.item_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.item_yn.Location = New System.Drawing.Point(376, 176)
        Me.item_yn.Name = "item_yn"
        Me.item_yn.Size = New System.Drawing.Size(152, 21)
        Me.item_yn.TabIndex = 8
        Me.item_yn.Title = "세목여부"
        '
        'fund_yn
        '
        Me.fund_yn.Caption = ""
        Me.fund_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fund_yn.Location = New System.Drawing.Point(376, 152)
        Me.fund_yn.Name = "fund_yn"
        Me.fund_yn.Size = New System.Drawing.Size(152, 21)
        Me.fund_yn.TabIndex = 14
        Me.fund_yn.Title = "자금과목"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.EPanel21)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.EPanel22)
        Me.SplitContainer6.Size = New System.Drawing.Size(716, 345)
        Me.SplitContainer6.SplitterDistance = 351
        Me.SplitContainer6.TabIndex = 0
        '
        'EPanel21
        '
        Me.EPanel21.Controls.Add(Me.g10)
        Me.EPanel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel21.Location = New System.Drawing.Point(0, 0)
        Me.EPanel21.Name = "EPanel21"
        Me.EPanel21.Size = New System.Drawing.Size(351, 345)
        Me.EPanel21.TabIndex = 2
        Me.EPanel21.Text = "     차변관리항목"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(347, 320)
        Me.g10.TabIndex = 0
        '
        'EPanel22
        '
        Me.EPanel22.Controls.Add(Me.g20)
        Me.EPanel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel22.Location = New System.Drawing.Point(0, 0)
        Me.EPanel22.Name = "EPanel22"
        Me.EPanel22.Size = New System.Drawing.Size(361, 345)
        Me.EPanel22.TabIndex = 1
        Me.EPanel22.Text = "     대변관리항목"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(357, 320)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(716, 625)
        Me.XtraTabPage2.Text = "계정조회 및 등록"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(716, 625)
        Me.g30.TabIndex = 4
        '
        'FAA100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAA100"
        Me.Size = New System.Drawing.Size(1169, 687)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.EPanel21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel21.ResumeLayout(False)
        CType(Me.EPanel22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel22.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents sys_cd As Frame7.eCombo
    Friend WithEvents exp_yn As Frame7.eCheck
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents mng_yn As Frame7.eCheck
    Friend WithEvents btn_copy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents acc_bc As Frame7.eCombo
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents up_cd As Frame7.eText
    Friend WithEvents acc_cd2 As Frame7.eText
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents del_yn As Frame7.eCheck
    Friend WithEvents ctrl_yn As Frame7.eCheck
    Friend WithEvents budg_yn As Frame7.eCheck
    Friend WithEvents item_yn As Frame7.eCheck
    Friend WithEvents doc_yn As Frame7.eCheck
    Friend WithEvents btn_copy1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents frgn_yn As Frame7.eCheck
    Friend WithEvents carry_yn As Frame7.eCheck
    Friend WithEvents pay_yn As Frame7.eCheck
    Friend WithEvents btn_copy2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pre_yn As Frame7.eCheck
    Friend WithEvents EPanel21 As Frame7.ePanel
    Friend WithEvents EPanel22 As Frame7.ePanel
    Friend WithEvents beg_dt As Frame7.eDate
    Friend WithEvents end_dt As Frame7.eDate
    Friend WithEvents rmk_yn As Frame7.eCheck
    Friend WithEvents range_bc As Frame7.eCombo
    Friend WithEvents fund_yn As Frame7.eCheck
    Friend WithEvents fund_cal_yn As Frame7.eCheck
    Friend WithEvents fund_bc As Frame7.eCombo
    Friend WithEvents sum_cd As Frame7.eCombo
    Friend WithEvents fund_cd As Frame7.eCombo
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents acc_cd4 As Frame7.eText
    Friend WithEvents acc_nm4 As Frame7.eText
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents rec_bc As Frame7.eCombo

End Class
