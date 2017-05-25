<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCZ110
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
        Me.검색조건 = New Frame7.ePanel()
        Me.학교코드등록 = New Frame7.ePanel()
        Me.sch_bc = New Frame7.eCombo()
        Me.sch_nm = New Frame7.eText()
        Me.close_yn = New Frame7.eCheck()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.검색조건, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.검색조건.SuspendLayout()
        CType(Me.학교코드등록, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.학교코드등록.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.검색조건)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.학교코드등록)
        Me.SplitContainer1.Size = New System.Drawing.Size(1050, 636)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 1
        '
        '검색조건
        '
        Me.검색조건.Controls.Add(Me.sch_bc)
        Me.검색조건.Controls.Add(Me.sch_nm)
        Me.검색조건.Controls.Add(Me.close_yn)
        Me.검색조건.Dock = System.Windows.Forms.DockStyle.Fill
        Me.검색조건.Location = New System.Drawing.Point(0, 0)
        Me.검색조건.Name = "검색조건"
        Me.검색조건.Size = New System.Drawing.Size(1050, 81)
        Me.검색조건.TabIndex = 0
        Me.검색조건.Text = "     검색조건"
        '
        '학교코드등록
        '
        Me.학교코드등록.Controls.Add(Me.g10)
        Me.학교코드등록.Dock = System.Windows.Forms.DockStyle.Fill
        Me.학교코드등록.Location = New System.Drawing.Point(0, 0)
        Me.학교코드등록.Name = "학교코드등록"
        Me.학교코드등록.Size = New System.Drawing.Size(1050, 551)
        Me.학교코드등록.TabIndex = 0
        Me.학교코드등록.Text = "     학교코드등록"
        '
        'sch_bc
        '
        Me.sch_bc.CompuText = Nothing
        Me.sch_bc.Location = New System.Drawing.Point(8, 28)
        Me.sch_bc.Name = "sch_bc"
        Me.sch_bc.Size = New System.Drawing.Size(240, 21)
        Me.sch_bc.TabIndex = 2
        '
        'sch_nm
        '
        Me.sch_nm.CompuText = Nothing
        Me.sch_nm.Location = New System.Drawing.Point(8, 52)
        Me.sch_nm.Name = "sch_nm"
        Me.sch_nm.Size = New System.Drawing.Size(240, 21)
        Me.sch_nm.TabIndex = 3
        '
        'close_yn
        '
        Me.close_yn.Caption = ""
        Me.close_yn.CompuText = Nothing
        Me.close_yn.Location = New System.Drawing.Point(264, 52)
        Me.close_yn.Name = "close_yn"
        Me.close_yn.Size = New System.Drawing.Size(240, 21)
        Me.close_yn.TabIndex = 4
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1046, 526)
        Me.g10.TabIndex = 2
        '
        'BCZ110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCZ110"
        Me.Size = New System.Drawing.Size(1050, 636)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.검색조건, System.ComponentModel.ISupportInitialize).EndInit()
        Me.검색조건.ResumeLayout(False)
        CType(Me.학교코드등록, System.ComponentModel.ISupportInitialize).EndInit()
        Me.학교코드등록.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents 검색조건 As Frame7.ePanel
    Friend WithEvents sch_bc As Frame7.eCombo
    Friend WithEvents sch_nm As Frame7.eText
    Friend WithEvents close_yn As Frame7.eCheck
    Friend WithEvents 학교코드등록 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid

End Class
