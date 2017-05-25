<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA3000
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.ym = New Frame7.eDate()
        Me.chk_bc = New Frame7.eCombo()
        Me.but_work = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ym)
        Me.EPanel1.Controls.Add(Me.chk_bc)
        Me.EPanel1.Controls.Add(Me.but_work)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(270, 188)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     영업월마감"
        '
        'ym
        '
        Me.ym.Location = New System.Drawing.Point(8, 28)
        Me.ym.Name = "ym"
        Me.ym.Size = New System.Drawing.Size(240, 21)
        Me.ym.TabIndex = 2
        Me.ym.Title = "년월"
        '
        'chk_bc
        '
        Me.chk_bc.Location = New System.Drawing.Point(8, 52)
        Me.chk_bc.Name = "chk_bc"
        Me.chk_bc.Size = New System.Drawing.Size(240, 21)
        Me.chk_bc.TabIndex = 3
        Me.chk_bc.Title = "마감구분"
        '
        'but_work
        '
        Me.but_work.Location = New System.Drawing.Point(48, 88)
        Me.but_work.Name = "but_work"
        Me.but_work.Size = New System.Drawing.Size(75, 32)
        Me.but_work.TabIndex = 4
        Me.but_work.Text = "처리"
        '
        'WI_SA3000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "WI_SA3000"
        Me.Size = New System.Drawing.Size(270, 188)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents ym As Frame7.eDate
    Friend WithEvents chk_bc As Frame7.eCombo
    Friend WithEvents but_work As DevExpress.XtraEditors.SimpleButton

End Class
