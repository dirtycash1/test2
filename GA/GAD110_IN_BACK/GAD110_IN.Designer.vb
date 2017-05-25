<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAD110_IN
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.bs_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.show_ty = New Frame7.eOptionBox()
        Me.emp_no = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.emp_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.dept_nm = New Frame7.eText()
        Me.bef_yn = New Frame7.eCheck()
        Me.work_bc = New Frame7.eCombo()
        Me.sub_yn = New Frame7.eCheck()
        Me.btn_show = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_calcu = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlshow = New Frame7.ePanel()
        Me.work_kd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.g30 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.chk_frtm = New Frame7.eCheck()
        Me.chk_totm = New Frame7.eCheck()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.pnlshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlshow.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1250, 516)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.chk_frtm)
        Me.EPanel1.Controls.Add(Me.show_ty)
        Me.EPanel1.Controls.Add(Me.chk_totm)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.bef_yn)
        Me.EPanel1.Controls.Add(Me.work_bc)
        Me.EPanel1.Controls.Add(Me.sub_yn)
        Me.EPanel1.Controls.Add(Me.btn_show)
        Me.EPanel1.Controls.Add(Me.btn_work)
        Me.EPanel1.Controls.Add(Me.btn_calcu)
        Me.EPanel1.Controls.Add(Me.pnlshow)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1250, 127)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 60
        Me.bs_cd.Title = "사업장"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 60
        Me.co_cd.Title = "법인"
        '
        'show_ty
        '
        Me.show_ty.Location = New System.Drawing.Point(264, 76)
        Me.show_ty.Name = "show_ty"
        Me.show_ty.SelectedIndex = -1
        Me.show_ty.Size = New System.Drawing.Size(240, 44)
        Me.show_ty.TabIndex = 68
        Me.show_ty.Title = "조회구분"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(264, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 64
        Me.emp_no.Title = "사원"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 62
        Me.fr_dt.Title = "근태기간"
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(508, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 65
        Me.emp_nm.Title = "성명"
        Me.emp_nm.TitleWidth = 0
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(264, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 64
        Me.dept_cd.Title = "부서"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(12, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 63
        Me.to_dt.Title = "근태기간"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(508, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 65
        Me.dept_nm.TitleWidth = 0
        '
        'bef_yn
        '
        Me.bef_yn.Caption = ""
        Me.bef_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bef_yn.Location = New System.Drawing.Point(508, 100)
        Me.bef_yn.Name = "bef_yn"
        Me.bef_yn.Size = New System.Drawing.Size(136, 21)
        Me.bef_yn.TabIndex = 66
        Me.bef_yn.Title = "원시근태 보기"
        Me.bef_yn.Visible = False
        '
        'work_bc
        '
        Me.work_bc.Location = New System.Drawing.Point(508, 76)
        Me.work_bc.Name = "work_bc"
        Me.work_bc.Size = New System.Drawing.Size(240, 21)
        Me.work_bc.TabIndex = 60
        Me.work_bc.Title = "근무직구분"
        '
        'sub_yn
        '
        Me.sub_yn.Caption = ""
        Me.sub_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sub_yn.Location = New System.Drawing.Point(650, 99)
        Me.sub_yn.Name = "sub_yn"
        Me.sub_yn.Size = New System.Drawing.Size(98, 21)
        Me.sub_yn.TabIndex = 66
        Me.sub_yn.Title = "하위부서 포함"
        Me.sub_yn.TitleWidth = 80
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(754, 83)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(89, 34)
        Me.btn_show.TabIndex = 70
        Me.btn_show.Text = "유형"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(871, 83)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(92, 34)
        Me.btn_work.TabIndex = 61
        Me.btn_work.Text = "일근태생성"
        '
        'btn_calcu
        '
        Me.btn_calcu.Location = New System.Drawing.Point(969, 83)
        Me.btn_calcu.Name = "btn_calcu"
        Me.btn_calcu.Size = New System.Drawing.Size(92, 34)
        Me.btn_calcu.TabIndex = 61
        Me.btn_calcu.Text = "자동시간계산"
        '
        'pnlshow
        '
        Me.pnlshow.Controls.Add(Me.work_kd)
        Me.pnlshow.Location = New System.Drawing.Point(873, 28)
        Me.pnlshow.Name = "pnlshow"
        Me.pnlshow.Size = New System.Drawing.Size(188, 45)
        Me.pnlshow.TabIndex = 77
        Me.pnlshow.Text = "     근무직유형"
        Me.pnlshow.Visible = False
        '
        'work_kd
        '
        Me.work_kd.Location = New System.Drawing.Point(89, 0)
        Me.work_kd.Name = "work_kd"
        Me.work_kd.Size = New System.Drawing.Size(99, 21)
        Me.work_kd.TabIndex = 60
        Me.work_kd.Title = ""
        Me.work_kd.TitleWidth = 1
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1250, 385)
        Me.SplitContainer2.SplitterDistance = 281
        Me.SplitContainer2.TabIndex = 3
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Controls.Add(Me.g30)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(281, 385)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     사원정보"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(277, 360)
        Me.g20.TabIndex = 3
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(277, 360)
        Me.g30.TabIndex = 4
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(965, 385)
        Me.EPanel3.TabIndex = 4
        Me.EPanel3.Text = "     근태등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(961, 360)
        Me.g10.TabIndex = 3
        '
        'chk_frtm
        '
        Me.chk_frtm.Caption = ""
        Me.chk_frtm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_frtm.Location = New System.Drawing.Point(754, 28)
        Me.chk_frtm.Name = "chk_frtm"
        Me.chk_frtm.Size = New System.Drawing.Size(113, 21)
        Me.chk_frtm.TabIndex = 78
        Me.chk_frtm.Title = "출근시간 BLK"
        Me.chk_frtm.TitleWidth = 80
        '
        'chk_totm
        '
        Me.chk_totm.Caption = ""
        Me.chk_totm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_totm.Location = New System.Drawing.Point(754, 49)
        Me.chk_totm.Name = "chk_totm"
        Me.chk_totm.Size = New System.Drawing.Size(113, 21)
        Me.chk_totm.TabIndex = 78
        Me.chk_totm.Title = "퇴근시간 BLK"
        Me.chk_totm.TitleWidth = 80
        '
        'GAD110_IN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GAD110_IN"
        Me.Size = New System.Drawing.Size(1286, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.pnlshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlshow.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents work_bc As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents btn_calcu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sub_yn As Frame7.eCheck
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents show_ty As Frame7.eOptionBox
    Friend WithEvents bef_yn As Frame7.eCheck
    Friend WithEvents btn_show As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlshow As Frame7.ePanel
    Friend WithEvents work_kd As Frame7.eCombo
    Friend WithEvents chk_frtm As Frame7.eCheck
    Friend WithEvents chk_totm As Frame7.eCheck

End Class
