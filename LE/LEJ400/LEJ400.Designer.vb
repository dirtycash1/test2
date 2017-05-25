<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEJ400
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
        Me.wh_cd = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.out_dt = New Frame7.eDate()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.grp1_cd = New Frame7.eCombo()
        Me.grp2_cd = New Frame7.eCombo()
        Me.out_no = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.grp3_cd = New Frame7.eCombo()
        Me.std_month = New Frame7.eDate()
        Me.itm_bc = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1040, 516)
        Me.SplitContainer1.SplitterDistance = 105
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.btn_work)
        Me.EPanel1.Controls.Add(Me.btn_delete)
        Me.EPanel1.Controls.Add(Me.grp1_cd)
        Me.EPanel1.Controls.Add(Me.out_dt)
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.out_no)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.grp3_cd)
        Me.EPanel1.Controls.Add(Me.std_month)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1040, 105)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(12, 76)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 60
        Me.wh_cd.Title = "관리창고"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(260, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 50
        Me.itm_nm.Title = "품목명%"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(772, 36)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(116, 24)
        Me.btn_work.TabIndex = 63
        Me.btn_work.Text = "조정출고"
        '
        'out_dt
        '
        Me.out_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_dt.Format = "yyyy-MM-dd"
        Me.out_dt.Location = New System.Drawing.Point(972, 32)
        Me.out_dt.Name = "out_dt"
        Me.out_dt.Size = New System.Drawing.Size(240, 21)
        Me.out_dt.TabIndex = 62
        Me.out_dt.Title = "출고일"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(772, 72)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(116, 24)
        Me.btn_delete.TabIndex = 63
        Me.btn_delete.Text = "조정취소"
        '
        'grp1_cd
        '
        Me.grp1_cd.Location = New System.Drawing.Point(512, 28)
        Me.grp1_cd.Name = "grp1_cd"
        Me.grp1_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp1_cd.TabIndex = 41
        Me.grp1_cd.Title = "대분류"
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(512, 52)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 42
        Me.grp2_cd.Title = "중분류"
        '
        'out_no
        '
        Me.out_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_no.Location = New System.Drawing.Point(992, 55)
        Me.out_no.Name = "out_no"
        Me.out_no.Size = New System.Drawing.Size(240, 21)
        Me.out_no.TabIndex = 61
        Me.out_no.Title = "출고번호"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(260, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 49
        Me.itm_cd.Title = "품목코드%"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(12, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 32
        Me.fac_cd.Title = "관리공장"
        '
        'grp3_cd
        '
        Me.grp3_cd.Location = New System.Drawing.Point(512, 76)
        Me.grp3_cd.Name = "grp3_cd"
        Me.grp3_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp3_cd.TabIndex = 43
        Me.grp3_cd.Title = "소분류"
        '
        'std_month
        '
        Me.std_month.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_month.Format = "yyyy-MM"
        Me.std_month.Location = New System.Drawing.Point(12, 28)
        Me.std_month.Name = "std_month"
        Me.std_month.Size = New System.Drawing.Size(240, 21)
        Me.std_month.TabIndex = 33
        Me.std_month.Title = "기준월"
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(260, 28)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 40
        Me.itm_bc.Title = "품목구분"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1040, 407)
        Me.SplitContainer2.SplitterDistance = 241
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1040, 241)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     월별 재고 조정"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1036, 216)
        Me.g10.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1040, 162)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     생산품목별 출고내역"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1036, 137)
        Me.g20.TabIndex = 2
        '
        'LEJ400
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEJ400"
        Me.Size = New System.Drawing.Size(1085, 563)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents grp2_cd As Frame7.eCombo
    Friend WithEvents grp1_cd As Frame7.eCombo
    Friend WithEvents grp3_cd As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents std_month As Frame7.eDate
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents out_no As Frame7.eText
    Friend WithEvents out_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton

End Class
