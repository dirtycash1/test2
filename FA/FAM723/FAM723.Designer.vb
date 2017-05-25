<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAM723
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.top_acc = New Frame7.eCombo()
        Me.bud_mon = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.bud_year = New Frame7.eText()
        Me.div_cd = New Frame7.eCombo()
        Me.bud_yearmm = New Frame7.eDate()
        Me.up_dept = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.Txt_chamt = New Frame7.eText()
        Me.g20 = New Frame7.eGrid()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.top_acc)
        Me.EPanel1.Controls.Add(Me.bud_mon)
        Me.EPanel1.Controls.Add(Me.bud_year)
        Me.EPanel1.Controls.Add(Me.bud_yearmm)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.up_dept)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 77)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'top_acc
        '
        Me.top_acc.Location = New System.Drawing.Point(267, 51)
        Me.top_acc.Name = "top_acc"
        Me.top_acc.Size = New System.Drawing.Size(240, 21)
        Me.top_acc.TabIndex = 13
        Me.top_acc.Title = "예산구분"
        '
        'bud_mon
        '
        Me.bud_mon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bud_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bud_mon.Location = New System.Drawing.Point(696, 51)
        Me.bud_mon.Name = "bud_mon"
        Me.bud_mon.Size = New System.Drawing.Size(166, 21)
        Me.bud_mon.TabIndex = 10
        Me.bud_mon.Title = "월"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(7, 51)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 7
        Me.co_cd.Title = "법인"
        '
        'bud_year
        '
        Me.bud_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bud_year.Location = New System.Drawing.Point(524, 51)
        Me.bud_year.Name = "bud_year"
        Me.bud_year.Size = New System.Drawing.Size(166, 21)
        Me.bud_year.TabIndex = 9
        Me.bud_year.Title = "년도"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(267, 27)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 8
        Me.div_cd.Title = "회계단위"
        '
        'bud_yearmm
        '
        Me.bud_yearmm.Format = "yyyy-MM"
        Me.bud_yearmm.Location = New System.Drawing.Point(7, 27)
        Me.bud_yearmm.Name = "bud_yearmm"
        Me.bud_yearmm.Size = New System.Drawing.Size(240, 21)
        Me.bud_yearmm.TabIndex = 6
        Me.bud_yearmm.Title = "기준년월"
        '
        'up_dept
        '
        Me.up_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.up_dept.Location = New System.Drawing.Point(524, 27)
        Me.up_dept.Name = "up_dept"
        Me.up_dept.Size = New System.Drawing.Size(240, 21)
        Me.up_dept.TabIndex = 3
        Me.up_dept.Title = "예산부서"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(649, 27)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 4
        Me.dept_nm.Title = "예산부서명"
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 1
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1050, 555)
        Me.SplitContainer2.SplitterDistance = 360
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 360)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     예산 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 335)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.Txt_chamt)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1050, 191)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     예산 분할 등록"
        '
        'Txt_chamt
        '
        Me.Txt_chamt.AccessibleDescription = ""
        Me.Txt_chamt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Txt_chamt.Location = New System.Drawing.Point(214, 1)
        Me.Txt_chamt.Name = "Txt_chamt"
        Me.Txt_chamt.Size = New System.Drawing.Size(251, 21)
        Me.Txt_chamt.TabIndex = 10
        Me.Txt_chamt.Title = "총 확정예산"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1046, 166)
        Me.g20.TabIndex = 2
        '
        'FAM723
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAM723"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents up_dept As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents bud_yearmm As Frame7.eDate
    Friend WithEvents bud_mon As Frame7.eText
    Friend WithEvents bud_year As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents Txt_chamt As Frame7.eText
    Friend WithEvents top_acc As Frame7.eCombo

End Class
