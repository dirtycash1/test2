<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCZ200
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
        Me.std_dt = New Frame7.eDate()
        Me.cury_bc = New Frame7.eCombo()
        Me.btn_get = New DevExpress.XtraEditors.SimpleButton()
        Me.g10 = New Frame7.eGrid()
        Me.btn_link = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_link)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.btn_get)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(16, 28)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 70
        Me.std_dt.Title = "기준일"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(16, 52)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 151
        Me.cury_bc.Title = "통화"
        '
        'btn_get
        '
        Me.btn_get.Location = New System.Drawing.Point(288, 44)
        Me.btn_get.Name = "btn_get"
        Me.btn_get.Size = New System.Drawing.Size(148, 28)
        Me.btn_get.TabIndex = 152
        Me.btn_get.Text = "환율가져오기"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1000, 605)
        Me.g10.TabIndex = 0
        '
        'btn_link
        '
        Me.btn_link.Location = New System.Drawing.Point(444, 44)
        Me.btn_link.Name = "btn_link"
        Me.btn_link.Size = New System.Drawing.Size(148, 28)
        Me.btn_link.TabIndex = 153
        Me.btn_link.Text = "서울외국환중개사이트"
        '
        'BCZ200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCZ200"
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents btn_get As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_link As DevExpress.XtraEditors.SimpleButton

End Class
