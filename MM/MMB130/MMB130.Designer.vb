<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB130
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.dlv_f_dt = New Frame7.eDate()
        Me.dlv_t_dt = New Frame7.eDate()
        Me.req_f_dt = New Frame7.eDate()
        Me.req_t_dt = New Frame7.eDate()
        Me.EPanel1 = New Frame7.ePanel()
        Me.ent_bc = New Frame7.eCombo()
        Me.po_kd = New Frame7.eCombo()
        Me.in_wh = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.po_dt = New Frame7.eDate()
        Me.btn_price = New DevExpress.XtraEditors.SimpleButton()
        Me.po_fac = New Frame7.eCombo()
        Me.rmks = New Frame7.eText()
        Me.po_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.po_dept = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(994, 516)
        Me.SplitContainer1.SplitterDistance = 171
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel3
        '
        Me.EPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel3.Controls.Add(Me.itm_bc)
        Me.EPanel3.Controls.Add(Me.grp1_cd)
        Me.EPanel3.Controls.Add(Me.itm_cd)
        Me.EPanel3.Controls.Add(Me.itm_nm)
        Me.EPanel3.Controls.Add(Me.dlv_f_dt)
        Me.EPanel3.Controls.Add(Me.dlv_t_dt)
        Me.EPanel3.Controls.Add(Me.req_f_dt)
        Me.EPanel3.Controls.Add(Me.req_t_dt)
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(994, 82)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     발주정보"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(530, 29)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 106
        Me.itm_bc.Title = "품목구분"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(530, 53)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 105
        Me.grp1_cd.Title = "대분류"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(792, 29)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 104
        Me.itm_cd.Title = "품목코드 %"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(792, 53)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 103
        Me.itm_nm.Title = "품목명 %"
        '
        'dlv_f_dt
        '
        Me.dlv_f_dt.Location = New System.Drawing.Point(267, 29)
        Me.dlv_f_dt.Name = "dlv_f_dt"
        Me.dlv_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_f_dt.TabIndex = 100
        Me.dlv_f_dt.Title = "납기일자"
        '
        'dlv_t_dt
        '
        Me.dlv_t_dt.Location = New System.Drawing.Point(387, 53)
        Me.dlv_t_dt.Name = "dlv_t_dt"
        Me.dlv_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.dlv_t_dt.TabIndex = 101
        Me.dlv_t_dt.Title = "dlv_t_dt"
        Me.dlv_t_dt.TitleWidth = 0
        '
        'req_f_dt
        '
        Me.req_f_dt.Location = New System.Drawing.Point(12, 29)
        Me.req_f_dt.Name = "req_f_dt"
        Me.req_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_f_dt.TabIndex = 99
        Me.req_f_dt.Title = "의뢰일자"
        '
        'req_t_dt
        '
        Me.req_t_dt.Location = New System.Drawing.Point(132, 53)
        Me.req_t_dt.Name = "req_t_dt"
        Me.req_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.req_t_dt.TabIndex = 102
        Me.req_t_dt.Title = "부터"
        Me.req_t_dt.TitleWidth = 0
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.po_dept)
        Me.EPanel1.Controls.Add(Me.ent_bc)
        Me.EPanel1.Controls.Add(Me.po_kd)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.po_dt)
        Me.EPanel1.Controls.Add(Me.btn_price)
        Me.EPanel1.Controls.Add(Me.po_fac)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 85)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(994, 84)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "검색"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(530, 8)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 24
        Me.ent_bc.Title = "입력경로"
        '
        'po_kd
        '
        Me.po_kd.Location = New System.Drawing.Point(12, 56)
        Me.po_kd.Name = "po_kd"
        Me.po_kd.Size = New System.Drawing.Size(240, 21)
        Me.po_kd.TabIndex = 3
        Me.po_kd.Title = "발주유형"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(267, 32)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 99
        Me.in_wh.Title = "입고창고"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(267, 8)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 100
        Me.in_fac.Title = "입고공장"
        '
        'po_dt
        '
        Me.po_dt.Location = New System.Drawing.Point(12, 32)
        Me.po_dt.Name = "po_dt"
        Me.po_dt.Size = New System.Drawing.Size(240, 21)
        Me.po_dt.TabIndex = 100
        Me.po_dt.Title = "발주일자"
        '
        'btn_price
        '
        Me.btn_price.Location = New System.Drawing.Point(792, 53)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(112, 24)
        Me.btn_price.TabIndex = 50
        Me.btn_price.Text = "최근단가 적용"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(12, 8)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 19
        Me.po_fac.Title = "발주공장"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(267, 56)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(503, 21)
        Me.rmks.TabIndex = 18
        Me.rmks.Title = "비고"
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(530, 32)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(240, 21)
        Me.po_bc.TabIndex = 3
        Me.po_bc.Title = "po_bc"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(994, 341)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     구매발주 상세 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(990, 316)
        Me.g10.TabIndex = 2
        '
        'po_dept
        '
        Me.po_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept.Location = New System.Drawing.Point(792, 8)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(100, 21)
        Me.po_dept.TabIndex = 101
        Me.po_dept.Title = "po_dept"
        '
        'MMB130
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB130"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents po_kd As Frame7.eCombo
    Friend WithEvents btn_price As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents po_bc As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents dlv_f_dt As Frame7.eDate
    Friend WithEvents dlv_t_dt As Frame7.eDate
    Friend WithEvents req_f_dt As Frame7.eDate
    Friend WithEvents req_t_dt As Frame7.eDate
    Friend WithEvents po_dt As Frame7.eDate
    Friend WithEvents po_dept As Frame7.eText

End Class
