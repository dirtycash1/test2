Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMP115

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                MyBase.Save()

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제
                MyBase.Open()

                'Case MenuType.New
                '    Me.New_Form()

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g20_AddedRow(sender As Object, RowIndex As Integer) Handles g20.AddedRow
        Dim sum As Decimal
        Dim avg As Decimal

        If g10.Text("up_chk", g10.RowIndex) = "1" Then
            For i = 0 To g20.RowCount
                sum = sum + g20.ToDec("up", i)
                avg = sum / g20.RowCount
            Next

            g10.Text("up", g10.RowIndex) = Math.Round(avg, 0)
        Else
            g10.Text("up", g10.RowIndex) = g20.Text("up", g20.RowCount - 1)
        End If
    End Sub

    Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        Dim sum As Decimal
        Dim avg As Decimal

        If g10.Text("up_chk", g10.RowIndex) = "1" Then
            For i = 0 To g20.RowCount
                sum = sum + g20.ToDec("up", i)
                avg = sum / g20.RowCount
            Next

            g10.Text("up", g10.RowIndex) = Math.Round(avg, 0)
        Else
            g10.Text("up", g10.RowIndex) = g20.Text("up", g20.RowCount - 1)
        End If
    End Sub

    Private Sub g20_DeletedRow(sender As Object, RowIndex As Integer) Handles g20.DeletedRow
        Dim sum As Decimal
        Dim avg As Decimal

            If g10.Text("up_chk", g10.RowIndex) = "1" Then
            If g20.RowCount > 0 Then
                For i = 0 To g20.RowCount
                    sum = sum + g20.ToDec("up", i)
                    avg = sum / g20.RowCount
                Next
                g10.Text("up", g10.RowIndex) = Math.Round(avg, 0)
            Else
                g10.Text("up", g10.RowIndex) = ""
            End If


            Else
                g10.Text("up", g10.RowIndex) = g20.Text("up", g20.RowCount - 1)
            End If

    End Sub
End Class
