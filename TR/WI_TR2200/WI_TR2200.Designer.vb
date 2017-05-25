<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_TR2200
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
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
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
        Me.find_cur_cd = New Frame7.eCombo()
        Me.find_to = New Frame7.eDate()
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
        Me.find_cs_nm2 = New Frame7.eText()
        Me.g_list2 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.epael = New Frame7.ePanel()
        Me.ot_gu = New Frame7.eText()
        Me.singo_nm = New Frame7.eCombo()
        Me.ac_gu = New Frame7.eCombo()
        Me.sa_cd = New Frame7.eText()
        Me.saeobjang_cd = New Frame7.eText()
        Me.tax_no = New Frame7.eText()
        Me.odgu_cd = New Frame7.eCombo()
        Me.bl_dt = New Frame7.eDate()
        Me.sebal_no = New Frame7.eText()
        Me.slno = New Frame7.eText()
        Me.rate = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.kwase_amtw = New Frame7.eText()
        Me.invoice_dt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.ot_no = New Frame7.eText()
        Me.ot_amt = New Frame7.eText()
        Me.bungae_stts = New Frame7.eText()
        Me.bungae_no = New Frame7.eText()
        Me.singo_no = New Frame7.eText()
        Me.hs_no = New Frame7.eText()
        Me.singo_dt = New Frame7.eDate()
        Me.cur_cd = New Frame7.eCombo()
        Me.g_body = New Frame7.eGrid()
        Me.file_nm = New Frame7.eCombo()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tp2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.epael, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.epael.SuspendLayout()
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
        Me.spc_1.SplitterDistance = 333
        Me.spc_1.TabIndex = 4
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(333, 611)
        Me.tab1.TabIndex = 50
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1, Me.tp2})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer1)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(326, 581)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(326, 581)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.find_from)
        Me.Panel2.Controls.Add(Me.find_cs_nm)
        Me.Panel2.Controls.Add(Me.find_cur_cd)
        Me.Panel2.Controls.Add(Me.find_to)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 190)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(232, 0)
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
        Me.find_cs_nm.Location = New System.Drawing.Point(11, 79)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(295, 21)
        Me.find_cs_nm.TabIndex = 93
        Me.find_cs_nm.Title = "거래처"
        Me.find_cs_nm.TitleWidth = 60
        '
        'find_cur_cd
        '
        Me.find_cur_cd.Location = New System.Drawing.Point(11, 50)
        Me.find_cur_cd.Name = "find_cur_cd"
        Me.find_cur_cd.Size = New System.Drawing.Size(295, 21)
        Me.find_cur_cd.TabIndex = 92
        Me.find_cur_cd.Title = "화폐"
        Me.find_cur_cd.TitleWidth = 60
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
        Me.g_list.Size = New System.Drawing.Size(326, 387)
        Me.g_list.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.SplitContainer4)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(326, 581)
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
        Me.SplitContainer4.Size = New System.Drawing.Size(326, 581)
        Me.SplitContainer4.SplitterDistance = 190
        Me.SplitContainer4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.find_to2)
        Me.Panel3.Controls.Add(Me.find_from2)
        Me.Panel3.Controls.Add(Me.find_cs_nm2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 190)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_cancel2)
        Me.Panel4.Controls.Add(Me.btn_find2)
        Me.Panel4.Controls.Add(Me.find_visible2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 41)
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
        Me.find_visible2.Location = New System.Drawing.Point(232, 0)
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
        'find_cs_nm2
        '
        Me.find_cs_nm2.ColumnName = "find_paymenterm_cd"
        Me.find_cs_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm2.Location = New System.Drawing.Point(25, 58)
        Me.find_cs_nm2.Name = "find_cs_nm2"
        Me.find_cs_nm2.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm2.TabIndex = 48
        Me.find_cs_nm2.TableName = "find_paymenterm_cd"
        Me.find_cs_nm2.Title = "거래처명"
        Me.find_cs_nm2.TitleWidth = 60
        '
        'g_list2
        '
        Me.g_list2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list2.Location = New System.Drawing.Point(0, 0)
        Me.g_list2.Name = "g_list2"
        Me.g_list2.ReadOnly = False
        Me.g_list2.RowHeight = -1
        Me.g_list2.Size = New System.Drawing.Size(326, 387)
        Me.g_list2.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.epael)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(845, 611)
        Me.SplitContainer2.SplitterDistance = 161
        Me.SplitContainer2.TabIndex = 0
        '
        'epael
        '
        Me.epael.Controls.Add(Me.file_nm)
        Me.epael.Controls.Add(Me.ot_gu)
        Me.epael.Controls.Add(Me.singo_nm)
        Me.epael.Controls.Add(Me.ac_gu)
        Me.epael.Controls.Add(Me.sa_cd)
        Me.epael.Controls.Add(Me.saeobjang_cd)
        Me.epael.Controls.Add(Me.tax_no)
        Me.epael.Controls.Add(Me.odgu_cd)
        Me.epael.Controls.Add(Me.bl_dt)
        Me.epael.Controls.Add(Me.sebal_no)
        Me.epael.Controls.Add(Me.slno)
        Me.epael.Controls.Add(Me.rate)
        Me.epael.Controls.Add(Me.cs_cd)
        Me.epael.Controls.Add(Me.LabelControl3)
        Me.epael.Controls.Add(Me.kwase_amtw)
        Me.epael.Controls.Add(Me.invoice_dt)
        Me.epael.Controls.Add(Me.cs_nm)
        Me.epael.Controls.Add(Me.ot_no)
        Me.epael.Controls.Add(Me.ot_amt)
        Me.epael.Controls.Add(Me.bungae_stts)
        Me.epael.Controls.Add(Me.bungae_no)
        Me.epael.Controls.Add(Me.singo_no)
        Me.epael.Controls.Add(Me.hs_no)
        Me.epael.Controls.Add(Me.singo_dt)
        Me.epael.Controls.Add(Me.cur_cd)
        Me.epael.Dock = System.Windows.Forms.DockStyle.Fill
        Me.epael.Location = New System.Drawing.Point(0, 0)
        Me.epael.Name = "epael"
        Me.epael.Size = New System.Drawing.Size(845, 161)
        Me.epael.TabIndex = 0
        Me.epael.Text = "     수출신고서등록"
        '
        'ot_gu
        '
        Me.ot_gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_gu.Location = New System.Drawing.Point(226, 268)
        Me.ot_gu.Name = "ot_gu"
        Me.ot_gu.Size = New System.Drawing.Size(226, 21)
        Me.ot_gu.TabIndex = 125
        Me.ot_gu.Title = "ot_gu1"
        Me.ot_gu.TitleWidth = 98
        '
        'singo_nm
        '
        Me.singo_nm.Location = New System.Drawing.Point(657, 89)
        Me.singo_nm.Name = "singo_nm"
        Me.singo_nm.Size = New System.Drawing.Size(192, 21)
        Me.singo_nm.TabIndex = 131
        Me.singo_nm.Title = "신고자"
        Me.singo_nm.TitleWidth = 88
        '
        'ac_gu
        '
        Me.ac_gu.Location = New System.Drawing.Point(657, 116)
        Me.ac_gu.Name = "ac_gu"
        Me.ac_gu.Size = New System.Drawing.Size(192, 21)
        Me.ac_gu.TabIndex = 128
        Me.ac_gu.Title = "상태"
        Me.ac_gu.TitleWidth = 88
        '
        'sa_cd
        '
        Me.sa_cd.ColumnName = "find_paymenterm_cd"
        Me.sa_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sa_cd.Location = New System.Drawing.Point(446, 295)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(203, 21)
        Me.sa_cd.TabIndex = 124
        Me.sa_cd.TableName = "find_paymenterm_cd"
        Me.sa_cd.Title = "사업장1"
        Me.sa_cd.TitleWidth = 98
        '
        'saeobjang_cd
        '
        Me.saeobjang_cd.ColumnName = "find_paymenterm_cd"
        Me.saeobjang_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.saeobjang_cd.Location = New System.Drawing.Point(226, 295)
        Me.saeobjang_cd.Name = "saeobjang_cd"
        Me.saeobjang_cd.Size = New System.Drawing.Size(203, 21)
        Me.saeobjang_cd.TabIndex = 123
        Me.saeobjang_cd.TableName = "find_paymenterm_cd"
        Me.saeobjang_cd.Title = "사업장1"
        Me.saeobjang_cd.TitleWidth = 98
        '
        'tax_no
        '
        Me.tax_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_no.Location = New System.Drawing.Point(486, 235)
        Me.tax_no.Name = "tax_no"
        Me.tax_no.Size = New System.Drawing.Size(240, 21)
        Me.tax_no.TabIndex = 132
        Me.tax_no.Title = "fac100삭제용"
        Me.tax_no.TitleWidth = 100
        '
        'odgu_cd
        '
        Me.odgu_cd.Location = New System.Drawing.Point(5, 62)
        Me.odgu_cd.Name = "odgu_cd"
        Me.odgu_cd.Size = New System.Drawing.Size(200, 21)
        Me.odgu_cd.TabIndex = 129
        Me.odgu_cd.Title = "거래유형"
        Me.odgu_cd.TitleWidth = 80
        '
        'bl_dt
        '
        Me.bl_dt.Location = New System.Drawing.Point(5, 116)
        Me.bl_dt.Name = "bl_dt"
        Me.bl_dt.Size = New System.Drawing.Size(200, 21)
        Me.bl_dt.TabIndex = 9
        Me.bl_dt.Title = "선적일"
        Me.bl_dt.TitleWidth = 80
        '
        'sebal_no
        '
        Me.sebal_no.ColumnName = "find_paymenterm_cd"
        Me.sebal_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sebal_no.Location = New System.Drawing.Point(9, 268)
        Me.sebal_no.Name = "sebal_no"
        Me.sebal_no.Size = New System.Drawing.Size(203, 21)
        Me.sebal_no.TabIndex = 127
        Me.sebal_no.TableName = "find_paymenterm_cd"
        Me.sebal_no.Title = "sebal_no1"
        Me.sebal_no.TitleWidth = 98
        '
        'slno
        '
        Me.slno.ColumnName = "find_paymenterm_cd"
        Me.slno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slno.Location = New System.Drawing.Point(458, 268)
        Me.slno.Name = "slno"
        Me.slno.Size = New System.Drawing.Size(203, 21)
        Me.slno.TabIndex = 126
        Me.slno.TableName = "find_paymenterm_cd"
        Me.slno.Title = "slno1"
        Me.slno.TitleWidth = 98
        '
        'rate
        '
        Me.rate.ColumnName = "find_paymenterm_cd"
        Me.rate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rate.Location = New System.Drawing.Point(214, 116)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(203, 21)
        Me.rate.TabIndex = 10
        Me.rate.TableName = "find_paymenterm_cd"
        Me.rate.Title = "선적환율"
        Me.rate.TitleWidth = 98
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(214, 35)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(180, 21)
        Me.cs_cd.TabIndex = 1
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(416, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(208, 14)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "  → 수출매출 회계전표를 생성합니다. "
        '
        'kwase_amtw
        '
        Me.kwase_amtw.ColumnName = "find_paymenterm_cd"
        Me.kwase_amtw.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.kwase_amtw.Location = New System.Drawing.Point(446, 89)
        Me.kwase_amtw.Name = "kwase_amtw"
        Me.kwase_amtw.Size = New System.Drawing.Size(202, 21)
        Me.kwase_amtw.TabIndex = 8
        Me.kwase_amtw.TableName = "find_paymenterm_cd"
        Me.kwase_amtw.Title = "원화금액(\)"
        Me.kwase_amtw.TitleWidth = 98
        '
        'invoice_dt
        '
        Me.invoice_dt.Location = New System.Drawing.Point(657, 35)
        Me.invoice_dt.Name = "invoice_dt"
        Me.invoice_dt.Size = New System.Drawing.Size(192, 21)
        Me.invoice_dt.TabIndex = 121
        Me.invoice_dt.Title = "Invoice Date"
        Me.invoice_dt.TitleWidth = 88
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(396, 35)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(252, 21)
        Me.cs_nm.TabIndex = 2
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "비 고"
        Me.cs_nm.TitleWidth = 0
        '
        'ot_no
        '
        Me.ot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_no.Location = New System.Drawing.Point(5, 35)
        Me.ot_no.Name = "ot_no"
        Me.ot_no.Size = New System.Drawing.Size(200, 21)
        Me.ot_no.TabIndex = 0
        Me.ot_no.Title = "Invoice  No."
        Me.ot_no.TitleWidth = 80
        '
        'ot_amt
        '
        Me.ot_amt.ColumnName = "find_paymenterm_cd"
        Me.ot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ot_amt.Location = New System.Drawing.Point(214, 89)
        Me.ot_amt.Name = "ot_amt"
        Me.ot_amt.Size = New System.Drawing.Size(203, 21)
        Me.ot_amt.TabIndex = 7
        Me.ot_amt.TableName = "find_paymenterm_cd"
        Me.ot_amt.Title = "Invoice Amount"
        Me.ot_amt.TitleWidth = 98
        '
        'bungae_stts
        '
        Me.bungae_stts.ColumnName = "find_stts"
        Me.bungae_stts.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_stts.Location = New System.Drawing.Point(892, 89)
        Me.bungae_stts.Name = "bungae_stts"
        Me.bungae_stts.Size = New System.Drawing.Size(111, 21)
        Me.bungae_stts.TabIndex = 16
        Me.bungae_stts.TableName = "find_stts"
        Me.bungae_stts.Title = "비 고"
        Me.bungae_stts.TitleWidth = 0
        '
        'bungae_no
        '
        Me.bungae_no.ColumnName = "find_paymenterm_cd"
        Me.bungae_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_no.Location = New System.Drawing.Point(668, 295)
        Me.bungae_no.Name = "bungae_no"
        Me.bungae_no.Size = New System.Drawing.Size(224, 21)
        Me.bungae_no.TabIndex = 17
        Me.bungae_no.TableName = "find_paymenterm_cd"
        Me.bungae_no.Title = "회계전표1"
        Me.bungae_no.TitleWidth = 98
        '
        'singo_no
        '
        Me.singo_no.ColumnName = "find_paymenterm_cd"
        Me.singo_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.singo_no.Location = New System.Drawing.Point(214, 62)
        Me.singo_no.Name = "singo_no"
        Me.singo_no.Size = New System.Drawing.Size(226, 21)
        Me.singo_no.TabIndex = 3
        Me.singo_no.TableName = "find_paymenterm_cd"
        Me.singo_no.Title = "신고번호"
        Me.singo_no.TitleWidth = 98
        '
        'hs_no
        '
        Me.hs_no.ColumnName = "find_paymenterm_cd"
        Me.hs_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.hs_no.Location = New System.Drawing.Point(9, 295)
        Me.hs_no.Name = "hs_no"
        Me.hs_no.Size = New System.Drawing.Size(202, 21)
        Me.hs_no.TabIndex = 5
        Me.hs_no.TableName = "find_paymenterm_cd"
        Me.hs_no.Title = "Hs No.1"
        Me.hs_no.TitleWidth = 98
        '
        'singo_dt
        '
        Me.singo_dt.Location = New System.Drawing.Point(657, 62)
        Me.singo_dt.Name = "singo_dt"
        Me.singo_dt.Size = New System.Drawing.Size(192, 21)
        Me.singo_dt.TabIndex = 15
        Me.singo_dt.Title = "신고일"
        Me.singo_dt.TitleWidth = 88
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(5, 89)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(200, 21)
        Me.cur_cd.TabIndex = 6
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 80
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(845, 446)
        Me.g_body.TabIndex = 0
        '
        'file_nm
        '
        Me.file_nm.Location = New System.Drawing.Point(446, 62)
        Me.file_nm.Name = "file_nm"
        Me.file_nm.Size = New System.Drawing.Size(202, 21)
        Me.file_nm.TabIndex = 133
        Me.file_nm.Title = "서류명"
        Me.file_nm.TitleWidth = 98
        '
        'WI_TR2200
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_TR2200"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.epael, System.ComponentModel.ISupportInitialize).EndInit()
        Me.epael.ResumeLayout(False)
        Me.epael.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents epael As Frame7.ePanel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rate As Frame7.eText
    Friend WithEvents kwase_amtw As Frame7.eText
    Friend WithEvents ot_amt As Frame7.eText
    Friend WithEvents hs_no As Frame7.eText
    Friend WithEvents singo_no As Frame7.eText
    Friend WithEvents ot_no As Frame7.eText
    Friend WithEvents singo_dt As Frame7.eDate
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents bungae_stts As Frame7.eText
    Friend WithEvents bungae_no As Frame7.eText
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents invoice_dt As Frame7.eDate
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_cur_cd As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents bl_dt As Frame7.eDate
    Friend WithEvents saeobjang_cd As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eText
    Friend WithEvents ot_gu As Frame7.eText
    Friend WithEvents slno As Frame7.eText
    Friend WithEvents sebal_no As Frame7.eText
    Friend WithEvents tp2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible2 As System.Windows.Forms.CheckBox
    Friend WithEvents find_to2 As Frame7.eDate
    Friend WithEvents find_from2 As Frame7.eDate
    Friend WithEvents find_cs_nm2 As Frame7.eText
    Friend WithEvents g_list2 As Frame7.eGrid
    Friend WithEvents ac_gu As Frame7.eCombo
    Friend WithEvents odgu_cd As Frame7.eCombo
    Friend WithEvents singo_nm As Frame7.eCombo
    Friend WithEvents tax_no As Frame7.eText
    Friend WithEvents file_nm As Frame7.eCombo
    ' Friend WithEvents CachedGAC120R1 As System7.CachedGAC120R

End Class
