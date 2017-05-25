<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_WO2000
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
        Me.CachedGAC120R1 = New System7.CachedGAC120R()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EGrid1 = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.ym = New Frame7.eDate()
        Me.btn_button = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EGrid1)
        Me.Panel1.Controls.Add(Me.EPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 558)
        Me.Panel1.TabIndex = 1
        '
        'EGrid1
        '
        Me.EGrid1.Location = New System.Drawing.Point(597, 150)
        Me.EGrid1.Name = "EGrid1"
        Me.EGrid1.ReadOnly = False
        Me.EGrid1.RowHeight = -1
        Me.EGrid1.Size = New System.Drawing.Size(198, 126)
        Me.EGrid1.TabIndex = 10
        Me.EGrid1.Visible = False
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_button)
        Me.EPanel1.Controls.Add(Me.ym)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(947, 558)
        Me.EPanel1.TabIndex = 11
        Me.EPanel1.Text = "     원가계산"
        '
        'ym
        '
        Me.ym.Location = New System.Drawing.Point(46, 67)
        Me.ym.Name = "ym"
        Me.ym.Size = New System.Drawing.Size(240, 21)
        Me.ym.TabIndex = 2
        Me.ym.Title = "년월"
        '
        'btn_button
        '
        Me.btn_button.Location = New System.Drawing.Point(47, 118)
        Me.btn_button.Name = "btn_button"
        Me.btn_button.Size = New System.Drawing.Size(239, 61)
        Me.btn_button.TabIndex = 72
        Me.btn_button.Text = "계   산"
        '
        'WI_WO2000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "WI_WO2000"
        Me.Size = New System.Drawing.Size(947, 558)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CachedGAC120R1 As System7.CachedGAC120R
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EGrid1 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents ym As Frame7.eDate
    Friend WithEvents btn_button As DevExpress.XtraEditors.SimpleButton

End Class
