<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC250
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
        Me.bs_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.tax_kd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.XtraTabPage = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.g30 = New Frame7.eGrid()
        Me.g40 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.XtraTabPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(812, 496)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.tax_kd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(812, 79)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 46
        Me.bs_cd.Title = "신고사업장"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(272, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "발행일"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(380, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(132, 21)
        Me.to_dt.TabIndex = 48
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'tax_kd
        '
        Me.tax_kd.Location = New System.Drawing.Point(528, 28)
        Me.tax_kd.Name = "tax_kd"
        Me.tax_kd.Size = New System.Drawing.Size(240, 21)
        Me.tax_kd.TabIndex = 51
        Me.tax_kd.Title = "계산서구분"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.XtraTabPage)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(812, 413)
        Me.SplitContainer2.SplitterDistance = 254
        Me.SplitContainer2.TabIndex = 0
        '
        'XtraTabPage
        '
        Me.XtraTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabPage.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabPage.Name = "XtraTabPage"
        Me.XtraTabPage.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabPage.Size = New System.Drawing.Size(812, 413)
        Me.XtraTabPage.TabIndex = 3
        Me.XtraTabPage.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(805, 383)
        Me.XtraTabPage1.Text = "계산서 단위"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer3.Size = New System.Drawing.Size(805, 383)
        Me.SplitContainer3.SplitterDistance = 270
        Me.SplitContainer3.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(805, 270)
        Me.g10.TabIndex = 3
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(805, 109)
        Me.g20.TabIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(805, 383)
        Me.XtraTabPage2.Text = "거래처 단위"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.g30)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.g40)
        Me.SplitContainer4.Size = New System.Drawing.Size(805, 383)
        Me.SplitContainer4.SplitterDistance = 203
        Me.SplitContainer4.TabIndex = 0
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(805, 203)
        Me.g30.TabIndex = 3
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(805, 176)
        Me.g40.TabIndex = 3
        '
        'FAC250
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAC250"
        Me.Size = New System.Drawing.Size(837, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.XtraTabPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents tax_kd As Frame7.eCombo
    Friend WithEvents XtraTabPage As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g40 As Frame7.eGrid

End Class
