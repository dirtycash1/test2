<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1174
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
        Me.sa_cd = New Frame7.eCombo()
        Me.sale_emp = New Frame7.eText()
        Me.se_no = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.se_dt = New Frame7.eDate()
        Me.chk_all = New Frame7.eCheck()
        Me.ps_cd = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
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
        Me.spc_1.SplitterDistance = 89
        Me.spc_1.TabIndex = 5
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.sale_emp)
        Me.EPanel2.Controls.Add(Me.se_no)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.se_dt)
        Me.EPanel2.Controls.Add(Me.chk_all)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 89)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     세금계산서발행"
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(661, 33)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(168, 21)
        Me.sa_cd.TabIndex = 206
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 70
        '
        'sale_emp
        '
        Me.sale_emp.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_emp.Location = New System.Drawing.Point(386, 59)
        Me.sale_emp.Name = "sale_emp"
        Me.sale_emp.Size = New System.Drawing.Size(256, 21)
        Me.sale_emp.TabIndex = 204
        Me.sale_emp.Title = "영업담당자"
        Me.sale_emp.TitleWidth = 70
        '
        'se_no
        '
        Me.se_no.ColumnName = "find_paymenterm_cd"
        Me.se_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.se_no.Location = New System.Drawing.Point(200, 154)
        Me.se_no.Name = "se_no"
        Me.se_no.Size = New System.Drawing.Size(261, 21)
        Me.se_no.TabIndex = 210
        Me.se_no.TableName = "find_paymenterm_cd"
        Me.se_no.Title = "발행번호-삭제x"
        Me.se_no.TitleWidth = 90
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(196, 59)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(179, 21)
        Me.cs_nm.TabIndex = 202
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'pl_cd
        '
        Me.pl_cd.ColumnName = "find_paymenterm_cd"
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(44, 154)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(150, 21)
        Me.pl_cd.TabIndex = 205
        Me.pl_cd.TableName = "find_paymenterm_cd"
        Me.pl_cd.Title = "발행자부서"
        Me.pl_cd.TitleWidth = 70
        '
        'se_dt
        '
        Me.se_dt.Location = New System.Drawing.Point(845, 33)
        Me.se_dt.Name = "se_dt"
        Me.se_dt.Size = New System.Drawing.Size(169, 21)
        Me.se_dt.TabIndex = 198
        Me.se_dt.Title = "발행일자"
        Me.se_dt.TitleWidth = 60
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(661, 59)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(240, 21)
        Me.chk_all.TabIndex = 211
        Me.chk_all.Title = "전체선택"
        Me.chk_all.TitleWidth = 60
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(386, 33)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(150, 21)
        Me.ps_cd.TabIndex = 197
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "발행자"
        Me.ps_cd.TitleWidth = 70
        '
        'cs_cd
        '
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(12, 59)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(182, 21)
        Me.cs_cd.TabIndex = 201
        Me.cs_cd.Title = "발행거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "ps_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(538, 33)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 196
        Me.ps_nm.TableName = "ps_nm"
        Me.ps_nm.Title = "ps_nm1"
        Me.ps_nm.TitleWidth = 0
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(12, 33)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(198, 21)
        Me.from_dt.TabIndex = 193
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 98
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(216, 33)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(111, 21)
        Me.to_dt.TabIndex = 194
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_list)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 518)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     발행리스트"
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(2, 23)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(1178, 493)
        Me.g_list.TabIndex = 2
        '
        'WI_SA1174
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1174"
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
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents sale_emp As Frame7.eText
    Friend WithEvents se_no As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents se_dt As Frame7.eDate
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid

End Class
