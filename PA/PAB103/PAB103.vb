Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView
Imports Base7.Parameter

Public Class PAB103

    Private Sub PAB103_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.but_select_proc()

        If Parameter.Login.LangNo = "1" Then
            but1.Properties.Items(0).Description = "부서별"
            but1.Properties.Items(1).Description = "직책별"
            but1.Properties.Items(2).Description = "직종별"
            but1.Properties.Items(2).Enabled = False

            but2.Properties.Items(0).Description = "소계"
            but2.Properties.Items(1).Description = "상세"
            but2.Properties.Items(2).Description = "사원"

            but3.Properties.Items(0).Description = "급여대장"
            but3.Properties.Items(1).Description = "급여명세서"
        Else
            but1.Properties.Items(0).Description = "Department"
            but1.Properties.Items(1).Description = "Duty"
            but1.Properties.Items(2).Description = "Kind"
            but1.Properties.Items(2).Enabled = False

            but2.Properties.Items(0).Description = "Summary"
            but2.Properties.Items(1).Description = "Detail"
            but2.Properties.Items(2).Description = "Emp."

            but3.Properties.Items(0).Description = "Report"
            but3.Properties.Items(1).Description = "Payslip"
        End If

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open("pab103_g10")
                Me.Open("pab103_g20")
                Me.Open("pab103_g30")
                Me.Open("pab103_g40")

            Case MenuType.Save

                'Me.save_Form()

            Case MenuType.New

                pay_mon.Text = Now().Date
                dept_cd.Text = ""
                emp_no.Text = ""
                emp_nm.Text = ""

                Me.but_select_proc()


            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", pay_mon.Text)
        p.Add("@pay_bc", pay_bc.Text)
        p.Add("@pay_sq", pay_sq.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@dept_cd", dept_cd.Text)
        p.Add("@duty1_bc", duty1_bc.Text)
        p.Add("@duty2_bc", duty1_bc.Text)
        p.Add("@emp_no", emp_no.Text)
        p.Add("@kind_bc", kind_bc.Text)

        Select Case pay_bc.Text
            Case "PA110205"  '연차 일때
                p.Add("@prt_order", "1") '부서
                p.Add("@prt_group", "2")  '개인별
            Case Else
                Select Case but1_text.Text
                    Case "0"
                        Select Case but2_text.Text
                            Case "0"
                                p.Add("@prt_order", "1") '부서
                                p.Add("@prt_group", "1")  '소계
                            Case Else
                                p.Add("@prt_order", "1") '부서
                                p.Add("@prt_group", "2")  '개인별
                        End Select
                    Case "1"
                        Select Case but2_text.Text
                            Case "0"
                                p.Add("@prt_order", "2") '직책
                                p.Add("@prt_group", "1")  '소계
                            Case Else
                                p.Add("@prt_order", "2") '직책
                                p.Add("@prt_group", "2")  '개인별
                        End Select
                    Case "2"
                        Select Case but2_text.Text
                            Case "0"
                                p.Add("@prt_order", "3") '직종
                                p.Add("@prt_group", "1")  '소계
                            Case Else
                                p.Add("@prt_order", "3") '직종
                                p.Add("@prt_group", "2")  '개인별
                        End Select
                End Select
        End Select



        Select Case but3_text.Text
            Case "0"
                System7.ReportView.LoadView("PAB103_Sum", "", "pab103_print_Sum", p, CrystalReportViewer, True)
                'Select Case but2_text.Text
                '    Case "0"
                '        System7.ReportView.LoadView("PAB103_Sum", "", "pab103_print_Sum", p, CrystalReportViewer, True) '소계
                '    Case "1"
                '        System7.ReportView.LoadView("PAB103_Emp", "", "pab103_print_Sum", p, CrystalReportViewer, True) '개인
                '    Case "2"
                '        System7.ReportView.LoadView("PAB103_Emp", "", "pab103_print_Sum", p, CrystalReportViewer, True) '개인
                'End Select

            Case Else
                System7.ReportView.LoadView("PAB103_Detail", "", "pab103_print_detail", p, CrystalReportViewer, True)
                'Select Case pay_bc.Text
                '    Case "PA110100"
                '        System7.ReportView.LoadView("PAB103_Detail", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여명세
                '    Case "PA110200"
                '        System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                '    Case "PA110224"
                '        System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                '    Case Else
                '        System7.ReportView.LoadView("PAB103_Detail_2", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                'End Select

        End Select


    End Sub

    Private Sub Print_g10()

        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", pay_mon.Text)
        p.Add("@pay_bc", pay_bc.Text)
        p.Add("@pay_sq", pay_sq.Text)
        p.Add("@bs_cd", bs_cd.Text)


        Select Case but1_text.Text
            Case "0"
                Select Case but2_text.Text
                    Case "0"
                        p.Add("@dept_cd", g30.Text("dept_cd"))
                    Case "1"
                        p.Add("@dept_cd", g30.Text("dept_cd"))
                    Case Else
                        p.Add("@dept_cd", "")
                End Select
            Case Else
                p.Add("@dept_cd", "")
        End Select

        Select Case but1_text.Text
            Case "1"
                Select Case but2_text.Text
                    Case "0"
                        p.Add("@duty1_bc", g20.Text("duty_bc"))
                        p.Add("@duty2_bc", g20.Text("duty_bc"))
                    Case "1"
                        p.Add("@duty1_bc", g20.Text("duty_bc"))
                        p.Add("@duty2_bc", g20.Text("duty_bc"))
                    Case Else
                        p.Add("@duty1_bc", "")
                        p.Add("@duty2_bc", "")
                End Select
            Case Else
                p.Add("@duty1_bc", "")
                p.Add("@duty2_bc", "")
        End Select


        Select Case but2_text.Text
            Case "0"
                p.Add("@emp_no", "")
            Case "1"
                p.Add("@emp_no", "")
            Case Else
                p.Add("@emp_no", g10.Text("emp_no"))
        End Select

        Select Case but1_text.Text
            Case "2"
                Select Case but2_text.Text
                    Case "0"
                        p.Add("@kind_bc", g40.Text("kind_bc"))
                    Case "1"
                        p.Add("@kind_bc", g40.Text("kind_bc"))
                    Case Else
                        p.Add("@kind_bc", "")
                End Select
            Case Else
                p.Add("@kind_bc", "")
        End Select

        Select Case pay_bc.Text
            Case "PA110205"  '연차 일때
                p.Add("@prt_order", "1") '부서
                p.Add("@prt_group", "2")  '개인별
            Case Else
                Select Case but3_text.Text
                    Case "0"
                        Select Case but1_text.Text
                            Case "0"
                                Select Case but2_text.Text
                                    Case "0"
                                        p.Add("@prt_order", "1") '부서
                                        p.Add("@prt_group", "1")  '소계
                                    Case Else
                                        p.Add("@prt_order", "1") '부서
                                        p.Add("@prt_group", "2")  '개인별
                                End Select
                            Case "1"
                                Select Case but2_text.Text
                                    Case "0"
                                        p.Add("@prt_order", "2")  '직책
                                        p.Add("@prt_group", "1")  '소계
                                    Case Else
                                        p.Add("@prt_order", "2") '직책
                                        p.Add("@prt_group", "2") '개인별
                                End Select
                            Case "2"
                                Select Case but2_text.Text
                                    Case "0"
                                        p.Add("@prt_order", "3") '직종
                                        p.Add("@prt_group", "1") '소계
                                    Case Else
                                        p.Add("@prt_order", "3") '직종
                                        p.Add("@prt_group", "2") '개인별
                                End Select
                        End Select
                    Case Else
                        Select Case but1_text.Text
                            Case "0"
                                p.Add("@prt_order", "1") '부서
                                p.Add("@prt_group", "2")  '개인별
                            Case "1"
                                p.Add("@prt_order", "2") '직책
                                p.Add("@prt_group", "2") '개인별
                            Case "2"
                                p.Add("@prt_order", "3") '직종
                                p.Add("@prt_group", "2") '개인별
                        End Select
                End Select
        End Select

        Select Case but3_text.Text
            Case "0"
                System7.ReportView.LoadView("PAB103_Sum", "", "pab103_print_Sum", p, CrystalReportViewer, True)
                'Select Case but2_text.Text
                '    Case "0"
                '        System7.ReportView.LoadView("PAB103_Sum", "", "pab103_print_Sum", p, CrystalReportViewer, True) '소계
                '    Case "1"
                '        System7.ReportView.LoadView("PAB103_Emp", "", "pab103_print_Sum", p, CrystalReportViewer, True) '개인
                '    Case "2"
                '        System7.ReportView.LoadView("PAB103_Emp", "", "pab103_print_Sum", p, CrystalReportViewer, True) '개인
                'End Select

            Case Else
                'Select Case pay_bc.Text
                System7.ReportView.LoadView("PAB103_Detail", "", "pab103_print_detail", p, CrystalReportViewer, True)

                'Case "PA110100"
                '    System7.ReportView.LoadView("PAB103_Detail", "", "pab103_print_Sum", p, CrystalReportViewer, True)   '급여명세
                'Case "PA110200"
                '    System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                'Case "PA110224"
                '    System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                'Case Else
                '    System7.ReportView.LoadView("PAB103_Detail_2", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여연차명세

                'Case "PA110200"
                '    System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                'Case "PA110224"
                '    System7.ReportView.LoadView("PAB103_Detail_1", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여상여명세
                'Case Else
                '    System7.ReportView.LoadView("PAB103_Detail_2", "", "pab103_print_Sum", p, CrystalReportViewer, True) '급여연차명세
                'End Select

        End Select



    End Sub

    Private Sub but_select()

        Select Case but3_text.Text
            Case "0"
                Select Case but2_text.Text
                    Case "0"
                        Select Case but1_text.Text
                            Case "0"
                                g30.BringToFront()
                                Me.Open("pab103_g30")
                            Case "1"
                                g20.BringToFront()
                                Me.Open("pab103_g20")
                            Case "2"
                                g40.BringToFront()
                                Me.Open("pab103_g40")
                        End Select

                    Case "1"
                        Select Case but1_text.Text
                            Case "0"
                                g30.BringToFront()
                                Me.Open("pab103_g30")
                            Case "1"
                                g20.BringToFront()
                                Me.Open("pab103_g20")
                            Case "2"
                                g40.BringToFront()
                                Me.Open("pab103_g40")
                        End Select

                    Case Else
                        g10.BringToFront()
                        Me.Open("pab103_g10")

                End Select
            Case Else
                Select Case but2_text.Text
                    Case "0"
                        Select Case but1_text.Text
                            Case "0"
                                g30.BringToFront()
                                Me.Open("pab103_g30")
                            Case "1"
                                g20.BringToFront()
                                Me.Open("pab103_g20")
                            Case "2"
                                g40.BringToFront()
                                Me.Open("pab103_g40")
                        End Select

                    Case "1"
                        Select Case but1_text.Text
                            Case "0"
                                g30.BringToFront()
                                Me.Open("pab103_g30")
                            Case "1"
                                g20.BringToFront()
                                Me.Open("pab103_g20")
                            Case "2"
                                g40.BringToFront()
                                Me.Open("pab103_g40")
                        End Select

                    Case Else
                        g10.BringToFront()
                        Me.Open("pab103_g10")
                End Select
        End Select

    End Sub
    Private Sub but_select_proc()
        but1_text.Text = but1.Properties.Items(but1.SelectedIndex).Value
        but2_text.Text = but1.Properties.Items(but2.SelectedIndex).Value
        but3_text.Text = but1.Properties.Items(but3.SelectedIndex).Value
    End Sub
    Private Sub but1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1.SelectedIndexChanged
        Me.but_select_proc()
        Me.but_select()
    End Sub

    Private Sub but2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2.SelectedIndexChanged
        Me.but_select_proc()
        Me.but_select()
    End Sub
    Private Sub but3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3.SelectedIndexChanged
        Me.but_select_proc()
        Me.but_select()
    End Sub

    Private Shared Function ReportView() As Object
        Throw New NotImplementedException
    End Function

    'Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
    '    but1_text.Text = but1.Properties.Items(but1.SelectedIndex).Value
    '    but2_text.Text = but1.Properties.Items(but2.SelectedIndex).Value
    '    but3_text.Text = but1.Properties.Items(but3.SelectedIndex).Value
    '    Me.Print_g10()
    'End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
         Me.but_select_proc()
        Me.Print_g10()
    End Sub
    Private Sub g20_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.DoubleClick
        Me.but_select_proc()
        Me.Print_g10()
    End Sub
    Private Sub g30_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g30.DoubleClick
        Me.but_select_proc()
        Me.Print_g10()
    End Sub
    Private Sub g40_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g40.DoubleClick
        Me.but_select_proc()
        Me.Print_g10()
    End Sub

End Class
