<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCH100
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
        Me.system_cd = New Frame7.eCombo()
        Me.frm_cd2 = New Frame7.eText()
        Me.menu_nm = New Frame7.eText()
        Me.top_menu = New Frame7.eCheckCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.EPanel4 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.dsc = New System.Windows.Forms.RichTextBox()
        Me.EPanel5 = New Frame7.ePanel()
        Me.usr_dsc = New System.Windows.Forms.RichTextBox()
        Me.EPanel6 = New Frame7.ePanel()
        Me.dsc_img = New Frame7.eImage()
        Me.frm_cd3 = New Frame7.eText()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.title = New System.Windows.Forms.RichTextBox()
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.EText3 = New Frame7.eText()
        Me.frm_nm3 = New Frame7.eText()
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
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel6.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 520)
        Me.SplitContainer1.SplitterDistance = 55
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.system_cd)
        Me.EPanel1.Controls.Add(Me.frm_cd2)
        Me.EPanel1.Controls.Add(Me.menu_nm)
        Me.EPanel1.Controls.Add(Me.top_menu)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(900, 55)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'system_cd
        '
        Me.system_cd.Location = New System.Drawing.Point(12, 28)
        Me.system_cd.Name = "system_cd"
        Me.system_cd.Size = New System.Drawing.Size(200, 21)
        Me.system_cd.TabIndex = 1
        Me.system_cd.Title = "system_cd"
        Me.system_cd.TitleWidth = 80
        '
        'frm_cd2
        '
        Me.frm_cd2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.frm_cd2.Location = New System.Drawing.Point(224, 28)
        Me.frm_cd2.Name = "frm_cd2"
        Me.frm_cd2.Size = New System.Drawing.Size(204, 21)
        Me.frm_cd2.TabIndex = 1
        Me.frm_cd2.Title = "Form Code"
        Me.frm_cd2.TitleWidth = 80
        '
        'menu_nm
        '
        Me.menu_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.menu_nm.Location = New System.Drawing.Point(720, 28)
        Me.menu_nm.Name = "menu_nm"
        Me.menu_nm.Size = New System.Drawing.Size(220, 21)
        Me.menu_nm.TabIndex = 1
        Me.menu_nm.Title = "Menu Name"
        Me.menu_nm.TitleWidth = 80
        '
        'top_menu
        '
        Me.top_menu.Location = New System.Drawing.Point(440, 28)
        Me.top_menu.Name = "top_menu"
        Me.top_menu.Size = New System.Drawing.Size(268, 21)
        Me.top_menu.TabIndex = 1
        Me.top_menu.Title = "top_menu"
        Me.top_menu.TitleWidth = 80
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
        Me.SplitContainer2.Size = New System.Drawing.Size(900, 461)
        Me.SplitContainer2.SplitterDistance = 298
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(298, 461)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     메뉴"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(294, 436)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.EPanel4)
        Me.EPanel3.Controls.Add(Me.frm_cd3)
        Me.EPanel3.Controls.Add(Me.btn_save)
        Me.EPanel3.Controls.Add(Me.title)
        Me.EPanel3.Controls.Add(Me.btn_jump)
        Me.EPanel3.Controls.Add(Me.EText3)
        Me.EPanel3.Controls.Add(Me.frm_nm3)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(598, 461)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     도움말"
        '
        'EPanel4
        '
        Me.EPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel4.Controls.Add(Me.SplitContainer3)
        Me.EPanel4.Location = New System.Drawing.Point(6, 116)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(586, 340)
        Me.EPanel4.TabIndex = 18
        Me.EPanel4.Text = "     설명"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel6)
        Me.SplitContainer3.Size = New System.Drawing.Size(582, 315)
        Me.SplitContainer3.SplitterDistance = 322
        Me.SplitContainer3.TabIndex = 17
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.dsc)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer4.Size = New System.Drawing.Size(322, 315)
        Me.SplitContainer4.SplitterDistance = 262
        Me.SplitContainer4.TabIndex = 1
        '
        'dsc
        '
        Me.dsc.AcceptsTab = True
        Me.dsc.AutoWordSelection = True
        Me.dsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dsc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dsc.Location = New System.Drawing.Point(0, 0)
        Me.dsc.Name = "dsc"
        Me.dsc.Size = New System.Drawing.Size(322, 262)
        Me.dsc.TabIndex = 0
        Me.dsc.Text = ""
        Me.dsc.WordWrap = False
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.usr_dsc)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(322, 49)
        Me.EPanel5.TabIndex = 0
        Me.EPanel5.Text = "     사용자 메모"
        '
        'usr_dsc
        '
        Me.usr_dsc.AcceptsTab = True
        Me.usr_dsc.AutoWordSelection = True
        Me.usr_dsc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usr_dsc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usr_dsc.Location = New System.Drawing.Point(2, 23)
        Me.usr_dsc.Name = "usr_dsc"
        Me.usr_dsc.Size = New System.Drawing.Size(318, 24)
        Me.usr_dsc.TabIndex = 0
        Me.usr_dsc.Text = ""
        Me.usr_dsc.WordWrap = False
        '
        'EPanel6
        '
        Me.EPanel6.Controls.Add(Me.dsc_img)
        Me.EPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel6.Location = New System.Drawing.Point(0, 0)
        Me.EPanel6.Name = "EPanel6"
        Me.EPanel6.Size = New System.Drawing.Size(256, 315)
        Me.EPanel6.TabIndex = 17
        Me.EPanel6.Text = "     그림"
        '
        'dsc_img
        '
        Me.dsc_img.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dsc_img.Location = New System.Drawing.Point(2, 23)
        Me.dsc_img.Name = "dsc_img"
        Me.dsc_img.Size = New System.Drawing.Size(252, 290)
        Me.dsc_img.SizeMode = Frame7.ImageSizeMode.Stretch
        Me.dsc_img.TabIndex = 16
        Me.dsc_img.TitleWidth = 80
        '
        'frm_cd3
        '
        Me.frm_cd3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.frm_cd3.Location = New System.Drawing.Point(8, 28)
        Me.frm_cd3.Name = "frm_cd3"
        Me.frm_cd3.Size = New System.Drawing.Size(216, 21)
        Me.frm_cd3.TabIndex = 1
        Me.frm_cd3.Title = "frm_cd"
        Me.frm_cd3.TitleWidth = 80
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(396, 52)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 20)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        '
        'title
        '
        Me.title.AcceptsTab = True
        Me.title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title.AutoWordSelection = True
        Me.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title.Location = New System.Drawing.Point(6, 76)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(586, 36)
        Me.title.TabIndex = 0
        Me.title.Text = ""
        Me.title.WordWrap = False
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(292, 52)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(96, 20)
        Me.btn_jump.TabIndex = 2
        Me.btn_jump.Text = "Jump"
        '
        'EText3
        '
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText3.Location = New System.Drawing.Point(8, 54)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(120, 21)
        Me.EText3.TabIndex = 1
        Me.EText3.Title = "개요"
        '
        'frm_nm3
        '
        Me.frm_nm3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.frm_nm3.Location = New System.Drawing.Point(226, 28)
        Me.frm_nm3.Name = "frm_nm3"
        Me.frm_nm3.Size = New System.Drawing.Size(266, 21)
        Me.frm_nm3.TabIndex = 1
        Me.frm_nm3.TitleWidth = 0
        '
        'SCH100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SCH100"
        Me.Size = New System.Drawing.Size(928, 540)
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
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents menu_nm As Frame7.eText
    Friend WithEvents frm_cd2 As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents frm_nm3 As Frame7.eText
    Friend WithEvents frm_cd3 As Frame7.eText
    Friend WithEvents dsc As System.Windows.Forms.RichTextBox
    Friend WithEvents title As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents top_menu As Frame7.eCheckCombo
    Friend WithEvents system_cd As Frame7.eCombo
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dsc_img As Frame7.eImage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents usr_dsc As System.Windows.Forms.RichTextBox
    Friend WithEvents EPanel6 As Frame7.ePanel

End Class
