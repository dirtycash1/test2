Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView
Imports Base7.Parameter

Public Class PAY152



    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open("pay152_g10")
       
            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New

                app_f_year.Text = Now().Date
                dept_f_cd.Text = ""
                emp_f_no.Text = ""
                emp_f_nm.Text = ""




            Case MenuType.Print
                'Me.Print_g10()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub



    Private Sub Print_g10(ByVal EmpNo As String)

        Dim p As OpenParameters = New OpenParameters

        p.Add("@app_year", app_f_year.Text)
        p.Add("@prt_dt", prt_dt.Text)
        p.Add("@prt_app_bc", prt_app_bc.EditText)
        p.Add("@emp_no", EmpNo)
        p.Add("@manage_no", "")

        System7.ReportView.LoadView("pay152_1", "", "pay152_print_1", p, CrystalReportViewer, True)   '원천징수 영수증 1페이지
        System7.ReportView.LoadView("pay152_2", "", "pay152_print_2", p, CrystalReportViewer1, True)   '원천징수 영수증 2페이지


        Dim p1 As OpenParameters = New OpenParameters
        p1.Add("@app_year", app_f_year.Text)
        p1.Add("@emp_no", EmpNo)
        System7.ReportView.LoadView("pay152_3", "", "pay152_print_3", p1, CrystalReportViewer2, True)   '원천징수 영수증 3페이지
        System7.ReportView.LoadView("pay152_4", "", "pay152_print_4", p1, CrystalReportViewer3, True)   '원천징수 영수증 4페이지


    End Sub

    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

    Private Sub g10_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Me.Print_g10(g10.Text("emp_no"))
    End Sub

    Private Sub btn_prt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prt.Click

        Dim i As Integer
        Dim Cnt As Integer
        Dim p As OpenParameters = New OpenParameters
        Dim p1 As OpenParameters = New OpenParameters
        Cnt = 0
        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then


                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    p.Add("@app_year", app_f_year.Text)
                    p.Add("@prt_dt", prt_dt.Text)
                    p.Add("@prt_app_bc", prt_app_bc.EditText)
                    p.Add("@emp_no", g10.Text("emp_no", i))
                    p.Add("@manage_no", "")

                    System7.ReportView.LoadView("pay152_1", "", "pay152_print_1", p, CrystalReportViewer, False)   '원천징수 영수증 1페이지

                End If

                If XtraTabControl1.SelectedTabPageIndex = 1 Then
                    p.Add("@app_year", app_f_year.Text)
                    p.Add("@prt_dt", prt_dt.Text)
                    p.Add("@prt_app_bc", prt_app_bc.EditText)
                    p.Add("@emp_no", g10.Text("emp_no", i))
                    p.Add("@manage_no", "")

                    System7.ReportView.LoadView("pay152_2", "", "pay152_print_2", p, CrystalReportViewer1, False)   '원천징수 영수증 1페이지

                End If

                If XtraTabControl1.SelectedTabPageIndex = 2 Then
                    p1.Add("@app_year", app_f_year.Text)
                    p1.Add("@emp_no", g10.Text("emp_no", i))

                    System7.ReportView.LoadView("pay152_3", "", "pay152_print_3", p1, CrystalReportViewer2, True)   '원천징수 영수증 3페이지

                End If

                If XtraTabControl1.SelectedTabPageIndex = 3 Then
                    p1.Add("@app_year", app_f_year.Text)
                    p1.Add("@emp_no", g10.Text("emp_no", i))

                    System7.ReportView.LoadView("pay152_4", "", "pay152_print_4", p1, CrystalReportViewer3, True)   '원천징수 영수증 4페이지
                End If

                Cnt = Cnt + 1

            End If

        Next

        If Cnt > 0 Then
            MessageInfo("일괄 출력 완료 되었습니다.")
        End If


    End Sub
End Class





