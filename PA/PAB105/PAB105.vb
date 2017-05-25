Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView

Public Class PAB105


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New

                pay_mon.Text = Now().Date
                
                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()
 
        Me.Open("pab105_g10")

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters


        p.Add("@co_cd", co_cd.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@pay_mon", pay_mon.Text)
        p.Add("@pay_bc", pay_bc.Text)
        p.Add("@bank_cd", g10.Text("bank_cd"))
       
       
        System7.ReportView.LoadView("PAB105", "", "pab105_print", p, CrystalReportViewer, True) '급여이체(지급)의뢰서


    End Sub

    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        Me.Print()
    End Sub

End Class
