Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM500


    Private Sub FAM500_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Open()

        '구매발주번호 자동채번 설정
        'po_no.CodeNo = "FAM500"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'po_no.CodeDateField = po_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If Not CheckRequired(bud_yy, bud_bc, co_cd, dept_cd) Then
                    Exit Sub
                End If

                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If Not CheckRequired(bud_yy, bud_bc, co_cd, dept_cd) Then
                    Exit Sub
                End If

                If MyBase.Save() Then
                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New

                Me.WorkSets("fam500_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub SumRowData()
        Dim s1 As Decimal

        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("_amt") And g10.FieldName(j).StartsWith("m") Then s1 += g10.ToDec(j)
        Next
        g10.Text("tot_amt") = s1

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        If ColumnName = "tot_amt" Then
            Exit Sub
        End If

        Me.SumRowData()
    End Sub
End Class
