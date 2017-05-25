<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAC104
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
        Me.to_mon = New Frame7.eDate()
        Me.fr_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.detail_yn = New Frame7.eCheck()
        Me.dept_cd = New Frame7.eText()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.chk_yn = New Frame7.eCheck()
        Me.pay_mon = New Frame7.eDate()
        Me.btn_pay = New DevExpress.XtraEditors.SimpleButton()
        Me.bs_cd = New Frame7.eCombo()
        Me.emp_no = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.GB1.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(925, 399)
        Me.SplitContainer1.SplitterDistance = 130
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_mon)
        Me.EPanel1.Controls.Add(Me.fr_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.detail_yn)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.GB1)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(925, 130)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'to_mon
        '
        Me.to_mon.Format = "yyyy-MM"
        Me.to_mon.Location = New System.Drawing.Point(8, 100)
        Me.to_mon.Name = "to_mon"
        Me.to_mon.Size = New System.Drawing.Size(240, 21)
        Me.to_mon.TabIndex = 8
        Me.to_mon.Title = "기간검색(to)"
        '
        'fr_mon
        '
        Me.fr_mon.Format = "yyyy-MM"
        Me.fr_mon.Location = New System.Drawing.Point(8, 76)
        Me.fr_mon.Name = "fr_mon"
        Me.fr_mon.Size = New System.Drawing.Size(240, 21)
        Me.fr_mon.TabIndex = 7
        Me.fr_mon.Title = "기간검색(fr)"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "법인"
        '
        'detail_yn
        '
        Me.detail_yn.Caption = ""
        Me.detail_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.detail_yn.Location = New System.Drawing.Point(260, 76)
        Me.detail_yn.Name = "detail_yn"
        Me.detail_yn.Size = New System.Drawing.Size(152, 21)
        Me.detail_yn.TabIndex = 6
        Me.detail_yn.Title = "detail_yn"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(260, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 3
        Me.dept_cd.Title = "부서"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.btn_del)
        Me.GB1.Controls.Add(Me.chk_yn)
        Me.GB1.Controls.Add(Me.pay_mon)
        Me.GB1.Controls.Add(Me.btn_pay)
        Me.GB1.Location = New System.Drawing.Point(640, 28)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(256, 96)
        Me.GB1.TabIndex = 9
        Me.GB1.TabStop = False
        Me.GB1.Text = "급여 반영"
        '
        'chk_yn
        '
        Me.chk_yn.Caption = ""
        Me.chk_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_yn.Location = New System.Drawing.Point(8, 44)
        Me.chk_yn.Name = "chk_yn"
        Me.chk_yn.Size = New System.Drawing.Size(120, 21)
        Me.chk_yn.TabIndex = 6
        Me.chk_yn.Title = "chk_yn"
        Me.chk_yn.TitleWidth = 80
        '
        'pay_mon
        '
        Me.pay_mon.Format = "yyyy-MM"
        Me.pay_mon.Location = New System.Drawing.Point(8, 20)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(240, 21)
        Me.pay_mon.TabIndex = 4
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(136, 44)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(112, 23)
        Me.btn_pay.TabIndex = 5
        Me.btn_pay.Text = "고정수당반영"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 2
        Me.bs_cd.Title = "사업장"
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(260, 52)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 3
        Me.emp_no.Title = "사원"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(384, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 10
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(384, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 11
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(925, 265)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     소급계산현황 (급여반영)"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(921, 240)
        Me.g10.TabIndex = 2
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(136, 68)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(112, 23)
        Me.btn_del.TabIndex = 7
        Me.btn_del.Text = "고정수당삭제"
        '
        'PAC104
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAC104"
        Me.Size = New System.Drawing.Size(925, 399)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.GB1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents btn_pay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents detail_yn As Frame7.eCheck
    Friend WithEvents chk_yn As Frame7.eCheck
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents to_mon As Frame7.eDate
    Friend WithEvents fr_mon As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton

End Class
