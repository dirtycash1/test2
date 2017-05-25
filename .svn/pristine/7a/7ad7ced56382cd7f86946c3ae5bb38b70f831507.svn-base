Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDW500

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

    Private Sub btn_trans_Click(sender As System.Object, e As System.EventArgs) Handles btn_trans.Click
        '그 외는 가져오기 공용 SP를 사용한다
        If MessageYesNo("기존 계획은 삭제되고 새로 작성됩니다." & vbLf & vbLf & "작성 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Open("sdw500_trans")

        MessageInfo("작업이 완료되었습니다")

        Me.Open()
    End Sub


End Class
