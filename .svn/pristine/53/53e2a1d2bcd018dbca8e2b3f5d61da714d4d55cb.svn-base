Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAA100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me._Open()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me._Open()

            Case MenuType.Save

                If Me.Save() Then
                    Me._Open()
                End If

            Case MenuType.New

                Me._Open()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub _Open()

        MyBase.Open("paa100_g10")
        MyBase.Open("paa100_g20")
        MyBase.Open("paa100_g30")
        'MyBase.Open("paa100_g40")

        If g10.RowCount = 0 Then
            g10.AddNewRow()
        End If

    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        Dim p As OpenParameters = New OpenParameters
        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@f_pay_sq", g10.Text("pay_sq"))

        Me.Open("paa100_g20", p)
        Me.Open("paa100_g30", p)
        'Me.Open("paa100_g40", p)

    End Sub

End Class
