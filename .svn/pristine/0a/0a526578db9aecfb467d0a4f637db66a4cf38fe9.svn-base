Imports System.Data
Imports Base7.Shared

Public Class frmMessage

    Public Sub AddLine(ByVal sMsg As String)
        RichTextBox1.Text += sMsg & vbLf
    End Sub

    Public Sub SetDataSet(ByVal dSet As DataSet)
        Dim iCol As Integer, sMsg As String
        Dim dRow As DataRow, dRows As DataRowCollection
        dRows = dSet.Tables(0).Rows
        For Each dRow In dRows
            sMsg = ""
            For iCol = 0 To dRow.ItemArray.Length - 1
                sMsg &= ToStr(dRow(iCol)) + vbTab
            Next
            RichTextBox1.Text += sMsg & vbLf
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

End Class