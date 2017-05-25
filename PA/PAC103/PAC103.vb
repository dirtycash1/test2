Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView

Public Class PAC103


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open()
           

            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New

                fr_mon.Text = Now().Date
                to_mon.Text = Now().Date
                dept_cd.Text = ""
                emp_no.Text = ""

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@fr_mon", fr_mon.Text)
        p.Add("@to_mon", to_mon.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@dept_cd", dept_cd.Text)

        System7.ReportView.LoadView("PAC103", "", "pac103_print", p, CrystalReportViewer, True)
           

    End Sub

    Private Sub Print_g10()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@fr_mon", fr_mon.Text)
        p.Add("@to_mon", to_mon.Text)
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@dept_cd", g10.Text("dept_cd"))

        System7.ReportView.LoadView("PAC103", "", "pac103_print", p, CrystalReportViewer, True)

    End Sub
    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Me.Print_g10()
    End Sub

    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

End Class
