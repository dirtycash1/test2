<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAW100
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
        Me.g10 = New Frame7.eGrid()
        Me.wrk_mon = New Frame7.eDate()
        Me.cmdok = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdproc = New DevExpress.XtraEditors.SimpleButton()
        Me.co_cd = New Frame7.eCombo()
        Me.EPanel1 = New Frame7.ePanel()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'g10
        '
        Me.g10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g10.Location = New System.Drawing.Point(8, 128)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(948, 380)
        Me.g10.TabIndex = 1
        '
        'wrk_mon
        '
        Me.wrk_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.wrk_mon.Format = "yyyy-MM"
        Me.wrk_mon.Location = New System.Drawing.Point(24, 40)
        Me.wrk_mon.Name = "wrk_mon"
        Me.wrk_mon.Size = New System.Drawing.Size(240, 21)
        Me.wrk_mon.TabIndex = 2
        '
        'cmdok
        '
        Me.cmdok.Location = New System.Drawing.Point(304, 64)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(104, 24)
        Me.cmdok.TabIndex = 3
        Me.cmdok.Text = "전체선택"
        '
        'cmdproc
        '
        Me.cmdproc.Location = New System.Drawing.Point(428, 64)
        Me.cmdproc.Name = "cmdproc"
        Me.cmdproc.Size = New System.Drawing.Size(104, 24)
        Me.cmdproc.TabIndex = 4
        Me.cmdproc.Text = "작업"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(24, 64)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 5
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.EPanel1.Controls.Add(Me.wrk_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.cmdok)
        Me.EPanel1.Controls.Add(Me.cmdproc)
        Me.EPanel1.Location = New System.Drawing.Point(8, 8)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(948, 112)
        Me.EPanel1.TabIndex = 6
        Me.EPanel1.Text = "     검색"
        '
        'CAW100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Controls.Add(Me.g10)
        Me.Name = "CAW100"
        Me.Size = New System.Drawing.Size(968, 519)
        Me.Controls.SetChildIndex(Me.g10, 0)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents wrk_mon As Frame7.eDate
    Friend WithEvents cmdok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdproc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel

End Class
