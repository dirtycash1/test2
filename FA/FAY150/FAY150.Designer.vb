<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY150
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.cust_nm = New Frame7.eText()
        Me.rec_bc = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.div_cd = New Frame7.eCheckCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.to_dt = New Frame7.eDate()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 360)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.rec_bc)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 102)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "co_cd"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(256, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 3
        Me.fr_dt.Title = "fr_dt"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(500, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(244, 21)
        Me.cust_nm.TabIndex = 5
        Me.cust_nm.Title = "cust_nm"
        Me.cust_nm.TitleWidth = 0
        '
        'rec_bc
        '
        Me.rec_bc.Location = New System.Drawing.Point(256, 52)
        Me.rec_bc.Name = "rec_bc"
        Me.rec_bc.Size = New System.Drawing.Size(240, 21)
        Me.rec_bc.TabIndex = 6
        Me.rec_bc.Title = "rec_bc"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(256, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 4
        Me.cust_cd.Title = "cust_cd"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(8, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 9
        Me.div_cd.Title = "div_cd"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(8, 76)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 8
        Me.cury_bc.Title = "cury_bc"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1020, 254)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1013, 224)
        Me.XtraTabPage1.Text = "가로보기"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1013, 224)
        Me.g10.TabIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g20)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1013, 224)
        Me.XtraTabPage2.Text = "세로보기"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1013, 224)
        Me.g20.TabIndex = 3
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(380, 28)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 3
        Me.to_dt.Title = "to_dt"
        '
        'FAY150
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY150"
        Me.Size = New System.Drawing.Size(1034, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents rec_bc As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCheckCombo
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate

End Class
