<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_TR1120
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
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.nacs_cd = New Frame7.eText()
        Me.nacs_nm = New Frame7.eText()
        Me.btn_prt = New DevExpress.XtraEditors.SimpleButton()
        Me.gd_nm = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.find_from = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.cur_cd = New Frame7.eCombo()
        Me.tab_1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tp1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g_retrieve = New Frame7.eGrid()
        Me.tp2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g_retrieve2 = New Frame7.eGrid()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame7.eGrid()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.tab_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer
        '
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer.Name = "splitContainer"
        Me.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.EPanel1)
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.tab_1)
        Me.splitContainer.Size = New System.Drawing.Size(1182, 611)
        Me.splitContainer.SplitterDistance = 133
        Me.splitContainer.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.nacs_cd)
        Me.EPanel1.Controls.Add(Me.nacs_nm)
        Me.EPanel1.Controls.Add(Me.btn_prt)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.cur_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 133)
        Me.EPanel1.TabIndex = 7
        Me.EPanel1.Text = "     수주 현황"
        '
        'nacs_cd
        '
        Me.nacs_cd.ColumnName = "find_paymenterm_cd"
        Me.nacs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_cd.Location = New System.Drawing.Point(5, 80)
        Me.nacs_cd.Name = "nacs_cd"
        Me.nacs_cd.Size = New System.Drawing.Size(204, 21)
        Me.nacs_cd.TabIndex = 132
        Me.nacs_cd.TableName = "find_paymenterm_cd"
        Me.nacs_cd.Title = "납품처코드"
        Me.nacs_cd.TitleWidth = 98
        '
        'nacs_nm
        '
        Me.nacs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nacs_nm.Location = New System.Drawing.Point(225, 80)
        Me.nacs_nm.Name = "nacs_nm"
        Me.nacs_nm.Size = New System.Drawing.Size(325, 21)
        Me.nacs_nm.TabIndex = 131
        Me.nacs_nm.Title = "납품처명"
        Me.nacs_nm.TitleWidth = 98
        '
        'btn_prt
        '
        Me.btn_prt.Location = New System.Drawing.Point(603, 26)
        Me.btn_prt.Name = "btn_prt"
        Me.btn_prt.Size = New System.Drawing.Size(128, 23)
        Me.btn_prt.TabIndex = 143
        Me.btn_prt.Text = "작업의뢰서 현황"
        '
        'gd_nm
        '
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(225, 107)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(325, 21)
        Me.gd_nm.TabIndex = 130
        Me.gd_nm.Title = "품명"
        Me.gd_nm.TitleWidth = 98
        '
        'gd_cd
        '
        Me.gd_cd.ColumnName = "find_paymenterm_cd"
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(5, 107)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(204, 21)
        Me.gd_cd.TabIndex = 129
        Me.gd_cd.TableName = "find_paymenterm_cd"
        Me.gd_cd.Title = "품목코드"
        Me.gd_cd.TitleWidth = 98
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(5, 53)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(204, 21)
        Me.cs_cd.TabIndex = 128
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 98
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(5, 26)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(204, 21)
        Me.find_from.TabIndex = 126
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 98
        '
        'cs_nm
        '
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(225, 53)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(325, 21)
        Me.cs_nm.TabIndex = 127
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 98
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(215, 26)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(125, 21)
        Me.find_to.TabIndex = 125
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 20
        '
        'cur_cd
        '
        Me.cur_cd.Location = New System.Drawing.Point(357, 26)
        Me.cur_cd.Name = "cur_cd"
        Me.cur_cd.Size = New System.Drawing.Size(193, 21)
        Me.cur_cd.TabIndex = 124
        Me.cur_cd.Title = "화폐"
        Me.cur_cd.TitleWidth = 80
        '
        'tab_1
        '
        Me.tab_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_1.Location = New System.Drawing.Point(0, 0)
        Me.tab_1.Name = "tab_1"
        Me.tab_1.SelectedTabPage = Me.tp1
        Me.tab_1.Size = New System.Drawing.Size(1182, 474)
        Me.tab_1.TabIndex = 53
        Me.tab_1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tp1, Me.tp2, Me.XtraTabPage1})
        '
        'tp1
        '
        Me.tp1.Controls.Add(Me.g_retrieve)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(1175, 444)
        Me.tp1.Text = "기간별수주현황"
        '
        'g_retrieve
        '
        Me.g_retrieve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_retrieve.Location = New System.Drawing.Point(0, 0)
        Me.g_retrieve.Name = "g_retrieve"
        Me.g_retrieve.ReadOnly = False
        Me.g_retrieve.RowHeight = -1
        Me.g_retrieve.Size = New System.Drawing.Size(1175, 444)
        Me.g_retrieve.TabIndex = 0
        '
        'tp2
        '
        Me.tp2.Controls.Add(Me.g_retrieve2)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(1175, 444)
        Me.tp2.Text = "미출고현황"
        '
        'g_retrieve2
        '
        Me.g_retrieve2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_retrieve2.Location = New System.Drawing.Point(0, 0)
        Me.g_retrieve2.Name = "g_retrieve2"
        Me.g_retrieve2.ReadOnly = False
        Me.g_retrieve2.RecordNavigator = False
        Me.g_retrieve2.RowHeight = -1
        Me.g_retrieve2.Size = New System.Drawing.Size(1175, 444)
        Me.g_retrieve2.TabIndex = 1
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1175, 444)
        Me.XtraTabPage1.Text = "품목별수주현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1175, 444)
        Me.g10.TabIndex = 0
        '
        'WP_TR1120
        '
        Me.Controls.Add(Me.splitContainer)
        Me.Name = "WP_TR1120"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.splitContainer, 0)
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        Me.splitContainer.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.tab_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_1.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents cur_cd As Frame7.eCombo
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents nacs_cd As Frame7.eText
    Friend WithEvents nacs_nm As Frame7.eText
    Friend WithEvents tab_1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g_retrieve As Frame7.eGrid
    Friend WithEvents tp2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g_retrieve2 As Frame7.eGrid
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_prt As DevExpress.XtraEditors.SimpleButton

End Class
