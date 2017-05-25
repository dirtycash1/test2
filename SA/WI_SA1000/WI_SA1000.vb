Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1000
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        p.Clear()
        p.Add("@OD_CLDT", od_cldt.Text)

        Me.Open("wi_sa1000_multi", p)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
            Case MenuType.Cancel
            Case MenuType.Confirm
            Case MenuType.Deconfirm
            Case MenuType.Find
            Case MenuType.Delete
            Case MenuType.Save
            Case MenuType.New
        End Select
    End Sub

    Private Function ConFrim() As Boolean
        If CNT_ODDT() = 1 Then
            Return False
        End If

        If MessageYesNo("마감 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@OD_CLDT", od_cldt.Text)

            Me.Open("wi_sa1000_insert", p)

            p.Clear()
            p.Add("@OD_CLDT", od_cldt.Text)

            Me.Open("wi_sa1000_multi", p)
        End If
    End Function

    Private Function DeConFrim() As Boolean
        If MessageYesNo("마감취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@OD_CLDT", od_cldt.Text)

            Me.Open("wi_sa1000_delete", p)

            p.Clear()
            p.Add("@OD_CLDT", od_cldt.Text)

            Me.Open("wi_sa1000_multi", p)
        End If

    End Function

    Private Function CNT_ODDT() As Integer
        p.Clear()
        p.Add("@OD_CLDT", od_cldt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1000_cnt", p)
        Dim ll_cnt As Decimal

        If Not IsEmpty(dSet) Then
            ll_cnt = DataValue(dSet)
        Else
            ll_cnt = 0
        End If

        If ll_cnt > 0 Then
            MsgBox("해당 일자는 이미 수주마감이 되었습니다.")
            Return 1
        End If

        Return 0
    End Function

    Private Sub btn_confirm_Click(sender As System.Object, e As System.EventArgs) Handles btn_confirm.Click
        Me.ConFrim()
    End Sub

    Private Sub btn_deconfirm_Click(sender As System.Object, e As System.EventArgs) Handles btn_deconfirm.Click
        Me.DeConFrim()
    End Sub
End Class
