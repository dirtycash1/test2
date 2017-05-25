Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports System.Math

Public Class GAL100

    Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
        Me.Open("gal100_f10")

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                MyBase.Open()
                compare_amt()
                g10.AddNewRow() '신규시 이동 할 Row

                If g10.RowCount - 1 > 0 Then
                    g10.RowIndex = 0
                End If

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = g10.Text("loan_id")

                    Me.Open()

                    g10.Find("loan_id=" + saveID)

                End If

            Case MenuType.New

                g10.RowIndex = g10.RowCount - 1
                loan_amt.TextBackColor = Color.White
                'loan_id.Text = ""
                'Open("gal100_f10")

                'g10.Text("loan_id", g20.RowIndex) = ""
                'Me.Open("gal100_f10")
                'Me.Open("gal100_g20")
                ''Me.Open("gal100_g30")

            Case MenuType.Delete

                MyBase.Delete("gal100_f10")
                Open("gal100_f10")

            Case MenuType.Print

                Print(loan_id.Text)

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub compare_amt()
        Dim totamt As Decimal = 0
        Dim loanamt As Decimal = loan_amt.ToDec

        With g20
            If .RowCount > 0 Then
                For i = 0 To .RowCount - 1
                    totamt += .ToDec("tot_amt")
                Next
                If loanamt <> totamt Then
                    loan_amt.TextBackColor = Color.Red
                Else
                    loan_amt.TextBackColor = Color.White
                End If
            Else
                loan_amt.TextBackColor = Color.White
            End If
            
        End With



    End Sub

    Private Sub g20_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g20.AddedRow

        g20.Text("loan_id", g20.RowIndex) = loan_id.Text

    End Sub

    Private Sub g20_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g20.InsertedRow

        g20.Text("loan_id", RowIndex) = loan_id.Text

    End Sub

    Private Sub btn_work_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_work.Click
        If MessageYesNo("상환계획서 작성을 실행하시겠습니까?", "주의!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not Me.Save() Then
            Exit Sub
        End If

        Me.Open("gal100_work")
        g20.Open()

        If g20.RowCount - 1 > 0 Then
            MessageInfo("상환계획서 작성이 완료되었습니다")
        End If

    End Sub
    Private Sub Print(ByVal GetNo As String)

        If GetNo = "" Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters
        p.Add("@loan_id", GetNo)

        If g20.RowCount - 1 > 40 Then
            System7.ReportView.LoadView("GAL100_HJ", "", "GAL100_Print", p)
        Else

            System7.ReportView.LoadView("GAL100", "", "GAL100_Print", p)
        End If



    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click

        Print(g10.Text("loan_id"))

    End Sub

    Private Sub btn_del_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_del.Click

        If loan_id.Text = "" Then
            MessageInfo("삭제할 대상이 없습니다.")
            Exit Sub
        End If

        If MessageYesNo("'" + loan_emp_nm.Text + "'" + " 님의 대출금 내역을 삭제하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("gal100_delete")
        g20.Open()



        'g20.DeleteAll()
        'MyBase.Save("gal100_g20")


    End Sub

    Private Sub loan_emp_nm_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles loan_emp_nm.TextChanged

    End Sub
End Class
