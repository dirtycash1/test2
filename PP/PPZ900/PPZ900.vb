Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class PPZ900

    Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open

            '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

                'Case MenuType.Delete

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                If g10.Text("fr_tm", g10.RowIndex) <> "" And g10.Text("fr_tm", g10.RowIndex) <> "" Then

                    Dim frTm As String = .Text("fr_tm")
                    Dim toTm As String = .Text("to_tm")

                    .Text("tot_min") = [Shared].DiffHour(frTm, toTm, 1)
                End If
            End If

            If ColumnName = "tot_min" Or ColumnName = "dis_min" Then

                .Text("act_min") = .ToDec("tot_min") - .ToDec("dis_min")

            End If
        End With
    End Sub


    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then

                Dim frTm As String = .Text("fr_tm")
                Dim toTm As String = .Text("to_tm")

                .Text("tot_min") = [Shared].DiffHour(frTm, toTm, 1)

            End If
        End With

    End Sub

End Class
