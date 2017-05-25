<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LEA505
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
        Me.f_set_dtf = New Frame7.eDate()
        Me.f_fac_cd = New Frame7.eCombo()
        Me.f_cust_cd = New Frame7.eText()
        Me.f_itm_cd = New Frame7.eText()
        Me.f_doc_no = New Frame7.eText()
        Me.f_cust_nm = New Frame7.eText()
        Me.f_set_dtt = New Frame7.eDate()
        Me.f_itm_nm = New Frame7.eText()
        Me.f_model_cd = New Frame7.eCombo()
        Me.f_spec1 = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.f_itm_bc = New Frame7.eCheckCombo()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 556)
        Me.SplitContainer1.SplitterDistance = 99
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_set_dtf)
        Me.EPanel1.Controls.Add(Me.f_fac_cd)
        Me.EPanel1.Controls.Add(Me.f_cust_cd)
        Me.EPanel1.Controls.Add(Me.f_itm_cd)
        Me.EPanel1.Controls.Add(Me.f_itm_bc)
        Me.EPanel1.Controls.Add(Me.f_doc_no)
        Me.EPanel1.Controls.Add(Me.f_cust_nm)
        Me.EPanel1.Controls.Add(Me.f_set_dtt)
        Me.EPanel1.Controls.Add(Me.f_itm_nm)
        Me.EPanel1.Controls.Add(Me.f_model_cd)
        Me.EPanel1.Controls.Add(Me.f_spec1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(936, 99)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'f_set_dtf
        '
        Me.f_set_dtf.Format = "yyyy-MM-dd"
        Me.f_set_dtf.Location = New System.Drawing.Point(8, 24)
        Me.f_set_dtf.Name = "f_set_dtf"
        Me.f_set_dtf.Size = New System.Drawing.Size(240, 21)
        Me.f_set_dtf.TabIndex = 12
        Me.f_set_dtf.Title = "전표발행일(fr)"
        '
        'f_fac_cd
        '
        Me.f_fac_cd.Location = New System.Drawing.Point(8, 72)
        Me.f_fac_cd.Name = "f_fac_cd"
        Me.f_fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_fac_cd.TabIndex = 3
        Me.f_fac_cd.Title = "공장구분"
        '
        'f_cust_cd
        '
        Me.f_cust_cd.Location = New System.Drawing.Point(252, 24)
        Me.f_cust_cd.Name = "f_cust_cd"
        Me.f_cust_cd.Size = New System.Drawing.Size(220, 21)
        Me.f_cust_cd.TabIndex = 13
        Me.f_cust_cd.Title = "매입처"
        Me.f_cust_cd.TitleWidth = 100
        '
        'f_itm_cd
        '
        Me.f_itm_cd.Location = New System.Drawing.Point(480, 48)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(220, 21)
        Me.f_itm_cd.TabIndex = 13
        Me.f_itm_cd.Title = "품목코드(%)"
        Me.f_itm_cd.TitleWidth = 100
        '
        'f_doc_no
        '
        Me.f_doc_no.Location = New System.Drawing.Point(252, 72)
        Me.f_doc_no.Name = "f_doc_no"
        Me.f_doc_no.Size = New System.Drawing.Size(220, 21)
        Me.f_doc_no.TabIndex = 13
        Me.f_doc_no.Title = "전표번호"
        Me.f_doc_no.TitleWidth = 100
        '
        'f_cust_nm
        '
        Me.f_cust_nm.Location = New System.Drawing.Point(252, 48)
        Me.f_cust_nm.Name = "f_cust_nm"
        Me.f_cust_nm.Size = New System.Drawing.Size(220, 21)
        Me.f_cust_nm.TabIndex = 13
        Me.f_cust_nm.Title = "거래처명"
        Me.f_cust_nm.TitleWidth = 0
        '
        'f_set_dtt
        '
        Me.f_set_dtt.Format = "yyyy-MM-dd"
        Me.f_set_dtt.Location = New System.Drawing.Point(8, 48)
        Me.f_set_dtt.Name = "f_set_dtt"
        Me.f_set_dtt.Size = New System.Drawing.Size(240, 21)
        Me.f_set_dtt.TabIndex = 12
        Me.f_set_dtt.Title = "전표발행일(to)"
        '
        'f_itm_nm
        '
        Me.f_itm_nm.Location = New System.Drawing.Point(480, 72)
        Me.f_itm_nm.Name = "f_itm_nm"
        Me.f_itm_nm.Size = New System.Drawing.Size(220, 21)
        Me.f_itm_nm.TabIndex = 13
        Me.f_itm_nm.Title = "품목명"
        Me.f_itm_nm.TitleWidth = 100
        '
        'f_model_cd
        '
        Me.f_model_cd.Location = New System.Drawing.Point(708, 24)
        Me.f_model_cd.Name = "f_model_cd"
        Me.f_model_cd.Size = New System.Drawing.Size(220, 21)
        Me.f_model_cd.TabIndex = 3
        Me.f_model_cd.Title = "차종"
        Me.f_model_cd.TitleWidth = 100
        '
        'f_spec1
        '
        Me.f_spec1.Location = New System.Drawing.Point(708, 48)
        Me.f_spec1.Name = "f_spec1"
        Me.f_spec1.Size = New System.Drawing.Size(220, 21)
        Me.f_spec1.TabIndex = 3
        Me.f_spec1.Title = "칼라"
        Me.f_spec1.TitleWidth = 100
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 453)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     매입품목현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 428)
        Me.g10.TabIndex = 2
        '
        'f_itm_bc
        '
        Me.f_itm_bc.Location = New System.Drawing.Point(480, 21)
        Me.f_itm_bc.Name = "f_itm_bc"
        Me.f_itm_bc.Size = New System.Drawing.Size(220, 21)
        Me.f_itm_bc.TabIndex = 14
        Me.f_itm_bc.Title = "품목구분"
        Me.f_itm_bc.TitleWidth = 100
        '
        'LEA505
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "LEA505"
        Me.Size = New System.Drawing.Size(944, 581)
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
    Friend WithEvents f_set_dtf As Frame7.eDate
    Friend WithEvents f_fac_cd As Frame7.eCombo
    Friend WithEvents f_cust_nm As Frame7.eText
    Friend WithEvents f_set_dtt As Frame7.eDate
    Friend WithEvents f_cust_cd As Frame7.eText
    Friend WithEvents f_itm_cd As Frame7.eText
    Friend WithEvents f_doc_no As Frame7.eText
    Friend WithEvents f_itm_nm As Frame7.eText
    Friend WithEvents f_model_cd As Frame7.eCombo
    Friend WithEvents f_spec1 As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f_itm_bc As Frame7.eCheckCombo

End Class
