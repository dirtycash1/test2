<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1270_PB
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
        Me.find_ot_gu = New Frame7.eCombo()
        Me.find_gd_nm = New Frame7.eText()
        Me.find_gd_cd = New Frame7.eText()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_cs_cd = New Frame7.eText()
        Me.find_to = New Frame7.eDate()
        Me.find_de_gu = New Frame7.eCombo()
        Me.find_from = New Frame7.eDate()
        Me.g_result = New Frame7.eGrid()
        Me.emp_nm = New Frame7.eText()
        Me.emp_no = New Frame7.eText()
        Me.find_sa_cs_nm = New Frame7.eText()
        Me.find_sa_cs = New Frame7.eText()
        Me.od_gu = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1253, 611)
        Me.SplitContainer1.SplitterDistance = 94
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.od_gu)
        Me.EPanel2.Controls.Add(Me.emp_nm)
        Me.EPanel2.Controls.Add(Me.emp_no)
        Me.EPanel2.Controls.Add(Me.find_sa_cs_nm)
        Me.EPanel2.Controls.Add(Me.find_sa_cs)
        Me.EPanel2.Controls.Add(Me.find_ot_gu)
        Me.EPanel2.Controls.Add(Me.find_gd_nm)
        Me.EPanel2.Controls.Add(Me.find_gd_cd)
        Me.EPanel2.Controls.Add(Me.find_cs_nm)
        Me.EPanel2.Controls.Add(Me.find_cs_cd)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.find_de_gu)
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1253, 94)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     기간별 매출 현황(PB)"
        '
        'find_ot_gu
        '
        Me.find_ot_gu.Location = New System.Drawing.Point(561, 60)
        Me.find_ot_gu.Name = "find_ot_gu"
        Me.find_ot_gu.Size = New System.Drawing.Size(187, 21)
        Me.find_ot_gu.TabIndex = 63
        Me.find_ot_gu.Title = "출하/반품"
        Me.find_ot_gu.TitleWidth = 80
        '
        'find_gd_nm
        '
        Me.find_gd_nm.ColumnName = "find_paymentterm_nm"
        Me.find_gd_nm.Location = New System.Drawing.Point(392, 60)
        Me.find_gd_nm.Name = "find_gd_nm"
        Me.find_gd_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_gd_nm.TabIndex = 62
        Me.find_gd_nm.TableName = "find_paymentterm_nm"
        Me.find_gd_nm.Title = "Price Term 명"
        Me.find_gd_nm.TitleWidth = 0
        '
        'find_gd_cd
        '
        Me.find_gd_cd.ColumnName = "find_paymentterm_nm"
        Me.find_gd_cd.Location = New System.Drawing.Point(210, 60)
        Me.find_gd_cd.Name = "find_gd_cd"
        Me.find_gd_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_gd_cd.TabIndex = 61
        Me.find_gd_cd.TableName = "find_paymentterm_nm"
        Me.find_gd_cd.Title = "판매코드"
        Me.find_gd_cd.TitleWidth = 80
        '
        'find_cs_nm
        '
        Me.find_cs_nm.ColumnName = "find_paymentterm_nm"
        Me.find_cs_nm.Location = New System.Drawing.Point(392, 36)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_cs_nm.TabIndex = 60
        Me.find_cs_nm.TableName = "find_paymentterm_nm"
        Me.find_cs_nm.Title = "Price Term 명"
        Me.find_cs_nm.TitleWidth = 0
        '
        'find_cs_cd
        '
        Me.find_cs_cd.ColumnName = "find_paymentterm_nm"
        Me.find_cs_cd.Location = New System.Drawing.Point(210, 36)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_cs_cd.TabIndex = 59
        Me.find_cs_cd.TableName = "find_paymentterm_nm"
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 80
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(64, 60)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(119, 21)
        Me.find_to.TabIndex = 53
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_de_gu
        '
        Me.find_de_gu.Location = New System.Drawing.Point(561, 36)
        Me.find_de_gu.Name = "find_de_gu"
        Me.find_de_gu.Size = New System.Drawing.Size(187, 21)
        Me.find_de_gu.TabIndex = 58
        Me.find_de_gu.Title = "국내/수출"
        Me.find_de_gu.TitleWidth = 80
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(15, 36)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(168, 21)
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
        Me.g_result.Size = New System.Drawing.Size(1253, 513)
        Me.g_result.TabIndex = 1
        '
        'emp_nm
        '
        Me.emp_nm.ColumnName = "find_paymentterm_nm"
        Me.emp_nm.Location = New System.Drawing.Point(966, 60)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(140, 21)
        Me.emp_nm.TabIndex = 67
        Me.emp_nm.TableName = "find_paymentterm_nm"
        Me.emp_nm.Title = "Price Term 명"
        Me.emp_nm.TitleWidth = 0
        '
        'emp_no
        '
        Me.emp_no.ColumnName = "find_paymentterm_nm"
        Me.emp_no.Location = New System.Drawing.Point(784, 60)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(176, 21)
        Me.emp_no.TabIndex = 66
        Me.emp_no.TableName = "find_paymentterm_nm"
        Me.emp_no.Title = "영업담당자"
        Me.emp_no.TitleWidth = 80
        '
        'find_sa_cs_nm
        '
        Me.find_sa_cs_nm.ColumnName = "find_paymentterm_nm"
        Me.find_sa_cs_nm.Location = New System.Drawing.Point(966, 36)
        Me.find_sa_cs_nm.Name = "find_sa_cs_nm"
        Me.find_sa_cs_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_sa_cs_nm.TabIndex = 65
        Me.find_sa_cs_nm.TableName = "find_paymentterm_nm"
        Me.find_sa_cs_nm.Title = "Price Term 명"
        Me.find_sa_cs_nm.TitleWidth = 0
        '
        'find_sa_cs
        '
        Me.find_sa_cs.ColumnName = "find_paymentterm_nm"
        Me.find_sa_cs.Location = New System.Drawing.Point(784, 36)
        Me.find_sa_cs.Name = "find_sa_cs"
        Me.find_sa_cs.Size = New System.Drawing.Size(176, 21)
        Me.find_sa_cs.TabIndex = 64
        Me.find_sa_cs.TableName = "find_paymentterm_nm"
        Me.find_sa_cs.Title = "매출거래처"
        Me.find_sa_cs.TitleWidth = 80
        '
        'od_gu
        '
        Me.od_gu.Location = New System.Drawing.Point(1137, 36)
        Me.od_gu.Name = "od_gu"
        Me.od_gu.Size = New System.Drawing.Size(187, 21)
        Me.od_gu.TabIndex = 68
        Me.od_gu.Title = "수주유형"
        Me.od_gu.TitleWidth = 70
        '
        'WP_SA1270_PB
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1270_PB"
        Me.Size = New System.Drawing.Size(1253, 611)
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
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_de_gu As Frame7.eCombo
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_gd_nm As Frame7.eText
    Friend WithEvents find_gd_cd As Frame7.eText
    Friend WithEvents find_ot_gu As Frame7.eCombo
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents find_sa_cs_nm As Frame7.eText
    Friend WithEvents find_sa_cs As Frame7.eText
    Friend WithEvents od_gu As Frame7.eCombo

End Class
