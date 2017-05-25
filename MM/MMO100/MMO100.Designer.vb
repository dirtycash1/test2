<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMO100
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EPanel1 = New Frame7.ePanel
        Me.out_dt = New Frame7.eDate
        Me.fac_cd = New Frame7.eCombo
        Me.dept_cd = New Frame7.eText
        Me.wh_cd = New Frame7.eCombo
        Me.id = New Frame7.eText
        Me.out_bc = New Frame7.eCombo
        Me.dept_nm = New Frame7.eText
        Me.out_no = New Frame7.eText
        Me.nm = New Frame7.eText
        Me.reg_id = New Frame7.eText
        Me.EPanel2 = New Frame7.ePanel
        Me.g10 = New Frame7.eGrid
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
        Me.SplitContainer1.Size = New System.Drawing.Size(920, 360)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.out_dt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.id)
        Me.EPanel1.Controls.Add(Me.out_bc)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.out_no)
        Me.EPanel1.Controls.Add(Me.nm)
        Me.EPanel1.Controls.Add(Me.reg_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(920, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'out_dt
        '
        Me.out_dt.Location = New System.Drawing.Point(12, 52)
        Me.out_dt.Name = "out_dt"
        Me.out_dt.Size = New System.Drawing.Size(240, 21)
        Me.out_dt.TabIndex = 5
        Me.out_dt.Title = "출고일자"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(268, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 3
        Me.fac_cd.Title = "출고공장"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(528, 28)
        Me.dept_cd.MaxLength = 0
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 2
        Me.dept_cd.Title = "출고부서"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(268, 52)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 3
        Me.wh_cd.Title = "출고창고"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(528, 52)
        Me.id.MaxLength = 0
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(240, 21)
        Me.id.TabIndex = 2
        Me.id.Title = "출고자"
        '
        'out_bc
        '
        Me.out_bc.Location = New System.Drawing.Point(268, 76)
        Me.out_bc.Name = "out_bc"
        Me.out_bc.Size = New System.Drawing.Size(240, 21)
        Me.out_bc.TabIndex = 3
        Me.out_bc.Title = "출고구분"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(772, 28)
        Me.dept_nm.MaxLength = 0
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(120, 21)
        Me.dept_nm.TabIndex = 2
        Me.dept_nm.Title = "출고번호"
        Me.dept_nm.TitleWidth = 0
        '
        'out_no
        '
        Me.out_no.Location = New System.Drawing.Point(12, 28)
        Me.out_no.MaxLength = 0
        Me.out_no.Name = "out_no"
        Me.out_no.Size = New System.Drawing.Size(240, 21)
        Me.out_no.TabIndex = 2
        Me.out_no.Title = "출고번호"
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(772, 52)
        Me.nm.MaxLength = 0
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(120, 21)
        Me.nm.TabIndex = 2
        Me.nm.Title = "출고번호"
        Me.nm.TitleWidth = 0
        '
        'reg_id
        '
        Me.reg_id.Location = New System.Drawing.Point(896, 52)
        Me.reg_id.MaxLength = 0
        Me.reg_id.Name = "reg_id"
        Me.reg_id.Size = New System.Drawing.Size(20, 21)
        Me.reg_id.TabIndex = 2
        Me.reg_id.Title = "출고번호"
        Me.reg_id.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(920, 252)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     출고상세정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(916, 227)
        Me.g10.TabIndex = 2
        '
        'MMO100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMO100"
        Me.Size = New System.Drawing.Size(971, 411)
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
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents out_no As Frame7.eText
    Friend WithEvents out_dt As Frame7.eDate
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents id As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents reg_id As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents out_bc As Frame7.eCombo

End Class
