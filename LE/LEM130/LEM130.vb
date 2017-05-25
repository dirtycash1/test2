Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEM130

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.New

                If Not CheckRequired(out_fac, out_wh, cust_cd, in_wh) Then
                    Exit Sub
                End If

                'If g10.RowCount - 1 < 0 Then
                '    MyBase.Open()
                'End If

                g10.AddNewRow()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        Me.Open("lem130_move_no")

        MyBase.Open()
    End Sub

    Public Sub Open2(ByVal outDt As String, ByVal custCd As String, ByVal facCd As String, ByVal whCd As String)
        fr_dt.Text = outDt
        to_dt.Text = outDt
        cust_cd.Text = custCd
        out_fac.Text = facCd
        out_wh.Text = whCd

        MyBase.Open()
    End Sub

    'Public Sub New_Form()
    '    Me.Open()
    'End Sub


    'Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow

    '    'g10.Text("mov_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("out_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("in_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("out_fac", g10.RowIndex) = out_fac.Text
    '    'g10.Text("out_wh", g10.RowIndex) = out_wh.Text
    '    'g10.Text("in_fac", g10.RowIndex) = cust_cd.Text
    '    'g10.Text("in_wh", g10.RowIndex) = in_wh.Text
    '    'g10.Text("out_dept", g10.RowIndex) = dept_cd.Text
    '    'g10.Text("in_dept", g10.RowIndex) = dept_cd.Text
    '    'g10.Text("mov_bc", g10.RowIndex) = mov_bc.Text
    '    'g10.Text("ent_bc", g10.RowIndex) = ent_bc.Text
    '    'g10.Text("rmks2", g10.RowIndex) = rmks.Text
    '    'g10.Text("in_dt", g10.RowIndex) = g10.Text("out_dt", g10.RowIndex)
    'End Sub


    'Private Sub cust_cd_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles cust_cd.TextChanged

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("in_fac", i) = cust_cd.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub dept_cd_TextChanged(ByVal sender As Object, ByVal oldValue As String)

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            'g10.Text("out_dept", i) = dept_cd.Text
    '            'g10.Text("in_dept", i) = dept_cd.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub reg_id_TextChanged(ByVal sender As Object, ByVal oldValue As String)

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            'g10.Text("mov_rid", i) = reg_id.Text
    '            'g10.Text("out_rid", i) = reg_id.Text
    '            'g10.Text("in_rid", i) = reg_id.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub in_wh_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles in_wh.TextChanged

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("in_wh", i) = in_wh.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub out_fac_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles out_fac.TextChanged

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("out_fac", i) = out_fac.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub out_wh_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles out_wh.TextChanged

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            g10.Text("out_wh", i) = out_wh.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub rmks_TextChanged(ByVal sender As Object, ByVal oldValue As String)

    '    Dim i As Integer
    '    If g10.RowCount - 1 >= 0 Then

    '        For i = 0 To g10.RowCount - 1
    '            'g10.Text("rmks2", i) = rmks.Text
    '        Next

    '    End If

    'End Sub

    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

    '    If ColumnName = "out_dt" Then
    '        g10.Text("in_dt", g10.RowIndex) = g10.Text("out_dt", g10.RowIndex)
    '    End If

    'End Sub

    'Private Sub g10_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.InsertedRow

    '    'g10.Text("mov_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("out_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("in_rid", g10.RowIndex) = reg_id.Text
    '    'g10.Text("out_fac", g10.RowIndex) = out_fac.Text
    '    'g10.Text("out_wh", g10.RowIndex) = out_wh.Text
    '    'g10.Text("in_fac", g10.RowIndex) = cust_cd.Text
    '    'g10.Text("in_wh", g10.RowIndex) = in_wh.Text
    '    'g10.Text("out_dept", g10.RowIndex) = dept_cd.Text
    '    'g10.Text("in_dept", g10.RowIndex) = dept_cd.Text
    '    'g10.Text("mov_bc", g10.RowIndex) = mov_bc.Text
    '    'g10.Text("ent_bc", g10.RowIndex) = ent_bc.Text
    '    'g10.Text("rmks2", g10.RowIndex) = rmks.Text
    '    'g10.Text("in_dt", g10.RowIndex) = g10.Text("out_dt", g10.RowIndex)

    'End Sub
End Class
