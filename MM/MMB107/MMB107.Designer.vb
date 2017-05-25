<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB107
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MMB107))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.but_tap_2 = New DevExpress.XtraEditors.SimpleButton()
        Me.but_print = New DevExpress.XtraEditors.SimpleButton()
        Me.but_tap_3 = New DevExpress.XtraEditors.SimpleButton()
        Me.req_dt = New Frame7.eDate()
        Me.but_tap = New DevExpress.XtraEditors.SimpleButton()
        Me.fac_cd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EText1 = New Frame7.eText()
        Me.wh_cd = New Frame7.eCombo()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.cust_nm = New Frame7.eText()
        Me.dlv_fr = New Frame7.eDate()
        Me.pgbDownload = New System.Windows.Forms.ProgressBar()
        Me.dlv_to = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.WebClient1 = New System.Net.WebClient()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 516)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.but_tap_2)
        Me.EPanel1.Controls.Add(Me.but_print)
        Me.EPanel1.Controls.Add(Me.but_tap_3)
        Me.EPanel1.Controls.Add(Me.req_dt)
        Me.EPanel1.Controls.Add(Me.but_tap)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Controls.Add(Me.wh_cd)
        Me.EPanel1.Controls.Add(Me.txtUrl)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.dlv_fr)
        Me.EPanel1.Controls.Add(Me.pgbDownload)
        Me.EPanel1.Controls.Add(Me.dlv_to)
        Me.EPanel1.Location = New System.Drawing.Point(26, 15)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1088, 88)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'but_tap_2
        '
        Me.but_tap_2.Location = New System.Drawing.Point(771, 77)
        Me.but_tap_2.Name = "but_tap_2"
        Me.but_tap_2.Size = New System.Drawing.Size(118, 21)
        Me.but_tap_2.TabIndex = 59
        Me.but_tap_2.Text = "식별표출력"
        '
        'but_print
        '
        Me.but_print.Location = New System.Drawing.Point(510, 77)
        Me.but_print.Name = "but_print"
        Me.but_print.Size = New System.Drawing.Size(120, 21)
        Me.but_print.TabIndex = 58
        Me.but_print.Text = "시험의뢰서출력"
        '
        'but_tap_3
        '
        Me.but_tap_3.Location = New System.Drawing.Point(895, 77)
        Me.but_tap_3.Name = "but_tap_3"
        Me.but_tap_3.Size = New System.Drawing.Size(118, 21)
        Me.but_tap_3.TabIndex = 59
        Me.but_tap_3.Text = "식별표출력(미니)"
        '
        'req_dt
        '
        Me.req_dt.Location = New System.Drawing.Point(264, 77)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 57
        Me.req_dt.Title = "의뢰일자"
        '
        'but_tap
        '
        Me.but_tap.Location = New System.Drawing.Point(636, 77)
        Me.but_tap.Name = "but_tap"
        Me.but_tap.Size = New System.Drawing.Size(129, 21)
        Me.but_tap.TabIndex = 56
        Me.but_tap.Text = "식별표출력(미리보기)"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(8, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 51
        Me.fac_cd.Title = "공장"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(264, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 35
        Me.cust_cd.Title = "거래처"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(634, 28)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 21)
        Me.SimpleButton1.TabIndex = 52
        Me.SimpleButton1.Text = "Excel출력하기"
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(8, 77)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(240, 21)
        Me.EText1.TabIndex = 55
        Me.EText1.Title = "가입고번호"
        '
        'wh_cd
        '
        Me.wh_cd.Location = New System.Drawing.Point(8, 52)
        Me.wh_cd.Name = "wh_cd"
        Me.wh_cd.Size = New System.Drawing.Size(240, 21)
        Me.wh_cd.TabIndex = 51
        Me.wh_cd.Title = "사업장"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(634, 112)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(250, 22)
        Me.txtUrl.TabIndex = 54
        Me.txtUrl.Visible = False
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(508, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(120, 21)
        Me.cust_nm.TabIndex = 38
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'dlv_fr
        '
        Me.dlv_fr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_fr.Location = New System.Drawing.Point(264, 28)
        Me.dlv_fr.Name = "dlv_fr"
        Me.dlv_fr.Size = New System.Drawing.Size(240, 21)
        Me.dlv_fr.TabIndex = 33
        Me.dlv_fr.Title = "가입고일자"
        '
        'pgbDownload
        '
        Me.pgbDownload.Location = New System.Drawing.Point(634, 52)
        Me.pgbDownload.Name = "pgbDownload"
        Me.pgbDownload.Size = New System.Drawing.Size(252, 23)
        Me.pgbDownload.TabIndex = 53
        '
        'dlv_to
        '
        Me.dlv_to.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dlv_to.Location = New System.Drawing.Point(508, 28)
        Me.dlv_to.Name = "dlv_to"
        Me.dlv_to.Size = New System.Drawing.Size(120, 21)
        Me.dlv_to.TabIndex = 36
        Me.dlv_to.Title = "부터"
        Me.dlv_to.TitleWidth = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 409)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     가입고 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 384)
        Me.g10.TabIndex = 2
        '
        'WebClient1
        '
        Me.WebClient1.BaseAddress = ""
        Me.WebClient1.CachePolicy = Nothing
        Me.WebClient1.Credentials = Nothing
        Me.WebClient1.Encoding = CType(resources.GetObject("WebClient1.Encoding"), System.Text.Encoding)
        Me.WebClient1.Headers = CType(resources.GetObject("WebClient1.Headers"), System.Net.WebHeaderCollection)
        Me.WebClient1.QueryString = CType(resources.GetObject("WebClient1.QueryString"), System.Collections.Specialized.NameValueCollection)
        Me.WebClient1.UseDefaultCredentials = False
        '
        'MMB107
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB107"
        Me.Size = New System.Drawing.Size(1037, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents dlv_fr As Frame7.eDate
    Friend WithEvents dlv_to As Frame7.eDate
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents WebClient1 As System.Net.WebClient
    Friend WithEvents pgbDownload As System.Windows.Forms.ProgressBar
    Friend WithEvents txtUrl As System.Windows.Forms.TextBox
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents wh_cd As Frame7.eCombo
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents but_tap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents but_tap_2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_tap_3 As DevExpress.XtraEditors.SimpleButton

End Class
