Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_PR1117
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Clear()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 사용하려면 재정의 가능하다.
                'g_result.Focus()
                'g_result.FocusedFieldName = "LOT_NO"

            Case MenuType.Save

                If Not Saves() Then Exit Sub

                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()

        p.Add("@find_sa_cd", find_sa_cd.Text)
        p.Add("@find_wh_cd", find_wh_cd.Text)
        p.Add("@find_lot_no", "XXX")
        p.Add("@find_nm_cd", find_nm_cd.Text)


        Me.Open("wi_pr1117_multi", p)
    End Sub

    Private Sub btn_chk_Click(sender As Object, e As System.EventArgs) Handles btn_chk.Click
        Dim s As String = "0"
        If btn_chk.Text = "전체선택" Then
            s = "1"
            btn_chk.Text = "전체해제"
        Else
            btn_chk.Text = "전체선택"
        End If

        With g_result
            For i As Integer = 0 To .RowCount - 1
                .Text("CHK", i) = s


                '170113smk 중지코드는 분리지시 불가
                'If .Text("STOP_YN", i) = "1" Then
                '    g_result.Text("CHK", i) = "0"    '중지코드는 선택불가
                'End If

            Next
        End With

    End Sub

    Private Function Saves() As Boolean

        If MessageYesNo("분리생산지시를 일괄 생성 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else

            If MyBase.Save() Then
                'MyBase.OpenTrigger("wi_sa1120_list")
            End If

            Me.Clear()

        End If

        Return True
    End Function

    '막아놓고
    'Private Sub g_result_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_result.CellValueChanged

    '    '170113smk 중지코드는 분리지시 할 수 없음.
    '    If ColumnName = "CHK" Then
    '        If g_result.Text("STOP_YN", RowIndex) = "1" And g_result.Text("CHK", RowIndex) = "1" Then
    '            g_result.Text("CHK", RowIndex) = "0"    '중지코드는 선택불가
    '            'SetColumnFocus("CHK")
    '            'g_result.Focus()
    '            'g_result.FocusedFieldName = "MC_CD"
    '        End If
    '    End If

    'End Sub

    '풀어놓기
    'Private Sub g_result_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g_result.AfterMoveRow
    '    If g_result.Text("STOP_YN", RowIndex) = "1" Then 'And g_result.Text("CHK", RowIndex) = "1" Then
    '        'g_result.Text("CHK", RowIndex) = "0"    '중지코드는 선택불가
    '        g_result.ColumnReadOnly("CHK") = True
    '    Else
    '        g_result.ColumnReadOnly("CHK") = False
    '    End If
    'End Sub

    'Private Sub g_result_AfterMoveColumn(sender As Object, PrevColumnName As String, ColumnName As String) Handles g_result.AfterMoveColumn


    '    If g_result.Text("STOP_YN", g_result.RowIndex) = "1" Then 'And g_result.Text("CHK", RowIndex) = "1" Then
    '        'g_result.Text("CHK", RowIndex) = "0"    '중지코드는 선택불가
    '        g_result.ColumnReadOnly("CHK") = True
    '    Else
    '        g_result.ColumnReadOnly("CHK") = False
    '    End If
    'End Sub
End Class
