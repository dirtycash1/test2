Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMN100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        New_Form()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            cust_cd.Text = ""
            itm_cd.Text = "zzzzzz"
            model_cd.Text = ""

            Me.Open()
            itm_cd.Text = ""

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

    'Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
    '    If g10.Text("adm_yn") = "1" Then
    '        MessageWarning("승인처리자료는 수정이 불가합니다.")
    '        g10.CancelRowChanges()
    '    End If
    'End Sub

    Private Sub g10_CellValueChanging(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If g10.Text("adm_yn") = "1" Then
            MessageWarning("[승인처리자료]는 수정이 불가합니다.")
            g10.CancelRowChanges()
        End If
    End Sub
End Class
