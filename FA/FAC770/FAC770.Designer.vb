<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAC770
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.btn_work = New DevExpress.XtraEditors.SimpleButton()
        Me.bs_cd = New Frame7.eCombo()
        Me.co_cd = New Frame7.eCombo()
        Me.tax_dtf = New Frame7.eDate()
        Me.omon_bc = New Frame7.eCombo()
        Me.otax_year = New Frame7.eDate()
        Me.bf_mon_bc = New Frame7.eCombo()
        Me.tax_dtt = New Frame7.eDate()
        Me.EPanel2 = New Frame7.ePanel()
        Me.addr = New Frame7.eText()
        Me.seq = New Frame7.eText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.int_rt = New Frame7.eText()
        Me.g10 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.g10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 690)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.btn_work)
        Me.EPanel1.Controls.Add(Me.bs_cd)
        Me.EPanel1.Controls.Add(Me.co_cd)
        Me.EPanel1.Controls.Add(Me.tax_dtf)
        Me.EPanel1.Controls.Add(Me.omon_bc)
        Me.EPanel1.Controls.Add(Me.otax_year)
        Me.EPanel1.Controls.Add(Me.bf_mon_bc)
        Me.EPanel1.Controls.Add(Me.tax_dtt)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 80)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     부동산 임대 공급가 명세서"
        '
        'btn_work
        '
        Me.btn_work.Location = New System.Drawing.Point(518, 52)
        Me.btn_work.Name = "btn_work"
        Me.btn_work.Size = New System.Drawing.Size(104, 23)
        Me.btn_work.TabIndex = 10
        Me.btn_work.Text = "가져오기"
        '
        'bs_cd
        '
        Me.bs_cd.Location = New System.Drawing.Point(12, 53)
        Me.bs_cd.Name = "bs_cd"
        Me.bs_cd.Size = New System.Drawing.Size(240, 21)
        Me.bs_cd.TabIndex = 9
        Me.bs_cd.Title = "사업장"
        '
        'co_cd
        '
        Me.co_cd.Location = New System.Drawing.Point(12, 29)
        Me.co_cd.Name = "co_cd"
        Me.co_cd.Size = New System.Drawing.Size(240, 21)
        Me.co_cd.TabIndex = 8
        Me.co_cd.Title = "법인"
        '
        'tax_dtf
        '
        Me.tax_dtf.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtf.Format = "yyyy-MM-dd"
        Me.tax_dtf.Location = New System.Drawing.Point(628, 29)
        Me.tax_dtf.Name = "tax_dtf"
        Me.tax_dtf.Size = New System.Drawing.Size(216, 21)
        Me.tax_dtf.TabIndex = 6
        '
        'omon_bc
        '
        Me.omon_bc.Location = New System.Drawing.Point(272, 53)
        Me.omon_bc.Name = "omon_bc"
        Me.omon_bc.Size = New System.Drawing.Size(240, 21)
        Me.omon_bc.TabIndex = 4
        Me.omon_bc.Title = "신고기간구분"
        '
        'otax_year
        '
        Me.otax_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.otax_year.Format = "yyyy"
        Me.otax_year.Location = New System.Drawing.Point(272, 29)
        Me.otax_year.Name = "otax_year"
        Me.otax_year.Size = New System.Drawing.Size(240, 21)
        Me.otax_year.TabIndex = 3
        Me.otax_year.Title = "신고년도"
        '
        'bf_mon_bc
        '
        Me.bf_mon_bc.Location = New System.Drawing.Point(628, 53)
        Me.bf_mon_bc.Name = "bf_mon_bc"
        Me.bf_mon_bc.Size = New System.Drawing.Size(240, 21)
        Me.bf_mon_bc.TabIndex = 4
        Me.bf_mon_bc.Title = "신고기간구분Form"
        '
        'tax_dtt
        '
        Me.tax_dtt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tax_dtt.Format = "yyyy-MM-dd"
        Me.tax_dtt.Location = New System.Drawing.Point(848, 29)
        Me.tax_dtt.Name = "tax_dtt"
        Me.tax_dtt.Size = New System.Drawing.Size(120, 21)
        Me.tax_dtt.TabIndex = 7
        Me.tax_dtt.Title = "~"
        Me.tax_dtt.TitleWidth = 30
        '
        'EPanel2
        '
        Me.EPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EPanel2.Controls.Add(Me.addr)
        Me.EPanel2.Controls.Add(Me.seq)
        Me.EPanel2.Controls.Add(Me.Label1)
        Me.EPanel2.Controls.Add(Me.int_rt)
        Me.EPanel2.IconVisible = False
        Me.EPanel2.Location = New System.Drawing.Point(1, 2)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.ShowCaption = False
        Me.EPanel2.Size = New System.Drawing.Size(997, 55)
        Me.EPanel2.TabIndex = 2
        Me.EPanel2.Text = "부동산 임대 공급가 명세서"
        '
        'addr
        '
        Me.addr.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr.Location = New System.Drawing.Point(11, 5)
        Me.addr.Name = "addr"
        Me.addr.Size = New System.Drawing.Size(500, 21)
        Me.addr.TabIndex = 2
        Me.addr.Title = "부동산소재지"
        '
        'seq
        '
        Me.seq.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.seq.Location = New System.Drawing.Point(11, 28)
        Me.seq.Name = "seq"
        Me.seq.Size = New System.Drawing.Size(240, 21)
        Me.seq.TabIndex = 2
        Me.seq.Title = "사업장일련번호"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "%"
        '
        'int_rt
        '
        Me.int_rt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.int_rt.Location = New System.Drawing.Point(271, 28)
        Me.int_rt.Name = "int_rt"
        Me.int_rt.Size = New System.Drawing.Size(240, 21)
        Me.int_rt.TabIndex = 2
        Me.int_rt.Title = "이자율"
        '
        'g10
        '
        Me.g10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g10.Location = New System.Drawing.Point(2, 60)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(996, 534)
        Me.g10.TabIndex = 0
        '
        'FAC770
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FAC770"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.EPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents bs_cd As Frame7.eCombo
    Friend WithEvents co_cd As Frame7.eCombo
    Friend WithEvents tax_dtf As Frame7.eDate
    Friend WithEvents omon_bc As Frame7.eCombo
    Friend WithEvents tax_dtt As Frame7.eDate
    Friend WithEvents otax_year As Frame7.eDate
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents addr As Frame7.eText
    Friend WithEvents seq As Frame7.eText
    Friend WithEvents int_rt As Frame7.eText
    Friend WithEvents bf_mon_bc As Frame7.eCombo
    Friend WithEvents btn_work As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
