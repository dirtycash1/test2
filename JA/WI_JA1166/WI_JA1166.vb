Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_JA1166
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        Me.Clear()
    End Sub
    Private Sub Clear()
        p.Clear()
        p.Add("@fr_dt", "2000-01-01")
        p.Add("@to_dt", "2000-01-01")


        Me.Open("WI_JA1166", p)
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save

                If Not Saves() Then Exit Sub

            Case MenuType.Cancel
                Me.Clear()

            Case MenuType.Confirm
                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm

                If Not DeConFrim() Then Exit Sub


            Case MenuType.Find


            Case MenuType.Delete



            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        g_body.AddNewRow()
    End Sub

    Private Function Max_NO() As Boolean
        

        '그리드에서 루프를 돌면서 행별로 처리 한다. 
        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Dim str As String = 0
            Dim str2 As String = 0
            For Row As Integer = 0 To g_body.RowCount - 1

                '자동 채번
                p.Clear()
                p.Add("@fr_dt", "wi_ja1165")
                p.Add("@ip_dt", ip_dt.Text)
                Dim dSet As Data.DataSet = Me.OpenDataSet("WI_ja1166_codeno", p)


                If Not IsEmpty(dSet) Then
                    Dim dRow As DataRow, dRows As DataRowCollection
                    dRows = dSet.Tables(0).Rows

                    For Each dRow In dRows
                        str = ToStr(dRow("code"))
                    Next
                End If

                'ip_no가 있다면 가져 오기 ;
                p.Clear()
                p.Add("@JOB_NO", g_body.Text("JOB_NO", Row))
                p.Add("@JOB_SEQ", g_body.Text("JOB_SEQ", Row))
                Dim dSet2 As Data.DataSet = Me.OpenDataSet("WI_JA1166_IPNO", p)


                If Not IsEmpty(dSet2) Then
                    Dim dRow2 As DataRow, dRows2 As DataRowCollection
                    dRows2 = dSet2.Tables(0).Rows

                    For Each dRow2 In dRows2
                        str2 = ToStr(dRow2("IP_NO"))
                    Next
                End If


                If g_body.Text("stts", Row) = "C" Then '상태값 CHECK
                    '  MsgBox("확인된 자료입니다.!")
                    ' Return False
                Else

                    If str2 = Nothing Or str2 = "" Or str2 = "0" Then

                        ' 외주실적 헤더정보를 INSERT 한다.
                        'MsgBox("insert")
                        p.Clear()
                        p.Add("@IP_NO", str)

                        p.Add("@IP_DT", ip_dt.Text)
                        p.Add("@PS_CD", ps_cd.Text)
                        p.Add("@CL_DT", ip_dt.Text)
                        p.Add("@STTS", "S")
                        p.Add("@IP_GU", "6")
                        p.Add("@PR_QTY", g_body.ToDec("IP_QTY", Row))
                        p.Add("@GD_CD", g_body.Text("GD_CD", Row))
                        p.Add("@JOB_NO", g_body.Text("JOB_NO", Row))
                        p.Add("@JOB_QTY", g_body.ToDec("JOB_QTY", Row))
                        p.Add("@BAL_NO", g_body.ToDec("JOB_NO", Row))
                        p.Add("@BAL_SEQ", g_body.ToDec("JOB_SEQ", Row))
                        p.Add("@FWH_CD", FWH_CD.Text)
                        p.Add("@TWH_CD", TWH_CD.Text)
                        p.Add("@JOB_TYPE", "PR0011")
                        p.Add("@BAL_NO", g_body.Text("JOB_NO", Row))
                        p.Add("@INK_LOT_NO", g_body.Text("INK_LOT_NO", Row))

                        Me.Open("WI_JA1166_INSERT2", p)



                        ' 외주실적 디데일정보를 INSERT 한다.
                        p.Clear()
                        p.Add("@IP_NO", str)
                        p.Add("@IP_SEQ", g_body.Text("JOB_SEQ", Row))

                        p.Add("@GD_CD", g_body.Text("GD_CD", Row))
                        p.Add("@LOT_NO", g_body.Text("CH_LOT_NO", Row))
                        p.Add("@IP_QTY", g_body.ToDec("IP_QTY", Row))
                        p.Add("@NG_QTY", g_body.ToDec("NG_QTY", Row))
                        p.Add("@BAL_NO", g_body.Text("JOB_NO", Row))
                        p.Add("@BAL_QTY", g_body.ToDec("JOB_QTY", Row))
                        p.Add("@BAL_SEQ", g_body.ToDec("JOB_SEQ", Row))
                        p.Add("@INK_LOT_NO", g_body.Text("INK_LOT_NO", Row))
                        p.Add("@OUT_NM", g_body.Text("OUT_NM", Row))
                        p.Add("@OUT_MASNO", g_body.Text("OUT_MASNO", Row))
                        p.Add("@OUT_SP1", g_body.Text("OUT_SP1", Row))
                        Me.Open("WI_JA1166_insert", p)




                    Else


                        '외주헤더정보를 UPDATE 한다.
                        'MsgBox("update")
                        p.Clear()
                        p.Add("@IP_NO", str2)

                        p.Add("@IP_DT", ip_dt.Text)
                        p.Add("@PS_CD", ps_cd.Text)
                        p.Add("@SA_CD", g_body.Text("SA_CD", Row))
                        p.Add("@PR_QTY", g_body.ToDec("IP_QTY", Row))
                        p.Add("@INK_LOT_NO", g_body.Text("INK_LOT_NO", Row))

                        Me.Open("WI_JA1166_update", p)

                        '외주디데일정보를 UPDATE 한다. 
                        p.Clear()
                        p.Add("@IP_NO", str2)
                        p.Add("@IP_SEQ", g_body.ToDec("IP_SEQ", Row))

                        p.Add("@IP_QTY", g_body.ToDec("IP_QTY", Row))
                        p.Add("@LOT_NO", g_body.Text("LOT_NO", Row))
                        p.Add("@INK_LOT_NO", g_body.Text("INK_LOT_NO", Row))
                        p.Add("@OUT_NM", g_body.Text("OUT_NM", Row))
                        p.Add("@OUT_MASNO", g_body.Text("OUT_MASNO", Row))
                        p.Add("@OUT_SP1", g_body.Text("OUT_SP1", Row))
                        p.Add("@NG_QTY", g_body.ToDec("NG_QTY", Row))

                        Me.Open("WI_JA1166_update_detail", p)

                    End If

                End If
                str = 0
                str2 = 0
            Next
        End If
        Return True
    End Function

    Private Function Saves() As Boolean

        'If Check_Stts() = "C" Then '상태값 CHECK
        '    MsgBox("확인된 자료입니다.!")
        '    Return False
        'End If

        'If Not Me.totQty() Then
        '    MsgBox("수량을 확인하세요.!")
        '    Return False
        'End If


        ''If job_qty.ToDec < tot_qty.ToDec Then
        ''    MsgBox("합계수량이 지시수량보다 많습니다.!")
        ''    Return False
        ''End If


        'If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
        '    Exit Function
        'Else
        Max_NO()  '전표채번..

        If MyBase.Save() Then
            '        'MyBase.OpenTrigger("wi_sa1120_list")
        End If

        '    stts.Text = "S"
        'End If        '

        'Return True
    End Function

    Private Function ConFrim() As Boolean
        
        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            For Row As Integer = 0 To g_body.RowCount - 1
                '' 체크 한거만 확인 한다. '1
                If g_body.Text("chk", Row) = "1" Then
                    ' 여기서 확인 된거 처리 한다. 

                    p.Clear()
                    p.Add("@ip_no", g_body.Text("ip_no", Row))

                    Dim dSet As Data.DataSet = Me.OpenDataSet("WI_ja1166_stts", p)
                    Dim stts As String = "S"

                    If Not IsEmpty(dSet) Then stts = DataValue(dSet)
                    If stts = "C" Then
                        ' MsgBox(g_body.Text("ip_no", Row))
                        ' MsgBox("확인된 자료입니다.!")
                        'Return False
                    Else

                        ' 확인 처리 한다. 

                        p.Clear()
                        p.Add("@ip_no", g_body.Text("ip_no", Row))
                        p.Add("@stts", "C")

                        Me.Open("WI_ja1166_confirm", p)

                        g_body.Text("@stts", Row) = "C"


                    End If
                End If
            Next
        End If
        ' Me.Open()

        Return True
    End Function

    Private Function DeConFrim() As Boolean
        If MessageYesNo("취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            For Row As Integer = 0 To g_body.RowCount - 1
                '' 체크 한거만 확인 한다. '1
                If g_body.Text("chk", Row) = "1" Then
                    ' 여기서 확인 된거 처리 한다. 

                    p.Clear()
                    p.Add("@ip_no", g_body.Text("ip_no", Row))

                    Dim dSet As Data.DataSet = Me.OpenDataSet("WI_ja1166_stts", p)
                    Dim stts As String = "S"

                    If Not IsEmpty(dSet) Then stts = DataValue(dSet)
                    If stts <> "C" Then
                        '  MsgBox(g_body.Text("ip_no", Row))
                        'MsgBox("확인된 자료가 아닙니다.!")
                        'Return False
                    Else

                        ' 확인 처리 한다. 

                        p.Clear()
                        p.Add("@ip_no", g_body.Text("ip_no", Row))
                        p.Add("@stts", "S")



                        Me.Open("WI_ja1166_confirm", p)

                        g_body.Text("@stts", Row) = "S"


                    End If
                End If
            Next
        End If

        Me.Open()
        Return True
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles print.Click
        If MessageYesNo("품질 CHECK_SHEET를 출력 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            For Row As Integer = 0 To g_body.RowCount - 1
                If g_body.Text("chk", Row) = "1" Then
                    '체크 된거만 출력 됨.
                    Dim pp As OpenParameters = New OpenParameters
                    pp.Clear()
                    pp.Add("@LOT_NO", g_body.Text("CH_LOT_NO", Row))
                    pp.Add("@IP_QTY", g_body.Text("IP_QTY", Row))
                    pp.Add("@IP_NO", g_body.Text("ip_no", Row))
                    System7.ReportView.LoadView("WI_JA1166", "", "WI_JA1166_prints", pp, )
                End If
            Next
        End If

    End Sub

    Private Sub LOT_auto_CheckedChanged(sender As Object, e As System.EventArgs) Handles LOT_auto.CheckedChanged
        Dim tot_qty As Double
        If LOT_auto.Text = "1" Then

            With g_body
                .UpdateRow()
                For i As Integer = 0 To .RowCount - 1
                    g_body.RowIndex = i
                    tot_qty = "1"
                    g_body.Text("chk", g_body.RowIndex) = tot_qty.ToString
                Next
            End With
        Else
            With g_body
                .UpdateRow()
                For i As Integer = 0 To .RowCount - 1
                    g_body.RowIndex = i
                    tot_qty = "0"
                    g_body.Text("chk", g_body.RowIndex) = tot_qty.ToString
                Next
            End With
        End If
    End Sub
End Class





