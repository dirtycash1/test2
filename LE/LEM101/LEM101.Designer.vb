<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEM101
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
        Me.mov_no1 = New Frame7.eText()
        Me.mov_no = New Frame7.eText()
        Me.in_wh = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.out_wh = New Frame7.eCombo()
        Me.out_fac = New Frame7.eCombo()
        Me.mov_dtf = New Frame7.eDate()
        Me.mov_dtt = New Frame7.eDate()
        Me.mov_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 564)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.mov_dtf)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.out_wh)
        Me.EPanel1.Controls.Add(Me.mov_no)
        Me.EPanel1.Controls.Add(Me.out_fac)
        Me.EPanel1.Controls.Add(Me.mov_bc)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.mov_dtt)
        Me.EPanel1.Controls.Add(Me.mov_no1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1028, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'mov_no1
        '
        Me.mov_no1.Location = New System.Drawing.Point(996, 48)
        Me.mov_no1.Name = "mov_no1"
        Me.mov_no1.Size = New System.Drawing.Size(240, 21)
        Me.mov_no1.TabIndex = 18
        '
        'mov_no
        '
        Me.mov_no.Location = New System.Drawing.Point(772, 52)
        Me.mov_no.Name = "mov_no"
        Me.mov_no.Size = New System.Drawing.Size(240, 21)
        Me.mov_no.TabIndex = 17
        Me.mov_no.Title = "mov_no"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(516, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 15
        Me.in_wh.Title = "in_wh"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(516, 28)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 14
        Me.in_fac.Title = "in_fac"
        '
        'out_wh
        '
        Me.out_wh.Location = New System.Drawing.Point(260, 52)
        Me.out_wh.Name = "out_wh"
        Me.out_wh.Size = New System.Drawing.Size(240, 21)
        Me.out_wh.TabIndex = 12
        Me.out_wh.Title = "out_wh"
        '
        'out_fac
        '
        Me.out_fac.Location = New System.Drawing.Point(260, 28)
        Me.out_fac.Name = "out_fac"
        Me.out_fac.Size = New System.Drawing.Size(240, 21)
        Me.out_fac.TabIndex = 11
        Me.out_fac.Title = "out_fac"
        '
        'mov_dtf
        '
        Me.mov_dtf.Location = New System.Drawing.Point(8, 28)
        Me.mov_dtf.Name = "mov_dtf"
        Me.mov_dtf.Size = New System.Drawing.Size(240, 21)
        Me.mov_dtf.TabIndex = 2
        Me.mov_dtf.Title = "mov_dtf"
        '
        'mov_dtt
        '
        Me.mov_dtt.Location = New System.Drawing.Point(8, 52)
        Me.mov_dtt.Name = "mov_dtt"
        Me.mov_dtt.Size = New System.Drawing.Size(240, 21)
        Me.mov_dtt.TabIndex = 3
        Me.mov_dtt.Title = "~"
        '
        'mov_bc
        '
        Me.mov_bc.Location = New System.Drawing.Point(772, 28)
        Me.mov_bc.Name = "mov_bc"
        Me.mov_bc.Size = New System.Drawing.Size(240, 21)
        Me.mov_bc.TabIndex = 10
        Me.mov_bc.Title = "mov_bc"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1028, 480)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     이동현황"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 23)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 455)
        Me.SplitContainer2.SplitterDistance = 284
        Me.SplitContainer2.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1024, 284)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1024, 167)
        Me.g20.TabIndex = 3
        '
        'LEM101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEM101"
        Me.Size = New System.Drawing.Size(1034, 613)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents mov_no As Frame7.eText
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents out_wh As Frame7.eCombo
    Friend WithEvents out_fac As Frame7.eCombo
    Friend WithEvents mov_bc As Frame7.eCombo
    Friend WithEvents mov_dtt As Frame7.eDate
    Friend WithEvents mov_dtf As Frame7.eDate
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents mov_no1 As Frame7.eText

End Class
