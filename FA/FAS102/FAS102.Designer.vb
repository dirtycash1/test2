<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAS102
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
        Me.get_dtf = New Frame7.eDate()
        Me.ast_nm = New Frame7.eText()
        Me.btn_doc = New DevExpress.XtraEditors.SimpleButton()
        Me.get_dtt = New Frame7.eDate()
        Me.ast_no = New Frame7.eText()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1020, 360)
        Me.SplitContainer1.SplitterDistance = 82
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.get_dtf)
        Me.EPanel1.Controls.Add(Me.ast_nm)
        Me.EPanel1.Controls.Add(Me.get_dtt)
        Me.EPanel1.Controls.Add(Me.ast_no)
        Me.EPanel1.Controls.Add(Me.btn_doc)
        Me.EPanel1.Controls.Add(Me.btn_del)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1020, 82)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        Me.co_cd.Title = "co_cd"
        '
        'get_dtf
        '
        Me.get_dtf.Location = New System.Drawing.Point(264, 28)
        Me.get_dtf.Name = "get_dtf"
        Me.get_dtf.Size = New System.Drawing.Size(240, 21)
        Me.get_dtf.TabIndex = 11
        Me.get_dtf.Title = "get_dtf"
        '
        'ast_nm
        '
        Me.ast_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ast_nm.Location = New System.Drawing.Point(516, 52)
        Me.ast_nm.Name = "ast_nm"
        Me.ast_nm.Size = New System.Drawing.Size(240, 21)
        Me.ast_nm.TabIndex = 5
        Me.ast_nm.Title = "ast_nm"
        '
        'btn_doc
        '
        Me.btn_doc.Location = New System.Drawing.Point(772, 52)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(112, 24)
        Me.btn_doc.TabIndex = 12
        Me.btn_doc.Text = "전표처리"
        '
        'get_dtt
        '
        Me.get_dtt.Location = New System.Drawing.Point(384, 52)
        Me.get_dtt.Name = "get_dtt"
        Me.get_dtt.Size = New System.Drawing.Size(120, 21)
        Me.get_dtt.TabIndex = 11
        Me.get_dtt.TitleWidth = 0
        '
        'ast_no
        '
        Me.ast_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ast_no.Location = New System.Drawing.Point(516, 28)
        Me.ast_no.Name = "ast_no"
        Me.ast_no.Size = New System.Drawing.Size(240, 21)
        Me.ast_no.TabIndex = 5
        Me.ast_no.Title = "ast_no"
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(892, 52)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(100, 24)
        Me.btn_del.TabIndex = 12
        Me.btn_del.Text = "전표삭제"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 274)
        Me.g10.TabIndex = 3
        '
        'FAS102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAS102"
        Me.Size = New System.Drawing.Size(1034, 382)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents ast_no As Frame7.eText
    Friend WithEvents get_dtf As Frame7.eDate
    Friend WithEvents get_dtt As Frame7.eDate
    Friend WithEvents ast_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_doc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton

End Class
