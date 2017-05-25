<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1121_1
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
        Me.PS_NO = New Frame7.eText()
        Me.STTS = New Frame7.eCombo()
        Me.CS_CD = New Frame7.eText()
        Me.SCD_CD = New Frame7.eText()
        Me.CS_NM = New Frame7.eText()
        Me.GD_CD = New Frame7.eText()
        Me.GD_MODEL = New Frame7.eCombo()
        Me.OD_FORM = New Frame7.eDate()
        Me.OD_TO = New Frame7.eDate()
        Me.GD_NM = New Frame7.eText()
        Me.PS_NM = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.OD_DT2.Controls.Add(Me.PS_NO)
        Me.OD_DT2.Controls.Add(Me.STTS)
        Me.OD_DT2.Controls.Add(Me.CS_CD)
        Me.OD_DT2.Controls.Add(Me.SCD_CD)
        Me.OD_DT2.Controls.Add(Me.CS_NM)
        Me.OD_DT2.Controls.Add(Me.GD_CD)
        Me.OD_DT2.Controls.Add(Me.GD_MODEL)
        Me.OD_DT2.Controls.Add(Me.OD_FORM)
        Me.OD_DT2.Controls.Add(Me.OD_TO)
        Me.OD_DT2.Controls.Add(Me.GD_NM)
        Me.OD_DT2.Controls.Add(Me.PS_NM)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'PS_NO
        '
        Me.PS_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PS_NO.Location = New System.Drawing.Point(558, 53)
        Me.PS_NO.Name = "PS_NO"
        Me.PS_NO.Size = New System.Drawing.Size(180, 21)
        Me.PS_NO.TabIndex = 11
        Me.PS_NO.Title = "수주입력자"
        Me.PS_NO.TitleWidth = 70
        '
        'STTS
        '
        Me.STTS.Location = New System.Drawing.Point(17, 80)
        Me.STTS.Name = "STTS"
        Me.STTS.Size = New System.Drawing.Size(200, 21)
        Me.STTS.TabIndex = 10
        Me.STTS.Title = "상태"
        Me.STTS.TitleWidth = 80
        '
        'CS_CD
        '
        Me.CS_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_CD.Location = New System.Drawing.Point(17, 53)
        Me.CS_CD.Name = "CS_CD"
        Me.CS_CD.Size = New System.Drawing.Size(200, 21)
        Me.CS_CD.TabIndex = 4
        Me.CS_CD.Title = "거래쳐"
        Me.CS_CD.TitleWidth = 80
        '
        'SCD_CD
        '
        Me.SCD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCD_CD.Location = New System.Drawing.Point(353, 53)
        Me.SCD_CD.Name = "SCD_CD"
        Me.SCD_CD.Size = New System.Drawing.Size(180, 21)
        Me.SCD_CD.TabIndex = 8
        Me.SCD_CD.Title = "영업담당자"
        Me.SCD_CD.TitleWidth = 70
        '
        'CS_NM
        '
        Me.CS_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_NM.Location = New System.Drawing.Point(136, 53)
        Me.CS_NM.Name = "CS_NM"
        Me.CS_NM.Size = New System.Drawing.Size(200, 21)
        Me.CS_NM.TabIndex = 7
        Me.CS_NM.Title = "SHEET번호"
        Me.CS_NM.TitleWidth = 80
        '
        'GD_CD
        '
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(558, 26)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(180, 21)
        Me.GD_CD.TabIndex = 6
        Me.GD_CD.Title = "판매코드"
        Me.GD_CD.TitleWidth = 70
        '
        'GD_MODEL
        '
        Me.GD_MODEL.Location = New System.Drawing.Point(353, 26)
        Me.GD_MODEL.Name = "GD_MODEL"
        Me.GD_MODEL.Size = New System.Drawing.Size(180, 21)
        Me.GD_MODEL.TabIndex = 5
        Me.GD_MODEL.Title = "제품군"
        Me.GD_MODEL.TitleWidth = 70
        '
        'OD_FORM
        '
        Me.OD_FORM.Location = New System.Drawing.Point(17, 27)
        Me.OD_FORM.Name = "OD_FORM"
        Me.OD_FORM.Size = New System.Drawing.Size(190, 21)
        Me.OD_FORM.TabIndex = 2
        Me.OD_FORM.Title = "수주 일자"
        Me.OD_FORM.TitleWidth = 80
        '
        'OD_TO
        '
        Me.OD_TO.Location = New System.Drawing.Point(202, 27)
        Me.OD_TO.Name = "OD_TO"
        Me.OD_TO.Size = New System.Drawing.Size(135, 21)
        Me.OD_TO.TabIndex = 3
        Me.OD_TO.Title = "   ~ "
        Me.OD_TO.TitleWidth = 30
        '
        'GD_NM
        '
        Me.GD_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_NM.Location = New System.Drawing.Point(678, 26)
        Me.GD_NM.Name = "GD_NM"
        Me.GD_NM.Size = New System.Drawing.Size(200, 21)
        Me.GD_NM.TabIndex = 9
        Me.GD_NM.Title = "SHEET번호"
        Me.GD_NM.TitleWidth = 60
        '
        'PS_NM
        '
        Me.PS_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PS_NM.Location = New System.Drawing.Point(678, 53)
        Me.PS_NM.Name = "PS_NM"
        Me.PS_NM.Size = New System.Drawing.Size(200, 21)
        Me.PS_NM.TabIndex = 12
        Me.PS_NM.Title = "SHEET번호"
        Me.PS_NM.TitleWidth = 60
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 247)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수주 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 222)
        Me.g10.TabIndex = 2
        '
        'WI_SA1121_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1121_1"
        Me.Size = New System.Drawing.Size(1027, 386)
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
    Friend WithEvents OD_TO As Frame7.eDate
    Friend WithEvents OD_FORM As Frame7.eDate
    Friend WithEvents CS_CD As Frame7.eText
    Friend WithEvents SCD_CD As Frame7.eText
    Friend WithEvents CS_NM As Frame7.eText
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents GD_MODEL As Frame7.eCombo
    Friend WithEvents GD_NM As Frame7.eText
    Friend WithEvents STTS As Frame7.eCombo
    Friend WithEvents PS_NO As Frame7.eText
    Friend WithEvents PS_NM As Frame7.eText

End Class
