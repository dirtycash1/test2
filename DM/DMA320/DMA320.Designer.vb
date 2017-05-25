<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMA320
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
        Me.o_pso = New Frame7.eCombo()
        Me.o_pjt_nm = New Frame7.eText()
        Me.o_rev = New Frame7.eCombo()
        Me.o_rslt = New Frame7.eCombo()
        Me.o_pjt_id = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.app_state = New Frame7.eCombo()
        Me.dept_nm = New Frame7.eCombo()
        Me.btn_app = New DevExpress.XtraEditors.SimpleButton()
        Me.rev = New Frame7.eCombo()
        Me.pjt_nm = New Frame7.eText()
        Me.work_dt = New Frame7.eDate()
        Me.btn_app_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.pso = New Frame7.eCombo()
        Me.rslt = New Frame7.eCombo()
        Me.pjt_id = New Frame7.eText()
        Me.emp_no1 = New Frame7.eText()
        Me.emp_nm1 = New Frame7.eText()
        Me.emp_no2 = New Frame7.eText()
        Me.emp_nm2 = New Frame7.eText()
        Me.file = New Frame7.eText()
        Me.btn_file_del = New DevExpress.XtraEditors.SimpleButton()
        Me.file1 = New Frame7.eText()
        Me.btn_file_view = New DevExpress.XtraEditors.SimpleButton()
        Me.file2 = New Frame7.eText()
        Me.btn_file_del1 = New DevExpress.XtraEditors.SimpleButton()
        Me.file3 = New Frame7.eText()
        Me.btn_file_add = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_del2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_view1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_del3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_add1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_view2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_add2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_view3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_file_add3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 138)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(282, 552)
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
        Me.g10.Size = New System.Drawing.Size(278, 527)
        Me.g10.TabIndex = 2
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_pso)
        Me.EPanel1.Controls.Add(Me.o_pjt_nm)
        Me.EPanel1.Controls.Add(Me.o_rev)
        Me.EPanel1.Controls.Add(Me.o_rslt)
        Me.EPanel1.Controls.Add(Me.o_pjt_id)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(282, 138)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     조회조건"
        '
        'o_pso
        '
        Me.o_pso.Location = New System.Drawing.Point(6, 82)
        Me.o_pso.Name = "o_pso"
        Me.o_pso.Size = New System.Drawing.Size(240, 21)
        Me.o_pso.TabIndex = 3
        Me.o_pso.Title = "PSO단계"
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
        'o_rev
        '
        Me.o_rev.Location = New System.Drawing.Point(6, 55)
        Me.o_rev.Name = "o_rev"
        Me.o_rev.Size = New System.Drawing.Size(240, 21)
        Me.o_rev.TabIndex = 3
        Me.o_rev.Title = "Rev."
        '
        'o_rslt
        '
        Me.o_rslt.Location = New System.Drawing.Point(6, 109)
        Me.o_rslt.Name = "o_rslt"
        Me.o_rslt.Size = New System.Drawing.Size(240, 21)
        Me.o_rslt.TabIndex = 3
        Me.o_rslt.Title = "성과물"
        '
        'o_pjt_id
        '
        Me.o_pjt_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_pjt_id.Location = New System.Drawing.Point(252, 27)
        Me.o_pjt_id.Name = "o_pjt_id"
        Me.o_pjt_id.Size = New System.Drawing.Size(240, 21)
        Me.o_pjt_id.TabIndex = 2
        Me.o_pjt_id.Title = "Project ID"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.app_state)
        Me.EPanel3.Controls.Add(Me.dept_nm)
        Me.EPanel3.Controls.Add(Me.btn_app)
        Me.EPanel3.Controls.Add(Me.rev)
        Me.EPanel3.Controls.Add(Me.pjt_nm)
        Me.EPanel3.Controls.Add(Me.work_dt)
        Me.EPanel3.Controls.Add(Me.btn_app_cancel)
        Me.EPanel3.Controls.Add(Me.pso)
        Me.EPanel3.Controls.Add(Me.rslt)
        Me.EPanel3.Controls.Add(Me.pjt_id)
        Me.EPanel3.Controls.Add(Me.emp_no1)
        Me.EPanel3.Controls.Add(Me.emp_nm1)
        Me.EPanel3.Controls.Add(Me.emp_no2)
        Me.EPanel3.Controls.Add(Me.emp_nm2)
        Me.EPanel3.Controls.Add(Me.file)
        Me.EPanel3.Controls.Add(Me.btn_file_del)
        Me.EPanel3.Controls.Add(Me.file1)
        Me.EPanel3.Controls.Add(Me.btn_file_view)
        Me.EPanel3.Controls.Add(Me.file2)
        Me.EPanel3.Controls.Add(Me.btn_file_del1)
        Me.EPanel3.Controls.Add(Me.file3)
        Me.EPanel3.Controls.Add(Me.btn_file_add)
        Me.EPanel3.Controls.Add(Me.btn_file_del2)
        Me.EPanel3.Controls.Add(Me.btn_file_view1)
        Me.EPanel3.Controls.Add(Me.btn_file_del3)
        Me.EPanel3.Controls.Add(Me.btn_file_add1)
        Me.EPanel3.Controls.Add(Me.btn_file_view2)
        Me.EPanel3.Controls.Add(Me.btn_file_add2)
        Me.EPanel3.Controls.Add(Me.btn_file_view3)
        Me.EPanel3.Controls.Add(Me.btn_file_add3)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(714, 690)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Project 등록"
        '
        'app_state
        '
        Me.app_state.Location = New System.Drawing.Point(294, 55)
        Me.app_state.Name = "app_state"
        Me.app_state.Size = New System.Drawing.Size(240, 21)
        Me.app_state.TabIndex = 7
        Me.app_state.Title = "결재상태"
        '
        'dept_nm
        '
        Me.dept_nm.Location = New System.Drawing.Point(6, 164)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 6
        Me.dept_nm.Title = "담당부서"
        '
        'btn_app
        '
        Me.btn_app.Location = New System.Drawing.Point(540, 55)
        Me.btn_app.Name = "btn_app"
        Me.btn_app.Size = New System.Drawing.Size(75, 23)
        Me.btn_app.TabIndex = 8
        Me.btn_app.Text = "결재요청"
        '
        'rev
        '
        Me.rev.Location = New System.Drawing.Point(6, 54)
        Me.rev.Name = "rev"
        Me.rev.Size = New System.Drawing.Size(240, 21)
        Me.rev.TabIndex = 3
        Me.rev.Title = "Rev."
        '
        'pjt_nm
        '
        Me.pjt_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pjt_nm.Location = New System.Drawing.Point(6, 27)
        Me.pjt_nm.Name = "pjt_nm"
        Me.pjt_nm.Size = New System.Drawing.Size(240, 21)
        Me.pjt_nm.TabIndex = 2
        Me.pjt_nm.Title = "Project 명"
        '
        'work_dt
        '
        Me.work_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.work_dt.Location = New System.Drawing.Point(6, 136)
        Me.work_dt.Name = "work_dt"
        Me.work_dt.Size = New System.Drawing.Size(240, 21)
        Me.work_dt.TabIndex = 4
        Me.work_dt.Title = "실시일"
        '
        'btn_app_cancel
        '
        Me.btn_app_cancel.Location = New System.Drawing.Point(621, 54)
        Me.btn_app_cancel.Name = "btn_app_cancel"
        Me.btn_app_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_app_cancel.TabIndex = 8
        Me.btn_app_cancel.Text = "결재취소"
        '
        'pso
        '
        Me.pso.Location = New System.Drawing.Point(6, 81)
        Me.pso.Name = "pso"
        Me.pso.Size = New System.Drawing.Size(240, 21)
        Me.pso.TabIndex = 3
        Me.pso.Title = "PSO단계"
        '
        'rslt
        '
        Me.rslt.Location = New System.Drawing.Point(6, 108)
        Me.rslt.Name = "rslt"
        Me.rslt.Size = New System.Drawing.Size(240, 21)
        Me.rslt.TabIndex = 3
        Me.rslt.Title = "성과물"
        '
        'pjt_id
        '
        Me.pjt_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pjt_id.Location = New System.Drawing.Point(294, 27)
        Me.pjt_id.Name = "pjt_id"
        Me.pjt_id.Size = New System.Drawing.Size(240, 21)
        Me.pjt_id.TabIndex = 2
        Me.pjt_id.Title = "Project ID"
        '
        'emp_no1
        '
        Me.emp_no1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no1.Location = New System.Drawing.Point(6, 210)
        Me.emp_no1.Name = "emp_no1"
        Me.emp_no1.Size = New System.Drawing.Size(240, 21)
        Me.emp_no1.TabIndex = 2
        Me.emp_no1.Title = "작성자1"
        '
        'emp_nm1
        '
        Me.emp_nm1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm1.Location = New System.Drawing.Point(252, 210)
        Me.emp_nm1.Name = "emp_nm1"
        Me.emp_nm1.Size = New System.Drawing.Size(117, 21)
        Me.emp_nm1.TabIndex = 2
        Me.emp_nm1.Title = "작성자1"
        Me.emp_nm1.TitleWidth = 0
        '
        'emp_no2
        '
        Me.emp_no2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_no2.Location = New System.Drawing.Point(6, 237)
        Me.emp_no2.Name = "emp_no2"
        Me.emp_no2.Size = New System.Drawing.Size(240, 21)
        Me.emp_no2.TabIndex = 2
        Me.emp_no2.Title = "작성자2"
        '
        'emp_nm2
        '
        Me.emp_nm2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.emp_nm2.Location = New System.Drawing.Point(252, 237)
        Me.emp_nm2.Name = "emp_nm2"
        Me.emp_nm2.Size = New System.Drawing.Size(117, 21)
        Me.emp_nm2.TabIndex = 2
        Me.emp_nm2.Title = "작성자2"
        Me.emp_nm2.TitleWidth = 0
        '
        'file
        '
        Me.file.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file.Location = New System.Drawing.Point(6, 283)
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(363, 21)
        Me.file.TabIndex = 2
        Me.file.Title = "파일첨부"
        '
        'btn_file_del
        '
        Me.btn_file_del.Location = New System.Drawing.Point(543, 283)
        Me.btn_file_del.Name = "btn_file_del"
        Me.btn_file_del.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_del.TabIndex = 5
        Me.btn_file_del.Text = "삭제"
        '
        'file1
        '
        Me.file1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file1.Location = New System.Drawing.Point(6, 310)
        Me.file1.Name = "file1"
        Me.file1.Size = New System.Drawing.Size(363, 21)
        Me.file1.TabIndex = 2
        Me.file1.Title = "파일첨부"
        '
        'btn_file_view
        '
        Me.btn_file_view.Location = New System.Drawing.Point(459, 283)
        Me.btn_file_view.Name = "btn_file_view"
        Me.btn_file_view.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_view.TabIndex = 5
        Me.btn_file_view.Text = "보기"
        '
        'file2
        '
        Me.file2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file2.Location = New System.Drawing.Point(6, 337)
        Me.file2.Name = "file2"
        Me.file2.Size = New System.Drawing.Size(363, 21)
        Me.file2.TabIndex = 2
        Me.file2.Title = "파일첨부"
        '
        'btn_file_del1
        '
        Me.btn_file_del1.Location = New System.Drawing.Point(543, 310)
        Me.btn_file_del1.Name = "btn_file_del1"
        Me.btn_file_del1.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_del1.TabIndex = 5
        Me.btn_file_del1.Text = "삭제"
        '
        'file3
        '
        Me.file3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.file3.Location = New System.Drawing.Point(6, 364)
        Me.file3.Name = "file3"
        Me.file3.Size = New System.Drawing.Size(363, 21)
        Me.file3.TabIndex = 2
        Me.file3.Title = "파일첨부"
        '
        'btn_file_add
        '
        Me.btn_file_add.Location = New System.Drawing.Point(375, 283)
        Me.btn_file_add.Name = "btn_file_add"
        Me.btn_file_add.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_add.TabIndex = 5
        Me.btn_file_add.Text = "첨부"
        '
        'btn_file_del2
        '
        Me.btn_file_del2.Location = New System.Drawing.Point(543, 337)
        Me.btn_file_del2.Name = "btn_file_del2"
        Me.btn_file_del2.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_del2.TabIndex = 5
        Me.btn_file_del2.Text = "삭제"
        '
        'btn_file_view1
        '
        Me.btn_file_view1.Location = New System.Drawing.Point(459, 310)
        Me.btn_file_view1.Name = "btn_file_view1"
        Me.btn_file_view1.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_view1.TabIndex = 5
        Me.btn_file_view1.Text = "보기"
        '
        'btn_file_del3
        '
        Me.btn_file_del3.Location = New System.Drawing.Point(543, 364)
        Me.btn_file_del3.Name = "btn_file_del3"
        Me.btn_file_del3.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_del3.TabIndex = 5
        Me.btn_file_del3.Text = "삭제"
        '
        'btn_file_add1
        '
        Me.btn_file_add1.Location = New System.Drawing.Point(375, 310)
        Me.btn_file_add1.Name = "btn_file_add1"
        Me.btn_file_add1.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_add1.TabIndex = 5
        Me.btn_file_add1.Text = "첨부"
        '
        'btn_file_view2
        '
        Me.btn_file_view2.Location = New System.Drawing.Point(459, 337)
        Me.btn_file_view2.Name = "btn_file_view2"
        Me.btn_file_view2.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_view2.TabIndex = 5
        Me.btn_file_view2.Text = "보기"
        '
        'btn_file_add2
        '
        Me.btn_file_add2.Location = New System.Drawing.Point(375, 337)
        Me.btn_file_add2.Name = "btn_file_add2"
        Me.btn_file_add2.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_add2.TabIndex = 5
        Me.btn_file_add2.Text = "첨부"
        '
        'btn_file_view3
        '
        Me.btn_file_view3.Location = New System.Drawing.Point(459, 364)
        Me.btn_file_view3.Name = "btn_file_view3"
        Me.btn_file_view3.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_view3.TabIndex = 5
        Me.btn_file_view3.Text = "보기"
        '
        'btn_file_add3
        '
        Me.btn_file_add3.Location = New System.Drawing.Point(375, 364)
        Me.btn_file_add3.Name = "btn_file_add3"
        Me.btn_file_add3.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_add3.TabIndex = 5
        Me.btn_file_add3.Text = "첨부"
        '
        'DMA320
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DMA320"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_pso As Frame7.eCombo
    Friend WithEvents o_pjt_nm As Frame7.eText
    Friend WithEvents o_rslt As Frame7.eCombo
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents work_dt As Frame7.eDate
    Friend WithEvents rev As Frame7.eCombo
    Friend WithEvents pjt_nm As Frame7.eText
    Friend WithEvents pso As Frame7.eCombo
    Friend WithEvents btn_file_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pjt_id As Frame7.eText
    Friend WithEvents btn_file_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents emp_no1 As Frame7.eText
    Friend WithEvents btn_file_del As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents emp_no2 As Frame7.eText
    Friend WithEvents file As Frame7.eText
    Friend WithEvents o_pjt_id As Frame7.eText
    Friend WithEvents o_rev As Frame7.eCombo
    Friend WithEvents rslt As Frame7.eCombo
    Friend WithEvents emp_nm1 As Frame7.eText
    Friend WithEvents emp_nm2 As Frame7.eText
    Friend WithEvents file1 As Frame7.eText
    Friend WithEvents file2 As Frame7.eText
    Friend WithEvents btn_file_del1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents file3 As Frame7.eText
    Friend WithEvents btn_file_del2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_view1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_del3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_add1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_view2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_add2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_view3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_file_add3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dept_nm As Frame7.eCombo
    Friend WithEvents app_state As Frame7.eCombo
    Friend WithEvents btn_app As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_app_cancel As DevExpress.XtraEditors.SimpleButton

End Class
