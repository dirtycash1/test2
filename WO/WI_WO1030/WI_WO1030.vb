Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_WO1030
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
     
        Me.NewForm()
       

    End Sub

    Private Sub btn_exec_Click(sender As Object, e As System.EventArgs) Handles btn_exec.Click
        If MessageYesNo("잔량 처리 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@ym", find_ym.Text)

            Me.Open("wi_wo1030_exec", p)
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As System.EventArgs) Handles btn_del.Click
        If MessageYesNo("잔량 처리 삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@ym", find_ym.Text)

            Me.Open("wi_wo1030_del", p)
        End If
    End Sub
End Class
