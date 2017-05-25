Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAG130

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

#Region " Event "

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()

                mng_sum.Text = 0

                For Row = 0 To g10.RowCount - 1

                    mng_sum.Text = Val(mng_sum.Text) + Val(g10.Text("amt", Row))

                Next

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        With g10
            If ColumnName = "chk" Then

                pay_amt.Text = 0

                For row = 0 To .RowCount - 1

                    If .Text("chk", row) = "1" Then pay_amt.Text = pay_amt.ToDec + .ToDec("amt", row)

                Next

                rest_amt.Text = Val(mng_sum.Text) - Val(pay_amt.Text)

            End If
        End With


    End Sub

    'Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
    '    pay_amt.Text = 0
    '    For row = 0 To g10.RowCount - 1

    '        If g10.Text("chk", row) = "" Then

    '            pay_amt.Text = Val(pay_amt.Text) + Val(g10.Text("amt", row))

    '        End If

    '    Next

    'End Sub

#End Region
End Class
