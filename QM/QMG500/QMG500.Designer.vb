<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMG500
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
        Me.fac_cd = New Frame7.eCombo()
        Me.to_dt = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.chk_no = New Frame7.eCheck()
        Me.cust_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.req_id = New Frame7.eText()
        Me.req_dt = New Frame7.eDate()
        Me.rtn_dt = New Frame7.eDate()
        Me.ntc_bc = New Frame7.eCombo()
        Me.cost_bc = New Frame7.eCombo()
        Me.done_bc = New Frame7.eCombo()
        Me.act_dt = New Frame7.eDate()
        Me.req_dept = New Frame7.eText()
        Me.req_dsc = New Frame7.eMemo()
        Me.req_nm = New Frame7.eText()
        Me.req_dept_nm = New Frame7.eText()
        Me.req_rid = New Frame7.eText()
        Me.EText1 = New Frame7.eText()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1024, 519)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.chk_no)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1024, 80)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     검색"
        '
        'fac_cd
        '
        Me.fac_cd.Location = New System.Drawing.Point(12, 28)
        Me.fac_cd.Name = "fac_cd"
        Me.fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.fac_cd.TabIndex = 13
        Me.fac_cd.Title = "공장"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(264, 52)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 20
        Me.to_dt.Title = "발생기간(to)"
        '
        'cust_cd
        '
        Me.cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_cd.Location = New System.Drawing.Point(516, 28)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 17
        Me.cust_cd.Title = "책임구(거래처)"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(264, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 16
        Me.fr_dt.Title = "발생기간(fr)"
        '
        'chk_no
        '
        Me.chk_no.Caption = ""
        Me.chk_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_no.Location = New System.Drawing.Point(12, 52)
        Me.chk_no.Name = "chk_no"
        Me.chk_no.Size = New System.Drawing.Size(240, 21)
        Me.chk_no.TabIndex = 19
        Me.chk_no.Title = "미처리 만"
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(516, 52)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(240, 21)
        Me.cust_nm.TabIndex = 18
        Me.cust_nm.Title = "책임구(거래처명)"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1024, 435)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     품질이상 통보이력 현황"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(2, 23)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1020, 410)
        Me.SplitContainer2.SplitterDistance = 163
        Me.SplitContainer2.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1020, 163)
        Me.g10.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.EText1)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Controls.Add(Me.req_id)
        Me.EPanel3.Controls.Add(Me.req_dt)
        Me.EPanel3.Controls.Add(Me.rtn_dt)
        Me.EPanel3.Controls.Add(Me.ntc_bc)
        Me.EPanel3.Controls.Add(Me.cost_bc)
        Me.EPanel3.Controls.Add(Me.done_bc)
        Me.EPanel3.Controls.Add(Me.act_dt)
        Me.EPanel3.Controls.Add(Me.req_dept)
        Me.EPanel3.Controls.Add(Me.req_dsc)
        Me.EPanel3.Controls.Add(Me.req_nm)
        Me.EPanel3.Controls.Add(Me.req_dept_nm)
        Me.EPanel3.Controls.Add(Me.req_rid)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1020, 243)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     품질이상 통보이력 등록"
        '
        'req_id
        '
        Me.req_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_id.Location = New System.Drawing.Point(516, 76)
        Me.req_id.Name = "req_id"
        Me.req_id.Size = New System.Drawing.Size(240, 21)
        Me.req_id.TabIndex = 25
        Me.req_id.Title = "통보자"
        '
        'req_dt
        '
        Me.req_dt.Location = New System.Drawing.Point(12, 28)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 2
        Me.req_dt.Title = "통보일자"
        '
        'rtn_dt
        '
        Me.rtn_dt.Location = New System.Drawing.Point(12, 52)
        Me.rtn_dt.Name = "rtn_dt"
        Me.rtn_dt.Size = New System.Drawing.Size(240, 21)
        Me.rtn_dt.TabIndex = 3
        Me.rtn_dt.Title = "회신요구일"
        '
        'ntc_bc
        '
        Me.ntc_bc.Location = New System.Drawing.Point(264, 76)
        Me.ntc_bc.Name = "ntc_bc"
        Me.ntc_bc.Size = New System.Drawing.Size(240, 21)
        Me.ntc_bc.TabIndex = 31
        Me.ntc_bc.Title = "통보방법"
        '
        'cost_bc
        '
        Me.cost_bc.Location = New System.Drawing.Point(264, 52)
        Me.cost_bc.Name = "cost_bc"
        Me.cost_bc.Size = New System.Drawing.Size(240, 21)
        Me.cost_bc.TabIndex = 30
        Me.cost_bc.Title = "비용공제"
        '
        'done_bc
        '
        Me.done_bc.Location = New System.Drawing.Point(264, 28)
        Me.done_bc.Name = "done_bc"
        Me.done_bc.Size = New System.Drawing.Size(240, 21)
        Me.done_bc.TabIndex = 29
        Me.done_bc.Title = "불량처리"
        '
        'act_dt
        '
        Me.act_dt.Location = New System.Drawing.Point(12, 76)
        Me.act_dt.Name = "act_dt"
        Me.act_dt.Size = New System.Drawing.Size(240, 21)
        Me.act_dt.TabIndex = 28
        Me.act_dt.Title = "회신일자"
        '
        'req_dept
        '
        Me.req_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept.Location = New System.Drawing.Point(516, 52)
        Me.req_dept.Name = "req_dept"
        Me.req_dept.Size = New System.Drawing.Size(240, 21)
        Me.req_dept.TabIndex = 23
        Me.req_dept.Title = "통보부서"
        '
        'req_dsc
        '
        Me.req_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dsc.Location = New System.Drawing.Point(12, 100)
        Me.req_dsc.Name = "req_dsc"
        Me.req_dsc.Size = New System.Drawing.Size(988, 60)
        Me.req_dsc.TabIndex = 27
        Me.req_dsc.Title = "의뢰사항"
        '
        'req_nm
        '
        Me.req_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_nm.Location = New System.Drawing.Point(640, 76)
        Me.req_nm.Name = "req_nm"
        Me.req_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_nm.TabIndex = 26
        Me.req_nm.Title = "통보자명"
        '
        'req_dept_nm
        '
        Me.req_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept_nm.Location = New System.Drawing.Point(640, 52)
        Me.req_dept_nm.Name = "req_dept_nm"
        Me.req_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_dept_nm.TabIndex = 24
        Me.req_dept_nm.Title = "통보부서명"
        '
        'req_rid
        '
        Me.req_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid.Location = New System.Drawing.Point(516, 28)
        Me.req_rid.Name = "req_rid"
        Me.req_rid.Size = New System.Drawing.Size(100, 21)
        Me.req_rid.TabIndex = 25
        Me.req_rid.Title = "req_rid"
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(12, 163)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(120, 21)
        Me.EText1.TabIndex = 41
        Me.EText1.Title = "첨부문서"
        '
        'g20
        '
        Me.g20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.g20.Location = New System.Drawing.Point(132, 162)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(868, 78)
        Me.g20.TabIndex = 42
        '
        'QMG500
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMG500"
        Me.Size = New System.Drawing.Size(1024, 519)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents fac_cd As Frame7.eCombo
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents chk_no As Frame7.eCheck
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents rtn_dt As Frame7.eDate
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents req_rid As Frame7.eText
    Friend WithEvents req_nm As Frame7.eText
    Friend WithEvents req_dept As Frame7.eText
    Friend WithEvents req_dept_nm As Frame7.eText
    Friend WithEvents req_dsc As Frame7.eMemo
    Friend WithEvents ntc_bc As Frame7.eCombo
    Friend WithEvents cost_bc As Frame7.eCombo
    Friend WithEvents done_bc As Frame7.eCombo
    Friend WithEvents act_dt As Frame7.eDate
    Friend WithEvents req_id As Frame7.eText
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid

End Class
