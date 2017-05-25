<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1175
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.to_dt = New Frame7.eDate()
        Me.find_cs_cd = New Frame7.eText()
        Me.find_cs_nm = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_list = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.spc_1.Panel1.Controls.Add(Me.EPanel2)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.EPanel3)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 78
        Me.spc_1.TabIndex = 7
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Controls.Add(Me.find_cs_cd)
        Me.EPanel2.Controls.Add(Me.find_cs_nm)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 78)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수주접수등록"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(174, 33)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(111, 21)
        Me.to_dt.TabIndex = 194
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'find_cs_cd
        '
        Me.find_cs_cd.ColumnName = "find_paymenterm_cd"
        Me.find_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_cd.Location = New System.Drawing.Point(327, 33)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(140, 21)
        Me.find_cs_cd.TabIndex = 197
        Me.find_cs_cd.TableName = "find_paymenterm_cd"
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.ColumnName = "ps_nm"
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(470, 33)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(264, 21)
        Me.find_cs_nm.TabIndex = 196
        Me.find_cs_nm.TableName = "ps_nm"
        Me.find_cs_nm.Title = "ps_nm1"
        Me.find_cs_nm.TitleWidth = 0
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(12, 33)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(159, 21)
        Me.from_dt.TabIndex = 193
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 60
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_list)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 529)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     수주리스트"
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(2, 23)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(1178, 504)
        Me.g_list.TabIndex = 2
        '
        'WI_SA1175
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1175"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid

End Class
