<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1151_PB
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
        Me.lot_no = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.od_gu = New Frame7.eCombo()
        Me.DIS_GU = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.DIS_GU)
        Me.EPanel1.Controls.Add(Me.od_gu)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.lot_no)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 116)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'lot_no
        '
        Me.lot_no.Location = New System.Drawing.Point(396, 28)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(211, 21)
        Me.lot_no.TabIndex = 8
        Me.lot_no.Title = "LOT NO"
        Me.lot_no.TitleWidth = 90
        '
        'gd_cd
        '
        Me.gd_cd.Location = New System.Drawing.Point(396, 79)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(211, 21)
        Me.gd_cd.TabIndex = 9
        Me.gd_cd.Title = "품목코드"
        Me.gd_cd.TitleWidth = 90
        '
        'cs_cd
        '
        Me.cs_cd.Location = New System.Drawing.Point(8, 52)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(215, 21)
        Me.cs_cd.TabIndex = 6
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 90
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(215, 21)
        Me.fr_dt.TabIndex = 2
        Me.fr_dt.Title = "기간"
        Me.fr_dt.TitleWidth = 90
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(229, 28)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(130, 21)
        Me.to_dt.TabIndex = 3
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'cs_nm
        '
        Me.cs_nm.Location = New System.Drawing.Point(106, 52)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(253, 21)
        Me.cs_nm.TabIndex = 7
        '
        'gd_nm
        '
        Me.gd_nm.Location = New System.Drawing.Point(490, 79)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(252, 21)
        Me.gd_nm.TabIndex = 10
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 570)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     반품요청현황(PB)"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 545)
        Me.g10.TabIndex = 2
        '
        'ps_cd
        '
        Me.ps_cd.Location = New System.Drawing.Point(8, 79)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(215, 21)
        Me.ps_cd.TabIndex = 11
        Me.ps_cd.Title = "영업담당자"
        Me.ps_cd.TitleWidth = 90
        '
        'ps_nm
        '
        Me.ps_nm.Location = New System.Drawing.Point(106, 79)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(252, 21)
        Me.ps_nm.TabIndex = 12
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(396, 55)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(211, 21)
        Me.od_gu.TabIndex = 69
        Me.od_gu.Title = "수주유형"
        Me.od_gu.TitleWidth = 90
        '
        'DIS_GU
        '
        Me.DIS_GU.Location = New System.Drawing.Point(771, 79)
        Me.DIS_GU.Name = "DIS_GU"
        Me.DIS_GU.Size = New System.Drawing.Size(187, 21)
        Me.DIS_GU.TabIndex = 70
        Me.DIS_GU.Title = "반품구분"
        Me.DIS_GU.TitleWidth = 70
        '
        'WI_SA1151_PB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1151_PB"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents DIS_GU As Frame7.eCombo
    Friend WithEvents od_gu As Frame7.eCombo

End Class
