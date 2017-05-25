<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WI_CO1510
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
        Me.find_cr_nm = New Frame7.eText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.find_visible = New System.Windows.Forms.CheckBox()
        Me.g_list = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ep_head = New Frame7.ePanel()
        Me.mold_nm = New Frame7.eText()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_insert = New DevExpress.XtraEditors.SimpleButton()
        Me.img = New Frame7.eImage()
        Me.dry_size = New Frame7.eText()
        Me.out_size = New Frame7.eText()
        Me.cr_mate = New Frame7.eText()
        Me.made_dt = New Frame7.eDate()
        Me.cr_gu = New Frame7.eCombo()
        Me.cr_mark = New Frame7.eText()
        Me.mold_cd = New Frame7.eText()
        Me.cr_type = New Frame7.eCombo()
        Me.g_body = New Frame7.eGrid()
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
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ep_head.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(374, 611)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.find_cr_nm)
        Me.EPanel1.Controls.Add(Me.Panel1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(374, 189)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색 조건"
        '
        'find_cr_nm
        '
        Me.find_cr_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.find_cr_nm.Location = New System.Drawing.Point(35, 71)
        Me.find_cr_nm.Name = "find_cr_nm"
        Me.find_cr_nm.Size = New System.Drawing.Size(267, 21)
        Me.find_cr_nm.TabIndex = 161
        Me.find_cr_nm.Title = "제품명"
        Me.find_cr_nm.TitleWidth = 85
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_find)
        Me.Panel1.Controls.Add(Me.find_visible)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 41)
        Me.Panel1.TabIndex = 117
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
        Me.find_visible.Dock = System.Windows.Forms.DockStyle.Right
        Me.find_visible.Location = New System.Drawing.Point(274, 0)
        Me.find_visible.Name = "find_visible"
        Me.find_visible.Size = New System.Drawing.Size(94, 39)
        Me.find_visible.TabIndex = 48
        Me.find_visible.Text = "선택 후 숨김"
        Me.find_visible.UseVisualStyleBackColor = True
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 0)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(374, 418)
        Me.g_list.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.g_body)
        Me.SplitContainer2.Size = New System.Drawing.Size(804, 611)
        Me.SplitContainer2.SplitterDistance = 257
        Me.SplitContainer2.TabIndex = 0
        '
        'ep_head
        '
        Me.ep_head.Controls.Add(Me.mold_nm)
        Me.ep_head.Controls.Add(Me.btn_delete)
        Me.ep_head.Controls.Add(Me.btn_insert)
        Me.ep_head.Controls.Add(Me.img)
        Me.ep_head.Controls.Add(Me.dry_size)
        Me.ep_head.Controls.Add(Me.out_size)
        Me.ep_head.Controls.Add(Me.cr_mate)
        Me.ep_head.Controls.Add(Me.made_dt)
        Me.ep_head.Controls.Add(Me.cr_gu)
        Me.ep_head.Controls.Add(Me.cr_mark)
        Me.ep_head.Controls.Add(Me.mold_cd)
        Me.ep_head.Controls.Add(Me.cr_type)
        Me.ep_head.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ep_head.Location = New System.Drawing.Point(0, 0)
        Me.ep_head.Name = "ep_head"
        Me.ep_head.Size = New System.Drawing.Size(804, 257)
        Me.ep_head.TabIndex = 0
        Me.ep_head.Text = "     출고등록"
        '
        'mold_nm
        '
        Me.mold_nm.ColumnName = "find_stts"
        Me.mold_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mold_nm.Location = New System.Drawing.Point(171, 53)
        Me.mold_nm.Name = "mold_nm"
        Me.mold_nm.Size = New System.Drawing.Size(146, 21)
        Me.mold_nm.TabIndex = 161
        Me.mold_nm.TableName = "find_stts"
        Me.mold_nm.Title = "비 고"
        Me.mold_nm.TitleWidth = 0
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(389, 102)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(72, 27)
        Me.btn_delete.TabIndex = 160
        Me.btn_delete.Text = "사진 삭제"
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(389, 56)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(72, 27)
        Me.btn_insert.TabIndex = 159
        Me.btn_insert.Text = "사진 첨부"
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(467, 30)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(326, 209)
        Me.img.SizeMode = Frame7.ImageSizeMode.Stretch
        Me.img.TabIndex = 158
        Me.img.TitleBorderStyle = Frame7.BorderStyle.None
        Me.img.Visible = False
        '
        'dry_size
        '
        Me.dry_size.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dry_size.Location = New System.Drawing.Point(20, 222)
        Me.dry_size.Name = "dry_size"
        Me.dry_size.Size = New System.Drawing.Size(297, 21)
        Me.dry_size.TabIndex = 80
        Me.dry_size.Title = "DRY 렌즈 SIZE"
        Me.dry_size.TitleWidth = 85
        '
        'out_size
        '
        Me.out_size.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.out_size.Location = New System.Drawing.Point(20, 198)
        Me.out_size.Name = "out_size"
        Me.out_size.Size = New System.Drawing.Size(297, 21)
        Me.out_size.TabIndex = 79
        Me.out_size.Title = "외경치수(1)"
        Me.out_size.TitleWidth = 85
        '
        'cr_mate
        '
        Me.cr_mate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cr_mate.Location = New System.Drawing.Point(20, 174)
        Me.cr_mate.Name = "cr_mate"
        Me.cr_mate.Size = New System.Drawing.Size(297, 21)
        Me.cr_mate.TabIndex = 78
        Me.cr_mate.Title = "재질"
        Me.cr_mate.TitleWidth = 85
        '
        'made_dt
        '
        Me.made_dt.Location = New System.Drawing.Point(20, 150)
        Me.made_dt.Name = "made_dt"
        Me.made_dt.Size = New System.Drawing.Size(223, 21)
        Me.made_dt.TabIndex = 77
        Me.made_dt.Title = "제작일자"
        Me.made_dt.TitleWidth = 85
        '
        'cr_gu
        '
        Me.cr_gu.Location = New System.Drawing.Point(20, 78)
        Me.cr_gu.Name = "cr_gu"
        Me.cr_gu.Size = New System.Drawing.Size(223, 21)
        Me.cr_gu.TabIndex = 76
        Me.cr_gu.Title = "유형구분"
        Me.cr_gu.TitleWidth = 85
        '
        'cr_mark
        '
        Me.cr_mark.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cr_mark.Location = New System.Drawing.Point(20, 126)
        Me.cr_mark.Name = "cr_mark"
        Me.cr_mark.Size = New System.Drawing.Size(297, 21)
        Me.cr_mark.TabIndex = 75
        Me.cr_mark.Title = "표기"
        Me.cr_mark.TitleWidth = 85
        '
        'mold_cd
        '
        Me.mold_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mold_cd.Location = New System.Drawing.Point(20, 54)
        Me.mold_cd.Name = "mold_cd"
        Me.mold_cd.Size = New System.Drawing.Size(149, 21)
        Me.mold_cd.TabIndex = 73
        Me.mold_cd.Title = "금형규격"
        Me.mold_cd.TitleWidth = 85
        '
        'cr_type
        '
        Me.cr_type.Location = New System.Drawing.Point(20, 102)
        Me.cr_type.Name = "cr_type"
        Me.cr_type.Size = New System.Drawing.Size(223, 21)
        Me.cr_type.TabIndex = 70
        Me.cr_type.Title = "코아종류"
        Me.cr_type.TitleWidth = 85
        '
        'g_body
        '
        Me.g_body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_body.Location = New System.Drawing.Point(0, 0)
        Me.g_body.Name = "g_body"
        Me.g_body.ReadOnly = False
        Me.g_body.RowHeight = -1
        Me.g_body.Size = New System.Drawing.Size(804, 350)
        Me.g_body.TabIndex = 0
        '
        'WI_CO1510
        '
        Me.Controls.Add(Me.spc_1)
        Me.Name = "WI_CO1510"
        Me.Size = New System.Drawing.Size(1182, 611)
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
        CType(Me.ep_head, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ep_head.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spc_1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_visible As System.Windows.Forms.CheckBox
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ep_head As Frame7.ePanel
    Friend WithEvents cr_type As Frame7.eCombo
    Friend WithEvents g_body As Frame7.eGrid
    Friend WithEvents mold_cd As Frame7.eText
    Friend WithEvents cr_mark As Frame7.eText
    Friend WithEvents dry_size As Frame7.eText
    Friend WithEvents out_size As Frame7.eText
    Friend WithEvents cr_mate As Frame7.eText
    Friend WithEvents made_dt As Frame7.eDate
    Friend WithEvents cr_gu As Frame7.eCombo
    Friend WithEvents img As Frame7.eImage
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_insert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents find_cr_nm As Frame7.eText
    Friend WithEvents mold_nm As Frame7.eText

End Class
