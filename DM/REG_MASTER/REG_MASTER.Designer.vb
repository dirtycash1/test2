<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REG_MASTER
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.url2 = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.local_yn = New Frame7.eCheck()
        Me.to_dt = New Frame7.eDate()
        Me.f_itm_nm = New Frame7.eText()
        Me.f_cust_nm = New Frame7.eText()
        Me.f_itm_cd = New Frame7.eText()
        Me.f_cust_cd = New Frame7.eText()
        Me.url = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.rmks = New Frame7.eMemo()
        Me.std_dt = New Frame7.eDate()
        Me.itm_cd = New Frame7.eText()
        Me.master_img = New Frame7.eImage()
        Me.cust_nm = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.ship_no = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.site = New Frame7.eText()
        Me.m_cu = New Frame7.eText()
        Me.phone = New Frame7.eText()
        Me.itm_id = New Frame7.eText()
        Me.c_cu = New Frame7.eText()
        Me.m_ag = New Frame7.eText()
        Me.m_au = New Frame7.eText()
        Me.c_ag = New Frame7.eText()
        Me.c_au = New Frame7.eText()
        Me.m_pd = New Frame7.eText()
        Me.c_pd = New Frame7.eText()
        Me.m_pt = New Frame7.eText()
        Me.c_pt = New Frame7.eText()
        Me.m_etc = New Frame7.eText()
        Me.c_etc = New Frame7.eText()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.SplitterDistance = 85
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.url2)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.local_yn)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.f_itm_nm)
        Me.EPanel1.Controls.Add(Me.f_cust_nm)
        Me.EPanel1.Controls.Add(Me.f_itm_cd)
        Me.EPanel1.Controls.Add(Me.f_cust_cd)
        Me.EPanel1.Controls.Add(Me.url)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 85)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'url2
        '
        Me.url2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.url2.Location = New System.Drawing.Point(868, 55)
        Me.url2.Name = "url2"
        Me.url2.Size = New System.Drawing.Size(14, 21)
        Me.url2.TabIndex = 6
        Me.url2.Title = "거래처"
        Me.url2.TitleWidth = 0
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(26, 31)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "등록기간"
        '
        'local_yn
        '
        Me.local_yn.Caption = ""
        Me.local_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.local_yn.Location = New System.Drawing.Point(602, 31)
        Me.local_yn.Name = "local_yn"
        Me.local_yn.Size = New System.Drawing.Size(221, 21)
        Me.local_yn.TabIndex = 7
        Me.local_yn.Title = "내부사용자"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(146, 55)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 5
        Me.to_dt.TitleWidth = 0
        '
        'f_itm_nm
        '
        Me.f_itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_itm_nm.Location = New System.Drawing.Point(283, 55)
        Me.f_itm_nm.Name = "f_itm_nm"
        Me.f_itm_nm.Size = New System.Drawing.Size(298, 21)
        Me.f_itm_nm.TabIndex = 2
        Me.f_itm_nm.Title = "품목명%"
        '
        'f_cust_nm
        '
        Me.f_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_nm.Location = New System.Drawing.Point(283, 31)
        Me.f_cust_nm.Name = "f_cust_nm"
        Me.f_cust_nm.Size = New System.Drawing.Size(298, 21)
        Me.f_cust_nm.TabIndex = 2
        Me.f_cust_nm.Title = "업체"
        '
        'f_itm_cd
        '
        Me.f_itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_itm_cd.Location = New System.Drawing.Point(602, 55)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_itm_cd.TabIndex = 2
        Me.f_itm_cd.Title = "품목코드%"
        '
        'f_cust_cd
        '
        Me.f_cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_cd.Location = New System.Drawing.Point(587, 31)
        Me.f_cust_cd.Name = "f_cust_cd"
        Me.f_cust_cd.Size = New System.Drawing.Size(14, 21)
        Me.f_cust_cd.TabIndex = 2
        Me.f_cust_cd.Title = "거래처"
        Me.f_cust_cd.TitleWidth = 0
        '
        'url
        '
        Me.url.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.url.Location = New System.Drawing.Point(848, 55)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(14, 21)
        Me.url.TabIndex = 2
        Me.url.Title = "거래처"
        Me.url.TitleWidth = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1000, 601)
        Me.SplitContainer2.SplitterDistance = 696
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
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
        Me.SplitContainer3.Size = New System.Drawing.Size(696, 601)
        Me.SplitContainer3.SplitterDistance = 198
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(696, 198)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     등록현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(692, 173)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.rmks)
        Me.EPanel3.Controls.Add(Me.std_dt)
        Me.EPanel3.Controls.Add(Me.itm_cd)
        Me.EPanel3.Controls.Add(Me.master_img)
        Me.EPanel3.Controls.Add(Me.cust_nm)
        Me.EPanel3.Controls.Add(Me.itm_nm)
        Me.EPanel3.Controls.Add(Me.ship_no)
        Me.EPanel3.Controls.Add(Me.cust_cd)
        Me.EPanel3.Controls.Add(Me.site)
        Me.EPanel3.Controls.Add(Me.m_cu)
        Me.EPanel3.Controls.Add(Me.phone)
        Me.EPanel3.Controls.Add(Me.itm_id)
        Me.EPanel3.Controls.Add(Me.c_cu)
        Me.EPanel3.Controls.Add(Me.m_ag)
        Me.EPanel3.Controls.Add(Me.m_au)
        Me.EPanel3.Controls.Add(Me.c_ag)
        Me.EPanel3.Controls.Add(Me.c_au)
        Me.EPanel3.Controls.Add(Me.m_pd)
        Me.EPanel3.Controls.Add(Me.c_pd)
        Me.EPanel3.Controls.Add(Me.m_pt)
        Me.EPanel3.Controls.Add(Me.c_pt)
        Me.EPanel3.Controls.Add(Me.m_etc)
        Me.EPanel3.Controls.Add(Me.c_etc)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(696, 399)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     기본정보"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(26, 328)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(653, 60)
        Me.rmks.TabIndex = 7
        Me.rmks.Title = "비고"
        '
        'std_dt
        '
        Me.std_dt.Format = "yyyy-MM-dd HH:mm:ss"
        Me.std_dt.Location = New System.Drawing.Point(26, 35)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(366, 21)
        Me.std_dt.TabIndex = 5
        Me.std_dt.Title = "기준일자"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(26, 83)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(366, 21)
        Me.itm_cd.TabIndex = 3
        Me.itm_cd.Title = "품목코드"
        '
        'master_img
        '
        Me.master_img.Location = New System.Drawing.Point(423, 35)
        Me.master_img.Name = "master_img"
        Me.master_img.Size = New System.Drawing.Size(256, 211)
        Me.master_img.TabIndex = 6
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(26, 59)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(366, 21)
        Me.cust_nm.TabIndex = 3
        Me.cust_nm.Title = "업체"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(26, 107)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(366, 21)
        Me.itm_nm.TabIndex = 3
        Me.itm_nm.Title = "품목명"
        '
        'ship_no
        '
        Me.ship_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_no.Location = New System.Drawing.Point(26, 131)
        Me.ship_no.Name = "ship_no"
        Me.ship_no.Size = New System.Drawing.Size(366, 21)
        Me.ship_no.TabIndex = 3
        Me.ship_no.Title = "차선"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(407, 59)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(10, 21)
        Me.cust_cd.TabIndex = 3
        Me.cust_cd.Title = "거래처코드"
        Me.cust_cd.TitleWidth = 0
        '
        'site
        '
        Me.site.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.site.Location = New System.Drawing.Point(26, 305)
        Me.site.Name = "site"
        Me.site.Size = New System.Drawing.Size(653, 21)
        Me.site.TabIndex = 3
        Me.site.Title = "위치"
        '
        'm_cu
        '
        Me.m_cu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_cu.Location = New System.Drawing.Point(26, 158)
        Me.m_cu.Name = "m_cu"
        Me.m_cu.Size = New System.Drawing.Size(180, 21)
        Me.m_cu.TabIndex = 3
        Me.m_cu.Title = "M Cu"
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.phone.Location = New System.Drawing.Point(423, 278)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(256, 21)
        Me.phone.TabIndex = 3
        Me.phone.Title = "전화번호"
        '
        'itm_id
        '
        Me.itm_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_id.Location = New System.Drawing.Point(407, 83)
        Me.itm_id.Name = "itm_id"
        Me.itm_id.Size = New System.Drawing.Size(10, 21)
        Me.itm_id.TabIndex = 3
        Me.itm_id.Title = "품목in"
        Me.itm_id.TitleWidth = 0
        '
        'c_cu
        '
        Me.c_cu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_cu.Location = New System.Drawing.Point(26, 230)
        Me.c_cu.Name = "c_cu"
        Me.c_cu.Size = New System.Drawing.Size(180, 21)
        Me.c_cu.TabIndex = 3
        Me.c_cu.Title = "C Cu"
        '
        'm_ag
        '
        Me.m_ag.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_ag.Location = New System.Drawing.Point(26, 182)
        Me.m_ag.Name = "m_ag"
        Me.m_ag.Size = New System.Drawing.Size(180, 21)
        Me.m_ag.TabIndex = 3
        Me.m_ag.Title = "M Ag"
        '
        'm_au
        '
        Me.m_au.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_au.Location = New System.Drawing.Point(212, 158)
        Me.m_au.Name = "m_au"
        Me.m_au.Size = New System.Drawing.Size(180, 21)
        Me.m_au.TabIndex = 3
        Me.m_au.Title = "M Au"
        '
        'c_ag
        '
        Me.c_ag.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_ag.Location = New System.Drawing.Point(26, 254)
        Me.c_ag.Name = "c_ag"
        Me.c_ag.Size = New System.Drawing.Size(180, 21)
        Me.c_ag.TabIndex = 3
        Me.c_ag.Title = "C Ag"
        '
        'c_au
        '
        Me.c_au.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_au.Location = New System.Drawing.Point(212, 230)
        Me.c_au.Name = "c_au"
        Me.c_au.Size = New System.Drawing.Size(180, 21)
        Me.c_au.TabIndex = 3
        Me.c_au.Title = "C Au"
        '
        'm_pd
        '
        Me.m_pd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_pd.Location = New System.Drawing.Point(212, 182)
        Me.m_pd.Name = "m_pd"
        Me.m_pd.Size = New System.Drawing.Size(180, 21)
        Me.m_pd.TabIndex = 3
        Me.m_pd.Title = "M Pd"
        '
        'c_pd
        '
        Me.c_pd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_pd.Location = New System.Drawing.Point(212, 254)
        Me.c_pd.Name = "c_pd"
        Me.c_pd.Size = New System.Drawing.Size(180, 21)
        Me.c_pd.TabIndex = 3
        Me.c_pd.Title = "C Pd"
        '
        'm_pt
        '
        Me.m_pt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_pt.Location = New System.Drawing.Point(26, 206)
        Me.m_pt.Name = "m_pt"
        Me.m_pt.Size = New System.Drawing.Size(180, 21)
        Me.m_pt.TabIndex = 3
        Me.m_pt.Title = "M Pt"
        '
        'c_pt
        '
        Me.c_pt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_pt.Location = New System.Drawing.Point(26, 278)
        Me.c_pt.Name = "c_pt"
        Me.c_pt.Size = New System.Drawing.Size(180, 21)
        Me.c_pt.TabIndex = 3
        Me.c_pt.Title = "C Pt"
        '
        'm_etc
        '
        Me.m_etc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.m_etc.Location = New System.Drawing.Point(212, 206)
        Me.m_etc.Name = "m_etc"
        Me.m_etc.Size = New System.Drawing.Size(180, 21)
        Me.m_etc.TabIndex = 3
        Me.m_etc.Title = "M Etc"
        '
        'c_etc
        '
        Me.c_etc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.c_etc.Location = New System.Drawing.Point(212, 278)
        Me.c_etc.Name = "c_etc"
        Me.c_etc.Size = New System.Drawing.Size(180, 21)
        Me.c_etc.TabIndex = 3
        Me.c_etc.Title = "C Etc"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(300, 601)
        Me.EPanel4.TabIndex = 2
        Me.EPanel4.Text = "     사진등록현황"
        '
        'g20
        '
        Me.g20.AllowDrop = True
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = 100
        Me.g20.Size = New System.Drawing.Size(296, 576)
        Me.g20.TabIndex = 2
        '
        'REG_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "REG_MASTER"
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents f_itm_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents f_itm_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents master_img As Frame7.eImage
    Friend WithEvents itm_id As Frame7.eText
    Friend WithEvents ship_no As Frame7.eText
    Friend WithEvents m_cu As Frame7.eText
    Friend WithEvents c_cu As Frame7.eText
    Friend WithEvents m_ag As Frame7.eText
    Friend WithEvents m_au As Frame7.eText
    Friend WithEvents c_ag As Frame7.eText
    Friend WithEvents c_au As Frame7.eText
    Friend WithEvents m_pd As Frame7.eText
    Friend WithEvents c_pd As Frame7.eText
    Friend WithEvents m_pt As Frame7.eText
    Friend WithEvents c_pt As Frame7.eText
    Friend WithEvents rmks As Frame7.eMemo
    Friend WithEvents site As Frame7.eText
    Friend WithEvents phone As Frame7.eText
    Friend WithEvents f_cust_nm As Frame7.eText
    Friend WithEvents f_cust_cd As Frame7.eText
    Friend WithEvents url As Frame7.eText
    Friend WithEvents m_etc As Frame7.eText
    Friend WithEvents c_etc As Frame7.eText
    Friend WithEvents url2 As Frame7.eText
    Friend WithEvents local_yn As Frame7.eCheck

End Class
