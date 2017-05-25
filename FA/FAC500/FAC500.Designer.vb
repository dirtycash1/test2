<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC500
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
        Me.chk9 = New Frame7.eCheck()
        Me.chk0 = New Frame7.eCheck()
        Me.chk8 = New Frame7.eCheck()
        Me.chk7 = New Frame7.eCheck()
        Me.chk6 = New Frame7.eCheck()
        Me.chk5 = New Frame7.eCheck()
        Me.chk4 = New Frame7.eCheck()
        Me.chk3 = New Frame7.eCheck()
        Me.chk2 = New Frame7.eCheck()
        Me.chk1 = New Frame7.eCheck()
        Me.tax_dtf = New Frame7.eDate()
        Me.work_dt = New Frame7.eDate()
        Me.tax_dtt = New Frame7.eDate()
        Me.desc = New System.Windows.Forms.Label()
        Me.desc2 = New System.Windows.Forms.Label()
        Me.co_cd = New Frame7.eCombo()
        Me.tax_year = New Frame7.eDate()
        Me.mon_bc = New Frame7.eCombo()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.bs_cd = New Frame7.eCombo()
        Me.end_yn = New Frame7.eCheck()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.chk = New Frame7.eCheck()
        Me.btn = New DevExpress.XtraEditors.SimpleButton()
        Me.fr_dt = New Frame7.eDate()
        Me.tax_kd = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(864, 628)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chk9)
        Me.EPanel1.Controls.Add(Me.chk0)
        Me.EPanel1.Controls.Add(Me.chk8)
        Me.EPanel1.Controls.Add(Me.chk7)
        Me.EPanel1.Controls.Add(Me.chk6)
        Me.EPanel1.Controls.Add(Me.chk5)
        Me.EPanel1.Controls.Add(Me.chk4)
        Me.EPanel1.Controls.Add(Me.chk3)
        Me.EPanel1.Controls.Add(Me.chk2)
        Me.EPanel1.Controls.Add(Me.chk1)
        Me.EPanel1.Controls.Add(Me.tax_dtf)
        Me.EPanel1.Controls.Add(Me.work_dt)
        Me.EPanel1.Controls.Add(Me.tax_dtt)
        Me.EPanel1.Controls.Add(Me.desc)
        Me.EPanel1.Controls.Add(Me.desc2)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.tax_year)
        Me.EPanel1.Controls.Add(Me.mon_bc)
        Me.EPanel1.Controls.Add(Me.btn_work)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.end_yn)
        Me.EPanel1.Controls.Add(Me.btn_close)
        Me.EPanel1.Location = New System.Drawing.Point(3, 3)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(501, 609)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "     부가세 집계"
        '
        'chk9
        '
        Me.chk9.Caption = ""
        Me.chk9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk9.Location = New System.Drawing.Point(88, 228)
        Me.chk9.Name = "chk9"
        Me.chk9.Size = New System.Drawing.Size(240, 21)
        Me.chk9.TabIndex = 73
        Me.chk9.Title = "면세계산서합계표"
        Me.chk9.TitleWidth = 150
        '
        'chk0
        '
        Me.chk0.Caption = ""
        Me.chk0.Checked = True
        Me.chk0.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk0.Location = New System.Drawing.Point(88, 204)
        Me.chk0.Name = "chk0"
        Me.chk0.Size = New System.Drawing.Size(240, 21)
        Me.chk0.TabIndex = 72
        Me.chk0.Title = "세금계산서합계표"
        Me.chk0.TitleWidth = 150
        '
        'chk8
        '
        Me.chk8.Caption = ""
        Me.chk8.Checked = True
        Me.chk8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk8.Location = New System.Drawing.Point(88, 420)
        Me.chk8.Name = "chk8"
        Me.chk8.Size = New System.Drawing.Size(240, 21)
        Me.chk8.TabIndex = 71
        Me.chk8.Title = "사업설비투자실적명세서"
        Me.chk8.TitleWidth = 150
        Me.chk8.Visible = False
        '
        'chk7
        '
        Me.chk7.Caption = ""
        Me.chk7.Checked = True
        Me.chk7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk7.Location = New System.Drawing.Point(88, 348)
        Me.chk7.Name = "chk7"
        Me.chk7.Size = New System.Drawing.Size(240, 21)
        Me.chk7.TabIndex = 70
        Me.chk7.Title = "건물등감가상각취득명세서"
        Me.chk7.TitleWidth = 150
        '
        'chk6
        '
        Me.chk6.Caption = ""
        Me.chk6.Checked = True
        Me.chk6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk6.Location = New System.Drawing.Point(88, 396)
        Me.chk6.Name = "chk6"
        Me.chk6.Size = New System.Drawing.Size(240, 21)
        Me.chk6.TabIndex = 69
        Me.chk6.Title = "외화획득명세서"
        Me.chk6.TitleWidth = 150
        Me.chk6.Visible = False
        '
        'chk5
        '
        Me.chk5.Caption = ""
        Me.chk5.Checked = True
        Me.chk5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk5.Location = New System.Drawing.Point(88, 324)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(240, 21)
        Me.chk5.TabIndex = 68
        Me.chk5.Title = "수출실적명세서"
        Me.chk5.TitleWidth = 150
        '
        'chk4
        '
        Me.chk4.Caption = ""
        Me.chk4.Checked = True
        Me.chk4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk4.Location = New System.Drawing.Point(88, 300)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(240, 21)
        Me.chk4.TabIndex = 67
        Me.chk4.Title = "영세율첨부서류"
        Me.chk4.TitleWidth = 150
        '
        'chk3
        '
        Me.chk3.Caption = ""
        Me.chk3.Checked = True
        Me.chk3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk3.Location = New System.Drawing.Point(88, 276)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(240, 21)
        Me.chk3.TabIndex = 66
        Me.chk3.Title = "매입세액불공제"
        Me.chk3.TitleWidth = 150
        '
        'chk2
        '
        Me.chk2.Caption = ""
        Me.chk2.Checked = True
        Me.chk2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk2.Location = New System.Drawing.Point(88, 372)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(240, 21)
        Me.chk2.TabIndex = 65
        Me.chk2.Title = "신용카드매출수취명세서"
        Me.chk2.TitleWidth = 150
        Me.chk2.Visible = False
        '
        'chk1
        '
        Me.chk1.Caption = ""
        Me.chk1.Checked = True
        Me.chk1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk1.Location = New System.Drawing.Point(88, 252)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(240, 21)
        Me.chk1.TabIndex = 64
        Me.chk1.Title = "부가가치세신고서"
        Me.chk1.TitleWidth = 150
        '
        'tax_dtf
        '
        Me.tax_dtf.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtf.Format = "yyyy-MM-dd"
        Me.tax_dtf.Location = New System.Drawing.Point(88, 124)
        Me.tax_dtf.Name = "tax_dtf"
        Me.tax_dtf.Size = New System.Drawing.Size(240, 21)
        Me.tax_dtf.TabIndex = 62
        '
        'work_dt
        '
        Me.work_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_dt.Location = New System.Drawing.Point(88, 172)
        Me.work_dt.Name = "work_dt"
        Me.work_dt.Size = New System.Drawing.Size(240, 21)
        Me.work_dt.TabIndex = 61
        '
        'tax_dtt
        '
        Me.tax_dtt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtt.Format = "yyyy-MM-dd"
        Me.tax_dtt.Location = New System.Drawing.Point(176, 148)
        Me.tax_dtt.Name = "tax_dtt"
        Me.tax_dtt.Size = New System.Drawing.Size(152, 21)
        Me.tax_dtt.TabIndex = 63
        Me.tax_dtt.Title = "~"
        Me.tax_dtt.TitleWidth = 30
        '
        'desc
        '
        Me.desc.ForeColor = System.Drawing.Color.Red
        Me.desc.Location = New System.Drawing.Point(40, 444)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(337, 40)
        Me.desc.TabIndex = 4
        '
        'desc2
        '
        Me.desc2.ForeColor = System.Drawing.Color.Red
        Me.desc2.Location = New System.Drawing.Point(38, 488)
        Me.desc2.Name = "desc2"
        Me.desc2.Size = New System.Drawing.Size(339, 44)
        Me.desc2.TabIndex = 4
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(88, 28)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 45
        Me.co_cd.Title = "법인명"
        '
        'tax_year
        '
        Me.tax_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_year.Location = New System.Drawing.Point(88, 76)
        Me.tax_year.Name = "tax_year"
        Me.tax_year.Size = New System.Drawing.Size(240, 21)
        Me.tax_year.TabIndex = 47
        Me.tax_year.Title = "신고년도"
        '
        'mon_bc
        '
        Me.mon_bc.Location = New System.Drawing.Point(88, 100)
        Me.mon_bc.Name = "mon_bc"
        Me.mon_bc.Size = New System.Drawing.Size(240, 21)
        Me.mon_bc.TabIndex = 51
        Me.mon_bc.Title = "신고분기"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(198, 564)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(104, 36)
        Me.btn_work.TabIndex = 52
        Me.btn_work.Text = "부가세 집계"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(88, 52)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 46
        Me.bs_cd.Title = "사업장"
        '
        'end_yn
        '
        Me.end_yn.Caption = ""
        Me.end_yn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.end_yn.Location = New System.Drawing.Point(92, 536)
        Me.end_yn.Name = "end_yn"
        Me.end_yn.Size = New System.Drawing.Size(240, 21)
        Me.end_yn.TabIndex = 60
        Me.end_yn.Title = "마감 여부"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(88, 564)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 36)
        Me.btn_close.TabIndex = 52
        Me.btn_close.Text = "마감처리"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(150, 46)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 0
        '
        'chk
        '
        Me.chk.Caption = ""
        Me.chk.Location = New System.Drawing.Point(88, 136)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(240, 21)
        Me.chk.TabIndex = 60
        Me.chk.Title = "마감 여부"
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(156, 212)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(104, 36)
        Me.btn.TabIndex = 52
        Me.btn.Text = "부가세 집계"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(88, 76)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 47
        Me.fr_dt.Title = "발행일"
        '
        'tax_kd
        '
        Me.tax_kd.Location = New System.Drawing.Point(88, 100)
        Me.tax_kd.Name = "tax_kd"
        Me.tax_kd.Size = New System.Drawing.Size(240, 21)
        Me.tax_kd.TabIndex = 51
        Me.tax_kd.Title = "계산서구분"
        '
        'FAC500
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAC500"
        Me.Size = New System.Drawing.Size(864, 628)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents chk As Frame7.eCheck
    Friend WithEvents btn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents tax_kd As Frame7.eCombo
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents end_yn As Frame7.eCheck
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tax_year As Frame7.eDate
    Friend WithEvents mon_bc As Frame7.eCombo
    Friend WithEvents desc As System.Windows.Forms.Label
    Friend WithEvents desc2 As System.Windows.Forms.Label
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chk7 As Frame7.eCheck
    Friend WithEvents chk6 As Frame7.eCheck
    Friend WithEvents chk5 As Frame7.eCheck
    Friend WithEvents chk4 As Frame7.eCheck
    Friend WithEvents chk3 As Frame7.eCheck
    Friend WithEvents chk2 As Frame7.eCheck
    Friend WithEvents chk1 As Frame7.eCheck
    Friend WithEvents tax_dtf As Frame7.eDate
    Friend WithEvents work_dt As Frame7.eDate
    Friend WithEvents tax_dtt As Frame7.eDate
    Friend WithEvents chk8 As Frame7.eCheck
    Friend WithEvents chk9 As Frame7.eCheck
    Friend WithEvents chk0 As Frame7.eCheck

End Class
