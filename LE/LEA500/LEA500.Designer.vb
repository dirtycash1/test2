<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEA500
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
        Me.EPanel4 = New Frame7.ePanel()
        Me.btn_doc_yn = New DevExpress.XtraEditors.SimpleButton()
        Me.tot_cnt = New Frame7.eText()
        Me.chk_all = New Frame7.eCheck()
        Me.itm_amt = New Frame7.eText()
        Me.btn_doc = New DevExpress.XtraEditors.SimpleButton()
        Me.vat_rt = New Frame7.eText()
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.tot_qty = New Frame7.eText()
        Me.set_dt = New Frame7.eDate()
        Me.doc_no = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.btn_up = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_show = New Frame7.eCheck()
        Me.vat_amt = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.fac_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.chk_set = New Frame7.eCheck()
        Me.wh_cd = New Frame7.eCombo()
        Me.echeck_doc_yn = New Frame7.eCheck()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.itm_nm = New Frame7.eText()
        Me.itm_bc = New Frame7.eCombo()
        Me.chk_notin = New Frame7.eCheck()
        Me.itm_cd = New Frame7.eText()
        Me.chk_in = New Frame7.eCheck()
        Me.doc_yn = New Frame7.eCheck()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 582)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel4.Controls.Add(Me.btn_doc_yn)
        Me.EPanel4.Controls.Add(Me.tot_cnt)
        Me.EPanel4.Controls.Add(Me.chk_all)
        Me.EPanel4.Controls.Add(Me.itm_amt)
        Me.EPanel4.Controls.Add(Me.btn_doc)
        Me.EPanel4.Controls.Add(Me.vat_rt)
        Me.EPanel4.Controls.Add(Me.btn_jump)
        Me.EPanel4.Controls.Add(Me.btn_delete)
        Me.EPanel4.Controls.Add(Me.tot_qty)
        Me.EPanel4.Controls.Add(Me.set_dt)
        Me.EPanel4.Controls.Add(Me.doc_no)
        Me.EPanel4.Controls.Add(Me.tot_amt)
        Me.EPanel4.Controls.Add(Me.btn_up)
        Me.EPanel4.Controls.Add(Me.chk_show)
        Me.EPanel4.Controls.Add(Me.vat_amt)
        Me.EPanel4.IconVisible = False
        Me.EPanel4.Location = New System.Drawing.Point(0, 108)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.ShowCaption = False
        Me.EPanel4.Size = New System.Drawing.Size(1034, 90)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "EPanel4"
        '
        'btn_doc_yn
        '
        Me.btn_doc_yn.Location = New System.Drawing.Point(904, 59)
        Me.btn_doc_yn.Name = "btn_doc_yn"
        Me.btn_doc_yn.Size = New System.Drawing.Size(122, 24)
        Me.btn_doc_yn.TabIndex = 142
        Me.btn_doc_yn.Text = "전표 강제미발행"
        '
        'tot_cnt
        '
        Me.tot_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_cnt.Location = New System.Drawing.Point(12, 8)
        Me.tot_cnt.Name = "tot_cnt"
        Me.tot_cnt.Size = New System.Drawing.Size(240, 21)
        Me.tot_cnt.TabIndex = 131
        Me.tot_cnt.Title = "선택건수"
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(516, 63)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(112, 21)
        Me.chk_all.TabIndex = 136
        Me.chk_all.Title = "전체선택"
        Me.chk_all.TitleWidth = 88
        '
        'itm_amt
        '
        Me.itm_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_amt.Location = New System.Drawing.Point(264, 8)
        Me.itm_amt.Name = "itm_amt"
        Me.itm_amt.Size = New System.Drawing.Size(240, 21)
        Me.itm_amt.TabIndex = 131
        Me.itm_amt.Title = "선택금액"
        '
        'btn_doc
        '
        Me.btn_doc.Location = New System.Drawing.Point(768, 4)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(112, 24)
        Me.btn_doc.TabIndex = 129
        Me.btn_doc.Text = "전표 발행"
        '
        'vat_rt
        '
        Me.vat_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_rt.Location = New System.Drawing.Point(264, 32)
        Me.vat_rt.Name = "vat_rt"
        Me.vat_rt.Size = New System.Drawing.Size(100, 21)
        Me.vat_rt.TabIndex = 133
        Me.vat_rt.Title = "부가세액"
        Me.vat_rt.TitleWidth = 60
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(768, 32)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(112, 24)
        Me.btn_jump.TabIndex = 130
        Me.btn_jump.Text = "전표 보기"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(768, 60)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 24)
        Me.btn_delete.TabIndex = 130
        Me.btn_delete.Text = "전표 삭제"
        '
        'tot_qty
        '
        Me.tot_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_qty.Location = New System.Drawing.Point(12, 32)
        Me.tot_qty.Name = "tot_qty"
        Me.tot_qty.Size = New System.Drawing.Size(240, 21)
        Me.tot_qty.TabIndex = 133
        Me.tot_qty.Title = "선택수량"
        '
        'set_dt
        '
        Me.set_dt.Location = New System.Drawing.Point(516, 8)
        Me.set_dt.Name = "set_dt"
        Me.set_dt.Size = New System.Drawing.Size(240, 21)
        Me.set_dt.TabIndex = 132
        Me.set_dt.Title = "전표일자"
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(516, 32)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 135
        Me.doc_no.Title = "전표번호"
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(264, 56)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 134
        Me.tot_amt.Title = "합계금액"
        '
        'btn_up
        '
        Me.btn_up.Location = New System.Drawing.Point(636, 60)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(120, 24)
        Me.btn_up.TabIndex = 130
        Me.btn_up.Text = "최신단가 적용"
        '
        'chk_show
        '
        Me.chk_show.Caption = ""
        Me.chk_show.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_show.Location = New System.Drawing.Point(12, 62)
        Me.chk_show.Name = "chk_show"
        Me.chk_show.Size = New System.Drawing.Size(164, 21)
        Me.chk_show.TabIndex = 141
        Me.chk_show.Title = "전표 내역 보기"
        '
        'vat_amt
        '
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(264, 32)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(240, 21)
        Me.vat_amt.TabIndex = 133
        Me.vat_amt.Title = "부가세액             %"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.chk_set)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.echeck_doc_yn)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.chk_notin)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.chk_in)
        Me.EPanel1.Controls.Add(Me.doc_yn)
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1034, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(264, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 139
        Me.fac_cd.Title = "입고공장"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 114
        Me.fr_dt.Title = "입고일자"
        '
        'chk_set
        '
        Me.chk_set.Caption = ""
        Me.chk_set.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_set.Location = New System.Drawing.Point(914, 76)
        Me.chk_set.Name = "chk_set"
        Me.chk_set.Size = New System.Drawing.Size(97, 21)
        Me.chk_set.TabIndex = 142
        Me.chk_set.Title = "수입입고건"
        Me.chk_set.TitleWidth = 70
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(264, 52)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 140
        Me.wh_cd.Title = "입고창고"
        '
        'echeck_doc_yn
        '
        Me.echeck_doc_yn.Caption = ""
        Me.echeck_doc_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.echeck_doc_yn.Location = New System.Drawing.Point(914, 52)
        Me.echeck_doc_yn.Name = "echeck_doc_yn"
        Me.echeck_doc_yn.Size = New System.Drawing.Size(159, 21)
        Me.echeck_doc_yn.TabIndex = 143
        Me.echeck_doc_yn.Title = "전표 강제미발행건 제외"
        Me.echeck_doc_yn.TitleWidth = 130
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.Title = "거래처"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(256, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(248, 21)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 115
        Me.to_dt.Title = "부터"
        Me.to_dt.TitleWidth = 0
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(516, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 138
        Me.itm_nm.Title = "품목명 %"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(516, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 136
        Me.itm_bc.Title = "품목구분"
        '
        'chk_notin
        '
        Me.chk_notin.Caption = ""
        Me.chk_notin.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_notin.Location = New System.Drawing.Point(768, 28)
        Me.chk_notin.Name = "chk_notin"
        Me.chk_notin.Size = New System.Drawing.Size(172, 21)
        Me.chk_notin.TabIndex = 128
        Me.chk_notin.Title = "미발행 조회"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(516, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 137
        Me.itm_cd.Title = "품목코드 %"
        '
        'chk_in
        '
        Me.chk_in.Caption = ""
        Me.chk_in.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_in.Location = New System.Drawing.Point(768, 52)
        Me.chk_in.Name = "chk_in"
        Me.chk_in.Size = New System.Drawing.Size(172, 21)
        Me.chk_in.TabIndex = 128
        Me.chk_in.Title = "발행 조회"
        '
        'doc_yn
        '
        Me.doc_yn.Caption = ""
        Me.doc_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_yn.Location = New System.Drawing.Point(768, 76)
        Me.doc_yn.Name = "doc_yn"
        Me.doc_yn.Size = New System.Drawing.Size(172, 21)
        Me.doc_yn.TabIndex = 128
        Me.doc_yn.Title = "전표발행건 제외"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Size = New System.Drawing.Size(1034, 380)
        Me.SplitContainer3.SplitterDistance = 209
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(209, 380)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     매입전표 정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(205, 355)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(821, 380)
        Me.EPanel3.TabIndex = 3
        Me.EPanel3.Text = "     매입상세 정보"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(817, 355)
        Me.g20.TabIndex = 2
        '
        'LEA500
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEA500"
        Me.Size = New System.Drawing.Size(1034, 582)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents chk_notin As Frame7.eCheck
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_doc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents set_dt As Frame7.eDate
    Friend WithEvents itm_amt As Frame7.eText
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents chk_show As Frame7.eCheck
    Friend WithEvents btn_up As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents tot_cnt As Frame7.eText
    Friend WithEvents tot_qty As Frame7.eText
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_in As Frame7.eCheck
    Friend WithEvents vat_rt As Frame7.eText
    Friend WithEvents doc_yn As Frame7.eCheck
    Friend WithEvents chk_set As Frame7.eCheck
    Friend WithEvents echeck_doc_yn As Frame7.eCheck
    Friend WithEvents btn_doc_yn As DevExpress.XtraEditors.SimpleButton

End Class
