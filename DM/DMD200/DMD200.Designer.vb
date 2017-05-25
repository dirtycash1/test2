<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMD200
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
        Me.p_eco_end_dt = New Frame7.eDate()
        Me.p_eco_start_dt = New Frame7.eDate()
        Me.p_chg_ty = New Frame7.eCombo()
        Me.p_itm_cd = New Frame7.eText()
        Me.p_eco_no = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 83
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.p_eco_no)
        Me.EPanel1.Controls.Add(Me.p_eco_end_dt)
        Me.EPanel1.Controls.Add(Me.p_chg_ty)
        Me.EPanel1.Controls.Add(Me.p_eco_start_dt)
        Me.EPanel1.Controls.Add(Me.p_itm_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 83)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     ECO현황"
        '
        'p_eco_end_dt
        '
        Me.p_eco_end_dt.Location = New System.Drawing.Point(497, 26)
        Me.p_eco_end_dt.Name = "p_eco_end_dt"
        Me.p_eco_end_dt.Size = New System.Drawing.Size(128, 21)
        Me.p_eco_end_dt.TabIndex = 7
        Me.p_eco_end_dt.Title = "~"
        Me.p_eco_end_dt.TitleWidth = 20
        '
        'p_eco_start_dt
        '
        Me.p_eco_start_dt.Location = New System.Drawing.Point(274, 26)
        Me.p_eco_start_dt.Name = "p_eco_start_dt"
        Me.p_eco_start_dt.Size = New System.Drawing.Size(204, 21)
        Me.p_eco_start_dt.TabIndex = 6
        Me.p_eco_start_dt.Title = "ECO 발행기간"
        Me.p_eco_start_dt.TitleWidth = 100
        '
        'p_chg_ty
        '
        Me.p_chg_ty.Location = New System.Drawing.Point(274, 53)
        Me.p_chg_ty.Name = "p_chg_ty"
        Me.p_chg_ty.Size = New System.Drawing.Size(251, 21)
        Me.p_chg_ty.TabIndex = 5
        Me.p_chg_ty.Title = "설계변경사유"
        Me.p_chg_ty.TitleWidth = 100
        '
        'p_itm_cd
        '
        Me.p_itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_itm_cd.Location = New System.Drawing.Point(5, 53)
        Me.p_itm_cd.Name = "p_itm_cd"
        Me.p_itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.p_itm_cd.TabIndex = 3
        Me.p_itm_cd.Title = "제품Part No(%)"
        Me.p_itm_cd.TitleWidth = 100
        '
        'p_eco_no
        '
        Me.p_eco_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_eco_no.Location = New System.Drawing.Point(5, 26)
        Me.p_eco_no.Name = "p_eco_no"
        Me.p_eco_no.Size = New System.Drawing.Size(240, 21)
        Me.p_eco_no.TabIndex = 2
        Me.p_eco_no.Title = "사내ECO No(%)"
        Me.p_eco_no.TitleWidth = 100
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1000, 603)
        Me.SplitContainer2.SplitterDistance = 175
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 175)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     ECO 마스터현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 150)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1000, 424)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     ECO 상세현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(996, 399)
        Me.g20.TabIndex = 3
        '
        'DMD200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMD200"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents p_eco_end_dt As Frame7.eDate
    Friend WithEvents p_eco_start_dt As Frame7.eDate
    Friend WithEvents p_chg_ty As Frame7.eCombo
    Friend WithEvents p_itm_cd As Frame7.eText
    Friend WithEvents p_eco_no As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid

End Class
