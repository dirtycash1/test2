<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAB120
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.port = New Frame7.eText()
        Me.smtphost = New Frame7.eText()
        Me.p_pw = New Frame7.eText()
        Me.email = New Frame7.eText()
        Me.pay_sq = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.nat_chk = New Frame7.eCheck()
        Me.btn_send = New DevExpress.XtraEditors.SimpleButton()
        Me.dept_cd = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.co_mail_yn = New Frame7.eCheck()
        Me.all_chk = New Frame7.eCheck()
        Me.bs_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.pay_mon = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.PrintControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
        Me.ECheck1 = New Frame7.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1329, 411)
        Me.SplitContainer1.SplitterDistance = 110
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.ECheck1)
        Me.EPanel2.Controls.Add(Me.port)
        Me.EPanel2.Controls.Add(Me.smtphost)
        Me.EPanel2.Controls.Add(Me.email)
        Me.EPanel2.Controls.Add(Me.pay_sq)
        Me.EPanel2.Controls.Add(Me.emp_no)
        Me.EPanel2.Controls.Add(Me.ProgressBar1)
        Me.EPanel2.Controls.Add(Me.nat_chk)
        Me.EPanel2.Controls.Add(Me.btn_send)
        Me.EPanel2.Controls.Add(Me.p_pw)
        Me.EPanel2.Controls.Add(Me.dept_cd)
        Me.EPanel2.Controls.Add(Me.emp_nm)
        Me.EPanel2.Controls.Add(Me.dept_nm)
        Me.EPanel2.Controls.Add(Me.co_mail_yn)
        Me.EPanel2.Controls.Add(Me.all_chk)
        Me.EPanel2.Controls.Add(Me.bs_cd)
        Me.EPanel2.Controls.Add(Me.co_cd)
        Me.EPanel2.Controls.Add(Me.pay_mon)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1329, 110)
        Me.EPanel2.TabIndex = 9
        Me.EPanel2.Text = "     급여정보"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(1207, 28)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(108, 21)
        Me.port.TabIndex = 73
        Me.port.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.port.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.port.TitleWidth = 60
        '
        'smtphost
        '
        Me.smtphost.Location = New System.Drawing.Point(957, 28)
        Me.smtphost.Name = "smtphost"
        Me.smtphost.Size = New System.Drawing.Size(244, 21)
        Me.smtphost.TabIndex = 73
        Me.smtphost.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.smtphost.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.smtphost.TitleWidth = 60
        '
        'p_pw
        '
        Me.p_pw.Location = New System.Drawing.Point(536, 79)
        Me.p_pw.Name = "p_pw"
        Me.p_pw.Size = New System.Drawing.Size(242, 21)
        Me.p_pw.TabIndex = 73
        Me.p_pw.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.p_pw.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(536, 28)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(415, 21)
        Me.email.TabIndex = 73
        Me.email.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.email.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'pay_sq
        '
        Me.pay_sq.Location = New System.Drawing.Point(268, 54)
        Me.pay_sq.Name = "pay_sq"
        Me.pay_sq.Size = New System.Drawing.Size(240, 21)
        Me.pay_sq.TabIndex = 72
        Me.pay_sq.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pay_sq.Title = "pay_sq"
        Me.pay_sq.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(1109, 163)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 71
        Me.emp_no.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.emp_no.Title = "emp_no"
        Me.emp_no.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1097, 71)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(218, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'nat_chk
        '
        Me.nat_chk.Caption = ""
        Me.nat_chk.Location = New System.Drawing.Point(909, 162)
        Me.nat_chk.Name = "nat_chk"
        Me.nat_chk.Size = New System.Drawing.Size(169, 21)
        Me.nat_chk.TabIndex = 69
        Me.nat_chk.Title = "외국인"
        Me.nat_chk.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(805, 58)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(146, 38)
        Me.btn_send.TabIndex = 8
        Me.btn_send.Text = "E-mail 보내기"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(1109, 137)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(162, 21)
        Me.dept_cd.TabIndex = 70
        Me.dept_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dept_cd.Title = "부서"
        Me.dept_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(268, 78)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 7
        Me.emp_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.emp_nm.Title = "사원명(%)"
        Me.emp_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(16, 78)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 5
        Me.dept_nm.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.dept_nm.Title = "부서"
        Me.dept_nm.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'co_mail_yn
        '
        Me.co_mail_yn.Caption = ""
        Me.co_mail_yn.Location = New System.Drawing.Point(970, 73)
        Me.co_mail_yn.Name = "co_mail_yn"
        Me.co_mail_yn.Size = New System.Drawing.Size(108, 21)
        Me.co_mail_yn.TabIndex = 9
        Me.co_mail_yn.Title = "회사메일서버"
        Me.co_mail_yn.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.co_mail_yn.TitleWidth = 80
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Location = New System.Drawing.Point(670, 73)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(108, 21)
        Me.all_chk.TabIndex = 9
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.all_chk.TitleWidth = 80
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(16, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 2
        Me.bs_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.bs_cd.Title = "사업장"
        Me.bs_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(16, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.co_cd.Title = "법인"
        Me.co_cd.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'pay_mon
        '
        Me.pay_mon.Location = New System.Drawing.Point(268, 28)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(240, 21)
        Me.pay_mon.TabIndex = 3
        Me.pay_mon.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pay_mon.Title = "기준월"
        Me.pay_mon.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1329, 297)
        Me.SplitContainer2.SplitterDistance = 708
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(708, 297)
        Me.EPanel1.TabIndex = 9
        Me.EPanel1.Text = "     사원선택"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(704, 272)
        Me.g10.TabIndex = 4
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.PrintControl1)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(617, 297)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     EPanel2"
        '
        'PrintControl1
        '
        Me.PrintControl1.BackColor = System.Drawing.Color.Empty
        Me.PrintControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintControl1.ForeColor = System.Drawing.Color.Empty
        Me.PrintControl1.IsMetric = True
        Me.PrintControl1.Location = New System.Drawing.Point(2, 23)
        Me.PrintControl1.Name = "PrintControl1"
        Me.PrintControl1.SelectedPageBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PrintControl1.Size = New System.Drawing.Size(613, 272)
        Me.PrintControl1.TabIndex = 2
        Me.PrintControl1.TooltipFont = New System.Drawing.Font("Tahoma", 9.0!)
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Location = New System.Drawing.Point(875, 79)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(240, 21)
        Me.ECheck1.TabIndex = 74
        '
        'PAB120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAB120"
        Me.Size = New System.Drawing.Size(1329, 411)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents nat_chk As Frame7.eCheck
    Friend WithEvents btn_send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents all_chk As Frame7.eCheck
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents pay_sq As Frame7.eCombo
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents p_pw As Frame7.eText
    Friend WithEvents email As Frame7.eText
    Friend WithEvents smtphost As Frame7.eText
    Friend WithEvents port As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents PrintControl1 As DevExpress.XtraPrinting.Control.PrintControl
    Friend WithEvents co_mail_yn As Frame7.eCheck
    Friend WithEvents ECheck1 As Frame7.eCheck
    'Friend WithEvents CachedGAD102R1 As System8.CachedGAD102R

End Class
