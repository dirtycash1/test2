<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPB417
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
        Me.outr_dtfr = New Frame7.eDate()
        Me.outr_no = New Frame7.eText()
        Me.outr_dtto = New Frame7.eDate()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.grp2_cd = New Frame7.eCombo()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1155, 553)
        Me.SplitContainer2.SplitterDistance = 57
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.grp2_cd)
        Me.EPanel1.Controls.Add(Me.outr_dtfr)
        Me.EPanel1.Controls.Add(Me.outr_no)
        Me.EPanel1.Controls.Add(Me.outr_dtto)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1155, 57)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'outr_dtfr
        '
        Me.outr_dtfr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.outr_dtfr.Location = New System.Drawing.Point(14, 28)
        Me.outr_dtfr.Name = "outr_dtfr"
        Me.outr_dtfr.Size = New System.Drawing.Size(240, 21)
        Me.outr_dtfr.TabIndex = 3
        '
        'outr_no
        '
        Me.outr_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.outr_no.Location = New System.Drawing.Point(401, 28)
        Me.outr_no.Name = "outr_no"
        Me.outr_no.Size = New System.Drawing.Size(240, 21)
        Me.outr_no.TabIndex = 8
        Me.outr_no.Title = "청구의뢰번호"
        '
        'outr_dtto
        '
        Me.outr_dtto.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.outr_dtto.Location = New System.Drawing.Point(139, 28)
        Me.outr_dtto.Name = "outr_dtto"
        Me.outr_dtto.Size = New System.Drawing.Size(240, 21)
        Me.outr_dtto.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer1.Size = New System.Drawing.Size(1155, 492)
        Me.SplitContainer1.SplitterDistance = 597
        Me.SplitContainer1.TabIndex = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(597, 492)
        Me.g10.TabIndex = 5
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(554, 492)
        Me.g20.TabIndex = 5
        '
        'grp2_cd
        '
        Me.grp2_cd.Location = New System.Drawing.Point(685, 28)
        Me.grp2_cd.Name = "grp2_cd"
        Me.grp2_cd.Size = New System.Drawing.Size(240, 21)
        Me.grp2_cd.TabIndex = 9
        '
        'PPB417
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "PPB417"
        Me.Size = New System.Drawing.Size(1186, 662)
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents outr_no As Frame7.eText
    Friend WithEvents outr_dtfr As Frame7.eDate
    Friend WithEvents outr_dtto As Frame7.eDate
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents grp2_cd As Frame7.eCombo

End Class
