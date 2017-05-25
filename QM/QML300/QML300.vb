Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QML300

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        MyBase.Open()

    End Sub

    Private Sub but_prt_Click(sender As System.Object, e As System.EventArgs) Handles but_prt.Click
        Dim P As New OpenParameters

        P.Add("@o_fr_dt", o_fr_dt.Text)
        P.Add("@o_to_dt", o_to_dt.Text)

        System7.ReportView.LoadView("QML300", "", "qml300_print", P)

    End Sub
End Class
