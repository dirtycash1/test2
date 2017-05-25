Public Class C_Packing_Other

    Dim DBNull As Object
    Public rowcnt As Integer
    Private Sub Invoice_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AfterPrint
        'Dim rdt As New DevExpress.XtraReports.UI.XRTable
        'rdt = CType(Me.XrTable1, DevExpress.XtraReports.UI.XRTable)


        'For ii As Integer = rowcnt To 8
        '    For jj As Integer = 0 To 5
        '        rdt.Rows(ii).Cells(jj).Text = ""
        '    Next
        'Next

    End Sub

    '데이터 테이블에 행넣기
    Private Sub Invoice_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint

        'Dim dt As New DataTable
        'dt = Me.KrserpDataSet1.Tables(0)
        'rowcnt = dt.Rows.Count

        ''dt = ds.Tables(0)
        'If dt.Rows.Count < 9 Then
        '    For ii As Integer = 0 To (8 - dt.Rows.Count)
        '        Dim dr As DataRow
        '        dr = dt.NewRow()
        '        'dr = dt.Columns
        '        'dr = dt.Rows(0)

        '        For jj As Integer = 0 To dt.Columns.Count - 1
        '            dt.Columns(jj).ReadOnly = False

        '            If jj >= 22 Then
        '                If dt.Columns(jj).DataType.Name.ToString = "String" Then
        '                    dr(jj) = ""
        '                Else
        '                    dt.Columns(jj).AllowDBNull = True
        '                    Dim col As New DataColumn
        '                    dr(jj) = 0
        '                End If
        '            ElseIf jj < 22 Then
        '                dr(jj) = dt.Rows(0)(jj)
        '            End If


        '        Next
        '        'dr("sq") = dt.Rows.Count + 1
        '        ' Me.KrserpDataSet1.Tables(0).NewRow()
        '        '
        '        dt.Rows.Add(dr)
        '    Next
        'ElseIf dt.Rows.Count > 9 Then

        'End If
    End Sub


    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        'SEP210_PrintTableAdapter.Fill(KrserpDataSet1.Tables(0), Me.invoiceno.Value)
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub

    '0인 값들 지우기
    Private Sub XrTableCell8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try

            'If CInt(XrTableCell8.Text.Replace("€", "")) = 0 Then
            '    XrTableCell8.Text = ""
            'End If

        Catch ex As Exception

        End Try
    End Sub

    '0인 값들 지우기
    Private Sub XrTableCell7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'If CInt(XrTableCell7.Text.Replace("€", "")) = 0 Then
            '    XrTableCell7.Text = ""
            'End If

        Catch ex As Exception

        End Try
    End Sub
    '0인 값들 지우기
    Private Sub XrTableCell3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            'If CInt(XrTableCell3.Text.Replace("€", "")) = 0 Then
            '    XrTableCell3.Text = ""
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub XrLabel40_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)

    End Sub
End Class