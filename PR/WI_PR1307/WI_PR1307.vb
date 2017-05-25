Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1307
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Me.Clear()
                Me.Preview()

            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
            Case MenuType.Find
            Case MenuType.Delete
            Case MenuType.Save

                If Not ConFrim() Then Exit Sub

            Case MenuType.New
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@lot_no", "xxx")
        p.Add("@gd_nm", "xxx")
        p.Add("@fa_cd", "xxx")
        p.Add("@mate_no", "xxx")

        Me.Open("wi_pr1307_multi", p)

        lot_no.Text = ""
        gd_nm.Text = ""
        ps_cd.Text = ""
        ps_nm.Text = ""
        pl_cd.Text = ""
        fa_cd.Text = ""

        chk_all.Checked = False

    End Sub

    Private Sub Preview()
        p.Clear()

        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@lot_no", lot_no.Text)
        p.Add("@gd_nm", gd_nm.Text)
        p.Add("@fa_cd", fa_cd.Text)
        p.Add("@mate_no", mate_no.Text)

        Me.Open("wi_pr1307_multi", p)
    End Sub

    Private Function ConFrim() As Boolean

        If wf_check() = 1 Then
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                'If CONFIRM() = 0 Then
                '    Me.Preview()
                '    chk_all.Checked = False
                'End If
                Me.Preview()
                chk_all.Checked = False
            End If
        End If
    End Function

    Private Sub g_list_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_list.CellValueChanged
        If ColumnName = "MV_QTY" Then
            g_list.Text("LOSS_QTY") = g_list.ToDec("IP_QTY") - g_list.ToDec("MV_QTY")
        End If
    End Sub

    Private Function CONFIRM() As Integer
        
        Dim ls_chk As String = "0"
        Dim ls_gdcd, ls_lotno, ls_ipno As String
        Dim ld_mvqty, ld_ipqty, ld_lossqty As Decimal

        With g_list
            For i As Integer = 0 To .RowCount - 1
                ls_chk = .Text("CHK", i)

                If ls_chk = "1" Then
                    ls_gdcd = .Text("GD_CD", i)
                    ls_lotno = .Text("LOT_NO", i)
                    ld_mvqty = .ToDec("MV_QTY", i)
                    ld_ipqty = .ToDec("IP_QTY", i)
                    ld_lossqty = .ToDec("LOSS_QTY", i)
                    ls_ipno = .Text("IP_NO", i)

                    p.Clear()
                    p.Add("@GD_CD", ls_gdcd)
                    p.Add("@LOT_NO", ls_lotno)
                    p.Add("@MV_QTY", ld_mvqty)
                    p.Add("@IP_QTY", ld_ipqty)
                    p.Add("@LOSS_QTY", ld_lossqty)
                    p.Add("@IP_NO", ls_ipno)
                    p.Add("@MV_DT", mv_dt.Text)
                    p.Add("@SA_CD", sa_cd.Text)
                    p.Add("@PS_CD", ps_cd.Text)
                    p.Add("@PL_CD", pl_cd.Text)
                    p.Add("@FA_CD", .Text("FA_CD", i))
                    p.Add("@FMPS_GU", .Text("FMPS_GU", i))
                    p.Add("@TMPS_GU", .Text("TMPS_GU", i))

                    Me.Open("wi_pr1307_confirm", p)
                End If
            Next
        End With
    End Function

    Private Function wf_check() As Integer
        Dim ls_pscd As String

        ls_pscd = ps_cd.Text

        If ls_pscd = Nothing Then
            MsgBox("작성자를 확인하세요.!")
            Return 1
        End If

        Return 0
    End Function

    Private Sub chk_all_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk_all.CheckedChanged
        If chk_all.Checked = True Then
            If g_list.RowCount() > 0 Then
                g_list.RowIndex = 0

                For i As Integer = 0 To g_list.RowCount + 1
                    g_list.Text("CHK", i) = "1"
                Next
            End If
        Else
            If g_list.RowCount() > 0 Then
                g_list.RowIndex = 0

                For i As Integer = 0 To g_list.RowCount + 1
                    g_list.Text("CHK", i) = "0"
                Next
            End If
        End If
    End Sub

  
    Private Sub g_list_Load(sender As System.Object, e As System.EventArgs) Handles g_list.Load

    End Sub
End Class
