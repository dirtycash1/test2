<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_KU2190
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
        Me.EText15 = New Frame7.eText()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EText14 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText7 = New Frame7.eText()
        Me.EText5 = New Frame7.eText()
        Me.EText6 = New Frame7.eText()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EText1 = New Frame7.eText()
        Me.ECheck1 = New Frame7.eCheck()
        Me.EDate1 = New Frame7.eDate()
        Me.EText2 = New Frame7.eText()
        Me.ECombo1 = New Frame7.eCombo()
        Me.EText3 = New Frame7.eText()
        Me.EText8 = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 558)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.EText8)
        Me.EPanel1.Controls.Add(Me.EText3)
        Me.EPanel1.Controls.Add(Me.ECombo1)
        Me.EPanel1.Controls.Add(Me.EText2)
        Me.EPanel1.Controls.Add(Me.EText15)
        Me.EPanel1.Controls.Add(Me.ECheck1)
        Me.EPanel1.Controls.Add(Me.EText14)
        Me.EPanel1.Controls.Add(Me.Label3)
        Me.EPanel1.Controls.Add(Me.EText4)
        Me.EPanel1.Controls.Add(Me.EText7)
        Me.EPanel1.Controls.Add(Me.EText5)
        Me.EPanel1.Controls.Add(Me.EText6)
        Me.EPanel1.Controls.Add(Me.Label2)
        Me.EPanel1.Controls.Add(Me.EText1)
        Me.EPanel1.Controls.Add(Me.EDate1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(947, 152)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     수입지급등록"
        '
        'EText15
        '
        Me.EText15.ColumnName = "find_paymenterm_cd"
        Me.EText15.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText15.Location = New System.Drawing.Point(334, 95)
        Me.EText15.Name = "EText15"
        Me.EText15.Size = New System.Drawing.Size(203, 21)
        Me.EText15.TabIndex = 82
        Me.EText15.TableName = "find_paymenterm_cd"
        Me.EText15.Title = "지급금액"
        Me.EText15.TitleWidth = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(661, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "결의전표보기"
        '
        'EText14
        '
        Me.EText14.ColumnName = "find_paymenterm_cd"
        Me.EText14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText14.Location = New System.Drawing.Point(560, 122)
        Me.EText14.Name = "EText14"
        Me.EText14.Size = New System.Drawing.Size(182, 21)
        Me.EText14.TabIndex = 80
        Me.EText14.TableName = "find_paymenterm_cd"
        Me.EText14.Title = "결의번호"
        Me.EText14.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymenterm_cd"
        Me.EText4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText4.Location = New System.Drawing.Point(19, 68)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(281, 21)
        Me.EText4.TabIndex = 75
        Me.EText4.TableName = "find_paymenterm_cd"
        Me.EText4.Title = "거래처"
        Me.EText4.TitleWidth = 98
        '
        'EText7
        '
        Me.EText7.ColumnName = "find_stts"
        Me.EText7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText7.Location = New System.Drawing.Point(489, 41)
        Me.EText7.Name = "EText7"
        Me.EText7.Size = New System.Drawing.Size(85, 21)
        Me.EText7.TabIndex = 64
        Me.EText7.TableName = "find_stts"
        Me.EText7.Title = "비 고"
        Me.EText7.TitleWidth = 0
        '
        'EText5
        '
        Me.EText5.ColumnName = "find_paymenterm_cd"
        Me.EText5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText5.Location = New System.Drawing.Point(226, 41)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(182, 21)
        Me.EText5.TabIndex = 63
        Me.EText5.TableName = "find_paymenterm_cd"
        Me.EText5.Title = "담당자"
        Me.EText5.TitleWidth = 98
        '
        'EText6
        '
        Me.EText6.ColumnName = "find_stts"
        Me.EText6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText6.Location = New System.Drawing.Point(409, 41)
        Me.EText6.Name = "EText6"
        Me.EText6.Size = New System.Drawing.Size(79, 21)
        Me.EText6.TabIndex = 62
        Me.EText6.TableName = "find_stts"
        Me.EText6.Title = "비 고"
        Me.EText6.TitleWidth = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(893, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 14)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "W"
        '
        'EText1
        '
        Me.EText1.ColumnName = "find_paymenterm_cd"
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(19, 41)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(200, 21)
        Me.EText1.TabIndex = 5
        Me.EText1.TableName = "find_paymenterm_cd"
        Me.EText1.Title = "전표번호"
        Me.EText1.TitleWidth = 98
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck1.Location = New System.Drawing.Point(622, 41)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(89, 21)
        Me.ECheck1.TabIndex = 84
        Me.ECheck1.Title = "완료"
        Me.ECheck1.TitleWidth = 60
        '
        'EDate1
        '
        Me.EDate1.Location = New System.Drawing.Point(728, 41)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(203, 21)
        Me.EDate1.TabIndex = 21
        Me.EDate1.Title = "지급일자"
        Me.EDate1.TitleWidth = 98
        '
        'EText2
        '
        Me.EText2.ColumnName = "find_stts"
        Me.EText2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText2.Location = New System.Drawing.Point(743, 122)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(79, 21)
        Me.EText2.TabIndex = 85
        Me.EText2.TableName = "find_stts"
        Me.EText2.Title = "비 고"
        Me.EText2.TitleWidth = 0
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(334, 68)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(184, 21)
        Me.ECombo1.TabIndex = 86
        Me.ECombo1.Title = "화폐"
        Me.ECombo1.TitleWidth = 98
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText3.Location = New System.Drawing.Point(560, 68)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(171, 21)
        Me.EText3.TabIndex = 87
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "환율"
        Me.EText3.TitleWidth = 98
        '
        'EText8
        '
        Me.EText8.ColumnName = "find_paymenterm_cd"
        Me.EText8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText8.Location = New System.Drawing.Point(334, 122)
        Me.EText8.Name = "EText8"
        Me.EText8.Size = New System.Drawing.Size(203, 21)
        Me.EText8.TabIndex = 88
        Me.EText8.TableName = "find_paymenterm_cd"
        Me.EText8.Title = "원화총금액"
        Me.EText8.TitleWidth = 98
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer2.Size = New System.Drawing.Size(947, 402)
        Me.SplitContainer2.SplitterDistance = 91
        Me.SplitContainer2.TabIndex = 0
        '
        'WI_KU2190
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_KU2190"
        Me.Size = New System.Drawing.Size(947, 558)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EText7 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText14 As Frame7.eText
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EText15 As Frame7.eText
    Friend WithEvents ECheck1 As Frame7.eCheck
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents EText8 As Frame7.eText
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer

End Class
