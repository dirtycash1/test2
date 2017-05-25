Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class FAB250

    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click

        Add_Slip_Rows()

    End Sub


    Private Function Add_Slip_Rows() As Boolean

        If g10.CheckedRows("chk") = 0 Then
            Return True
        End If

        If Not Me.Save Then
            Return False
        End If

        '전표화면 찾기
        Dim menuName As String = "FAB100_CSI"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Set_Origin_Rows(g10, "2")

    End Function

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If ColumnName = "chk" Then
            If Value = "1" Then

                g10.Text("chk") = "0"

                g10.UpdateCurrentRow()

                MessageInfo("이미 지급처리 되었습니다")
            End If
        End If
    End Sub

End Class
