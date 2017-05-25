Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEM115


    Private Sub LEM115_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '품목이동 번호 채번
        'mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'mov_no.CodeDateField = out_dt

        Me.New_Form()
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
                Me.New_Form()

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        mov_no.Text = ""
        Me.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        Me.Open()
    End Sub


    Private m_StopEvent As Boolean

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        If ColumnName = "chk" Then

            If Value = "1" Then
                g20.Text("mov_qty") = g20.Text("end_qty")

            Else
                g20.Text("mov_qty") = ""
            End If

        End If

        If ColumnName = "mov_qty" Then

            g20.Text("chk") = IIf(Value = "", "0", "1")

        End If


        m_StopEvent = False

    End Sub


    'Public Sub Open5(ByVal faccd As String, ByVal outwh As String, ByVal inwh As String)

    '    Me.Open()

    '    Dim dset As DataSet = Me.OpenDataSet("LEM115_open5")

    '    For Each dRow In dset.Tables(0).Rows
    '        g10.AddNewRow()

    '        g10.Text("itm_cd", g10.RowIndex) = dRow(0)
    '        g10.Text("mov_qty", g10.RowIndex) = dRow(1)
    '    Next

    '    Me.Open("LEM115_open5_del")

    '    out_fac.Text = faccd
    '    in_fac.Text = faccd
    '    out_wh.Text = outwh
    '    in_wh.Text = inwh
    '    mov_bc.Text = "LE300200"
    'End Sub

    '#Region " Print "
    '    Private Sub Print()
    '        Dim p As OpenParameters = New OpenParameters
    '        p.Add("@mov_no", g10.Text("mov_no"))

    '        System7.ReportView.LoadView("LEM101", "", "LEM101_Print", p)
    '    End Sub
    '#End Region

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim i As Integer
        Dim k As Integer, l As Integer

        If Not CheckRequired(in_fac, in_wh) Then
            Exit Sub
        End If

        If g10.Text("itm_cd", 0) = "" Then
            g10.DeleteRow(0)
        End If

        If g20.RowCount >= 0 Then
            For i = 0 To g20.RowCount - 1
                If g20.Text("chk", i) = "1" Then
                    g10.AddNewRow()
                    For l = 0 To g20.ColumnCount - 1
                        For k = 0 To g10.ColumnCount - 1
                            If g20.FieldName(l) = g10.FieldName(k) Then
                                g10.Text(g10.FieldName(k), g10.RowIndex) = g20.Text(g10.FieldName(k), i)
                            End If
                        Next
                    Next
                End If
            Next
        End If
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        MyBase.Open("LEM115_g20")
    End Sub

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow
        g10.Text("out_dt") = out_dt.Text
        g10.Text("out_wh") = out_wh.Text : g10.Text("wh_nm") = out_wh.EditText
        g10.Text("in_wh") = in_wh.Text : g10.Text("in_wh_nm") = in_wh.EditText
    End Sub


    Private Sub chk_lot_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_lot.CheckedChanged
        MyBase.Open()
    End Sub

End Class
