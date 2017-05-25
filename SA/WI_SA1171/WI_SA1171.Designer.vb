<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1171
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
        Me.FROM_DT = New Frame7.eDate()
        Me.TO_DT = New Frame7.eDate()
        Me.CS_CD = New Frame7.eText()
        Me.CS_NM = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.sale_emp = New Frame7.eText()
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
        Me.SplitContainer1.SplitterDistance = 57
        Me.SplitContainer1.TabIndex = 0
        '
        'OD_DT2
        '
        Me.OD_DT2.Controls.Add(Me.FROM_DT)
        Me.OD_DT2.Controls.Add(Me.TO_DT)
        Me.OD_DT2.Controls.Add(Me.CS_CD)
        Me.OD_DT2.Controls.Add(Me.CS_NM)
        Me.OD_DT2.Controls.Add(Me.sale_emp)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 57)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'FROM_DT
        '
        Me.FROM_DT.Location = New System.Drawing.Point(17, 27)
        Me.FROM_DT.Name = "FROM_DT"
        Me.FROM_DT.Size = New System.Drawing.Size(140, 21)
        Me.FROM_DT.TabIndex = 2
        Me.FROM_DT.Title = "발행 일자"
        Me.FROM_DT.TitleWidth = 50
        '
        'TO_DT
        '
        Me.TO_DT.Location = New System.Drawing.Point(155, 27)
        Me.TO_DT.Name = "TO_DT"
        Me.TO_DT.Size = New System.Drawing.Size(135, 21)
        Me.TO_DT.TabIndex = 3
        Me.TO_DT.Title = "   ~ "
        Me.TO_DT.TitleWidth = 30
        '
        'CS_CD
        '
        Me.CS_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_CD.Location = New System.Drawing.Point(313, 27)
        Me.CS_CD.Name = "CS_CD"
        Me.CS_CD.Size = New System.Drawing.Size(200, 21)
        Me.CS_CD.TabIndex = 4
        Me.CS_CD.Title = "발행거래처코드"
        Me.CS_CD.TitleWidth = 90
        '
        'CS_NM
        '
        Me.CS_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CS_NM.Location = New System.Drawing.Point(464, 27)
        Me.CS_NM.Name = "CS_NM"
        Me.CS_NM.Size = New System.Drawing.Size(240, 21)
        Me.CS_NM.TabIndex = 4
        Me.CS_NM.Title = "거래처명"
        Me.CS_NM.TitleWidth = 50
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 299)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     세금계산서발행현황 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 274)
        Me.g10.TabIndex = 2
        '
        'sale_emp
        '
        Me.sale_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_emp.Location = New System.Drawing.Point(710, 27)
        Me.sale_emp.Name = "sale_emp"
        Me.sale_emp.Size = New System.Drawing.Size(160, 21)
        Me.sale_emp.TabIndex = 4
        Me.sale_emp.Title = "영업 담당자"
        Me.sale_emp.TitleWidth = 70
        '
        'WI_SA1171
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1171"
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
    Friend WithEvents CS_CD As Frame7.eText
    Friend WithEvents CS_NM As Frame7.eText
    Friend WithEvents sale_emp As Frame7.eText

End Class
