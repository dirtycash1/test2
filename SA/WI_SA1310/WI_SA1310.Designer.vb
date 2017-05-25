<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1310
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
        Me.find_stts = New Frame7.eCombo()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_mv_no = New Frame7.eText()
        Me.g_list = New Frame7.eGrid()
        Me.SC2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.stts1 = New Frame7.eCombo()
        Me.to_vatamt = New Frame7.eText()
        Me.to_mvamt = New Frame7.eText()
        Me.from_vatamt = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.to_odno = New Frame7.eText()
        Me.from_rtno = New Frame7.eText()
        Me.from_mvamt = New Frame7.eText()
        Me.to_totamt = New Frame7.eText()
        Me.to_otno = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.to_csnm = New Frame7.eText()
        Me.to_cscd = New Frame7.eText()
        Me.from_totamt = New Frame7.eText()
        Me.from_csnm = New Frame7.eText()
        Me.from_cscd = New Frame7.eText()
        Me.mv_dt = New Frame7.eDate()
        Me.mv_no = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.g_body = New Frame7.eGrid()
        Me.od_gu = New Frame7.eCombo()
        Me.mv_desc = New Frame7.eCombo()
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
        Me.spc_1.Size = New System.Drawing.Size(1350, 558)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 558)
        Me.SplitContainer1.SplitterDistance = 197
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_mv_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 197)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 154)
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
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(5, 108)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(326, 21)
        Me.find_stts.TabIndex = 105
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 98
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
        'find_mv_no
        '
        Me.find_mv_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_mv_no.Location = New System.Drawing.Point(5, 81)
        Me.find_mv_no.Name = "find_mv_no"
        Me.find_mv_no.Size = New System.Drawing.Size(326, 21)
        Me.find_mv_no.TabIndex = 41
        Me.find_mv_no.Title = "전표번호"
        Me.find_mv_no.TitleWidth = 98
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(374, 357)
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
        Me.SC2.Size = New System.Drawing.Size(972, 558)
        Me.SC2.SplitterDistance = 148
        Me.SC2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.od_gu)
        Me.ep_head.Controls.Add(Me.stts1)
        Me.ep_head.Controls.Add(Me.mv_desc)
        Me.ep_head.Controls.Add(Me.to_vatamt)
        Me.ep_head.Controls.Add(Me.to_mvamt)
        Me.ep_head.Controls.Add(Me.from_vatamt)
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.to_odno)
        Me.ep_head.Controls.Add(Me.from_rtno)
        Me.ep_head.Controls.Add(Me.from_mvamt)
        Me.ep_head.Controls.Add(Me.to_totamt)
        Me.ep_head.Controls.Add(Me.to_otno)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.to_csnm)
        Me.ep_head.Controls.Add(Me.to_cscd)
        Me.ep_head.Controls.Add(Me.from_totamt)
        Me.ep_head.Controls.Add(Me.from_csnm)
        Me.ep_head.Controls.Add(Me.from_cscd)
        Me.ep_head.Controls.Add(Me.mv_dt)
        Me.ep_head.Controls.Add(Me.mv_no)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(972, 148)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     전표등록"
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(866, 29)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(196, 21)
        Me.stts1.TabIndex = 81
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 80
        '
        'to_vatamt
        '
        Me.to_vatamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_vatamt.Location = New System.Drawing.Point(596, 200)
        Me.to_vatamt.Name = "to_vatamt"
        Me.to_vatamt.Size = New System.Drawing.Size(187, 21)
        Me.to_vatamt.TabIndex = 80
        Me.to_vatamt.Title = "to부가세"
        Me.to_vatamt.TitleWidth = 80
        Me.to_vatamt.Visible = False
        '
        'to_mvamt
        '
        Me.to_mvamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_mvamt.Location = New System.Drawing.Point(400, 200)
        Me.to_mvamt.Name = "to_mvamt"
        Me.to_mvamt.Size = New System.Drawing.Size(187, 21)
        Me.to_mvamt.TabIndex = 79
        Me.to_mvamt.Title = "to금액"
        Me.to_mvamt.TitleWidth = 80
        Me.to_mvamt.Visible = False
        '
        'from_vatamt
        '
        Me.from_vatamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_vatamt.Location = New System.Drawing.Point(207, 200)
        Me.from_vatamt.Name = "from_vatamt"
        Me.from_vatamt.Size = New System.Drawing.Size(187, 21)
        Me.from_vatamt.TabIndex = 78
        Me.from_vatamt.Title = "from부가세"
        Me.from_vatamt.TitleWidth = 80
        Me.from_vatamt.Visible = False
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(5, 113)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(646, 21)
        Me.remk.TabIndex = 76
        Me.remk.Title = "특기사항"
        Me.remk.TitleWidth = 88
        '
        'to_odno
        '
        Me.to_odno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_odno.Location = New System.Drawing.Point(662, 85)
        Me.to_odno.Name = "to_odno"
        Me.to_odno.ReadOnly = True
        Me.to_odno.Size = New System.Drawing.Size(196, 21)
        Me.to_odno.TabIndex = 74
        Me.to_odno.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.to_odno.Title = "수주번호"
        Me.to_odno.TitleWidth = 80
        '
        'from_rtno
        '
        Me.from_rtno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_rtno.Location = New System.Drawing.Point(662, 57)
        Me.from_rtno.Name = "from_rtno"
        Me.from_rtno.ReadOnly = True
        Me.from_rtno.Size = New System.Drawing.Size(196, 21)
        Me.from_rtno.TabIndex = 73
        Me.from_rtno.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.from_rtno.Title = "반품번호"
        Me.from_rtno.TitleWidth = 80
        '
        'from_mvamt
        '
        Me.from_mvamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_mvamt.Location = New System.Drawing.Point(11, 200)
        Me.from_mvamt.Name = "from_mvamt"
        Me.from_mvamt.Size = New System.Drawing.Size(187, 21)
        Me.from_mvamt.TabIndex = 77
        Me.from_mvamt.Title = "from금액"
        Me.from_mvamt.TitleWidth = 80
        Me.from_mvamt.Visible = False
        '
        'to_totamt
        '
        Me.to_totamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_totamt.Location = New System.Drawing.Point(464, 85)
        Me.to_totamt.Name = "to_totamt"
        Me.to_totamt.Size = New System.Drawing.Size(187, 21)
        Me.to_totamt.TabIndex = 72
        Me.to_totamt.Title = "금액합계"
        Me.to_totamt.TitleWidth = 80
        '
        'to_otno
        '
        Me.to_otno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_otno.Location = New System.Drawing.Point(866, 85)
        Me.to_otno.Name = "to_otno"
        Me.to_otno.ReadOnly = True
        Me.to_otno.Size = New System.Drawing.Size(196, 21)
        Me.to_otno.TabIndex = 75
        Me.to_otno.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.to_otno.Title = "출하번호"
        Me.to_otno.TitleWidth = 80
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(464, 29)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(187, 21)
        Me.sa_cd.TabIndex = 71
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 80
        '
        'to_csnm
        '
        Me.to_csnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_csnm.Location = New System.Drawing.Point(177, 85)
        Me.to_csnm.Name = "to_csnm"
        Me.to_csnm.Size = New System.Drawing.Size(280, 21)
        Me.to_csnm.TabIndex = 70
        Me.to_csnm.Title = "TO거래처명"
        Me.to_csnm.TitleWidth = 0
        '
        'to_cscd
        '
        Me.to_cscd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_cscd.Location = New System.Drawing.Point(5, 85)
        Me.to_cscd.Name = "to_cscd"
        Me.to_cscd.Size = New System.Drawing.Size(170, 21)
        Me.to_cscd.TabIndex = 69
        Me.to_cscd.Title = "TO    거래처"
        Me.to_cscd.TitleWidth = 88
        '
        'from_totamt
        '
        Me.from_totamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_totamt.Location = New System.Drawing.Point(464, 57)
        Me.from_totamt.Name = "from_totamt"
        Me.from_totamt.Size = New System.Drawing.Size(187, 21)
        Me.from_totamt.TabIndex = 64
        Me.from_totamt.Title = "금액합계"
        Me.from_totamt.TitleWidth = 80
        '
        'from_csnm
        '
        Me.from_csnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_csnm.Location = New System.Drawing.Point(177, 57)
        Me.from_csnm.Name = "from_csnm"
        Me.from_csnm.Size = New System.Drawing.Size(280, 21)
        Me.from_csnm.TabIndex = 52
        Me.from_csnm.Title = "from_csnm"
        Me.from_csnm.TitleWidth = 0
        '
        'from_cscd
        '
        Me.from_cscd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.from_cscd.Location = New System.Drawing.Point(5, 57)
        Me.from_cscd.Name = "from_cscd"
        Me.from_cscd.Size = New System.Drawing.Size(170, 21)
        Me.from_cscd.TabIndex = 51
        Me.from_cscd.Title = "FROM 거래처"
        Me.from_cscd.TitleWidth = 88
        '
        'mv_dt
        '
        Me.mv_dt.Location = New System.Drawing.Point(662, 29)
        Me.mv_dt.Name = "mv_dt"
        Me.mv_dt.Size = New System.Drawing.Size(196, 21)
        Me.mv_dt.TabIndex = 44
        Me.mv_dt.Title = "이동일자"
        Me.mv_dt.TitleWidth = 80
        '
        'mv_no
        '
        Me.mv_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mv_no.Location = New System.Drawing.Point(5, 29)
        Me.mv_no.Name = "mv_no"
        Me.mv_no.ReadOnly = True
        Me.mv_no.Size = New System.Drawing.Size(196, 21)
        Me.mv_no.TabIndex = 44
        Me.mv_no.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.mv_no.Title = "전표번호"
        Me.mv_no.TitleWidth = 88
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(362, 30)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(95, 21)
        Me.ps_nm.TabIndex = 56
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(377, 165)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(192, 21)
        Me.pl_cd.TabIndex = 45
        Me.pl_cd.Title = "pl_cd"
        Me.pl_cd.TitleWidth = 98
        Me.pl_cd.Visible = False
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(210, 30)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(150, 21)
        Me.ps_cd.TabIndex = 44
        Me.ps_cd.Title = "ps_cd"
        Me.ps_cd.TitleWidth = 70
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(972, 406)
        Me.g_body.TabIndex = 0
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(662, 113)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(196, 21)
        Me.od_gu.TabIndex = 82
        Me.od_gu.Title = "수주유형"
        Me.od_gu.TitleWidth = 80
        '
        'mv_desc
        '
        Me.mv_desc.Location = New System.Drawing.Point(866, 113)
        Me.mv_desc.Name = "mv_desc"
        Me.mv_desc.Size = New System.Drawing.Size(196, 21)
        Me.mv_desc.TabIndex = 83
        Me.mv_desc.Title = "이동사유"
        Me.mv_desc.TitleWidth = 80
        '
        'WI_SA1310
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1310"
        Me.Size = New System.Drawing.Size(1350, 558)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SC2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_mv_no As Frame7.eText
    Friend WithEvents mv_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents mv_dt As Frame7.eDate
    Friend WithEvents from_cscd As Frame7.eText
    Friend WithEvents from_csnm As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents from_totamt As Frame7.eText
    Friend WithEvents to_csnm As Frame7.eText
    Friend WithEvents to_cscd As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents to_otno As Frame7.eText
    Friend WithEvents to_odno As Frame7.eText
    Friend WithEvents from_rtno As Frame7.eText
    Friend WithEvents to_totamt As Frame7.eText
    Friend WithEvents from_mvamt As Frame7.eText
    Friend WithEvents from_vatamt As Frame7.eText
    Friend WithEvents to_vatamt As Frame7.eText
    Friend WithEvents to_mvamt As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents od_gu As Frame7.eCombo
    Friend WithEvents mv_desc As Frame7.eCombo

End Class
