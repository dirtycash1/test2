Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEA200


    Private Sub LEA200_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

        '자재 출고 번호 채번
        out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then

                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("lea200_g10").AddNew()  '특정Workset 신규처리
                out_no.Text = ""
                MyBase.Open()
            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim StockQty As Integer

        If ColumnName = "out_qty" Then
            StockQty = g10.ToDec("stock_qty")
            If Value > 0 Then
                If (StockQty) < Value Then
                    MsgBox("현재고량 보다 출고수량이 많습니다")
                    g10.Text("out_qty") = 0
                    Exit Sub
                End If
            End If
        End If

    End Sub
End Class
