<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1200
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
        Me.components = New System.ComponentModel.Container()
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_stts = New Frame7.eCombo()
        Me.find_help_gu = New Frame7.eCombo()
        Me.find_jagu_cd = New Frame7.eCombo()
        Me.find_gd_nm = New Frame7.eText()
        Me.find_gd_cd = New Frame7.eText()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.color_r = New Frame7.eText()
        Me.color_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.sale_cd = New Frame7.eCombo()
        Me.help_gu = New Frame7.eCombo()
        Me.stock_gu = New Frame7.eOptionBox()
        Me.jo_gu = New Frame7.eOptionBox()
        Me.model_no = New Frame7.eCombo()
        Me.gp_cd = New Frame7.eOptionBox()
        Me.jam_cd = New Frame7.eCombo()
        Me.jas_cd = New Frame7.eCombo()
        Me.price = New Frame7.eText()
        Me.jal_cd = New Frame7.eCombo()
        Me.inspect_cd = New Frame7.eCombo()
        Me.mate_cd = New Frame7.eCombo()
        Me.jagu_cd = New Frame7.eCombo()
        Me.jo_cd = New Frame7.eCombo()
        Me.unit_cd = New Frame7.eCombo()
        Me.spec = New Frame7.eText()
        Me.stts = New Frame7.eOptionBox()
        Me.gd_enm = New Frame7.eText()
        Me.gd_gu = New Frame7.eCombo()
        Me.gd_cd = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.img = New Frame7.eImage()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_list1 = New Frame7.eGrid()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.color_g = New Frame7.eText()
        Me.color_b = New Frame7.eText()
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
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.spc_1.SplitterDistance = 447
        Me.spc_1.TabIndex = 4
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
        Me.SplitContainer1.Size = New System.Drawing.Size(447, 611)
        Me.SplitContainer1.SplitterDistance = 214
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Controls.Add(Me.find_help_gu)
        Me.EPanel1.Controls.Add(Me.find_jagu_cd)
        Me.EPanel1.Controls.Add(Me.find_gd_nm)
        Me.EPanel1.Controls.Add(Me.find_gd_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(447, 214)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색 조건"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 41)
        Me.Panel1.TabIndex = 105
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
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(11, 105)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(240, 21)
        Me.find_stts.TabIndex = 11
        Me.find_stts.Title = "find_stts"
        '
        'find_help_gu
        '
        Me.find_help_gu.Location = New System.Drawing.Point(11, 130)
        Me.find_help_gu.Name = "find_help_gu"
        Me.find_help_gu.Size = New System.Drawing.Size(240, 21)
        Me.find_help_gu.TabIndex = 106
        Me.find_help_gu.Title = "find_help_gu"
        '
        'find_jagu_cd
        '
        Me.find_jagu_cd.Location = New System.Drawing.Point(11, 81)
        Me.find_jagu_cd.Name = "find_jagu_cd"
        Me.find_jagu_cd.Size = New System.Drawing.Size(240, 21)
        Me.find_jagu_cd.TabIndex = 10
        Me.find_jagu_cd.Title = "find_jagu_cd"
        '
        'find_gd_nm
        '
        Me.find_gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_nm.Location = New System.Drawing.Point(11, 57)
        Me.find_gd_nm.Name = "find_gd_nm"
        Me.find_gd_nm.Size = New System.Drawing.Size(346, 21)
        Me.find_gd_nm.TabIndex = 9
        Me.find_gd_nm.Title = "find_gd_nm"
        '
        'find_gd_cd
        '
        Me.find_gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_cd.Location = New System.Drawing.Point(11, 33)
        Me.find_gd_cd.Name = "find_gd_cd"
        Me.find_gd_cd.Size = New System.Drawing.Size(346, 21)
        Me.find_gd_cd.TabIndex = 8
        Me.find_gd_cd.Title = "find_gd_cd"
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(447, 393)
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(731, 611)
        Me.SplitContainer2.SplitterDistance = 231
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.color_r)
        Me.EPanel2.Controls.Add(Me.color_btn)
        Me.EPanel2.Controls.Add(Me.sale_cd)
        Me.EPanel2.Controls.Add(Me.help_gu)
        Me.EPanel2.Controls.Add(Me.stock_gu)
        Me.EPanel2.Controls.Add(Me.jo_gu)
        Me.EPanel2.Controls.Add(Me.model_no)
        Me.EPanel2.Controls.Add(Me.gp_cd)
        Me.EPanel2.Controls.Add(Me.jam_cd)
        Me.EPanel2.Controls.Add(Me.jas_cd)
        Me.EPanel2.Controls.Add(Me.price)
        Me.EPanel2.Controls.Add(Me.jal_cd)
        Me.EPanel2.Controls.Add(Me.inspect_cd)
        Me.EPanel2.Controls.Add(Me.mate_cd)
        Me.EPanel2.Controls.Add(Me.jagu_cd)
        Me.EPanel2.Controls.Add(Me.jo_cd)
        Me.EPanel2.Controls.Add(Me.unit_cd)
        Me.EPanel2.Controls.Add(Me.spec)
        Me.EPanel2.Controls.Add(Me.stts)
        Me.EPanel2.Controls.Add(Me.gd_enm)
        Me.EPanel2.Controls.Add(Me.gd_gu)
        Me.EPanel2.Controls.Add(Me.gd_cd)
        Me.EPanel2.Controls.Add(Me.gd_nm)
        Me.EPanel2.Controls.Add(Me.color_g)
        Me.EPanel2.Controls.Add(Me.color_b)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(731, 231)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     상세 정보"
        '
        'color_r
        '
        Me.color_r.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.color_r.Location = New System.Drawing.Point(282, 201)
        Me.color_r.Name = "color_r"
        Me.color_r.Size = New System.Drawing.Size(140, 21)
        Me.color_r.TabIndex = 198
        Me.color_r.Title = "색상 RGB값"
        Me.color_r.TitleWidth = 98
        '
        'color_btn
        '
        Me.color_btn.Location = New System.Drawing.Point(555, 195)
        Me.color_btn.Name = "color_btn"
        Me.color_btn.Size = New System.Drawing.Size(72, 27)
        Me.color_btn.TabIndex = 197
        Me.color_btn.Text = "색상 선택"
        '
        'sale_cd
        '
        Me.sale_cd.Location = New System.Drawing.Point(282, 151)
        Me.sale_cd.Name = "sale_cd"
        Me.sale_cd.Size = New System.Drawing.Size(252, 21)
        Me.sale_cd.TabIndex = 196
        Me.sale_cd.Title = "sale_cd"
        Me.sale_cd.TitleWidth = 98
        '
        'help_gu
        '
        Me.help_gu.Location = New System.Drawing.Point(24, 151)
        Me.help_gu.Name = "help_gu"
        Me.help_gu.Size = New System.Drawing.Size(252, 21)
        Me.help_gu.TabIndex = 195
        Me.help_gu.Title = "help_gu"
        Me.help_gu.TitleWidth = 98
        '
        'stock_gu
        '
        Me.stock_gu.Location = New System.Drawing.Point(282, 281)
        Me.stock_gu.Name = "stock_gu"
        Me.stock_gu.SelectedIndex = -1
        Me.stock_gu.Size = New System.Drawing.Size(252, 22)
        Me.stock_gu.TabIndex = 194
        Me.stock_gu.Title = "stock_gu"
        Me.stock_gu.TitleWidth = 98
        '
        'jo_gu
        '
        Me.jo_gu.Location = New System.Drawing.Point(24, 281)
        Me.jo_gu.Name = "jo_gu"
        Me.jo_gu.SelectedIndex = -1
        Me.jo_gu.Size = New System.Drawing.Size(252, 22)
        Me.jo_gu.TabIndex = 193
        Me.jo_gu.Title = "jo_gu"
        Me.jo_gu.TitleWidth = 98
        '
        'model_no
        '
        Me.model_no.Location = New System.Drawing.Point(282, 127)
        Me.model_no.Name = "model_no"
        Me.model_no.Size = New System.Drawing.Size(252, 21)
        Me.model_no.TabIndex = 192
        Me.model_no.Title = "model_no"
        Me.model_no.TitleWidth = 98
        '
        'gp_cd
        '
        Me.gp_cd.Location = New System.Drawing.Point(24, 201)
        Me.gp_cd.Name = "gp_cd"
        Me.gp_cd.SelectedIndex = -1
        Me.gp_cd.Size = New System.Drawing.Size(252, 23)
        Me.gp_cd.TabIndex = 191
        Me.gp_cd.Title = "gp_cd"
        Me.gp_cd.TitleWidth = 98
        '
        'jam_cd
        '
        Me.jam_cd.Location = New System.Drawing.Point(282, 336)
        Me.jam_cd.Name = "jam_cd"
        Me.jam_cd.Size = New System.Drawing.Size(252, 21)
        Me.jam_cd.TabIndex = 185
        Me.jam_cd.Title = "jam_cd"
        Me.jam_cd.TitleWidth = 98
        '
        'jas_cd
        '
        Me.jas_cd.Location = New System.Drawing.Point(282, 309)
        Me.jas_cd.Name = "jas_cd"
        Me.jas_cd.Size = New System.Drawing.Size(252, 21)
        Me.jas_cd.TabIndex = 186
        Me.jas_cd.Title = "jas_cd"
        Me.jas_cd.TitleWidth = 98
        '
        'price
        '
        Me.price.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.price.Location = New System.Drawing.Point(24, 309)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(252, 21)
        Me.price.TabIndex = 189
        Me.price.Title = "price"
        Me.price.TitleWidth = 98
        '
        'jal_cd
        '
        Me.jal_cd.Location = New System.Drawing.Point(24, 336)
        Me.jal_cd.Name = "jal_cd"
        Me.jal_cd.Size = New System.Drawing.Size(252, 21)
        Me.jal_cd.TabIndex = 184
        Me.jal_cd.Title = "jal_cd"
        Me.jal_cd.TitleWidth = 98
        '
        'inspect_cd
        '
        Me.inspect_cd.Location = New System.Drawing.Point(24, 176)
        Me.inspect_cd.Name = "inspect_cd"
        Me.inspect_cd.Size = New System.Drawing.Size(252, 21)
        Me.inspect_cd.TabIndex = 188
        Me.inspect_cd.Title = "inspect_cd"
        Me.inspect_cd.TitleWidth = 98
        '
        'mate_cd
        '
        Me.mate_cd.Location = New System.Drawing.Point(24, 363)
        Me.mate_cd.Name = "mate_cd"
        Me.mate_cd.Size = New System.Drawing.Size(252, 21)
        Me.mate_cd.TabIndex = 5
        Me.mate_cd.Title = "mate_cd"
        Me.mate_cd.TitleWidth = 98
        '
        'jagu_cd
        '
        Me.jagu_cd.Location = New System.Drawing.Point(282, 176)
        Me.jagu_cd.Name = "jagu_cd"
        Me.jagu_cd.Size = New System.Drawing.Size(252, 21)
        Me.jagu_cd.TabIndex = 177
        Me.jagu_cd.Title = "jagu_cd"
        Me.jagu_cd.TitleWidth = 98
        '
        'jo_cd
        '
        Me.jo_cd.Location = New System.Drawing.Point(282, 363)
        Me.jo_cd.Name = "jo_cd"
        Me.jo_cd.Size = New System.Drawing.Size(252, 21)
        Me.jo_cd.TabIndex = 181
        Me.jo_cd.Title = "jo_cd"
        Me.jo_cd.TitleWidth = 98
        '
        'unit_cd
        '
        Me.unit_cd.Location = New System.Drawing.Point(24, 127)
        Me.unit_cd.Name = "unit_cd"
        Me.unit_cd.Size = New System.Drawing.Size(252, 21)
        Me.unit_cd.TabIndex = 176
        Me.unit_cd.Title = "unit_cd"
        Me.unit_cd.TitleWidth = 98
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(24, 100)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(452, 21)
        Me.spec.TabIndex = 4
        Me.spec.Title = "spec"
        Me.spec.TitleWidth = 98
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(351, 26)
        Me.stts.Name = "stts"
        Me.stts.SelectedIndex = -1
        Me.stts.Size = New System.Drawing.Size(125, 23)
        Me.stts.TabIndex = 175
        Me.stts.Title = "stts"
        Me.stts.TitleWidth = 0
        '
        'gd_enm
        '
        Me.gd_enm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_enm.Location = New System.Drawing.Point(24, 76)
        Me.gd_enm.Name = "gd_enm"
        Me.gd_enm.Size = New System.Drawing.Size(452, 21)
        Me.gd_enm.TabIndex = 3
        Me.gd_enm.Title = "gd_enm"
        Me.gd_enm.TitleWidth = 98
        '
        'gd_gu
        '
        Me.gd_gu.Location = New System.Drawing.Point(282, 254)
        Me.gd_gu.Name = "gd_gu"
        Me.gd_gu.Size = New System.Drawing.Size(252, 21)
        Me.gd_gu.TabIndex = 178
        Me.gd_gu.Title = "gd_gu"
        Me.gd_gu.TitleWidth = 98
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(24, 27)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(252, 21)
        Me.gd_cd.TabIndex = 1
        Me.gd_cd.Title = "gd_cd"
        Me.gd_cd.TitleWidth = 98
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(24, 52)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(452, 21)
        Me.gd_nm.TabIndex = 2
        Me.gd_nm.Title = "gd_nm"
        Me.gd_nm.TitleWidth = 98
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Size = New System.Drawing.Size(731, 376)
        Me.SplitContainer3.SplitterDistance = 195
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.img)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(195, 376)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     품목사진"
        '
        'img
        '
        Me.img.Dock = System.Windows.Forms.DockStyle.Fill
        Me.img.Location = New System.Drawing.Point(2, 23)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(191, 351)
        Me.img.SizeMode = Frame7.ImageSizeMode.Stretch
        Me.img.TabIndex = 157
        Me.img.TitleBorderStyle = Frame7.BorderStyle.None
        Me.img.Visible = False
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_list1)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(532, 376)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     품목Spec"
        '
        'g_list1
        '
        Me.g_list1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list1.Location = New System.Drawing.Point(2, 23)
        Me.g_list1.Name = "g_list1"
        Me.g_list1.ReadOnly = False
        Me.g_list1.RowHeight = -1
        Me.g_list1.Size = New System.Drawing.Size(528, 351)
        Me.g_list1.TabIndex = 2
        '
        'color_g
        '
        Me.color_g.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.color_g.Location = New System.Drawing.Point(326, 201)
        Me.color_g.Name = "color_g"
        Me.color_g.Size = New System.Drawing.Size(141, 21)
        Me.color_g.TabIndex = 199
        Me.color_g.Title = "색상 RGB값"
        Me.color_g.TitleWidth = 98
        '
        'color_b
        '
        Me.color_b.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.color_b.Location = New System.Drawing.Point(371, 201)
        Me.color_b.Name = "color_b"
        Me.color_b.Size = New System.Drawing.Size(141, 21)
        Me.color_b.TabIndex = 200
        Me.color_b.Title = "색상 RGB값"
        Me.color_b.TitleWidth = 98
        '
        'WI_CO1200
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_CO1200"
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
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents find_jagu_cd As Frame7.eCombo
    Friend WithEvents find_gd_nm As Frame7.eText
    Friend WithEvents find_gd_cd As Frame7.eText
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents price As Frame7.eText
    Friend WithEvents inspect_cd As Frame7.eCombo
    Friend WithEvents jas_cd As Frame7.eCombo
    Friend WithEvents jam_cd As Frame7.eCombo
    Friend WithEvents jal_cd As Frame7.eCombo
    Friend WithEvents jo_cd As Frame7.eCombo
    Friend WithEvents mate_cd As Frame7.eCombo
    Friend WithEvents gd_gu As Frame7.eCombo
    Friend WithEvents jagu_cd As Frame7.eCombo
    Friend WithEvents unit_cd As Frame7.eCombo
    Friend WithEvents stts As Frame7.eOptionBox
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents gd_enm As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents gp_cd As Frame7.eOptionBox
    Friend WithEvents model_no As Frame7.eCombo
    Friend WithEvents jo_gu As Frame7.eOptionBox
    Friend WithEvents stock_gu As Frame7.eOptionBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents img As Frame7.eImage
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list1 As Frame7.eGrid
    Friend WithEvents help_gu As Frame7.eCombo
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sale_cd As Frame7.eCombo
    Friend WithEvents find_help_gu As Frame7.eCombo
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents color_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents color_r As Frame7.eText
    Friend WithEvents color_g As Frame7.eText
    Friend WithEvents color_b As Frame7.eText
End Class
