﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAW800
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
        Me.bs_cd = New Frame7.eCombo()
        Me.end_bc = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.chk_yn = New DevExpress.XtraEditors.CheckEdit()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.chk_yn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(880, 360)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.end_bc)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(880, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 2
        '
        'end_bc
        '
        Me.end_bc.Location = New System.Drawing.Point(8, 52)
        Me.end_bc.Name = "end_bc"
        Me.end_bc.Size = New System.Drawing.Size(240, 21)
        Me.end_bc.TabIndex = 2
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(268, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 3
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(268, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.chk_yn)
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(880, 276)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     일 마감 등록"
        '
        'chk_yn
        '
        Me.chk_yn.Location = New System.Drawing.Point(213, 26)
        Me.chk_yn.Name = "chk_yn"
        Me.chk_yn.Properties.Caption = "CheckEdit1"
        Me.chk_yn.Size = New System.Drawing.Size(16, 19)
        Me.chk_yn.TabIndex = 3
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(876, 251)
        Me.g10.TabIndex = 2
        '
        'CAW800
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CAW800"
        Me.Size = New System.Drawing.Size(909, 384)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.chk_yn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents end_bc As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents chk_yn As DevExpress.XtraEditors.CheckEdit

End Class