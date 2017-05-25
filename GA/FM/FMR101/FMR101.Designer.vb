<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMR101
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
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.fa_nm = New Frame7.eText()
        Me.fa_no = New Frame7.eText()
        Me.wc_cd = New Frame7.eCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 581)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.wc_cd)
        Me.EPanel1.Controls.Add(Me.fa_no)
        Me.EPanel1.Controls.Add(Me.fa_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1234, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(8, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 9
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 8
        '
        'fa_nm
        '
        Me.fa_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fa_nm.Location = New System.Drawing.Point(508, 52)
        Me.fa_nm.Name = "fa_nm"
        Me.fa_nm.Size = New System.Drawing.Size(240, 21)
        Me.fa_nm.TabIndex = 5
        '
        'fa_no
        '
        Me.fa_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fa_no.Location = New System.Drawing.Point(508, 28)
        Me.fa_no.Name = "fa_no"
        Me.fa_no.Size = New System.Drawing.Size(240, 21)
        Me.fa_no.TabIndex = 4
        '
        'wc_cd
        '
        Me.wc_cd.Location = New System.Drawing.Point(256, 52)
        Me.wc_cd.Name = "wc_cd"
        Me.wc_cd.Size = New System.Drawing.Size(240, 21)
        Me.wc_cd.TabIndex = 3
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(256, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1234, 497)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     설비 수리 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1230, 472)
        Me.g10.TabIndex = 2
        '
        'FMR101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FMR101"
        Me.Size = New System.Drawing.Size(1234, 581)
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
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents fa_nm As Frame7.eText
    Friend WithEvents fa_no As Frame7.eText
    Friend WithEvents wc_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid

End Class
