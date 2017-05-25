<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMR100
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.to_dt = New Frame7.eDate()
        Me.f_fa_no = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.labor_amt = New Frame7.eText()
        Me.work_tm = New Frame7.eText()
        Me.part_nm = New Frame7.eText()
        Me.part_mk = New Frame7.eText()
        Me.part_qty = New Frame7.eText()
        Me.part_no = New Frame7.eText()
        Me.rep_dsc = New Frame7.eMemo()
        Me.iss_dsc = New Frame7.eMemo()
        Me.fac_cd = New Frame7.eCombo()
        Me.wc_cd = New Frame7.eCombo()
        Me.break_bc = New Frame7.eCombo()
        Me.fa_no = New Frame7.eText()
        Me.reason_bc = New Frame7.eCombo()
        Me.rep_tm = New Frame7.eText()
        Me.rep_bc = New Frame7.eCombo()
        Me.rep_dt = New Frame7.eDate()
        Me.iss_tm = New Frame7.eText()
        Me.iss_dt = New Frame7.eDate()
        Me.rep_no = New Frame7.eText()
        Me.fa_nm = New Frame7.eText()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.photo1 = New Frame7.eImage()
        Me.photo2 = New Frame7.eImage()
        Me.photo_title = New Frame7.eText()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1252, 624)
        Me.SplitContainer1.SplitterDistance = 288
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(288, 624)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.to_dt)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_fa_no)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fr_dt)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(284, 599)
        Me.SplitContainer3.SplitterDistance = 86
        Me.SplitContainer3.TabIndex = 161
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(8, 56)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        '
        'f_fa_no
        '
        Me.f_fa_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_fa_no.Location = New System.Drawing.Point(8, 8)
        Me.f_fa_no.Name = "f_fa_no"
        Me.f_fa_no.Size = New System.Drawing.Size(240, 21)
        Me.f_fa_no.TabIndex = 2
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 32)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(284, 509)
        Me.g10.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(960, 624)
        Me.SplitContainer2.SplitterDistance = 422
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.labor_amt)
        Me.EPanel2.Controls.Add(Me.work_tm)
        Me.EPanel2.Controls.Add(Me.part_nm)
        Me.EPanel2.Controls.Add(Me.part_mk)
        Me.EPanel2.Controls.Add(Me.part_qty)
        Me.EPanel2.Controls.Add(Me.part_no)
        Me.EPanel2.Controls.Add(Me.rep_dsc)
        Me.EPanel2.Controls.Add(Me.iss_dsc)
        Me.EPanel2.Controls.Add(Me.fac_cd)
        Me.EPanel2.Controls.Add(Me.wc_cd)
        Me.EPanel2.Controls.Add(Me.break_bc)
        Me.EPanel2.Controls.Add(Me.fa_no)
        Me.EPanel2.Controls.Add(Me.reason_bc)
        Me.EPanel2.Controls.Add(Me.rep_tm)
        Me.EPanel2.Controls.Add(Me.rep_bc)
        Me.EPanel2.Controls.Add(Me.rep_dt)
        Me.EPanel2.Controls.Add(Me.iss_tm)
        Me.EPanel2.Controls.Add(Me.iss_dt)
        Me.EPanel2.Controls.Add(Me.rep_no)
        Me.EPanel2.Controls.Add(Me.fa_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(960, 422)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     설비 수리 내역 등록"
        '
        'labor_amt
        '
        Me.labor_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.labor_amt.Location = New System.Drawing.Point(8, 208)
        Me.labor_amt.Name = "labor_amt"
        Me.labor_amt.Size = New System.Drawing.Size(327, 21)
        Me.labor_amt.TabIndex = 7
        Me.labor_amt.Title = "수리공수"
        '
        'work_tm
        '
        Me.work_tm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_tm.Location = New System.Drawing.Point(425, 181)
        Me.work_tm.Name = "work_tm"
        Me.work_tm.Size = New System.Drawing.Size(340, 21)
        Me.work_tm.TabIndex = 12
        Me.work_tm.Title = "수리공수"
        '
        'part_nm
        '
        Me.part_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.part_nm.Location = New System.Drawing.Point(8, 397)
        Me.part_nm.Name = "part_nm"
        Me.part_nm.Size = New System.Drawing.Size(327, 21)
        Me.part_nm.TabIndex = 16
        Me.part_nm.Title = "부품명"
        '
        'part_mk
        '
        Me.part_mk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.part_mk.Location = New System.Drawing.Point(8, 371)
        Me.part_mk.Name = "part_mk"
        Me.part_mk.Size = New System.Drawing.Size(327, 21)
        Me.part_mk.TabIndex = 15
        Me.part_mk.Title = "제조사"
        '
        'part_qty
        '
        Me.part_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.part_qty.Location = New System.Drawing.Point(425, 397)
        Me.part_qty.Name = "part_qty"
        Me.part_qty.Size = New System.Drawing.Size(340, 21)
        Me.part_qty.TabIndex = 18
        Me.part_qty.Title = "사용수량"
        '
        'part_no
        '
        Me.part_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.part_no.Location = New System.Drawing.Point(425, 370)
        Me.part_no.Name = "part_no"
        Me.part_no.Size = New System.Drawing.Size(340, 21)
        Me.part_no.TabIndex = 17
        Me.part_no.Title = "부품번호"
        '
        'rep_dsc
        '
        Me.rep_dsc.Location = New System.Drawing.Point(8, 306)
        Me.rep_dsc.Name = "rep_dsc"
        Me.rep_dsc.Size = New System.Drawing.Size(757, 60)
        Me.rep_dsc.TabIndex = 14
        Me.rep_dsc.Title = "수리내역"
        '
        'iss_dsc
        '
        Me.iss_dsc.Location = New System.Drawing.Point(8, 242)
        Me.iss_dsc.Name = "iss_dsc"
        Me.iss_dsc.Size = New System.Drawing.Size(757, 60)
        Me.iss_dsc.TabIndex = 13
        Me.iss_dsc.Title = "고장내역"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 83)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(327, 21)
        Me.fac_cd.TabIndex = 2
        Me.fac_cd.Title = "사용공장"
        '
        'wc_cd
        '
        Me.wc_cd.Location = New System.Drawing.Point(425, 83)
        Me.wc_cd.Name = "wc_cd"
        Me.wc_cd.Size = New System.Drawing.Size(340, 21)
        Me.wc_cd.TabIndex = 8
        Me.wc_cd.Title = "사용라인"
        '
        'break_bc
        '
        Me.break_bc.Location = New System.Drawing.Point(425, 157)
        Me.break_bc.Name = "break_bc"
        Me.break_bc.Size = New System.Drawing.Size(340, 21)
        Me.break_bc.TabIndex = 11
        Me.break_bc.Title = "고장유형"
        '
        'fa_no
        '
        Me.fa_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fa_no.Location = New System.Drawing.Point(8, 56)
        Me.fa_no.Name = "fa_no"
        Me.fa_no.Size = New System.Drawing.Size(240, 21)
        Me.fa_no.TabIndex = 1
        Me.fa_no.Title = "설비번호"
        '
        'reason_bc
        '
        Me.reason_bc.Location = New System.Drawing.Point(425, 133)
        Me.reason_bc.Name = "reason_bc"
        Me.reason_bc.Size = New System.Drawing.Size(340, 21)
        Me.reason_bc.TabIndex = 10
        Me.reason_bc.Title = "고장원인"
        '
        'rep_tm
        '
        Me.rep_tm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rep_tm.Location = New System.Drawing.Point(8, 181)
        Me.rep_tm.Name = "rep_tm"
        Me.rep_tm.Size = New System.Drawing.Size(327, 21)
        Me.rep_tm.TabIndex = 6
        Me.rep_tm.Title = "수리공수"
        '
        'rep_bc
        '
        Me.rep_bc.Location = New System.Drawing.Point(425, 108)
        Me.rep_bc.Name = "rep_bc"
        Me.rep_bc.Size = New System.Drawing.Size(340, 21)
        Me.rep_bc.TabIndex = 9
        Me.rep_bc.Title = "보전구분"
        '
        'rep_dt
        '
        Me.rep_dt.Location = New System.Drawing.Point(8, 157)
        Me.rep_dt.Name = "rep_dt"
        Me.rep_dt.Size = New System.Drawing.Size(327, 21)
        Me.rep_dt.TabIndex = 5
        Me.rep_dt.Title = "수리일자"
        '
        'iss_tm
        '
        Me.iss_tm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.iss_tm.Location = New System.Drawing.Point(8, 133)
        Me.iss_tm.Name = "iss_tm"
        Me.iss_tm.Size = New System.Drawing.Size(327, 21)
        Me.iss_tm.TabIndex = 4
        Me.iss_tm.Title = "발생시간"
        '
        'iss_dt
        '
        Me.iss_dt.Location = New System.Drawing.Point(8, 108)
        Me.iss_dt.Name = "iss_dt"
        Me.iss_dt.Size = New System.Drawing.Size(327, 21)
        Me.iss_dt.TabIndex = 3
        Me.iss_dt.Title = "발생일자"
        '
        'rep_no
        '
        Me.rep_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rep_no.Location = New System.Drawing.Point(8, 32)
        Me.rep_no.Name = "rep_no"
        Me.rep_no.Size = New System.Drawing.Size(240, 21)
        Me.rep_no.TabIndex = 100
        Me.rep_no.Title = "수리번호"
        '
        'fa_nm
        '
        Me.fa_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fa_nm.Location = New System.Drawing.Point(132, 56)
        Me.fa_nm.Name = "fa_nm"
        Me.fa_nm.Size = New System.Drawing.Size(368, 21)
        Me.fa_nm.TabIndex = 5
        Me.fa_nm.Title = "설비번호"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl2.Location = New System.Drawing.Point(2, 3)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(955, 198)
        Me.XtraTabControl2.TabIndex = 163
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage6})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage1.Controls.Add(Me.photo_title)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(948, 168)
        Me.XtraTabPage1.Text = "사진 정보"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Location = New System.Drawing.Point(68, 5)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.photo1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.photo2)
        Me.SplitContainer4.Size = New System.Drawing.Size(880, 241)
        Me.SplitContainer4.SplitterDistance = 430
        Me.SplitContainer4.TabIndex = 162
        '
        'photo1
        '
        Me.photo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.photo1.Location = New System.Drawing.Point(0, 0)
        Me.photo1.Name = "photo1"
        Me.photo1.Size = New System.Drawing.Size(430, 241)
        Me.photo1.TabIndex = 160
        Me.photo1.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'photo2
        '
        Me.photo2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.photo2.Location = New System.Drawing.Point(0, 0)
        Me.photo2.Name = "photo2"
        Me.photo2.Size = New System.Drawing.Size(446, 241)
        Me.photo2.TabIndex = 161
        Me.photo2.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'photo_title
        '
        Me.photo_title.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.photo_title.Location = New System.Drawing.Point(3, 5)
        Me.photo_title.Name = "photo_title"
        Me.photo_title.Size = New System.Drawing.Size(240, 21)
        Me.photo_title.TabIndex = 29
        Me.photo_title.Title = "사진1 / 2"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.g40)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(948, 168)
        Me.XtraTabPage6.Text = "작업자"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(948, 168)
        Me.g40.TabIndex = 5
        '
        'FMR100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FMR100"
        Me.Size = New System.Drawing.Size(1265, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents photo1 As Frame7.eImage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents f_fa_no As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents part_no As Frame7.eText
    Friend WithEvents part_nm As Frame7.eText
    Friend WithEvents part_mk As Frame7.eText
    Friend WithEvents rep_dsc As Frame7.eMemo
    Friend WithEvents iss_dsc As Frame7.eMemo
    Friend WithEvents wc_cd As Frame7.eCombo
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents break_bc As Frame7.eCombo
    Friend WithEvents reason_bc As Frame7.eCombo
    Friend WithEvents fa_no As Frame7.eText
    Friend WithEvents rep_tm As Frame7.eText
    Friend WithEvents rep_dt As Frame7.eDate
    Friend WithEvents iss_tm As Frame7.eText
    Friend WithEvents iss_dt As Frame7.eDate
    Friend WithEvents rep_no As Frame7.eText
    Friend WithEvents photo2 As Frame7.eImage
    Friend WithEvents fa_nm As Frame7.eText
    Friend WithEvents part_qty As Frame7.eText
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents photo_title As Frame7.eText
    Friend WithEvents work_tm As Frame7.eText
    Friend WithEvents rep_bc As Frame7.eCombo
    Friend WithEvents labor_amt As Frame7.eText
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g40 As Frame7.eGrid

End Class
