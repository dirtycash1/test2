<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1121
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
        Me.confirm_no = New Frame7.eText()
        Me.confirm_dt = New Frame7.eDate()
        Me.confirm_pscd = New Frame7.eText()
        Me.delete_odno = New Frame7.eText()
        Me.head_odno = New Frame7.eText()
        Me.confirm_psnm = New Frame7.eText()
        Me.confirm_gu = New Frame7.eOptionBox()
        Me.to_dt = New Frame7.eDate()
        Me.from_dt = New Frame7.eDate()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_odno = New Frame7.eGrid()
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
        Me.spc_1.SplitterDistance = 66
        Me.spc_1.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.confirm_no)
        Me.EPanel2.Controls.Add(Me.confirm_dt)
        Me.EPanel2.Controls.Add(Me.confirm_pscd)
        Me.EPanel2.Controls.Add(Me.delete_odno)
        Me.EPanel2.Controls.Add(Me.head_odno)
        Me.EPanel2.Controls.Add(Me.confirm_psnm)
        Me.EPanel2.Controls.Add(Me.confirm_gu)
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 66)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     수주접수등록"
        '
        'confirm_no
        '
        Me.confirm_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.confirm_no.Location = New System.Drawing.Point(807, 23)
        Me.confirm_no.Name = "confirm_no"
        Me.confirm_no.Size = New System.Drawing.Size(240, 21)
        Me.confirm_no.TabIndex = 201
        Me.confirm_no.Title = "전표번호"
        '
        'confirm_dt
        '
        Me.confirm_dt.Location = New System.Drawing.Point(847, 33)
        Me.confirm_dt.Name = "confirm_dt"
        Me.confirm_dt.Size = New System.Drawing.Size(169, 21)
        Me.confirm_dt.TabIndex = 198
        Me.confirm_dt.Title = "접수일자"
        Me.confirm_dt.TitleWidth = 60
        '
        'confirm_pscd
        '
        Me.confirm_pscd.ColumnName = "find_paymenterm_cd"
        Me.confirm_pscd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.confirm_pscd.Location = New System.Drawing.Point(569, 33)
        Me.confirm_pscd.Name = "confirm_pscd"
        Me.confirm_pscd.Size = New System.Drawing.Size(140, 21)
        Me.confirm_pscd.TabIndex = 197
        Me.confirm_pscd.TableName = "find_paymenterm_cd"
        Me.confirm_pscd.Title = "접수자"
        Me.confirm_pscd.TitleWidth = 60
        '
        'delete_odno
        '
        Me.delete_odno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.delete_odno.Location = New System.Drawing.Point(1023, 40)
        Me.delete_odno.Name = "delete_odno"
        Me.delete_odno.Size = New System.Drawing.Size(240, 21)
        Me.delete_odno.TabIndex = 200
        Me.delete_odno.Title = "수주번호-삭제용"
        '
        'head_odno
        '
        Me.head_odno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.head_odno.Location = New System.Drawing.Point(1023, 16)
        Me.head_odno.Name = "head_odno"
        Me.head_odno.Size = New System.Drawing.Size(240, 21)
        Me.head_odno.TabIndex = 199
        Me.head_odno.Title = "수주번호-찾기용"
        '
        'confirm_psnm
        '
        Me.confirm_psnm.ColumnName = "ps_nm"
        Me.confirm_psnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.confirm_psnm.Location = New System.Drawing.Point(711, 33)
        Me.confirm_psnm.Name = "confirm_psnm"
        Me.confirm_psnm.Size = New System.Drawing.Size(104, 21)
        Me.confirm_psnm.TabIndex = 196
        Me.confirm_psnm.TableName = "ps_nm"
        Me.confirm_psnm.Title = "ps_nm1"
        Me.confirm_psnm.TitleWidth = 0
        '
        'confirm_gu
        '
        Me.confirm_gu.Location = New System.Drawing.Point(302, 33)
        Me.confirm_gu.Name = "confirm_gu"
        Me.confirm_gu.SelectedIndex = -1
        Me.confirm_gu.Size = New System.Drawing.Size(240, 24)
        Me.confirm_gu.TabIndex = 195
        Me.confirm_gu.Title = "구분"
        Me.confirm_gu.TitleWidth = 60
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
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 60
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_odno)
        Me.EPanel3.Controls.Add(Me.g_list)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 541)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     수주리스트"
        '
        'g_odno
        '
        Me.g_odno.Location = New System.Drawing.Point(490, 2)
        Me.g_odno.Name = "g_odno"
        Me.g_odno.ReadOnly = False
        Me.g_odno.RowHeight = -1
        Me.g_odno.Size = New System.Drawing.Size(392, 174)
        Me.g_odno.TabIndex = 3
        Me.g_odno.Visible = False
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(2, 23)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(1178, 516)
        Me.g_list.TabIndex = 2
        '
        'WI_SA1121
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1121"
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
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents confirm_gu As Frame7.eOptionBox
    Friend WithEvents confirm_dt As Frame7.eDate
    Friend WithEvents confirm_pscd As Frame7.eText
    Friend WithEvents confirm_psnm As Frame7.eText
    Friend WithEvents head_odno As Frame7.eText
    Friend WithEvents delete_odno As Frame7.eText
    Friend WithEvents g_odno As Frame7.eGrid
    Friend WithEvents confirm_no As Frame7.eText

End Class
