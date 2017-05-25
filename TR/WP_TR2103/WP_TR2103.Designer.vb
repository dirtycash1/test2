<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WP_TR2103
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
        Me.tp1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EPanel1 = New Frame7.ePanel()
        Me.mon_dt4 = New Frame7.eText()
        Me.gigan_dt4 = New Frame7.eText()
        Me.mon_dt3 = New Frame7.eText()
        Me.gigan_dt3 = New Frame7.eText()
        Me.gigan_dt2 = New Frame7.eText()
        Me.mon_dt2 = New Frame7.eText()
        Me.mon_dt = New Frame7.eDate()
        Me.mon_dt1 = New Frame7.eText()
        Me.gigan_dt1 = New Frame7.eText()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.ch_sum1 = New Frame7.eText()
        Me.p_sum1 = New Frame7.eText()
        Me.EPanel3 = New Frame7.ePanel()
        Me.ch_sum3 = New Frame7.eText()
        Me.p_sum3 = New Frame7.eText()
        Me.g30 = New Frame7.eGrid()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel4 = New Frame7.ePanel()
        Me.g20 = New Frame7.eGrid()
        Me.p_sum2 = New Frame7.eText()
        Me.ch_sum2 = New Frame7.eText()
        Me.EPanel5 = New Frame7.ePanel()
        Me.g40 = New Frame7.eGrid()
        Me.p_sum4 = New Frame7.eText()
        Me.ch_sum4 = New Frame7.eText()
        Me.od_amt = New Frame7.eText()
        Me.od_qty = New Frame7.eText()
        Me.wait_amt = New Frame7.eText()
        Me.chul_amt = New Frame7.eText()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel4.SuspendLayout()
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tp1
        '
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(305, 581)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer1.Size = New System.Drawing.Size(305, 581)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1383, 611)
        Me.SplitContainer2.SplitterDistance = 66
        Me.SplitContainer2.TabIndex = 1
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.chul_amt)
        Me.EPanel1.Controls.Add(Me.wait_amt)
        Me.EPanel1.Controls.Add(Me.od_qty)
        Me.EPanel1.Controls.Add(Me.od_amt)
        Me.EPanel1.Controls.Add(Me.mon_dt4)
        Me.EPanel1.Controls.Add(Me.gigan_dt4)
        Me.EPanel1.Controls.Add(Me.mon_dt3)
        Me.EPanel1.Controls.Add(Me.gigan_dt3)
        Me.EPanel1.Controls.Add(Me.gigan_dt2)
        Me.EPanel1.Controls.Add(Me.mon_dt2)
        Me.EPanel1.Controls.Add(Me.mon_dt)
        Me.EPanel1.Controls.Add(Me.mon_dt1)
        Me.EPanel1.Controls.Add(Me.gigan_dt1)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1383, 66)
        Me.EPanel1.TabIndex = 4
        Me.EPanel1.Text = "     판매 계획 比 생산/출하 계획"
        '
        'mon_dt4
        '
        Me.mon_dt4.ColumnName = "ps_cd"
        Me.mon_dt4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mon_dt4.Location = New System.Drawing.Point(1113, 26)
        Me.mon_dt4.Name = "mon_dt4"
        Me.mon_dt4.Size = New System.Drawing.Size(78, 21)
        Me.mon_dt4.TabIndex = 137
        Me.mon_dt4.TableName = "ps_cd"
        Me.mon_dt4.Title = "날짜4"
        Me.mon_dt4.TitleWidth = 30
        Me.mon_dt4.Visible = False
        '
        'gigan_dt4
        '
        Me.gigan_dt4.ColumnName = "ps_cd"
        Me.gigan_dt4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gigan_dt4.Location = New System.Drawing.Point(1197, 26)
        Me.gigan_dt4.Name = "gigan_dt4"
        Me.gigan_dt4.Size = New System.Drawing.Size(78, 21)
        Me.gigan_dt4.TabIndex = 138
        Me.gigan_dt4.TableName = "ps_cd"
        Me.gigan_dt4.Title = "기간4"
        Me.gigan_dt4.TitleWidth = 30
        Me.gigan_dt4.Visible = False
        '
        'mon_dt3
        '
        Me.mon_dt3.ColumnName = "ps_cd"
        Me.mon_dt3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mon_dt3.Location = New System.Drawing.Point(1113, 3)
        Me.mon_dt3.Name = "mon_dt3"
        Me.mon_dt3.Size = New System.Drawing.Size(78, 21)
        Me.mon_dt3.TabIndex = 135
        Me.mon_dt3.TableName = "ps_cd"
        Me.mon_dt3.Title = "날짜3"
        Me.mon_dt3.TitleWidth = 30
        Me.mon_dt3.Visible = False
        '
        'gigan_dt3
        '
        Me.gigan_dt3.ColumnName = "ps_cd"
        Me.gigan_dt3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gigan_dt3.Location = New System.Drawing.Point(1197, 3)
        Me.gigan_dt3.Name = "gigan_dt3"
        Me.gigan_dt3.Size = New System.Drawing.Size(78, 21)
        Me.gigan_dt3.TabIndex = 136
        Me.gigan_dt3.TableName = "ps_cd"
        Me.gigan_dt3.Title = "기간3"
        Me.gigan_dt3.TitleWidth = 30
        Me.gigan_dt3.Visible = False
        '
        'gigan_dt2
        '
        Me.gigan_dt2.ColumnName = "ps_cd"
        Me.gigan_dt2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gigan_dt2.Location = New System.Drawing.Point(1021, 26)
        Me.gigan_dt2.Name = "gigan_dt2"
        Me.gigan_dt2.Size = New System.Drawing.Size(78, 21)
        Me.gigan_dt2.TabIndex = 134
        Me.gigan_dt2.TableName = "ps_cd"
        Me.gigan_dt2.Title = "기간2"
        Me.gigan_dt2.TitleWidth = 30
        Me.gigan_dt2.Visible = False
        '
        'mon_dt2
        '
        Me.mon_dt2.ColumnName = "ps_cd"
        Me.mon_dt2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mon_dt2.Location = New System.Drawing.Point(937, 26)
        Me.mon_dt2.Name = "mon_dt2"
        Me.mon_dt2.Size = New System.Drawing.Size(78, 21)
        Me.mon_dt2.TabIndex = 133
        Me.mon_dt2.TableName = "ps_cd"
        Me.mon_dt2.Title = "날짜2"
        Me.mon_dt2.TitleWidth = 30
        Me.mon_dt2.Visible = False
        '
        'mon_dt
        '
        Me.mon_dt.Location = New System.Drawing.Point(26, 34)
        Me.mon_dt.Name = "mon_dt"
        Me.mon_dt.Size = New System.Drawing.Size(221, 21)
        Me.mon_dt.TabIndex = 129
        Me.mon_dt.Title = "월 설정"
        Me.mon_dt.TitleWidth = 90
        '
        'mon_dt1
        '
        Me.mon_dt1.ColumnName = "ps_cd"
        Me.mon_dt1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.mon_dt1.Location = New System.Drawing.Point(937, 3)
        Me.mon_dt1.Name = "mon_dt1"
        Me.mon_dt1.Size = New System.Drawing.Size(78, 21)
        Me.mon_dt1.TabIndex = 131
        Me.mon_dt1.TableName = "ps_cd"
        Me.mon_dt1.Title = "날짜1"
        Me.mon_dt1.TitleWidth = 30
        Me.mon_dt1.Visible = False
        '
        'gigan_dt1
        '
        Me.gigan_dt1.ColumnName = "ps_cd"
        Me.gigan_dt1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gigan_dt1.Location = New System.Drawing.Point(1021, 3)
        Me.gigan_dt1.Name = "gigan_dt1"
        Me.gigan_dt1.Size = New System.Drawing.Size(78, 21)
        Me.gigan_dt1.TabIndex = 132
        Me.gigan_dt1.TableName = "ps_cd"
        Me.gigan_dt1.Title = "기간1"
        Me.gigan_dt1.TitleWidth = 30
        Me.gigan_dt1.Visible = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer3.Size = New System.Drawing.Size(1383, 541)
        Me.SplitContainer3.SplitterDistance = 671
        Me.SplitContainer3.TabIndex = 1
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.EPanel3)
        Me.SplitContainer4.Size = New System.Drawing.Size(671, 541)
        Me.SplitContainer4.SplitterDistance = 258
        Me.SplitContainer4.TabIndex = 0
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Controls.Add(Me.ch_sum1)
        Me.EPanel2.Controls.Add(Me.p_sum1)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(671, 258)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     1 주차"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RecordNavigator = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(667, 233)
        Me.g10.TabIndex = 2
        '
        'ch_sum1
        '
        Me.ch_sum1.ColumnName = "ps_cd"
        Me.ch_sum1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ch_sum1.Location = New System.Drawing.Point(484, 2)
        Me.ch_sum1.Name = "ch_sum1"
        Me.ch_sum1.Size = New System.Drawing.Size(182, 21)
        Me.ch_sum1.TabIndex = 128
        Me.ch_sum1.TableName = "ps_cd"
        Me.ch_sum1.Title = "출고확인 합계"
        Me.ch_sum1.TitleWidth = 90
        '
        'p_sum1
        '
        Me.p_sum1.ColumnName = "ps_cd"
        Me.p_sum1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_sum1.Location = New System.Drawing.Point(286, 2)
        Me.p_sum1.Name = "p_sum1"
        Me.p_sum1.Size = New System.Drawing.Size(192, 21)
        Me.p_sum1.TabIndex = 127
        Me.p_sum1.TableName = "ps_cd"
        Me.p_sum1.Title = "포장완료 합계"
        Me.p_sum1.TitleWidth = 90
        '
        'EPanel3
        '
        Me.EPanel3.Controls.Add(Me.ch_sum3)
        Me.EPanel3.Controls.Add(Me.p_sum3)
        Me.EPanel3.Controls.Add(Me.g30)
        Me.EPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel3.Location = New System.Drawing.Point(0, 0)
        Me.EPanel3.Name = "EPanel3"
        Me.EPanel3.Size = New System.Drawing.Size(671, 279)
        Me.EPanel3.TabIndex = 1
        Me.EPanel3.Text = "     3 주차"
        '
        'ch_sum3
        '
        Me.ch_sum3.ColumnName = "ps_cd"
        Me.ch_sum3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ch_sum3.Location = New System.Drawing.Point(484, 1)
        Me.ch_sum3.Name = "ch_sum3"
        Me.ch_sum3.Size = New System.Drawing.Size(182, 21)
        Me.ch_sum3.TabIndex = 130
        Me.ch_sum3.TableName = "ps_cd"
        Me.ch_sum3.Title = "출고확인 합계"
        Me.ch_sum3.TitleWidth = 90
        '
        'p_sum3
        '
        Me.p_sum3.ColumnName = "ps_cd"
        Me.p_sum3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_sum3.Location = New System.Drawing.Point(286, 1)
        Me.p_sum3.Name = "p_sum3"
        Me.p_sum3.Size = New System.Drawing.Size(192, 21)
        Me.p_sum3.TabIndex = 129
        Me.p_sum3.TableName = "ps_cd"
        Me.p_sum3.Title = "포장완료 합계"
        Me.p_sum3.TitleWidth = 90
        '
        'g30
        '
        Me.g30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g30.Location = New System.Drawing.Point(2, 23)
        Me.g30.Name = "g30"
        Me.g30.ReadOnly = False
        Me.g30.RecordNavigator = False
        Me.g30.RowHeight = -1
        Me.g30.Size = New System.Drawing.Size(667, 254)
        Me.g30.TabIndex = 2
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
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel4)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.EPanel5)
        Me.SplitContainer5.Size = New System.Drawing.Size(708, 541)
        Me.SplitContainer5.SplitterDistance = 259
        Me.SplitContainer5.TabIndex = 0
        '
        'EPanel4
        '
        Me.EPanel4.Controls.Add(Me.g20)
        Me.EPanel4.Controls.Add(Me.p_sum2)
        Me.EPanel4.Controls.Add(Me.ch_sum2)
        Me.EPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel4.Location = New System.Drawing.Point(0, 0)
        Me.EPanel4.Name = "EPanel4"
        Me.EPanel4.Size = New System.Drawing.Size(708, 259)
        Me.EPanel4.TabIndex = 1
        Me.EPanel4.Text = "     2 주차"
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(2, 23)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(704, 234)
        Me.g20.TabIndex = 2
        '
        'p_sum2
        '
        Me.p_sum2.ColumnName = "ps_cd"
        Me.p_sum2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_sum2.Location = New System.Drawing.Point(324, 2)
        Me.p_sum2.Name = "p_sum2"
        Me.p_sum2.Size = New System.Drawing.Size(192, 21)
        Me.p_sum2.TabIndex = 131
        Me.p_sum2.TableName = "ps_cd"
        Me.p_sum2.Title = "포장완료 합계"
        Me.p_sum2.TitleWidth = 90
        '
        'ch_sum2
        '
        Me.ch_sum2.ColumnName = "ps_cd"
        Me.ch_sum2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ch_sum2.Location = New System.Drawing.Point(522, 2)
        Me.ch_sum2.Name = "ch_sum2"
        Me.ch_sum2.Size = New System.Drawing.Size(182, 21)
        Me.ch_sum2.TabIndex = 132
        Me.ch_sum2.TableName = "ps_cd"
        Me.ch_sum2.Title = "출고확인 합계"
        Me.ch_sum2.TitleWidth = 90
        '
        'EPanel5
        '
        Me.EPanel5.Controls.Add(Me.g40)
        Me.EPanel5.Controls.Add(Me.p_sum4)
        Me.EPanel5.Controls.Add(Me.ch_sum4)
        Me.EPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel5.Location = New System.Drawing.Point(0, 0)
        Me.EPanel5.Name = "EPanel5"
        Me.EPanel5.Size = New System.Drawing.Size(708, 278)
        Me.EPanel5.TabIndex = 1
        Me.EPanel5.Text = "     4 주차"
        '
        'g40
        '
        Me.g40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g40.Location = New System.Drawing.Point(2, 23)
        Me.g40.Name = "g40"
        Me.g40.ReadOnly = False
        Me.g40.RecordNavigator = False
        Me.g40.RowHeight = -1
        Me.g40.Size = New System.Drawing.Size(704, 253)
        Me.g40.TabIndex = 2
        '
        'p_sum4
        '
        Me.p_sum4.ColumnName = "ps_cd"
        Me.p_sum4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.p_sum4.Location = New System.Drawing.Point(324, 1)
        Me.p_sum4.Name = "p_sum4"
        Me.p_sum4.Size = New System.Drawing.Size(192, 21)
        Me.p_sum4.TabIndex = 131
        Me.p_sum4.TableName = "ps_cd"
        Me.p_sum4.Title = "포장완료 합계"
        Me.p_sum4.TitleWidth = 90
        '
        'ch_sum4
        '
        Me.ch_sum4.ColumnName = "ps_cd"
        Me.ch_sum4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ch_sum4.Location = New System.Drawing.Point(522, 1)
        Me.ch_sum4.Name = "ch_sum4"
        Me.ch_sum4.Size = New System.Drawing.Size(182, 21)
        Me.ch_sum4.TabIndex = 132
        Me.ch_sum4.TableName = "ps_cd"
        Me.ch_sum4.Title = "출고확인 합계"
        Me.ch_sum4.TitleWidth = 90
        '
        'od_amt
        '
        Me.od_amt.ColumnName = "ps_cd"
        Me.od_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_amt.Location = New System.Drawing.Point(286, 34)
        Me.od_amt.Name = "od_amt"
        Me.od_amt.Size = New System.Drawing.Size(179, 21)
        Me.od_amt.TabIndex = 139
        Me.od_amt.TableName = "ps_cd"
        Me.od_amt.Title = "총 주문금액"
        Me.od_amt.TitleWidth = 80
        '
        'od_qty
        '
        Me.od_qty.ColumnName = "ps_cd"
        Me.od_qty.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.od_qty.Location = New System.Drawing.Point(492, 34)
        Me.od_qty.Name = "od_qty"
        Me.od_qty.Size = New System.Drawing.Size(179, 21)
        Me.od_qty.TabIndex = 140
        Me.od_qty.TableName = "ps_cd"
        Me.od_qty.Title = "총 주문수량"
        Me.od_qty.TitleWidth = 80
        '
        'wait_amt
        '
        Me.wait_amt.ColumnName = "ps_cd"
        Me.wait_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.wait_amt.Location = New System.Drawing.Point(706, 34)
        Me.wait_amt.Name = "wait_amt"
        Me.wait_amt.Size = New System.Drawing.Size(179, 21)
        Me.wait_amt.TabIndex = 141
        Me.wait_amt.TableName = "ps_cd"
        Me.wait_amt.Title = "포장 완료대기"
        Me.wait_amt.TitleWidth = 80
        '
        'chul_amt
        '
        Me.chul_amt.ColumnName = "ps_cd"
        Me.chul_amt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chul_amt.Location = New System.Drawing.Point(920, 34)
        Me.chul_amt.Name = "chul_amt"
        Me.chul_amt.Size = New System.Drawing.Size(179, 21)
        Me.chul_amt.TabIndex = 142
        Me.chul_amt.TableName = "ps_cd"
        Me.chul_amt.Title = "총 출하금액"
        Me.chul_amt.TitleWidth = 80
        '
        'WP_TR2103
        '
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "WP_TR2103"
        Me.Size = New System.Drawing.Size(1383, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.EPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel3.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel4.ResumeLayout(False)
        CType(Me.EPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tp1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents mon_dt As Frame7.eDate
    Friend WithEvents ch_sum1 As Frame7.eText
    Friend WithEvents p_sum1 As Frame7.eText
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Private WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Private WithEvents EPanel3 As Frame7.ePanel
    Friend WithEvents g30 As Frame7.eGrid
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Private WithEvents EPanel4 As Frame7.ePanel
    Friend WithEvents g20 As Frame7.eGrid
    Private WithEvents EPanel5 As Frame7.ePanel
    Friend WithEvents g40 As Frame7.eGrid
    Friend WithEvents ch_sum3 As Frame7.eText
    Friend WithEvents p_sum3 As Frame7.eText
    Friend WithEvents p_sum2 As Frame7.eText
    Friend WithEvents ch_sum2 As Frame7.eText
    Friend WithEvents p_sum4 As Frame7.eText
    Friend WithEvents ch_sum4 As Frame7.eText
    Friend WithEvents gigan_dt1 As Frame7.eText
    Friend WithEvents mon_dt1 As Frame7.eText
    Friend WithEvents mon_dt4 As Frame7.eText
    Friend WithEvents gigan_dt4 As Frame7.eText
    Friend WithEvents mon_dt3 As Frame7.eText
    Friend WithEvents gigan_dt3 As Frame7.eText
    Friend WithEvents gigan_dt2 As Frame7.eText
    Friend WithEvents mon_dt2 As Frame7.eText
    Friend WithEvents chul_amt As Frame7.eText
    Friend WithEvents wait_amt As Frame7.eText
    Friend WithEvents od_qty As Frame7.eText
    Friend WithEvents od_amt As Frame7.eText

End Class
