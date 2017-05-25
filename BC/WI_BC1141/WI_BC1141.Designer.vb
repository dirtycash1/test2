<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_BC1141
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
        Me.OD_DT2 = New Frame7.ePanel()
        Me.CS_CD = New Frame7.eText()
        Me.OD_FORM = New Frame7.eDate()
        Me.OT_TO = New Frame7.eDate()
        Me.GD_MODEL = New Frame7.eCombo()
        Me.GD_NM = New Frame7.eText()
        Me.GD_CD = New Frame7.eText()
        Me.scd_cd = New Frame7.eText()
        Me.CS_NM = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.de_gu = New Frame7.eCombo()
        Me.OD_NO = New Frame7.eText()
        Me.OT_NO = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OD_DT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OD_DT2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OD_DT2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 360)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 0
        '
        'OD_DT2
        '
        Me.OD_DT2.Controls.Add(Me.OT_NO)
        Me.OD_DT2.Controls.Add(Me.OD_NO)
        Me.OD_DT2.Controls.Add(Me.de_gu)
        Me.OD_DT2.Controls.Add(Me.CS_CD)
        Me.OD_DT2.Controls.Add(Me.OD_FORM)
        Me.OD_DT2.Controls.Add(Me.OT_TO)
        Me.OD_DT2.Controls.Add(Me.GD_MODEL)
        Me.OD_DT2.Controls.Add(Me.GD_NM)
        Me.OD_DT2.Controls.Add(Me.GD_CD)
        Me.OD_DT2.Controls.Add(Me.scd_cd)
        Me.OD_DT2.Controls.Add(Me.CS_NM)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'CS_CD
        '
        Me.CS_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_CD.Location = New System.Drawing.Point(365, 53)
        Me.CS_CD.Name = "CS_CD"
        Me.CS_CD.Size = New System.Drawing.Size(200, 21)
        Me.CS_CD.TabIndex = 4
        Me.CS_CD.Title = "거래처 코드"
        Me.CS_CD.TitleWidth = 70
        '
        'OD_FORM
        '
        Me.OD_FORM.Location = New System.Drawing.Point(17, 27)
        Me.OD_FORM.Name = "OD_FORM"
        Me.OD_FORM.Size = New System.Drawing.Size(170, 21)
        Me.OD_FORM.TabIndex = 2
        Me.OD_FORM.Title = "출하 일자"
        Me.OD_FORM.TitleWidth = 70
        '
        'OT_TO
        '
        Me.OT_TO.Location = New System.Drawing.Point(209, 26)
        Me.OT_TO.Name = "OT_TO"
        Me.OT_TO.Size = New System.Drawing.Size(135, 21)
        Me.OT_TO.TabIndex = 3
        Me.OT_TO.Title = "   ~ "
        Me.OT_TO.TitleWidth = 30
        '
        'GD_MODEL
        '
        Me.GD_MODEL.Location = New System.Drawing.Point(365, 26)
        Me.GD_MODEL.Name = "GD_MODEL"
        Me.GD_MODEL.Size = New System.Drawing.Size(140, 21)
        Me.GD_MODEL.TabIndex = 5
        Me.GD_MODEL.Title = "제품군"
        Me.GD_MODEL.TitleWidth = 50
        '
        'GD_NM
        '
        Me.GD_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_NM.Location = New System.Drawing.Point(17, 54)
        Me.GD_NM.Name = "GD_NM"
        Me.GD_NM.Size = New System.Drawing.Size(170, 21)
        Me.GD_NM.TabIndex = 4
        Me.GD_NM.Title = "판매명"
        Me.GD_NM.TitleWidth = 70
        '
        'GD_CD
        '
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(204, 53)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(140, 21)
        Me.GD_CD.TabIndex = 4
        Me.GD_CD.Title = "판매코드"
        Me.GD_CD.TitleWidth = 50
        '
        'scd_cd
        '
        Me.scd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.scd_cd.Location = New System.Drawing.Point(515, 26)
        Me.scd_cd.Name = "scd_cd"
        Me.scd_cd.Size = New System.Drawing.Size(160, 21)
        Me.scd_cd.TabIndex = 4
        Me.scd_cd.Title = "영업 담당자"
        Me.scd_cd.TitleWidth = 70
        '
        'CS_NM
        '
        Me.CS_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_NM.Location = New System.Drawing.Point(535, 53)
        Me.CS_NM.Name = "CS_NM"
        Me.CS_NM.Size = New System.Drawing.Size(140, 21)
        Me.CS_NM.TabIndex = 4
        Me.CS_NM.Title = ""
        Me.CS_NM.TitleWidth = 35
        '
        'EPanel2
        '
        Me.EPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 247)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     출하 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 222)
        Me.g10.TabIndex = 2
        '
        'de_gu
        '
        Me.de_gu.Location = New System.Drawing.Point(17, 83)
        Me.de_gu.Name = "de_gu"
        Me.de_gu.Size = New System.Drawing.Size(170, 21)
        Me.de_gu.TabIndex = 6
        Me.de_gu.Title = "국내/수출"
        Me.de_gu.TitleWidth = 70
        '
        'OD_NO
        '
        Me.OD_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.OD_NO.Location = New System.Drawing.Point(681, 54)
        Me.OD_NO.Name = "OD_NO"
        Me.OD_NO.Size = New System.Drawing.Size(200, 21)
        Me.OD_NO.TabIndex = 7
        Me.OD_NO.Title = "수주 번호"
        Me.OD_NO.TitleWidth = 70
        '
        'OT_NO
        '
        Me.OT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.OT_NO.Location = New System.Drawing.Point(681, 27)
        Me.OT_NO.Name = "OT_NO"
        Me.OT_NO.Size = New System.Drawing.Size(200, 21)
        Me.OT_NO.TabIndex = 8
        Me.OT_NO.Title = "출하 번호"
        Me.OT_NO.TitleWidth = 70
        '
        'WI_BC1141
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_BC1141"
        Me.Size = New System.Drawing.Size(970, 392)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OD_DT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OD_DT2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents OD_DT2 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents OT_TO As Frame7.eDate
    Friend WithEvents OD_FORM As Frame7.eDate
    Friend WithEvents GD_NM As Frame7.eText
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents CS_CD As Frame7.eText
    Friend WithEvents CS_NM As Frame7.eText
    Friend WithEvents scd_cd As Frame7.eText
    Friend WithEvents GD_MODEL As Frame7.eCombo
    Friend WithEvents OT_NO As Frame7.eText
    Friend WithEvents OD_NO As Frame7.eText
    Friend WithEvents de_gu As Frame7.eCombo

End Class
