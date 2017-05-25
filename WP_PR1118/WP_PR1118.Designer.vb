<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1118
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
        Me.LOT_NO = New Frame7.eText()
        Me.IN_NO = New Frame7.eText()
        Me.IN_FR = New Frame7.eDate()
        Me.IN_TO = New Frame7.eDate()
        Me.GD_CD = New Frame7.eText()
        Me.GD_NM = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.out_nm = New Frame7.eCombo()
        Me.out_mas = New Frame7.eCombo()
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
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1137, 532)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 0
        '
        'OD_DT2
        '
        Me.OD_DT2.Controls.Add(Me.out_mas)
        Me.OD_DT2.Controls.Add(Me.out_nm)
        Me.OD_DT2.Controls.Add(Me.LOT_NO)
        Me.OD_DT2.Controls.Add(Me.IN_NO)
        Me.OD_DT2.Controls.Add(Me.IN_FR)
        Me.OD_DT2.Controls.Add(Me.IN_TO)
        Me.OD_DT2.Controls.Add(Me.GD_CD)
        Me.OD_DT2.Controls.Add(Me.GD_NM)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(1137, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'LOT_NO
        '
        Me.LOT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LOT_NO.Location = New System.Drawing.Point(668, 54)
        Me.LOT_NO.Name = "LOT_NO"
        Me.LOT_NO.Size = New System.Drawing.Size(200, 21)
        Me.LOT_NO.TabIndex = 10
        Me.LOT_NO.Title = "LOT_NO"
        Me.LOT_NO.TitleWidth = 80
        '
        'IN_NO
        '
        Me.IN_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.IN_NO.Location = New System.Drawing.Point(668, 27)
        Me.IN_NO.Name = "IN_NO"
        Me.IN_NO.Size = New System.Drawing.Size(200, 21)
        Me.IN_NO.TabIndex = 9
        Me.IN_NO.Title = "실적 번호"
        Me.IN_NO.TitleWidth = 80
        '
        'IN_FR
        '
        Me.IN_FR.Location = New System.Drawing.Point(18, 27)
        Me.IN_FR.Name = "IN_FR"
        Me.IN_FR.Size = New System.Drawing.Size(199, 21)
        Me.IN_FR.TabIndex = 2
        Me.IN_FR.Title = "기간"
        Me.IN_FR.TitleWidth = 70
        '
        'IN_TO
        '
        Me.IN_TO.Location = New System.Drawing.Point(209, 26)
        Me.IN_TO.Name = "IN_TO"
        Me.IN_TO.Size = New System.Drawing.Size(135, 21)
        Me.IN_TO.TabIndex = 3
        Me.IN_TO.Title = "   ~ "
        Me.IN_TO.TitleWidth = 30
        '
        'GD_CD
        '
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(17, 54)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(200, 21)
        Me.GD_CD.TabIndex = 4
        Me.GD_CD.Title = "품목코드"
        Me.GD_CD.TitleWidth = 70
        '
        'GD_NM
        '
        Me.GD_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_NM.Location = New System.Drawing.Point(204, 54)
        Me.GD_NM.Name = "GD_NM"
        Me.GD_NM.Size = New System.Drawing.Size(140, 21)
        Me.GD_NM.TabIndex = 4
        Me.GD_NM.Title = ""
        Me.GD_NM.TitleWidth = 35
        '
        'EPanel2
        '
        Me.EPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1137, 419)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     외주수율현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1133, 394)
        Me.g10.TabIndex = 2
        '
        'out_nm
        '
        Me.out_nm.Location = New System.Drawing.Point(392, 27)
        Me.out_nm.Name = "out_nm"
        Me.out_nm.Size = New System.Drawing.Size(240, 21)
        Me.out_nm.TabIndex = 11
        Me.out_nm.Title = "외주작업자"
        '
        'out_mas
        '
        Me.out_mas.Location = New System.Drawing.Point(392, 54)
        Me.out_mas.Name = "out_mas"
        Me.out_mas.Size = New System.Drawing.Size(240, 21)
        Me.out_mas.TabIndex = 12
        Me.out_mas.Title = "외주기계번호"
        '
        'WP_PR1118
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1118"
        Me.Size = New System.Drawing.Size(1137, 532)
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
    Friend WithEvents IN_TO As Frame7.eDate
    Friend WithEvents IN_FR As Frame7.eDate
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents GD_NM As Frame7.eText
    Friend WithEvents LOT_NO As Frame7.eText
    Friend WithEvents IN_NO As Frame7.eText
    Friend WithEvents out_mas As Frame7.eCombo
    Friend WithEvents out_nm As Frame7.eCombo

End Class
