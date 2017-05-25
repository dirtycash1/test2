<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_TR2150
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
        Me.g_retrieve = New Frame7.eGrid()
        Me.bi_fdt = New Frame7.eDate()
        Me.bi_tdt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_retrieve)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 118
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bi_fdt)
        Me.EPanel1.Controls.Add(Me.bi_tdt)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 118)
        Me.EPanel1.TabIndex = 11
        Me.EPanel1.Text = "     비용 현황"
        '
        'g_retrieve
        '
        Me.g_retrieve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_retrieve.Location = New System.Drawing.Point(0, 0)
        Me.g_retrieve.Name = "g_retrieve"
        Me.g_retrieve.ReadOnly = False
        Me.g_retrieve.RowHeight = -1
        Me.g_retrieve.Size = New System.Drawing.Size(1182, 489)
        Me.g_retrieve.TabIndex = 2
        '
        'bi_fdt
        '
        Me.bi_fdt.Location = New System.Drawing.Point(14, 42)
        Me.bi_fdt.Name = "bi_fdt"
        Me.bi_fdt.Size = New System.Drawing.Size(198, 21)
        Me.bi_fdt.TabIndex = 119
        Me.bi_fdt.Title = "기간"
        Me.bi_fdt.TitleWidth = 98
        '
        'bi_tdt
        '
        Me.bi_tdt.Location = New System.Drawing.Point(218, 42)
        Me.bi_tdt.Name = "bi_tdt"
        Me.bi_tdt.Size = New System.Drawing.Size(120, 21)
        Me.bi_tdt.TabIndex = 120
        Me.bi_tdt.Title = "~"
        Me.bi_tdt.TitleWidth = 20
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(218, 69)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(323, 21)
        Me.cs_nm.TabIndex = 117
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 80
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(14, 69)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(198, 21)
        Me.cs_cd.TabIndex = 118
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 98
        '
        'WP_TR2150
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_TR2150"
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
    Friend WithEvents g_retrieve As Frame7.eGrid
    Friend WithEvents bi_fdt As Frame7.eDate
    Friend WithEvents bi_tdt As Frame7.eDate
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText

End Class
