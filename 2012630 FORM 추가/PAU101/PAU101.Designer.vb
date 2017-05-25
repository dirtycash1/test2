<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAU101
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
        Me.ty3_chk = New Frame7.eCheck()
        Me.ty2_chk = New Frame7.eCheck()
        Me.ty1_chk = New Frame7.eCheck()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eText()
        Me.fr_mon = New Frame7.eDate()
        Me.dept_nm = New Frame7.eText()
        Me.to_mon = New Frame7.eDate()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ty3_chk)
        Me.EPanel1.Controls.Add(Me.ty2_chk)
        Me.EPanel1.Controls.Add(Me.ty1_chk)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.fr_mon)
        Me.EPanel1.Controls.Add(Me.to_mon)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1034, 105)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'ty3_chk
        '
        Me.ty3_chk.Caption = ""
        Me.ty3_chk.Checked = True
        Me.ty3_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ty3_chk.Location = New System.Drawing.Point(632, 76)
        Me.ty3_chk.Name = "ty3_chk"
        Me.ty3_chk.Size = New System.Drawing.Size(144, 21)
        Me.ty3_chk.TabIndex = 11
        Me.ty3_chk.Title = "총임금"
        '
        'ty2_chk
        '
        Me.ty2_chk.Caption = ""
        Me.ty2_chk.Checked = True
        Me.ty2_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ty2_chk.Location = New System.Drawing.Point(632, 52)
        Me.ty2_chk.Name = "ty2_chk"
        Me.ty2_chk.Size = New System.Drawing.Size(144, 21)
        Me.ty2_chk.TabIndex = 10
        Me.ty2_chk.Title = "평균임금"
        '
        'ty1_chk
        '
        Me.ty1_chk.Caption = ""
        Me.ty1_chk.Checked = True
        Me.ty1_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ty1_chk.Location = New System.Drawing.Point(632, 28)
        Me.ty1_chk.Name = "ty1_chk"
        Me.ty1_chk.Size = New System.Drawing.Size(144, 21)
        Me.ty1_chk.TabIndex = 9
        Me.ty1_chk.Title = "통상임금"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(256, 76)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 7
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(380, 76)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 8
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(256, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 2
        Me.bs_cd.Title = "사업장"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(256, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 5
        '
        'fr_mon
        '
        Me.fr_mon.Location = New System.Drawing.Point(8, 28)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(240, 21)
        Me.fr_mon.TabIndex = 3
        Me.fr_mon.Title = "지급년월"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(380, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 6
        '
        'to_mon
        '
        Me.to_mon.Location = New System.Drawing.Point(8, 52)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(240, 21)
        Me.to_mon.TabIndex = 4
        Me.to_mon.Title = "지급년월"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 636)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1034, 527)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     통상임금 및 평균임금 산출 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1030, 502)
        Me.g10.TabIndex = 2
        '
        'PAU101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAU101"
        Me.Size = New System.Drawing.Size(1034, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents to_mon As Frame7.eDate
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents ty3_chk As Frame7.eCheck
    Friend WithEvents ty2_chk As Frame7.eCheck
    Friend WithEvents ty1_chk As Frame7.eCheck
    Friend WithEvents g10 As Frame7.eGrid

End Class
