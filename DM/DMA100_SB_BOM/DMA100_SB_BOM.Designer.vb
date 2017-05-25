<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMA100_SB_BOM
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.f_nm_nm = New Frame7.eText()
        Me.f_nm_cd = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.panel22 = New Frame7.ePanel()
        Me.rmk = New Frame7.eText()
        Me.pk_list = New Frame7.eText()
        Me.nm_nm = New Frame7.eText()
        Me.nm_cd = New Frame7.eText()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.panel22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel22.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 324
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(324, 611)
        Me.SplitContainer2.SplitterDistance = 141
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_nm_cd)
        Me.EPanel1.Controls.Add(Me.f_nm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(324, 141)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색조건"
        '
        'f_nm_nm
        '
        Me.f_nm_nm.Location = New System.Drawing.Point(79, 75)
        Me.f_nm_nm.Name = "f_nm_nm"
        Me.f_nm_nm.Size = New System.Drawing.Size(178, 21)
        Me.f_nm_nm.TabIndex = 93
        Me.f_nm_nm.Title = "품명"
        Me.f_nm_nm.TitleWidth = 0
        '
        'f_nm_cd
        '
        Me.f_nm_cd.Location = New System.Drawing.Point(17, 48)
        Me.f_nm_cd.Name = "f_nm_cd"
        Me.f_nm_cd.Size = New System.Drawing.Size(178, 21)
        Me.f_nm_cd.TabIndex = 92
        Me.f_nm_cd.Title = "품목코드"
        Me.f_nm_cd.TitleWidth = 60
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(324, 466)
        Me.g10.TabIndex = 4
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.panel22)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(854, 611)
        Me.SplitContainer3.SplitterDistance = 142
        Me.SplitContainer3.TabIndex = 0
        '
        'panel22
        '
        Me.panel22.Controls.Add(Me.rmk)
        Me.panel22.Controls.Add(Me.pk_list)
        Me.panel22.Controls.Add(Me.nm_nm)
        Me.panel22.Controls.Add(Me.nm_cd)
        Me.panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel22.Location = New System.Drawing.Point(0, 0)
        Me.panel22.Name = "panel22"
        Me.panel22.Size = New System.Drawing.Size(854, 142)
        Me.panel22.TabIndex = 2
        Me.panel22.Text = "     제품 시방서 정보"
        '
        'rmk
        '
        Me.rmk.Location = New System.Drawing.Point(19, 91)
        Me.rmk.Name = "rmk"
        Me.rmk.Size = New System.Drawing.Size(390, 21)
        Me.rmk.TabIndex = 96
        Me.rmk.Title = "특이사항"
        Me.rmk.TitleWidth = 80
        '
        'pk_list
        '
        Me.pk_list.Location = New System.Drawing.Point(19, 64)
        Me.pk_list.Name = "pk_list"
        Me.pk_list.Size = New System.Drawing.Size(268, 21)
        Me.pk_list.TabIndex = 95
        Me.pk_list.Title = "패킹리스트"
        Me.pk_list.TitleWidth = 80
        '
        'nm_nm
        '
        Me.nm_nm.Location = New System.Drawing.Point(231, 37)
        Me.nm_nm.Name = "nm_nm"
        Me.nm_nm.Size = New System.Drawing.Size(178, 21)
        Me.nm_nm.TabIndex = 94
        Me.nm_nm.Title = "품명"
        Me.nm_nm.TitleWidth = 0
        '
        'nm_cd
        '
        Me.nm_cd.Location = New System.Drawing.Point(19, 37)
        Me.nm_cd.Name = "nm_cd"
        Me.nm_cd.Size = New System.Drawing.Size(206, 21)
        Me.nm_cd.TabIndex = 67
        Me.nm_cd.Title = "품목코드"
        Me.nm_cd.TitleWidth = 80
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(854, 465)
        Me.g20.TabIndex = 4
        '
        'DMA100_SB_BOM
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMA100_SB_BOM"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.panel22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel22.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents panel22 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents f_nm_nm As Frame7.eText
    Friend WithEvents f_nm_cd As Frame7.eText
    Friend WithEvents nm_cd As Frame7.eText
    Friend WithEvents nm_nm As Frame7.eText
    Friend WithEvents pk_list As Frame7.eText
    Friend WithEvents rmk As Frame7.eText

End Class
