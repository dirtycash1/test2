Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMZ200

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

            Case MenuType.Save
                If CheckRequired(item_cd, rel_dt) Then
                    If Me.Save() Then
                        Me.Open()
                    End If
                End If

            Case MenuType.New
                item_cd.Text = ""
                item_id.Text = ""
                item_nm.Text = ""
                rel_dt.Text = ""

                Dim param As OpenParameters = New OpenParameters
                param.Add("@item_id", "")
                param.Add("@rel_dt", "")
                Me.Open("qmz200_g20", param)

                g20.AddNewRow()

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
        If ColumnName = "mtr_amt" Or ColumnName = "prc_amt1" Or ColumnName = "prc_amt2" Then
            g20.Text("tot_amt1", RowIndex) = ToDec(g20.Text("mtr_amt", RowIndex)) + ToDec(g20.Text("prc_amt1", RowIndex))
            g20.Text("tot_amt2", RowIndex) = ToDec(g20.Text("mtr_amt", RowIndex)) + ToDec(g20.Text("prc_amt1", RowIndex)) + ToDec(g20.Text("prc_amt2", RowIndex))
        End If
    End Sub
End Class
