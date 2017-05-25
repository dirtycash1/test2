<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAS700
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.co_cd = New Frame7.eCombo()
        Me.opt_show = New Frame7.eOptionBox()
        Me.g10 = New Frame7.eGrid()
        Me.btn_doc = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(994, 516)
        Me.SplitContainer1.SplitterDistance = 64
        Me.SplitContainer1.TabIndex = 7
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.opt_show)
        Me.EPanel1.Controls.Add(Me.btn_doc)
        Me.EPanel1.Controls.Add(Me.btn_del)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(994, 64)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 32)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 74
        Me.co_cd.Title = "법인"
        '
        'opt_show
        '
        Me.opt_show.Location = New System.Drawing.Point(276, 32)
        Me.opt_show.Name = "opt_show"
        Me.opt_show.SelectedIndex = -1
        Me.opt_show.Size = New System.Drawing.Size(368, 24)
        Me.opt_show.TabIndex = 75
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(994, 448)
        Me.g10.TabIndex = 3
        '
        'btn_doc
        '
        Me.btn_doc.Location = New System.Drawing.Point(672, 32)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(108, 24)
        Me.btn_doc.TabIndex = 76
        Me.btn_doc.Text = "전표생성"
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(788, 32)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(108, 24)
        Me.btn_del.TabIndex = 76
        Me.btn_del.Text = "전표삭제"
        '
        'FAS700
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAS700"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents opt_show As Frame7.eOptionBox
    Friend WithEvents btn_doc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton

End Class
