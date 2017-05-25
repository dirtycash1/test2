Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMA330

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearReplace()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New

            Case MenuType.Save

            Case MenuType.Delete

            Case Else
                If (o_year.EditText = String.Empty) Then
                    Return
                End If
                MyBase.MenuButton_Click(mty)
                YearReplace()
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

    Private Sub YearReplace()
        g10.ColumnTitle(10) = (Convert.ToInt32(o_year.EditText) - 2).ToString + "계획"
        g10.ColumnTitle(11) = (Convert.ToInt32(o_year.EditText) - 2).ToString + "완료"
        g10.ColumnTitle(12) = (Convert.ToInt32(o_year.EditText) - 1).ToString + "계획"
        g10.ColumnTitle(13) = (Convert.ToInt32(o_year.EditText) - 1).ToString + "완료"
        g10.ColumnTitle(14) = (Convert.ToInt32(o_year.EditText)).ToString + "계획"
        g10.ColumnTitle(15) = (Convert.ToInt32(o_year.EditText)).ToString + "완료"

    End Sub
End Class
