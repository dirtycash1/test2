<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BI_MONTH_SPEC30
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
        Me.model_nm = New Frame7.eText()
        Me.kijong_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.g10 = New Frame7.ePivotGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 88
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.kijong_cd)
        Me.EPanel1.Controls.Add(Me.model_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 88)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     월 도수별 생산현황"
        '
        'model_nm
        '
        Me.model_nm.Location = New System.Drawing.Point(652, 40)
        Me.model_nm.Name = "model_nm"
        Me.model_nm.Size = New System.Drawing.Size(215, 21)
        Me.model_nm.TabIndex = 7
        Me.model_nm.Title = "제품군"
        Me.model_nm.TitleWidth = 85
        '
        'kijong_cd
        '
        Me.kijong_cd.Location = New System.Drawing.Point(381, 40)
        Me.kijong_cd.Name = "kijong_cd"
        Me.kijong_cd.Size = New System.Drawing.Size(223, 21)
        Me.kijong_cd.TabIndex = 59
        Me.kijong_cd.Title = "제품군 분류"
        Me.kijong_cd.TitleWidth = 100
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(27, 40)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(178, 21)
        Me.fr_dt.TabIndex = 60
        Me.fr_dt.Title = "기준 월"
        Me.fr_dt.TitleWidth = 80
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(211, 40)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(119, 21)
        Me.to_dt.TabIndex = 61
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'g10
        '
        Me.g10.AllowAddRows = False
        Me.g10.AllowDeleteRows = False
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1182, 519)
        Me.g10.TabIndex = 0
        '
        'BI_MONTH_SPEC30
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BI_MONTH_SPEC30"
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
    Friend WithEvents model_nm As Frame7.eText
    Friend WithEvents kijong_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents g10 As Frame7.ePivotGrid

End Class
