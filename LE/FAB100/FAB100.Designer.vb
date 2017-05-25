<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB100
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.fr_dt = New Frame7.eDate()
        Me.f_dept_cd = New Frame7.eText()
        Me.f_dsc = New Frame7.eText()
        Me.f_div_cd = New Frame7.eCombo()
        Me.ECheck1 = New Frame7.eCheck()
        Me.f_stat_bc = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.acc_cd = New Frame7.eText()
        Me.title = New Frame7.eText()
        Me.doc_no = New Frame7.eText()
        Me.div_cd = New Frame7.eCombo()
        Me.doc_no2 = New Frame7.eText()
        Me.apr_no = New Frame7.eText()
        Me.doc_dt = New Frame7.eDate()
        Me.apr_no2 = New Frame7.eText()
        Me.btn_copy_new = New DevExpress.XtraEditors.SimpleButton()
        Me.doc_bc = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.doc_nm = New Frame7.eText()
        Me.doc_rid = New Frame7.eText()
        Me.stat_bc = New Frame7.eCombo()
        Me.btn_sample = New DevExpress.XtraEditors.SimpleButton()
        Me.dept_cd = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.btn_pay = New DevExpress.XtraEditors.SimpleButton()
        Me.apr_dt = New Frame7.eDate()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.apr_dt2 = New Frame7.eDate()
        Me.btn_apr = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.rem_amt = New Frame7.eText()
        Me.amt1 = New Frame7.eText()
        Me.btn_vat = New DevExpress.XtraEditors.SimpleButton()
        Me.diff = New Frame7.eText()
        Me.amt2 = New Frame7.eText()
        Me.diff2 = New Frame7.eText()
        Me.btn_paste_row = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_copy_row = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_show_bud = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.pnlMng = New Frame7.ePanel()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.pnlMng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMng.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1164, 756)
        Me.SplitContainer1.SplitterDistance = 84
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(84, 100)
        Me.SplitContainer2.SplitterDistance = 71
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.f_dept_cd)
        Me.EPanel1.Controls.Add(Me.f_dsc)
        Me.EPanel1.Controls.Add(Me.f_div_cd)
        Me.EPanel1.Controls.Add(Me.ECheck1)
        Me.EPanel1.Controls.Add(Me.f_stat_bc)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(84, 71)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "발의일자"
        '
        'f_dept_cd
        '
        Me.f_dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_dept_cd.Location = New System.Drawing.Point(12, 52)
        Me.f_dept_cd.Name = "f_dept_cd"
        Me.f_dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_dept_cd.TabIndex = 2
        Me.f_dept_cd.Title = "발의부서"
        '
        'f_dsc
        '
        Me.f_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_dsc.Location = New System.Drawing.Point(272, 52)
        Me.f_dsc.Name = "f_dsc"
        Me.f_dsc.Size = New System.Drawing.Size(240, 21)
        Me.f_dsc.TabIndex = 2
        Me.f_dsc.Title = "발의내용"
        '
        'f_div_cd
        '
        Me.f_div_cd.Location = New System.Drawing.Point(12, 28)
        Me.f_div_cd.Name = "f_div_cd"
        Me.f_div_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_div_cd.TabIndex = 3
        Me.f_div_cd.Title = "회계사업장"
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck1.Location = New System.Drawing.Point(532, 76)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(172, 21)
        Me.ECheck1.TabIndex = 4
        Me.ECheck1.Title = "Check"
        '
        'f_stat_bc
        '
        Me.f_stat_bc.Location = New System.Drawing.Point(272, 28)
        Me.f_stat_bc.Name = "f_stat_bc"
        Me.f_stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_stat_bc.TabIndex = 3
        Me.f_stat_bc.Title = "진행상태"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 5
        Me.to_dt.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(84, 25)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     전표 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(80, 0)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.pnlMng)
        Me.SplitContainer3.Size = New System.Drawing.Size(1164, 756)
        Me.SplitContainer3.SplitterDistance = 381
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer5.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainer5.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer5.Size = New System.Drawing.Size(1164, 381)
        Me.SplitContainer5.SplitterDistance = 127
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.acc_cd)
        Me.EPanel3.Controls.Add(Me.title)
        Me.EPanel3.Controls.Add(Me.doc_no)
        Me.EPanel3.Controls.Add(Me.div_cd)
        Me.EPanel3.Controls.Add(Me.doc_no2)
        Me.EPanel3.Controls.Add(Me.apr_no)
        Me.EPanel3.Controls.Add(Me.doc_dt)
        Me.EPanel3.Controls.Add(Me.apr_no2)
        Me.EPanel3.Controls.Add(Me.btn_copy_new)
        Me.EPanel3.Controls.Add(Me.doc_bc)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.doc_nm)
        Me.EPanel3.Controls.Add(Me.doc_rid)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Controls.Add(Me.btn_sample)
        Me.EPanel3.Controls.Add(Me.dept_cd)
        Me.EPanel3.Controls.Add(Me.co_cd)
        Me.EPanel3.Controls.Add(Me.btn_pay)
        Me.EPanel3.Controls.Add(Me.apr_dt)
        Me.EPanel3.Controls.Add(Me.btn_save)
        Me.EPanel3.Controls.Add(Me.apr_dt2)
        Me.EPanel3.Controls.Add(Me.btn_apr)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1164, 127)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     전표 등록"
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd.Location = New System.Drawing.Point(936, 5)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(52, 21)
        Me.acc_cd.TabIndex = 18
        Me.acc_cd.Title = "acc_cd"
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.title.Location = New System.Drawing.Point(12, 100)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(492, 21)
        Me.title.TabIndex = 2
        Me.title.Title = "발의내용"
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(264, 3)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 2
        Me.doc_no.Title = "전표번호"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 76)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 3
        Me.div_cd.Title = "회계사업장"
        '
        'doc_no2
        '
        Me.doc_no2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no2.Location = New System.Drawing.Point(12, 28)
        Me.doc_no2.Name = "doc_no2"
        Me.doc_no2.Size = New System.Drawing.Size(240, 21)
        Me.doc_no2.TabIndex = 2
        Me.doc_no2.Title = "전표번호"
        '
        'apr_no
        '
        Me.apr_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.apr_no.Location = New System.Drawing.Point(516, 5)
        Me.apr_no.Name = "apr_no"
        Me.apr_no.Size = New System.Drawing.Size(240, 21)
        Me.apr_no.TabIndex = 2
        Me.apr_no.Title = "승인번호"
        '
        'doc_dt
        '
        Me.doc_dt.Location = New System.Drawing.Point(264, 28)
        Me.doc_dt.Name = "doc_dt"
        Me.doc_dt.Size = New System.Drawing.Size(240, 21)
        Me.doc_dt.TabIndex = 5
        Me.doc_dt.Title = "발의일자"
        '
        'apr_no2
        '
        Me.apr_no2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.apr_no2.Location = New System.Drawing.Point(516, 100)
        Me.apr_no2.Name = "apr_no2"
        Me.apr_no2.Size = New System.Drawing.Size(240, 21)
        Me.apr_no2.TabIndex = 2
        Me.apr_no2.Title = "승인번호"
        '
        'btn_copy_new
        '
        Me.btn_copy_new.Location = New System.Drawing.Point(896, 97)
        Me.btn_copy_new.Name = "btn_copy_new"
        Me.btn_copy_new.Size = New System.Drawing.Size(112, 24)
        Me.btn_copy_new.TabIndex = 16
        Me.btn_copy_new.Text = "새전표로 복사"
        '
        'doc_bc
        '
        Me.doc_bc.Location = New System.Drawing.Point(264, 52)
        Me.doc_bc.Name = "doc_bc"
        Me.doc_bc.Size = New System.Drawing.Size(240, 21)
        Me.doc_bc.TabIndex = 3
        Me.doc_bc.Title = "전표구분"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(516, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 2
        Me.dept_nm.Title = "발의부서"
        '
        'doc_nm
        '
        Me.doc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_nm.Location = New System.Drawing.Point(516, 52)
        Me.doc_nm.Name = "doc_nm"
        Me.doc_nm.Size = New System.Drawing.Size(240, 21)
        Me.doc_nm.TabIndex = 2
        Me.doc_nm.Title = "발의자"
        '
        'doc_rid
        '
        Me.doc_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_rid.Location = New System.Drawing.Point(886, 5)
        Me.doc_rid.Name = "doc_rid"
        Me.doc_rid.Size = New System.Drawing.Size(44, 21)
        Me.doc_rid.TabIndex = 2
        Me.doc_rid.Title = "doc_rid"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(264, 76)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 3
        Me.stat_bc.Title = "진행상태"
        '
        'btn_sample
        '
        Me.btn_sample.Location = New System.Drawing.Point(896, 32)
        Me.btn_sample.Name = "btn_sample"
        Me.btn_sample.Size = New System.Drawing.Size(112, 24)
        Me.btn_sample.TabIndex = 15
        Me.btn_sample.Text = "유형전표 검색"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(828, 5)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(52, 21)
        Me.dept_cd.TabIndex = 2
        Me.dept_cd.Title = "dept_cd"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 52)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "법인"
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(768, 32)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(112, 24)
        Me.btn_pay.TabIndex = 17
        Me.btn_pay.Text = "미결전표 검색"
        '
        'apr_dt
        '
        Me.apr_dt.Location = New System.Drawing.Point(768, 100)
        Me.apr_dt.Name = "apr_dt"
        Me.apr_dt.Size = New System.Drawing.Size(112, 21)
        Me.apr_dt.TabIndex = 5
        Me.apr_dt.Title = "apr_dt"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(896, 67)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(112, 24)
        Me.btn_save.TabIndex = 16
        Me.btn_save.Text = "유형전표로 저장"
        '
        'apr_dt2
        '
        Me.apr_dt2.Location = New System.Drawing.Point(516, 76)
        Me.apr_dt2.Name = "apr_dt2"
        Me.apr_dt2.Size = New System.Drawing.Size(240, 21)
        Me.apr_dt2.TabIndex = 5
        Me.apr_dt2.Title = "회계일자"
        '
        'btn_apr
        '
        Me.btn_apr.Location = New System.Drawing.Point(768, 67)
        Me.btn_apr.Name = "btn_apr"
        Me.btn_apr.Size = New System.Drawing.Size(112, 24)
        Me.btn_apr.TabIndex = 16
        Me.btn_apr.Text = "전표 승인"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl1.Controls.Add(Me.rem_amt)
        Me.PanelControl1.Controls.Add(Me.amt1)
        Me.PanelControl1.Controls.Add(Me.btn_vat)
        Me.PanelControl1.Controls.Add(Me.diff)
        Me.PanelControl1.Controls.Add(Me.amt2)
        Me.PanelControl1.Controls.Add(Me.diff2)
        Me.PanelControl1.Controls.Add(Me.btn_paste_row)
        Me.PanelControl1.Controls.Add(Me.btn_copy_row)
        Me.PanelControl1.Controls.Add(Me.btn_show_bud)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1164, 32)
        Me.PanelControl1.TabIndex = 4
        '
        'rem_amt
        '
        Me.rem_amt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rem_amt.Location = New System.Drawing.Point(873, 7)
        Me.rem_amt.Name = "rem_amt"
        Me.rem_amt.Size = New System.Drawing.Size(220, 21)
        Me.rem_amt.TabIndex = 3
        Me.rem_amt.Title = "예산잔액"
        '
        'amt1
        '
        Me.amt1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.amt1.Location = New System.Drawing.Point(288, 7)
        Me.amt1.Name = "amt1"
        Me.amt1.Size = New System.Drawing.Size(176, 21)
        Me.amt1.TabIndex = 2
        Me.amt1.Title = "차변/대변"
        Me.amt1.TitleWidth = 82
        '
        'btn_vat
        '
        Me.btn_vat.Location = New System.Drawing.Point(164, 4)
        Me.btn_vat.Name = "btn_vat"
        Me.btn_vat.Size = New System.Drawing.Size(88, 24)
        Me.btn_vat.TabIndex = 18
        Me.btn_vat.Text = "부가세 생성"
        '
        'diff
        '
        Me.diff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.diff.Location = New System.Drawing.Point(576, 7)
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(184, 21)
        Me.diff.TabIndex = 2
        Me.diff.Title = "차이원화/외화"
        Me.diff.TitleWidth = 90
        '
        'amt2
        '
        Me.amt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.amt2.Location = New System.Drawing.Point(466, 7)
        Me.amt2.Name = "amt2"
        Me.amt2.Size = New System.Drawing.Size(92, 21)
        Me.amt2.TabIndex = 2
        Me.amt2.Title = "차변/대변"
        Me.amt2.TitleWidth = 0
        '
        'diff2
        '
        Me.diff2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.diff2.Location = New System.Drawing.Point(700, 7)
        Me.diff2.Name = "diff2"
        Me.diff2.Size = New System.Drawing.Size(152, 21)
        Me.diff2.TabIndex = 2
        Me.diff2.Title = "차이"
        Me.diff2.TitleWidth = 60
        '
        'btn_paste_row
        '
        Me.btn_paste_row.Location = New System.Drawing.Point(100, 4)
        Me.btn_paste_row.Name = "btn_paste_row"
        Me.btn_paste_row.Size = New System.Drawing.Size(60, 24)
        Me.btn_paste_row.TabIndex = 16
        Me.btn_paste_row.Text = "붙여넣기"
        '
        'btn_copy_row
        '
        Me.btn_copy_row.Location = New System.Drawing.Point(36, 4)
        Me.btn_copy_row.Name = "btn_copy_row"
        Me.btn_copy_row.Size = New System.Drawing.Size(60, 24)
        Me.btn_copy_row.TabIndex = 16
        Me.btn_copy_row.Text = "행복사"
        '
        'btn_show_bud
        '
        Me.btn_show_bud.Location = New System.Drawing.Point(1096, 4)
        Me.btn_show_bud.Name = "btn_show_bud"
        Me.btn_show_bud.Size = New System.Drawing.Size(36, 24)
        Me.btn_show_bud.TabIndex = 16
        Me.btn_show_bud.Text = "..."
        '
        'g20
        '
        Me.g20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g20.Location = New System.Drawing.Point(0, 32)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1164, 218)
        Me.g20.TabIndex = 0
        '
        'pnlMng
        '
        Me.pnlMng.Controls.Add(Me.pnl2)
        Me.pnlMng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMng.Location = New System.Drawing.Point(0, 0)
        Me.pnlMng.Name = "pnlMng"
        Me.pnlMng.Size = New System.Drawing.Size(1164, 371)
        Me.pnlMng.TabIndex = 0
        Me.pnlMng.Text = "     관리항목"
        '
        'pnl2
        '
        Me.pnl2.AutoScroll = True
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl2.Location = New System.Drawing.Point(2, 23)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(1160, 346)
        Me.pnl2.TabIndex = 3
        '
        'FAB100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB100"
        Me.Size = New System.Drawing.Size(1178, 788)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.pnlMng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMng.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents f_div_cd As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents f_dept_cd As Frame7.eText
    Friend WithEvents ECheck1 As Frame7.eCheck
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents amt1 As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents title As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents doc_dt As Frame7.eDate
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents f_stat_bc As Frame7.eCombo
    Friend WithEvents f_dsc As Frame7.eText
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents doc_bc As Frame7.eCombo
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents doc_rid As Frame7.eText
    Friend WithEvents diff As Frame7.eText
    Friend WithEvents amt2 As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents doc_nm As Frame7.eText
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents btn_pay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_sample As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rem_amt As Frame7.eText
    Friend WithEvents diff2 As Frame7.eText
    Friend WithEvents btn_apr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents apr_dt2 As Frame7.eDate
    Friend WithEvents btn_copy_row As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_copy_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents apr_dt As Frame7.eDate
    Friend WithEvents btn_vat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_paste_row As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_show_bud As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlMng As Frame7.ePanel
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents apr_no As Frame7.eText
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents doc_no2 As Frame7.eText
    Friend WithEvents apr_no2 As Frame7.eText

End Class
