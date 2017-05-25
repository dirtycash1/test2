<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1125
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
        Me.ship_nm = New Frame7.eText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.to_dt = New Frame7.eDate()
        Me.from_dt = New Frame7.eDate()
        Me.cs_nm = New Frame7.eText()
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
        Me.spc_1.SplitterDistance = 83
        Me.spc_1.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.ship_nm)
        Me.EPanel2.Controls.Add(Me.Label1)
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 83)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수주배송일변경"
        '
        'ship_nm
        '
        Me.ship_nm.ColumnName = "ps_nm"
        Me.ship_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ship_nm.Location = New System.Drawing.Point(625, 33)
        Me.ship_nm.Name = "ship_nm"
        Me.ship_nm.Size = New System.Drawing.Size(360, 21)
        Me.ship_nm.TabIndex = 208
        Me.ship_nm.TableName = "ps_nm"
        Me.ship_nm.Title = "배송지"
        Me.ship_nm.TitleWidth = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 14)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "※변경할 수주를 선택한 후 배송일자를 변경하고 확인을 클릭하면 됩니다."
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
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(12, 33)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(159, 21)
        Me.from_dt.TabIndex = 193
        Me.from_dt.Title = "배송일자"
        Me.from_dt.TitleWidth = 60
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "ps_nm"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(298, 33)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(311, 21)
        Me.cs_nm.TabIndex = 196
        Me.cs_nm.TableName = "ps_nm"
        Me.cs_nm.Title = "거래처"
        Me.cs_nm.TitleWidth = 70
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_list)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 524)
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
        Me.g_list.Size = New System.Drawing.Size(1178, 499)
        Me.g_list.TabIndex = 2
        '
        'WI_SA1125
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1125"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(false)
        Me.spc_1.Panel2.ResumeLayout(false)
        Me.spc_1.ResumeLayout(false)
        CType(Me.EPanel2,System.ComponentModel.ISupportInitialize).EndInit
        Me.EPanel2.ResumeLayout(false)
        Me.EPanel2.PerformLayout
        CType(Me.EPanel3,System.ComponentModel.ISupportInitialize).EndInit
        Me.EPanel3.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ship_nm As Frame7.eText

End Class
