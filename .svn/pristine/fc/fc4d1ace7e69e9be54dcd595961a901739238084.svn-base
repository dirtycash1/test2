Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRP150

 
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    Me.New_Form()
            'Case MenuType.Save

            '    If Me.Save() Then
            '        Me.New_Form()
            '    End If

            Case MenuType.New

                emp_no.Text = "zz"
                MyBase.Open()

                emp_no.Text = ""
                emp_nm.Text = ""
                app_dt.Text = ""
                dept_cd.Text = ""

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    'Private Sub New_Form()


    '    MyBase.Open("HRP150_g10")

    '    g10.AddNewRow()

    'End Sub


End Class
