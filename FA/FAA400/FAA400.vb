Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAA400


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        all_yn.Visible = False

        Me._SetColumn()

        g10.SelectRow = True

        'SplitContainer1.SplitterDistance = 80
        SplitContainer4.Panel2Collapsed = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty

            Case MenuType.Save

                Me._Save()

            Case Else

                MyBase.MenuButton_Click(ty)

        End Select

    End Sub

    Private Sub _Save()

        If Not Me.DataChanged Then
            Exit Sub
        End If

        If Me.Save() Then
            Dim find(0) As String
            find(0) = "sq_no = " + g10.Text("sq_no")

            Me.Open()

            g10.Find(find)
        End If

    End Sub

    Private m_EventStop As Boolean
    Private m_StopEvent As Boolean

#Region " Control Event "

    Private Sub acc_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles acc_yn.CheckedChanged
        g10.ColumnVisible("chk") = acc_yn.Checked
        g10.ColumnVisible("acc_cd") = acc_yn.Checked
        g10.ColumnVisible("acc_nm") = acc_yn.Checked
        Me.Open()

        all_yn.Visible = acc_yn.Checked
    End Sub

    Private Sub all_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles all_yn.CheckedChanged
        If all_yn.Checked Then
            m_StopEvent = True
            With g10
                For i As Integer = 0 To .RowCount - 1
                    If .Value("chk", i) <> "1" Then
                        .Value("chk", i) = "1"
                        .Value("sq_no", i) = .Value("acc_cd", i)
                        .Value("prt_nm", i) = .Value("acc_nm", i)
                        .Value("prt_bc", i) = "FA960100"
                        If .Value("prt_l_yn", i) = "0" And .Value("prt_r_yn", i) = "0" Then
                            .Value("prt_r_yn", i) = "1"
                        End If
                    End If
                Next
            End With
            m_StopEvent = False
        End If
    End Sub

    Private Sub doc_bc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doc_bc.TextChanged, doc_bc2.TextChanged
        Me._SetColumn()
    End Sub

    Private Sub _SetColumn()
        Dim yn As Boolean
        If doc_bc.Text < "FA950400" Then
            both_yn.Text = "N"
            yn = False
        Else
            both_yn.Text = "Y"
            yn = True
        End If
        g10.ColumnVisible("prt_l_yn") = yn
        g10.ColumnVisible("prt_r_yn") = yn
        g10.ColumnVisible("line_l_yn") = yn
        g10.ColumnVisible("line_r_yn") = yn

        g20.ColumnVisible("prt_l_yn") = yn
        g20.ColumnVisible("prt_r_yn") = yn
    End Sub

    Private Sub _CopyRow(ByVal iRow As Integer)
        m_EventStop = True

        If g10.Text("sq_no") = "" Then
            MessageInfo("Select item first.")
            Exit Sub
        End If

        g20.AddNewRow()
        g20.Text("lv") = g30.Text("lv", iRow)
        g20.Text("acc_cd") = g30.Text("acc_cd", iRow)
        g20.Text("acc_nm") = g30.Text("acc_nm", iRow)

        If g20.Text("acc_cd").StartsWith("$") Then
            g20.Text("cal_bc") = ""
        End If

        m_EventStop = False
    End Sub

#End Region

#Region " Grid Event "

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If m_StopEvent Then
            Exit Sub
        End If
        If g10.Text("acc_cd") <> "" Then
            Dim find(0) As String
            find(0) = "acc_cd = " + g10.Text("acc_cd")

            g30.Find(find)
        End If
    End Sub

    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow

        If m_EventStop Then Exit Sub

        Dim accCd As String
        If g20.Text("acc_cd") <> "" Then
            accCd = g20.Text("acc_cd")
        Else
            '없으면 g10의 계정
            accCd = g10.Text("acc_cd")
        End If

        Dim find(0) As String
        find(0) = "acc_cd = " + accCd

        g30.Find(find)

    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        If m_StopEvent Then
            Exit Sub
        End If
        With g10
            If ColumnName = "chk" Then
                If .Text("doc_id") = "" Then
                    If ToBool(Value) Then
                        .Text("sq_no") = .Text("acc_cd")
                        .Text("prt_nm") = .Text("acc_nm")
                        .Text("prt_bc") = "FA960100"
                        If .Text("prt_l_yn") = "0" And .Text("prt_r_yn") = "0" Then
                            .Text("prt_r_yn") = "1"
                        End If
                    Else
                        .Text("sq_no") = ""
                        .Text("prt_nm") = ""
                        .Text("prt_bc") = ""
                        .Text("prt_l_yn") = "0"
                        .Text("prt_r_yn") = "0"
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub g30_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g30.DoubleClick

        Me._CopyRow(g30.RowIndex)

    End Sub

#End Region

#Region " Button Event "

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Me._Save()
    End Sub

    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        SplitContainer4.Panel2Collapsed = Not SplitContainer4.Panel2Collapsed
        If Not SplitContainer4.Panel2Collapsed Then
            'SplitContainer1.SplitterDistance = 104
            SplitContainer4.SplitterDistance = 680
            'Else
            '    SplitContainer1.SplitterDistance = 80
        End If
    End Sub

    Private Sub btn_copy_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy_save.Click
        If MessageYesNo("To 쪽은 삭제되고 복사됩니다." + vbLf + vbLf + "복사 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not CheckRequired(sys_cd, doc_year, doc_bc, doc_year2, doc_bc2) Then
            Exit Sub
        End If
        Me.Open("faa400_copy")
    End Sub

    Private Sub btn_lv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m_StopEvent = True
        g10.StopOpenEvent = True
        Try
            For i As Integer = 0 To g10.RowCount - 1
                If g10.Text("prt_nm", i) <> "" Then
                    g10.Text("prt_nm", i) = Space(g10.ToDec("lv", i) * 2) + g10.Text("prt_nm", i)
                End If
            Next
            g10.RowIndex = 0
        Catch ex As Exception
            MessageInfo(ex)
        Finally
            g10.StopOpenEvent = False
            m_StopEvent = False
        End Try

    End Sub

    Private Sub btn_move_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_move.Click
        Dim rows() As Integer = g30.GetSelectedRows

        For Each r As Integer In rows
            Me._CopyRow(r)
            g30.Text("used_yn", r) = "1"
        Next
    End Sub

#End Region



End Class
