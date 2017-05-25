<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1137
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
        Me.job_no = New Frame7.eText()
        Me.btn_chk = New DevExpress.XtraEditors.SimpleButton()
        Me.find_cs_nm = New Frame7.eText()
        Me.find_cs_cd = New Frame7.eText()
        Me.find_sa_cd = New Frame7.eCombo()
        Me.find_wh_cd = New Frame7.eCombo()
        Me.find_gd_cd = New Frame7.eText()
        Me.g_result = New Frame7.eGrid()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_gd_nm = New Frame7.eText()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_result)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 97
        Me.SplitContainer1.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_gd_nm)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.job_no)
        Me.EPanel1.Controls.Add(Me.btn_chk)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.find_cs_cd)
        Me.EPanel1.Controls.Add(Me.find_sa_cd)
        Me.EPanel1.Controls.Add(Me.find_wh_cd)
        Me.EPanel1.Controls.Add(Me.find_gd_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 97)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'job_no
        '
        Me.job_no.ColumnName = "job_no"
        Me.job_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.job_no.Location = New System.Drawing.Point(855, 50)
        Me.job_no.Name = "job_no"
        Me.job_no.Size = New System.Drawing.Size(217, 21)
        Me.job_no.TabIndex = 113
        Me.job_no.TableName = "job_no"
        Me.job_no.Title = "CHECK_SHEET NO."
        Me.job_no.TitleWidth = 108
        '
        'btn_chk
        '
        Me.btn_chk.Location = New System.Drawing.Point(777, 35)
        Me.btn_chk.Name = "btn_chk"
        Me.btn_chk.Size = New System.Drawing.Size(72, 48)
        Me.btn_chk.TabIndex = 112
        Me.btn_chk.Text = "전체선택"
        '
        'find_cs_nm
        '
        Me.find_cs_nm.ColumnName = "job_no"
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(559, 35)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(193, 21)
        Me.find_cs_nm.TabIndex = 111
        Me.find_cs_nm.TableName = "job_no"
        Me.find_cs_nm.Title = "CHECK_SHEET NO."
        Me.find_cs_nm.TitleWidth = 0
        '
        'find_cs_cd
        '
        Me.find_cs_cd.ColumnName = "job_no"
        Me.find_cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_cd.Location = New System.Drawing.Point(393, 35)
        Me.find_cs_cd.Name = "find_cs_cd"
        Me.find_cs_cd.Size = New System.Drawing.Size(164, 21)
        Me.find_cs_cd.TabIndex = 110
        Me.find_cs_cd.TableName = "job_no"
        Me.find_cs_cd.Title = "거래처"
        Me.find_cs_cd.TitleWidth = 60
        '
        'find_sa_cd
        '
        Me.find_sa_cd.Location = New System.Drawing.Point(19, 62)
        Me.find_sa_cd.Name = "find_sa_cd"
        Me.find_sa_cd.Size = New System.Drawing.Size(159, 21)
        Me.find_sa_cd.TabIndex = 108
        Me.find_sa_cd.Title = "사업장"
        Me.find_sa_cd.TitleWidth = 60
        '
        'find_wh_cd
        '
        Me.find_wh_cd.Location = New System.Drawing.Point(196, 62)
        Me.find_wh_cd.Name = "find_wh_cd"
        Me.find_wh_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_wh_cd.TabIndex = 109
        Me.find_wh_cd.Title = "창고"
        Me.find_wh_cd.TitleWidth = 60
        '
        'find_gd_cd
        '
        Me.find_gd_cd.ColumnName = "job_no"
        Me.find_gd_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_cd.Location = New System.Drawing.Point(393, 62)
        Me.find_gd_cd.Name = "find_gd_cd"
        Me.find_gd_cd.Size = New System.Drawing.Size(164, 21)
        Me.find_gd_cd.TabIndex = 107
        Me.find_gd_cd.TableName = "job_no"
        Me.find_gd_cd.Title = "품목코드"
        Me.find_gd_cd.TitleWidth = 60
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(0, 0)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1182, 510)
        Me.g_result.TabIndex = 0
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(184, 35)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 115
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(19, 35)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 114
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_gd_nm
        '
        Me.find_gd_nm.ColumnName = "job_no"
        Me.find_gd_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_gd_nm.Location = New System.Drawing.Point(559, 62)
        Me.find_gd_nm.Name = "find_gd_nm"
        Me.find_gd_nm.Size = New System.Drawing.Size(193, 21)
        Me.find_gd_nm.TabIndex = 116
        Me.find_gd_nm.TableName = "job_no"
        Me.find_gd_nm.Title = "CHECK_SHEET NO."
        Me.find_gd_nm.TitleWidth = 0
        '
        'WI_PR1137
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_PR1137"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents job_no As Frame7.eText
    Friend WithEvents btn_chk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents find_cs_cd As Frame7.eText
    Friend WithEvents find_sa_cd As Frame7.eCombo
    Friend WithEvents find_wh_cd As Frame7.eCombo
    Friend WithEvents find_gd_cd As Frame7.eText
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_gd_nm As Frame7.eText

End Class
