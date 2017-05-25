<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMS100
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
        Me.fr_dt = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.cust_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f10 = New Frame7.ePanel()
        Me.bad_id = New Frame7.eText()
        Me.spc_dept = New Frame7.eText()
        Me.spc_rid = New Frame7.eText()
        Me.req_dept = New Frame7.eText()
        Me.req_rid = New Frame7.eText()
        Me.spc_no = New Frame7.eText()
        Me.req_dt = New Frame7.eDate()
        Me.spc_dsc = New Frame7.eMemo()
        Me.req_dsc = New Frame7.eMemo()
        Me.spc_bc = New Frame7.eCombo()
        Me.req_qty = New Frame7.eText()
        Me.no_bc = New Frame7.eCombo()
        Me.spc_dt = New Frame7.eDate()
        Me.req_nm = New Frame7.eText()
        Me.spc_nm = New Frame7.eText()
        Me.req_dept_nm = New Frame7.eText()
        Me.spc_dept_nm = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
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
        CType(Me.f10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.f10.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 660)
        Me.SplitContainer1.SplitterDistance = 78
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 78)
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
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(268, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 3
        Me.fr_dt.Title = "fr_dt"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(528, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 5
        Me.cust_cd.Title = "cust_cd"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(268, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 4
        Me.to_dt.Title = "to_dt"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(770, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(180, 21)
        Me.cust_nm.TabIndex = 5
        Me.cust_nm.TitleWidth = 0
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1020, 578)
        Me.SplitContainer2.SplitterDistance = 349
        Me.SplitContainer2.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 349)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.f10)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(1020, 225)
        Me.SplitContainer3.SplitterDistance = 557
        Me.SplitContainer3.TabIndex = 0
        '
        'f10
        '
        Me.f10.Controls.Add(Me.bad_id)
        Me.f10.Controls.Add(Me.spc_dept)
        Me.f10.Controls.Add(Me.spc_rid)
        Me.f10.Controls.Add(Me.req_dept)
        Me.f10.Controls.Add(Me.req_rid)
        Me.f10.Controls.Add(Me.spc_no)
        Me.f10.Controls.Add(Me.req_dt)
        Me.f10.Controls.Add(Me.spc_dsc)
        Me.f10.Controls.Add(Me.req_dsc)
        Me.f10.Controls.Add(Me.spc_bc)
        Me.f10.Controls.Add(Me.req_qty)
        Me.f10.Controls.Add(Me.no_bc)
        Me.f10.Controls.Add(Me.spc_dt)
        Me.f10.Controls.Add(Me.req_nm)
        Me.f10.Controls.Add(Me.spc_nm)
        Me.f10.Controls.Add(Me.req_dept_nm)
        Me.f10.Controls.Add(Me.spc_dept_nm)
        Me.f10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.f10.IconVisible = False
        Me.f10.Location = New System.Drawing.Point(0, 0)
        Me.f10.Name = "f10"
        Me.f10.ShowCaption = False
        Me.f10.Size = New System.Drawing.Size(557, 225)
        Me.f10.TabIndex = 0
        Me.f10.Text = "EPanel2"
        '
        'bad_id
        '
        Me.bad_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bad_id.Location = New System.Drawing.Point(76, 204)
        Me.bad_id.Name = "bad_id"
        Me.bad_id.Size = New System.Drawing.Size(12, 21)
        Me.bad_id.TabIndex = 5
        Me.bad_id.Visible = False
        '
        'spc_dept
        '
        Me.spc_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dept.Location = New System.Drawing.Point(60, 204)
        Me.spc_dept.Name = "spc_dept"
        Me.spc_dept.Size = New System.Drawing.Size(12, 21)
        Me.spc_dept.TabIndex = 5
        Me.spc_dept.Visible = False
        '
        'spc_rid
        '
        Me.spc_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_rid.Location = New System.Drawing.Point(44, 204)
        Me.spc_rid.Name = "spc_rid"
        Me.spc_rid.Size = New System.Drawing.Size(12, 21)
        Me.spc_rid.TabIndex = 5
        Me.spc_rid.Visible = False
        '
        'req_dept
        '
        Me.req_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept.Location = New System.Drawing.Point(28, 204)
        Me.req_dept.Name = "req_dept"
        Me.req_dept.Size = New System.Drawing.Size(12, 21)
        Me.req_dept.TabIndex = 5
        Me.req_dept.Visible = False
        '
        'req_rid
        '
        Me.req_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid.Location = New System.Drawing.Point(12, 204)
        Me.req_rid.Name = "req_rid"
        Me.req_rid.Size = New System.Drawing.Size(12, 21)
        Me.req_rid.TabIndex = 5
        Me.req_rid.Visible = False
        '
        'spc_no
        '
        Me.spc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_no.Location = New System.Drawing.Point(8, 8)
        Me.spc_no.Name = "spc_no"
        Me.spc_no.Size = New System.Drawing.Size(240, 21)
        Me.spc_no.TabIndex = 5
        Me.spc_no.Title = "spc_no"
        '
        'req_dt
        '
        Me.req_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dt.Location = New System.Drawing.Point(8, 32)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 3
        Me.req_dt.Title = "req_dt"
        '
        'spc_dsc
        '
        Me.spc_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dsc.Location = New System.Drawing.Point(8, 176)
        Me.spc_dsc.Name = "spc_dsc"
        Me.spc_dsc.Size = New System.Drawing.Size(536, 44)
        Me.spc_dsc.TabIndex = 6
        Me.spc_dsc.Title = "spc_dsc"
        '
        'req_dsc
        '
        Me.req_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dsc.Location = New System.Drawing.Point(8, 128)
        Me.req_dsc.Name = "req_dsc"
        Me.req_dsc.Size = New System.Drawing.Size(536, 44)
        Me.req_dsc.TabIndex = 6
        Me.req_dsc.Title = "req_dsc"
        '
        'spc_bc
        '
        Me.spc_bc.Location = New System.Drawing.Point(268, 32)
        Me.spc_bc.Name = "spc_bc"
        Me.spc_bc.Size = New System.Drawing.Size(240, 21)
        Me.spc_bc.TabIndex = 2
        Me.spc_bc.Title = "spc_bc"
        '
        'req_qty
        '
        Me.req_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_qty.Location = New System.Drawing.Point(8, 56)
        Me.req_qty.Name = "req_qty"
        Me.req_qty.Size = New System.Drawing.Size(240, 21)
        Me.req_qty.TabIndex = 5
        Me.req_qty.Title = "req_qty"
        '
        'no_bc
        '
        Me.no_bc.Location = New System.Drawing.Point(268, 56)
        Me.no_bc.Name = "no_bc"
        Me.no_bc.Size = New System.Drawing.Size(240, 21)
        Me.no_bc.TabIndex = 2
        Me.no_bc.Title = "no_bc"
        '
        'spc_dt
        '
        Me.spc_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dt.Location = New System.Drawing.Point(268, 8)
        Me.spc_dt.Name = "spc_dt"
        Me.spc_dt.Size = New System.Drawing.Size(240, 21)
        Me.spc_dt.TabIndex = 3
        Me.spc_dt.Title = "spc_dt"
        '
        'req_nm
        '
        Me.req_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_nm.Location = New System.Drawing.Point(8, 80)
        Me.req_nm.Name = "req_nm"
        Me.req_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_nm.TabIndex = 5
        Me.req_nm.Title = "req_nm"
        '
        'spc_nm
        '
        Me.spc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_nm.Location = New System.Drawing.Point(268, 80)
        Me.spc_nm.Name = "spc_nm"
        Me.spc_nm.Size = New System.Drawing.Size(240, 21)
        Me.spc_nm.TabIndex = 5
        Me.spc_nm.Title = "spc_nm"
        '
        'req_dept_nm
        '
        Me.req_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept_nm.Location = New System.Drawing.Point(8, 104)
        Me.req_dept_nm.Name = "req_dept_nm"
        Me.req_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_dept_nm.TabIndex = 5
        Me.req_dept_nm.Title = "req_dept_nm"
        '
        'spc_dept_nm
        '
        Me.spc_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spc_dept_nm.Location = New System.Drawing.Point(268, 104)
        Me.spc_dept_nm.Name = "spc_dept_nm"
        Me.spc_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.spc_dept_nm.TabIndex = 5
        Me.spc_dept_nm.Title = "spc_dept_nm"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(459, 225)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(452, 195)
        Me.XtraTabPage1.Text = "불량내역"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(452, 195)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(452, 195)
        Me.XtraTabPage2.Text = "합의부서"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(452, 195)
        Me.g30.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g50)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(452, 195)
        Me.XtraTabPage3.Text = "첨부문서"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(452, 195)
        Me.g50.TabIndex = 1
        '
        'QMS100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMS100"
        Me.Size = New System.Drawing.Size(1034, 769)
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
        CType(Me.f10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.f10.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f10 As Frame7.ePanel
    Friend WithEvents spc_no As Frame7.eText
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents spc_bc As Frame7.eCombo
    Friend WithEvents req_qty As Frame7.eText
    Friend WithEvents no_bc As Frame7.eCombo
    Friend WithEvents spc_dt As Frame7.eDate
    Friend WithEvents req_nm As Frame7.eText
    Friend WithEvents spc_nm As Frame7.eText
    Friend WithEvents req_dept_nm As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents spc_dsc As Frame7.eMemo
    Friend WithEvents req_dsc As Frame7.eMemo
    Friend WithEvents spc_dept As Frame7.eText
    Friend WithEvents spc_rid As Frame7.eText
    Friend WithEvents req_dept As Frame7.eText
    Friend WithEvents req_rid As Frame7.eText
    Friend WithEvents spc_dept_nm As Frame7.eText
    Friend WithEvents bad_id As Frame7.eText
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid

End Class
