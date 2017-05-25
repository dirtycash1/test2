Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class MMV110_B
    Dim p As New OpenParameters
    Dim com_row As Integer

    Public Overloads Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save

                save_mmv100_2(com_row)

                Me.Save()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    ' 2014-06-27 대체거래처 체크 
    Private Sub num_chk_CheckedChanged(sender As Object, e As System.EventArgs) Handles num_chk.CheckedChanged
        Dim ls_item_bc, ls_item_cd, ls_item_nm, ls_grp1_cd, ls_grp2_cd, ls_itm_yn As String
        ls_item_bc = itm_bc.Text
        ls_item_cd = itm_cd.Text
        ls_item_nm = itm_nm.Text
        ls_grp1_cd = grp1_cd.Text
        ls_grp2_cd = grp2_cd.Text
        ls_itm_yn = itm_yn.Text

        p.Clear()
        p.Add("@itm_yn", ls_itm_yn)
        p.Add("@itm_bc", ls_item_bc)
        p.Add("@itm_cd", ls_item_cd)
        p.Add("@itm_nm", ls_item_nm)
        p.Add("@grp1_cd", ls_grp1_cd)
        p.Add("@grp2_cd", ls_grp2_cd)
        'p.Add("@grp3_cd", grp3_cd.Text)
        'p.Add("@model_cd", model_cd.Text)
        p.Add("@cust_cd", cust_cd.Text)
        p.Add("@cust_nm", cust_nm.Text)

        If num_chk.Checked = True Then    '체크 되면,     
            p.Add("@num_chk", "1")        '전체 조회
        Else                              '체크 안되면,
            p.Add("@num_chk", "2")
        End If
        Me.Open("mmv110_b", p)
    End Sub

    Public Sub save_mmv100_2(com_row)
        p.Clear()
        p.Add("@ITM_ID", g10.Text("itm_id", com_row))
        p.Add("@ITM_CD", g10.Text("itm_cd", com_row))
        p.Add("@CUST_CD", g10.Text("cust_cd", com_row))
        p.Add("@ITM_NM", g10.Text("itm_nm", com_row))
        p.Add("@SPEC", g10.Text("spec", com_row))
        p.Add("@UP", g10.Text("up", com_row))
        p.Add("@RMK", g10.Text("rmk", com_row))
        p.Add("@MB_NM", g10.Text("mb_nm", com_row))

        Me.Open("mmv110_qry", p)

    End Sub


    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        'Select Case ColumnName
        '    Case "up"  '단가 or 자재규격 or 제조메이커 or 입고거래처 변경시, Or "spec" Or "mb_nm" Or "cust_cd"  
        '        com_row = RowIndex
        'End Select

        If ColumnName = "up" Or ColumnName = "mb_nm" Or ColumnName = "cust_cd" Then
            com_row = RowIndex
        End If

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        jump_open("MMV110_2", g10.Text("itm_cd"), g10.Text("cust_cd"))
    End Sub

    Private Sub jump_open(ByVal lparam As String, ByVal wparam As String, ByVal wparam2 As String)

        Dim menuName As String = lparam
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open3(wparam, wparam2)

    End Sub

End Class
