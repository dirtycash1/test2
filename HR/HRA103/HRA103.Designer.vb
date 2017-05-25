<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRA103
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRA103))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.ECheckCombo1 = New Frame7.eCheckCombo
        Me.EText2 = New Frame7.eText
        Me.EText1 = New Frame7.eText
        Me.ECombo2 = New Frame7.eCombo
        Me.ECombo1 = New Frame7.eCombo
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(196, 256)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(140, 36)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(152, 344)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(156, 21)
        Me.TextEdit1.TabIndex = 7
        '
        'ECheckCombo1
        '
        Me.ECheckCombo1.Location = New System.Drawing.Point(148, 188)
        Me.ECheckCombo1.Name = "ECheckCombo1"
        Me.ECheckCombo1.Size = New System.Drawing.Size(368, 21)
        Me.ECheckCombo1.TabIndex = 12
        '
        'EText2
        '
        Me.EText2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EText2.Location = New System.Drawing.Point(152, 148)
        Me.EText2.Name = "EText2"
        Me.EText2.Size = New System.Drawing.Size(252, 21)
        Me.EText2.TabIndex = 11
        '
        'EText1
        '
        Me.EText1.Location = New System.Drawing.Point(152, 124)
        Me.EText1.Name = "EText1"
        Me.EText1.Size = New System.Drawing.Size(252, 21)
        Me.EText1.TabIndex = 10
        '
        'ECombo2
        '
        Me.ECombo2.Location = New System.Drawing.Point(136, 52)
        Me.ECombo2.Name = "ECombo2"
        Me.ECombo2.Size = New System.Drawing.Size(292, 21)
        Me.ECombo2.TabIndex = 8
        Me.ECombo2.TitleWidth = 24
        '
        'ECombo1
        '
        Me.ECombo1.Location = New System.Drawing.Point(76, 232)
        Me.ECombo1.Name = "ECombo1"
        Me.ECombo1.Size = New System.Drawing.Size(248, 21)
        Me.ECombo1.TabIndex = 6
        Me.ECombo1.TitleWidth = 24
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(48, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(588, 428)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(564, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'HRA103
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ECheckCombo1)
        Me.Controls.Add(Me.EText2)
        Me.Controls.Add(Me.EText1)
        Me.Controls.Add(Me.ECombo2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.ECombo1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "HRA103"
        Me.Size = New System.Drawing.Size(747, 516)
        Me.WorkSets = CType(resources.GetObject("$this.WorkSets"), Microsoft.VisualBasic.Collection)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ECombo1 As Frame7.eCombo
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ECombo2 As Frame7.eCombo
    Friend WithEvents EText1 As Frame7.eText
    Friend WithEvents EText2 As Frame7.eText
    Friend WithEvents ECheckCombo1 As Frame7.eCheckCombo
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
