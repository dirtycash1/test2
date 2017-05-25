Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAS500

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub ast_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ast_insert.Click

        If MessageYesNo("[" + de_monf.Text + "] " + "에서" + vbLf + "[" + de_mont.Text + "] " + "까지" + vbLf + _
                        "기간을 상각처리 하시겠습니까?") <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Dim p As New OpenParameters
        p.Add("@work_ty", "insert")
        p.Add("@de_monf", de_monf.Text)
        p.Add("@de_mont", de_mont.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@ast_no", ast_no.Text)
        p.Add("@ast_nm", ast_nm.Text)
        p.Add("@grp1_cd", grp1_cd.Text)
        p.Add("@grp2_cd", grp2_cd.Text)
        Me.OpenDataSet("fas500_work", p)   'test_f30 WorkSet이 등록되어있어야 한다

        de_monf.Text = de_monf.Text
        de_mont.Text = de_mont.Text

        Me.Open()

    End Sub

    'Private Sub ast_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ast_insert.Click

    '    If MessageYesNo("[" + de_monf.Text + "] " + "에서" + vbLf + "[" + de_mont.Text + "] " + "까지" + vbLf + _
    '            "기간을 상각처리 하시겠습니까?") <> MsgBoxResult.Yes Then
    '        Exit Sub
    '    End If

    '    Dim i As Integer
    '    For i = 0 To g10.RowCount
    '        If g10.Text("chk", i) = "1" Then
    '            Dim p As New OpenParameters
    '            p.Add("@work_ty", "insert")
    '            p.Add("@de_monf", de_monf.Text)
    '            p.Add("@de_mont", de_mont.Text)
    '            p.Add("@div_cd", div_cd.Text)
    '            p.Add("@ast_no", ast_no.Text)
    '            p.Add("@ast_nm", ast_nm.Text)
    '            p.Add("@grp1_cd", grp1_cd.Text)
    '            p.Add("@grp2_cd", grp2_cd.Text)
    '            Me.OpenDataSet("fas500_work", p)   'test_f30 WorkSet이 등록되어있어야 한다
    '            de_monf.Text = de_monf.Text
    '            de_mont.Text = de_mont.Text
    '        End If
    '    Next

    '    Me.Open()
    'End Sub

    Private Sub ast_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ast_delete.Click
        If MessageYesNo("삭 제 주 의" + vbLf + _
                "[" + de_monf.Text + "] " + "에서" + vbLf + "[" + de_mont.Text + "] " + "까지" + vbLf + _
                "기간의 상각금액을 삭제합니다" + vbLf + _
                "" + vbLf + _
                "개별자산 상각금액 삭제시 자산번호 검색 후 삭제 하세요") <> MsgBoxResult.Yes Then
            Exit Sub
        End If
        Dim p As New OpenParameters
        p.Add("@work_ty", "delete")
        p.Add("@de_monf", de_monf.Text)
        p.Add("@de_mont", de_mont.Text)
        p.Add("@div_cd", div_cd.Text)
        p.Add("@ast_no", ast_no.Text)
        p.Add("@ast_nm", ast_nm.Text)
        p.Add("@grp1_cd", grp1_cd.Text)
        p.Add("@grp2_cd", grp2_cd.Text)
        Me.OpenDataSet("fas500_work", p)   'test_f30 WorkSet이 등록되어있어야 한다
        Me.Open()
    End Sub

    'Private Sub ast_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ast_delete.Click
    '    If MessageYesNo("삭 제 주 의" + vbLf + _
    '            "[" + de_monf.Text + "] " + "에서" + vbLf + "[" + de_mont.Text + "] " + "까지" + vbLf + _
    '            "기간의 상각금액을 삭제합니다" + vbLf + _
    '            "" + vbLf + _
    '            "개별자산 상각금액 삭제시 자산번호 검색 후 삭제 하세요") <> MsgBoxResult.Yes Then
    '        Exit Sub

    '    End If
    '    Dim i As Integer

    '    For i = 0 To g10.RowCount
    '        If g10.Text("chk", i) = "1" Then
    '            Dim p As New OpenParameters
    '            p.Add("@work_ty", "delete")
    '            p.Add("@de_monf", de_monf.Text)
    '            p.Add("@de_mont", de_mont.Text)
    '            p.Add("@div_cd", div_cd.Text)
    '            p.Add("@ast_no", ast_no.Text)
    '            p.Add("@ast_nm", ast_nm.Text)
    '            p.Add("@grp1_cd", grp1_cd.Text)
    '            p.Add("@grp2_cd", grp2_cd.Text)
    '            Me.OpenDataSet("fas500_work", p)   'test_f30 WorkSet이 등록되어있어야 한다
    '        End If
    '    Next
    '    Me.Open()

    'End Sub

    Private Sub month_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles month_chk.CheckedChanged
        If month_chk.Text = "1" Then
            SplitContainer2.Panel2Collapsed = False
        Else
            SplitContainer2.Panel2Collapsed = True
        End If
    End Sub

    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
    '    If ColumnName = "chk" Then
    '        If Value = "1" Then
    '            If g10.Text("de_pre_yn", RowIndex) <> "1" Then
    '                MsgBox("전월 미상각된 자산입니다")
    '                g10.Text("chk") = "0"
    '                Exit Sub
    '            End If
    '        End If
    '    End If

    'End Sub

    'Private Sub chk_all_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
    '    Dim i As Integer
    '    Dim De_Yn As String

    '    For i = 0 To g10.RowCount - 1
    '        If chk_all.Text = "1" Then
    '            ' g10.RowIndex = i
    '            De_Yn = g10.Value("de_pre_yn", i)

    '            g10.Text("chk", i) = De_Yn
    '            '  g10.Update()
    '        Else
    '            g10.SaveValue("chk", chk_all.Text, False)
    '        End If

    '    Next
    'End Sub

    '전체선택시 오류 발생(월상각이 틀림)
    'Private Sub chk_all_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged

    '    g10.CheckRows("chk", chk_all.Checked)

    'End Sub

End Class
