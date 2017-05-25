<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMA200
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.f_fac_cd = New Frame7.eCombo()
        Me.f_dept_cd = New Frame7.eText()
        Me.f_dept_nm = New Frame7.eText()
        Me.f_fa_bc = New Frame7.eCombo()
        Me.f_fa_nm = New Frame7.eText()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.f_fa_no = New Frame7.eText()
        Me.f_stat_bc = New Frame7.eCheckCombo()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_fac_cd)
        Me.EPanel1.Controls.Add(Me.f_dept_cd)
        Me.EPanel1.Controls.Add(Me.f_dept_nm)
        Me.EPanel1.Controls.Add(Me.f_fa_bc)
        Me.EPanel1.Controls.Add(Me.f_fa_nm)
        Me.EPanel1.Controls.Add(Me.f_fa_no)
        Me.EPanel1.Controls.Add(Me.f_stat_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 86)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     조회조건"
        '
        'f_fac_cd
        '
        Me.f_fac_cd.Location = New System.Drawing.Point(6, 27)
        Me.f_fac_cd.Name = "f_fac_cd"
        Me.f_fac_cd.Size = New System.Drawing.Size(191, 21)
        Me.f_fac_cd.TabIndex = 2
        Me.f_fac_cd.Title = "공장"
        Me.f_fac_cd.TitleWidth = 80
        '
        'f_dept_cd
        '
        Me.f_dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_dept_cd.Location = New System.Drawing.Point(6, 54)
        Me.f_dept_cd.Name = "f_dept_cd"
        Me.f_dept_cd.Size = New System.Drawing.Size(191, 21)
        Me.f_dept_cd.TabIndex = 83
        Me.f_dept_cd.Title = "부서"
        Me.f_dept_cd.TitleWidth = 80
        '
        'f_dept_nm
        '
        Me.f_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_dept_nm.Location = New System.Drawing.Point(203, 54)
        Me.f_dept_nm.Name = "f_dept_nm"
        Me.f_dept_nm.Size = New System.Drawing.Size(216, 21)
        Me.f_dept_nm.TabIndex = 84
        Me.f_dept_nm.Title = "부서명"
        Me.f_dept_nm.TitleWidth = 0
        '
        'f_fa_bc
        '
        Me.f_fa_bc.Location = New System.Drawing.Point(234, 26)
        Me.f_fa_bc.Name = "f_fa_bc"
        Me.f_fa_bc.Size = New System.Drawing.Size(185, 21)
        Me.f_fa_bc.TabIndex = 85
        Me.f_fa_bc.Title = "설비구분"
        Me.f_fa_bc.TitleWidth = 80
        '
        'f_fa_nm
        '
        Me.f_fa_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_fa_nm.Location = New System.Drawing.Point(447, 27)
        Me.f_fa_nm.Name = "f_fa_nm"
        Me.f_fa_nm.Size = New System.Drawing.Size(261, 21)
        Me.f_fa_nm.TabIndex = 3
        Me.f_fa_nm.Title = "설비명(%)"
        Me.f_fa_nm.TitleWidth = 80
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 86)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 604)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 274)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     설비 등록 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 249)
        Me.g10.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1000, 326)
        Me.SplitContainer2.SplitterDistance = 542
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(542, 326)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     설비 점검 내역 등록 및 조회"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(538, 301)
        Me.g20.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g30)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(454, 326)
        Me.EPanel4.TabIndex = 2
        Me.EPanel4.Text = "     관련문서첨부"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(450, 301)
        Me.g30.TabIndex = 2
        '
        'f_fa_no
        '
        Me.f_fa_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_fa_no.Location = New System.Drawing.Point(447, 54)
        Me.f_fa_no.Name = "f_fa_no"
        Me.f_fa_no.Size = New System.Drawing.Size(261, 21)
        Me.f_fa_no.TabIndex = 3
        Me.f_fa_no.Title = "설비번호(%)"
        Me.f_fa_no.TitleWidth = 80
        '
        'f_stat_bc
        '
        Me.f_stat_bc.Location = New System.Drawing.Point(740, 27)
        Me.f_stat_bc.Name = "f_stat_bc"
        Me.f_stat_bc.Size = New System.Drawing.Size(178, 21)
        Me.f_stat_bc.TabIndex = 86
        Me.f_stat_bc.Title = "설비상태"
        Me.f_stat_bc.TitleWidth = 80
        '
        'FMA200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "FMA200"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents f_fa_nm As Frame7.eText
    Friend WithEvents f_fac_cd As Frame7.eCombo
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f_dept_nm As Frame7.eText
    Friend WithEvents f_dept_cd As Frame7.eText
    Friend WithEvents f_fa_bc As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents f_fa_no As Frame7.eText
    Friend WithEvents f_stat_bc As Frame7.eCheckCombo

End Class
