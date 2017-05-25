<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_TR1120P
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
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.spec90 = New Frame7.eText()
        Me.spec80 = New Frame7.eText()
        Me.spec70 = New Frame7.eText()
        Me.spec60 = New Frame7.eText()
        Me.spec50 = New Frame7.eText()
        Me.spec40 = New Frame7.eText()
        Me.spec30 = New Frame7.eText()
        Me.spec20 = New Frame7.eText()
        Me.spec10 = New Frame7.eText()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.od_no = New Frame7.eText()
        Me.value = New Frame7.eText()
        Me.x_spec = New Frame7.eText()
        Me.y_spec = New Frame7.eText()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        Me.seq = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.tot_qty = New Frame7.eText()
        Me.btn_ok = New DevExpress.XtraEditors.SimpleButton()
        Me.qty = New Frame7.eText()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.ty = New Frame7.eText()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        Me.spc_1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.EPanel1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer1)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 105
        Me.spc_1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ty)
        Me.EPanel1.Controls.Add(Me.spec90)
        Me.EPanel1.Controls.Add(Me.spec80)
        Me.EPanel1.Controls.Add(Me.spec70)
        Me.EPanel1.Controls.Add(Me.spec60)
        Me.EPanel1.Controls.Add(Me.spec50)
        Me.EPanel1.Controls.Add(Me.spec40)
        Me.EPanel1.Controls.Add(Me.spec30)
        Me.EPanel1.Controls.Add(Me.spec20)
        Me.EPanel1.Controls.Add(Me.spec10)
        Me.EPanel1.Controls.Add(Me.btn_save)
        Me.EPanel1.Controls.Add(Me.od_no)
        Me.EPanel1.Controls.Add(Me.value)
        Me.EPanel1.Controls.Add(Me.x_spec)
        Me.EPanel1.Controls.Add(Me.y_spec)
        Me.EPanel1.Controls.Add(Me.btn_exit)
        Me.EPanel1.Controls.Add(Me.seq)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.tot_qty)
        Me.EPanel1.Controls.Add(Me.btn_ok)
        Me.EPanel1.Controls.Add(Me.qty)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 105)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'spec90
        '
        Me.spec90.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec90.Location = New System.Drawing.Point(1124, 28)
        Me.spec90.Name = "spec90"
        Me.spec90.Size = New System.Drawing.Size(21, 21)
        Me.spec90.TabIndex = 94
        Me.spec90.Title = "y_spec"
        Me.spec90.TitleWidth = 0
        '
        'spec80
        '
        Me.spec80.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec80.Location = New System.Drawing.Point(1097, 28)
        Me.spec80.Name = "spec80"
        Me.spec80.Size = New System.Drawing.Size(21, 21)
        Me.spec80.TabIndex = 93
        Me.spec80.Title = "y_spec"
        Me.spec80.TitleWidth = 0
        '
        'spec70
        '
        Me.spec70.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec70.Location = New System.Drawing.Point(1070, 28)
        Me.spec70.Name = "spec70"
        Me.spec70.Size = New System.Drawing.Size(21, 21)
        Me.spec70.TabIndex = 92
        Me.spec70.Title = "y_spec"
        Me.spec70.TitleWidth = 0
        '
        'spec60
        '
        Me.spec60.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec60.Location = New System.Drawing.Point(1043, 28)
        Me.spec60.Name = "spec60"
        Me.spec60.Size = New System.Drawing.Size(21, 21)
        Me.spec60.TabIndex = 91
        Me.spec60.Title = "y_spec"
        Me.spec60.TitleWidth = 0
        '
        'spec50
        '
        Me.spec50.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec50.Location = New System.Drawing.Point(1016, 28)
        Me.spec50.Name = "spec50"
        Me.spec50.Size = New System.Drawing.Size(21, 21)
        Me.spec50.TabIndex = 90
        Me.spec50.Title = "y_spec"
        Me.spec50.TitleWidth = 0
        '
        'spec40
        '
        Me.spec40.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec40.Location = New System.Drawing.Point(989, 28)
        Me.spec40.Name = "spec40"
        Me.spec40.Size = New System.Drawing.Size(21, 21)
        Me.spec40.TabIndex = 89
        Me.spec40.Title = "y_spec"
        Me.spec40.TitleWidth = 0
        '
        'spec30
        '
        Me.spec30.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec30.Location = New System.Drawing.Point(962, 28)
        Me.spec30.Name = "spec30"
        Me.spec30.Size = New System.Drawing.Size(21, 21)
        Me.spec30.TabIndex = 88
        Me.spec30.Title = "y_spec"
        Me.spec30.TitleWidth = 0
        '
        'spec20
        '
        Me.spec20.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec20.Location = New System.Drawing.Point(935, 28)
        Me.spec20.Name = "spec20"
        Me.spec20.Size = New System.Drawing.Size(21, 21)
        Me.spec20.TabIndex = 87
        Me.spec20.Title = "y_spec"
        Me.spec20.TitleWidth = 0
        '
        'spec10
        '
        Me.spec10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.spec10.Location = New System.Drawing.Point(908, 28)
        Me.spec10.Name = "spec10"
        Me.spec10.Size = New System.Drawing.Size(21, 21)
        Me.spec10.TabIndex = 86
        Me.spec10.Title = "y_spec"
        Me.spec10.TitleWidth = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(607, 74)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 24)
        Me.btn_save.TabIndex = 85
        Me.btn_save.Text = "저  장"
        '
        'od_no
        '
        Me.od_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_no.Location = New System.Drawing.Point(8, 52)
        Me.od_no.Name = "od_no"
        Me.od_no.Size = New System.Drawing.Size(240, 21)
        Me.od_no.TabIndex = 84
        Me.od_no.Title = "od_no"
        '
        'value
        '
        Me.value.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.value.Location = New System.Drawing.Point(780, 28)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(92, 21)
        Me.value.TabIndex = 83
        Me.value.Title = "y_spec"
        Me.value.TitleWidth = 0
        '
        'x_spec
        '
        Me.x_spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.x_spec.Location = New System.Drawing.Point(780, 52)
        Me.x_spec.Name = "x_spec"
        Me.x_spec.Size = New System.Drawing.Size(92, 21)
        Me.x_spec.TabIndex = 82
        Me.x_spec.Title = "x_spec"
        Me.x_spec.TitleWidth = 0
        '
        'y_spec
        '
        Me.y_spec.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.y_spec.Location = New System.Drawing.Point(780, 80)
        Me.y_spec.Name = "y_spec"
        Me.y_spec.Size = New System.Drawing.Size(92, 21)
        Me.y_spec.TabIndex = 81
        Me.y_spec.Title = "y_spec"
        Me.y_spec.TitleWidth = 0
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(685, 74)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(72, 24)
        Me.btn_exit.TabIndex = 74
        Me.btn_exit.Text = "종   료"
        '
        'seq
        '
        Me.seq.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seq.Location = New System.Drawing.Point(252, 52)
        Me.seq.Name = "seq"
        Me.seq.Size = New System.Drawing.Size(92, 21)
        Me.seq.TabIndex = 78
        Me.seq.Title = "seq"
        Me.seq.TitleWidth = 0
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(8, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 76
        Me.itm_cd.Title = "itm_cd"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(252, 28)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 77
        Me.itm_nm.Title = "itm_nm"
        Me.itm_nm.TitleWidth = 0
        '
        'tot_qty
        '
        Me.tot_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_qty.Location = New System.Drawing.Point(252, 77)
        Me.tot_qty.Name = "tot_qty"
        Me.tot_qty.Size = New System.Drawing.Size(240, 21)
        Me.tot_qty.TabIndex = 80
        Me.tot_qty.Title = "tot_qty"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(529, 74)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(72, 24)
        Me.btn_ok.TabIndex = 73
        Me.btn_ok.Text = "조  회"
        '
        'qty
        '
        Me.qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.qty.Location = New System.Drawing.Point(8, 77)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(240, 21)
        Me.qty.TabIndex = 79
        Me.qty.Title = "qty"
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 502)
        Me.SplitContainer1.SplitterDistance = 310
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(310, 502)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     제품Spec"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(306, 477)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(868, 502)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     제품상세"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(864, 477)
        Me.g20.TabIndex = 2
        '
        'ty
        '
        Me.ty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ty.Location = New System.Drawing.Point(908, 80)
        Me.ty.Name = "ty"
        Me.ty.Size = New System.Drawing.Size(21, 21)
        Me.ty.TabIndex = 95
        Me.ty.Title = "y_spec"
        Me.ty.TitleWidth = 0
        '
        'WI_TR1120P
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_TR1120P"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tot_qty As Frame7.eText
    Friend WithEvents qty As Frame7.eText
    Friend WithEvents seq As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents x_spec As Frame7.eText
    Friend WithEvents y_spec As Frame7.eText
    Friend WithEvents value As Frame7.eText
    Friend WithEvents od_no As Frame7.eText
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spec90 As Frame7.eText
    Friend WithEvents spec80 As Frame7.eText
    Friend WithEvents spec70 As Frame7.eText
    Friend WithEvents spec60 As Frame7.eText
    Friend WithEvents spec50 As Frame7.eText
    Friend WithEvents spec40 As Frame7.eText
    Friend WithEvents spec30 As Frame7.eText
    Friend WithEvents spec20 As Frame7.eText
    Friend WithEvents spec10 As Frame7.eText
    Friend WithEvents ty As Frame7.eText

End Class
