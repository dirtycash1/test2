<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB150
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
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.fr_fac = New Frame7.eCombo()
        Me.fr_nm = New Frame7.eText()
        Me.fr_dept_nm = New Frame7.eText()
        Me.to_nm = New Frame7.eText()
        Me.to_dept_nm = New Frame7.eText()
        Me.req_no = New Frame7.eText()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.dlv_f_dt = New Frame7.eDate()
        Me.dlv_t_dt = New Frame7.eDate()
        Me.req_f_dt = New Frame7.eDate()
        Me.req_t_dt = New Frame7.eDate()
        Me.btn_do = New DevExpress.XtraEditors.SimpleButton()
        Me.to_rid = New Frame7.eText()
        Me.to_dept = New Frame7.eText()
        Me.fr_rid = New Frame7.eText()
        Me.fr_dept = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.CachedLEB160R1 = New System7.CachedLEB160R()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 516)
        Me.SplitContainer1.SplitterDistance = 132
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.fr_fac)
        Me.EPanel1.Controls.Add(Me.fr_nm)
        Me.EPanel1.Controls.Add(Me.fr_dept_nm)
        Me.EPanel1.Controls.Add(Me.to_nm)
        Me.EPanel1.Controls.Add(Me.to_dept_nm)
        Me.EPanel1.Controls.Add(Me.req_no)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.dlv_f_dt)
        Me.EPanel1.Controls.Add(Me.dlv_t_dt)
        Me.EPanel1.Controls.Add(Me.req_f_dt)
        Me.EPanel1.Controls.Add(Me.req_t_dt)
        Me.EPanel1.Controls.Add(Me.btn_do)
        Me.EPanel1.Controls.Add(Me.to_rid)
        Me.EPanel1.Controls.Add(Me.to_dept)
        Me.EPanel1.Controls.Add(Me.fr_rid)
        Me.EPanel1.Controls.Add(Me.fr_dept)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 132)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(776, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 98
        Me.itm_bc.Title = "품목구분"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(520, 28)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 99
        Me.stat_bc.Title = "진행상태"
        '
        'fr_fac
        '
        Me.fr_fac.Location = New System.Drawing.Point(264, 28)
        Me.fr_fac.Name = "fr_fac"
        Me.fr_fac.Size = New System.Drawing.Size(240, 21)
        Me.fr_fac.TabIndex = 93
        Me.fr_fac.Title = "의뢰공장"
        '
        'fr_nm
        '
        Me.fr_nm.Location = New System.Drawing.Point(264, 76)
        Me.fr_nm.Name = "fr_nm"
        Me.fr_nm.Size = New System.Drawing.Size(240, 21)
        Me.fr_nm.TabIndex = 91
        Me.fr_nm.Title = "의뢰자"
        '
        'fr_dept_nm
        '
        Me.fr_dept_nm.Location = New System.Drawing.Point(264, 52)
        Me.fr_dept_nm.Name = "fr_dept_nm"
        Me.fr_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.fr_dept_nm.TabIndex = 90
        Me.fr_dept_nm.Title = "의뢰부서"
        '
        'to_nm
        '
        Me.to_nm.Location = New System.Drawing.Point(520, 76)
        Me.to_nm.Name = "to_nm"
        Me.to_nm.Size = New System.Drawing.Size(240, 21)
        Me.to_nm.TabIndex = 92
        Me.to_nm.Title = "수신자"
        '
        'to_dept_nm
        '
        Me.to_dept_nm.Location = New System.Drawing.Point(520, 52)
        Me.to_dept_nm.Name = "to_dept_nm"
        Me.to_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.to_dept_nm.TabIndex = 89
        Me.to_dept_nm.Title = "수신부서"
        '
        'req_no
        '
        Me.req_no.Location = New System.Drawing.Point(264, 100)
        Me.req_no.Name = "req_no"
        Me.req_no.Size = New System.Drawing.Size(240, 21)
        Me.req_no.TabIndex = 86
        Me.req_no.Title = "의뢰번호"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(776, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 88
        Me.grp1_cd.Title = "대분류"
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(776, 76)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 87
        Me.itm_cd.Title = "품목코드 %"
        '
        'itm_nm
        '
        Me.itm_nm.Location = New System.Drawing.Point(776, 100)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 85
        Me.itm_nm.Title = "품목명 %"
        '
        'dlv_f_dt
        '
        Me.dlv_f_dt.Location = New System.Drawing.Point(8, 76)
        Me.dlv_f_dt.Name = "dlv_f_dt"
        Me.dlv_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_f_dt.TabIndex = 82
        Me.dlv_f_dt.Title = "납기일자"
        '
        'dlv_t_dt
        '
        Me.dlv_t_dt.Location = New System.Drawing.Point(128, 100)
        Me.dlv_t_dt.Name = "dlv_t_dt"
        Me.dlv_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.dlv_t_dt.TabIndex = 83
        Me.dlv_t_dt.Title = "dlv_t_dt"
        Me.dlv_t_dt.TitleWidth = 0
        '
        'req_f_dt
        '
        Me.req_f_dt.Location = New System.Drawing.Point(8, 28)
        Me.req_f_dt.Name = "req_f_dt"
        Me.req_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_f_dt.TabIndex = 81
        Me.req_f_dt.Title = "의뢰일자"
        '
        'req_t_dt
        '
        Me.req_t_dt.Location = New System.Drawing.Point(128, 52)
        Me.req_t_dt.Name = "req_t_dt"
        Me.req_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.req_t_dt.TabIndex = 84
        Me.req_t_dt.Title = "부터"
        Me.req_t_dt.TitleWidth = 0
        '
        'btn_do
        '
        Me.btn_do.Location = New System.Drawing.Point(640, 102)
        Me.btn_do.Name = "btn_do"
        Me.btn_do.Size = New System.Drawing.Size(120, 24)
        Me.btn_do.TabIndex = 50
        Me.btn_do.Text = "발주처리"
        '
        'to_rid
        '
        Me.to_rid.Location = New System.Drawing.Point(324, 112)
        Me.to_rid.Name = "to_rid"
        Me.to_rid.Size = New System.Drawing.Size(56, 21)
        Me.to_rid.TabIndex = 95
        Me.to_rid.Title = "to_rid"
        '
        'to_dept
        '
        Me.to_dept.Location = New System.Drawing.Point(260, 112)
        Me.to_dept.Name = "to_dept"
        Me.to_dept.Size = New System.Drawing.Size(76, 21)
        Me.to_dept.TabIndex = 97
        Me.to_dept.Title = "to_dept"
        '
        'fr_rid
        '
        Me.fr_rid.Location = New System.Drawing.Point(212, 112)
        Me.fr_rid.Name = "fr_rid"
        Me.fr_rid.Size = New System.Drawing.Size(56, 21)
        Me.fr_rid.TabIndex = 94
        Me.fr_rid.Title = "fr_rid"
        '
        'fr_dept
        '
        Me.fr_dept.Location = New System.Drawing.Point(148, 112)
        Me.fr_dept.Name = "fr_dept"
        Me.fr_dept.Size = New System.Drawing.Size(76, 21)
        Me.fr_dept.TabIndex = 96
        Me.fr_dept.Title = "fr_dept"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 380)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     구매의뢰 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 355)
        Me.g10.TabIndex = 2
        '
        'MMB150
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB150"
        Me.Size = New System.Drawing.Size(1034, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_do As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo
    Friend WithEvents fr_fac As Frame7.eCombo
    Friend WithEvents fr_nm As Frame7.eText
    Friend WithEvents fr_dept_nm As Frame7.eText
    Friend WithEvents to_nm As Frame7.eText
    Friend WithEvents to_dept_nm As Frame7.eText
    Friend WithEvents req_no As Frame7.eText
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents dlv_f_dt As Frame7.eDate
    Friend WithEvents dlv_t_dt As Frame7.eDate
    Friend WithEvents req_f_dt As Frame7.eDate
    Friend WithEvents req_t_dt As Frame7.eDate
    Friend WithEvents to_rid As Frame7.eText
    Friend WithEvents to_dept As Frame7.eText
    Friend WithEvents fr_rid As Frame7.eText
    Friend WithEvents fr_dept As Frame7.eText
    Friend WithEvents CachedLEB160R1 As System7.CachedLEB160R

End Class
