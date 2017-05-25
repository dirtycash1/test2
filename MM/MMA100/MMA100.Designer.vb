<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMA100
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
        Me.go_gw2 = New DevExpress.XtraEditors.SimpleButton()
        Me.rmks = New Frame7.eMemo()
        Me.req_no = New Frame7.eText()
        Me.go_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.req_dt = New Frame7.eDate()
        Me.sh_gw = New DevExpress.XtraEditors.SimpleButton()
        Me.dlv_dt = New Frame7.eDate()
        Me.fr_fac = New Frame7.eCombo()
        Me.chk_show = New Frame7.eCheck()
        Me.fr_emp = New Frame7.eText()
        Me.to_rid = New Frame7.eText()
        Me.in_wh = New Frame7.eCombo()
        Me.to_nm = New Frame7.eText()
        Me.in_fac = New Frame7.eCombo()
        Me.fr_nm = New Frame7.eText()
        Me.req_bc = New Frame7.eCombo()
        Me.to_dept_nm = New Frame7.eText()
        Me.to_dept = New Frame7.eText()
        Me.fr_rid = New Frame7.eText()
        Me.fr_dept_nm = New Frame7.eText()
        Me.fr_dept = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f_itm_cd = New Frame7.eText()
        Me.f_itm_nm2 = New Frame7.eText()
        Me.f_req_fr = New Frame7.eDate()
        Me.f_req_to = New Frame7.eDate()
        Me.f_cust_cd = New Frame7.eText()
        Me.f_itm_bc = New Frame7.eCombo()
        Me.f_cust_nm = New Frame7.eText()
        Me.btn_mov = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_srh = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1353, 563)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.go_gw2)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.req_no)
        Me.EPanel1.Controls.Add(Me.go_gw)
        Me.EPanel1.Controls.Add(Me.req_dt)
        Me.EPanel1.Controls.Add(Me.sh_gw)
        Me.EPanel1.Controls.Add(Me.dlv_dt)
        Me.EPanel1.Controls.Add(Me.fr_fac)
        Me.EPanel1.Controls.Add(Me.chk_show)
        Me.EPanel1.Controls.Add(Me.fr_emp)
        Me.EPanel1.Controls.Add(Me.to_rid)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.to_nm)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.fr_nm)
        Me.EPanel1.Controls.Add(Me.req_bc)
        Me.EPanel1.Controls.Add(Me.to_dept_nm)
        Me.EPanel1.Controls.Add(Me.to_dept)
        Me.EPanel1.Controls.Add(Me.fr_rid)
        Me.EPanel1.Controls.Add(Me.fr_dept_nm)
        Me.EPanel1.Controls.Add(Me.fr_dept)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1353, 105)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'go_gw2
        '
        Me.go_gw2.Location = New System.Drawing.Point(1025, 52)
        Me.go_gw2.Name = "go_gw2"
        Me.go_gw2.Size = New System.Drawing.Size(112, 21)
        Me.go_gw2.TabIndex = 105
        Me.go_gw2.Text = "구매결의상신"
        '
        'rmks
        '
        Me.rmks.Location = New System.Drawing.Point(779, 26)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(240, 47)
        Me.rmks.TabIndex = 106
        Me.rmks.Title = "비고"
        Me.rmks.TitleWidth = 40
        '
        'req_no
        '
        Me.req_no.Location = New System.Drawing.Point(8, 28)
        Me.req_no.Name = "req_no"
        Me.req_no.Size = New System.Drawing.Size(240, 21)
        Me.req_no.TabIndex = 34
        Me.req_no.Title = "의뢰번호"
        '
        'go_gw
        '
        Me.go_gw.Location = New System.Drawing.Point(1025, 28)
        Me.go_gw.Name = "go_gw"
        Me.go_gw.Size = New System.Drawing.Size(112, 21)
        Me.go_gw.TabIndex = 102
        Me.go_gw.Text = "구매의뢰상신"
        '
        'req_dt
        '
        Me.req_dt.Location = New System.Drawing.Point(8, 52)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 33
        Me.req_dt.Title = "의뢰일자"
        '
        'sh_gw
        '
        Me.sh_gw.Location = New System.Drawing.Point(1025, 76)
        Me.sh_gw.Name = "sh_gw"
        Me.sh_gw.Size = New System.Drawing.Size(112, 21)
        Me.sh_gw.TabIndex = 103
        Me.sh_gw.Text = "결재문서조회"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(516, 76)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 33
        Me.dlv_dt.Title = "납기일자"
        '
        'fr_fac
        '
        Me.fr_fac.Location = New System.Drawing.Point(260, 28)
        Me.fr_fac.Name = "fr_fac"
        Me.fr_fac.Size = New System.Drawing.Size(240, 21)
        Me.fr_fac.TabIndex = 36
        Me.fr_fac.Title = "의뢰공장"
        '
        'chk_show
        '
        Me.chk_show.Caption = ""
        Me.chk_show.Location = New System.Drawing.Point(779, 79)
        Me.chk_show.Name = "chk_show"
        Me.chk_show.Size = New System.Drawing.Size(140, 21)
        Me.chk_show.TabIndex = 43
        Me.chk_show.Title = "품목 조회하기"
        '
        'fr_emp
        '
        Me.fr_emp.Location = New System.Drawing.Point(233, 3)
        Me.fr_emp.Name = "fr_emp"
        Me.fr_emp.Size = New System.Drawing.Size(213, 21)
        Me.fr_emp.TabIndex = 104
        Me.fr_emp.Title = "fr_emp"
        '
        'to_rid
        '
        Me.to_rid.Location = New System.Drawing.Point(946, 79)
        Me.to_rid.Name = "to_rid"
        Me.to_rid.Size = New System.Drawing.Size(56, 21)
        Me.to_rid.TabIndex = 38
        Me.to_rid.Title = "to_rid"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(779, 1)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 35
        Me.in_wh.Title = "입고창고"
        '
        'to_nm
        '
        Me.to_nm.Location = New System.Drawing.Point(516, 52)
        Me.to_nm.Name = "to_nm"
        Me.to_nm.Size = New System.Drawing.Size(240, 21)
        Me.to_nm.TabIndex = 41
        Me.to_nm.Title = "수신자"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(516, 3)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 36
        Me.in_fac.Title = "입고공장"
        '
        'fr_nm
        '
        Me.fr_nm.Location = New System.Drawing.Point(260, 76)
        Me.fr_nm.Name = "fr_nm"
        Me.fr_nm.Size = New System.Drawing.Size(240, 21)
        Me.fr_nm.TabIndex = 41
        Me.fr_nm.Title = "의뢰자"
        '
        'req_bc
        '
        Me.req_bc.Location = New System.Drawing.Point(8, 76)
        Me.req_bc.Name = "req_bc"
        Me.req_bc.Size = New System.Drawing.Size(240, 21)
        Me.req_bc.TabIndex = 32
        Me.req_bc.Title = "진행상태"
        '
        'to_dept_nm
        '
        Me.to_dept_nm.Location = New System.Drawing.Point(516, 28)
        Me.to_dept_nm.Name = "to_dept_nm"
        Me.to_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.to_dept_nm.TabIndex = 39
        Me.to_dept_nm.Title = "수신부서"
        '
        'to_dept
        '
        Me.to_dept.Location = New System.Drawing.Point(1234, 28)
        Me.to_dept.Name = "to_dept"
        Me.to_dept.Size = New System.Drawing.Size(76, 21)
        Me.to_dept.TabIndex = 40
        Me.to_dept.Title = "to_dept"
        '
        'fr_rid
        '
        Me.fr_rid.Location = New System.Drawing.Point(1186, 28)
        Me.fr_rid.Name = "fr_rid"
        Me.fr_rid.Size = New System.Drawing.Size(56, 21)
        Me.fr_rid.TabIndex = 38
        Me.fr_rid.Title = "fr_rid"
        '
        'fr_dept_nm
        '
        Me.fr_dept_nm.Location = New System.Drawing.Point(260, 52)
        Me.fr_dept_nm.Name = "fr_dept_nm"
        Me.fr_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.fr_dept_nm.TabIndex = 39
        Me.fr_dept_nm.Title = "의뢰부서"
        '
        'fr_dept
        '
        Me.fr_dept.Location = New System.Drawing.Point(1186, 76)
        Me.fr_dept.Name = "fr_dept"
        Me.fr_dept.Size = New System.Drawing.Size(76, 21)
        Me.fr_dept.TabIndex = 40
        Me.fr_dept.Title = "fr_dept"
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1353, 454)
        Me.SplitContainer2.SplitterDistance = 495
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer3)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(495, 454)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     의뢰조회"
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_nm2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_req_fr)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_req_to)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_cust_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_cust_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_mov)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_srh)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(491, 429)
        Me.SplitContainer3.SplitterDistance = 103
        Me.SplitContainer3.TabIndex = 2
        '
        'f_itm_cd
        '
        Me.f_itm_cd.Location = New System.Drawing.Point(8, 52)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_itm_cd.TabIndex = 36
        Me.f_itm_cd.Title = "품목코드"
        Me.f_itm_cd.TitleWidth = 90
        '
        'f_itm_nm2
        '
        Me.f_itm_nm2.Location = New System.Drawing.Point(209, 52)
        Me.f_itm_nm2.Name = "f_itm_nm2"
        Me.f_itm_nm2.Size = New System.Drawing.Size(148, 21)
        Me.f_itm_nm2.TabIndex = 35
        Me.f_itm_nm2.Title = "거래처"
        Me.f_itm_nm2.TitleWidth = 0
        '
        'f_req_fr
        '
        Me.f_req_fr.Location = New System.Drawing.Point(8, 28)
        Me.f_req_fr.Name = "f_req_fr"
        Me.f_req_fr.Size = New System.Drawing.Size(200, 21)
        Me.f_req_fr.TabIndex = 34
        Me.f_req_fr.Title = "의뢰기간"
        Me.f_req_fr.TitleWidth = 90
        '
        'f_req_to
        '
        Me.f_req_to.Location = New System.Drawing.Point(117, 28)
        Me.f_req_to.Name = "f_req_to"
        Me.f_req_to.Size = New System.Drawing.Size(200, 21)
        Me.f_req_to.TabIndex = 34
        Me.f_req_to.Title = ""
        Me.f_req_to.TitleWidth = 90
        '
        'f_cust_cd
        '
        Me.f_cust_cd.Location = New System.Drawing.Point(8, 4)
        Me.f_cust_cd.Name = "f_cust_cd"
        Me.f_cust_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_cust_cd.TabIndex = 17
        Me.f_cust_cd.Title = "거래처"
        Me.f_cust_cd.TitleWidth = 90
        '
        'f_itm_bc
        '
        Me.f_itm_bc.Location = New System.Drawing.Point(8, 76)
        Me.f_itm_bc.Name = "f_itm_bc"
        Me.f_itm_bc.Size = New System.Drawing.Size(200, 21)
        Me.f_itm_bc.TabIndex = 18
        Me.f_itm_bc.Title = "품목구분"
        Me.f_itm_bc.TitleWidth = 90
        '
        'f_cust_nm
        '
        Me.f_cust_nm.Location = New System.Drawing.Point(209, 4)
        Me.f_cust_nm.Name = "f_cust_nm"
        Me.f_cust_nm.Size = New System.Drawing.Size(148, 21)
        Me.f_cust_nm.TabIndex = 14
        Me.f_cust_nm.Title = "거래처"
        Me.f_cust_nm.TitleWidth = 0
        '
        'btn_mov
        '
        Me.btn_mov.Location = New System.Drawing.Point(295, 76)
        Me.btn_mov.Name = "btn_mov"
        Me.btn_mov.Size = New System.Drawing.Size(62, 23)
        Me.btn_mov.TabIndex = 20
        Me.btn_mov.Text = "적용"
        '
        'btn_srh
        '
        Me.btn_srh.Location = New System.Drawing.Point(231, 76)
        Me.btn_srh.Name = "btn_srh"
        Me.btn_srh.Size = New System.Drawing.Size(58, 23)
        Me.btn_srh.TabIndex = 19
        Me.btn_srh.Text = "검색"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(491, 322)
        Me.g20.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(854, 454)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     구매의뢰등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(850, 429)
        Me.g10.TabIndex = 2
        '
        'MMA100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMA100"
        Me.Size = New System.Drawing.Size(1353, 563)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fr_dept As Frame7.eText
    Friend WithEvents fr_nm As Frame7.eText
    Friend WithEvents fr_dept_nm As Frame7.eText
    Friend WithEvents fr_rid As Frame7.eText
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents req_no As Frame7.eText
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents to_nm As Frame7.eText
    Friend WithEvents to_dept_nm As Frame7.eText
    Friend WithEvents to_rid As Frame7.eText
    Friend WithEvents to_dept As Frame7.eText
    Friend WithEvents fr_fac As Frame7.eCombo
    Friend WithEvents req_bc As Frame7.eCombo
    Friend WithEvents chk_show As Frame7.eCheck
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_cust_cd As Frame7.eText
    Friend WithEvents f_itm_bc As Frame7.eCombo
    Friend WithEvents f_cust_nm As Frame7.eText
    Friend WithEvents btn_mov As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_srh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f_req_fr As Frame7.eDate
    Friend WithEvents f_req_to As Frame7.eDate
    Friend WithEvents f_itm_cd As Frame7.eText
    Friend WithEvents f_itm_nm2 As Frame7.eText
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents sh_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents go_gw As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fr_emp As Frame7.eText
    Friend WithEvents go_gw2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rmks As Frame7.eMemo

End Class
