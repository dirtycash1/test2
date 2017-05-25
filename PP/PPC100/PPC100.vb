Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPC100

    Private Sub PPC100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()

                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then
                    Dim pwNo As String = g10.Text("pw_no")
                    Me._Open()
                    g10.Find("pw_no=" + pwNo)
                End If

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
        g50.AddNewRow()
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

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging, g30.CellValueChanging, g50.CellValueChanging
        If g10.DataChanged Then
            MessageInfo("먼저 생산실적을 저장하세요")
            Exit Sub
        End If
        If g10.Text("pw_no") = "" Then
            MessageInfo("먼저 생산실적 건을 선택하세요")
            Exit Sub
        End If
    End Sub


End Class
