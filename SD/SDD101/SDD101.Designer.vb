<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDD101
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
        Me.sal_dept = New Frame7.eText()
        Me.sal_dept_nm = New Frame7.eText()
        Me.cury_bc = New Frame7.eCombo()
        Me.sal_bs = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.itm_bc = New Frame7.eCombo()
        Me.cust_cd = New Frame7.eText()
        Me.de_bc = New Frame7.eCombo()
        Me.cust_nm = New Frame7.eText()
        Me.itm_cd = New Frame7.eText()
        Me.itm_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.sal_no = New Frame7.eText()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1048, 516)
        Me.SplitContainer1.SplitterDistance = 130
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.sal_no)
        Me.EPanel1.Controls.Add(Me.sal_dept)
        Me.EPanel1.Controls.Add(Me.sal_dept_nm)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.sal_bs)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.itm_bc)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.de_bc)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.itm_cd)
        Me.EPanel1.Controls.Add(Me.itm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1048, 130)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "     검색"
        '
        'sal_dept
        '
        Me.sal_dept.Location = New System.Drawing.Point(856, 48)
        Me.sal_dept.Name = "sal_dept"
        Me.sal_dept.Size = New System.Drawing.Size(80, 21)
        Me.sal_dept.TabIndex = 117
        Me.sal_dept.Title = "dept_cd"
        '
        'sal_dept_nm
        '
        Me.sal_dept_nm.Location = New System.Drawing.Point(12, 100)
        Me.sal_dept_nm.Name = "sal_dept_nm"
        Me.sal_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.sal_dept_nm.TabIndex = 116
        Me.sal_dept_nm.Title = "dept_nm"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(272, 76)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 115
        Me.cury_bc.Title = "통화"
        '
        'sal_bs
        '
        Me.sal_bs.Location = New System.Drawing.Point(12, 76)
        Me.sal_bs.Name = "sal_bs"
        Me.sal_bs.Size = New System.Drawing.Size(240, 21)
        Me.sal_bs.TabIndex = 113
        Me.sal_bs.Title = "출하사업장"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(12, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 111
        Me.fr_dt.Title = "출고일자"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(132, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 112
        Me.to_dt.Title = "부터"
        Me.to_dt.TitleWidth = 0
        '
        'itm_bc
        '
        Me.itm_bc.Location = New System.Drawing.Point(528, 52)
        Me.itm_bc.Name = "itm_bc"
        Me.itm_bc.Size = New System.Drawing.Size(240, 21)
        Me.itm_bc.TabIndex = 88
        Me.itm_bc.Title = "품목구분"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(272, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 85
        Me.cust_cd.Title = "거래처"
        '
        'de_bc
        '
        Me.de_bc.Location = New System.Drawing.Point(272, 52)
        Me.de_bc.Name = "de_bc"
        Me.de_bc.Size = New System.Drawing.Size(240, 21)
        Me.de_bc.TabIndex = 89
        Me.de_bc.Title = "지역구분"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(516, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 84
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'itm_cd
        '
        Me.itm_cd.Location = New System.Drawing.Point(528, 76)
        Me.itm_cd.Name = "itm_cd"
        Me.itm_cd.Size = New System.Drawing.Size(240, 21)
        Me.itm_cd.TabIndex = 87
        Me.itm_cd.Title = "매출품목"
        '
        'itm_nm
        '
        Me.itm_nm.Location = New System.Drawing.Point(528, 100)
        Me.itm_nm.Name = "itm_nm"
        Me.itm_nm.Size = New System.Drawing.Size(240, 21)
        Me.itm_nm.TabIndex = 86
        Me.itm_nm.Title = "itm_nm"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1048, 382)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     매출 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1044, 357)
        Me.g10.TabIndex = 2
        '
        'sal_no
        '
        Me.sal_no.Location = New System.Drawing.Point(272, 100)
        Me.sal_no.Name = "sal_no"
        Me.sal_no.Size = New System.Drawing.Size(240, 21)
        Me.sal_no.TabIndex = 118
        Me.sal_no.Title = "매출번호"
        '
        'SDD101
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SDD101"
        Me.Size = New System.Drawing.Size(1094, 527)
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
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents de_bc As Frame7.eCombo
    Friend WithEvents itm_bc As Frame7.eCombo
    Friend WithEvents itm_cd As Frame7.eText
    Friend WithEvents itm_nm As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents sal_bs As Frame7.eCombo
    Friend WithEvents sal_dept As Frame7.eText
    Friend WithEvents sal_dept_nm As Frame7.eText
    Friend WithEvents sal_no As Frame7.eText

End Class
