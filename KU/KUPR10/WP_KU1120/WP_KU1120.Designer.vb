<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_KU1120
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
        Me.EText5 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText3 = New Frame7.eText()
        Me.EText2 = New Frame7.eText()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ECombo2 = New Frame7.eCombo()
        Me.EDate2 = New Frame7.eDate()
        Me.EText16 = New Frame7.eText()
        Me.EDate1 = New Frame7.eDate()
        Me.EText1 = New Frame7.eText()
        Me.g_retrieve = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.spc_1.Panel2.Controls.Add(Me.g_retrieve)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 118
        Me.spc_1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.EText3)
        Me.EPanel1.Controls.Add(Me.EText2)
        Me.EPanel1.Controls.Add(Me.EText5)
        Me.EPanel1.Controls.Add(Me.EText4)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.EText16)
        Me.EPanel1.Controls.Add(Me.EDate1)
        Me.EPanel1.Controls.Add(Me.ECombo2)
        Me.EPanel1.Controls.Add(Me.EDate2)
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 118)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     P/O 현황"
        '
        'EText5
        '
        Me.EText5.ColumnName = "find_paymenterm_cd"
        Me.EText5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText5.Location = New System.Drawing.Point(750, 89)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(212, 21)
        Me.EText5.TabIndex = 102
        Me.EText5.TableName = "find_paymenterm_cd"
        Me.EText5.Title = "File No."
        Me.EText5.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymenterm_cd"
        Me.EText4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText4.Location = New System.Drawing.Point(532, 89)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(194, 21)
        Me.EText4.TabIndex = 101
        Me.EText4.TableName = "find_paymenterm_cd"
        Me.EText4.Title = "P/O No."
        Me.EText4.TitleWidth = 98
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText3.Location = New System.Drawing.Point(750, 62)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(212, 21)
        Me.EText3.TabIndex = 100
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "품목명"
        Me.EText3.TitleWidth = 98
        '
        'EText2
        '
        Me.EText2.ColumnName = "find_paymenterm_cd"
        Me.EText2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText2.Location = New System.Drawing.Point(532, 62)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(194, 21)
        Me.EText2.TabIndex = 99
        Me.EText2.TableName = "find_paymenterm_cd"
        Me.EText2.Title = "품목코드"
        Me.EText2.TitleWidth = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(263, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 14)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(467, 35)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(198, 21)
        Me.ECombo2.TabIndex = 51
        Me.ECombo2.Title = "화폐"
        Me.ECombo2.TitleWidth = 98
        '
        'EDate2
        '
        Me.EDate2.Location = New System.Drawing.Point(279, 35)
        Me.EDate2.Name = "EDate2"
        Me.EDate2.Size = New System.Drawing.Size(115, 21)
        Me.EDate2.TabIndex = 48
        Me.EDate2.Title = "기간"
        Me.EDate2.TitleWidth = 0
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
        Me.EText1.Location = New System.Drawing.Point(270, 62)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(242, 21)
        Me.EText1.TabIndex = 49
        Me.EText1.Title = "거래처명"
        Me.EText1.TitleWidth = 98
        '
        'g_retrieve
        '
        Me.g_retrieve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_retrieve.Location = New System.Drawing.Point(0, 0)
        Me.g_retrieve.Name = "g_retrieve"
        Me.g_retrieve.ReadOnly = False
        Me.g_retrieve.RowHeight = -1
        Me.g_retrieve.Size = New System.Drawing.Size(1182, 489)
        Me.g_retrieve.TabIndex = 0
        '
        'WP_KU1120
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WP_KU1120"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g_retrieve As Frame7.eGrid
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents EDate2 As Frame7.eDate
    Friend WithEvents EText16 As Frame7.eText
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
