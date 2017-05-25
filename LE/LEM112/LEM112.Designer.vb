<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEM112
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
        Me.EPanel3 = New Frame7.ePanel()
        Me.mov_bc = New Frame7.eCombo()
        Me.in_id = New Frame7.eText()
        Me.in_dept = New Frame7.eText()
        Me.in_dept_nm = New Frame7.eText()
        Me.show_btn = New Frame7.eCheck()
        Me.in_nm = New Frame7.eText()
        Me.in_fac = New Frame7.eCombo()
        Me.out_fac = New Frame7.eCombo()
        Me.ent_bc = New Frame7.eCombo()
        Me.in_rid = New Frame7.eText()
        Me.mov_no = New Frame7.eText()
        Me.out_dt = New Frame7.eDate()
        Me.in_wh = New Frame7.eCombo()
        Me.lot_chk = New Frame7.eCheck()
        Me.itm_chk = New Frame7.eCheck()
        Me.out_nm = New Frame7.eText()
        Me.out_wh = New Frame7.eCombo()
        Me.out_dept_nm = New Frame7.eText()
        Me.out_dept = New Frame7.eText()
        Me.out_rid = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.opt_show = New Frame7.eOptionBox()
        Me.f_itm_cd = New Frame7.eText()
        Me.f_itm_nm2 = New Frame7.eText()
        Me.f_req_fr = New Frame7.eDate()
        Me.f_req_to = New Frame7.eDate()
        Me.f_dept_cd = New Frame7.eText()
        Me.f_itm_bc = New Frame7.eCombo()
        Me.f_dept_nm = New Frame7.eText()
        Me.btn_srh = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.ban_type = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 563)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.mov_bc)
        Me.EPanel3.Controls.Add(Me.in_id)
        Me.EPanel3.Controls.Add(Me.in_dept)
        Me.EPanel3.Controls.Add(Me.in_dept_nm)
        Me.EPanel3.Controls.Add(Me.show_btn)
        Me.EPanel3.Controls.Add(Me.in_nm)
        Me.EPanel3.Controls.Add(Me.in_fac)
        Me.EPanel3.Controls.Add(Me.out_fac)
        Me.EPanel3.Controls.Add(Me.ent_bc)
        Me.EPanel3.Controls.Add(Me.in_rid)
        Me.EPanel3.Controls.Add(Me.mov_no)
        Me.EPanel3.Controls.Add(Me.out_dt)
        Me.EPanel3.Controls.Add(Me.in_wh)
        Me.EPanel3.Controls.Add(Me.lot_chk)
        Me.EPanel3.Controls.Add(Me.itm_chk)
        Me.EPanel3.Controls.Add(Me.out_nm)
        Me.EPanel3.Controls.Add(Me.out_wh)
        Me.EPanel3.Controls.Add(Me.out_dept_nm)
        Me.EPanel3.Controls.Add(Me.out_dept)
        Me.EPanel3.Controls.Add(Me.out_rid)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1034, 105)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     검색"
        '
        'mov_bc
        '
        Me.mov_bc.Location = New System.Drawing.Point(11, 76)
        Me.mov_bc.Name = "mov_bc"
        Me.mov_bc.Size = New System.Drawing.Size(241, 21)
        Me.mov_bc.TabIndex = 68
        Me.mov_bc.Title = "이동구분"
        '
        'in_id
        '
        Me.in_id.Location = New System.Drawing.Point(424, 212)
        Me.in_id.Name = "in_id"
        Me.in_id.Size = New System.Drawing.Size(240, 21)
        Me.in_id.TabIndex = 79
        Me.in_id.Title = "입고담당"
        '
        'in_dept
        '
        Me.in_dept.Location = New System.Drawing.Point(424, 236)
        Me.in_dept.Name = "in_dept"
        Me.in_dept.Size = New System.Drawing.Size(240, 21)
        Me.in_dept.TabIndex = 78
        Me.in_dept.Title = "입고부서"
        '
        'in_dept_nm
        '
        Me.in_dept_nm.Location = New System.Drawing.Point(668, 236)
        Me.in_dept_nm.Name = "in_dept_nm"
        Me.in_dept_nm.Size = New System.Drawing.Size(120, 21)
        Me.in_dept_nm.TabIndex = 77
        Me.in_dept_nm.Title = "출고번호"
        Me.in_dept_nm.TitleWidth = 0
        '
        'show_btn
        '
        Me.show_btn.Caption = ""
        Me.show_btn.Location = New System.Drawing.Point(264, 76)
        Me.show_btn.Name = "show_btn"
        Me.show_btn.Size = New System.Drawing.Size(148, 21)
        Me.show_btn.TabIndex = 112
        Me.show_btn.Title = "반납조회 숨기기"
        '
        'in_nm
        '
        Me.in_nm.Location = New System.Drawing.Point(668, 212)
        Me.in_nm.Name = "in_nm"
        Me.in_nm.Size = New System.Drawing.Size(120, 21)
        Me.in_nm.TabIndex = 75
        Me.in_nm.Title = "출고번호"
        Me.in_nm.TitleWidth = 0
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(520, 28)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 61
        Me.in_fac.Title = "입고공장"
        '
        'out_fac
        '
        Me.out_fac.Location = New System.Drawing.Point(264, 28)
        Me.out_fac.Name = "out_fac"
        Me.out_fac.Size = New System.Drawing.Size(240, 21)
        Me.out_fac.TabIndex = 57
        Me.out_fac.Title = "출고공장"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(520, 76)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 61
        Me.ent_bc.Title = "ent_bc"
        '
        'in_rid
        '
        Me.in_rid.Location = New System.Drawing.Point(793, 212)
        Me.in_rid.Name = "in_rid"
        Me.in_rid.Size = New System.Drawing.Size(20, 21)
        Me.in_rid.TabIndex = 76
        Me.in_rid.Title = "출고번호"
        Me.in_rid.TitleWidth = 0
        '
        'mov_no
        '
        Me.mov_no.Location = New System.Drawing.Point(11, 28)
        Me.mov_no.Name = "mov_no"
        Me.mov_no.Size = New System.Drawing.Size(240, 21)
        Me.mov_no.TabIndex = 59
        Me.mov_no.Title = "이동번호"
        '
        'out_dt
        '
        Me.out_dt.Location = New System.Drawing.Point(11, 52)
        Me.out_dt.Name = "out_dt"
        Me.out_dt.Size = New System.Drawing.Size(240, 21)
        Me.out_dt.TabIndex = 58
        Me.out_dt.Title = "이동일자"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(520, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 60
        Me.in_wh.Title = "입고창고"
        '
        'lot_chk
        '
        Me.lot_chk.Caption = ""
        Me.lot_chk.Location = New System.Drawing.Point(240, 236)
        Me.lot_chk.Name = "lot_chk"
        Me.lot_chk.Size = New System.Drawing.Size(172, 21)
        Me.lot_chk.TabIndex = 65
        Me.lot_chk.Title = "LOT전환 여부"
        '
        'itm_chk
        '
        Me.itm_chk.Caption = ""
        Me.itm_chk.Location = New System.Drawing.Point(240, 212)
        Me.itm_chk.Name = "itm_chk"
        Me.itm_chk.Size = New System.Drawing.Size(172, 21)
        Me.itm_chk.TabIndex = 64
        Me.itm_chk.Title = "품목전환 여부"
        '
        'out_nm
        '
        Me.out_nm.Location = New System.Drawing.Point(772, 52)
        Me.out_nm.Name = "out_nm"
        Me.out_nm.Size = New System.Drawing.Size(240, 21)
        Me.out_nm.TabIndex = 70
        Me.out_nm.Title = "out_nm"
        '
        'out_wh
        '
        Me.out_wh.Location = New System.Drawing.Point(264, 52)
        Me.out_wh.Name = "out_wh"
        Me.out_wh.Size = New System.Drawing.Size(240, 21)
        Me.out_wh.TabIndex = 56
        Me.out_wh.Title = "출고창고"
        '
        'out_dept_nm
        '
        Me.out_dept_nm.Location = New System.Drawing.Point(772, 28)
        Me.out_dept_nm.Name = "out_dept_nm"
        Me.out_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.out_dept_nm.TabIndex = 72
        Me.out_dept_nm.Title = "out_dept_nm"
        '
        'out_dept
        '
        Me.out_dept.Location = New System.Drawing.Point(619, 3)
        Me.out_dept.Name = "out_dept"
        Me.out_dept.Size = New System.Drawing.Size(56, 21)
        Me.out_dept.TabIndex = 73
        Me.out_dept.Title = "out_dept"
        '
        'out_rid
        '
        Me.out_rid.Location = New System.Drawing.Point(690, 3)
        Me.out_rid.Name = "out_rid"
        Me.out_rid.Size = New System.Drawing.Size(52, 21)
        Me.out_rid.TabIndex = 74
        Me.out_rid.Title = "out_rid"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1034, 454)
        Me.SplitContainer2.SplitterDistance = 503
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(503, 454)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     반납 자재 조회"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ban_type)
        Me.SplitContainer3.Panel1.Controls.Add(Me.opt_show)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_nm2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_req_fr)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_req_to)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_dept_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_itm_bc)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_dept_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btn_srh)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(499, 429)
        Me.SplitContainer3.SplitterDistance = 131
        Me.SplitContainer3.TabIndex = 2
        '
        'opt_show
        '
        Me.opt_show.Location = New System.Drawing.Point(100, 76)
        Me.opt_show.Name = "opt_show"
        Me.opt_show.SelectedIndex = -1
        Me.opt_show.Size = New System.Drawing.Size(199, 24)
        Me.opt_show.TabIndex = 37
        Me.opt_show.TitleWidth = 0
        '
        'f_itm_cd
        '
        Me.f_itm_cd.Location = New System.Drawing.Point(8, 52)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_itm_cd.TabIndex = 36
        Me.f_itm_cd.Title = "품목코드"
        Me.f_itm_cd.TitleWidth = 90
        '
        'f_itm_nm2
        '
        Me.f_itm_nm2.Location = New System.Drawing.Point(209, 52)
        Me.f_itm_nm2.Name = "f_itm_nm2"
        Me.f_itm_nm2.Size = New System.Drawing.Size(287, 21)
        Me.f_itm_nm2.TabIndex = 35
        Me.f_itm_nm2.Title = "거래처"
        Me.f_itm_nm2.TitleWidth = 0
        '
        'f_req_fr
        '
        Me.f_req_fr.Location = New System.Drawing.Point(8, 28)
        Me.f_req_fr.Name = "f_req_fr"
        Me.f_req_fr.Size = New System.Drawing.Size(200, 21)
        Me.f_req_fr.TabIndex = 34
        Me.f_req_fr.Title = "의뢰기간"
        Me.f_req_fr.TitleWidth = 90
        '
        'f_req_to
        '
        Me.f_req_to.Location = New System.Drawing.Point(117, 28)
        Me.f_req_to.Name = "f_req_to"
        Me.f_req_to.Size = New System.Drawing.Size(200, 21)
        Me.f_req_to.TabIndex = 34
        Me.f_req_to.Title = ""
        Me.f_req_to.TitleWidth = 90
        '
        'f_dept_cd
        '
        Me.f_dept_cd.Location = New System.Drawing.Point(8, 4)
        Me.f_dept_cd.Name = "f_dept_cd"
        Me.f_dept_cd.Size = New System.Drawing.Size(200, 21)
        Me.f_dept_cd.TabIndex = 17
        Me.f_dept_cd.Title = "거래처"
        Me.f_dept_cd.TitleWidth = 90
        '
        'f_itm_bc
        '
        Me.f_itm_bc.Location = New System.Drawing.Point(323, 28)
        Me.f_itm_bc.Name = "f_itm_bc"
        Me.f_itm_bc.Size = New System.Drawing.Size(173, 21)
        Me.f_itm_bc.TabIndex = 18
        Me.f_itm_bc.Title = "품목구분"
        Me.f_itm_bc.TitleWidth = 60
        '
        'f_dept_nm
        '
        Me.f_dept_nm.Location = New System.Drawing.Point(209, 4)
        Me.f_dept_nm.Name = "f_dept_nm"
        Me.f_dept_nm.Size = New System.Drawing.Size(287, 21)
        Me.f_dept_nm.TabIndex = 14
        Me.f_dept_nm.Title = "거래처"
        Me.f_dept_nm.TitleWidth = 0
        '
        'btn_srh
        '
        Me.btn_srh.Location = New System.Drawing.Point(370, 76)
        Me.btn_srh.Name = "btn_srh"
        Me.btn_srh.Size = New System.Drawing.Size(126, 25)
        Me.btn_srh.TabIndex = 19
        Me.btn_srh.Text = "검색"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(499, 294)
        Me.g20.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(527, 454)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     자재 반납 처리"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(523, 429)
        Me.g10.TabIndex = 2
        '
        'ban_type
        '
        Me.ban_type.Location = New System.Drawing.Point(9, 106)
        Me.ban_type.Name = "ban_type"
        Me.ban_type.Size = New System.Drawing.Size(223, 21)
        Me.ban_type.TabIndex = 38
        Me.ban_type.Title = "반납유형"
        Me.ban_type.TitleWidth = 90
        '
        'LEM112
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEM112"
        Me.Size = New System.Drawing.Size(1034, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents mov_bc As Frame7.eCombo
    Friend WithEvents lot_chk As Frame7.eCheck
    Friend WithEvents itm_chk As Frame7.eCheck
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents mov_no As Frame7.eText
    Friend WithEvents out_dt As Frame7.eDate
    Friend WithEvents out_fac As Frame7.eCombo
    Friend WithEvents out_wh As Frame7.eCombo
    Friend WithEvents in_dept As Frame7.eText
    Friend WithEvents in_id As Frame7.eText
    Friend WithEvents in_dept_nm As Frame7.eText
    Friend WithEvents in_nm As Frame7.eText
    Friend WithEvents in_rid As Frame7.eText
    Friend WithEvents out_dept As Frame7.eText
    Friend WithEvents out_rid As Frame7.eText
    Friend WithEvents out_dept_nm As Frame7.eText
    Friend WithEvents out_nm As Frame7.eText
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_itm_cd As Frame7.eText
    Friend WithEvents f_itm_nm2 As Frame7.eText
    Friend WithEvents f_req_fr As Frame7.eDate
    Friend WithEvents f_req_to As Frame7.eDate
    Friend WithEvents f_dept_cd As Frame7.eText
    Friend WithEvents f_itm_bc As Frame7.eCombo
    Friend WithEvents f_dept_nm As Frame7.eText
    Friend WithEvents btn_srh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents opt_show As Frame7.eOptionBox
    Friend WithEvents show_btn As Frame7.eCheck
    Friend WithEvents ban_type As Frame7.eCombo

End Class
