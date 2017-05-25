<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMB200
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PMB200))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f_prj_nm = New Frame7.eText()
        Me.f_prj_cd = New Frame7.eText()
        Me.f_prj_bc = New Frame7.eCheckCombo()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.prj_bc = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.stat_bc = New Frame7.eCombo()
        Me.prj_nm = New Frame7.eText()
        Me.prj_cd = New Frame7.eText()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.btn_open = New DevExpress.XtraEditors.SimpleButton()
        Me.exp_yn = New Frame7.eCheck()
        Me.doc_chk = New Frame7.eCheck()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 581)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(270, 581)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_bc)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(266, 556)
        Me.SplitContainer3.SplitterDistance = 82
        Me.SplitContainer3.TabIndex = 2
        '
        'f_prj_nm
        '
        Me.f_prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_nm.Location = New System.Drawing.Point(8, 8)
        Me.f_prj_nm.Name = "f_prj_nm"
        Me.f_prj_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_nm.TabIndex = 1
        Me.f_prj_nm.Title = "Project 명"
        '
        'f_prj_cd
        '
        Me.f_prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_cd.Location = New System.Drawing.Point(8, 32)
        Me.f_prj_cd.Name = "f_prj_cd"
        Me.f_prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_cd.TabIndex = 2
        Me.f_prj_cd.Title = "Project 코드"
        '
        'f_prj_bc
        '
        Me.f_prj_bc.Location = New System.Drawing.Point(8, 56)
        Me.f_prj_bc.Name = "f_prj_bc"
        Me.f_prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_bc.TabIndex = 3
        Me.f_prj_bc.Title = "Project 구분"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(266, 470)
        Me.g10.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(960, 581)
        Me.SplitContainer2.SplitterDistance = 80
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.prj_bc)
        Me.EPanel3.Controls.Add(Me.prj_nm)
        Me.EPanel3.Controls.Add(Me.prj_cd)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(960, 80)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Project 조회"
        '
        'prj_bc
        '
        Me.prj_bc.Location = New System.Drawing.Point(256, 28)
        Me.prj_bc.Name = "prj_bc"
        Me.prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.prj_bc.TabIndex = 7
        Me.prj_bc.Title = "Project 구분"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(504, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 6
        Me.to_dt.Title = "종료일"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(504, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "시작일"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(752, 28)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 4
        Me.stat_bc.Title = "Project 상태"
        '
        'prj_nm
        '
        Me.prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_nm.Location = New System.Drawing.Point(8, 52)
        Me.prj_nm.Name = "prj_nm"
        Me.prj_nm.Size = New System.Drawing.Size(488, 21)
        Me.prj_nm.TabIndex = 3
        Me.prj_nm.Title = "Project 명"
        '
        'prj_cd
        '
        Me.prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_cd.Location = New System.Drawing.Point(8, 28)
        Me.prj_cd.Name = "prj_cd"
        Me.prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.prj_cd.TabIndex = 2
        Me.prj_cd.Title = "Project 코드"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer4.Size = New System.Drawing.Size(960, 497)
        Me.SplitContainer4.SplitterDistance = 254
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer6)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(254, 497)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     WBS Tree"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer6.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.btn_open)
        Me.SplitContainer6.Panel1.Controls.Add(Me.exp_yn)
        Me.SplitContainer6.Panel1.Controls.Add(Me.doc_chk)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.TreeView1)
        Me.SplitContainer6.Size = New System.Drawing.Size(250, 472)
        Me.SplitContainer6.SplitterDistance = 58
        Me.SplitContainer6.TabIndex = 25
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(164, 8)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(75, 44)
        Me.btn_open.TabIndex = 7
        Me.btn_open.Text = "조회"
        '
        'exp_yn
        '
        Me.exp_yn.Caption = ""
        Me.exp_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.exp_yn.Location = New System.Drawing.Point(8, 8)
        Me.exp_yn.Name = "exp_yn"
        Me.exp_yn.Size = New System.Drawing.Size(144, 21)
        Me.exp_yn.TabIndex = 6
        Me.exp_yn.Title = "Tree 확장"
        '
        'doc_chk
        '
        Me.doc_chk.Caption = ""
        Me.doc_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_chk.Location = New System.Drawing.Point(8, 32)
        Me.doc_chk.Name = "doc_chk"
        Me.doc_chk.Size = New System.Drawing.Size(144, 21)
        Me.doc_chk.TabIndex = 5
        Me.doc_chk.Title = "산출물포함 여부"
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(250, 410)
        Me.TreeView1.TabIndex = 24
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "group.png")
        Me.ImageList1.Images.SetKeyName(1, "check_128_hot.gif")
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer5.Size = New System.Drawing.Size(702, 497)
        Me.SplitContainer5.SplitterDistance = 342
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(702, 342)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     단계등록"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(698, 317)
        Me.g20.TabIndex = 2
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g30)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(702, 151)
        Me.EPanel5.TabIndex = 1
        Me.EPanel5.Text = "     산출물"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(698, 126)
        Me.g30.TabIndex = 2
        '
        'PMB200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMB200"
        Me.Size = New System.Drawing.Size(1234, 581)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_prj_cd As Frame7.eText
    Friend WithEvents f_prj_bc As Frame7.eCheckCombo
    Friend WithEvents doc_chk As Frame7.eCheck
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents exp_yn As Frame7.eCheck
    Friend WithEvents btn_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents f_prj_nm As Frame7.eText
    Friend WithEvents prj_bc As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents prj_nm As Frame7.eText
    Friend WithEvents prj_cd As Frame7.eText

End Class
