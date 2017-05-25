<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAN200
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
        Me.co_cd = New Frame7.eCombo()
        Me.bs_cd = New Frame7.eCombo()
        Me.bud_year = New Frame7.eDate()
        Me.mnm = New Frame7.eText()
        Me.merge_yn = New Frame7.eCheck()
        Me.mdt = New Frame7.eDate()
        Me.dept_cd = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.acc_nm = New Frame7.eText()
        Me.acc_cd = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Size = New System.Drawing.Size(996, 432)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.bud_year)
        Me.EPanel1.Controls.Add(Me.mnm)
        Me.EPanel1.Controls.Add(Me.merge_yn)
        Me.EPanel1.Controls.Add(Me.mdt)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.acc_nm)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(996, 105)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.CompuText = Nothing
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "법인"
        '
        'bs_cd
        '
        Me.bs_cd.CompuText = Nothing
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 3
        Me.bs_cd.Title = "사업장"
        '
        'bud_year
        '
        Me.bud_year.CompuText = Nothing
        Me.bud_year.Location = New System.Drawing.Point(12, 76)
        Me.bud_year.Name = "bud_year"
        Me.bud_year.Size = New System.Drawing.Size(240, 21)
        Me.bud_year.TabIndex = 5
        Me.bud_year.Title = "년도"
        '
        'mnm
        '
        Me.mnm.CompuText = Nothing
        Me.mnm.Location = New System.Drawing.Point(716, 52)
        Me.mnm.Name = "mnm"
        Me.mnm.Size = New System.Drawing.Size(240, 21)
        Me.mnm.TabIndex = 2
        Me.mnm.Title = "작성자"
        '
        'merge_yn
        '
        Me.merge_yn.Caption = ""
        Me.merge_yn.CompuText = Nothing
        Me.merge_yn.Location = New System.Drawing.Point(272, 28)
        Me.merge_yn.Name = "merge_yn"
        Me.merge_yn.Size = New System.Drawing.Size(168, 21)
        Me.merge_yn.TabIndex = 7
        Me.merge_yn.Title = "Cell 병합"
        '
        'mdt
        '
        Me.mdt.CompuText = Nothing
        Me.mdt.Location = New System.Drawing.Point(716, 76)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(240, 21)
        Me.mdt.TabIndex = 6
        Me.mdt.Title = "작성일자"
        '
        'dept_cd
        '
        Me.dept_cd.CompuText = Nothing
        Me.dept_cd.Location = New System.Drawing.Point(272, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 2
        Me.dept_cd.Title = "작성부서"
        '
        'dept_nm
        '
        Me.dept_nm.CompuText = Nothing
        Me.dept_nm.Location = New System.Drawing.Point(516, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(180, 21)
        Me.dept_nm.TabIndex = 4
        Me.dept_nm.Title = "부서명"
        Me.dept_nm.TitleWidth = 0
        '
        'acc_nm
        '
        Me.acc_nm.CompuText = Nothing
        Me.acc_nm.Location = New System.Drawing.Point(516, 76)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(180, 21)
        Me.acc_nm.TabIndex = 4
        Me.acc_nm.Title = "계정명"
        Me.acc_nm.TitleWidth = 0
        '
        'acc_cd
        '
        Me.acc_cd.CompuText = Nothing
        Me.acc_cd.Location = New System.Drawing.Point(272, 76)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd.TabIndex = 2
        Me.acc_cd.Title = "계정코드"
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer2.Size = New System.Drawing.Size(996, 323)
        Me.SplitContainer2.SplitterDistance = 206
        Me.SplitContainer2.TabIndex = 1
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 206)
        Me.g10.TabIndex = 0
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(996, 113)
        Me.g20.TabIndex = 0
        '
        'FAN200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAN200"
        Me.Size = New System.Drawing.Size(1034, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents bud_year As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents mdt As Frame7.eDate
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents mnm As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents merge_yn As Frame7.eCheck

End Class
