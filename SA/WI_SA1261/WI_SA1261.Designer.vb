<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1261
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.find_fa_cd = New Frame7.eCombo()
        Me.find_stts = New Frame7.eCombo()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.g_list = New Frame7.eGrid()
        Me.tp2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.find_fa_cd2 = New Frame7.eCombo()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find2 = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible2 = New System.Windows.Forms.CheckBox()
        Me.find_to2 = New Frame7.eDate()
        Me.find_from2 = New Frame7.eDate()
        Me.find_pr_jobno2 = New Frame7.eText()
        Me.g_list2 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.LOT_AUTO = New Frame7.eCheck()
        Me.fwh_cd05 = New Frame7.eCombo()
        Me.fwh_cd04 = New Frame7.eCombo()
        Me.pr_no = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.fa_cd = New Frame7.eCombo()
        Me.nm_nm = New Frame7.eText()
        Me.nm_cd = New Frame7.eText()
        Me.pr_jobno = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.ps_cd = New Frame7.eText()
        Me.pr_qty = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.ps_nm = New Frame7.eText()
        Me.pr_dt = New Frame7.eDate()
        Me.job_qty = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.twh_cd = New Frame7.eCombo()
        Me.fwh_cd = New Frame7.eCombo()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g_body1 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_body = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g_body2 = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.spc_1.TabIndex = 6
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(374, 611)
        Me.tab1.TabIndex = 51
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(367, 581)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_fa_cd)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(367, 175)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_fa_cd
        '
        Me.find_fa_cd.Location = New System.Drawing.Point(27, 88)
        Me.find_fa_cd.Name = "find_fa_cd"
        Me.find_fa_cd.Size = New System.Drawing.Size(146, 21)
        Me.find_fa_cd.TabIndex = 122
        Me.find_fa_cd.Title = "공장"
        Me.find_fa_cd.TitleWidth = 50
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(27, 64)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(146, 21)
        Me.find_stts.TabIndex = 118
        Me.find_stts.Title = "구분"
        Me.find_stts.TitleWidth = 50
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 41)
        Me.Panel1.TabIndex = 117
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
        Me.find_visible.Location = New System.Drawing.Point(267, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(94, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(176, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 14)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(196, 40)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(104, 21)
        Me.find_to.TabIndex = 111
        Me.find_to.Title = "기간"
        Me.find_to.TitleWidth = 0
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(27, 40)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(145, 21)
        Me.find_from.TabIndex = 110
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 50
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(367, 402)
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
        Me.SplitContainer4.SplitterDistance = 189
        Me.SplitContainer4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.find_fa_cd2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.find_to2)
        Me.Panel3.Controls.Add(Me.find_from2)
        Me.Panel3.Controls.Add(Me.find_pr_jobno2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 189)
        Me.Panel3.TabIndex = 2
        '
        'find_fa_cd2
        '
        Me.find_fa_cd2.Location = New System.Drawing.Point(17, 78)
        Me.find_fa_cd2.Name = "find_fa_cd2"
        Me.find_fa_cd2.Size = New System.Drawing.Size(212, 21)
        Me.find_fa_cd2.TabIndex = 121
        Me.find_fa_cd2.Title = "공장구분"
        Me.find_fa_cd2.TitleWidth = 85
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel2)
        Me.Panel4.Controls.Add(Me.btn_find2)
        Me.Panel4.Controls.Add(Me.find_visible2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 148)
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
        Me.find_to2.Location = New System.Drawing.Point(212, 30)
        Me.find_to2.Name = "find_to2"
        Me.find_to2.Size = New System.Drawing.Size(117, 21)
        Me.find_to2.TabIndex = 51
        Me.find_to2.Title = "~"
        Me.find_to2.TitleWidth = 10
        '
        'find_from2
        '
        Me.find_from2.Location = New System.Drawing.Point(17, 30)
        Me.find_from2.Name = "find_from2"
        Me.find_from2.Size = New System.Drawing.Size(191, 21)
        Me.find_from2.TabIndex = 50
        Me.find_from2.Title = "기간"
        Me.find_from2.TitleWidth = 85
        '
        'find_pr_jobno2
        '
        Me.find_pr_jobno2.ColumnName = "find_paymenterm_cd"
        Me.find_pr_jobno2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_pr_jobno2.Location = New System.Drawing.Point(17, 54)
        Me.find_pr_jobno2.Name = "find_pr_jobno2"
        Me.find_pr_jobno2.Size = New System.Drawing.Size(312, 21)
        Me.find_pr_jobno2.TabIndex = 48
        Me.find_pr_jobno2.TableName = "find_paymenterm_cd"
        Me.find_pr_jobno2.Title = "포장지시번호"
        Me.find_pr_jobno2.TitleWidth = 85
        '
        'g_list2
        '
        Me.g_list2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list2.Location = New System.Drawing.Point(0, 0)
        Me.g_list2.Name = "g_list2"
        Me.g_list2.ReadOnly = False
        Me.g_list2.RowHeight = -1
        Me.g_list2.Size = New System.Drawing.Size(367, 388)
        Me.g_list2.TabIndex = 115
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 611)
        Me.SplitContainer2.SplitterDistance = 167
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer5.Size = New System.Drawing.Size(804, 167)
        Me.SplitContainer5.SplitterDistance = 760
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.LOT_AUTO)
        Me.EPanel2.Controls.Add(Me.fwh_cd05)
        Me.EPanel2.Controls.Add(Me.fwh_cd04)
        Me.EPanel2.Controls.Add(Me.pr_no)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.fa_cd)
        Me.EPanel2.Controls.Add(Me.nm_nm)
        Me.EPanel2.Controls.Add(Me.nm_cd)
        Me.EPanel2.Controls.Add(Me.pr_jobno)
        Me.EPanel2.Controls.Add(Me.stts)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.pr_qty)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Controls.Add(Me.pr_dt)
        Me.EPanel2.Controls.Add(Me.job_qty)
        Me.EPanel2.Controls.Add(Me.gd_cd)
        Me.EPanel2.Controls.Add(Me.twh_cd)
        Me.EPanel2.Controls.Add(Me.fwh_cd)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(760, 167)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     포장지시등록"
        '
        'LOT_AUTO
        '
        Me.LOT_AUTO.Caption = ""
        Me.LOT_AUTO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LOT_AUTO.Location = New System.Drawing.Point(17, 137)
        Me.LOT_AUTO.Name = "LOT_AUTO"
        Me.LOT_AUTO.Size = New System.Drawing.Size(231, 21)
        Me.LOT_AUTO.TabIndex = 119
        Me.LOT_AUTO.Title = "LOT 자동체크"
        Me.LOT_AUTO.TitleWidth = 85
        '
        'fwh_cd05
        '
        Me.fwh_cd05.Location = New System.Drawing.Point(549, 137)
        Me.fwh_cd05.Name = "fwh_cd05"
        Me.fwh_cd05.Size = New System.Drawing.Size(199, 21)
        Me.fwh_cd05.TabIndex = 118
        Me.fwh_cd05.Title = "포장재창고"
        Me.fwh_cd05.TitleWidth = 80
        '
        'fwh_cd04
        '
        Me.fwh_cd04.Location = New System.Drawing.Point(549, 113)
        Me.fwh_cd04.Name = "fwh_cd04"
        Me.fwh_cd04.Size = New System.Drawing.Size(199, 21)
        Me.fwh_cd04.TabIndex = 117
        Me.fwh_cd04.Title = "부자재창고"
        Me.fwh_cd04.TitleWidth = 80
        '
        'pr_no
        '
        Me.pr_no.ColumnName = "job_no"
        Me.pr_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pr_no.Location = New System.Drawing.Point(17, 41)
        Me.pr_no.Name = "pr_no"
        Me.pr_no.Size = New System.Drawing.Size(231, 21)
        Me.pr_no.TabIndex = 65
        Me.pr_no.TableName = "job_no"
        Me.pr_no.Title = "포장실적번호"
        Me.pr_no.TitleWidth = 85
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(507, 159)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(231, 21)
        Me.pl_cd.TabIndex = 114
        Me.pl_cd.Title = "부서코드"
        Me.pl_cd.TitleWidth = 85
        '
        'fa_cd
        '
        Me.fa_cd.Location = New System.Drawing.Point(267, 113)
        Me.fa_cd.Name = "fa_cd"
        Me.fa_cd.Size = New System.Drawing.Size(228, 21)
        Me.fa_cd.TabIndex = 116
        Me.fa_cd.Title = "공장구분"
        Me.fa_cd.TitleWidth = 80
        '
        'nm_nm
        '
        Me.nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_nm.Location = New System.Drawing.Point(17, 113)
        Me.nm_nm.Name = "nm_nm"
        Me.nm_nm.Size = New System.Drawing.Size(231, 21)
        Me.nm_nm.TabIndex = 113
        Me.nm_nm.Title = "제품명"
        Me.nm_nm.TitleWidth = 85
        '
        'nm_cd
        '
        Me.nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_cd.Location = New System.Drawing.Point(17, 89)
        Me.nm_cd.Name = "nm_cd"
        Me.nm_cd.Size = New System.Drawing.Size(231, 21)
        Me.nm_cd.TabIndex = 112
        Me.nm_cd.Title = "제품코드"
        Me.nm_cd.TitleWidth = 85
        '
        'pr_jobno
        '
        Me.pr_jobno.ColumnName = "job_no"
        Me.pr_jobno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pr_jobno.Location = New System.Drawing.Point(17, 65)
        Me.pr_jobno.Name = "pr_jobno"
        Me.pr_jobno.Size = New System.Drawing.Size(231, 21)
        Me.pr_jobno.TabIndex = 107
        Me.pr_jobno.TableName = "job_no"
        Me.pr_jobno.Title = "포장지시번호"
        Me.pr_jobno.TitleWidth = 85
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(267, 65)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(228, 21)
        Me.stts.TabIndex = 111
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 80
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "ps_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(267, 41)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(144, 21)
        Me.ps_cd.TabIndex = 63
        Me.ps_cd.TableName = "ps_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 80
        '
        'pr_qty
        '
        Me.pr_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pr_qty.Location = New System.Drawing.Point(17, 159)
        Me.pr_qty.Name = "pr_qty"
        Me.pr_qty.Size = New System.Drawing.Size(190, 21)
        Me.pr_qty.TabIndex = 108
        Me.pr_qty.Title = "포장수량"
        Me.pr_qty.TitleWidth = 80
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(267, 89)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(228, 21)
        Me.sa_cd.TabIndex = 109
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 80
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "pl_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(412, 41)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(83, 21)
        Me.ps_nm.TabIndex = 64
        Me.ps_nm.TableName = "pl_nm"
        Me.ps_nm.Title = "부서"
        Me.ps_nm.TitleWidth = 0
        '
        'pr_dt
        '
        Me.pr_dt.ColumnName = "plan_dt"
        Me.pr_dt.Location = New System.Drawing.Point(549, 41)
        Me.pr_dt.Name = "pr_dt"
        Me.pr_dt.Size = New System.Drawing.Size(199, 21)
        Me.pr_dt.TabIndex = 62
        Me.pr_dt.TableName = "plan_dt"
        Me.pr_dt.Title = "포장일자"
        Me.pr_dt.TitleWidth = 80
        '
        'job_qty
        '
        Me.job_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_qty.Location = New System.Drawing.Point(17, 140)
        Me.job_qty.Name = "job_qty"
        Me.job_qty.Size = New System.Drawing.Size(190, 21)
        Me.job_qty.TabIndex = 73
        Me.job_qty.Title = "지시수량"
        Me.job_qty.TitleWidth = 80
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(241, 159)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(231, 21)
        Me.gd_cd.TabIndex = 69
        Me.gd_cd.Title = "제품코드"
        Me.gd_cd.TitleWidth = 85
        '
        'twh_cd
        '
        Me.twh_cd.Location = New System.Drawing.Point(549, 89)
        Me.twh_cd.Name = "twh_cd"
        Me.twh_cd.Size = New System.Drawing.Size(199, 21)
        Me.twh_cd.TabIndex = 105
        Me.twh_cd.Title = "입고창고"
        Me.twh_cd.TitleWidth = 80
        '
        'fwh_cd
        '
        Me.fwh_cd.Location = New System.Drawing.Point(549, 65)
        Me.fwh_cd.Name = "fwh_cd"
        Me.fwh_cd.Size = New System.Drawing.Size(199, 21)
        Me.fwh_cd.TabIndex = 104
        Me.fwh_cd.Title = "출고창고"
        Me.fwh_cd.TitleWidth = 80
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g_body1)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(40, 167)
        Me.EPanel5.TabIndex = 1
        Me.EPanel5.Text = "     부자재 및 포장재"
        '
        'g_body1
        '
        Me.g_body1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body1.Location = New System.Drawing.Point(2, 23)
        Me.g_body1.Name = "g_body1"
        Me.g_body1.ReadOnly = False
        Me.g_body1.RowHeight = -1
        Me.g_body1.Size = New System.Drawing.Size(36, 142)
        Me.g_body1.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(804, 440)
        Me.SplitContainer3.SplitterDistance = 533
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_body)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(533, 440)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     EPanel3"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(2, 23)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(529, 415)
        Me.g_body.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g_body2)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(267, 440)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     EPanel4"
        '
        'g_body2
        '
        Me.g_body2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body2.Location = New System.Drawing.Point(2, 23)
        Me.g_body2.Name = "g_body2"
        Me.g_body2.ReadOnly = False
        Me.g_body2.RowHeight = -1
        Me.g_body2.Size = New System.Drawing.Size(263, 415)
        Me.g_body2.TabIndex = 2
        '
        'WI_SA1261
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1261"
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
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
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
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents twh_cd As Frame7.eCombo
    Friend WithEvents fwh_cd As Frame7.eCombo
    Friend WithEvents job_qty As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents pr_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents pr_dt As Frame7.eDate
    Friend WithEvents pr_jobno As Frame7.eText
    Friend WithEvents pr_qty As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents nm_nm As Frame7.eText
    Friend WithEvents nm_cd As Frame7.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tp2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible2 As System.Windows.Forms.CheckBox
    Friend WithEvents find_to2 As Frame7.eDate
    Friend WithEvents find_from2 As Frame7.eDate
    Friend WithEvents find_pr_jobno2 As Frame7.eText
    Friend WithEvents g_list2 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g_body2 As Frame7.eGrid
    Friend WithEvents fa_cd As Frame7.eCombo
    Friend WithEvents find_fa_cd2 As Frame7.eCombo
    Friend WithEvents find_fa_cd As Frame7.eCombo
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g_body1 As Frame7.eGrid
    Friend WithEvents fwh_cd05 As Frame7.eCombo
    Friend WithEvents fwh_cd04 As Frame7.eCombo
    Friend WithEvents LOT_AUTO As Frame7.eCheck

End Class
