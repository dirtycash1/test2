<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAR100
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
        Me.to_dt1 = New Frame7.eDate()
        Me.fr_dt1 = New Frame7.eDate()
        Me.to_dt2 = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt2 = New Frame7.eDate()
        Me.done_chk = New Frame7.eCheck()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(970, 561)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt1)
        Me.EPanel1.Controls.Add(Me.fr_dt1)
        Me.EPanel1.Controls.Add(Me.to_dt2)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt2)
        Me.EPanel1.Controls.Add(Me.done_chk)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(970, 78)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'to_dt1
        '
        Me.to_dt1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt1.Location = New System.Drawing.Point(512, 28)
        Me.to_dt1.Name = "to_dt1"
        Me.to_dt1.Size = New System.Drawing.Size(240, 21)
        Me.to_dt1.TabIndex = 80
        Me.to_dt1.Title = "종료일기간"
        '
        'fr_dt1
        '
        Me.fr_dt1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt1.Location = New System.Drawing.Point(260, 28)
        Me.fr_dt1.Name = "fr_dt1"
        Me.fr_dt1.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt1.TabIndex = 79
        Me.fr_dt1.Title = "시작일기간"
        '
        'to_dt2
        '
        Me.to_dt2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt2.Location = New System.Drawing.Point(632, 52)
        Me.to_dt2.Name = "to_dt2"
        Me.to_dt2.Size = New System.Drawing.Size(120, 21)
        Me.to_dt2.TabIndex = 82
        Me.to_dt2.Title = "기준일"
        Me.to_dt2.TitleWidth = 0
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 78
        Me.co_cd.Title = "법인"
        '
        'fr_dt2
        '
        Me.fr_dt2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt2.Location = New System.Drawing.Point(380, 52)
        Me.fr_dt2.Name = "fr_dt2"
        Me.fr_dt2.Size = New System.Drawing.Size(120, 21)
        Me.fr_dt2.TabIndex = 81
        Me.fr_dt2.Title = "기준일"
        Me.fr_dt2.TitleWidth = 0
        '
        'done_chk
        '
        Me.done_chk.Caption = ""
        Me.done_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.done_chk.Location = New System.Drawing.Point(128, 52)
        Me.done_chk.Name = "done_chk"
        Me.done_chk.Size = New System.Drawing.Size(136, 21)
        Me.done_chk.TabIndex = 83
        Me.done_chk.Title = "완결제외"
        Me.done_chk.TitleWidth = 98
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
        Me.SplitContainer2.Size = New System.Drawing.Size(970, 479)
        Me.SplitContainer2.SplitterDistance = 305
        Me.SplitContainer2.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(970, 305)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     미수수익 List"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(966, 280)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(970, 170)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     미수수익 전표"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(966, 145)
        Me.g20.TabIndex = 2
        '
        'FAR100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAR100"
        Me.Size = New System.Drawing.Size(1025, 610)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
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
    Friend WithEvents to_dt1 As Frame7.eDate
    Friend WithEvents fr_dt1 As Frame7.eDate
    Friend WithEvents to_dt2 As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt2 As Frame7.eDate
    Friend WithEvents done_chk As Frame7.eCheck
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid

End Class
