<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1661
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
        Me.find_nm_gu = New Frame7.eCombo()
        Me.g_list = New Frame7.eGrid()
        Me.find_plcd_gu = New Frame7.eCombo()
        Me.find_sale_gu = New Frame7.eCombo()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_plcd_gu)
        Me.EPanel1.Controls.Add(Me.find_sale_gu)
        Me.EPanel1.Controls.Add(Me.find_nm_cd)
        Me.EPanel1.Controls.Add(Me.find_nm_nm)
        Me.EPanel1.Controls.Add(Me.find_nm_gu)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 77)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     "
        '
        'find_nm_gu
        '
        Me.find_nm_gu.Location = New System.Drawing.Point(46, 37)
        Me.find_nm_gu.Name = "find_nm_gu"
        Me.find_nm_gu.Size = New System.Drawing.Size(180, 21)
        Me.find_nm_gu.TabIndex = 74
        Me.find_nm_gu.Title = "제품구분"
        Me.find_nm_gu.TitleWidth = 80
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(1182, 530)
        Me.g_list.TabIndex = 0
        '
        'find_plcd_gu
        '
        Me.find_plcd_gu.Location = New System.Drawing.Point(515, 53)
        Me.find_plcd_gu.Name = "find_plcd_gu"
        Me.find_plcd_gu.Size = New System.Drawing.Size(240, 21)
        Me.find_plcd_gu.TabIndex = 78
        Me.find_plcd_gu.Title = "생산과구분"
        Me.find_plcd_gu.TitleWidth = 98
        '
        'find_sale_gu
        '
        Me.find_sale_gu.Location = New System.Drawing.Point(515, 26)
        Me.find_sale_gu.Name = "find_sale_gu"
        Me.find_sale_gu.Size = New System.Drawing.Size(240, 21)
        Me.find_sale_gu.TabIndex = 77
        Me.find_sale_gu.Title = "판매구분"
        Me.find_sale_gu.TitleWidth = 98
        '
        'find_nm_cd
        '
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(258, 26)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(240, 21)
        Me.find_nm_cd.TabIndex = 75
        Me.find_nm_cd.Title = "코 드"
        Me.find_nm_cd.TitleWidth = 98
        '
        'find_nm_nm
        '
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(258, 51)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(240, 21)
        Me.find_nm_nm.TabIndex = 76
        Me.find_nm_nm.Title = "제품명"
        Me.find_nm_nm.TitleWidth = 98
        '
        'WI_CO1661
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_CO1661"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents find_nm_gu As Frame7.eCombo
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents find_plcd_gu As Frame7.eCombo
    Friend WithEvents find_sale_gu As Frame7.eCombo
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_nm_nm As Frame7.eText

End Class
