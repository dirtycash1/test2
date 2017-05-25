<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY820
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
        Me.div_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.to_sdt = New Frame7.eDate()
        Me.to_edt = New Frame7.eDate()
        Me.fr_sdt = New Frame7.eDate()
        Me.fr_edt = New Frame7.eDate()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(960, 615)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_sdt)
        Me.EPanel1.Controls.Add(Me.to_edt)
        Me.EPanel1.Controls.Add(Me.fr_sdt)
        Me.EPanel1.Controls.Add(Me.fr_edt)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(960, 81)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 5
        Me.div_cd.Title = "div_cd"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 4
        Me.co_cd.Title = "법인"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(960, 530)
        Me.g10.TabIndex = 4
        '
        'to_sdt
        '
        Me.to_sdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_sdt.Location = New System.Drawing.Point(535, 28)
        Me.to_sdt.Name = "to_sdt"
        Me.to_sdt.Size = New System.Drawing.Size(240, 21)
        Me.to_sdt.TabIndex = 77
        Me.to_sdt.Title = "종료기간"
        '
        'to_edt
        '
        Me.to_edt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_edt.Location = New System.Drawing.Point(655, 52)
        Me.to_edt.Name = "to_edt"
        Me.to_edt.Size = New System.Drawing.Size(120, 21)
        Me.to_edt.TabIndex = 79
        Me.to_edt.Title = "기준일"
        Me.to_edt.TitleWidth = 0
        '
        'fr_sdt
        '
        Me.fr_sdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_sdt.Location = New System.Drawing.Point(272, 28)
        Me.fr_sdt.Name = "fr_sdt"
        Me.fr_sdt.Size = New System.Drawing.Size(240, 21)
        Me.fr_sdt.TabIndex = 76
        Me.fr_sdt.Title = "시작기간"
        '
        'fr_edt
        '
        Me.fr_edt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_edt.Location = New System.Drawing.Point(392, 52)
        Me.fr_edt.Name = "fr_edt"
        Me.fr_edt.Size = New System.Drawing.Size(120, 21)
        Me.fr_edt.TabIndex = 78
        Me.fr_edt.Title = "기준일"
        Me.fr_edt.TitleWidth = 0
        '
        'FAY820
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY820"
        Me.Size = New System.Drawing.Size(991, 618)
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
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_sdt As Frame7.eDate
    Friend WithEvents to_edt As Frame7.eDate
    Friend WithEvents fr_sdt As Frame7.eDate
    Friend WithEvents fr_edt As Frame7.eDate

End Class
