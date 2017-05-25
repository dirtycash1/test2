Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAL103

    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        'If Not CheckRequired(acc_cd2, ast_no2, doc_dt) Then
        '    Exit Sub
        'End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim loanNo As String = ""

        With g10
            For i As Integer = 0 To g10.RowCount - 1
                If .ToBool("chk", i) Then
                    If .Text("acc_cd", i) = "" Or .Text("acct_no2", i) = "" Then
                        MessageInfo("필수입력항목(계정코드,입금계좌번호)을 입력하세요.")
                        Exit Sub
                    End If
                    loanNo = .Text("loan_no", i)
                End If
            Next
        End With

        g10.SaveValue("ty", "1")

        If Me.Save() Then

            Me.Open()
            g10.Find("loan_no=" + loanNo)

            Me.jump_fab100(g10.Text("doc_no"))
        End If
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
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

    Private _StopEvent As Boolean
    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If _StopEvent Then Exit Sub

        If ColumnName = "chk" And Value = "1" Then

            _StopEvent = True

            With g10
                Dim si As Integer = .RowIndex
                For i As Integer = 0 To .RowCount - 1
                    If RowIndex <> i Then
                        If .Text("chk", i) = "1" Then
                            .Text("chk", i) = "0"
                        End If
                    Else
                        .Text("chk", i) = "1"
                        .UpdateCurrentRow()
                    End If
                Next
                .RowIndex = si 'IIf(0 < si, si - 1, 0)
            End With

            _StopEvent = False
        End If
    End Sub

End Class
