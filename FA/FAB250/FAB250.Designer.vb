<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB250
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
        Me.div_cd = New Frame7.eCombo()
        Me.dept_cd = New Frame7.eCombo()
        Me.chk_All = New Frame7.eCheck()
        Me.fr_dt = New Frame7.eDate()
        Me.pay_bc = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.pay_kd = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.btn_doc = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel7 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel7.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel7)
        Me.SplitContainer1.Size = New System.Drawing.Size(951, 556)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.div_cd)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.chk_All)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.pay_bc)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.pay_kd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.btn_doc)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(951, 127)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(12, 52)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 21
        Me.div_cd.Title = "회계단위"
        '
        'dept_cd
        '
        Me.dept_cd.Location = New System.Drawing.Point(272, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 18
        Me.dept_cd.Title = "작성부서"
        '
        'chk_All
        '
        Me.chk_All.Caption = ""
        Me.chk_All.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_All.Location = New System.Drawing.Point(272, 100)
        Me.chk_All.Name = "chk_All"
        Me.chk_All.Size = New System.Drawing.Size(172, 21)
        Me.chk_All.TabIndex = 57
        Me.chk_All.Title = "미승인 포함 여부"
        '
        'fr_dt
        '
        Me.fr_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fr_dt.Format = "yyyy-MM-dd"
        Me.fr_dt.Location = New System.Drawing.Point(12, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 7
        Me.fr_dt.Title = "예상지급일"
        '
        'pay_bc
        '
        Me.pay_bc.Location = New System.Drawing.Point(272, 52)
        Me.pay_bc.Name = "pay_bc"
        Me.pay_bc.Size = New System.Drawing.Size(240, 21)
        Me.pay_bc.TabIndex = 19
        Me.pay_bc.Title = "지급구분"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 3
        Me.co_cd.Title = "법인"
        '
        'pay_kd
        '
        Me.pay_kd.Location = New System.Drawing.Point(272, 76)
        Me.pay_kd.Name = "pay_kd"
        Me.pay_kd.Size = New System.Drawing.Size(240, 21)
        Me.pay_kd.TabIndex = 20
        Me.pay_kd.Title = "지급형태"
        '
        'to_dt
        '
        Me.to_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.to_dt.Format = "yyyy-MM-dd"
        Me.to_dt.Location = New System.Drawing.Point(132, 100)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(120, 21)
        Me.to_dt.TabIndex = 6
        Me.to_dt.TitleWidth = 0
        '
        'btn_doc
        '
        Me.btn_doc.Location = New System.Drawing.Point(540, 96)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(120, 24)
        Me.btn_doc.TabIndex = 58
        Me.btn_doc.Text = "전표발행"
        '
        'EPanel7
        '
        Me.EPanel7.Controls.Add(Me.g10)
        Me.EPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel7.Location = New System.Drawing.Point(0, 0)
        Me.EPanel7.Name = "EPanel7"
        Me.EPanel7.Size = New System.Drawing.Size(951, 425)
        Me.EPanel7.TabIndex = 2
        Me.EPanel7.Text = "     전표현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(947, 400)
        Me.g10.TabIndex = 2
        '
        'FAB250
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAB250"
        Me.Size = New System.Drawing.Size(977, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents EPanel7 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents pay_kd As Frame7.eCombo
    Friend WithEvents pay_bc As Frame7.eCombo
    Friend WithEvents dept_cd As Frame7.eCombo
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents chk_All As Frame7.eCheck
    Friend WithEvents btn_doc As DevExpress.XtraEditors.SimpleButton

End Class
