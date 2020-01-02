<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCC100
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
        Me.g10 = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.EPanel4 = New Frame7.ePanel()
        Me.stamp = New Frame7.eImage()
        Me.mdt = New Frame7.eText()
        Me.mid_nm = New Frame7.eText()
        Me.rmks = New Frame7.eText()
        Me.addr = New Frame7.eText()
        Me.zip_cd = New Frame7.eText()
        Me.capital_amt = New Frame7.eText()
        Me.trade_no = New Frame7.eText()
        Me.approv_no = New Frame7.eText()
        Me.ceo_id = New Frame7.eText()
        Me.cury_bc = New Frame7.eCombo()
        Me.sys_cd = New Frame7.eCombo()
        Me.co_bc = New Frame7.eCombo()
        Me.biz_bc = New Frame7.eCombo()
        Me.head_bs = New Frame7.eCombo()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.addr6 = New Frame7.eText()
        Me.co_nm6 = New Frame7.eText()
        Me.addr5 = New Frame7.eText()
        Me.co_nm5 = New Frame7.eText()
        Me.ceo_nm6 = New Frame7.eText()
        Me.ceo_nm5 = New Frame7.eText()
        Me.ceo_nm4 = New Frame7.eText()
        Me.ceo_nm3 = New Frame7.eText()
        Me.ceo_nm2 = New Frame7.eText()
        Me.ceo_nm1 = New Frame7.eText()
        Me.addr4 = New Frame7.eText()
        Me.co_nm4 = New Frame7.eText()
        Me.addr3 = New Frame7.eText()
        Me.co_nm3 = New Frame7.eText()
        Me.addr2 = New Frame7.eText()
        Me.co_nm2 = New Frame7.eText()
        Me.co_bnm6 = New Frame7.eText()
        Me.co_bnm5 = New Frame7.eText()
        Me.co_bnm4 = New Frame7.eText()
        Me.co_bnm3 = New Frame7.eText()
        Me.co_bnm2 = New Frame7.eText()
        Me.co_bnm1 = New Frame7.eText()
        Me.addr1 = New Frame7.eText()
        Me.co_nm1 = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.disp_sq = New Frame7.eText()
        Me.co_no = New Frame7.eText()
        Me.ceo_nm = New Frame7.eText()
        Me.co_bnm = New Frame7.eText()
        Me.co_nm = New Frame7.eText()
        Me.co_cd = New Frame7.eText()
        Me.to_dt = New Frame7.eDate()
        Me.fr_dt = New Frame7.eDate()
        Me.co_dt = New Frame7.eDate()
        Me.set_mon = New Frame7.eCombo()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 687)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(220, 687)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     법인등록현황"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(216, 662)
        Me.g10.TabIndex = 3
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 164)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(810, 523)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AlwaysScrollActiveControlIntoView = False
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.EPanel4)
        Me.XtraTabPage1.Controls.Add(Me.mdt)
        Me.XtraTabPage1.Controls.Add(Me.mid_nm)
        Me.XtraTabPage1.Controls.Add(Me.rmks)
        Me.XtraTabPage1.Controls.Add(Me.addr)
        Me.XtraTabPage1.Controls.Add(Me.zip_cd)
        Me.XtraTabPage1.Controls.Add(Me.capital_amt)
        Me.XtraTabPage1.Controls.Add(Me.trade_no)
        Me.XtraTabPage1.Controls.Add(Me.approv_no)
        Me.XtraTabPage1.Controls.Add(Me.ceo_id)
        Me.XtraTabPage1.Controls.Add(Me.cury_bc)
        Me.XtraTabPage1.Controls.Add(Me.sys_cd)
        Me.XtraTabPage1.Controls.Add(Me.co_bc)
        Me.XtraTabPage1.Controls.Add(Me.biz_bc)
        Me.XtraTabPage1.Controls.Add(Me.head_bs)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(803, 493)
        Me.XtraTabPage1.Text = "기본정보"
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.stamp)
        Me.EPanel4.Location = New System.Drawing.Point(492, 84)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(124, 144)
        Me.EPanel4.TabIndex = 152
        Me.EPanel4.Text = "     직인"
        '
        'stamp
        '
        Me.stamp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stamp.Location = New System.Drawing.Point(2, 23)
        Me.stamp.Name = "stamp"
        Me.stamp.Size = New System.Drawing.Size(120, 119)
        Me.stamp.SizeMode = Frame7.ImageSizeMode.Stretch
        Me.stamp.TabIndex = 2
        Me.stamp.TitleBorderStyle = Frame7.BorderStyle.None
        '
        'mdt
        '
        Me.mdt.Location = New System.Drawing.Point(16, 304)
        Me.mdt.Name = "mdt"
        Me.mdt.Size = New System.Drawing.Size(300, 21)
        Me.mdt.TabIndex = 151
        Me.mdt.Title = "최종수정일"
        '
        'mid_nm
        '
        Me.mid_nm.Location = New System.Drawing.Point(16, 280)
        Me.mid_nm.Name = "mid_nm"
        Me.mid_nm.Size = New System.Drawing.Size(300, 21)
        Me.mid_nm.TabIndex = 151
        Me.mid_nm.Title = "최종수정자"
        '
        'rmks
        '
        Me.rmks.Location = New System.Drawing.Point(16, 256)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(600, 21)
        Me.rmks.TabIndex = 151
        Me.rmks.Title = "비고"
        '
        'addr
        '
        Me.addr.Location = New System.Drawing.Point(16, 232)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(600, 21)
        Me.addr.TabIndex = 151
        Me.addr.Title = "주소"
        '
        'zip_cd
        '
        Me.zip_cd.Location = New System.Drawing.Point(16, 208)
        Me.zip_cd.Name = "zip_cd"
        Me.zip_cd.Size = New System.Drawing.Size(301, 21)
        Me.zip_cd.TabIndex = 151
        Me.zip_cd.Title = "우편번호"
        '
        'capital_amt
        '
        Me.capital_amt.Location = New System.Drawing.Point(16, 168)
        Me.capital_amt.Name = "capital_amt"
        Me.capital_amt.Size = New System.Drawing.Size(301, 21)
        Me.capital_amt.TabIndex = 151
        Me.capital_amt.Title = "자본금"
        '
        'trade_no
        '
        Me.trade_no.Location = New System.Drawing.Point(16, 144)
        Me.trade_no.Name = "trade_no"
        Me.trade_no.Size = New System.Drawing.Size(301, 21)
        Me.trade_no.TabIndex = 151
        Me.trade_no.Title = "무역업 허가번호"
        '
        'approv_no
        '
        Me.approv_no.Location = New System.Drawing.Point(16, 120)
        Me.approv_no.Name = "approv_no"
        Me.approv_no.Size = New System.Drawing.Size(301, 21)
        Me.approv_no.TabIndex = 151
        Me.approv_no.Title = "총괄승인 납부번호"
        '
        'ceo_id
        '
        Me.ceo_id.Location = New System.Drawing.Point(16, 96)
        Me.ceo_id.Name = "ceo_id"
        Me.ceo_id.Size = New System.Drawing.Size(301, 21)
        Me.ceo_id.TabIndex = 151
        Me.ceo_id.Title = "대표자 주민번호"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(492, 32)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 150
        Me.cury_bc.Title = "cury_bc"
        '
        'sys_cd
        '
        Me.sys_cd.Location = New System.Drawing.Point(492, 8)
        Me.sys_cd.Name = "sys_cd"
        Me.sys_cd.Size = New System.Drawing.Size(240, 21)
        Me.sys_cd.TabIndex = 150
        Me.sys_cd.Title = "회계 계정체계"
        '
        'co_bc
        '
        Me.co_bc.Location = New System.Drawing.Point(16, 32)
        Me.co_bc.Name = "co_bc"
        Me.co_bc.Size = New System.Drawing.Size(300, 21)
        Me.co_bc.TabIndex = 149
        Me.co_bc.Title = "법인 구분"
        '
        'biz_bc
        '
        Me.biz_bc.Location = New System.Drawing.Point(16, 56)
        Me.biz_bc.Name = "biz_bc"
        Me.biz_bc.Size = New System.Drawing.Size(301, 21)
        Me.biz_bc.TabIndex = 148
        Me.biz_bc.Title = "기업 구분"
        '
        'head_bs
        '
        Me.head_bs.Location = New System.Drawing.Point(16, 8)
        Me.head_bs.Name = "head_bs"
        Me.head_bs.Size = New System.Drawing.Size(300, 21)
        Me.head_bs.TabIndex = 147
        Me.head_bs.Title = "본지점 사업장"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Panel4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(803, 493)
        Me.XtraTabPage2.Text = "언어정보"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.addr6)
        Me.Panel4.Controls.Add(Me.co_nm6)
        Me.Panel4.Controls.Add(Me.addr5)
        Me.Panel4.Controls.Add(Me.co_nm5)
        Me.Panel4.Controls.Add(Me.ceo_nm6)
        Me.Panel4.Controls.Add(Me.ceo_nm5)
        Me.Panel4.Controls.Add(Me.ceo_nm4)
        Me.Panel4.Controls.Add(Me.ceo_nm3)
        Me.Panel4.Controls.Add(Me.ceo_nm2)
        Me.Panel4.Controls.Add(Me.ceo_nm1)
        Me.Panel4.Controls.Add(Me.addr4)
        Me.Panel4.Controls.Add(Me.co_nm4)
        Me.Panel4.Controls.Add(Me.addr3)
        Me.Panel4.Controls.Add(Me.co_nm3)
        Me.Panel4.Controls.Add(Me.addr2)
        Me.Panel4.Controls.Add(Me.co_nm2)
        Me.Panel4.Controls.Add(Me.co_bnm6)
        Me.Panel4.Controls.Add(Me.co_bnm5)
        Me.Panel4.Controls.Add(Me.co_bnm4)
        Me.Panel4.Controls.Add(Me.co_bnm3)
        Me.Panel4.Controls.Add(Me.co_bnm2)
        Me.Panel4.Controls.Add(Me.co_bnm1)
        Me.Panel4.Controls.Add(Me.addr1)
        Me.Panel4.Controls.Add(Me.co_nm1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(803, 493)
        Me.Panel4.TabIndex = 1
        '
        'addr6
        '
        Me.addr6.Location = New System.Drawing.Point(308, 272)
        Me.addr6.Name = "addr6"
        Me.addr6.Size = New System.Drawing.Size(428, 21)
        Me.addr6.TabIndex = 66
        Me.addr6.Title = "주소6"
        '
        'co_nm6
        '
        Me.co_nm6.Location = New System.Drawing.Point(16, 128)
        Me.co_nm6.Name = "co_nm6"
        Me.co_nm6.Size = New System.Drawing.Size(400, 21)
        Me.co_nm6.TabIndex = 66
        Me.co_nm6.Title = "법인명6"
        '
        'addr5
        '
        Me.addr5.Location = New System.Drawing.Point(308, 248)
        Me.addr5.Name = "addr5"
        Me.addr5.Size = New System.Drawing.Size(428, 21)
        Me.addr5.TabIndex = 66
        Me.addr5.Title = "주소5"
        '
        'co_nm5
        '
        Me.co_nm5.Location = New System.Drawing.Point(16, 104)
        Me.co_nm5.Name = "co_nm5"
        Me.co_nm5.Size = New System.Drawing.Size(400, 21)
        Me.co_nm5.TabIndex = 66
        Me.co_nm5.Title = "법인명5"
        '
        'ceo_nm6
        '
        Me.ceo_nm6.Location = New System.Drawing.Point(16, 272)
        Me.ceo_nm6.Name = "ceo_nm6"
        Me.ceo_nm6.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm6.TabIndex = 65
        Me.ceo_nm6.Title = "대표자명6"
        '
        'ceo_nm5
        '
        Me.ceo_nm5.Location = New System.Drawing.Point(16, 248)
        Me.ceo_nm5.Name = "ceo_nm5"
        Me.ceo_nm5.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm5.TabIndex = 65
        Me.ceo_nm5.Title = "대표자명5"
        '
        'ceo_nm4
        '
        Me.ceo_nm4.Location = New System.Drawing.Point(16, 224)
        Me.ceo_nm4.Name = "ceo_nm4"
        Me.ceo_nm4.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm4.TabIndex = 65
        Me.ceo_nm4.Title = "대표자명4"
        '
        'ceo_nm3
        '
        Me.ceo_nm3.Location = New System.Drawing.Point(16, 200)
        Me.ceo_nm3.Name = "ceo_nm3"
        Me.ceo_nm3.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm3.TabIndex = 65
        Me.ceo_nm3.Title = "대표자명3"
        '
        'ceo_nm2
        '
        Me.ceo_nm2.Location = New System.Drawing.Point(16, 176)
        Me.ceo_nm2.Name = "ceo_nm2"
        Me.ceo_nm2.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm2.TabIndex = 65
        Me.ceo_nm2.Title = "대표자명2"
        '
        'ceo_nm1
        '
        Me.ceo_nm1.Location = New System.Drawing.Point(16, 152)
        Me.ceo_nm1.Name = "ceo_nm1"
        Me.ceo_nm1.Size = New System.Drawing.Size(276, 21)
        Me.ceo_nm1.TabIndex = 65
        Me.ceo_nm1.Title = "대표자명1"
        '
        'addr4
        '
        Me.addr4.Location = New System.Drawing.Point(308, 224)
        Me.addr4.Name = "addr4"
        Me.addr4.Size = New System.Drawing.Size(428, 21)
        Me.addr4.TabIndex = 66
        Me.addr4.Title = "주소4"
        '
        'co_nm4
        '
        Me.co_nm4.Location = New System.Drawing.Point(16, 80)
        Me.co_nm4.Name = "co_nm4"
        Me.co_nm4.Size = New System.Drawing.Size(400, 21)
        Me.co_nm4.TabIndex = 66
        Me.co_nm4.Title = "법인명4"
        '
        'addr3
        '
        Me.addr3.Location = New System.Drawing.Point(308, 200)
        Me.addr3.Name = "addr3"
        Me.addr3.Size = New System.Drawing.Size(428, 21)
        Me.addr3.TabIndex = 66
        Me.addr3.Title = "주소3"
        '
        'co_nm3
        '
        Me.co_nm3.Location = New System.Drawing.Point(16, 56)
        Me.co_nm3.Name = "co_nm3"
        Me.co_nm3.Size = New System.Drawing.Size(400, 21)
        Me.co_nm3.TabIndex = 66
        Me.co_nm3.Title = "법인명3"
        '
        'addr2
        '
        Me.addr2.Location = New System.Drawing.Point(308, 176)
        Me.addr2.Name = "addr2"
        Me.addr2.Size = New System.Drawing.Size(428, 21)
        Me.addr2.TabIndex = 66
        Me.addr2.Title = "주소2"
        '
        'co_nm2
        '
        Me.co_nm2.Location = New System.Drawing.Point(16, 32)
        Me.co_nm2.Name = "co_nm2"
        Me.co_nm2.Size = New System.Drawing.Size(400, 21)
        Me.co_nm2.TabIndex = 66
        Me.co_nm2.Title = "법인명2"
        '
        'co_bnm6
        '
        Me.co_bnm6.Location = New System.Drawing.Point(436, 128)
        Me.co_bnm6.Name = "co_bnm6"
        Me.co_bnm6.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm6.TabIndex = 66
        Me.co_bnm6.Title = "법인명(약칭)6"
        '
        'co_bnm5
        '
        Me.co_bnm5.Location = New System.Drawing.Point(436, 104)
        Me.co_bnm5.Name = "co_bnm5"
        Me.co_bnm5.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm5.TabIndex = 66
        Me.co_bnm5.Title = "법인명(약칭)5"
        '
        'co_bnm4
        '
        Me.co_bnm4.Location = New System.Drawing.Point(436, 80)
        Me.co_bnm4.Name = "co_bnm4"
        Me.co_bnm4.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm4.TabIndex = 66
        Me.co_bnm4.Title = "법인명(약칭)4"
        '
        'co_bnm3
        '
        Me.co_bnm3.Location = New System.Drawing.Point(436, 56)
        Me.co_bnm3.Name = "co_bnm3"
        Me.co_bnm3.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm3.TabIndex = 66
        Me.co_bnm3.Title = "법인명(약칭)3"
        '
        'co_bnm2
        '
        Me.co_bnm2.Location = New System.Drawing.Point(436, 32)
        Me.co_bnm2.Name = "co_bnm2"
        Me.co_bnm2.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm2.TabIndex = 66
        Me.co_bnm2.Title = "법인명(약칭)2"
        '
        'co_bnm1
        '
        Me.co_bnm1.Location = New System.Drawing.Point(436, 8)
        Me.co_bnm1.Name = "co_bnm1"
        Me.co_bnm1.Size = New System.Drawing.Size(300, 21)
        Me.co_bnm1.TabIndex = 66
        Me.co_bnm1.Title = "법인명(약칭)1"
        '
        'addr1
        '
        Me.addr1.Location = New System.Drawing.Point(308, 152)
        Me.addr1.Name = "addr1"
        Me.addr1.Size = New System.Drawing.Size(428, 21)
        Me.addr1.TabIndex = 66
        Me.addr1.Title = "주소1"
        '
        'co_nm1
        '
        Me.co_nm1.Location = New System.Drawing.Point(16, 8)
        Me.co_nm1.Name = "co_nm1"
        Me.co_nm1.Size = New System.Drawing.Size(400, 21)
        Me.co_nm1.TabIndex = 66
        Me.co_nm1.Title = "법인명1"
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.Panel2)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(810, 164)
        Me.EPanel3.TabIndex = 63
        Me.EPanel3.Text = "     법인정보"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.disp_sq)
        Me.Panel2.Controls.Add(Me.co_no)
        Me.Panel2.Controls.Add(Me.ceo_nm)
        Me.Panel2.Controls.Add(Me.co_bnm)
        Me.Panel2.Controls.Add(Me.co_nm)
        Me.Panel2.Controls.Add(Me.co_cd)
        Me.Panel2.Controls.Add(Me.to_dt)
        Me.Panel2.Controls.Add(Me.fr_dt)
        Me.Panel2.Controls.Add(Me.co_dt)
        Me.Panel2.Controls.Add(Me.set_mon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 139)
        Me.Panel2.TabIndex = 2
        '
        'disp_sq
        '
        Me.disp_sq.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.disp_sq.Location = New System.Drawing.Point(496, 12)
        Me.disp_sq.Name = "disp_sq"
        Me.disp_sq.Size = New System.Drawing.Size(240, 21)
        Me.disp_sq.TabIndex = 63
        Me.disp_sq.Title = "출력순서"
        '
        'co_no
        '
        Me.co_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.co_no.Location = New System.Drawing.Point(16, 108)
        Me.co_no.Name = "co_no"
        Me.co_no.Size = New System.Drawing.Size(301, 21)
        Me.co_no.TabIndex = 67
        Me.co_no.Title = "법인등록번호"
        '
        'ceo_nm
        '
        Me.ceo_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ceo_nm.Location = New System.Drawing.Point(16, 84)
        Me.ceo_nm.Name = "ceo_nm"
        Me.ceo_nm.Size = New System.Drawing.Size(301, 21)
        Me.ceo_nm.TabIndex = 65
        Me.ceo_nm.Title = "대표자명"
        '
        'co_bnm
        '
        Me.co_bnm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.co_bnm.Location = New System.Drawing.Point(16, 60)
        Me.co_bnm.Name = "co_bnm"
        Me.co_bnm.Size = New System.Drawing.Size(458, 21)
        Me.co_bnm.TabIndex = 65
        Me.co_bnm.Title = "법인명(약칭)"
        '
        'co_nm
        '
        Me.co_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.co_nm.Location = New System.Drawing.Point(16, 36)
        Me.co_nm.Name = "co_nm"
        Me.co_nm.Size = New System.Drawing.Size(458, 21)
        Me.co_nm.TabIndex = 64
        Me.co_nm.Title = "법인명"
        '
        'co_cd
        '
        Me.co_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.co_cd.Location = New System.Drawing.Point(16, 12)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 66
        Me.co_cd.Title = "법인코드"
        '
        'to_dt
        '
        Me.to_dt.Location = New System.Drawing.Point(496, 84)
        Me.to_dt.Name = "to_dt"
        Me.to_dt.Size = New System.Drawing.Size(240, 21)
        Me.to_dt.TabIndex = 69
        Me.to_dt.Title = "폐업일"
        '
        'fr_dt
        '
        Me.fr_dt.Location = New System.Drawing.Point(496, 60)
        Me.fr_dt.Name = "fr_dt"
        Me.fr_dt.Size = New System.Drawing.Size(240, 21)
        Me.fr_dt.TabIndex = 69
        Me.fr_dt.Title = "개업일"
        '
        'co_dt
        '
        Me.co_dt.Location = New System.Drawing.Point(496, 36)
        Me.co_dt.Name = "co_dt"
        Me.co_dt.Size = New System.Drawing.Size(240, 21)
        Me.co_dt.TabIndex = 69
        Me.co_dt.Title = "설립일"
        '
        'set_mon
        '
        Me.set_mon.Location = New System.Drawing.Point(496, 108)
        Me.set_mon.Name = "set_mon"
        Me.set_mon.Size = New System.Drawing.Size(240, 21)
        Me.set_mon.TabIndex = 150
        Me.set_mon.Title = "결산 기준월"
        '
        'BCC100
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCC100"
        Me.Size = New System.Drawing.Size(1034, 687)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents co_dt As Frame7.eDate
    Friend WithEvents co_cd As Frame7.eText
    Friend WithEvents disp_sq As Frame7.eText
    Friend WithEvents co_nm As Frame7.eText
    Friend WithEvents co_bnm As Frame7.eText
    Friend WithEvents co_no As Frame7.eText
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ceo_id As Frame7.eText
    Friend WithEvents co_bc As Frame7.eCombo
    Friend WithEvents biz_bc As Frame7.eCombo
    Friend WithEvents head_bs As Frame7.eCombo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents ceo_nm As Frame7.eText
    Friend WithEvents fr_dt As Frame7.eDate
    Friend WithEvents to_dt As Frame7.eDate
    Friend WithEvents mid_nm As Frame7.eText
    Friend WithEvents set_mon As Frame7.eCombo
    Friend WithEvents trade_no As Frame7.eText
    Friend WithEvents approv_no As Frame7.eText
    Friend WithEvents addr As Frame7.eText
    Friend WithEvents zip_cd As Frame7.eText
    Friend WithEvents capital_amt As Frame7.eText
    Friend WithEvents sys_cd As Frame7.eCombo
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents stamp As Frame7.eImage
    Friend WithEvents co_nm1 As Frame7.eText
    Friend WithEvents co_nm6 As Frame7.eText
    Friend WithEvents co_nm5 As Frame7.eText
    Friend WithEvents co_nm4 As Frame7.eText
    Friend WithEvents co_nm3 As Frame7.eText
    Friend WithEvents co_nm2 As Frame7.eText
    Friend WithEvents co_bnm1 As Frame7.eText
    Friend WithEvents co_bnm3 As Frame7.eText
    Friend WithEvents co_bnm2 As Frame7.eText
    Friend WithEvents co_bnm6 As Frame7.eText
    Friend WithEvents co_bnm5 As Frame7.eText
    Friend WithEvents co_bnm4 As Frame7.eText
    Friend WithEvents addr6 As Frame7.eText
    Friend WithEvents addr5 As Frame7.eText
    Friend WithEvents ceo_nm5 As Frame7.eText
    Friend WithEvents ceo_nm4 As Frame7.eText
    Friend WithEvents ceo_nm3 As Frame7.eText
    Friend WithEvents ceo_nm2 As Frame7.eText
    Friend WithEvents ceo_nm1 As Frame7.eText
    Friend WithEvents addr4 As Frame7.eText
    Friend WithEvents addr3 As Frame7.eText
    Friend WithEvents addr2 As Frame7.eText
    Friend WithEvents addr1 As Frame7.eText
    Friend WithEvents ceo_nm6 As Frame7.eText
    Friend WithEvents mdt As Frame7.eText
    Friend WithEvents cury_bc As Frame7.eCombo

End Class
