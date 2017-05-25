<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1143
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
        Me.gd_nm = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.find_from = New Frame7.eDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cs_nm = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.cur_cd = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.bl_to = New Frame7.eDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bl_from = New Frame7.eDate()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 142
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bl_to)
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Controls.Add(Me.bl_from)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.cur_cd)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 142)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     출하현황(수출)"
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(226, 113)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(312, 21)
        Me.gd_nm.TabIndex = 130
        Me.gd_nm.Title = "품명"
        Me.gd_nm.TitleWidth = 98
        '
        'gd_cd
        '
        Me.gd_cd.ColumnName = "find_paymenterm_cd"
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(6, 113)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(204, 21)
        Me.gd_cd.TabIndex = 129
        Me.gd_cd.TableName = "find_paymenterm_cd"
        Me.gd_cd.Title = "품목코드"
        Me.gd_cd.TitleWidth = 98
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(6, 86)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(204, 21)
        Me.cs_cd.TabIndex = 128
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 98
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(6, 59)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(204, 21)
        Me.find_from.TabIndex = 126
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(212, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 14)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(226, 86)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(312, 21)
        Me.cs_nm.TabIndex = 127
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 98
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(232, 59)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(99, 21)
        Me.find_to.TabIndex = 124
        Me.find_to.Title = "기간"
        Me.find_to.TitleWidth = 0
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(347, 59)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(193, 21)
        Me.cur_cd.TabIndex = 123
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 80
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1182, 465)
        Me.g10.TabIndex = 1
        '
        'bl_to
        '
        Me.bl_to.Location = New System.Drawing.Point(232, 30)
        Me.bl_to.Name = "bl_to"
        Me.bl_to.Size = New System.Drawing.Size(99, 21)
        Me.bl_to.TabIndex = 131
        Me.bl_to.Title = "기간"
        Me.bl_to.TitleWidth = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(212, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 14)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bl_from
        '
        Me.bl_from.Location = New System.Drawing.Point(6, 30)
        Me.bl_from.Name = "bl_from"
        Me.bl_from.Size = New System.Drawing.Size(204, 21)
        Me.bl_from.TabIndex = 133
        Me.bl_from.Title = "기간"
        Me.bl_from.TitleWidth = 98
        '
        'WI_SA1143
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1143"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents bl_to As Frame7.eDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bl_from As Frame7.eDate

End Class
