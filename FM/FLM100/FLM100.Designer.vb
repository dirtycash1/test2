<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLM100
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
        Me.emp_no = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.sh_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.go_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.pr_nm = New Frame7.eText()
        Me.re_dept = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.re_dept_nm = New Frame7.eText()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(394, 39)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(147, 21)
        Me.emp_no.TabIndex = 7
        Me.emp_no.Title = "요청자"
        Me.emp_no.TitleWidth = 60
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1397, 504)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.pr_nm)
        Me.EPanel1.Controls.Add(Me.sh_gw)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.go_gw)
        Me.EPanel1.Controls.Add(Me.re_dept)
        Me.EPanel1.Controls.Add(Me.re_dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1401, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(200, 39)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(122, 21)
        Me.to_dt.TabIndex = 107
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(17, 39)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(177, 21)
        Me.fr_dt.TabIndex = 4
        Me.fr_dt.Title = "요청 일자"
        Me.fr_dt.TitleWidth = 70
        '
        'sh_gw
        '
        Me.sh_gw.Location = New System.Drawing.Point(845, 39)
        Me.sh_gw.Name = "sh_gw"
        Me.sh_gw.Size = New System.Drawing.Size(112, 45)
        Me.sh_gw.TabIndex = 103
        Me.sh_gw.Text = "결재조회"
        '
        'go_gw
        '
        Me.go_gw.Location = New System.Drawing.Point(727, 39)
        Me.go_gw.Name = "go_gw"
        Me.go_gw.Size = New System.Drawing.Size(112, 45)
        Me.go_gw.TabIndex = 102
        Me.go_gw.Text = "결재상신"
        '
        'pr_nm
        '
        Me.pr_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pr_nm.Location = New System.Drawing.Point(17, 66)
        Me.pr_nm.Name = "pr_nm"
        Me.pr_nm.Size = New System.Drawing.Size(177, 21)
        Me.pr_nm.TabIndex = 106
        Me.pr_nm.Title = "제품명"
        Me.pr_nm.TitleWidth = 70
        '
        're_dept
        '
        Me.re_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.re_dept.Location = New System.Drawing.Point(385, 66)
        Me.re_dept.Name = "re_dept"
        Me.re_dept.Size = New System.Drawing.Size(156, 21)
        Me.re_dept.TabIndex = 3
        Me.re_dept.Title = "의뢰 부서"
        Me.re_dept.TitleWidth = 70
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(472, 39)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(180, 21)
        Me.emp_nm.TabIndex = 9
        Me.emp_nm.Title = "요청자명"
        Me.emp_nm.TitleWidth = 70
        '
        're_dept_nm
        '
        Me.re_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.re_dept_nm.Location = New System.Drawing.Point(473, 66)
        Me.re_dept_nm.Name = "re_dept_nm"
        Me.re_dept_nm.Size = New System.Drawing.Size(179, 21)
        Me.re_dept_nm.TabIndex = 8
        Me.re_dept_nm.Title = "의뢰부서명"
        Me.re_dept_nm.TitleWidth = 70
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1401, 636)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1401, 529)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     필름교체 의뢰등록"
        '
        'FLM100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FLM100"
        Me.Size = New System.Drawing.Size(1401, 636)
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
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents re_dept As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents re_dept_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents sh_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents go_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pr_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate

End Class
