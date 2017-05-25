Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMR200

    Private Sub MMR200_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.Open()
        Stk2_Set()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Try
            Select Case mty

                Case MenuType.Open

                Case Else

                    MyBase.MenuButton_Click(mty)

            End Select

        Catch ex As Exception

        Finally

        End Try

    End Sub

    Private Sub btn_mrp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mrp.Click

        If MessageYesNo("소요량 산출 작업을 진행하시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim dSet As DataSet = OpenDataSet("mmr200_batch")

            'Open()
            If Not IsEmpty(dSet) Then
                g10.DataSet = dSet.Tables(0).DataSet
                If Not IsEmpty(dSet.Tables(1).DataSet) Then
                    Dim dRows As DataRowCollection = dSet.Tables(1).Rows

                    Dim Msg As String = "아래와 같이 작업이 완료되었습니다." & vbLf & vbLf & _
                    "[정 상   처리건수] : " & ToDec(dRows(0).Item(0)) & "건" & vbLf & _
                    "[Warning 처리건수] : " & ToDec(dRows(0).Item(1)) & "건" & vbLf & _
                    "[Error 미처리건수] : " & ToDec(dRows(0).Item(2)) & "건"
                    'Dim Msg As String = "아래와 같이 작업이 완료되었습니다." & vbLf & vbLf & _
                    '                    "[정상처리건수] : " & ToDec(DataValue(dSet, "mrp_cnt")) & "건" & vbLf & _
                    '                    "[Warning처리건수] : " & ToDec(DataValue(dSet, "warning_cnt")) & "건" & vbLf & _
                    '                    "[Error미처리건수] : " & ToDec(DataValue(dSet, "bad_cnt")) & "건"
                    MessageInfo(Msg)
                    '    MessageInfo("자재 소요량 산출이 완료 되었습니다")
                    '    Dset = Nothing
                End If
                '    MessageInfo("자재 소요량 산출이 완료 되었습니다")
                '    Dset = Nothing
            End If

        Catch ex As Exception

        Finally
            Cursor.Current = Cursors.Default
        End Try


    End Sub

    Private Sub chk_mm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mm.CheckedChanged
        If chk_mm.Checked = True Then
            chk_dd.Checked = False
        Else
            chk_dd.Checked = True
        End If
    End Sub

    Private Sub chk_dd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dd.CheckedChanged
        If chk_dd.Checked = True Then
            chk_mm.Checked = False
        Else
            chk_mm.Checked = True
        End If
    End Sub

    Private Sub chk_stk_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_stk.CheckedChanged
        Stk2_Set()
    End Sub

    Private Sub Stk2_Set()
        If chk_stk.Checked Then
            chk2_stk.Checked = True
            chk2_stk.Enabled = True
        Else
            chk2_stk.Checked = False
            chk2_stk.Enabled = False
        End If
    End Sub
End Class
