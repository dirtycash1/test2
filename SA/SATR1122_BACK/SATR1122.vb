Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SATR1122
    Dim p As New OpenParameters
    Dim DBNull As Boolean
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.New
                New_Form()
            Case MenuType.Save
                Me.Save()
                Me.Open()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub
    Private Sub New_Form()
        g_multi.AddNewRow()
        g_multi.Focus()
    End Sub
    Public Sub Open_Form()
        Me.Open()
        g_multi.AddNewRow()
    End Sub
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load '첫오픈시, 행추가를 위함.
        p.Clear()
        p.Add("@cust_cd", "")
        p.Add("@map_gu", "")
        p.Add("@emp_no", "")
        p.Add("@od_dt", "")
        Me.OpenDataSet("satr1122_g_multi", p)
        Me.Open()
    End Sub

    Private Sub btn_map_Click(sender As System.Object, e As System.EventArgs) Handles btn_map.Click

        With g_multi
            For i As Integer = 0 To g_multi.RowCount - 1
                p.Clear()
                p.Add("@fc_cd", g_multi.Text("FC_CD", i))   '거래처코드
                Dim dSet1 As Data.DataSet = Me.OpenDataSet("satr1122_map1", p)
                Dim dRow1 As DataRow, dRows1 As DataRowCollection
                dRows1 = dSet1.Tables(0).Rows

                p.Add("@sty_cd", g_multi.Text("STY_CD", i))   '상품코드
                Dim dSet2 As Data.DataSet = Me.OpenDataSet("satr1122_map2", p)
                Dim dRow2 As DataRow, dRows2 As DataRowCollection
                dRows2 = dSet2.Tables(0).Rows

                If IsEmpty(dSet1) Then             '매핑실패
                    g_multi.Text("CS_CD", i) = ""
                    'g_multi.Text("MAP_GU", i) = "0"
                Else
                    For Each dRow1 In dRows1            '매핑성공
                        g_multi.Text("CS_CD", i) = ToStr(dRow1("CS_CD"))
                        'g_multi.Text("MAP_GU", i) = "1"
                    Next
                End If

                If IsEmpty(dSet2) Then
                    g_multi.Text("GD_CD", i) = ""
                Else
                    For Each dRow2 In dRows2
                        g_multi.Text("GD_CD", i) = ToStr(dRow2("GD_CD"))
                    Next
                End If

                If g_multi.Text("GD_CD", i) = "" Or g_multi.Text("CS_CD", i) = "" Then
                    g_multi.Text("MAP_GU", i) = "0"             '매핑실패
                Else
                    g_multi.Text("MAP_GU", i) = "1"             '매핑성공
                End If
            Next

            If MessageYesNo("매핑 완료. 저장하겠습니까?") = MsgBoxResult.No Then
                Exit Sub
            Else
                MyBase.Save()
                MsgBox("저장되었습니다.", vbOKOnly, "저장")
                Me.Open()
            End If

        End With
    End Sub

    'Private Sub fc_div_TextChanged(sender As System.Object, e As System.EventArgs) Handles fc_div.TextChanged
    ' For i As Integer = 0 To g_multi.RowCount - 1
    'g_multi.Text("DIV", i) = fc_div.Text
    'MsgBox("fc_div: " & ToStr(fc_div.Text)
    ' Next
    'End Sub

    Private Sub btn_su_Click(sender As System.Object, e As System.EventArgs) Handles btn_su.Click
        wf_odno()
    End Sub

    Private Function wf_odno() As Integer

        For i As Integer = 0 To g_multi.RowCount - 1
            p.Clear()
            p.Add("@fc_cd", g_multi.Text("FC_CD", i))
            p.Add("@od_dt", g_multi.Text("OD_DT", i))

            Dim dCnt As Data.DataSet = Me.OpenDataSet("satr1122_cnt", p)
            Dim dRow1 As DataRow, dRows1 As DataRowCollection
            dRows1 = dCnt.Tables(0).Rows
            For Each dRow1 In dRows1
                i = i + ToDec(dRow1("cnt")) - 1
            Next

            Dim dSet As Data.DataSet = Me.OpenDataSet("satr1122_same_fc", p)
            Dim dRow As DataRow, dRows As DataRowCollection

            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                p.Clear()
                p.Add("@FC_CD", ToStr(dRow("FC_CD")))
                p.Add("@OD_DT", ToStr(dRow("OD_DT")))
                p.Add("@OD_AMT", ToStr(dRow("OD_AMT")))
                p.Add("@VAT", ToStr(dRow("VAT")))
                p.Add("@SUM_AMT", ToStr(dRow("SUM_AMT")))
                Me.Open("SATR1122_ODNO", p)
            Next
        Next
        MsgBox("수주생성이 완료되었습니다.", vbOKOnly, "수주생성")
        Me.Open()
    End Function

End Class

