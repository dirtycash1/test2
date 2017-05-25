<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEA115
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
        Me.ent_bc = New Frame7.eCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.in_no = New Frame7.eText()
        Me.wh_cd = New Frame7.eCombo()
        Me.btn_price = New DevExpress.XtraEditors.SimpleButton()
        Me.in_dt = New Frame7.eDate()
        Me.reg_nm = New Frame7.eText()
        Me.reg_id = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 516)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ent_bc)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.in_no)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.btn_price)
        Me.EPanel1.Controls.Add(Me.in_dt)
        Me.EPanel1.Controls.Add(Me.reg_nm)
        Me.EPanel1.Controls.Add(Me.reg_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 79)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(776, 52)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 66
        Me.ent_bc.Title = "ent_bc"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(264, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 60
        Me.fac_cd.Title = "입고공장"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(936, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(76, 21)
        Me.dept_cd.TabIndex = 63
        Me.dept_cd.Title = "dept_cd"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(520, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 63
        Me.dept_nm.Title = "dept_nm"
        '
        'in_no
        '
        Me.in_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_no.Location = New System.Drawing.Point(8, 28)
        Me.in_no.Name = "in_no"
        Me.in_no.Size = New System.Drawing.Size(240, 21)
        Me.in_no.TabIndex = 45
        Me.in_no.Title = "입고번호"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(264, 52)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 59
        Me.wh_cd.Title = "입고창고"
        '
        'btn_price
        '
        Me.btn_price.Location = New System.Drawing.Point(768, 26)
        Me.btn_price.Name = "btn_price"
        Me.btn_price.Size = New System.Drawing.Size(120, 24)
        Me.btn_price.TabIndex = 64
        Me.btn_price.Text = "최신단가 적용"
        '
        'in_dt
        '
        Me.in_dt.Location = New System.Drawing.Point(8, 52)
        Me.in_dt.Name = "in_dt"
        Me.in_dt.Size = New System.Drawing.Size(240, 21)
        Me.in_dt.TabIndex = 37
        Me.in_dt.Title = "입고일자"
        '
        'reg_nm
        '
        Me.reg_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.reg_nm.Location = New System.Drawing.Point(520, 52)
        Me.reg_nm.Name = "reg_nm"
        Me.reg_nm.Size = New System.Drawing.Size(240, 21)
        Me.reg_nm.TabIndex = 63
        Me.reg_nm.Title = "reg_nm"
        '
        'reg_id
        '
        Me.reg_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.reg_id.Location = New System.Drawing.Point(884, 56)
        Me.reg_id.Name = "reg_id"
        Me.reg_id.Size = New System.Drawing.Size(80, 21)
        Me.reg_id.TabIndex = 62
        Me.reg_id.Title = "reg_id"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1020, 433)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     발주정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1016, 408)
        Me.g10.TabIndex = 2
        '
        'LEA115
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEA115"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents in_no As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents btn_price As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents in_dt As Frame7.eDate
    Friend WithEvents reg_nm As Frame7.eText
    Friend WithEvents reg_id As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid

End Class
