<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDA102
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
        Me.itm_cd = New Frame7.eText()
        Me.co_cd = New Frame7.eCombo()
        Me.itm_nm = New Frame7.eText()
        Me.md_no = New Frame7.eText()
        Me.wc_cd = New Frame7.eCombo()
        Me.model_cd = New Frame7.eCombo()
        Me.md_nm = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.md_bc = New Frame7.eCombo()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 645)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Controls.Add(Me.md_no)
        Me.EPanel1.Controls.Add(Me.wc_cd)
        Me.EPanel1.Controls.Add(Me.model_cd)
        Me.EPanel1.Controls.Add(Me.md_nm)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.md_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1234, 106)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'itm_cd
        '
        Me.itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_cd.Location = New System.Drawing.Point(512, 52)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 29
        Me.itm_cd.Title = "대표생산품"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 0
        Me.co_cd.Title = "법인"
        '
        'itm_nm
        '
        Me.itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.itm_nm.Location = New System.Drawing.Point(512, 76)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 30
        Me.itm_nm.Title = "생산품명"
        '
        'md_no
        '
        Me.md_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.md_no.Location = New System.Drawing.Point(260, 28)
        Me.md_no.Name = "md_no"
        Me.md_no.Size = New System.Drawing.Size(240, 21)
        Me.md_no.TabIndex = 3
        Me.md_no.Title = "관리번호"
        '
        'wc_cd
        '
        Me.wc_cd.Location = New System.Drawing.Point(8, 76)
        Me.wc_cd.Name = "wc_cd"
        Me.wc_cd.Size = New System.Drawing.Size(240, 21)
        Me.wc_cd.TabIndex = 7
        Me.wc_cd.Title = "사용라인"
        '
        'model_cd
        '
        Me.model_cd.Location = New System.Drawing.Point(512, 28)
        Me.model_cd.Name = "model_cd"
        Me.model_cd.Size = New System.Drawing.Size(240, 21)
        Me.model_cd.TabIndex = 31
        Me.model_cd.Title = "차종"
        '
        'md_nm
        '
        Me.md_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.md_nm.Location = New System.Drawing.Point(260, 52)
        Me.md_nm.Name = "md_nm"
        Me.md_nm.Size = New System.Drawing.Size(240, 21)
        Me.md_nm.TabIndex = 2
        Me.md_nm.Title = "치형구명(%)"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 1
        Me.fac_cd.Title = "공장"
        '
        'md_bc
        '
        Me.md_bc.Location = New System.Drawing.Point(260, 76)
        Me.md_bc.Name = "md_bc"
        Me.md_bc.Size = New System.Drawing.Size(240, 21)
        Me.md_bc.TabIndex = 21
        Me.md_bc.Title = "형구분"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1234, 535)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1227, 505)
        Me.XtraTabPage1.Text = "제품기준"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g20)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1227, 505)
        Me.XtraTabPage2.Text = "생산품기준"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1227, 505)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1227, 505)
        Me.g20.TabIndex = 4
        '
        'MDA102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MDA102"
        Me.Size = New System.Drawing.Size(1234, 645)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents md_no As Frame7.eText
    Friend WithEvents wc_cd As Frame7.eCombo
    Friend WithEvents model_cd As Frame7.eCombo
    Friend WithEvents md_nm As Frame7.eText
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents md_bc As Frame7.eCombo
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid

End Class
