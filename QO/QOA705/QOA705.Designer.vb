<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QOA705
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
        Me.EPanel5 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.btn_up = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_dn = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel6 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.gvx = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.mat_nm = New Frame7.eText()
        Me.mat_cd = New Frame7.eText()
        Me.re_no = New Frame7.eText()
        Me.cid = New Frame7.eText()
        Me.mid = New Frame7.eText()
        Me.mdt = New Frame7.eDate()
        Me.cdt = New Frame7.eDate()
        Me.itm_id = New Frame7.eText()
        Me.reg_id = New Frame7.eText()
        Me.com_bc = New Frame7.eCombo()
        Me.cust_tel = New Frame7.eText()
        Me.cust_dept = New Frame7.eText()
        Me.cust_emp = New Frame7.eText()
        Me.use_rmk = New Frame7.eMemo()
        Me.cust_nm = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.req_rmk = New Frame7.eMemo()
        Me.com_no = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.com_dt = New Frame7.eDate()
        Me.itm_nm = New Frame7.eText()
        Me.stat_bc = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.end_dt = New Frame7.eDate()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel6.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 608)
        Me.SplitContainer1.SplitterDistance = 288
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.end_dt)
        Me.EPanel1.Controls.Add(Me.mat_nm)
        Me.EPanel1.Controls.Add(Me.mat_cd)
        Me.EPanel1.Controls.Add(Me.re_no)
        Me.EPanel1.Controls.Add(Me.cid)
        Me.EPanel1.Controls.Add(Me.mid)
        Me.EPanel1.Controls.Add(Me.mdt)
        Me.EPanel1.Controls.Add(Me.cdt)
        Me.EPanel1.Controls.Add(Me.itm_id)
        Me.EPanel1.Controls.Add(Me.reg_id)
        Me.EPanel1.Controls.Add(Me.com_bc)
        Me.EPanel1.Controls.Add(Me.cust_tel)
        Me.EPanel1.Controls.Add(Me.cust_dept)
        Me.EPanel1.Controls.Add(Me.cust_emp)
        Me.EPanel1.Controls.Add(Me.use_rmk)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.req_rmk)
        Me.EPanel1.Controls.Add(Me.com_no)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.com_dt)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1120, 288)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     의사 소통 등록"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel5)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel6)
        Me.SplitContainer3.Size = New System.Drawing.Size(1120, 316)
        Me.SplitContainer3.SplitterDistance = 343
        Me.SplitContainer3.TabIndex = 2
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g10)
        Me.EPanel5.Controls.Add(Me.btn_up)
        Me.EPanel5.Controls.Add(Me.btn_dn)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(343, 316)
        Me.EPanel5.TabIndex = 0
        Me.EPanel5.Text = "     관련근거 등록"
        '
        'g10
        '
        Me.g10.AllowAddRows = False
        Me.g10.AllowDeleteRows = False
        Me.g10.AllowDrop = True
        Me.g10.AllowInsertRows = False
        Me.g10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g10.Location = New System.Drawing.Point(2, 64)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(339, 250)
        Me.g10.TabIndex = 2
        '
        'btn_up
        '
        Me.btn_up.Location = New System.Drawing.Point(12, 26)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(93, 32)
        Me.btn_up.TabIndex = 3
        Me.btn_up.Text = "파일올리기"
        '
        'btn_dn
        '
        Me.btn_dn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dn.Location = New System.Drawing.Point(234, 26)
        Me.btn_dn.Name = "btn_dn"
        Me.btn_dn.Size = New System.Drawing.Size(93, 32)
        Me.btn_dn.TabIndex = 4
        Me.btn_dn.Text = "모두내려받기"
        '
        'EPanel6
        '
        Me.EPanel6.Controls.Add(Me.g20)
        Me.EPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel6.Location = New System.Drawing.Point(0, 0)
        Me.EPanel6.Name = "EPanel6"
        Me.EPanel6.Size = New System.Drawing.Size(773, 316)
        Me.EPanel6.TabIndex = 1
        Me.EPanel6.Text = "     유해물질 구성 현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(769, 291)
        Me.g20.TabIndex = 2
        '
        'gvx
        '
        Me.gvx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvx.Location = New System.Drawing.Point(2, 23)
        Me.gvx.Name = "gvx"
        Me.gvx.ReadOnly = False
        Me.gvx.RecordNavigator = False
        Me.gvx.RowHeight = -1
        Me.gvx.Size = New System.Drawing.Size(1109, 309)
        Me.gvx.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.gvx)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(2, 2)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1113, 334)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     품목현황"
        '
        'mat_nm
        '
        Me.mat_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mat_nm.Location = New System.Drawing.Point(515, 50)
        Me.mat_nm.Name = "mat_nm"
        Me.mat_nm.Size = New System.Drawing.Size(240, 21)
        Me.mat_nm.TabIndex = 208
        Me.mat_nm.Title = "재질명칭"
        Me.mat_nm.TitleWidth = 0
        '
        'mat_cd
        '
        Me.mat_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mat_cd.Location = New System.Drawing.Point(271, 50)
        Me.mat_cd.Name = "mat_cd"
        Me.mat_cd.Size = New System.Drawing.Size(240, 21)
        Me.mat_cd.TabIndex = 207
        Me.mat_cd.Title = "재질정보"
        '
        're_no
        '
        Me.re_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.re_no.Location = New System.Drawing.Point(802, 107)
        Me.re_no.Name = "re_no"
        Me.re_no.Size = New System.Drawing.Size(80, 21)
        Me.re_no.TabIndex = 206
        Me.re_no.Title = "re_no"
        '
        'cid
        '
        Me.cid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cid.Location = New System.Drawing.Point(802, 53)
        Me.cid.Name = "cid"
        Me.cid.Size = New System.Drawing.Size(40, 21)
        Me.cid.TabIndex = 205
        Me.cid.Title = "cid"
        '
        'mid
        '
        Me.mid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mid.Location = New System.Drawing.Point(802, 80)
        Me.mid.Name = "mid"
        Me.mid.Size = New System.Drawing.Size(53, 21)
        Me.mid.TabIndex = 204
        Me.mid.Title = "mid"
        '
        'mdt
        '
        Me.mdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mdt.Location = New System.Drawing.Point(878, 80)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(69, 21)
        Me.mdt.TabIndex = 203
        Me.mdt.Title = "mdt"
        '
        'cdt
        '
        Me.cdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cdt.Location = New System.Drawing.Point(878, 53)
        Me.cdt.Name = "cdt"
        Me.cdt.Size = New System.Drawing.Size(40, 21)
        Me.cdt.TabIndex = 202
        Me.cdt.Title = "cdt"
        '
        'itm_id
        '
        Me.itm_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_id.Location = New System.Drawing.Point(802, 25)
        Me.itm_id.Name = "itm_id"
        Me.itm_id.Size = New System.Drawing.Size(80, 21)
        Me.itm_id.TabIndex = 201
        Me.itm_id.Title = "itm_id"
        '
        'reg_id
        '
        Me.reg_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.reg_id.Location = New System.Drawing.Point(802, 134)
        Me.reg_id.Name = "reg_id"
        Me.reg_id.Size = New System.Drawing.Size(80, 21)
        Me.reg_id.TabIndex = 199
        Me.reg_id.Title = "reg_id"
        Me.reg_id.Visible = False
        '
        'com_bc
        '
        Me.com_bc.Location = New System.Drawing.Point(12, 74)
        Me.com_bc.Name = "com_bc"
        Me.com_bc.Size = New System.Drawing.Size(240, 21)
        Me.com_bc.TabIndex = 198
        Me.com_bc.Title = "대응구분"
        '
        'cust_tel
        '
        Me.cust_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_tel.Location = New System.Drawing.Point(515, 98)
        Me.cust_tel.Name = "cust_tel"
        Me.cust_tel.Size = New System.Drawing.Size(240, 21)
        Me.cust_tel.TabIndex = 193
        Me.cust_tel.Title = "의뢰자 전화번호"
        '
        'cust_dept
        '
        Me.cust_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_dept.Location = New System.Drawing.Point(271, 98)
        Me.cust_dept.Name = "cust_dept"
        Me.cust_dept.Size = New System.Drawing.Size(240, 21)
        Me.cust_dept.TabIndex = 192
        Me.cust_dept.Title = "의뢰부서"
        '
        'cust_emp
        '
        Me.cust_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_emp.Location = New System.Drawing.Point(12, 98)
        Me.cust_emp.Name = "cust_emp"
        Me.cust_emp.Size = New System.Drawing.Size(240, 21)
        Me.cust_emp.TabIndex = 191
        Me.cust_emp.Title = "의뢰자"
        '
        'use_rmk
        '
        Me.use_rmk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.use_rmk.Location = New System.Drawing.Point(12, 179)
        Me.use_rmk.Name = "use_rmk"
        Me.use_rmk.Size = New System.Drawing.Size(745, 54)
        Me.use_rmk.TabIndex = 189
        Me.use_rmk.Title = "처리내용"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(515, 74)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 188
        Me.cust_nm.Title = "주요원자재명"
        Me.cust_nm.TitleWidth = 0
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(271, 74)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 187
        Me.cust_cd.Title = "업체정보"
        '
        'req_rmk
        '
        Me.req_rmk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rmk.Location = New System.Drawing.Point(12, 122)
        Me.req_rmk.Name = "req_rmk"
        Me.req_rmk.Size = New System.Drawing.Size(745, 54)
        Me.req_rmk.TabIndex = 186
        Me.req_rmk.Title = "요구사항"
        '
        'com_no
        '
        Me.com_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.com_no.Location = New System.Drawing.Point(12, 26)
        Me.com_no.Name = "com_no"
        Me.com_no.Size = New System.Drawing.Size(240, 21)
        Me.com_no.TabIndex = 182
        Me.com_no.Title = "소통 번호"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(271, 26)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 184
        Me.itm_cd.Title = "품목정보"
        '
        'com_dt
        '
        Me.com_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.com_dt.Location = New System.Drawing.Point(12, 50)
        Me.com_dt.Name = "com_dt"
        Me.com_dt.Size = New System.Drawing.Size(240, 21)
        Me.com_dt.TabIndex = 183
        Me.com_dt.Title = "대응일"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(515, 26)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 185
        Me.itm_nm.Title = "주요원자재명"
        Me.itm_nm.TitleWidth = 0
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(12, 260)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 214
        Me.stat_bc.Title = "처리상태"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(636, 260)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(123, 21)
        Me.dept_nm.TabIndex = 213
        Me.dept_nm.Title = "주요원자재명"
        Me.dept_nm.TitleWidth = 0
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(390, 260)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 212
        Me.dept_cd.Title = "담당부서"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(636, 236)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(123, 21)
        Me.emp_nm.TabIndex = 211
        Me.emp_nm.Title = "주요원자재명"
        Me.emp_nm.TitleWidth = 0
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(390, 236)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 210
        Me.emp_no.Title = "담당자"
        '
        'end_dt
        '
        Me.end_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_dt.Location = New System.Drawing.Point(12, 236)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(240, 21)
        Me.end_dt.TabIndex = 209
        Me.end_dt.Title = "처리일"
        '
        'QOA705
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QOA705"
        Me.Size = New System.Drawing.Size(1143, 654)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel6.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents gvx As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel6 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents btn_up As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_dn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mat_nm As Frame7.eText
    Friend WithEvents mat_cd As Frame7.eText
    Friend WithEvents re_no As Frame7.eText
    Friend WithEvents cid As Frame7.eText
    Friend WithEvents mid As Frame7.eText
    Friend WithEvents mdt As Frame7.eDate
    Friend WithEvents cdt As Frame7.eDate
    Friend WithEvents itm_id As Frame7.eText
    Friend WithEvents reg_id As Frame7.eText
    Friend WithEvents com_bc As Frame7.eCombo
    Friend WithEvents cust_tel As Frame7.eText
    Friend WithEvents cust_dept As Frame7.eText
    Friend WithEvents cust_emp As Frame7.eText
    Friend WithEvents use_rmk As Frame7.eMemo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents req_rmk As Frame7.eMemo
    Friend WithEvents com_no As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents com_dt As Frame7.eDate
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents end_dt As Frame7.eDate

End Class
