<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1120
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
        Me.find_cs_nm = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_stts = New Frame7.eOptionBox()
        Me.find_od_no = New Frame7.eText()
        Me.g_list = New Frame7.eGrid()
        Me.SC2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.stts = New Frame7.eCombo()
        Me.ps_nm = New Frame7.eText()
        Me.remk = New Frame7.eMemo()
        Me.cs_tel = New Frame7.eText()
        Me.cs_addr = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.nacs_tel = New Frame7.eText()
        Me.nacs_addr = New Frame7.eText()
        Me.nacs_nm = New Frame7.eText()
        Me.nacs_cd = New Frame7.eText()
        Me.od_gu = New Frame7.eOptionBox()
        Me.od_dt = New Frame7.eDate()
        Me.pl_nm = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.od_no = New Frame7.eText()
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
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 416
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
        Me.SplitContainer1.Size = New System.Drawing.Size(416, 611)
        Me.SplitContainer1.SplitterDistance = 216
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.find_od_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(416, 216)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(316, 0)
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
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(5, 108)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.SelectedIndex = -1
        Me.find_stts.Size = New System.Drawing.Size(326, 22)
        Me.find_stts.TabIndex = 42
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 98
        '
        'find_od_no
        '
        Me.find_od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_od_no.Location = New System.Drawing.Point(5, 81)
        Me.find_od_no.Name = "find_od_no"
        Me.find_od_no.Size = New System.Drawing.Size(326, 21)
        Me.find_od_no.TabIndex = 41
        Me.find_od_no.Title = "수주번호"
        Me.find_od_no.TitleWidth = 98
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(416, 391)
        Me.g_list.TabIndex = 1
        '
        'SC2
        '
        Me.SC2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SC2.Size = New System.Drawing.Size(762, 611)
        Me.SC2.SplitterDistance = 215
        Me.SC2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.stts)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.cs_tel)
        Me.ep_head.Controls.Add(Me.cs_addr)
        Me.ep_head.Controls.Add(Me.cs_nm)
        Me.ep_head.Controls.Add(Me.cs_cd)
        Me.ep_head.Controls.Add(Me.nacs_tel)
        Me.ep_head.Controls.Add(Me.nacs_addr)
        Me.ep_head.Controls.Add(Me.nacs_nm)
        Me.ep_head.Controls.Add(Me.nacs_cd)
        Me.ep_head.Controls.Add(Me.od_gu)
        Me.ep_head.Controls.Add(Me.od_dt)
        Me.ep_head.Controls.Add(Me.pl_nm)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.od_no)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(762, 215)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     전표등록"
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(338, 54)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(187, 21)
        Me.stts.TabIndex = 57
        Me.stts.Title = "stts"
        Me.stts.TitleWidth = 98
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(229, 26)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(192, 21)
        Me.ps_nm.TabIndex = 56
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 98
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(5, 134)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(677, 60)
        Me.remk.TabIndex = 55
        Me.remk.Title = "remk"
        Me.remk.TitleWidth = 98
        '
        'cs_tel
        '
        Me.cs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_tel.Location = New System.Drawing.Point(555, 107)
        Me.cs_tel.Name = "cs_tel"
        Me.cs_tel.Size = New System.Drawing.Size(127, 21)
        Me.cs_tel.TabIndex = 54
        Me.cs_tel.Title = "nacs_nm"
        Me.cs_tel.TitleWidth = 0
        '
        'cs_addr
        '
        Me.cs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_addr.Location = New System.Drawing.Point(332, 107)
        Me.cs_addr.Name = "cs_addr"
        Me.cs_addr.Size = New System.Drawing.Size(222, 21)
        Me.cs_addr.TabIndex = 53
        Me.cs_addr.Title = "nacs_nm"
        Me.cs_addr.TitleWidth = 0
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(198, 107)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(133, 21)
        Me.cs_nm.TabIndex = 52
        Me.cs_nm.Title = "nacs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(5, 107)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(192, 21)
        Me.cs_cd.TabIndex = 51
        Me.cs_cd.Title = "cs_cd"
        Me.cs_cd.TitleWidth = 98
        '
        'nacs_tel
        '
        Me.nacs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_tel.Location = New System.Drawing.Point(555, 80)
        Me.nacs_tel.Name = "nacs_tel"
        Me.nacs_tel.Size = New System.Drawing.Size(127, 21)
        Me.nacs_tel.TabIndex = 50
        Me.nacs_tel.Title = "nacs_nm"
        Me.nacs_tel.TitleWidth = 0
        '
        'nacs_addr
        '
        Me.nacs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_addr.Location = New System.Drawing.Point(332, 80)
        Me.nacs_addr.Name = "nacs_addr"
        Me.nacs_addr.Size = New System.Drawing.Size(222, 21)
        Me.nacs_addr.TabIndex = 49
        Me.nacs_addr.Title = "nacs_nm"
        Me.nacs_addr.TitleWidth = 0
        '
        'nacs_nm
        '
        Me.nacs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_nm.Location = New System.Drawing.Point(198, 80)
        Me.nacs_nm.Name = "nacs_nm"
        Me.nacs_nm.Size = New System.Drawing.Size(133, 21)
        Me.nacs_nm.TabIndex = 48
        Me.nacs_nm.Title = "nacs_nm"
        Me.nacs_nm.TitleWidth = 0
        '
        'nacs_cd
        '
        Me.nacs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_cd.Location = New System.Drawing.Point(5, 80)
        Me.nacs_cd.Name = "nacs_cd"
        Me.nacs_cd.Size = New System.Drawing.Size(192, 21)
        Me.nacs_cd.TabIndex = 47
        Me.nacs_cd.Title = "nacs_cd"
        Me.nacs_cd.TitleWidth = 98
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(5, 52)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.SelectedIndex = -1
        Me.od_gu.Size = New System.Drawing.Size(326, 22)
        Me.od_gu.TabIndex = 44
        Me.od_gu.Title = "od_gu"
        Me.od_gu.TitleWidth = 98
        '
        'od_dt
        '
        Me.od_dt.Location = New System.Drawing.Point(539, 26)
        Me.od_dt.Name = "od_dt"
        Me.od_dt.Size = New System.Drawing.Size(192, 21)
        Me.od_dt.TabIndex = 44
        Me.od_dt.Title = "od_dt"
        Me.od_dt.TitleWidth = 98
        '
        'pl_nm
        '
        Me.pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_nm.Location = New System.Drawing.Point(422, 26)
        Me.pl_nm.Name = "pl_nm"
        Me.pl_nm.Size = New System.Drawing.Size(103, 21)
        Me.pl_nm.TabIndex = 46
        Me.pl_nm.Title = "pl_nm"
        Me.pl_nm.TitleWidth = 0
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(544, 146)
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
        Me.ps_cd.Location = New System.Drawing.Point(539, 173)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(192, 21)
        Me.ps_cd.TabIndex = 44
        Me.ps_cd.Title = "ps_cd"
        Me.ps_cd.TitleWidth = 98
        '
        'od_no
        '
        Me.od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_no.Format = "00000000-0000"
        Me.od_no.Location = New System.Drawing.Point(5, 26)
        Me.od_no.Name = "od_no"
        Me.od_no.ReadOnly = True
        Me.od_no.Size = New System.Drawing.Size(206, 21)
        Me.od_no.TabIndex = 44
        Me.od_no.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.od_no.Title = "od_no"
        Me.od_no.TitleWidth = 98
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(762, 392)
        Me.g_body.TabIndex = 0
        '
        'WI_SA1120
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1120"
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
    Friend WithEvents find_od_no As Frame7.eText
    Friend WithEvents find_stts As Frame7.eOptionBox
    Friend WithEvents od_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents pl_nm As Frame7.eText
    Friend WithEvents od_dt As Frame7.eDate
    Friend WithEvents od_gu As Frame7.eOptionBox
    Friend WithEvents nacs_cd As Frame7.eText
    Friend WithEvents nacs_nm As Frame7.eText
    Friend WithEvents nacs_tel As Frame7.eText
    Friend WithEvents nacs_addr As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_tel As Frame7.eText
    Friend WithEvents cs_addr As Frame7.eText
    Friend WithEvents remk As Frame7.eMemo
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox

End Class
