Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAS700

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opt_show.AddItem("1", "처리")
        opt_show.AddItem("2", "미처리")
        opt_show.AddItem("0", "전체")

        opt_show.Text = "0"

        Me.Open()
    End Sub

    Private Sub btn_doc_Click(sender As System.Object, e As System.EventArgs) Handles btn_doc.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g10.SaveValue("ty", "1")
        g10.SaveValue("mdt", Now)

        If Me.Save() Then

            Me.OpenDataSet("fas700_make_doc")

            g10.Open()
        End If
    End Sub

    Private Sub btn_del_Click(sender As System.Object, e As System.EventArgs) Handles btn_del.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g10.SaveValue("ty", "2")

        If Me.Save() Then
            g10.Open()
        End If
    End Sub

End Class
