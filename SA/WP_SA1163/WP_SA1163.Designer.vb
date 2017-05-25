<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1163
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
        Me.scd_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.grid1 = New Frame7.eGrid()
        Me.scd_nm = New Frame7.eText()
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
        Me.SplitContainer1.SplitterDistance = 111
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.scd_nm)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.from_dt)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.scd_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 111)
        Me.EPanel1.TabIndex = 7
        Me.EPanel1.Text = "     검색"
        '
        'scd_cd
        '
        Me.scd_cd.ColumnName = "find_paymenterm_cd"
        Me.scd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.scd_cd.Location = New System.Drawing.Point(285, 40)
        Me.scd_cd.Name = "scd_cd"
        Me.scd_cd.Size = New System.Drawing.Size(240, 21)
        Me.scd_cd.TabIndex = 126
        Me.scd_cd.TableName = "find_paymenterm_cd"
        Me.scd_cd.Title = "scd_cd"
        Me.scd_cd.TitleWidth = 98
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(19, 67)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(204, 21)
        Me.cs_cd.TabIndex = 122
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 98
        '
        'from_dt
        '
        Me.from_dt.Format = "yyyy-MM"
        Me.from_dt.FormatType = Frame7.DateFormatType.Month
        Me.from_dt.Location = New System.Drawing.Point(19, 40)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(204, 21)
        Me.from_dt.TabIndex = 120
        Me.from_dt.Title = "from_dt"
        Me.from_dt.TitleWidth = 98
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(228, 67)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(297, 21)
        Me.cs_nm.TabIndex = 121
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.grid1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 496)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     미수금현황"
        '
        'grid1
        '
        Me.grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid1.Location = New System.Drawing.Point(2, 23)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = False
        Me.grid1.RowHeight = -1
        Me.grid1.Size = New System.Drawing.Size(1178, 471)
        Me.grid1.TabIndex = 2
        '
        'scd_nm
        '
        Me.scd_nm.ColumnName = "find_paymenterm_cd"
        Me.scd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.scd_nm.Location = New System.Drawing.Point(531, 40)
        Me.scd_nm.Name = "scd_nm"
        Me.scd_nm.Size = New System.Drawing.Size(240, 21)
        Me.scd_nm.TabIndex = 127
        Me.scd_nm.TableName = "find_paymenterm_cd"
        Me.scd_nm.Title = "scd_nm"
        Me.scd_nm.TitleWidth = 98
        '
        'WP_SA1163
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1163"
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
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents grid1 As Frame7.eGrid
    Friend WithEvents scd_cd As Frame7.eText
    Friend WithEvents scd_nm As Frame7.eText

End Class
