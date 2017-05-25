<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MME030
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
        Me.EPanel1 = New Frame7.ePanel
        Me.fac_cd = New Frame7.eCombo
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EPanel2 = New Frame7.ePanel
        Me.cust_cd = New Frame7.eText
        Me.cust_nm = New Frame7.eText
        Me.g10 = New Frame7.eGrid
        Me.plan_dtf = New Frame7.eDate
        Me.plan_dtt = New Frame7.eDate
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.plan_dtt)
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.plan_dtf)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1050, 80)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색 조건"
        '
        'fac_cd
        '
        Me.fac_cd.CompuText = Nothing
        Me.fac_cd.Location = New System.Drawing.Point(8, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 2
        Me.fac_cd.Title = "발주공장"
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 663)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1050, 579)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     작업 지시 현황"
        '
        'cust_cd
        '
        Me.cust_cd.CompuText = Nothing
        Me.cust_cd.Location = New System.Drawing.Point(524, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(236, 21)
        Me.cust_cd.TabIndex = 3
        Me.cust_cd.Title = "거래처코드"
        '
        'cust_nm
        '
        Me.cust_nm.CompuText = Nothing
        Me.cust_nm.Location = New System.Drawing.Point(644, 28)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(284, 21)
        Me.cust_nm.TabIndex = 4
        Me.cust_nm.Title = "거래처명"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 554)
        Me.g10.TabIndex = 2
        '
        'plan_dtf
        '
        Me.plan_dtf.CompuText = Nothing
        Me.plan_dtf.Location = New System.Drawing.Point(264, 28)
        Me.plan_dtf.Name = "plan_dtf"
        Me.plan_dtf.Size = New System.Drawing.Size(240, 21)
        Me.plan_dtf.TabIndex = 5
        '
        'plan_dtt
        '
        Me.plan_dtt.CompuText = Nothing
        Me.plan_dtt.Location = New System.Drawing.Point(264, 52)
        Me.plan_dtt.Name = "plan_dtt"
        Me.plan_dtt.Size = New System.Drawing.Size(240, 21)
        Me.plan_dtt.TabIndex = 6
        Me.plan_dtt.Title = "~"
        '
        'MME030
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MME030"
        Me.Size = New System.Drawing.Size(1050, 663)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents plan_dtf As Frame7.eDate
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents plan_dtt As Frame7.eDate

End Class
