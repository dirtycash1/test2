<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMT110
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f_temp_nm = New Frame7.eText()
        Me.f_prj_bc = New Frame7.eCheckCombo()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.temp_cd = New Frame7.eText()
        Me.temp_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.step_no = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 581)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(322, 581)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_temp_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_bc)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(318, 556)
        Me.SplitContainer3.SplitterDistance = 62
        Me.SplitContainer3.TabIndex = 2
        '
        'f_temp_nm
        '
        Me.f_temp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_temp_nm.Location = New System.Drawing.Point(8, 8)
        Me.f_temp_nm.Name = "f_temp_nm"
        Me.f_temp_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_temp_nm.TabIndex = 1
        Me.f_temp_nm.Title = "Templete 명"
        '
        'f_prj_bc
        '
        Me.f_prj_bc.Location = New System.Drawing.Point(8, 32)
        Me.f_prj_bc.Name = "f_prj_bc"
        Me.f_prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_bc.TabIndex = 3
        Me.f_prj_bc.Title = "Project 구분"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(318, 490)
        Me.g10.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(908, 581)
        Me.SplitContainer2.SplitterDistance = 85
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.temp_cd)
        Me.EPanel3.Controls.Add(Me.temp_nm)
        Me.EPanel3.Controls.Add(Me.step_no)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(908, 85)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Templete 조회"
        '
        'temp_cd
        '
        Me.temp_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.temp_cd.Location = New System.Drawing.Point(8, 28)
        Me.temp_cd.Name = "temp_cd"
        Me.temp_cd.Size = New System.Drawing.Size(240, 21)
        Me.temp_cd.TabIndex = 2
        Me.temp_cd.Title = "Templete 코드"
        '
        'temp_nm
        '
        Me.temp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.temp_nm.Location = New System.Drawing.Point(136, 28)
        Me.temp_nm.Name = "temp_nm"
        Me.temp_nm.Size = New System.Drawing.Size(348, 21)
        Me.temp_nm.TabIndex = 3
        Me.temp_nm.Title = "templete 코드"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(908, 492)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     Templete 단계별 점검항목 등록"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(904, 467)
        Me.g20.TabIndex = 2
        '
        'step_no
        '
        Me.step_no.Location = New System.Drawing.Point(8, 52)
        Me.step_no.Name = "step_no"
        Me.step_no.Size = New System.Drawing.Size(476, 21)
        Me.step_no.TabIndex = 4
        '
        'PMT110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMT110"
        Me.Size = New System.Drawing.Size(1234, 581)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_prj_bc As Frame7.eCheckCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f_temp_nm As Frame7.eText
    Friend WithEvents temp_cd As Frame7.eText
    Friend WithEvents temp_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents step_no As Frame7.eCombo

End Class
