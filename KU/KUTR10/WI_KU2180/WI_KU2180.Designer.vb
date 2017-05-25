<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_KU2180
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ECombo1 = New Frame7.eCombo()
        Me.EMemo1 = New Frame7.eMemo()
        Me.EText2 = New Frame7.eText()
        Me.EText8 = New Frame7.eText()
        Me.EText12 = New Frame7.eText()
        Me.EDate2 = New Frame7.eDate()
        Me.EText14 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.EText7 = New Frame7.eText()
        Me.EText5 = New Frame7.eText()
        Me.EText6 = New Frame7.eText()
        Me.EText1 = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.g_body = New Frame7.eGrid()
        Me.g_body1 = New Frame7.eGrid()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.g_list = New Frame7.eGrid()
        Me.spc_1 = New System.Windows.Forms.SplitContainer()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EText3 = New Frame7.eText()
        Me.ECombo9 = New Frame7.eCombo()
        Me.EDate1 = New Frame7.eDate()
        Me.EDate3 = New Frame7.eDate()
        Me.ECheck1 = New Frame7.eCheck()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ep_head.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ep_head)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(845, 611)
        Me.SplitContainer2.SplitterDistance = 156
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.Label3)
        Me.ep_head.Controls.Add(Me.ECombo1)
        Me.ep_head.Controls.Add(Me.EMemo1)
        Me.ep_head.Controls.Add(Me.EText2)
        Me.ep_head.Controls.Add(Me.EText8)
        Me.ep_head.Controls.Add(Me.EText12)
        Me.ep_head.Controls.Add(Me.EDate2)
        Me.ep_head.Controls.Add(Me.EText14)
        Me.ep_head.Controls.Add(Me.EText4)
        Me.ep_head.Controls.Add(Me.EText7)
        Me.ep_head.Controls.Add(Me.EText5)
        Me.ep_head.Controls.Add(Me.EText6)
        Me.ep_head.Controls.Add(Me.EText1)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(845, 156)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     선급금대체등록"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(614, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "회계전표보기"
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(221, 61)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(182, 21)
        Me.ECombo1.TabIndex = 85
        Me.ECombo1.Title = "화폐"
        Me.ECombo1.TitleWidth = 98
        '
        'EMemo1
        '
        Me.EMemo1.Location = New System.Drawing.Point(14, 88)
        Me.EMemo1.Name = "EMemo1"
        Me.EMemo1.Size = New System.Drawing.Size(389, 50)
        Me.EMemo1.TabIndex = 89
        Me.EMemo1.Title = "비고"
        Me.EMemo1.TitleWidth = 98
        '
        'EText2
        '
        Me.EText2.ColumnName = "find_stts"
        Me.EText2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText2.Location = New System.Drawing.Point(704, 117)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(79, 21)
        Me.EText2.TabIndex = 84
        Me.EText2.TableName = "find_stts"
        Me.EText2.Title = "비 고"
        Me.EText2.TitleWidth = 0
        '
        'EText8
        '
        Me.EText8.ColumnName = "find_paymenterm_cd"
        Me.EText8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText8.Location = New System.Drawing.Point(626, 61)
        Me.EText8.Name = "EText8"
        Me.EText8.Size = New System.Drawing.Size(200, 21)
        Me.EText8.TabIndex = 88
        Me.EText8.TableName = "find_paymenterm_cd"
        Me.EText8.Title = "원화금액"
        Me.EText8.TitleWidth = 98
        '
        'EText12
        '
        Me.EText12.ColumnName = "find_paymenterm_cd"
        Me.EText12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText12.Location = New System.Drawing.Point(409, 61)
        Me.EText12.Name = "EText12"
        Me.EText12.Size = New System.Drawing.Size(182, 21)
        Me.EText12.TabIndex = 82
        Me.EText12.TableName = "find_paymenterm_cd"
        Me.EText12.Title = "대체금액"
        Me.EText12.TitleWidth = 98
        '
        'EDate2
        '
        Me.EDate2.Location = New System.Drawing.Point(626, 34)
        Me.EDate2.Name = "EDate2"
        Me.EDate2.Size = New System.Drawing.Size(200, 21)
        Me.EDate2.TabIndex = 80
        Me.EDate2.Title = "대체일자"
        Me.EDate2.TitleWidth = 98
        '
        'EText14
        '
        Me.EText14.ColumnName = "find_paymenterm_cd"
        Me.EText14.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText14.Location = New System.Drawing.Point(511, 117)
        Me.EText14.Name = "EText14"
        Me.EText14.Size = New System.Drawing.Size(187, 21)
        Me.EText14.TabIndex = 83
        Me.EText14.TableName = "find_paymenterm_cd"
        Me.EText14.Title = "회계전표"
        Me.EText14.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymenterm_cd"
        Me.EText4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText4.Location = New System.Drawing.Point(14, 61)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(200, 21)
        Me.EText4.TabIndex = 76
        Me.EText4.TableName = "find_paymenterm_cd"
        Me.EText4.Title = "거래처"
        Me.EText4.TitleWidth = 98
        '
        'EText7
        '
        Me.EText7.ColumnName = "find_stts"
        Me.EText7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText7.Location = New System.Drawing.Point(484, 34)
        Me.EText7.Name = "EText7"
        Me.EText7.Size = New System.Drawing.Size(85, 21)
        Me.EText7.TabIndex = 68
        Me.EText7.TableName = "find_stts"
        Me.EText7.Title = "비 고"
        Me.EText7.TitleWidth = 0
        '
        'EText5
        '
        Me.EText5.ColumnName = "find_paymenterm_cd"
        Me.EText5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText5.Location = New System.Drawing.Point(221, 34)
        Me.EText5.Name = "EText5"
        Me.EText5.Size = New System.Drawing.Size(182, 21)
        Me.EText5.TabIndex = 67
        Me.EText5.TableName = "find_paymenterm_cd"
        Me.EText5.Title = "작성자"
        Me.EText5.TitleWidth = 98
        '
        'EText6
        '
        Me.EText6.ColumnName = "find_stts"
        Me.EText6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText6.Location = New System.Drawing.Point(404, 34)
        Me.EText6.Name = "EText6"
        Me.EText6.Size = New System.Drawing.Size(79, 21)
        Me.EText6.TabIndex = 66
        Me.EText6.TableName = "find_stts"
        Me.EText6.Title = "비 고"
        Me.EText6.TitleWidth = 0
        '
        'EText1
        '
        Me.EText1.ColumnName = "find_paymenterm_cd"
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(15, 34)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(200, 21)
        Me.EText1.TabIndex = 65
        Me.EText1.TableName = "find_paymenterm_cd"
        Me.EText1.Title = "대체번호"
        Me.EText1.TitleWidth = 98
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.g_body)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g_body1)
        Me.SplitContainer3.Size = New System.Drawing.Size(845, 451)
        Me.SplitContainer3.SplitterDistance = 281
        Me.SplitContainer3.TabIndex = 0
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(845, 281)
        Me.g_body.TabIndex = 1
        '
        'g_body1
        '
        Me.g_body1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body1.Location = New System.Drawing.Point(0, 0)
        Me.g_body1.Name = "g_body1"
        Me.g_body1.ReadOnly = False
        Me.g_body1.RowHeight = -1
        Me.g_body1.Size = New System.Drawing.Size(845, 166)
        Me.g_body1.TabIndex = 2
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_list)
        Me.SplitContainer1.Size = New System.Drawing.Size(333, 611)
        Me.SplitContainer1.SplitterDistance = 214
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.RadioButton1)
        Me.EPanel1.Controls.Add(Me.RadioButton2)
        Me.EPanel1.Controls.Add(Me.RadioButton3)
        Me.EPanel1.Controls.Add(Me.Label1)
        Me.EPanel1.Controls.Add(Me.EText3)
        Me.EPanel1.Controls.Add(Me.ECombo9)
        Me.EPanel1.Controls.Add(Me.EDate1)
        Me.EPanel1.Controls.Add(Me.EDate3)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(333, 214)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색 조건"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ECheck1)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 33)
        Me.Panel1.TabIndex = 2
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(98, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 27)
        Me.btn_cancel.TabIndex = 72
        Me.btn_cancel.Text = "취   소"
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(10, 3)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(72, 27)
        Me.btn_find.TabIndex = 71
        Me.btn_find.Text = "검   색"
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(333, 393)
        Me.g_list.TabIndex = 0
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.Location = New System.Drawing.Point(0, 0)
        Me.spc_1.Name = "spc_1"
        '
        'spc_1.Panel1
        '
        Me.spc_1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'spc_1.Panel2
        '
        Me.spc_1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.spc_1.Size = New System.Drawing.Size(1182, 611)
        Me.spc_1.SplitterDistance = 333
        Me.spc_1.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(159, 103)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 18)
        Me.RadioButton1.TabIndex = 117
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "전체"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(106, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 18)
        Me.RadioButton2.TabIndex = 116
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "확인"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(53, 103)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 18)
        Me.RadioButton3.TabIndex = 115
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "저장"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(162, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 14)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EText3
        '
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText3.Location = New System.Drawing.Point(12, 72)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(275, 21)
        Me.EText3.TabIndex = 113
        Me.EText3.Title = "거래처"
        Me.EText3.TitleWidth = 40
        '
        'ECombo9
        '
        Me.ECombo9.Location = New System.Drawing.Point(304, 45)
        Me.ECombo9.Name = "ECombo9"
        Me.ECombo9.Size = New System.Drawing.Size(97, 21)
        Me.ECombo9.TabIndex = 112
        Me.ECombo9.Title = "화폐"
        Me.ECombo9.TitleWidth = 40
        '
        'EDate1
        '
        Me.EDate1.Location = New System.Drawing.Point(183, 45)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(104, 21)
        Me.EDate1.TabIndex = 111
        Me.EDate1.Title = "기간"
        Me.EDate1.TitleWidth = 0
        '
        'EDate3
        '
        Me.EDate3.Location = New System.Drawing.Point(12, 45)
        Me.EDate3.Name = "EDate3"
        Me.EDate3.Size = New System.Drawing.Size(145, 21)
        Me.EDate3.TabIndex = 110
        Me.EDate3.Title = "기간"
        Me.EDate3.TitleWidth = 40
        '
        'ECheck1
        '
        Me.ECheck1.BackColor = System.Drawing.Color.White
        Me.ECheck1.Caption = ""
        Me.ECheck1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck1.Location = New System.Drawing.Point(181, 9)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(120, 21)
        Me.ECheck1.TabIndex = 76
        Me.ECheck1.Title = "선택후 숨김"
        Me.ECheck1.TitleWidth = 90
        '
        'WI_KU2180
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_KU2180"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ep_head.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.EPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EText8 As Frame7.eText
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents EMemo1 As Frame7.eMemo
    Friend WithEvents EText14 As Frame7.eText
    Friend WithEvents EText12 As Frame7.eText
    Friend WithEvents EDate2 As Frame7.eDate
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents EText7 As Frame7.eText
    Friend WithEvents EText5 As Frame7.eText
    Friend WithEvents EText6 As Frame7.eText
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents g_body1 As Frame7.eGrid
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents ECombo9 As Frame7.eCombo
    Friend WithEvents EDate1 As Frame7.eDate
    Friend WithEvents EDate3 As Frame7.eDate
    Friend WithEvents ECheck1 As Frame7.eCheck

End Class
