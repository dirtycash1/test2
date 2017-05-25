<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMA320
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
        Me.o_mc_nm = New Frame7.eText()
        Me.o_fac_cd = New Frame7.eCombo()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.o_dept_nm = New Frame7.eText()
        Me.o_dept_cd = New Frame7.eText()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_dept_nm)
        Me.EPanel1.Controls.Add(Me.o_dept_cd)
        Me.EPanel1.Controls.Add(Me.o_mc_nm)
        Me.EPanel1.Controls.Add(Me.o_fac_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 112)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     조회조건"
        '
        'o_mc_nm
        '
        Me.o_mc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_mc_nm.Location = New System.Drawing.Point(6, 82)
        Me.o_mc_nm.Name = "o_mc_nm"
        Me.o_mc_nm.Size = New System.Drawing.Size(370, 21)
        Me.o_mc_nm.TabIndex = 3
        Me.o_mc_nm.Title = "계측기명"
        '
        'o_fac_cd
        '
        Me.o_fac_cd.Location = New System.Drawing.Point(6, 27)
        Me.o_fac_cd.Name = "o_fac_cd"
        Me.o_fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_fac_cd.TabIndex = 2
        Me.o_fac_cd.Title = "공장"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 112)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 578)
        Me.SplitContainer1.SplitterDistance = 289
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 289)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     계측기 등록현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 264)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1000, 285)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     계측기 이상발생 등록 및 조회"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(996, 260)
        Me.g20.TabIndex = 2
        '
        'o_dept_nm
        '
        Me.o_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_dept_nm.Location = New System.Drawing.Point(251, 55)
        Me.o_dept_nm.Name = "o_dept_nm"
        Me.o_dept_nm.Size = New System.Drawing.Size(125, 21)
        Me.o_dept_nm.TabIndex = 84
        Me.o_dept_nm.Title = "부서명"
        Me.o_dept_nm.TitleWidth = 0
        '
        'o_dept_cd
        '
        Me.o_dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_dept_cd.Location = New System.Drawing.Point(6, 55)
        Me.o_dept_cd.Name = "o_dept_cd"
        Me.o_dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_dept_cd.TabIndex = 83
        Me.o_dept_cd.Title = "부서"
        '
        'QMA320
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "QMA320"
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
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_mc_nm As Frame7.eText
    Friend WithEvents o_fac_cd As Frame7.eCombo
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents o_dept_nm As Frame7.eText
    Friend WithEvents o_dept_cd As Frame7.eText

End Class
