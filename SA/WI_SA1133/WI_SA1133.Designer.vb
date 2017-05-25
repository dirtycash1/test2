<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WI_SA1133
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.sign_all = New Frame7.eCheck()
        Me.sign_yn = New Frame7.eCheck()
        Me.save_ing = New Frame7.eText()
        Me.save_end = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.start_dt = New Frame7.eDate()
        Me.end_dt = New Frame7.eDate()
        Me.btn_set = New DevExpress.XtraEditors.SimpleButton()
        Me.all_chk = New Frame7.eCheck()
        Me.cs_cd = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EText1 = New Frame7.eText()
        Me.EText2 = New Frame7.eText()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText5 = New Frame7.eText()
        Me.EText6 = New Frame7.eText()
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
        Me.SplitContainer1.SplitterDistance = 113
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.sign_all)
        Me.EPanel1.Controls.Add(Me.sign_yn)
        Me.EPanel1.Controls.Add(Me.save_ing)
        Me.EPanel1.Controls.Add(Me.save_end)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.start_dt)
        Me.EPanel1.Controls.Add(Me.end_dt)
        Me.EPanel1.Controls.Add(Me.btn_set)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1410, 113)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'sign_all
        '
        Me.sign_all.Caption = ""
        Me.sign_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sign_all.Location = New System.Drawing.Point(837, 55)
        Me.sign_all.Name = "sign_all"
        Me.sign_all.Size = New System.Drawing.Size(170, 21)
        Me.sign_all.TabIndex = 24
        Me.sign_all.Title = "미출력/기출력 전체조회"
        Me.sign_all.TitleWidth = 140
        '
        'sign_yn
        '
        Me.sign_yn.Caption = ""
        Me.sign_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sign_yn.Location = New System.Drawing.Point(837, 28)
        Me.sign_yn.Name = "sign_yn"
        Me.sign_yn.Size = New System.Drawing.Size(136, 21)
        Me.sign_yn.TabIndex = 23
        Me.sign_yn.Title = "기출력건만 조회"
        Me.sign_yn.TitleWidth = 110
        '
        'save_ing
        '
        Me.save_ing.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.save_ing.Location = New System.Drawing.Point(1122, 26)
        Me.save_ing.Name = "save_ing"
        Me.save_ing.Size = New System.Drawing.Size(165, 21)
        Me.save_ing.TabIndex = 21
        Me.save_ing.Title = "(작성 중 . . .기다려주세요 )"
        Me.save_ing.TitleWidth = 200
        '
        'save_end
        '
        Me.save_end.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.save_end.Location = New System.Drawing.Point(1122, 53)
        Me.save_end.Name = "save_end"
        Me.save_end.Size = New System.Drawing.Size(94, 21)
        Me.save_end.TabIndex = 22
        Me.save_end.Title = "(작성 완료)"
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(400, 55)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(197, 21)
        Me.ps_cd.TabIndex = 18
        Me.ps_cd.Title = "영업담당자"
        Me.ps_cd.TitleWidth = 90
        '
        'ps_nm
        '
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(482, 55)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(315, 21)
        Me.ps_nm.TabIndex = 19
        Me.ps_nm.Title = "영업담당자명"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 55)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(207, 21)
        Me.fr_dt.TabIndex = 16
        Me.fr_dt.Title = "출고기간"
        Me.fr_dt.TitleWidth = 90
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(221, 55)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(147, 21)
        Me.to_dt.TabIndex = 17
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'start_dt
        '
        Me.start_dt.Location = New System.Drawing.Point(8, 28)
        Me.start_dt.Name = "start_dt"
        Me.start_dt.Size = New System.Drawing.Size(207, 21)
        Me.start_dt.TabIndex = 2
        Me.start_dt.Title = "거래기간"
        Me.start_dt.TitleWidth = 90
        '
        'end_dt
        '
        Me.end_dt.Location = New System.Drawing.Point(221, 28)
        Me.end_dt.Name = "end_dt"
        Me.end_dt.Size = New System.Drawing.Size(147, 21)
        Me.end_dt.TabIndex = 3
        Me.end_dt.Title = "~"
        Me.end_dt.TitleWidth = 20
        '
        'btn_set
        '
        Me.btn_set.Location = New System.Drawing.Point(1043, 28)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(73, 48)
        Me.btn_set.TabIndex = 15
        Me.btn_set.Text = "작 성"
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.all_chk.Location = New System.Drawing.Point(400, 82)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(115, 21)
        Me.all_chk.TabIndex = 14
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 90
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(400, 28)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(197, 21)
        Me.cs_cd.TabIndex = 4
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 90
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(482, 28)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(315, 21)
        Me.cs_nm.TabIndex = 5
        Me.cs_nm.Title = "거래처명"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1410, 375)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     거래처등록원장"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1406, 350)
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
        'WI_SA1133
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1133"
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
    Friend WithEvents start_dt As Frame7.eDate
    Friend WithEvents end_dt As Frame7.eDate
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents all_chk As Frame7.eCheck
    'Friend WithEvents CachedGAC120R3 As WI_SA1133.CachedGAC120R
    'Friend WithEvents CachedGAC120R4 As WI_SA1133.CachedGAC120R

    Private WithEvents EPanel1 As Frame7.ePanel
    Private WithEvents EPanel2 As Frame7.ePanel
    Private WithEvents btn_set As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents save_ing As Frame7.eText
    Friend WithEvents save_end As Frame7.eText
    Friend WithEvents sign_yn As Frame7.eCheck
    Friend WithEvents sign_all As Frame7.eCheck
End Class
