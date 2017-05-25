<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grid2
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EPanel1 = New Frame7.ePanel
        Me.fr_dt = New Frame7.eDate
        Me.ECombo1 = New Frame7.eCombo
        Me.to_dt = New Frame7.eDate
        Me.ECheck1 = New Frame7.eCheck
        Me.EText2 = New Frame7.eText
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.EPanel2 = New Frame7.ePanel
        Me.g10 = New Frame7.eGrid
        Me.EPanel3 = New Frame7.ePanel
        Me.g20 = New Frame7.eGrid
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.ECheckCombo1 = New Frame7.eCheckCombo
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 516)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ECheckCombo1)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.ECombo1)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.EText2)
        Me.EPanel1.Controls.Add(Me.ECheck1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(900, 78)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "기간 (Date)"
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(272, 28)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECombo1.TabIndex = 3
        Me.ECombo1.Title = "Combo"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 5
        Me.to_dt.TitleWidth = 0
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Location = New System.Drawing.Point(532, 28)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(172, 21)
        Me.ECheck1.TabIndex = 4
        Me.ECheck1.Title = "Check"
        '
        'EText2
        '
        Me.EText2.Location = New System.Drawing.Point(532, 52)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(240, 21)
        Me.EText2.TabIndex = 2
        Me.EText2.Title = "Text"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(900, 434)
        Me.SplitContainer2.SplitterDistance = 265
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(900, 265)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     사원 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.Size = New System.Drawing.Size(896, 240)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(900, 165)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     급여 현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.Size = New System.Drawing.Size(896, 140)
        Me.g20.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(780, 49)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 24)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'ECheckCombo1
        '
        Me.ECheckCombo1.Location = New System.Drawing.Point(272, 52)
        Me.ECheckCombo1.Name = "ECheckCombo1"
        Me.ECheckCombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECheckCombo1.TabIndex = 9
        Me.ECheckCombo1.Title = "CheckCombo"
        '
        'Grid2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Grid2"
        Me.Size = New System.Drawing.Size(977, 563)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents ECheck1 As Frame7.eCheck
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ECheckCombo1 As Frame7.eCheckCombo

End Class
