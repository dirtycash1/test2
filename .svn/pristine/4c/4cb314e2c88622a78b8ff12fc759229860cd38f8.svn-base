Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAC150

    Private Sub PAC150_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Doc()
        'to_pay_tot.TextForeColor = Color.Blue
        'to_dif_tot.TextForeColor = Color.Blue
        'to_pay_amt.TextForeColor = Color.Blue

        'dif_pay_tot.TextForeColor = Color.Red
        'dif_dif_tot.TextForeColor = Color.Red
        'dif_pay_amt.TextForeColor = Color.Red


    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.New_Form()

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub New_Form()

        Me.Doc()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("PAC150_g10")
        MyBase.Open("PAC150_g20")
        MyBase.Open("PAC150_g30")
        'MyBase.Open("PAC150_g40")
        'Me.SetTotal()

    End Sub

    Private Sub Doc()

        If chk.Text = "1" Then
            g10.ColumnVisible("bs_cd") = True
            g10.ColumnVisible("dept_nm") = True
            g10.ColumnVisible("pay_kd") = True
            g10.ColumnVisible("pay_bc") = True
            g10.ColumnVisible("hire_dt") = True
            g10.ColumnVisible("retr_dt") = True

        Else
            g10.ColumnVisible("bs_cd") = False
            g10.ColumnVisible("dept_nm") = False
            g10.ColumnVisible("pay_kd") = False
            g10.ColumnVisible("pay_bc") = False
            g10.ColumnVisible("hire_dt") = False
            g10.ColumnVisible("retr_dt") = False
        End If

    End Sub

    'Private Sub but_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_next.Click
    '    With g10
    '        Dim RowCnt As Integer = .RowCount - 1
    '        If RowCnt <= 0 Then Exit Sub

    '        Dim Row As Integer = .RowIndex + 1
    '        If Row <= RowCnt Then
    '            .RowIndex = Row
    '        Else
    '            .RowIndex = 0
    '        End If

    '    End With

    '    Me.SetTotal()

    'End Sub

    'Private Sub SetTotal() '지급금액계산

    '    Dim iRow As Integer
    '    Dim yRow As Integer
    '    Dim to_aft As Double, to_Bef As Double, to_diff As Double
    '    Dim fr_aft As Double, fr_Bef As Double, fr_diff As Double

    '    For iRow = 0 To g20.RowCount
    '        If g20.IsDataRow(iRow) Then
    '            to_aft = to_aft + g20.ToDec("pay_amt", iRow)
    '            to_Bef = to_Bef + g20.ToDec("com_amt", iRow)
    '            to_diff = to_diff + g20.ToDec("diff_amt", iRow)
    '        End If
    '    Next

    '    For yRow = 0 To g30.RowCount
    '        If g30.IsDataRow(yRow) Then
    '            fr_aft = fr_aft + g30.ToDec("pay_amt", yRow)
    '            fr_Bef = fr_Bef + g30.ToDec("com_amt", yRow)
    '            fr_diff = fr_diff + g30.ToDec("diff_amt", yRow)
    '        End If
    '    Next

    '    to_pay_tot.Text = to_aft
    '    fr_pay_tot.Text = to_Bef
    '    dif_pay_tot.Text = to_diff

    '    to_dif_tot.Text = fr_aft
    '    fr_dif_tot.Text = fr_Bef
    '    dif_dif_tot.Text = fr_diff

    '    to_pay_amt.Text = to_pay_tot.ToDec - to_dif_tot.ToDec
    '    fr_pay_amt.Text = fr_pay_tot.ToDec - fr_dif_tot.ToDec
    '    dif_pay_amt.Text = dif_pay_tot.ToDec - dif_dif_tot.ToDec



    '    If dif_pay_amt.ToDec <> 0 Then
    '        dif_pay_amt.ForeColor = Color.Red
    '    Else
    '        dif_pay_amt.ForeColor = Color.Black
    '    End If

    'End Sub

    'Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
    '    Me.SetTotal()
    'End Sub

    'Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
    '    Me.SetTotal()
    'End Sub


    'Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)
    '    Me.SetTotal()
    'End Sub

    'Private Sub g40_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object)
    '    Me.SetTotal()
    'End Sub

End Class
