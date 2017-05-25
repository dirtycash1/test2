<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC780
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.tax_year = New Frame7.eDate()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.year_amt = New Frame7.eText()
        Me.max_amt = New Frame7.eText()
        Me.pre_amt = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.cnt = New Frame7.eText()
        Me.amt2 = New Frame7.eText()
        Me.amt = New Frame7.eText()
        Me.up = New Frame7.eText()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ECombo4 = New Frame7.eCombo()
        Me.ECombo3 = New Frame7.eCombo()
        Me.EText6 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText5 = New Frame7.eText()
        Me.EText3 = New Frame7.eText()
        Me.EText2 = New Frame7.eText()
        Me.EDate1 = New Frame7.eDate()
        Me.ECombo2 = New Frame7.eCombo()
        Me.EText1 = New Frame7.eText()
        Me.ECombo1 = New Frame7.eCombo()
        Me.bs_cd = New Frame7.eCombo()
        Me.mon_bc = New Frame7.eCombo()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(896, 508)
        Me.SplitContainer2.SplitterDistance = 83
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.tax_year)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.mon_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(896, 83)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "법인명"
        '
        'tax_year
        '
        Me.tax_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_year.Location = New System.Drawing.Point(272, 28)
        Me.tax_year.Name = "tax_year"
        Me.tax_year.Size = New System.Drawing.Size(240, 21)
        Me.tax_year.TabIndex = 14
        Me.tax_year.Title = "tax_year"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(896, 421)
        Me.SplitContainer3.SplitterDistance = 220
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel3.Controls.Add(Me.year_amt)
        Me.EPanel3.Controls.Add(Me.max_amt)
        Me.EPanel3.Controls.Add(Me.pre_amt)
        Me.EPanel3.Location = New System.Drawing.Point(0, 176)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(896, 160)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     나. 공제한도액 계산"
        '
        'year_amt
        '
        Me.year_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.year_amt.Location = New System.Drawing.Point(28, 36)
        Me.year_amt.Name = "year_amt"
        Me.year_amt.Size = New System.Drawing.Size(240, 21)
        Me.year_amt.TabIndex = 0
        '
        'max_amt
        '
        Me.max_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.max_amt.Location = New System.Drawing.Point(28, 92)
        Me.max_amt.Name = "max_amt"
        Me.max_amt.Size = New System.Drawing.Size(240, 21)
        Me.max_amt.TabIndex = 0
        '
        'pre_amt
        '
        Me.pre_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pre_amt.Location = New System.Drawing.Point(28, 64)
        Me.pre_amt.Name = "pre_amt"
        Me.pre_amt.Size = New System.Drawing.Size(240, 21)
        Me.pre_amt.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel2.Controls.Add(Me.cnt)
        Me.EPanel2.Controls.Add(Me.amt2)
        Me.EPanel2.Controls.Add(Me.amt)
        Me.EPanel2.Controls.Add(Me.up)
        Me.EPanel2.Location = New System.Drawing.Point(0, 8)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(896, 160)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     가. 공제대상 세액"
        '
        'cnt
        '
        Me.cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cnt.Location = New System.Drawing.Point(28, 36)
        Me.cnt.Name = "cnt"
        Me.cnt.Size = New System.Drawing.Size(240, 21)
        Me.cnt.TabIndex = 0
        '
        'amt2
        '
        Me.amt2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.amt2.Location = New System.Drawing.Point(28, 120)
        Me.amt2.Name = "amt2"
        Me.amt2.Size = New System.Drawing.Size(240, 21)
        Me.amt2.TabIndex = 0
        '
        'amt
        '
        Me.amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.amt.Location = New System.Drawing.Point(28, 92)
        Me.amt.Name = "amt"
        Me.amt.Size = New System.Drawing.Size(240, 21)
        Me.amt.TabIndex = 0
        '
        'up
        '
        Me.up.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.up.Location = New System.Drawing.Point(28, 64)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(240, 21)
        Me.up.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(776, 84)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 24)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "새전표로 복사"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(648, 84)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 24)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "견본전표로 저장"
        '
        'ECombo4
        '
        Me.ECombo4.Location = New System.Drawing.Point(648, 28)
        Me.ECombo4.Name = "ECombo4"
        Me.ECombo4.Size = New System.Drawing.Size(240, 21)
        Me.ECombo4.TabIndex = 12
        Me.ECombo4.Title = "전표유형"
        '
        'ECombo3
        '
        Me.ECombo3.Location = New System.Drawing.Point(648, 52)
        Me.ECombo3.Name = "ECombo3"
        Me.ECombo3.Size = New System.Drawing.Size(240, 21)
        Me.ECombo3.TabIndex = 11
        Me.ECombo3.Title = "진행상태"
        '
        'EText6
        '
        Me.EText6.Location = New System.Drawing.Point(12, 100)
        Me.EText6.Name = "EText6"
        Me.EText6.Size = New System.Drawing.Size(496, 21)
        Me.EText6.TabIndex = 10
        Me.EText6.Title = "발의내용"
        '
        'EText4
        '
        Me.EText4.Location = New System.Drawing.Point(512, 76)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(120, 21)
        Me.EText4.TabIndex = 9
        Me.EText4.TitleWidth = 0
        '
        'EText5
        '
        Me.EText5.Location = New System.Drawing.Point(268, 76)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(240, 21)
        Me.EText5.TabIndex = 8
        Me.EText5.Title = "발의자"
        '
        'EText3
        '
        Me.EText3.Location = New System.Drawing.Point(512, 52)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(120, 21)
        Me.EText3.TabIndex = 7
        Me.EText3.TitleWidth = 0
        '
        'EText2
        '
        Me.EText2.Location = New System.Drawing.Point(268, 52)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(240, 21)
        Me.EText2.TabIndex = 6
        Me.EText2.Title = "발의부서"
        '
        'EDate1
        '
        Me.EDate1.Location = New System.Drawing.Point(268, 28)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(240, 21)
        Me.EDate1.TabIndex = 5
        Me.EDate1.Title = "발의일자"
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(12, 76)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 4
        Me.ECombo2.Title = "사업장명"
        '
        'EText1
        '
        Me.EText1.Location = New System.Drawing.Point(12, 28)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(240, 21)
        Me.EText1.TabIndex = 2
        Me.EText1.Title = "전표번호"
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(12, 52)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(240, 21)
        Me.ECombo1.TabIndex = 3
        Me.ECombo1.Title = "법인명"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 3
        Me.bs_cd.Title = "bs_cd"
        '
        'mon_bc
        '
        Me.mon_bc.Location = New System.Drawing.Point(272, 52)
        Me.mon_bc.Name = "mon_bc"
        Me.mon_bc.Size = New System.Drawing.Size(240, 21)
        Me.mon_bc.TabIndex = 3
        Me.mon_bc.Title = "mon_bc"
        '
        'FAC780
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "FAC780"
        Me.Size = New System.Drawing.Size(1034, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents tax_year As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ECombo4 As Frame7.eCombo
    Friend WithEvents ECombo3 As Frame7.eCombo
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents year_amt As Frame7.eText
    Friend WithEvents max_amt As Frame7.eText
    Friend WithEvents pre_amt As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents cnt As Frame7.eText
    Friend WithEvents amt2 As Frame7.eText
    Friend WithEvents amt As Frame7.eText
    Friend WithEvents up As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents mon_bc As Frame7.eCombo

End Class
