<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAB800
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
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.amt1 = New Frame7.eText()
        Me.acc_cd = New Frame7.eText()
        Me.gap_amt1 = New Frame7.eText()
        Me.acc_nm = New Frame7.eText()
        Me.amt2 = New Frame7.eText()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.EPanel3 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.acc_cd2 = New Frame7.eText()
        Me.acc_nm2 = New Frame7.eText()
        Me.acc_sum_proc = New DevExpress.XtraEditors.SimpleButton()
        Me.kd = New Frame7.eText()
        Me.dummy = New Frame7.eText()
        Me.deb_amt2 = New Frame7.eText()
        Me.mng_no2 = New Frame7.eCombo()
        Me.cre_amt2 = New Frame7.eText()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.mng_no3 = New Frame7.eCombo()
        Me.mng_val3 = New Frame7.eText()
        Me.mng_dsc3 = New Frame7.eText()
        Me.acc_cd3 = New Frame7.eText()
        Me.acc_nm3 = New Frame7.eText()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g30 = New Frame7.eGrid()
        Me.doc_mon = New Frame7.eDate()
        Me.cury_bc = New Frame7.eCombo()
        Me.div_cd = New Frame7.eCombo()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.co_cd = New Frame7.eCombo()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(1040, 463)
        Me.XtraTabControl2.TabIndex = 5
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1033, 433)
        Me.XtraTabPage1.Text = "계정별 기초금액 등록"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.PanelControl1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer4.Size = New System.Drawing.Size(1033, 433)
        Me.SplitContainer4.SplitterDistance = 61
        Me.SplitContainer4.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl1.Controls.Add(Me.amt1)
        Me.PanelControl1.Controls.Add(Me.acc_cd)
        Me.PanelControl1.Controls.Add(Me.gap_amt1)
        Me.PanelControl1.Controls.Add(Me.acc_nm)
        Me.PanelControl1.Controls.Add(Me.amt2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1033, 61)
        Me.PanelControl1.TabIndex = 62
        '
        'amt1
        '
        Me.amt1.Location = New System.Drawing.Point(276, 32)
        Me.amt1.Name = "amt1"
        Me.amt1.Size = New System.Drawing.Size(240, 21)
        Me.amt1.TabIndex = 57
        Me.amt1.Title = "차변잔액"
        '
        'acc_cd
        '
        Me.acc_cd.Location = New System.Drawing.Point(12, 8)
        Me.acc_cd.Name = "acc_cd"
        Me.acc_cd.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd.TabIndex = 50
        Me.acc_cd.Title = "계정코드(%)"
        '
        'gap_amt1
        '
        Me.gap_amt1.Location = New System.Drawing.Point(644, 32)
        Me.gap_amt1.Name = "gap_amt1"
        Me.gap_amt1.Size = New System.Drawing.Size(240, 21)
        Me.gap_amt1.TabIndex = 59
        Me.gap_amt1.Title = "차      이"
        '
        'acc_nm
        '
        Me.acc_nm.Location = New System.Drawing.Point(12, 32)
        Me.acc_nm.Name = "acc_nm"
        Me.acc_nm.Size = New System.Drawing.Size(240, 21)
        Me.acc_nm.TabIndex = 51
        Me.acc_nm.Title = "계정명(%)"
        '
        'amt2
        '
        Me.amt2.Location = New System.Drawing.Point(400, 32)
        Me.amt2.Name = "amt2"
        Me.amt2.Size = New System.Drawing.Size(240, 21)
        Me.amt2.TabIndex = 58
        Me.amt2.Title = "대변잔액"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(900, 28)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(120, 24)
        Me.SimpleButton4.TabIndex = 52
        Me.SimpleButton4.Text = "계정가져오기"
        Me.SimpleButton4.Visible = False
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.g10)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(1033, 368)
        Me.EPanel3.TabIndex = 2
        Me.EPanel3.Text = "     계정별기초금액"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1029, 343)
        Me.g10.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SplitContainer2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1033, 433)
        Me.XtraTabPage2.Text = "관리항목별 기초금액 등록"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelControl2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.EPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1033, 433)
        Me.SplitContainer2.SplitterDistance = 61
        Me.SplitContainer2.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl2.Controls.Add(Me.acc_cd2)
        Me.PanelControl2.Controls.Add(Me.acc_nm2)
        Me.PanelControl2.Controls.Add(Me.acc_sum_proc)
        Me.PanelControl2.Controls.Add(Me.kd)
        Me.PanelControl2.Controls.Add(Me.dummy)
        Me.PanelControl2.Controls.Add(Me.deb_amt2)
        Me.PanelControl2.Controls.Add(Me.mng_no2)
        Me.PanelControl2.Controls.Add(Me.cre_amt2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1033, 61)
        Me.PanelControl2.TabIndex = 81
        '
        'acc_cd2
        '
        Me.acc_cd2.Location = New System.Drawing.Point(12, 32)
        Me.acc_cd2.Name = "acc_cd2"
        Me.acc_cd2.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd2.TabIndex = 64
        Me.acc_cd2.Title = "계정코드"
        '
        'acc_nm2
        '
        Me.acc_nm2.Location = New System.Drawing.Point(256, 32)
        Me.acc_nm2.Name = "acc_nm2"
        Me.acc_nm2.Size = New System.Drawing.Size(200, 21)
        Me.acc_nm2.TabIndex = 65
        Me.acc_nm2.Title = ""
        Me.acc_nm2.TitleWidth = 0
        '
        'acc_sum_proc
        '
        Me.acc_sum_proc.Location = New System.Drawing.Point(684, 4)
        Me.acc_sum_proc.Name = "acc_sum_proc"
        Me.acc_sum_proc.Size = New System.Drawing.Size(156, 24)
        Me.acc_sum_proc.TabIndex = 66
        Me.acc_sum_proc.Text = "계정기초금액적용"
        Me.acc_sum_proc.Visible = False
        '
        'kd
        '
        Me.kd.Location = New System.Drawing.Point(256, 8)
        Me.kd.Name = "kd"
        Me.kd.Size = New System.Drawing.Size(64, 21)
        Me.kd.TabIndex = 77
        Me.kd.Title = "dummy"
        Me.kd.TitleWidth = 0
        '
        'dummy
        '
        Me.dummy.Location = New System.Drawing.Point(944, 32)
        Me.dummy.Name = "dummy"
        Me.dummy.Size = New System.Drawing.Size(92, 21)
        Me.dummy.TabIndex = 77
        Me.dummy.Title = "dummy"
        Me.dummy.Visible = False
        '
        'deb_amt2
        '
        Me.deb_amt2.Location = New System.Drawing.Point(476, 32)
        Me.deb_amt2.Name = "deb_amt2"
        Me.deb_amt2.Size = New System.Drawing.Size(240, 21)
        Me.deb_amt2.TabIndex = 69
        Me.deb_amt2.Title = "차변잔액"
        '
        'mng_no2
        '
        Me.mng_no2.Location = New System.Drawing.Point(12, 8)
        Me.mng_no2.Name = "mng_no2"
        Me.mng_no2.Size = New System.Drawing.Size(240, 21)
        Me.mng_no2.TabIndex = 72
        Me.mng_no2.Title = "관리항목명"
        '
        'cre_amt2
        '
        Me.cre_amt2.Location = New System.Drawing.Point(600, 32)
        Me.cre_amt2.Name = "cre_amt2"
        Me.cre_amt2.Size = New System.Drawing.Size(240, 21)
        Me.cre_amt2.TabIndex = 70
        Me.cre_amt2.Title = "대변잔액"
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g20)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1033, 368)
        Me.EPanel1.TabIndex = 3
        Me.EPanel1.Text = "     관리항목별 기초데이타 등록 (계정기준)"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(1029, 343)
        Me.g20.TabIndex = 2
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.SplitContainer3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1033, 433)
        Me.XtraTabPage3.Text = "관리항목별 기초금액 현황"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.PanelControl3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.EPanel2)
        Me.SplitContainer3.Size = New System.Drawing.Size(1033, 433)
        Me.SplitContainer3.SplitterDistance = 61
        Me.SplitContainer3.TabIndex = 0
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl3.Controls.Add(Me.mng_no3)
        Me.PanelControl3.Controls.Add(Me.mng_val3)
        Me.PanelControl3.Controls.Add(Me.mng_dsc3)
        Me.PanelControl3.Controls.Add(Me.acc_cd3)
        Me.PanelControl3.Controls.Add(Me.acc_nm3)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1033, 61)
        Me.PanelControl3.TabIndex = 93
        '
        'mng_no3
        '
        Me.mng_no3.Location = New System.Drawing.Point(276, 8)
        Me.mng_no3.Name = "mng_no3"
        Me.mng_no3.Size = New System.Drawing.Size(240, 21)
        Me.mng_no3.TabIndex = 93
        Me.mng_no3.Title = "관리항목명"
        '
        'mng_val3
        '
        Me.mng_val3.Location = New System.Drawing.Point(524, 8)
        Me.mng_val3.Name = "mng_val3"
        Me.mng_val3.Size = New System.Drawing.Size(240, 21)
        Me.mng_val3.TabIndex = 92
        Me.mng_val3.Title = "Value(*)"
        '
        'mng_dsc3
        '
        Me.mng_dsc3.Location = New System.Drawing.Point(524, 32)
        Me.mng_dsc3.Name = "mng_dsc3"
        Me.mng_dsc3.Size = New System.Drawing.Size(240, 21)
        Me.mng_dsc3.TabIndex = 81
        Me.mng_dsc3.Title = "Description(*)"
        '
        'acc_cd3
        '
        Me.acc_cd3.Location = New System.Drawing.Point(12, 8)
        Me.acc_cd3.Name = "acc_cd3"
        Me.acc_cd3.Size = New System.Drawing.Size(240, 21)
        Me.acc_cd3.TabIndex = 92
        Me.acc_cd3.Title = "계정코드"
        '
        'acc_nm3
        '
        Me.acc_nm3.Location = New System.Drawing.Point(12, 32)
        Me.acc_nm3.Name = "acc_nm3"
        Me.acc_nm3.Size = New System.Drawing.Size(240, 21)
        Me.acc_nm3.TabIndex = 81
        Me.acc_nm3.Title = "계정명"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g30)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(1033, 368)
        Me.EPanel2.TabIndex = 4
        Me.EPanel2.Text = "     관리항목별 기초데이타 현황"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(1029, 343)
        Me.g30.TabIndex = 2
        '
        'doc_mon
        '
        Me.doc_mon.Format = "yyyy"
        Me.doc_mon.Location = New System.Drawing.Point(8, 28)
        Me.doc_mon.Name = "doc_mon"
        Me.doc_mon.Size = New System.Drawing.Size(240, 21)
        Me.doc_mon.TabIndex = 60
        Me.doc_mon.Title = "기준년"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(256, 52)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 61
        Me.cury_bc.Title = "통화구분"
        '
        'div_cd
        '
        Me.div_cd.Location = New System.Drawing.Point(256, 28)
        Me.div_cd.Name = "div_cd"
        Me.div_cd.Size = New System.Drawing.Size(240, 21)
        Me.div_cd.TabIndex = 48
        Me.div_cd.Title = "회계단위"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(4, 8)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer5.Size = New System.Drawing.Size(1040, 548)
        Me.SplitContainer5.SplitterDistance = 81
        Me.SplitContainer5.TabIndex = 6
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.doc_mon)
        Me.EPanel4.Controls.Add(Me.cury_bc)
        Me.EPanel4.Controls.Add(Me.co_cd)
        Me.EPanel4.Controls.Add(Me.div_cd)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(1040, 81)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     검색"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(8, 52)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 48
        Me.co_cd.Title = "법인"
        '
        'FAB800
        '
        Me.Controls.Add(Me.SplitContainer5)
        Me.Name = "FAB800"
        Me.Size = New System.Drawing.Size(1054, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer5, 0)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents gap_amt1 As Frame7.eText
    Friend WithEvents amt2 As Frame7.eText
    Friend WithEvents amt1 As Frame7.eText
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents acc_nm As Frame7.eText
    Friend WithEvents acc_cd As Frame7.eText
    Friend WithEvents div_cd As Frame7.eCombo
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents mng_no2 As Frame7.eCombo
    Friend WithEvents cre_amt2 As Frame7.eText
    Friend WithEvents deb_amt2 As Frame7.eText
    Friend WithEvents acc_sum_proc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents acc_nm2 As Frame7.eText
    Friend WithEvents acc_cd2 As Frame7.eText
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents acc_cd3 As Frame7.eText
    Friend WithEvents acc_nm3 As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents doc_mon As Frame7.eDate
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents dummy As Frame7.eText
    Friend WithEvents mng_no3 As Frame7.eCombo
    Friend WithEvents mng_val3 As Frame7.eText
    Friend WithEvents mng_dsc3 As Frame7.eText
    Friend WithEvents kd As Frame7.eText

End Class
