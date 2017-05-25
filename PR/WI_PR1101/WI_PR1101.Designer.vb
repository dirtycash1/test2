<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1101
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
        Me.ep_head = New Frame7.ePanel()
        Me.CHUL_GU = New Frame7.eCombo()
        Me.ja_nm = New Frame7.eText()
        Me.ja_cd = New Frame7.eText()
        Me.stock_qty = New Frame7.eText()
        Me.wh_cd = New Frame7.eCombo()
        Me.unit_cd = New Frame7.eCombo()
        Me.stts = New Frame7.eCombo()
        Me.daytime_gu = New Frame7.eCombo()
        Me.plan_qty = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.lot_no = New Frame7.eText()
        Me.spec = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.plan_no = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.plan_dt = New Frame7.eDate()
        Me.mc_cd = New Frame7.eCombo()
        Me.g_body = New Frame7.eGrid()
        Me.mate_job_qty = New Frame7.eText()
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
        Me.spc_1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 6
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
        Me.find_chul_gu.Location = New System.Drawing.Point(27, 98)
        Me.find_chul_gu.Name = "find_chul_gu"
        Me.find_chul_gu.Size = New System.Drawing.Size(212, 21)
        Me.find_chul_gu.TabIndex = 119
        Me.find_chul_gu.Title = "출고구분"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.ep_head)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 611)
        Me.SplitContainer2.SplitterDistance = 178
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.mate_job_qty)
        Me.ep_head.Controls.Add(Me.CHUL_GU)
        Me.ep_head.Controls.Add(Me.ja_nm)
        Me.ep_head.Controls.Add(Me.ja_cd)
        Me.ep_head.Controls.Add(Me.stock_qty)
        Me.ep_head.Controls.Add(Me.wh_cd)
        Me.ep_head.Controls.Add(Me.unit_cd)
        Me.ep_head.Controls.Add(Me.stts)
        Me.ep_head.Controls.Add(Me.daytime_gu)
        Me.ep_head.Controls.Add(Me.gd_cd)
        Me.ep_head.Controls.Add(Me.spec)
        Me.ep_head.Controls.Add(Me.plan_qty)
        Me.ep_head.Controls.Add(Me.gd_nm)
        Me.ep_head.Controls.Add(Me.lot_no)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.plan_no)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.plan_dt)
        Me.ep_head.Controls.Add(Me.mc_cd)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(804, 178)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     출고등록"
        '
        'CHUL_GU
        '
        Me.CHUL_GU.Location = New System.Drawing.Point(686, 140)
        Me.CHUL_GU.Name = "CHUL_GU"
        Me.CHUL_GU.Size = New System.Drawing.Size(242, 21)
        Me.CHUL_GU.TabIndex = 114
        Me.CHUL_GU.Title = "약품투입기준"
        Me.CHUL_GU.TitleWidth = 98
        '
        'ja_nm
        '
        Me.ja_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ja_nm.Location = New System.Drawing.Point(511, 90)
        Me.ja_nm.Name = "ja_nm"
        Me.ja_nm.Size = New System.Drawing.Size(119, 21)
        Me.ja_nm.TabIndex = 113
        Me.ja_nm.Title = "약품번호"
        Me.ja_nm.TitleWidth = 0
        '
        'ja_cd
        '
        Me.ja_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ja_cd.Location = New System.Drawing.Point(348, 90)
        Me.ja_cd.Name = "ja_cd"
        Me.ja_cd.Size = New System.Drawing.Size(160, 21)
        Me.ja_cd.TabIndex = 112
        Me.ja_cd.Title = "약품코드"
        Me.ja_cd.TitleWidth = 98
        '
        'stock_qty
        '
        Me.stock_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.stock_qty.Location = New System.Drawing.Point(519, 146)
        Me.stock_qty.Name = "stock_qty"
        Me.stock_qty.Size = New System.Drawing.Size(111, 21)
        Me.stock_qty.TabIndex = 111
        Me.stock_qty.Title = "현재고"
        Me.stock_qty.TitleWidth = 50
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(539, 181)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(199, 21)
        Me.wh_cd.TabIndex = 110
        Me.wh_cd.Title = "출고창고"
        Me.wh_cd.TitleWidth = 70
        '
        'unit_cd
        '
        Me.unit_cd.Location = New System.Drawing.Point(23, 140)
        Me.unit_cd.Name = "unit_cd"
        Me.unit_cd.Size = New System.Drawing.Size(244, 21)
        Me.unit_cd.TabIndex = 109
        Me.unit_cd.Title = "단위"
        Me.unit_cd.TitleWidth = 98
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(686, 65)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(242, 21)
        Me.stts.TabIndex = 108
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 98
        '
        'daytime_gu
        '
        Me.daytime_gu.Location = New System.Drawing.Point(686, 115)
        Me.daytime_gu.Name = "daytime_gu"
        Me.daytime_gu.Size = New System.Drawing.Size(242, 21)
        Me.daytime_gu.TabIndex = 77
        Me.daytime_gu.Title = "주/야간구분"
        Me.daytime_gu.TitleWidth = 98
        '
        'plan_qty
        '
        Me.plan_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.plan_qty.Location = New System.Drawing.Point(348, 115)
        Me.plan_qty.Name = "plan_qty"
        Me.plan_qty.Size = New System.Drawing.Size(160, 21)
        Me.plan_qty.TabIndex = 76
        Me.plan_qty.Title = "작업수량"
        Me.plan_qty.TitleWidth = 98
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(23, 65)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(244, 21)
        Me.gd_cd.TabIndex = 72
        Me.gd_cd.Title = "품목코드"
        Me.gd_cd.TitleWidth = 98
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(107, 153)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(282, 21)
        Me.lot_no.TabIndex = 71
        Me.lot_no.Title = "약품번호"
        Me.lot_no.TitleWidth = 98
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(23, 115)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(244, 21)
        Me.spec.TabIndex = 74
        Me.spec.Title = "규격"
        Me.spec.TitleWidth = 98
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(23, 90)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(244, 21)
        Me.gd_nm.TabIndex = 73
        Me.gd_nm.Title = "제품명"
        Me.gd_nm.TitleWidth = 98
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(686, 90)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(242, 21)
        Me.sa_cd.TabIndex = 70
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 98
        '
        'plan_no
        '
        Me.plan_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.plan_no.Location = New System.Drawing.Point(23, 40)
        Me.plan_no.Name = "plan_no"
        Me.plan_no.Size = New System.Drawing.Size(244, 21)
        Me.plan_no.TabIndex = 56
        Me.plan_no.Title = "출하번호"
        Me.plan_no.TitleWidth = 98
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(348, 40)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(171, 21)
        Me.ps_cd.TabIndex = 59
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 98
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(525, 40)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(105, 21)
        Me.ps_nm.TabIndex = 58
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "비 고"
        Me.ps_nm.TitleWidth = 0
        '
        'plan_dt
        '
        Me.plan_dt.Location = New System.Drawing.Point(686, 40)
        Me.plan_dt.Name = "plan_dt"
        Me.plan_dt.Size = New System.Drawing.Size(242, 21)
        Me.plan_dt.TabIndex = 57
        Me.plan_dt.Title = "출고일자"
        Me.plan_dt.TitleWidth = 98
        '
        'mc_cd
        '
        Me.mc_cd.Location = New System.Drawing.Point(348, 65)
        Me.mc_cd.Name = "mc_cd"
        Me.mc_cd.Size = New System.Drawing.Size(282, 21)
        Me.mc_cd.TabIndex = 68
        Me.mc_cd.Title = "기계"
        Me.mc_cd.TitleWidth = 98
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(804, 429)
        Me.g_body.TabIndex = 0
        '
        'mate_job_qty
        '
        Me.mate_job_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mate_job_qty.Location = New System.Drawing.Point(348, 140)
        Me.mate_job_qty.Name = "mate_job_qty"
        Me.mate_job_qty.Size = New System.Drawing.Size(160, 21)
        Me.mate_job_qty.TabIndex = 115
        Me.mate_job_qty.Title = "배합지시량"
        Me.mate_job_qty.TitleWidth = 98
        '
        'WI_PR1101
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_PR1101"
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
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents find_chul_gu As Frame7.eCombo
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents CHUL_GU As Frame7.eCombo
    Friend WithEvents ja_nm As Frame7.eText
    Friend WithEvents ja_cd As Frame7.eText
    Friend WithEvents stock_qty As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents unit_cd As Frame7.eCombo
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents daytime_gu As Frame7.eCombo
    Friend WithEvents plan_qty As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents plan_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents plan_dt As Frame7.eDate
    Friend WithEvents mc_cd As Frame7.eCombo
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents mate_job_qty As Frame7.eText

End Class
