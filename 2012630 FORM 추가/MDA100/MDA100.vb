Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class MDA100

    Private Sub pmt100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
 
        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True

        md_no.ReadOnly = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Me.Open()


            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = md_no.Text

                    Me.Open()

                    g10.Find("md_no=" + saveID)

                End If

            Case MenuType.New

                New_Form()

            Case MenuType.Delete

                Me.WorkSet("mda100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub New_Form()

        md_no.Text = ""
        md_no.ReadOnly = False

        Me.OpenTrigger("mda100_g10")

    End Sub
   
    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        md_no.ReadOnly = True
    End Sub

    Private Sub bom_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles bom_yn.CheckedChanged
        g30.Open()
    End Sub

End Class
