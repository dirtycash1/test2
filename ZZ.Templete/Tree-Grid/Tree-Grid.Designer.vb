<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tree_Grid
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
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드4")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드5")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드0", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드1")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("노드2")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EPanel1 = New Frame7.ePanel
        Me.EDate1 = New Frame7.eDate
        Me.ECombo1 = New Frame7.eCombo
        Me.EDate2 = New Frame7.eDate
        Me.ECheck1 = New Frame7.eCheck
        Me.EText2 = New Frame7.eText
        Me.EPanel2 = New Frame7.ePanel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.EPanel3 = New Frame7.ePanel
        Me.g10 = New Frame7.eGrid
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 528)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.EDate1)
        Me.EPanel1.Controls.Add(Me.ECombo1)
        Me.EPanel1.Controls.Add(Me.EDate2)
        Me.EPanel1.Controls.Add(Me.ECheck1)
        Me.EPanel1.Controls.Add(Me.EText2)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(936, 78)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'EDate1
        '
        Me.EDate1.Location = New System.Drawing.Point(12, 28)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(240, 21)
        Me.EDate1.TabIndex = 5
        Me.EDate1.Title = "기간 (Date)"
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(272, 28)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECombo1.TabIndex = 3
        Me.ECombo1.Title = "Combo"
        '
        'EDate2
        '
        Me.EDate2.Location = New System.Drawing.Point(132, 52)
        Me.EDate2.Name = "EDate2"
        Me.EDate2.Size = New System.Drawing.Size(120, 21)
        Me.EDate2.TabIndex = 5
        Me.EDate2.TitleWidth = 0
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Location = New System.Drawing.Point(532, 28)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(172, 21)
        Me.ECheck1.TabIndex = 4
        Me.ECheck1.Title = "Check"
        '
        'EText2
        '
        Me.EText2.Location = New System.Drawing.Point(272, 52)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(240, 21)
        Me.EText2.TabIndex = 2
        Me.EText2.Title = "Text"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.TreeView1)
        Me.EPanel2.Controls.Add(Me.CheckEdit1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(312, 446)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     부서 구조도"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(936, 446)
        Me.SplitContainer2.SplitterDistance = 312
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(620, 446)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     사원 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.Size = New System.Drawing.Size(616, 421)
        Me.g10.TabIndex = 3
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(2, 23)
        Me.TreeView1.Name = "TreeView1"
        TreeNode6.Name = "노드4"
        TreeNode6.Text = "노드4"
        TreeNode7.Name = "노드5"
        TreeNode7.Text = "노드5"
        TreeNode8.Name = "노드0"
        TreeNode8.Text = "노드0"
        TreeNode9.Name = "노드1"
        TreeNode9.Text = "노드1"
        TreeNode10.Name = "노드2"
        TreeNode10.Text = "노드2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Me.TreeView1.Size = New System.Drawing.Size(308, 421)
        Me.TreeView1.TabIndex = 2
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(224, 3)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Expand"
        Me.CheckEdit1.Size = New System.Drawing.Size(88, 19)
        Me.CheckEdit1.TabIndex = 3
        '
        'Tree_Grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Tree_Grid"
        Me.Size = New System.Drawing.Size(1040, 623)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents ECheck1 As Frame7.eCheck
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents EDate2 As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView

End Class
