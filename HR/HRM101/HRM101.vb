Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class HRM101

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If
            Case MenuType.New
                emp_no.Text = ""
                emp_nm.Text = ""
                fr_dt.Text = ""
                to_dt.Text = ""
                dept_cd.Text = ""
                dept_nm.Text = ""
                bs_cd.Text = ""
                ord_ty.Text = ""
                chk.Text = "1"

                Me.Open("hrm101_g10")


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

End Class
