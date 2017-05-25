Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LES200


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    Private Sub chk_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yn.CheckedChanged
        g10.CheckRows("chk", chk_yn.Checked)
    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If m_StopEvent Then
            Exit Sub
        End If
        If ColumnName = "chk" Then
            If ToStr(Value) = "1" Then
                g10.Text("to_qty") = g10.Text("fr_qty")
            Else
                g10.Text("to_qty") = ""
            End If
        End If
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If
        m_StopEvent = True
        If ColumnName = "to_qty" Then
            'If g10.ToDec("to_qty") = 0 AndAlso g10.ToBool("chk") Then
            '    g10.Text("chk") = "0"
            'End If
            If g10.ToDec("to_qty") <> 0 AndAlso Not g10.ToBool("chk") Then
                g10.Text("chk") = "1"
            End If
        End If
        m_StopEvent = False
    End Sub


End Class
