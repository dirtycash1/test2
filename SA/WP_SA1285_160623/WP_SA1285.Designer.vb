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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.all_chk = New Frame7.eCheck()
        Me.chk = New Frame7.eCheck()
        Me.ps_nm = New Frame7.eText()
        Me.chk2 = New Frame7.eCheck()
        Me.ps_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.btn_send = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.CachedGAC120R1 = New System7.CachedGAC120R()
        Me.CachedGAC120R2 = New System7.CachedGAC120R()
        Me.CachedGAC120R3 = New System7.CachedGAC120R()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1410, 492)
        Me.SplitContainer1.SplitterDistance = 84
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.chk)
        Me.EPanel1.Controls.Add(Me.ps_nm)
        Me.EPanel1.Controls.Add(Me.chk2)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.btn_send)
        Me.EPanel1.Controls.Add(Me.ProgressBar1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1410, 84)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1009, 53)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 24)
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.Text = "출력(선택)"
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
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.all_chk.Location = New System.Drawing.Point(801, 55)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(103, 21)
        Me.all_chk.TabIndex = 14
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 80
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk.Location = New System.Drawing.Point(402, 55)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(111, 21)
        Me.chk.TabIndex = 12
        Me.chk.Title = "청구금액 양수"
        Me.chk.TitleWidth = 83
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
        'chk2
        '
        Me.chk2.Caption = ""
        Me.chk2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk2.Location = New System.Drawing.Point(519, 55)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(156, 21)
        Me.chk2.TabIndex = 13
        Me.chk2.Title = "폐업,거래종료 미출력"
        Me.chk2.TitleWidth = 120
        '
        'ps_cd
        '
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(8, 55)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(240, 21)
        Me.ps_cd.TabIndex = 6
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
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(912, 53)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(91, 24)
        Me.btn_send.TabIndex = 10
        Me.btn_send.Text = "E-mail 보내기"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(912, 28)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(104, 21)
        Me.ProgressBar1.TabIndex = 9
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1410, 404)
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
        Me.g10.Size = New System.Drawing.Size(1406, 379)
        Me.g10.TabIndex = 2
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
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents chk2 As Frame7.eCheck
    Friend WithEvents CachedGAC120R1 As System7.CachedGAC120R
    Friend WithEvents all_chk As Frame7.eCheck
    Friend WithEvents CachedGAC120R2 As System7.CachedGAC120R
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CachedGAC120R3 As System7.CachedGAC120R

End Class
