Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1140_2
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open()
        Retrieve()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Retrieve()
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                ''사용하려면 재정의 가능하다
            Case MenuType.Save
                If Not ConFrim() Then Exit Sub

                'If Check_Stts() = "C" Then '상태값 CHECK
                '    MsgBox("확인처리된 자료입니다.!")
                'Else
                '    If Me.Save() Then
                '        Me.Open()
                '    End If
                'End If

                'Case MenuType.Confirm
                '    If Not ConFrim() Then Exit Sub

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub ok_Click(sender As System.Object, e As System.EventArgs) Handles ok.Click
        For i = 0 To g10.RowCount - 1
            g10.Text("OT_DT", i) = ok_ot_dt.Text
        Next
    End Sub


    Private Function ConFrim() As Boolean
        p.Clear()
        'For i = 0 To g10.RowCount - 1
        '    If g10.Text("OD_NO", i) = Nothing Then
        '        MsgBox("자료를 확인하세요.!")
        '        Return False
        '    End If
        'Next

        '상태값 CHECK
        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("확인처리된 자료입니다.!")
            Return False
        End If

        'If Check_Od_Qty() <> 0 Then
        '    Return False
        'End If

        'If MessageYesNo("확인 하시겠습니까?", Nothing, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.No Then
        '    Exit Function
        'Else



        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then
                If g10.Text("OD_NO", i) = Nothing Then
                    MsgBox("자료를 확인하세요.!")
                    Return False

                Else
                    p.Add("@ot_no", g10.Text("OT_NO", i))
                    p.Add("@stts", "C")
                    p.Add("@OT_SUM_QTY", g10.Text("OT_SUM_QTY", i))
                    p.Add("@OLD_SUM_QTY", g10.Text("OLD_SUM_QTY", i))

                    Me.Open("wi_sa1140_confirm2", p)
                End If
            End If
            
        Next


        'If wf_update_satr1121("C") <> 0 Then
        '    Return False
        'End If

        'If wf_update_lotno() <> 0 Then
        '    Return False
        'End If

        g10.Open()
        ot_no.Focus()

        'End If

        Return True
    End Function

    Private Function Check_Stts() As String
        p.Clear()

        For i = 0 To g10.RowCount - 1
            p.Add("@ot_no", g10.Text("OT_NO", i))
        Next

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_sa1140_stts2", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function


    Private Sub all_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles all_chk.CheckedChanged

        g10.CheckRows("chk", all_chk.Checked)

    End Sub


    Private Sub Retrieve()
        p.Clear()

        p.Add("@fr_dt", fr_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@ot_no", ot_no.Text)
        p.Add("@cs_cd", cs_cd.Text)
        p.Add("@stts", stts.Text)
        p.Add("@dps_stts", dps_stts.Text)
        p.Add("@ot_chk", "B")

        If ot_chk.Text = "A" Then  '전체조회
            p.Add("@chk1 ", "1")
            p.Add("@chk2 ", "0")
        ElseIf ot_chk.Text = "B" Then   '수주수량=출하수량 인것만
            p.Add("@chk1", "1")
            p.Add("@chk2", "1")
        ElseIf ot_chk.Text = "C" Then   '수주수량 <> 출하수량 인것만 
            p.Add("@chk1", "0")
            p.Add("@chk2", "0")
        End If

        Me.Open("wi_sa1140_2_g10", p)

    End Sub




    'Private Function wf_update_satr1121(a_stts As String) As Integer
    '    Dim ls_odno As String, ll_odseq As Integer, ld_otqty As Decimal

    '    With g10
    '        For i As Integer = 0 To .RowCount - 1
    '            ls_odno = .Text("OD_NO", i)
    '            ll_odseq = .Text("OD_SEQ", i)
    '            ld_otqty = .Text("OT_QTY", i)

    '            p.Clear()
    '            p.Add("@STTS", a_stts)
    '            p.Add("@OT_QTY", ld_otqty)
    '            p.Add("@OD_NO", ls_odno)
    '            p.Add("@OD_SEQ", ll_odseq)

    '            Me.Open("wi_sa1140_update", p)
    '        Next
    '    End With
    'End Function


    'Private Function Check_Od_Qty() As Integer
    '    Dim ld_rqty As Decimal, ld_oqty As Decimal

    '    With g10
    '        For i As Integer = 0 To .RowCount - 1
    '            ld_rqty = .Text("RM_QTY", i)
    '            ld_oqty = .Text("OT_QTY", i)

    '            'If ld_oqty > ld_rqty Then
    '            '    MsgBox("출하수량이이 미출하수량보다 많습니다!")

    '            '    '-----------------
    '            '    .Focus()
    '            '    .FocusedFieldName = "OT_QTY"
    '            '    .RowIndex = i
    '            '    .EditMode()
    '            '    '------------------
    '            '    Return 1
    '            'End If
    '        Next
    '    End With

    '    Return 0
    'End Function


    'Private Function wf_update_lotno() As Integer
    '    Dim ls_otno As String, ll_seq As Integer, ls_lotno As String

    '    ls_otno = ot_no.Text

    '    With g10
    '        For i As Integer = 0 To .RowCount - 1
    '            ll_seq = .Text("SEQ", i)
    '            ls_lotno = .Text("LOT_NO", i)

    '            p.Clear()
    '            p.Add("@OT_NO", ls_otno)
    '            p.Add("@LOT_NO", ls_lotno)
    '            p.Add("@SEQ", ll_seq)

    '            Me.Open("wi_sa1140_lotno_update", p)
    '        Next
    '    End With
    'End Function




End Class
