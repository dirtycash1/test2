<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1255
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
        Me.MV_from = New Frame7.eDate()
        Me.MV_to = New Frame7.eDate()
        Me.find_nm_nm = New Frame7.eText()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_lot_no = New Frame7.eText()
        Me.g_result = New Frame7.eGrid()
        Me.find_nw_nm_cd = New Frame7.eText()
        Me.find_nw_nm_nm = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_result)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.MV_from)
        Me.EPanel1.Controls.Add(Me.find_nm_nm)
        Me.EPanel1.Controls.Add(Me.find_nm_cd)
        Me.EPanel1.Controls.Add(Me.MV_to)
        Me.EPanel1.Controls.Add(Me.find_lot_no)
        Me.EPanel1.Controls.Add(Me.find_nw_nm_nm)
        Me.EPanel1.Controls.Add(Me.find_nw_nm_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 97)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'MV_from
        '
        Me.MV_from.Location = New System.Drawing.Point(19, 35)
        Me.MV_from.Name = "MV_from"
        Me.MV_from.Size = New System.Drawing.Size(179, 21)
        Me.MV_from.TabIndex = 114
        Me.MV_from.Title = "이동기간"
        Me.MV_from.TitleWidth = 80
        '
        'MV_to
        '
        Me.MV_to.Location = New System.Drawing.Point(204, 35)
        Me.MV_to.Name = "MV_to"
        Me.MV_to.Size = New System.Drawing.Size(149, 21)
        Me.MV_to.TabIndex = 114
        Me.MV_to.Title = "    ~"
        Me.MV_to.TitleWidth = 50
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "job_no"
        Me.find_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_nm.Location = New System.Drawing.Point(559, 35)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(193, 21)
        Me.find_nm_nm.TabIndex = 111
        Me.find_nm_nm.TableName = "job_no"
        Me.find_nm_nm.Title = "CHECK_SHEET NO."
        Me.find_nm_nm.TitleWidth = 0
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "job_no"
        Me.find_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nm_cd.Location = New System.Drawing.Point(376, 35)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(177, 21)
        Me.find_nm_cd.TabIndex = 110
        Me.find_nm_cd.TableName = "job_no"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 108
        '
        'find_lot_no
        '
        Me.find_lot_no.ColumnName = "job_no"
        Me.find_lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_lot_no.Location = New System.Drawing.Point(19, 64)
        Me.find_lot_no.Name = "find_lot_no"
        Me.find_lot_no.Size = New System.Drawing.Size(334, 21)
        Me.find_lot_no.TabIndex = 107
        Me.find_lot_no.TableName = "job_no"
        Me.find_lot_no.Title = "CHECK_SHEET NO."
        Me.find_lot_no.TitleWidth = 108
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 510)
        Me.g_result.TabIndex = 0
        '
        'find_nw_nm_cd
        '
        Me.find_nw_nm_cd.ColumnName = "job_no"
        Me.find_nw_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nw_nm_cd.Location = New System.Drawing.Point(376, 64)
        Me.find_nw_nm_cd.Name = "find_nw_nm_cd"
        Me.find_nw_nm_cd.Size = New System.Drawing.Size(177, 21)
        Me.find_nw_nm_cd.TabIndex = 110
        Me.find_nw_nm_cd.TableName = "job_no"
        Me.find_nw_nm_cd.Title = "제품명"
        Me.find_nw_nm_cd.TitleWidth = 108
        '
        'find_nw_nm_nm
        '
        Me.find_nw_nm_nm.ColumnName = "job_no"
        Me.find_nw_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_nw_nm_nm.Location = New System.Drawing.Point(559, 64)
        Me.find_nw_nm_nm.Name = "find_nw_nm_nm"
        Me.find_nw_nm_nm.Size = New System.Drawing.Size(193, 21)
        Me.find_nw_nm_nm.TabIndex = 111
        Me.find_nw_nm_nm.TableName = "job_no"
        Me.find_nw_nm_nm.Title = "CHECK_SHEET NO."
        Me.find_nw_nm_nm.TitleWidth = 0
        '
        'WI_SA1255
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1255"
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
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_lot_no As Frame7.eText
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents MV_from As Frame7.eDate
    Friend WithEvents MV_to As Frame7.eDate
    Friend WithEvents find_nw_nm_nm As Frame7.eText
    Friend WithEvents find_nw_nm_cd As Frame7.eText

End Class
