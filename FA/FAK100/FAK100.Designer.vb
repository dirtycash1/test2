<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAK100
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
        Me.EPanel2 = New Frame7.ePanel
        Me.g10 = New Frame7.eGrid
        Me.use_yn = New Frame7.eCheck
        Me.co_cd = New Frame7.eCombo
        Me.card_bc = New Frame7.eCombo
        Me.EPanel1 = New Frame7.ePanel
        Me.card_no = New Frame7.eText
        Me.card_kd = New Frame7.eCombo
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(837, 436)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     법인카드현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(833, 411)
        Me.g10.TabIndex = 2
        '
        'use_yn
        '
        Me.use_yn.Caption = ""
        Me.use_yn.CompuText = Nothing
        Me.use_yn.Location = New System.Drawing.Point(532, 52)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(180, 21)
        Me.use_yn.TabIndex = 8
        Me.use_yn.Title = "전표사용"
        '
        'co_cd
        '
        Me.co_cd.CompuText = Nothing
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "법인"
        '
        'card_bc
        '
        Me.card_bc.CompuText = Nothing
        Me.card_bc.Location = New System.Drawing.Point(272, 28)
        Me.card_bc.Name = "card_bc"
        Me.card_bc.Size = New System.Drawing.Size(240, 21)
        Me.card_bc.TabIndex = 3
        Me.card_bc.Title = "카드구분"
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.card_bc)
        Me.EPanel1.Controls.Add(Me.card_no)
        Me.EPanel1.Controls.Add(Me.card_kd)
        Me.EPanel1.Controls.Add(Me.use_yn)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(837, 79)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'card_no
        '
        Me.card_no.CompuText = Nothing
        Me.card_no.Location = New System.Drawing.Point(12, 52)
        Me.card_no.Name = "card_no"
        Me.card_no.Size = New System.Drawing.Size(240, 21)
        Me.card_no.TabIndex = 2
        Me.card_no.Title = "카드번호(%)"
        '
        'card_kd
        '
        Me.card_kd.CompuText = Nothing
        Me.card_kd.Location = New System.Drawing.Point(272, 52)
        Me.card_kd.Name = "card_kd"
        Me.card_kd.Size = New System.Drawing.Size(240, 21)
        Me.card_kd.TabIndex = 3
        Me.card_kd.Title = "카드유형"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(837, 519)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 1
        '
        'FAK100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAK100"
        Me.Size = New System.Drawing.Size(837, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents use_yn As Frame7.eCheck
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents card_bc As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents card_no As Frame7.eText
    Friend WithEvents card_kd As Frame7.eCombo
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
