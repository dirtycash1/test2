<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAC102
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
        Me.pay_mon = New Frame7.eDate()
        Me.pay_sq = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.emp_nm = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.emp_no2 = New Frame7.eText()
        Me.emp_nm2 = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.tot_de = New Frame7.eText()
        Me.duty_bc = New Frame7.eCombo()
        Me.pay_amt = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 556)
        Me.SplitContainer1.SplitterDistance = 351
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(351, 556)
        Me.SplitContainer2.SplitterDistance = 150
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.pay_mon)
        Me.EPanel1.Controls.Add(Me.pay_sq)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(351, 150)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'pay_mon
        '
        Me.pay_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pay_mon.Format = "yyyy-MM"
        Me.pay_mon.Location = New System.Drawing.Point(12, 28)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(240, 21)
        Me.pay_mon.TabIndex = 2
        '
        'pay_sq
        '
        Me.pay_sq.Location = New System.Drawing.Point(12, 52)
        Me.pay_sq.Name = "pay_sq"
        Me.pay_sq.Size = New System.Drawing.Size(240, 21)
        Me.pay_sq.TabIndex = 3
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(12, 100)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 4
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 76)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 3
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(12, 124)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 4
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(351, 402)
        Me.g10.TabIndex = 0
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(633, 556)
        Me.SplitContainer3.SplitterDistance = 108
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.emp_no2)
        Me.EPanel2.Controls.Add(Me.emp_nm2)
        Me.EPanel2.Controls.Add(Me.tot_amt)
        Me.EPanel2.Controls.Add(Me.dept_nm)
        Me.EPanel2.Controls.Add(Me.tot_de)
        Me.EPanel2.Controls.Add(Me.duty_bc)
        Me.EPanel2.Controls.Add(Me.pay_amt)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.IconVisible = False
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.ShowCaption = False
        Me.EPanel2.Size = New System.Drawing.Size(633, 108)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "EPanel2"
        '
        'emp_no2
        '
        Me.emp_no2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no2.Location = New System.Drawing.Point(12, 8)
        Me.emp_no2.Name = "emp_no2"
        Me.emp_no2.Size = New System.Drawing.Size(240, 21)
        Me.emp_no2.TabIndex = 2
        '
        'emp_nm2
        '
        Me.emp_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm2.Location = New System.Drawing.Point(12, 32)
        Me.emp_nm2.Name = "emp_nm2"
        Me.emp_nm2.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm2.TabIndex = 2
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(272, 32)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 2
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(12, 56)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 3
        '
        'tot_de
        '
        Me.tot_de.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_de.Location = New System.Drawing.Point(272, 56)
        Me.tot_de.Name = "tot_de"
        Me.tot_de.Size = New System.Drawing.Size(240, 21)
        Me.tot_de.TabIndex = 2
        '
        'duty_bc
        '
        Me.duty_bc.Location = New System.Drawing.Point(12, 80)
        Me.duty_bc.Name = "duty_bc"
        Me.duty_bc.Size = New System.Drawing.Size(241, 21)
        Me.duty_bc.TabIndex = 3
        '
        'pay_amt
        '
        Me.pay_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pay_amt.Location = New System.Drawing.Point(272, 80)
        Me.pay_amt.Name = "pay_amt"
        Me.pay_amt.Size = New System.Drawing.Size(240, 21)
        Me.pay_amt.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(633, 444)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(626, 414)
        Me.XtraTabPage1.Text = "지급/공제"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(626, 414)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(626, 414)
        Me.XtraTabPage2.Text = "     계산    "
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(626, 414)
        Me.g30.TabIndex = 0
        '
        'PAC102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAC102"
        Me.Size = New System.Drawing.Size(1057, 581)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
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
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents pay_sq As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents emp_no2 As Frame7.eText
    Friend WithEvents emp_nm2 As Frame7.eText
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents tot_de As Frame7.eText
    Friend WithEvents duty_bc As Frame7.eCombo
    Friend WithEvents pay_amt As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid

End Class
