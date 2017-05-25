<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_JA1166
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
        Me.ep_head = New Frame7.ePanel()
        Me.fr_dt = New Frame7.eDate()
        Me.to_dt = New Frame7.eDate()
        Me.FWH_CD = New Frame7.eCombo()
        Me.ps_nm = New Frame7.eText()
        Me.print = New System.Windows.Forms.Button()
        Me.ps_cd = New Frame7.eText()
        Me.TWH_CD = New Frame7.eCombo()
        Me.ip_dt = New Frame7.eDate()
        Me.g_body = New Frame7.eGrid()
        Me.LOT_auto = New Frame7.eCheck()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ep_head.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        Me.spc_1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.ep_head)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.g_body)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 108
        Me.spc_1.TabIndex = 3
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.LOT_auto)
        Me.ep_head.Controls.Add(Me.fr_dt)
        Me.ep_head.Controls.Add(Me.to_dt)
        Me.ep_head.Controls.Add(Me.FWH_CD)
        Me.ep_head.Controls.Add(Me.ps_nm)
        Me.ep_head.Controls.Add(Me.print)
        Me.ep_head.Controls.Add(Me.ps_cd)
        Me.ep_head.Controls.Add(Me.TWH_CD)
        Me.ep_head.Controls.Add(Me.ip_dt)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(1182, 108)
        Me.ep_head.TabIndex = 2
        Me.ep_head.Text = "     생산외주실적등록"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(18, 38)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(159, 21)
        Me.fr_dt.TabIndex = 52
        Me.fr_dt.Title = "시작일"
        Me.fr_dt.TitleWidth = 60
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(18, 65)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(159, 21)
        Me.to_dt.TabIndex = 130
        Me.to_dt.Title = "종료일"
        Me.to_dt.TitleWidth = 60
        '
        'FWH_CD
        '
        Me.FWH_CD.Location = New System.Drawing.Point(183, 38)
        Me.FWH_CD.Name = "FWH_CD"
        Me.FWH_CD.Size = New System.Drawing.Size(203, 21)
        Me.FWH_CD.TabIndex = 124
        Me.FWH_CD.Title = "출고창고"
        Me.FWH_CD.TitleWidth = 85
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "pl_nm"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(569, 38)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(76, 21)
        Me.ps_nm.TabIndex = 130
        Me.ps_nm.TableName = "pl_nm"
        Me.ps_nm.Title = "부서"
        Me.ps_nm.TitleWidth = 0
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(670, 38)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(126, 48)
        Me.print.TabIndex = 134
        Me.print.Text = "출력 "
        Me.print.UseVisualStyleBackColor = True
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "ps_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(402, 38)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(163, 21)
        Me.ps_cd.TabIndex = 129
        Me.ps_cd.TableName = "ps_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 90
        '
        'TWH_CD
        '
        Me.TWH_CD.Location = New System.Drawing.Point(183, 65)
        Me.TWH_CD.Name = "TWH_CD"
        Me.TWH_CD.Size = New System.Drawing.Size(203, 21)
        Me.TWH_CD.TabIndex = 132
        Me.TWH_CD.Title = "입고창고"
        Me.TWH_CD.TitleWidth = 85
        '
        'ip_dt
        '
        Me.ip_dt.ColumnName = "plan_dt"
        Me.ip_dt.Location = New System.Drawing.Point(402, 65)
        Me.ip_dt.Name = "ip_dt"
        Me.ip_dt.Size = New System.Drawing.Size(243, 21)
        Me.ip_dt.TabIndex = 133
        Me.ip_dt.TableName = "plan_dt"
        Me.ip_dt.Title = "외주입고일자"
        Me.ip_dt.TitleWidth = 90
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(1182, 499)
        Me.g_body.TabIndex = 1
        Me.g_body.TabStop = False
        '
        'LOT_auto
        '
        Me.LOT_auto.Caption = ""
        Me.LOT_auto.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LOT_auto.Location = New System.Drawing.Point(814, 38)
        Me.LOT_auto.Name = "LOT_auto"
        Me.LOT_auto.Size = New System.Drawing.Size(119, 21)
        Me.LOT_auto.TabIndex = 126
        Me.LOT_auto.Title = "LOT 자동입력"
        Me.LOT_auto.TitleWidth = 85
        '
        'WI_JA1166
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_JA1166"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents g_body As Frame7.eGrid
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TWH_CD As Frame7.eCombo
    Friend WithEvents FWH_CD As Frame7.eCombo
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents ip_dt As Frame7.eDate
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents LOT_auto As Frame7.eCheck

End Class
