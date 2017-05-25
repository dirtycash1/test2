<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB120
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.in_wh = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.po_dt = New Frame7.eDate()
        Me.po_dept_nm = New Frame7.eText()
        Me.po_fac = New Frame7.eCombo()
        Me.po_nm = New Frame7.eText()
        Me.po_dept = New Frame7.eText()
        Me.po_rid = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.btn_price = New DevExpress.XtraEditors.SimpleButton()
        Me.ent_bc = New Frame7.eCombo()
        Me.di_bc = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.po_kd = New Frame7.eCombo()
        Me.po_bc = New Frame7.eCombo()
        Me.rmks = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 516)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel3.Controls.Add(Me.in_wh)
        Me.EPanel3.Controls.Add(Me.in_fac)
        Me.EPanel3.Controls.Add(Me.po_dt)
        Me.EPanel3.Controls.Add(Me.po_dept_nm)
        Me.EPanel3.Controls.Add(Me.di_bc)
        Me.EPanel3.Controls.Add(Me.cury_bc)
        Me.EPanel3.Controls.Add(Me.po_fac)
        Me.EPanel3.Controls.Add(Me.po_nm)
        Me.EPanel3.Controls.Add(Me.po_dept)
        Me.EPanel3.Controls.Add(Me.po_rid)
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1024, 80)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     발주정보"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(267, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 99
        Me.in_wh.Title = "입고창고"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(267, 28)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 100
        Me.in_fac.Title = "입고공장"
        '
        'po_dt
        '
        Me.po_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dt.Location = New System.Drawing.Point(12, 52)
        Me.po_dt.Name = "po_dt"
        Me.po_dt.Size = New System.Drawing.Size(240, 21)
        Me.po_dt.TabIndex = 5
        Me.po_dt.Title = "발주일자"
        '
        'po_dept_nm
        '
        Me.po_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept_nm.Location = New System.Drawing.Point(522, 52)
        Me.po_dept_nm.Name = "po_dept_nm"
        Me.po_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_dept_nm.TabIndex = 20
        Me.po_dept_nm.Title = "po_dept_nm"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(12, 28)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 19
        Me.po_fac.Title = "발주공장"
        '
        'po_nm
        '
        Me.po_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_nm.Location = New System.Drawing.Point(522, 28)
        Me.po_nm.Name = "po_nm"
        Me.po_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_nm.TabIndex = 16
        Me.po_nm.Title = "po_nm"
        '
        'po_dept
        '
        Me.po_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept.Location = New System.Drawing.Point(796, 52)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(100, 21)
        Me.po_dept.TabIndex = 21
        Me.po_dept.Title = "po_dept"
        '
        'po_rid
        '
        Me.po_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_rid.Location = New System.Drawing.Point(796, 28)
        Me.po_rid.Name = "po_rid"
        Me.po_rid.Size = New System.Drawing.Size(48, 21)
        Me.po_rid.TabIndex = 13
        Me.po_rid.Title = "po_rid"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.ent_bc)
        Me.EPanel1.Controls.Add(Me.po_kd)
        Me.EPanel1.Controls.Add(Me.btn_price)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1024, 60)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "검색"
        '
        'btn_price
        '
        Me.btn_price.Location = New System.Drawing.Point(796, 19)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(112, 24)
        Me.btn_price.TabIndex = 50
        Me.btn_price.Text = "최근단가 적용"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(524, 8)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 24
        Me.ent_bc.Title = "입력경로"
        '
        'di_bc
        '
        Me.di_bc.Location = New System.Drawing.Point(850, 28)
        Me.di_bc.Name = "di_bc"
        Me.di_bc.Size = New System.Drawing.Size(240, 21)
        Me.di_bc.TabIndex = 22
        Me.di_bc.Title = "내외자"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(850, 52)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 23
        Me.cury_bc.Title = "통화"
        '
        'po_kd
        '
        Me.po_kd.Location = New System.Drawing.Point(12, 8)
        Me.po_kd.Name = "po_kd"
        Me.po_kd.Size = New System.Drawing.Size(240, 21)
        Me.po_kd.TabIndex = 3
        Me.po_kd.Title = "발주유형"
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(267, 8)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(240, 21)
        Me.po_bc.TabIndex = 3
        Me.po_bc.Title = "po_bc"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(12, 32)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(752, 21)
        Me.rmks.TabIndex = 18
        Me.rmks.Title = "비고"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 364)
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
        Me.g10.Size = New System.Drawing.Size(1020, 339)
        Me.g10.TabIndex = 2
        '
        'MMB120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB120"
        Me.Size = New System.Drawing.Size(1034, 563)
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
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents po_kd As Frame7.eCombo
    Friend WithEvents po_dt As Frame7.eDate
    Friend WithEvents po_nm As Frame7.eText
    Friend WithEvents po_rid As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents di_bc As Frame7.eCombo
    Friend WithEvents po_dept As Frame7.eText
    Friend WithEvents po_dept_nm As Frame7.eText
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents po_bc As Frame7.eCombo
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents btn_price As DevExpress.XtraEditors.SimpleButton

End Class
