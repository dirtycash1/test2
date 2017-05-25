<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1130
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
        Me.find_mc_cd = New Frame7.eCombo()
        Me.find_gong_cd = New Frame7.eCombo()
        Me.find_lot_no = New Frame7.eText()
        Me.find_daytime_gu = New Frame7.eCombo()
        Me.find_nm_nm = New Frame7.eText()
        Me.find_model_nm = New Frame7.eText()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_model_no = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.g_result = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_result)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.find_mc_cd)
        Me.EPanel2.Controls.Add(Me.find_gong_cd)
        Me.EPanel2.Controls.Add(Me.find_lot_no)
        Me.EPanel2.Controls.Add(Me.find_daytime_gu)
        Me.EPanel2.Controls.Add(Me.find_nm_nm)
        Me.EPanel2.Controls.Add(Me.find_model_nm)
        Me.EPanel2.Controls.Add(Me.find_nm_cd)
        Me.EPanel2.Controls.Add(Me.find_model_no)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 116)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     생산지시현황"
        '
        'find_mc_cd
        '
        Me.find_mc_cd.Location = New System.Drawing.Point(944, 48)
        Me.find_mc_cd.Name = "find_mc_cd"
        Me.find_mc_cd.Size = New System.Drawing.Size(238, 21)
        Me.find_mc_cd.TabIndex = 125
        Me.find_mc_cd.Title = "기계"
        Me.find_mc_cd.TitleWidth = 90
        '
        'find_gong_cd
        '
        Me.find_gong_cd.Location = New System.Drawing.Point(690, 48)
        Me.find_gong_cd.Name = "find_gong_cd"
        Me.find_gong_cd.Size = New System.Drawing.Size(238, 21)
        Me.find_gong_cd.TabIndex = 124
        Me.find_gong_cd.Title = "공정"
        Me.find_gong_cd.TitleWidth = 90
        '
        'find_lot_no
        '
        Me.find_lot_no.ColumnName = "job_no"
        Me.find_lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_lot_no.Location = New System.Drawing.Point(40, 75)
        Me.find_lot_no.Name = "find_lot_no"
        Me.find_lot_no.Size = New System.Drawing.Size(273, 21)
        Me.find_lot_no.TabIndex = 123
        Me.find_lot_no.TableName = "job_no"
        Me.find_lot_no.Title = "CHECK_SHEET NO."
        Me.find_lot_no.TitleWidth = 108
        '
        'find_daytime_gu
        '
        Me.find_daytime_gu.Location = New System.Drawing.Point(690, 75)
        Me.find_daytime_gu.Name = "find_daytime_gu"
        Me.find_daytime_gu.Size = New System.Drawing.Size(238, 21)
        Me.find_daytime_gu.TabIndex = 121
        Me.find_daytime_gu.Title = "주/야간"
        Me.find_daytime_gu.TitleWidth = 90
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(530, 75)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_nm_nm.TabIndex = 57
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
        '
        'find_model_nm
        '
        Me.find_model_nm.ColumnName = "find_paymentterm_nm"
        Me.find_model_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_nm.Location = New System.Drawing.Point(530, 48)
        Me.find_model_nm.Name = "find_model_nm"
        Me.find_model_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_model_nm.TabIndex = 56
        Me.find_model_nm.TableName = "find_paymentterm_nm"
        Me.find_model_nm.Title = "Price Term 명"
        Me.find_model_nm.TitleWidth = 0
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(348, 75)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_nm_cd.TabIndex = 55
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 80
        '
        'find_model_no
        '
        Me.find_model_no.ColumnName = "find_paymentterm_nm"
        Me.find_model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_no.Location = New System.Drawing.Point(348, 48)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(176, 21)
        Me.find_model_no.TabIndex = 54
        Me.find_model_no.TableName = "find_paymentterm_nm"
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 80
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(202, 48)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 53
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(40, 48)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 52
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 491)
        Me.g_result.TabIndex = 1
        '
        'WP_PR1130
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1130"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_mc_cd As Frame7.eCombo
    Friend WithEvents find_gong_cd As Frame7.eCombo
    Friend WithEvents find_lot_no As Frame7.eText
    Friend WithEvents find_daytime_gu As Frame7.eCombo
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_nm As Frame7.eText
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents g_result As Frame7.eGrid

End Class
