Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMM101

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            Me.Open()
    '        Case MenuType.Save

    '            'If Me.Save() Then
    '            '    Me.Open()
    '            'End If

    '        Case MenuType.New
    '            Me.Open()

    '        Case MenuType.Print
    '            'Me.Print()
    '        Case Else
    '            MyBase.MenuButton_Click(mty)
    '    End Select

    'End Sub
    Private Sub g10_ButtonPressed(sender As Object, columnName As String) Handles g10.ButtonPressed
        Dim pp As OpenParameters = New OpenParameters
            

            Select Case g10.Text("ok_yn")
            Case "1"
                pp.Add("@iqc_no", g10.Text("iqc_no"))
                System7.ReportView.LoadView("QMM101", "", "QMM101_print", pp, )
            Case "0"
                pp.Add("@iqc_no", g10.Text("iqc_no"))
                System7.ReportView.LoadView("QMM101R2", "", "QMM101_print", pp, )
            End Select
            'If g10.Text("ED_STH") <> "ED101200" Then
            'Else
            'End If

    End Sub
  
End Class
