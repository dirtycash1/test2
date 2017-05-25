Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMV100

    Private Sub MMV100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cust_yn.SetValue("1", "")

        'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
        'Me.Open()

    End Sub



    'Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

    '    itm_id.Text = g10.Text("itm_id")
    '    itm_cd2.Text = g10.Text("itm_cd")
    '    itm_nm2.Text = g10.Text("itm_nm")

    'End Sub

End Class
