<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCV160_2
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
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.confirm_no = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.use_yn = New Frame7.eCombo()
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
        Me.spc_1.SplitterDistance = 74
        Me.spc_1.TabIndex = 5
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.use_yn)
        Me.EPanel2.Controls.Add(Me.cust_cd)
        Me.EPanel2.Controls.Add(Me.confirm_no)
        Me.EPanel2.Controls.Add(Me.cust_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 74)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     여신정보 조회"
        '
        'cust_cd
        '
        Me.cust_cd.ColumnName = "find_paymenterm_cd"
        Me.cust_cd.Location = New System.Drawing.Point(15, 33)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(201, 21)
        Me.cust_cd.TabIndex = 197
        Me.cust_cd.TableName = "find_paymenterm_cd"
        Me.cust_cd.Title = "거래처코드"
        Me.cust_cd.TitleWidth = 90
        '
        'cust_nm
        '
        Me.cust_nm.ColumnName = "ps_nm"
        Me.cust_nm.Location = New System.Drawing.Point(221, 33)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(186, 21)
        Me.cust_nm.TabIndex = 196
        Me.cust_nm.TableName = "ps_nm"
        Me.cust_nm.Title = "ps_nm1"
        Me.cust_nm.TitleWidth = 0
        '
        'confirm_no
        '
        Me.confirm_no.Location = New System.Drawing.Point(15, 151)
        Me.confirm_no.Name = "confirm_no"
        Me.confirm_no.Size = New System.Drawing.Size(240, 21)
        Me.confirm_no.TabIndex = 201
        Me.confirm_no.Title = "전표번호"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 533)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     여신정보"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1178, 508)
        Me.g10.TabIndex = 2
        '
        'use_yn
        '
        Me.use_yn.Location = New System.Drawing.Point(468, 33)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(193, 21)
        Me.use_yn.TabIndex = 202
        Me.use_yn.Title = "사용여부"
        Me.use_yn.TitleWidth = 90
        '
        'BCV160_2
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "BCV160_2"
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
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents confirm_no As Frame7.eText
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents use_yn As Frame7.eCombo

End Class
