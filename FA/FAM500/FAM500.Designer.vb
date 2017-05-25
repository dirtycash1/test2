<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAM500
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
        Me.co_cd = New Frame7.eCombo()
        Me.bud_yy = New Frame7.eDate()
        Me.bud_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.dept_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.acc_nm = New Frame7.eText()
        Me.acc_cd = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 516)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.acc_nm)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.bud_yy)
        Me.EPanel1.Controls.Add(Me.bud_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(900, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 11
        Me.co_cd.Title = "법인"
        '
        'bud_yy
        '
        Me.bud_yy.Format = "yyyy"
        Me.bud_yy.Location = New System.Drawing.Point(12, 52)
        Me.bud_yy.Name = "bud_yy"
        Me.bud_yy.Size = New System.Drawing.Size(240, 21)
        Me.bud_yy.TabIndex = 5
        Me.bud_yy.Title = "예산년도"
        '
        'bud_bc
        '
        Me.bud_bc.Location = New System.Drawing.Point(12, 76)
        Me.bud_bc.Name = "bud_bc"
        Me.bud_bc.Size = New System.Drawing.Size(240, 21)
        Me.bud_bc.TabIndex = 3
        Me.bud_bc.Title = "예산구분"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(900, 408)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     계정별 년간 예산 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(896, 383)
        Me.g10.TabIndex = 2
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(516, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(120, 21)
        Me.dept_nm.TabIndex = 81
        Me.dept_nm.Title = "일수"
        Me.dept_nm.TitleWidth = 0
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(272, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 80
        Me.dept_cd.Title = "예산부서"
        '
        'acc_nm
        '
        Me.acc_nm.Location = New System.Drawing.Point(516, 76)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(120, 21)
        Me.acc_nm.TabIndex = 83
        Me.acc_nm.Title = "일수"
        Me.acc_nm.TitleWidth = 0
        '
        'acc_cd
        '
        Me.acc_cd.Location = New System.Drawing.Point(272, 76)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd.TabIndex = 82
        Me.acc_cd.Title = "계정코드"
        '
        'FAM500
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAM500"
        Me.Size = New System.Drawing.Size(977, 563)
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
    Friend WithEvents bud_bc As Frame7.eCombo
    Friend WithEvents bud_yy As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText

End Class
