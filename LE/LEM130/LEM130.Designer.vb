<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEM130
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
        Me.out_fac = New Frame7.eCombo()
        Me.out_wh = New Frame7.eCombo()
        Me.in_wh = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.cust_nm = New Frame7.eText()
        Me.mov_bc = New Frame7.eCombo()
        Me.ent_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.mov_no = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 360)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.out_fac)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.out_wh)
        Me.EPanel1.Controls.Add(Me.mov_no)
        Me.EPanel1.Controls.Add(Me.mov_bc)
        Me.EPanel1.Controls.Add(Me.ent_bc)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 128)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'out_fac
        '
        Me.out_fac.Location = New System.Drawing.Point(264, 76)
        Me.out_fac.Name = "out_fac"
        Me.out_fac.Size = New System.Drawing.Size(240, 21)
        Me.out_fac.TabIndex = 2
        Me.out_fac.Title = "out_fac"
        '
        'out_wh
        '
        Me.out_wh.Location = New System.Drawing.Point(264, 100)
        Me.out_wh.Name = "out_wh"
        Me.out_wh.Size = New System.Drawing.Size(240, 21)
        Me.out_wh.TabIndex = 2
        Me.out_wh.Title = "out_wh"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(264, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(299, 21)
        Me.in_wh.TabIndex = 2
        Me.in_wh.Title = "in_wh"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(264, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 4
        Me.cust_cd.Title = "cust_cd"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 3
        Me.fr_dt.Title = "fr_dt"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(8, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        Me.to_dt.Title = "to_dt"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(508, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(180, 21)
        Me.cust_nm.TabIndex = 4
        Me.cust_nm.TitleWidth = 0
        '
        'mov_bc
        '
        Me.mov_bc.Location = New System.Drawing.Point(708, 28)
        Me.mov_bc.Name = "mov_bc"
        Me.mov_bc.Size = New System.Drawing.Size(240, 21)
        Me.mov_bc.TabIndex = 2
        Me.mov_bc.Title = "mov_bc"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(708, 52)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 2
        Me.ent_bc.Title = "ent_bc"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 228)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     출하 반품 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 203)
        Me.g10.TabIndex = 2
        '
        'mov_no
        '
        Me.mov_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mov_no.Location = New System.Drawing.Point(8, 76)
        Me.mov_no.Name = "mov_no"
        Me.mov_no.Size = New System.Drawing.Size(240, 21)
        Me.mov_no.TabIndex = 4
        Me.mov_no.Title = "mov_no"
        '
        'LEM130
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEM130"
        Me.Size = New System.Drawing.Size(1034, 392)
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
    Friend WithEvents out_fac As Frame7.eCombo
    Friend WithEvents out_wh As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents mov_bc As Frame7.eCombo
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents mov_no As Frame7.eText

End Class
