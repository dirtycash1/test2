<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QOA115
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.EPanel5 = New Frame7.ePanel()
        Me.gvx = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.itm_cd = New Frame7.eText()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.itm_nm = New Frame7.eText()
        Me.g10 = New Frame7.ePivotGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 608)
        Me.SplitContainer1.SplitterDistance = 56
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1120, 56)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g10)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(1120, 548)
        Me.EPanel5.TabIndex = 1
        Me.EPanel5.Text = "     자재 인벤트리 현황"
        '
        'gvx
        '
        Me.gvx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvx.Location = New System.Drawing.Point(2, 23)
        Me.gvx.Name = "gvx"
        Me.gvx.ReadOnly = False
        Me.gvx.RecordNavigator = False
        Me.gvx.RowHeight = -1
        Me.gvx.Size = New System.Drawing.Size(1109, 309)
        Me.gvx.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.gvx)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(2, 2)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1113, 334)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     품목현황"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(315, 26)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 14
        Me.itm_cd.Title = "품목코드"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(14, 26)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(284, 21)
        Me.itm_bc.TabIndex = 15
        Me.itm_bc.Title = "품목구분"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(573, 26)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 13
        Me.itm_nm.Title = "품목명"
        '
        'g10
        '
        Me.g10.AllowAddRows = False
        Me.g10.AllowDeleteRows = False
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(1116, 523)
        Me.g10.TabIndex = 2
        '
        'QOA115
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QOA115"
        Me.Size = New System.Drawing.Size(1143, 654)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents gvx As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.ePivotGrid

End Class
