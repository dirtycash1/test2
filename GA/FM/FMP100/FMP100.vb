Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FMP100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Me.Open()

        f_fr_dt.ReadOnly = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()

            Case MenuType.New
                f_fr_dt.Text = ""
                f_fr_dt.ReadOnly = False

                MyBase.OpenTrigger("fmp100_g10")

                'MyBase.Open("fmp100_g20")
                'MyBase.Open("fmp100_g30")
            Case MenuType.Save
                If Not CheckRequired(f_fr_dt) Then
                    Exit Sub
                End If

                If Me.Save() Then

                    Dim saveID As String = f_fr_dt.Text 'g10.Text("fr_dt")

                    MyBase.Open()

                    g10.Find("fr_dt=" + saveID + "-01")


                End If
             

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        f_fr_dt.ReadOnly = True
    End Sub

End Class
