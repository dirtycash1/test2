<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_MD1000
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.all_chk = New Frame7.eCheck()
        Me.gd_nm = New Frame7.eText()
        Me.ps_cd = New Frame7.eText()
        Me.DAYTIME_GU = New Frame7.eCombo()
        Me.mc_cd = New Frame7.eCombo()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.gong_cd = New Frame7.eCombo()
        Me.g_multi = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
        'Me.CachedGAC120R1 = New System7.CachedGAC120R()
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
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_multi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 101
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SimpleButton1)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.gd_nm)
        Me.EPanel1.Controls.Add(Me.ps_cd)
        Me.EPanel1.Controls.Add(Me.DAYTIME_GU)
        Me.EPanel1.Controls.Add(Me.mc_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.gong_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 101)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     MOLD 현황"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(1042, 61)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 24)
        Me.SimpleButton1.TabIndex = 68
        Me.SimpleButton1.Text = "출력(선택)"
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.all_chk.Location = New System.Drawing.Point(910, 64)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(103, 21)
        Me.all_chk.TabIndex = 67
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 80
        '
        'gd_nm
        '
        Me.gd_nm.ColumnName = "find_paymentterm_nm"
        Me.gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gd_nm.Location = New System.Drawing.Point(616, 64)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(256, 21)
        Me.gd_nm.TabIndex = 66
        Me.gd_nm.TableName = "find_paymentterm_nm"
        Me.gd_nm.Title = "품명"
        Me.gd_nm.TitleWidth = 110
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymentterm_nm"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(616, 37)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(256, 21)
        Me.ps_cd.TabIndex = 65
        Me.ps_cd.TableName = "find_paymentterm_nm"
        Me.ps_cd.Title = "작업자"
        Me.ps_cd.TitleWidth = 110
        '
        'DAYTIME_GU
        '
        Me.DAYTIME_GU.Location = New System.Drawing.Point(19, 64)
        Me.DAYTIME_GU.Name = "DAYTIME_GU"
        Me.DAYTIME_GU.Size = New System.Drawing.Size(273, 21)
        Me.DAYTIME_GU.TabIndex = 64
        Me.DAYTIME_GU.Title = "주/야 구분"
        '
        'mc_cd
        '
        Me.mc_cd.Location = New System.Drawing.Point(320, 64)
        Me.mc_cd.Name = "mc_cd"
        Me.mc_cd.Size = New System.Drawing.Size(240, 21)
        Me.mc_cd.TabIndex = 63
        Me.mc_cd.Title = "기계코드"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(19, 37)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(159, 21)
        Me.fr_dt.TabIndex = 61
        Me.fr_dt.Title = "기간"
        Me.fr_dt.TitleWidth = 60
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(181, 37)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(111, 21)
        Me.to_dt.TabIndex = 62
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'gong_cd
        '
        Me.gong_cd.Location = New System.Drawing.Point(320, 37)
        Me.gong_cd.Name = "gong_cd"
        Me.gong_cd.Size = New System.Drawing.Size(240, 21)
        Me.gong_cd.TabIndex = 60
        Me.gong_cd.Title = "공장"
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 506)
        Me.g_multi.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 506)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText3.Location = New System.Drawing.Point(19, 41)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(210, 21)
        Me.EText3.TabIndex = 5
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "코 드"
        Me.EText3.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymentterm_nm"
        Me.EText4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText4.Location = New System.Drawing.Point(19, 68)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(240, 21)
        Me.EText4.TabIndex = 6
        Me.EText4.TableName = "find_paymentterm_nm"
        Me.EText4.Title = "Price Term 명"
        Me.EText4.TitleWidth = 98
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(364, 41)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 7
        Me.ECombo2.Title = "사용여부"
        '
        'WI_MD1000
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_MD1000"
        Me.Size = New System.Drawing.Size(1182, 611)
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
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents gong_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents DAYTIME_GU As Frame7.eCombo
    Friend WithEvents mc_cd As Frame7.eCombo
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents all_chk As Frame7.eCheck
    'Friend WithEvents CachedGAC120R1 As System7.CachedGAC120R

End Class
