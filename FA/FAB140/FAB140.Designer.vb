<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB140
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
        Me.div_cd = New Frame7.eCheckCombo()
        Me.stat_bc = New Frame7.eCheckCombo()
        Me.doc_bc = New Frame7.eCheckCombo()
        Me.to_dt = New Frame7.eDate()
        Me.dsc = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.doc_no = New Frame7.eText()
        Me.doc_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.doc_id = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.doc_rid = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.chk_all = New DevExpress.XtraEditors.CheckEdit()
        Me.g10 = New Frame7.eGrid()
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
        CType(Me.chk_all.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 512)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.stat_bc)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dsc)
        Me.EPanel1.Controls.Add(Me.doc_bc)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.doc_no)
        Me.EPanel1.Controls.Add(Me.doc_nm)
        Me.EPanel1.Controls.Add(Me.doc_rid)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.doc_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 127)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 48
        Me.div_cd.Title = "div_cd"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(652, 52)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 48
        Me.stat_bc.Title = "stat_bc"
        '
        'doc_bc
        '
        Me.doc_bc.Location = New System.Drawing.Point(652, 76)
        Me.doc_bc.Name = "doc_bc"
        Me.doc_bc.Size = New System.Drawing.Size(240, 21)
        Me.doc_bc.TabIndex = 47
        Me.doc_bc.Title = "doc_bc"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Location = New System.Drawing.Point(132, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 33
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 0
        '
        'dsc
        '
        Me.dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dsc.Location = New System.Drawing.Point(264, 76)
        Me.dsc.Name = "dsc"
        Me.dsc.Size = New System.Drawing.Size(372, 21)
        Me.dsc.TabIndex = 40
        Me.dsc.Title = "적요 (%)"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 32
        Me.fr_dt.Title = "발의일자"
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(652, 28)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 42
        Me.doc_no.Title = "전표번호"
        '
        'doc_nm
        '
        Me.doc_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_nm.Location = New System.Drawing.Point(508, 52)
        Me.doc_nm.Name = "doc_nm"
        Me.doc_nm.Size = New System.Drawing.Size(128, 21)
        Me.doc_nm.TabIndex = 39
        Me.doc_nm.TitleWidth = 0
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(508, 28)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(128, 21)
        Me.dept_nm.TabIndex = 35
        Me.dept_nm.TitleWidth = 0
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(264, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 34
        Me.dept_cd.Title = "발의부서"
        '
        'doc_id
        '
        Me.doc_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_id.Location = New System.Drawing.Point(264, 52)
        Me.doc_id.Name = "doc_id"
        Me.doc_id.Size = New System.Drawing.Size(240, 21)
        Me.doc_id.TabIndex = 38
        Me.doc_id.Title = "발의자"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 28
        Me.co_cd.Title = "법인명"
        '
        'doc_rid
        '
        Me.doc_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_rid.Location = New System.Drawing.Point(956, 48)
        Me.doc_rid.Name = "doc_rid"
        Me.doc_rid.Size = New System.Drawing.Size(52, 21)
        Me.doc_rid.TabIndex = 38
        Me.doc_rid.Title = "doc_rid"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer2.Size = New System.Drawing.Size(1020, 381)
        Me.SplitContainer2.SplitterDistance = 237
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.chk_all)
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1020, 237)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     "
        '
        'chk_all
        '
        Me.chk_all.Location = New System.Drawing.Point(36, 3)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Properties.Caption = "CheckEdit1"
        Me.chk_all.Size = New System.Drawing.Size(16, 19)
        Me.chk_all.TabIndex = 4
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1016, 212)
        Me.g10.TabIndex = 2
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1020, 140)
        Me.g20.TabIndex = 2
        '
        'FAB140
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB140"
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
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.chk_all.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents dsc As Frame7.eText
    Friend WithEvents doc_nm As Frame7.eText
    Friend WithEvents doc_rid As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents chk_all As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents doc_id As Frame7.eText
    Friend WithEvents doc_bc As Frame7.eCheckCombo
    Friend WithEvents div_cd As Frame7.eCheckCombo
    Friend WithEvents stat_bc As Frame7.eCheckCombo

End Class
