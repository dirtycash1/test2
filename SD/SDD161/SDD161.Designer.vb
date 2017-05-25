<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDD161
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
        Me.btn_jump = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_all = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.chg_dt = New Frame7.eDate()
        Me.itm_cd = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.model_cd = New Frame7.eCombo()
        Me.spec1 = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 556)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_jump)
        Me.EPanel1.Controls.Add(Me.btn_all)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.spec1)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.chg_dt)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(876, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'btn_jump
        '
        Me.btn_jump.Location = New System.Drawing.Point(352, 76)
        Me.btn_jump.Name = "btn_jump"
        Me.btn_jump.Size = New System.Drawing.Size(120, 24)
        Me.btn_jump.TabIndex = 66
        Me.btn_jump.Text = "매출처리"
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(228, 76)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(116, 24)
        Me.btn_all.TabIndex = 65
        Me.btn_all.Text = "전체선택"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(210, 21)
        Me.fr_dt.TabIndex = 13
        Me.fr_dt.Title = "소급정산일(fr)"
        Me.fr_dt.TitleWidth = 100
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(12, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(210, 21)
        Me.to_dt.TabIndex = 13
        Me.to_dt.Title = "소급정산일(to)"
        Me.to_dt.TitleWidth = 100
        '
        'chg_dt
        '
        Me.chg_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chg_dt.Location = New System.Drawing.Point(12, 76)
        Me.chg_dt.Name = "chg_dt"
        Me.chg_dt.Size = New System.Drawing.Size(210, 21)
        Me.chg_dt.TabIndex = 13
        Me.chg_dt.Title = "단가협의일"
        Me.chg_dt.TitleWidth = 100
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(228, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(210, 21)
        Me.itm_cd.TabIndex = 14
        Me.itm_cd.Title = "품목코드"
        Me.itm_cd.TitleWidth = 100
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(228, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(210, 21)
        Me.cust_cd.TabIndex = 14
        Me.cust_cd.Title = "거래처"
        Me.cust_cd.TitleWidth = 100
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(440, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(124, 21)
        Me.cust_nm.TabIndex = 14
        Me.cust_nm.Title = "거래처명"
        Me.cust_nm.TitleWidth = 0
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(440, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(124, 21)
        Me.itm_nm.TabIndex = 14
        Me.itm_nm.Title = "품목명"
        Me.itm_nm.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(876, 449)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     단가소급현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(872, 424)
        Me.g10.TabIndex = 2
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(572, 28)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(210, 21)
        Me.model_cd.TabIndex = 67
        Me.model_cd.Title = "차종"
        Me.model_cd.TitleWidth = 100
        '
        'spec1
        '
        Me.spec1.Location = New System.Drawing.Point(572, 52)
        Me.spec1.Name = "spec1"
        Me.spec1.Size = New System.Drawing.Size(210, 21)
        Me.spec1.TabIndex = 67
        Me.spec1.Title = "color"
        Me.spec1.TitleWidth = 100
        '
        'SDD161
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDD161"
        Me.Size = New System.Drawing.Size(882, 581)
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
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents chg_dt As Frame7.eDate
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_jump As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents spec1 As Frame7.eCombo

End Class
