Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMB211_KRS
    Private MoveRow As Boolean
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        Select Case opt_ty.DefaultText
            Case "", "0" '전체
                opt_ty.Text = "0"
                r1.Checked = True
            Case "1" '진행
                r2.Checked = True
            Case "2" '완료
                r3.Checked = True
        End Select
        EPanel2.SetSplitter(SplitContainer2, SplitContainer2.Panel2)
        EPanel3.SetSplitter(SplitContainer3, SplitContainer3.Panel2)
        g10.SelectRow = True
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            Case MenuType.Save
                Me.Save()

                Try

                    MoveRow = True
                    Me.Open("mmb211_g10")
                    g10.Find("dlv_no=" & dlv_no.Text)
                    Me.Open("mmb211_g20")
                    g20.Find("dlv_sq=" & dlv_sq.Text)
                    Me.Open("mmb211_g30")

                Catch ex As Exception

                Finally
                    MoveRow = False
                End Try

                'Case MenuType.Delete

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

    Private Sub o_dlv_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles o_dlv_no.KeyDown
        If o_dlv_no.Text = "" Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            Me.Open()
        End If
    End Sub

    Private Sub r_Click(sender As Object, e As System.EventArgs) Handles r1.Click, r2.Click, r3.Click
        If r1.Checked Then opt_ty.Text = "0"
        If r2.Checked Then opt_ty.Text = "1"
        If r3.Checked Then opt_ty.Text = "2"
    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        If MoveRow Then Exit Sub
        dlv_no.Text = g10.Text("dlv_no")
        Me.Open("mmb211_g20")

    End Sub

    Private Sub g20_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g20.AfterMoveRow
        If MoveRow Then Exit Sub
        dlv_sq.Text = g20.Text("dlv_sq")
        Me.Open("mmb211_g30")
    End Sub

End Class
