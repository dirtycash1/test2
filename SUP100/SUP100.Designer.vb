<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUP100
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.bs_cd = New Frame7.eCombo()
        Me.no_amt_yn = New Frame7.eCheck()
        Me.rem_yn = New Frame7.eCheck()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.sup_num = New Frame7.eText()
        Me.dept_cd = New Frame7.eText()
        Me.end_yn = New Frame7.eCheck()
        Me.dept_nm = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1232, 690)
        Me.SplitContainer1.SplitterDistance = 128
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.no_amt_yn)
        Me.EPanel1.Controls.Add(Me.rem_yn)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.sup_num)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.end_yn)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1232, 128)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(8, 28)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 56
        '
        'no_amt_yn
        '
        Me.no_amt_yn.Caption = ""
        Me.no_amt_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.no_amt_yn.Location = New System.Drawing.Point(518, 79)
        Me.no_amt_yn.Name = "no_amt_yn"
        Me.no_amt_yn.Size = New System.Drawing.Size(240, 21)
        Me.no_amt_yn.TabIndex = 55
        Me.no_amt_yn.Title = "미지급금 있는 건만"
        '
        'rem_yn
        '
        Me.rem_yn.Caption = ""
        Me.rem_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rem_yn.Location = New System.Drawing.Point(260, 79)
        Me.rem_yn.Name = "rem_yn"
        Me.rem_yn.Size = New System.Drawing.Size(240, 21)
        Me.rem_yn.TabIndex = 54
        Me.rem_yn.Title = "잔금 있는 건만"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(8, 79)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 52
        Me.to_dt.Title = "기간"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(8, 53)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 51
        Me.fr_dt.Title = "기간"
        '
        'sup_num
        '
        Me.sup_num.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sup_num.Location = New System.Drawing.Point(260, 28)
        Me.sup_num.Name = "sup_num"
        Me.sup_num.Size = New System.Drawing.Size(240, 21)
        Me.sup_num.TabIndex = 9
        '
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(518, 52)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 7
        '
        'end_yn
        '
        Me.end_yn.Caption = ""
        Me.end_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_yn.Location = New System.Drawing.Point(260, 55)
        Me.end_yn.Name = "end_yn"
        Me.end_yn.Size = New System.Drawing.Size(240, 21)
        Me.end_yn.TabIndex = 53
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(642, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(300, 21)
        Me.dept_nm.TabIndex = 8
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(518, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 5
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(642, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(300, 21)
        Me.cust_nm.TabIndex = 6
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1232, 558)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     지역별 실적 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1228, 533)
        Me.g10.TabIndex = 2
        '
        'SUP100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SUP100"
        Me.Size = New System.Drawing.Size(1232, 690)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents sup_num As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents rem_yn As Frame7.eCheck
    Friend WithEvents end_yn As Frame7.eCheck
    Friend WithEvents no_amt_yn As Frame7.eCheck
    Friend WithEvents bs_cd As Frame7.eCombo

End Class
