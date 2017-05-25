<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_TR1180
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
        Me.won_amt = New Frame7.eText()
        Me.daeche_amt = New Frame7.eText()
        Me.cl_dt = New Frame7.eDate()
        Me.cur_cd = New Frame7.eCombo()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.daeche_dt = New Frame7.eDate()
        Me.ps_cd = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.sa_cd = New Frame7.eCombo()
        Me.daeche_no = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_body = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g_body1 = New Frame7.eGrid()
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
        Me.SplitContainer2.SplitterDistance = 111
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.won_amt)
        Me.EPanel2.Controls.Add(Me.daeche_amt)
        Me.EPanel2.Controls.Add(Me.cl_dt)
        Me.EPanel2.Controls.Add(Me.cur_cd)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.daeche_dt)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.stts1)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.daeche_no)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(972, 111)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     선수금대체 등록(수출)"
        '
        'won_amt
        '
        Me.won_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.won_amt.Location = New System.Drawing.Point(246, 82)
        Me.won_amt.Name = "won_amt"
        Me.won_amt.Size = New System.Drawing.Size(270, 21)
        Me.won_amt.TabIndex = 50
        Me.won_amt.Title = "원화총금액"
        Me.won_amt.TitleWidth = 85
        '
        'daeche_amt
        '
        Me.daeche_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.daeche_amt.Location = New System.Drawing.Point(19, 82)
        Me.daeche_amt.Name = "daeche_amt"
        Me.daeche_amt.Size = New System.Drawing.Size(215, 21)
        Me.daeche_amt.TabIndex = 49
        Me.daeche_amt.Title = "대체금액합계"
        Me.daeche_amt.TitleWidth = 98
        '
        'cl_dt
        '
        Me.cl_dt.Location = New System.Drawing.Point(722, 57)
        Me.cl_dt.Name = "cl_dt"
        Me.cl_dt.Size = New System.Drawing.Size(169, 21)
        Me.cl_dt.TabIndex = 47
        Me.cl_dt.Title = "확인일자"
        Me.cl_dt.TitleWidth = 60
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(528, 57)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(179, 21)
        Me.cur_cd.TabIndex = 46
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 70
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(246, 57)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(270, 21)
        Me.cs_nm.TabIndex = 45
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 85
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(19, 57)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(215, 21)
        Me.cs_cd.TabIndex = 44
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_paymenterm_cd"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(898, 58)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(123, 21)
        Me.pl_cd.TabIndex = 42
        Me.pl_cd.TableName = "find_paymenterm_cd"
        Me.pl_cd.Title = "부서"
        Me.pl_cd.TitleWidth = 40
        '
        'daeche_dt
        '
        Me.daeche_dt.Location = New System.Drawing.Point(722, 32)
        Me.daeche_dt.Name = "daeche_dt"
        Me.daeche_dt.Size = New System.Drawing.Size(169, 21)
        Me.daeche_dt.TabIndex = 21
        Me.daeche_dt.Title = "대체일자"
        Me.daeche_dt.TitleWidth = 60
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(246, 32)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(165, 21)
        Me.ps_cd.TabIndex = 19
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "담당자"
        Me.ps_cd.TitleWidth = 85
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(898, 32)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(58, 21)
        Me.stts1.TabIndex = 43
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 0
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(528, 32)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(179, 21)
        Me.sa_cd.TabIndex = 40
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 70
        '
        'daeche_no
        '
        Me.daeche_no.ColumnName = "find_paymenterm_cd"
        Me.daeche_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.daeche_no.Location = New System.Drawing.Point(19, 32)
        Me.daeche_no.Name = "daeche_no"
        Me.daeche_no.Size = New System.Drawing.Size(215, 21)
        Me.daeche_no.TabIndex = 5
        Me.daeche_no.TableName = "find_paymenterm_cd"
        Me.daeche_no.Title = "전표번호"
        Me.daeche_no.TitleWidth = 98
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(412, 32)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 18
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
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
        Me.SplitContainer3.Size = New System.Drawing.Size(972, 443)
        Me.SplitContainer3.SplitterDistance = 169
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_body)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(972, 169)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     수주별 선수금"
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(2, 23)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(968, 144)
        Me.g_body.TabIndex = 1
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g_body1)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(972, 270)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     수주별 대체금"
        '
        'g_body1
        '
        Me.g_body1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body1.Location = New System.Drawing.Point(2, 23)
        Me.g_body1.Name = "g_body1"
        Me.g_body1.ReadOnly = False
        Me.g_body1.RowHeight = -1
        Me.g_body1.Size = New System.Drawing.Size(968, 245)
        Me.g_body1.TabIndex = 0
        '
        'WI_TR1180
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_TR1180"
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
    Friend WithEvents daeche_dt As Frame7.eDate
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents daeche_no As Frame7.eText
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents cl_dt As Frame7.eDate
    Friend WithEvents daeche_amt As Frame7.eText
    Friend WithEvents won_amt As Frame7.eText
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_body1 As Frame7.eGrid
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel4 As Frame7.ePanel

End Class
