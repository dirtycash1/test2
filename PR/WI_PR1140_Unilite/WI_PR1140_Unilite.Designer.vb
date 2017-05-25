<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_PR1140_Unilite
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
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
        Me.sa_cd = New Frame7.eCombo()
        Me.find_from = New Frame7.eDate()
        Me.find_to = New Frame7.eDate()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 75
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.sa_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 75)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     완제품 멸균가동일지"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1182, 532)
        Me.g10.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 532)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Location = New System.Drawing.Point(19, 41)
        Me.EText3.Name = "EText3"
        Me.EText3.Size = New System.Drawing.Size(210, 21)
        Me.EText3.TabIndex = 5
        Me.EText3.TableName = "find_paymenterm_cd"
        Me.EText3.Title = "코 드"
        Me.EText3.TitleWidth = 98
        '
        'EText4
        '
        Me.EText4.ColumnName = "find_paymentterm_nm"
        Me.EText4.Location = New System.Drawing.Point(19, 68)
        Me.EText4.Name = "EText4"
        Me.EText4.Size = New System.Drawing.Size(240, 21)
        Me.EText4.TabIndex = 6
        Me.EText4.TableName = "find_paymentterm_nm"
        Me.EText4.Title = "Price Term 명"
        Me.EText4.TitleWidth = 98
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(364, 41)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(240, 21)
        Me.ECombo2.TabIndex = 7
        Me.ECombo2.Title = "사용여부"
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(19, 36)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(184, 21)
        Me.sa_cd.TabIndex = 76
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 70
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(250, 36)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(202, 21)
        Me.find_from.TabIndex = 77
        Me.find_from.Title = "멸균 일자"
        Me.find_from.TitleWidth = 80
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(458, 36)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(150, 21)
        Me.find_to.TabIndex = 78
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 20
        '
        'WI_PR1140_Unilite
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_PR1140_Unilite"
        Me.Size = New System.Drawing.Size(1182, 611)
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
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_to As Frame7.eDate

End Class
