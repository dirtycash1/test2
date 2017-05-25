Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SDY500

    Public Overrides Sub Open()
        MyBase.Open()
        item_yn.Text = "0"
    End Sub

    Public Overrides Function Save() As Boolean
        g10.UpdateCurrentRow()

        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Function

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

            Open("sdy500_trans")

            MessageInfo("작업이 완료되었습니다")

            Me.Open()
        End If

    End Sub

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
                If .Text("itm_id", i) <> "" And .ToDec("plan_qty", i) <> 0 Then

                    .RowIndex = i   'Open에 Input값(거래처)이 있는 행으로 이동

                    dSet = OpenDataSet("sdy500_price")

                    If IsEmpty(dSet) Then
                        Continue For
                    End If

                    up = ToDec(dSet.Tables(0).Rows(0).Item("up"))
                    .Text("plan_up", i) = up

                    '각월의 금액계산
                    .Text("plan_amt") = .ToDec("plan_qty") * up

                End If
            Next

            .UpdateCurrentRow()

            If 0 < .RowCount Then
                .RowIndex = 0
            End If

        End With

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        If ColumnName = "itm_cd" Then

            For i = 0 To g10.RowCount - 1
                If i <> g10.RowIndex Then

                    If g10.Text("itm_cd", i) = g10.Text("itm_cd", g10.RowIndex) Then
                        MsgBox("선택하신 품목이 이미 등록되어 있습니다.")
                        g10.Text("itm_id", g10.RowIndex) = ""
                        g10.Text("itm_cd", g10.RowIndex) = ""
                        g10.Text("itm_nm", g10.RowIndex) = ""
                        g10.Text("itm_bc", g10.RowIndex) = ""
                        g10.Text("um_bc", g10.RowIndex) = ""
                        Exit Sub
                    End If

                End If
            Next

        End If

    End Sub

End Class
