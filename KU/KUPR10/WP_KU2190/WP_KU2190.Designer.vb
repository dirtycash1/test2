<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_KU2190
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
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EDate2 = New Frame7.eDate()
        Me.EText6 = New Frame7.eText()
        Me.EText16 = New Frame7.eText()
        Me.EDate1 = New Frame7.eDate()
        Me.EText1 = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        Me.spc_1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.EPanel1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 118
        Me.spc_1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.EDate2)
        Me.EPanel1.Controls.Add(Me.EText6)
        Me.EPanel1.Controls.Add(Me.EText16)
        Me.EPanel1.Controls.Add(Me.EDate1)
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 118)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     지급등록현황"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(265, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 14)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EDate2
        '
        Me.EDate2.Location = New System.Drawing.Point(286, 35)
        Me.EDate2.Name = "EDate2"
        Me.EDate2.Size = New System.Drawing.Size(115, 21)
        Me.EDate2.TabIndex = 48
        Me.EDate2.Title = "기간"
        Me.EDate2.TitleWidth = 0
        '
        'EText6
        '
        Me.EText6.ColumnName = "find_paymenterm_cd"
        Me.EText6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText6.Location = New System.Drawing.Point(548, 62)
        Me.EText6.Name = "EText6"
        Me.EText6.Size = New System.Drawing.Size(203, 21)
        Me.EText6.TabIndex = 104
        Me.EText6.TableName = "find_paymenterm_cd"
        Me.EText6.Title = "File No."
        Me.EText6.TitleWidth = 98
        '
        'EText16
        '
        Me.EText16.ColumnName = "find_paymenterm_cd"
        Me.EText16.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText16.Location = New System.Drawing.Point(49, 62)
        Me.EText16.Name = "EText16"
        Me.EText16.Size = New System.Drawing.Size(212, 21)
        Me.EText16.TabIndex = 98
        Me.EText16.TableName = "find_paymenterm_cd"
        Me.EText16.Title = "거래처코드"
        Me.EText16.TitleWidth = 98
        '
        'EDate1
        '
        Me.EDate1.Location = New System.Drawing.Point(49, 35)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(212, 21)
        Me.EDate1.TabIndex = 47
        Me.EDate1.Title = "기간"
        Me.EDate1.TitleWidth = 98
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(268, 62)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(242, 21)
        Me.EText1.TabIndex = 49
        Me.EText1.Title = "거래처명"
        Me.EText1.TitleWidth = 98
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1182, 489)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1175, 459)
        Me.XtraTabPage1.Text = "지급등록현황"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1175, 459)
        Me.XtraTabPage2.Text = "결재예정현황"
        '
        'WP_KU2190
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WP_KU2190"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EDate2 As Frame7.eDate
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents EText16 As Frame7.eText
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage

End Class
