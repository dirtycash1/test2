<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMB106
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DMB106))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.itm_f_nm = New Frame7.eText()
        Me.chk_bom = New Frame7.eCheck()
        Me.spec1 = New Frame7.eCombo()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_f_cd = New Frame7.eText()
        Me.grp3_cd = New Frame7.eCombo()
        Me.grp2_cd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.itm_rev = New Frame7.eCombo()
        Me.itm_pcd = New Frame7.eText()
        Me.itm_pnm = New Frame7.eText()
        Me.itm_pid = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel6 = New Frame7.ePanel()
        Me.chk_expand = New DevExpress.XtraEditors.CheckEdit()
        Me.treeFields = New DevExpress.XtraTreeList.TreeList()
        Me.BOM_Icon = New System.Windows.Forms.ImageList()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel6.SuspendLayout()
        CType(Me.chk_expand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.treeFields, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 616)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_f_nm)
        Me.EPanel1.Controls.Add(Me.chk_bom)
        Me.EPanel1.Controls.Add(Me.spec1)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_f_cd)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(916, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'itm_f_nm
        '
        Me.itm_f_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_f_nm.Location = New System.Drawing.Point(12, 76)
        Me.itm_f_nm.Name = "itm_f_nm"
        Me.itm_f_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_f_nm.TabIndex = 56
        Me.itm_f_nm.Title = "품목코드%"
        '
        'chk_bom
        '
        Me.chk_bom.Caption = ""
        Me.chk_bom.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_bom.Location = New System.Drawing.Point(532, 76)
        Me.chk_bom.Name = "chk_bom"
        Me.chk_bom.Size = New System.Drawing.Size(136, 21)
        Me.chk_bom.TabIndex = 57
        Me.chk_bom.Title = "BOM구성품 만 보기"
        '
        'spec1
        '
        Me.spec1.Location = New System.Drawing.Point(532, 52)
        Me.spec1.Name = "spec1"
        Me.spec1.Size = New System.Drawing.Size(240, 21)
        Me.spec1.TabIndex = 59
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(12, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 58
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(532, 28)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 59
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(272, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 55
        Me.grp1_cd.Title = "대분류"
        '
        'itm_f_cd
        '
        Me.itm_f_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_f_cd.Location = New System.Drawing.Point(12, 52)
        Me.itm_f_cd.Name = "itm_f_cd"
        Me.itm_f_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_f_cd.TabIndex = 2
        Me.itm_f_cd.Title = "품목코드%"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(272, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 53
        Me.grp3_cd.Title = "소분류"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(272, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 52
        Me.grp2_cd.Title = "중분류"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(916, 509)
        Me.SplitContainer2.SplitterDistance = 300
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(300, 509)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     품목정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(296, 484)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(612, 509)
        Me.SplitContainer3.SplitterDistance = 57
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.itm_rev)
        Me.EPanel2.Controls.Add(Me.itm_pcd)
        Me.EPanel2.Controls.Add(Me.itm_pnm)
        Me.EPanel2.Controls.Add(Me.itm_pid)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(612, 57)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     BOM Tree"
        '
        'itm_rev
        '
        Me.itm_rev.Location = New System.Drawing.Point(60, 100)
        Me.itm_rev.Name = "itm_rev"
        Me.itm_rev.Size = New System.Drawing.Size(240, 21)
        Me.itm_rev.TabIndex = 58
        Me.itm_rev.Title = "차수"
        '
        'itm_pcd
        '
        Me.itm_pcd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_pcd.Location = New System.Drawing.Point(12, 29)
        Me.itm_pcd.Name = "itm_pcd"
        Me.itm_pcd.Size = New System.Drawing.Size(128, 21)
        Me.itm_pcd.TabIndex = 4
        Me.itm_pcd.Title = "모품목코드"
        Me.itm_pcd.TitleWidth = 0
        '
        'itm_pnm
        '
        Me.itm_pnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_pnm.Location = New System.Drawing.Point(144, 29)
        Me.itm_pnm.Name = "itm_pnm"
        Me.itm_pnm.Size = New System.Drawing.Size(328, 21)
        Me.itm_pnm.TabIndex = 3
        Me.itm_pnm.Title = "모품목명"
        Me.itm_pnm.TitleWidth = 0
        '
        'itm_pid
        '
        Me.itm_pid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_pid.Location = New System.Drawing.Point(508, 32)
        Me.itm_pid.Name = "itm_pid"
        Me.itm_pid.Size = New System.Drawing.Size(13, 21)
        Me.itm_pid.TabIndex = 2
        Me.itm_pid.Title = "품목id"
        Me.itm_pid.TitleWidth = 0
        Me.itm_pid.Visible = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(612, 448)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.EPanel4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(605, 418)
        Me.XtraTabPage1.Text = "EPL"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(605, 418)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     "
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(601, 393)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.EPanel6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(605, 418)
        Me.XtraTabPage2.Text = "Tree"
        '
        'EPanel6
        '
        Me.EPanel6.Controls.Add(Me.chk_expand)
        Me.EPanel6.Controls.Add(Me.treeFields)
        Me.EPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel6.Location = New System.Drawing.Point(0, 0)
        Me.EPanel6.Name = "EPanel6"
        Me.EPanel6.Size = New System.Drawing.Size(605, 418)
        Me.EPanel6.TabIndex = 0
        Me.EPanel6.Text = "     EPanel6"
        '
        'chk_expand
        '
        Me.chk_expand.Location = New System.Drawing.Point(8, 26)
        Me.chk_expand.Name = "chk_expand"
        Me.chk_expand.Properties.Caption = ""
        Me.chk_expand.Size = New System.Drawing.Size(19, 19)
        Me.chk_expand.TabIndex = 6
        '
        'treeFields
        '
        Me.treeFields.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeFields.Location = New System.Drawing.Point(2, 23)
        Me.treeFields.Name = "treeFields"
        Me.treeFields.Size = New System.Drawing.Size(601, 393)
        Me.treeFields.StateImageList = Me.BOM_Icon
        Me.treeFields.TabIndex = 5
        '
        'BOM_Icon
        '
        Me.BOM_Icon.ImageStream = CType(resources.GetObject("BOM_Icon.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.BOM_Icon.TransparentColor = System.Drawing.Color.Transparent
        Me.BOM_Icon.Images.SetKeyName(0, "validationprovider.gif")
        Me.BOM_Icon.Images.SetKeyName(1, "Templates.png")
        Me.BOM_Icon.Images.SetKeyName(2, "Tasks_25.png")
        Me.BOM_Icon.Images.SetKeyName(3, "ExternalNightClock.png")
        Me.BOM_Icon.Images.SetKeyName(4, "Layout.png")
        '
        'DMB106
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMB106"
        Me.Size = New System.Drawing.Size(1003, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel6.ResumeLayout(False)
        CType(Me.chk_expand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.treeFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents itm_f_cd As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents itm_pcd As Frame7.eText
    Friend WithEvents itm_pnm As Frame7.eText
    Friend WithEvents itm_pid As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents chk_expand As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents treeFields As DevExpress.XtraTreeList.TreeList
    Friend WithEvents itm_f_nm As Frame7.eText
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents itm_rev As Frame7.eCombo
    Friend WithEvents chk_bom As Frame7.eCheck
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents spec1 As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel6 As Frame7.ePanel
    Friend WithEvents BOM_Icon As System.Windows.Forms.ImageList

End Class
