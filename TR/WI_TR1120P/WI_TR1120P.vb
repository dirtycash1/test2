Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_TR1120P
    Dim popGrid As eGrid

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.Open()
        'If g_multi.RowCount = 1 Then
        '    g_multi.Text("CHK", 1) = "1"
        '    Try
        '        popGrid = Me.g_multi

        '        Me.Tag = popGrid
        '        Me.ParentForm.DialogResult = Windows.Forms.DialogResult.OK

        '    Catch ex As Exception
        '        MessageInfo(ex)
        '    End Try
        'End If
    End Sub


    Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If ColumnName <> "dt_nm" And ColumnName <> "dt_cd" Then
            'MessageInfo(g20.Text(2, 1))
            Dim tot_tmp As Decimal = 0
            tot_qty.Text = 0
            For i = 0 To g20.RowCount - 1
                For j = 2 To g20.ColumnCount - 1
                    tot_tmp = tot_tmp + g20.ToDec(j, i)
                Next
            Next

            tot_qty.Text = tot_tmp
            '2012.10.16 막음
            'If tot_tmp > qty.ToDec And (qty.Text <> "") Then
            '    MessageInfo("수량을 초과하였습니다.")
            '    g20.Text(ColumnName, RowIndex) = "0"
            '    Exit Sub
            'End If
            '----
        End If
    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        Dim x As Integer = 0
        Dim y As Integer = 0
        If ColumnName = "XY" Then
            For i = 0 To g10.RowCount - 1
                If g10.Text("XY", i) = "XY01" Then
                    x = x + 1
                End If
                If g10.Text("XY", i) = "XY02" Then
                    y = y + 1
                End If
            Next

            'If x = 0 Then
            '    MessageInfo("X축을 선택하세요.")
            'End If
            'If y = 0 Then
            '    MessageInfo("Y축을 선택하세요.")
            'End If
            If x > 1 Then
                MessageInfo("X축은 하나만 선택하세요.")
            End If
            If y > 1 Then
                MessageInfo("Y축은 하나만 선택하세요.")
            End If
        End If
    End Sub

    'Private Sub btn_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click
    '    Try
    '        'Me.Save("wi_tr1120p_g20")

    '        popGrid = Me.g20

    '        Me.Tag = popGrid
    '        Form1.DialogResult = Windows.Forms.DialogResult.OK

    '    Catch ex As Exception
    '        MessageInfo(ex)
    '    End Try
    'End Sub

End Class
