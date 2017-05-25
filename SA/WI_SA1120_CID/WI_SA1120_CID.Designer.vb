<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1120_CID
    Inherits Base7.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.listBox_TX = New System.Windows.Forms.ListBox()
        Me.checkBox_ack = New System.Windows.Forms.CheckBox()
        Me.toolButton = New System.Windows.Forms.Button()
        Me.toolcom = New System.Windows.Forms.ComboBox()
        Me.g10 = New Frame7.eGrid()
        Me.listBox_RX = New System.Windows.Forms.ListBox()
        Me.tButton = New System.Windows.Forms.Button()
        Me.toollabel = New System.Windows.Forms.Label()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.listBox_TX)
        Me.EPanel1.Controls.Add(Me.checkBox_ack)
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Controls.Add(Me.listBox_RX)
        Me.EPanel1.Controls.Add(Me.toolButton)
        Me.EPanel1.Controls.Add(Me.toolcom)
        Me.EPanel1.Controls.Add(Me.tButton)
        Me.EPanel1.Controls.Add(Me.toollabel)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(935, 565)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     CID 연결설정"
        '
        'listBox_TX
        '
        Me.listBox_TX.FormattingEnabled = True
        Me.listBox_TX.ItemHeight = 12
        Me.listBox_TX.Location = New System.Drawing.Point(18, 412)
        Me.listBox_TX.Name = "listBox_TX"
        Me.listBox_TX.Size = New System.Drawing.Size(516, 88)
        Me.listBox_TX.TabIndex = 8
        Me.listBox_TX.Visible = False
        '
        'checkBox_ack
        '
        Me.checkBox_ack.AutoSize = True
        Me.checkBox_ack.Location = New System.Drawing.Point(464, 388)
        Me.checkBox_ack.Name = "checkBox_ack"
        Me.checkBox_ack.Size = New System.Drawing.Size(70, 18)
        Me.checkBox_ack.TabIndex = 7
        Me.checkBox_ack.Text = "Ack전송"
        Me.checkBox_ack.UseVisualStyleBackColor = True
        Me.checkBox_ack.Visible = False
        '
        'toolButton
        '
        Me.toolButton.Location = New System.Drawing.Point(630, 140)
        Me.toolButton.Name = "toolButton"
        Me.toolButton.Size = New System.Drawing.Size(104, 34)
        Me.toolButton.TabIndex = 11
        Me.toolButton.Text = "장비확인"
        Me.toolButton.UseVisualStyleBackColor = True
        '
        'toolcom
        '
        Me.toolcom.FormattingEnabled = True
        Me.toolcom.Location = New System.Drawing.Point(630, 106)
        Me.toolcom.Name = "toolcom"
        Me.toolcom.Size = New System.Drawing.Size(216, 20)
        Me.toolcom.TabIndex = 10
        '
        'g10
        '
        Me.g10.Location = New System.Drawing.Point(18, 36)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(606, 224)
        Me.g10.TabIndex = 12
        '
        'listBox_RX
        '
        Me.listBox_RX.FormattingEnabled = True
        Me.listBox_RX.ItemHeight = 12
        Me.listBox_RX.Location = New System.Drawing.Point(18, 294)
        Me.listBox_RX.Name = "listBox_RX"
        Me.listBox_RX.Size = New System.Drawing.Size(516, 88)
        Me.listBox_RX.TabIndex = 6
        Me.listBox_RX.Visible = False
        '
        'tButton
        '
        Me.tButton.Location = New System.Drawing.Point(630, 36)
        Me.tButton.Name = "tButton"
        Me.tButton.Size = New System.Drawing.Size(104, 64)
        Me.tButton.TabIndex = 4
        Me.tButton.Text = "포트열기"
        Me.tButton.UseVisualStyleBackColor = True
        '
        'toollabel
        '
        Me.toollabel.AutoSize = True
        Me.toollabel.Location = New System.Drawing.Point(630, 190)
        Me.toollabel.Name = "toollabel"
        Me.toollabel.Size = New System.Drawing.Size(55, 14)
        Me.toollabel.TabIndex = 9
        Me.toollabel.Text = "장비정보"
        '
        'WI_SA1120_CID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "WI_SA1120_CID"
        Me.Size = New System.Drawing.Size(935, 565)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Private WithEvents listBox_TX As System.Windows.Forms.ListBox
    Private WithEvents checkBox_ack As System.Windows.Forms.CheckBox
    Private WithEvents listBox_RX As System.Windows.Forms.ListBox
    Private WithEvents tButton As System.Windows.Forms.Button
    Private WithEvents toollabel As System.Windows.Forms.Label
    Private WithEvents toolcom As System.Windows.Forms.ComboBox
    Private WithEvents toolButton As System.Windows.Forms.Button
    Friend WithEvents g10 As Frame7.eGrid

End Class
