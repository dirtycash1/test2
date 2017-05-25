<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDA101
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.model_cd = New Frame7.eCombo()
        Me.md_bc = New Frame7.eCombo()
        Me.own_bc = New Frame7.eCombo()
        Me.own_cust = New Frame7.eText()
        Me.own_cust_nm = New Frame7.eText()
        Me.rent_cust = New Frame7.eText()
        Me.rent_cust_nm = New Frame7.eText()
        Me.rent_bc = New Frame7.eCombo()
        Me.wc_cd = New Frame7.eCombo()
        Me.md_no = New Frame7.eText()
        Me.md_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.photo1 = New Frame7.eImage()
        Me.photo1_title = New Frame7.eCheck()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.photo2 = New Frame7.eImage()
        Me.photo2_title = New Frame7.eCheck()
        Me.photo3 = New Frame7.eImage()
        Me.photo3_title = New Frame7.eCheck()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 645)
        Me.SplitContainer1.SplitterDistance = 432
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1234, 432)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.itm_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.itm_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.model_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.md_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.own_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.own_cust)
        Me.SplitContainer3.Panel1.Controls.Add(Me.own_cust_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rent_cust)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rent_cust_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.rent_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.wc_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.md_no)
        Me.SplitContainer3.Panel1.Controls.Add(Me.md_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fac_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.co_cd)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Size = New System.Drawing.Size(1230, 407)
        Me.SplitContainer3.SplitterDistance = 108
        Me.SplitContainer3.TabIndex = 2
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(8, 80)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 29
        Me.itm_cd.Title = "대표생산품"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(260, 80)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 30
        Me.itm_nm.Title = "생산품명"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(512, 32)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 31
        Me.model_cd.Title = "차종"
        '
        'md_bc
        '
        Me.md_bc.Location = New System.Drawing.Point(260, 56)
        Me.md_bc.Name = "md_bc"
        Me.md_bc.Size = New System.Drawing.Size(240, 21)
        Me.md_bc.TabIndex = 21
        Me.md_bc.Title = "형구분"
        '
        'own_bc
        '
        Me.own_bc.Location = New System.Drawing.Point(512, 56)
        Me.own_bc.Name = "own_bc"
        Me.own_bc.Size = New System.Drawing.Size(240, 21)
        Me.own_bc.TabIndex = 18
        Me.own_bc.Title = "자산구분"
        '
        'own_cust
        '
        Me.own_cust.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.own_cust.Location = New System.Drawing.Point(764, 56)
        Me.own_cust.Name = "own_cust"
        Me.own_cust.Size = New System.Drawing.Size(240, 21)
        Me.own_cust.TabIndex = 19
        Me.own_cust.Title = "자산처"
        '
        'own_cust_nm
        '
        Me.own_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.own_cust_nm.Location = New System.Drawing.Point(888, 56)
        Me.own_cust_nm.Name = "own_cust_nm"
        Me.own_cust_nm.Size = New System.Drawing.Size(264, 21)
        Me.own_cust_nm.TabIndex = 20
        Me.own_cust_nm.Title = "자산처명"
        '
        'rent_cust
        '
        Me.rent_cust.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rent_cust.Location = New System.Drawing.Point(764, 80)
        Me.rent_cust.Name = "rent_cust"
        Me.rent_cust.Size = New System.Drawing.Size(240, 21)
        Me.rent_cust.TabIndex = 16
        Me.rent_cust.Title = "대여업체"
        '
        'rent_cust_nm
        '
        Me.rent_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rent_cust_nm.Location = New System.Drawing.Point(888, 80)
        Me.rent_cust_nm.Name = "rent_cust_nm"
        Me.rent_cust_nm.Size = New System.Drawing.Size(264, 21)
        Me.rent_cust_nm.TabIndex = 17
        Me.rent_cust_nm.Title = "대여업체명"
        '
        'rent_bc
        '
        Me.rent_bc.Location = New System.Drawing.Point(512, 80)
        Me.rent_bc.Name = "rent_bc"
        Me.rent_bc.Size = New System.Drawing.Size(240, 21)
        Me.rent_bc.TabIndex = 15
        Me.rent_bc.Title = "업체대여"
        '
        'wc_cd
        '
        Me.wc_cd.Location = New System.Drawing.Point(8, 56)
        Me.wc_cd.Name = "wc_cd"
        Me.wc_cd.Size = New System.Drawing.Size(240, 21)
        Me.wc_cd.TabIndex = 7
        Me.wc_cd.Title = "사용라인"
        '
        'md_no
        '
        Me.md_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.md_no.Location = New System.Drawing.Point(260, 8)
        Me.md_no.Name = "md_no"
        Me.md_no.Size = New System.Drawing.Size(240, 21)
        Me.md_no.TabIndex = 3
        Me.md_no.Title = "관리번호"
        '
        'md_nm
        '
        Me.md_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.md_nm.Location = New System.Drawing.Point(260, 32)
        Me.md_nm.Name = "md_nm"
        Me.md_nm.Size = New System.Drawing.Size(240, 21)
        Me.md_nm.TabIndex = 2
        Me.md_nm.Title = "치형구명(%)"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 32)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 1
        Me.fac_cd.Title = "공장"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 8)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 0
        Me.co_cd.Title = "법인"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1230, 295)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     치형구 현황 조회"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1226, 270)
        Me.g10.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1234, 209)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1227, 179)
        Me.XtraTabPage1.Text = "사진정보"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer5.Location = New System.Drawing.Point(8, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.photo1)
        Me.SplitContainer5.Panel1.Controls.Add(Me.photo1_title)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer5.Size = New System.Drawing.Size(1212, 174)
        Me.SplitContainer5.SplitterDistance = 401
        Me.SplitContainer5.TabIndex = 7
        '
        'photo1
        '
        Me.photo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.photo1.Location = New System.Drawing.Point(0, 21)
        Me.photo1.Name = "photo1"
        Me.photo1.Size = New System.Drawing.Size(401, 153)
        Me.photo1.TabIndex = 0
        '
        'photo1_title
        '
        Me.photo1_title.Caption = ""
        Me.photo1_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.photo1_title.Location = New System.Drawing.Point(0, 0)
        Me.photo1_title.Name = "photo1_title"
        Me.photo1_title.Size = New System.Drawing.Size(401, 21)
        Me.photo1_title.TabIndex = 1
        Me.photo1_title.Title = "사진1"
        Me.photo1_title.TitleWidth = 500
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.photo2)
        Me.SplitContainer6.Panel1.Controls.Add(Me.photo2_title)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.photo3)
        Me.SplitContainer6.Panel2.Controls.Add(Me.photo3_title)
        Me.SplitContainer6.Size = New System.Drawing.Size(807, 174)
        Me.SplitContainer6.SplitterDistance = 392
        Me.SplitContainer6.TabIndex = 0
        '
        'photo2
        '
        Me.photo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.photo2.Location = New System.Drawing.Point(0, 21)
        Me.photo2.Name = "photo2"
        Me.photo2.Size = New System.Drawing.Size(392, 153)
        Me.photo2.TabIndex = 2
        '
        'photo2_title
        '
        Me.photo2_title.Caption = ""
        Me.photo2_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.photo2_title.Location = New System.Drawing.Point(0, 0)
        Me.photo2_title.Name = "photo2_title"
        Me.photo2_title.Size = New System.Drawing.Size(392, 21)
        Me.photo2_title.TabIndex = 3
        Me.photo2_title.Title = "사진2"
        Me.photo2_title.TitleWidth = 500
        '
        'photo3
        '
        Me.photo3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.photo3.Location = New System.Drawing.Point(0, 21)
        Me.photo3.Name = "photo3"
        Me.photo3.Size = New System.Drawing.Size(411, 153)
        Me.photo3.TabIndex = 4
        '
        'photo3_title
        '
        Me.photo3_title.Caption = ""
        Me.photo3_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.photo3_title.Location = New System.Drawing.Point(0, 0)
        Me.photo3_title.Name = "photo3_title"
        Me.photo3_title.Size = New System.Drawing.Size(411, 21)
        Me.photo3_title.TabIndex = 5
        Me.photo3_title.Title = "사진3"
        Me.photo3_title.TitleWidth = 500
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1227, 179)
        Me.XtraTabPage2.Text = "생산품목"
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer4.Size = New System.Drawing.Size(1227, 179)
        Me.SplitContainer4.SplitterDistance = 78
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1227, 78)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     제품기준 등록 - 납입기준"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1223, 53)
        Me.g20.TabIndex = 4
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g30)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(1227, 97)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     제품등록기준 해당 소모품 등록"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(1223, 72)
        Me.g30.TabIndex = 4
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g40)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1227, 179)
        Me.XtraTabPage3.Text = "수리이력"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(1227, 179)
        Me.g40.TabIndex = 0
        '
        'MDA101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MDA101"
        Me.Size = New System.Drawing.Size(1234, 645)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents md_nm As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents md_no As Frame7.eText
    Friend WithEvents wc_cd As Frame7.eCombo
    Friend WithEvents rent_cust As Frame7.eText
    Friend WithEvents rent_cust_nm As Frame7.eText
    Friend WithEvents rent_bc As Frame7.eCombo
    Friend WithEvents own_bc As Frame7.eCombo
    Friend WithEvents own_cust As Frame7.eText
    Friend WithEvents own_cust_nm As Frame7.eText
    Friend WithEvents md_bc As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents photo1 As Frame7.eImage
    Friend WithEvents photo1_title As Frame7.eCheck
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents photo2 As Frame7.eImage
    Friend WithEvents photo2_title As Frame7.eCheck
    Friend WithEvents photo3 As Frame7.eImage
    Friend WithEvents photo3_title As Frame7.eCheck

End Class
