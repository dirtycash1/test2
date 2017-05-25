<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QML220
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
        Me.o_to_dt = New Frame7.eDate()
        Me.o_fr_dt = New Frame7.eDate()
        Me.chk_no = New Frame7.eCheck()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g40 = New Frame7.eGrid()
        Me.g50 = New Frame7.eGrid()
        Me.o_clm_no = New Frame7.eText()
        Me.o_stat_bc = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 600)
        Me.SplitContainer1.SplitterDistance = 57
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_stat_bc)
        Me.EPanel1.Controls.Add(Me.o_clm_no)
        Me.EPanel1.Controls.Add(Me.o_fr_dt)
        Me.EPanel1.Controls.Add(Me.o_to_dt)
        Me.EPanel1.Controls.Add(Me.chk_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1028, 57)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'o_to_dt
        '
        Me.o_to_dt.Location = New System.Drawing.Point(142, 28)
        Me.o_to_dt.Name = "o_to_dt"
        Me.o_to_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_to_dt.TabIndex = 20
        Me.o_to_dt.Title = "발생기간(to)"
        '
        'o_fr_dt
        '
        Me.o_fr_dt.Location = New System.Drawing.Point(19, 28)
        Me.o_fr_dt.Name = "o_fr_dt"
        Me.o_fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_fr_dt.TabIndex = 16
        Me.o_fr_dt.Title = "발생기간(fr)"
        '
        'chk_no
        '
        Me.chk_no.Caption = ""
        Me.chk_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_no.Location = New System.Drawing.Point(871, 28)
        Me.chk_no.Name = "chk_no"
        Me.chk_no.Size = New System.Drawing.Size(111, 21)
        Me.chk_no.TabIndex = 19
        Me.chk_no.Title = "미처리 만"
        Me.chk_no.TitleWidth = 80
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1028, 539)
        Me.SplitContainer2.SplitterDistance = 353
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g10)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(353, 539)
        Me.EPanel5.TabIndex = 0
        Me.EPanel5.Text = "     고객불만 접수현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(349, 514)
        Me.g10.TabIndex = 2
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(671, 539)
        Me.SplitContainer3.SplitterDistance = 305
        Me.SplitContainer3.TabIndex = 0
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
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer4.Size = New System.Drawing.Size(671, 305)
        Me.SplitContainer4.SplitterDistance = 163
        Me.SplitContainer4.TabIndex = 0
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
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.g50)
        Me.SplitContainer5.Size = New System.Drawing.Size(671, 230)
        Me.SplitContainer5.SplitterDistance = 136
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g20)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(671, 163)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     검사결과"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(667, 138)
        Me.g20.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g30)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(671, 138)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     발생원인조사결과"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(667, 113)
        Me.g30.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g40)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(671, 136)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     조치내용"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(2, 23)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(667, 111)
        Me.g40.TabIndex = 2
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(671, 90)
        Me.g50.TabIndex = 3
        '
        'o_clm_no
        '
        Me.o_clm_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_clm_no.Location = New System.Drawing.Point(411, 28)
        Me.o_clm_no.Name = "o_clm_no"
        Me.o_clm_no.Size = New System.Drawing.Size(214, 21)
        Me.o_clm_no.TabIndex = 21
        Me.o_clm_no.Title = "접수번호"
        Me.o_clm_no.TitleWidth = 80
        '
        'o_stat_bc
        '
        Me.o_stat_bc.Location = New System.Drawing.Point(664, 28)
        Me.o_stat_bc.Name = "o_stat_bc"
        Me.o_stat_bc.Size = New System.Drawing.Size(168, 21)
        Me.o_stat_bc.TabIndex = 22
        Me.o_stat_bc.Title = "진행상태"
        Me.o_stat_bc.TitleWidth = 80
        '
        'QML220
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QML220"
        Me.Size = New System.Drawing.Size(1034, 699)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_fr_dt As Frame7.eDate
    Friend WithEvents chk_no As Frame7.eCheck
    Friend WithEvents o_to_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents o_clm_no As Frame7.eText
    Friend WithEvents o_stat_bc As Frame7.eCombo

End Class
