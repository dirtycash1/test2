Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class HRK261

    Private Sub HRK261_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Open()
        Me.doc()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open("hrk261_g10")
                Me.doc()

            Case MenuType.Save
                If Me.Save("hrk261_f10") Then

                    With g10
                        Dim RowCnt As Integer = .RowCount - 1
                        If RowCnt <= 0 Then Exit Sub

                        Dim Row As Integer = .RowCount

                        .RowIndex = Row

                    End With

                End If


            Case MenuType.New
                fr_dt.Text = ""
                emp_no.Text = ""


                Me.Open("hrk261_f10")
                Me.doc()

            Case MenuType.Print

                Dim p As OpenParameters = New OpenParameters
                p.Add("@emp_no", g10.Text("emp_no"))
                p.Add("@fr_dt", g10.Text("fr_dt"))

                System7.ReportView.LoadView("HRK261", "", "hrk261_print", p)


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Me.Open("hrk261_f10")
        Me.doc()

    End Sub

    Private Sub doc()
        If iss_bc.Text = "HR481180" Then
            iss_rmk.Visible = True

        Else
            iss_rmk.Visible = False
        End If
    End Sub
    Private Sub iss_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iss_bc.TextChanged

        Me.doc()

    End Sub
End Class
