<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB130
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
        Me.sl_gu = New Frame7.eCheckCombo()
        Me.div_cd = New Frame7.eCombo()
        Me.chk_all = New Frame7.eCheck()
        Me.cust_nm = New Frame7.eText()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_apply = New DevExpress.XtraEditors.SimpleButton()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.sl_type = New Frame7.eCheckCombo()
        Me.to_dt = New Frame7.eDate()
        Me.rf_no = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.doc_rid = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.doc_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.doc_id = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.pas = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 512)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.sl_gu)
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.pas)
        Me.EPanel1.Controls.Add(Me.chk_all)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.btn_cancel)
        Me.EPanel1.Controls.Add(Me.btn_apply)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.sl_type)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.rf_no)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.doc_rid)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.doc_nm)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.doc_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 127)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'sl_gu
        '
        Me.sl_gu.Location = New System.Drawing.Point(264, 28)
        Me.sl_gu.Name = "sl_gu"
        Me.sl_gu.Size = New System.Drawing.Size(240, 21)
        Me.sl_gu.TabIndex = 53
        Me.sl_gu.Title = "sl_gu"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 52
        Me.div_cd.Title = "div_cd"
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_all.Location = New System.Drawing.Point(510, 100)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(240, 21)
        Me.chk_all.TabIndex = 50
        Me.chk_all.Title = "chk_all"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(258, 100)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(128, 21)
        Me.cust_nm.TabIndex = 49
        Me.cust_nm.Title = "cust_nm"
        Me.cust_nm.TitleWidth = 0
        '
        'btn_cancel
        '
        Me.btn_cancel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Appearance.Options.UseForeColor = True
        Me.btn_cancel.Location = New System.Drawing.Point(898, 82)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(96, 24)
        Me.btn_cancel.TabIndex = 45
        Me.btn_cancel.Text = "취소"
        '
        'btn_apply
        '
        Me.btn_apply.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_apply.Appearance.Options.UseForeColor = True
        Me.btn_apply.Location = New System.Drawing.Point(898, 52)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(96, 24)
        Me.btn_apply.TabIndex = 45
        Me.btn_apply.Text = "전표 생성"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 28
        Me.co_cd.Title = "법인명"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 32
        Me.fr_dt.Title = "기간"
        '
        'sl_type
        '
        Me.sl_type.Location = New System.Drawing.Point(264, 52)
        Me.sl_type.Name = "sl_type"
        Me.sl_type.Size = New System.Drawing.Size(240, 21)
        Me.sl_type.TabIndex = 47
        Me.sl_type.Title = "sl_type"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(255, 76)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(131, 21)
        Me.to_dt.TabIndex = 33
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 11
        '
        'rf_no
        '
        Me.rf_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rf_no.Location = New System.Drawing.Point(510, 28)
        Me.rf_no.Name = "rf_no"
        Me.rf_no.Size = New System.Drawing.Size(240, 21)
        Me.rf_no.TabIndex = 42
        Me.rf_no.Title = "rf_no"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(12, 100)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 40
        Me.cust_cd.Title = "cust_cd"
        '
        'doc_rid
        '
        Me.doc_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_rid.Location = New System.Drawing.Point(927, 28)
        Me.doc_rid.Name = "doc_rid"
        Me.doc_rid.Size = New System.Drawing.Size(52, 21)
        Me.doc_rid.TabIndex = 38
        Me.doc_rid.Title = "doc_rid"
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(510, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 34
        Me.dept_cd.Title = "발의부서"
        '
        'doc_nm
        '
        Me.doc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_nm.Location = New System.Drawing.Point(754, 76)
        Me.doc_nm.Name = "doc_nm"
        Me.doc_nm.Size = New System.Drawing.Size(128, 21)
        Me.doc_nm.TabIndex = 39
        Me.doc_nm.TitleWidth = 0
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(754, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(128, 21)
        Me.dept_nm.TabIndex = 35
        Me.dept_nm.TitleWidth = 0
        '
        'doc_id
        '
        Me.doc_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_id.Location = New System.Drawing.Point(510, 76)
        Me.doc_id.Name = "doc_id"
        Me.doc_id.Size = New System.Drawing.Size(240, 21)
        Me.doc_id.TabIndex = 38
        Me.doc_id.Title = "발의자"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 381)
        Me.SplitContainer2.SplitterDistance = 189
        Me.SplitContainer2.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.g10)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1024, 189)
        Me.PanelControl1.TabIndex = 46
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 2)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 185)
        Me.g10.TabIndex = 2
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1024, 188)
        Me.g20.TabIndex = 2
        '
        'pas
        '
        Me.pas.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pas.Location = New System.Drawing.Point(667, 101)
        Me.pas.Name = "pas"
        Me.pas.Size = New System.Drawing.Size(352, 21)
        Me.pas.TabIndex = 54
        '
        'FAB130
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB130"
        Me.Size = New System.Drawing.Size(1035, 589)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents rf_no As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents doc_nm As Frame7.eText
    Friend WithEvents doc_rid As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents btn_apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents doc_id As Frame7.eText
    Friend WithEvents sl_type As Frame7.eCheckCombo
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents sl_gu As Frame7.eCheckCombo
    Friend WithEvents pas As Frame7.eText

End Class
