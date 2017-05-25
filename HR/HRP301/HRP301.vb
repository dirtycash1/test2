Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class HRP301

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    'End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save

                'If Me.Save() Then
                '    Me.Open()
                'End If


            Case MenuType.New

                bs_cd.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""
                fr_dt.Text = ""
                to_dt.Text = ""
                fr1_dt.Text = ""
                to1_dt.Text = ""
                dept_cd.Text = ""


                Me.Open("hrp301_g10")


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


End Class
