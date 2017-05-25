<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1200A
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
        Me.r_model_no = New Frame7.eText()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_search = New DevExpress.XtraEditors.SimpleButton()
        Me.r_nm_nm = New Frame7.eText()
        Me.r_nm_cd = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g_multi = New Frame7.eGrid()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g_result = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 108
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.r_model_no)
        Me.EPanel1.Controls.Add(Me.btn_create)
        Me.EPanel1.Controls.Add(Me.btn_search)
        Me.EPanel1.Controls.Add(Me.r_nm_nm)
        Me.EPanel1.Controls.Add(Me.r_nm_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 108)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     "
        '
        'r_model_no
        '
        Me.r_model_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_model_no.Location = New System.Drawing.Point(37, 55)
        Me.r_model_no.Name = "r_model_no"
        Me.r_model_no.Size = New System.Drawing.Size(240, 21)
        Me.r_model_no.TabIndex = 1
        Me.r_model_no.Title = "제품군"
        Me.r_model_no.TitleWidth = 98
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(742, 55)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(113, 31)
        Me.btn_create.TabIndex = 4
        Me.btn_create.Text = "품목코드 생성"
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(606, 55)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(81, 31)
        Me.btn_search.TabIndex = 3
        Me.btn_search.Text = "조   회"
        '
        'r_nm_nm
        '
        Me.r_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_nm_nm.Location = New System.Drawing.Point(283, 28)
        Me.r_nm_nm.Name = "r_nm_nm"
        Me.r_nm_nm.Size = New System.Drawing.Size(240, 21)
        Me.r_nm_nm.TabIndex = 76
        Me.r_nm_nm.Title = "제품명"
        Me.r_nm_nm.TitleWidth = 0
        '
        'r_nm_cd
        '
        Me.r_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.r_nm_cd.Location = New System.Drawing.Point(37, 28)
        Me.r_nm_cd.Name = "r_nm_cd"
        Me.r_nm_cd.Size = New System.Drawing.Size(240, 21)
        Me.r_nm_cd.TabIndex = 0
        Me.r_nm_cd.Title = "제품명코드"
        Me.r_nm_cd.TitleWidth = 98
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1182, 499)
        Me.SplitContainer2.SplitterDistance = 294
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g_list)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(294, 499)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     Spec 리스트"
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(2, 23)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(290, 474)
        Me.g_list.TabIndex = 1
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel4)
        Me.SplitContainer3.Size = New System.Drawing.Size(884, 499)
        Me.SplitContainer3.SplitterDistance = 166
        Me.SplitContainer3.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g_multi)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(884, 166)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     품목 생성 구간 설정"
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(2, 23)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(880, 141)
        Me.g_multi.TabIndex = 2
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g_result)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(884, 329)
        Me.EPanel4.TabIndex = 0
        Me.EPanel4.Text = "     품목정보 리스트"
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(2, 23)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(880, 304)
        Me.g_result.TabIndex = 2
        '
        'WI_CO1200A
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_CO1200A"
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
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_search As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents r_nm_nm As Frame7.eText
    Friend WithEvents r_nm_cd As Frame7.eText
    Friend WithEvents r_model_no As Frame7.eText

End Class
