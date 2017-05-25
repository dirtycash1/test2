Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMM100

    Private Sub QMM100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SplitContainer2.SplitterDistance = 250
        g30.ShowRowHeaders = False
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Save

                Me._Save()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub _Save()
        If Not CheckRequired(fac_cd, wh_cd, iqc_dt) Then
            Exit Sub
        End If

        If MessageYesNoCancel("저장 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then

            Dim saveNo As String = g20.Text("dlv_no")
            Dim saveSq As String = g20.Text("dlv_sq")

            If chk_show.Text = "1" Then
                Me.Open("qmm100_g20")
            Else
                Me.Open()
            End If

            Dim find(1) As String
            find(0) = "dlv_no=" + saveNo
            find(1) = "dlv_sq=" + saveSq

            g20.Find(find)
        End If
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        If Not chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            cust_cd.Text = ""
            Me.Open("qmm100_g20")
        End If

        If chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            Me.Open("qmm100_g10")

            cust_cd.Text = g10.Text("cust_cd")
            Me.Open("qmm100_g20")
        End If

        g20.ColumnVisible("cust_cd") = Not chk_show.Checked
        g20.ColumnVisible("cust_nm") = Not chk_show.Checked

    End Sub

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        Me._Save()

    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click

        Dim saveNo As String = g40.Text("smp_no")

        Me._Save()

        g40.Find("smp_no=" + saveNo)
    End Sub


    Private Sub chk_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_no.CheckedChanged
        Me.Open()
    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g20.CheckRows("chk", chk_all.Checked)
    End Sub

    'Private Sub g40_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g40.AfterMoveRow
    '    g50.Text("iqc_no") = g20.Text("iqc_no")
    '    g50.Text("iqc_sq") = g20.Text("iqc_sq")
    '    g50.Text("smp_no") = g40.Text("smp_no")

    '    Me.Open("qmm100_g50")
    'End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If chk_show.Text = "1" Then
            cust_cd.Text = g10.Text("cust_cd")

            Me.Open("qmm100_g20")
        End If
    End Sub


    Private m_StopEvent As Boolean

    Private Sub _AddSample(ByVal qty As Decimal)
        'Smple 수량으로 시료행 만들기
        If ToDec(qty) > 0 Then
            Dim cnt As Integer = g40.RowCount
            If cnt < qty Then
                For i As Integer = 1 To qty - cnt
                    g40.AddNewRow()
                    g40.Text("smp_no") = cnt + i
                Next
            End If
            g40.RowIndex = 0
        End If
    End Sub

    Private Sub g20_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g20.AfterMoveRow
        'Smple 수량으로 시료행 만들기
        Me._AddSample(g20.ToDec("smp_qty"))
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20
            If ColumnName = "smp_qty" Then
                'Smple 수량으로 시료행 만들기
                Me._AddSample(ToDec(Value))
            End If

            If ColumnName = "rw_qty" Then
                If .ToDec("bad_qty") < .ToDec("rw_qty") Then
                    MessageInfo("불량수량보다 클 수 없습니다.")
                    .Text("rw_qty") = ""
                End If
            End If
        End With
    End Sub

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging
        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        With g20

            If ColumnName = "chk" Then
                If Value = "1" Then
                    .Text("ok_qty") = .ToDec("dlv_qty") - .ToDec("bad_qty")
                Else
                    .Text("ok_qty") = ""
                End If
            End If

            If ColumnName = "bad_qty" Then
                .Text("ok_qty") = .ToDec("dlv_qty") - ToDec(Value) + .ToDec("rw_qty")
                If .ToDec("ok_qty") <> 0 Then
                    .Text("chk") = "1"
                End If
            End If

            If ColumnName = "rw_qty" Then
                .Text("ok_qty") = .ToDec("dlv_qty") - .ToDec("bad_qty") + ToDec(Value)
                If .ToDec("ok_qty") <> 0 Then
                    .Text("chk") = "1"
                End If
            End If

            If ColumnName = "brk_qty" Then
                If ToDec(Value) <> 0 Then
                    .Text("chk") = "1"
                    .Text("ok_qty") = .ToDec("dlv_qty") - .ToDec("bad_qty")
                End If
            End If

        End With

        m_StopEvent = False
    End Sub

    Private Sub g50_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g50.CellValueChanged
        With g50
            '측정값으로 합불판정
            If ColumnName = "insp_val" Then
                If .ToDec("insp_min") <= ToDec(Value) And ToDec(Value) <= .ToDec("insp_max") Then
                    .Text("ok_yn") = "1"
                Else
                    .Text("ok_yn") = "0"
                End If
            End If
            '검사항목으로 시료 합불판정
            If ColumnName = "ok_yn" Then
                For i As Integer = 0 To .RowCount - 1
                    If .Text("ok_yn", i) = "0" Then
                        g40.Text("ok_yn") = "0"
                        Exit Sub
                    End If
                Next
                g40.Text("ok_yn") = "1"
            End If

        End With
    End Sub


End Class
