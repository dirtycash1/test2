<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMR100_KRS
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
        Me.btn_mrp = New DevExpress.XtraEditors.SimpleButton()
        Me.chk_dd_prod = New Frame7.eCheck()
        Me.chk_req_prod = New Frame7.eCheck()
        Me.chk_mm_sales = New Frame7.eCheck()
        Me.day_cnt = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.grp2_cd = New Frame7.eCombo()
        Me.std_dt = New Frame7.eDate()
        Me.grp3_cd = New Frame7.eCombo()
        Me.itm_bc = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.chk_store = New Frame7.eCheck()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 516)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_mrp)
        Me.EPanel1.Controls.Add(Me.chk_dd_prod)
        Me.EPanel1.Controls.Add(Me.chk_req_prod)
        Me.EPanel1.Controls.Add(Me.chk_mm_sales)
        Me.EPanel1.Controls.Add(Me.chk_store)
        Me.EPanel1.Controls.Add(Me.day_cnt)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(956, 131)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'btn_mrp
        '
        Me.btn_mrp.Location = New System.Drawing.Point(648, 102)
        Me.btn_mrp.Name = "btn_mrp"
        Me.btn_mrp.Size = New System.Drawing.Size(176, 24)
        Me.btn_mrp.TabIndex = 62
        Me.btn_mrp.Text = "결품예상 자재 산출"
        '
        'chk_dd_prod
        '
        Me.chk_dd_prod.Caption = ""
        Me.chk_dd_prod.Checked = True
        Me.chk_dd_prod.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_dd_prod.Location = New System.Drawing.Point(652, 52)
        Me.chk_dd_prod.Name = "chk_dd_prod"
        Me.chk_dd_prod.Size = New System.Drawing.Size(143, 21)
        Me.chk_dd_prod.TabIndex = 61
        Me.chk_dd_prod.Title = "일 생산계획 기준"
        '
        'chk_req_prod
        '
        Me.chk_req_prod.Caption = ""
        Me.chk_req_prod.Checked = True
        Me.chk_req_prod.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_req_prod.Location = New System.Drawing.Point(652, 76)
        Me.chk_req_prod.Name = "chk_req_prod"
        Me.chk_req_prod.Size = New System.Drawing.Size(143, 21)
        Me.chk_req_prod.TabIndex = 60
        Me.chk_req_prod.Title = "생산지지 기준"
        '
        'chk_mm_sales
        '
        Me.chk_mm_sales.Caption = ""
        Me.chk_mm_sales.Checked = True
        Me.chk_mm_sales.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_mm_sales.Location = New System.Drawing.Point(652, 28)
        Me.chk_mm_sales.Name = "chk_mm_sales"
        Me.chk_mm_sales.Size = New System.Drawing.Size(143, 21)
        Me.chk_mm_sales.TabIndex = 59
        Me.chk_mm_sales.Title = "월 판매계획 기준"
        '
        'day_cnt
        '
        Me.day_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.day_cnt.Location = New System.Drawing.Point(260, 28)
        Me.day_cnt.Name = "day_cnt"
        Me.day_cnt.Size = New System.Drawing.Size(92, 21)
        Me.day_cnt.TabIndex = 51
        Me.day_cnt.Title = "기간"
        Me.day_cnt.TitleWidth = 40
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(12, 76)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 49
        Me.itm_cd.Title = "품목코드%"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(12, 100)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 50
        Me.itm_nm.Title = "품목명%"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(12, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 32
        Me.fac_cd.Title = "관리공장"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(384, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 41
        Me.grp1_cd.Title = "대분류"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(384, 76)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 42
        Me.grp2_cd.Title = "중분류"
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(12, 28)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 33
        Me.std_dt.Title = "기준일"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(384, 100)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 43
        Me.grp3_cd.Title = "소분류"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(384, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 40
        Me.itm_bc.Title = "품목구분"
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
        Me.EPanel3.Text = "     생산계획 품목"
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
        'chk_store
        '
        Me.chk_store.Caption = ""
        Me.chk_store.Checked = True
        Me.chk_store.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_store.Location = New System.Drawing.Point(801, 28)
        Me.chk_store.Name = "chk_store"
        Me.chk_store.Size = New System.Drawing.Size(150, 21)
        Me.chk_store.TabIndex = 60
        Me.chk_store.Title = "재공재고포함"
        '
        'MMR100_KRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMR100_KRS"
        Me.Size = New System.Drawing.Size(977, 563)
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
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents day_cnt As Frame7.eText
    Friend WithEvents chk_dd_prod As Frame7.eCheck
    Friend WithEvents chk_req_prod As Frame7.eCheck
    Friend WithEvents chk_mm_sales As Frame7.eCheck
    Friend WithEvents btn_mrp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents chk_store As Frame7.eCheck

End Class
