<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_JA1179
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find2 = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible2 = New System.Windows.Forms.CheckBox()
        Me.find_to2 = New Frame7.eDate()
        Me.find_from2 = New Frame7.eDate()
        Me.find_ps_nm2 = New Frame7.eText()
        Me.g_list2 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.remk = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.pl_cd = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.chul_no = New Frame7.eText()
        Me.chul_type = New Frame7.eCombo()
        Me.wh_cd = New Frame7.eCombo()
        Me.ps_cd = New Frame7.eText()
        Me.chul_dt = New Frame7.eDate()
        Me.ps_nm = New Frame7.eText()
        Me.g_body = New Frame7.eGrid()
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
        Me.spc_1.Panel1.Controls.Add(Me.tab1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 3
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(374, 611)
        Me.tab1.TabIndex = 50
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
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(367, 154)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(27, 64)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(273, 21)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 111)
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
        Me.g_list.Size = New System.Drawing.Size(367, 423)
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
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer4.SplitterDistance = 159
        Me.SplitContainer4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.find_to2)
        Me.Panel3.Controls.Add(Me.find_from2)
        Me.Panel3.Controls.Add(Me.find_ps_nm2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 159)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel2)
        Me.Panel4.Controls.Add(Me.btn_find2)
        Me.Panel4.Controls.Add(Me.find_visible2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 118)
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
        Me.find_to2.Location = New System.Drawing.Point(187, 30)
        Me.find_to2.Name = "find_to2"
        Me.find_to2.Size = New System.Drawing.Size(111, 21)
        Me.find_to2.TabIndex = 51
        Me.find_to2.Title = "~"
        Me.find_to2.TitleWidth = 10
        '
        'find_from2
        '
        Me.find_from2.Location = New System.Drawing.Point(25, 30)
        Me.find_from2.Name = "find_from2"
        Me.find_from2.Size = New System.Drawing.Size(159, 21)
        Me.find_from2.TabIndex = 50
        Me.find_from2.Title = "기간"
        Me.find_from2.TitleWidth = 60
        '
        'find_ps_nm2
        '
        Me.find_ps_nm2.ColumnName = "find_paymenterm_cd"
        Me.find_ps_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_ps_nm2.Location = New System.Drawing.Point(25, 54)
        Me.find_ps_nm2.Name = "find_ps_nm2"
        Me.find_ps_nm2.Size = New System.Drawing.Size(273, 21)
        Me.find_ps_nm2.TabIndex = 48
        Me.find_ps_nm2.TableName = "find_paymenterm_cd"
        Me.find_ps_nm2.Title = "요청자명"
        Me.find_ps_nm2.TitleWidth = 60
        '
        'g_list2
        '
        Me.g_list2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list2.Location = New System.Drawing.Point(0, 0)
        Me.g_list2.Name = "g_list2"
        Me.g_list2.ReadOnly = False
        Me.g_list2.RowHeight = -1
        Me.g_list2.Size = New System.Drawing.Size(367, 418)
        Me.g_list2.TabIndex = 1
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
        Me.SplitContainer2.SplitterDistance = 124
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.remk)
        Me.ep_head.Controls.Add(Me.stts)
        Me.ep_head.Controls.Add(Me.pl_cd)
        Me.ep_head.Controls.Add(Me.sa_cd)
        Me.ep_head.Controls.Add(Me.chul_no)
        Me.ep_head.Controls.Add(Me.chul_type)
        Me.ep_head.Controls.Add(Me.wh_cd)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.chul_dt)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(804, 124)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     출고등록"
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(23, 88)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(607, 21)
        Me.remk.TabIndex = 72
        Me.remk.Title = "비고"
        Me.remk.TitleWidth = 98
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(679, 88)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(199, 21)
        Me.stts.TabIndex = 71
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 70
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_paymenterm_cd"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(185, 204)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(171, 21)
        Me.pl_cd.TabIndex = 73
        Me.pl_cd.TableName = "find_paymenterm_cd"
        Me.pl_cd.Title = "부서코드"
        Me.pl_cd.TitleWidth = 98
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(679, 64)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(199, 21)
        Me.sa_cd.TabIndex = 70
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 70
        '
        'chul_no
        '
        Me.chul_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chul_no.Location = New System.Drawing.Point(23, 40)
        Me.chul_no.Name = "chul_no"
        Me.chul_no.Size = New System.Drawing.Size(244, 21)
        Me.chul_no.TabIndex = 56
        Me.chul_no.Title = "출하번호"
        Me.chul_no.TitleWidth = 98
        '
        'chul_type
        '
        Me.chul_type.Location = New System.Drawing.Point(348, 64)
        Me.chul_type.Name = "chul_type"
        Me.chul_type.Size = New System.Drawing.Size(282, 21)
        Me.chul_type.TabIndex = 69
        Me.chul_type.Title = "출고구분"
        Me.chul_type.TitleWidth = 98
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(23, 64)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(244, 21)
        Me.wh_cd.TabIndex = 68
        Me.wh_cd.Title = "창고"
        Me.wh_cd.TitleWidth = 98
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
        'chul_dt
        '
        Me.chul_dt.Location = New System.Drawing.Point(679, 40)
        Me.chul_dt.Name = "chul_dt"
        Me.chul_dt.Size = New System.Drawing.Size(199, 21)
        Me.chul_dt.TabIndex = 57
        Me.chul_dt.Title = "출고일자"
        Me.chul_dt.TitleWidth = 70
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(521, 40)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(109, 21)
        Me.ps_nm.TabIndex = 58
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "비 고"
        Me.ps_nm.TitleWidth = 0
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(804, 483)
        Me.g_body.TabIndex = 0
        '
        'WI_JA1179
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_JA1179"
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
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents chul_no As Frame7.eText
    Friend WithEvents chul_dt As Frame7.eDate
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents chul_type As Frame7.eCombo
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents stts As Frame7.eCombo
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
    Friend WithEvents find_ps_nm2 As Frame7.eText
    Friend WithEvents g_list2 As Frame7.eGrid
    Friend WithEvents pl_cd As Frame7.eText

End Class
