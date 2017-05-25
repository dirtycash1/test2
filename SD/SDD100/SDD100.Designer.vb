<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDD100
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
        Me.sal_no = New Frame7.eText()
        Me.sal_dt = New Frame7.eDate()
        Me.sal_bs = New Frame7.eCombo()
        Me.sal_dept_nm = New Frame7.eText()
        Me.sal_nm = New Frame7.eText()
        Me.ent_bc = New Frame7.eCombo()
        Me.sal_dept = New Frame7.eText()
        Me.sal_rid = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.cust_nm = New Frame7.eText()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.doc_no = New Frame7.eText()
        Me.vat_amt = New Frame7.eText()
        Me.btn_up = New DevExpress.XtraEditors.SimpleButton()
        Me.ex_rt = New Frame7.eText()
        Me.vat_rt = New Frame7.eText()
        Me.tax_no = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.mdt = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.sal_amt = New Frame7.eText()
        Me.mnm = New Frame7.eText()
        Me.rmks = New Frame7.eMemo()
        Me.de_bc = New Frame7.eCombo()
        Me.nat_cd = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.sal_famt = New Frame7.eText()
        Me.vat_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 620)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.sal_no)
        Me.EPanel3.Controls.Add(Me.sal_dt)
        Me.EPanel3.Controls.Add(Me.sal_bs)
        Me.EPanel3.Controls.Add(Me.sal_dept_nm)
        Me.EPanel3.Controls.Add(Me.sal_nm)
        Me.EPanel3.Controls.Add(Me.ent_bc)
        Me.EPanel3.Controls.Add(Me.sal_dept)
        Me.EPanel3.Controls.Add(Me.sal_rid)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1024, 80)
        Me.EPanel3.TabIndex = 4
        Me.EPanel3.Text = "     검색"
        '
        'sal_no
        '
        Me.sal_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_no.Location = New System.Drawing.Point(12, 28)
        Me.sal_no.Name = "sal_no"
        Me.sal_no.Size = New System.Drawing.Size(240, 21)
        Me.sal_no.TabIndex = 96
        Me.sal_no.Title = "매출번호"
        '
        'sal_dt
        '
        Me.sal_dt.Location = New System.Drawing.Point(12, 52)
        Me.sal_dt.Name = "sal_dt"
        Me.sal_dt.Size = New System.Drawing.Size(240, 21)
        Me.sal_dt.TabIndex = 94
        Me.sal_dt.Title = "매출일자"
        '
        'sal_bs
        '
        Me.sal_bs.Location = New System.Drawing.Point(272, 28)
        Me.sal_bs.Name = "sal_bs"
        Me.sal_bs.Size = New System.Drawing.Size(240, 21)
        Me.sal_bs.TabIndex = 95
        Me.sal_bs.Title = "매출사업장"
        '
        'sal_dept_nm
        '
        Me.sal_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_dept_nm.Location = New System.Drawing.Point(272, 52)
        Me.sal_dept_nm.Name = "sal_dept_nm"
        Me.sal_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.sal_dept_nm.TabIndex = 101
        Me.sal_dept_nm.Title = "매출부서"
        '
        'sal_nm
        '
        Me.sal_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_nm.Location = New System.Drawing.Point(532, 28)
        Me.sal_nm.Name = "sal_nm"
        Me.sal_nm.Size = New System.Drawing.Size(240, 21)
        Me.sal_nm.TabIndex = 101
        Me.sal_nm.Title = "매출담당"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(532, 52)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(240, 21)
        Me.ent_bc.TabIndex = 93
        Me.ent_bc.Title = "입력구분"
        '
        'sal_dept
        '
        Me.sal_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_dept.Location = New System.Drawing.Point(804, 32)
        Me.sal_dept.Name = "sal_dept"
        Me.sal_dept.Size = New System.Drawing.Size(92, 21)
        Me.sal_dept.TabIndex = 101
        Me.sal_dept.Title = "sal_dept"
        '
        'sal_rid
        '
        Me.sal_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_rid.Location = New System.Drawing.Point(804, 52)
        Me.sal_rid.Name = "sal_rid"
        Me.sal_rid.Size = New System.Drawing.Size(92, 21)
        Me.sal_rid.TabIndex = 101
        Me.sal_rid.Title = "sal_rid"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.SimpleButton2)
        Me.EPanel1.Controls.Add(Me.doc_no)
        Me.EPanel1.Controls.Add(Me.vat_amt)
        Me.EPanel1.Controls.Add(Me.btn_up)
        Me.EPanel1.Controls.Add(Me.ex_rt)
        Me.EPanel1.Controls.Add(Me.vat_rt)
        Me.EPanel1.Controls.Add(Me.tax_no)
        Me.EPanel1.Controls.Add(Me.tot_amt)
        Me.EPanel1.Controls.Add(Me.mdt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.sal_amt)
        Me.EPanel1.Controls.Add(Me.mnm)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.de_bc)
        Me.EPanel1.Controls.Add(Me.nat_cd)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.sal_famt)
        Me.EPanel1.Controls.Add(Me.vat_bc)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1024, 156)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "검색"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(256, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(256, 21)
        Me.cust_nm.TabIndex = 84
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(796, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 24)
        Me.SimpleButton2.TabIndex = 109
        Me.SimpleButton2.Text = "품목가져오기"
        Me.SimpleButton2.Visible = False
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(532, 32)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 106
        Me.doc_no.Title = "매출전표번호"
        '
        'vat_amt
        '
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(372, 104)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(140, 21)
        Me.vat_amt.TabIndex = 110
        Me.vat_amt.Title = " %"
        Me.vat_amt.TitleWidth = 18
        '
        'btn_up
        '
        Me.btn_up.Location = New System.Drawing.Point(796, 36)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(120, 24)
        Me.btn_up.TabIndex = 109
        Me.btn_up.Text = "최신단가 적용"
        '
        'ex_rt
        '
        Me.ex_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ex_rt.Location = New System.Drawing.Point(12, 80)
        Me.ex_rt.Name = "ex_rt"
        Me.ex_rt.Size = New System.Drawing.Size(240, 21)
        Me.ex_rt.TabIndex = 104
        Me.ex_rt.Title = "환율"
        '
        'vat_rt
        '
        Me.vat_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_rt.Location = New System.Drawing.Point(272, 104)
        Me.vat_rt.Name = "vat_rt"
        Me.vat_rt.Size = New System.Drawing.Size(100, 21)
        Me.vat_rt.TabIndex = 111
        Me.vat_rt.Title = "VAT"
        Me.vat_rt.TitleWidth = 68
        '
        'tax_no
        '
        Me.tax_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_no.Location = New System.Drawing.Point(532, 8)
        Me.tax_no.Name = "tax_no"
        Me.tax_no.Size = New System.Drawing.Size(240, 21)
        Me.tax_no.TabIndex = 105
        Me.tax_no.Title = "세금계산서 번호"
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(272, 128)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 93
        Me.tot_amt.Title = "합계금액"
        '
        'mdt
        '
        Me.mdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mdt.Location = New System.Drawing.Point(532, 80)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(240, 21)
        Me.mdt.TabIndex = 106
        Me.mdt.Title = "등록일"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 85
        Me.cust_cd.Title = "cust_cd"
        '
        'sal_amt
        '
        Me.sal_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_amt.Location = New System.Drawing.Point(272, 80)
        Me.sal_amt.Name = "sal_amt"
        Me.sal_amt.Size = New System.Drawing.Size(240, 21)
        Me.sal_amt.TabIndex = 94
        Me.sal_amt.Title = "매출원화"
        '
        'mnm
        '
        Me.mnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mnm.Location = New System.Drawing.Point(532, 56)
        Me.mnm.Name = "mnm"
        Me.mnm.Size = New System.Drawing.Size(240, 21)
        Me.mnm.TabIndex = 105
        Me.mnm.Title = "등록자"
        '
        'rmks
        '
        Me.rmks.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rmks.Location = New System.Drawing.Point(532, 104)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(428, 44)
        Me.rmks.TabIndex = 60
        Me.rmks.Title = "비고"
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(12, 32)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 21)
        Me.de_bc.TabIndex = 89
        Me.de_bc.Title = "지역구분"
        '
        'nat_cd
        '
        Me.nat_cd.Location = New System.Drawing.Point(12, 56)
        Me.nat_cd.Name = "nat_cd"
        Me.nat_cd.Size = New System.Drawing.Size(240, 21)
        Me.nat_cd.TabIndex = 89
        Me.nat_cd.Title = "국가"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(272, 32)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 91
        Me.cury_bc.Title = "매출통화"
        '
        'sal_famt
        '
        Me.sal_famt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_famt.Location = New System.Drawing.Point(272, 56)
        Me.sal_famt.Name = "sal_famt"
        Me.sal_famt.Size = New System.Drawing.Size(240, 21)
        Me.sal_famt.TabIndex = 91
        Me.sal_famt.Title = "매출금액"
        '
        'vat_bc
        '
        Me.vat_bc.Location = New System.Drawing.Point(12, 104)
        Me.vat_bc.Name = "vat_bc"
        Me.vat_bc.Size = New System.Drawing.Size(240, 21)
        Me.vat_bc.TabIndex = 92
        Me.vat_bc.Title = "부가세구분"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 375)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     매출 정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 350)
        Me.g10.TabIndex = 2
        '
        'SDD100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDD100"
        Me.Size = New System.Drawing.Size(1036, 662)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents vat_bc As Frame7.eCombo
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents de_bc As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents sal_famt As Frame7.eText
    Friend WithEvents rmks As Frame7.eMemo
    Friend WithEvents sal_amt As Frame7.eText
    Friend WithEvents sal_dt As Frame7.eDate
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents tax_no As Frame7.eText
    Friend WithEvents ex_rt As Frame7.eText
    Friend WithEvents sal_nm As Frame7.eText
    Friend WithEvents sal_bs As Frame7.eCombo
    Friend WithEvents sal_no As Frame7.eText
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents sal_dept_nm As Frame7.eText
    Friend WithEvents mdt As Frame7.eText
    Friend WithEvents mnm As Frame7.eText
    Friend WithEvents nat_cd As Frame7.eCombo
    Friend WithEvents vat_rt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents sal_dept As Frame7.eText
    Friend WithEvents sal_rid As Frame7.eText
    Friend WithEvents btn_up As DevExpress.XtraEditors.SimpleButton

End Class
