Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WP_EIS2050

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)

    '    Me.NewForm()


    'End Sub
    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty


            Case MenuType.Print
                Me.Print()

            Case Else

                MyBase.MenuButton_Click(ty)

        End Select

    End Sub
    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@find_ym", find_ym.Text)


        System7.ReportView.LoadView("WP_EIS2050", "", "wp_eis2050_print", p)
    End Sub
End Class
