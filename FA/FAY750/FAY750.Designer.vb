<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY750
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
        Me.pfr_mon = New Frame7.eDate()
        Me.pto_mon = New Frame7.eDate()
        Me.fr_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.to_mon = New Frame7.eDate()
        Me.doc_bc = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.div_cd = New Frame7.eCheckCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1032, 611)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.pfr_mon)
        Me.EPanel1.Controls.Add(Me.pto_mon)
        Me.EPanel1.Controls.Add(Me.fr_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.to_mon)
        Me.EPanel1.Controls.Add(Me.doc_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1032, 81)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'pfr_mon
        '
        Me.pfr_mon.Format = "yyyy-MM"
        Me.pfr_mon.Location = New System.Drawing.Point(556, 28)
        Me.pfr_mon.Name = "pfr_mon"
        Me.pfr_mon.Size = New System.Drawing.Size(196, 21)
        Me.pfr_mon.TabIndex = 51
        Me.pfr_mon.Title = "전기"
        Me.pfr_mon.TitleWidth = 88
        '
        'pto_mon
        '
        Me.pto_mon.Format = "yyyy-MM"
        Me.pto_mon.Location = New System.Drawing.Point(556, 52)
        Me.pto_mon.Name = "pto_mon"
        Me.pto_mon.Size = New System.Drawing.Size(196, 21)
        Me.pto_mon.TabIndex = 52
        Me.pto_mon.Title = ""
        Me.pto_mon.TitleWidth = 88
        '
        'fr_mon
        '
        Me.fr_mon.Format = "yyyy-MM"
        Me.fr_mon.Location = New System.Drawing.Point(352, 28)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(196, 21)
        Me.fr_mon.TabIndex = 47
        Me.fr_mon.Title = "당기"
        Me.fr_mon.TitleWidth = 88
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'to_mon
        '
        Me.to_mon.Format = "yyyy-MM"
        Me.to_mon.Location = New System.Drawing.Point(352, 52)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(196, 21)
        Me.to_mon.TabIndex = 48
        Me.to_mon.Title = ""
        Me.to_mon.TitleWidth = 88
        '
        'doc_bc
        '
        Me.doc_bc.Location = New System.Drawing.Point(764, 28)
        Me.doc_bc.Name = "doc_bc"
        Me.doc_bc.Size = New System.Drawing.Size(240, 21)
        Me.doc_bc.TabIndex = 50
        Me.doc_bc.Title = "결산양식(시산표)"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1032, 526)
        Me.g10.TabIndex = 5
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(320, 21)
        Me.div_cd.TabIndex = 53
        Me.div_cd.Title = "회계단위"
        '
        'FAY750
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY750"
        Me.Size = New System.Drawing.Size(1054, 611)
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
    Friend WithEvents pfr_mon As Frame7.eDate
    Friend WithEvents pto_mon As Frame7.eDate
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents doc_bc As Frame7.eCombo
    Friend WithEvents to_mon As Frame7.eDate
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents div_cd As Frame7.eCheckCombo

End Class
