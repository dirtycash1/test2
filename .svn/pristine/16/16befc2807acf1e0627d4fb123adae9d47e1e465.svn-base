Imports Frame7
Imports Base7
Imports Base7.Shared

'Imports System.Web.UI
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
'Imports System.Data
'Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
'Imports DevExpress.XtraGrid.Views.Grid

Public Class HRA105

    Private Sub HRA105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Fill(Me, SplitContainer1)

        'EGrid2.RowHeight = 80

        'EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me.WorkSets("hra105_1").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub EGrid2_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles EGrid2.AfterMoveRow
        'If EGrid2.Text("emp_nm") = "송일구" And 1 = 1 Then


        '    EGrid2.Editable = False
        'Else

        '    EGrid2.Editable = True

        'End If
    End Sub

    Private Sub EGrid2_BeforeMoveRow(ByVal sender As Object, ByVal RowIndex As Integer, ByRef AllowMove As Boolean) Handles EGrid2.BeforeMoveRow

    End Sub

    Private Sub EGrid2_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles EGrid2.CellValueChanging

        'MsgBox(ColumnName + "-> " + Value)

    End Sub

    Private Sub EGrid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles EGrid2.DoubleClick

        'MsgBox(EGrid2.RowIndex.ToString + "-> " + EGrid2.Text("emp_nm"))

    End Sub

    'Private Sub EGrid2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EGrid2.Click
    '    MsgBox("aaaa")
    'End Sub

    'Private Sub EGrid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles EGrid2.DoubleClick
    '    MsgBox("bbb")
    'End Sub



    'Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
    '    'Console.WriteLine(e.KeyCode.ToString + "  " + e.KeyValue.ToString + "   " + e.KeyData.ToString)

    '    'RichTextBox1.Font = New Font("Courier New", 10) ', newFontStyle)

    'End Sub

    'Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
    '    'RichTextBox1.SelectAll()
    '    'RichTextBox1.Font = New Font("Courier New", 10) ', newFontStyle)


    'End Sub

    'Private Sub HRA105_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    RichTextBox1.Text = "iiiiiiiiiii"

    '    RichTextBox1.Font = New Font("Courier New", 10) ', newFontStyle)


    '    'RichTextBox1.SelectionTabs.Length = New int()  {4,4,4,}



    'End Sub

    'Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    'End Sub

    'Private Sub GridView1_DragObjectOver(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs) Handles GridView1.DragObjectOver
    '    e.DragObject

    '    GridView1.OptionsLayout.dr()

    'End Sub





    '''' <summary>
    '''' Summary description for GridDragDropInternal.
    '''' </summary>
    'Partial Public Class GridDragDropInternal
    '    Inherits TutorialControl
    '    Public Sub New()
    '        '
    '        ' Required for Windows Form Designer support
    '        '
    '        InitializeComponent()

    '        '
    '        ' TODO: Add any constructor code after InitializeComponent call
    '        '
    '    End Sub
    'Private hitInfo As GridHitInfo = Nothing

    '    Private Sub GridDragDropInternal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        InitData()
    '        gridView1.SetRowExpanded(-1, True)
    '    End Sub

    '    Private Sub InitData()
    '        Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Contacts.xml")
    '        If DBFileName <> "" Then
    '            Dim ds As DataSet = New DataSet()
    '            ds.ReadXml(DBFileName)
    '            gridControl1.DataSource = ds.Tables(0)
    '        End If
    '    End Sub


    ''<gridControl1>
    'Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    'Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo
    '    hitInfo = GridView1.CalcHitInfo(New Point(e.X, e.Y))
    '    If hitInfo.RowHandle < 0 Then
    '        hitInfo = Nothing
    '    End If
    'End Sub

    'Private Sub gridControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    If hitInfo Is Nothing Then
    '        Return
    '    End If
    '    If e.Button <> Windows.Forms.MouseButtons.Left Then
    '        Return
    '    End If
    '    Dim dragRect As Rectangle = New Rectangle(New Point(hitInfo.HitPoint.X - SystemInformation.DragSize.Width \ 2, hitInfo.HitPoint.Y - SystemInformation.DragSize.Height \ 2), SystemInformation.DragSize)
    '    If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
    '        If hitInfo.InRow Then
    '            gridControl1.DoDragDrop(New Object() {hitInfo.RowHandle, gridControl1}, DragDropEffects.All)
    '        End If
    '    End If
    'End Sub
    ''</gridControl1>

    'Private Function GetDragObject(ByVal sender As Object, ByVal data As IDataObject) As Integer
    '    Dim obj As Object() = TryCast(data.GetData(GetType(Object())), Object())
    '    If obj Is Nothing OrElse (Not sender.Equals(gridControl1)) Then
    '        Return -2
    '    End If
    '    If TypeOf obj(0) Is Int32 Then
    '        Return CInt(Fix(obj(0)))
    '    Else
    '        Return -1
    '    End If
    'End Function

    ''<gridControl1>
    'Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    '    Dim hi As GridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(New Point(e.X, e.Y)))
    '    Dim handle As Integer = GetDragObject(sender, e.Data)
    '    If hi.InRow AndAlso handle >= 0 AndAlso handle <> hi.RowHandle Then



    '        If (e.KeyState And 8) <> 0 Then
    '            e.Effect = DragDropEffects.Copy
    '        Else
    '            e.Effect = DragDropEffects.Move
    '        End If
    '    Else
    '        e.Effect = DragDropEffects.None
    '    End If
    'End Sub

    ''    Private Sub gridControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles GridControl1.DragDrop
    ''        Dim hi As GridHitInfo = gridView1.CalcHitInfo(gridControl1.PointToClient(New Point(e.X, e.Y)))
    ''        Dim handle As Integer = GetDragObject(sender, e.Data)
    ''        If handle < 0 Then
    ''            Return
    ''        End If
    ''        If hi.InRow Then
    ''            Dim i As Integer = 0
    ''            Dim row As DataRowView = TryCast(gridView1.GetRow(handle), DataRowView)
    ''            'the following code determines whether the target row is a group row and if a group row is detected, 
    ''            'it retrieves the actual data row corresponding to it.
    ''            Dim newHandle As Integer = hi.RowHandle
    ''            If newHandle < 0 Then
    ''                gridView1.SetRowExpanded(newHandle, True, True)
    ''                newHandle = gridView1.GetDataRowHandleByGroupRowHandle(newHandle)
    ''            End If
    ''            Dim rowReciever As DataRow = gridView1.GetDataRow(newHandle)
    ''            'the following code implements actual data moving or copying
    ''            Dim newRow As DataRowView = Nothing
    ''            If e.Effect = DragDropEffects.Copy Then
    ''                newRow = (CType(gridView1.DataSource, DataView)).AddNew()
    ''                i = 0
    ''                Do While i < gridView1.Columns.Count
    ''                    newRow.Row(gridView1.Columns(i).FieldName) = row(gridView1.Columns(i).FieldName)
    ''                    i += 1
    ''                Loop
    ''                row = newRow
    ''            End If
    ''            i = 0
    ''            Do While i < gridView1.SortInfo.GroupCount
    ''                row.Row(gridView1.GroupedColumns(i).FieldName) = rowReciever(gridView1.GroupedColumns(i).FieldName)
    ''                i += 1
    ''            Loop
    ''            If Not newRow Is Nothing Then
    ''                newRow.Row("id") = (CType(gridView1.DataSource, DataView)).Count
    ''            End If
    ''            row.EndEdit()
    ''        End If
    ''    End Sub
    ''    '</gridControl1>

    ''    Private Sub gridView1_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
    ''        If (Not MouseButtons.Equals(Windows.Forms.MouseButtons.None)) Then
    ''            e.Cancel = True
    ''        End If
    ''    End Sub
    ''    Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
    ''        Get
    ''            Return True
    ''        End Get
    ''    End Property
    ''End Class



    Private Sub Print()
        'Dim p As OpenParameters = New OpenParameters
        'p.Add("@emp_no", emp_no.Text)

        'System7.ReportView.LoadView("HRA100", "", "", p, )
        ''System7.ReportView.LoadView("HRA100", "", "hra100_print", p, )
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Print()
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        EGrid2.Text("qty") = "12345"
        EGrid2.Text("up") = "3"

    End Sub

    Private Sub EDate2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDate2.Load

    End Sub
End Class
