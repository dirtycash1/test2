<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1285
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
        Me.print_ck = New Frame7.eCheck()
        Me.g_end = New Frame7.eCheck()
        Me.grp_chk = New Frame7.eCheck()
        Me.save_ing = New Frame7.eText()
        Me.file_save = New DevExpress.XtraEditors.SimpleButton()
        Me.save_end = New Frame7.eText()
        Me.sal_cust = New Frame7.eText()
        Me.sal_cust_nm = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ps_nm = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.all_chk = New Frame7.eCheck()
        Me.cs_cd = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.chk = New Frame7.eCheck()
        Me.btn_send = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EText1 = New Frame7.eText()
        Me.EText2 = New Frame7.eText()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText5 = New Frame7.eText()
        Me.EText6 = New Frame7.eText()
        Me.grp2_cd = New Frame7.eCombo()
        Me.grp22_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1410, 492)
        Me.SplitContainer1.SplitterDistance = 112
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.grp22_cd)
        Me.EPanel1.Controls.Add(Me.print_ck)
        Me.EPanel1.Controls.Add(Me.g_end)
        Me.EPanel1.Controls.Add(Me.grp_chk)
        Me.EPanel1.Controls.Add(Me.save_ing)
        Me.EPanel1.Controls.Add(Me.file_save)
        Me.EPanel1.Controls.Add(Me.save_end)
        Me.EPanel1.Controls.Add(Me.sal_cust)
        Me.EPanel1.Controls.Add(Me.sal_cust_nm)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.ProgressBar1)
        Me.EPanel1.Controls.Add(Me.chk)
        Me.EPanel1.Controls.Add(Me.btn_send)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1410, 112)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'print_ck
        '
        Me.print_ck.Caption = ""
        Me.print_ck.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.print_ck.Location = New System.Drawing.Point(646, 82)
        Me.print_ck.Name = "print_ck"
        Me.print_ck.Size = New System.Drawing.Size(70, 21)
        Me.print_ck.TabIndex = 23
        Me.print_ck.Title = "미출력"
        Me.print_ck.TitleWidth = 50
        '
        'g_end
        '
        Me.g_end.Caption = ""
        Me.g_end.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.g_end.Location = New System.Drawing.Point(565, 82)
        Me.g_end.Name = "g_end"
        Me.g_end.Size = New System.Drawing.Size(75, 21)
        Me.g_end.TabIndex = 22
        Me.g_end.Title = "거래종료"
        Me.g_end.TitleWidth = 55
        '
        'grp_chk
        '
        Me.grp_chk.Caption = ""
        Me.grp_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grp_chk.Location = New System.Drawing.Point(506, 82)
        Me.grp_chk.Name = "grp_chk"
        Me.grp_chk.Size = New System.Drawing.Size(57, 21)
        Me.grp_chk.TabIndex = 21
        Me.grp_chk.Title = "폐업"
        Me.grp_chk.TitleWidth = 30
        '
        'save_ing
        '
        Me.save_ing.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.save_ing.Location = New System.Drawing.Point(1203, 80)
        Me.save_ing.Name = "save_ing"
        Me.save_ing.Size = New System.Drawing.Size(94, 21)
        Me.save_ing.TabIndex = 19
        Me.save_ing.Title = "(저장 중 . . . )"
        '
        'file_save
        '
        Me.file_save.Location = New System.Drawing.Point(1106, 77)
        Me.file_save.Name = "file_save"
        Me.file_save.Size = New System.Drawing.Size(91, 24)
        Me.file_save.TabIndex = 18
        Me.file_save.Text = "파일 저장"
        '
        'save_end
        '
        Me.save_end.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.save_end.Location = New System.Drawing.Point(1288, 78)
        Me.save_end.Name = "save_end"
        Me.save_end.Size = New System.Drawing.Size(94, 21)
        Me.save_end.TabIndex = 20
        Me.save_end.Title = "(저장 완료)"
        '
        'sal_cust
        '
        Me.sal_cust.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust.Location = New System.Drawing.Point(400, 55)
        Me.sal_cust.Name = "sal_cust"
        Me.sal_cust.Size = New System.Drawing.Size(240, 21)
        Me.sal_cust.TabIndex = 16
        Me.sal_cust.Title = "매출정산거래처"
        '
        'sal_cust_nm
        '
        Me.sal_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sal_cust_nm.Location = New System.Drawing.Point(528, 55)
        Me.sal_cust_nm.Name = "sal_cust_nm"
        Me.sal_cust_nm.Size = New System.Drawing.Size(376, 21)
        Me.sal_cust_nm.TabIndex = 17
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 2
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(148, 28)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1009, 78)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 24)
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.Text = "출력(선택)"
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(267, 55)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(121, 21)
        Me.ps_nm.TabIndex = 7
        Me.ps_nm.TitleWidth = 0
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(8, 55)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(240, 21)
        Me.ps_cd.TabIndex = 6
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.all_chk.Location = New System.Drawing.Point(801, 80)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(103, 21)
        Me.all_chk.TabIndex = 14
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 80
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(400, 28)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(240, 21)
        Me.cs_cd.TabIndex = 4
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(528, 28)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(376, 21)
        Me.cs_nm.TabIndex = 5
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(912, 28)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(104, 21)
        Me.ProgressBar1.TabIndex = 9
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk.Location = New System.Drawing.Point(400, 82)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(100, 21)
        Me.chk.TabIndex = 12
        Me.chk.Title = "청구금액 0원"
        Me.chk.TitleWidth = 75
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(912, 78)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(91, 24)
        Me.btn_send.TabIndex = 10
        Me.btn_send.Text = "E-mail 보내기"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1410, 376)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     거래명세 및 대금청구서"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1406, 351)
        Me.g10.TabIndex = 2
        '
        'EText1
        '
        Me.EText1.Location = New System.Drawing.Point(400, 55)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(240, 21)
        Me.EText1.TabIndex = 16
        Me.EText1.Title = "매출정산거래처"
        '
        'EText2
        '
        Me.EText2.Location = New System.Drawing.Point(8, 55)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(240, 21)
        Me.EText2.TabIndex = 6
        '
        'EText3
        '
        Me.EText3.Location = New System.Drawing.Point(8, 55)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(240, 21)
        Me.EText3.TabIndex = 6
        '
        'EText4
        '
        Me.EText4.Location = New System.Drawing.Point(8, 55)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(240, 21)
        Me.EText4.TabIndex = 6
        '
        'EText5
        '
        Me.EText5.Location = New System.Drawing.Point(400, 28)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(240, 21)
        Me.EText5.TabIndex = 4
        '
        'EText6
        '
        Me.EText6.Location = New System.Drawing.Point(8, 55)
        Me.EText6.Name = "EText6"
        Me.EText6.Size = New System.Drawing.Size(240, 21)
        Me.EText6.TabIndex = 6
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(1032, 26)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(212, 21)
        Me.grp2_cd.TabIndex = 25
        Me.grp2_cd.Title = "지역분류"
        Me.grp2_cd.TitleWidth = 90
        '
        'grp22_cd
        '
        Me.grp22_cd.Location = New System.Drawing.Point(1032, 50)
        Me.grp22_cd.Name = "grp22_cd"
        Me.grp22_cd.Size = New System.Drawing.Size(212, 21)
        Me.grp22_cd.TabIndex = 26
        Me.grp22_cd.Title = "시군분류"
        Me.grp22_cd.TitleWidth = 90
        '
        'WP_SA1285
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1285"
        Me.Size = New System.Drawing.Size(1410, 492)
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
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents all_chk As Frame7.eCheck
    Friend WithEvents sal_cust As Frame7.eText
    Friend WithEvents sal_cust_nm As Frame7.eText
    'Friend WithEvents CachedGAC120R3 As System7.CachedGAC120R
    'Friend WithEvents CachedGAC120R4 As System7.CachedGAC120R

    Private WithEvents EPanel1 As Frame7.ePanel
    Private WithEvents EPanel2 As Frame7.ePanel
    Private WithEvents btn_send As DevExpress.XtraEditors.SimpleButton
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents file_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents save_ing As Frame7.eText
    Friend WithEvents save_end As Frame7.eText
    Friend WithEvents grp_chk As Frame7.eCheck
    Friend WithEvents g_end As Frame7.eCheck
    Friend WithEvents print_ck As Frame7.eCheck
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp22_cd As Frame7.eCombo

End Class
