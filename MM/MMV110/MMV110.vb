Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class MMV110
    Dim p As New OpenParameters
    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub
    Dim com_row As Integer

    Public Overloads Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                ' save_mmv100_2(g10.RowIndex)
                save_mmv100_2(com_row)

                Me.Save()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub
    ' 2014-06-27 대체거래처 체크 

    Private Sub num_chk_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles num_chk.CheckedChanged
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
        p.Add("@grp3_cd", grp3_cd.Text)
        'p.Add("@model_cd", model_cd.Text)
        p.Add("@cust_cd", cust_cd.Text)
        p.Add("@cust_nm", cust_nm.Text)

        If num_chk.Checked = True Then    '체크 되면,     
            p.Add("@num_chk", "1")        '전체 조회
        Else                              '체크 안되면,
            p.Add("@num_chk", "2")
        End If
        Me.Open("MMV110_g10", p)
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

        If ColumnName = "up" Or ColumnName = "mb_nm" Or ColumnName = "cust_cd" Then
            com_row = RowIndex
        End If


        'With g10
        '    If ColumnName = "up" And MenuType.Save = True Then
        '        p.Clear()
        '        p.Add("@ITM_ID", g10.Text("itm_id", RowIndex))
        '        p.Add("@ITM_CD", g10.Text("itm_cd", RowIndex))
        '        p.Add("@CUST_CD", g10.Text("cust_cd", RowIndex))
        '        p.Add("@ITM_NM", g10.Text("itm_nm", RowIndex))
        '        p.Add("@SPEC", g10.Text("spec", RowIndex))
        '        p.Add("@UP", g10.Text("up", RowIndex))
        '        p.Add("@RMK", g10.Text("rmk", RowIndex))

        '        Me.Open("mmv110_qry", p)
        '    End If
        'End With

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
