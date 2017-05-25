<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1307_DRY
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
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.mate_no = New Frame7.eText()
        Me.fa_cd = New Frame7.eCombo()
        Me.sa_cd = New Frame7.eCombo()
        Me.mv_dt = New Frame7.eDate()
        Me.ps_cd = New Frame7.eText()
        Me.mv_no = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.pl_cd = New Frame7.eText()
        Me.gd_nm = New Frame7.eText()
        Me.from_dt = New Frame7.eDate()
        Me.lot_no = New Frame7.eText()
        Me.chk_all = New Frame7.eCheck()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_list = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        Me.spc_1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.EPanel2)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.EPanel3)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 90
        Me.spc_1.TabIndex = 4
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.mate_no)
        Me.EPanel2.Controls.Add(Me.fa_cd)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.mv_dt)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.mv_no)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Controls.Add(Me.to_dt)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.gd_nm)
        Me.EPanel2.Controls.Add(Me.from_dt)
        Me.EPanel2.Controls.Add(Me.lot_no)
        Me.EPanel2.Controls.Add(Me.chk_all)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 90)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     [DRY전면] 생산입고등록(일괄)"
        '
        'mate_no
        '
        Me.mate_no.Location = New System.Drawing.Point(879, 60)
        Me.mate_no.Name = "mate_no"
        Me.mate_no.Size = New System.Drawing.Size(169, 21)
        Me.mate_no.TabIndex = 217
        Me.mate_no.Title = "LOT NO."
        Me.mate_no.TitleWidth = 60
        '
        'fa_cd
        '
        Me.fa_cd.Location = New System.Drawing.Point(111, 58)
        Me.fa_cd.Name = "fa_cd"
        Me.fa_cd.Size = New System.Drawing.Size(141, 21)
        Me.fa_cd.TabIndex = 215
        Me.fa_cd.Title = "공장구분"
        Me.fa_cd.TitleWidth = 60
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(594, 58)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(246, 21)
        Me.sa_cd.TabIndex = 214
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 60
        '
        'mv_dt
        '
        Me.mv_dt.Location = New System.Drawing.Point(879, 33)
        Me.mv_dt.Name = "mv_dt"
        Me.mv_dt.Size = New System.Drawing.Size(169, 21)
        Me.mv_dt.TabIndex = 198
        Me.mv_dt.Title = "입고일자"
        Me.mv_dt.TitleWidth = 60
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Location = New System.Drawing.Point(594, 33)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(140, 21)
        Me.ps_cd.TabIndex = 197
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 60
        '
        'mv_no
        '
        Me.mv_no.Location = New System.Drawing.Point(1054, 33)
        Me.mv_no.Name = "mv_no"
        Me.mv_no.Size = New System.Drawing.Size(188, 21)
        Me.mv_no.TabIndex = 216
        Me.mv_no.Title = "품명"
        Me.mv_no.TitleWidth = 80
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "ps_nm"
        Me.ps_nm.Location = New System.Drawing.Point(736, 33)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 196
        Me.ps_nm.TableName = "ps_nm"
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(141, 33)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(111, 21)
        Me.to_dt.TabIndex = 194
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 10
        '
        'pl_cd
        '
        Me.pl_cd.Location = New System.Drawing.Point(12, 115)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(240, 21)
        Me.pl_cd.TabIndex = 212
        Me.pl_cd.Title = "부서코드"
        '
        'gd_nm
        '
        Me.gd_nm.Location = New System.Drawing.Point(325, 33)
        Me.gd_nm.Name = "gd_nm"
        Me.gd_nm.Size = New System.Drawing.Size(252, 21)
        Me.gd_nm.TabIndex = 211
        Me.gd_nm.Title = "품명"
        Me.gd_nm.TitleWidth = 120
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(8, 33)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(129, 21)
        Me.from_dt.TabIndex = 193
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 30
        '
        'lot_no
        '
        Me.lot_no.Location = New System.Drawing.Point(325, 58)
        Me.lot_no.Name = "lot_no"
        Me.lot_no.Size = New System.Drawing.Size(252, 21)
        Me.lot_no.TabIndex = 199
        Me.lot_no.Title = "CHECK SHEET NO."
        Me.lot_no.TitleWidth = 120
        '
        'chk_all
        '
        Me.chk_all.Caption = ""
        Me.chk_all.Location = New System.Drawing.Point(8, 58)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(85, 21)
        Me.chk_all.TabIndex = 210
        Me.chk_all.Title = "전체선택"
        Me.chk_all.TitleWidth = 60
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_list)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1182, 517)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     "
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(2, 23)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(1178, 492)
        Me.g_list.TabIndex = 2
        '
        'WI_PR1307_DRY
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_PR1307_DRY"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents from_dt As Frame7.eDate
    Friend WithEvents mv_dt As Frame7.eDate
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents lot_no As Frame7.eText
    Friend WithEvents chk_all As Frame7.eCheck
    Friend WithEvents gd_nm As Frame7.eText
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents fa_cd As Frame7.eCombo
    Friend WithEvents mv_no As Frame7.eText
    Friend WithEvents mate_no As Frame7.eText

End Class
