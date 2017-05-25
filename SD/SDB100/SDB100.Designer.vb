<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDB100
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
        Me.vat_rt = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.cust_cd2 = New Frame7.eText()
        Me.cust_nm2 = New Frame7.eText()
        Me.req_doc = New Frame7.eText()
        Me.de_bc = New Frame7.eCombo()
        Me.nat_cd = New Frame7.eCombo()
        Me.mnm = New Frame7.eText()
        Me.mdt = New Frame7.eDate()
        Me.union_yn = New Frame7.eText()
        Me.setl_bc = New Frame7.eCombo()
        Me.vat_bc = New Frame7.eCombo()
        Me.stat_bc = New Frame7.eCombo()
        Me.rmks = New Frame7.eMemo()
        Me.so_dept = New Frame7.eText()
        Me.cust_po = New Frame7.eText()
        Me.so_rid = New Frame7.eText()
        Me.cury_bc = New Frame7.eCombo()
        Me.so_amt = New Frame7.eText()
        Me.sal_bc = New Frame7.eCombo()
        Me.btn_cust_items = New DevExpress.XtraEditors.SimpleButton()
        Me.so_vat = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.dlv_yard = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.so_no = New Frame7.eText()
        Me.so_bs = New Frame7.eCombo()
        Me.so_dt = New Frame7.eDate()
        Me.dlv_dt = New Frame7.eDate()
        Me.so_dept_nm = New Frame7.eText()
        Me.so_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 488)
        Me.SplitContainer1.SplitterDistance = 244
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.vat_rt)
        Me.EPanel1.Controls.Add(Me.cust_cd2)
        Me.EPanel1.Controls.Add(Me.cust_nm2)
        Me.EPanel1.Controls.Add(Me.req_doc)
        Me.EPanel1.Controls.Add(Me.de_bc)
        Me.EPanel1.Controls.Add(Me.nat_cd)
        Me.EPanel1.Controls.Add(Me.union_yn)
        Me.EPanel1.Controls.Add(Me.mnm)
        Me.EPanel1.Controls.Add(Me.setl_bc)
        Me.EPanel1.Controls.Add(Me.mdt)
        Me.EPanel1.Controls.Add(Me.vat_bc)
        Me.EPanel1.Controls.Add(Me.so_dept)
        Me.EPanel1.Controls.Add(Me.cust_po)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.so_rid)
        Me.EPanel1.Controls.Add(Me.sal_bc)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.so_amt)
        Me.EPanel1.Controls.Add(Me.tot_amt)
        Me.EPanel1.Controls.Add(Me.btn_cust_items)
        Me.EPanel1.Controls.Add(Me.so_vat)
        Me.EPanel1.Controls.Add(Me.dlv_yard)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 84)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(1028, 160)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "검색"
        '
        'vat_rt
        '
        Me.vat_rt.Location = New System.Drawing.Point(272, 104)
        Me.vat_rt.Name = "vat_rt"
        Me.vat_rt.Size = New System.Drawing.Size(100, 21)
        Me.vat_rt.TabIndex = 96
        Me.vat_rt.Title = "VAT"
        Me.vat_rt.TitleWidth = 68
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(12, 8)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 85
        Me.cust_cd.Title = "출하거래처"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(254, 8)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(258, 21)
        Me.cust_nm.TabIndex = 84
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'cust_cd2
        '
        Me.cust_cd2.Location = New System.Drawing.Point(12, 32)
        Me.cust_cd2.Name = "cust_cd2"
        Me.cust_cd2.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd2.TabIndex = 87
        Me.cust_cd2.Title = "매출거래처"
        '
        'cust_nm2
        '
        Me.cust_nm2.Location = New System.Drawing.Point(254, 32)
        Me.cust_nm2.Name = "cust_nm2"
        Me.cust_nm2.Size = New System.Drawing.Size(258, 21)
        Me.cust_nm2.TabIndex = 86
        Me.cust_nm2.Title = "출고번호"
        Me.cust_nm2.TitleWidth = 0
        '
        'req_doc
        '
        Me.req_doc.Location = New System.Drawing.Point(756, 212)
        Me.req_doc.Name = "req_doc"
        Me.req_doc.Size = New System.Drawing.Size(240, 21)
        Me.req_doc.TabIndex = 82
        Me.req_doc.Title = "요청서류"
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(12, 56)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 21)
        Me.de_bc.TabIndex = 89
        Me.de_bc.Title = "지역구분"
        '
        'nat_cd
        '
        Me.nat_cd.Location = New System.Drawing.Point(12, 80)
        Me.nat_cd.Name = "nat_cd"
        Me.nat_cd.Size = New System.Drawing.Size(240, 21)
        Me.nat_cd.TabIndex = 88
        Me.nat_cd.Title = "국가"
        '
        'mnm
        '
        Me.mnm.Location = New System.Drawing.Point(532, 8)
        Me.mnm.Name = "mnm"
        Me.mnm.Size = New System.Drawing.Size(240, 21)
        Me.mnm.TabIndex = 79
        Me.mnm.Title = "등록자"
        '
        'mdt
        '
        Me.mdt.Location = New System.Drawing.Point(532, 32)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(240, 21)
        Me.mdt.TabIndex = 95
        Me.mdt.Title = "등록일"
        '
        'union_yn
        '
        Me.union_yn.Location = New System.Drawing.Point(940, 60)
        Me.union_yn.Name = "union_yn"
        Me.union_yn.Size = New System.Drawing.Size(88, 21)
        Me.union_yn.TabIndex = 97
        Me.union_yn.Title = "union_yn"
        '
        'setl_bc
        '
        Me.setl_bc.Location = New System.Drawing.Point(940, 108)
        Me.setl_bc.Name = "setl_bc"
        Me.setl_bc.Size = New System.Drawing.Size(240, 21)
        Me.setl_bc.TabIndex = 93
        Me.setl_bc.Title = "결재조건"
        '
        'vat_bc
        '
        Me.vat_bc.Location = New System.Drawing.Point(12, 104)
        Me.vat_bc.Name = "vat_bc"
        Me.vat_bc.Size = New System.Drawing.Size(240, 21)
        Me.vat_bc.TabIndex = 92
        Me.vat_bc.Title = "부가세구분"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(532, 56)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 80
        Me.stat_bc.Title = "진행상태"
        '
        'rmks
        '
        Me.rmks.Location = New System.Drawing.Point(532, 104)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(396, 46)
        Me.rmks.TabIndex = 60
        Me.rmks.Title = "비고"
        '
        'so_dept
        '
        Me.so_dept.Location = New System.Drawing.Point(940, 12)
        Me.so_dept.Name = "so_dept"
        Me.so_dept.Size = New System.Drawing.Size(72, 21)
        Me.so_dept.TabIndex = 73
        Me.so_dept.Title = "so_dept"
        '
        'cust_po
        '
        Me.cust_po.Location = New System.Drawing.Point(940, 84)
        Me.cust_po.Name = "cust_po"
        Me.cust_po.Size = New System.Drawing.Size(240, 21)
        Me.cust_po.TabIndex = 83
        Me.cust_po.Title = "PO No."
        '
        'so_rid
        '
        Me.so_rid.Location = New System.Drawing.Point(940, 36)
        Me.so_rid.Name = "so_rid"
        Me.so_rid.Size = New System.Drawing.Size(44, 21)
        Me.so_rid.TabIndex = 71
        Me.so_rid.Title = "so_rid"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(272, 56)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 91
        Me.cury_bc.Title = "수주통화"
        '
        'so_amt
        '
        Me.so_amt.Location = New System.Drawing.Point(272, 80)
        Me.so_amt.Name = "so_amt"
        Me.so_amt.Size = New System.Drawing.Size(240, 21)
        Me.so_amt.TabIndex = 91
        Me.so_amt.Title = "수주금액"
        '
        'sal_bc
        '
        Me.sal_bc.Location = New System.Drawing.Point(12, 128)
        Me.sal_bc.Name = "sal_bc"
        Me.sal_bc.Size = New System.Drawing.Size(240, 21)
        Me.sal_bc.TabIndex = 81
        Me.sal_bc.Title = "출하구분"
        '
        'btn_cust_items
        '
        Me.btn_cust_items.Location = New System.Drawing.Point(800, 12)
        Me.btn_cust_items.Name = "btn_cust_items"
        Me.btn_cust_items.Size = New System.Drawing.Size(100, 24)
        Me.btn_cust_items.TabIndex = 94
        Me.btn_cust_items.Text = "품목가져오기"
        '
        'so_vat
        '
        Me.so_vat.Location = New System.Drawing.Point(372, 104)
        Me.so_vat.Name = "so_vat"
        Me.so_vat.Size = New System.Drawing.Size(140, 21)
        Me.so_vat.TabIndex = 92
        Me.so_vat.Title = " %"
        Me.so_vat.TitleWidth = 18
        '
        'tot_amt
        '
        Me.tot_amt.Location = New System.Drawing.Point(272, 128)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 91
        Me.tot_amt.Title = "합계"
        '
        'dlv_yard
        '
        Me.dlv_yard.Location = New System.Drawing.Point(532, 80)
        Me.dlv_yard.Name = "dlv_yard"
        Me.dlv_yard.Size = New System.Drawing.Size(396, 21)
        Me.dlv_yard.TabIndex = 90
        Me.dlv_yard.Title = "도착지"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.so_no)
        Me.EPanel3.Controls.Add(Me.so_dt)
        Me.EPanel3.Controls.Add(Me.so_bs)
        Me.EPanel3.Controls.Add(Me.dlv_dt)
        Me.EPanel3.Controls.Add(Me.so_dept_nm)
        Me.EPanel3.Controls.Add(Me.so_nm)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1028, 80)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     수주정보"
        '
        'so_no
        '
        Me.so_no.Location = New System.Drawing.Point(12, 28)
        Me.so_no.Name = "so_no"
        Me.so_no.Size = New System.Drawing.Size(240, 21)
        Me.so_no.TabIndex = 59
        Me.so_no.Title = "수주번호"
        '
        'so_bs
        '
        Me.so_bs.Location = New System.Drawing.Point(272, 28)
        Me.so_bs.Name = "so_bs"
        Me.so_bs.Size = New System.Drawing.Size(240, 21)
        Me.so_bs.TabIndex = 57
        Me.so_bs.Title = "수주사업장"
        '
        'so_dt
        '
        Me.so_dt.Location = New System.Drawing.Point(12, 52)
        Me.so_dt.Name = "so_dt"
        Me.so_dt.Size = New System.Drawing.Size(240, 21)
        Me.so_dt.TabIndex = 58
        Me.so_dt.Title = "수주일자"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(272, 52)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 96
        Me.dlv_dt.Title = "납기일자"
        '
        'so_dept_nm
        '
        Me.so_dept_nm.Location = New System.Drawing.Point(532, 28)
        Me.so_dept_nm.Name = "so_dept_nm"
        Me.so_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.so_dept_nm.TabIndex = 72
        Me.so_dept_nm.Title = "수주부서"
        '
        'so_nm
        '
        Me.so_nm.Location = New System.Drawing.Point(532, 52)
        Me.so_nm.Name = "so_nm"
        Me.so_nm.Size = New System.Drawing.Size(240, 21)
        Me.so_nm.TabIndex = 70
        Me.so_nm.Title = "수주담당"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1028, 240)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     수주상세 정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1024, 215)
        Me.g10.TabIndex = 2
        '
        'SDB100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDB100"
        Me.Size = New System.Drawing.Size(1034, 522)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents so_no As Frame7.eText
    Friend WithEvents so_dt As Frame7.eDate
    Friend WithEvents so_bs As Frame7.eCombo
    Friend WithEvents mnm As Frame7.eText
    Friend WithEvents so_dept As Frame7.eText
    Friend WithEvents so_dept_nm As Frame7.eText
    Friend WithEvents so_nm As Frame7.eText
    Friend WithEvents so_rid As Frame7.eText
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents sal_bc As Frame7.eCombo
    Friend WithEvents btn_cust_items As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents setl_bc As Frame7.eCombo
    Friend WithEvents vat_bc As Frame7.eCombo
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents dlv_yard As Frame7.eText
    Friend WithEvents de_bc As Frame7.eCombo
    Friend WithEvents nat_cd As Frame7.eCombo
    Friend WithEvents cust_cd2 As Frame7.eText
    Friend WithEvents cust_nm2 As Frame7.eText
    Friend WithEvents req_doc As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_po As Frame7.eText
    Friend WithEvents mdt As Frame7.eDate
    Friend WithEvents so_vat As Frame7.eText
    Friend WithEvents so_amt As Frame7.eText
    Friend WithEvents rmks As Frame7.eMemo
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents vat_rt As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents union_yn As Frame7.eText

End Class
