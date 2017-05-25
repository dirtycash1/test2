Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView

Public Class PAR102

    Private Sub PAB103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
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
                'emp_no.Text = ""
                'emp_nm.Text = ""
                prt_dt.Text = Now().Date

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()

        Me.Open("par102_g10")

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@pay_bc", g10.Text("pay_bc"))
        p.Add("@bs_cd", g10.Text("bs_cd"))
        p.Add("@dept_cd", g10.Text("dept_cd"))
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@prt_dt", prt_dt.Text)
        p.Add("@prt_bc", prt_bc.Text)

        System7.ReportView.LoadView("PAR102", "", "par102_print", p, CrystalReportViewer, True) '소계
       
    End Sub
    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        Me.Print()

    End Sub
    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
End Class
