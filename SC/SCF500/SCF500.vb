Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SCF500

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()
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

    Private Sub g10_BeforeMoveRow(sender As Object, RowIndex As Integer, ByRef AllowMove As Boolean) Handles g10.BeforeMoveRow
        If g20.DataChanged() Then
            Select Case MessageYesNoCancel("저장하시겠습니까 ?")
                Case MsgBoxResult.Yes
                    If Not Me.Save() Then
                        '저장에 실패 했으면 Move Row가 허용되면 안된다
                        AllowMove = False
                    End If
                Case MsgBoxResult.No
                    'No를 눌렀으면 저장하지 않고 Row를 변경한다
                    Exit Sub
                Case MsgBoxResult.Cancel
                    '취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
                    AllowMove = False
            End Select
        End If

    End Sub

    Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If ColumnName = "mng_bc" Then
            If g20.Text("mng_bc") = "SC720100" Then '전체
                g20.Text("mng_cd") = "All"
            Else
                g20.Text("mng_cd") = ""
            End If

        End If
    End Sub
End Class
