<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1140
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
        Me.find_gong_cd = New Frame7.eCombo()
        Me.find_lot_no = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
        Me.find_model_nm = New Frame7.eText()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_model_no = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_mate_no = New Frame7.eText()
        Me.g_multi = New Frame7.eGrid()
        Me.chk_all = New Frame7.eCheck()
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
        Me.spc_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.spc_1.Panel2.Controls.Add(Me.g_multi)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 92
        Me.spc_1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chk_all)
        Me.EPanel1.Controls.Add(Me.find_gong_cd)
        Me.EPanel1.Controls.Add(Me.find_lot_no)
        Me.EPanel1.Controls.Add(Me.find_nm_nm)
        Me.EPanel1.Controls.Add(Me.find_model_nm)
        Me.EPanel1.Controls.Add(Me.find_nm_cd)
        Me.EPanel1.Controls.Add(Me.find_model_no)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_mate_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 92)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     멸균기 가동일지"
        '
        'find_gong_cd
        '
        Me.find_gong_cd.Location = New System.Drawing.Point(15, 61)
        Me.find_gong_cd.Name = "find_gong_cd"
        Me.find_gong_cd.Size = New System.Drawing.Size(276, 21)
        Me.find_gong_cd.TabIndex = 120
        Me.find_gong_cd.Title = "공정"
        Me.find_gong_cd.TitleWidth = 60
        '
        'find_lot_no
        '
        Me.find_lot_no.ColumnName = "find_paymentterm_nm"
        Me.find_lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_lot_no.Location = New System.Drawing.Point(665, 61)
        Me.find_lot_no.Name = "find_lot_no"
        Me.find_lot_no.Size = New System.Drawing.Size(220, 21)
        Me.find_lot_no.TabIndex = 72
        Me.find_lot_no.TableName = "find_paymentterm_nm"
        Me.find_lot_no.Title = "LOT NO."
        Me.find_lot_no.TitleWidth = 98
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(498, 61)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_nm_nm.TabIndex = 71
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
        '
        'find_model_nm
        '
        Me.find_model_nm.ColumnName = "find_paymentterm_nm"
        Me.find_model_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_nm.Location = New System.Drawing.Point(498, 37)
        Me.find_model_nm.Name = "find_model_nm"
        Me.find_model_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_model_nm.TabIndex = 70
        Me.find_model_nm.TableName = "find_paymentterm_nm"
        Me.find_model_nm.Title = "Price Term 명"
        Me.find_model_nm.TitleWidth = 0
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(319, 61)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_nm_cd.TabIndex = 69
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 80
        '
        'find_model_no
        '
        Me.find_model_no.ColumnName = "find_paymentterm_nm"
        Me.find_model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_no.Location = New System.Drawing.Point(319, 37)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(176, 21)
        Me.find_model_no.TabIndex = 68
        Me.find_model_no.TableName = "find_paymentterm_nm"
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 80
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(180, 37)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 67
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(15, 37)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 66
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_mate_no
        '
        Me.find_mate_no.ColumnName = "find_paymentterm_nm"
        Me.find_mate_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_mate_no.Location = New System.Drawing.Point(665, 37)
        Me.find_mate_no.Name = "find_mate_no"
        Me.find_mate_no.Size = New System.Drawing.Size(220, 21)
        Me.find_mate_no.TabIndex = 65
        Me.find_mate_no.TableName = "find_paymentterm_nm"
        Me.find_mate_no.Title = "멸균번호"
        Me.find_mate_no.TitleWidth = 98
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 515)
        Me.g_multi.TabIndex = 0
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(903, 61)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(240, 21)
        Me.chk_all.TabIndex = 122
        Me.chk_all.Title = "전체 선택"
        '
        'WI_PR1140
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_PR1140"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents find_mate_no As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_nm As Frame7.eText
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eText
    Friend WithEvents find_lot_no As Frame7.eText
    Friend WithEvents find_gong_cd As Frame7.eCombo
    Friend WithEvents chk_all As Frame7.eCheck

End Class
