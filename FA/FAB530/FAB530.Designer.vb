<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB530
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
        Me.iss_dt = New Frame7.eDate()
        Me.end_dt = New Frame7.eDate()
        Me.cust_yn = New Frame7.eCheck()
        Me.acct_no = New Frame7.eCombo()
        Me.bank_cd = New Frame7.eCombo()
        Me.pay_kd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.card_nm = New Frame7.eCheckCombo()
        Me.chk_notin = New Frame7.eCheck()
        Me.chk_in = New Frame7.eCheck()
        Me.chk_all = New Frame7.eCheck()
        Me.co_cd = New Frame7.eCombo()
        Me.ok_num = New Frame7.eText()
        Me.div_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to2_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.fr2_dt = New Frame7.eDate()
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.acc_cd = New Frame7.eCheckCombo()
        Me.g10 = New Frame7.eGrid()
        Me.sel_amt = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 360)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.sel_amt)
        Me.EPanel1.Controls.Add(Me.iss_dt)
        Me.EPanel1.Controls.Add(Me.end_dt)
        Me.EPanel1.Controls.Add(Me.cust_yn)
        Me.EPanel1.Controls.Add(Me.acct_no)
        Me.EPanel1.Controls.Add(Me.bank_cd)
        Me.EPanel1.Controls.Add(Me.pay_kd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.chk_notin)
        Me.EPanel1.Controls.Add(Me.chk_in)
        Me.EPanel1.Controls.Add(Me.card_nm)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.ok_num)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.chk_all)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Controls.Add(Me.btn_jump)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.to2_dt)
        Me.EPanel1.Controls.Add(Me.fr2_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 129)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'iss_dt
        '
        Me.iss_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.iss_dt.Location = New System.Drawing.Point(683, 3)
        Me.iss_dt.Name = "iss_dt"
        Me.iss_dt.Size = New System.Drawing.Size(164, 21)
        Me.iss_dt.TabIndex = 92
        Me.iss_dt.Title = "iss_dt"
        Me.iss_dt.TitleWidth = 68
        Me.iss_dt.Visible = False
        '
        'end_dt
        '
        Me.end_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_dt.Location = New System.Drawing.Point(853, 3)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(164, 21)
        Me.end_dt.TabIndex = 91
        Me.end_dt.Title = "end_dt"
        Me.end_dt.TitleWidth = 68
        Me.end_dt.Visible = False
        '
        'cust_yn
        '
        Me.cust_yn.Caption = ""
        Me.cust_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_yn.Location = New System.Drawing.Point(558, 3)
        Me.cust_yn.Name = "cust_yn"
        Me.cust_yn.Size = New System.Drawing.Size(100, 21)
        Me.cust_yn.TabIndex = 93
        Me.cust_yn.Title = "거래처별 행"
        Me.cust_yn.TitleWidth = 78
        Me.cust_yn.Visible = False
        '
        'acct_no
        '
        Me.acct_no.Location = New System.Drawing.Point(772, 76)
        Me.acct_no.Name = "acct_no"
        Me.acct_no.Size = New System.Drawing.Size(248, 21)
        Me.acct_no.TabIndex = 90
        Me.acct_no.Title = "acct_no"
        Me.acct_no.TitleWidth = 98
        '
        'bank_cd
        '
        Me.bank_cd.Location = New System.Drawing.Point(772, 52)
        Me.bank_cd.Name = "bank_cd"
        Me.bank_cd.Size = New System.Drawing.Size(248, 21)
        Me.bank_cd.TabIndex = 89
        Me.bank_cd.Title = "bank_cd"
        Me.bank_cd.TitleWidth = 98
        '
        'pay_kd
        '
        Me.pay_kd.Location = New System.Drawing.Point(772, 28)
        Me.pay_kd.Name = "pay_kd"
        Me.pay_kd.Size = New System.Drawing.Size(248, 21)
        Me.pay_kd.TabIndex = 88
        Me.pay_kd.Title = "pay_kd"
        Me.pay_kd.TitleWidth = 98
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(190, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(246, 21)
        Me.cust_cd.TabIndex = 86
        Me.cust_cd.Title = "거래처"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(437, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(183, 21)
        Me.cust_nm.TabIndex = 87
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'card_nm
        '
        Me.card_nm.Location = New System.Drawing.Point(316, 52)
        Me.card_nm.Name = "card_nm"
        Me.card_nm.Size = New System.Drawing.Size(304, 21)
        Me.card_nm.TabIndex = 85
        Me.card_nm.Title = "금융기관"
        '
        'chk_notin
        '
        Me.chk_notin.Caption = ""
        Me.chk_notin.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_notin.Location = New System.Drawing.Point(644, 28)
        Me.chk_notin.Name = "chk_notin"
        Me.chk_notin.Size = New System.Drawing.Size(100, 21)
        Me.chk_notin.TabIndex = 84
        Me.chk_notin.Title = "미반제"
        Me.chk_notin.TitleWidth = 78
        '
        'chk_in
        '
        Me.chk_in.Caption = ""
        Me.chk_in.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_in.Location = New System.Drawing.Point(644, 55)
        Me.chk_in.Name = "chk_in"
        Me.chk_in.Size = New System.Drawing.Size(100, 21)
        Me.chk_in.TabIndex = 83
        Me.chk_in.Title = "반제완료"
        Me.chk_in.TitleWidth = 78
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(452, 100)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(87, 21)
        Me.chk_all.TabIndex = 82
        Me.chk_all.Title = "전체선택"
        Me.chk_all.TitleForeColor = System.Drawing.Color.Blue
        Me.chk_all.TitleWidth = 70
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(172, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "법인"
        Me.co_cd.TitleWidth = 60
        '
        'ok_num
        '
        Me.ok_num.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ok_num.Location = New System.Drawing.Point(316, 76)
        Me.ok_num.Name = "ok_num"
        Me.ok_num.Size = New System.Drawing.Size(304, 21)
        Me.ok_num.TabIndex = 81
        Me.ok_num.Title = "카드승인번호"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(172, 21)
        Me.div_cd.TabIndex = 2
        Me.div_cd.Title = "회계단위"
        Me.div_cd.TitleWidth = 60
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(172, 21)
        Me.fr_dt.TabIndex = 11
        Me.fr_dt.Title = "전표일자"
        Me.fr_dt.TitleWidth = 60
        '
        'to2_dt
        '
        Me.to2_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to2_dt.Location = New System.Drawing.Point(190, 100)
        Me.to2_dt.Name = "to2_dt"
        Me.to2_dt.Size = New System.Drawing.Size(110, 21)
        Me.to2_dt.TabIndex = 11
        Me.to2_dt.TitleWidth = 0
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(190, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(110, 21)
        Me.to_dt.TabIndex = 11
        Me.to_dt.TitleWidth = 0
        '
        'fr2_dt
        '
        Me.fr2_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr2_dt.Location = New System.Drawing.Point(12, 100)
        Me.fr2_dt.Name = "fr2_dt"
        Me.fr2_dt.Size = New System.Drawing.Size(172, 21)
        Me.fr2_dt.TabIndex = 11
        Me.fr2_dt.Title = "만기일자"
        Me.fr2_dt.TitleWidth = 60
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(316, 100)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(120, 21)
        Me.btn_jump.TabIndex = 12
        Me.btn_jump.Text = "반제처리"
        '
        'acc_cd
        '
        Me.acc_cd.Location = New System.Drawing.Point(772, 100)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(248, 21)
        Me.acc_cd.TabIndex = 13
        Me.acc_cd.Title = "계정명"
        Me.acc_cd.TitleWidth = 98
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 227)
        Me.g10.TabIndex = 3
        '
        'sel_amt
        '
        Me.sel_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sel_amt.Location = New System.Drawing.Point(558, 100)
        Me.sel_amt.Name = "sel_amt"
        Me.sel_amt.Size = New System.Drawing.Size(179, 21)
        Me.sel_amt.TabIndex = 94
        Me.sel_amt.Title = "선택금액"
        Me.sel_amt.TitleWidth = 60
        '
        'FAB530
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB530"
        Me.Size = New System.Drawing.Size(1034, 382)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents acc_cd As Frame7.eCheckCombo
    Friend WithEvents to2_dt As Frame7.eDate
    Friend WithEvents fr2_dt As Frame7.eDate
    Friend WithEvents ok_num As Frame7.eText
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents chk_notin As Frame7.eCheck
    Friend WithEvents chk_in As Frame7.eCheck
    Friend WithEvents card_nm As Frame7.eCheckCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents acct_no As Frame7.eCombo
    Friend WithEvents bank_cd As Frame7.eCombo
    Friend WithEvents pay_kd As Frame7.eCombo
    Friend WithEvents iss_dt As Frame7.eDate
    Friend WithEvents end_dt As Frame7.eDate
    Friend WithEvents cust_yn As Frame7.eCheck
    Friend WithEvents sel_amt As Frame7.eText

End Class
