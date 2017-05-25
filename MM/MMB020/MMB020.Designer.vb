<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB020
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
        Me.g10 = New Frame7.eGrid
        Me.EPanel1 = New Frame7.ePanel
        Me.fac_cd = New Frame7.eCombo
        Me.plan_dtf = New Frame7.eDate
        Me.plan_dtt = New Frame7.eDate
        Me.p1_chk = New Frame7.eCheck
        Me.p3_chk = New Frame7.eCheck
        Me.p2_chk = New Frame7.eCheck
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.EPanel2 = New Frame7.ePanel
        Me.EPanel3 = New Frame7.ePanel
        Me.g20 = New Frame7.eGrid
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
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 428)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.plan_dtf)
        Me.EPanel1.Controls.Add(Me.plan_dtt)
        Me.EPanel1.Controls.Add(Me.p1_chk)
        Me.EPanel1.Controls.Add(Me.p3_chk)
        Me.EPanel1.Controls.Add(Me.p2_chk)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 105)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     결품리스트 현황 조건"
        '
        'fac_cd
        '
        Me.fac_cd.CompuText = Nothing
        Me.fac_cd.Location = New System.Drawing.Point(8, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 2
        Me.fac_cd.Title = "발주공장"
        '
        'plan_dtf
        '
        Me.plan_dtf.CompuText = Nothing
        Me.plan_dtf.Location = New System.Drawing.Point(8, 52)
        Me.plan_dtf.Name = "plan_dtf"
        Me.plan_dtf.Size = New System.Drawing.Size(240, 21)
        Me.plan_dtf.TabIndex = 9
        Me.plan_dtf.Title = "기간시작"
        '
        'plan_dtt
        '
        Me.plan_dtt.CompuText = Nothing
        Me.plan_dtt.Location = New System.Drawing.Point(8, 76)
        Me.plan_dtt.Name = "plan_dtt"
        Me.plan_dtt.Size = New System.Drawing.Size(240, 21)
        Me.plan_dtt.TabIndex = 10
        Me.plan_dtt.Title = "기간종료"
        '
        'p1_chk
        '
        Me.p1_chk.Caption = ""
        Me.p1_chk.CompuText = Nothing
        Me.p1_chk.Location = New System.Drawing.Point(264, 28)
        Me.p1_chk.Name = "p1_chk"
        Me.p1_chk.Size = New System.Drawing.Size(240, 21)
        Me.p1_chk.TabIndex = 6
        Me.p1_chk.Title = "안전재고감안"
        '
        'p3_chk
        '
        Me.p3_chk.Caption = ""
        Me.p3_chk.CompuText = Nothing
        Me.p3_chk.Location = New System.Drawing.Point(264, 76)
        Me.p3_chk.Name = "p3_chk"
        Me.p3_chk.Size = New System.Drawing.Size(240, 21)
        Me.p3_chk.TabIndex = 8
        Me.p3_chk.Title = "재고감안"
        '
        'p2_chk
        '
        Me.p2_chk.Caption = ""
        Me.p2_chk.CompuText = Nothing
        Me.p2_chk.Location = New System.Drawing.Point(264, 52)
        Me.p2_chk.Name = "p2_chk"
        Me.p2_chk.Size = New System.Drawing.Size(240, 21)
        Me.p2_chk.TabIndex = 7
        Me.p2_chk.Title = "발주잔량감안"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 663)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 1
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1050, 554)
        Me.SplitContainer2.SplitterDistance = 453
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 453)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     결품 현황"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1050, 97)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     MODEL 결품 현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1046, 72)
        Me.g20.TabIndex = 2
        '
        'MMB020
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB020"
        Me.Size = New System.Drawing.Size(1050, 663)
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents p3_chk As Frame7.eCheck
    Friend WithEvents p2_chk As Frame7.eCheck
    Friend WithEvents p1_chk As Frame7.eCheck
    Friend WithEvents plan_dtf As Frame7.eDate
    Friend WithEvents plan_dtt As Frame7.eDate
    Friend WithEvents g20 As Frame7.eGrid

End Class
