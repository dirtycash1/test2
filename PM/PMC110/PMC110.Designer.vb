<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMC110
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
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.f_prj_nm = New Frame7.eText()
        Me.f_prj_cd = New Frame7.eText()
        Me.f_prj_bc = New Frame7.eCheckCombo()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel3 = New Frame7.ePanel()
        Me.step_no = New Frame7.eCombo()
        Me.ent_id = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.prj_bc = New Frame7.eCombo()
        Me.stat_bc = New Frame7.eCombo()
        Me.prj_nm = New Frame7.eText()
        Me.prj_cd = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.ECheck3 = New Frame7.eCheck()
        Me.photo3 = New Frame7.eImage()
        Me.ECheck2 = New Frame7.eCheck()
        Me.photo2 = New Frame7.eImage()
        Me.aft_dsc = New Frame7.eMemo()
        Me.imp_dsc = New Frame7.eMemo()
        Me.act_dt = New Frame7.eDate()
        Me.reason = New Frame7.eMemo()
        Me.iss_dsc = New Frame7.eMemo()
        Me.iss_bc = New Frame7.eCombo()
        Me.plan_dt = New Frame7.eDate()
        Me.ECheck1 = New Frame7.eCheck()
        Me.photo1 = New Frame7.eImage()
        Me.mng_dept_nm = New Frame7.eText()
        Me.mng_nm = New Frame7.eText()
        Me.dept_nm = New Frame7.eText()
        Me.nm = New Frame7.eText()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1096, 672)
        Me.SplitContainer1.SplitterDistance = 322
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SplitContainer3)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(322, 672)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_nm)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_cd)
        Me.SplitContainer3.Panel1.Controls.Add(Me.f_prj_bc)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer3.Size = New System.Drawing.Size(318, 647)
        Me.SplitContainer3.SplitterDistance = 82
        Me.SplitContainer3.TabIndex = 2
        '
        'f_prj_nm
        '
        Me.f_prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_nm.Location = New System.Drawing.Point(8, 8)
        Me.f_prj_nm.Name = "f_prj_nm"
        Me.f_prj_nm.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_nm.TabIndex = 1
        Me.f_prj_nm.Title = "Project 명"
        '
        'f_prj_cd
        '
        Me.f_prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_prj_cd.Location = New System.Drawing.Point(8, 32)
        Me.f_prj_cd.Name = "f_prj_cd"
        Me.f_prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_cd.TabIndex = 2
        Me.f_prj_cd.Title = "Project 코드"
        '
        'f_prj_bc
        '
        Me.f_prj_bc.Location = New System.Drawing.Point(8, 56)
        Me.f_prj_bc.Name = "f_prj_bc"
        Me.f_prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.f_prj_bc.TabIndex = 3
        Me.f_prj_bc.Title = "Project 구분"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(318, 561)
        Me.g10.TabIndex = 3
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(770, 672)
        Me.SplitContainer2.SplitterDistance = 105
        Me.SplitContainer2.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.mng_dept_nm)
        Me.EPanel3.Controls.Add(Me.mng_nm)
        Me.EPanel3.Controls.Add(Me.to_dt)
        Me.EPanel3.Controls.Add(Me.fr_dt)
        Me.EPanel3.Controls.Add(Me.prj_bc)
        Me.EPanel3.Controls.Add(Me.stat_bc)
        Me.EPanel3.Controls.Add(Me.prj_nm)
        Me.EPanel3.Controls.Add(Me.prj_cd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(770, 105)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     Project 조회"
        '
        'step_no
        '
        Me.step_no.Location = New System.Drawing.Point(8, 28)
        Me.step_no.Name = "step_no"
        Me.step_no.Size = New System.Drawing.Size(364, 21)
        Me.step_no.TabIndex = 15
        '
        'ent_id
        '
        Me.ent_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ent_id.Location = New System.Drawing.Point(392, 28)
        Me.ent_id.Name = "ent_id"
        Me.ent_id.Size = New System.Drawing.Size(240, 21)
        Me.ent_id.TabIndex = 14
        Me.ent_id.Title = "등록id"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(504, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 6
        Me.to_dt.Title = "종료일"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(504, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 5
        Me.fr_dt.Title = "시작일"
        '
        'prj_bc
        '
        Me.prj_bc.Location = New System.Drawing.Point(256, 28)
        Me.prj_bc.Name = "prj_bc"
        Me.prj_bc.Size = New System.Drawing.Size(240, 21)
        Me.prj_bc.TabIndex = 7
        Me.prj_bc.Title = "Project 구분"
        '
        'stat_bc
        '
        Me.stat_bc.Location = New System.Drawing.Point(504, 76)
        Me.stat_bc.Name = "stat_bc"
        Me.stat_bc.Size = New System.Drawing.Size(240, 21)
        Me.stat_bc.TabIndex = 4
        Me.stat_bc.Title = "Project 상태"
        '
        'prj_nm
        '
        Me.prj_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_nm.Location = New System.Drawing.Point(8, 52)
        Me.prj_nm.Name = "prj_nm"
        Me.prj_nm.Size = New System.Drawing.Size(488, 21)
        Me.prj_nm.TabIndex = 3
        Me.prj_nm.Title = "Project 명"
        '
        'prj_cd
        '
        Me.prj_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.prj_cd.Location = New System.Drawing.Point(8, 28)
        Me.prj_cd.Name = "prj_cd"
        Me.prj_cd.Size = New System.Drawing.Size(240, 21)
        Me.prj_cd.TabIndex = 2
        Me.prj_cd.Title = "Project 코드"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer4)
        Me.EPanel2.Controls.Add(Me.dept_nm)
        Me.EPanel2.Controls.Add(Me.nm)
        Me.EPanel2.Controls.Add(Me.ent_id)
        Me.EPanel2.Controls.Add(Me.photo1)
        Me.EPanel2.Controls.Add(Me.aft_dsc)
        Me.EPanel2.Controls.Add(Me.imp_dsc)
        Me.EPanel2.Controls.Add(Me.act_dt)
        Me.EPanel2.Controls.Add(Me.reason)
        Me.EPanel2.Controls.Add(Me.step_no)
        Me.EPanel2.Controls.Add(Me.iss_dsc)
        Me.EPanel2.Controls.Add(Me.iss_bc)
        Me.EPanel2.Controls.Add(Me.plan_dt)
        Me.EPanel2.Controls.Add(Me.ECheck1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(770, 563)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     Project 단계별 문제점등록"
        '
        'ECheck3
        '
        Me.ECheck3.Caption = ""
        Me.ECheck3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck3.Location = New System.Drawing.Point(0, 0)
        Me.ECheck3.Name = "ECheck3"
        Me.ECheck3.Size = New System.Drawing.Size(120, 21)
        Me.ECheck3.TabIndex = 26
        Me.ECheck3.Title = "개선 후 사진2"
        Me.ECheck3.TitleWidth = 120
        '
        'photo3
        '
        Me.photo3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.photo3.Location = New System.Drawing.Point(0, 20)
        Me.photo3.Name = "photo3"
        Me.photo3.Size = New System.Drawing.Size(253, 220)
        Me.photo3.TabIndex = 25
        Me.photo3.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'ECheck2
        '
        Me.ECheck2.Caption = ""
        Me.ECheck2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck2.Location = New System.Drawing.Point(0, 0)
        Me.ECheck2.Name = "ECheck2"
        Me.ECheck2.Size = New System.Drawing.Size(120, 21)
        Me.ECheck2.TabIndex = 24
        Me.ECheck2.Title = "개선 후 사진1"
        Me.ECheck2.TitleWidth = 120
        '
        'photo2
        '
        Me.photo2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.photo2.Location = New System.Drawing.Point(0, 20)
        Me.photo2.Name = "photo2"
        Me.photo2.Size = New System.Drawing.Size(259, 220)
        Me.photo2.TabIndex = 23
        Me.photo2.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'aft_dsc
        '
        Me.aft_dsc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aft_dsc.Location = New System.Drawing.Point(8, 256)
        Me.aft_dsc.Name = "aft_dsc"
        Me.aft_dsc.Size = New System.Drawing.Size(744, 50)
        Me.aft_dsc.TabIndex = 22
        Me.aft_dsc.Title = "원인"
        '
        'imp_dsc
        '
        Me.imp_dsc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imp_dsc.Location = New System.Drawing.Point(8, 204)
        Me.imp_dsc.Name = "imp_dsc"
        Me.imp_dsc.Size = New System.Drawing.Size(744, 50)
        Me.imp_dsc.TabIndex = 21
        Me.imp_dsc.Title = "문제점"
        '
        'act_dt
        '
        Me.act_dt.Location = New System.Drawing.Point(392, 76)
        Me.act_dt.Name = "act_dt"
        Me.act_dt.Size = New System.Drawing.Size(240, 21)
        Me.act_dt.TabIndex = 18
        Me.act_dt.Title = "개선완료일"
        '
        'reason
        '
        Me.reason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reason.Location = New System.Drawing.Point(8, 152)
        Me.reason.Name = "reason"
        Me.reason.Size = New System.Drawing.Size(744, 50)
        Me.reason.TabIndex = 15
        Me.reason.Title = "원인"
        '
        'iss_dsc
        '
        Me.iss_dsc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iss_dsc.Location = New System.Drawing.Point(8, 100)
        Me.iss_dsc.Name = "iss_dsc"
        Me.iss_dsc.Size = New System.Drawing.Size(744, 50)
        Me.iss_dsc.TabIndex = 14
        Me.iss_dsc.Title = "문제점"
        '
        'iss_bc
        '
        Me.iss_bc.Location = New System.Drawing.Point(8, 76)
        Me.iss_bc.Name = "iss_bc"
        Me.iss_bc.Size = New System.Drawing.Size(240, 21)
        Me.iss_bc.TabIndex = 19
        Me.iss_bc.Title = "문제점구분"
        '
        'plan_dt
        '
        Me.plan_dt.Location = New System.Drawing.Point(392, 52)
        Me.plan_dt.Name = "plan_dt"
        Me.plan_dt.Size = New System.Drawing.Size(240, 21)
        Me.plan_dt.TabIndex = 17
        Me.plan_dt.Title = "개선계획일"
        '
        'ECheck1
        '
        Me.ECheck1.Caption = ""
        Me.ECheck1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ECheck1.Location = New System.Drawing.Point(8, 312)
        Me.ECheck1.Name = "ECheck1"
        Me.ECheck1.Size = New System.Drawing.Size(120, 21)
        Me.ECheck1.TabIndex = 20
        Me.ECheck1.Title = "문제점 사진"
        Me.ECheck1.TitleWidth = 120
        '
        'photo1
        '
        Me.photo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.photo1.Location = New System.Drawing.Point(8, 332)
        Me.photo1.Name = "photo1"
        Me.photo1.Size = New System.Drawing.Size(224, 220)
        Me.photo1.TabIndex = 16
        Me.photo1.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'mng_dept_nm
        '
        Me.mng_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mng_dept_nm.Location = New System.Drawing.Point(8, 76)
        Me.mng_dept_nm.Name = "mng_dept_nm"
        Me.mng_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.mng_dept_nm.TabIndex = 16
        Me.mng_dept_nm.Title = "담당부서"
        '
        'mng_nm
        '
        Me.mng_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mng_nm.Location = New System.Drawing.Point(132, 76)
        Me.mng_nm.Name = "mng_nm"
        Me.mng_nm.Size = New System.Drawing.Size(240, 21)
        Me.mng_nm.TabIndex = 17
        Me.mng_nm.Title = "담당부서명"
        '
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(8, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 28
        Me.dept_nm.Title = "개선부서"
        '
        'nm
        '
        Me.nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.nm.Location = New System.Drawing.Point(132, 52)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(240, 21)
        Me.nm.TabIndex = 29
        Me.nm.Title = "개선부서명"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer4.Location = New System.Drawing.Point(236, 312)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.photo2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.ECheck2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.photo3)
        Me.SplitContainer4.Panel2.Controls.Add(Me.ECheck3)
        Me.SplitContainer4.Size = New System.Drawing.Size(516, 240)
        Me.SplitContainer4.SplitterDistance = 258
        Me.SplitContainer4.TabIndex = 30
        '
        'PMC110
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PMC110"
        Me.Size = New System.Drawing.Size(1234, 682)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents f_prj_cd As Frame7.eText
    Friend WithEvents f_prj_bc As Frame7.eCheckCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents f_prj_nm As Frame7.eText
    Friend WithEvents prj_bc As Frame7.eCombo
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents stat_bc As Frame7.eCombo
    Friend WithEvents prj_nm As Frame7.eText
    Friend WithEvents prj_cd As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents reason As Frame7.eMemo
    Friend WithEvents iss_dsc As Frame7.eMemo
    Friend WithEvents iss_bc As Frame7.eCombo
    Friend WithEvents act_dt As Frame7.eDate
    Friend WithEvents plan_dt As Frame7.eDate
    Friend WithEvents photo1 As Frame7.eImage
    Friend WithEvents ECheck1 As Frame7.eCheck
    Friend WithEvents ent_id As Frame7.eText
    Friend WithEvents step_no As Frame7.eCombo
    Friend WithEvents ECheck3 As Frame7.eCheck
    Friend WithEvents photo3 As Frame7.eImage
    Friend WithEvents ECheck2 As Frame7.eCheck
    Friend WithEvents photo2 As Frame7.eImage
    Friend WithEvents aft_dsc As Frame7.eMemo
    Friend WithEvents imp_dsc As Frame7.eMemo
    Friend WithEvents mng_dept_nm As Frame7.eText
    Friend WithEvents mng_nm As Frame7.eText
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer

End Class
