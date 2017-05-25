<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEA130
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.chk = New Frame7.eCheck()
        Me.in_no = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.ent_bc = New Frame7.eCombo()
        Me.itm_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.in_fac = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.dlv_no = New Frame7.eText()
        Me.in_dt = New Frame7.eDate()
        Me.in_wh = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.lot_no = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.bs_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1166, 516)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.lot_no)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.chk)
        Me.EPanel1.Controls.Add(Me.in_no)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.ent_bc)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dlv_no)
        Me.EPanel1.Controls.Add(Me.in_dt)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1166, 131)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(645, 77)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 21)
        Me.SimpleButton1.TabIndex = 95
        Me.SimpleButton1.Text = "입고내역 반품처리"
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk.Location = New System.Drawing.Point(527, 77)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(112, 21)
        Me.chk.TabIndex = 94
        Me.chk.Title = "입고내역 조회"
        Me.chk.TitleWidth = 90
        '
        'in_no
        '
        Me.in_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.in_no.Location = New System.Drawing.Point(15, 29)
        Me.in_no.Name = "in_no"
        Me.in_no.Size = New System.Drawing.Size(240, 21)
        Me.in_no.TabIndex = 90
        Me.in_no.Title = "반품번호"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(271, 29)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 82
        Me.cust_cd.Title = "입고업체"
        '
        'ent_bc
        '
        Me.ent_bc.Location = New System.Drawing.Point(806, 1)
        Me.ent_bc.Name = "ent_bc"
        Me.ent_bc.Size = New System.Drawing.Size(244, 21)
        Me.ent_bc.TabIndex = 93
        Me.ent_bc.Title = "ent_bc"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(271, 53)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 83
        Me.itm_cd.Title = "품목코드"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(515, 29)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 88
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(515, 53)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(252, 21)
        Me.itm_nm.TabIndex = 87
        Me.itm_nm.Title = "출고번호"
        Me.itm_nm.TitleWidth = 0
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(15, 53)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 86
        Me.fr_dt.Title = "입고일자"
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(806, 53)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 92
        Me.in_fac.Title = "반품공장"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(15, 77)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 84
        Me.to_dt.Title = "~"
        '
        'dlv_no
        '
        Me.dlv_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_no.Location = New System.Drawing.Point(271, 77)
        Me.dlv_no.Name = "dlv_no"
        Me.dlv_no.Size = New System.Drawing.Size(240, 21)
        Me.dlv_no.TabIndex = 89
        Me.dlv_no.Title = "가입고번호 검색"
        '
        'in_dt
        '
        Me.in_dt.Location = New System.Drawing.Point(806, 101)
        Me.in_dt.Name = "in_dt"
        Me.in_dt.Size = New System.Drawing.Size(240, 21)
        Me.in_dt.TabIndex = 85
        Me.in_dt.Title = "반품일자"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(806, 77)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 91
        Me.in_wh.Title = "반품창고"
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
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1166, 381)
        Me.SplitContainer2.SplitterDistance = 178
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1166, 178)
        Me.EPanel3.TabIndex = 9
        Me.EPanel3.Text = "     입고현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1162, 153)
        Me.g20.TabIndex = 2
        '
        'lot_no
        '
        Me.lot_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lot_no.Location = New System.Drawing.Point(15, 101)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(377, 21)
        Me.lot_no.TabIndex = 83
        Me.lot_no.Title = "Lot.No"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1166, 199)
        Me.EPanel2.TabIndex = 8
        Me.EPanel2.Text = "     반품등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1162, 174)
        Me.g10.TabIndex = 2
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(806, 29)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 97
        Me.bs_cd.Title = "사업장"
        '
        'LEA130
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEA130"
        Me.Size = New System.Drawing.Size(1210, 563)
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
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents in_no As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents ent_bc As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents dlv_no As Frame7.eText
    Friend WithEvents in_dt As Frame7.eDate
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents bs_cd As Frame7.eCombo

End Class
