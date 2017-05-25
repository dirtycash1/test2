Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WP_PR1270
    Private Sub WP_PR1270_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim frDt As Date = fr_week.Text
        Dim toDt As Date = to_week.Text

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
        'std_week.Text = 0
        std_week.Text = cnt.ToString
    End Sub
   
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open()

                'Case MenuType.Save

                '    Me.save_Form()

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
  
End Class
