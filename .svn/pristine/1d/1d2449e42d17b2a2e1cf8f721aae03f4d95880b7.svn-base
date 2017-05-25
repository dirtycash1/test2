Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAS102

    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        'If Not CheckRequired(acc_cd2, ast_no2, doc_dt) Then
        '    Exit Sub
        'End If

        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not g10.CheckRequiredCheckedRow("chk") Then
            Exit Sub
        End If

        'With g10
        '    For i As Integer = 0 To g10.RowCount - 1
        '        If .ToBool("chk", i) Then
        '            If .Text("vat_amt", i) = "" Or .Text("tax_bc", i) = "" Or .Text("cust_cd", i) = "" Then
        '                MessageInfo("필수입력항목(부가세,과세구분,거래처)을 입력하세요.")
        '                Exit Sub
        '            End If
        '        End If
        '    Next
        'End With

        g10.SaveValue("ty", "1")
        g10.SaveValue("cdt", Now)

        If Me.Save() Then

            Dim docNo As String, dSet As DataSet

            dSet = Me.OpenDataSet("fas102_work")
            If IsEmpty(dSet) Then
                Exit Sub
            End If

            docNo = DataValue(dSet)

            If docNo <> "" Then
                Me.Open()
                g10.Find("doc_no=" + docNo)

                Me.jump_fab100(docNo)
            End If

        End If
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g10.SaveValue("ty", "2")

        If Me.Save() Then
            Me.Open()
        End If

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Me.jump_fab100(g10.Text("doc_no"))
    End Sub

    Private Sub jump_fab100(ByVal docNo As String)
        Dim menuName As String = "FAB100"
        With g10
            If docNo = "" Then
                MessageInfo("연결된 전표가 없습니다.")
                Exit Sub
            End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(docNo)
            End If
        End With
    End Sub

End Class
