<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FA_AGB140
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
        Me.accnt = New Frame7.eText()
        Me.accnt_name = New Frame7.eText()
        Me.div_cd = New Frame7.eCombo()
        Me.custom_cd = New Frame7.eText()
        Me.custom_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.to_ac_dt = New Frame7.eDate()
        Me.fr_ac_dt = New Frame7.eDate()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1052, 558)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.accnt)
        Me.EPanel1.Controls.Add(Me.accnt_name)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.custom_cd)
        Me.EPanel1.Controls.Add(Me.custom_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.to_ac_dt)
        Me.EPanel1.Controls.Add(Me.fr_ac_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1052, 116)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     UniLite 계정명세"
        '
        'accnt
        '
        Me.accnt.Location = New System.Drawing.Point(18, 71)
        Me.accnt.Name = "accnt"
        Me.accnt.Size = New System.Drawing.Size(195, 21)
        Me.accnt.TabIndex = 63
        Me.accnt.Title = "계정과목(unilite)"
        Me.accnt.TitleWidth = 100
        '
        'accnt_name
        '
        Me.accnt_name.Location = New System.Drawing.Point(217, 71)
        Me.accnt_name.Name = "accnt_name"
        Me.accnt_name.Size = New System.Drawing.Size(129, 21)
        Me.accnt_name.TabIndex = 64
        Me.accnt_name.Title = "nacs_nm"
        Me.accnt_name.TitleWidth = 0
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(394, 35)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(158, 21)
        Me.div_cd.TabIndex = 62
        Me.div_cd.Title = "사업장"
        Me.div_cd.TitleWidth = 60
        '
        'custom_cd
        '
        Me.custom_cd.Location = New System.Drawing.Point(702, 71)
        Me.custom_cd.Name = "custom_cd"
        Me.custom_cd.Size = New System.Drawing.Size(172, 21)
        Me.custom_cd.TabIndex = 55
        Me.custom_cd.Title = "거래처"
        Me.custom_cd.TitleWidth = 80
        '
        'custom_nm
        '
        Me.custom_nm.Location = New System.Drawing.Point(880, 71)
        Me.custom_nm.Name = "custom_nm"
        Me.custom_nm.Size = New System.Drawing.Size(129, 21)
        Me.custom_nm.TabIndex = 56
        Me.custom_nm.Title = "nacs_nm"
        Me.custom_nm.TitleWidth = 0
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(702, 35)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(172, 21)
        Me.dept_cd.TabIndex = 53
        Me.dept_cd.Title = "입력부서"
        Me.dept_cd.TitleWidth = 80
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(880, 35)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(129, 21)
        Me.dept_nm.TabIndex = 54
        Me.dept_nm.Title = "nacs_nm"
        Me.dept_nm.TitleWidth = 0
        '
        'to_ac_dt
        '
        Me.to_ac_dt.Location = New System.Drawing.Point(216, 35)
        Me.to_ac_dt.Name = "to_ac_dt"
        Me.to_ac_dt.Size = New System.Drawing.Size(137, 21)
        Me.to_ac_dt.TabIndex = 39
        Me.to_ac_dt.Title = "~"
        Me.to_ac_dt.TitleWidth = 20
        '
        'fr_ac_dt
        '
        Me.fr_ac_dt.Location = New System.Drawing.Point(18, 35)
        Me.fr_ac_dt.Name = "fr_ac_dt"
        Me.fr_ac_dt.Size = New System.Drawing.Size(192, 21)
        Me.fr_ac_dt.TabIndex = 38
        Me.fr_ac_dt.Title = "전표일자"
        Me.fr_ac_dt.TitleWidth = 75
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1052, 438)
        Me.g10.TabIndex = 0
        '
        'FA_AGB140
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FA_AGB140"
        Me.Size = New System.Drawing.Size(1052, 558)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_ac_dt As Frame7.eDate
    Friend WithEvents fr_ac_dt As Frame7.eDate
    Friend WithEvents custom_cd As Frame7.eText
    Friend WithEvents custom_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents accnt As Frame7.eText
    Friend WithEvents accnt_name As Frame7.eText

End Class
