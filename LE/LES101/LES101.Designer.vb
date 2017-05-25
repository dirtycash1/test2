<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LES101
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
        Me.fr_dt = New Frame7.eDate()
        Me.chk_io = New Frame7.eCheck()
        Me.itm_bc = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.bs_cd = New Frame7.eCombo()
        Me.fac_cd = New Frame7.eCombo()
        Me.chk_lot = New Frame7.eCheck()
        Me.wh_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.grp2_cd = New Frame7.eCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.chk_inout = New Frame7.eCheck()
        Me.grp3_cd = New Frame7.eCombo()
        Me.spec1 = New Frame7.eCombo()
        Me.lot_no = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.chk_bu = New Frame7.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1140, 516)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chk_bu)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.chk_io)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.chk_lot)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.chk_inout)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.spec1)
        Me.EPanel1.Controls.Add(Me.lot_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1140, 102)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 63
        Me.fr_dt.Title = "조회기간"
        '
        'chk_io
        '
        Me.chk_io.Caption = ""
        Me.chk_io.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_io.Location = New System.Drawing.Point(108, 104)
        Me.chk_io.Name = "chk_io"
        Me.chk_io.Size = New System.Drawing.Size(56, 21)
        Me.chk_io.TabIndex = 70
        Me.chk_io.Title = "입출고 있는것만"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(508, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 74
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(128, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 73
        Me.to_dt.Title = "기준일"
        Me.to_dt.TitleWidth = 0
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(260, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 62
        Me.bs_cd.Title = "사업장"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(260, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 62
        Me.fac_cd.Title = "조회공장"
        '
        'chk_lot
        '
        Me.chk_lot.Caption = ""
        Me.chk_lot.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_lot.Location = New System.Drawing.Point(128, 76)
        Me.chk_lot.Name = "chk_lot"
        Me.chk_lot.Size = New System.Drawing.Size(120, 21)
        Me.chk_lot.TabIndex = 71
        Me.chk_lot.Title = "LOT별 재고"
        Me.chk_lot.TitleWidth = 80
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(260, 76)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 72
        Me.wh_cd.Title = "조회창고"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(508, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 65
        Me.grp1_cd.Title = "대분류"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(766, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 68
        Me.itm_cd.Title = "품목코드%"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(766, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 69
        Me.itm_nm.Title = "품목명%"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(508, 76)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 66
        Me.grp2_cd.Title = "중분류"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(828, 1)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(40, 21)
        Me.model_cd.TabIndex = 64
        Me.model_cd.Title = "차종"
        '
        'chk_inout
        '
        Me.chk_inout.Caption = ""
        Me.chk_inout.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_inout.Location = New System.Drawing.Point(8, 76)
        Me.chk_inout.Name = "chk_inout"
        Me.chk_inout.Size = New System.Drawing.Size(103, 21)
        Me.chk_inout.TabIndex = 71
        Me.chk_inout.Title = "입출고 품목만"
        Me.chk_inout.TitleWidth = 80
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(942, 3)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(51, 21)
        Me.grp3_cd.TabIndex = 67
        Me.grp3_cd.Title = "소분류"
        Me.grp3_cd.Visible = False
        '
        'spec1
        '
        Me.spec1.Location = New System.Drawing.Point(874, 3)
        Me.spec1.Name = "spec1"
        Me.spec1.Size = New System.Drawing.Size(42, 21)
        Me.spec1.TabIndex = 65
        Me.spec1.Title = "Color"
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(766, 76)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(240, 21)
        Me.lot_no.TabIndex = 68
        Me.lot_no.Title = "Lot No(%)"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1140, 410)
        Me.SplitContainer2.SplitterDistance = 240
        Me.SplitContainer2.TabIndex = 3
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1140, 240)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1140, 166)
        Me.g20.TabIndex = 3
        '
        'chk_bu
        '
        Me.chk_bu.Caption = ""
        Me.chk_bu.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_bu.Location = New System.Drawing.Point(1017, 28)
        Me.chk_bu.Name = "chk_bu"
        Me.chk_bu.Size = New System.Drawing.Size(120, 21)
        Me.chk_bu.TabIndex = 75
        Me.chk_bu.Title = "부자재"
        Me.chk_bu.TitleWidth = 80
        '
        'LES101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LES101"
        Me.Size = New System.Drawing.Size(1198, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents chk_lot As Frame7.eCheck
    Friend WithEvents chk_io As Frame7.eCheck
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents spec1 As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents chk_inout As Frame7.eCheck
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents chk_bu As Frame7.eCheck

End Class
