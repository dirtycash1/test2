<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1162
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
        Me.IP_DT = New Frame7.eDate()
        Me.IP_SDT = New Frame7.eDate()
        Me.CS_CD = New Frame7.eText()
        Me.CS_NM = New Frame7.eText()
        Me.SCD_CD = New Frame7.eText()
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
        Me.OD_DT2.Controls.Add(Me.IP_DT)
        Me.OD_DT2.Controls.Add(Me.IP_SDT)
        Me.OD_DT2.Controls.Add(Me.CS_CD)
        Me.OD_DT2.Controls.Add(Me.CS_NM)
        Me.OD_DT2.Controls.Add(Me.SCD_CD)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'IP_DT
        '
        Me.IP_DT.Location = New System.Drawing.Point(17, 27)
        Me.IP_DT.Name = "IP_DT"
        Me.IP_DT.Size = New System.Drawing.Size(160, 21)
        Me.IP_DT.TabIndex = 2
        Me.IP_DT.Title = "수금 기간"
        Me.IP_DT.TitleWidth = 70
        '
        'IP_SDT
        '
        Me.IP_SDT.Location = New System.Drawing.Point(173, 27)
        Me.IP_SDT.Name = "IP_SDT"
        Me.IP_SDT.Size = New System.Drawing.Size(135, 21)
        Me.IP_SDT.TabIndex = 3
        Me.IP_SDT.Title = "   ~ "
        Me.IP_SDT.TitleWidth = 30
        '
        'CS_CD
        '
        Me.CS_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_CD.Location = New System.Drawing.Point(342, 65)
        Me.CS_CD.Name = "CS_CD"
        Me.CS_CD.Size = New System.Drawing.Size(240, 21)
        Me.CS_CD.TabIndex = 4
        Me.CS_CD.Title = "거래처 코드"
        '
        'CS_NM
        '
        Me.CS_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_NM.Location = New System.Drawing.Point(342, 27)
        Me.CS_NM.Name = "CS_NM"
        Me.CS_NM.Size = New System.Drawing.Size(240, 21)
        Me.CS_NM.TabIndex = 4
        Me.CS_NM.Title = "거래처명"
        '
        'SCD_CD
        '
        Me.SCD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SCD_CD.Location = New System.Drawing.Point(17, 65)
        Me.SCD_CD.Name = "SCD_CD"
        Me.SCD_CD.Size = New System.Drawing.Size(240, 21)
        Me.SCD_CD.TabIndex = 4
        Me.SCD_CD.Title = "영업담당자"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 247)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수금 현황"
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
        'WI_SA1162
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1162"
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
    Friend WithEvents IP_SDT As Frame7.eDate
    Friend WithEvents IP_DT As Frame7.eDate
    Friend WithEvents CS_CD As Frame7.eText
    Friend WithEvents CS_NM As Frame7.eText
    Friend WithEvents SCD_CD As Frame7.eText

End Class
