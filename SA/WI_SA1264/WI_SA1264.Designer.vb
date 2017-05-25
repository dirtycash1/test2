<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1264
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
        Me.find_chul_gu = New Frame7.eCombo()
        Me.find_stts = New Frame7.eCombo()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.fa_cd = New Frame7.eCombo()
        Me.stts = New Frame7.eCombo()
        Me.pl_cd = New Frame7.eText()
        Me.nm_nm = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.s_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.hot_cd = New Frame7.eText()
        Me.nm_cd = New Frame7.eText()
        Me.job_type = New Frame7.eCombo()
        Me.cs_nm = New Frame7.eText()
        Me.twh_cd = New Frame7.eCombo()
        Me.job_qty = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.fwh_cd = New Frame7.eCombo()
        Me.job_no = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.spec = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.od_qty = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.job_dt = New Frame7.eDate()
        Me.od_no = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_body = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.spc_1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 5
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
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_chul_gu)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 189)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_chul_gu
        '
        Me.find_chul_gu.Location = New System.Drawing.Point(27, 99)
        Me.find_chul_gu.Name = "find_chul_gu"
        Me.find_chul_gu.Size = New System.Drawing.Size(146, 21)
        Me.find_chul_gu.TabIndex = 120
        Me.find_chul_gu.Title = "공장구분"
        Me.find_chul_gu.TitleWidth = 50
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(27, 68)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(274, 0)
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
        Me.g_list.Size = New System.Drawing.Size(374, 418)
        Me.g_list.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 611)
        Me.SplitContainer2.SplitterDistance = 120
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.fa_cd)
        Me.EPanel2.Controls.Add(Me.stts)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.nm_nm)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.s_btn)
        Me.EPanel2.Controls.Add(Me.hot_cd)
        Me.EPanel2.Controls.Add(Me.nm_cd)
        Me.EPanel2.Controls.Add(Me.job_type)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.twh_cd)
        Me.EPanel2.Controls.Add(Me.job_qty)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.fwh_cd)
        Me.EPanel2.Controls.Add(Me.job_no)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.gd_nm)
        Me.EPanel2.Controls.Add(Me.spec)
        Me.EPanel2.Controls.Add(Me.gd_cd)
        Me.EPanel2.Controls.Add(Me.od_qty)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Controls.Add(Me.job_dt)
        Me.EPanel2.Controls.Add(Me.od_no)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(804, 120)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     포장지시등록(국내)"
        '
        'fa_cd
        '
        Me.fa_cd.Location = New System.Drawing.Point(13, 65)
        Me.fa_cd.Name = "fa_cd"
        Me.fa_cd.Size = New System.Drawing.Size(231, 21)
        Me.fa_cd.TabIndex = 113
        Me.fa_cd.Title = "공장구분"
        Me.fa_cd.TitleWidth = 85
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(521, 65)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(211, 21)
        Me.stts.TabIndex = 107
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 80
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(19, 248)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(240, 21)
        Me.pl_cd.TabIndex = 110
        Me.pl_cd.Title = "부서코드"
        '
        'nm_nm
        '
        Me.nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_nm.Location = New System.Drawing.Point(511, 253)
        Me.nm_nm.Name = "nm_nm"
        Me.nm_nm.Size = New System.Drawing.Size(256, 21)
        Me.nm_nm.TabIndex = 109
        Me.nm_nm.Title = "제품명"
        Me.nm_nm.TitleWidth = 80
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(521, 89)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(211, 21)
        Me.sa_cd.TabIndex = 106
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 80
        '
        's_btn
        '
        Me.s_btn.Location = New System.Drawing.Point(216, 180)
        Me.s_btn.Name = "s_btn"
        Me.s_btn.Size = New System.Drawing.Size(36, 27)
        Me.s_btn.TabIndex = 103
        Me.s_btn.Text = "검색"
        Me.s_btn.Visible = False
        '
        'hot_cd
        '
        Me.hot_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.hot_cd.Location = New System.Drawing.Point(78, 211)
        Me.hot_cd.Name = "hot_cd"
        Me.hot_cd.Size = New System.Drawing.Size(25, 21)
        Me.hot_cd.TabIndex = 76
        Me.hot_cd.Title = "제품코드"
        Me.hot_cd.TitleWidth = 0
        '
        'nm_cd
        '
        Me.nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_cd.Location = New System.Drawing.Point(270, 253)
        Me.nm_cd.Name = "nm_cd"
        Me.nm_cd.Size = New System.Drawing.Size(231, 21)
        Me.nm_cd.TabIndex = 108
        Me.nm_cd.Title = "제품코드"
        Me.nm_cd.TitleWidth = 85
        '
        'job_type
        '
        Me.job_type.Location = New System.Drawing.Point(270, 280)
        Me.job_type.Name = "job_type"
        Me.job_type.Size = New System.Drawing.Size(231, 21)
        Me.job_type.TabIndex = 102
        Me.job_type.Title = "생산구분"
        Me.job_type.TitleWidth = 85
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(421, 184)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(89, 21)
        Me.cs_nm.TabIndex = 68
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 0
        '
        'twh_cd
        '
        Me.twh_cd.Location = New System.Drawing.Point(254, 89)
        Me.twh_cd.Name = "twh_cd"
        Me.twh_cd.Size = New System.Drawing.Size(231, 21)
        Me.twh_cd.TabIndex = 105
        Me.twh_cd.Title = "입고창고"
        Me.twh_cd.TitleWidth = 80
        '
        'job_qty
        '
        Me.job_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_qty.Location = New System.Drawing.Point(511, 280)
        Me.job_qty.Name = "job_qty"
        Me.job_qty.Size = New System.Drawing.Size(256, 21)
        Me.job_qty.TabIndex = 73
        Me.job_qty.Title = "생산지시수량"
        Me.job_qty.TitleWidth = 80
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(270, 184)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(150, 21)
        Me.cs_cd.TabIndex = 67
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 80
        '
        'fwh_cd
        '
        Me.fwh_cd.Location = New System.Drawing.Point(254, 65)
        Me.fwh_cd.Name = "fwh_cd"
        Me.fwh_cd.Size = New System.Drawing.Size(231, 21)
        Me.fwh_cd.TabIndex = 104
        Me.fwh_cd.Title = "출고창고"
        Me.fwh_cd.TitleWidth = 80
        '
        'job_no
        '
        Me.job_no.ColumnName = "job_no"
        Me.job_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_no.Location = New System.Drawing.Point(13, 41)
        Me.job_no.Name = "job_no"
        Me.job_no.Size = New System.Drawing.Size(231, 21)
        Me.job_no.TabIndex = 65
        Me.job_no.TableName = "job_no"
        Me.job_no.Title = "포장지시번호"
        Me.job_no.TitleWidth = 85
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "ps_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(254, 41)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(145, 21)
        Me.ps_cd.TabIndex = 63
        Me.ps_cd.TableName = "ps_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 80
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(258, 211)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(252, 21)
        Me.gd_nm.TabIndex = 70
        Me.gd_nm.Title = "제품명"
        Me.gd_nm.TitleWidth = 80
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(516, 213)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(252, 21)
        Me.spec.TabIndex = 71
        Me.spec.Title = "규격"
        Me.spec.TitleWidth = 80
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(19, 211)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(231, 21)
        Me.gd_cd.TabIndex = 69
        Me.gd_cd.Title = "제품코드"
        Me.gd_cd.TitleWidth = 85
        '
        'od_qty
        '
        Me.od_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_qty.Location = New System.Drawing.Point(516, 186)
        Me.od_qty.Name = "od_qty"
        Me.od_qty.Size = New System.Drawing.Size(190, 21)
        Me.od_qty.TabIndex = 72
        Me.od_qty.Title = "수주수량"
        Me.od_qty.TitleWidth = 80
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "pl_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(401, 41)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(84, 21)
        Me.ps_nm.TabIndex = 64
        Me.ps_nm.TableName = "pl_nm"
        Me.ps_nm.Title = "부서"
        Me.ps_nm.TitleWidth = 0
        '
        'job_dt
        '
        Me.job_dt.ColumnName = "plan_dt"
        Me.job_dt.Location = New System.Drawing.Point(521, 41)
        Me.job_dt.Name = "job_dt"
        Me.job_dt.Size = New System.Drawing.Size(211, 21)
        Me.job_dt.TabIndex = 62
        Me.job_dt.TableName = "plan_dt"
        Me.job_dt.Title = "지시일자"
        Me.job_dt.TitleWidth = 80
        '
        'od_no
        '
        Me.od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_no.Location = New System.Drawing.Point(17, 184)
        Me.od_no.Name = "od_no"
        Me.od_no.Size = New System.Drawing.Size(195, 21)
        Me.od_no.TabIndex = 66
        Me.od_no.Title = "수주번호"
        Me.od_no.TitleWidth = 85
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_body)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(804, 487)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     포장지시 투입품목"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(2, 23)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(800, 462)
        Me.g_body.TabIndex = 2
        '
        'WI_SA1264
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1264"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents s_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents job_type As Frame7.eCombo
    Friend WithEvents hot_cd As Frame7.eText
    Friend WithEvents od_qty As Frame7.eText
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents job_qty As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents job_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents od_no As Frame7.eText
    Friend WithEvents job_dt As Frame7.eDate
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents twh_cd As Frame7.eCombo
    Friend WithEvents fwh_cd As Frame7.eCombo
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents nm_nm As Frame7.eText
    Friend WithEvents nm_cd As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents fa_cd As Frame7.eCombo
    Friend WithEvents find_chul_gu As Frame7.eCombo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
