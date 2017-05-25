<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QML300
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.o_cust_cd = New Frame7.eText()
        Me.o_fr_dt = New Frame7.eDate()
        Me.o_to_dt = New Frame7.eDate()
        Me.o_clm_bc = New Frame7.eCombo()
        Me.o_clm_no = New Frame7.eText()
        Me.o_clm_nm = New Frame7.eText()
        Me.o_cust_nm = New Frame7.eText()
        Me.o_stat_bc = New Frame7.eCombo()
        Me.g10 = New Frame7.eGrid()
        Me.but_prt = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1117, 650)
        Me.SplitContainer2.SplitterDistance = 81
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_cust_cd)
        Me.EPanel1.Controls.Add(Me.o_fr_dt)
        Me.EPanel1.Controls.Add(Me.but_prt)
        Me.EPanel1.Controls.Add(Me.o_to_dt)
        Me.EPanel1.Controls.Add(Me.o_clm_bc)
        Me.EPanel1.Controls.Add(Me.o_clm_no)
        Me.EPanel1.Controls.Add(Me.o_clm_nm)
        Me.EPanel1.Controls.Add(Me.o_cust_nm)
        Me.EPanel1.Controls.Add(Me.o_stat_bc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1117, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'o_cust_cd
        '
        Me.o_cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_cust_cd.Location = New System.Drawing.Point(282, 25)
        Me.o_cust_cd.Name = "o_cust_cd"
        Me.o_cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_cust_cd.TabIndex = 2
        Me.o_cust_cd.Title = "cust_cd"
        Me.o_cust_cd.Visible = False
        '
        'o_fr_dt
        '
        Me.o_fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_fr_dt.Location = New System.Drawing.Point(15, 28)
        Me.o_fr_dt.Name = "o_fr_dt"
        Me.o_fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_fr_dt.TabIndex = 3
        Me.o_fr_dt.Title = "fr_dt"
        '
        'o_to_dt
        '
        Me.o_to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_to_dt.Location = New System.Drawing.Point(15, 52)
        Me.o_to_dt.Name = "o_to_dt"
        Me.o_to_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_to_dt.TabIndex = 3
        Me.o_to_dt.Title = "to_dt"
        '
        'o_clm_bc
        '
        Me.o_clm_bc.Location = New System.Drawing.Point(752, 25)
        Me.o_clm_bc.Name = "o_clm_bc"
        Me.o_clm_bc.Size = New System.Drawing.Size(240, 21)
        Me.o_clm_bc.TabIndex = 4
        Me.o_clm_bc.Title = "clm_bc"
        '
        'o_clm_no
        '
        Me.o_clm_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_clm_no.Location = New System.Drawing.Point(282, 52)
        Me.o_clm_no.Name = "o_clm_no"
        Me.o_clm_no.Size = New System.Drawing.Size(240, 21)
        Me.o_clm_no.TabIndex = 2
        Me.o_clm_no.Title = "접수번호"
        '
        'o_clm_nm
        '
        Me.o_clm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_clm_nm.Location = New System.Drawing.Point(528, 52)
        Me.o_clm_nm.Name = "o_clm_nm"
        Me.o_clm_nm.Size = New System.Drawing.Size(189, 21)
        Me.o_clm_nm.TabIndex = 2
        Me.o_clm_nm.Title = "접수자"
        Me.o_clm_nm.TitleWidth = 60
        '
        'o_cust_nm
        '
        Me.o_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_cust_nm.Location = New System.Drawing.Point(406, 25)
        Me.o_cust_nm.Name = "o_cust_nm"
        Me.o_cust_nm.Size = New System.Drawing.Size(311, 21)
        Me.o_cust_nm.TabIndex = 2
        Me.o_cust_nm.Title = "고객"
        '
        'o_stat_bc
        '
        Me.o_stat_bc.Location = New System.Drawing.Point(752, 52)
        Me.o_stat_bc.Name = "o_stat_bc"
        Me.o_stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.o_stat_bc.TabIndex = 4
        Me.o_stat_bc.Title = "진행상태"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1117, 565)
        Me.g10.TabIndex = 0
        '
        'but_prt
        '
        Me.but_prt.Location = New System.Drawing.Point(998, 26)
        Me.but_prt.Name = "but_prt"
        Me.but_prt.Size = New System.Drawing.Size(114, 47)
        Me.but_prt.TabIndex = 5
        Me.but_prt.Text = "관리대장출력"
        '
        'QML300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "QML300"
        Me.Size = New System.Drawing.Size(1117, 650)
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_fr_dt As Frame7.eDate
    Friend WithEvents o_to_dt As Frame7.eDate
    Friend WithEvents o_clm_no As Frame7.eText
    Friend WithEvents o_cust_nm As Frame7.eText
    Friend WithEvents o_clm_bc As Frame7.eCombo
    Friend WithEvents o_clm_nm As Frame7.eText
    Friend WithEvents o_stat_bc As Frame7.eCombo
    Friend WithEvents o_cust_cd As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents but_prt As DevExpress.XtraEditors.SimpleButton

End Class
