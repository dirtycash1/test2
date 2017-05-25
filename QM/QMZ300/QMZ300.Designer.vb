<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMZ300
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
        Me.o_fr_dt = New Frame7.eDate()
        Me.o_grp1_cd = New Frame7.eCombo()
        Me.o_to_dt = New Frame7.eDate()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.rel_dt = New Frame7.eDate()
        Me.grp1_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 100)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(254, 590)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     ReWork단가 등록 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(250, 565)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_fr_dt)
        Me.EPanel1.Controls.Add(Me.o_grp1_cd)
        Me.EPanel1.Controls.Add(Me.o_to_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(254, 100)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'o_fr_dt
        '
        Me.o_fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_fr_dt.Location = New System.Drawing.Point(6, 51)
        Me.o_fr_dt.Name = "o_fr_dt"
        Me.o_fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_fr_dt.TabIndex = 3
        Me.o_fr_dt.Title = "적용기간"
        '
        'o_grp1_cd
        '
        Me.o_grp1_cd.Location = New System.Drawing.Point(6, 27)
        Me.o_grp1_cd.Name = "o_grp1_cd"
        Me.o_grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_grp1_cd.TabIndex = 2
        Me.o_grp1_cd.Title = "품목대분류"
        '
        'o_to_dt
        '
        Me.o_to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_to_dt.Location = New System.Drawing.Point(6, 74)
        Me.o_to_dt.Name = "o_to_dt"
        Me.o_to_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_to_dt.TabIndex = 3
        Me.o_to_dt.Title = ""
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 78)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(742, 612)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     ReWork단가 등록 조회"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(738, 587)
        Me.g20.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.rel_dt)
        Me.EPanel3.Controls.Add(Me.grp1_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(742, 78)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     입력"
        '
        'rel_dt
        '
        Me.rel_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rel_dt.Location = New System.Drawing.Point(5, 51)
        Me.rel_dt.Name = "rel_dt"
        Me.rel_dt.Size = New System.Drawing.Size(240, 21)
        Me.rel_dt.TabIndex = 3
        Me.rel_dt.Title = "적용일자"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(5, 27)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 2
        Me.grp1_cd.Title = "품목대분류"
        '
        'QMZ300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMZ300"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents o_grp1_cd As Frame7.eCombo
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents rel_dt As Frame7.eDate
    Friend WithEvents o_fr_dt As Frame7.eDate
    Friend WithEvents o_to_dt As Frame7.eDate

End Class
