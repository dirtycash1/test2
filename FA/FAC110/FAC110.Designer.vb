<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC110
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EPanel1 = New Frame7.ePanel
        Me.bs_cd = New Frame7.eCombo
        Me.co_cd = New Frame7.eCombo
        Me.to_dt = New Frame7.eDate
        Me.fr_dt = New Frame7.eDate
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.tax_kd = New Frame7.eCombo
        Me.tax_bc = New Frame7.eCombo
        Me.cust_nm = New Frame7.eText
        Me.cust_cd = New Frame7.eText
        Me.chk_done = New Frame7.eCheck
        Me.XtraTabPage = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.g10 = New Frame7.eGrid
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.g20 = New Frame7.eGrid
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(837, 519)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chk_done)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.tax_bc)
        Me.EPanel1.Controls.Add(Me.tax_kd)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(837, 129)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 46
        Me.bs_cd.Title = "사업장"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(120, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(132, 21)
        Me.to_dt.TabIndex = 48
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "발행일"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(837, 386)
        Me.SplitContainer2.SplitterDistance = 254
        Me.SplitContainer2.TabIndex = 0
        '
        'tax_kd
        '
        Me.tax_kd.Location = New System.Drawing.Point(272, 28)
        Me.tax_kd.Name = "tax_kd"
        Me.tax_kd.Size = New System.Drawing.Size(240, 21)
        Me.tax_kd.TabIndex = 51
        Me.tax_kd.Title = "계산서구분"
        '
        'tax_bc
        '
        Me.tax_bc.Location = New System.Drawing.Point(272, 52)
        Me.tax_bc.Name = "tax_bc"
        Me.tax_bc.Size = New System.Drawing.Size(240, 21)
        Me.tax_bc.TabIndex = 54
        Me.tax_bc.Title = "과세구분"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(516, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(176, 21)
        Me.cust_nm.TabIndex = 58
        Me.cust_nm.Title = "거래처"
        Me.cust_nm.TitleWidth = 0
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(272, 76)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 57
        Me.cust_cd.Title = "거래처"
        '
        'chk_done
        '
        Me.chk_done.Caption = ""
        Me.chk_done.Location = New System.Drawing.Point(272, 100)
        Me.chk_done.Name = "chk_done"
        Me.chk_done.Size = New System.Drawing.Size(240, 21)
        Me.chk_done.TabIndex = 59
        Me.chk_done.Title = "전표승인 된것 만"
        '
        'XtraTabPage
        '
        Me.XtraTabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabPage.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabPage.Name = "XtraTabPage"
        Me.XtraTabPage.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabPage.Size = New System.Drawing.Size(837, 386)
        Me.XtraTabPage.TabIndex = 3
        Me.XtraTabPage.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(830, 356)
        Me.XtraTabPage1.Text = "세금계산서 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(830, 356)
        Me.g10.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g20)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(830, 356)
        Me.XtraTabPage2.Text = "과세구분별 현황"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(830, 356)
        Me.g20.TabIndex = 1
        '
        'FAC110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAC110"
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
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents tax_kd As Frame7.eCombo
    Friend WithEvents tax_bc As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents chk_done As Frame7.eCheck
    Friend WithEvents XtraTabPage As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g20 As Frame7.eGrid

End Class
