<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAA110
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
        Me.pay_mon = New Frame7.eDate()
        Me.app_work = New DevExpress.XtraEditors.SimpleButton()
        Me.del_work = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.pay_sq = New Frame7.eCombo()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(919, 519)
        Me.SplitContainer1.SplitterDistance = 79
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.pay_mon)
        Me.EPanel1.Controls.Add(Me.pay_sq)
        Me.EPanel1.Controls.Add(Me.del_work)
        Me.EPanel1.Controls.Add(Me.app_work)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(919, 79)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'pay_mon
        '
        Me.pay_mon.Location = New System.Drawing.Point(20, 28)
        Me.pay_mon.Name = "pay_mon"
        Me.pay_mon.Size = New System.Drawing.Size(240, 21)
        Me.pay_mon.TabIndex = 3
        Me.pay_mon.Title = "지급월"
        '
        'app_work
        '
        Me.app_work.Location = New System.Drawing.Point(301, 29)
        Me.app_work.Name = "app_work"
        Me.app_work.Size = New System.Drawing.Size(112, 44)
        Me.app_work.TabIndex = 8
        Me.app_work.Text = "급/상여 마감"
        '
        'del_work
        '
        Me.del_work.Location = New System.Drawing.Point(421, 29)
        Me.del_work.Name = "del_work"
        Me.del_work.Size = New System.Drawing.Size(112, 44)
        Me.del_work.TabIndex = 9
        Me.del_work.Text = "마감 취소"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(919, 436)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     마감 대상 현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(915, 411)
        Me.g10.TabIndex = 2
        '
        'pay_sq
        '
        Me.pay_sq.Location = New System.Drawing.Point(20, 52)
        Me.pay_sq.Name = "pay_sq"
        Me.pay_sq.Size = New System.Drawing.Size(240, 21)
        Me.pay_sq.TabIndex = 4
        Me.pay_sq.Title = "급여유형"
        '
        'PAA110
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PAA110"
        Me.Size = New System.Drawing.Size(919, 519)
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
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents pay_mon As Frame7.eDate
    Friend WithEvents del_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents app_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pay_sq As Frame7.eCombo

End Class
