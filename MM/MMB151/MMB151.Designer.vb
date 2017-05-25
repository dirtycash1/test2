<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMB151
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
        Me.urg_bc = New Frame7.eCombo()
        Me.cury_bc = New Frame7.eCombo()
        Me.di_bc = New Frame7.eCombo()
        Me.po_dept = New Frame7.eText()
        Me.po_dept_nm = New Frame7.eText()
        Me.po_fac = New Frame7.eCombo()
        Me.rmks = New Frame7.eText()
        Me.dlv_dt = New Frame7.eDate()
        Me.cust_cd = New Frame7.eText()
        Me.id = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.nm = New Frame7.eText()
        Me.reg_id = New Frame7.eText()
        Me.in_fac = New Frame7.eCombo()
        Me.in_wh = New Frame7.eCombo()
        Me.po_no = New Frame7.eText()
        Me.po_dt = New Frame7.eDate()
        Me.po_kd = New Frame7.eCombo()
        Me.EPanel2 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(900, 516)
        Me.SplitContainer1.SplitterDistance = 179
        Me.SplitContainer1.TabIndex = 0
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.SimpleButton2)
        Me.EPanel1.Controls.Add(Me.urg_bc)
        Me.EPanel1.Controls.Add(Me.cury_bc)
        Me.EPanel1.Controls.Add(Me.di_bc)
        Me.EPanel1.Controls.Add(Me.po_dept)
        Me.EPanel1.Controls.Add(Me.po_dept_nm)
        Me.EPanel1.Controls.Add(Me.po_fac)
        Me.EPanel1.Controls.Add(Me.rmks)
        Me.EPanel1.Controls.Add(Me.dlv_dt)
        Me.EPanel1.Controls.Add(Me.cust_cd)
        Me.EPanel1.Controls.Add(Me.id)
        Me.EPanel1.Controls.Add(Me.cust_nm)
        Me.EPanel1.Controls.Add(Me.nm)
        Me.EPanel1.Controls.Add(Me.reg_id)
        Me.EPanel1.Controls.Add(Me.in_fac)
        Me.EPanel1.Controls.Add(Me.in_wh)
        Me.EPanel1.Controls.Add(Me.po_no)
        Me.EPanel1.Controls.Add(Me.po_dt)
        Me.EPanel1.Controls.Add(Me.po_kd)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(900, 179)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색"
        '
        'urg_bc
        '
        Me.urg_bc.Location = New System.Drawing.Point(520, 124)
        Me.urg_bc.Name = "urg_bc"
        Me.urg_bc.Size = New System.Drawing.Size(240, 21)
        Me.urg_bc.TabIndex = 50
        Me.urg_bc.Title = "긴급구분"
        '
        'cury_bc
        '
        Me.cury_bc.Location = New System.Drawing.Point(520, 148)
        Me.cury_bc.Name = "cury_bc"
        Me.cury_bc.Size = New System.Drawing.Size(240, 21)
        Me.cury_bc.TabIndex = 23
        Me.cury_bc.Title = "통화"
        '
        'di_bc
        '
        Me.di_bc.Location = New System.Drawing.Point(520, 100)
        Me.di_bc.Name = "di_bc"
        Me.di_bc.Size = New System.Drawing.Size(240, 21)
        Me.di_bc.TabIndex = 22
        Me.di_bc.Title = "내외자"
        '
        'po_dept
        '
        Me.po_dept.Location = New System.Drawing.Point(520, 76)
        Me.po_dept.Name = "po_dept"
        Me.po_dept.Size = New System.Drawing.Size(240, 21)
        Me.po_dept.TabIndex = 21
        Me.po_dept.Title = "발주부서"
        '
        'po_dept_nm
        '
        Me.po_dept_nm.Location = New System.Drawing.Point(764, 76)
        Me.po_dept_nm.Name = "po_dept_nm"
        Me.po_dept_nm.Size = New System.Drawing.Size(120, 21)
        Me.po_dept_nm.TabIndex = 20
        Me.po_dept_nm.Title = "출고번호"
        Me.po_dept_nm.TitleWidth = 0
        '
        'po_fac
        '
        Me.po_fac.Location = New System.Drawing.Point(520, 28)
        Me.po_fac.Name = "po_fac"
        Me.po_fac.Size = New System.Drawing.Size(240, 21)
        Me.po_fac.TabIndex = 19
        Me.po_fac.Title = "발주공장"
        '
        'rmks
        '
        Me.rmks.Location = New System.Drawing.Point(8, 124)
        Me.rmks.Name = "rmks"
        Me.rmks.Size = New System.Drawing.Size(496, 21)
        Me.rmks.TabIndex = 18
        Me.rmks.Title = "비고"
        '
        'dlv_dt
        '
        Me.dlv_dt.Location = New System.Drawing.Point(8, 76)
        Me.dlv_dt.Name = "dlv_dt"
        Me.dlv_dt.Size = New System.Drawing.Size(240, 21)
        Me.dlv_dt.TabIndex = 17
        Me.dlv_dt.Title = "납기일자"
        '
        'cust_cd
        '
        Me.cust_cd.Location = New System.Drawing.Point(8, 100)
        Me.cust_cd.Name = "cust_cd"
        Me.cust_cd.Size = New System.Drawing.Size(240, 21)
        Me.cust_cd.TabIndex = 15
        Me.cust_cd.Title = "매입업체"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(520, 52)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(240, 21)
        Me.id.TabIndex = 16
        Me.id.Title = "발주담당"
        '
        'cust_nm
        '
        Me.cust_nm.Location = New System.Drawing.Point(252, 100)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(252, 21)
        Me.cust_nm.TabIndex = 14
        Me.cust_nm.Title = "출고번호"
        Me.cust_nm.TitleWidth = 0
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(762, 52)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(120, 21)
        Me.nm.TabIndex = 12
        Me.nm.Title = "출고번호"
        Me.nm.TitleWidth = 0
        '
        'reg_id
        '
        Me.reg_id.Location = New System.Drawing.Point(886, 52)
        Me.reg_id.Name = "reg_id"
        Me.reg_id.Size = New System.Drawing.Size(20, 21)
        Me.reg_id.TabIndex = 13
        Me.reg_id.Title = "출고번호"
        Me.reg_id.TitleWidth = 0
        '
        'in_fac
        '
        Me.in_fac.Location = New System.Drawing.Point(264, 52)
        Me.in_fac.Name = "in_fac"
        Me.in_fac.Size = New System.Drawing.Size(240, 21)
        Me.in_fac.TabIndex = 11
        Me.in_fac.Title = "입고공장"
        '
        'in_wh
        '
        Me.in_wh.Location = New System.Drawing.Point(264, 76)
        Me.in_wh.Name = "in_wh"
        Me.in_wh.Size = New System.Drawing.Size(240, 21)
        Me.in_wh.TabIndex = 10
        Me.in_wh.Title = "입고창고"
        '
        'po_no
        '
        Me.po_no.Location = New System.Drawing.Point(8, 28)
        Me.po_no.Name = "po_no"
        Me.po_no.Size = New System.Drawing.Size(240, 21)
        Me.po_no.TabIndex = 9
        Me.po_no.Title = "발주번호"
        '
        'po_dt
        '
        Me.po_dt.Location = New System.Drawing.Point(8, 52)
        Me.po_dt.Name = "po_dt"
        Me.po_dt.Size = New System.Drawing.Size(240, 21)
        Me.po_dt.TabIndex = 5
        Me.po_dt.Title = "발주일자"
        '
        'po_kd
        '
        Me.po_kd.Location = New System.Drawing.Point(264, 28)
        Me.po_kd.Name = "po_kd"
        Me.po_kd.Size = New System.Drawing.Size(240, 21)
        Me.po_kd.TabIndex = 3
        Me.po_kd.Title = "발주유형"
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.g10)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(900, 333)
        Me.EPanel2.TabIndex = 1
        Me.EPanel2.Text = "     구매발주 상세 등록"
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(896, 308)
        Me.g10.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(128, 152)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(100, 24)
        Me.SimpleButton2.TabIndex = 51
        Me.SimpleButton2.Text = "최근단가 적용"
        '
        'MMB151
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MMB151"
        Me.Size = New System.Drawing.Size(977, 563)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents po_kd As Frame7.eCombo
    Friend WithEvents po_dt As Frame7.eDate
    Friend WithEvents in_fac As Frame7.eCombo
    Friend WithEvents in_wh As Frame7.eCombo
    Friend WithEvents po_no As Frame7.eText
    Friend WithEvents cust_cd As Frame7.eText
    Friend WithEvents id As Frame7.eText
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents nm As Frame7.eText
    Friend WithEvents reg_id As Frame7.eText
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents cury_bc As Frame7.eCombo
    Friend WithEvents di_bc As Frame7.eCombo
    Friend WithEvents po_dept As Frame7.eText
    Friend WithEvents po_dept_nm As Frame7.eText
    Friend WithEvents po_fac As Frame7.eCombo
    Friend WithEvents rmks As Frame7.eText
    Friend WithEvents dlv_dt As Frame7.eDate
    Friend WithEvents urg_bc As Frame7.eCombo
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton

End Class
