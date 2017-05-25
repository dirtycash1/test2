<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_TR2170
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.ac_dt = New Frame7.eText()
        Me.slno = New Frame7.eText()
        Me.seonsu_gu = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.sale_amt = New Frame7.eText()
        Me.cl_dt = New Frame7.eText()
        Me.in_dt = New Frame7.eText()
        Me.ac_no = New Frame7.eText()
        Me.ga_amt = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.ip_no = New Frame7.eText()
        Me.rate = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.ip_dt = New Frame7.eDate()
        Me.pre_amt = New Frame7.eText()
        Me.ac_gu = New Frame7.eText()
        Me.pl_nm = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.cur_cd = New Frame7.eCombo()
        Me.bungae_stts = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.bungae_no = New Frame7.eText()
        Me.won_amt = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g_body = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.g_body3 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g_body2 = New Frame7.eGrid()
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.tab1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tp1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
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
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(908, 864)
        Me.SplitContainer2.SplitterDistance = 150
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ac_dt)
        Me.EPanel1.Controls.Add(Me.slno)
        Me.EPanel1.Controls.Add(Me.seonsu_gu)
        Me.EPanel1.Controls.Add(Me.stts1)
        Me.EPanel1.Controls.Add(Me.sale_amt)
        Me.EPanel1.Controls.Add(Me.cl_dt)
        Me.EPanel1.Controls.Add(Me.in_dt)
        Me.EPanel1.Controls.Add(Me.ac_no)
        Me.EPanel1.Controls.Add(Me.ga_amt)
        Me.EPanel1.Controls.Add(Me.pl_cd)
        Me.EPanel1.Controls.Add(Me.ip_no)
        Me.EPanel1.Controls.Add(Me.rate)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.ip_dt)
        Me.EPanel1.Controls.Add(Me.pre_amt)
        Me.EPanel1.Controls.Add(Me.ac_gu)
        Me.EPanel1.Controls.Add(Me.pl_nm)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.cur_cd)
        Me.EPanel1.Controls.Add(Me.bungae_stts)
        Me.EPanel1.Controls.Add(Me.tot_amt)
        Me.EPanel1.Controls.Add(Me.bungae_no)
        Me.EPanel1.Controls.Add(Me.won_amt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(908, 150)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     수금등록"
        '
        'ac_dt
        '
        Me.ac_dt.ColumnName = "find_stts"
        Me.ac_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_dt.Location = New System.Drawing.Point(582, 368)
        Me.ac_dt.Name = "ac_dt"
        Me.ac_dt.Size = New System.Drawing.Size(190, 21)
        Me.ac_dt.TabIndex = 86
        Me.ac_dt.TableName = "find_stts"
        Me.ac_dt.Title = "ac_dt"
        Me.ac_dt.TitleWidth = 98
        '
        'slno
        '
        Me.slno.ColumnName = "find_stts"
        Me.slno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.slno.Location = New System.Drawing.Point(582, 341)
        Me.slno.Name = "slno"
        Me.slno.Size = New System.Drawing.Size(190, 21)
        Me.slno.TabIndex = 85
        Me.slno.TableName = "find_stts"
        Me.slno.Title = "slno"
        Me.slno.TitleWidth = 98
        '
        'seonsu_gu
        '
        Me.seonsu_gu.ColumnName = "find_stts"
        Me.seonsu_gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seonsu_gu.Location = New System.Drawing.Point(582, 314)
        Me.seonsu_gu.Name = "seonsu_gu"
        Me.seonsu_gu.Size = New System.Drawing.Size(190, 21)
        Me.seonsu_gu.TabIndex = 84
        Me.seonsu_gu.TableName = "find_stts"
        Me.seonsu_gu.Title = "seonsu_gu"
        Me.seonsu_gu.TitleWidth = 98
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(833, 29)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(57, 21)
        Me.stts1.TabIndex = 88
        Me.stts1.Title = "stts1"
        Me.stts1.TitleWidth = 0
        '
        'sale_amt
        '
        Me.sale_amt.ColumnName = "find_stts"
        Me.sale_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_amt.Location = New System.Drawing.Point(853, 79)
        Me.sale_amt.Name = "sale_amt"
        Me.sale_amt.Size = New System.Drawing.Size(190, 21)
        Me.sale_amt.TabIndex = 87
        Me.sale_amt.TableName = "find_stts"
        Me.sale_amt.Title = "sale_amt"
        Me.sale_amt.TitleWidth = 98
        '
        'cl_dt
        '
        Me.cl_dt.ColumnName = "find_stts"
        Me.cl_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cl_dt.Location = New System.Drawing.Point(582, 260)
        Me.cl_dt.Name = "cl_dt"
        Me.cl_dt.Size = New System.Drawing.Size(190, 21)
        Me.cl_dt.TabIndex = 82
        Me.cl_dt.TableName = "find_stts"
        Me.cl_dt.Title = "cl_dt"
        Me.cl_dt.TitleWidth = 98
        '
        'in_dt
        '
        Me.in_dt.ColumnName = "find_stts"
        Me.in_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_dt.Location = New System.Drawing.Point(582, 233)
        Me.in_dt.Name = "in_dt"
        Me.in_dt.Size = New System.Drawing.Size(190, 21)
        Me.in_dt.TabIndex = 81
        Me.in_dt.TableName = "find_stts"
        Me.in_dt.Title = "in_dt"
        Me.in_dt.TitleWidth = 98
        '
        'ac_no
        '
        Me.ac_no.ColumnName = "find_stts"
        Me.ac_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_no.Location = New System.Drawing.Point(582, 206)
        Me.ac_no.Name = "ac_no"
        Me.ac_no.Size = New System.Drawing.Size(190, 21)
        Me.ac_no.TabIndex = 80
        Me.ac_no.TableName = "find_stts"
        Me.ac_no.Title = "ac_no"
        Me.ac_no.TitleWidth = 98
        '
        'ga_amt
        '
        Me.ga_amt.ColumnName = "find_stts"
        Me.ga_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ga_amt.Location = New System.Drawing.Point(582, 179)
        Me.ga_amt.Name = "ga_amt"
        Me.ga_amt.Size = New System.Drawing.Size(190, 21)
        Me.ga_amt.TabIndex = 79
        Me.ga_amt.TableName = "find_stts"
        Me.ga_amt.Title = "ga_amt"
        Me.ga_amt.TitleWidth = 98
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_stts"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(356, 314)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(190, 21)
        Me.pl_cd.TabIndex = 75
        Me.pl_cd.TableName = "find_stts"
        Me.pl_cd.Title = "pl_cd"
        Me.pl_cd.TitleWidth = 98
        '
        'ip_no
        '
        Me.ip_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ip_no.Location = New System.Drawing.Point(5, 29)
        Me.ip_no.Name = "ip_no"
        Me.ip_no.Size = New System.Drawing.Size(224, 21)
        Me.ip_no.TabIndex = 50
        Me.ip_no.Title = "전표번호1"
        Me.ip_no.TitleWidth = 98
        '
        'rate
        '
        Me.rate.ColumnName = "find_paymenterm_cd"
        Me.rate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rate.Location = New System.Drawing.Point(245, 79)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(156, 21)
        Me.rate.TabIndex = 76
        Me.rate.TableName = "find_paymenterm_cd"
        Me.rate.Title = "환율1"
        Me.rate.TitleWidth = 78
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_paymenterm_cd"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(245, 54)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(363, 21)
        Me.cs_nm.TabIndex = 70
        Me.cs_nm.TableName = "find_paymenterm_cd"
        Me.cs_nm.Title = "거래처명1"
        Me.cs_nm.TitleWidth = 78
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(5, 54)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(224, 21)
        Me.cs_cd.TabIndex = 66
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드1"
        Me.cs_cd.TitleWidth = 98
        '
        'ip_dt
        '
        Me.ip_dt.Location = New System.Drawing.Point(621, 29)
        Me.ip_dt.Name = "ip_dt"
        Me.ip_dt.Size = New System.Drawing.Size(187, 21)
        Me.ip_dt.TabIndex = 52
        Me.ip_dt.Title = "수금일자1"
        Me.ip_dt.TitleWidth = 98
        '
        'pre_amt
        '
        Me.pre_amt.ColumnName = "find_stts"
        Me.pre_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pre_amt.Location = New System.Drawing.Point(475, 192)
        Me.pre_amt.Name = "pre_amt"
        Me.pre_amt.Size = New System.Drawing.Size(190, 21)
        Me.pre_amt.TabIndex = 78
        Me.pre_amt.TableName = "find_stts"
        Me.pre_amt.Title = "pre_amt"
        Me.pre_amt.TitleWidth = 98
        '
        'ac_gu
        '
        Me.ac_gu.ColumnName = "find_stts"
        Me.ac_gu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ac_gu.Location = New System.Drawing.Point(475, 165)
        Me.ac_gu.Name = "ac_gu"
        Me.ac_gu.Size = New System.Drawing.Size(190, 21)
        Me.ac_gu.TabIndex = 77
        Me.ac_gu.TableName = "find_stts"
        Me.ac_gu.Title = "ac_gu"
        Me.ac_gu.TitleWidth = 98
        '
        'pl_nm
        '
        Me.pl_nm.ColumnName = "find_stts"
        Me.pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_nm.Location = New System.Drawing.Point(501, 29)
        Me.pl_nm.Name = "pl_nm"
        Me.pl_nm.Size = New System.Drawing.Size(107, 21)
        Me.pl_nm.TabIndex = 57
        Me.pl_nm.TableName = "find_stts"
        Me.pl_nm.Title = "비 고"
        Me.pl_nm.TitleWidth = 0
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(245, 29)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(166, 21)
        Me.ps_cd.TabIndex = 55
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "담당자1"
        Me.ps_cd.TitleWidth = 78
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(412, 29)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(88, 21)
        Me.ps_nm.TabIndex = 54
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "비 고"
        Me.ps_nm.TitleWidth = 0
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(5, 79)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(224, 21)
        Me.cur_cd.TabIndex = 67
        Me.cur_cd.Title = "화폐1"
        Me.cur_cd.TitleWidth = 98
        '
        'bungae_stts
        '
        Me.bungae_stts.ColumnName = "find_stts"
        Me.bungae_stts.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_stts.Location = New System.Drawing.Point(846, 52)
        Me.bungae_stts.Name = "bungae_stts"
        Me.bungae_stts.Size = New System.Drawing.Size(149, 21)
        Me.bungae_stts.TabIndex = 71
        Me.bungae_stts.TableName = "find_stts"
        Me.bungae_stts.Title = "비 고"
        Me.bungae_stts.TitleWidth = 0
        '
        'tot_amt
        '
        Me.tot_amt.ColumnName = "find_paymenterm_cd"
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(412, 79)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(196, 21)
        Me.tot_amt.TabIndex = 56
        Me.tot_amt.TableName = "find_paymenterm_cd"
        Me.tot_amt.Title = "입금금액합계1"
        Me.tot_amt.TitleWidth = 88
        '
        'bungae_no
        '
        Me.bungae_no.ColumnName = "find_paymenterm_cd"
        Me.bungae_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bungae_no.Location = New System.Drawing.Point(621, 52)
        Me.bungae_no.Name = "bungae_no"
        Me.bungae_no.Size = New System.Drawing.Size(224, 21)
        Me.bungae_no.TabIndex = 63
        Me.bungae_no.TableName = "find_paymenterm_cd"
        Me.bungae_no.Title = "회계전표1"
        Me.bungae_no.TitleWidth = 98
        '
        'won_amt
        '
        Me.won_amt.ColumnName = "find_paymenterm_cd"
        Me.won_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.won_amt.Location = New System.Drawing.Point(621, 79)
        Me.won_amt.Name = "won_amt"
        Me.won_amt.Size = New System.Drawing.Size(224, 21)
        Me.won_amt.TabIndex = 68
        Me.won_amt.TableName = "find_paymenterm_cd"
        Me.won_amt.Title = "원화총금액1"
        Me.won_amt.TitleWidth = 98
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(908, 710)
        Me.SplitContainer3.SplitterDistance = 215
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g_body)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(908, 215)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     입급내역"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(2, 23)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(904, 190)
        Me.g_body.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(908, 491)
        Me.XtraTabControl1.TabIndex = 6
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(901, 461)
        Me.XtraTabPage2.Text = "수주별수금내역"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.g_body3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(901, 461)
        Me.Panel4.TabIndex = 1
        '
        'g_body3
        '
        Me.g_body3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body3.Location = New System.Drawing.Point(0, 0)
        Me.g_body3.Name = "g_body3"
        Me.g_body3.ReadOnly = False
        Me.g_body3.RowHeight = -1
        Me.g_body3.Size = New System.Drawing.Size(901, 461)
        Me.g_body3.TabIndex = 2
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.AutoScroll = True
        Me.XtraTabPage3.Controls.Add(Me.g_body2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(901, 461)
        Me.XtraTabPage3.Text = "미수금내역"
        '
        'g_body2
        '
        Me.g_body2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body2.Location = New System.Drawing.Point(0, 0)
        Me.g_body2.Name = "g_body2"
        Me.g_body2.ReadOnly = False
        Me.g_body2.RowHeight = -1
        Me.g_body2.Size = New System.Drawing.Size(901, 461)
        Me.g_body2.TabIndex = 2
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
        Me.spc_1.Size = New System.Drawing.Size(1337, 864)
        Me.spc_1.SplitterDistance = 425
        Me.spc_1.TabIndex = 2
        '
        'tab1
        '
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedTabPage = Me.tp1
        Me.tab1.Size = New System.Drawing.Size(425, 864)
        Me.tab1.TabIndex = 54
        Me.tab1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.SplitContainer4)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(418, 834)
        Me.tp1.Text = "검색 조건"
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer4.Size = New System.Drawing.Size(418, 834)
        Me.SplitContainer4.SplitterDistance = 223
        Me.SplitContainer4.TabIndex = 2
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
        Me.Panel2.Size = New System.Drawing.Size(418, 223)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(324, 0)
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
        Me.find_cs_nm.Location = New System.Drawing.Point(11, 76)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(295, 21)
        Me.find_cs_nm.TabIndex = 93
        Me.find_cs_nm.Title = "거래처"
        Me.find_cs_nm.TitleWidth = 60
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(11, 49)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(295, 21)
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
        Me.g_list.Size = New System.Drawing.Size(418, 607)
        Me.g_list.TabIndex = 0
        '
        'WI_TR2170
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_TR2170"
        Me.Size = New System.Drawing.Size(1337, 864)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.tab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab1.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents bungae_stts As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents won_amt As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents pl_nm As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents bungae_no As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ip_no As Frame7.eText
    Friend WithEvents ip_dt As Frame7.eDate
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tab1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents g_body2 As Frame7.eGrid
    Friend WithEvents g_body3 As Frame7.eGrid
    Friend WithEvents rate As Frame7.eText
    Friend WithEvents ac_gu As Frame7.eText
    Friend WithEvents pre_amt As Frame7.eText
    Friend WithEvents ga_amt As Frame7.eText
    Friend WithEvents ac_no As Frame7.eText
    Friend WithEvents in_dt As Frame7.eText
    Friend WithEvents cl_dt As Frame7.eText
    Friend WithEvents seonsu_gu As Frame7.eText
    Friend WithEvents slno As Frame7.eText
    Friend WithEvents ac_dt As Frame7.eText
    Friend WithEvents sale_amt As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage

End Class
