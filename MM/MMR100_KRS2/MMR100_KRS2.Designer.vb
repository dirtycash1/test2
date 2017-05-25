<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMR100_KRS2
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.day_cnt = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.std_dt = New Frame7.eDate()
        Me.itm_bc = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.cust_nm = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 516)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.day_cnt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.std_dt)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(956, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'day_cnt
        '
        Me.day_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.day_cnt.Location = New System.Drawing.Point(260, 28)
        Me.day_cnt.Name = "day_cnt"
        Me.day_cnt.Size = New System.Drawing.Size(92, 21)
        Me.day_cnt.TabIndex = 51
        Me.day_cnt.Title = "기간"
        Me.day_cnt.TitleWidth = 40
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(384, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 49
        Me.itm_cd.Title = "품목코드%"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(384, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 50
        Me.itm_nm.Title = "품목명%"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(12, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 32
        Me.fac_cd.Title = "관리공장"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(641, 52)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 41
        Me.grp1_cd.Title = "대분류"
        '
        'std_dt
        '
        Me.std_dt.Location = New System.Drawing.Point(12, 28)
        Me.std_dt.Name = "std_dt"
        Me.std_dt.Size = New System.Drawing.Size(240, 21)
        Me.std_dt.TabIndex = 33
        Me.std_dt.Title = "기준일"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(641, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 40
        Me.itm_bc.Title = "품목구분"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(956, 409)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     자재 결품 예상 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(952, 384)
        Me.g10.TabIndex = 2
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(256, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(249, 21)
        Me.cust_nm.TabIndex = 85
        Me.cust_nm.Title = "출고거래처명"
        Me.cust_nm.TitleWidth = 0
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 84
        Me.cust_cd.Title = "납품처"
        '
        'MMR100_KRS2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMR100_KRS2"
        Me.Size = New System.Drawing.Size(1000, 690)
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
    Friend WithEvents day_cnt As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents std_dt As Frame7.eDate
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText

End Class
