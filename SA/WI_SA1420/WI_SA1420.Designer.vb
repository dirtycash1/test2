<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1420
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
        Me.f_sl_no = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.emp_no = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.Split3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.sl_no = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.unit_cd = New Frame7.eCombo()
        Me.lot_no = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.d01 = New Frame7.eText()
        Me.cl_dt = New Frame7.eDate()
        Me.d05 = New Frame7.eText()
        Me.spec = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.ac_dt = New Frame7.eDate()
        Me.sl_dt = New Frame7.eDate()
        Me.d02 = New Frame7.eText()
        Me.d07 = New Frame7.eText()
        Me.stts = New Frame7.eCombo()
        Me.print_cnt = New Frame7.eText()
        Me.d04 = New Frame7.eText()
        Me.d08 = New Frame7.eText()
        Me.d06 = New Frame7.eText()
        Me.d03 = New Frame7.eText()
        Me.Split3.Panel1.SuspendLayout()
        Me.Split3.Panel2.SuspendLayout()
        Me.Split3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'f_sl_no
        '
        Me.f_sl_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_sl_no.Location = New System.Drawing.Point(8, 28)
        Me.f_sl_no.Name = "f_sl_no"
        Me.f_sl_no.Size = New System.Drawing.Size(240, 21)
        Me.f_sl_no.TabIndex = 1
        Me.f_sl_no.Title = "관리번호"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 52)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 2
        Me.fr_dt.Title = "등록기간"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(8, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        Me.to_dt.Title = "~"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(8, 100)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 4
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(8, 124)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 5
        '
        'Split3
        '
        Me.Split3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Split3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Split3.Location = New System.Drawing.Point(0, 0)
        Me.Split3.Name = "Split3"
        '
        'Split3.Panel1
        '
        Me.Split3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'Split3.Panel2
        '
        Me.Split3.Panel2.Controls.Add(Me.EPanel3)
        Me.Split3.Size = New System.Drawing.Size(1074, 507)
        Me.Split3.SplitterDistance = 345
        Me.Split3.TabIndex = 2
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer4.Size = New System.Drawing.Size(345, 507)
        Me.SplitContainer4.SplitterDistance = 154
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.emp_no)
        Me.EPanel4.Controls.Add(Me.fr_dt)
        Me.EPanel4.Controls.Add(Me.f_sl_no)
        Me.EPanel4.Controls.Add(Me.emp_nm)
        Me.EPanel4.Controls.Add(Me.to_dt)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(345, 154)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     EPanel4"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(345, 349)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     마킹등록현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(341, 324)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.sl_no)
        Me.EPanel3.Controls.Add(Me.gd_cd)
        Me.EPanel3.Controls.Add(Me.unit_cd)
        Me.EPanel3.Controls.Add(Me.lot_no)
        Me.EPanel3.Controls.Add(Me.d01)
        Me.EPanel3.Controls.Add(Me.cl_dt)
        Me.EPanel3.Controls.Add(Me.d05)
        Me.EPanel3.Controls.Add(Me.spec)
        Me.EPanel3.Controls.Add(Me.gd_nm)
        Me.EPanel3.Controls.Add(Me.ps_cd)
        Me.EPanel3.Controls.Add(Me.ps_nm)
        Me.EPanel3.Controls.Add(Me.ac_dt)
        Me.EPanel3.Controls.Add(Me.sl_dt)
        Me.EPanel3.Controls.Add(Me.d02)
        Me.EPanel3.Controls.Add(Me.d07)
        Me.EPanel3.Controls.Add(Me.stts)
        Me.EPanel3.Controls.Add(Me.print_cnt)
        Me.EPanel3.Controls.Add(Me.d04)
        Me.EPanel3.Controls.Add(Me.d08)
        Me.EPanel3.Controls.Add(Me.d06)
        Me.EPanel3.Controls.Add(Me.d03)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(725, 507)
        Me.EPanel3.TabIndex = 14
        Me.EPanel3.Text = "     레이저 마킹등록"
        '
        'sl_no
        '
        Me.sl_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sl_no.Location = New System.Drawing.Point(16, 32)
        Me.sl_no.Name = "sl_no"
        Me.sl_no.Size = New System.Drawing.Size(240, 21)
        Me.sl_no.TabIndex = 0
        Me.sl_no.Title = "관리번호"
        '
        'gd_cd
        '
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(16, 144)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(372, 21)
        Me.gd_cd.TabIndex = 0
        '
        'unit_cd
        '
        Me.unit_cd.Location = New System.Drawing.Point(16, 192)
        Me.unit_cd.Name = "unit_cd"
        Me.unit_cd.Size = New System.Drawing.Size(240, 21)
        Me.unit_cd.TabIndex = 14
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(16, 120)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(372, 21)
        Me.lot_no.TabIndex = 13
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(272, 144)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(360, 21)
        Me.gd_nm.TabIndex = 1
        '
        'd01
        '
        Me.d01.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d01.Location = New System.Drawing.Point(16, 224)
        Me.d01.Name = "d01"
        Me.d01.Size = New System.Drawing.Size(240, 21)
        Me.d01.TabIndex = 4
        '
        'cl_dt
        '
        Me.cl_dt.Location = New System.Drawing.Point(268, 80)
        Me.cl_dt.Name = "cl_dt"
        Me.cl_dt.Size = New System.Drawing.Size(240, 21)
        Me.cl_dt.TabIndex = 6
        '
        'd05
        '
        Me.d05.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d05.Location = New System.Drawing.Point(16, 320)
        Me.d05.Name = "d05"
        Me.d05.Size = New System.Drawing.Size(240, 21)
        Me.d05.TabIndex = 8
        '
        'spec
        '
        Me.spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec.Location = New System.Drawing.Point(16, 168)
        Me.spec.Name = "spec"
        Me.spec.Size = New System.Drawing.Size(372, 21)
        Me.spec.TabIndex = 2
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(268, 32)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(240, 21)
        Me.ps_cd.TabIndex = 1
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(396, 32)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(240, 21)
        Me.ps_nm.TabIndex = 2
        '
        'ac_dt
        '
        Me.ac_dt.Location = New System.Drawing.Point(268, 56)
        Me.ac_dt.Name = "ac_dt"
        Me.ac_dt.Size = New System.Drawing.Size(240, 21)
        Me.ac_dt.TabIndex = 5
        '
        'sl_dt
        '
        Me.sl_dt.Location = New System.Drawing.Point(16, 80)
        Me.sl_dt.Name = "sl_dt"
        Me.sl_dt.Size = New System.Drawing.Size(240, 21)
        Me.sl_dt.TabIndex = 4
        '
        'd02
        '
        Me.d02.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d02.Location = New System.Drawing.Point(16, 248)
        Me.d02.Name = "d02"
        Me.d02.Size = New System.Drawing.Size(240, 21)
        Me.d02.TabIndex = 5
        '
        'd07
        '
        Me.d07.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d07.Location = New System.Drawing.Point(16, 368)
        Me.d07.Name = "d07"
        Me.d07.Size = New System.Drawing.Size(240, 21)
        Me.d07.TabIndex = 10
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(16, 56)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(240, 21)
        Me.stts.TabIndex = 3
        '
        'print_cnt
        '
        Me.print_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.print_cnt.Location = New System.Drawing.Point(16, 416)
        Me.print_cnt.Name = "print_cnt"
        Me.print_cnt.Size = New System.Drawing.Size(240, 21)
        Me.print_cnt.TabIndex = 12
        '
        'd04
        '
        Me.d04.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d04.Location = New System.Drawing.Point(16, 296)
        Me.d04.Name = "d04"
        Me.d04.Size = New System.Drawing.Size(240, 21)
        Me.d04.TabIndex = 7
        '
        'd08
        '
        Me.d08.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d08.Location = New System.Drawing.Point(16, 392)
        Me.d08.Name = "d08"
        Me.d08.Size = New System.Drawing.Size(240, 21)
        Me.d08.TabIndex = 11
        '
        'd06
        '
        Me.d06.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d06.Location = New System.Drawing.Point(16, 344)
        Me.d06.Name = "d06"
        Me.d06.Size = New System.Drawing.Size(240, 21)
        Me.d06.TabIndex = 9
        '
        'd03
        '
        Me.d03.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.d03.Location = New System.Drawing.Point(16, 272)
        Me.d03.Name = "d03"
        Me.d03.Size = New System.Drawing.Size(240, 21)
        Me.d03.TabIndex = 6
        '
        'WI_SA1420
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Split3)
        Me.Name = "WI_SA1420"
        Me.Size = New System.Drawing.Size(1074, 507)
        Me.Controls.SetChildIndex(Me.Split3, 0)
        Me.Split3.Panel1.ResumeLayout(False)
        Me.Split3.Panel2.ResumeLayout(False)
        Me.Split3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents f_sl_no As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents Split3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents sl_no As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents d01 As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents cl_dt As Frame7.eDate
    Friend WithEvents d05 As Frame7.eText
    Friend WithEvents ac_dt As Frame7.eDate
    Friend WithEvents sl_dt As Frame7.eDate
    Friend WithEvents spec As Frame7.eText
    Friend WithEvents d07 As Frame7.eText
    Friend WithEvents print_cnt As Frame7.eText
    Friend WithEvents d04 As Frame7.eText
    Friend WithEvents stts As Frame7.eCombo
    Friend WithEvents d06 As Frame7.eText
    Friend WithEvents d03 As Frame7.eText
    Friend WithEvents d08 As Frame7.eText
    Friend WithEvents d02 As Frame7.eText
    Friend WithEvents unit_cd As Frame7.eCombo

End Class
