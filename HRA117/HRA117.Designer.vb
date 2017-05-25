<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRA117
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.to_mon = New Frame7.eDate()
        Me.fr_mon = New Frame7.eDate()
        Me.bs_cd = New Frame7.eCheckCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.work_bs = New Frame7.eCombo()
        Me.work_kd = New Frame7.eCheckCombo()
        Me.emp_no = New Frame7.eText()
        Me.work_bc = New Frame7.eCheckCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.chk_hire = New Frame7.eCheck()
        Me.chk_retr = New Frame7.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1265, 405)
        Me.SplitContainer1.SplitterDistance = 132
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.to_mon)
        Me.EPanel3.Controls.Add(Me.fr_mon)
        Me.EPanel3.Controls.Add(Me.chk_retr)
        Me.EPanel3.Controls.Add(Me.chk_hire)
        Me.EPanel3.Controls.Add(Me.bs_cd)
        Me.EPanel3.Controls.Add(Me.co_cd)
        Me.EPanel3.Controls.Add(Me.work_bs)
        Me.EPanel3.Controls.Add(Me.work_kd)
        Me.EPanel3.Controls.Add(Me.emp_no)
        Me.EPanel3.Controls.Add(Me.work_bc)
        Me.EPanel3.Controls.Add(Me.fac_cd)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.emp_nm)
        Me.EPanel3.Controls.Add(Me.dept_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1265, 132)
        Me.EPanel3.TabIndex = 63
        Me.EPanel3.Text = "     사원정보"
        '
        'to_mon
        '
        Me.to_mon.Location = New System.Drawing.Point(267, 52)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(240, 21)
        Me.to_mon.TabIndex = 131
        '
        'fr_mon
        '
        Me.fr_mon.Location = New System.Drawing.Point(267, 28)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(240, 21)
        Me.fr_mon.TabIndex = 130
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 129
        Me.bs_cd.Title = "bs_cd"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 110
        Me.co_cd.Title = "법인"
        '
        'work_bs
        '
        Me.work_bs.Location = New System.Drawing.Point(8, 76)
        Me.work_bs.Name = "work_bs"
        Me.work_bs.Size = New System.Drawing.Size(240, 21)
        Me.work_bs.TabIndex = 105
        Me.work_bs.Title = "근무사업장"
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(529, 28)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(240, 21)
        Me.work_kd.TabIndex = 121
        Me.work_kd.Title = "work_kd"
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(267, 76)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 108
        Me.emp_no.Title = "사원코드(%)"
        '
        'work_bc
        '
        Me.work_bc.Location = New System.Drawing.Point(529, 52)
        Me.work_bc.Name = "work_bc"
        Me.work_bc.Size = New System.Drawing.Size(240, 21)
        Me.work_bc.TabIndex = 121
        Me.work_bc.Title = "work_bc"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 100)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 105
        Me.fac_cd.Title = "근무공장"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(529, 100)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 80
        Me.dept_nm.Title = "부서명"
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(267, 100)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 63
        Me.emp_nm.Title = "사원명(%)"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(529, 76)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 109
        Me.dept_cd.Title = "부서명"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1265, 269)
        Me.g10.TabIndex = 0
        '
        'chk_hire
        '
        Me.chk_hire.Caption = ""
        Me.chk_hire.Location = New System.Drawing.Point(784, 28)
        Me.chk_hire.Name = "chk_hire"
        Me.chk_hire.Size = New System.Drawing.Size(159, 21)
        Me.chk_hire.TabIndex = 132
        Me.chk_hire.Title = "입사자 만"
        '
        'chk_retr
        '
        Me.chk_retr.Caption = ""
        Me.chk_retr.Location = New System.Drawing.Point(784, 55)
        Me.chk_retr.Name = "chk_retr"
        Me.chk_retr.Size = New System.Drawing.Size(159, 21)
        Me.chk_retr.TabIndex = 133
        Me.chk_retr.Title = "퇴사자 만"
        '
        'HRA117
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRA117"
        Me.Size = New System.Drawing.Size(1265, 405)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents work_bs As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents work_bc As Frame7.eCheckCombo
    Friend WithEvents work_kd As Frame7.eCheckCombo
    Friend WithEvents bs_cd As Frame7.eCheckCombo
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents to_mon As Frame7.eDate
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents chk_retr As Frame7.eCheck
    Friend WithEvents chk_hire As Frame7.eCheck

End Class
