Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections

Public Class WP_TR2103
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)
        'Me.Clear()
        NEW_OPEN()
        setPercent1()
        setPercent2()
        setPercent3()
        setPercent4()
        set_Sum()
        Me.Open()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                NEW_OPEN()
                setPercent1()
                setPercent2()
                setPercent3()
                setPercent4()
                set_Sum()
                Me.Open()

            Case MenuType.Cancel

                Me.Clear()
                'Case MenuType.New
                '    New_Form()

            Case MenuType.Save

                If Not Saves() Then Exit Sub

                'Case MenuType.Confirm
                '    If Not ConFrim() Then Exit Sub

                'Case MenuType.Deconfirm
                '    If Not DeConFrim() Then Exit Sub

                'Case MenuType.Find
                '    Me.Find()
                'Case MenuType.Delete
                '    Me.Del()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@mon_dt", "2000-01-01")
        Me.Open("wp_tr2103_g10", p)

    End Sub

    Private Function Saves() As Boolean

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            setPercent1()
            setPercent2()
            setPercent3()
            setPercent4()

            If MyBase.Save() Then

                NEW_OPEN()
                setPercent1()
                setPercent2()
                setPercent3()
                setPercent4()
                set_Sum()
                Me.Open()

                'With g10
                '    .UpdateRow()
                '    For i As Integer = 0 To .RowCount - 1
                '        'p_sum1.Text = 
                '        ''.Text("TUIP_QTY", i) = .ToDec("SO_QTY", i) * pr_qty.ToDec
                '    Next
                'End With
            End If

        End If

            Return True
    End Function

    Private Sub NEW_OPEN()
        p.Clear()
        p.Add("@mon_dt", mon_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_title", p)
        Dim dRow As DataRow, dRows As DataRowCollection
        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows

            EPanel2.Text = "1주차(" + ToStr(dRow("FIRST1")) + "~" + ToStr(dRow("LAST1")) + ")"
            EPanel4.Text = "2주차(" + ToStr(dRow("FIRST2")) + "~" + ToStr(dRow("LAST2")) + ")"
            EPanel3.Text = "3주차(" + ToStr(dRow("FIRST3")) + "~" + ToStr(dRow("LAST3")) + ")"
            EPanel5.Text = "4주차(" + ToStr(dRow("FIRST4")) + "~" + ToStr(dRow("LAST4")) + ")"

        Next

        mon_dt1.Text = Mid(EPanel2.Text, 10, 8) + "01"
        gigan_dt1.Text = Mid(EPanel2.Text, 10, 21)
        mon_dt2.Text = Mid(EPanel4.Text, 10, 8) + "01"
        gigan_dt2.Text = Mid(EPanel4.Text, 10, 21)
        mon_dt3.Text = Mid(EPanel3.Text, 10, 8) + "01"
        gigan_dt3.Text = Mid(EPanel3.Text, 10, 21)
        mon_dt4.Text = Mid(EPanel5.Text, 10, 8) + "01"
        gigan_dt4.Text = Mid(EPanel5.Text, 10, 21)

    End Sub


    Private Sub setPercent1()

        'If pr_jobno.Text = Nothing Then Exit Sub
        'If gong_cd.Text = Nothing Then Exit Sub
        'Dim s_pr_jobno As String = "", s_gong_cd As String = ""

        p.Clear()
        p.Add("@week_no", "1주차")
        p.Add("@mon_dt", mon_dt1.Text)
        p.Add("@gigan_dt", gigan_dt1.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_p_sum", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                p_sum1.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            'Me.Clear()
            Exit Sub
        End If

        'format("########")

        p.Clear()
        p.Add("@week_no", "1주차")
        p.Add("@mon_dt", mon_dt1.Text)
        p.Add("@gigan_dt", gigan_dt1.Text)

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wp_tr2103_ch_sum", p)

        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows

            For Each dRow In dRows
                ch_sum1.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            'Me.Clear()
            Exit Sub
        End If

    End Sub



    Private Sub setPercent2()

        p.Clear()
        p.Add("@week_no", "2주차")
        p.Add("@mon_dt", mon_dt2.Text)
        p.Add("@gigan_dt", gigan_dt2.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_p_sum", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                p_sum2.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

        p.Clear()
        p.Add("@week_no", "2주차")
        p.Add("@mon_dt", mon_dt2.Text)
        p.Add("@gigan_dt", gigan_dt2.Text)

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wp_tr2103_ch_sum", p)

        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows

            For Each dRow In dRows
                ch_sum2.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

    End Sub


    Private Sub setPercent3()

        p.Clear()
        p.Add("@week_no", "3주차")
        p.Add("@mon_dt", mon_dt3.Text)
        p.Add("@gigan_dt", gigan_dt3.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_p_sum", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                p_sum3.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

        p.Clear()
        p.Add("@week_no", "3주차")
        p.Add("@mon_dt", mon_dt3.Text)
        p.Add("@gigan_dt", gigan_dt3.Text)

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wp_tr2103_ch_sum", p)

        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows

            For Each dRow In dRows
                ch_sum3.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

    End Sub


    Private Sub setPercent4()

        p.Clear()
        p.Add("@week_no", "4주차")
        p.Add("@mon_dt", mon_dt4.Text)
        p.Add("@gigan_dt", gigan_dt4.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_p_sum", p)

        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                p_sum4.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

        p.Clear()
        p.Add("@week_no", "4주차")
        p.Add("@mon_dt", mon_dt4.Text)
        p.Add("@gigan_dt", gigan_dt4.Text)

        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wp_tr2103_ch_sum", p)

        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows

            For Each dRow In dRows
                ch_sum4.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

    End Sub



    '주문금액, 주문수량, 출하금액, 포장완료대기 합계 
    Private Sub set_Sum()

        '총 주문금액
        p.Clear()
        p.Add("@mon_dt", mon_dt1.Text)
        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2103_odamt", p)
        If Not IsEmpty(dSet) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet.Tables(0).Rows
            For Each dRow In dRows
                od_amt.Text = ToStr(Math.Round(dRow("SUM_OD_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

        '총주문수량
        p.Clear()
        p.Add("@mon_dt", mon_dt1.Text)
        Dim dSet2 As Data.DataSet = Me.OpenDataSet("wp_tr2103_odqty", p)
        If Not IsEmpty(dSet2) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet2.Tables(0).Rows
            For Each dRow In dRows
                od_qty.Text = ToStr(Math.Round(dRow("SUM_OD_QTY"), 0))
            Next
        Else
            Exit Sub
        End If

        '총 포장완료대기 금액
        p.Clear()
        p.Add("@mon_dt", mon_dt1.Text)
        Dim dSet3 As Data.DataSet = Me.OpenDataSet("wp_tr2103_wait", p)

        If Not IsEmpty(dSet3) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet3.Tables(0).Rows
            For Each dRow In dRows
                wait_amt.Text = ToStr(Math.Round(dRow("WAIT_AMT"), 0))
            Next
        Else
            Exit Sub
        End If

        '총 포장완료대기 금액
        p.Clear()
        p.Add("@mon_dt", mon_dt1.Text)
        Dim dSet4 As Data.DataSet = Me.OpenDataSet("wp_tr2103_chamt", p)

        If Not IsEmpty(dSet4) Then
            Dim dRow As DataRow, dRows As DataRowCollection
            dRows = dSet4.Tables(0).Rows
            For Each dRow In dRows
                chul_amt.Text = ToStr(Math.Round(dRow("CH_AMT"), 0))
            Next
        Else
            Exit Sub
        End If



    End Sub





End Class