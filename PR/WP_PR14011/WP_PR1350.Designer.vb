<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1350
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.p_gocd = New Frame7.eText()
        Me.p_from = New Frame7.eDate()
        Me.p_gonm = New Frame7.eText()
        Me.p_to = New Frame7.eDate()
        Me.p_lot = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g_result = New Frame7.eGrid()
        Me.f_gd_cd = New Frame7.eText()
        Me.f_gd_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 83
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.fac_cd)
        Me.EPanel2.Controls.Add(Me.f_gd_cd)
        Me.EPanel2.Controls.Add(Me.p_gocd)
        Me.EPanel2.Controls.Add(Me.p_from)
        Me.EPanel2.Controls.Add(Me.p_gonm)
        Me.EPanel2.Controls.Add(Me.p_to)
        Me.EPanel2.Controls.Add(Me.p_lot)
        Me.EPanel2.Controls.Add(Me.f_gd_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 83)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     검색"
        '
        'p_gocd
        '
        Me.p_gocd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_gocd.Location = New System.Drawing.Point(6, 57)
        Me.p_gocd.Name = "p_gocd"
        Me.p_gocd.Size = New System.Drawing.Size(200, 21)
        Me.p_gocd.TabIndex = 4
        Me.p_gocd.Title = "검사코드"
        Me.p_gocd.TitleWidth = 80
        '
        'p_from
        '
        Me.p_from.Location = New System.Drawing.Point(6, 27)
        Me.p_from.Name = "p_from"
        Me.p_from.Size = New System.Drawing.Size(200, 21)
        Me.p_from.TabIndex = 2
        Me.p_from.Title = "기간"
        Me.p_from.TitleWidth = 80
        '
        'p_gonm
        '
        Me.p_gonm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_gonm.Location = New System.Drawing.Point(135, 57)
        Me.p_gonm.Name = "p_gonm"
        Me.p_gonm.Size = New System.Drawing.Size(200, 21)
        Me.p_gonm.TabIndex = 4
        Me.p_gonm.Title = "검사코드"
        Me.p_gonm.TitleWidth = 80
        '
        'p_to
        '
        Me.p_to.Location = New System.Drawing.Point(135, 27)
        Me.p_to.Name = "p_to"
        Me.p_to.Size = New System.Drawing.Size(200, 21)
        Me.p_to.TabIndex = 2
        Me.p_to.TitleWidth = 80
        '
        'p_lot
        '
        Me.p_lot.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_lot.Location = New System.Drawing.Point(356, 27)
        Me.p_lot.Name = "p_lot"
        Me.p_lot.Size = New System.Drawing.Size(200, 21)
        Me.p_lot.TabIndex = 3
        Me.p_lot.Title = "LOT_NO"
        Me.p_lot.TitleWidth = 80
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g_result)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 524)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     창고별재고현황"
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(2, 23)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1178, 499)
        Me.g_result.TabIndex = 1
        '
        'f_gd_cd
        '
        Me.f_gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_gd_cd.Location = New System.Drawing.Point(356, 57)
        Me.f_gd_cd.Name = "f_gd_cd"
        Me.f_gd_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_gd_cd.TabIndex = 5
        Me.f_gd_cd.Title = "제품명"
        Me.f_gd_cd.TitleWidth = 80
        '
        'f_gd_nm
        '
        Me.f_gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_gd_nm.Location = New System.Drawing.Point(480, 57)
        Me.f_gd_nm.Name = "f_gd_nm"
        Me.f_gd_nm.Size = New System.Drawing.Size(200, 21)
        Me.f_gd_nm.TabIndex = 6
        Me.f_gd_nm.Title = "검사코드"
        Me.f_gd_nm.TitleWidth = 80
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(562, 26)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(200, 21)
        Me.fac_cd.TabIndex = 130
        Me.fac_cd.Title = "공장"
        Me.fac_cd.TitleWidth = 80
        '
        'WP_PR1350
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1350"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents p_gocd As Frame7.eText
    Friend WithEvents p_from As Frame7.eDate
    Friend WithEvents p_gonm As Frame7.eText
    Friend WithEvents p_to As Frame7.eDate
    Friend WithEvents p_lot As Frame7.eText
    Friend WithEvents f_gd_cd As Frame7.eText
    Friend WithEvents f_gd_nm As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo

End Class
