<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCV150
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
        Me.cust_bc = New Frame7.eCombo()
        Me.cust_kd = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.biz_no = New Frame7.eText()
        Me.use_yn = New Frame7.eCheck()
        Me.co_cd = New Frame7.eCombo()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 440)
        Me.SplitContainer1.SplitterDistance = 106
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.cust_bc)
        Me.EPanel1.Controls.Add(Me.cust_kd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.biz_no)
        Me.EPanel1.Controls.Add(Me.use_yn)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1028, 106)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'cust_bc
        '
        Me.cust_bc.Location = New System.Drawing.Point(268, 28)
        Me.cust_bc.Name = "cust_bc"
        Me.cust_bc.Size = New System.Drawing.Size(240, 21)
        Me.cust_bc.TabIndex = 18
        Me.cust_bc.Title = "거래처구분"
        '
        'cust_kd
        '
        Me.cust_kd.Location = New System.Drawing.Point(268, 52)
        Me.cust_kd.Name = "cust_kd"
        Me.cust_kd.Size = New System.Drawing.Size(240, 21)
        Me.cust_kd.TabIndex = 19
        Me.cust_kd.Title = "거래처형태"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(12, 52)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 15
        Me.cust_cd.Title = "거래처코드(%)"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(12, 76)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 16
        Me.cust_nm.Title = "거래처명(%)"
        '
        'biz_no
        '
        Me.biz_no.Location = New System.Drawing.Point(268, 76)
        Me.biz_no.Name = "biz_no"
        Me.biz_no.Size = New System.Drawing.Size(240, 21)
        Me.biz_no.TabIndex = 17
        Me.biz_no.Title = "사업자번호(%)"
        '
        'use_yn
        '
        Me.use_yn.Caption = ""
        Me.use_yn.Location = New System.Drawing.Point(528, 76)
        Me.use_yn.Name = "use_yn"
        Me.use_yn.Size = New System.Drawing.Size(152, 21)
        Me.use_yn.TabIndex = 14
        Me.use_yn.Title = "거래여부"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 13
        Me.co_cd.Title = "법인"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1028, 330)
        Me.g10.TabIndex = 0
        '
        'BCV150
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCV150"
        Me.Size = New System.Drawing.Size(1038, 519)
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents use_yn As Frame7.eCheck
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents biz_no As Frame7.eText
    Friend WithEvents cust_bc As Frame7.eCombo
    Friend WithEvents cust_kd As Frame7.eCombo

End Class
