Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class GAC120

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    New_Form()

    'End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                New_Form()

            Case MenuType.Save

                If Me.Save() Then
                    New_Form()
                End If

            Case MenuType.New

                emp_no.Text = ""
                emp_nm.Text = ""
                to_dt.Text = ""
                but1.Text = but.Properties.Items(but.SelectedIndex).Value
            
               New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Me.Doc()
        MyBase.Open("gac120_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        'g10.AddNewRow()

    End Sub

    Private Sub but_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but.SelectedIndexChanged
        but1.Text = but.Properties.Items(but.SelectedIndex).Value
    End Sub

    Private Sub Print(ByVal GetDocNo As String)

        If g10.Text("chk1") = "1" Then
            Dim p As OpenParameters = New OpenParameters
            p.Add("@doc_no", GetDocNo)
            p.Add("@chk1", g10.Text("chk1"))

            Select Case doc_bc.Text
                Case "HR495100"
                    System7.ReportView.LoadView("GAC120", "", "gac120_print", p) '재직
                Case "HR495200"
                    System7.ReportView.LoadView("GAC121", "", "gac120_print", p) '경력
                Case "HR495300"
                    System7.ReportView.LoadView("GAC122", "", "gac120_print", p) '퇴직

            End Select
        Else
            Return
        End If
      

        Me.Save("gac120_g10")


    End Sub

    Private Sub Doc()

        If doc_bc.Text = "HR495300" Then
            g10.ColumnVisible("rmks") = True
            btn_print_en.Visible = False
        Else
            g10.ColumnVisible("rmks") = False
            btn_print_en.Visible = True
        End If

    End Sub
    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click

        For Row As Integer = 0 To g10.RowCount - 1
            If g10.Text("chk1", Row) = "1" Then
                Print(g10.Text("doc_no", Row))
            End If
        Next

    End Sub
    Private Sub Print_en(ByVal GetDocNo As String)

        If g10.Text("chk1") = "1" Then
            Dim p As OpenParameters = New OpenParameters
            p.Add("@doc_no", GetDocNo)
            p.Add("@chk1", g10.Text("chk1"))

            Select Case doc_bc.Text
                Case "HR495100"
                    System7.ReportView.LoadView("GAC120_en", "", "gac120_print_en", p) '재직영문
                Case "HR495110"
                    System7.ReportView.LoadView("GAC120_en", "", "gac120_print_en", p) '재직영문

                Case "HR495200"
                    System7.ReportView.LoadView("GAC121_en", "", "gac120_print_en", p) '경력영문
            End Select
        Else
            Return
        End If

        Me.Save("gac120_g10")

    End Sub

    Private Sub btn_print_en_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_print_en.Click

        For Row As Integer = 0 To g10.RowCount - 1
            If g10.Text("chk1", Row) = "1" Then
                Print_en(g10.Text("doc_no", Row))
            End If
        Next

    End Sub
End Class
