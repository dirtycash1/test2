<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDD185
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
        Me.print_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.item_amt = New Frame7.eText()
        Me.vat_amt = New Frame7.eText()
        Me.tot_amt = New Frame7.eText()
        Me.doc_dt = New Frame7.eDate()
        Me.doc_no = New Frame7.eText()
        Me.chk_all = New Frame7.eCheck()
        Me.btn_doc = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel1 = New Frame7.ePanel()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.chk_notin = New Frame7.eCheck()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.sal_bs = New Frame7.eCombo()
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
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1120, 584)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel3.Controls.Add(Me.print_btn)
        Me.EPanel3.Controls.Add(Me.item_amt)
        Me.EPanel3.Controls.Add(Me.vat_amt)
        Me.EPanel3.Controls.Add(Me.tot_amt)
        Me.EPanel3.Controls.Add(Me.doc_dt)
        Me.EPanel3.Controls.Add(Me.doc_no)
        Me.EPanel3.Controls.Add(Me.chk_all)
        Me.EPanel3.Controls.Add(Me.btn_doc)
        Me.EPanel3.Controls.Add(Me.btn_jump)
        Me.EPanel3.Controls.Add(Me.btn_delete)
        Me.EPanel3.IconVisible = False
        Me.EPanel3.Location = New System.Drawing.Point(0, 84)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.ShowCaption = False
        Me.EPanel3.Size = New System.Drawing.Size(1120, 65)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "EPanel3"
        '
        'print_btn
        '
        Me.print_btn.Location = New System.Drawing.Point(999, 34)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(91, 24)
        Me.print_btn.TabIndex = 67
        Me.print_btn.Text = "매출전표 인쇄"
        '
        'item_amt
        '
        Me.item_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.item_amt.Location = New System.Drawing.Point(12, 8)
        Me.item_amt.Name = "item_amt"
        Me.item_amt.Size = New System.Drawing.Size(240, 21)
        Me.item_amt.TabIndex = 75
        Me.item_amt.Title = "선택금액"
        '
        'vat_amt
        '
        Me.vat_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vat_amt.Location = New System.Drawing.Point(12, 32)
        Me.vat_amt.Name = "vat_amt"
        Me.vat_amt.Size = New System.Drawing.Size(240, 21)
        Me.vat_amt.TabIndex = 125
        Me.vat_amt.Title = "부가세액"
        '
        'tot_amt
        '
        Me.tot_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_amt.Location = New System.Drawing.Point(264, 32)
        Me.tot_amt.Name = "tot_amt"
        Me.tot_amt.Size = New System.Drawing.Size(240, 21)
        Me.tot_amt.TabIndex = 126
        Me.tot_amt.Title = "합계금액"
        '
        'doc_dt
        '
        Me.doc_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_dt.Location = New System.Drawing.Point(516, 8)
        Me.doc_dt.Name = "doc_dt"
        Me.doc_dt.Size = New System.Drawing.Size(240, 21)
        Me.doc_dt.TabIndex = 124
        Me.doc_dt.Title = "전표발행일"
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(516, 32)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 128
        Me.doc_no.Title = "전표번호"
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(880, 7)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(92, 21)
        Me.chk_all.TabIndex = 127
        Me.chk_all.Title = "전체선택"
        Me.chk_all.TitleWidth = 60
        '
        'btn_doc
        '
        Me.btn_doc.Location = New System.Drawing.Point(768, 6)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(100, 24)
        Me.btn_doc.TabIndex = 65
        Me.btn_doc.Text = "전표 발행"
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(768, 34)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(100, 24)
        Me.btn_jump.TabIndex = 65
        Me.btn_jump.Text = "전표 보기"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(880, 34)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(100, 24)
        Me.btn_delete.TabIndex = 66
        Me.btn_delete.Text = "전표 삭제"
        '
        'EPanel1
        '
        Me.EPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.chk_notin)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.sal_bs)
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1120, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(18, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(220, 21)
        Me.to_dt.TabIndex = 129
        Me.to_dt.Title = "      ~"
        Me.to_dt.TitleWidth = 90
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(18, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(220, 21)
        Me.fr_dt.TabIndex = 128
        Me.fr_dt.Title = "매출 기간"
        Me.fr_dt.TitleWidth = 90
        '
        'chk_notin
        '
        Me.chk_notin.Caption = ""
        Me.chk_notin.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_notin.Location = New System.Drawing.Point(776, 52)
        Me.chk_notin.Name = "chk_notin"
        Me.chk_notin.Size = New System.Drawing.Size(172, 21)
        Me.chk_notin.TabIndex = 127
        Me.chk_notin.Title = "미 발행 조회"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(264, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.Title = "거래처"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(508, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(248, 21)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.Title = "거래처명"
        Me.cust_nm.TitleWidth = 0
        '
        'sal_bs
        '
        Me.sal_bs.Location = New System.Drawing.Point(264, 28)
        Me.sal_bs.Name = "sal_bs"
        Me.sal_bs.Size = New System.Drawing.Size(240, 21)
        Me.sal_bs.TabIndex = 116
        Me.sal_bs.Title = "출하사업장"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1120, 432)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     계산서현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1116, 407)
        Me.g10.TabIndex = 2
        '
        'SDD185
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDD185"
        Me.Size = New System.Drawing.Size(1120, 584)
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
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents item_amt As Frame7.eText
    Friend WithEvents sal_bs As Frame7.eCombo
    Friend WithEvents tot_amt As Frame7.eText
    Friend WithEvents vat_amt As Frame7.eText
    Friend WithEvents doc_dt As Frame7.eDate
    Friend WithEvents chk_notin As Frame7.eCheck
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_doc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents print_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
End Class
