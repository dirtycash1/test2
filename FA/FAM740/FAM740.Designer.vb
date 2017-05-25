<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAM740
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.o_bud_year = New Frame7.eDate()
        Me.o_co_cd = New Frame7.eCombo()
        Me.o_div_cd = New Frame7.eCombo()
        Me.o_dept_nm = New Frame7.eText()
        Me.o_dept_cd = New Frame7.eText()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.bud_year = New Frame7.eDate()
        Me.chg_dt = New Frame7.eDate()
        Me.div_cd = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.o_fr_dt = New Frame7.eDate()
        Me.o_to_dt = New Frame7.eDate()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 690)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 196)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(254, 494)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     예산신청 등록 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(250, 469)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_fr_dt)
        Me.EPanel1.Controls.Add(Me.o_bud_year)
        Me.EPanel1.Controls.Add(Me.o_to_dt)
        Me.EPanel1.Controls.Add(Me.o_co_cd)
        Me.EPanel1.Controls.Add(Me.o_div_cd)
        Me.EPanel1.Controls.Add(Me.o_dept_nm)
        Me.EPanel1.Controls.Add(Me.o_dept_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(254, 196)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'o_bud_year
        '
        Me.o_bud_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_bud_year.Format = "yyyy"
        Me.o_bud_year.Location = New System.Drawing.Point(6, 27)
        Me.o_bud_year.Name = "o_bud_year"
        Me.o_bud_year.Size = New System.Drawing.Size(240, 21)
        Me.o_bud_year.TabIndex = 6
        Me.o_bud_year.Title = "예산년도"
        '
        'o_co_cd
        '
        Me.o_co_cd.Location = New System.Drawing.Point(6, 55)
        Me.o_co_cd.Name = "o_co_cd"
        Me.o_co_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_co_cd.TabIndex = 5
        Me.o_co_cd.Title = "법인"
        '
        'o_div_cd
        '
        Me.o_div_cd.Location = New System.Drawing.Point(6, 83)
        Me.o_div_cd.Name = "o_div_cd"
        Me.o_div_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_div_cd.TabIndex = 4
        Me.o_div_cd.Title = "회계단위"
        '
        'o_dept_nm
        '
        Me.o_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_dept_nm.Location = New System.Drawing.Point(6, 110)
        Me.o_dept_nm.Name = "o_dept_nm"
        Me.o_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.o_dept_nm.TabIndex = 3
        Me.o_dept_nm.Title = "예산부서"
        '
        'o_dept_cd
        '
        Me.o_dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_dept_cd.Location = New System.Drawing.Point(252, 110)
        Me.o_dept_cd.Name = "o_dept_cd"
        Me.o_dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_dept_cd.TabIndex = 3
        Me.o_dept_cd.Title = "예산부서코드"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 110)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(818, 580)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     예산변경 등록/조회"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(814, 555)
        Me.g20.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.chg_dt)
        Me.EPanel3.Controls.Add(Me.bud_year)
        Me.EPanel3.Controls.Add(Me.div_cd)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.dept_cd)
        Me.EPanel3.Controls.Add(Me.co_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(818, 110)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     예산신청 등록/조회"
        '
        'bud_year
        '
        Me.bud_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bud_year.Format = "yyyy"
        Me.bud_year.Location = New System.Drawing.Point(6, 28)
        Me.bud_year.Name = "bud_year"
        Me.bud_year.Size = New System.Drawing.Size(240, 21)
        Me.bud_year.TabIndex = 7
        Me.bud_year.Title = "예산년도"
        '
        'chg_dt
        '
        Me.chg_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chg_dt.Location = New System.Drawing.Point(281, 55)
        Me.chg_dt.Name = "chg_dt"
        Me.chg_dt.Size = New System.Drawing.Size(240, 21)
        Me.chg_dt.TabIndex = 6
        Me.chg_dt.Title = "예산변경일"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(6, 81)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 3
        Me.div_cd.Title = "회계단위"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(281, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 5
        Me.dept_nm.Title = "예산부서"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(6, 55)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "법인"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(527, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(115, 21)
        Me.dept_cd.TabIndex = 5
        Me.dept_cd.Title = "예산부서코드"
        Me.dept_cd.TitleWidth = 0
        '
        'o_fr_dt
        '
        Me.o_fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_fr_dt.Location = New System.Drawing.Point(6, 138)
        Me.o_fr_dt.Name = "o_fr_dt"
        Me.o_fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_fr_dt.TabIndex = 7
        Me.o_fr_dt.Title = "변경기간"
        '
        'o_to_dt
        '
        Me.o_to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_to_dt.Location = New System.Drawing.Point(6, 165)
        Me.o_to_dt.Name = "o_to_dt"
        Me.o_to_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_to_dt.TabIndex = 7
        Me.o_to_dt.Title = ""
        '
        'FAM740
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAM740"
        Me.Size = New System.Drawing.Size(1076, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_co_cd As Frame7.eCombo
    Friend WithEvents o_div_cd As Frame7.eCombo
    Friend WithEvents o_dept_nm As Frame7.eText
    Friend WithEvents o_dept_cd As Frame7.eText
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents chg_dt As Frame7.eDate
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents o_bud_year As Frame7.eDate
    Friend WithEvents bud_year As Frame7.eDate
    Friend WithEvents o_fr_dt As Frame7.eDate
    Friend WithEvents o_to_dt As Frame7.eDate

End Class
