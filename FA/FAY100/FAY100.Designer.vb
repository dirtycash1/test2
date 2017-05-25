<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY100
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
        Me.acc_nm = New Frame7.eText()
        Me.fr_acc_cd = New Frame7.eText()
        Me.acc_cd = New Frame7.eText()
        Me.to_acc_cd = New Frame7.eText()
        Me.div_cd = New Frame7.eCheckCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.cury_bc = New Frame7.eCombo()
        Me.no_yn = New Frame7.eCheck()
        Me.up_yn = New Frame7.eCheck()
        Me.doc_yn = New Frame7.eCheck()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g70 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1184, 500)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.acc_nm)
        Me.EPanel1.Controls.Add(Me.fr_acc_cd)
        Me.EPanel1.Controls.Add(Me.acc_cd)
        Me.EPanel1.Controls.Add(Me.to_acc_cd)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.no_yn)
        Me.EPanel1.Controls.Add(Me.up_yn)
        Me.EPanel1.Controls.Add(Me.doc_yn)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1184, 104)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'acc_nm
        '
        Me.acc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_nm.Location = New System.Drawing.Point(632, 28)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(132, 21)
        Me.acc_nm.TabIndex = 60
        Me.acc_nm.Title = "발의부서명"
        Me.acc_nm.TitleWidth = 0
        '
        'fr_acc_cd
        '
        Me.fr_acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_acc_cd.Location = New System.Drawing.Point(388, 52)
        Me.fr_acc_cd.Name = "fr_acc_cd"
        Me.fr_acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.fr_acc_cd.TabIndex = 58
        Me.fr_acc_cd.Title = "계정구간"
        '
        'acc_cd
        '
        Me.acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_cd.Location = New System.Drawing.Point(388, 28)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd.TabIndex = 57
        Me.acc_cd.Title = "계정코드"
        '
        'to_acc_cd
        '
        Me.to_acc_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_acc_cd.Location = New System.Drawing.Point(632, 52)
        Me.to_acc_cd.Name = "to_acc_cd"
        Me.to_acc_cd.Size = New System.Drawing.Size(132, 21)
        Me.to_acc_cd.TabIndex = 59
        Me.to_acc_cd.Title = "~"
        Me.to_acc_cd.TitleWidth = 10
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(320, 21)
        Me.div_cd.TabIndex = 53
        Me.div_cd.Title = "회계단위"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "조회일자"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(244, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(132, 21)
        Me.to_dt.TabIndex = 48
        Me.to_dt.Title = ""
        Me.to_dt.TitleWidth = 10
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(388, 76)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 45
        Me.cury_bc.Title = "통화"
        '
        'no_yn
        '
        Me.no_yn.Caption = ""
        Me.no_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.no_yn.Location = New System.Drawing.Point(816, 28)
        Me.no_yn.Name = "no_yn"
        Me.no_yn.Size = New System.Drawing.Size(196, 21)
        Me.no_yn.TabIndex = 56
        Me.no_yn.Title = "미승인 포함"
        '
        'up_yn
        '
        Me.up_yn.Caption = ""
        Me.up_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.up_yn.Location = New System.Drawing.Point(816, 52)
        Me.up_yn.Name = "up_yn"
        Me.up_yn.Size = New System.Drawing.Size(196, 21)
        Me.up_yn.TabIndex = 54
        Me.up_yn.Title = "과목계정으로 집계"
        '
        'doc_yn
        '
        Me.doc_yn.Caption = ""
        Me.doc_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_yn.Location = New System.Drawing.Point(816, 76)
        Me.doc_yn.Name = "doc_yn"
        Me.doc_yn.Size = New System.Drawing.Size(196, 21)
        Me.doc_yn.TabIndex = 55
        Me.doc_yn.Title = "전표발행계정 조회"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1184, 392)
        Me.PanelControl1.TabIndex = 55
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1180, 388)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1173, 358)
        Me.XtraTabPage1.Text = "계정 원장"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer2.Size = New System.Drawing.Size(1173, 358)
        Me.SplitContainer2.SplitterDistance = 204
        Me.SplitContainer2.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1173, 204)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1173, 150)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g50)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1173, 358)
        Me.XtraTabPage2.Text = "계정세부 원장"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RecordNavigator = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(1173, 358)
        Me.g50.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g70)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1173, 358)
        Me.XtraTabPage3.Text = "총계정원장"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(0, 0)
        Me.g70.Name = "g70"
        Me.g70.ReadOnly = False
        Me.g70.RecordNavigator = False
        Me.g70.RowHeight = -1
        Me.g70.Size = New System.Drawing.Size(1173, 358)
        Me.g70.TabIndex = 1
        '
        'FAY100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY100"
        Me.Size = New System.Drawing.Size(1206, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents div_cd As Frame7.eCheckCombo
    Friend WithEvents up_yn As Frame7.eCheck
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents no_yn As Frame7.eCheck
    Friend WithEvents doc_yn As Frame7.eCheck
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g70 As Frame7.eGrid
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents fr_acc_cd As Frame7.eText
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents to_acc_cd As Frame7.eText

End Class
