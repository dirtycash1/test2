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
        Me.SC1 = New System.Windows.Forms.SplitContainer()
        Me.g_list = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.find_from = New Frame7.eDate()
        Me.find_to = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_stts = New Frame7.eOptionBox()
        Me.find_od_no = New Frame7.eText()
        Me.find_cs_cd = New Frame7.eText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.SC2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
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
        Me.chk_show = New Frame7.eCheck()
        Me.SC1.Panel1.SuspendLayout()
        Me.SC1.Panel2.SuspendLayout()
        Me.SC1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SC2.Panel1.SuspendLayout()
        Me.SC2.Panel2.SuspendLayout()
        Me.SC2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SC1
        '
        Me.SC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SC1.Location = New System.Drawing.Point(0, 0)
        Me.SC1.Name = "SC1"
        '
        'SC1.Panel1
        '
        Me.SC1.Panel1.Controls.Add(Me.g_list)
        Me.SC1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SC1.Panel2
        '
        Me.SC1.Panel2.Controls.Add(Me.SC2)
        Me.SC1.Size = New System.Drawing.Size(1182, 611)
        Me.SC1.SplitterDistance = 442
        Me.SC1.TabIndex = 2
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 268)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(442, 343)
        Me.g_list.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.find_cs_nm)
        Me.EPanel2.Controls.Add(Me.find_stts)
        Me.EPanel2.Controls.Add(Me.find_od_no)
        Me.EPanel2.Controls.Add(Me.find_cs_cd)
        Me.EPanel2.Controls.Add(Me.Panel1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(442, 268)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     검색조건"
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(5, 26)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(192, 21)
        Me.find_from.TabIndex = 37
        Me.find_from.Title = "수주일자"
        Me.find_from.TitleWidth = 98
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(204, 26)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(101, 21)
        Me.find_to.TabIndex = 38
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(198, 53)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.ReadOnly = True
        Me.find_cs_nm.Size = New System.Drawing.Size(133, 21)
        Me.find_cs_nm.TabIndex = 43
        Me.find_cs_nm.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.find_cs_nm.Title = "수주번호"
        Me.find_cs_nm.TitleWidth = 0
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(5, 107)
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
        Me.find_od_no.Location = New System.Drawing.Point(5, 80)
        Me.find_od_no.Name = "find_od_no"
        Me.find_od_no.Size = New System.Drawing.Size(326, 21)
        Me.find_od_no.TabIndex = 41
        Me.find_od_no.Title = "수주번호"
        Me.find_od_no.TitleWidth = 98
        '
        'find_cs_cd
        '
        Me.find_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_cd.Location = New System.Drawing.Point(5, 53)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(192, 21)
        Me.find_cs_cd.TabIndex = 40
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 98
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 48)
        Me.Panel1.TabIndex = 2
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(239, 9)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 30)
        Me.btn_cancel.TabIndex = 101
        Me.btn_cancel.Text = "취소"
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(143, 9)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(90, 30)
        Me.btn_find.TabIndex = 98
        Me.btn_find.Text = "찾기"
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
        Me.SC2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SC2.Panel2
        '
        Me.SC2.Panel2.Controls.Add(Me.g_body)
        Me.SC2.Size = New System.Drawing.Size(736, 611)
        Me.SC2.SplitterDistance = 226
        Me.SC2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chk_show)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.remk)
        Me.EPanel1.Controls.Add(Me.cs_tel)
        Me.EPanel1.Controls.Add(Me.cs_addr)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.nacs_tel)
        Me.EPanel1.Controls.Add(Me.nacs_addr)
        Me.EPanel1.Controls.Add(Me.nacs_nm)
        Me.EPanel1.Controls.Add(Me.nacs_cd)
        Me.EPanel1.Controls.Add(Me.od_gu)
        Me.EPanel1.Controls.Add(Me.od_dt)
        Me.EPanel1.Controls.Add(Me.pl_nm)
        Me.EPanel1.Controls.Add(Me.pl_cd)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.od_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(736, 226)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     전표등록"
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
        Me.remk.Location = New System.Drawing.Point(5, 134)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(549, 60)
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
        Me.g_body.Size = New System.Drawing.Size(736, 381)
        Me.g_body.TabIndex = 0
        '
        'chk_show
        '
        Me.chk_show.Caption = ""
        Me.chk_show.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_show.Location = New System.Drawing.Point(107, 1)
        Me.chk_show.Name = "chk_show"
        Me.chk_show.Size = New System.Drawing.Size(107, 21)
        Me.chk_show.TabIndex = 143
        Me.chk_show.Title = "검색조건"
        Me.chk_show.TitleWidth = 80
        '
        'WI_SA1120
        '
        Me.Controls.Add(Me.SC1)
        Me.Name = "WI_SA1120"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SC1, 0)
        Me.SC1.Panel1.ResumeLayout(False)
        Me.SC1.Panel2.ResumeLayout(False)
        Me.SC1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SC2.Panel1.ResumeLayout(False)
        Me.SC2.Panel2.ResumeLayout(False)
        Me.SC2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SC1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SC2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_od_no As Frame7.eText
    Friend WithEvents find_stts As Frame7.eOptionBox
    Friend WithEvents find_cs_nm As Frame7.eText
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
    Friend WithEvents chk_show As Frame7.eCheck

End Class
