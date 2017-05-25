<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMV110
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
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.itm_yn = New Frame7.eCheck()
        Me.grp1_cd = New Frame7.eCombo()
        Me.itm_bc = New Frame7.eCheckCombo()
        Me.cust_cd = New Frame7.eText()
        Me.model_cd = New Frame7.eCombo()
        Me.cust_cd2 = New Frame7.eText()
        Me.grp2_cd = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.cust_nm2 = New Frame7.eText()
        Me.grp3_cd = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1068, 360)
        Me.SplitContainer1.SplitterDistance = 104
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.itm_yn)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.cust_cd2)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_nm2)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1068, 104)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(8, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 3
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(8, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 3
        '
        'itm_yn
        '
        Me.itm_yn.Caption = ""
        Me.itm_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_yn.Location = New System.Drawing.Point(264, 76)
        Me.itm_yn.Name = "itm_yn"
        Me.itm_yn.Size = New System.Drawing.Size(140, 21)
        Me.itm_yn.TabIndex = 6
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(264, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 5
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(8, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 4
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(520, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 3
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(520, 28)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 5
        '
        'cust_cd2
        '
        Me.cust_cd2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd2.Location = New System.Drawing.Point(520, 76)
        Me.cust_cd2.Name = "cust_cd2"
        Me.cust_cd2.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd2.TabIndex = 3
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(264, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 5
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(764, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 3
        Me.cust_nm.TitleWidth = 0
        '
        'cust_nm2
        '
        Me.cust_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm2.Location = New System.Drawing.Point(764, 76)
        Me.cust_nm2.Name = "cust_nm2"
        Me.cust_nm2.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm2.TabIndex = 3
        Me.cust_nm2.TitleWidth = 0
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(1024, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(32, 21)
        Me.grp3_cd.TabIndex = 5
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1068, 252)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     품목별 매입처 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1064, 227)
        Me.g10.TabIndex = 2
        '
        'MMV110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMV110"
        Me.Size = New System.Drawing.Size(1090, 392)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents itm_yn As Frame7.eCheck
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCheckCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents cust_cd2 As Frame7.eText
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_nm2 As Frame7.eText
    Friend WithEvents grp3_cd As Frame7.eCombo

End Class
