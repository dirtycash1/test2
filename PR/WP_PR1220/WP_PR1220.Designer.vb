﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1220
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.lot_no = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.ps_cd = New Frame7.eText()
        Me.gong_cd = New Frame7.eCombo()
        Me.ps_nm = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.ECombo1 = New Frame7.eCombo()
        Me.ECombo2 = New Frame7.eCombo()
        Me.ECheckCombo1 = New Frame7.eCheckCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1035, 690)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ECombo2)
        Me.EPanel1.Controls.Add(Me.ECombo1)
        Me.EPanel1.Controls.Add(Me.ECheckCombo1)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.lot_no)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.gong_cd)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1035, 124)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(776, 28)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(240, 21)
        Me.lot_no.TabIndex = 10
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(400, 52)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(368, 21)
        Me.gd_cd.TabIndex = 8
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 2
        Me.fr_dt.Title = "기준일자"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(152, 28)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 4
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(400, 28)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(240, 21)
        Me.ps_cd.TabIndex = 6
        '
        'gong_cd
        '
        Me.gong_cd.Location = New System.Drawing.Point(8, 52)
        Me.gong_cd.Name = "gong_cd"
        Me.gong_cd.Size = New System.Drawing.Size(384, 21)
        Me.gong_cd.TabIndex = 5
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(528, 28)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(240, 21)
        Me.ps_nm.TabIndex = 7
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(652, 52)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(364, 21)
        Me.gd_nm.TabIndex = 9
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1035, 562)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     담당자별 검사실적 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1031, 537)
        Me.g10.TabIndex = 2
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(699, 79)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECombo1.TabIndex = 13
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(8, 79)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 14
        '
        'ECheckCombo1
        '
        Me.ECheckCombo1.Location = New System.Drawing.Point(152, 79)
        Me.ECheckCombo1.Name = "ECheckCombo1"
        Me.ECheckCombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECheckCombo1.TabIndex = 15
        '
        'WP_PR1220
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1220"
        Me.Size = New System.Drawing.Size(1035, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents gong_cd As Frame7.eCombo
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents ECheckCombo1 As Frame7.eCheckCombo

End Class
