Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMA341

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
                If CheckRequired(fr_dt, to_dt) Then
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

    Private Sub fr_dt_TextChanged(sender As System.Object, e As System.EventArgs) Handles fr_dt.TextChanged
        If fr_dt.Text = "" Then
            to_dt.Text = ""
        Else
            Dim dt = Convert.ToDateTime(fr_dt.Text)
            to_dt.Text = DateAdd(DateInterval.Day, 6, dt)
        End If
    End Sub

    Private Sub grid_ButtonPressed(sender As System.Object, columnName As System.String) Handles g10.ButtonPressed, g20.ButtonPressed
        Dim control As Control = sender
        If control.Name = "g10" Then
            [Shared].FileDownLoad(g10.Text("file"), , True)
        ElseIf control.Name = "g20" Then
            [Shared].FileDownLoad(g20.Text("file"), , True)
        End If
    End Sub
End Class
