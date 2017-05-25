Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView

Public Class PAY102

    Private Sub PAY102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New


                fr_dt.Text = Now().Date
                to_dt.Text = Now().Date
                emp_no.Text = ""
                emp_nm.Text = ""
                prt_dt.Text = Now().Date

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()

        Me.Open("pay102_g10")

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@bs_cd", g10.Text("bs_cd"))
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@prt_dt", prt_dt.Text)

        System7.ReportView.LoadView("PAY102", "", "PAY102_print", p, CrystalReportViewer, True)
       
    End Sub
    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Me.Print()

    End Sub
    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function
End Class
