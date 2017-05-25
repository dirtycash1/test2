<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY900
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
        Me.diff = New Frame7.eText()
        Me.std_mont = New Frame7.eDate()
        Me.co_cd = New Frame7.eCombo()
        Me.std_monf = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.div_cd = New Frame7.eCombo()
        Me.title = New Frame7.eText()
        Me.use_yn = New Frame7.eCheck()
        Me.std_mon = New Frame7.eDate()
        Me.doc_no = New Frame7.eText()
        Me.EPanel4 = New Frame7.ePanel()
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
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 606)
        Me.SplitContainer1.SplitterDistance = 73
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.diff)
        Me.EPanel1.Controls.Add(Me.std_mont)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.std_monf)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 73)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'diff
        '
        Me.diff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.diff.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.diff.Location = New System.Drawing.Point(592, 36)
        Me.diff.Name = "diff"
        Me.diff.Size = New System.Drawing.Size(152, 21)
        Me.diff.TabIndex = 5
        Me.diff.Title = "차이"
        Me.diff.TitleWidth = 60
        Me.diff.Visible = False
        '
        'std_mont
        '
        Me.std_mont.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_mont.Format = "yyyy-MM"
        Me.std_mont.Location = New System.Drawing.Point(264, 48)
        Me.std_mont.Name = "std_mont"
        Me.std_mont.Size = New System.Drawing.Size(240, 21)
        Me.std_mont.TabIndex = 4
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(4, 24)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        '
        'std_monf
        '
        Me.std_monf.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_monf.Format = "yyyy-MM"
        Me.std_monf.Location = New System.Drawing.Point(264, 24)
        Me.std_monf.Name = "std_monf"
        Me.std_monf.Size = New System.Drawing.Size(240, 21)
        Me.std_monf.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 529)
        Me.SplitContainer2.SplitterDistance = 385
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(385, 529)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     결산전표현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(381, 504)
        Me.g10.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(635, 529)
        Me.SplitContainer3.SplitterDistance = 97
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.div_cd)
        Me.EPanel3.Controls.Add(Me.title)
        Me.EPanel3.Controls.Add(Me.use_yn)
        Me.EPanel3.Controls.Add(Me.std_mon)
        Me.EPanel3.Controls.Add(Me.doc_no)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(635, 97)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     결산전표등록"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(264, 24)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 7
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.title.Location = New System.Drawing.Point(4, 72)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(500, 21)
        Me.title.TabIndex = 6
        '
        'use_yn
        '
        Me.use_yn.Caption = ""
        Me.use_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.use_yn.Location = New System.Drawing.Point(264, 48)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(240, 21)
        Me.use_yn.TabIndex = 5
        '
        'std_mon
        '
        Me.std_mon.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.std_mon.Format = "yyyy-MM"
        Me.std_mon.Location = New System.Drawing.Point(4, 48)
        Me.std_mon.Name = "std_mon"
        Me.std_mon.Size = New System.Drawing.Size(240, 21)
        Me.std_mon.TabIndex = 4
        '
        'doc_no
        '
        Me.doc_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.doc_no.Location = New System.Drawing.Point(4, 24)
        Me.doc_no.Name = "doc_no"
        Me.doc_no.Size = New System.Drawing.Size(240, 21)
        Me.doc_no.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(635, 428)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     세부사항"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(631, 403)
        Me.g20.TabIndex = 3
        '
        'FAY900
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY900"
        Me.Size = New System.Drawing.Size(1024, 606)
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents std_mont As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents std_monf As Frame7.eDate
    Friend WithEvents title As Frame7.eText
    Friend WithEvents use_yn As Frame7.eCheck
    Friend WithEvents std_mon As Frame7.eDate
    Friend WithEvents doc_no As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents diff As Frame7.eText

End Class
