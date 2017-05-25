<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMR201
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
        Me.btn_reqpo = New DevExpress.XtraEditors.SimpleButton()
        Me.itm_cd = New Frame7.eText()
        Me.grp2_cd = New Frame7.eCombo()
        Me.grp1_cd = New Frame7.eCombo()
        Me.grp3_cd = New Frame7.eCombo()
        Me.itm_bc = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.dlv_t_dt = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.dlv_f_dt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.fac_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 516)
        Me.SplitContainer1.SplitterDistance = 108
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.btn_reqpo)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.dlv_f_dt)
        Me.EPanel1.Controls.Add(Me.dlv_t_dt)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(956, 108)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'btn_reqpo
        '
        Me.btn_reqpo.Location = New System.Drawing.Point(556, 80)
        Me.btn_reqpo.Name = "btn_reqpo"
        Me.btn_reqpo.Size = New System.Drawing.Size(100, 24)
        Me.btn_reqpo.TabIndex = 50
        Me.btn_reqpo.Text = "구매의뢰"
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(8, 76)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 49
        Me.itm_cd.Title = "품목코드%"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(696, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 42
        Me.grp2_cd.Title = "중분류"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(696, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 41
        Me.grp1_cd.Title = "대분류"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(696, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 43
        Me.grp3_cd.Title = "소분류"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(432, 52)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 40
        Me.itm_bc.Title = "품목구분"
        '
        'itm_nm
        '
        Me.itm_nm.Location = New System.Drawing.Point(252, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(160, 21)
        Me.itm_nm.TabIndex = 39
        Me.itm_nm.Title = "출고번호"
        Me.itm_nm.TitleWidth = 0
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(252, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(160, 21)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'dlv_t_dt
        '
        Me.dlv_t_dt.Location = New System.Drawing.Point(252, 28)
        Me.dlv_t_dt.Name = "dlv_t_dt"
        Me.dlv_t_dt.Size = New System.Drawing.Size(160, 21)
        Me.dlv_t_dt.TabIndex = 36
        Me.dlv_t_dt.Title = "부터"
        Me.dlv_t_dt.TitleWidth = 40
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(8, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.Title = "거래처"
        '
        'dlv_f_dt
        '
        Me.dlv_f_dt.Location = New System.Drawing.Point(8, 28)
        Me.dlv_f_dt.Name = "dlv_f_dt"
        Me.dlv_f_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_f_dt.TabIndex = 33
        Me.dlv_f_dt.Title = "발주예정일"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(956, 404)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     자재 소요량 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(952, 379)
        Me.g10.TabIndex = 2
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(432, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 51
        Me.fac_cd.Title = "관리공장"
        '
        'MMR201
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMR201"
        Me.Size = New System.Drawing.Size(977, 563)
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
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents dlv_t_dt As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents dlv_f_dt As Frame7.eDate
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents btn_reqpo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fac_cd As Frame7.eCombo

End Class
