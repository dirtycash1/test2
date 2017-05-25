<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRM200
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
        Me.app_year = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.btn_all = New DevExpress.XtraEditors.SimpleButton()
        Me.dept_cd = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.btn_chk = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(972, 556)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.app_year)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.btn_all)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(972, 79)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'app_year
        '
        Me.app_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.app_year.Format = "yyyy"
        Me.app_year.Location = New System.Drawing.Point(12, 28)
        Me.app_year.Name = "app_year"
        Me.app_year.Size = New System.Drawing.Size(240, 21)
        Me.app_year.TabIndex = 3
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 52)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(756, 51)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(100, 23)
        Me.btn_all.TabIndex = 5
        Me.btn_all.Text = "전체집계"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(272, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 4
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(272, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 4
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(514, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(160, 21)
        Me.dept_nm.TabIndex = 4
        Me.dept_nm.TitleWidth = 0
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(514, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(160, 21)
        Me.emp_nm.TabIndex = 4
        Me.emp_nm.TitleWidth = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(972, 473)
        Me.SplitContainer2.SplitterDistance = 228
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(972, 228)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     공제 가족정보 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(968, 203)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(972, 241)
        Me.SplitContainer3.SplitterDistance = 35
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.btn_chk)
        Me.EPanel3.Controls.Add(Me.btn_save)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.IconVisible = False
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.ShowCaption = False
        Me.EPanel3.Size = New System.Drawing.Size(972, 35)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "EPanel3"
        '
        'btn_chk
        '
        Me.btn_chk.Location = New System.Drawing.Point(640, 6)
        Me.btn_chk.Name = "btn_chk"
        Me.btn_chk.Size = New System.Drawing.Size(100, 23)
        Me.btn_chk.TabIndex = 5
        Me.btn_chk.Text = "주민번호체크"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(756, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(100, 23)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "저장"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(972, 202)
        Me.g20.TabIndex = 0
        '
        'HRM200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "HRM200"
        Me.Size = New System.Drawing.Size(1020, 581)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents app_year As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents btn_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents btn_chk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid

End Class
