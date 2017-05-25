<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB101
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
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.po_dept_nm = New Frame7.eText()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.po_fac = New Frame7.eCombo()
        Me.dlv_t_dt = New Frame7.eDate()
        Me.po_dept = New Frame7.eText()
        Me.po_f_dt = New Frame7.eDate()
        Me.po_t_dt = New Frame7.eDate()
        Me.dlv_f_dt = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.po_no = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.po_bc = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.di_bc = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.grp1_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1049, 643)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.po_dept_nm)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.po_fac)
        Me.EPanel1.Controls.Add(Me.dlv_t_dt)
        Me.EPanel1.Controls.Add(Me.po_dept)
        Me.EPanel1.Controls.Add(Me.po_f_dt)
        Me.EPanel1.Controls.Add(Me.po_t_dt)
        Me.EPanel1.Controls.Add(Me.dlv_f_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.po_no)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.di_bc)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1049, 128)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(520, 28)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 73
        Me.stat_bc.Title = "stat_bc"
        '
        'po_dept_nm
        '
        Me.po_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept_nm.Location = New System.Drawing.Point(264, 52)
        Me.po_dept_nm.Name = "po_dept_nm"
        Me.po_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.po_dept_nm.TabIndex = 71
        Me.po_dept_nm.Title = "po_dept_nm"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(776, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 74
        Me.itm_bc.Title = "itm_bc"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(264, 28)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 70
        Me.po_fac.Title = "po_fac"
        '
        'dlv_t_dt
        '
        Me.dlv_t_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_t_dt.Location = New System.Drawing.Point(128, 100)
        Me.dlv_t_dt.Name = "dlv_t_dt"
        Me.dlv_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.dlv_t_dt.TabIndex = 65
        Me.dlv_t_dt.Title = "부터"
        Me.dlv_t_dt.TitleWidth = 0
        '
        'po_dept
        '
        Me.po_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_dept.Location = New System.Drawing.Point(12, 100)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(56, 21)
        Me.po_dept.TabIndex = 72
        Me.po_dept.Title = "po_dept"
        '
        'po_f_dt
        '
        Me.po_f_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_f_dt.Location = New System.Drawing.Point(8, 28)
        Me.po_f_dt.Name = "po_f_dt"
        Me.po_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.po_f_dt.TabIndex = 56
        Me.po_f_dt.Title = "발주일자"
        '
        'po_t_dt
        '
        Me.po_t_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_t_dt.Location = New System.Drawing.Point(128, 52)
        Me.po_t_dt.Name = "po_t_dt"
        Me.po_t_dt.Size = New System.Drawing.Size(120, 21)
        Me.po_t_dt.TabIndex = 58
        Me.po_t_dt.Title = "부터"
        Me.po_t_dt.TitleWidth = 0
        '
        'dlv_f_dt
        '
        Me.dlv_f_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_f_dt.Location = New System.Drawing.Point(8, 76)
        Me.dlv_f_dt.Name = "dlv_f_dt"
        Me.dlv_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_f_dt.TabIndex = 59
        Me.dlv_f_dt.Title = "납기일자"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(264, 100)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 57
        Me.cust_cd.Title = "거래처"
        '
        'po_no
        '
        Me.po_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.po_no.Location = New System.Drawing.Point(264, 76)
        Me.po_no.Name = "po_no"
        Me.po_no.Size = New System.Drawing.Size(240, 21)
        Me.po_no.TabIndex = 66
        Me.po_no.Title = "발주번호"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(508, 100)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 60
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(520, 52)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(240, 21)
        Me.po_bc.TabIndex = 63
        Me.po_bc.Title = "po_bc"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(776, 76)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 69
        Me.itm_cd.Title = "itm_cd"
        '
        'di_bc
        '
        Me.di_bc.Location = New System.Drawing.Point(520, 76)
        Me.di_bc.Name = "di_bc"
        Me.di_bc.Size = New System.Drawing.Size(240, 21)
        Me.di_bc.TabIndex = 62
        Me.di_bc.Title = "di_bc"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(776, 100)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 61
        Me.itm_nm.Title = "itm_nm"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(776, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 64
        Me.grp1_cd.Title = "대분류"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1049, 511)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     구매발주현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1045, 486)
        Me.g10.TabIndex = 2
        '
        'MMB101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB101"
        Me.Size = New System.Drawing.Size(1049, 643)
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
    Friend WithEvents stat_bc As Frame7.eCheckCombo
    Friend WithEvents po_dept_nm As Frame7.eText
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents dlv_t_dt As Frame7.eDate
    Friend WithEvents po_dept As Frame7.eText
    Friend WithEvents po_f_dt As Frame7.eDate
    Friend WithEvents po_t_dt As Frame7.eDate
    Friend WithEvents dlv_f_dt As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents po_no As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents po_bc As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents di_bc As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents grp1_cd As Frame7.eCombo

End Class
