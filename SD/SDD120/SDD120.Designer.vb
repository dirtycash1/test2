<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDD120
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
        Me.cury_bc = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.out_bc = New Frame7.eCheckCombo()
        Me.wh_cd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.bs_cd = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.de_bc = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.chk_notin = New Frame7.eCheck()
        Me.dept_cd = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 516)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.out_bc)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.btn_jump)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.de_bc)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.chk_notin)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(956, 152)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(532, 76)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 66
        Me.cury_bc.Title = "통화"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(516, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(256, 21)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(272, 76)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 61
        Me.fac_cd.Title = "출하공장"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 33
        Me.fr_dt.Title = "출고일자"
        '
        'out_bc
        '
        Me.out_bc.Location = New System.Drawing.Point(12, 76)
        Me.out_bc.Name = "out_bc"
        Me.out_bc.Size = New System.Drawing.Size(240, 21)
        Me.out_bc.TabIndex = 67
        Me.out_bc.Title = "out_bc"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(272, 100)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 61
        Me.wh_cd.Title = "wh_cd"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(272, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.Title = "거래처"
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(652, 124)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(120, 24)
        Me.btn_jump.TabIndex = 64
        Me.btn_jump.Text = "가공비 매출처리"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(272, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 61
        Me.bs_cd.Title = "출하사업장"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 36
        Me.to_dt.Title = "부터"
        Me.to_dt.TitleWidth = 0
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(532, 52)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 21)
        Me.de_bc.TabIndex = 66
        Me.de_bc.Title = "de_bc"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(532, 100)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 35
        Me.dept_nm.Title = "dept_nm"
        '
        'chk_notin
        '
        Me.chk_notin.Caption = ""
        Me.chk_notin.Location = New System.Drawing.Point(272, 124)
        Me.chk_notin.Name = "chk_notin"
        Me.chk_notin.Size = New System.Drawing.Size(172, 21)
        Me.chk_notin.TabIndex = 56
        Me.chk_notin.Title = "미매출 조회"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(784, 100)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(156, 21)
        Me.dept_cd.TabIndex = 35
        Me.dept_cd.Title = "dept_cd"
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(12, 100)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 35
        Me.itm_cd.Title = "itm_cd"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(956, 360)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     출하 정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(952, 335)
        Me.g10.TabIndex = 2
        '
        'SDD120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDD120"
        Me.Size = New System.Drawing.Size(977, 563)
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
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents chk_notin As Frame7.eCheck
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents de_bc As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents out_bc As Frame7.eCheckCombo

End Class
