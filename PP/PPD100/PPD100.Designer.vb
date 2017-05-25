<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPD100
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
        Me.itm_nm = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.week_dt = New Frame7.eText()
        Me.week = New Frame7.eText()
        Me.preq_nm = New Frame7.eText()
        Me.preq_dept_nm = New Frame7.eText()
        Me.preq_dept = New Frame7.eText()
        Me.preq_rid = New Frame7.eText()
        Me.preq_bs = New Frame7.eCheckCombo()
        Me.fld_cd = New Frame7.eText()
        Me.fld_nm = New Frame7.eText()
        Me.preq_year = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.g20 = New Frame7.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(970, 551)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.week_dt)
        Me.EPanel1.Controls.Add(Me.week)
        Me.EPanel1.Controls.Add(Me.preq_nm)
        Me.EPanel1.Controls.Add(Me.preq_dept_nm)
        Me.EPanel1.Controls.Add(Me.preq_dept)
        Me.EPanel1.Controls.Add(Me.preq_rid)
        Me.EPanel1.Controls.Add(Me.preq_bs)
        Me.EPanel1.Controls.Add(Me.fld_cd)
        Me.EPanel1.Controls.Add(Me.fld_nm)
        Me.EPanel1.Controls.Add(Me.preq_year)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(970, 106)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색조건"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(768, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 38
        Me.itm_nm.Title = "품목명(%)"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(500, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 37
        Me.itm_cd.Title = "품목코드(%)"
        '
        'week_dt
        '
        Me.week_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.week_dt.Location = New System.Drawing.Point(248, 52)
        Me.week_dt.Name = "week_dt"
        Me.week_dt.Size = New System.Drawing.Size(232, 21)
        Me.week_dt.TabIndex = 35
        Me.week_dt.Title = "주차"
        Me.week_dt.TitleWidth = 0
        '
        'week
        '
        Me.week.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.week.Location = New System.Drawing.Point(192, 52)
        Me.week.Name = "week"
        Me.week.Size = New System.Drawing.Size(56, 21)
        Me.week.TabIndex = 34
        Me.week.Title = "주차"
        Me.week.TitleWidth = 0
        '
        'preq_nm
        '
        Me.preq_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.preq_nm.Location = New System.Drawing.Point(500, 28)
        Me.preq_nm.Name = "preq_nm"
        Me.preq_nm.Size = New System.Drawing.Size(240, 21)
        Me.preq_nm.TabIndex = 33
        Me.preq_nm.Title = "담당자"
        '
        'preq_dept_nm
        '
        Me.preq_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.preq_dept_nm.Location = New System.Drawing.Point(768, 28)
        Me.preq_dept_nm.Name = "preq_dept_nm"
        Me.preq_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.preq_dept_nm.TabIndex = 32
        Me.preq_dept_nm.Title = "부서명"
        '
        'preq_dept
        '
        Me.preq_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.preq_dept.Location = New System.Drawing.Point(500, 28)
        Me.preq_dept.Name = "preq_dept"
        Me.preq_dept.Size = New System.Drawing.Size(240, 21)
        Me.preq_dept.TabIndex = 31
        Me.preq_dept.Title = "담당자"
        '
        'preq_rid
        '
        Me.preq_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.preq_rid.Location = New System.Drawing.Point(768, 28)
        Me.preq_rid.Name = "preq_rid"
        Me.preq_rid.Size = New System.Drawing.Size(240, 21)
        Me.preq_rid.TabIndex = 30
        Me.preq_rid.Title = "부서코드"
        '
        'preq_bs
        '
        Me.preq_bs.Location = New System.Drawing.Point(8, 28)
        Me.preq_bs.Name = "preq_bs"
        Me.preq_bs.Size = New System.Drawing.Size(244, 21)
        Me.preq_bs.TabIndex = 0
        Me.preq_bs.Title = "매출사업장"
        '
        'fld_cd
        '
        Me.fld_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fld_cd.Location = New System.Drawing.Point(8, 76)
        Me.fld_cd.Name = "fld_cd"
        Me.fld_cd.Size = New System.Drawing.Size(240, 21)
        Me.fld_cd.TabIndex = 24
        Me.fld_cd.Title = "현장"
        '
        'fld_nm
        '
        Me.fld_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fld_nm.Location = New System.Drawing.Point(128, 76)
        Me.fld_nm.Name = "fld_nm"
        Me.fld_nm.Size = New System.Drawing.Size(352, 21)
        Me.fld_nm.TabIndex = 26
        Me.fld_nm.Title = "현장명"
        '
        'preq_year
        '
        Me.preq_year.Format = "yyyy"
        Me.preq_year.Location = New System.Drawing.Point(8, 52)
        Me.preq_year.Name = "preq_year"
        Me.preq_year.Size = New System.Drawing.Size(180, 21)
        Me.preq_year.TabIndex = 22
        Me.preq_year.Title = "요청주차"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(970, 441)
        Me.SplitContainer2.SplitterDistance = 203
        Me.SplitContainer2.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(970, 203)
        Me.g10.TabIndex = 5
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.g20)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g30)
        Me.SplitContainer3.Size = New System.Drawing.Size(970, 234)
        Me.SplitContainer3.SplitterDistance = 236
        Me.SplitContainer3.TabIndex = 0
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(236, 234)
        Me.g20.TabIndex = 3
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(730, 234)
        Me.g30.TabIndex = 3
        '
        'PPD100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PPD100"
        Me.Size = New System.Drawing.Size(970, 551)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents week_dt As Frame7.eText
    Friend WithEvents week As Frame7.eText
    Friend WithEvents preq_nm As Frame7.eText
    Friend WithEvents preq_dept_nm As Frame7.eText
    Friend WithEvents preq_dept As Frame7.eText
    Friend WithEvents preq_rid As Frame7.eText
    Friend WithEvents preq_bs As Frame7.eCheckCombo
    Friend WithEvents fld_cd As Frame7.eText
    Friend WithEvents fld_nm As Frame7.eText
    Friend WithEvents preq_year As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g10 As Frame7.eGrid

End Class
