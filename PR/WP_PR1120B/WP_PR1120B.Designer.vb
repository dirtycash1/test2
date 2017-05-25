<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_PR1120B
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.chk2 = New Frame7.eCheck()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk1 = New Frame7.eCheck()
        Me.LOT_NO = New Frame7.eText()
        Me.fac_cd = New Frame7.eCombo()
        Me.find_from = New Frame7.eDate()
        Me.find_to = New Frame7.eDate()
        Me.gong_cd = New Frame7.eCombo()
        Me.find_model_no = New Frame7.eText()
        Me.kijong_cd = New Frame7.eCombo()
        Me.find_model_nm = New Frame7.eText()
        Me.find_nm_cd = New Frame7.eText()
        Me.find_nm_nm = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.생산실적현황 = New Frame7.ePanel()
        Me.g_result = New Frame7.eGrid()
        Me.불량유형벼 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.생산실적현황, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.생산실적현황.SuspendLayout()
        CType(Me.불량유형벼, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.불량유형벼.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1426, 611)
        Me.SplitContainer1.SplitterDistance = 82
        Me.SplitContainer1.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.chk2)
        Me.EPanel2.Controls.Add(Me.Label9)
        Me.EPanel2.Controls.Add(Me.Label2)
        Me.EPanel2.Controls.Add(Me.Label8)
        Me.EPanel2.Controls.Add(Me.Label7)
        Me.EPanel2.Controls.Add(Me.Label6)
        Me.EPanel2.Controls.Add(Me.Label5)
        Me.EPanel2.Controls.Add(Me.Label4)
        Me.EPanel2.Controls.Add(Me.Label3)
        Me.EPanel2.Controls.Add(Me.chk1)
        Me.EPanel2.Controls.Add(Me.LOT_NO)
        Me.EPanel2.Controls.Add(Me.fac_cd)
        Me.EPanel2.Controls.Add(Me.find_from)
        Me.EPanel2.Controls.Add(Me.find_to)
        Me.EPanel2.Controls.Add(Me.gong_cd)
        Me.EPanel2.Controls.Add(Me.find_model_no)
        Me.EPanel2.Controls.Add(Me.kijong_cd)
        Me.EPanel2.Controls.Add(Me.find_model_nm)
        Me.EPanel2.Controls.Add(Me.find_nm_cd)
        Me.EPanel2.Controls.Add(Me.find_nm_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1426, 82)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     검색"
        '
        'chk2
        '
        Me.chk2.Caption = ""
        Me.chk2.Location = New System.Drawing.Point(1162, 26)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(122, 21)
        Me.chk2.TabIndex = 90
        Me.chk2.Title = "1차 작업로트포함"
        Me.chk2.TitleWidth = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("돋움", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.Location = New System.Drawing.Point(1051, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 14)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "사출"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("돋움", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(1088, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "분리"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(1310, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 14)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "외주"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(1273, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 14)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "규격"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(1236, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "누수"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(1199, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "포장"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(1162, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "전면"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(1125, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 14)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "하드"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk1
        '
        Me.chk1.Caption = ""
        Me.chk1.Location = New System.Drawing.Point(887, 52)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(129, 21)
        Me.chk1.TabIndex = 62
        Me.chk1.Title = "폐기된 시트 제외"
        Me.chk1.TitleWidth = 100
        '
        'LOT_NO
        '
        Me.LOT_NO.ColumnName = "find_paymentterm_nm"
        Me.LOT_NO.Location = New System.Drawing.Point(887, 28)
        Me.LOT_NO.Name = "LOT_NO"
        Me.LOT_NO.Size = New System.Drawing.Size(256, 21)
        Me.LOT_NO.TabIndex = 61
        Me.LOT_NO.TableName = "find_paymentterm_nm"
        Me.LOT_NO.Title = "CHECK  SHEET NO"
        Me.LOT_NO.TitleWidth = 110
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(628, 52)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 60
        Me.fac_cd.TitleWidth = 100
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(12, 28)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 52
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(174, 28)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 53
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'gong_cd
        '
        Me.gong_cd.Location = New System.Drawing.Point(628, 28)
        Me.gong_cd.Name = "gong_cd"
        Me.gong_cd.Size = New System.Drawing.Size(240, 21)
        Me.gong_cd.TabIndex = 59
        Me.gong_cd.TitleWidth = 100
        '
        'find_model_no
        '
        Me.find_model_no.ColumnName = "find_paymentterm_nm"
        Me.find_model_no.Location = New System.Drawing.Point(292, 28)
        Me.find_model_no.Name = "find_model_no"
        Me.find_model_no.Size = New System.Drawing.Size(176, 21)
        Me.find_model_no.TabIndex = 54
        Me.find_model_no.TableName = "find_paymentterm_nm"
        Me.find_model_no.Title = "제품군"
        Me.find_model_no.TitleWidth = 80
        '
        'kijong_cd
        '
        Me.kijong_cd.Location = New System.Drawing.Point(12, 52)
        Me.kijong_cd.Name = "kijong_cd"
        Me.kijong_cd.Size = New System.Drawing.Size(272, 21)
        Me.kijong_cd.TabIndex = 58
        '
        'find_model_nm
        '
        Me.find_model_nm.ColumnName = "find_paymentterm_nm"
        Me.find_model_nm.Location = New System.Drawing.Point(474, 28)
        Me.find_model_nm.Name = "find_model_nm"
        Me.find_model_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_model_nm.TabIndex = 56
        Me.find_model_nm.TableName = "find_paymentterm_nm"
        Me.find_model_nm.Title = "Price Term 명"
        Me.find_model_nm.TitleWidth = 0
        '
        'find_nm_cd
        '
        Me.find_nm_cd.ColumnName = "find_paymentterm_nm"
        Me.find_nm_cd.Location = New System.Drawing.Point(292, 52)
        Me.find_nm_cd.Name = "find_nm_cd"
        Me.find_nm_cd.Size = New System.Drawing.Size(176, 21)
        Me.find_nm_cd.TabIndex = 55
        Me.find_nm_cd.TableName = "find_paymentterm_nm"
        Me.find_nm_cd.Title = "제품명"
        Me.find_nm_cd.TitleWidth = 80
        '
        'find_nm_nm
        '
        Me.find_nm_nm.ColumnName = "find_paymentterm_nm"
        Me.find_nm_nm.Location = New System.Drawing.Point(474, 52)
        Me.find_nm_nm.Name = "find_nm_nm"
        Me.find_nm_nm.Size = New System.Drawing.Size(140, 21)
        Me.find_nm_nm.TabIndex = 57
        Me.find_nm_nm.TableName = "find_paymentterm_nm"
        Me.find_nm_nm.Title = "Price Term 명"
        Me.find_nm_nm.TitleWidth = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.생산실적현황)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.불량유형벼)
        Me.SplitContainer2.Size = New System.Drawing.Size(1426, 525)
        Me.SplitContainer2.SplitterDistance = 409
        Me.SplitContainer2.TabIndex = 0
        '
        '생산실적현황
        '
        Me.생산실적현황.Controls.Add(Me.g_result)
        Me.생산실적현황.Dock = System.Windows.Forms.DockStyle.Fill
        Me.생산실적현황.Location = New System.Drawing.Point(0, 0)
        Me.생산실적현황.Name = "생산실적현황"
        Me.생산실적현황.Size = New System.Drawing.Size(1426, 409)
        Me.생산실적현황.TabIndex = 0
        Me.생산실적현황.Text = "     생산실적현황"
        '
        'g_result
        '
        Me.g_result.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_result.Location = New System.Drawing.Point(2, 23)
        Me.g_result.Name = "g_result"
        Me.g_result.ReadOnly = False
        Me.g_result.RowHeight = -1
        Me.g_result.Size = New System.Drawing.Size(1422, 384)
        Me.g_result.TabIndex = 2
        '
        '불량유형벼
        '
        Me.불량유형벼.Controls.Add(Me.g20)
        Me.불량유형벼.Dock = System.Windows.Forms.DockStyle.Fill
        Me.불량유형벼.Location = New System.Drawing.Point(0, 0)
        Me.불량유형벼.Name = "불량유형벼"
        Me.불량유형벼.Size = New System.Drawing.Size(1426, 112)
        Me.불량유형벼.TabIndex = 0
        Me.불량유형벼.Text = "     불량유형별 불량수량"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1422, 87)
        Me.g20.TabIndex = 2
        '
        'WP_PR1120B
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WP_PR1120B"
        Me.Size = New System.Drawing.Size(1426, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.EPanel2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.생산실적현황, System.ComponentModel.ISupportInitialize).EndInit()
        Me.생산실적현황.ResumeLayout(False)
        CType(Me.불량유형벼, System.ComponentModel.ISupportInitialize).EndInit()
        Me.불량유형벼.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents find_nm_nm As Frame7.eText
    Friend WithEvents find_model_nm As Frame7.eText
    Friend WithEvents find_nm_cd As Frame7.eText
    Friend WithEvents find_model_no As Frame7.eText
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents gong_cd As Frame7.eCombo
    Friend WithEvents kijong_cd As Frame7.eCombo
    Friend WithEvents LOT_NO As Frame7.eText
    Friend WithEvents chk1 As Frame7.eCheck
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk2 As Frame7.eCheck
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents 생산실적현황 As Frame7.ePanel
    Friend WithEvents g_result As Frame7.eGrid
    Friend WithEvents 불량유형벼 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid

End Class
