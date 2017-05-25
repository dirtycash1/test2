<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_SA1190
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.find_to = New Frame7.eDate()
        Me.find_from = New Frame7.eDate()
        Me.find_cs_nm = New Frame7.eText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.find_stts = New Frame7.eCombo()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.head_otno = New Frame7.eText()
        Me.lavel_print_qty = New Frame7.eText()
        Me.addr_deli = New Frame7.eText()
        Me.delete_otno = New Frame7.eText()
        Me.deli_place = New Frame7.eText()
        Me.pl_cd = New Frame7.eText()
        Me.sa_cd = New Frame7.eCombo()
        Me.cs_addr = New Frame7.eText()
        Me.cs_tel = New Frame7.eText()
        Me.stts1 = New Frame7.eCombo()
        Me.cs_nm = New Frame7.eText()
        Me.cs_cd = New Frame7.eText()
        Me.deli_dt = New Frame7.eDate()
        Me.ps_cd = New Frame7.eText()
        Me.deli_no = New Frame7.eText()
        Me.ps_nm = New Frame7.eText()
        Me.g_body = New Frame7.eGrid()
        Me.sale_amt = New Frame7.eText()
        Me.but_print = New DevExpress.XtraEditors.SimpleButton()
        Me.spc_1.Panel1.SuspendLayout()
        Me.spc_1.Panel2.SuspendLayout()
        Me.spc_1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'spc_1
        '
        Me.spc_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.spc_1.Size = New System.Drawing.Size(1350, 558)
        Me.spc_1.SplitterDistance = 374
        Me.spc_1.TabIndex = 4
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
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 558)
        Me.SplitContainer1.SplitterDistance = 162
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_to)
        Me.EPanel1.Controls.Add(Me.find_from)
        Me.EPanel1.Controls.Add(Me.find_cs_nm)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Controls.Add(Me.find_stts)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 162)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_to
        '
        Me.find_to.Location = New System.Drawing.Point(175, 32)
        Me.find_to.Name = "find_to"
        Me.find_to.Size = New System.Drawing.Size(111, 21)
        Me.find_to.TabIndex = 47
        Me.find_to.Title = "~"
        Me.find_to.TitleWidth = 10
        '
        'find_from
        '
        Me.find_from.Location = New System.Drawing.Point(13, 32)
        Me.find_from.Name = "find_from"
        Me.find_from.Size = New System.Drawing.Size(159, 21)
        Me.find_from.TabIndex = 46
        Me.find_from.Title = "기간"
        Me.find_from.TitleWidth = 60
        '
        'find_cs_nm
        '
        Me.find_cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cs_nm.Location = New System.Drawing.Point(13, 58)
        Me.find_cs_nm.Name = "find_cs_nm"
        Me.find_cs_nm.Size = New System.Drawing.Size(273, 21)
        Me.find_cs_nm.TabIndex = 48
        Me.find_cs_nm.Title = "거래처명"
        Me.find_cs_nm.TitleWidth = 60
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 41)
        Me.Panel1.TabIndex = 2
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(98, 6)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 27)
        Me.btn_cancel.TabIndex = 72
        Me.btn_cancel.Text = "취   소"
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(10, 6)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(72, 27)
        Me.btn_find.TabIndex = 71
        Me.btn_find.Text = "검   색"
        '
        'find_visible
        '
        Me.find_visible.AutoSize = True
        Me.find_visible.Checked = True
        Me.find_visible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.find_visible.Dock = System.Windows.Forms.DockStyle.Right
        Me.find_visible.Location = New System.Drawing.Point(274, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(94, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'find_stts
        '
        Me.find_stts.Location = New System.Drawing.Point(14, 84)
        Me.find_stts.Name = "find_stts"
        Me.find_stts.Size = New System.Drawing.Size(159, 21)
        Me.find_stts.TabIndex = 11
        Me.find_stts.Title = "상태"
        Me.find_stts.TitleWidth = 60
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(374, 392)
        Me.g_list.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Panel2.Controls.Add(Me.sale_amt)
        Me.SplitContainer2.Size = New System.Drawing.Size(972, 558)
        Me.SplitContainer2.SplitterDistance = 132
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.head_otno)
        Me.EPanel2.Controls.Add(Me.lavel_print_qty)
        Me.EPanel2.Controls.Add(Me.but_print)
        Me.EPanel2.Controls.Add(Me.addr_deli)
        Me.EPanel2.Controls.Add(Me.delete_otno)
        Me.EPanel2.Controls.Add(Me.deli_place)
        Me.EPanel2.Controls.Add(Me.pl_cd)
        Me.EPanel2.Controls.Add(Me.sa_cd)
        Me.EPanel2.Controls.Add(Me.cs_addr)
        Me.EPanel2.Controls.Add(Me.cs_tel)
        Me.EPanel2.Controls.Add(Me.stts1)
        Me.EPanel2.Controls.Add(Me.cs_nm)
        Me.EPanel2.Controls.Add(Me.cs_cd)
        Me.EPanel2.Controls.Add(Me.deli_dt)
        Me.EPanel2.Controls.Add(Me.ps_cd)
        Me.EPanel2.Controls.Add(Me.deli_no)
        Me.EPanel2.Controls.Add(Me.ps_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(972, 132)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "     배송 등록"
        '
        'head_otno
        '
        Me.head_otno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.head_otno.Location = New System.Drawing.Point(40, 166)
        Me.head_otno.Name = "head_otno"
        Me.head_otno.Size = New System.Drawing.Size(240, 21)
        Me.head_otno.TabIndex = 83
        Me.head_otno.Title = "출하전표찾기용-삭제X"
        '
        'lavel_print_qty
        '
        Me.lavel_print_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lavel_print_qty.Location = New System.Drawing.Point(668, 86)
        Me.lavel_print_qty.Name = "lavel_print_qty"
        Me.lavel_print_qty.Size = New System.Drawing.Size(169, 21)
        Me.lavel_print_qty.TabIndex = 81
        Me.lavel_print_qty.Title = "라벨수량"
        Me.lavel_print_qty.TitleWidth = 60
        '
        'addr_deli
        '
        Me.addr_deli.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr_deli.Location = New System.Drawing.Point(456, 107)
        Me.addr_deli.Name = "addr_deli"
        Me.addr_deli.Size = New System.Drawing.Size(18, 21)
        Me.addr_deli.TabIndex = 80
        Me.addr_deli.Title = "배송지"
        Me.addr_deli.TitleWidth = 0
        '
        'delete_otno
        '
        Me.delete_otno.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.delete_otno.Location = New System.Drawing.Point(40, 193)
        Me.delete_otno.Name = "delete_otno"
        Me.delete_otno.Size = New System.Drawing.Size(240, 21)
        Me.delete_otno.TabIndex = 82
        Me.delete_otno.Title = "출하삭제용-삭제X"
        '
        'deli_place
        '
        Me.deli_place.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deli_place.Location = New System.Drawing.Point(19, 107)
        Me.deli_place.Name = "deli_place"
        Me.deli_place.Size = New System.Drawing.Size(438, 21)
        Me.deli_place.TabIndex = 79
        Me.deli_place.Title = "배송지"
        Me.deli_place.TitleWidth = 98
        '
        'pl_cd
        '
        Me.pl_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pl_cd.Location = New System.Drawing.Point(474, 204)
        Me.pl_cd.Name = "pl_cd"
        Me.pl_cd.Size = New System.Drawing.Size(240, 21)
        Me.pl_cd.TabIndex = 76
        Me.pl_cd.Title = "부서코드"
        '
        'sa_cd
        '
        Me.sa_cd.Location = New System.Drawing.Point(486, 32)
        Me.sa_cd.Name = "sa_cd"
        Me.sa_cd.Size = New System.Drawing.Size(168, 21)
        Me.sa_cd.TabIndex = 77
        Me.sa_cd.Title = "사업장"
        Me.sa_cd.TitleWidth = 60
        '
        'cs_addr
        '
        Me.cs_addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_addr.Location = New System.Drawing.Point(19, 82)
        Me.cs_addr.Name = "cs_addr"
        Me.cs_addr.Size = New System.Drawing.Size(455, 21)
        Me.cs_addr.TabIndex = 70
        Me.cs_addr.Title = "주소"
        Me.cs_addr.TitleWidth = 98
        '
        'cs_tel
        '
        Me.cs_tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_tel.Location = New System.Drawing.Point(486, 82)
        Me.cs_tel.Name = "cs_tel"
        Me.cs_tel.Size = New System.Drawing.Size(168, 21)
        Me.cs_tel.TabIndex = 69
        Me.cs_tel.Title = "전화번호"
        Me.cs_tel.TitleWidth = 60
        '
        'stts1
        '
        Me.stts1.Location = New System.Drawing.Point(668, 59)
        Me.stts1.Name = "stts1"
        Me.stts1.Size = New System.Drawing.Size(169, 21)
        Me.stts1.TabIndex = 74
        Me.stts1.Title = "상태"
        Me.stts1.TitleWidth = 60
        '
        'cs_nm
        '
        Me.cs_nm.ColumnName = "find_stts"
        Me.cs_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_nm.Location = New System.Drawing.Point(203, 57)
        Me.cs_nm.Name = "cs_nm"
        Me.cs_nm.Size = New System.Drawing.Size(271, 21)
        Me.cs_nm.TabIndex = 68
        Me.cs_nm.TableName = "find_stts"
        Me.cs_nm.Title = "cs_nm"
        Me.cs_nm.TitleWidth = 0
        '
        'cs_cd
        '
        Me.cs_cd.ColumnName = "find_paymenterm_cd"
        Me.cs_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cs_cd.Location = New System.Drawing.Point(19, 57)
        Me.cs_cd.Name = "cs_cd"
        Me.cs_cd.Size = New System.Drawing.Size(182, 21)
        Me.cs_cd.TabIndex = 67
        Me.cs_cd.TableName = "find_paymenterm_cd"
        Me.cs_cd.Title = "거래처"
        Me.cs_cd.TitleWidth = 98
        '
        'deli_dt
        '
        Me.deli_dt.Location = New System.Drawing.Point(668, 32)
        Me.deli_dt.Name = "deli_dt"
        Me.deli_dt.Size = New System.Drawing.Size(169, 21)
        Me.deli_dt.TabIndex = 21
        Me.deli_dt.Title = "배송일자"
        Me.deli_dt.TitleWidth = 60
        '
        'ps_cd
        '
        Me.ps_cd.ColumnName = "find_paymenterm_cd"
        Me.ps_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_cd.Location = New System.Drawing.Point(244, 32)
        Me.ps_cd.Name = "ps_cd"
        Me.ps_cd.Size = New System.Drawing.Size(123, 21)
        Me.ps_cd.TabIndex = 19
        Me.ps_cd.TableName = "find_paymenterm_cd"
        Me.ps_cd.Title = "작성자"
        Me.ps_cd.TitleWidth = 40
        '
        'deli_no
        '
        Me.deli_no.ColumnName = "find_paymenterm_cd"
        Me.deli_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.deli_no.Location = New System.Drawing.Point(19, 32)
        Me.deli_no.Name = "deli_no"
        Me.deli_no.Size = New System.Drawing.Size(215, 21)
        Me.deli_no.TabIndex = 5
        Me.deli_no.TableName = "find_paymenterm_cd"
        Me.deli_no.Title = "배송번호"
        Me.deli_no.TitleWidth = 98
        '
        'ps_nm
        '
        Me.ps_nm.ColumnName = "find_stts"
        Me.ps_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ps_nm.Location = New System.Drawing.Point(370, 32)
        Me.ps_nm.Name = "ps_nm"
        Me.ps_nm.Size = New System.Drawing.Size(104, 21)
        Me.ps_nm.TabIndex = 18
        Me.ps_nm.TableName = "find_stts"
        Me.ps_nm.Title = "ps_nm"
        Me.ps_nm.TitleWidth = 0
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(972, 422)
        Me.g_body.TabIndex = 1
        '
        'sale_amt
        '
        Me.sale_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.sale_amt.Location = New System.Drawing.Point(487, 3)
        Me.sale_amt.Name = "sale_amt"
        Me.sale_amt.Size = New System.Drawing.Size(240, 21)
        Me.sale_amt.TabIndex = 39
        Me.sale_amt.Title = "합계금액"
        '
        'but_print
        '
        Me.but_print.Location = New System.Drawing.Point(853, 32)
        Me.but_print.Name = "but_print"
        Me.but_print.Size = New System.Drawing.Size(98, 46)
        Me.but_print.TabIndex = 84
        Me.but_print.Text = "송장출력"
        '
        'WI_SA1190
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_SA1190"
        Me.Size = New System.Drawing.Size(1350, 558)
        Me.Controls.SetChildIndex(Me.spc_1, 0)
        Me.spc_1.Panel1.ResumeLayout(False)
        Me.spc_1.Panel2.ResumeLayout(False)
        Me.spc_1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents deli_dt As Frame7.eDate
    Friend WithEvents ps_cd As Frame7.eText
    Friend WithEvents ps_nm As Frame7.eText
    Friend WithEvents deli_no As Frame7.eText
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents find_stts As Frame7.eCombo
    Friend WithEvents find_to As Frame7.eDate
    Friend WithEvents find_from As Frame7.eDate
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents sale_amt As Frame7.eText
    Friend WithEvents cs_tel As Frame7.eText
    Friend WithEvents cs_nm As Frame7.eText
    Friend WithEvents cs_cd As Frame7.eText
    Friend WithEvents cs_addr As Frame7.eText
    Friend WithEvents find_cs_nm As Frame7.eText
    Friend WithEvents stts1 As Frame7.eCombo
    Friend WithEvents pl_cd As Frame7.eText
    Friend WithEvents sa_cd As Frame7.eCombo
    Friend WithEvents addr_deli As Frame7.eText
    Friend WithEvents deli_place As Frame7.eText
    Friend WithEvents lavel_print_qty As Frame7.eText
    Friend WithEvents delete_otno As Frame7.eText
    Friend WithEvents head_otno As Frame7.eText
    Friend WithEvents but_print As DevExpress.XtraEditors.SimpleButton

End Class
