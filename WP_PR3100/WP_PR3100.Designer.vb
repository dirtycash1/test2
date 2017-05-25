<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR3100
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
        Me.mc_nm = New Frame7.eText()
        Me.mc_cd = New Frame7.eText()
        Me.to_pwer = New Frame7.eText()
        Me.fr_pwer = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.nm_nm = New Frame7.eText()
        Me.model_nm = New Frame7.eText()
        Me.nm_cd = New Frame7.eText()
        Me.model_no = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.fr_pwer2 = New Frame7.eText()
        Me.to_pwer2 = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 75
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_pwer2)
        Me.EPanel1.Controls.Add(Me.fr_pwer2)
        Me.EPanel1.Controls.Add(Me.mc_nm)
        Me.EPanel1.Controls.Add(Me.mc_cd)
        Me.EPanel1.Controls.Add(Me.to_pwer)
        Me.EPanel1.Controls.Add(Me.fr_pwer)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.nm_nm)
        Me.EPanel1.Controls.Add(Me.model_nm)
        Me.EPanel1.Controls.Add(Me.nm_cd)
        Me.EPanel1.Controls.Add(Me.model_no)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 75)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     실적조회"
        '
        'mc_nm
        '
        Me.mc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mc_nm.Location = New System.Drawing.Point(422, 54)
        Me.mc_nm.Name = "mc_nm"
        Me.mc_nm.Size = New System.Drawing.Size(155, 21)
        Me.mc_nm.TabIndex = 136
        Me.mc_nm.Title = "nm_cd"
        Me.mc_nm.TitleWidth = 60
        '
        'mc_cd
        '
        Me.mc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mc_cd.Location = New System.Drawing.Point(221, 50)
        Me.mc_cd.Name = "mc_cd"
        Me.mc_cd.Size = New System.Drawing.Size(155, 21)
        Me.mc_cd.TabIndex = 135
        Me.mc_cd.Title = "nm_cd"
        Me.mc_cd.TitleWidth = 60
        '
        'to_pwer
        '
        Me.to_pwer.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_pwer.Location = New System.Drawing.Point(1006, 26)
        Me.to_pwer.Name = "to_pwer"
        Me.to_pwer.Size = New System.Drawing.Size(171, 21)
        Me.to_pwer.TabIndex = 134
        Me.to_pwer.Title = "model_no"
        Me.to_pwer.TitleWidth = 50
        '
        'fr_pwer
        '
        Me.fr_pwer.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_pwer.Location = New System.Drawing.Point(786, 26)
        Me.fr_pwer.Name = "fr_pwer"
        Me.fr_pwer.Size = New System.Drawing.Size(214, 21)
        Me.fr_pwer.TabIndex = 132
        Me.fr_pwer.Title = "model_no"
        Me.fr_pwer.TitleWidth = 90
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(5, 50)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(210, 21)
        Me.fac_cd.TabIndex = 131
        Me.fac_cd.Title = "공정"
        Me.fac_cd.TitleWidth = 98
        '
        'nm_nm
        '
        Me.nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_nm.Location = New System.Drawing.Point(649, 50)
        Me.nm_nm.Name = "nm_nm"
        Me.nm_nm.Size = New System.Drawing.Size(120, 21)
        Me.nm_nm.TabIndex = 130
        Me.nm_nm.Title = "nm_nm"
        Me.nm_nm.TitleWidth = 0
        '
        'model_nm
        '
        Me.model_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.model_nm.Location = New System.Drawing.Point(649, 26)
        Me.model_nm.Name = "model_nm"
        Me.model_nm.Size = New System.Drawing.Size(120, 21)
        Me.model_nm.TabIndex = 129
        Me.model_nm.Title = "model_nm"
        Me.model_nm.TitleWidth = 0
        '
        'nm_cd
        '
        Me.nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm_cd.Location = New System.Drawing.Point(403, 50)
        Me.nm_cd.Name = "nm_cd"
        Me.nm_cd.Size = New System.Drawing.Size(240, 21)
        Me.nm_cd.TabIndex = 128
        Me.nm_cd.Title = "nm_cd"
        '
        'model_no
        '
        Me.model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.model_no.Location = New System.Drawing.Point(403, 26)
        Me.model_no.Name = "model_no"
        Me.model_no.Size = New System.Drawing.Size(240, 21)
        Me.model_no.TabIndex = 127
        Me.model_no.Title = "model_no"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(221, 26)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(155, 21)
        Me.to_dt.TabIndex = 126
        Me.to_dt.Title = "to_dt"
        Me.to_dt.TitleWidth = 18
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(5, 26)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(210, 21)
        Me.fr_dt.TabIndex = 125
        Me.fr_dt.Title = "fr_dt"
        Me.fr_dt.TitleWidth = 98
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 532)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     실적 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1178, 507)
        Me.g10.TabIndex = 2
        '
        'fr_pwer2
        '
        Me.fr_pwer2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_pwer2.Location = New System.Drawing.Point(786, 49)
        Me.fr_pwer2.Name = "fr_pwer2"
        Me.fr_pwer2.Size = New System.Drawing.Size(214, 21)
        Me.fr_pwer2.TabIndex = 137
        Me.fr_pwer2.Title = "model_no"
        Me.fr_pwer2.TitleWidth = 90
        '
        'to_pwer2
        '
        Me.to_pwer2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_pwer2.Location = New System.Drawing.Point(1006, 49)
        Me.to_pwer2.Name = "to_pwer2"
        Me.to_pwer2.Size = New System.Drawing.Size(171, 21)
        Me.to_pwer2.TabIndex = 138
        Me.to_pwer2.Title = "model_no"
        Me.to_pwer2.TitleWidth = 50
        '
        'WP_PR3100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR3100"
        Me.Size = New System.Drawing.Size(1182, 611)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_pwer As Frame7.eText
    Friend WithEvents fr_pwer As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents nm_nm As Frame7.eText
    Friend WithEvents model_nm As Frame7.eText
    Friend WithEvents nm_cd As Frame7.eText
    Friend WithEvents model_no As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents mc_cd As Frame7.eText
    Friend WithEvents mc_nm As Frame7.eText
    Friend WithEvents to_pwer2 As Frame7.eText
    Friend WithEvents fr_pwer2 As Frame7.eText

End Class
