<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1295_2
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
        Me.to_dt = New Frame7.eDate()
        Me.from_dt = New Frame7.eDate()
        Me.f_itm_cd = New Frame7.eText()
        Me.ip_no = New Frame7.eText()
        Me.f_nm_cd = New Frame7.eText()
        Me.bal_no = New Frame7.eText()
        Me.f_itm_nm = New Frame7.eText()
        Me.f_nm_nm = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel2 = New Frame7.ePanel()
        Me.EText3 = New Frame7.eText()
        Me.EText4 = New Frame7.eText()
        Me.ECombo2 = New Frame7.eCombo()
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
        Me.SplitContainer1.SplitterDistance = 112
        Me.SplitContainer1.TabIndex = 6
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.from_dt)
        Me.EPanel1.Controls.Add(Me.f_itm_cd)
        Me.EPanel1.Controls.Add(Me.ip_no)
        Me.EPanel1.Controls.Add(Me.f_nm_cd)
        Me.EPanel1.Controls.Add(Me.bal_no)
        Me.EPanel1.Controls.Add(Me.f_itm_nm)
        Me.EPanel1.Controls.Add(Me.f_nm_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 112)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     반품 해체실적 현황"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(186, 51)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(133, 21)
        Me.to_dt.TabIndex = 99
        Me.to_dt.Title = "~"
        Me.to_dt.TitleWidth = 20
        '
        'from_dt
        '
        Me.from_dt.Location = New System.Drawing.Point(19, 51)
        Me.from_dt.Name = "from_dt"
        Me.from_dt.Size = New System.Drawing.Size(161, 21)
        Me.from_dt.TabIndex = 98
        Me.from_dt.Title = "기간"
        Me.from_dt.TitleWidth = 50
        '
        'f_itm_cd
        '
        Me.f_itm_cd.ColumnName = "ps_cd"
        Me.f_itm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_itm_cd.Location = New System.Drawing.Point(937, 69)
        Me.f_itm_cd.Name = "f_itm_cd"
        Me.f_itm_cd.Size = New System.Drawing.Size(208, 21)
        Me.f_itm_cd.TabIndex = 94
        Me.f_itm_cd.TableName = "ps_cd"
        Me.f_itm_cd.Title = "품목코드"
        Me.f_itm_cd.TitleWidth = 80
        '
        'ip_no
        '
        Me.ip_no.ColumnName = "pl_nm"
        Me.ip_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ip_no.Location = New System.Drawing.Point(364, 51)
        Me.ip_no.Name = "ip_no"
        Me.ip_no.Size = New System.Drawing.Size(240, 21)
        Me.ip_no.TabIndex = 96
        Me.ip_no.TableName = "pl_nm"
        Me.ip_no.Title = "해체실적번호"
        Me.ip_no.TitleWidth = 100
        '
        'f_nm_cd
        '
        Me.f_nm_cd.ColumnName = "ps_cd"
        Me.f_nm_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_nm_cd.Location = New System.Drawing.Point(937, 33)
        Me.f_nm_cd.Name = "f_nm_cd"
        Me.f_nm_cd.Size = New System.Drawing.Size(208, 21)
        Me.f_nm_cd.TabIndex = 92
        Me.f_nm_cd.TableName = "ps_cd"
        Me.f_nm_cd.Title = "제품코드"
        Me.f_nm_cd.TitleWidth = 80
        '
        'bal_no
        '
        Me.bal_no.ColumnName = "pl_nm"
        Me.bal_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.bal_no.Location = New System.Drawing.Point(635, 51)
        Me.bal_no.Name = "bal_no"
        Me.bal_no.Size = New System.Drawing.Size(240, 21)
        Me.bal_no.TabIndex = 97
        Me.bal_no.TableName = "pl_nm"
        Me.bal_no.Title = "해체지시번호"
        Me.bal_no.TitleWidth = 100
        '
        'f_itm_nm
        '
        Me.f_itm_nm.ColumnName = "pl_nm"
        Me.f_itm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_itm_nm.Location = New System.Drawing.Point(1148, 69)
        Me.f_itm_nm.Name = "f_itm_nm"
        Me.f_itm_nm.Size = New System.Drawing.Size(66, 21)
        Me.f_itm_nm.TabIndex = 95
        Me.f_itm_nm.TableName = "pl_nm"
        Me.f_itm_nm.Title = "부서"
        Me.f_itm_nm.TitleWidth = 0
        '
        'f_nm_nm
        '
        Me.f_nm_nm.ColumnName = "pl_nm"
        Me.f_nm_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_nm_nm.Location = New System.Drawing.Point(1148, 33)
        Me.f_nm_nm.Name = "f_nm_nm"
        Me.f_nm_nm.Size = New System.Drawing.Size(66, 21)
        Me.f_nm_nm.TabIndex = 93
        Me.f_nm_nm.TableName = "pl_nm"
        Me.f_nm_nm.Title = "부서"
        Me.f_nm_nm.TitleWidth = 0
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1182, 495)
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
        Me.EPanel2.Size = New System.Drawing.Size(1182, 495)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Price Term 등록"
        '
        'EText3
        '
        Me.EText3.ColumnName = "find_paymenterm_cd"
        Me.EText3.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.EText4.Font = New System.Drawing.Font("Tahoma", 9.0!)
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
        'WI_SA1295_2
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "WI_SA1295_2"
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
    Friend WithEvents f_nm_nm As Frame7.eText
    Friend WithEvents f_nm_cd As Frame7.eText
    Friend WithEvents f_itm_nm As Frame7.eText
    Friend WithEvents f_itm_cd As Frame7.eText
    Friend WithEvents bal_no As Frame7.eText
    Friend WithEvents ip_no As Frame7.eText
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents from_dt As Frame7.eDate

End Class
