<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QMG300
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
        Me.dept_cd = New Frame7.eText()
        Me.fr_dt = New Frame7.eDate()
        Me.req_rid = New Frame7.eText()
        Me.chk_no = New Frame7.eCheck()
        Me.dept_nm = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.EPanel3 = New Frame7.ePanel()
        Me.EText1 = New Frame7.eText()
        Me.req_id = New Frame7.eText()
        Me.g20 = New Frame7.eGrid()
        Me.req_dept = New Frame7.eText()
        Me.rtn2_dept = New Frame7.eText()
        Me.req_dsc = New Frame7.eMemo()
        Me.req_nm = New Frame7.eText()
        Me.rtn_dept = New Frame7.eText()
        Me.rtn_dt = New Frame7.eDate()
        Me.req_dt = New Frame7.eDate()
        Me.ftp_ip = New Frame7.eText()
        Me.req_dept_nm = New Frame7.eText()
        Me.ftp_port = New Frame7.eText()
        Me.rtn_dept_nm = New Frame7.eText()
        Me.rtn2_dept_nm = New Frame7.eText()
        Me.ftp_id = New Frame7.eText()
        Me.ftp_path = New Frame7.eText()
        Me.ftp_pwd = New Frame7.eText()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1028, 536)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.fac_cd)
        Me.EPanel1.Controls.Add(Me.to_dt)
        Me.EPanel1.Controls.Add(Me.dept_cd)
        Me.EPanel1.Controls.Add(Me.fr_dt)
        Me.EPanel1.Controls.Add(Me.req_rid)
        Me.EPanel1.Controls.Add(Me.chk_no)
        Me.EPanel1.Controls.Add(Me.dept_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1028, 81)
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
        'dept_cd
        '
        Me.dept_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_cd.Location = New System.Drawing.Point(516, 28)
        Me.dept_cd.Name = "dept_cd"
        Me.dept_cd.Size = New System.Drawing.Size(240, 21)
        Me.dept_cd.TabIndex = 17
        Me.dept_cd.Title = "책임구(부서)"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(264, 28)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 16
        Me.fr_dt.Title = "발생기간(fr)"
        '
        'req_rid
        '
        Me.req_rid.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_rid.Location = New System.Drawing.Point(818, 44)
        Me.req_rid.Name = "req_rid"
        Me.req_rid.Size = New System.Drawing.Size(146, 21)
        Me.req_rid.TabIndex = 25
        Me.req_rid.Title = "req_rid"
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
        'dept_nm
        '
        Me.dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dept_nm.Location = New System.Drawing.Point(516, 52)
        Me.dept_nm.Name = "dept_nm"
        Me.dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.dept_nm.TabIndex = 18
        Me.dept_nm.Title = "책임구(부서명)"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.SplitContainer2)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1028, 451)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     시정조치 의뢰 현황"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1024, 426)
        Me.SplitContainer2.SplitterDistance = 209
        Me.SplitContainer2.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1024, 209)
        Me.g10.TabIndex = 0
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.EText1)
        Me.EPanel3.Controls.Add(Me.req_id)
        Me.EPanel3.Controls.Add(Me.g20)
        Me.EPanel3.Controls.Add(Me.req_dept)
        Me.EPanel3.Controls.Add(Me.rtn2_dept)
        Me.EPanel3.Controls.Add(Me.req_dsc)
        Me.EPanel3.Controls.Add(Me.req_nm)
        Me.EPanel3.Controls.Add(Me.rtn_dept)
        Me.EPanel3.Controls.Add(Me.rtn_dt)
        Me.EPanel3.Controls.Add(Me.req_dt)
        Me.EPanel3.Controls.Add(Me.ftp_ip)
        Me.EPanel3.Controls.Add(Me.req_dept_nm)
        Me.EPanel3.Controls.Add(Me.ftp_port)
        Me.EPanel3.Controls.Add(Me.rtn_dept_nm)
        Me.EPanel3.Controls.Add(Me.rtn2_dept_nm)
        Me.EPanel3.Controls.Add(Me.ftp_id)
        Me.EPanel3.Controls.Add(Me.ftp_path)
        Me.EPanel3.Controls.Add(Me.ftp_pwd)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1024, 213)
        Me.EPanel3.TabIndex = 0
        Me.EPanel3.Text = "     시정조치 의뢰 등록"
        '
        'EText1
        '
        Me.EText1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.EText1.Location = New System.Drawing.Point(8, 128)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(120, 21)
        Me.EText1.TabIndex = 26
        Me.EText1.Title = "첨부문서"
        '
        'req_id
        '
        Me.req_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_id.Location = New System.Drawing.Point(640, 52)
        Me.req_id.Name = "req_id"
        Me.req_id.Size = New System.Drawing.Size(240, 21)
        Me.req_id.TabIndex = 26
        Me.req_id.Title = "의뢰자"
        '
        'g20
        '
        Me.g20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.g20.Location = New System.Drawing.Point(128, 127)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(876, 82)
        Me.g20.TabIndex = 40
        '
        'req_dept
        '
        Me.req_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept.Location = New System.Drawing.Point(640, 28)
        Me.req_dept.Name = "req_dept"
        Me.req_dept.Size = New System.Drawing.Size(240, 21)
        Me.req_dept.TabIndex = 23
        Me.req_dept.Title = "의뢰부서"
        '
        'rtn2_dept
        '
        Me.rtn2_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rtn2_dept.Location = New System.Drawing.Point(260, 52)
        Me.rtn2_dept.Name = "rtn2_dept"
        Me.rtn2_dept.Size = New System.Drawing.Size(240, 21)
        Me.rtn2_dept.TabIndex = 21
        Me.rtn2_dept.Title = "변경회신부서"
        '
        'req_dsc
        '
        Me.req_dsc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dsc.Location = New System.Drawing.Point(8, 76)
        Me.req_dsc.Name = "req_dsc"
        Me.req_dsc.Size = New System.Drawing.Size(996, 48)
        Me.req_dsc.TabIndex = 27
        Me.req_dsc.Title = "의뢰사항"
        '
        'req_nm
        '
        Me.req_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_nm.Location = New System.Drawing.Point(764, 52)
        Me.req_nm.Name = "req_nm"
        Me.req_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_nm.TabIndex = 26
        Me.req_nm.Title = "의뢰자명"
        '
        'rtn_dept
        '
        Me.rtn_dept.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rtn_dept.Location = New System.Drawing.Point(260, 28)
        Me.rtn_dept.Name = "rtn_dept"
        Me.rtn_dept.Size = New System.Drawing.Size(240, 21)
        Me.rtn_dept.TabIndex = 19
        Me.rtn_dept.Title = "회신부서"
        '
        'rtn_dt
        '
        Me.rtn_dt.Location = New System.Drawing.Point(8, 52)
        Me.rtn_dt.Name = "rtn_dt"
        Me.rtn_dt.Size = New System.Drawing.Size(240, 21)
        Me.rtn_dt.TabIndex = 3
        Me.rtn_dt.Title = "회신요구일"
        '
        'req_dt
        '
        Me.req_dt.Location = New System.Drawing.Point(8, 28)
        Me.req_dt.Name = "req_dt"
        Me.req_dt.Size = New System.Drawing.Size(240, 21)
        Me.req_dt.TabIndex = 2
        Me.req_dt.Title = "의뢰일자"
        '
        'ftp_ip
        '
        Me.ftp_ip.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ftp_ip.Location = New System.Drawing.Point(144, 216)
        Me.ftp_ip.Name = "ftp_ip"
        Me.ftp_ip.Size = New System.Drawing.Size(240, 21)
        Me.ftp_ip.TabIndex = 28
        Me.ftp_ip.Title = "URL"
        '
        'req_dept_nm
        '
        Me.req_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.req_dept_nm.Location = New System.Drawing.Point(764, 28)
        Me.req_dept_nm.Name = "req_dept_nm"
        Me.req_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.req_dept_nm.TabIndex = 24
        Me.req_dept_nm.Title = "의뢰부서명"
        '
        'ftp_port
        '
        Me.ftp_port.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ftp_port.Location = New System.Drawing.Point(144, 240)
        Me.ftp_port.Name = "ftp_port"
        Me.ftp_port.Size = New System.Drawing.Size(240, 21)
        Me.ftp_port.TabIndex = 29
        Me.ftp_port.Title = "Port"
        '
        'rtn_dept_nm
        '
        Me.rtn_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rtn_dept_nm.Location = New System.Drawing.Point(384, 28)
        Me.rtn_dept_nm.Name = "rtn_dept_nm"
        Me.rtn_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.rtn_dept_nm.TabIndex = 20
        Me.rtn_dept_nm.Title = "회신부서명"
        '
        'rtn2_dept_nm
        '
        Me.rtn2_dept_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rtn2_dept_nm.Location = New System.Drawing.Point(384, 52)
        Me.rtn2_dept_nm.Name = "rtn2_dept_nm"
        Me.rtn2_dept_nm.Size = New System.Drawing.Size(240, 21)
        Me.rtn2_dept_nm.TabIndex = 22
        Me.rtn2_dept_nm.Title = "변경회신부서명"
        '
        'ftp_id
        '
        Me.ftp_id.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ftp_id.Location = New System.Drawing.Point(392, 216)
        Me.ftp_id.Name = "ftp_id"
        Me.ftp_id.Size = New System.Drawing.Size(240, 21)
        Me.ftp_id.TabIndex = 30
        Me.ftp_id.Title = "ftpID"
        '
        'ftp_path
        '
        Me.ftp_path.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ftp_path.Location = New System.Drawing.Point(648, 220)
        Me.ftp_path.Name = "ftp_path"
        Me.ftp_path.Size = New System.Drawing.Size(240, 21)
        Me.ftp_path.TabIndex = 32
        Me.ftp_path.Title = "경로"
        '
        'ftp_pwd
        '
        Me.ftp_pwd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ftp_pwd.Location = New System.Drawing.Point(392, 240)
        Me.ftp_pwd.Name = "ftp_pwd"
        Me.ftp_pwd.Size = New System.Drawing.Size(240, 21)
        Me.ftp_pwd.TabIndex = 31
        Me.ftp_pwd.Title = "ftp_pw"
        '
        'QMG300
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "QMG300"
        Me.Size = New System.Drawing.Size(1034, 699)
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
    Friend WithEvents dept_cd As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents dept_nm As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents chk_no As Frame7.eCheck
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents rtn_dept As Frame7.eText
    Friend WithEvents rtn_dept_nm As Frame7.eText
    Friend WithEvents rtn_dt As Frame7.eDate
    Friend WithEvents req_dt As Frame7.eDate
    Friend WithEvents req_rid As Frame7.eText
    Friend WithEvents req_nm As Frame7.eText
    Friend WithEvents req_dept As Frame7.eText
    Friend WithEvents req_dept_nm As Frame7.eText
    Friend WithEvents rtn2_dept As Frame7.eText
    Friend WithEvents rtn2_dept_nm As Frame7.eText
    Friend WithEvents req_dsc As Frame7.eMemo
    Friend WithEvents req_id As Frame7.eText
    Friend WithEvents ftp_path As Frame7.eText
    Friend WithEvents ftp_pwd As Frame7.eText
    Friend WithEvents ftp_id As Frame7.eText
    Friend WithEvents ftp_port As Frame7.eText
    Friend WithEvents ftp_ip As Frame7.eText
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents EText1 As Frame7.eText

End Class
