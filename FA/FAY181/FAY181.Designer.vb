<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY181
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
        Me.fr_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.to_mon = New Frame7.eDate()
        Me.fr_acc_cd = New Frame7.eText()
        Me.grp_cd = New Frame7.eText()
        Me.to_acc_cd = New Frame7.eText()
        Me.dept_yn = New Frame7.eCheck()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.div_cd = New Frame7.eCheckCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(970, 561)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.fr_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.to_mon)
        Me.EPanel1.Controls.Add(Me.fr_acc_cd)
        Me.EPanel1.Controls.Add(Me.grp_cd)
        Me.EPanel1.Controls.Add(Me.to_acc_cd)
        Me.EPanel1.Controls.Add(Me.dept_yn)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(970, 105)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'fr_mon
        '
        Me.fr_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_mon.Location = New System.Drawing.Point(260, 28)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(240, 21)
        Me.fr_mon.TabIndex = 79
        Me.fr_mon.Title = "fr_mon"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 78
        Me.co_cd.Title = "co_cd"
        '
        'to_mon
        '
        Me.to_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_mon.Location = New System.Drawing.Point(380, 52)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(120, 21)
        Me.to_mon.TabIndex = 81
        Me.to_mon.Title = "기준일"
        Me.to_mon.TitleWidth = 0
        '
        'fr_acc_cd
        '
        Me.fr_acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_acc_cd.Location = New System.Drawing.Point(512, 52)
        Me.fr_acc_cd.Name = "fr_acc_cd"
        Me.fr_acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.fr_acc_cd.TabIndex = 84
        Me.fr_acc_cd.Title = "acc_cd"
        '
        'grp_cd
        '
        Me.grp_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grp_cd.Location = New System.Drawing.Point(512, 28)
        Me.grp_cd.Name = "grp_cd"
        Me.grp_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp_cd.TabIndex = 84
        Me.grp_cd.Title = "grp_cd"
        '
        'to_acc_cd
        '
        Me.to_acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_acc_cd.Location = New System.Drawing.Point(512, 76)
        Me.to_acc_cd.Name = "to_acc_cd"
        Me.to_acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.to_acc_cd.TabIndex = 84
        Me.to_acc_cd.Title = "acc_cd"
        '
        'dept_yn
        '
        Me.dept_yn.Caption = ""
        Me.dept_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_yn.Location = New System.Drawing.Point(384, 76)
        Me.dept_yn.Name = "dept_yn"
        Me.dept_yn.Size = New System.Drawing.Size(136, 21)
        Me.dept_yn.TabIndex = 85
        Me.dept_yn.Title = "dept_yn"
        Me.dept_yn.TitleWidth = 98
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(970, 452)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     기간별 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(966, 427)
        Me.g10.TabIndex = 2
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(8, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(320, 21)
        Me.div_cd.TabIndex = 86
        Me.div_cd.Title = "회계단위"
        '
        'FAY181
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY181"
        Me.Size = New System.Drawing.Size(1025, 610)
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
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_acc_cd As Frame7.eText
    Friend WithEvents to_mon As Frame7.eDate
    Friend WithEvents to_acc_cd As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dept_yn As Frame7.eCheck
    Friend WithEvents grp_cd As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCheckCombo

End Class
