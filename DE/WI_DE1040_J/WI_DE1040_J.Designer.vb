<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_DE1040_J
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
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.code_no = New Frame7.eText()
        Me.gd_cd = New Frame7.eText()
        Me.button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.code_nm = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.base_dt = New Frame7.eDate()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel7 = New Frame7.ePanel()
        Me.etc_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.etc = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.bs_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.EPanel5 = New Frame7.ePanel()
        Me.ip_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.g40 = New Frame7.eGrid()
        Me.EPanel6 = New Frame7.ePanel()
        Me.j_btn = New DevExpress.XtraEditors.SimpleButton()
        Me.g50 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel7.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.Button2)
        Me.EPanel1.Controls.Add(Me.code_no)
        Me.EPanel1.Controls.Add(Me.gd_cd)
        Me.EPanel1.Controls.Add(Me.button1)
        Me.EPanel1.Controls.Add(Me.code_nm)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.base_dt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 80)
        Me.EPanel1.TabIndex = 10
        Me.EPanel1.Text = "     허가용 재고 관리"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1063, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 27)
        Me.Button2.TabIndex = 124
        Me.Button2.Text = "출력 닫기"
        '
        'code_no
        '
        Me.code_no.Location = New System.Drawing.Point(23, 42)
        Me.code_no.Name = "code_no"
        Me.code_no.Size = New System.Drawing.Size(170, 21)
        Me.code_no.TabIndex = 117
        Me.code_no.Title = "허가용 코드번호"
        Me.code_no.TitleWidth = 110
        '
        'gd_cd
        '
        Me.gd_cd.Location = New System.Drawing.Point(653, 42)
        Me.gd_cd.Name = "gd_cd"
        Me.gd_cd.Size = New System.Drawing.Size(180, 21)
        Me.gd_cd.TabIndex = 121
        Me.gd_cd.Title = "약품코드"
        Me.gd_cd.TitleWidth = 90
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(990, 36)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(67, 27)
        Me.button1.TabIndex = 123
        Me.button1.Text = "출력"
        '
        'code_nm
        '
        Me.code_nm.Location = New System.Drawing.Point(199, 42)
        Me.code_nm.Name = "code_nm"
        Me.code_nm.Size = New System.Drawing.Size(98, 21)
        Me.code_nm.TabIndex = 118
        Me.code_nm.Title = "허가용코드명"
        Me.code_nm.TitleWidth = 0
        '
        'gd_nm
        '
        Me.gd_nm.Location = New System.Drawing.Point(839, 42)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(125, 21)
        Me.gd_nm.TabIndex = 122
        Me.gd_nm.Title = "itm_nm"
        Me.gd_nm.TitleWidth = 0
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(498, 42)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(122, 21)
        Me.to_dt.TabIndex = 120
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 15
        '
        'base_dt
        '
        Me.base_dt.Location = New System.Drawing.Point(323, 42)
        Me.base_dt.Name = "base_dt"
        Me.base_dt.Size = New System.Drawing.Size(169, 21)
        Me.base_dt.TabIndex = 119
        Me.base_dt.Title = "기준 일자"
        Me.base_dt.TitleWidth = 60
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 527)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1182, 527)
        Me.Panel2.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 527)
        Me.SplitContainer2.SplitterDistance = 539
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(539, 527)
        Me.SplitContainer3.SplitterDistance = 220
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(539, 220)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     출고"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(535, 195)
        Me.g10.TabIndex = 2
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel7)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer5.Size = New System.Drawing.Size(539, 303)
        Me.SplitContainer5.SplitterDistance = 158
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel7
        '
        Me.EPanel7.Controls.Add(Me.etc_btn)
        Me.EPanel7.Controls.Add(Me.etc)
        Me.EPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel7.Location = New System.Drawing.Point(0, 0)
        Me.EPanel7.Name = "EPanel7"
        Me.EPanel7.Size = New System.Drawing.Size(539, 158)
        Me.EPanel7.TabIndex = 2
        Me.EPanel7.Text = "     기타출고"
        '
        'etc_btn
        '
        Me.etc_btn.Location = New System.Drawing.Point(100, 0)
        Me.etc_btn.Name = "etc_btn"
        Me.etc_btn.Size = New System.Drawing.Size(108, 21)
        Me.etc_btn.TabIndex = 72
        Me.etc_btn.Text = "기타 출고 저장"
        '
        'etc
        '
        Me.etc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.etc.Location = New System.Drawing.Point(2, 23)
        Me.etc.Name = "etc"
        Me.etc.ReadOnly = False
        Me.etc.RowHeight = -1
        Me.etc.Size = New System.Drawing.Size(535, 133)
        Me.etc.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.bs_btn)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(539, 141)
        Me.EPanel3.TabIndex = 3
        Me.EPanel3.Text = "     기초(허가용)"
        '
        'bs_btn
        '
        Me.bs_btn.Location = New System.Drawing.Point(129, 2)
        Me.bs_btn.Name = "bs_btn"
        Me.bs_btn.Size = New System.Drawing.Size(79, 21)
        Me.bs_btn.TabIndex = 71
        Me.bs_btn.Text = " 기초 저장"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(535, 116)
        Me.g20.TabIndex = 3
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer4.Size = New System.Drawing.Size(639, 527)
        Me.SplitContainer4.SplitterDistance = 183
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g30)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(639, 183)
        Me.EPanel4.TabIndex = 4
        Me.EPanel4.Text = "     가입고 데이터"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(635, 158)
        Me.g30.TabIndex = 4
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.EPanel5)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.EPanel6)
        Me.SplitContainer6.Size = New System.Drawing.Size(639, 340)
        Me.SplitContainer6.SplitterDistance = 147
        Me.SplitContainer6.TabIndex = 0
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.ip_btn)
        Me.EPanel5.Controls.Add(Me.g40)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(639, 147)
        Me.EPanel5.TabIndex = 3
        Me.EPanel5.Text = "     입고(허가용)"
        '
        'ip_btn
        '
        Me.ip_btn.Location = New System.Drawing.Point(126, 0)
        Me.ip_btn.Name = "ip_btn"
        Me.ip_btn.Size = New System.Drawing.Size(79, 21)
        Me.ip_btn.TabIndex = 72
        Me.ip_btn.Text = " 입고 저장"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(2, 23)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(635, 122)
        Me.g40.TabIndex = 5
        '
        'EPanel6
        '
        Me.EPanel6.Controls.Add(Me.j_btn)
        Me.EPanel6.Controls.Add(Me.g50)
        Me.EPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel6.Location = New System.Drawing.Point(0, 0)
        Me.EPanel6.Name = "EPanel6"
        Me.EPanel6.Size = New System.Drawing.Size(639, 189)
        Me.EPanel6.TabIndex = 4
        Me.EPanel6.Text = "     재고(허가용)"
        '
        'j_btn
        '
        Me.j_btn.Location = New System.Drawing.Point(126, 0)
        Me.j_btn.Name = "j_btn"
        Me.j_btn.Size = New System.Drawing.Size(79, 21)
        Me.j_btn.TabIndex = 73
        Me.j_btn.Text = " 재고 저장"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(2, 23)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(635, 164)
        Me.g50.TabIndex = 3
        '
        'WI_DE1040_J
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_DE1040_J"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel7.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        CType(Me.EPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gd_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents base_dt As Frame7.eDate
    Friend WithEvents code_no As Frame7.eText
    Friend WithEvents code_nm As Frame7.eText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel7 As Frame7.ePanel
    Friend WithEvents etc_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents etc As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents bs_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents ip_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents EPanel6 As Frame7.ePanel
    Friend WithEvents j_btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton

End Class
