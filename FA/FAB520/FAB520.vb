Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAB520

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        opt1.AddItem("0", "전체")
        opt1.AddItem("1", "완료")
        opt1.AddItem("2", "미완료")

        opt2.AddItem("0", "전체")
        opt2.AddItem("1", "입금")
        opt2.AddItem("2", "출금")

        opt3.AddItem("0", "전체")
        opt3.AddItem("1", "승인")
        opt3.AddItem("2", "미승인")

        'opt1.InsertItem(5, "qqww", "wwrwwr")

        'MsgBox(opt_stat.Text)
        'MsgBox(opt_stat.EditText)
        'opt_stat.Text = "2"

        opt1.Text = "2"
        opt2.Text = "2"
        opt3.Text = "1"


        'MsgBox(opt_stat.SelectedIndex.ToString)
        'MsgBox(opt_stat.Properties.Items(opt_stat.SelectedIndex).Description)
        'MsgBox(opt_stat.Text)

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                'opt1.Text = opt_stat.Text
                'opt2.Text = opt_pay.Text
                'opt3.Text = opt_approv.Text

                MyBase.Open()

                sel_amt.Text = ""

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click


        '관리항목 완성


        Me.Add_Origin_Rows()
    End Sub

    Private Sub Add_Origin_Rows()
        If Not CheckRequired(pay_kd) Then
            Exit Sub
        End If

        Dim dSet As DataSet = Me.OpenDataSet("fab520_acc_cd")
        Dim accCd As String = DataValue(dSet)
        If accCd = "" Then
            MessageInfo(pay_kd.EditText + ": 계정코드가 설정되지 않았습니다 (기초코드에서 설정)")
            Exit Sub
        End If

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To g10.RowCount - 1
            If g10.ToBool("chk", i) And g10.Text("apr_dt", i) = "" Then
                MessageInfo("승인되지 않은 건이 있습니다")
                Exit Sub
            End If
        Next

        Me.Save()

        '전표화면 찾기
        Dim menuName As String = "FAB100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Set_Origin_Rows2(g10, accCd, pay_kd.Text, bank_cd.Text, bank_cd.EditText, acct_no.Text, acct_no.EditText, iss_dt.Text, end_dt.Text, "", cust_yn.Text)

    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        With g10
            If ColumnName = "chk" Then
                If Value = "1" Then
                    g10.Text("set_amt") = g10.ToDec("rem_amt")
                Else
                    g10.Text("set_amt") = ""
                End If

                If pay_kd.Text = "" Then
                    pay_kd.Text = g10.Text("pay_kd")
                End If

                Dim chk As Boolean, sum As Decimal
                For i As Integer = 0 To g10.RowCount - 1
                    If i = g10.RowIndex Then
                        chk = ToBool(Value)
                    ElseIf g10.ToBool("chk", i) Then
                        chk = g10.ToBool("chk", i)
                    End If
                    If chk Then
                        sum += g10.ToDec("set_amt", i)
                    End If
                Next
                sel_amt.Text = sum
            End If
        End With
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "set_amt" Then
                If .ToDec("set_amt") <> 0 Then
                    If .ToDec("rem_amt") < .ToDec("set_amt") Then
                        MessageInfo("잔액보다 많을 수 없습니다")
                        .CancelRowChanges()
                        Exit Sub
                    End If
                End If
            End If
            If ColumnName = "chk" Then
                If .Text("apr_dt") = "" Then
                    MessageInfo("승인된 건만 전표처리 가능합니다")
                    .CancelRowChanges()
                    Exit Sub
                End If
                If .ToDec("rem_amt") = 0 Then
                    MessageInfo("이미 처리되어 잔액이 없습니다")
                    .CancelRowChanges()
                End If
            End If

            'If ColumnName = "fix_amt" Then
            '    'rem_amt  = isnull(a.doc_amt,0) - isnull(pay_amt,0) - isnull(fix_amt, 0),
            '    .Text("rem_amt") = .ToDec("doc_amt") - .ToDec("pay_amt") - .ToDec("fix_amt")
            'End If

        End With
    End Sub

    'Private Sub opt1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt1.Click
    '    MsgBox("Click")
    'End Sub

    'Private Sub opt1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt1.DoubleClick
    '    MsgBox("DoubleClick")
    'End Sub


    Private Sub EOptionBox1_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles opt1.TextChanged
        'MsgBox("TextChanged -> " + opt1.Text)




    End Sub


  
End Class
