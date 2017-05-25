
Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SDD140

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        With g10
            If ColumnName = "chk" Then

                Dim cnt As Integer = 0
                Dim custCd As String
                If ColumnName = "chk" Then
                    If ToBool(Value) Then
                        custCd = .Text("cust_cd2")

                        '  동일 거래처  체크
                        For iRow = 0 To .RowCount - 1
                            If custCd <> .Text("cust_cd2", iRow) And .ToBool("chk", iRow) Then
                                cnt += 1
                            End If
                        Next
                        If cnt > 0 Then
                            MessageInfo("동일한 매출처만 처리 가능 합니다")
                            .UpdateRow()
                            .Text("sal_qty") = ""
                            .Text("chk", RowIndex) = ""
                            Exit Sub
                        End If
                    End If

                    If Value = "1" Then
                        .Text("sal_qty") = .Text("rem_qty")
                    Else
                        .Text("sal_qty") = ""
                    End If
                End If

            End If

        End With

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "sal_qty" Then
            If ToDec(Value) > 0 Then
                If ToDec(Value) > g10.ToDec("rem_qty") Then
                    g10.Text("chk") = "0"
                    g10.Text("sal_qty") = "0"
                    MsgBox("출하량보다 매출수량이 클 수 없습니다")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    'Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    ' 본 화면에서 바로 출하 처리 할려면 나중에 참조 하기
    '2. 데이타 검정
    'If Not CheckRequired(fac_cd, wh_cd, out_dt) Then
    ' Exit Sub
    ' End If

    ' Me.Save()
    ' Me.Open()

    'End Sub


    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        Dim menuName As String = "SDD100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open6(g10.DataSet)

    End Sub


    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click
        Dim custCd As String = cust_cd.Text
        With g10

            If custCd = "" Then
                If .CheckedRows("chk") > 0 Then
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("chk", i) Then
                            custCd = .Text("cust_cd", i)
                            Exit For
                        End If
                    Next
                End If
            End If

            If custCd = "" Then
                MessageInfo("먼저 거래처를 선택해 주세요")
                Exit Sub
            End If

            For i As Integer = 0 To .RowCount - 1
                If .Text("cust_cd2", i) <> custCd Then
                    If .Text("chk", i) = "1" Then
                        .Text("chk", i) = "0"
                    End If
                End If
            Next

            For i As Integer = 0 To .RowCount - 1
                If .Text("cust_cd2", i) = custCd Then
                    .Text("chk", i) = "1"
                End If
            Next
        End With
    End Sub

End Class
