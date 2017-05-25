<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAR270
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
        Me.bud_yy = New Frame7.eDate()
        Me.fr_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eCheckCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.to_mon = New Frame7.eDate()
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
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1132, 360)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bud_yy)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_mon)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.to_mon)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1132, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'bud_yy
        '
        Me.bud_yy.Format = "yyyy"
        Me.bud_yy.Location = New System.Drawing.Point(16, 54)
        Me.bud_yy.Name = "bud_yy"
        Me.bud_yy.Size = New System.Drawing.Size(240, 21)
        Me.bud_yy.TabIndex = 6
        Me.bud_yy.Title = "예산년도"
        '
        'fr_mon
        '
        Me.fr_mon.Format = "yyyy-MM"
        Me.fr_mon.Location = New System.Drawing.Point(284, 28)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(240, 21)
        Me.fr_mon.TabIndex = 5
        Me.fr_mon.Title = "기준월"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(16, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "co_cd"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(551, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 4
        Me.dept_cd.Title = "부서명"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1132, 276)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     판매관리비 예산대비실적조회"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1128, 251)
        Me.g10.TabIndex = 2
        '
        'to_mon
        '
        Me.to_mon.Format = "yyyy-MM"
        Me.to_mon.Location = New System.Drawing.Point(284, 54)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(240, 21)
        Me.to_mon.TabIndex = 5
        Me.to_mon.Title = "~"
        '
        'FAR270
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAR270"
        Me.Size = New System.Drawing.Size(1146, 392)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eCheckCombo
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents bud_yy As Frame7.eDate
    Friend WithEvents to_mon As Frame7.eDate

End Class
