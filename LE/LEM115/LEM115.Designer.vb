<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEM115
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
        Me.chk_lot = New Frame7.eCheck()
        Me.co_cd = New Frame7.eCombo()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.itm_nm = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.in_id = New Frame7.eText()
        Me.in_dept = New Frame7.eText()
        Me.in_dept_nm = New Frame7.eText()
        Me.in_nm = New Frame7.eText()
        Me.mov_bc = New Frame7.eCombo()
        Me.in_fac = New Frame7.eCombo()
        Me.out_fac = New Frame7.eCombo()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.in_bs = New Frame7.eCombo()
        Me.out_bs = New Frame7.eCombo()
        Me.ent_bc = New Frame7.eCombo()
        Me.in_rid = New Frame7.eText()
        Me.in_wh = New Frame7.eCombo()
        Me.mov_no = New Frame7.eText()
        Me.out_dt = New Frame7.eDate()
        Me.lot_chk = New Frame7.eCheck()
        Me.fr_dt = New Frame7.eDate()
        Me.itm_chk = New Frame7.eCheck()
        Me.out_nm = New Frame7.eText()
        Me.out_wh = New Frame7.eCombo()
        Me.out_dept_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.rmks = New Frame7.eText()
        Me.out_rid = New Frame7.eText()
        Me.out_dept = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.g20 = New Frame7.eGrid()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 516)
        Me.SplitContainer1.SplitterDistance = 135
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.chk_lot)
        Me.EPanel3.Controls.Add(Me.co_cd)
        Me.EPanel3.Controls.Add(Me.SimpleButton2)
        Me.EPanel3.Controls.Add(Me.itm_nm)
        Me.EPanel3.Controls.Add(Me.itm_cd)
        Me.EPanel3.Controls.Add(Me.in_id)
        Me.EPanel3.Controls.Add(Me.in_dept)
        Me.EPanel3.Controls.Add(Me.in_dept_nm)
        Me.EPanel3.Controls.Add(Me.in_nm)
        Me.EPanel3.Controls.Add(Me.mov_bc)
        Me.EPanel3.Controls.Add(Me.in_fac)
        Me.EPanel3.Controls.Add(Me.out_fac)
        Me.EPanel3.Controls.Add(Me.SimpleButton1)
        Me.EPanel3.Controls.Add(Me.in_bs)
        Me.EPanel3.Controls.Add(Me.out_bs)
        Me.EPanel3.Controls.Add(Me.ent_bc)
        Me.EPanel3.Controls.Add(Me.in_rid)
        Me.EPanel3.Controls.Add(Me.in_wh)
        Me.EPanel3.Controls.Add(Me.out_dt)
        Me.EPanel3.Controls.Add(Me.lot_chk)
        Me.EPanel3.Controls.Add(Me.mov_no)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.itm_chk)
        Me.EPanel3.Controls.Add(Me.out_nm)
        Me.EPanel3.Controls.Add(Me.out_wh)
        Me.EPanel3.Controls.Add(Me.out_dept_nm)
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Controls.Add(Me.rmks)
        Me.EPanel3.Controls.Add(Me.out_rid)
        Me.EPanel3.Controls.Add(Me.out_dept)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1024, 135)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     검색"
        '
        'chk_lot
        '
        Me.chk_lot.Caption = ""
        Me.chk_lot.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_lot.Location = New System.Drawing.Point(659, 108)
        Me.chk_lot.Name = "chk_lot"
        Me.chk_lot.Size = New System.Drawing.Size(105, 21)
        Me.chk_lot.TabIndex = 91
        Me.chk_lot.Title = "LOT별"
        Me.chk_lot.TitleWidth = 80
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(543, 3)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(81, 21)
        Me.co_cd.TabIndex = 90
        Me.co_cd.Title = "입고법인"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(894, 108)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(118, 23)
        Me.SimpleButton2.TabIndex = 83
        Me.SimpleButton2.Text = "재고현황조회"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(264, 108)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(379, 21)
        Me.itm_nm.TabIndex = 82
        Me.itm_nm.Title = "품목명"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(12, 108)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 81
        Me.itm_cd.Title = "품목코드"
        '
        'in_id
        '
        Me.in_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_id.Location = New System.Drawing.Point(424, 212)
        Me.in_id.Name = "in_id"
        Me.in_id.Size = New System.Drawing.Size(240, 21)
        Me.in_id.TabIndex = 79
        Me.in_id.Title = "입고담당"
        '
        'in_dept
        '
        Me.in_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_dept.Location = New System.Drawing.Point(424, 236)
        Me.in_dept.Name = "in_dept"
        Me.in_dept.Size = New System.Drawing.Size(240, 21)
        Me.in_dept.TabIndex = 78
        Me.in_dept.Title = "입고부서"
        '
        'in_dept_nm
        '
        Me.in_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_dept_nm.Location = New System.Drawing.Point(668, 236)
        Me.in_dept_nm.Name = "in_dept_nm"
        Me.in_dept_nm.Size = New System.Drawing.Size(120, 21)
        Me.in_dept_nm.TabIndex = 77
        Me.in_dept_nm.Title = "출고번호"
        Me.in_dept_nm.TitleWidth = 0
        '
        'in_nm
        '
        Me.in_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_nm.Location = New System.Drawing.Point(668, 212)
        Me.in_nm.Name = "in_nm"
        Me.in_nm.Size = New System.Drawing.Size(120, 21)
        Me.in_nm.TabIndex = 75
        Me.in_nm.Title = "출고번호"
        Me.in_nm.TitleWidth = 0
        '
        'mov_bc
        '
        Me.mov_bc.Location = New System.Drawing.Point(264, 76)
        Me.mov_bc.Name = "mov_bc"
        Me.mov_bc.Size = New System.Drawing.Size(240, 21)
        Me.mov_bc.TabIndex = 68
        Me.mov_bc.Title = "이동구분"
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
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(770, 108)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 23)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Text = "재고이동처리"
        '
        'in_bs
        '
        Me.in_bs.Location = New System.Drawing.Point(356, 3)
        Me.in_bs.Name = "in_bs"
        Me.in_bs.Size = New System.Drawing.Size(89, 21)
        Me.in_bs.TabIndex = 57
        Me.in_bs.Title = "입고사업장"
        Me.in_bs.Visible = False
        '
        'out_bs
        '
        Me.out_bs.Location = New System.Drawing.Point(264, 3)
        Me.out_bs.Name = "out_bs"
        Me.out_bs.Size = New System.Drawing.Size(62, 21)
        Me.out_bs.TabIndex = 57
        Me.out_bs.Title = "출고사업장"
        Me.out_bs.Visible = False
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(772, 76)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 61
        Me.ent_bc.Title = "ent_bc"
        '
        'in_rid
        '
        Me.in_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_rid.Location = New System.Drawing.Point(793, 212)
        Me.in_rid.Name = "in_rid"
        Me.in_rid.Size = New System.Drawing.Size(20, 21)
        Me.in_rid.TabIndex = 76
        Me.in_rid.Title = "출고번호"
        Me.in_rid.TitleWidth = 0
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(520, 52)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 60
        Me.in_wh.Title = "입고창고"
        '
        'mov_no
        '
        Me.mov_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mov_no.Location = New System.Drawing.Point(129, 2)
        Me.mov_no.Name = "mov_no"
        Me.mov_no.Size = New System.Drawing.Size(122, 21)
        Me.mov_no.TabIndex = 59
        Me.mov_no.Title = "이동번호"
        Me.mov_no.TitleWidth = 1
        '
        'out_dt
        '
        Me.out_dt.Location = New System.Drawing.Point(12, 76)
        Me.out_dt.Name = "out_dt"
        Me.out_dt.Size = New System.Drawing.Size(240, 21)
        Me.out_dt.TabIndex = 58
        Me.out_dt.Title = "이동일자"
        '
        'lot_chk
        '
        Me.lot_chk.Caption = ""
        Me.lot_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_chk.Location = New System.Drawing.Point(240, 236)
        Me.lot_chk.Name = "lot_chk"
        Me.lot_chk.Size = New System.Drawing.Size(172, 21)
        Me.lot_chk.TabIndex = 65
        Me.lot_chk.Title = "LOT전환 여부"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 58
        Me.fr_dt.Title = "이동기간"
        '
        'itm_chk
        '
        Me.itm_chk.Caption = ""
        Me.itm_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_chk.Location = New System.Drawing.Point(240, 212)
        Me.itm_chk.Name = "itm_chk"
        Me.itm_chk.Size = New System.Drawing.Size(172, 21)
        Me.itm_chk.TabIndex = 64
        Me.itm_chk.Title = "품목전환 여부"
        '
        'out_nm
        '
        Me.out_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.out_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_dept_nm.Location = New System.Drawing.Point(772, 28)
        Me.out_dept_nm.Name = "out_dept_nm"
        Me.out_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.out_dept_nm.TabIndex = 72
        Me.out_dept_nm.Title = "out_dept_nm"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(12, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 58
        Me.to_dt.Title = "~"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(520, 76)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(240, 21)
        Me.rmks.TabIndex = 69
        Me.rmks.Title = "비고"
        '
        'out_rid
        '
        Me.out_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_rid.Location = New System.Drawing.Point(761, 3)
        Me.out_rid.Name = "out_rid"
        Me.out_rid.Size = New System.Drawing.Size(52, 21)
        Me.out_rid.TabIndex = 74
        Me.out_rid.Title = "out_rid"
        '
        'out_dept
        '
        Me.out_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_dept.Location = New System.Drawing.Point(699, 3)
        Me.out_dept.Name = "out_dept"
        Me.out_dept.Size = New System.Drawing.Size(56, 21)
        Me.out_dept.TabIndex = 73
        Me.out_dept.Title = "out_dept"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainerControl1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 377)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     재고이동품목정보"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.g20)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1020, 352)
        Me.SplitContainerControl1.SplitterPosition = 217
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1020, 217)
        Me.g20.TabIndex = 3
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 129)
        Me.g10.TabIndex = 3
        '
        'LEM115
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEM115"
        Me.Size = New System.Drawing.Size(1034, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
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
    Friend WithEvents rmks As Frame7.eText
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
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents in_bs As Frame7.eCombo
    Friend WithEvents out_bs As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents chk_lot As Frame7.eCheck

End Class
