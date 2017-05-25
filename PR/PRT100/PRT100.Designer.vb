<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRT100
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
        Me.img = New Frame7.eImage()
        Me.gd_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.sh_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.go_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.emp_nm = New Frame7.eText()
        Me.pl_nm = New Frame7.eText()
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
        Me.emp_no.Location = New System.Drawing.Point(17, 66)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(147, 21)
        Me.emp_no.TabIndex = 7
        Me.emp_no.Title = "작성자"
        Me.emp_no.TitleWidth = 70
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
        Me.EPanel1.Controls.Add(Me.img)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.go_gw)
        Me.EPanel1.Controls.Add(Me.pl_nm)
        Me.EPanel1.Controls.Add(Me.sh_gw)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1401, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(1132, 3)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(210, 140)
        Me.img.SizeMode = Frame7.ImageSizeMode.Stretch
        Me.img.TabIndex = 109
        Me.img.TitleBorderStyle = Frame7.BorderStyle.None
        Me.img.Visible = False
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(376, 66)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(177, 21)
        Me.gd_nm.TabIndex = 108
        Me.gd_nm.Title = "제품명"
        Me.gd_nm.TitleWidth = 70
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
        Me.fr_dt.Title = "DATE"
        Me.fr_dt.TitleWidth = 70
        '
        'sh_gw
        '
        Me.sh_gw.Location = New System.Drawing.Point(753, 42)
        Me.sh_gw.Name = "sh_gw"
        Me.sh_gw.Size = New System.Drawing.Size(112, 45)
        Me.sh_gw.TabIndex = 103
        Me.sh_gw.Text = "결재조회"
        '
        'go_gw
        '
        Me.go_gw.Location = New System.Drawing.Point(635, 42)
        Me.go_gw.Name = "go_gw"
        Me.go_gw.Size = New System.Drawing.Size(112, 45)
        Me.go_gw.TabIndex = 102
        Me.go_gw.Text = "결재상신"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(95, 66)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(168, 21)
        Me.emp_nm.TabIndex = 9
        Me.emp_nm.Title = "요청자명"
        Me.emp_nm.TitleWidth = 70
        '
        'pl_nm
        '
        Me.pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_nm.Location = New System.Drawing.Point(376, 39)
        Me.pl_nm.Name = "pl_nm"
        Me.pl_nm.Size = New System.Drawing.Size(177, 21)
        Me.pl_nm.TabIndex = 106
        Me.pl_nm.Title = "제작처"
        Me.pl_nm.TitleWidth = 70
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
        Me.EPanel2.Text = "     인쇄시방서"
        '
        'PRT100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PRT100"
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
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents sh_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents go_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pl_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents img As Frame7.eImage

End Class
