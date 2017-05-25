<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1150
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
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.find_stts = New Frame7.eCombo()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.rrt_samt = New Frame7.eText()
        Me.rrt_vamt = New Frame7.eText()
        Me.rrt_amt = New Frame7.eText()
        Me.remk = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.rpl_cd = New Frame7.eText()
        Me.sum_amt = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.vat_amt = New Frame7.eText()
        Me.rt_amt = New Frame7.eText()
        Me.cs_addr = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.rps_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.cs_tel = New Frame7.eText()
        Me.rrt_dt = New Frame7.eDate()
        Me.wh_cd = New Frame7.eCombo()
        Me.od_gu = New Frame7.eCombo()
        Me.rt_dt = New Frame7.eDate()
        Me.rt_no = New Frame7.eText()
        Me.rps_nm = New Frame7.eText()
        Me.g_body = New Frame7.eGrid()
        Me.sale_amt = New Frame7.eText()
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
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1350, 558)
        Me.spc_1.SplitterDistance = 374
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
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 558)
        Me.SplitContainer1.SplitterDistance = 162
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 162)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(175, 32)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 47
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(13, 32)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 46
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(13, 58)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm.TabIndex = 48
        Me.find_cs_nm.Title = "거래처명"
        Me.find_cs_nm.TitleWidth = 60
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 41)
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
        Me.find_visible.Location = New System.Drawing.Point(274, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(94, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(14, 84)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(159, 21)
        Me.find_stts.TabIndex = 11
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
        Me.g_list.Size = New System.Drawing.Size(374, 392)
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Panel2.Controls.Add(Me.sale_amt)
        Me.SplitContainer2.Size = New System.Drawing.Size(972, 558)
        Me.SplitContainer2.SplitterDistance = 164
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.rrt_samt)
        Me.EPanel2.Controls.Add(Me.rrt_vamt)
        Me.EPanel2.Controls.Add(Me.rrt_amt)
        Me.EPanel2.Controls.Add(Me.remk)
        Me.EPanel2.Controls.Add(Me.stts1)
        Me.EPanel2.Controls.Add(Me.rpl_cd)
        Me.EPanel2.Controls.Add(Me.sum_amt)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.vat_amt)
        Me.EPanel2.Controls.Add(Me.rt_amt)
        Me.EPanel2.Controls.Add(Me.cs_addr)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.rps_cd)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.cs_tel)
        Me.EPanel2.Controls.Add(Me.rrt_dt)
        Me.EPanel2.Controls.Add(Me.wh_cd)
        Me.EPanel2.Controls.Add(Me.od_gu)
        Me.EPanel2.Controls.Add(Me.rt_dt)
        Me.EPanel2.Controls.Add(Me.rt_no)
        Me.EPanel2.Controls.Add(Me.rps_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(972, 164)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     반품요청 등록"
        '
        'rrt_samt
        '
        Me.rrt_samt.ColumnName = "find_paymenterm_cd"
        Me.rrt_samt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rrt_samt.Location = New System.Drawing.Point(717, 132)
        Me.rrt_samt.Name = "rrt_samt"
        Me.rrt_samt.Size = New System.Drawing.Size(210, 21)
        Me.rrt_samt.TabIndex = 80
        Me.rrt_samt.TableName = "find_paymenterm_cd"
        Me.rrt_samt.Title = "합계금액"
        Me.rrt_samt.TitleWidth = 85
        '
        'rrt_vamt
        '
        Me.rrt_vamt.ColumnName = "find_paymenterm_cd"
        Me.rrt_vamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rrt_vamt.Location = New System.Drawing.Point(717, 107)
        Me.rrt_vamt.Name = "rrt_vamt"
        Me.rrt_vamt.Size = New System.Drawing.Size(210, 21)
        Me.rrt_vamt.TabIndex = 79
        Me.rrt_vamt.TableName = "find_paymenterm_cd"
        Me.rrt_vamt.Title = "부가세"
        Me.rrt_vamt.TitleWidth = 85
        '
        'rrt_amt
        '
        Me.rrt_amt.ColumnName = "find_paymenterm_cd"
        Me.rrt_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rrt_amt.Location = New System.Drawing.Point(717, 82)
        Me.rrt_amt.Name = "rrt_amt"
        Me.rrt_amt.Size = New System.Drawing.Size(210, 21)
        Me.rrt_amt.TabIndex = 78
        Me.rrt_amt.TableName = "find_paymenterm_cd"
        Me.rrt_amt.Title = "공급가액"
        Me.rrt_amt.TitleWidth = 85
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(17, 132)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(683, 21)
        Me.remk.TabIndex = 75
        Me.remk.Title = "특기사항"
        Me.remk.TitleWidth = 70
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(717, 57)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(210, 21)
        Me.stts1.TabIndex = 74
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 85
        '
        'rpl_cd
        '
        Me.rpl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rpl_cd.Location = New System.Drawing.Point(17, 202)
        Me.rpl_cd.Name = "rpl_cd"
        Me.rpl_cd.Size = New System.Drawing.Size(240, 21)
        Me.rpl_cd.TabIndex = 76
        Me.rpl_cd.Title = "부서코드"
        '
        'sum_amt
        '
        Me.sum_amt.ColumnName = "find_paymenterm_cd"
        Me.sum_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sum_amt.Location = New System.Drawing.Point(717, 202)
        Me.sum_amt.Name = "sum_amt"
        Me.sum_amt.Size = New System.Drawing.Size(210, 21)
        Me.sum_amt.TabIndex = 73
        Me.sum_amt.TableName = "find_paymenterm_cd"
        Me.sum_amt.Title = "합계금액"
        Me.sum_amt.TitleWidth = 85
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(472, 57)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(228, 21)
        Me.sa_cd.TabIndex = 77
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 85
        '
        'vat_amt
        '
        Me.vat_amt.ColumnName = "find_paymenterm_cd"
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(485, 202)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(210, 21)
        Me.vat_amt.TabIndex = 72
        Me.vat_amt.TableName = "find_paymenterm_cd"
        Me.vat_amt.Title = "부가세"
        Me.vat_amt.TitleWidth = 85
        '
        'rt_amt
        '
        Me.rt_amt.ColumnName = "find_paymenterm_cd"
        Me.rt_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_amt.Location = New System.Drawing.Point(269, 202)
        Me.rt_amt.Name = "rt_amt"
        Me.rt_amt.Size = New System.Drawing.Size(210, 21)
        Me.rt_amt.TabIndex = 71
        Me.rt_amt.TableName = "find_paymenterm_cd"
        Me.rt_amt.Title = "공급가액"
        Me.rt_amt.TitleWidth = 85
        '
        'cs_addr
        '
        Me.cs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_addr.Location = New System.Drawing.Point(17, 107)
        Me.cs_addr.Name = "cs_addr"
        Me.cs_addr.Size = New System.Drawing.Size(439, 21)
        Me.cs_addr.TabIndex = 70
        Me.cs_addr.Title = "주소"
        Me.cs_addr.TitleWidth = 70
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(173, 57)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(283, 21)
        Me.cs_nm.TabIndex = 68
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'rps_cd
        '
        Me.rps_cd.ColumnName = "find_paymenterm_cd"
        Me.rps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rps_cd.Location = New System.Drawing.Point(218, 32)
        Me.rps_cd.Name = "rps_cd"
        Me.rps_cd.Size = New System.Drawing.Size(133, 21)
        Me.rps_cd.TabIndex = 19
        Me.rps_cd.TableName = "find_paymenterm_cd"
        Me.rps_cd.Title = "작성자"
        Me.rps_cd.TitleWidth = 50
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(17, 57)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(155, 21)
        Me.cs_cd.TabIndex = 67
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 70
        '
        'cs_tel
        '
        Me.cs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_tel.Location = New System.Drawing.Point(17, 82)
        Me.cs_tel.Name = "cs_tel"
        Me.cs_tel.Size = New System.Drawing.Size(439, 21)
        Me.cs_tel.TabIndex = 69
        Me.cs_tel.Title = "전화번호"
        Me.cs_tel.TitleWidth = 70
        '
        'rrt_dt
        '
        Me.rrt_dt.Location = New System.Drawing.Point(472, 32)
        Me.rrt_dt.Name = "rrt_dt"
        Me.rrt_dt.Size = New System.Drawing.Size(228, 21)
        Me.rrt_dt.TabIndex = 21
        Me.rrt_dt.Title = "반품요청일자"
        Me.rrt_dt.TitleWidth = 85
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(473, 82)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(227, 21)
        Me.wh_cd.TabIndex = 41
        Me.wh_cd.Title = "창고"
        Me.wh_cd.TitleWidth = 85
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(513, 107)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(187, 21)
        Me.od_gu.TabIndex = 40
        Me.od_gu.Title = "구분"
        Me.od_gu.TitleWidth = 70
        '
        'rt_dt
        '
        Me.rt_dt.Location = New System.Drawing.Point(717, 32)
        Me.rt_dt.Name = "rt_dt"
        Me.rt_dt.Size = New System.Drawing.Size(210, 21)
        Me.rt_dt.TabIndex = 42
        Me.rt_dt.Title = "반품승인일자"
        Me.rt_dt.TitleWidth = 85
        '
        'rt_no
        '
        Me.rt_no.ColumnName = "find_paymenterm_cd"
        Me.rt_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_no.Location = New System.Drawing.Point(17, 32)
        Me.rt_no.Name = "rt_no"
        Me.rt_no.Size = New System.Drawing.Size(187, 21)
        Me.rt_no.TabIndex = 5
        Me.rt_no.TableName = "find_paymenterm_cd"
        Me.rt_no.Title = "반품번호"
        Me.rt_no.TitleWidth = 70
        '
        'rps_nm
        '
        Me.rps_nm.ColumnName = "find_stts"
        Me.rps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rps_nm.Location = New System.Drawing.Point(352, 32)
        Me.rps_nm.Name = "rps_nm"
        Me.rps_nm.Size = New System.Drawing.Size(104, 21)
        Me.rps_nm.TabIndex = 18
        Me.rps_nm.TableName = "find_stts"
        Me.rps_nm.Title = "ps_nm"
        Me.rps_nm.TitleWidth = 0
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(972, 390)
        Me.g_body.TabIndex = 1
        '
        'sale_amt
        '
        Me.sale_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_amt.Location = New System.Drawing.Point(487, 3)
        Me.sale_amt.Name = "sale_amt"
        Me.sale_amt.Size = New System.Drawing.Size(240, 21)
        Me.sale_amt.TabIndex = 39
        Me.sale_amt.Title = "합계금액"
        '
        'WI_SA1150
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1150"
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
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents rrt_dt As Frame7.eDate
    Friend WithEvents rps_cd As Frame7.eText
    Friend WithEvents rps_nm As Frame7.eText
    Friend WithEvents rt_no As Frame7.eText
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents sale_amt As Frame7.eText
    Friend WithEvents rt_dt As Frame7.eDate
    Friend WithEvents od_gu As Frame7.eCombo
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents cs_tel As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_addr As Frame7.eText
    Friend WithEvents sum_amt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents rt_amt As Frame7.eText
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents rpl_cd As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents rrt_amt As Frame7.eText
    Friend WithEvents rrt_vamt As Frame7.eText
    Friend WithEvents rrt_samt As Frame7.eText

End Class
