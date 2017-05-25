<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMA100_SB_LIST
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
        Me.f_nm_nm = New Frame7.eText()
        Me.f_nm_cd = New Frame7.eText()
        Me.f_itm_bc = New Frame7.eCheckCombo()
        Me.f_grp1_cd = New Frame7.eCombo()
        Me.f_grp2_cd = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
        Me.f_itm_nm = New Frame7.eText()
        Me.f_itm_cd = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 120
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_itm_nm)
        Me.EPanel1.Controls.Add(Me.f_itm_cd)
        Me.EPanel1.Controls.Add(Me.f_itm_bc)
        Me.EPanel1.Controls.Add(Me.f_grp1_cd)
        Me.EPanel1.Controls.Add(Me.f_nm_nm)
        Me.EPanel1.Controls.Add(Me.f_nm_cd)
        Me.EPanel1.Controls.Add(Me.f_grp2_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 120)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     포장시방서 현황"
        '
        'f_nm_nm
        '
        Me.f_nm_nm.ColumnName = "pl_nm"
        Me.f_nm_nm.Location = New System.Drawing.Point(504, 36)
        Me.f_nm_nm.Name = "f_nm_nm"
        Me.f_nm_nm.Size = New System.Drawing.Size(229, 21)
        Me.f_nm_nm.TabIndex = 93
        Me.f_nm_nm.TableName = "pl_nm"
        Me.f_nm_nm.Title = "부서"
        Me.f_nm_nm.TitleWidth = 0
        '
        'f_nm_cd
        '
        Me.f_nm_cd.ColumnName = "ps_cd"
        Me.f_nm_cd.Location = New System.Drawing.Point(293, 36)
        Me.f_nm_cd.Name = "f_nm_cd"
        Me.f_nm_cd.Size = New System.Drawing.Size(208, 21)
        Me.f_nm_cd.TabIndex = 92
        Me.f_nm_cd.TableName = "ps_cd"
        Me.f_nm_cd.Title = "제품코드"
        Me.f_nm_cd.TitleWidth = 80
        '
        'f_itm_bc
        '
        Me.f_itm_bc.Location = New System.Drawing.Point(19, 36)
        Me.f_itm_bc.Name = "f_itm_bc"
        Me.f_itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_itm_bc.TabIndex = 12
        Me.f_itm_bc.Title = "품목구분"
        '
        'f_grp1_cd
        '
        Me.f_grp1_cd.Location = New System.Drawing.Point(19, 60)
        Me.f_grp1_cd.Name = "f_grp1_cd"
        Me.f_grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_grp1_cd.TabIndex = 11
        Me.f_grp1_cd.Title = "대분류"
        '
        'f_grp2_cd
        '
        Me.f_grp2_cd.Location = New System.Drawing.Point(19, 84)
        Me.f_grp2_cd.Name = "f_grp2_cd"
        Me.f_grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_grp2_cd.TabIndex = 10
        Me.f_grp2_cd.Title = "중분류"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1182, 487)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 487)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Location = New System.Drawing.Point(19, 41)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(210, 21)
        Me.EText3.TabIndex = 5
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "코 드"
        Me.EText3.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymentterm_nm"
        Me.EText4.Location = New System.Drawing.Point(19, 68)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(240, 21)
        Me.EText4.TabIndex = 6
        Me.EText4.TableName = "find_paymentterm_nm"
        Me.EText4.Title = "Price Term 명"
        Me.EText4.TitleWidth = 98
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(364, 41)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 7
        Me.ECombo2.Title = "사용여부"
        '
        'f_itm_nm
        '
        Me.f_itm_nm.ColumnName = "pl_nm"
        Me.f_itm_nm.Location = New System.Drawing.Point(504, 63)
        Me.f_itm_nm.Name = "f_itm_nm"
        Me.f_itm_nm.Size = New System.Drawing.Size(229, 21)
        Me.f_itm_nm.TabIndex = 95
        Me.f_itm_nm.TableName = "pl_nm"
        Me.f_itm_nm.Title = "부서"
        Me.f_itm_nm.TitleWidth = 0
        '
        'f_itm_cd
        '
        Me.f_itm_cd.ColumnName = "ps_cd"
        Me.f_itm_cd.Location = New System.Drawing.Point(293, 63)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(208, 21)
        Me.f_itm_cd.TabIndex = 94
        Me.f_itm_cd.TableName = "ps_cd"
        Me.f_itm_cd.Title = "품목코드"
        Me.f_itm_cd.TitleWidth = 80
        '
        'DMA100_SB_LIST
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMA100_SB_LIST"
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents f_itm_bc As Frame7.eCheckCombo
    Friend WithEvents f_grp1_cd As Frame7.eCombo
    Friend WithEvents f_grp2_cd As Frame7.eCombo
    Friend WithEvents f_nm_nm As Frame7.eText
    Friend WithEvents f_nm_cd As Frame7.eText
    Friend WithEvents f_itm_nm As Frame7.eText
    Friend WithEvents f_itm_cd As Frame7.eText

End Class
