Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QML210

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MyBase.Open()

    End Sub


    Private Sub invest_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles invest_dt.TextChanged

        If invest_dt.Text = "" Then
            invest_yn.Text = "0"
            stat_bc.Text = "QM151100"
        End If
        If invest_dt.Text <> "" Then
            invest_yn.Text = "1"
            stat_bc.Text = "QM151200"
        End If
    End Sub


    Private Sub act_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles act_dt.TextChanged

        If act_dt.Text = "" Then
            act_yn.Text = "0"
            stat_bc.Text = "QM151200"
        End If
        If act_dt.Text <> "" Then
            act_yn.Text = "1"
            stat_bc.Text = "QM151300"
        End If
    End Sub


    Private Sub rep_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rep_dt.TextChanged

        If rep_dt.Text = "" Then
            rep_yn.Text = "0"
            stat_bc.Text = "QM151300"
        End If
        If rep_dt.Text <> "" Then
            rep_yn.Text = "1"
            stat_bc.Text = "QM151400"
        End If
    End Sub


    'Private Sub invest_yn_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles invest_yn.TextChanged

    '    If invest_yn.Text = "0" Then
    '        stat_bc.Text = "QM151100"
    '    End If
    '    If invest_yn.Text = "1" Then
    '        stat_bc.Text = "QM151200"
    '    End If
    'End Sub

End Class
