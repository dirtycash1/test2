<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPD200
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
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.fac_cd = New Frame7.eCombo()
        Me.ty = New Frame7.eCheckCombo()
        Me.days = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.grp1_cd = New Frame7.eCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.btn_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del_all = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.btn_row = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 516)
        Me.SplitContainer1.SplitterDistance = 102
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.ty)
        Me.EPanel1.Controls.Add(Me.days)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 102)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "co_cd"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(268, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "fr_dt"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(12, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 3
        Me.fac_cd.Title = "fac_cd"
        '
        'ty
        '
        Me.ty.Location = New System.Drawing.Point(268, 76)
        Me.ty.Name = "ty"
        Me.ty.Size = New System.Drawing.Size(240, 21)
        Me.ty.TabIndex = 8
        Me.ty.Title = "ty"
        '
        'days
        '
        Me.days.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.days.Location = New System.Drawing.Point(268, 52)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(240, 21)
        Me.days.TabIndex = 6
        Me.days.Title = "days"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(524, 52)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 7
        Me.itm_nm.Title = "itm_nm"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(776, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 3
        Me.grp1_cd.Title = "grp1_cd"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(776, 52)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 3
        Me.model_cd.Title = "model_cd"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(524, 28)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 7
        Me.itm_cd.Title = "itm_cd"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(12, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 5
        Me.to_dt.Title = "to_dt"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1020, 410)
        Me.SplitContainer2.SplitterDistance = 255
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Controls.Add(Me.btn_all)
        Me.EPanel2.Controls.Add(Me.btn_del_all)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1020, 255)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     일 생산계획"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1016, 230)
        Me.g10.TabIndex = 2
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(644, 2)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(100, 21)
        Me.btn_all.TabIndex = 21
        Me.btn_all.Text = "소요산출"
        '
        'btn_del_all
        '
        Me.btn_del_all.Location = New System.Drawing.Point(752, 2)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(100, 21)
        Me.btn_del_all.TabIndex = 21
        Me.btn_del_all.Text = "소요삭제"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Controls.Add(Me.btn_row)
        Me.EPanel3.Controls.Add(Me.btn_del)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1020, 151)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     반제품 생산계획"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1016, 126)
        Me.g20.TabIndex = 2
        '
        'btn_row
        '
        Me.btn_row.Location = New System.Drawing.Point(644, 3)
        Me.btn_row.Name = "btn_row"
        Me.btn_row.Size = New System.Drawing.Size(100, 19)
        Me.btn_row.TabIndex = 22
        Me.btn_row.Text = "소요산출"
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(752, 3)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(100, 19)
        Me.btn_del.TabIndex = 22
        Me.btn_del.Text = "소요삭제"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(644, 78)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 21)
        Me.SimpleButton1.TabIndex = 21
        Me.SimpleButton1.Text = "출하계획 반영하기"
        '
        'PPD200
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PPD200"
        Me.Size = New System.Drawing.Size(1034, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents days As Frame7.eText
    Friend WithEvents ty As Frame7.eCheckCombo
    Friend WithEvents btn_row As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents btn_del_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton

End Class
