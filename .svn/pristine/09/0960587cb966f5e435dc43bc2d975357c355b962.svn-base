Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class LEA603

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cust_chk.Text = "1"
        amt_chk.Text = "1"
        g10.ColumnVisible("cust_nm") = True
        'Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save

            Case MenuType.New
                'cust_cd.Text = ""
                'itm_cd.Text = ""
                'itm_nm.Text = ""
                'emp_id.Text = ""
                'emp_nm.Text = ""

                'Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Public Sub Open_Form()

        Me.Init_Title()
        amt_chk.Text = "1"

        If cust_chk.Text = "1" And itm_chk.Text <> "1" Then
            Me.Disp_Data1()
        End If

        If cust_chk.Text <> "1" And itm_chk.Text = "1" Then
            Me.Disp_Data2()
        End If

        If cust_chk.Text = "1" And itm_chk.Text = "1" Then
            Me.Disp_Data3()
        End If

    End Sub

    Public Sub chk_change()

        Me.Init_Title()

        If cust_chk.Text = "1" And itm_chk.Text <> "1" Then
            g10.ColumnVisible("itm_bc") = False
            g10.ColumnVisible("itm_cd") = False
            g10.ColumnVisible("itm_nm") = False
            g10.ColumnVisible("cust_nm") = True
        End If

        If cust_chk.Text <> "1" And itm_chk.Text = "1" Then
            g10.ColumnVisible("cust_nm") = False
            g10.ColumnVisible("itm_bc") = True
            g10.ColumnVisible("itm_cd") = True
            g10.ColumnVisible("itm_nm") = True
        End If

        If cust_chk.Text = "1" And itm_chk.Text = "1" Then
            g10.ColumnVisible("cust_nm") = True
            g10.ColumnVisible("itm_bc") = True
            g10.ColumnVisible("itm_cd") = True
            g10.ColumnVisible("itm_nm") = True
        End If

    End Sub


    Private Sub Init_Title()

        Dim dset As DataSet
        dset = Me.OpenDataSet("lea603_g10")

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_mon.Text + "-01"
        Dim toDt As Date = to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, yyyymm As String, title As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i * 2 + 1)     'Array를 증가시킨다 (수량,금액) 2개씩 생성

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = (i + 1).ToString

            arr(0, i * 2) = yyyymm + "_1"              'FieldName
            arr(1, i * 2) = yyyymm                      'Title

            arr(0, i * 2 + 1) = yyyymm + "_2"          'FieldName
            arr(1, i * 2 + 1) = yyyymm + " (금액)"     'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("tot_amt", arr, "qty")
        'g10.InsertArrayColumns("qty_val", arr, "plan_amt")
    End Sub


    Private Sub Disp_Data1()

        Dim dset As DataSet
        dset = Me.OpenDataSet("lea603_g10")

        If IsEmpty(dset) Then
            MessageInfo("조회 할 Data가 없습니다")
            Exit Sub
        End If

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = "", s2 As String = ""
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                'g10.AllowAddRows = True
                'g10.Editable = True
                'm_StopEvent = True  '쓸데없는 Event방지

                iRow = -1

                For Each dRow In dset.Tables(0).Rows
                    If IsDBNull(dRow("cust_nm")) Then
                        dRow("cust_nm") = ""
                    End If

                    If s1 <> dRow("fac_cd") Or s2 <> dRow("cust_nm") Then

                        'Me.SumRowData() 'Row 합계구하기

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow

                        .Text("fac_cd", iRow) = ToStr(dRow("fac_cd"))
                        .Text("cust_nm", iRow) = ToStr(dRow("cust_nm"))
                        .Text("tot_qty", iRow) = ToStr(dRow("tot_qty"))
                        .Text("tot_amt", iRow) = ToStr(dRow("tot_amt"))
                        '.Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        '.Text("qty_cd", iRow) = ToStr(dRow("qty_cd"))
                        '.Text("qty_val", iRow) = ToStr(dRow("qty_val"))
                        '.Text("spec1", iRow) = ToStr(dRow("spec1"))
                        '.Text("plan_up", iRow) = ToDec(dRow("plan_up"))


                        s1 = ToStr(dRow("fac_cd"))
                        s2 = ToStr(dRow("cust_nm"))

                    End If

                    colNm = ToStr(dRow("std_mon"))

                    .Text(colNm + "_1", iRow) = ToStr(dRow("qty"))
                    .Text(colNm + "_2", iRow) = ToStr(dRow("amt"))

                    iCnt += 1

                    'Parameter.MainFrame.ProgBar.Value = iCnt

                Next

            End With

        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            'Parameter.MainFrame.ProgBar.Visible = False

            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Disp_Data2()

        Dim dset As DataSet
        dset = Me.OpenDataSet("lea603_g10")

        If IsEmpty(dset) Then
            MessageInfo("조회 할 Data가 없습니다")
            Exit Sub
        End If

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = "", s2 As String = ""
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                'g10.AllowAddRows = True
                'g10.Editable = True
                'm_StopEvent = True  '쓸데없는 Event방지

                iRow = -1

                For Each dRow In dset.Tables(0).Rows
                    'If IsDBNull(dRow("cust_nm")) Then
                    '    dRow("cust_nm") = ""
                    'End If

                    If s1 <> dRow("fac_cd") Or s2 <> dRow("itm_cd") Then

                        'Me.SumRowData() 'Row 합계구하기

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow

                        .Text("fac_cd", iRow) = ToStr(dRow("fac_cd"))
                        .Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        .Text("itm_cd", iRow) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", iRow) = ToStr(dRow("itm_nm"))
                        .Text("tot_qty", iRow) = ToStr(dRow("tot_qty"))
                        .Text("tot_amt", iRow) = ToStr(dRow("tot_amt"))
                        '.Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        '.Text("qty_cd", iRow) = ToStr(dRow("qty_cd"))
                        '.Text("qty_val", iRow) = ToStr(dRow("qty_val"))
                        '.Text("spec1", iRow) = ToStr(dRow("spec1"))
                        '.Text("plan_up", iRow) = ToDec(dRow("plan_up"))


                        s1 = ToStr(dRow("fac_cd"))
                        s2 = ToStr(dRow("itm_cd"))

                    End If

                    colNm = ToStr(dRow("std_mon"))

                    .Text(colNm + "_1", iRow) = ToStr(dRow("qty"))
                    .Text(colNm + "_2", iRow) = ToStr(dRow("amt"))

                    iCnt += 1

                    'Parameter.MainFrame.ProgBar.Value = iCnt

                Next

            End With

        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            'Parameter.MainFrame.ProgBar.Visible = False

            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub Disp_Data3()

        Dim dset As DataSet
        dset = Me.OpenDataSet("lea603_g10")

        If IsEmpty(dset) Then
            MessageInfo("조회 할 Data가 없습니다")
            Exit Sub
        End If

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dRow As DataRow, colNm As String, s1 As String = "", s2 As String = "", s3 As String = ""
            Dim iRow As Integer, iCnt As Integer

            With g10

                '추가와 쓰기가 가능해야 행이 추가 된다
                'g10.AllowAddRows = True
                'g10.Editable = True
                'm_StopEvent = True  '쓸데없는 Event방지

                iRow = -1

                For Each dRow In dset.Tables(0).Rows
                    If IsDBNull(dRow("cust_nm")) Then
                        dRow("cust_nm") = ""
                    End If

                    If s1 <> dRow("fac_cd") Or s2 <> dRow("cust_nm") Or s3 <> dRow("itm_cd") Then

                        'Me.SumRowData() 'Row 합계구하기

                        g10.AddNewRow()

                        iRow += 1
                        '.Row = iRow

                        .Text("fac_cd", iRow) = ToStr(dRow("fac_cd"))
                        .Text("cust_nm", iRow) = ToStr(dRow("cust_nm"))
                        .Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        .Text("itm_cd", iRow) = ToStr(dRow("itm_cd"))
                        .Text("itm_nm", iRow) = ToStr(dRow("itm_nm"))
                        .Text("tot_qty", iRow) = ToStr(dRow("tot_qty"))
                        .Text("tot_amt", iRow) = ToStr(dRow("tot_amt"))
                        '.Text("itm_bc", iRow) = ToStr(dRow("itm_bc"))
                        '.Text("qty_cd", iRow) = ToStr(dRow("qty_cd"))
                        '.Text("qty_val", iRow) = ToStr(dRow("qty_val"))
                        '.Text("spec1", iRow) = ToStr(dRow("spec1"))
                        '.Text("plan_up", iRow) = ToDec(dRow("plan_up"))


                        s1 = ToStr(dRow("fac_cd"))
                        s2 = ToStr(dRow("cust_nm"))
                        s3 = ToStr(dRow("itm_cd"))

                    End If

                    colNm = ToStr(dRow("std_mon"))

                    .Text(colNm + "_1", iRow) = ToStr(dRow("qty"))
                    .Text(colNm + "_2", iRow) = ToStr(dRow("amt"))

                    iCnt += 1

                    'Parameter.MainFrame.ProgBar.Value = iCnt

                Next

            End With

        Catch ex As Exception
            MessageError(ex, , "Display()")

        Finally
            'Parameter.MainFrame.ProgBar.Visible = False

            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub cust_chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cust_chk.CheckedChanged

        If itm_chk.Text <> "1" Then

            cust_chk.Text = "1"

        End If

        Me.chk_change()

    End Sub


    Private Sub itm_chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles itm_chk.CheckedChanged

        If cust_chk.Text <> "1" Then

            itm_chk.Text = "1"

        End If

        Me.chk_change()

    End Sub

    Private Sub amt_chk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles amt_chk.CheckedChanged

        For j As Integer = 0 To g10.ColumnCount - 1
            If g10.FieldName(j).EndsWith("_2") Then
                g10.ColumnVisible(j) = amt_chk.Checked
            End If
        Next

    End Sub



End Class
