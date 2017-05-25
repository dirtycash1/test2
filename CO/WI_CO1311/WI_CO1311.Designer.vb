<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1311
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
        Me.find_from = New Frame7.eDate()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.find_to = New Frame7.eDate()
        Me.g_retrieve = New Frame7.eGrid()
        Me.print = New System.Windows.Forms.Button()
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
        Me.SplitContainer1.SplitterDistance = 126
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.print)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 126)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     Invoice 현황"
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(5, 39)
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
        Me.Label3.Location = New System.Drawing.Point(211, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 14)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(231, 39)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(99, 21)
        Me.find_to.TabIndex = 124
        Me.find_to.Title = "기간"
        Me.find_to.TitleWidth = 0
        '
        'g_retrieve
        '
        Me.g_retrieve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_retrieve.Location = New System.Drawing.Point(0, 0)
        Me.g_retrieve.Name = "g_retrieve"
        Me.g_retrieve.ReadOnly = False
        Me.g_retrieve.RowHeight = -1
        Me.g_retrieve.Size = New System.Drawing.Size(1182, 481)
        Me.g_retrieve.TabIndex = 1
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(390, 36)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(125, 23)
        Me.print.TabIndex = 127
        Me.print.Text = "출력"
        Me.print.UseVisualStyleBackColor = True
        '
        'WI_CO1311
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_CO1311"
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
    Friend WithEvents g_retrieve As Frame7.eGrid
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents print As System.Windows.Forms.Button

End Class
