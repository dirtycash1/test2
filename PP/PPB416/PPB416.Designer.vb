<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPB416
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.out_rid = New Frame7.eText()
        Me.in_dept = New Frame7.eText()
        Me.out_dept = New Frame7.eText()
        Me.in_rid = New Frame7.eText()
        Me.EText1 = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.outr_no = New Frame7.eText()
        Me.out_nm = New Frame7.eText()
        Me.in_nm = New Frame7.eText()
        Me.out_dept_nm = New Frame7.eText()
        Me.in_dept_nm = New Frame7.eText()
        Me.outr_dt = New Frame7.eDate()
        Me.out_fac = New Frame7.eCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.wh_cd = New Frame7.eCombo()
        Me.out_wh = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.grp2_cd = New Frame7.eCombo()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1155, 553)
        Me.SplitContainer2.SplitterDistance = 104
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.out_rid)
        Me.EPanel1.Controls.Add(Me.in_dept)
        Me.EPanel1.Controls.Add(Me.out_dept)
        Me.EPanel1.Controls.Add(Me.in_rid)
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.outr_no)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.out_nm)
        Me.EPanel1.Controls.Add(Me.in_nm)
        Me.EPanel1.Controls.Add(Me.out_dept_nm)
        Me.EPanel1.Controls.Add(Me.in_dept_nm)
        Me.EPanel1.Controls.Add(Me.outr_dt)
        Me.EPanel1.Controls.Add(Me.out_fac)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.out_wh)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1155, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'out_rid
        '
        Me.out_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_rid.Location = New System.Drawing.Point(1001, 3)
        Me.out_rid.Name = "out_rid"
        Me.out_rid.Size = New System.Drawing.Size(56, 21)
        Me.out_rid.TabIndex = 47
        Me.out_rid.Title = "out_rid"
        Me.out_rid.Visible = False
        '
        'in_dept
        '
        Me.in_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_dept.Location = New System.Drawing.Point(815, 3)
        Me.in_dept.Name = "in_dept"
        Me.in_dept.Size = New System.Drawing.Size(76, 21)
        Me.in_dept.TabIndex = 48
        Me.in_dept.Title = "in_dept"
        Me.in_dept.Visible = False
        '
        'out_dept
        '
        Me.out_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_dept.Location = New System.Drawing.Point(937, 3)
        Me.out_dept.Name = "out_dept"
        Me.out_dept.Size = New System.Drawing.Size(76, 21)
        Me.out_dept.TabIndex = 48
        Me.out_dept.Title = "out_dept"
        Me.out_dept.Visible = False
        '
        'in_rid
        '
        Me.in_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_rid.Location = New System.Drawing.Point(772, 3)
        Me.in_rid.Name = "in_rid"
        Me.in_rid.Size = New System.Drawing.Size(56, 21)
        Me.in_rid.TabIndex = 46
        Me.in_rid.Title = "in_rid"
        Me.in_rid.Visible = False
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(844, 75)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(301, 21)
        Me.EText1.TabIndex = 49
        Me.EText1.Title = "재고조회시 공장 및 창고 선택 후 아래 품목 적용 하세요"
        Me.EText1.TitleWidth = 300
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(14, 51)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(216, 21)
        Me.bs_cd.TabIndex = 6
        Me.bs_cd.TitleWidth = 80
        '
        'outr_no
        '
        Me.outr_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.outr_no.Location = New System.Drawing.Point(14, 26)
        Me.outr_no.Name = "outr_no"
        Me.outr_no.Size = New System.Drawing.Size(216, 21)
        Me.outr_no.TabIndex = 8
        Me.outr_no.Title = "청구의뢰번호"
        Me.outr_no.TitleWidth = 80
        '
        'out_nm
        '
        Me.out_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_nm.Location = New System.Drawing.Point(715, 50)
        Me.out_nm.Name = "out_nm"
        Me.out_nm.Size = New System.Drawing.Size(205, 21)
        Me.out_nm.TabIndex = 44
        Me.out_nm.Title = "수신자"
        Me.out_nm.TitleWidth = 80
        '
        'in_nm
        '
        Me.in_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_nm.Location = New System.Drawing.Point(492, 50)
        Me.in_nm.Name = "in_nm"
        Me.in_nm.Size = New System.Drawing.Size(205, 21)
        Me.in_nm.TabIndex = 45
        Me.in_nm.Title = "의뢰자"
        Me.in_nm.TitleWidth = 80
        '
        'out_dept_nm
        '
        Me.out_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_dept_nm.Location = New System.Drawing.Point(715, 26)
        Me.out_dept_nm.Name = "out_dept_nm"
        Me.out_dept_nm.Size = New System.Drawing.Size(205, 21)
        Me.out_dept_nm.TabIndex = 42
        Me.out_dept_nm.Title = "수신부서"
        Me.out_dept_nm.TitleWidth = 80
        '
        'in_dept_nm
        '
        Me.in_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_dept_nm.Location = New System.Drawing.Point(492, 26)
        Me.in_dept_nm.Name = "in_dept_nm"
        Me.in_dept_nm.Size = New System.Drawing.Size(205, 21)
        Me.in_dept_nm.TabIndex = 43
        Me.in_dept_nm.Title = "의뢰부서"
        Me.in_dept_nm.TitleWidth = 80
        '
        'outr_dt
        '
        Me.outr_dt.Location = New System.Drawing.Point(492, 75)
        Me.outr_dt.Name = "outr_dt"
        Me.outr_dt.Size = New System.Drawing.Size(208, 21)
        Me.outr_dt.TabIndex = 3
        Me.outr_dt.TitleWidth = 80
        '
        'out_fac
        '
        Me.out_fac.Location = New System.Drawing.Point(937, 26)
        Me.out_fac.Name = "out_fac"
        Me.out_fac.Size = New System.Drawing.Size(208, 21)
        Me.out_fac.TabIndex = 5
        Me.out_fac.TitleWidth = 80
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(258, 26)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(208, 21)
        Me.fac_cd.TabIndex = 2
        Me.fac_cd.TitleWidth = 80
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(258, 51)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(208, 21)
        Me.wh_cd.TabIndex = 5
        Me.wh_cd.TitleWidth = 80
        '
        'out_wh
        '
        Me.out_wh.Location = New System.Drawing.Point(937, 50)
        Me.out_wh.Name = "out_wh"
        Me.out_wh.Size = New System.Drawing.Size(208, 21)
        Me.out_wh.TabIndex = 5
        Me.out_wh.TitleWidth = 80
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1155, 445)
        Me.g10.TabIndex = 4
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(14, 75)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(216, 21)
        Me.grp2_cd.TabIndex = 6
        Me.grp2_cd.TitleWidth = 80
        '
        'PPB416
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "PPB416"
        Me.Size = New System.Drawing.Size(1186, 662)
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents outr_no As Frame7.eText
    Friend WithEvents outr_dt As Frame7.eDate
    Friend WithEvents out_wh As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents out_nm As Frame7.eText
    Friend WithEvents in_nm As Frame7.eText
    Friend WithEvents out_dept_nm As Frame7.eText
    Friend WithEvents in_dept_nm As Frame7.eText
    Friend WithEvents out_rid As Frame7.eText
    Friend WithEvents out_dept As Frame7.eText
    Friend WithEvents in_rid As Frame7.eText
    Friend WithEvents in_dept As Frame7.eText
    Friend WithEvents out_fac As Frame7.eCombo
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents grp2_cd As Frame7.eCombo

End Class
