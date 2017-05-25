Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM720

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    'Dim amt_count = 0
    'Dim amt_bef_count = 0

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                If CheckRequired(o_bud_year) Then
                    Me.Open()
                End If

            Case MenuType.Save
                If Me.Save() Then
                    Me.Open()

                    'Dim param As OpenParameters = New OpenParameters
                    'param.Add("@co_cd", co_cd.Text)
                    'param.Add("@div_cd", div_cd.Text)
                    'param.Add("@dept_cd", dept_cd.Text)
                    'param.Add("@bud_year", bud_year.Text)
                    'Me.Open("fam720_g20", param)
                    'Me.Open("fam720_g30", param)
                End If
            Case MenuType.Delete
                Dim dr As DialogResult =
                    MessageBox.Show("예산년도 : " + bud_year.EditText + vbCr +
                                    "법인코드 : " + co_cd.EditText + vbCr +
                                    "회계단위 : " + div_cd.EditText + vbCr +
                                    "예산부서 : " + dept_nm.EditText + vbCr + vbCr +
                                    "현재 선택된 예산신청을 삭제 하시겠습니까?" + vbCr +
                                    "(삭제시 월예산 및 년예산이 삭제됩니다.)", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                If dr = DialogResult.Yes Then
                    Dim param As OpenParameters = New OpenParameters
                    param.Add("@bud_year", bud_year.Text)
                    param.Add("@co_cd", co_cd.Text)
                    param.Add("@div_cd", div_cd.Text)
                    param.Add("@dept_cd", dept_cd.Text)
                    Me.Open("fam720_delete", param)
                    Me.Open()
                End If
            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@bud_year", "")
            param.Add("@co_cd", "")
            param.Add("@div_cd", "")
            param.Add("@dept_cd", "")
            'param.Add("@seq", "")
            Me.Open("fam720_f10", param)

            param = New OpenParameters
            param.Add("@co_cd", "")
            param.Add("@div_cd", "")
            param.Add("@dept_cd", "")
            param.Add("@bud_year", "")
            param.Add("@bud_mon", "")
            'param.Add("@seq", "")
            Me.Open("fam720_g20", param)

            param = New OpenParameters
            param.Add("@co_cd", "")
            param.Add("@div_cd", "")
            param.Add("@dept_cd", "")
            param.Add("@bud_year", "")
            'param.Add("@seq", "")
            Me.Open("fam720_g30", param)

            dept_nm.Text = ""

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g20_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g20.CellValueChanged

        If ColumnName = "m01" Or ColumnName = "m02" Or ColumnName = "m03" Or ColumnName = "m04" Or ColumnName = "m05" Or ColumnName = "m06" Or
            ColumnName = "m07" Or ColumnName = "m08" Or ColumnName = "m09" Or ColumnName = "m10" Or ColumnName = "m11" Or ColumnName = "m12" Then
            g20.Text("bud_sum", RowIndex) =
                ToDec(g20.Text("m01", RowIndex)) + ToDec(g20.Text("m02", RowIndex)) + ToDec(g20.Text("m03", RowIndex)) +
                ToDec(g20.Text("m04", RowIndex)) + ToDec(g20.Text("m05", RowIndex)) + ToDec(g20.Text("m06", RowIndex)) +
                ToDec(g20.Text("m07", RowIndex)) + ToDec(g20.Text("m08", RowIndex)) + ToDec(g20.Text("m09", RowIndex)) +
                ToDec(g20.Text("m10", RowIndex)) + ToDec(g20.Text("m11", RowIndex)) + ToDec(g20.Text("m12", RowIndex))
        End If
    End Sub

    Private Sub g30_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g30.CellValueChanged

        If ColumnName = "bef_amt" Then
            'If ColumnName = "amt" And amt_count = 0 Then
            '    amt_count += 1
            '    g20.Text("amt", RowIndex) = g20.Text("amt", RowIndex) * ToDec(amt_unit.Text)
            'ElseIf ColumnName = "amt" And amt_count > 0 Then
            '    Return
            'End If

            'If ColumnName = "bef_amt" And amt_bef_count = 0 Then
            '    amt_bef_count += 1
            '    g20.Text("bef_amt", RowIndex) = g20.Text("bef_amt", RowIndex) * ToDec(amt_unit.Text)
            'ElseIf ColumnName = "bef_amt" And amt_bef_count > 0 Then
            '    Return
            'End If

            g30.Text("diff_yamt", RowIndex) = ToDec(g30.Text("bud1_yamt", RowIndex)) - ToDec(g30.Text("bef_amt", RowIndex))
            If ToDec(g30.Text("bef_amt", RowIndex)) = 0 Then
                g30.Text("diff_yrt", RowIndex) = 0.0
            Else
                g30.Text("diff_yrt", RowIndex) = Rounding((ToDec(g30.Text("bud1_yamt", RowIndex)) - ToDec(g30.Text("bef_amt", RowIndex))) / ToDec(g30.Text("bef_amt", RowIndex)) * 100, 1).ToString
            End If


            'amt_count = 0
            'amt_bef_count = 0
        End If

    End Sub
  
End Class
