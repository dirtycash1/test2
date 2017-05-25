<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_WO1050
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
        Me.find_ym = New Frame7.eDate()
        Me.g_multi = New Frame7.eGrid()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_multi)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 89
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_ym)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 89)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'find_ym
        '
        Me.find_ym.Location = New System.Drawing.Point(24, 44)
        Me.find_ym.Name = "find_ym"
        Me.find_ym.Size = New System.Drawing.Size(190, 21)
        Me.find_ym.TabIndex = 81
        Me.find_ym.Title = "년월"
        Me.find_ym.TitleWidth = 80
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 518)
        Me.g_multi.TabIndex = 0
        '
        'WI_WO1050
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_WO1050"
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
    Friend WithEvents find_ym As Frame7.eDate
    Friend WithEvents g_multi As Frame7.eGrid

End Class
