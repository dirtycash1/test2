<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1410
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
        Me.find_wh_cd = New Frame7.eCombo()
        Me.find_sa_cd = New Frame7.eCombo()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_model_nm = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
        Me.find_model_no = New Frame7.eText()
        Me.g_result = New Frame7.eGrid()
        Me.find_chk = New Frame7.eCheck()
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
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
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
        'find_wh_cd
        '
        Me.find_wh_cd.Location = New System.Drawing.Point(57, 66)
        Me.find_wh_cd.Name = "find_wh_cd"
        Me.find_wh_cd.Size = New System.Drawing.Size(235, 21)
        Me.find_wh_cd.TabIndex = 72
        Me.find_wh_cd.Title = "창고"
        Me.find_wh_cd.TitleWidth = 70
        '
        'find_sa_cd
        '
        Me.find_sa_cd.Location = New System.Drawing.Point(57, 39)
        Me.find_sa_cd.Name = "find_sa_cd"
        Me.find_sa_cd.Size = New System.Drawing.Size(235, 21)
        Me.find_sa_cd.TabIndex = 71
        Me.find_sa_cd.Title = "사업장"
        Me.find_sa_cd.TitleWidth = 70
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(451, 66)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_nm_cd.TabIndex = 55
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 80
        '
        'find_model_nm
        '
        Me.find_model_nm.ColumnName = "find_paymentterm_nm"
        Me.find_model_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_nm.Location = New System.Drawing.Point(633, 39)
        Me.find_model_nm.Name = "find_model_nm"
        Me.find_model_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_model_nm.TabIndex = 56
        Me.find_model_nm.TableName = "find_paymentterm_nm"
        Me.find_model_nm.Title = "Price Term 명"
        Me.find_model_nm.TitleWidth = 0
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(633, 66)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_nm_nm.TabIndex = 57
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
        '
        'find_model_no
        '
        Me.find_model_no.ColumnName = "find_paymentterm_nm"
        Me.find_model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_model_no.Location = New System.Drawing.Point(451, 39)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(176, 21)
        Me.find_model_no.TabIndex = 54
        Me.find_model_no.TableName = "find_paymentterm_nm"
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 80
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 507)
        Me.g_result.TabIndex = 1
        '
        'find_chk
        '
        Me.find_chk.Caption = ""
        Me.find_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_chk.Location = New System.Drawing.Point(792, 39)
        Me.find_chk.Name = "find_chk"
        Me.find_chk.Size = New System.Drawing.Size(240, 21)
        Me.find_chk.TabIndex = 73
        Me.find_chk.Title = "LOT 별 재고 조회"
        '
        'WP_SA1410
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1410"
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
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_nm As Frame7.eText
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eText
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents find_wh_cd As Frame7.eCombo
    Friend WithEvents find_sa_cd As Frame7.eCombo
    Friend WithEvents find_chk As Frame7.eCheck

End Class
