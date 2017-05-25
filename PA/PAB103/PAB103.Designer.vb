<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAB103
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.but3_text = New Frame7.eText()
        Me.but2_text = New Frame7.eText()
        Me.kind_bc = New Frame7.eCombo()
        Me.pay_sq = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.duty2_bc = New Frame7.eCombo()
        Me.duty1_bc = New Frame7.eCombo()
        Me.pay_bc = New Frame7.eCombo()
        Me.emp_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.pay_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.but1_text = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.but1 = New DevExpress.XtraEditors.RadioGroup()
        Me.but2 = New DevExpress.XtraEditors.RadioGroup()
        Me.but3 = New DevExpress.XtraEditors.RadioGroup()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.g40 = New Frame7.eGrid()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.but1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.but3_text)
        Me.EPanel1.Controls.Add(Me.but2_text)
        Me.EPanel1.Controls.Add(Me.kind_bc)
        Me.EPanel1.Controls.Add(Me.pay_sq)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.duty2_bc)
        Me.EPanel1.Controls.Add(Me.duty1_bc)
        Me.EPanel1.Controls.Add(Me.pay_bc)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.pay_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.but1_text)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.but1)
        Me.EPanel1.Controls.Add(Me.but2)
        Me.EPanel1.Controls.Add(Me.but3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1200, 127)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'but3_text
        '
        Me.but3_text.Location = New System.Drawing.Point(772, 176)
        Me.but3_text.Name = "but3_text"
        Me.but3_text.Size = New System.Drawing.Size(240, 21)
        Me.but3_text.TabIndex = 97
        '
        'but2_text
        '
        Me.but2_text.Location = New System.Drawing.Point(772, 155)
        Me.but2_text.Name = "but2_text"
        Me.but2_text.Size = New System.Drawing.Size(240, 21)
        Me.but2_text.TabIndex = 95
        '
        'kind_bc
        '
        Me.kind_bc.Location = New System.Drawing.Point(520, 100)
        Me.kind_bc.Name = "kind_bc"
        Me.kind_bc.Size = New System.Drawing.Size(240, 21)
        Me.kind_bc.TabIndex = 98
        Me.kind_bc.Title = "직종"
        '
        'pay_sq
        '
        Me.pay_sq.Location = New System.Drawing.Point(8, 100)
        Me.pay_sq.Name = "pay_sq"
        Me.pay_sq.Size = New System.Drawing.Size(240, 21)
        Me.pay_sq.TabIndex = 90
        Me.pay_sq.Title = "지급차수"
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(264, 76)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 85
        Me.emp_no.Title = "사원"
        '
        'duty2_bc
        '
        Me.duty2_bc.Location = New System.Drawing.Point(520, 76)
        Me.duty2_bc.Name = "duty2_bc"
        Me.duty2_bc.Size = New System.Drawing.Size(240, 21)
        Me.duty2_bc.TabIndex = 93
        Me.duty2_bc.Title = "직책(이상)"
        '
        'duty1_bc
        '
        Me.duty1_bc.Location = New System.Drawing.Point(520, 52)
        Me.duty1_bc.Name = "duty1_bc"
        Me.duty1_bc.Size = New System.Drawing.Size(240, 21)
        Me.duty1_bc.TabIndex = 92
        Me.duty1_bc.Title = "직책"
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(520, 28)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(240, 21)
        Me.pay_bc.TabIndex = 91
        Me.pay_bc.Title = "급여지급유형"
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(264, 100)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 87
        Me.emp_nm.Title = "사원명"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(264, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 84
        Me.dept_cd.Title = "부서"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(264, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 86
        Me.dept_nm.Title = "부서명"
        '
        'pay_mon
        '
        Me.pay_mon.Location = New System.Drawing.Point(8, 76)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(240, 21)
        Me.pay_mon.TabIndex = 83
        Me.pay_mon.Title = "귀속년월"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 82
        Me.co_cd.Title = "법인"
        '
        'but1_text
        '
        Me.but1_text.Location = New System.Drawing.Point(772, 132)
        Me.but1_text.Name = "but1_text"
        Me.but1_text.Size = New System.Drawing.Size(240, 21)
        Me.but1_text.TabIndex = 89
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 81
        Me.bs_cd.Title = "사업장"
        '
        'but1
        '
        Me.but1.EditValue = "0"
        Me.but1.Location = New System.Drawing.Point(776, 28)
        Me.but1.Name = "but1"
        Me.but1.Properties.Columns = 1
        Me.but1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "부서별"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "직책별"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "직종별")})
        Me.but1.Size = New System.Drawing.Size(76, 92)
        Me.but1.TabIndex = 88
        '
        'but2
        '
        Me.but2.EditValue = "1"
        Me.but2.Location = New System.Drawing.Point(868, 28)
        Me.but2.Name = "but2"
        Me.but2.Properties.Columns = 1
        Me.but2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "소계"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "상세"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "사원")})
        Me.but2.Size = New System.Drawing.Size(68, 92)
        Me.but2.TabIndex = 94
        '
        'but3
        '
        Me.but3.EditValue = "0"
        Me.but3.Location = New System.Drawing.Point(952, 28)
        Me.but3.Name = "but3"
        Me.but3.Properties.Columns = 1
        Me.but3.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "급여대장"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "급여명세서")})
        Me.but3.Size = New System.Drawing.Size(92, 92)
        Me.but3.TabIndex = 96
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1200, 636)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1200, 505)
        Me.SplitContainer2.SplitterDistance = 256
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g30)
        Me.EPanel3.Controls.Add(Me.g40)
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(256, 505)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     검색리스트"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(252, 480)
        Me.g30.TabIndex = 5
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(2, 23)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(252, 480)
        Me.g40.TabIndex = 6
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(252, 480)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(252, 480)
        Me.g20.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.CrystalReportViewer)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(940, 505)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     출력"
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer.Location = New System.Drawing.Point(2, 23)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.ShowCloseButton = False
        Me.CrystalReportViewer.ShowExportButton = False
        Me.CrystalReportViewer.ShowGroupTreeButton = False
        Me.CrystalReportViewer.ShowParameterPanelButton = False
        Me.CrystalReportViewer.ShowRefreshButton = False
        Me.CrystalReportViewer.Size = New System.Drawing.Size(936, 480)
        Me.CrystalReportViewer.TabIndex = 2
        Me.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PAB103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAB103"
        Me.Size = New System.Drawing.Size(1200, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.but1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents but2_text As Frame7.eText
    Friend WithEvents but2 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents duty2_bc As Frame7.eCombo
    Friend WithEvents duty1_bc As Frame7.eCombo
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents pay_sq As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents but1_text As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents but1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents but3_text As Frame7.eText
    Friend WithEvents but3 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents kind_bc As Frame7.eCombo

End Class
