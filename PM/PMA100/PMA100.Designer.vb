<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMA100
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
        Me.f_prj_cd = New Frame7.eText()
        Me.f_prj_nm = New Frame7.eText()
        Me.f_prj_bc = New Frame7.eCheckCombo()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.mng_rid = New Frame7.eText()
        Me.itm_id = New Frame7.eText()
        Me.range_bc = New Frame7.eCombo()
        Me.prj_kd = New Frame7.eCombo()
        Me.stat_bc = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.model_cd = New Frame7.eCombo()
        Me.itm_rev = New Frame7.eText()
        Me.mkr_bc = New Frame7.eCombo()
        Me.prj_bc = New Frame7.eCombo()
        Me.prj_nm = New Frame7.eText()
        Me.prj_cd = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.eco_no = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.mng_dept = New Frame7.eText()
        Me.prj_dsc = New Frame7.eMemo()
        Me.cdt = New Frame7.eDate()
        Me.emp_nm = New Frame7.eText()
        Me.cnm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.g60 = New Frame7.eGrid()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g70 = New Frame7.eGrid()
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
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_bc)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(266, 556)
        Me.SplitContainer3.SplitterDistance = 86
        Me.SplitContainer3.TabIndex = 2
        '
        'f_prj_cd
        '
        Me.f_prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_cd.Location = New System.Drawing.Point(8, 32)
        Me.f_prj_cd.Name = "f_prj_cd"
        Me.f_prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_cd.TabIndex = 3
        Me.f_prj_cd.Title = "Project 코드(%)"
        '
        'f_prj_nm
        '
        Me.f_prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_nm.Location = New System.Drawing.Point(8, 8)
        Me.f_prj_nm.Name = "f_prj_nm"
        Me.f_prj_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_nm.TabIndex = 2
        Me.f_prj_nm.Title = "Project 명(%)"
        '
        'f_prj_bc
        '
        Me.f_prj_bc.Location = New System.Drawing.Point(8, 56)
        Me.f_prj_bc.Name = "f_prj_bc"
        Me.f_prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_bc.TabIndex = 2
        Me.f_prj_bc.Title = "Project 구분"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(266, 466)
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl)
        Me.SplitContainer2.Size = New System.Drawing.Size(960, 581)
        Me.SplitContainer2.SplitterDistance = 285
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.mng_rid)
        Me.EPanel3.Controls.Add(Me.itm_id)
        Me.EPanel3.Controls.Add(Me.range_bc)
        Me.EPanel3.Controls.Add(Me.prj_kd)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.model_cd)
        Me.EPanel3.Controls.Add(Me.itm_rev)
        Me.EPanel3.Controls.Add(Me.mkr_bc)
        Me.EPanel3.Controls.Add(Me.prj_bc)
        Me.EPanel3.Controls.Add(Me.prj_nm)
        Me.EPanel3.Controls.Add(Me.prj_cd)
        Me.EPanel3.Controls.Add(Me.itm_cd)
        Me.EPanel3.Controls.Add(Me.eco_no)
        Me.EPanel3.Controls.Add(Me.emp_no)
        Me.EPanel3.Controls.Add(Me.itm_nm)
        Me.EPanel3.Controls.Add(Me.mng_dept)
        Me.EPanel3.Controls.Add(Me.prj_dsc)
        Me.EPanel3.Controls.Add(Me.cdt)
        Me.EPanel3.Controls.Add(Me.emp_nm)
        Me.EPanel3.Controls.Add(Me.cnm)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(960, 285)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Project 등록"
        '
        'mng_rid
        '
        Me.mng_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mng_rid.Location = New System.Drawing.Point(788, 88)
        Me.mng_rid.Name = "mng_rid"
        Me.mng_rid.Size = New System.Drawing.Size(240, 21)
        Me.mng_rid.TabIndex = 20
        Me.mng_rid.Title = "관리자ID"
        '
        'itm_id
        '
        Me.itm_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_id.Location = New System.Drawing.Point(788, 112)
        Me.itm_id.Name = "itm_id"
        Me.itm_id.Size = New System.Drawing.Size(240, 21)
        Me.itm_id.TabIndex = 19
        Me.itm_id.Title = "품목코드ID"
        '
        'range_bc
        '
        Me.range_bc.Location = New System.Drawing.Point(788, 136)
        Me.range_bc.Name = "range_bc"
        Me.range_bc.Size = New System.Drawing.Size(240, 21)
        Me.range_bc.TabIndex = 21
        Me.range_bc.Title = "권한범위"
        '
        'prj_kd
        '
        Me.prj_kd.Location = New System.Drawing.Point(8, 100)
        Me.prj_kd.Name = "prj_kd"
        Me.prj_kd.Size = New System.Drawing.Size(240, 21)
        Me.prj_kd.TabIndex = 5
        Me.prj_kd.Title = "Project 분류"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(8, 124)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 9
        Me.stat_bc.Title = "Project 상태"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(260, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 17
        Me.fr_dt.Title = "시작일"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(8, 172)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 7
        Me.model_cd.Title = "차종"
        '
        'itm_rev
        '
        Me.itm_rev.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_rev.Location = New System.Drawing.Point(260, 172)
        Me.itm_rev.Name = "itm_rev"
        Me.itm_rev.Size = New System.Drawing.Size(240, 21)
        Me.itm_rev.TabIndex = 24
        Me.itm_rev.Title = "품목 Rev"
        '
        'mkr_bc
        '
        Me.mkr_bc.Location = New System.Drawing.Point(8, 148)
        Me.mkr_bc.Name = "mkr_bc"
        Me.mkr_bc.Size = New System.Drawing.Size(240, 21)
        Me.mkr_bc.TabIndex = 6
        Me.mkr_bc.Title = "Maker"
        '
        'prj_bc
        '
        Me.prj_bc.Location = New System.Drawing.Point(8, 76)
        Me.prj_bc.Name = "prj_bc"
        Me.prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.prj_bc.TabIndex = 4
        Me.prj_bc.Title = "Project 구분"
        '
        'prj_nm
        '
        Me.prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_nm.Location = New System.Drawing.Point(8, 52)
        Me.prj_nm.Name = "prj_nm"
        Me.prj_nm.Size = New System.Drawing.Size(616, 21)
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
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(260, 148)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 14
        Me.itm_cd.Title = "품목코드"
        '
        'eco_no
        '
        Me.eco_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.eco_no.Location = New System.Drawing.Point(260, 196)
        Me.eco_no.Name = "eco_no"
        Me.eco_no.Size = New System.Drawing.Size(240, 21)
        Me.eco_no.TabIndex = 16
        Me.eco_no.Title = "ECN"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(260, 124)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 12
        Me.emp_no.Title = "관리자"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(384, 148)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(364, 21)
        Me.itm_nm.TabIndex = 15
        Me.itm_nm.Title = "품목명"
        '
        'mng_dept
        '
        Me.mng_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mng_dept.Location = New System.Drawing.Point(260, 100)
        Me.mng_dept.Name = "mng_dept"
        Me.mng_dept.Size = New System.Drawing.Size(240, 21)
        Me.mng_dept.TabIndex = 10
        Me.mng_dept.Title = "관리부서"
        '
        'prj_dsc
        '
        Me.prj_dsc.Location = New System.Drawing.Point(8, 220)
        Me.prj_dsc.Name = "prj_dsc"
        Me.prj_dsc.Size = New System.Drawing.Size(616, 60)
        Me.prj_dsc.TabIndex = 8
        Me.prj_dsc.Title = "Project 개요"
        '
        'cdt
        '
        Me.cdt.Location = New System.Drawing.Point(508, 196)
        Me.cdt.Name = "cdt"
        Me.cdt.Size = New System.Drawing.Size(240, 21)
        Me.cdt.TabIndex = 22
        Me.cdt.Title = "등록일"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(384, 124)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 13
        Me.emp_nm.Title = "관리자명"
        '
        'cnm
        '
        Me.cnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cnm.Location = New System.Drawing.Point(508, 172)
        Me.cnm.Name = "cnm"
        Me.cnm.Size = New System.Drawing.Size(240, 21)
        Me.cnm.TabIndex = 23
        Me.cnm.Title = "등록자"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(384, 100)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 11
        Me.dept_nm.Title = "관리부서명"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(384, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 18
        Me.to_dt.Title = "종료일"
        '
        'XtraTabControl
        '
        Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl.Name = "XtraTabControl"
        Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl.Size = New System.Drawing.Size(960, 292)
        Me.XtraTabControl.TabIndex = 0
        Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage1.Text = "CFT 구성"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(953, 262)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage2.Text = "자원"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(953, 262)
        Me.g30.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g40)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage3.Text = "허용 그룹"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(953, 262)
        Me.g40.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.g50)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage4.Text = "개정내역"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RecordNavigator = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(953, 262)
        Me.g50.TabIndex = 1
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.g60)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage5.Text = "구성품목"
        '
        'g60
        '
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(0, 0)
        Me.g60.Name = "g60"
        Me.g60.ReadOnly = False
        Me.g60.RecordNavigator = False
        Me.g60.RowHeight = -1
        Me.g60.Size = New System.Drawing.Size(953, 262)
        Me.g60.TabIndex = 1
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.g70)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(953, 262)
        Me.XtraTabPage6.Text = "첨부문서"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Name = "g70"
        Me.g70.ReadOnly = False
        Me.g70.RecordNavigator = False
        Me.g70.RowHeight = -1
        Me.g70.Size = New System.Drawing.Size(953, 262)
        Me.g70.TabIndex = 1
        '
        'PMA100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMA100"
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
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g60 As Frame7.eGrid
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g70 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_prj_cd As Frame7.eText
    Friend WithEvents f_prj_nm As Frame7.eText
    Friend WithEvents f_prj_bc As Frame7.eCheckCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cnm As Frame7.eText
    Friend WithEvents cdt As Frame7.eDate
    Friend WithEvents range_bc As Frame7.eCombo
    Friend WithEvents mng_rid As Frame7.eText
    Friend WithEvents itm_id As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents eco_no As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents mng_dept As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents prj_dsc As Frame7.eMemo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents mkr_bc As Frame7.eCombo
    Friend WithEvents prj_kd As Frame7.eCombo
    Friend WithEvents prj_bc As Frame7.eCombo
    Friend WithEvents prj_nm As Frame7.eText
    Friend WithEvents prj_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents itm_rev As Frame7.eText

End Class
