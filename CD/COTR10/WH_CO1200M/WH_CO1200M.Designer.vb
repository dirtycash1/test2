<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WH_CO1200M
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_exit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ok = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_search = New Frame7.eText()
        Me.g_multi = New Frame7.eGrid()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        Me.spc_1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.EPanel1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.g_multi)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 118
        Me.spc_1.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_cancel)
        Me.EPanel1.Controls.Add(Me.btn_exit)
        Me.EPanel1.Controls.Add(Me.btn_find)
        Me.EPanel1.Controls.Add(Me.find_search)
        Me.EPanel1.Controls.Add(Me.btn_ok)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 118)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(697, 26)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 24)
        Me.btn_cancel.TabIndex = 75
        Me.btn_cancel.Text = "취   소"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(697, 55)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(72, 24)
        Me.btn_exit.TabIndex = 74
        Me.btn_exit.Text = "종   료"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(610, 56)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(72, 24)
        Me.btn_ok.TabIndex = 73
        Me.btn_ok.Text = "선   택"
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(610, 26)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(72, 24)
        Me.btn_find.TabIndex = 72
        Me.btn_find.Text = "검   색"
        '
        'find_search
        '
        Me.find_search.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_search.Location = New System.Drawing.Point(43, 39)
        Me.find_search.Name = "find_search"
        Me.find_search.Size = New System.Drawing.Size(460, 21)
        Me.find_search.TabIndex = 2
        Me.find_search.Title = "검색 조건"
        Me.find_search.TitleWidth = 98
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 489)
        Me.g_multi.TabIndex = 0
        '
        'WH_CO1200M
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WH_CO1200M"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents find_search As Frame7.eText
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton

End Class
