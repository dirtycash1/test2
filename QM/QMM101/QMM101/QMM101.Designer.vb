<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMM101
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.fac_cd = New Frame7.eCombo()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.itm_bc = New Frame7.eCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.grp2_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1265, 516)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.itm_nm)
        Me.EPanel3.Controls.Add(Me.itm_cd)
        Me.EPanel3.Controls.Add(Me.grp2_cd)
        Me.EPanel3.Controls.Add(Me.grp1_cd)
        Me.EPanel3.Controls.Add(Me.model_cd)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Controls.Add(Me.itm_bc)
        Me.EPanel3.Controls.Add(Me.fac_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1265, 80)
        Me.EPanel3.TabIndex = 63
        Me.EPanel3.Text = "     검색"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(256, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 9
        Me.fr_dt.Title = "조회기간"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(256, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 10
        Me.to_dt.Title = "~"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 7
        Me.fac_cd.Title = "생산공장"
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1265, 432)
        Me.EPanel1.TabIndex = 64
        Me.EPanel1.Text = "     품질문제 신고 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1261, 407)
        Me.g10.TabIndex = 0
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(504, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 11
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(504, 52)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 12
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(752, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 14
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(752, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 13
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(1000, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 15
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(1000, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 16
        '
        'QMM101
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMM101"
        Me.Size = New System.Drawing.Size(1265, 516)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCombo

End Class
