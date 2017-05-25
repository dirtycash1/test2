Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_EIS1110

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
        p.Add("@std_dt", std_dt.Text)
        Dim p1 As OpenParameters = New OpenParameters
        p1.Add("@std_dt", std_dt.Text)

        System7.ReportView.LoadView("WI_EIS1110", "", "WI_EIS1110_PRINT", p, Nothing, True, 1, "1234", "WI_EIS1110_QUERY_1234", p1)

    End Sub


End Class
