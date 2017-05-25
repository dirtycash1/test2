<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB520
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.sel_amt = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.div_cd = New Frame7.eCombo()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.acc_cd = New Frame7.eText()
        Me.pay_kd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.cust_yn = New Frame7.eCheck()
        Me.opt2 = New Frame7.eOptionBox()
        Me.acc_nm = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.opt1 = New Frame7.eOptionBox()
        Me.cust_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.opt3 = New Frame7.eOptionBox()
        Me.g10 = New Frame7.eGrid()
        Me.iss_dt = New Frame7.eDate()
        Me.end_dt = New Frame7.eDate()
        Me.bank_cd = New Frame7.eCombo()
        Me.acct_no = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 360)
        Me.SplitContainer1.SplitterDistance = 134
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.sel_amt)
        Me.EPanel1.Controls.Add(Me.btn_work)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.acct_no)
        Me.EPanel1.Controls.Add(Me.bank_cd)
        Me.EPanel1.Controls.Add(Me.iss_dt)
        Me.EPanel1.Controls.Add(Me.pay_kd)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Controls.Add(Me.end_dt)
        Me.EPanel1.Controls.Add(Me.cust_yn)
        Me.EPanel1.Controls.Add(Me.opt2)
        Me.EPanel1.Controls.Add(Me.acc_nm)
        Me.EPanel1.Controls.Add(Me.opt1)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.opt3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1264, 134)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'sel_amt
        '
        Me.sel_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sel_amt.Location = New System.Drawing.Point(528, 104)
        Me.sel_amt.Name = "sel_amt"
        Me.sel_amt.Size = New System.Drawing.Size(208, 21)
        Me.sel_amt.TabIndex = 5
        Me.sel_amt.Title = "sel_amt"
        Me.sel_amt.TitleWidth = 98
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "co_cd"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 2
        Me.div_cd.Title = "div_cd"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(844, 102)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(148, 24)
        Me.btn_work.TabIndex = 12
        Me.btn_work.Text = "전표처리"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 11
        Me.fr_dt.Title = "fr_dt"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(132, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 11
        Me.to_dt.TitleWidth = 0
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd.Location = New System.Drawing.Point(268, 108)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(51, 21)
        Me.acc_cd.TabIndex = 5
        Me.acc_cd.Title = "acc_cd"
        Me.acc_cd.Visible = False
        '
        'pay_kd
        '
        Me.pay_kd.Location = New System.Drawing.Point(744, 28)
        Me.pay_kd.Name = "pay_kd"
        Me.pay_kd.Size = New System.Drawing.Size(248, 21)
        Me.pay_kd.TabIndex = 2
        Me.pay_kd.Title = "pay_kd"
        Me.pay_kd.TitleWidth = 98
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(300, 108)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(52, 21)
        Me.dept_cd.TabIndex = 5
        Me.dept_cd.Title = "dept_cd"
        Me.dept_cd.Visible = False
        '
        'cust_yn
        '
        Me.cust_yn.Caption = ""
        Me.cust_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_yn.Location = New System.Drawing.Point(744, 104)
        Me.cust_yn.Name = "cust_yn"
        Me.cust_yn.Size = New System.Drawing.Size(112, 21)
        Me.cust_yn.TabIndex = 58
        Me.cust_yn.Title = "거래처별 행"
        Me.cust_yn.TitleWidth = 78
        '
        'opt2
        '
        Me.opt2.Location = New System.Drawing.Point(572, 28)
        Me.opt2.Name = "opt2"
        Me.opt2.SelectedIndex = -1
        Me.opt2.Size = New System.Drawing.Size(80, 68)
        Me.opt2.TabIndex = 61
        Me.opt2.TitleWidth = 0
        '
        'acc_nm
        '
        Me.acc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_nm.Location = New System.Drawing.Point(260, 28)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(220, 21)
        Me.acc_nm.TabIndex = 5
        Me.acc_nm.Title = "acc_nm"
        Me.acc_nm.TitleWidth = 98
        Me.acc_nm.Visible = False
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(340, 108)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(56, 21)
        Me.cust_cd.TabIndex = 5
        Me.cust_cd.Title = "cust_cd"
        Me.cust_cd.Visible = False
        '
        'opt1
        '
        Me.opt1.Location = New System.Drawing.Point(488, 28)
        Me.opt1.Name = "opt1"
        Me.opt1.SelectedIndex = -1
        Me.opt1.Size = New System.Drawing.Size(80, 68)
        Me.opt1.TabIndex = 61
        Me.opt1.TitleWidth = 0
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(260, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(220, 21)
        Me.cust_nm.TabIndex = 5
        Me.cust_nm.Title = "cust_nm"
        Me.cust_nm.TitleWidth = 98
        Me.cust_nm.Visible = False
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(260, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(220, 21)
        Me.dept_nm.TabIndex = 5
        Me.dept_nm.Title = "dept_nm"
        Me.dept_nm.TitleWidth = 98
        Me.dept_nm.Visible = False
        '
        'opt3
        '
        Me.opt3.Location = New System.Drawing.Point(656, 28)
        Me.opt3.Name = "opt3"
        Me.opt3.SelectedIndex = -1
        Me.opt3.Size = New System.Drawing.Size(80, 68)
        Me.opt3.TabIndex = 61
        Me.opt3.TitleWidth = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1264, 222)
        Me.g10.TabIndex = 3
        '
        'iss_dt
        '
        Me.iss_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.iss_dt.Location = New System.Drawing.Point(1000, 52)
        Me.iss_dt.Name = "iss_dt"
        Me.iss_dt.Size = New System.Drawing.Size(164, 21)
        Me.iss_dt.TabIndex = 11
        Me.iss_dt.Title = "iss_dt"
        Me.iss_dt.TitleWidth = 68
        '
        'end_dt
        '
        Me.end_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_dt.Location = New System.Drawing.Point(1000, 76)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(164, 21)
        Me.end_dt.TabIndex = 11
        Me.end_dt.Title = "end_dt"
        Me.end_dt.TitleWidth = 68
        '
        'bank_cd
        '
        Me.bank_cd.Location = New System.Drawing.Point(744, 52)
        Me.bank_cd.Name = "bank_cd"
        Me.bank_cd.Size = New System.Drawing.Size(248, 21)
        Me.bank_cd.TabIndex = 2
        Me.bank_cd.Title = "bank_cd"
        Me.bank_cd.TitleWidth = 98
        '
        'acct_no
        '
        Me.acct_no.Location = New System.Drawing.Point(744, 76)
        Me.acct_no.Name = "acct_no"
        Me.acct_no.Size = New System.Drawing.Size(248, 21)
        Me.acct_no.TabIndex = 2
        Me.acct_no.Title = "acct_no"
        Me.acct_no.TitleWidth = 98
        '
        'FAB520
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB520"
        Me.Size = New System.Drawing.Size(1286, 382)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pay_kd As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents cust_yn As Frame7.eCheck
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents sel_amt As Frame7.eText
    Friend WithEvents opt1 As Frame7.eOptionBox
    Friend WithEvents opt2 As Frame7.eOptionBox
    Friend WithEvents opt3 As Frame7.eOptionBox
    Friend WithEvents acct_no As Frame7.eCombo
    Friend WithEvents bank_cd As Frame7.eCombo
    Friend WithEvents iss_dt As Frame7.eDate
    Friend WithEvents end_dt As Frame7.eDate

End Class
