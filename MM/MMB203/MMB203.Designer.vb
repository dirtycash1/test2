<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB203
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
        Me.po_fac = New Frame7.eCombo()
        Me.po_bc = New Frame7.eCombo()
        Me.po_no = New Frame7.eText()
        Me.po_chk = New Frame7.eCheck()
        Me.po_fr = New Frame7.eDate()
        Me.in_fac = New Frame7.eCombo()
        Me.dlv_fr = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.ex_rt = New Frame7.eText()
        Me.lot_chk = New Frame7.eCheck()
        Me.cury_bc = New Frame7.eCombo()
        Me.opt_show = New Frame7.eOptionBox()
        Me.itm_cd = New Frame7.eText()
        Me.std_dt = New Frame7.eDate()
        Me.in_wh = New Frame7.eCombo()
        Me.dir_bc = New Frame7.eCombo()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.dlv_dt = New Frame7.eDate()
        Me.po_to = New Frame7.eDate()
        Me.dlv_to = New Frame7.eDate()
        Me.lot_save = New DevExpress.XtraEditors.SimpleButton()
        Me.cust_nm = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g30 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.dlv_save = New DevExpress.XtraEditors.SimpleButton()
        Me.use_bc = New Frame7.eCheckCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1335, 581)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.use_bc)
        Me.EPanel1.Controls.Add(Me.po_fac)
        Me.EPanel1.Controls.Add(Me.po_bc)
        Me.EPanel1.Controls.Add(Me.po_no)
        Me.EPanel1.Controls.Add(Me.po_chk)
        Me.EPanel1.Controls.Add(Me.po_fr)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.dlv_fr)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.ex_rt)
        Me.EPanel1.Controls.Add(Me.lot_chk)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.opt_show)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.dir_bc)
        Me.EPanel1.Controls.Add(Me.btn_save)
        Me.EPanel1.Controls.Add(Me.dlv_dt)
        Me.EPanel1.Controls.Add(Me.po_to)
        Me.EPanel1.Controls.Add(Me.dlv_to)
        Me.EPanel1.Controls.Add(Me.lot_save)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1335, 129)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(8, 28)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(186, 21)
        Me.po_fac.TabIndex = 2
        Me.po_fac.Title = "po_fac"
        Me.po_fac.TitleWidth = 80
        '
        'po_bc
        '
        Me.po_bc.Location = New System.Drawing.Point(8, 76)
        Me.po_bc.Name = "po_bc"
        Me.po_bc.Size = New System.Drawing.Size(188, 21)
        Me.po_bc.TabIndex = 114
        Me.po_bc.Title = "발주구분"
        Me.po_bc.TitleWidth = 80
        '
        'po_no
        '
        Me.po_no.Location = New System.Drawing.Point(8, 52)
        Me.po_no.Name = "po_no"
        Me.po_no.Size = New System.Drawing.Size(186, 21)
        Me.po_no.TabIndex = 3
        Me.po_no.Title = "po_no"
        Me.po_no.TitleWidth = 80
        '
        'po_chk
        '
        Me.po_chk.Caption = ""
        Me.po_chk.Location = New System.Drawing.Point(641, 100)
        Me.po_chk.Name = "po_chk"
        Me.po_chk.Size = New System.Drawing.Size(95, 21)
        Me.po_chk.TabIndex = 115
        Me.po_chk.Title = "전결 발주건 만"
        Me.po_chk.TitleWidth = 80
        '
        'po_fr
        '
        Me.po_fr.Location = New System.Drawing.Point(217, 28)
        Me.po_fr.Name = "po_fr"
        Me.po_fr.Size = New System.Drawing.Size(187, 21)
        Me.po_fr.TabIndex = 4
        Me.po_fr.Title = "po_fr"
        Me.po_fr.TitleWidth = 80
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(658, 28)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(188, 21)
        Me.in_fac.TabIndex = 2
        Me.in_fac.Title = "in_fac"
        Me.in_fac.TitleWidth = 80
        '
        'dlv_fr
        '
        Me.dlv_fr.Location = New System.Drawing.Point(217, 52)
        Me.dlv_fr.Name = "dlv_fr"
        Me.dlv_fr.Size = New System.Drawing.Size(187, 21)
        Me.dlv_fr.TabIndex = 4
        Me.dlv_fr.Title = "dlv_fr"
        Me.dlv_fr.TitleWidth = 80
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(217, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(187, 21)
        Me.cust_cd.TabIndex = 3
        Me.cust_cd.Title = "cust_cd"
        Me.cust_cd.TitleWidth = 80
        '
        'ex_rt
        '
        Me.ex_rt.Location = New System.Drawing.Point(983, 76)
        Me.ex_rt.Name = "ex_rt"
        Me.ex_rt.Size = New System.Drawing.Size(180, 21)
        Me.ex_rt.TabIndex = 103
        Me.ex_rt.Title = "환율"
        Me.ex_rt.TitleWidth = 80
        '
        'lot_chk
        '
        Me.lot_chk.Caption = ""
        Me.lot_chk.Location = New System.Drawing.Point(868, 52)
        Me.lot_chk.Name = "lot_chk"
        Me.lot_chk.Size = New System.Drawing.Size(98, 21)
        Me.lot_chk.TabIndex = 111
        Me.lot_chk.Title = "Lot No 등록"
        Me.lot_chk.TitleWidth = 80
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(983, 52)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(180, 21)
        Me.cury_bc.TabIndex = 6
        Me.cury_bc.Title = "통화"
        Me.cury_bc.TitleWidth = 80
        '
        'opt_show
        '
        Me.opt_show.Location = New System.Drawing.Point(522, 29)
        Me.opt_show.Name = "opt_show"
        Me.opt_show.SelectedIndex = -1
        Me.opt_show.Size = New System.Drawing.Size(116, 44)
        Me.opt_show.TabIndex = 7
        Me.opt_show.TitleWidth = 0
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(217, 100)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(186, 21)
        Me.itm_cd.TabIndex = 3
        Me.itm_cd.Title = "itm_cd"
        Me.itm_cd.TitleWidth = 80
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(983, 28)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(180, 21)
        Me.std_dt.TabIndex = 5
        Me.std_dt.Title = "환율적용일"
        Me.std_dt.TitleWidth = 80
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(658, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(188, 21)
        Me.in_wh.TabIndex = 2
        Me.in_wh.Title = "in_wh"
        Me.in_wh.TitleWidth = 80
        '
        'dir_bc
        '
        Me.dir_bc.Location = New System.Drawing.Point(868, 28)
        Me.dir_bc.Name = "dir_bc"
        Me.dir_bc.Size = New System.Drawing.Size(95, 21)
        Me.dir_bc.TabIndex = 2
        Me.dir_bc.Title = "내외자"
        Me.dir_bc.TitleWidth = 1
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(743, 100)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(103, 23)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "납품 처리"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(658, 76)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(188, 21)
        Me.dlv_dt.TabIndex = 4
        Me.dlv_dt.Title = "dlv_dt"
        Me.dlv_dt.TitleWidth = 80
        '
        'po_to
        '
        Me.po_to.Location = New System.Drawing.Point(408, 28)
        Me.po_to.Name = "po_to"
        Me.po_to.Size = New System.Drawing.Size(108, 21)
        Me.po_to.TabIndex = 4
        Me.po_to.Title = "po_to"
        Me.po_to.TitleWidth = 0
        '
        'dlv_to
        '
        Me.dlv_to.Location = New System.Drawing.Point(408, 52)
        Me.dlv_to.Name = "dlv_to"
        Me.dlv_to.Size = New System.Drawing.Size(108, 21)
        Me.dlv_to.TabIndex = 4
        Me.dlv_to.TitleWidth = 0
        '
        'lot_save
        '
        Me.lot_save.Location = New System.Drawing.Point(868, 98)
        Me.lot_save.Name = "lot_save"
        Me.lot_save.Size = New System.Drawing.Size(95, 23)
        Me.lot_save.TabIndex = 5
        Me.lot_save.Text = "Lot별 저장"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(408, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(230, 21)
        Me.cust_nm.TabIndex = 3
        Me.cust_nm.Title = "cust_nm"
        Me.cust_nm.TitleWidth = 0
        '
        'itm_nm
        '
        Me.itm_nm.Location = New System.Drawing.Point(408, 100)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(230, 21)
        Me.itm_nm.TabIndex = 3
        Me.itm_nm.Title = "cust_nm"
        Me.itm_nm.TitleWidth = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1335, 448)
        Me.SplitContainer2.SplitterDistance = 251
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g30)
        Me.SplitContainer3.Size = New System.Drawing.Size(1335, 251)
        Me.SplitContainer3.SplitterDistance = 806
        Me.SplitContainer3.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(806, 251)
        Me.g10.TabIndex = 1
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(525, 251)
        Me.g30.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Controls.Add(Me.dlv_save)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1335, 193)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     납품 현황 및 취소"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1331, 168)
        Me.g20.TabIndex = 0
        '
        'dlv_save
        '
        Me.dlv_save.Location = New System.Drawing.Point(254, 0)
        Me.dlv_save.Name = "dlv_save"
        Me.dlv_save.Size = New System.Drawing.Size(126, 23)
        Me.dlv_save.TabIndex = 112
        Me.dlv_save.Text = "저장"
        '
        'use_bc
        '
        Me.use_bc.Location = New System.Drawing.Point(983, 100)
        Me.use_bc.Name = "use_bc"
        Me.use_bc.Size = New System.Drawing.Size(180, 21)
        Me.use_bc.TabIndex = 116
        Me.use_bc.Title = "용도구분"
        Me.use_bc.TitleWidth = 80
        '
        'MMB203
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB203"
        Me.Size = New System.Drawing.Size(1360, 682)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents po_no As Frame7.eText
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents po_fr As Frame7.eDate
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents dlv_fr As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents po_to As Frame7.eDate
    Friend WithEvents dlv_to As Frame7.eDate
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents opt_show As Frame7.eOptionBox
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents lot_chk As Frame7.eCheck
    Friend WithEvents lot_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dir_bc As Frame7.eCombo
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents ex_rt As Frame7.eText
    Friend WithEvents dlv_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents po_chk As Frame7.eCheck
    Friend WithEvents po_bc As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents use_bc As Frame7.eCheckCombo

End Class
