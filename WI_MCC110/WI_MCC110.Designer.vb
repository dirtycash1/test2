<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_MCC110
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
        Me.FAC_CD = New Frame7.eCombo()
        Me.LOT_NO = New Frame7.eText()
        Me.GD_CD = New Frame7.eText()
        Me.GD_NM = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.MC_CD = New Frame7.eCombo()
        Me.MC_NO = New Frame7.eText()
        Me.g_multi = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_multi)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 99
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.FAC_CD)
        Me.EPanel1.Controls.Add(Me.LOT_NO)
        Me.EPanel1.Controls.Add(Me.GD_CD)
        Me.EPanel1.Controls.Add(Me.GD_NM)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.MC_CD)
        Me.EPanel1.Controls.Add(Me.MC_NO)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 99)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     MC 현황"
        '
        'FAC_CD
        '
        Me.FAC_CD.Location = New System.Drawing.Point(639, 34)
        Me.FAC_CD.Name = "FAC_CD"
        Me.FAC_CD.Size = New System.Drawing.Size(240, 21)
        Me.FAC_CD.TabIndex = 63
        Me.FAC_CD.Title = "공장번호"
        Me.FAC_CD.TitleWidth = 98
        '
        'LOT_NO
        '
        Me.LOT_NO.ColumnName = "find_paymentterm_nm"
        Me.LOT_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LOT_NO.Location = New System.Drawing.Point(364, 34)
        Me.LOT_NO.Name = "LOT_NO"
        Me.LOT_NO.Size = New System.Drawing.Size(256, 21)
        Me.LOT_NO.TabIndex = 62
        Me.LOT_NO.TableName = "find_paymentterm_nm"
        Me.LOT_NO.Title = "CHECK  SHEET NO"
        Me.LOT_NO.TitleWidth = 110
        '
        'GD_CD
        '
        Me.GD_CD.ColumnName = "find_paymentterm_nm"
        Me.GD_CD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_CD.Location = New System.Drawing.Point(19, 61)
        Me.GD_CD.Name = "GD_CD"
        Me.GD_CD.Size = New System.Drawing.Size(176, 21)
        Me.GD_CD.TabIndex = 58
        Me.GD_CD.TableName = "find_paymentterm_nm"
        Me.GD_CD.Title = "제품명"
        Me.GD_CD.TitleWidth = 60
        '
        'GD_NM
        '
        Me.GD_NM.ColumnName = "find_paymentterm_nm"
        Me.GD_NM.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.GD_NM.Location = New System.Drawing.Point(201, 61)
        Me.GD_NM.Name = "GD_NM"
        Me.GD_NM.Size = New System.Drawing.Size(140, 21)
        Me.GD_NM.TabIndex = 59
        Me.GD_NM.TableName = "find_paymentterm_nm"
        Me.GD_NM.Title = "Price Term 명"
        Me.GD_NM.TitleWidth = 0
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(19, 34)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(176, 21)
        Me.fr_dt.TabIndex = 54
        Me.fr_dt.Title = "기간"
        Me.fr_dt.TitleWidth = 60
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(201, 34)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(140, 21)
        Me.to_dt.TabIndex = 55
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'MC_CD
        '
        Me.MC_CD.Location = New System.Drawing.Point(639, 61)
        Me.MC_CD.Name = "MC_CD"
        Me.MC_CD.Size = New System.Drawing.Size(240, 21)
        Me.MC_CD.TabIndex = 12
        Me.MC_CD.Title = "장비 번호"
        Me.MC_CD.TitleWidth = 98
        '
        'MC_NO
        '
        Me.MC_NO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.MC_NO.Location = New System.Drawing.Point(364, 61)
        Me.MC_NO.Name = "MC_NO"
        Me.MC_NO.Size = New System.Drawing.Size(256, 21)
        Me.MC_NO.TabIndex = 11
        Me.MC_NO.Title = "교체번호"
        Me.MC_NO.TitleWidth = 110
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 508)
        Me.g_multi.TabIndex = 2
        '
        'WI_MCC110
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_MCC110"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents MC_NO As Frame7.eText
    Friend WithEvents MC_CD As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents GD_CD As Frame7.eText
    Friend WithEvents GD_NM As Frame7.eText
    Friend WithEvents LOT_NO As Frame7.eText
    Friend WithEvents FAC_CD As Frame7.eCombo

End Class
