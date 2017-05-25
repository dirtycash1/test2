<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMS110
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
        Me.fac_cd = New Frame7.eCombo()
        Me.req_rid = New Frame7.eText()
        Me.req_dept = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.req_dept_nm = New Frame7.eText()
        Me.req_rid_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.spc_dt = New Frame7.eDate()
        Me.req_dsc = New Frame7.eMemo()
        Me.dept_nm = New Frame7.eText()
        Me.spc_dsc = New Frame7.eMemo()
        Me.spc_bc = New Frame7.eCombo()
        Me.spc_rid = New Frame7.eText()
        Me.no_bc = New Frame7.eCombo()
        Me.nm = New Frame7.eText()
        Me.spc_dept = New Frame7.eText()
        Me.g30 = New Frame7.eGrid()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(940, 580)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.req_rid)
        Me.EPanel1.Controls.Add(Me.req_dept)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.req_dept_nm)
        Me.EPanel1.Controls.Add(Me.req_rid_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(940, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 2
        '
        'req_rid
        '
        Me.req_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid.Location = New System.Drawing.Point(520, 52)
        Me.req_rid.Name = "req_rid"
        Me.req_rid.Size = New System.Drawing.Size(240, 21)
        Me.req_rid.TabIndex = 4
        '
        'req_dept
        '
        Me.req_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept.Location = New System.Drawing.Point(520, 28)
        Me.req_dept.Name = "req_dept"
        Me.req_dept.Size = New System.Drawing.Size(240, 21)
        Me.req_dept.TabIndex = 4
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(264, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 3
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(264, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        '
        'req_dept_nm
        '
        Me.req_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept_nm.Location = New System.Drawing.Point(761, 28)
        Me.req_dept_nm.Name = "req_dept_nm"
        Me.req_dept_nm.Size = New System.Drawing.Size(147, 21)
        Me.req_dept_nm.TabIndex = 4
        Me.req_dept_nm.TitleWidth = 0
        '
        'req_rid_nm
        '
        Me.req_rid_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid_nm.Location = New System.Drawing.Point(761, 52)
        Me.req_rid_nm.Name = "req_rid_nm"
        Me.req_rid_nm.Size = New System.Drawing.Size(147, 21)
        Me.req_rid_nm.TabIndex = 4
        Me.req_rid_nm.TitleWidth = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(940, 495)
        Me.SplitContainer2.SplitterDistance = 333
        Me.SplitContainer2.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(940, 333)
        Me.g10.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g30)
        Me.SplitContainer3.Size = New System.Drawing.Size(940, 158)
        Me.SplitContainer3.SplitterDistance = 554
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.spc_dt)
        Me.EPanel2.Controls.Add(Me.req_dsc)
        Me.EPanel2.Controls.Add(Me.dept_nm)
        Me.EPanel2.Controls.Add(Me.spc_dsc)
        Me.EPanel2.Controls.Add(Me.spc_bc)
        Me.EPanel2.Controls.Add(Me.spc_rid)
        Me.EPanel2.Controls.Add(Me.no_bc)
        Me.EPanel2.Controls.Add(Me.nm)
        Me.EPanel2.Controls.Add(Me.spc_dept)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.IconVisible = False
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.ShowCaption = False
        Me.EPanel2.Size = New System.Drawing.Size(554, 158)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "EPanel2"
        '
        'spc_dt
        '
        Me.spc_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dt.Location = New System.Drawing.Point(8, 9)
        Me.spc_dt.Name = "spc_dt"
        Me.spc_dt.Size = New System.Drawing.Size(240, 21)
        Me.spc_dt.TabIndex = 1
        Me.spc_dt.Title = "spc_dt"
        '
        'req_dsc
        '
        Me.req_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dsc.Location = New System.Drawing.Point(8, 81)
        Me.req_dsc.Name = "req_dsc"
        Me.req_dsc.Size = New System.Drawing.Size(536, 32)
        Me.req_dsc.TabIndex = 0
        Me.req_dsc.Title = "req_dsc"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(264, 57)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 3
        Me.dept_nm.Title = "dept_nm"
        '
        'spc_dsc
        '
        Me.spc_dsc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.spc_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dsc.Location = New System.Drawing.Point(8, 117)
        Me.spc_dsc.Name = "spc_dsc"
        Me.spc_dsc.Size = New System.Drawing.Size(536, 35)
        Me.spc_dsc.TabIndex = 0
        Me.spc_dsc.Title = "spc_dsc"
        '
        'spc_bc
        '
        Me.spc_bc.Location = New System.Drawing.Point(8, 33)
        Me.spc_bc.Name = "spc_bc"
        Me.spc_bc.Size = New System.Drawing.Size(240, 21)
        Me.spc_bc.TabIndex = 2
        Me.spc_bc.Title = "spc_bc"
        '
        'spc_rid
        '
        Me.spc_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_rid.Location = New System.Drawing.Point(428, 5)
        Me.spc_rid.Name = "spc_rid"
        Me.spc_rid.Size = New System.Drawing.Size(60, 21)
        Me.spc_rid.TabIndex = 3
        Me.spc_rid.Title = "spc_rid"
        '
        'no_bc
        '
        Me.no_bc.Location = New System.Drawing.Point(8, 57)
        Me.no_bc.Name = "no_bc"
        Me.no_bc.Size = New System.Drawing.Size(240, 21)
        Me.no_bc.TabIndex = 2
        Me.no_bc.Title = "no_bc"
        '
        'nm
        '
        Me.nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm.Location = New System.Drawing.Point(264, 33)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(240, 21)
        Me.nm.TabIndex = 3
        Me.nm.Title = "nm"
        '
        'spc_dept
        '
        Me.spc_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dept.Location = New System.Drawing.Point(376, 5)
        Me.spc_dept.Name = "spc_dept"
        Me.spc_dept.Size = New System.Drawing.Size(40, 21)
        Me.spc_dept.TabIndex = 3
        Me.spc_dept.Title = "spc_dept"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(382, 158)
        Me.g30.TabIndex = 4
        '
        'QMS110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMS110"
        Me.Size = New System.Drawing.Size(1021, 650)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents req_dept As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents req_rid As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents req_dept_nm As Frame7.eText
    Friend WithEvents req_rid_nm As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents spc_rid As Frame7.eText
    Friend WithEvents spc_dept As Frame7.eText
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents no_bc As Frame7.eCombo
    Friend WithEvents spc_bc As Frame7.eCombo
    Friend WithEvents spc_dt As Frame7.eDate
    Friend WithEvents spc_dsc As Frame7.eMemo
    Friend WithEvents req_dsc As Frame7.eMemo
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel

End Class
