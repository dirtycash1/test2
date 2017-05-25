<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_DE1040
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WI_DE1040))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.dsc = New Frame7.eMemo()
        Me.itm_rev = New Frame7.eCombo()
        Me.adm_dt = New Frame7.eDate()
        Me.nm = New Frame7.eText()
        Me.itm_id = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel20 = New Frame7.ePanel()
        Me.chk_expand = New DevExpress.XtraEditors.CheckEdit()
        Me.treeFields = New DevExpress.XtraTreeList.TreeList()
        Me.BOM_Icon = New System.Windows.Forms.ImageList(Me.components)
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.pitm_cd = New Frame7.eText()
        Me.pitm_nm = New Frame7.eText()
        Me.std_dt = New Frame7.eDate()
        Me.pitm_id = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.stts1 = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.EPanel20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel20.SuspendLayout()
        CType(Me.chk_expand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.treeFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 63
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.dsc)
        Me.EPanel1.Controls.Add(Me.itm_rev)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.adm_dt)
        Me.EPanel1.Controls.Add(Me.pitm_id)
        Me.EPanel1.Controls.Add(Me.nm)
        Me.EPanel1.Controls.Add(Me.itm_id)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 63)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(12, 32)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(226, 21)
        Me.itm_cd.TabIndex = 2
        Me.itm_cd.Title = "제품군%"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(240, 32)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(292, 21)
        Me.itm_nm.TabIndex = 2
        Me.itm_nm.Title = "품목명"
        Me.itm_nm.TitleWidth = 0
        '
        'dsc
        '
        Me.dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dsc.Location = New System.Drawing.Point(12, 100)
        Me.dsc.Name = "dsc"
        Me.dsc.Size = New System.Drawing.Size(484, 73)
        Me.dsc.TabIndex = 6
        Me.dsc.Title = "개정사유"
        '
        'itm_rev
        '
        Me.itm_rev.Location = New System.Drawing.Point(12, 76)
        Me.itm_rev.Name = "itm_rev"
        Me.itm_rev.Size = New System.Drawing.Size(240, 21)
        Me.itm_rev.TabIndex = 11
        Me.itm_rev.Title = "차수"
        '
        'adm_dt
        '
        Me.adm_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.adm_dt.Location = New System.Drawing.Point(512, 148)
        Me.adm_dt.Name = "adm_dt"
        Me.adm_dt.Size = New System.Drawing.Size(240, 21)
        Me.adm_dt.TabIndex = 5
        Me.adm_dt.Title = "승인일자"
        '
        'nm
        '
        Me.nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm.Location = New System.Drawing.Point(512, 124)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(240, 21)
        Me.nm.TabIndex = 4
        Me.nm.Title = "승인자"
        '
        'itm_id
        '
        Me.itm_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_id.Location = New System.Drawing.Point(552, 32)
        Me.itm_id.Name = "itm_id"
        Me.itm_id.Size = New System.Drawing.Size(13, 21)
        Me.itm_id.TabIndex = 2
        Me.itm_id.Title = "품목id"
        Me.itm_id.TitleWidth = 0
        Me.itm_id.Visible = False
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(512, 100)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "적용일자"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.XtraTabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1000, 623)
        Me.SplitContainer2.SplitterDistance = 275
        Me.SplitContainer2.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(275, 623)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.EPanel20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(268, 593)
        Me.XtraTabPage1.Text = "Tree"
        '
        'EPanel20
        '
        Me.EPanel20.Controls.Add(Me.chk_expand)
        Me.EPanel20.Controls.Add(Me.treeFields)
        Me.EPanel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel20.Location = New System.Drawing.Point(0, 0)
        Me.EPanel20.Name = "EPanel20"
        Me.EPanel20.Size = New System.Drawing.Size(268, 593)
        Me.EPanel20.TabIndex = 7
        Me.EPanel20.Text = "     "
        '
        'chk_expand
        '
        Me.chk_expand.Location = New System.Drawing.Point(9, 26)
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
        Me.treeFields.Size = New System.Drawing.Size(264, 568)
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.EPanel5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(268, 593)
        Me.XtraTabPage2.Text = "EPL"
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g20)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(268, 593)
        Me.EPanel5.TabIndex = 2
        Me.EPanel5.Text = "     "
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(264, 568)
        Me.g20.TabIndex = 2
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Size = New System.Drawing.Size(721, 623)
        Me.SplitContainer3.SplitterDistance = 56
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.pitm_cd)
        Me.EPanel2.Controls.Add(Me.pitm_nm)
        Me.EPanel2.Controls.Add(Me.stts1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(721, 56)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     모폼목"
        '
        'pitm_cd
        '
        Me.pitm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pitm_cd.Location = New System.Drawing.Point(12, 28)
        Me.pitm_cd.Name = "pitm_cd"
        Me.pitm_cd.Size = New System.Drawing.Size(114, 21)
        Me.pitm_cd.TabIndex = 4
        Me.pitm_cd.Title = "모품목코드"
        Me.pitm_cd.TitleWidth = 0
        '
        'pitm_nm
        '
        Me.pitm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pitm_nm.Location = New System.Drawing.Point(128, 28)
        Me.pitm_nm.Name = "pitm_nm"
        Me.pitm_nm.Size = New System.Drawing.Size(294, 21)
        Me.pitm_nm.TabIndex = 3
        Me.pitm_nm.Title = "모품목명"
        Me.pitm_nm.TitleWidth = 0
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(590, 32)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 12
        Me.std_dt.Visible = False
        '
        'pitm_id
        '
        Me.pitm_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pitm_id.Location = New System.Drawing.Point(571, 32)
        Me.pitm_id.Name = "pitm_id"
        Me.pitm_id.Size = New System.Drawing.Size(13, 21)
        Me.pitm_id.TabIndex = 2
        Me.pitm_id.Title = "품목id"
        Me.pitm_id.TitleWidth = 0
        Me.pitm_id.Visible = False
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(721, 563)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     자품목"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(717, 538)
        Me.g10.TabIndex = 2
        '
        'stts1
        '
        Me.stts1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.stts1.Location = New System.Drawing.Point(428, 28)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(68, 21)
        Me.stts1.TabIndex = 5
        Me.stts1.Title = "stts1"
        Me.stts1.TitleWidth = 0
        '
        'WI_DE1040
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_DE1040"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.EPanel20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel20.ResumeLayout(False)
        CType(Me.chk_expand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.treeFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_rev As Frame7.eCombo
    Friend WithEvents itm_id As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents chk_expand As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents treeFields As DevExpress.XtraTreeList.TreeList
    Friend WithEvents BOM_Icon As System.Windows.Forms.ImageList
    Friend WithEvents pitm_cd As Frame7.eText
    Friend WithEvents pitm_nm As Frame7.eText
    Friend WithEvents pitm_id As Frame7.eText
    Friend WithEvents adm_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents dsc As Frame7.eMemo
    Friend WithEvents EPanel20 As Frame7.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents stts1 As Frame7.eText

End Class
