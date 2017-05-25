<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1161
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
        Me.GONG_NM = New Frame7.eCombo()
        Me.CS_NO = New Frame7.eText()
        Me.WA_GU = New Frame7.eCombo()
        Me.FROM_DT = New Frame7.eDate()
        Me.GD_CD = New Frame7.eText()
        Me.TO_DT = New Frame7.eDate()
        Me.MC_CD = New Frame7.eText()
        Me.NOT_NO = New Frame7.eText()
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
        Me.OD_DT2.Controls.Add(Me.GONG_NM)
        Me.OD_DT2.Controls.Add(Me.CS_NO)
        Me.OD_DT2.Controls.Add(Me.WA_GU)
        Me.OD_DT2.Controls.Add(Me.FROM_DT)
        Me.OD_DT2.Controls.Add(Me.GD_CD)
        Me.OD_DT2.Controls.Add(Me.TO_DT)
        Me.OD_DT2.Controls.Add(Me.MC_CD)
        Me.OD_DT2.Controls.Add(Me.NOT_NO)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'GONG_NM
        '
        Me.GONG_NM.Location = New System.Drawing.Point(648, 27)
        Me.GONG_NM.Name = "GONG_NM"
        Me.GONG_NM.Size = New System.Drawing.Size(200, 21)
        Me.GONG_NM.TabIndex = 5
        Me.GONG_NM.Title = "공정명"
        Me.GONG_NM.TitleWidth = 90
        '
        'CS_NO
        '
        Me.CS_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_NO.Location = New System.Drawing.Point(17, 66)
        Me.CS_NO.Name = "CS_NO"
        Me.CS_NO.Size = New System.Drawing.Size(200, 21)
        Me.CS_NO.TabIndex = 4
        Me.CS_NO.Title = "SEHHT번호"
        Me.CS_NO.TitleWidth = 80
        '
        'WA_GU
        '
        Me.WA_GU.Location = New System.Drawing.Point(648, 66)
        Me.WA_GU.Name = "WA_GU"
        Me.WA_GU.Size = New System.Drawing.Size(200, 21)
        Me.WA_GU.TabIndex = 5
        Me.WA_GU.Title = "작업장구분"
        Me.WA_GU.TitleWidth = 90
        '
        'FROM_DT
        '
        Me.FROM_DT.Location = New System.Drawing.Point(17, 27)
        Me.FROM_DT.Name = "FROM_DT"
        Me.FROM_DT.Size = New System.Drawing.Size(140, 21)
        Me.FROM_DT.TabIndex = 2
        Me.FROM_DT.TextAlign = Frame7.Alignment.Center
        Me.FROM_DT.Title = "발행일자"
        Me.FROM_DT.TitleWidth = 50
        '
        'GD_CD
        '
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(223, 66)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(200, 21)
        Me.GD_CD.TabIndex = 4
        Me.GD_CD.Title = "제품명"
        Me.GD_CD.TitleAlign = Frame7.Alignment.Center
        Me.GD_CD.TitleWidth = 80
        '
        'TO_DT
        '
        Me.TO_DT.Location = New System.Drawing.Point(163, 27)
        Me.TO_DT.Name = "TO_DT"
        Me.TO_DT.Size = New System.Drawing.Size(135, 21)
        Me.TO_DT.TabIndex = 3
        Me.TO_DT.TextAlign = Frame7.Alignment.Center
        Me.TO_DT.Title = "   ~ "
        Me.TO_DT.TitleWidth = 30
        '
        'MC_CD
        '
        Me.MC_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.MC_CD.Location = New System.Drawing.Point(429, 66)
        Me.MC_CD.Name = "MC_CD"
        Me.MC_CD.Size = New System.Drawing.Size(200, 21)
        Me.MC_CD.TabIndex = 4
        Me.MC_CD.Title = "기계명"
        Me.MC_CD.TitleAlign = Frame7.Alignment.Center
        Me.MC_CD.TitleWidth = 80
        '
        'NOT_NO
        '
        Me.NOT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.NOT_NO.Location = New System.Drawing.Point(429, 27)
        Me.NOT_NO.Name = "NOT_NO"
        Me.NOT_NO.Size = New System.Drawing.Size(200, 21)
        Me.NOT_NO.TabIndex = 4
        Me.NOT_NO.Title = "Not_No"
        Me.NOT_NO.TitleAlign = Frame7.Alignment.Center
        Me.NOT_NO.TitleWidth = 80
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 247)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     CHECK-SHEET 현황"
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
        'WP_PR1161
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1161"
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
    Friend WithEvents TO_DT As Frame7.eDate
    Friend WithEvents FROM_DT As Frame7.eDate
    Friend WithEvents CS_NO As Frame7.eText
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents MC_CD As Frame7.eText
    Friend WithEvents NOT_NO As Frame7.eText
    Friend WithEvents GONG_NM As Frame7.eCombo
    Friend WithEvents WA_GU As Frame7.eCombo

End Class
