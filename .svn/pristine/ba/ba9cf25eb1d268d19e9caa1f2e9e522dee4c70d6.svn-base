Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class SDD161

    'Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
    '    Me.New_Form()

    'End Sub

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
                If .Text("cust_cd", i) <> custCd Then
                    If .Text("chk", i) = "1" Then
                        .Text("chk", i) = "0"
                    End If
                End If
            Next
            For i As Integer = 0 To .RowCount - 1
                If .Text("cust_cd", i) = custCd Then
                    .Text("chk", i) = "1"
                End If
            Next

        End With
    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If
        Dim menuName As String = "SDD100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open7(g10.DataSet)

    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        With g10
            If ColumnName = "chk" Then
                Dim cnt As Integer = 0
                Dim custCd As String
                If ColumnName = "chk" Then
                    If ToBool(Value) Then
                        custCd = .Text("cust_cd")
                        '  동일 거래처  체크
                        For iRow = 0 To .RowCount - 1
                            If custCd <> .Text("cust_cd", iRow) And .ToBool("chk", iRow) Then
                                cnt += 1
                            End If
                        Next
                        If cnt > 0 Then
                            MessageInfo("동일한 매출처만 처리 가능 합니다")
                            .UpdateRow()
                            .Text("chk", RowIndex) = ""
                            Exit Sub

                        End If
                    End If
                End If
            End If
        End With
    End Sub

End Class
