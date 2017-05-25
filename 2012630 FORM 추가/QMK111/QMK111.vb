Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class QMK111


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        YearReplace()
        g10.RecordNavigator = True

     
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.Open

            '    MyBase.Open()


            ''Case MenuType.Save

            '    If MyBase.Save() Then
            '        Dim saveID As String = g10.Text("mng_no")
            '        MyBase.Open()
            '        g10.Find("mng_no=" + saveID)
            '    End If

            'Case MenuType.New

            '    MyBase.Open()



            Case Else

                If (std_year.Text = String.Empty) Then
                    Return
                End If
                MyBase.MenuButton_Click(mty)
                YearReplace()

        End Select

    End Sub

    Private Sub YearReplace()
        'g10.BandTitle("n1") = (Convert.ToInt32(std_year.Text) - 2).ToString
        'g10.BandTitle("k1") = (Convert.ToInt32(std_year.Text) - 2).ToString
        'g10.BandTitle("n2") = (Convert.ToInt32(std_year.Text) - 1).ToString
        'g10.BandTitle("k2") = (Convert.ToInt32(std_year.Text) - 1).ToString
        'g10.BandTitle("n3") = (std_year.Text).ToString
        'g10.BandTitle("k3") = (std_year.Text).ToString

        g10.ColumnTitle("n1") = (Convert.ToInt32(std_year.Text) - 2).ToString + "계획"
        g10.ColumnTitle("k1") = (Convert.ToInt32(std_year.Text) - 2).ToString + "완료"
        g10.ColumnTitle("n2") = (Convert.ToInt32(std_year.Text) - 1).ToString + "계획"
        g10.ColumnTitle("k2") = (Convert.ToInt32(std_year.Text) - 1).ToString + "완료"
        g10.ColumnTitle("n3") = (std_year.Text).ToString + "계획"
        g10.ColumnTitle("k3") = (std_year.Text).ToString + "완료"
    End Sub
 


End Class
