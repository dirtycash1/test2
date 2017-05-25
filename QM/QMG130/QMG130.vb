Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMG130

    Private Sub QMG130_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SplitContainer2.SplitterDistance = 250
        '  g30.ShowRowHeaders = False
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
        If Not CheckRequired(f_fac_cd, bad_dt) Then
            Exit Sub
        End If

        If MessageYesNo("저장 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then

            Dim saveNo As String = g20.Text("mov_no")
            Dim saveSq As String = g20.Text("mov_sq")

            If chk_show.Text = "1" Then
                Me.Open("qmg130_g20")
            Else
                Me.Open()
            End If

            Dim find(1) As String
            find(0) = "mov_no=" + saveNo
            find(1) = "mov_sq=" + saveSq

            g20.Find(find)
        End If
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged

        If Not chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            cust_cd.Text = ""
            Me.Open("qmg130_g20")
        End If

        If chk_show.Checked Then
            SplitContainer2.Panel1Collapsed = Not chk_show.Checked
            Me.Open("qmg130_g10")

            cust_cd.Text = g10.Text("cust_cd")
            Me.Open("qmg130_g20")
        End If

        g20.ColumnVisible("cust_cd") = Not chk_show.Checked
        g20.ColumnVisible("cust_nm") = Not chk_show.Checked

    End Sub

    Private Sub btn_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work.Click

        Me._Save()

    End Sub


    Private Sub chk_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_no.CheckedChanged
        Me.Open()
    End Sub



    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If chk_show.Text = "1" Then
            cust_cd.Text = g10.Text("cust_cd")

            Me.Open("qmg130_g20")
        End If
    End Sub


    Private m_StopEvent As Boolean

    Private Sub g20_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanging
        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        With g20

            If ColumnName = "chk" Then

                If Value = "1" Then
                    .Text("sel_qty") = .ToDec("mov_qty") - ToDec("bad_qty")
                Else
                    .Text("sel_qty") = ""
                End If

            End If



        End With

        m_StopEvent = False
    End Sub


    Private Sub g30_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanging
        Dim badTot As Decimal
        With g30
            For i As Integer = 0 To .RowCount - 1
                If RowIndex = i Then
                    badTot += ToDec(Value)
                Else
                    badTot += .ToDec("bad_qty", i)
                End If
            Next
        End With
        bad_qty.Text = badTot
    End Sub




End Class
