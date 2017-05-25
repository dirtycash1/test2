<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA3040
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
        Me.credit_bc = New Frame7.eCheckCombo()
        Me.addr_prt = New Frame7.eText()
        Me.tel = New Frame7.eText()
        Me.grp3_cd = New Frame7.eCheckCombo()
        Me.grp4_cd = New Frame7.eCheckCombo()
        Me.grp2_cd = New Frame7.eCheckCombo()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.sale_emp = New Frame7.eText()
        Me.sale_nm = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.credit_bc)
        Me.EPanel1.Controls.Add(Me.addr_prt)
        Me.EPanel1.Controls.Add(Me.tel)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.grp4_cd)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.sale_emp)
        Me.EPanel1.Controls.Add(Me.sale_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'credit_bc
        '
        Me.credit_bc.Location = New System.Drawing.Point(628, 28)
        Me.credit_bc.Name = "credit_bc"
        Me.credit_bc.Size = New System.Drawing.Size(240, 21)
        Me.credit_bc.TabIndex = 13
        '
        'addr_prt
        '
        Me.addr_prt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr_prt.Location = New System.Drawing.Point(628, 76)
        Me.addr_prt.Name = "addr_prt"
        Me.addr_prt.Size = New System.Drawing.Size(240, 21)
        Me.addr_prt.TabIndex = 12
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tel.Location = New System.Drawing.Point(628, 52)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(240, 21)
        Me.tel.TabIndex = 11
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(380, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 10
        '
        'grp4_cd
        '
        Me.grp4_cd.Location = New System.Drawing.Point(380, 52)
        Me.grp4_cd.Name = "grp4_cd"
        Me.grp4_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp4_cd.TabIndex = 9
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(380, 28)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 8
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(8, 76)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 6
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(132, 76)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 7
        '
        'sale_emp
        '
        Me.sale_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_emp.Location = New System.Drawing.Point(8, 52)
        Me.sale_emp.Name = "sale_emp"
        Me.sale_emp.Size = New System.Drawing.Size(240, 21)
        Me.sale_emp.TabIndex = 4
        '
        'sale_nm
        '
        Me.sale_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_nm.Location = New System.Drawing.Point(132, 52)
        Me.sale_nm.Name = "sale_nm"
        Me.sale_nm.Size = New System.Drawing.Size(240, 21)
        Me.sale_nm.TabIndex = 5
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(8, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 2
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(132, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 3
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 582)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     거래처 리스트"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 557)
        Me.g10.TabIndex = 2
        '
        'WP_SA3040
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA3040"
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents credit_bc As Frame7.eCheckCombo
    Friend WithEvents addr_prt As Frame7.eText
    Friend WithEvents tel As Frame7.eText
    Friend WithEvents grp3_cd As Frame7.eCheckCombo
    Friend WithEvents grp4_cd As Frame7.eCheckCombo
    Friend WithEvents grp2_cd As Frame7.eCheckCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents sale_emp As Frame7.eText
    Friend WithEvents sale_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText

End Class
