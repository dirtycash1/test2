<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_EIS1080
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.find_ym = New Frame7.eDate()
        Me.find_jagu_cd = New Frame7.eCombo()
        Me.find_nm_gu = New Frame7.eCheckCombo()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g_result2 = New Frame7.eGrid()
        Me.g_result = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.find_ym)
        Me.EPanel2.Controls.Add(Me.find_jagu_cd)
        Me.EPanel2.Controls.Add(Me.find_nm_gu)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 73)
        Me.EPanel2.TabIndex = 8
        Me.EPanel2.Text = "     제품수불부"
        '
        'find_ym
        '
        Me.find_ym.Location = New System.Drawing.Point(29, 37)
        Me.find_ym.Name = "find_ym"
        Me.find_ym.Size = New System.Drawing.Size(155, 21)
        Me.find_ym.TabIndex = 74
        Me.find_ym.Title = "년월"
        Me.find_ym.TitleWidth = 60
        '
        'find_jagu_cd
        '
        Me.find_jagu_cd.Location = New System.Drawing.Point(205, 37)
        Me.find_jagu_cd.Name = "find_jagu_cd"
        Me.find_jagu_cd.Size = New System.Drawing.Size(193, 21)
        Me.find_jagu_cd.TabIndex = 72
        Me.find_jagu_cd.Title = "회계분류"
        Me.find_jagu_cd.TitleWidth = 70
        '
        'find_nm_gu
        '
        Me.find_nm_gu.Location = New System.Drawing.Point(430, 37)
        Me.find_nm_gu.Name = "find_nm_gu"
        Me.find_nm_gu.Size = New System.Drawing.Size(240, 21)
        Me.find_nm_gu.TabIndex = 79
        Me.find_nm_gu.Title = "제품구분"
        Me.find_nm_gu.TitleWidth = 70
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1182, 534)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g_result)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1175, 504)
        Me.XtraTabPage1.Text = "  금액  "
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g_result2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1175, 504)
        Me.XtraTabPage2.Text = "  수량  "
        '
        'g_result2
        '
        Me.g_result2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result2.Location = New System.Drawing.Point(0, 0)
        Me.g_result2.Name = "g_result2"
        Me.g_result2.ReadOnly = False
        Me.g_result2.RowHeight = -1
        Me.g_result2.Size = New System.Drawing.Size(1175, 504)
        Me.g_result2.TabIndex = 0
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1175, 504)
        Me.g_result.TabIndex = 0
        '
        'WP_EIS1080
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_EIS1080"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_ym As Frame7.eDate
    Friend WithEvents find_jagu_cd As Frame7.eCombo
    Friend WithEvents find_nm_gu As Frame7.eCheckCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g_result2 As Frame7.eGrid

End Class
