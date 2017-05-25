<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAY160
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
        Me.OD_DT2 = New Frame7.ePanel()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.emp_no = New Frame7.eText()
        Me.home_tel = New Frame7.eText()
        Me.emp_nm = New Frame7.eText()
        Me.acnt_no = New Frame7.eText()
        Me.mobile = New Frame7.eText()
        Me.back_cd = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OD_DT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OD_DT2.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.OD_DT2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 360)
        Me.SplitContainer1.SplitterDistance = 109
        Me.SplitContainer1.TabIndex = 0
        '
        'OD_DT2
        '
        Me.OD_DT2.Controls.Add(Me.emp_no)
        Me.OD_DT2.Controls.Add(Me.mobile)
        Me.OD_DT2.Controls.Add(Me.back_cd)
        Me.OD_DT2.Controls.Add(Me.emp_nm)
        Me.OD_DT2.Controls.Add(Me.acnt_no)
        Me.OD_DT2.Controls.Add(Me.home_tel)
        Me.OD_DT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OD_DT2.Location = New System.Drawing.Point(0, 0)
        Me.OD_DT2.Name = "OD_DT2"
        Me.OD_DT2.Size = New System.Drawing.Size(936, 109)
        Me.OD_DT2.TabIndex = 0
        Me.OD_DT2.Text = "     검색"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(936, 247)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     사원 계좌 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(932, 222)
        Me.g10.TabIndex = 2
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(6, 27)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(190, 21)
        Me.emp_no.TabIndex = 2
        Me.emp_no.Title = "사번"
        Me.emp_no.TitleWidth = 70
        '
        'home_tel
        '
        Me.home_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.home_tel.Location = New System.Drawing.Point(202, 63)
        Me.home_tel.Name = "home_tel"
        Me.home_tel.Size = New System.Drawing.Size(190, 21)
        Me.home_tel.TabIndex = 2
        Me.home_tel.Title = "전화번호"
        Me.home_tel.TitleWidth = 70
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(82, 27)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(240, 21)
        Me.emp_nm.TabIndex = 2
        Me.emp_nm.Title = ""
        '
        'acnt_no
        '
        Me.acnt_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acnt_no.Location = New System.Drawing.Point(408, 63)
        Me.acnt_no.Name = "acnt_no"
        Me.acnt_no.Size = New System.Drawing.Size(190, 21)
        Me.acnt_no.TabIndex = 2
        Me.acnt_no.Title = "계좌번호"
        Me.acnt_no.TitleWidth = 70
        '
        'mobile
        '
        Me.mobile.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mobile.Location = New System.Drawing.Point(6, 63)
        Me.mobile.Name = "mobile"
        Me.mobile.Size = New System.Drawing.Size(190, 21)
        Me.mobile.TabIndex = 2
        Me.mobile.Title = "핸드폰"
        Me.mobile.TitleWidth = 70
        '
        'back_cd
        '
        Me.back_cd.Location = New System.Drawing.Point(408, 27)
        Me.back_cd.Name = "back_cd"
        Me.back_cd.Size = New System.Drawing.Size(190, 21)
        Me.back_cd.TabIndex = 3
        Me.back_cd.Title = "은행"
        Me.back_cd.TitleWidth = 70
        '
        'FAY160
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAY160"
        Me.Size = New System.Drawing.Size(970, 392)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OD_DT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OD_DT2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents OD_DT2 As Frame7.ePanel
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents mobile As Frame7.eText
    Friend WithEvents back_cd As Frame7.eCombo
    Friend WithEvents emp_nm As Frame7.eText
    Friend WithEvents acnt_no As Frame7.eText
    Friend WithEvents home_tel As Frame7.eText

End Class
