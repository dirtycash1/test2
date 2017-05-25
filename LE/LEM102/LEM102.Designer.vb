<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEM102
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
        Me.itm_bc = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.mov_no = New Frame7.eText()
        Me.in_wh = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.out_wh = New Frame7.eCombo()
        Me.out_fac = New Frame7.eCombo()
        Me.mov_dtf = New Frame7.eDate()
        Me.mov_dtt = New Frame7.eDate()
        Me.mov_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(916, 613)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.mov_no)
        Me.EPanel1.Controls.Add(Me.mov_dtf)
        Me.EPanel1.Controls.Add(Me.mov_dtt)
        Me.EPanel1.Controls.Add(Me.out_wh)
        Me.EPanel1.Controls.Add(Me.out_fac)
        Me.EPanel1.Controls.Add(Me.mov_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(916, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(796, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 70
        Me.itm_bc.Title = "품목구분"
        '
        'itm_nm
        '
        Me.itm_nm.Location = New System.Drawing.Point(796, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 72
        Me.itm_nm.Title = "품목코드%"
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(796, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 71
        Me.itm_cd.Title = "품목코드%"
        '
        'mov_no
        '
        Me.mov_no.Location = New System.Drawing.Point(532, 76)
        Me.mov_no.Name = "mov_no"
        Me.mov_no.Size = New System.Drawing.Size(240, 21)
        Me.mov_no.TabIndex = 69
        Me.mov_no.Title = "이동번호"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(532, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 68
        Me.in_wh.Title = "입고창고"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(532, 28)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 67
        Me.in_fac.Title = "입고공장"
        '
        'out_wh
        '
        Me.out_wh.Location = New System.Drawing.Point(272, 52)
        Me.out_wh.Name = "out_wh"
        Me.out_wh.Size = New System.Drawing.Size(240, 21)
        Me.out_wh.TabIndex = 66
        Me.out_wh.Title = "출고창고"
        '
        'out_fac
        '
        Me.out_fac.Location = New System.Drawing.Point(272, 28)
        Me.out_fac.Name = "out_fac"
        Me.out_fac.Size = New System.Drawing.Size(240, 21)
        Me.out_fac.TabIndex = 65
        Me.out_fac.Title = "출고공장"
        '
        'mov_dtf
        '
        Me.mov_dtf.Location = New System.Drawing.Point(12, 28)
        Me.mov_dtf.Name = "mov_dtf"
        Me.mov_dtf.Size = New System.Drawing.Size(240, 21)
        Me.mov_dtf.TabIndex = 62
        Me.mov_dtf.Title = "이동일자"
        '
        'mov_dtt
        '
        Me.mov_dtt.Location = New System.Drawing.Point(12, 52)
        Me.mov_dtt.Name = "mov_dtt"
        Me.mov_dtt.Size = New System.Drawing.Size(240, 21)
        Me.mov_dtt.TabIndex = 63
        Me.mov_dtt.Title = "~"
        '
        'mov_bc
        '
        Me.mov_bc.Location = New System.Drawing.Point(272, 76)
        Me.mov_bc.Name = "mov_bc"
        Me.mov_bc.Size = New System.Drawing.Size(240, 21)
        Me.mov_bc.TabIndex = 64
        Me.mov_bc.Title = "이동구분"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(916, 505)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     이동현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(912, 480)
        Me.g10.TabIndex = 4
        '
        'LEM102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEM102"
        Me.Size = New System.Drawing.Size(916, 613)
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
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents mov_no As Frame7.eText
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents out_wh As Frame7.eCombo
    Friend WithEvents out_fac As Frame7.eCombo
    Friend WithEvents mov_dtf As Frame7.eDate
    Friend WithEvents mov_dtt As Frame7.eDate
    Friend WithEvents mov_bc As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid

End Class
