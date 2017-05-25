Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM730

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open
                If CheckRequired(o_bud_year) Then
                    Me.Open()
                End If

            Case MenuType.Save
                If CheckRequired(bud2_emp_nm, bud2_dt) Then
                    If Me.Save() Then
                        Me.Open()

                        'Dim param As OpenParameters = New OpenParameters
                        'param.Add("@bud_year", bud_year.Text)
                        'param.Add("@co_cd", co_cd.Text)
                        'param.Add("@div_cd", div_cd.Text)
                        'param.Add("@dept_cd", dept_cd.Text)
                        'Me.Open("fam730_g20", param)
                        'Me.Open("fam730_g30", param)
                    End If
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

    Private Sub btn_load_Click(sender As System.Object, e As System.EventArgs) Handles btn_load.Click
        Dim param As OpenParameters = New OpenParameters
        param.Add("@bud_year", bud_year.Text)
        param.Add("@co_cd", co_cd.Text)
        param.Add("@div_cd", div_cd.Text)
        param.Add("@dept_cd", dept_cd.Text)
        Me.Open("fam730_g20_btn", param)

        Dim row_cnt = g20.DataSet.Tables(0).Rows.Count
        If row_cnt <> 0 Then
            For i = 0 To row_cnt - 1
                g20.Text("bud_sum", i) =
                   ToDec(g20.Text("m01", i)) + ToDec(g20.Text("m02", i)) + ToDec(g20.Text("m03", i)) +
                   ToDec(g20.Text("m04", i)) + ToDec(g20.Text("m05", i)) + ToDec(g20.Text("m06", i)) +
                   ToDec(g20.Text("m07", i)) + ToDec(g20.Text("m08", i)) + ToDec(g20.Text("m09", i)) +
                   ToDec(g20.Text("m10", i)) + ToDec(g20.Text("m11", i)) + ToDec(g20.Text("m12", i))
            Next
        End If
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        If CheckRequired(bud2_emp_nm, bud2_dt) Then
            If Me.Save() Then
                Me.Open()
                'Dim param As OpenParameters = New OpenParameters
                'param.Add("@bud_year", bud_year.Text)
                'param.Add("@co_cd", co_cd.Text)
                'param.Add("@div_cd", div_cd.Text)
                'param.Add("@dept_cd", dept_cd.Text)
                'Me.Open("fam730_g20", param)
                'Me.Open("fam730_g30", param)
            End If
        End If
    End Sub
End Class
