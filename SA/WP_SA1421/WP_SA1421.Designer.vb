<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1421
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.find_from = New Frame7.eDate()
        Me.find_to = New Frame7.eDate()
        Me.wh_cd = New Frame7.eCombo()
        Me.gd_cd = New Frame7.eText()
        Me.LOT_NO = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g_result = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 83
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.Button1)
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.wh_cd)
        Me.EPanel2.Controls.Add(Me.gd_cd)
        Me.EPanel2.Controls.Add(Me.LOT_NO)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 83)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     검색"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(12, 28)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 52
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(174, 28)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 53
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(12, 55)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(273, 21)
        Me.wh_cd.TabIndex = 62
        Me.wh_cd.Title = "창고"
        '
        'gd_cd
        '
        Me.gd_cd.ColumnName = "find_paymentterm_nm"
        Me.gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_cd.Location = New System.Drawing.Point(329, 28)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(220, 21)
        Me.gd_cd.TabIndex = 61
        Me.gd_cd.TableName = "find_paymentterm_nm"
        Me.gd_cd.Title = "품목코드"
        Me.gd_cd.TitleWidth = 60
        '
        'LOT_NO
        '
        Me.LOT_NO.ColumnName = "find_paymentterm_nm"
        Me.LOT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LOT_NO.Location = New System.Drawing.Point(565, 28)
        Me.LOT_NO.Name = "LOT_NO"
        Me.LOT_NO.Size = New System.Drawing.Size(256, 21)
        Me.LOT_NO.TabIndex = 61
        Me.LOT_NO.TableName = "find_paymentterm_nm"
        Me.LOT_NO.Title = "CHECK  SHEET NO"
        Me.LOT_NO.TitleWidth = 110
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g_result)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 524)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     재고 이동 현황"
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(2, 23)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1178, 499)
        Me.g_result.TabIndex = 1
        '
        'WP_SA1421
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1421"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents LOT_NO As Frame7.eText
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
