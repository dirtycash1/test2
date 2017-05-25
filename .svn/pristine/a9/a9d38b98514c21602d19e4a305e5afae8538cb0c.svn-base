Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LET400
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open("let400_g10")

            Case MenuType.Save

                Me.Save()

                'Case MenuType.New


            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

   

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@fr_dt", g10.Text("mov_dt"))
        p.Add("@to_dt", g10.Text("mov_dt"))
        p.Add("@car_no", car_no.Text)


        Me.Open("let400_g20", p)
        g20.AddNewRow()

    End Sub


End Class
