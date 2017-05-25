<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_SA1142
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.deli_nm = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.from_dt = New Frame7.eDate()
        Me.deli_place = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.prt_chk = New Frame7.eCombo()
        Me.but_all = New DevExpress.XtraEditors.SimpleButton()
        Me.cs_nm = New Frame7.eText()
        Me.but_pri = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1152, 611)
        Me.SplitContainer1.SplitterDistance = 86
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.deli_nm)
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Controls.Add(Me.deli_place)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.prt_chk)
        Me.EPanel2.Controls.Add(Me.but_all)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.but_pri)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1152, 86)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     거래명세서인쇄(일괄)"
        '
        'deli_nm
        '
        Me.deli_nm.Location = New System.Drawing.Point(705, 26)
        Me.deli_nm.Name = "deli_nm"
        Me.deli_nm.Size = New System.Drawing.Size(171, 21)
        Me.deli_nm.TabIndex = 60
        Me.deli_nm.Title = "나우/용마 구분"
        Me.deli_nm.TitleWidth = 90
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(172, 30)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(111, 21)
        Me.to_dt.TabIndex = 53
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(10, 30)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(159, 21)
        Me.from_dt.TabIndex = 52
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 60
        '
        'deli_place
        '
        Me.deli_place.ColumnName = "find_stts"
        Me.deli_place.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deli_place.Location = New System.Drawing.Point(289, 30)
        Me.deli_place.Name = "deli_place"
        Me.deli_place.Size = New System.Drawing.Size(304, 21)
        Me.deli_place.TabIndex = 56
        Me.deli_place.TableName = "find_stts"
        Me.deli_place.Title = "배송지"
        Me.deli_place.TitleWidth = 78
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(10, 57)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(182, 21)
        Me.cs_cd.TabIndex = 54
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 78
        '
        'prt_chk
        '
        Me.prt_chk.Location = New System.Drawing.Point(705, 57)
        Me.prt_chk.Name = "prt_chk"
        Me.prt_chk.Size = New System.Drawing.Size(171, 21)
        Me.prt_chk.TabIndex = 59
        Me.prt_chk.TitleWidth = 90
        '
        'but_all
        '
        Me.but_all.Location = New System.Drawing.Point(608, 53)
        Me.but_all.Name = "but_all"
        Me.but_all.Size = New System.Drawing.Size(78, 28)
        Me.but_all.TabIndex = 58
        Me.but_all.Text = "전체선택"
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(201, 57)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(392, 21)
        Me.cs_nm.TabIndex = 55
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "거래처명"
        Me.cs_nm.TitleWidth = 78
        '
        'but_pri
        '
        Me.but_pri.Location = New System.Drawing.Point(882, 26)
        Me.but_pri.Name = "but_pri"
        Me.but_pri.Size = New System.Drawing.Size(124, 48)
        Me.but_pri.TabIndex = 57
        Me.but_pri.Text = "거래명세서출력"
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1152, 521)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     거래명세서 조회"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1148, 496)
        Me.g10.TabIndex = 1
        '
        'WP_SA1142
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_SA1142"
        Me.Size = New System.Drawing.Size(1152, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents deli_place As Frame7.eText
    Friend WithEvents but_pri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents but_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents prt_chk As Frame7.eCombo
    Friend WithEvents deli_nm As Frame7.eCombo

End Class
