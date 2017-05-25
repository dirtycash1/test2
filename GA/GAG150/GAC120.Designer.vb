<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAC120
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
        Me.emp_no = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.to_dt = New Frame7.eDate()
        Me.EPanel1 = New Frame7.ePanel()
        Me.fr_dt = New Frame7.eDate()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.but1 = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.but = New DevExpress.XtraEditors.RadioGroup()
        Me.doc_bc = New Frame7.eCombo()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.btn_print_en = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.but.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'emp_no
        '
        Me.emp_no.Location = New System.Drawing.Point(268, 28)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(240, 21)
        Me.emp_no.TabIndex = 7
        Me.emp_no.Title = "사원코드(%)"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 525)
        Me.g10.TabIndex = 2
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(12, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 6
        Me.to_dt.Title = ""
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_print_en)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.btn_print)
        Me.EPanel1.Controls.Add(Me.but1)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.but)
        Me.EPanel1.Controls.Add(Me.doc_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 82)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 4
        Me.fr_dt.Title = "신청일자"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(780, 28)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(112, 48)
        Me.btn_print.TabIndex = 13
        Me.btn_print.Text = "제증명출력(국문)"
        '
        'but1
        '
        Me.but1.Location = New System.Drawing.Point(640, 124)
        Me.but1.Name = "but1"
        Me.but1.Size = New System.Drawing.Size(80, 21)
        Me.but1.TabIndex = 12
        Me.but1.Visible = False
        '
        'emp_nm
        '
        Me.emp_nm.Location = New System.Drawing.Point(268, 52)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 9
        Me.emp_nm.Title = "사원명(%)"
        '
        'but
        '
        Me.but.EditValue = "%"
        Me.but.Location = New System.Drawing.Point(524, 52)
        Me.but.Name = "but"
        Me.but.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("%", "전체"), New DevExpress.XtraEditors.Controls.RadioGroupItem("0", "미출력"), New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "출력")})
        Me.but.Size = New System.Drawing.Size(240, 24)
        Me.but.TabIndex = 11
        '
        'doc_bc
        '
        Me.doc_bc.Location = New System.Drawing.Point(524, 28)
        Me.doc_bc.Name = "doc_bc"
        Me.doc_bc.Size = New System.Drawing.Size(240, 21)
        Me.doc_bc.TabIndex = 10
        Me.doc_bc.Title = "문서구분"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 82
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 550)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     상세정보등록"
        '
        'btn_print_en
        '
        Me.btn_print_en.Location = New System.Drawing.Point(908, 28)
        Me.btn_print_en.Name = "btn_print_en"
        Me.btn_print_en.Size = New System.Drawing.Size(112, 48)
        Me.btn_print_en.TabIndex = 14
        Me.btn_print_en.Text = "제증명출력(영문)"
        '
        'GAC120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "GAC120"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.but.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents doc_bc As Frame7.eCombo
    Friend WithEvents but As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents but1 As Frame7.eText
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print_en As DevExpress.XtraEditors.SimpleButton

End Class
