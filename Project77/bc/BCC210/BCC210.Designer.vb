<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCC210
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.sal_yn = New Frame7.eCheck()
        Me.cust_kd = New Frame7.eCombo()
        Me.pur_yn = New Frame7.eCheck()
        Me.cust_nm = New Frame7.eText()
        Me.use_yn = New Frame7.eCheck()
        Me.biz_no = New Frame7.eText()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.XtraTabControl1)
        Me.EPanel1.IconVisible = False
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.ShowCaption = False
        Me.EPanel1.Size = New System.Drawing.Size(892, 388)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "EPanel1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(888, 384)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.EPanel3)
        Me.XtraTabPage1.Controls.Add(Me.EPanel2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(881, 354)
        Me.XtraTabPage1.Text = "거래처"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.IconVisible = False
        Me.EPanel3.Location = New System.Drawing.Point(0, 88)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.ShowCaption = False
        Me.EPanel3.Size = New System.Drawing.Size(881, 266)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "EPanel3"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 2)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(877, 262)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.co_cd)
        Me.EPanel2.Controls.Add(Me.cust_cd)
        Me.EPanel2.Controls.Add(Me.sal_yn)
        Me.EPanel2.Controls.Add(Me.cust_kd)
        Me.EPanel2.Controls.Add(Me.pur_yn)
        Me.EPanel2.Controls.Add(Me.cust_nm)
        Me.EPanel2.Controls.Add(Me.use_yn)
        Me.EPanel2.Controls.Add(Me.biz_no)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel2.IconVisible = False
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.ShowCaption = False
        Me.EPanel2.Size = New System.Drawing.Size(881, 88)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "EPanel2"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 8)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 2
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(8, 32)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 3
        '
        'sal_yn
        '
        Me.sal_yn.Caption = ""
        Me.sal_yn.Location = New System.Drawing.Point(528, 32)
        Me.sal_yn.Name = "sal_yn"
        Me.sal_yn.Size = New System.Drawing.Size(136, 21)
        Me.sal_yn.TabIndex = 4
        '
        'cust_kd
        '
        Me.cust_kd.Location = New System.Drawing.Point(268, 32)
        Me.cust_kd.Name = "cust_kd"
        Me.cust_kd.Size = New System.Drawing.Size(240, 21)
        Me.cust_kd.TabIndex = 2
        '
        'pur_yn
        '
        Me.pur_yn.Caption = ""
        Me.pur_yn.Location = New System.Drawing.Point(528, 56)
        Me.pur_yn.Name = "pur_yn"
        Me.pur_yn.Size = New System.Drawing.Size(136, 21)
        Me.pur_yn.TabIndex = 4
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(8, 56)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 3
        '
        'use_yn
        '
        Me.use_yn.Caption = ""
        Me.use_yn.Location = New System.Drawing.Point(683, 56)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(136, 21)
        Me.use_yn.TabIndex = 4
        '
        'biz_no
        '
        Me.biz_no.Location = New System.Drawing.Point(268, 56)
        Me.biz_no.Name = "biz_no"
        Me.biz_no.Size = New System.Drawing.Size(240, 21)
        Me.biz_no.TabIndex = 3
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.EPanel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(881, 354)
        Me.XtraTabPage2.Text = " 본사 "
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.IconVisible = False
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.ShowCaption = False
        Me.EPanel4.Size = New System.Drawing.Size(881, 354)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "EPanel4"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 2)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(877, 350)
        Me.g20.TabIndex = 2
        '
        'BCC210
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "BCC210"
        Me.Size = New System.Drawing.Size(919, 411)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents sal_yn As Frame7.eCheck
    Friend WithEvents cust_kd As Frame7.eCombo
    Friend WithEvents pur_yn As Frame7.eCheck
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents use_yn As Frame7.eCheck
    Friend WithEvents biz_no As Frame7.eText
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid

End Class
