<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1000
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.stts = New Frame7.eText()
        Me.btn_confirm = New DevExpress.XtraEditors.SimpleButton()
        Me.od_cldt = New Frame7.eDate()
        Me.btn_deconfirm = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_deconfirm)
        Me.EPanel1.Controls.Add(Me.stts)
        Me.EPanel1.Controls.Add(Me.btn_confirm)
        Me.EPanel1.Controls.Add(Me.od_cldt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 611)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     수주 일마감"
        '
        'stts
        '
        Me.stts.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.stts.Location = New System.Drawing.Point(102, 106)
        Me.stts.Name = "stts"
        Me.stts.Size = New System.Drawing.Size(240, 21)
        Me.stts.TabIndex = 210
        Me.stts.TitleWidth = 0
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(102, 142)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(104, 40)
        Me.btn_confirm.TabIndex = 209
        Me.btn_confirm.Text = "마감"
        '
        'od_cldt
        '
        Me.od_cldt.Location = New System.Drawing.Point(102, 72)
        Me.od_cldt.Name = "od_cldt"
        Me.od_cldt.Size = New System.Drawing.Size(240, 21)
        Me.od_cldt.TabIndex = 2
        Me.od_cldt.Title = "마감일"
        '
        'btn_deconfirm
        '
        Me.btn_deconfirm.Location = New System.Drawing.Point(238, 142)
        Me.btn_deconfirm.Name = "btn_deconfirm"
        Me.btn_deconfirm.Size = New System.Drawing.Size(104, 40)
        Me.btn_deconfirm.TabIndex = 211
        Me.btn_deconfirm.Text = "마감취소"
        '
        'WI_SA1000
        '
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "WI_SA1000"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents od_cldt As Frame7.eDate
    Friend WithEvents btn_confirm As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stts As Frame7.eText
    Friend WithEvents btn_deconfirm As DevExpress.XtraEditors.SimpleButton

End Class
