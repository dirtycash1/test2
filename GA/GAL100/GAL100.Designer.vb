<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAL100
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
        Me.loan_f_ty = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.dept_cd = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.bs_cd = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.stat_bc1 = New Frame7.eCombo()
        Me.work_bs = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.loan_ty = New Frame7.eCombo()
        Me.loan_emp = New Frame7.eText()
        Me.loan_emp_nm = New Frame7.eText()
        Me.pay_yn = New Frame7.eCheck()
        Me.loan_dt = New Frame7.eDate()
        Me.loan_id = New Frame7.eText()
        Me.repay_month = New Frame7.eText()
        Me.delay_month = New Frame7.eText()
        Me.use_bc = New Frame7.eCombo()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.ECheck2 = New Frame7.eCheck()
        Me.rmks = New Frame7.eText()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.loan_amt = New Frame7.eText()
        Me.int_rt = New Frame7.eText()
        Me.stat_bc = New Frame7.eCombo()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 581)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.loan_f_ty)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.stat_bc1)
        Me.EPanel1.Controls.Add(Me.work_bs)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1234, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'loan_f_ty
        '
        Me.loan_f_ty.Location = New System.Drawing.Point(268, 52)
        Me.loan_f_ty.Name = "loan_f_ty"
        Me.loan_f_ty.Size = New System.Drawing.Size(240, 21)
        Me.loan_f_ty.TabIndex = 14
        Me.loan_f_ty.Title = "대출구분"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 12
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(8, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 12
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(528, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 13
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(528, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 13
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(268, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 3
        Me.bs_cd.Title = "Combo"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(772, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(156, 21)
        Me.dept_nm.TabIndex = 13
        Me.dept_nm.TitleWidth = 0
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(772, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(156, 21)
        Me.emp_nm.TabIndex = 13
        Me.emp_nm.TitleWidth = 0
        '
        'stat_bc1
        '
        Me.stat_bc1.Location = New System.Drawing.Point(948, 28)
        Me.stat_bc1.Name = "stat_bc1"
        Me.stat_bc1.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc1.TabIndex = 3
        Me.stat_bc1.Title = "진행상태"
        '
        'work_bs
        '
        Me.work_bs.Location = New System.Drawing.Point(948, 52)
        Me.work_bs.Name = "work_bs"
        Me.work_bs.Size = New System.Drawing.Size(240, 21)
        Me.work_bs.TabIndex = 3
        Me.work_bs.Title = "Combo"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1234, 496)
        Me.SplitContainer2.SplitterDistance = 413
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(413, 496)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     대출현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(409, 471)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl)
        Me.SplitContainer3.Size = New System.Drawing.Size(817, 496)
        Me.SplitContainer3.SplitterDistance = 199
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.loan_emp)
        Me.EPanel3.Controls.Add(Me.loan_ty)
        Me.EPanel3.Controls.Add(Me.pay_yn)
        Me.EPanel3.Controls.Add(Me.loan_emp_nm)
        Me.EPanel3.Controls.Add(Me.loan_dt)
        Me.EPanel3.Controls.Add(Me.loan_id)
        Me.EPanel3.Controls.Add(Me.repay_month)
        Me.EPanel3.Controls.Add(Me.delay_month)
        Me.EPanel3.Controls.Add(Me.use_bc)
        Me.EPanel3.Controls.Add(Me.btn_work)
        Me.EPanel3.Controls.Add(Me.ECheck2)
        Me.EPanel3.Controls.Add(Me.rmks)
        Me.EPanel3.Controls.Add(Me.btn_del)
        Me.EPanel3.Controls.Add(Me.loan_amt)
        Me.EPanel3.Controls.Add(Me.int_rt)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Controls.Add(Me.btn_print)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(817, 199)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     대출등록"
        '
        'loan_ty
        '
        Me.loan_ty.Location = New System.Drawing.Point(252, 52)
        Me.loan_ty.Name = "loan_ty"
        Me.loan_ty.Size = New System.Drawing.Size(112, 21)
        Me.loan_ty.TabIndex = 18
        Me.loan_ty.Title = "대출구분"
        '
        'loan_emp
        '
        Me.loan_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loan_emp.Location = New System.Drawing.Point(8, 28)
        Me.loan_emp.Name = "loan_emp"
        Me.loan_emp.Size = New System.Drawing.Size(240, 21)
        Me.loan_emp.TabIndex = 13
        '
        'loan_emp_nm
        '
        Me.loan_emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loan_emp_nm.Location = New System.Drawing.Point(8, 52)
        Me.loan_emp_nm.Name = "loan_emp_nm"
        Me.loan_emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.loan_emp_nm.TabIndex = 13
        Me.loan_emp_nm.Title = "loan_emp_nm"
        '
        'pay_yn
        '
        Me.pay_yn.Caption = ""
        Me.pay_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pay_yn.Location = New System.Drawing.Point(264, 100)
        Me.pay_yn.Name = "pay_yn"
        Me.pay_yn.Size = New System.Drawing.Size(148, 21)
        Me.pay_yn.TabIndex = 17
        Me.pay_yn.Title = "pay_yn"
        '
        'loan_dt
        '
        Me.loan_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loan_dt.Location = New System.Drawing.Point(8, 76)
        Me.loan_dt.Name = "loan_dt"
        Me.loan_dt.Size = New System.Drawing.Size(240, 21)
        Me.loan_dt.TabIndex = 12
        Me.loan_dt.Title = "loan_dt"
        '
        'loan_id
        '
        Me.loan_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loan_id.Location = New System.Drawing.Point(564, 60)
        Me.loan_id.Name = "loan_id"
        Me.loan_id.Size = New System.Drawing.Size(84, 21)
        Me.loan_id.TabIndex = 13
        Me.loan_id.Title = "loan_id"
        '
        'repay_month
        '
        Me.repay_month.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.repay_month.Location = New System.Drawing.Point(8, 100)
        Me.repay_month.Name = "repay_month"
        Me.repay_month.Size = New System.Drawing.Size(240, 21)
        Me.repay_month.TabIndex = 13
        Me.repay_month.Title = "repay_month"
        '
        'delay_month
        '
        Me.delay_month.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.delay_month.Location = New System.Drawing.Point(560, 84)
        Me.delay_month.Name = "delay_month"
        Me.delay_month.Size = New System.Drawing.Size(240, 21)
        Me.delay_month.TabIndex = 13
        Me.delay_month.Title = "delay_month"
        '
        'use_bc
        '
        Me.use_bc.Location = New System.Drawing.Point(8, 148)
        Me.use_bc.Name = "use_bc"
        Me.use_bc.Size = New System.Drawing.Size(240, 21)
        Me.use_bc.TabIndex = 3
        Me.use_bc.Title = "use_bc"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(384, 28)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(120, 23)
        Me.btn_work.TabIndex = 14
        Me.btn_work.Text = "상환계획 작성"
        '
        'ECheck2
        '
        Me.ECheck2.Caption = ""
        Me.ECheck2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck2.Location = New System.Drawing.Point(509, 145)
        Me.ECheck2.Name = "ECheck2"
        Me.ECheck2.Size = New System.Drawing.Size(20, 21)
        Me.ECheck2.TabIndex = 14
        Me.ECheck2.Title = "%"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(8, 172)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(496, 21)
        Me.rmks.TabIndex = 13
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(384, 56)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(120, 23)
        Me.btn_del.TabIndex = 16
        Me.btn_del.Text = "상환계획 삭제"
        '
        'loan_amt
        '
        Me.loan_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loan_amt.Location = New System.Drawing.Point(8, 124)
        Me.loan_amt.Name = "loan_amt"
        Me.loan_amt.Size = New System.Drawing.Size(240, 21)
        Me.loan_amt.TabIndex = 13
        Me.loan_amt.Title = "loan_amt"
        '
        'int_rt
        '
        Me.int_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.int_rt.Location = New System.Drawing.Point(264, 148)
        Me.int_rt.Name = "int_rt"
        Me.int_rt.Size = New System.Drawing.Size(240, 21)
        Me.int_rt.TabIndex = 13
        Me.int_rt.Title = "int_rt"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(264, 124)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 3
        Me.stat_bc.Title = "stat_bc"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(531, 28)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(120, 23)
        Me.btn_print.TabIndex = 15
        Me.btn_print.Text = "상환계획 출력"
        '
        'XtraTabControl
        '
        Me.XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl.Name = "XtraTabControl"
        Me.XtraTabControl.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl.Size = New System.Drawing.Size(817, 293)
        Me.XtraTabControl.TabIndex = 0
        Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(810, 263)
        Me.XtraTabPage1.Text = "상환내역"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(810, 263)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(810, 263)
        Me.XtraTabPage2.Text = "유예정보"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(810, 263)
        Me.g30.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g40)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(810, 263)
        Me.XtraTabPage3.Text = "중도상환"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(810, 263)
        Me.g40.TabIndex = 1
        '
        'GAL100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GAL100"
        Me.Size = New System.Drawing.Size(1234, 581)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents work_bs As Frame7.eCombo
    Friend WithEvents stat_bc1 As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents loan_emp As Frame7.eText
    Friend WithEvents loan_emp_nm As Frame7.eText
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents loan_amt As Frame7.eText
    Friend WithEvents loan_dt As Frame7.eDate
    Friend WithEvents delay_month As Frame7.eText
    Friend WithEvents repay_month As Frame7.eText
    Friend WithEvents use_bc As Frame7.eCombo
    Friend WithEvents int_rt As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents ECheck2 As Frame7.eCheck
    Friend WithEvents loan_id As Frame7.eText
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents pay_yn As Frame7.eCheck
    Friend WithEvents loan_ty As Frame7.eCombo
    Friend WithEvents loan_f_ty As Frame7.eCombo

End Class
