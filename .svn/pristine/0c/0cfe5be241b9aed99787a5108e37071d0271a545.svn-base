Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPC120

    Private Sub PPC120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._Open()

        CheckChanged()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()

                '사용하려면 재정의 가능하다
            Case MenuType.Save

                'If g10.ToDec("good_qty") > 0 Or g10.ToDec("bad_qty") > 0 Or g10.ToDec("out_qty") > 0 Then
                '    If Not CheckRequired(work_dt, fac_cd, wc_cd, mc_cd) Then
                '        MessageInfo("필수 정보 누락 입니다")
                '        Exit Sub
                '    End If

                '    If MyBase.Save Then ' Save("ppc120_g10") Then

                '        Me._Open()

                '    End If
                'End If

                If Not CheckRequired(work_dt, fac_cd, wc_cd, mc_cd) Then
                    MessageInfo("필수 정보 누락 입니다")
                    Exit Sub
                End If

                If MyBase.Save Then ' Save("ppc120_g10") Then
                    Me._Open()
                End If

                'MyBase.Save("PPC120_g20")
                'MyBase.Save("PPC120_g30")
                'MyBase.Save("PPC120_g60")

                Dim pwNo As String = g10.Text("pw_no")
                Me._Open()
                g10.Find("pw_no=" + pwNo)

                'Case MenuType.Delete
                '    'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                Me._Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub _Open()
        MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
        'g10.AddNewRow()
        g20.AddNewRow()
        g30.AddNewRow()
        g60.Open()
        ' g50.AddNewRow()
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        EMemo1.Text = g10.Text("rmks")
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                Dim frTm As String = .Text("fr_tm")
                Dim toTm As String = .Text("to_tm")

                .Text("pw_tm") = [Shared].DiffHour(frTm, toTm, 1)
            End If
        End With
    End Sub
    Private Sub g60_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g60.CellValueChanged
        With g60
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                Dim frTm As String = .Text("fr_tm")
                Dim toTm As String = .Text("to_tm")

                .Text("pw_tm") = [Shared].DiffHour(frTm, toTm, 1)
            End If
        End With
    End Sub

    Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        With g30
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                Dim frTm As String = .Text("fr_tm")
                Dim toTm As String = .Text("to_tm")

                .Text("stop_tm") = [Shared].DiffHour(frTm, toTm, 1)
            End If
            If ColumnName = "stop_tm" Or ColumnName = "loss_man" Then
                .Text("loss_tm") = .ToDec("stop_tm") * .ToDec("loss_man")
            End If
        End With
    End Sub

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If g10.DataChanged Then
            MessageInfo("먼저 생산실적을 저장하세요")
            Exit Sub
        End If
        '  If g10.Text("pw_no") = "" Then
        ' MessageInfo("먼저 생산실적 건을 선택하세요")
        ' Exit Sub
        'End If
    End Sub


    Private Sub chk_prod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_prod.CheckedChanged
        CheckChanged()
    End Sub

    Private Sub CheckChanged()
        If chk_prod.Checked Then
            as_yn.Checked = False
            oem_yn.Checked = False
        End If

        as_yn.Enabled = Not chk_prod.Checked
        oem_yn.Enabled = Not chk_prod.Checked
    End Sub

End Class
