<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMA101
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
        Me.qr_itm_cd = New Frame7.eText()
        Me.nat_cd = New Frame7.eCombo()
        Me.ex_cust_cd = New Frame7.eText()
        Me.ex_cust_nm = New Frame7.eText()
        Me.model_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.end_yn = New Frame7.eCheck()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.grp2_cd = New Frame7.eCombo()
        Me.grp3_cd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.Add_Btn = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
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
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.qr_itm_cd)
        Me.EPanel1.Controls.Add(Me.nat_cd)
        Me.EPanel1.Controls.Add(Me.ex_cust_cd)
        Me.EPanel1.Controls.Add(Me.ex_cust_nm)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.end_yn)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 109)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'qr_itm_cd
        '
        Me.qr_itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.qr_itm_cd.Location = New System.Drawing.Point(274, 76)
        Me.qr_itm_cd.Name = "qr_itm_cd"
        Me.qr_itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.qr_itm_cd.TabIndex = 28
        Me.qr_itm_cd.Title = "QR 품목코드"
        '
        'nat_cd
        '
        Me.nat_cd.Location = New System.Drawing.Point(553, 52)
        Me.nat_cd.Name = "nat_cd"
        Me.nat_cd.Size = New System.Drawing.Size(210, 21)
        Me.nat_cd.TabIndex = 27
        Me.nat_cd.Title = "국가코드"
        Me.nat_cd.TitleWidth = 98
        '
        'ex_cust_cd
        '
        Me.ex_cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ex_cust_cd.Location = New System.Drawing.Point(553, 28)
        Me.ex_cust_cd.Name = "ex_cust_cd"
        Me.ex_cust_cd.Size = New System.Drawing.Size(210, 21)
        Me.ex_cust_cd.TabIndex = 26
        Me.ex_cust_cd.Title = "수출거래처"
        Me.ex_cust_cd.TitleWidth = 98
        '
        'ex_cust_nm
        '
        Me.ex_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ex_cust_nm.Location = New System.Drawing.Point(769, 28)
        Me.ex_cust_nm.Name = "ex_cust_nm"
        Me.ex_cust_nm.Size = New System.Drawing.Size(138, 21)
        Me.ex_cust_nm.TabIndex = 25
        Me.ex_cust_nm.Title = "출고번호"
        Me.ex_cust_nm.TitleWidth = 0
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(834, 26)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 22
        Me.model_cd.Title = "차종"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(12, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 18
        Me.itm_cd.Title = "품목코드%"
        '
        'end_yn
        '
        Me.end_yn.Caption = ""
        Me.end_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_yn.Location = New System.Drawing.Point(834, 53)
        Me.end_yn.Name = "end_yn"
        Me.end_yn.Size = New System.Drawing.Size(156, 21)
        Me.end_yn.TabIndex = 24
        Me.end_yn.Title = "end_yn"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(12, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 23
        Me.itm_bc.Title = "itm_bc"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(274, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 19
        Me.grp1_cd.Title = "대분류"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(12, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 17
        Me.itm_nm.Title = "품목명%"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(274, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 21
        Me.grp2_cd.Title = "중분류"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(834, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 20
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 498)
        Me.SplitContainer2.SplitterDistance = 333
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 333)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     품목 등록 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1178, 308)
        Me.g10.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.Add_Btn)
        Me.EPanel4.Controls.Add(Me.btn_close)
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(1182, 161)
        Me.EPanel4.TabIndex = 3
        Me.EPanel4.Text = "     품목 세부 현황"
        '
        'Add_Btn
        '
        Me.Add_Btn.Location = New System.Drawing.Point(175, 0)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(64, 23)
        Me.Add_Btn.TabIndex = 75
        Me.Add_Btn.Text = "첨 부"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(245, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(64, 23)
        Me.btn_close.TabIndex = 74
        Me.btn_close.Text = "닫 기"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1178, 136)
        Me.g20.TabIndex = 2
        '
        'DMA101
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMA101"
        Me.Size = New System.Drawing.Size(1182, 611)
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
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents end_yn As Frame7.eCheck
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents Add_Btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nat_cd As Frame7.eCombo
    Friend WithEvents ex_cust_cd As Frame7.eText
    Friend WithEvents ex_cust_nm As Frame7.eText
    Friend WithEvents qr_itm_cd As Frame7.eText
End Class
