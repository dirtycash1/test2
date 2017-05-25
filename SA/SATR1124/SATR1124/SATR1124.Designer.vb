<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SATR1124
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
        Me.od_dt = New Frame7.eDate()
        Me.emp_no = New Frame7.eText()
        Me.cust_cd = New Frame7.eText()
        Me.map_gu = New Frame7.eOptionBox()
        Me.btn_su = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_map = New DevExpress.XtraEditors.SimpleButton()
        Me.emp_nm = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.g_multi = New Frame7.eGrid()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g_multi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1182, 611)
        Me.SplitContainer1.SplitterDistance = 101
        Me.SplitContainer1.TabIndex = 4
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.od_dt)
        Me.EPanel1.Controls.Add(Me.emp_no)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.map_gu)
        Me.EPanel1.Controls.Add(Me.btn_su)
        Me.EPanel1.Controls.Add(Me.btn_map)
        Me.EPanel1.Controls.Add(Me.emp_nm)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1182, 101)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     주문일보등록(스타비젼)"
        '
        'od_dt
        '
        Me.od_dt.Location = New System.Drawing.Point(341, 37)
        Me.od_dt.Name = "od_dt"
        Me.od_dt.Size = New System.Drawing.Size(245, 21)
        Me.od_dt.TabIndex = 217
        Me.od_dt.Title = "주문 일자"
        Me.od_dt.TitleWidth = 80
        '
        'emp_no
        '
        Me.emp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no.Location = New System.Drawing.Point(19, 64)
        Me.emp_no.Name = "emp_no"
        Me.emp_no.Size = New System.Drawing.Size(172, 21)
        Me.emp_no.TabIndex = 214
        Me.emp_no.Title = "작성자"
        Me.emp_no.TitleWidth = 80
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(19, 37)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(172, 21)
        Me.cust_cd.TabIndex = 79
        Me.cust_cd.Title = "거래처 코드"
        Me.cust_cd.TitleWidth = 80
        '
        'map_gu
        '
        Me.map_gu.Location = New System.Drawing.Point(341, 61)
        Me.map_gu.Name = "map_gu"
        Me.map_gu.SelectedIndex = -1
        Me.map_gu.Size = New System.Drawing.Size(245, 24)
        Me.map_gu.TabIndex = 213
        Me.map_gu.Title = "조회 구분"
        Me.map_gu.TitleWidth = 80
        '
        'btn_su
        '
        Me.btn_su.Location = New System.Drawing.Point(711, 37)
        Me.btn_su.Name = "btn_su"
        Me.btn_su.Size = New System.Drawing.Size(98, 24)
        Me.btn_su.TabIndex = 82
        Me.btn_su.Text = "수주생성" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn_map
        '
        Me.btn_map.Location = New System.Drawing.Point(611, 37)
        Me.btn_map.Name = "btn_map"
        Me.btn_map.Size = New System.Drawing.Size(75, 24)
        Me.btn_map.TabIndex = 81
        Me.btn_map.Text = "매핑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'emp_nm
        '
        Me.emp_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm.Location = New System.Drawing.Point(90, 64)
        Me.emp_nm.Name = "emp_nm"
        Me.emp_nm.Size = New System.Drawing.Size(213, 21)
        Me.emp_nm.TabIndex = 218
        Me.emp_nm.Title = "이름"
        Me.emp_nm.TitleWidth = 100
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(90, 37)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(213, 21)
        Me.cust_nm.TabIndex = 80
        Me.cust_nm.Title = "거래처 코드"
        Me.cust_nm.TitleWidth = 100
        '
        'g_multi
        '
        Me.g_multi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_multi.Location = New System.Drawing.Point(0, 0)
        Me.g_multi.Name = "g_multi"
        Me.g_multi.ReadOnly = False
        Me.g_multi.RowHeight = -1
        Me.g_multi.Size = New System.Drawing.Size(1182, 506)
        Me.g_multi.TabIndex = 2
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.EText3)
        Me.EPanel2.Controls.Add(Me.EText4)
        Me.EPanel2.Controls.Add(Me.ECombo2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1182, 506)
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
        'SATR1124
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SATR1124"
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
    Friend WithEvents g_multi As Frame7.eGrid
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EText3 As Frame7.eText
    Friend WithEvents EText4 As Frame7.eText
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents btn_su As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_map As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents map_gu As Frame7.eOptionBox
    Friend WithEvents emp_no As Frame7.eText
    Friend WithEvents od_dt As Frame7.eDate
    Friend WithEvents emp_nm As Frame7.eText
 

End Class
