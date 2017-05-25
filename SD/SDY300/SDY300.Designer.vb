<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDY300
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
        Me.plan_mon = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.item_yn = New Frame7.eCheck()
        Me.cust_cd = New Frame7.eText()
        Me.plan_rev = New Frame7.eCombo()
        Me.show_bc = New Frame7.eCheckCombo()
        Me.btn_amt = New DevExpress.XtraEditors.SimpleButton()
        Me.trans_bc = New Frame7.eCombo()
        Me.btn_trans = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_plan_rev = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1076, 360)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.plan_mon)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.item_yn)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.plan_rev)
        Me.EPanel1.Controls.Add(Me.show_bc)
        Me.EPanel1.Controls.Add(Me.btn_amt)
        Me.EPanel1.Controls.Add(Me.trans_bc)
        Me.EPanel1.Controls.Add(Me.btn_trans)
        Me.EPanel1.Controls.Add(Me.fr_plan_rev)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1076, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'plan_mon
        '
        Me.plan_mon.Format = "yyyy"
        Me.plan_mon.Location = New System.Drawing.Point(12, 52)
        Me.plan_mon.Name = "plan_mon"
        Me.plan_mon.Size = New System.Drawing.Size(240, 21)
        Me.plan_mon.TabIndex = 19
        Me.plan_mon.Title = "plan_mon"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 17
        Me.co_cd.Title = "co_cd"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(504, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(244, 21)
        Me.cust_nm.TabIndex = 22
        Me.cust_nm.TitleWidth = 0
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(260, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 16
        Me.fac_cd.Title = "fac_cd"
        '
        'item_yn
        '
        Me.item_yn.Caption = ""
        Me.item_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.item_yn.Location = New System.Drawing.Point(516, 44)
        Me.item_yn.Name = "item_yn"
        Me.item_yn.Size = New System.Drawing.Size(84, 21)
        Me.item_yn.TabIndex = 25
        Me.item_yn.Title = "item_yn"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(260, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 23
        Me.cust_cd.Title = "cust_cd"
        '
        'plan_rev
        '
        Me.plan_rev.Location = New System.Drawing.Point(12, 76)
        Me.plan_rev.Name = "plan_rev"
        Me.plan_rev.Size = New System.Drawing.Size(240, 21)
        Me.plan_rev.TabIndex = 18
        Me.plan_rev.Title = "plan_rev"
        '
        'show_bc
        '
        Me.show_bc.Location = New System.Drawing.Point(260, 52)
        Me.show_bc.Name = "show_bc"
        Me.show_bc.Size = New System.Drawing.Size(240, 21)
        Me.show_bc.TabIndex = 24
        Me.show_bc.Title = "show_bc"
        '
        'btn_amt
        '
        Me.btn_amt.Location = New System.Drawing.Point(636, 48)
        Me.btn_amt.Name = "btn_amt"
        Me.btn_amt.Size = New System.Drawing.Size(112, 23)
        Me.btn_amt.TabIndex = 21
        Me.btn_amt.Text = "단가적용"
        '
        'trans_bc
        '
        Me.trans_bc.Location = New System.Drawing.Point(900, 48)
        Me.trans_bc.Name = "trans_bc"
        Me.trans_bc.Size = New System.Drawing.Size(164, 21)
        Me.trans_bc.TabIndex = 27
        Me.trans_bc.TitleWidth = 0
        '
        'btn_trans
        '
        Me.btn_trans.Location = New System.Drawing.Point(796, 48)
        Me.btn_trans.Name = "btn_trans"
        Me.btn_trans.Size = New System.Drawing.Size(100, 23)
        Me.btn_trans.TabIndex = 20
        Me.btn_trans.Text = "가져오기"
        '
        'fr_plan_rev
        '
        Me.fr_plan_rev.Location = New System.Drawing.Point(780, 72)
        Me.fr_plan_rev.Name = "fr_plan_rev"
        Me.fr_plan_rev.Size = New System.Drawing.Size(284, 21)
        Me.fr_plan_rev.TabIndex = 26
        Me.fr_plan_rev.Title = "fr_plan_rev"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1076, 253)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     3개월 판매계획 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1072, 228)
        Me.g10.TabIndex = 2
        '
        'SDY300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDY300"
        Me.Size = New System.Drawing.Size(1154, 388)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents plan_mon As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents item_yn As Frame7.eCheck
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents plan_rev As Frame7.eCombo
    Friend WithEvents show_bc As Frame7.eCheckCombo
    Friend WithEvents btn_amt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents trans_bc As Frame7.eCombo
    Friend WithEvents btn_trans As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fr_plan_rev As Frame7.eCombo

End Class
