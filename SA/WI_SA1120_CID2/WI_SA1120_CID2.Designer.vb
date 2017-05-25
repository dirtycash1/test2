<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1120_CID2
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.listBox_TX = New System.Windows.Forms.ListBox()
        Me.checkBox_ack = New System.Windows.Forms.CheckBox()
        Me.toolButton = New System.Windows.Forms.Button()
        Me.toollabel = New System.Windows.Forms.Label()
        Me.toolcom = New System.Windows.Forms.ComboBox()
        Me.listBox_RX = New System.Windows.Forms.ListBox()
        Me.tButton = New System.Windows.Forms.Button()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.text1 = New Frame7.eText()
        Me.text2 = New Frame7.eText()
        Me.text3 = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(935, 565)
        Me.SplitContainer1.SplitterDistance = 103
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.text3)
        Me.EPanel1.Controls.Add(Me.text2)
        Me.EPanel1.Controls.Add(Me.text1)
        Me.EPanel1.Controls.Add(Me.listBox_TX)
        Me.EPanel1.Controls.Add(Me.checkBox_ack)
        Me.EPanel1.Controls.Add(Me.toolButton)
        Me.EPanel1.Controls.Add(Me.toollabel)
        Me.EPanel1.Controls.Add(Me.toolcom)
        Me.EPanel1.Controls.Add(Me.listBox_RX)
        Me.EPanel1.Controls.Add(Me.tButton)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(935, 103)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     CID 연결"
        '
        'listBox_TX
        '
        Me.listBox_TX.FormattingEnabled = True
        Me.listBox_TX.ItemHeight = 12
        Me.listBox_TX.Location = New System.Drawing.Point(536, 15)
        Me.listBox_TX.Name = "listBox_TX"
        Me.listBox_TX.Size = New System.Drawing.Size(102, 28)
        Me.listBox_TX.TabIndex = 16
        Me.listBox_TX.Visible = False
        '
        'checkBox_ack
        '
        Me.checkBox_ack.AutoSize = True
        Me.checkBox_ack.Location = New System.Drawing.Point(644, 59)
        Me.checkBox_ack.Name = "checkBox_ack"
        Me.checkBox_ack.Size = New System.Drawing.Size(70, 18)
        Me.checkBox_ack.TabIndex = 15
        Me.checkBox_ack.Text = "Ack전송"
        Me.checkBox_ack.UseVisualStyleBackColor = True
        Me.checkBox_ack.Visible = False
        '
        'toolButton
        '
        Me.toolButton.Location = New System.Drawing.Point(363, 36)
        Me.toolButton.Name = "toolButton"
        Me.toolButton.Size = New System.Drawing.Size(91, 34)
        Me.toolButton.TabIndex = 19
        Me.toolButton.Text = "장비확인"
        Me.toolButton.UseVisualStyleBackColor = True
        Me.toolButton.Visible = False
        '
        'toollabel
        '
        Me.toollabel.AutoSize = True
        Me.toollabel.Location = New System.Drawing.Point(460, 56)
        Me.toollabel.Name = "toollabel"
        Me.toollabel.Size = New System.Drawing.Size(55, 14)
        Me.toollabel.TabIndex = 17
        Me.toollabel.Text = "장비정보"
        Me.toollabel.Visible = False
        '
        'toolcom
        '
        Me.toolcom.FormattingEnabled = True
        Me.toolcom.Location = New System.Drawing.Point(28, 48)
        Me.toolcom.Name = "toolcom"
        Me.toolcom.Size = New System.Drawing.Size(143, 20)
        Me.toolcom.TabIndex = 18
        '
        'listBox_RX
        '
        Me.listBox_RX.FormattingEnabled = True
        Me.listBox_RX.ItemHeight = 12
        Me.listBox_RX.Location = New System.Drawing.Point(536, 49)
        Me.listBox_RX.Name = "listBox_RX"
        Me.listBox_RX.Size = New System.Drawing.Size(102, 28)
        Me.listBox_RX.TabIndex = 14
        '
        'tButton
        '
        Me.tButton.Location = New System.Drawing.Point(195, 33)
        Me.tButton.Name = "tButton"
        Me.tButton.Size = New System.Drawing.Size(102, 51)
        Me.tButton.TabIndex = 20
        Me.tButton.Text = "포트열기"
        Me.tButton.UseVisualStyleBackColor = True
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(935, 458)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     발신정보표시"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(931, 433)
        Me.g10.TabIndex = 20
        '
        'text1
        '
        Me.text1.ColumnName = "find_paymentterm_nm"
        Me.text1.Location = New System.Drawing.Point(756, 26)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(163, 21)
        Me.text1.TabIndex = 62
        Me.text1.TableName = "find_paymentterm_nm"
        Me.text1.Title = "통신연결I "
        Me.text1.TitleWidth = 70
        '
        'text2
        '
        Me.text2.ColumnName = "find_paymentterm_nm"
        Me.text2.Location = New System.Drawing.Point(756, 49)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(163, 21)
        Me.text2.TabIndex = 63
        Me.text2.TableName = "find_paymentterm_nm"
        Me.text2.Title = "전화받음S"
        Me.text2.TitleWidth = 70
        '
        'text3
        '
        Me.text3.ColumnName = "find_paymentterm_nm"
        Me.text3.Location = New System.Drawing.Point(756, 73)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(163, 21)
        Me.text3.TabIndex = 64
        Me.text3.TableName = "find_paymentterm_nm"
        Me.text3.Title = "타인 A"
        Me.text3.TitleWidth = 70
        '
        'WI_SA1120_CID2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1120_CID2"
        Me.Size = New System.Drawing.Size(935, 565)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Private WithEvents toolcom As System.Windows.Forms.ComboBox
    Private WithEvents listBox_TX As System.Windows.Forms.ListBox
    Private WithEvents checkBox_ack As System.Windows.Forms.CheckBox
    Private WithEvents toolButton As System.Windows.Forms.Button
    Private WithEvents toollabel As System.Windows.Forms.Label
    Friend WithEvents g10 As Frame7.eGrid
    Private WithEvents listBox_RX As System.Windows.Forms.ListBox
    Friend WithEvents EPanel2 As Frame7.ePanel
    Private WithEvents tButton As System.Windows.Forms.Button
    Friend WithEvents text2 As Frame7.eText
    Friend WithEvents text1 As Frame7.eText
    Friend WithEvents text3 As Frame7.eText

End Class
