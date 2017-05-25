<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDA100
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
        Me.ed_fr = New Frame7.eDate()
        Me.ed_to = New Frame7.eDate()
        Me.ed_sth = New Frame7.eCombo()
        Me.lot_no = New Frame7.eText()
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
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'OD_DT2
        '
        Me.OD_DT2.Controls.Add(Me.ed_fr)
        Me.OD_DT2.Controls.Add(Me.ed_to)
        Me.OD_DT2.Controls.Add(Me.ed_sth)
        Me.OD_DT2.Controls.Add(Me.lot_no)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 78)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'ed_fr
        '
        Me.ed_fr.Location = New System.Drawing.Point(17, 27)
        Me.ed_fr.Name = "ed_fr"
        Me.ed_fr.Size = New System.Drawing.Size(180, 21)
        Me.ed_fr.TabIndex = 2
        Me.ed_fr.Title = "작성 일자"
        Me.ed_fr.TitleWidth = 60
        '
        'ed_to
        '
        Me.ed_to.Location = New System.Drawing.Point(165, 27)
        Me.ed_to.Name = "ed_to"
        Me.ed_to.Size = New System.Drawing.Size(180, 21)
        Me.ed_to.TabIndex = 3
        Me.ed_to.Title = "           ~ "
        Me.ed_to.TitleWidth = 60
        '
        'ed_sth
        '
        Me.ed_sth.Location = New System.Drawing.Point(360, 27)
        Me.ed_sth.Name = "ed_sth"
        Me.ed_sth.Size = New System.Drawing.Size(150, 21)
        Me.ed_sth.TabIndex = 5
        Me.ed_sth.Title = "식별"
        Me.ed_sth.TitleWidth = 70
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(527, 27)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(292, 21)
        Me.lot_no.TabIndex = 4
        Me.lot_no.Title = "LOT_NO"
        Me.lot_no.TitleWidth = 70
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 278)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     기술 개발 라벨 리스트 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 253)
        Me.g10.TabIndex = 2
        '
        'WI_SA11411
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA11411"
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
    Friend WithEvents ed_to As Frame7.eDate
    Friend WithEvents ed_fr As Frame7.eDate
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents ed_sth As Frame7.eCombo

End Class
