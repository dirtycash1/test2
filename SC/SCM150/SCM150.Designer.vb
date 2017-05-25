<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCM150
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCM150))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.optMenu = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.mdl_cd = New Frame7.eCombo()
        Me.system_cd = New Frame7.eCombo()
        Me.rol_nm = New Frame7.eText()
        Me.rol_cd = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.chk_expand = New Frame7.eCheck()
        Me.EPanel3 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chk_expand2 = New Frame7.eCheck()
        Me.g10 = New Frame7.eGrid()
        Me.rol_nm2 = New Frame7.eText()
        Me.chk_under = New Frame7.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(884, 532)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.optMenu)
        Me.EPanel1.Controls.Add(Me.optAll)
        Me.EPanel1.Controls.Add(Me.mdl_cd)
        Me.EPanel1.Controls.Add(Me.system_cd)
        Me.EPanel1.Controls.Add(Me.rol_nm)
        Me.EPanel1.Controls.Add(Me.rol_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(884, 78)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'optMenu
        '
        Me.optMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.optMenu.Location = New System.Drawing.Point(528, 51)
        Me.optMenu.Name = "optMenu"
        Me.optMenu.Size = New System.Drawing.Size(88, 20)
        Me.optMenu.TabIndex = 10
        Me.optMenu.Text = "1 Panel"
        '
        'optAll
        '
        Me.optAll.Checked = True
        Me.optAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.optAll.Location = New System.Drawing.Point(528, 28)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(116, 24)
        Me.optAll.TabIndex = 9
        Me.optAll.TabStop = True
        Me.optAll.Text = "2 Panels"
        '
        'mdl_cd
        '
        Me.mdl_cd.Location = New System.Drawing.Point(12, 52)
        Me.mdl_cd.Name = "mdl_cd"
        Me.mdl_cd.Size = New System.Drawing.Size(240, 21)
        Me.mdl_cd.TabIndex = 3
        Me.mdl_cd.Title = "Module"
        Me.mdl_cd.TitleWidth = 80
        '
        'system_cd
        '
        Me.system_cd.Location = New System.Drawing.Point(12, 28)
        Me.system_cd.Name = "system_cd"
        Me.system_cd.Size = New System.Drawing.Size(240, 21)
        Me.system_cd.TabIndex = 3
        Me.system_cd.Title = "System"
        Me.system_cd.TitleWidth = 80
        '
        'rol_nm
        '
        Me.rol_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rol_nm.Location = New System.Drawing.Point(268, 28)
        Me.rol_nm.Name = "rol_nm"
        Me.rol_nm.Size = New System.Drawing.Size(240, 21)
        Me.rol_nm.TabIndex = 2
        Me.rol_nm.Title = "업무그룹명"
        Me.rol_nm.TitleWidth = 80
        '
        'rol_cd
        '
        Me.rol_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rol_cd.Location = New System.Drawing.Point(696, 40)
        Me.rol_cd.Name = "rol_cd"
        Me.rol_cd.Size = New System.Drawing.Size(100, 21)
        Me.rol_cd.TabIndex = 2
        Me.rol_cd.Title = "rol_cd"
        Me.rol_cd.TitleWidth = 80
        Me.rol_cd.Visible = False
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
        Me.SplitContainer2.Size = New System.Drawing.Size(884, 450)
        Me.SplitContainer2.SplitterDistance = 244
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.TreeView1)
        Me.EPanel2.Controls.Add(Me.chk_expand)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(244, 450)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     업무그룹 구조도"
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(2, 23)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(240, 425)
        Me.TreeView1.TabIndex = 2
        '
        'chk_expand
        '
        Me.chk_expand.BackColor = System.Drawing.Color.Transparent
        Me.chk_expand.Caption = "Expand"
        Me.chk_expand.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_expand.Location = New System.Drawing.Point(142, 2)
        Me.chk_expand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_expand.Name = "chk_expand"
        Me.chk_expand.Size = New System.Drawing.Size(74, 21)
        Me.chk_expand.TabIndex = 4
        Me.chk_expand.Title = "Check"
        Me.chk_expand.TitleWidth = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.SplitContainer3)
        Me.EPanel3.Controls.Add(Me.rol_nm2)
        Me.EPanel3.Controls.Add(Me.chk_under)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(636, 450)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     권한 등록"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(632, 425)
        Me.SplitContainer3.SplitterDistance = 203
        Me.SplitContainer3.TabIndex = 3
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.TreeView2)
        Me.EPanel4.Controls.Add(Me.chk_expand2)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(203, 425)
        Me.EPanel4.TabIndex = 3
        Me.EPanel4.Text = "     Menu"
        '
        'TreeView2
        '
        Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView2.ImageIndex = 0
        Me.TreeView2.ImageList = Me.ImageList1
        Me.TreeView2.Location = New System.Drawing.Point(2, 23)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.SelectedImageIndex = 0
        Me.TreeView2.Size = New System.Drawing.Size(199, 400)
        Me.TreeView2.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        '
        'chk_expand2
        '
        Me.chk_expand2.BackColor = System.Drawing.Color.Transparent
        Me.chk_expand2.Caption = "Expand"
        Me.chk_expand2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_expand2.Location = New System.Drawing.Point(92, 2)
        Me.chk_expand2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_expand2.Name = "chk_expand2"
        Me.chk_expand2.Size = New System.Drawing.Size(68, 21)
        Me.chk_expand2.TabIndex = 4
        Me.chk_expand2.Title = "Expand"
        Me.chk_expand2.TitleWidth = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(425, 425)
        Me.g10.TabIndex = 2
        '
        'rol_nm2
        '
        Me.rol_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rol_nm2.Location = New System.Drawing.Point(120, 2)
        Me.rol_nm2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rol_nm2.Name = "rol_nm2"
        Me.rol_nm2.Size = New System.Drawing.Size(296, 21)
        Me.rol_nm2.TabIndex = 2
        Me.rol_nm2.Title = "업무그룹"
        Me.rol_nm2.TitleWidth = 70
        '
        'chk_under
        '
        Me.chk_under.BackColor = System.Drawing.Color.Transparent
        Me.chk_under.Caption = ""
        Me.chk_under.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_under.Location = New System.Drawing.Point(428, 2)
        Me.chk_under.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_under.Name = "chk_under"
        Me.chk_under.Size = New System.Drawing.Size(152, 21)
        Me.chk_under.TabIndex = 4
        Me.chk_under.Title = "하위구조 변경"
        Me.chk_under.TitleWidth = 100
        '
        'SCM150
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SCM150"
        Me.Size = New System.Drawing.Size(977, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents rol_nm As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents chk_expand As Frame7.eCheck
    Friend WithEvents rol_nm2 As Frame7.eText
    Friend WithEvents system_cd As Frame7.eCombo
    Friend WithEvents chk_under As Frame7.eCheck
    Friend WithEvents mdl_cd As Frame7.eCombo
    Friend WithEvents optMenu As System.Windows.Forms.RadioButton
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents rol_cd As Frame7.eText
    Friend WithEvents chk_expand2 As Frame7.eCheck
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
