﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_TR1130
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
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.ePivotGrid()
        Me.cur_cd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 88
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cur_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 88)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 2
        Me.fr_dt.Title = "수주기간"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(152, 28)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1000, 598)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수출수주현황"
        '
        'g10
        '
        Me.g10.AllowAddRows = False
        Me.g10.AllowDeleteRows = False
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.Size = New System.Drawing.Size(996, 573)
        Me.g10.TabIndex = 2
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(404, 28)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(240, 21)
        Me.cur_cd.TabIndex = 5
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(8, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 6
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(132, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(260, 21)
        Me.cust_nm.TabIndex = 7
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(404, 52)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(240, 21)
        Me.gd_cd.TabIndex = 8
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(528, 52)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(260, 21)
        Me.gd_nm.TabIndex = 9
        '
        'WP_TR1130
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_TR1130"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.ePivotGrid

End Class