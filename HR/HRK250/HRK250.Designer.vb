<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRK250
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
        Me.g10 = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.pass_bc = New Frame7.eCombo()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.bs_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.chk = New Frame7.eCheck()
        Me.fr1_dt = New Frame7.eDate()
        Me.emp_no = New Frame7.eText()
        Me.to1_dt = New Frame7.eDate()
        Me.emp_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 479)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.chk)
        Me.EPanel1.Controls.Add(Me.fr1_dt)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.to1_dt)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.pass_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 128)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'pass_bc
        '
        Me.pass_bc.CompuText = Nothing
        Me.pass_bc.Location = New System.Drawing.Point(12, 76)
        Me.pass_bc.Name = "pass_bc"
        Me.pass_bc.Size = New System.Drawing.Size(240, 21)
        Me.pass_bc.TabIndex = 10
        Me.pass_bc.Title = "여권비자구분"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 504)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     상세정보등록"
        '
        'co_cd
        '
        Me.co_cd.CompuText = Nothing
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 23
        Me.co_cd.Title = "법인"
        '
        'fr_dt
        '
        Me.fr_dt.CompuText = Nothing
        Me.fr_dt.Location = New System.Drawing.Point(524, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 16
        Me.fr_dt.Title = "발급일자(fr)"
        '
        'bs_cd
        '
        Me.bs_cd.CompuText = Nothing
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 13
        Me.bs_cd.Title = "사업장"
        '
        'dept_cd
        '
        Me.dept_cd.CompuText = Nothing
        Me.dept_cd.Location = New System.Drawing.Point(268, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 14
        Me.dept_cd.Title = "부서"
        '
        'to_dt
        '
        Me.to_dt.CompuText = Nothing
        Me.to_dt.Location = New System.Drawing.Point(524, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 18
        Me.to_dt.Title = "발급일자(to)"
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.CompuText = Nothing
        Me.chk.Location = New System.Drawing.Point(12, 100)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(240, 21)
        Me.chk.TabIndex = 22
        Me.chk.Title = "퇴사자제외"
        '
        'fr1_dt
        '
        Me.fr1_dt.CompuText = Nothing
        Me.fr1_dt.Location = New System.Drawing.Point(524, 76)
        Me.fr1_dt.Name = "fr1_dt"
        Me.fr1_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr1_dt.TabIndex = 15
        Me.fr1_dt.Title = "만료일자(fr)"
        '
        'emp_no
        '
        Me.emp_no.CompuText = Nothing
        Me.emp_no.Location = New System.Drawing.Point(268, 76)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 19
        Me.emp_no.Title = "사원코드(%)"
        '
        'to1_dt
        '
        Me.to1_dt.CompuText = Nothing
        Me.to1_dt.Location = New System.Drawing.Point(524, 100)
        Me.to1_dt.Name = "to1_dt"
        Me.to1_dt.Size = New System.Drawing.Size(240, 21)
        Me.to1_dt.TabIndex = 17
        Me.to1_dt.Title = "만료일자(to)"
        '
        'emp_nm
        '
        Me.emp_nm.CompuText = Nothing
        Me.emp_nm.Location = New System.Drawing.Point(268, 100)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 21
        Me.emp_nm.Title = "사원명(%)"
        '
        'dept_nm
        '
        Me.dept_nm.CompuText = Nothing
        Me.dept_nm.Location = New System.Drawing.Point(268, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 20
        Me.dept_nm.Title = "부서명"
        '
        'HRK250
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRK250"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents pass_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents fr1_dt As Frame7.eDate
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents to1_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText

End Class
