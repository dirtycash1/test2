<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1080
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
        Me.find_bi_cd = New Frame7.eText()
        Me.find_bi_nm = New Frame7.eText()
        Me.find_stts = New Frame7.eCombo()
        Me.g_multi = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_multi)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 558)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.find_bi_cd)
        Me.EPanel2.Controls.Add(Me.find_bi_nm)
        Me.EPanel2.Controls.Add(Me.find_stts)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(947, 116)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     수출입비용등록"
        '
        'find_bi_cd
        '
        Me.find_bi_cd.ColumnName = "find_paymenterm_cd"
        Me.find_bi_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_bi_cd.Location = New System.Drawing.Point(19, 41)
        Me.find_bi_cd.Name = "find_bi_cd"
        Me.find_bi_cd.Size = New System.Drawing.Size(240, 21)
        Me.find_bi_cd.TabIndex = 5
        Me.find_bi_cd.TableName = "find_paymenterm_cd"
        Me.find_bi_cd.Title = "비용코드"
        Me.find_bi_cd.TitleWidth = 98
        '
        'find_bi_nm
        '
        Me.find_bi_nm.ColumnName = "find_paymentterm_nm"
        Me.find_bi_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_bi_nm.Location = New System.Drawing.Point(19, 68)
        Me.find_bi_nm.Name = "find_bi_nm"
        Me.find_bi_nm.Size = New System.Drawing.Size(240, 21)
        Me.find_bi_nm.TabIndex = 6
        Me.find_bi_nm.TableName = "find_paymentterm_nm"
        Me.find_bi_nm.Title = "비용명"
        Me.find_bi_nm.TitleWidth = 98
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(364, 41)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(240, 21)
        Me.find_stts.TabIndex = 7
        Me.find_stts.Title = "등록여부"
        Me.find_stts.TitleWidth = 98
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(947, 438)
        Me.g_multi.TabIndex = 1
        '
        'WI_CO1080
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_CO1080"
        Me.Size = New System.Drawing.Size(947, 558)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_bi_cd As Frame7.eText
    Friend WithEvents find_bi_nm As Frame7.eText
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents g_multi As Frame7.eGrid

End Class
