<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRK270
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
        Me.chk = New Frame7.eCheck()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.dept_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
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
        Me.g10.Size = New System.Drawing.Size(1046, 503)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.chk)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.CompuText = Nothing
        Me.chk.Location = New System.Drawing.Point(8, 76)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(240, 21)
        Me.chk.TabIndex = 11
        Me.chk.Title = "퇴사자제외"
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
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 528)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     상세정보등록"
        '
        'co_cd
        '
        Me.co_cd.CompuText = Nothing
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 75
        Me.co_cd.Title = "법인"
        '
        'emp_no
        '
        Me.emp_no.CompuText = Nothing
        Me.emp_no.Location = New System.Drawing.Point(520, 28)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 72
        Me.emp_no.Title = "사원코드(%)"
        '
        'emp_nm
        '
        Me.emp_nm.CompuText = Nothing
        Me.emp_nm.Location = New System.Drawing.Point(520, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 74
        Me.emp_nm.Title = "사원명(%)"
        '
        'bs_cd
        '
        Me.bs_cd.CompuText = Nothing
        Me.bs_cd.Location = New System.Drawing.Point(8, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 67
        Me.bs_cd.Title = "사업장"
        '
        'to_dt
        '
        Me.to_dt.CompuText = Nothing
        Me.to_dt.Location = New System.Drawing.Point(776, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 71
        Me.to_dt.Title = "검진일자(to)"
        '
        'dept_cd
        '
        Me.dept_cd.CompuText = Nothing
        Me.dept_cd.Location = New System.Drawing.Point(264, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 68
        Me.dept_cd.Title = "부서"
        '
        'fr_dt
        '
        Me.fr_dt.CompuText = Nothing
        Me.fr_dt.Location = New System.Drawing.Point(776, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 69
        Me.fr_dt.Title = "검진일자(fr)"
        '
        'dept_nm
        '
        Me.dept_nm.CompuText = Nothing
        Me.dept_nm.Location = New System.Drawing.Point(264, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 73
        Me.dept_nm.Title = "부서명"
        '
        'HRK270
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRK270"
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
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText

End Class
