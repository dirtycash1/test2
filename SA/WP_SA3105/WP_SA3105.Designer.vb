<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA3105
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
        Me.find_nm_cd = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
        Me.std_dt = New Frame7.eDate()
        Me.find_pl_cd = New Frame7.eText()
        Me.find_pl_nm = New Frame7.eText()
        Me.find_cs_cd = New Frame7.eText()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_ps_cd = New Frame7.eText()
        Me.find_ps_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.find_kijong_cd = New Frame7.eCombo()
        Me.find_model_no = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 116
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_model_no)
        Me.EPanel1.Controls.Add(Me.find_kijong_cd)
        Me.EPanel1.Controls.Add(Me.find_nm_cd)
        Me.EPanel1.Controls.Add(Me.find_nm_nm)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.find_pl_cd)
        Me.EPanel1.Controls.Add(Me.find_pl_nm)
        Me.EPanel1.Controls.Add(Me.find_cs_cd)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.find_ps_cd)
        Me.EPanel1.Controls.Add(Me.find_ps_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 116)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(711, 82)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(135, 21)
        Me.find_nm_cd.TabIndex = 59
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 60
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(850, 82)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(139, 21)
        Me.find_nm_nm.TabIndex = 60
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(19, 34)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 2
        Me.std_dt.Title = "기준일자"
        Me.std_dt.TitleWidth = 100
        '
        'find_pl_cd
        '
        Me.find_pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_pl_cd.Location = New System.Drawing.Point(290, 58)
        Me.find_pl_cd.Name = "find_pl_cd"
        Me.find_pl_cd.Size = New System.Drawing.Size(156, 21)
        Me.find_pl_cd.TabIndex = 12
        Me.find_pl_cd.Title = "영업부서"
        Me.find_pl_cd.TitleWidth = 60
        '
        'find_pl_nm
        '
        Me.find_pl_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_pl_nm.Location = New System.Drawing.Point(449, 58)
        Me.find_pl_nm.Name = "find_pl_nm"
        Me.find_pl_nm.Size = New System.Drawing.Size(240, 21)
        Me.find_pl_nm.TabIndex = 13
        Me.find_pl_nm.TitleWidth = 0
        '
        'find_cs_cd
        '
        Me.find_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_cd.Location = New System.Drawing.Point(290, 34)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(156, 21)
        Me.find_cs_cd.TabIndex = 8
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(449, 34)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(240, 21)
        Me.find_cs_nm.TabIndex = 9
        Me.find_cs_nm.TitleWidth = 0
        '
        'find_ps_cd
        '
        Me.find_ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_ps_cd.Location = New System.Drawing.Point(290, 82)
        Me.find_ps_cd.Name = "find_ps_cd"
        Me.find_ps_cd.Size = New System.Drawing.Size(156, 21)
        Me.find_ps_cd.TabIndex = 10
        Me.find_ps_cd.Title = "영업담당자"
        Me.find_ps_cd.TitleWidth = 60
        '
        'find_ps_nm
        '
        Me.find_ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_ps_nm.Location = New System.Drawing.Point(449, 82)
        Me.find_ps_nm.Name = "find_ps_nm"
        Me.find_ps_nm.Size = New System.Drawing.Size(115, 21)
        Me.find_ps_nm.TabIndex = 11
        Me.find_ps_nm.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 491)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     위탁현황조회"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1178, 466)
        Me.g10.TabIndex = 2
        '
        'find_kijong_cd
        '
        Me.find_kijong_cd.Location = New System.Drawing.Point(711, 34)
        Me.find_kijong_cd.Name = "find_kijong_cd"
        Me.find_kijong_cd.Size = New System.Drawing.Size(193, 21)
        Me.find_kijong_cd.TabIndex = 73
        Me.find_kijong_cd.Title = "제품명분류"
        Me.find_kijong_cd.TitleWidth = 60
        '
        'find_model_no
        '
        Me.find_model_no.Location = New System.Drawing.Point(711, 58)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(193, 21)
        Me.find_model_no.TabIndex = 74
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 60
        '
        'WP_SA3105
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA3105"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents find_pl_cd As Frame7.eText
    Friend WithEvents find_pl_nm As Frame7.eText
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_ps_cd As Frame7.eText
    Friend WithEvents find_ps_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eCombo
    Friend WithEvents find_kijong_cd As Frame7.eCombo

End Class
