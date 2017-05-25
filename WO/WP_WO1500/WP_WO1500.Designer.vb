<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_WO1500
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
        Me.find_to = New Frame7.ePanel()
        Me.g_result = New Frame7.eGrid()
        Me.ym = New Frame7.eDate()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.find_to, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.find_to.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.find_to)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_result)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 2
        '
        'find_to
        '
        Me.find_to.Controls.Add(Me.ym)
        Me.find_to.Dock = System.Windows.Forms.DockStyle.Fill
        Me.find_to.Location = New System.Drawing.Point(0, 0)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(1182, 97)
        Me.find_to.TabIndex = 0
        Me.find_to.Text = "     검색조건"
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 510)
        Me.g_result.TabIndex = 0
        '
        'ym
        '
        Me.ym.Location = New System.Drawing.Point(5, 36)
        Me.ym.Name = "ym"
        Me.ym.Size = New System.Drawing.Size(172, 21)
        Me.ym.TabIndex = 111
        Me.ym.Title = "기간"
        Me.ym.TitleWidth = 50
        '
        'WP_WO1500
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_WO1500"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.find_to, System.ComponentModel.ISupportInitialize).EndInit()
        Me.find_to.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents find_to As Frame7.ePanel
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents ym As Frame7.eDate

End Class
