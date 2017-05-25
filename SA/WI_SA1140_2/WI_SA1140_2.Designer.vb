<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1140_2
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
        Me.all_chk = New Frame7.eCheck()
        Me.stts = New Frame7.eOptionBox()
        Me.ok_ot_dt = New Frame7.eDate()
        Me.dps_stts = New Frame7.eOptionBox()
        Me.ok = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.ot_no = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.cs_nm = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
        Me.ot_chk = New Frame7.eCombo()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 113
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.ot_chk)
        Me.EPanel1.Controls.Add(Me.all_chk)
        Me.EPanel1.Controls.Add(Me.stts)
        Me.EPanel1.Controls.Add(Me.ok_ot_dt)
        Me.EPanel1.Controls.Add(Me.dps_stts)
        Me.EPanel1.Controls.Add(Me.ok)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.ot_no)
        Me.EPanel1.Controls.Add(Me.cs_cd)
        Me.EPanel1.Controls.Add(Me.cs_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 113)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     출하 등록 일괄"
        '
        'all_chk
        '
        Me.all_chk.Caption = ""
        Me.all_chk.Location = New System.Drawing.Point(19, 80)
        Me.all_chk.Name = "all_chk"
        Me.all_chk.Size = New System.Drawing.Size(103, 21)
        Me.all_chk.TabIndex = 74
        Me.all_chk.Title = "전체선택"
        Me.all_chk.TitleWidth = 80
        '
        'stts
        '
        Me.stts.Location = New System.Drawing.Point(824, 25)
        Me.stts.Name = "stts"
        Me.stts.SelectedIndex = -1
        Me.stts.Size = New System.Drawing.Size(233, 22)
        Me.stts.TabIndex = 73
        Me.stts.Title = "출하 상태"
        Me.stts.TitleWidth = 100
        '
        'ok_ot_dt
        '
        Me.ok_ot_dt.Location = New System.Drawing.Point(462, 52)
        Me.ok_ot_dt.Name = "ok_ot_dt"
        Me.ok_ot_dt.Size = New System.Drawing.Size(209, 21)
        Me.ok_ot_dt.TabIndex = 44
        Me.ok_ot_dt.Title = "출하일자 적용"
        Me.ok_ot_dt.TitleWidth = 100
        '
        'dps_stts
        '
        Me.dps_stts.Location = New System.Drawing.Point(824, 53)
        Me.dps_stts.Name = "dps_stts"
        Me.dps_stts.SelectedIndex = -1
        Me.dps_stts.Size = New System.Drawing.Size(233, 22)
        Me.dps_stts.TabIndex = 43
        Me.dps_stts.Title = "DPS 상태"
        Me.dps_stts.TitleWidth = 100
        '
        'ok
        '
        Me.ok.Location = New System.Drawing.Point(697, 46)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(86, 27)
        Me.ok.TabIndex = 72
        Me.ok.Text = "일자 변경"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(19, 26)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(202, 21)
        Me.fr_dt.TabIndex = 39
        Me.fr_dt.Title = "출하일자"
        Me.fr_dt.TitleWidth = 80
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(229, 26)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(145, 21)
        Me.to_dt.TabIndex = 40
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'ot_no
        '
        Me.ot_no.Location = New System.Drawing.Point(462, 26)
        Me.ot_no.Name = "ot_no"
        Me.ot_no.Size = New System.Drawing.Size(209, 21)
        Me.ot_no.TabIndex = 7
        Me.ot_no.Title = "출하번호"
        Me.ot_no.TitleWidth = 100
        '
        'cs_cd
        '
        Me.cs_cd.Location = New System.Drawing.Point(19, 52)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(199, 21)
        Me.cs_cd.TabIndex = 5
        Me.cs_cd.Title = "거래처코드"
        Me.cs_cd.TitleWidth = 80
        '
        'cs_nm
        '
        Me.cs_nm.Location = New System.Drawing.Point(224, 52)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(150, 21)
        Me.cs_nm.TabIndex = 6
        Me.cs_nm.Title = "사양"
        Me.cs_nm.TitleWidth = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1182, 494)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 494)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
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
        'ot_chk
        '
        Me.ot_chk.Location = New System.Drawing.Point(462, 81)
        Me.ot_chk.Name = "ot_chk"
        Me.ot_chk.Size = New System.Drawing.Size(390, 21)
        Me.ot_chk.TabIndex = 108
        Me.ot_chk.Title = "수주,출하수량 일치여부"
        Me.ot_chk.TitleWidth = 150
        '
        'WI_SA1140_2
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1140_2"
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
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents ot_no As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents dps_stts As Frame7.eOptionBox
    Friend WithEvents ok_ot_dt As Frame7.eDate
    Friend WithEvents ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stts As Frame7.eOptionBox
    Friend WithEvents all_chk As Frame7.eCheck
    Friend WithEvents ot_chk As Frame7.eCombo

End Class
