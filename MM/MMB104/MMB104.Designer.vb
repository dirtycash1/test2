<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB104
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
        Me.S_time_to = New Frame7.eDate()
        Me.S_time_from = New Frame7.eDate()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.S_addr = New Frame7.eText()
        Me.S_admo = New Frame7.eText()
        Me.S_cont = New Frame7.eMemo()
        Me.S_sand = New System.Windows.Forms.Button()
        Me.G20 = New Frame7.eGrid()
        Me.G10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 131
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.S_time_from)
        Me.EPanel1.Controls.Add(Me.S_time_to)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 131)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     SMS 검색"
        '
        'S_time_to
        '
        Me.S_time_to.Location = New System.Drawing.Point(216, 27)
        Me.S_time_to.Name = "S_time_to"
        Me.S_time_to.Size = New System.Drawing.Size(240, 21)
        Me.S_time_to.TabIndex = 3
        Me.S_time_to.Title = "            ~"
        Me.S_time_to.TitleWidth = 70
        '
        'S_time_from
        '
        Me.S_time_from.Location = New System.Drawing.Point(6, 27)
        Me.S_time_from.Name = "S_time_from"
        Me.S_time_from.Size = New System.Drawing.Size(240, 21)
        Me.S_time_from.TabIndex = 2
        Me.S_time_from.Title = "기간"
        Me.S_time_from.TitleWidth = 70
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.G10)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 476)
        Me.SplitContainer2.SplitterDistance = 305
        Me.SplitContainer2.TabIndex = 0
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.G20)
        Me.SplitContainer3.Size = New System.Drawing.Size(305, 476)
        Me.SplitContainer3.SplitterDistance = 284
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.S_addr)
        Me.EPanel2.Controls.Add(Me.S_admo)
        Me.EPanel2.Controls.Add(Me.S_cont)
        Me.EPanel2.Controls.Add(Me.S_sand)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(305, 284)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     SMS 작성"
        '
        'S_addr
        '
        Me.S_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_addr.Location = New System.Drawing.Point(6, 194)
        Me.S_addr.Name = "S_addr"
        Me.S_addr.Size = New System.Drawing.Size(163, 21)
        Me.S_addr.TabIndex = 3
        Me.S_addr.Title = "보내는 사람"
        Me.S_addr.TitleWidth = 80
        '
        'S_admo
        '
        Me.S_admo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.S_admo.Location = New System.Drawing.Point(99, 194)
        Me.S_admo.Name = "S_admo"
        Me.S_admo.Size = New System.Drawing.Size(201, 21)
        Me.S_admo.TabIndex = 5
        Me.S_admo.Title = "보내는 사람"
        Me.S_admo.TitleWidth = 80
        '
        'S_cont
        '
        Me.S_cont.Location = New System.Drawing.Point(6, 27)
        Me.S_cont.Name = "S_cont"
        Me.S_cont.Size = New System.Drawing.Size(294, 161)
        Me.S_cont.TabIndex = 2
        Me.S_cont.Title = "SMS 내용"
        Me.S_cont.TitleWidth = 80
        '
        'S_sand
        '
        Me.S_sand.Location = New System.Drawing.Point(85, 221)
        Me.S_sand.Name = "S_sand"
        Me.S_sand.Size = New System.Drawing.Size(215, 23)
        Me.S_sand.TabIndex = 4
        Me.S_sand.Text = "SMS 보내기"
        Me.S_sand.UseVisualStyleBackColor = True
        '
        'G20
        '
        Me.G20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G20.Location = New System.Drawing.Point(0, 0)
        Me.G20.Name = "G20"
        Me.G20.ReadOnly = False
        Me.G20.RowHeight = -1
        Me.G20.Size = New System.Drawing.Size(305, 188)
        Me.G20.TabIndex = 0
        '
        'G10
        '
        Me.G10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.G10.Location = New System.Drawing.Point(0, 0)
        Me.G10.Name = "G10"
        Me.G10.ReadOnly = False
        Me.G10.RowHeight = -1
        Me.G10.Size = New System.Drawing.Size(873, 476)
        Me.G10.TabIndex = 0
        '
        'MMB104
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB104"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents S_cont As Frame7.eMemo
    Friend WithEvents S_addr As Frame7.eText
    Friend WithEvents S_sand As System.Windows.Forms.Button
    Friend WithEvents G20 As Frame7.eGrid
    Friend WithEvents G10 As Frame7.eGrid
    Friend WithEvents S_admo As Frame7.eText
    Friend WithEvents S_time_to As Frame7.eDate
    Friend WithEvents S_time_from As Frame7.eDate

End Class
