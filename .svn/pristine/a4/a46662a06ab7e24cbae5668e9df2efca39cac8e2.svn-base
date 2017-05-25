Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAS710

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opt_show.AddItem("1", "대체처리")
        opt_show.AddItem("2", "미처리")
        opt_show.AddItem("0", "전체")

        opt_show.Text = "0"
    End Sub

    Public Sub Open2(ByVal astNo As String, ByVal facNo As String, ByVal accCd As String)
        ast_no2.Text = astNo
        fac_no.Text = facNo
        acc_cd2.Text = accCd

        Me.Open()
    End Sub

    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not CheckRequired(doc_dt) Then
            Exit Sub
        End If

        If Not g10.CheckRequiredCheckedRow("chk") Then
            Exit Sub
        End If

        g10.SaveValue("ty", "1")
        g10.SaveValue("mdt", Now)
        g10.SaveValue("acc_cd2", acc_cd2.Text)
        g10.SaveValue("ast_no2", ast_no2.Text)

        If Me.Save() Then

            Me.Open("fas710_work")

            Me.Open()
        End If
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g10.SaveValue("ty", "2")

        If Me.Save() Then
            Me.Open()
        End If

    End Sub

End Class
