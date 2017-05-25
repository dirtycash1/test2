<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1110
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_gd_nm = New Frame7.eText()
        Me.find_stts = New Frame7.eCombo()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.stts = New Frame7.eCombo()
        Me.hot_cd = New Frame7.eText()
        Me.job_qty = New Frame7.eText()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.but = New DevExpress.XtraEditors.RadioGroup()
        Me.job_no = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.lot_no = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.spec = New Frame7.eText()
        Me.job_type = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.gd_nm = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.gd_cd = New Frame7.eText()
        Me.job_dt = New Frame7.eDate()
        Me.g_body = New Frame7.eGrid()
        Me.unit_cd = New Frame7.eCombo()
        Me.daytime_gu = New Frame7.eCombo()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.but.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.spc_1.Panel1.Controls.Add(Me.tab1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1420, 611)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 8
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(374, 611)
        Me.tab1.TabIndex = 49
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1})
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(367, 581)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.find_to)
        Me.Panel2.Controls.Add(Me.find_from)
        Me.Panel2.Controls.Add(Me.find_gd_nm)
        Me.Panel2.Controls.Add(Me.find_stts)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 189)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 41)
        Me.Panel1.TabIndex = 2
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
        Me.find_visible.Location = New System.Drawing.Point(273, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(92, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(187, 30)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 51
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(25, 30)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 50
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_gd_nm
        '
        Me.find_gd_nm.ColumnName = "find_paymenterm_cd"
        Me.find_gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_nm.Location = New System.Drawing.Point(25, 58)
        Me.find_gd_nm.Name = "find_gd_nm"
        Me.find_gd_nm.Size = New System.Drawing.Size(273, 21)
        Me.find_gd_nm.TabIndex = 48
        Me.find_gd_nm.TableName = "find_paymenterm_cd"
        Me.find_gd_nm.Title = "제품명"
        Me.find_gd_nm.TitleWidth = 60
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(25, 85)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(159, 21)
        Me.find_stts.TabIndex = 49
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 60
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(367, 388)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(1042, 611)
        Me.SplitContainer2.SplitterDistance = 198
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.daytime_gu)
        Me.EPanel1.Controls.Add(Me.unit_cd)
        Me.EPanel1.Controls.Add(Me.stts)
        Me.EPanel1.Controls.Add(Me.GroupBox1)
        Me.EPanel1.Controls.Add(Me.job_no)
        Me.EPanel1.Controls.Add(Me.hot_cd)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.sa_cd)
        Me.EPanel1.Controls.Add(Me.job_qty)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.lot_no)
        Me.EPanel1.Controls.Add(Me.job_type)
        Me.EPanel1.Controls.Add(Me.spec)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.from_dt)
        Me.EPanel1.Controls.Add(Me.job_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1042, 198)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     생산지시서"
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(614, 69)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(209, 21)
        Me.stts.TabIndex = 106
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 85
        '
        'hot_cd
        '
        Me.hot_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.hot_cd.Location = New System.Drawing.Point(77, 69)
        Me.hot_cd.Name = "hot_cd"
        Me.hot_cd.Size = New System.Drawing.Size(25, 21)
        Me.hot_cd.TabIndex = 76
        Me.hot_cd.Title = "제품코드"
        Me.hot_cd.TitleWidth = 0
        '
        'job_qty
        '
        Me.job_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_qty.Location = New System.Drawing.Point(301, 150)
        Me.job_qty.Name = "job_qty"
        Me.job_qty.Size = New System.Drawing.Size(269, 21)
        Me.job_qty.TabIndex = 73
        Me.job_qty.Title = "생산지시수량"
        Me.job_qty.TitleWidth = 90
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.but)
        Me.GroupBox1.Location = New System.Drawing.Point(841, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 127)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "출력물선택"
        '
        'but
        '
        Me.but.EditValue = "0"
        Me.but.Location = New System.Drawing.Point(6, 22)
        Me.but.Name = "but"
        Me.but.Properties.Columns = 1
        Me.but.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "생산지시서"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "품질CHECK_SHEET")})
        Me.but.Size = New System.Drawing.Size(187, 92)
        Me.but.TabIndex = 97
        '
        'job_no
        '
        Me.job_no.ColumnName = "job_no"
        Me.job_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_no.Location = New System.Drawing.Point(17, 41)
        Me.job_no.Name = "job_no"
        Me.job_no.Size = New System.Drawing.Size(252, 21)
        Me.job_no.TabIndex = 65
        Me.job_no.TableName = "job_no"
        Me.job_no.Title = "생산지시번호"
        Me.job_no.TitleWidth = 85
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "ps_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(301, 41)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(163, 21)
        Me.ps_cd.TabIndex = 63
        Me.ps_cd.TableName = "ps_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 90
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(301, 69)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(269, 21)
        Me.sa_cd.TabIndex = 105
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 90
        '
        'lot_no
        '
        Me.lot_no.ColumnName = "job_no"
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(301, 96)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(269, 21)
        Me.lot_no.TabIndex = 104
        Me.lot_no.TableName = "job_no"
        Me.lot_no.Title = "CHECK_SHEET NO."
        Me.lot_no.TitleWidth = 90
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "pl_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(468, 41)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(102, 21)
        Me.ps_nm.TabIndex = 64
        Me.ps_nm.TableName = "pl_nm"
        Me.ps_nm.Title = "부서"
        Me.ps_nm.TitleWidth = 0
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(17, 123)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(252, 21)
        Me.spec.TabIndex = 71
        Me.spec.Title = "규격"
        Me.spec.TitleWidth = 85
        '
        'job_type
        '
        Me.job_type.Location = New System.Drawing.Point(301, 123)
        Me.job_type.Name = "job_type"
        Me.job_type.Size = New System.Drawing.Size(269, 21)
        Me.job_type.TabIndex = 102
        Me.job_type.Title = "생산구분"
        Me.job_type.TitleWidth = 90
        '
        'to_dt
        '
        Me.to_dt.ColumnName = "plan_dt"
        Me.to_dt.Location = New System.Drawing.Point(614, 123)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(209, 21)
        Me.to_dt.TabIndex = 75
        Me.to_dt.TableName = "plan_dt"
        Me.to_dt.Title = "완료예정일자"
        Me.to_dt.TitleWidth = 85
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(17, 96)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(252, 21)
        Me.gd_nm.TabIndex = 70
        Me.gd_nm.Title = "제품명"
        Me.gd_nm.TitleWidth = 85
        '
        'from_dt
        '
        Me.from_dt.ColumnName = "plan_dt"
        Me.from_dt.Location = New System.Drawing.Point(614, 96)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(209, 21)
        Me.from_dt.TabIndex = 74
        Me.from_dt.TableName = "plan_dt"
        Me.from_dt.Title = "생산시작일자"
        Me.from_dt.TitleWidth = 85
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(17, 69)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(252, 21)
        Me.gd_cd.TabIndex = 69
        Me.gd_cd.Title = "제품코드"
        Me.gd_cd.TitleWidth = 85
        '
        'job_dt
        '
        Me.job_dt.ColumnName = "plan_dt"
        Me.job_dt.Location = New System.Drawing.Point(614, 41)
        Me.job_dt.Name = "job_dt"
        Me.job_dt.Size = New System.Drawing.Size(209, 21)
        Me.job_dt.TabIndex = 62
        Me.job_dt.TableName = "plan_dt"
        Me.job_dt.Title = "생산지시일자"
        Me.job_dt.TitleWidth = 85
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(1042, 409)
        Me.g_body.TabIndex = 0
        '
        'unit_cd
        '
        Me.unit_cd.Location = New System.Drawing.Point(17, 150)
        Me.unit_cd.Name = "unit_cd"
        Me.unit_cd.Size = New System.Drawing.Size(252, 21)
        Me.unit_cd.TabIndex = 107
        Me.unit_cd.Title = "단위"
        Me.unit_cd.TitleWidth = 85
        '
        'daytime_gu
        '
        Me.daytime_gu.Location = New System.Drawing.Point(614, 150)
        Me.daytime_gu.Name = "daytime_gu"
        Me.daytime_gu.Size = New System.Drawing.Size(209, 21)
        Me.daytime_gu.TabIndex = 108
        Me.daytime_gu.Title = "주/야간"
        Me.daytime_gu.TitleWidth = 85
        '
        'WI_PR1110
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_PR1110"
        Me.Size = New System.Drawing.Size(1420, 611)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.but.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_gd_nm As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents job_qty As Frame7.eText
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents job_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents job_dt As Frame7.eDate
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents hot_cd As Frame7.eText
    Friend WithEvents but As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents job_type As Frame7.eCombo
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents unit_cd As Frame7.eCombo
    Friend WithEvents daytime_gu As Frame7.eCombo

End Class
