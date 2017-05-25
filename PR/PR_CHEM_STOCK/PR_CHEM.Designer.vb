<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_CHEM
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
        Me.from_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.fac_cd = New Frame7.eCombo()
        Me.btn_jo2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_jo1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_jo3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g_list2 = New Frame7.eGrid()
        Me.g_list1 = New Frame7.eGrid()
        Me.CachedHRA100R1 = New System7.CachedHRA100R()
        Me.CachedGAC120R1 = New System7.CachedGAC120R()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1335, 581)
        Me.SplitContainer1.SplitterDistance = 70
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.from_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.btn_jo2)
        Me.EPanel1.Controls.Add(Me.btn_jo1)
        Me.EPanel1.Controls.Add(Me.btn_jo3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1335, 70)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(430, 35)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(202, 21)
        Me.from_dt.TabIndex = 123
        Me.from_dt.Title = "출고기간"
        Me.from_dt.TitleWidth = 98
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(635, 35)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(121, 21)
        Me.to_dt.TabIndex = 124
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(15, 35)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(186, 21)
        Me.fac_cd.TabIndex = 2
        Me.fac_cd.Title = "공장 선택"
        Me.fac_cd.TitleWidth = 80
        '
        'btn_jo2
        '
        Me.btn_jo2.Location = New System.Drawing.Point(773, 26)
        Me.btn_jo2.Name = "btn_jo2"
        Me.btn_jo2.Size = New System.Drawing.Size(156, 35)
        Me.btn_jo2.TabIndex = 121
        Me.btn_jo2.Text = "약품 출고 내역 조회"
        '
        'btn_jo1
        '
        Me.btn_jo1.Location = New System.Drawing.Point(219, 26)
        Me.btn_jo1.Name = "btn_jo1"
        Me.btn_jo1.Size = New System.Drawing.Size(158, 35)
        Me.btn_jo1.TabIndex = 5
        Me.btn_jo1.Text = "현 재고 상황 조회"
        '
        'btn_jo3
        '
        Me.btn_jo3.Location = New System.Drawing.Point(951, 26)
        Me.btn_jo3.Name = "btn_jo3"
        Me.btn_jo3.Size = New System.Drawing.Size(143, 35)
        Me.btn_jo3.TabIndex = 122
        Me.btn_jo3.Text = "유효기간 초과내역"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1335, 507)
        Me.SplitContainer2.SplitterDistance = 277
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g30)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1335, 277)
        Me.EPanel3.TabIndex = 113
        Me.EPanel3.Text = "     약품재고현황"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(1331, 252)
        Me.g30.TabIndex = 114
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1331, 252)
        Me.g20.TabIndex = 113
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1331, 252)
        Me.g10.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Location = New System.Drawing.Point(72, 9)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer3.Panel1MinSize = 0
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(1332, 251)
        Me.SplitContainer3.SplitterDistance = 222
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g_list2)
        Me.EPanel2.Controls.Add(Me.g_list1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1335, 226)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     약품재고상세"
        '
        'g_list2
        '
        Me.g_list2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list2.Location = New System.Drawing.Point(2, 23)
        Me.g_list2.Name = "g_list2"
        Me.g_list2.ReadOnly = False
        Me.g_list2.RowHeight = -1
        Me.g_list2.Size = New System.Drawing.Size(1331, 201)
        Me.g_list2.TabIndex = 113
        '
        'g_list1
        '
        Me.g_list1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list1.Location = New System.Drawing.Point(2, 23)
        Me.g_list1.Name = "g_list1"
        Me.g_list1.ReadOnly = False
        Me.g_list1.RowHeight = -1
        Me.g_list1.Size = New System.Drawing.Size(1331, 201)
        Me.g_list1.TabIndex = 0
        '
        'PR_CHEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PR_CHEM"
        Me.Size = New System.Drawing.Size(1347, 592)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents btn_jo1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g_list1 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents CachedHRA100R1 As System7.CachedHRA100R
    Friend WithEvents btn_jo3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_jo2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents g_list2 As Frame7.eGrid
    Friend WithEvents CachedGAC120R1 As System7.CachedGAC120R

End Class
