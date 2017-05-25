<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMR510
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
        Me.id = New Frame7.eText()
        Me.nm = New Frame7.eText()
        Me.rpt_t_dt = New Frame7.eDate()
        Me.prj_cd = New Frame7.eText()
        Me.prj_nm = New Frame7.eText()
        Me.rpt_f_dt = New Frame7.eDate()
        Me.prj_id = New Frame7.eText()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
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
        Me.EPanel1.Controls.Add(Me.id)
        Me.EPanel1.Controls.Add(Me.nm)
        Me.EPanel1.Controls.Add(Me.rpt_t_dt)
        Me.EPanel1.Controls.Add(Me.prj_cd)
        Me.EPanel1.Controls.Add(Me.prj_nm)
        Me.EPanel1.Controls.Add(Me.rpt_f_dt)
        Me.EPanel1.Controls.Add(Me.prj_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 76)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.id.Location = New System.Drawing.Point(263, 50)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(240, 21)
        Me.id.TabIndex = 7
        Me.id.Title = "보고자"
        '
        'nm
        '
        Me.nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm.Location = New System.Drawing.Point(386, 50)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(240, 21)
        Me.nm.TabIndex = 8
        Me.nm.Title = "보고자명"
        '
        'rpt_t_dt
        '
        Me.rpt_t_dt.Location = New System.Drawing.Point(5, 50)
        Me.rpt_t_dt.Name = "rpt_t_dt"
        Me.rpt_t_dt.Size = New System.Drawing.Size(240, 21)
        Me.rpt_t_dt.TabIndex = 6
        Me.rpt_t_dt.Title = "                          ~"
        '
        'prj_cd
        '
        Me.prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_cd.Location = New System.Drawing.Point(263, 26)
        Me.prj_cd.Name = "prj_cd"
        Me.prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.prj_cd.TabIndex = 3
        Me.prj_cd.Title = "프로젝트번호"
        '
        'prj_nm
        '
        Me.prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_nm.Location = New System.Drawing.Point(386, 26)
        Me.prj_nm.Name = "prj_nm"
        Me.prj_nm.Size = New System.Drawing.Size(240, 21)
        Me.prj_nm.TabIndex = 4
        Me.prj_nm.Title = "항목명(%)"
        '
        'rpt_f_dt
        '
        Me.rpt_f_dt.Location = New System.Drawing.Point(5, 26)
        Me.rpt_f_dt.Name = "rpt_f_dt"
        Me.rpt_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.rpt_f_dt.TabIndex = 5
        Me.rpt_f_dt.Title = "기간"
        '
        'prj_id
        '
        Me.prj_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_id.Location = New System.Drawing.Point(509, 26)
        Me.prj_id.Name = "prj_id"
        Me.prj_id.Size = New System.Drawing.Size(159, 21)
        Me.prj_id.TabIndex = 9
        Me.prj_id.Title = "prj_id"
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
        Me.SplitContainer1.SplitterDistance = 76
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1050, 556)
        Me.SplitContainer2.SplitterDistance = 499
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(499, 556)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     계획"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(495, 531)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(547, 556)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     실적"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(543, 531)
        Me.g20.TabIndex = 2
        '
        'PMR510
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMR510"
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
    Friend WithEvents prj_cd As Frame7.eText
    Friend WithEvents prj_nm As Frame7.eText
    Friend WithEvents id As Frame7.eText
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents rpt_t_dt As Frame7.eDate
    Friend WithEvents rpt_f_dt As Frame7.eDate
    Friend WithEvents prj_id As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid

End Class
