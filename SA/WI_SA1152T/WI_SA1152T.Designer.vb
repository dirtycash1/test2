<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1152T
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
        Me.remk = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.rt_amt = New Frame7.eText()
        Me.rpl_cd = New Frame7.eText()
        Me.rt_dt = New Frame7.eDate()
        Me.wh_cd = New Frame7.eCombo()
        Me.cs_nm = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.rrt_dt = New Frame7.eDate()
        Me.rps_cd = New Frame7.eText()
        Me.rps_nm = New Frame7.eText()
        Me.rt_no = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_body = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g_body1 = New Frame7.eGrid()
        Me.won_amt = New Frame7.eText()
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
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.SplitterDistance = 157
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
        Me.EPanel1.Size = New System.Drawing.Size(374, 157)
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
        Me.find_cs_nm.Location = New System.Drawing.Point(13, 82)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(272, 21)
        Me.find_cs_nm.TabIndex = 48
        Me.find_cs_nm.Title = "거래처"
        Me.find_cs_nm.TitleWidth = 60
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 114)
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
        Me.find_stts.Location = New System.Drawing.Point(13, 57)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(272, 21)
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
        Me.g_list.Size = New System.Drawing.Size(374, 397)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(972, 558)
        Me.SplitContainer2.SplitterDistance = 112
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.won_amt)
        Me.EPanel2.Controls.Add(Me.remk)
        Me.EPanel2.Controls.Add(Me.stts1)
        Me.EPanel2.Controls.Add(Me.rt_amt)
        Me.EPanel2.Controls.Add(Me.rpl_cd)
        Me.EPanel2.Controls.Add(Me.rt_dt)
        Me.EPanel2.Controls.Add(Me.wh_cd)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.rrt_dt)
        Me.EPanel2.Controls.Add(Me.rps_cd)
        Me.EPanel2.Controls.Add(Me.rps_nm)
        Me.EPanel2.Controls.Add(Me.rt_no)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(972, 112)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     반품요청등록(수출)"
        '
        'remk
        '
        Me.remk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.remk.Location = New System.Drawing.Point(9, 82)
        Me.remk.Name = "remk"
        Me.remk.Size = New System.Drawing.Size(614, 21)
        Me.remk.TabIndex = 99
        Me.remk.Title = "특기사항"
        Me.remk.TitleWidth = 68
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(633, 82)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(194, 21)
        Me.stts1.TabIndex = 100
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 85
        '
        'rt_amt
        '
        Me.rt_amt.ColumnName = "find_paymenterm_cd"
        Me.rt_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_amt.Location = New System.Drawing.Point(310, 141)
        Me.rt_amt.Name = "rt_amt"
        Me.rt_amt.Size = New System.Drawing.Size(194, 21)
        Me.rt_amt.TabIndex = 98
        Me.rt_amt.TableName = "find_paymenterm_cd"
        Me.rt_amt.Title = "반품금액"
        Me.rt_amt.TitleWidth = 85
        '
        'rpl_cd
        '
        Me.rpl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rpl_cd.Location = New System.Drawing.Point(9, 141)
        Me.rpl_cd.Name = "rpl_cd"
        Me.rpl_cd.Size = New System.Drawing.Size(240, 21)
        Me.rpl_cd.TabIndex = 96
        Me.rpl_cd.Title = "부서"
        '
        'rt_dt
        '
        Me.rt_dt.Location = New System.Drawing.Point(633, 57)
        Me.rt_dt.Name = "rt_dt"
        Me.rt_dt.Size = New System.Drawing.Size(194, 21)
        Me.rt_dt.TabIndex = 93
        Me.rt_dt.Title = "반품승인일자"
        Me.rt_dt.TitleWidth = 85
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(452, 57)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(171, 21)
        Me.wh_cd.TabIndex = 92
        Me.wh_cd.Title = "창고"
        Me.wh_cd.TitleWidth = 60
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(188, 57)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(256, 21)
        Me.cs_nm.TabIndex = 91
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(452, 32)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(171, 21)
        Me.sa_cd.TabIndex = 87
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 60
        '
        'rrt_dt
        '
        Me.rrt_dt.Location = New System.Drawing.Point(633, 32)
        Me.rrt_dt.Name = "rrt_dt"
        Me.rrt_dt.Size = New System.Drawing.Size(194, 21)
        Me.rrt_dt.TabIndex = 86
        Me.rrt_dt.Title = "반품요청일자"
        Me.rrt_dt.TitleWidth = 85
        '
        'rps_cd
        '
        Me.rps_cd.ColumnName = "find_paymenterm_cd"
        Me.rps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rps_cd.Location = New System.Drawing.Point(196, 32)
        Me.rps_cd.Name = "rps_cd"
        Me.rps_cd.Size = New System.Drawing.Size(143, 21)
        Me.rps_cd.TabIndex = 85
        Me.rps_cd.TableName = "find_paymenterm_cd"
        Me.rps_cd.Title = "작성자"
        Me.rps_cd.TitleWidth = 60
        '
        'rps_nm
        '
        Me.rps_nm.ColumnName = "find_stts"
        Me.rps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rps_nm.Location = New System.Drawing.Point(340, 32)
        Me.rps_nm.Name = "rps_nm"
        Me.rps_nm.Size = New System.Drawing.Size(104, 21)
        Me.rps_nm.TabIndex = 84
        Me.rps_nm.TableName = "find_stts"
        Me.rps_nm.Title = "ps_nm"
        Me.rps_nm.TitleWidth = 0
        '
        'rt_no
        '
        Me.rt_no.ColumnName = "find_paymenterm_cd"
        Me.rt_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rt_no.Location = New System.Drawing.Point(9, 32)
        Me.rt_no.Name = "rt_no"
        Me.rt_no.Size = New System.Drawing.Size(178, 21)
        Me.rt_no.TabIndex = 80
        Me.rt_no.TableName = "find_paymenterm_cd"
        Me.rt_no.Title = "반품번호"
        Me.rt_no.TitleWidth = 68
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(9, 57)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(178, 21)
        Me.cs_cd.TabIndex = 44
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 68
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(972, 442)
        Me.SplitContainer3.SplitterDistance = 154
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_body)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(972, 154)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Invoice 내역"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(2, 23)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(968, 129)
        Me.g_body.TabIndex = 1
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g_body1)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(972, 284)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     출하 내역"
        '
        'g_body1
        '
        Me.g_body1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body1.Location = New System.Drawing.Point(2, 23)
        Me.g_body1.Name = "g_body1"
        Me.g_body1.ReadOnly = False
        Me.g_body1.RowHeight = -1
        Me.g_body1.Size = New System.Drawing.Size(968, 259)
        Me.g_body1.TabIndex = 0
        '
        'won_amt
        '
        Me.won_amt.ColumnName = "find_paymenterm_cd"
        Me.won_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.won_amt.Location = New System.Drawing.Point(521, 141)
        Me.won_amt.Name = "won_amt"
        Me.won_amt.Size = New System.Drawing.Size(194, 21)
        Me.won_amt.TabIndex = 101
        Me.won_amt.TableName = "find_paymenterm_cd"
        Me.won_amt.Title = "원화금액"
        Me.won_amt.TitleWidth = 85
        '
        'WI_SA1152T
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1152T"
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
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
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_body1 As Frame7.eGrid
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents rt_no As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents rrt_dt As Frame7.eDate
    Friend WithEvents rps_cd As Frame7.eText
    Friend WithEvents rps_nm As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents rt_dt As Frame7.eDate
    Friend WithEvents rpl_cd As Frame7.eText
    Friend WithEvents remk As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents rt_amt As Frame7.eText
    Friend WithEvents won_amt As Frame7.eText

End Class
