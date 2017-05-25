Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Math

Public Class FAF400

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chk_all.Text = 1
    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        'Case MenuType.Open
    '        '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '        '    '사용하려면 재정의 가능하다
    '        'Case MenuType.Save

    '        Case MenuType.New
    '            cust_cd.Text = ""
    '            itm_cd.Text = ""
    '            itm_nm.Text = ""
    '            emp_id.Text = ""
    '            emp_nm.Text = ""

    '            Me.New_Form()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If co_cd.Text = "" Then
            MsgBox("법인선택은 필수 입니다.")
            Exit Sub
        End If

        If plan_mon.Text = "" Then
            MsgBox("결제년월 선택은 필수 입니다.")
            Exit Sub
        End If

        If MessageYesNo("기존 결제년월의 Data는 삭제되고 새로집계 합니다. 계속하시겠습니까?", "경고!!") = MsgBoxResult.No Then
            Exit Sub
        End If

        MyBase.Open("faf400_work")
        Me.Open()

        'Dim i As Integer
        'For i = 0 To g10.RowCount - 1
        '    g10.Text("fit_amt", i) = 0
        'Next

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        Me.Open()
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        With g10
            If ColumnName = "out_bas" Or ColumnName = "out_pay" Or ColumnName = "in_bas" Or ColumnName = "out2_bas" Or ColumnName = "out2_pay" Or ColumnName = "in2_end" Or ColumnName = "fit_amt" Then

                .Text("pay_amt") = .ToDec("out_bas") - .ToDec("out_pay") - .ToDec("in_bas") + .ToDec("out2_bas") - .ToDec("out2_pay") - .ToDec("in2_end") - .ToDec("fit_amt")

            End If

            If ColumnName = "pay_amt" Then

                If .ToDec("pay_amt") >= 1000000 Then
                    .Text("pay2_amt") = .ToDec("pay_amt")
                End If

                If .ToDec("pay_amt") < 1000000 Then
                    .Text("pay1_amt") = .ToDec("pay_amt")
                End If
            End If

        End With

    End Sub

End Class
