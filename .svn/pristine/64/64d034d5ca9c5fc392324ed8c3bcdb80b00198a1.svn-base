Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class GAC130

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

                but1.Text = but.Properties.Items(but.SelectedIndex).Value

                New_Form()

            Case MenuType.Print
                Print()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Me.Doc()
        MyBase.Open("gac130_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        'g10.AddNewRow()

    End Sub
    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@emp_no", emp_no.Text)
        p.Add("@emp_nm", emp_nm.Text)
        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@doc_bc", doc_bc.Text)

        System7.ReportView.LoadView("GAC130", "", "gac130_print", p)

    End Sub
    Private Sub Doc()

        If doc_bc.Text = "HR495200" Then
            g10.ColumnVisible("rmks") = True
        Else
            g10.ColumnVisible("rmks") = False
        End If

    End Sub

    Private Sub but_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but.SelectedIndexChanged
        but1.Text = but.Properties.Items(but.SelectedIndex).Value
    End Sub
End Class
