Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class DMN110

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
                Save_Form()

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
            With g10
                For Row As Integer = 0 To .RowIndex
                    If .IsDataRow(Row) Then
                        If .Text("adm_yn", Row) = "1" Then
                            If .Text("adm_nm", Row) = "" Or .Text("adm_dt", Row) = "" Then
                                MessageWarning("승인 선택시 [승인자]와 [일자]는 필수 입력입니다.")
                                Return False
                                Exit For
                            End If
                        End If
                    End If
                Next

                Save()
            End With
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

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "adm_yn" Then
                If .Text("adm_yn") = "1" Then
                    .Text("adm_dt") = Now.ToShortDateString 'Format(Now, "yyyy-MM-dd")
                    '.Text("adm_uid") = Login.ID
                    .Text("adm_nm") = Login.Name
                Else
                    .Text("adm_dt") = ""
                    .Text("adm_nm") = ""
                    '.Text("adm_uid") = ""
                End If
            End If
        End With
    End Sub
End Class
