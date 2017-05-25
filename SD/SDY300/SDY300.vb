Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SDY300

    Public Overrides Sub Open()
        MyBase.Open()
        item_yn.Text = "0"

        Dim dt As Date = plan_mon.Text + "-01"
        g10.BandTitle("m1_qty") = Format(DateAdd(DateInterval.Month, 0, dt), "yyyy-MM")
        g10.BandTitle("m2_qty") = Format(DateAdd(DateInterval.Month, 1, dt), "yyyy-MM")
        g10.BandTitle("m3_qty") = Format(DateAdd(DateInterval.Month, 2, dt), "yyyy-MM")
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

    '단가가져오기
    Private Sub btn_amt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_amt.Click
        Me.GetAmt()
    End Sub

    Private Sub GetAmt()

        '필수 입력항목 누락여부 체크
        If Not CheckRequired(co_cd) Then
            Exit Sub
        End If

        Dim oParams As Object = Nothing
        Dim dSet As DataSet
        With g10

            Dim p As New OpenParameters, up As Decimal
            For i As Integer = 0 To .RowCount - 1
                If .Text("itm_id", i) <> "" And .ToDec("qty_tot", i) <> 0 Then

                    .RowIndex = i   'Open에 Input값(거래처)이 있는 행으로 이동

                    dSet = OpenDataSet("sdy300_price")

                    If IsEmpty(dSet) Then
                        Continue For
                    End If

                    up = ToDec(dSet.Tables(0).Rows(0).Item("up"))
                    .Text("m1_up", i) = up

                    '각월의 금액계산
                    For j As Integer = 0 To .ColumnCount - 1
                        If g10.FieldName(j).EndsWith("_amt") Then
                            .Text(j) = .ToDec(j - 1) * up
                        End If
                    Next

                    Me.SumRowData()

                End If
            Next

            .UpdateCurrentRow()

            If 0 < .RowCount Then
                .RowIndex = 0
            End If

        End With

    End Sub

    Private Sub SumRowData()
        Dim s1 As Decimal, s2 As Decimal
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("_qty") Then s1 += g10.ToDec(j)
            If g10.FieldName(j).EndsWith("_amt") Then s2 += g10.ToDec(j)
        Next
        g10.Text("qty_tot") = s1
        g10.Text("amt_tot") = s2
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If

        If ColumnName.EndsWith("_qty") Or ColumnName.EndsWith("_amt") Then
            Me.SumRowData()
        End If

        With g10
            If ColumnName = "m1_up" Or ColumnName.EndsWith("_qty") Then
                .Text("m1_amt") = .ToDec("m1_qty") * .ToDec("m1_up")
                .Text("m2_amt") = .ToDec("m2_qty") * .ToDec("m1_up")
                .Text("m3_amt") = .ToDec("m3_qty") * .ToDec("m1_up")
            End If
        End With

    End Sub

    Private Sub btn_trans_Click(sender As System.Object, e As System.EventArgs) Handles btn_trans.Click

        '품목가져오기 여부
        If trans_bc.Text.EndsWith("SDZ1") Then
            item_yn.Text = "1"  '품목가져오기 여부

            If Not CheckRequired(cust_cd) Then
                Exit Sub
            End If

            If g10.DataChanged Then
                Select Case MessageYesNoCancel("현재 작업중인 정보를 저장하시겠습니까 ?")
                    Case MsgBoxResult.Cancel
                        Exit Sub
                    Case MsgBoxResult.Yes
                        If Not Me.Save() Then
                            Exit Sub
                        End If
                End Select
            End If

            Me.Open()
        Else
            '그 외는 가져오기 공용 SP를 사용한다
            If MessageYesNo("기존 계획은 삭제되고 새로 작성됩니다." & vbLf & vbLf & "작성 하시겠습니까 ?") = MsgBoxResult.No Then
                Exit Sub
            End If

            Open("sdy300_trans")

            MessageInfo("작업이 완료되었습니다")

            Me.Open()
        End If

    End Sub

    Private Sub show_bc_TextChanged(sender As Object, e As System.EventArgs) Handles show_bc.TextChanged
        Dim all As Boolean = False
        If show_bc.Text = "" Then
            all = True
        End If
        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("&plan_qty") Then
                g10.ColumnVisible(j) = (all Or show_bc.Text.Contains("qty"))
            End If
            If g10.FieldName(j).EndsWith("&plan_amt") Then
                g10.ColumnVisible(j) = (all Or show_bc.Text.Contains("amt"))
            End If
        Next
    End Sub

End Class
