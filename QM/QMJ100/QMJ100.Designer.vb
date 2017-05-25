<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMJ100
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
        Me.req_rid = New Frame7.eText()
        Me.req_dept = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.f_model_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.dept_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.test_rid = New Frame7.eText()
        Me.test_nm = New Frame7.eText()
        Me.test_dt = New Frame7.eDate()
        Me.req_rmk = New Frame7.eMemo()
        Me.spec3 = New Frame7.eText()
        Me.spec2 = New Frame7.eText()
        Me.req_dsc = New Frame7.eMemo()
        Me.spec1 = New Frame7.eText()
        Me.req_nm = New Frame7.eText()
        Me.req_dept_nm = New Frame7.eText()
        Me.mkr_bc = New Frame7.eCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.req_dt = New Frame7.eDate()
        Me.req_no = New Frame7.eText()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
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
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 616)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.req_rid)
        Me.EPanel1.Controls.Add(Me.req_dept)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.f_model_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 80)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'req_rid
        '
        Me.req_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid.Location = New System.Drawing.Point(648, 52)
        Me.req_rid.Name = "req_rid"
        Me.req_rid.Size = New System.Drawing.Size(240, 21)
        Me.req_rid.TabIndex = 27
        Me.req_rid.Title = "의뢰자ID"
        '
        'req_dept
        '
        Me.req_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept.Location = New System.Drawing.Point(648, 28)
        Me.req_dept.Name = "req_dept"
        Me.req_dept.Size = New System.Drawing.Size(240, 21)
        Me.req_dept.TabIndex = 26
        Me.req_dept.Title = "의뢰부서코드"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(268, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 17
        Me.dept_cd.Title = "책임구(부서)"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(12, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 20
        Me.to_dt.Title = "발생기간(to)"
        '
        'f_model_cd
        '
        Me.f_model_cd.Location = New System.Drawing.Point(268, 52)
        Me.f_model_cd.Name = "f_model_cd"
        Me.f_model_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_model_cd.TabIndex = 21
        Me.f_model_cd.Title = "차종"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 16
        Me.fr_dt.Title = "발생기간(fr)"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(392, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 18
        Me.dept_nm.Title = "책임구(부서명)"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 532)
        Me.SplitContainer2.SplitterDistance = 262
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(262, 532)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     시험성적리스트"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(258, 507)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(758, 532)
        Me.SplitContainer3.SplitterDistance = 218
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.spec3)
        Me.EPanel3.Controls.Add(Me.spec2)
        Me.EPanel3.Controls.Add(Me.test_rid)
        Me.EPanel3.Controls.Add(Me.test_nm)
        Me.EPanel3.Controls.Add(Me.test_dt)
        Me.EPanel3.Controls.Add(Me.req_rmk)
        Me.EPanel3.Controls.Add(Me.spec1)
        Me.EPanel3.Controls.Add(Me.req_nm)
        Me.EPanel3.Controls.Add(Me.req_dsc)
        Me.EPanel3.Controls.Add(Me.req_dept_nm)
        Me.EPanel3.Controls.Add(Me.mkr_bc)
        Me.EPanel3.Controls.Add(Me.model_cd)
        Me.EPanel3.Controls.Add(Me.req_dt)
        Me.EPanel3.Controls.Add(Me.req_no)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(758, 218)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     시험성적등록"
        '
        'test_rid
        '
        Me.test_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.test_rid.Location = New System.Drawing.Point(512, 192)
        Me.test_rid.Name = "test_rid"
        Me.test_rid.Size = New System.Drawing.Size(240, 21)
        Me.test_rid.TabIndex = 33
        Me.test_rid.Title = "평가자ID"
        '
        'test_nm
        '
        Me.test_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.test_nm.Location = New System.Drawing.Point(256, 192)
        Me.test_nm.Name = "test_nm"
        Me.test_nm.Size = New System.Drawing.Size(240, 21)
        Me.test_nm.TabIndex = 32
        Me.test_nm.Title = "평가자"
        '
        'test_dt
        '
        Me.test_dt.Location = New System.Drawing.Point(8, 192)
        Me.test_dt.Name = "test_dt"
        Me.test_dt.Size = New System.Drawing.Size(240, 21)
        Me.test_dt.TabIndex = 31
        Me.test_dt.Title = "평가일자"
        '
        'req_rmk
        '
        Me.req_rmk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rmk.Location = New System.Drawing.Point(8, 144)
        Me.req_rmk.Name = "req_rmk"
        Me.req_rmk.Size = New System.Drawing.Size(744, 44)
        Me.req_rmk.TabIndex = 30
        Me.req_rmk.Title = "의뢰목적"
        '
        'spec3
        '
        Me.spec3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec3.Location = New System.Drawing.Point(512, 76)
        Me.spec3.Name = "spec3"
        Me.spec3.Size = New System.Drawing.Size(240, 21)
        Me.spec3.TabIndex = 28
        Me.spec3.Title = "Spec3"
        '
        'spec2
        '
        Me.spec2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec2.Location = New System.Drawing.Point(512, 52)
        Me.spec2.Name = "spec2"
        Me.spec2.Size = New System.Drawing.Size(240, 21)
        Me.spec2.TabIndex = 27
        Me.spec2.Title = "Spec2"
        '
        'req_dsc
        '
        Me.req_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dsc.Location = New System.Drawing.Point(8, 100)
        Me.req_dsc.Name = "req_dsc"
        Me.req_dsc.Size = New System.Drawing.Size(744, 40)
        Me.req_dsc.TabIndex = 29
        Me.req_dsc.Title = "의뢰사유"
        '
        'spec1
        '
        Me.spec1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec1.Location = New System.Drawing.Point(512, 28)
        Me.spec1.Name = "spec1"
        Me.spec1.Size = New System.Drawing.Size(240, 21)
        Me.spec1.TabIndex = 26
        Me.spec1.Title = "Spec1"
        '
        'req_nm
        '
        Me.req_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_nm.Location = New System.Drawing.Point(260, 76)
        Me.req_nm.Name = "req_nm"
        Me.req_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_nm.TabIndex = 25
        Me.req_nm.Title = "의뢰자"
        '
        'req_dept_nm
        '
        Me.req_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept_nm.Location = New System.Drawing.Point(260, 52)
        Me.req_dept_nm.Name = "req_dept_nm"
        Me.req_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_dept_nm.TabIndex = 24
        Me.req_dept_nm.Title = "의뢰부서"
        '
        'mkr_bc
        '
        Me.mkr_bc.Location = New System.Drawing.Point(8, 76)
        Me.mkr_bc.Name = "mkr_bc"
        Me.mkr_bc.Size = New System.Drawing.Size(240, 21)
        Me.mkr_bc.TabIndex = 23
        Me.mkr_bc.Title = "Maker"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(8, 52)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 22
        Me.model_cd.Title = "차종"
        '
        'req_dt
        '
        Me.req_dt.Location = New System.Drawing.Point(260, 28)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 21
        Me.req_dt.Title = "의뢰일자"
        '
        'req_no
        '
        Me.req_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_no.Location = New System.Drawing.Point(8, 28)
        Me.req_no.Name = "req_no"
        Me.req_no.Size = New System.Drawing.Size(240, 21)
        Me.req_no.TabIndex = 2
        Me.req_no.Title = "의뢰NO"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(751, 238)
        Me.g20.TabIndex = 3
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(758, 310)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(751, 238)
        Me.XtraTabPage1.Text = "상세현황"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g50)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(751, 280)
        Me.XtraTabPage2.Text = "첨부문서"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(751, 280)
        Me.g50.TabIndex = 4
        '
        'QMJ100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMJ100"
        Me.Size = New System.Drawing.Size(1034, 634)
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents req_rid As Frame7.eText
    Friend WithEvents req_dept As Frame7.eText
    Friend WithEvents f_model_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents spec3 As Frame7.eText
    Friend WithEvents spec2 As Frame7.eText
    Friend WithEvents spec1 As Frame7.eText
    Friend WithEvents req_nm As Frame7.eText
    Friend WithEvents req_dept_nm As Frame7.eText
    Friend WithEvents mkr_bc As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents req_no As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents test_rid As Frame7.eText
    Friend WithEvents test_nm As Frame7.eText
    Friend WithEvents test_dt As Frame7.eDate
    Friend WithEvents req_rmk As Frame7.eMemo
    Friend WithEvents req_dsc As Frame7.eMemo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid

End Class
