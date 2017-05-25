<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAB120_2
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
        Me.pay_sq = New Frame7.eCombo()
        Me.nat_chk = New Frame7.eCheck()
        Me.dept_nm = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.co_cd = New Frame7.eCombo()
        Me.btn_send = New DevExpress.XtraEditors.SimpleButton()
        Me.pay_mon = New Frame7.eDate()
        Me.emp_nm = New Frame7.eText()
        Me.all_chk = New Frame7.eCheck()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
        Me.g_multi = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1298, 611)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.pay_sq)
        Me.EPanel1.Controls.Add(Me.nat_chk)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.pay_mon)
        Me.EPanel1.Controls.Add(Me.btn_send)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.ProgressBar1)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1298, 97)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     급여명세서 메일 (기존 PDF)"
        '
        'pay_sq
        '
        Me.pay_sq.Location = New System.Drawing.Point(235, 57)
        Me.pay_sq.Name = "pay_sq"
        Me.pay_sq.Size = New System.Drawing.Size(204, 21)
        Me.pay_sq.TabIndex = 83
        Me.pay_sq.Title = "지급차수"
        Me.pay_sq.TitleWidth = 70
        '
        'nat_chk
        '
        Me.nat_chk.Caption = ""
        Me.nat_chk.Location = New System.Drawing.Point(829, 26)
        Me.nat_chk.Name = "nat_chk"
        Me.nat_chk.Size = New System.Drawing.Size(109, 21)
        Me.nat_chk.TabIndex = 80
        Me.nat_chk.Title = "외국인"
        Me.nat_chk.TitleWidth = 70
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(572, 30)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(214, 21)
        Me.dept_nm.TabIndex = 75
        Me.dept_nm.Title = "부서명"
        Me.dept_nm.TitleWidth = 90
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(478, 57)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(182, 21)
        Me.emp_no.TabIndex = 82
        Me.emp_no.Title = "사원번호(%)"
        Me.emp_no.TitleWidth = 90
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(478, 30)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(182, 21)
        Me.dept_cd.TabIndex = 81
        Me.dept_cd.Title = "부서코드"
        Me.dept_cd.TitleWidth = 90
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1117, 53)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(113, 20)
        Me.ProgressBar1.TabIndex = 76
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(34, 30)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(167, 21)
        Me.co_cd.TabIndex = 73
        Me.co_cd.Title = "법인"
        Me.co_cd.TitleWidth = 60
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(950, 30)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(152, 43)
        Me.btn_send.TabIndex = 78
        Me.btn_send.Text = "E-mail 보내기"
        '
        'pay_mon
        '
        Me.pay_mon.Location = New System.Drawing.Point(235, 30)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(204, 21)
        Me.pay_mon.TabIndex = 74
        Me.pay_mon.Title = "기준월"
        Me.pay_mon.TitleWidth = 70
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(582, 57)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(204, 21)
        Me.emp_nm.TabIndex = 77
        Me.emp_nm.Title = "사원명(%)"
        Me.emp_nm.TitleWidth = 80
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Location = New System.Drawing.Point(829, 53)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(115, 21)
        Me.all_chk.TabIndex = 79
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 70
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1298, 510)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1298, 510)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Location = New System.Drawing.Point(19, 41)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(210, 21)
        Me.EText3.TabIndex = 5
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "코 드"
        Me.EText3.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymentterm_nm"
        Me.EText4.Location = New System.Drawing.Point(19, 68)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(240, 21)
        Me.EText4.TabIndex = 6
        Me.EText4.TableName = "find_paymentterm_nm"
        Me.EText4.Title = "Price Term 명"
        Me.EText4.TitleWidth = 98
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(364, 41)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 7
        Me.ECombo2.Title = "사용여부"
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RecordNavigator = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 506)
        Me.g_multi.TabIndex = 2
        '
        'PAB120_2
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAB120_2"
        Me.Size = New System.Drawing.Size(1298, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents nat_chk As Frame7.eCheck
    Friend WithEvents btn_send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents all_chk As Frame7.eCheck
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents pay_sq As Frame7.eCombo

End Class
