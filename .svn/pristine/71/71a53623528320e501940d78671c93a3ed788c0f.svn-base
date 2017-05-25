Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM740

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

            Case MenuType.New
                bud_year.Text = ""
                co_cd.Text = ""
                div_cd.Text = ""
                dept_cd.Text = ""
                dept_nm.Text = ""
                chg_dt.Text = ""

                Dim param As OpenParameters = New OpenParameters
                param.Add("@bud_year", "")
                param.Add("@co_cd", "")
                param.Add("@div_cd", "")
                param.Add("@dept_cd", "")
                param.Add("@chg_dt", "")
                Me.Open("fam740_g20", param)

            Case MenuType.Save
                If CheckRequired(bud_year, dept_nm, co_cd, chg_dt, div_cd) Then
                    If Me.Save Then
                        Me.Open()

                        'Dim param As OpenParameters = New OpenParameters
                        'param.Add("@co_cd", co_cd.Text)
                        'param.Add("@div_cd", div_cd.Text)
                        'param.Add("@dept_cd", dept_cd.Text)
                        'param.Add("@bud_year", bud_year.Text)
                        'param.Add("@chg_dt", chg_dt.Text)
                        'Me.Open("fam740_g20", param)
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

        If g20.Text("chg_mon", RowIndex) = "" Then
            Return
        End If

        If ColumnName = "chg_mon" Then
            If ToDec(g20.Text("chg_mon", RowIndex)) > 0 And ToDec(g20.Text("chg_mon", RowIndex)) < 13 Then
                If g20.Text("chg_mon", RowIndex).Length = 1 Then
                    g20.Text("chg_mon", RowIndex) = "0" + g20.Text("chg_mon", RowIndex)
                End If
            Else
                g20.Text("chg_mon", RowIndex) = ""
                Return
            End If
        End If
    End Sub
End Class
