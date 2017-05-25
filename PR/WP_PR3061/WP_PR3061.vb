Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_PR3061

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    New_Form()
            Case MenuType.Save

                g_result.Focus()
                g_result.FocusedFieldName = "PR_QTY"


                Dim TOT_QTY As Decimal

                If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_QTY", g_result.RowIndex)) = True) And
                   (IsNumeric(g_result.ToDec("MOD_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) And
                   (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = True) Then


                    TOT_QTY = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex)) + g_result.ToDec("MOD_QTY", g_result.RowIndex) + g_result.ToDec("LOSS_QTY", g_result.RowIndex) + g_result.ToDec("SAM_QTY", g_result.RowIndex)

                ElseIf (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_QTY", g_result.RowIndex)) = True) And
                       (IsNumeric(g_result.ToDec("MOD_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) And
                       (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = False) Then

                    TOT_QTY = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex)) + g_result.ToDec("MOD_QTY", g_result.RowIndex) + g_result.ToDec("LOSS_QTY", g_result.RowIndex)

                ElseIf (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_QTY", g_result.RowIndex)) = True) And
                       (IsNumeric(g_result.ToDec("MOD_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = False) And
                       (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = False) Then

                    TOT_QTY = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex)) + g_result.ToDec("MOD_QTY", g_result.RowIndex)

                ElseIf (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PACK_QTY", g_result.RowIndex)) = True) And
                   (IsNumeric(g_result.ToDec("MOD_QTY", g_result.RowIndex)) = False) And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = False) And
                   (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = False) Then

                    TOT_QTY = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))

                End If


                If TOT_QTY = g_result.ToDec("PR_QTY", g_result.RowIndex) Then
                    If Me.Save() Then
                        Me.Open()
                    End If
                Else

                    If MessageYesNo("LOT NO: " & g_result.Text("LOT_NO", g_result.RowIndex) & " 의 생산수량(" & ToStr(FormatNumber(g_result.ToDec("PR_QTY", g_result.RowIndex), 0)) & ")과 나머지 합계(" & ToStr(FormatNumber(TOT_QTY, 0)) & ")가 일치하지 않습니다. " &
                                    vbCrLf & "그래도 저장하시겠습니까? ") = MsgBoxResult.No Then

                    Else

                        If Me.Save() Then
                            Me.Open()
                        End If

                    End If

                End If

                'If Me.Save() Then
                '    Me.Open()
                'End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub g_result_CellValueChanged1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_result.CellValueChanged
        Select Case ColumnName
            Case "PACK_UNIT"  '포장단위
                If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True Then

                    'g_result.Text("PACK_QTY", g_result.RowIndex) = Fix(g_result.ToDec("PR_QTY", g_result.RowIndex) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))
                    g_result.Text("PCS_QTY", g_result.RowIndex) = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))
                    'g_result.Text("MOD_QTY", g_result.RowIndex) = g_result.ToDec("PR_QTY", g_result.RowIndex) - (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))
                End If

            Case "PACK_QTY"  '팩수량
                If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True Then

                    g_result.Text("PCS_QTY", g_result.RowIndex) = (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))

                    '기존막힘
                    'If IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True Then
                    '    g_result.Text("MOD_QTY", g_result.RowIndex) = (g_result.ToDec("PR_QTY", g_result.RowIndex) - (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))) - g_result.ToDec("LOSS_QTY", g_result.RowIndex)
                    'Else
                    '    g_result.Text("MOD_QTY", g_result.RowIndex) = g_result.ToDec("PR_QTY", g_result.RowIndex) - (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))
                    'End If

                End If


                'Case "LOSS_QTY"  '파손
                '    'MsgBox(ToStr((g_result.Text("PACK_QTY", g_result.RowIndex)) - g_result.Text("LOSS_QTY", g_result.RowIndex)) / g_result.Text("PACK_UNIT", g_result.RowIndex))

                '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PCS_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = True) Then

                '        g_result.Text("PACK_QTY", g_result.RowIndex) =
                '         Fix((g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))

                '        g_result.Text("MOD_QTY", g_result.RowIndex) =
                '                 (g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)) Mod g_result.ToDec("PACK_UNIT", g_result.RowIndex)

                '        '잔량의 변화
                '        If g_result.ToDec("MOD_QTY", g_result.RowIndex) >= g_result.ToDec("PACK_UNIT", g_result.RowIndex) Then
                '            g_result.Text("PACK_QTY", g_result.RowIndex) =
                '                Fix(g_result.ToDec("MOD_QTY", g_result.RowIndex) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))

                '            g_result.Text("MOD_QTY", g_result.RowIndex) =
                '                (g_result.ToDec("PACK_UNIT", g_result.RowIndex) * (Fix(g_result.ToDec("MOD_QTY", g_result.RowIndex) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))))

                '        End If


                '        '기존막힘
                '        'If (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = True) Then
                '        '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) Then

                '        '        g_result.Text("MOD_QTY", g_result.RowIndex) = g_result.Text("MOD_QTY", g_result.RowIndex) +
                '        '           (g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)) Mod g_result.ToDec("PACK_UNIT", g_result.RowIndex)

                '        '    End If

                '        'Else

                '        '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) Then

                '        '        g_result.Text("MOD_QTY", g_result.RowIndex) = g_result.Text("MOD_QTY", g_result.RowIndex) +
                '        '          (g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex)) Mod g_result.ToDec("PACK_UNIT", g_result.RowIndex)

                '        '    End If

                '        'End If


                '    End If



                '    '기존 소스 '기존막힘 
                '    'If (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = True) Then
                '    '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) Then

                '    '        g_result.Text("MOD_QTY", g_result.RowIndex) = (g_result.ToDec("PR_QTY", g_result.RowIndex) - (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)

                '    '    End If

                '    'Else
                '    '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) Then

                '    '        g_result.Text("MOD_QTY", g_result.RowIndex) = (g_result.ToDec("PR_QTY", g_result.RowIndex) - (g_result.ToDec("PACK_QTY", g_result.RowIndex) * g_result.ToDec("PACK_UNIT", g_result.RowIndex))) - g_result.ToDec("LOSS_QTY", g_result.RowIndex)

                '    '    End If
                '    'End If

                'Case "SAM_QTY"   '샘플/선출하 수량
                '    If (IsNumeric(g_result.ToDec("PR_QTY", g_result.RowIndex)) = True) And IsNumeric(g_result.ToDec("PACK_UNIT", g_result.RowIndex)) = True And (IsNumeric(g_result.ToDec("LOSS_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("PCS_QTY", g_result.RowIndex)) = True) And (IsNumeric(g_result.ToDec("SAM_QTY", g_result.RowIndex)) = True) Then

                '        g_result.Text("PACK_QTY", g_result.RowIndex) =
                '         Fix((g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))


                '        g_result.Text("MOD_QTY", g_result.RowIndex) =
                '                 (g_result.ToDec("PR_QTY", g_result.RowIndex) - g_result.ToDec("LOSS_QTY", g_result.RowIndex) - g_result.ToDec("SAM_QTY", g_result.RowIndex)) Mod g_result.ToDec("PACK_UNIT", g_result.RowIndex)


                '        '잔량의 변화 
                '        If g_result.ToDec("MOD_QTY", g_result.RowIndex) >= g_result.ToDec("PACK_UNIT", g_result.RowIndex) Then
                '            g_result.Text("PACK_QTY", g_result.RowIndex) =
                '                Fix(g_result.ToDec("MOD_QTY", g_result.RowIndex) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))

                '            g_result.Text("MOD_QTY", g_result.RowIndex) =
                '                (g_result.ToDec("PACK_UNIT", g_result.RowIndex) * (Fix(g_result.ToDec("MOD_QTY", g_result.RowIndex) / g_result.ToDec("PACK_UNIT", g_result.RowIndex))))

                '        End If
                '    End If

        End Select
    End Sub
End Class
