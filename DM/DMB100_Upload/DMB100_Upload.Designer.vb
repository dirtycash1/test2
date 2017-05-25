<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMB100_Upload
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
        Me.EPanel1 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        Me.btn_item = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_bom = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_del = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Controls.Add(Me.btn_item)
        Me.EPanel1.Controls.Add(Me.btn_del)
        Me.EPanel1.Controls.Add(Me.btn_bom)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(1000, 690)
        Me.EPanel1.TabIndex = 1
        Me.EPanel1.Text = "     BOM 일괄등록"
        '
        'g10
        '
        Me.g10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g10.Location = New System.Drawing.Point(0, 56)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(1001, 632)
        Me.g10.TabIndex = 2
        '
        'btn_item
        '
        Me.btn_item.Location = New System.Drawing.Point(31, 27)
        Me.btn_item.Name = "btn_item"
        Me.btn_item.Size = New System.Drawing.Size(163, 25)
        Me.btn_item.TabIndex = 3
        Me.btn_item.Text = "2. 품목등록"
        '
        'btn_bom
        '
        Me.btn_bom.Location = New System.Drawing.Point(200, 27)
        Me.btn_bom.Name = "btn_bom"
        Me.btn_bom.Size = New System.Drawing.Size(163, 25)
        Me.btn_bom.TabIndex = 3
        Me.btn_bom.Text = "3. BOM등록"
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(369, 28)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(163, 25)
        Me.btn_del.TabIndex = 3
        Me.btn_del.Text = "4. 임시자료 삭제"
        '
        'DMB100_Upload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "DMB100_Upload"
        Me.Size = New System.Drawing.Size(1000, 690)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents btn_item As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_bom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_del As DevExpress.XtraEditors.SimpleButton

End Class
