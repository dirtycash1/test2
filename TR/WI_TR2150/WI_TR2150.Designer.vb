<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_TR2150
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
        Me.find_from = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_stts = New Frame7.eCombo()
        Me.find_to = New Frame7.eDate()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.bi_hapamt = New Frame7.ePanel()
        Me.sa_cd = New Frame7.eCombo()
        Me.bi_csnm = New Frame7.eText()
        Me.bi_cscd = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.bl_amt = New Frame7.eText()
        Me.inv_no = New Frame7.eText()
        Me.sl_no = New Frame7.eText()
        Me.ac_nm = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.ac_no = New Frame7.eText()
        Me.ac_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.gu = New Frame7.eText()
        Me.prepay_amt = New Frame7.eText()
        Me.misu_amt = New Frame7.eText()
        Me.daeche_amt = New Frame7.eText()
        Me.sl_gu = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.bl_no = New Frame7.eText()
        Me.bi_no = New Frame7.eText()
        Me.bi_amt = New Frame7.eText()
        Me.bungae_stts = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.bi_hap = New Frame7.eText()
        Me.sb_1 = New DevExpress.XtraEditors.SimpleButton()
        Me.pl_nm = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.ac_dt = New Frame7.eDate()
        Me.bi_amt1 = New Frame7.eText()
        Me.bi_dt = New Frame7.eDate()
        Me.close_gu = New Frame7.eOptionBox()
        Me.bungae_no = New Frame7.eText()
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
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.bi_hapamt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bi_hapamt.SuspendLayout()
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
        Me.spc_1.Size = New System.Drawing.Size(1450, 611)
        Me.spc_1.SplitterDistance = 408
        Me.spc_1.TabIndex = 4
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(408, 611)
        Me.tab1.TabIndex = 53
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer1)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(401, 581)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(401, 581)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.find_from)
        Me.Panel2.Controls.Add(Me.find_cs_nm)
        Me.Panel2.Controls.Add(Me.find_stts)
        Me.Panel2.Controls.Add(Me.find_to)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 146)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(307, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(92, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(11, 22)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(160, 21)
        Me.find_from.TabIndex = 90
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(11, 46)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(295, 21)
        Me.find_cs_nm.TabIndex = 93
        Me.find_cs_nm.Title = "거래처"
        Me.find_cs_nm.TitleWidth = 60
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(11, 70)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(160, 21)
        Me.find_stts.TabIndex = 97
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 60
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(177, 22)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(129, 21)
        Me.find_to.TabIndex = 105
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 20
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(401, 431)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.bi_hapamt)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(1038, 611)
        Me.SplitContainer2.SplitterDistance = 113
        Me.SplitContainer2.TabIndex = 0
        '
        'bi_hapamt
        '
        Me.bi_hapamt.Controls.Add(Me.bi_csnm)
        Me.bi_hapamt.Controls.Add(Me.bi_cscd)
        Me.bi_hapamt.Controls.Add(Me.sl_no)
        Me.bi_hapamt.Controls.Add(Me.stts)
        Me.bi_hapamt.Controls.Add(Me.ac_nm)
        Me.bi_hapamt.Controls.Add(Me.inv_no)
        Me.bi_hapamt.Controls.Add(Me.ac_no)
        Me.bi_hapamt.Controls.Add(Me.sa_cd)
        Me.bi_hapamt.Controls.Add(Me.ac_cd)
        Me.bi_hapamt.Controls.Add(Me.gu)
        Me.bi_hapamt.Controls.Add(Me.bl_amt)
        Me.bi_hapamt.Controls.Add(Me.prepay_amt)
        Me.bi_hapamt.Controls.Add(Me.misu_amt)
        Me.bi_hapamt.Controls.Add(Me.daeche_amt)
        Me.bi_hapamt.Controls.Add(Me.cs_cd)
        Me.bi_hapamt.Controls.Add(Me.sl_gu)
        Me.bi_hapamt.Controls.Add(Me.cs_nm)
        Me.bi_hapamt.Controls.Add(Me.pl_cd)
        Me.bi_hapamt.Controls.Add(Me.remk)
        Me.bi_hapamt.Controls.Add(Me.bl_no)
        Me.bi_hapamt.Controls.Add(Me.bi_no)
        Me.bi_hapamt.Controls.Add(Me.bungae_stts)
        Me.bi_hapamt.Controls.Add(Me.sb_1)
        Me.bi_hapamt.Controls.Add(Me.ps_cd)
        Me.bi_hapamt.Controls.Add(Me.bi_amt)
        Me.bi_hapamt.Controls.Add(Me.pl_nm)
        Me.bi_hapamt.Controls.Add(Me.ac_dt)
        Me.bi_hapamt.Controls.Add(Me.bi_dt)
        Me.bi_hapamt.Controls.Add(Me.ps_nm)
        Me.bi_hapamt.Controls.Add(Me.close_gu)
        Me.bi_hapamt.Controls.Add(Me.bungae_no)
        Me.bi_hapamt.Controls.Add(Me.bi_amt1)
        Me.bi_hapamt.Controls.Add(Me.bi_hap)
        Me.bi_hapamt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bi_hapamt.Location = New System.Drawing.Point(0, 0)
        Me.bi_hapamt.Name = "bi_hapamt"
        Me.bi_hapamt.Size = New System.Drawing.Size(1038, 113)
        Me.bi_hapamt.TabIndex = 1
        Me.bi_hapamt.Text = "     비용등록"
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(735, 78)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(206, 21)
        Me.sa_cd.TabIndex = 97
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 80
        '
        'bi_csnm
        '
        Me.bi_csnm.ColumnName = "find_paymenterm_cd"
        Me.bi_csnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_csnm.Location = New System.Drawing.Point(208, 178)
        Me.bi_csnm.Name = "bi_csnm"
        Me.bi_csnm.Size = New System.Drawing.Size(261, 21)
        Me.bi_csnm.TabIndex = 95
        Me.bi_csnm.TableName = "find_paymenterm_cd"
        Me.bi_csnm.Title = "cs_nm"
        Me.bi_csnm.TitleWidth = 0
        '
        'bi_cscd
        '
        Me.bi_cscd.ColumnName = "find_paymenterm_cd"
        Me.bi_cscd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_cscd.Location = New System.Drawing.Point(13, 178)
        Me.bi_cscd.Name = "bi_cscd"
        Me.bi_cscd.Size = New System.Drawing.Size(193, 21)
        Me.bi_cscd.TabIndex = 94
        Me.bi_cscd.TableName = "find_paymenterm_cd"
        Me.bi_cscd.Title = "정산거래처"
        Me.bi_cscd.TitleWidth = 98
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(735, 54)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(206, 21)
        Me.stts.TabIndex = 96
        Me.stts.Title = "상태"
        Me.stts.TitleWidth = 80
        '
        'bl_amt
        '
        Me.bl_amt.ColumnName = "find_paymenterm_cd"
        Me.bl_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bl_amt.Location = New System.Drawing.Point(252, 54)
        Me.bl_amt.Name = "bl_amt"
        Me.bl_amt.Size = New System.Drawing.Size(235, 21)
        Me.bl_amt.TabIndex = 93
        Me.bl_amt.TableName = "find_paymenterm_cd"
        Me.bl_amt.Title = "Invoice 금액"
        Me.bl_amt.TitleWidth = 80
        '
        'inv_no
        '
        Me.inv_no.ColumnName = "find_paymenterm_cd"
        Me.inv_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.inv_no.Location = New System.Drawing.Point(13, 54)
        Me.inv_no.Name = "inv_no"
        Me.inv_no.Size = New System.Drawing.Size(211, 21)
        Me.inv_no.TabIndex = 92
        Me.inv_no.TableName = "find_paymenterm_cd"
        Me.inv_no.Title = "Invoice No"
        Me.inv_no.TitleWidth = 80
        '
        'sl_no
        '
        Me.sl_no.ColumnName = "find_paymenterm_cd"
        Me.sl_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sl_no.Location = New System.Drawing.Point(260, 408)
        Me.sl_no.Name = "sl_no"
        Me.sl_no.Size = New System.Drawing.Size(225, 21)
        Me.sl_no.TabIndex = 90
        Me.sl_no.TableName = "find_paymenterm_cd"
        Me.sl_no.Title = "sl_no"
        Me.sl_no.TitleWidth = 98
        '
        'ac_nm
        '
        Me.ac_nm.ColumnName = "find_paymenterm_cd"
        Me.ac_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_nm.Location = New System.Drawing.Point(260, 381)
        Me.ac_nm.Name = "ac_nm"
        Me.ac_nm.Size = New System.Drawing.Size(225, 21)
        Me.ac_nm.TabIndex = 89
        Me.ac_nm.TableName = "find_paymenterm_cd"
        Me.ac_nm.Title = "ac_nm"
        Me.ac_nm.TitleWidth = 98
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_paymenterm_cd"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(172, 78)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(315, 21)
        Me.cs_nm.TabIndex = 91
        Me.cs_nm.TableName = "find_paymenterm_cd"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'ac_no
        '
        Me.ac_no.ColumnName = "find_paymenterm_cd"
        Me.ac_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_no.Location = New System.Drawing.Point(260, 354)
        Me.ac_no.Name = "ac_no"
        Me.ac_no.Size = New System.Drawing.Size(225, 21)
        Me.ac_no.TabIndex = 88
        Me.ac_no.TableName = "find_paymenterm_cd"
        Me.ac_no.Title = "ac_no"
        Me.ac_no.TitleWidth = 98
        '
        'ac_cd
        '
        Me.ac_cd.ColumnName = "find_paymenterm_cd"
        Me.ac_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_cd.Location = New System.Drawing.Point(260, 327)
        Me.ac_cd.Name = "ac_cd"
        Me.ac_cd.Size = New System.Drawing.Size(225, 21)
        Me.ac_cd.TabIndex = 87
        Me.ac_cd.TableName = "find_paymenterm_cd"
        Me.ac_cd.Title = "ac_cd"
        Me.ac_cd.TitleWidth = 98
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(13, 78)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(156, 21)
        Me.cs_cd.TabIndex = 86
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "cs_cd"
        Me.cs_cd.TitleWidth = 80
        '
        'gu
        '
        Me.gu.ColumnName = "find_paymenterm_cd"
        Me.gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gu.Location = New System.Drawing.Point(260, 273)
        Me.gu.Name = "gu"
        Me.gu.Size = New System.Drawing.Size(225, 21)
        Me.gu.TabIndex = 85
        Me.gu.TableName = "find_paymenterm_cd"
        Me.gu.Title = "gu"
        Me.gu.TitleWidth = 98
        '
        'prepay_amt
        '
        Me.prepay_amt.ColumnName = "find_paymenterm_cd"
        Me.prepay_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prepay_amt.Location = New System.Drawing.Point(374, 232)
        Me.prepay_amt.Name = "prepay_amt"
        Me.prepay_amt.Size = New System.Drawing.Size(190, 21)
        Me.prepay_amt.TabIndex = 84
        Me.prepay_amt.TableName = "find_paymenterm_cd"
        Me.prepay_amt.Title = "선급금"
        Me.prepay_amt.TitleWidth = 68
        '
        'misu_amt
        '
        Me.misu_amt.ColumnName = "find_paymenterm_cd"
        Me.misu_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.misu_amt.Location = New System.Drawing.Point(792, 232)
        Me.misu_amt.Name = "misu_amt"
        Me.misu_amt.Size = New System.Drawing.Size(225, 21)
        Me.misu_amt.TabIndex = 82
        Me.misu_amt.TableName = "find_paymenterm_cd"
        Me.misu_amt.Title = "미지급금"
        Me.misu_amt.TitleWidth = 98
        '
        'daeche_amt
        '
        Me.daeche_amt.ColumnName = "find_paymenterm_cd"
        Me.daeche_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.daeche_amt.Location = New System.Drawing.Point(578, 232)
        Me.daeche_amt.Name = "daeche_amt"
        Me.daeche_amt.Size = New System.Drawing.Size(191, 21)
        Me.daeche_amt.TabIndex = 81
        Me.daeche_amt.TableName = "find_paymenterm_cd"
        Me.daeche_amt.Title = "선급금대체"
        Me.daeche_amt.TitleWidth = 78
        '
        'sl_gu
        '
        Me.sl_gu.ColumnName = "find_paymenterm_cd"
        Me.sl_gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sl_gu.Location = New System.Drawing.Point(29, 354)
        Me.sl_gu.Name = "sl_gu"
        Me.sl_gu.Size = New System.Drawing.Size(225, 21)
        Me.sl_gu.TabIndex = 80
        Me.sl_gu.TableName = "find_paymenterm_cd"
        Me.sl_gu.Title = "sl_gu"
        Me.sl_gu.TitleWidth = 98
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_paymenterm_cd"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(29, 300)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(225, 21)
        Me.pl_cd.TabIndex = 78
        Me.pl_cd.TableName = "find_paymenterm_cd"
        Me.pl_cd.Title = "pl_cd"
        Me.pl_cd.TitleWidth = 98
        '
        'remk
        '
        Me.remk.ColumnName = "find_paymenterm_cd"
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(29, 246)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(225, 21)
        Me.remk.TabIndex = 75
        Me.remk.TableName = "find_paymenterm_cd"
        Me.remk.Title = "remk"
        Me.remk.TitleWidth = 98
        '
        'bl_no
        '
        Me.bl_no.ColumnName = "find_paymenterm_cd"
        Me.bl_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bl_no.Location = New System.Drawing.Point(640, 156)
        Me.bl_no.Name = "bl_no"
        Me.bl_no.Size = New System.Drawing.Size(142, 21)
        Me.bl_no.TabIndex = 76
        Me.bl_no.TableName = "find_paymenterm_cd"
        Me.bl_no.Title = "bl_no"
        Me.bl_no.TitleWidth = 98
        '
        'bi_no
        '
        Me.bi_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_no.Location = New System.Drawing.Point(13, 30)
        Me.bi_no.Name = "bi_no"
        Me.bi_no.Size = New System.Drawing.Size(211, 21)
        Me.bi_no.TabIndex = 50
        Me.bi_no.Title = "비용번호1"
        Me.bi_no.TitleWidth = 80
        '
        'bi_amt
        '
        Me.bi_amt.ColumnName = "find_paymenterm_cd"
        Me.bi_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_amt.Location = New System.Drawing.Point(502, 30)
        Me.bi_amt.Name = "bi_amt"
        Me.bi_amt.Size = New System.Drawing.Size(215, 21)
        Me.bi_amt.TabIndex = 60
        Me.bi_amt.TableName = "find_paymenterm_cd"
        Me.bi_amt.Title = "금액1"
        Me.bi_amt.TitleWidth = 80
        '
        'bungae_stts
        '
        Me.bungae_stts.ColumnName = "find_paymenterm_cd"
        Me.bungae_stts.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_stts.Location = New System.Drawing.Point(788, 156)
        Me.bungae_stts.Name = "bungae_stts"
        Me.bungae_stts.Size = New System.Drawing.Size(117, 21)
        Me.bungae_stts.TabIndex = 74
        Me.bungae_stts.TableName = "find_paymenterm_cd"
        Me.bungae_stts.Title = "회계전표"
        Me.bungae_stts.TitleWidth = 0
        Me.bungae_stts.Visible = False
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(252, 30)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(151, 21)
        Me.ps_cd.TabIndex = 55
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "담당자1"
        Me.ps_cd.TitleWidth = 80
        '
        'bi_hap
        '
        Me.bi_hap.ColumnName = "find_paymenterm_cd"
        Me.bi_hap.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_hap.Location = New System.Drawing.Point(502, 78)
        Me.bi_hap.Name = "bi_hap"
        Me.bi_hap.Size = New System.Drawing.Size(215, 21)
        Me.bi_hap.TabIndex = 64
        Me.bi_hap.TableName = "find_paymenterm_cd"
        Me.bi_hap.Title = "합계1"
        Me.bi_hap.TitleWidth = 80
        '
        'sb_1
        '
        Me.sb_1.Location = New System.Drawing.Point(923, 156)
        Me.sb_1.Name = "sb_1"
        Me.sb_1.Size = New System.Drawing.Size(110, 27)
        Me.sb_1.TabIndex = 73
        Me.sb_1.Text = "회계전표보기"
        Me.sb_1.Visible = False
        '
        'pl_nm
        '
        Me.pl_nm.ColumnName = "find_stts"
        Me.pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_nm.Location = New System.Drawing.Point(992, 25)
        Me.pl_nm.Name = "pl_nm"
        Me.pl_nm.Size = New System.Drawing.Size(27, 21)
        Me.pl_nm.TabIndex = 57
        Me.pl_nm.TableName = "find_stts"
        Me.pl_nm.Title = "비 고"
        Me.pl_nm.TitleWidth = 0
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(405, 30)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(82, 21)
        Me.ps_nm.TabIndex = 54
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "비 고"
        Me.ps_nm.TitleWidth = 0
        '
        'ac_dt
        '
        Me.ac_dt.Location = New System.Drawing.Point(429, 154)
        Me.ac_dt.Name = "ac_dt"
        Me.ac_dt.Size = New System.Drawing.Size(191, 21)
        Me.ac_dt.TabIndex = 53
        Me.ac_dt.Title = "확인일1"
        Me.ac_dt.TitleWidth = 78
        '
        'bi_amt1
        '
        Me.bi_amt1.ColumnName = "find_paymenterm_cd"
        Me.bi_amt1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bi_amt1.Location = New System.Drawing.Point(502, 54)
        Me.bi_amt1.Name = "bi_amt1"
        Me.bi_amt1.Size = New System.Drawing.Size(215, 21)
        Me.bi_amt1.TabIndex = 61
        Me.bi_amt1.TableName = "find_paymenterm_cd"
        Me.bi_amt1.Title = "세액1"
        Me.bi_amt1.TitleWidth = 80
        '
        'bi_dt
        '
        Me.bi_dt.Location = New System.Drawing.Point(735, 30)
        Me.bi_dt.Name = "bi_dt"
        Me.bi_dt.Size = New System.Drawing.Size(206, 21)
        Me.bi_dt.TabIndex = 52
        Me.bi_dt.Title = "등록일1"
        Me.bi_dt.TitleWidth = 80
        '
        'close_gu
        '
        Me.close_gu.Location = New System.Drawing.Point(954, 67)
        Me.close_gu.Name = "close_gu"
        Me.close_gu.SelectedIndex = -1
        Me.close_gu.Size = New System.Drawing.Size(118, 23)
        Me.close_gu.TabIndex = 65
        Me.close_gu.Title = "완료구분1"
        Me.close_gu.TitleWidth = 98
        '
        'bungae_no
        '
        Me.bungae_no.ColumnName = "find_paymenterm_cd"
        Me.bungae_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_no.Location = New System.Drawing.Point(958, 84)
        Me.bungae_no.Name = "bungae_no"
        Me.bungae_no.Size = New System.Drawing.Size(149, 21)
        Me.bungae_no.TabIndex = 63
        Me.bungae_no.TableName = "find_paymenterm_cd"
        Me.bungae_no.Title = "회계전표1"
        Me.bungae_no.TitleWidth = 98
        Me.bungae_no.Visible = False
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(1038, 494)
        Me.g_body.TabIndex = 0
        '
        'WI_TR2150
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_TR2150"
        Me.Size = New System.Drawing.Size(1450, 611)
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
        CType(Me.bi_hapamt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bi_hapamt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents bi_hapamt As Frame7.ePanel
    Friend WithEvents bungae_no As Frame7.eText
    Friend WithEvents bi_amt1 As Frame7.eText
    Friend WithEvents bi_amt As Frame7.eText
    Friend WithEvents pl_nm As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ac_dt As Frame7.eDate
    Friend WithEvents bi_dt As Frame7.eDate
    Friend WithEvents bi_no As Frame7.eText
    Friend WithEvents bi_hap As Frame7.eText
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents close_gu As Frame7.eOptionBox
    Friend WithEvents sb_1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bungae_stts As Frame7.eText
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents bl_no As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents sl_gu As Frame7.eText
    Friend WithEvents daeche_amt As Frame7.eText
    Friend WithEvents misu_amt As Frame7.eText
    Friend WithEvents prepay_amt As Frame7.eText
    Friend WithEvents gu As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents ac_cd As Frame7.eText
    Friend WithEvents ac_no As Frame7.eText
    Friend WithEvents ac_nm As Frame7.eText
    Friend WithEvents sl_no As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents bi_csnm As Frame7.eText
    Friend WithEvents bi_cscd As Frame7.eText
    Friend WithEvents bl_amt As Frame7.eText
    Friend WithEvents inv_no As Frame7.eText
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents sa_cd As Frame7.eCombo

End Class
