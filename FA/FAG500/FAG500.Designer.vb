<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAG500
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
        Me.co_cd = New Frame7.eCombo
        Me.fr_dt = New Frame7.eDate
        Me.to_dt = New Frame7.eDate
        Me.fr_amt = New Frame7.eText
        Me.to_amt = New Frame7.eText
        Me.mng_no = New Frame7.eText
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.EPanel2 = New Frame7.ePanel
        Me.g10 = New Frame7.eGrid
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(837, 519)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_amt)
        Me.EPanel1.Controls.Add(Me.to_amt)
        Me.EPanel1.Controls.Add(Me.mng_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(837, 81)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.CompuText = Nothing
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'fr_dt
        '
        Me.fr_dt.CompuText = Nothing
        Me.fr_dt.Location = New System.Drawing.Point(272, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "발행일"
        '
        'to_dt
        '
        Me.to_dt.CompuText = Nothing
        Me.to_dt.Location = New System.Drawing.Point(380, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(132, 21)
        Me.to_dt.TabIndex = 48
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'fr_amt
        '
        Me.fr_amt.CompuText = Nothing
        Me.fr_amt.Location = New System.Drawing.Point(532, 28)
        Me.fr_amt.Name = "fr_amt"
        Me.fr_amt.Size = New System.Drawing.Size(240, 21)
        Me.fr_amt.TabIndex = 51
        Me.fr_amt.Title = "금액"
        '
        'to_amt
        '
        Me.to_amt.CompuText = Nothing
        Me.to_amt.Location = New System.Drawing.Point(640, 52)
        Me.to_amt.Name = "to_amt"
        Me.to_amt.Size = New System.Drawing.Size(132, 21)
        Me.to_amt.TabIndex = 52
        Me.to_amt.Title = "~"
        Me.to_amt.TitleWidth = 10
        '
        'mng_no
        '
        Me.mng_no.CompuText = Nothing
        Me.mng_no.Location = New System.Drawing.Point(12, 52)
        Me.mng_no.Name = "mng_no"
        Me.mng_no.Size = New System.Drawing.Size(240, 21)
        Me.mng_no.TabIndex = 50
        Me.mng_no.Title = "어음번호"
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
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(837, 434)
        Me.SplitContainer2.SplitterDistance = 254
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(837, 434)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     받을어음 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(833, 409)
        Me.g10.TabIndex = 2
        '
        'FAG500
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAG500"
        Me.Size = New System.Drawing.Size(837, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_amt As Frame7.eText
    Friend WithEvents fr_amt As Frame7.eText
    Friend WithEvents mng_no As Frame7.eText

End Class
