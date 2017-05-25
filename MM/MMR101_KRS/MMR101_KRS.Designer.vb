<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMR101_KRS
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
        Me.plan_rev = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.plan_t_mon = New Frame7.eDate()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.work_ty = New Frame7.eText()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.itm_cd = New Frame7.eText()
        Me.btn_amt = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_amt = New Frame7.eCheck()
        Me.btn_mrp = New DevExpress.XtraEditors.SimpleButton()
        Me.itm_nm = New Frame7.eText()
        Me.chk_stk = New Frame7.eCheck()
        Me.plan_f_mon = New Frame7.eDate()
        Me.grp1_cd = New Frame7.eCombo()
        Me.grp2_cd = New Frame7.eCombo()
        Me.grp3_cd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.itm_bc = New Frame7.eCheckCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 516)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.plan_rev)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.plan_t_mon)
        Me.EPanel1.Controls.Add(Me.r1)
        Me.EPanel1.Controls.Add(Me.work_ty)
        Me.EPanel1.Controls.Add(Me.r2)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.btn_amt)
        Me.EPanel1.Controls.Add(Me.chk_amt)
        Me.EPanel1.Controls.Add(Me.btn_mrp)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.chk_stk)
        Me.EPanel1.Controls.Add(Me.plan_f_mon)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(956, 131)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'plan_rev
        '
        Me.plan_rev.Location = New System.Drawing.Point(12, 100)
        Me.plan_rev.Name = "plan_rev"
        Me.plan_rev.Size = New System.Drawing.Size(240, 21)
        Me.plan_rev.TabIndex = 70
        Me.plan_rev.Title = "생산계획차수"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 67
        Me.co_cd.Title = "사업장"
        '
        'plan_t_mon
        '
        Me.plan_t_mon.Format = "yyyy-MM"
        Me.plan_t_mon.Location = New System.Drawing.Point(132, 76)
        Me.plan_t_mon.Name = "plan_t_mon"
        Me.plan_t_mon.Size = New System.Drawing.Size(120, 21)
        Me.plan_t_mon.TabIndex = 63
        Me.plan_t_mon.Title = "기준일"
        Me.plan_t_mon.TitleWidth = 0
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Location = New System.Drawing.Point(827, 84)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(109, 18)
        Me.r1.TabIndex = 69
        Me.r1.TabStop = True
        Me.r1.Text = "년생산계획정보"
        Me.r1.UseVisualStyleBackColor = True
        '
        'work_ty
        '
        Me.work_ty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_ty.Location = New System.Drawing.Point(703, 84)
        Me.work_ty.Name = "work_ty"
        Me.work_ty.Size = New System.Drawing.Size(118, 21)
        Me.work_ty.TabIndex = 68
        Me.work_ty.Title = "작업구분"
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Location = New System.Drawing.Point(827, 106)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(109, 18)
        Me.r2.TabIndex = 69
        Me.r2.TabStop = True
        Me.r2.Text = "월생산계획정보"
        Me.r2.UseVisualStyleBackColor = True
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(544, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 49
        Me.itm_cd.Title = "품목코드%"
        '
        'btn_amt
        '
        Me.btn_amt.Location = New System.Drawing.Point(790, 54)
        Me.btn_amt.Name = "btn_amt"
        Me.btn_amt.Size = New System.Drawing.Size(161, 24)
        Me.btn_amt.TabIndex = 64
        Me.btn_amt.Text = "금액 재계산"
        '
        'chk_amt
        '
        Me.chk_amt.Caption = ""
        Me.chk_amt.Checked = True
        Me.chk_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_amt.Location = New System.Drawing.Point(544, 76)
        Me.chk_amt.Name = "chk_amt"
        Me.chk_amt.Size = New System.Drawing.Size(172, 21)
        Me.chk_amt.TabIndex = 60
        Me.chk_amt.Title = "금액보기"
        '
        'btn_mrp
        '
        Me.btn_mrp.Location = New System.Drawing.Point(790, 28)
        Me.btn_mrp.Name = "btn_mrp"
        Me.btn_mrp.Size = New System.Drawing.Size(161, 24)
        Me.btn_mrp.TabIndex = 62
        Me.btn_mrp.Text = "월생산계획 소요량산출"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(544, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 50
        Me.itm_nm.Title = "품목명%"
        '
        'chk_stk
        '
        Me.chk_stk.Caption = ""
        Me.chk_stk.Checked = True
        Me.chk_stk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_stk.Location = New System.Drawing.Point(544, 100)
        Me.chk_stk.Name = "chk_stk"
        Me.chk_stk.Size = New System.Drawing.Size(172, 21)
        Me.chk_stk.TabIndex = 60
        Me.chk_stk.Title = "재공재고포함"
        '
        'plan_f_mon
        '
        Me.plan_f_mon.Format = "yyyy-MM"
        Me.plan_f_mon.Location = New System.Drawing.Point(12, 52)
        Me.plan_f_mon.Name = "plan_f_mon"
        Me.plan_f_mon.Size = New System.Drawing.Size(240, 21)
        Me.plan_f_mon.TabIndex = 33
        Me.plan_f_mon.Title = "생산계획 년월"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(276, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 41
        Me.grp1_cd.Title = "대분류"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(276, 76)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 42
        Me.grp2_cd.Title = "중분류"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(276, 100)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 43
        Me.grp3_cd.Title = "소분류"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(956, 381)
        Me.SplitContainer2.SplitterDistance = 218
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(956, 218)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     자재 결품 예상 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(952, 193)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(956, 159)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     월 생산계획 품목"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(952, 134)
        Me.g20.TabIndex = 2
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(277, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(239, 21)
        Me.itm_bc.TabIndex = 71
        Me.itm_bc.Title = "품목구분"
        '
        'MMR101_KRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMR101_KRS"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
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
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents btn_amt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents plan_t_mon As Frame7.eDate
    Friend WithEvents btn_mrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents chk_amt As Frame7.eCheck
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents chk_stk As Frame7.eCheck
    Friend WithEvents plan_f_mon As Frame7.eDate
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents work_ty As Frame7.eText
    Friend WithEvents r1 As System.Windows.Forms.RadioButton
    Friend WithEvents r2 As System.Windows.Forms.RadioButton
    Friend WithEvents plan_rev As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCheckCombo

End Class
