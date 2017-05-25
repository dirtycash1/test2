<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAD105
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
        Me.bs_cd = New Frame7.eCombo()
        Me.EPanel1 = New Frame7.ePanel()
        Me.sub_yn = New Frame7.eCheck()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.btn_show = New DevExpress.XtraEditors.SimpleButton()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.work_bc = New Frame7.eCombo()
        Me.pnlshow = New Frame7.ePanel()
        Me.work_kd = New Frame7.eCombo()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.pnlshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlshow.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 2
        Me.bs_cd.Title = "사업장"
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.sub_yn)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.btn_show)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.work_bc)
        Me.EPanel1.Controls.Add(Me.pnlshow)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 128)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'sub_yn
        '
        Me.sub_yn.Caption = ""
        Me.sub_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sub_yn.Location = New System.Drawing.Point(612, 52)
        Me.sub_yn.Name = "sub_yn"
        Me.sub_yn.Size = New System.Drawing.Size(146, 21)
        Me.sub_yn.TabIndex = 70
        Me.sub_yn.Title = "하위부서포함"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(264, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 67
        Me.emp_no.Title = "사원"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(264, 76)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 69
        Me.emp_nm.Title = "성명"
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(508, 52)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(59, 21)
        Me.btn_show.TabIndex = 74
        Me.btn_show.Text = "유형"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(264, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 66
        Me.dept_cd.Title = "부서"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(508, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 68
        Me.dept_nm.TitleWidth = 0
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 13
        Me.co_cd.Title = "법인"
        '
        'work_bc
        '
        Me.work_bc.Location = New System.Drawing.Point(264, 100)
        Me.work_bc.Name = "work_bc"
        Me.work_bc.Size = New System.Drawing.Size(240, 21)
        Me.work_bc.TabIndex = 9
        Me.work_bc.Title = "근무직구분"
        '
        'pnlshow
        '
        Me.pnlshow.Controls.Add(Me.work_kd)
        Me.pnlshow.Location = New System.Drawing.Point(508, 74)
        Me.pnlshow.Name = "pnlshow"
        Me.pnlshow.Size = New System.Drawing.Size(240, 47)
        Me.pnlshow.TabIndex = 75
        Me.pnlshow.Text = "     근무직유형"
        Me.pnlshow.Visible = False
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(91, 2)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(147, 21)
        Me.work_kd.TabIndex = 60
        Me.work_kd.Title = ""
        Me.work_kd.TitleWidth = 1
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 504)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     상세정보등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 479)
        Me.g10.TabIndex = 2
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 74)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 76
        Me.fr_dt.Title = "기간"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(12, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 77
        Me.to_dt.Title = "~"
        '
        'GAD105
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GAD105"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.pnlshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlshow.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents work_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents sub_yn As Frame7.eCheck
    Friend WithEvents btn_show As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents pnlshow As Frame7.ePanel
    Friend WithEvents work_kd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
End Class
