<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMA300
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
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.o_pjt_nm = New Frame7.eText()
        Me.o_eng = New Frame7.eText()
        Me.o_model = New Frame7.eText()
        Me.o_item_no = New Frame7.eText()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.pjt_nm = New Frame7.eText()
        Me.item_no = New Frame7.eText()
        Me.item_nm = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.btn_file1_open = New DevExpress.XtraEditors.SimpleButton()
        Me.frdt = New Frame7.eDate()
        Me.btn_file2_open = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file1_view = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file3_open = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file2_view = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file4_open = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file3_view = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file5_open = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file4_view = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file5_view = New DevExpress.XtraEditors.SimpleButton()
        Me.qty = New Frame7.eText()
        Me.btn_file1_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file2_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file3_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file4_del = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file5_del = New DevExpress.XtraEditors.SimpleButton()
        Me.todt = New Frame7.eDate()
        Me.file1 = New Frame7.eText()
        Me.pjt_id = New Frame7.eText()
        Me.file2 = New Frame7.eText()
        Me.file3 = New Frame7.eText()
        Me.eng = New Frame7.eText()
        Me.file4 = New Frame7.eText()
        Me.model = New Frame7.eText()
        Me.file5 = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 140)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(274, 550)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     Project 등록현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(270, 525)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_pjt_nm)
        Me.EPanel1.Controls.Add(Me.o_eng)
        Me.EPanel1.Controls.Add(Me.o_model)
        Me.EPanel1.Controls.Add(Me.o_item_no)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(274, 140)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'o_pjt_nm
        '
        Me.o_pjt_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_pjt_nm.Location = New System.Drawing.Point(6, 27)
        Me.o_pjt_nm.Name = "o_pjt_nm"
        Me.o_pjt_nm.Size = New System.Drawing.Size(240, 21)
        Me.o_pjt_nm.TabIndex = 2
        Me.o_pjt_nm.Title = "Project 명 %"
        '
        'o_eng
        '
        Me.o_eng.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_eng.Location = New System.Drawing.Point(6, 80)
        Me.o_eng.Name = "o_eng"
        Me.o_eng.Size = New System.Drawing.Size(240, 21)
        Me.o_eng.TabIndex = 2
        Me.o_eng.Title = "엔진 %"
        '
        'o_model
        '
        Me.o_model.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_model.Location = New System.Drawing.Point(6, 107)
        Me.o_model.Name = "o_model"
        Me.o_model.Size = New System.Drawing.Size(240, 21)
        Me.o_model.TabIndex = 2
        Me.o_model.Title = "차종 %"
        '
        'o_item_no
        '
        Me.o_item_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_item_no.Location = New System.Drawing.Point(6, 53)
        Me.o_item_no.Name = "o_item_no"
        Me.o_item_no.Size = New System.Drawing.Size(240, 21)
        Me.o_item_no.TabIndex = 2
        Me.o_item_no.Title = "품번 %"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(722, 690)
        Me.SplitContainer2.SplitterDistance = 326
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.pjt_nm)
        Me.EPanel3.Controls.Add(Me.item_no)
        Me.EPanel3.Controls.Add(Me.item_nm)
        Me.EPanel3.Controls.Add(Me.cust_nm)
        Me.EPanel3.Controls.Add(Me.btn_file1_open)
        Me.EPanel3.Controls.Add(Me.frdt)
        Me.EPanel3.Controls.Add(Me.btn_file2_open)
        Me.EPanel3.Controls.Add(Me.btn_file1_view)
        Me.EPanel3.Controls.Add(Me.btn_file3_open)
        Me.EPanel3.Controls.Add(Me.btn_file2_view)
        Me.EPanel3.Controls.Add(Me.btn_file4_open)
        Me.EPanel3.Controls.Add(Me.btn_file3_view)
        Me.EPanel3.Controls.Add(Me.btn_file5_open)
        Me.EPanel3.Controls.Add(Me.btn_file4_view)
        Me.EPanel3.Controls.Add(Me.btn_file5_view)
        Me.EPanel3.Controls.Add(Me.qty)
        Me.EPanel3.Controls.Add(Me.btn_file1_del)
        Me.EPanel3.Controls.Add(Me.btn_file2_del)
        Me.EPanel3.Controls.Add(Me.btn_file3_del)
        Me.EPanel3.Controls.Add(Me.btn_file4_del)
        Me.EPanel3.Controls.Add(Me.btn_file5_del)
        Me.EPanel3.Controls.Add(Me.todt)
        Me.EPanel3.Controls.Add(Me.file1)
        Me.EPanel3.Controls.Add(Me.pjt_id)
        Me.EPanel3.Controls.Add(Me.file2)
        Me.EPanel3.Controls.Add(Me.file3)
        Me.EPanel3.Controls.Add(Me.eng)
        Me.EPanel3.Controls.Add(Me.file4)
        Me.EPanel3.Controls.Add(Me.model)
        Me.EPanel3.Controls.Add(Me.file5)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(722, 326)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Project 등록"
        '
        'pjt_nm
        '
        Me.pjt_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pjt_nm.Location = New System.Drawing.Point(6, 27)
        Me.pjt_nm.Name = "pjt_nm"
        Me.pjt_nm.Size = New System.Drawing.Size(240, 21)
        Me.pjt_nm.TabIndex = 1
        Me.pjt_nm.Title = "Project 명"
        '
        'item_no
        '
        Me.item_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.item_no.Location = New System.Drawing.Point(6, 54)
        Me.item_no.Name = "item_no"
        Me.item_no.Size = New System.Drawing.Size(240, 21)
        Me.item_no.TabIndex = 2
        Me.item_no.Title = "품번"
        '
        'item_nm
        '
        Me.item_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.item_nm.Location = New System.Drawing.Point(6, 81)
        Me.item_nm.Name = "item_nm"
        Me.item_nm.Size = New System.Drawing.Size(240, 21)
        Me.item_nm.TabIndex = 4
        Me.item_nm.Title = "품명"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(6, 108)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 6
        Me.cust_nm.Title = "고객"
        '
        'btn_file1_open
        '
        Me.btn_file1_open.Location = New System.Drawing.Point(261, 185)
        Me.btn_file1_open.Name = "btn_file1_open"
        Me.btn_file1_open.Size = New System.Drawing.Size(75, 21)
        Me.btn_file1_open.TabIndex = 4
        Me.btn_file1_open.Text = "첨부"
        '
        'frdt
        '
        Me.frdt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.frdt.Location = New System.Drawing.Point(261, 107)
        Me.frdt.Name = "frdt"
        Me.frdt.Size = New System.Drawing.Size(240, 21)
        Me.frdt.TabIndex = 8
        Me.frdt.Title = "Project 시작일"
        '
        'btn_file2_open
        '
        Me.btn_file2_open.Location = New System.Drawing.Point(261, 212)
        Me.btn_file2_open.Name = "btn_file2_open"
        Me.btn_file2_open.Size = New System.Drawing.Size(75, 21)
        Me.btn_file2_open.TabIndex = 4
        Me.btn_file2_open.Text = "첨부"
        '
        'btn_file1_view
        '
        Me.btn_file1_view.Location = New System.Drawing.Point(342, 185)
        Me.btn_file1_view.Name = "btn_file1_view"
        Me.btn_file1_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file1_view.TabIndex = 4
        Me.btn_file1_view.Text = "보기"
        '
        'btn_file3_open
        '
        Me.btn_file3_open.Location = New System.Drawing.Point(261, 239)
        Me.btn_file3_open.Name = "btn_file3_open"
        Me.btn_file3_open.Size = New System.Drawing.Size(75, 21)
        Me.btn_file3_open.TabIndex = 4
        Me.btn_file3_open.Text = "첨부"
        '
        'btn_file2_view
        '
        Me.btn_file2_view.Location = New System.Drawing.Point(342, 212)
        Me.btn_file2_view.Name = "btn_file2_view"
        Me.btn_file2_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file2_view.TabIndex = 4
        Me.btn_file2_view.Text = "보기"
        '
        'btn_file4_open
        '
        Me.btn_file4_open.Location = New System.Drawing.Point(261, 266)
        Me.btn_file4_open.Name = "btn_file4_open"
        Me.btn_file4_open.Size = New System.Drawing.Size(75, 21)
        Me.btn_file4_open.TabIndex = 4
        Me.btn_file4_open.Text = "첨부"
        '
        'btn_file3_view
        '
        Me.btn_file3_view.Location = New System.Drawing.Point(342, 239)
        Me.btn_file3_view.Name = "btn_file3_view"
        Me.btn_file3_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file3_view.TabIndex = 4
        Me.btn_file3_view.Text = "보기"
        '
        'btn_file5_open
        '
        Me.btn_file5_open.Location = New System.Drawing.Point(261, 293)
        Me.btn_file5_open.Name = "btn_file5_open"
        Me.btn_file5_open.Size = New System.Drawing.Size(75, 21)
        Me.btn_file5_open.TabIndex = 4
        Me.btn_file5_open.Text = "첨부"
        '
        'btn_file4_view
        '
        Me.btn_file4_view.Location = New System.Drawing.Point(342, 266)
        Me.btn_file4_view.Name = "btn_file4_view"
        Me.btn_file4_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file4_view.TabIndex = 4
        Me.btn_file4_view.Text = "보기"
        '
        'btn_file5_view
        '
        Me.btn_file5_view.Location = New System.Drawing.Point(342, 293)
        Me.btn_file5_view.Name = "btn_file5_view"
        Me.btn_file5_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file5_view.TabIndex = 4
        Me.btn_file5_view.Text = "보기"
        '
        'qty
        '
        Me.qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.qty.Location = New System.Drawing.Point(6, 135)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(240, 21)
        Me.qty.TabIndex = 7
        Me.qty.Title = "연간생산대수"
        '
        'btn_file1_del
        '
        Me.btn_file1_del.Location = New System.Drawing.Point(423, 185)
        Me.btn_file1_del.Name = "btn_file1_del"
        Me.btn_file1_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file1_del.TabIndex = 4
        Me.btn_file1_del.Text = "삭제"
        '
        'btn_file2_del
        '
        Me.btn_file2_del.Location = New System.Drawing.Point(423, 212)
        Me.btn_file2_del.Name = "btn_file2_del"
        Me.btn_file2_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file2_del.TabIndex = 4
        Me.btn_file2_del.Text = "삭제"
        '
        'btn_file3_del
        '
        Me.btn_file3_del.Location = New System.Drawing.Point(423, 239)
        Me.btn_file3_del.Name = "btn_file3_del"
        Me.btn_file3_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file3_del.TabIndex = 4
        Me.btn_file3_del.Text = "삭제"
        '
        'btn_file4_del
        '
        Me.btn_file4_del.Location = New System.Drawing.Point(423, 266)
        Me.btn_file4_del.Name = "btn_file4_del"
        Me.btn_file4_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file4_del.TabIndex = 4
        Me.btn_file4_del.Text = "삭제"
        '
        'btn_file5_del
        '
        Me.btn_file5_del.Location = New System.Drawing.Point(423, 293)
        Me.btn_file5_del.Name = "btn_file5_del"
        Me.btn_file5_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file5_del.TabIndex = 4
        Me.btn_file5_del.Text = "삭제"
        '
        'todt
        '
        Me.todt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.todt.Location = New System.Drawing.Point(261, 134)
        Me.todt.Name = "todt"
        Me.todt.Size = New System.Drawing.Size(240, 21)
        Me.todt.TabIndex = 9
        Me.todt.Title = "Project 종료일"
        '
        'file1
        '
        Me.file1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file1.Location = New System.Drawing.Point(6, 185)
        Me.file1.Name = "file1"
        Me.file1.Size = New System.Drawing.Size(240, 21)
        Me.file1.TabIndex = 10
        Me.file1.Title = "파일첨부1"
        '
        'pjt_id
        '
        Me.pjt_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pjt_id.Location = New System.Drawing.Point(261, 26)
        Me.pjt_id.Name = "pjt_id"
        Me.pjt_id.Size = New System.Drawing.Size(240, 21)
        Me.pjt_id.TabIndex = 2
        Me.pjt_id.Title = "Project ID"
        '
        'file2
        '
        Me.file2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file2.Location = New System.Drawing.Point(6, 212)
        Me.file2.Name = "file2"
        Me.file2.Size = New System.Drawing.Size(240, 21)
        Me.file2.TabIndex = 11
        Me.file2.Title = "파일첨부2"
        '
        'file3
        '
        Me.file3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file3.Location = New System.Drawing.Point(6, 239)
        Me.file3.Name = "file3"
        Me.file3.Size = New System.Drawing.Size(240, 21)
        Me.file3.TabIndex = 12
        Me.file3.Title = "파일첨부3"
        '
        'eng
        '
        Me.eng.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.eng.Location = New System.Drawing.Point(261, 53)
        Me.eng.Name = "eng"
        Me.eng.Size = New System.Drawing.Size(240, 21)
        Me.eng.TabIndex = 3
        Me.eng.Title = "엔진"
        '
        'file4
        '
        Me.file4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file4.Location = New System.Drawing.Point(6, 266)
        Me.file4.Name = "file4"
        Me.file4.Size = New System.Drawing.Size(240, 21)
        Me.file4.TabIndex = 13
        Me.file4.Title = "파일첨부4"
        '
        'model
        '
        Me.model.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.model.Location = New System.Drawing.Point(261, 80)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(240, 21)
        Me.model.TabIndex = 5
        Me.model.Title = "차종"
        '
        'file5
        '
        Me.file5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file5.Location = New System.Drawing.Point(6, 293)
        Me.file5.Name = "file5"
        Me.file5.Size = New System.Drawing.Size(240, 21)
        Me.file5.TabIndex = 14
        Me.file5.Title = "파일첨부5"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(722, 360)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.g20)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(715, 330)
        Me.XtraTabPage1.Text = "CFT"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(715, 330)
        Me.g20.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.g30)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(715, 330)
        Me.XtraTabPage2.Text = "투자계획"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(715, 330)
        Me.g30.TabIndex = 0
        '
        'DMA300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMA300"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents o_pjt_nm As Frame7.eText
    Friend WithEvents o_eng As Frame7.eText
    Friend WithEvents o_model As Frame7.eText
    Friend WithEvents o_item_no As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents pjt_nm As Frame7.eText
    Friend WithEvents item_no As Frame7.eText
    Friend WithEvents item_nm As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents btn_file1_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents frdt As Frame7.eDate
    Friend WithEvents btn_file2_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file1_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file3_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file2_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file4_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file3_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file5_open As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file4_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file5_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents qty As Frame7.eText
    Friend WithEvents btn_file1_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file2_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file3_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file4_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file5_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents todt As Frame7.eDate
    Friend WithEvents file1 As Frame7.eText
    Friend WithEvents pjt_id As Frame7.eText
    Friend WithEvents file2 As Frame7.eText
    Friend WithEvents file3 As Frame7.eText
    Friend WithEvents eng As Frame7.eText
    Friend WithEvents file4 As Frame7.eText
    Friend WithEvents model As Frame7.eText
    Friend WithEvents file5 As Frame7.eText
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer

End Class
