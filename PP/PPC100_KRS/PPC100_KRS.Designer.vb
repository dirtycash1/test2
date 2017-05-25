<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PPC100_KRS
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
        Me.o_co_cd = New Frame7.eCombo()
        Me.o_fac_cd = New Frame7.eCombo()
        Me.o_work_dt = New Frame7.eDate()
        Me.o_cust_cd = New Frame7.eCombo()
        Me.o_dn_bc = New Frame7.eCombo()
        Me.o_prc_cd = New Frame7.eCombo()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel7 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.have_mh = New Frame7.eText()
        Me.acc_mh = New Frame7.eText()
        Me.give_mh = New Frame7.eText()
        Me.tot_mh = New Frame7.eText()
        Me.have_wk = New Frame7.eText()
        Me.loss = New Frame7.eText()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.g30 = New Frame7.eGrid()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.g40 = New Frame7.eGrid()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.EPanel10 = New Frame7.ePanel()
        Me.g60 = New Frame7.eGrid()
        Me.EPanel11 = New Frame7.ePanel()
        Me.g70 = New Frame7.eGrid()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.g50 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel7.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.EPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel10.SuspendLayout()
        CType(Me.EPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel11.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1034, 563)
        Me.SplitContainer1.SplitterDistance = 81
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.o_co_cd)
        Me.EPanel1.Controls.Add(Me.o_fac_cd)
        Me.EPanel1.Controls.Add(Me.o_work_dt)
        Me.EPanel1.Controls.Add(Me.o_cust_cd)
        Me.EPanel1.Controls.Add(Me.o_dn_bc)
        Me.EPanel1.Controls.Add(Me.o_prc_cd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1034, 81)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'o_co_cd
        '
        Me.o_co_cd.Location = New System.Drawing.Point(14, 28)
        Me.o_co_cd.Name = "o_co_cd"
        Me.o_co_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_co_cd.TabIndex = 16
        Me.o_co_cd.Title = "법인"
        '
        'o_fac_cd
        '
        Me.o_fac_cd.Location = New System.Drawing.Point(14, 52)
        Me.o_fac_cd.Name = "o_fac_cd"
        Me.o_fac_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_fac_cd.TabIndex = 3
        Me.o_fac_cd.Title = "공장"
        '
        'o_work_dt
        '
        Me.o_work_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.o_work_dt.Location = New System.Drawing.Point(260, 28)
        Me.o_work_dt.Name = "o_work_dt"
        Me.o_work_dt.Size = New System.Drawing.Size(240, 21)
        Me.o_work_dt.TabIndex = 7
        Me.o_work_dt.Title = "생산일자"
        '
        'o_cust_cd
        '
        Me.o_cust_cd.Location = New System.Drawing.Point(260, 52)
        Me.o_cust_cd.Name = "o_cust_cd"
        Me.o_cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_cust_cd.TabIndex = 3
        Me.o_cust_cd.Title = "생산처"
        '
        'o_dn_bc
        '
        Me.o_dn_bc.Location = New System.Drawing.Point(506, 28)
        Me.o_dn_bc.Name = "o_dn_bc"
        Me.o_dn_bc.Size = New System.Drawing.Size(240, 21)
        Me.o_dn_bc.TabIndex = 14
        Me.o_dn_bc.Title = "주야구분"
        '
        'o_prc_cd
        '
        Me.o_prc_cd.Location = New System.Drawing.Point(506, 52)
        Me.o_prc_cd.Name = "o_prc_cd"
        Me.o_prc_cd.Size = New System.Drawing.Size(240, 21)
        Me.o_prc_cd.TabIndex = 3
        Me.o_prc_cd.Title = "공정"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer2.Size = New System.Drawing.Size(1034, 478)
        Me.SplitContainer2.SplitterDistance = 186
        Me.SplitContainer2.TabIndex = 2
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g10)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(186, 478)
        Me.EPanel5.TabIndex = 0
        Me.EPanel5.Text = "     생산라인"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(182, 453)
        Me.g10.TabIndex = 2
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel7)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer5.Size = New System.Drawing.Size(844, 478)
        Me.SplitContainer5.SplitterDistance = 208
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel7
        '
        Me.EPanel7.Controls.Add(Me.g20)
        Me.EPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel7.Location = New System.Drawing.Point(0, 0)
        Me.EPanel7.Name = "EPanel7"
        Me.EPanel7.Size = New System.Drawing.Size(844, 208)
        Me.EPanel7.TabIndex = 1
        Me.EPanel7.Text = "     품목별 생산실적 조회"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(840, 183)
        Me.g20.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(844, 266)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(837, 236)
        Me.XtraTabPage1.Text = "투입공수 및 비가동"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainer3.Size = New System.Drawing.Size(837, 236)
        Me.SplitContainer3.SplitterDistance = 265
        Me.SplitContainer3.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.have_mh)
        Me.EPanel2.Controls.Add(Me.acc_mh)
        Me.EPanel2.Controls.Add(Me.give_mh)
        Me.EPanel2.Controls.Add(Me.tot_mh)
        Me.EPanel2.Controls.Add(Me.have_wk)
        Me.EPanel2.Controls.Add(Me.loss)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(265, 236)
        Me.EPanel2.TabIndex = 0
        Me.EPanel2.Text = "     투입공수"
        '
        'have_mh
        '
        Me.have_mh.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.have_mh.Location = New System.Drawing.Point(14, 35)
        Me.have_mh.Name = "have_mh"
        Me.have_mh.Size = New System.Drawing.Size(240, 21)
        Me.have_mh.TabIndex = 2
        Me.have_mh.Title = "보유공수(MH)"
        '
        'acc_mh
        '
        Me.acc_mh.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.acc_mh.Location = New System.Drawing.Point(14, 62)
        Me.acc_mh.Name = "acc_mh"
        Me.acc_mh.Size = New System.Drawing.Size(240, 21)
        Me.acc_mh.TabIndex = 2
        Me.acc_mh.Title = "받음공수(MH)"
        '
        'give_mh
        '
        Me.give_mh.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.give_mh.Location = New System.Drawing.Point(14, 89)
        Me.give_mh.Name = "give_mh"
        Me.give_mh.Size = New System.Drawing.Size(240, 21)
        Me.give_mh.TabIndex = 2
        Me.give_mh.Title = "준공수(MH)"
        '
        'tot_mh
        '
        Me.tot_mh.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tot_mh.Location = New System.Drawing.Point(14, 116)
        Me.tot_mh.Name = "tot_mh"
        Me.tot_mh.ReadOnly = True
        Me.tot_mh.Size = New System.Drawing.Size(240, 21)
        Me.tot_mh.TabIndex = 2
        Me.tot_mh.TextAlign = Frame7.Alignment.Right
        Me.tot_mh.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.tot_mh.Title = "투입공수(MH)"
        '
        'have_wk
        '
        Me.have_wk.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.have_wk.Location = New System.Drawing.Point(14, 143)
        Me.have_wk.Name = "have_wk"
        Me.have_wk.Size = New System.Drawing.Size(240, 21)
        Me.have_wk.TabIndex = 2
        Me.have_wk.Title = "보유인원"
        '
        'loss
        '
        Me.loss.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.loss.Location = New System.Drawing.Point(14, 188)
        Me.loss.Name = "loss"
        Me.loss.ReadOnly = True
        Me.loss.Size = New System.Drawing.Size(240, 21)
        Me.loss.TabIndex = 2
        Me.loss.TextAlign = Frame7.Alignment.Right
        Me.loss.TextBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.loss.Title = "LOSS"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage4
        Me.XtraTabControl2.Size = New System.Drawing.Size(568, 236)
        Me.XtraTabControl2.TabIndex = 1
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.g30)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(561, 206)
        Me.XtraTabPage4.Text = "통제가능 비가동"
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(0, 0)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(561, 206)
        Me.g30.TabIndex = 2
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.g40)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(561, 206)
        Me.XtraTabPage5.Text = "통제불가능 비가동"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(0, 0)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(561, 206)
        Me.g40.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SplitContainer6)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(837, 236)
        Me.XtraTabPage2.Text = "불량 내역"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.EPanel10)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.EPanel11)
        Me.SplitContainer6.Size = New System.Drawing.Size(837, 236)
        Me.SplitContainer6.SplitterDistance = 374
        Me.SplitContainer6.TabIndex = 0
        '
        'EPanel10
        '
        Me.EPanel10.Controls.Add(Me.g60)
        Me.EPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel10.Location = New System.Drawing.Point(0, 0)
        Me.EPanel10.Name = "EPanel10"
        Me.EPanel10.Size = New System.Drawing.Size(374, 236)
        Me.EPanel10.TabIndex = 0
        Me.EPanel10.Text = "     공정불량"
        '
        'g60
        '
        Me.g60.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g60.Location = New System.Drawing.Point(2, 23)
        Me.g60.Name = "g60"
        Me.g60.ReadOnly = False
        Me.g60.RowHeight = -1
        Me.g60.Size = New System.Drawing.Size(370, 211)
        Me.g60.TabIndex = 2
        '
        'EPanel11
        '
        Me.EPanel11.Controls.Add(Me.g70)
        Me.EPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel11.Location = New System.Drawing.Point(0, 0)
        Me.EPanel11.Name = "EPanel11"
        Me.EPanel11.Size = New System.Drawing.Size(459, 236)
        Me.EPanel11.TabIndex = 0
        Me.EPanel11.Text = "     외주불량"
        '
        'g70
        '
        Me.g70.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g70.Location = New System.Drawing.Point(2, 23)
        Me.g70.Name = "g70"
        Me.g70.ReadOnly = False
        Me.g70.RowHeight = -1
        Me.g70.Size = New System.Drawing.Size(455, 211)
        Me.g70.TabIndex = 2
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.g50)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(837, 236)
        Me.XtraTabPage3.Text = "소요자재"
        '
        'g50
        '
        Me.g50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g50.Location = New System.Drawing.Point(0, 0)
        Me.g50.Name = "g50"
        Me.g50.ReadOnly = False
        Me.g50.RecordNavigator = False
        Me.g50.RowHeight = -1
        Me.g50.Size = New System.Drawing.Size(837, 236)
        Me.g50.TabIndex = 3
        '
        'PPC100_KRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "PPC100_KRS"
        Me.Size = New System.Drawing.Size(1034, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel7.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        CType(Me.EPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel10.ResumeLayout(False)
        CType(Me.EPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel11.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents o_fac_cd As Frame7.eCombo
    Friend WithEvents o_work_dt As Frame7.eDate
    Friend WithEvents EPanel7 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Friend WithEvents o_co_cd As Frame7.eCombo
    Friend WithEvents o_dn_bc As Frame7.eCombo
    Friend WithEvents o_cust_cd As Frame7.eCombo
    Friend WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents have_mh As Frame7.eText
    Friend WithEvents acc_mh As Frame7.eText
    Friend WithEvents give_mh As Frame7.eText
    Friend WithEvents tot_mh As Frame7.eText
    Friend WithEvents have_wk As Frame7.eText
    Friend WithEvents loss As Frame7.eText
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents g50 As Frame7.eGrid
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel10 As Frame7.ePanel
    Friend WithEvents EPanel11 As Frame7.ePanel
    Friend WithEvents g60 As Frame7.eGrid
    Friend WithEvents g70 As Frame7.eGrid
    Friend WithEvents o_pw_no As Frame7.eText
    Friend WithEvents o_prc_cd As Frame7.eCombo
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage

End Class
