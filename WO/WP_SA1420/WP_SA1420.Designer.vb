<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1420
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
        Me.find_help_gu = New Frame7.eCombo()
        Me.find_lot_no = New Frame7.eText()
        Me.find_gd_cd = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_wh_cd = New Frame7.eCombo()
        Me.find_sa_cd = New Frame7.eCombo()
        Me.find_chk = New Frame7.eCheck()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_model_nm = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
        Me.find_model_no = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g_result = New Frame7.eGrid()
        Me.g_detail = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.find_help_gu)
        Me.EPanel2.Controls.Add(Me.find_lot_no)
        Me.EPanel2.Controls.Add(Me.find_gd_cd)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Controls.Add(Me.find_wh_cd)
        Me.EPanel2.Controls.Add(Me.find_sa_cd)
        Me.EPanel2.Controls.Add(Me.find_chk)
        Me.EPanel2.Controls.Add(Me.find_nm_cd)
        Me.EPanel2.Controls.Add(Me.find_model_nm)
        Me.EPanel2.Controls.Add(Me.find_nm_nm)
        Me.EPanel2.Controls.Add(Me.find_model_no)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 100)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     제품현황"
        '
        'find_help_gu
        '
        Me.find_help_gu.Location = New System.Drawing.Point(792, 39)
        Me.find_help_gu.Name = "find_help_gu"
        Me.find_help_gu.Size = New System.Drawing.Size(193, 21)
        Me.find_help_gu.TabIndex = 78
        Me.find_help_gu.Title = "구분"
        Me.find_help_gu.TitleWidth = 60
        '
        'find_lot_no
        '
        Me.find_lot_no.ColumnName = "find_paymentterm_nm"
        Me.find_lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_lot_no.Location = New System.Drawing.Point(792, 63)
        Me.find_lot_no.Name = "find_lot_no"
        Me.find_lot_no.Size = New System.Drawing.Size(193, 21)
        Me.find_lot_no.TabIndex = 77
        Me.find_lot_no.TableName = "find_paymentterm_nm"
        Me.find_lot_no.Title = "LOT NO."
        Me.find_lot_no.TitleWidth = 60
        '
        'find_gd_cd
        '
        Me.find_gd_cd.ColumnName = "find_paymentterm_nm"
        Me.find_gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_cd.Location = New System.Drawing.Point(574, 63)
        Me.find_gd_cd.Name = "find_gd_cd"
        Me.find_gd_cd.Size = New System.Drawing.Size(193, 21)
        Me.find_gd_cd.TabIndex = 76
        Me.find_gd_cd.TableName = "find_paymentterm_nm"
        Me.find_gd_cd.Title = "품목코드"
        Me.find_gd_cd.TitleWidth = 60
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(194, 39)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 75
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(29, 39)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 74
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_wh_cd
        '
        Me.find_wh_cd.Location = New System.Drawing.Point(574, 39)
        Me.find_wh_cd.Name = "find_wh_cd"
        Me.find_wh_cd.Size = New System.Drawing.Size(193, 21)
        Me.find_wh_cd.TabIndex = 72
        Me.find_wh_cd.Title = "창고"
        Me.find_wh_cd.TitleWidth = 60
        '
        'find_sa_cd
        '
        Me.find_sa_cd.Location = New System.Drawing.Point(320, 39)
        Me.find_sa_cd.Name = "find_sa_cd"
        Me.find_sa_cd.Size = New System.Drawing.Size(235, 21)
        Me.find_sa_cd.TabIndex = 71
        Me.find_sa_cd.Title = "사업장"
        Me.find_sa_cd.TitleWidth = 60
        '
        'find_chk
        '
        Me.find_chk.Caption = ""
        Me.find_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_chk.Location = New System.Drawing.Point(991, 63)
        Me.find_chk.Name = "find_chk"
        Me.find_chk.Size = New System.Drawing.Size(240, 21)
        Me.find_chk.TabIndex = 73
        Me.find_chk.Title = "LOT 별 재고 조회"
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(320, 63)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(122, 21)
        Me.find_nm_cd.TabIndex = 55
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 60
        '
        'find_model_nm
        '
        Me.find_model_nm.ColumnName = "find_paymentterm_nm"
        Me.find_model_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_nm.Location = New System.Drawing.Point(166, 63)
        Me.find_model_nm.Name = "find_model_nm"
        Me.find_model_nm.Size = New System.Drawing.Size(139, 21)
        Me.find_model_nm.TabIndex = 56
        Me.find_model_nm.TableName = "find_paymentterm_nm"
        Me.find_model_nm.Title = "Price Term 명"
        Me.find_model_nm.TitleWidth = 0
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(445, 63)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(110, 21)
        Me.find_nm_nm.TabIndex = 57
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
        '
        'find_model_no
        '
        Me.find_model_no.ColumnName = "find_paymentterm_nm"
        Me.find_model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_no.Location = New System.Drawing.Point(29, 63)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(135, 21)
        Me.find_model_no.TabIndex = 54
        Me.find_model_no.TableName = "find_paymentterm_nm"
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 60
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.g_result)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_detail)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 507)
        Me.SplitContainer2.SplitterDistance = 337
        Me.SplitContainer2.TabIndex = 2
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 337)
        Me.g_result.TabIndex = 1
        '
        'g_detail
        '
        Me.g_detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_detail.Location = New System.Drawing.Point(0, 0)
        Me.g_detail.Name = "g_detail"
        Me.g_detail.ReadOnly = False
        Me.g_detail.RowHeight = -1
        Me.g_detail.Size = New System.Drawing.Size(1182, 166)
        Me.g_detail.TabIndex = 0
        '
        'WP_SA1420
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1420"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_wh_cd As Frame7.eCombo
    Friend WithEvents find_sa_cd As Frame7.eCombo
    Friend WithEvents find_chk As Frame7.eCheck
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_model_nm As Frame7.eText
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eText
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents g_detail As Frame7.eGrid
    Friend WithEvents find_lot_no As Frame7.eText
    Friend WithEvents find_gd_cd As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_help_gu As Frame7.eCombo

End Class
