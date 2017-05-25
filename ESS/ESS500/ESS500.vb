Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class ESS500
    Private Sub pay150_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g40.RecordNavigator = True
        g41.RecordNavigator = True
        g50.RecordNavigator = True
        g60.RecordNavigator = True
        g61.RecordNavigator = True
        g70.RecordNavigator = True
        g71.RecordNavigator = True
        g72.RecordNavigator = True
        Me.Open()
        If g10.Text("cal_yn") = "1" Then
            cal_yn.Text = "정산"
        Else
            cal_yn.Text = "미정산"
        End If

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다

            Case MenuType.Save

                If MyBase.Save() Then

                End If


            Case MenuType.Delete
                'Me.WorkSets("qoz200_f10").DeleteRow()   '특정Workset을 삭제
                'Me.Open()

            Case MenuType.New

            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click



        emp_no.Text = g10.Text("emp_no")
        emp_nm.Text = g10.Text("emp_nm")

        Me.Open()

        g10.Find("emp_no=" + emp_no.Text)


    End Sub
    Private Sub g20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g20.Click

        emp_no.Text = g20.Text("emp_no")
        emp_nm.Text = g20.Text("emp_nm")

        Me.Open()

        g20.Find("emp_no=" + emp_no.Text)


    End Sub


    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub


    Private Sub btn_cal_emp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cal_emp.Click

        Dim p As OpenParameters = New OpenParameters

        p.Add("@app_year", app_year.Text)
        p.Add("@emp_no", emp_no.Text)

        Me.OpenDataSet("ess500_work", p)

        MessageInfo("정산처리 완료 되었습니다.")
        MyBase.Open("ess500_g10")
        MyBase.Open("ess500_g20")
        MyBase.Open("ess500_g30")
        MyBase.Open("ess500_g31")

        g10.Find("emp_no=" + emp_no.Text)
        g20.Find("emp_no=" + emp_no.Text)

    End Sub



    Private Sub btn_pay400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay400.Click



        ' Dim i As Integer

        'For i = 0 To g41.RowCount - 1

        'g41.RowIndex = i
        'g41.SaveValue("chk", "1", False)
        'g41.Update()
        'Next



        If Me.Save("ess500_g41") Then


            '가족 공제 인원 집계
            Dim p As OpenParameters = New OpenParameters

            ''일반회사 
            'p.Add("@app_year", app_year.Text)
            'p.Add("@emp_no", emp_no.Text)


            ' 동서 가족공제 인원 집계 수정된 내용임
            p.Add("@co_f_cd", co_f_cd.Text)
            p.Add("@bs_f_cd", bs_f_cd.Text)
            p.Add("@dept_cd", dept_cd.Text)
            p.Add("@app_year", app_year.Text)
            p.Add("@emp_no", emp_no.Text)

            Me.OpenDataSet("ess500_fmly_sum", p)




            MessageInfo("저장되었습니다.")
            MyBase.Open("ess500_g40")
            MyBase.Open("ess500_g41")


        End If


    End Sub
    Private Sub btn_pay300_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay300.Click



        Dim i As Integer

        For i = 0 To g80.RowCount - 1

            g80.RowIndex = i
            g80.SaveValue("chk", "1", False)
            g80.Update()
        Next



        If Me.Save("ess500_g80") Then
            MessageInfo("저장되었습니다.")
            MyBase.Open("ess500_g80")

        End If


    End Sub

    Private Sub btn_get_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_get_pay.Click

        Dim p As OpenParameters = New OpenParameters

        'Dim i As Integer

        '선택된 행이 있으면  일선택된 행 일괄 급여 가져오기 수행

       p.Add("@app_year", app_year.Text)
        p.Add("@emp_no", g10.Text("emp_no"))

        Me.OpenDataSet("ess500_get_pay", p)

        p.Add("@app_year", app_year.Text)
        p.Add("@emp_no", emp_no.Text)


        Me.OpenDataSet("ess500_get_pay", p)
        MessageInfo("급여 가져오기 완료 되었습니다.")
        MyBase.Open("ess500_g50")

    End Sub

    Private Sub btn_pay_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay_save.Click
        Dim p As OpenParameters = New OpenParameters

        Dim i As Integer

        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then

                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g10.Text("emp_no", i))

                Me.OpenDataSet("ess500_pay_sum", p)
            End If

        Next

        For i = 0 To g20.RowCount - 1

            If g20.Text("chk", i) = "1" Then

                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g10.Text("emp_no", i))

                Me.OpenDataSet("ess500_pay_sum", p)
            End If

        Next

        If Me.Save("ess500_g50") Then

            '급여 집계


            p.Add("@app_year", app_year.Text)
            p.Add("@emp_no", emp_no.Text)

            Me.OpenDataSet("ess500_pay_sum", p)

            MessageInfo("저장되었습니다.")

            MyBase.Open("ess500_g50")

        End If
    End Sub

    Public Sub Open2(ByVal AppYear As String, ByVal EmpNO As String, ByVal EmpNm As String)


        app_year.Text = AppYear
        emp_f_no.Text = EmpNO
        emp_f_nm.Text = EmpNm

        emp_no.Text = EmpNO
        emp_nm.Text = EmpNm

        Me.Open()

    End Sub

    Private Sub chk_all_g10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_g10.CheckedChanged
        Dim i As Integer

        For i = 0 To g10.RowCount - 1

            g10.RowIndex = i
            g10.SaveValue("chk", chk_all_g10.Text, False)
            ' g10.Update()
        Next

    End Sub
    Private Sub chk_all_g20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all_g20.CheckedChanged
        Dim i As Integer

        For i = 0 To g20.RowCount - 1

            g20.RowIndex = i
            g20.SaveValue("chk", chk_all_g20.Text, False)
            ' g20.Update()
        Next

    End Sub

    Private Sub btn_prt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer

        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then
                Dim p As OpenParameters = New OpenParameters
                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g10.Text("emp_no", i))

                Me.OpenDataSet("ess500_work", p)
            End If

        Next

        For i = 0 To g20.RowCount - 1

            If g20.Text("chk", i) = "1" Then
                Dim p As OpenParameters = New OpenParameters
                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g20.Text("emp_no", i))

                Me.OpenDataSet("ess500_work", p)
            End If

        Next
        MessageInfo("일괄 정산처리 완료 되었습니다.")
        MyBase.Open("ess500_g10")
        MyBase.Open("ess500_g20")

    End Sub

    Private Sub g20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g20.Load

    End Sub

    Private Sub btn_cal_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cal_del.Click
        Dim p As OpenParameters = New OpenParameters

        p.Add("@app_year", app_year.Text)
        p.Add("@emp_no", emp_no.Text)

        Me.OpenDataSet("ess500_cancel", p)

        MessageInfo("정산처리가 취소 되었습니다.")
        MyBase.Open("ess500_g10")
        MyBase.Open("ess500_g20")

        g10.Find("emp_no=" + emp_no.Text)
        g20.Find("emp_no=" + emp_no.Text)

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer

        For i = 0 To g10.RowCount - 1

            If g10.Text("chk", i) = "1" Then
                Dim p As OpenParameters = New OpenParameters
                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g10.Text("emp_no", i))

                Me.OpenDataSet("ess500_cancel", p)
            End If

        Next

        For i = 0 To g20.RowCount - 1

            If g20.Text("chk", i) = "1" Then
                Dim p As OpenParameters = New OpenParameters
                p.Add("@app_year", app_year.Text)
                p.Add("@emp_no", g20.Text("emp_no", i))

                Me.OpenDataSet("ess500_cancel", p)
            End If

        Next
        MessageInfo("일괄 정산취소 처리가 완료 되었습니다.")
        MyBase.Open("ess500_g10")
        MyBase.Open("ess500_g20")
    End Sub

End Class
