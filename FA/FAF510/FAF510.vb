Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Microsoft.Office.Interop
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel

Public Class FAF510

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        opt1.AddItem("0", "전체")
        opt1.AddItem("1", "집행")
        opt1.AddItem("2", "미집행")

        opt3.AddItem("0", "전체")
        opt3.AddItem("1", "승인")
        opt3.AddItem("2", "미승인")

        opt1.Text = "0"
        opt3.Text = "0"

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Print
                ToExcel()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub Open()

        MyBase.Open()

        Dim a1 As Decimal, a2 As Decimal


        Dim f(1) As String

        f(0) = "ty=sum"
        f(1) = "acc_cd=1110710"
        g20.Find(f)

        a1 = g20.ToDec("amt")

        a2 = g30.ToDec("can_amt")

        g10.Find("ty=sum2")
        g10.Text("doc_amt") = g10.ToDec("doc_amt") + a1 + a2


    End Sub

    Private Sub ToExcel()
        If g10.RowCount <= 0 And g20.RowCount <= 0 And g30.RowCount <= 0 Then Exit Sub

        Dim xlApp As New Application
        xlApp.Application.SheetsInNewWorkbook = 1 '표현할 SHEET개수

        'Instantiating a Workbook object
        Dim xlBook As Workbook = xlApp.Workbooks.Add
        'Obtaining the reference of the first (default) worksheet by passing its sheet index
        Dim xlSheet As Worksheet = xlBook.ActiveSheet
        xlSheet.Name = "일일 자금집행 계획서"

        'Setting the scaling factor to 100
        xlSheet.PageSetup.Zoom = 88

        Dim TotRow As Integer = 0
        Try
            Cursor.Current = Cursors.WaitCursor
            ''xlSheet.Paste() 'ClipBoard정보를 반영
            ''Cell Color Idx Color Print
            'Dim CellStr As String = ""
            'Dim Cells As String = ""
            'For Row As Integer = 1 To 56
            '    CellStr = "A" + Row.ToString
            '    Cells = CellStr & ":" & CellStr
            '    Dim GetRange As Range = xlSheet.Range(CellStr, CellStr)
            '    GetRange.FormulaR1C1 = Row
            '    xlSheet.Range(Cells).Select()
            '    With xlApp.Selection.Interior
            '        .ColorIndex = Row 'red
            '        .Pattern = 1
            '        .PatternColorIndex = -4105
            '    End With
            'Next

            RtpTitle(xlApp)
            TotRow = 8
            '현금과 예금 전일잔액
            Dim Cel1 As String = "A", Cel2 As String = "Q"
            SetCellWidth(xlApp.Sheets(1))

            With g30
                DataHeader(xlApp, "현금과 예금 전일잔액", TotRow)
                TotRow += 1
                Cel1 = "A" & TotRow : Cel2 = "E" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "계 정 과 목", True, True, True, , , 9)

                Cel1 = "F" & TotRow : Cel2 = "I" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "계 좌 번 호", True, True, True, , , 9)

                Cel1 = "J" & TotRow : Cel2 = "N" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "은    행", True, True, True, , , 9)

                Cel1 = "O" & TotRow : Cel2 = "Q" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "잔    액", True, True, True, , , 9)
                TotRow += 1

                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        Select Case .Text("ty", Row)
                            Case "row" 'Data
                                Data(xlApp, .Text("dsc", Row), _
                                              .Text("dsc2", Row), _
                                              .Text("dsc3", Row), _
                                              .ToDec("end_amt", Row), _
                                               TotRow)
                                TotRow += 1
                            Case "sub", "sum" '소계, 총계
                                SubTot(xlApp, .Text("dsc", Row), _
                                       .ToDec("end_amt", Row), _
                                       TotRow)
                                TotRow += 1
                        End Select
                    End If
                Next
            End With

            '받을어음 잔액 / 당일만기 지급어음
            With g20
                DataHeader(xlApp, "받을어음 잔액 / 당일만기 지급어음", TotRow)
                TotRow += 1
                Cel1 = "A" & TotRow : Cel2 = "C" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "구    분", True, True, True, , , 9)

                Cel1 = "D" & TotRow : Cel2 = "G" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "어 음 번 호", True, True, True, , , 9)

                Cel1 = "H" & TotRow : Cel2 = "I" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "만기일", True, True, True, , , 9)

                Cel1 = "J" & TotRow : Cel2 = "N" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "거  래  처", True, True, True, , , 9)

                Cel1 = "O" & TotRow : Cel2 = "Q" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "금    액", True, True, True, , , 9)
                TotRow += 1

                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        Select Case .Text("ty", Row)
                            Case "row" 'Data
                                Data2(xlApp, .Text("acc_nm", Row), _
                                              .Text("mng_no", Row), _
                                              .Text("end_dt", Row), _
                                              .Text("cust_nm", Row), _
                                              .ToDec("amt", Row), _
                                               TotRow)
                                TotRow += 1

                            Case "sub", "sum" '소계, 총계
                                SubTot2(xlApp, .Text("acc_nm", Row), _
                                       .ToDec("amt", Row), _
                                       TotRow)
                                TotRow += 1

                        End Select
                    End If
                Next

            End With

            '입금 / 출금 계획
            With g10
                DataHeader(xlApp, "입금 / 출금 계획", TotRow)
                TotRow += 1
                Cel1 = "A" & TotRow : Cel2 = "B" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "입출구분", True, True, True, , , 9)

                Cel1 = "C" & TotRow : Cel2 = "F" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "계 정 과 목", True, True, True, , , 9)

                Cel1 = "G" & TotRow : Cel2 = "K" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "적    요", True, True, True, , , 9)

                Cel1 = "L" & TotRow : Cel2 = "N" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "금    액", True, True, True, , , 9)

                Cel1 = "O" & TotRow : Cel2 = "Q" & TotRow
                CellStyle(xlApp, Cel1, Cel2, "거  래  처", True, True, True, , , 9)
                TotRow += 1
                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        Select Case .Text("ty", Row)
                            Case "row" 'Data
                                Data3(xlApp, .Text("pay_bc", Row), _
                                              .Text("acc_nm", Row), _
                                              .Text("dsc", Row), _
                                              .Text("cust_nm", Row), _
                                              .ToDec("doc_amt", Row), _
                                               TotRow)
                                TotRow += 1

                            Case "sub" '합계
                                SubTot3_2(xlApp, .Text("pay_bc", Row), _
                                       .ToDec("doc_amt", Row), _
                                       TotRow)
                                TotRow += 1

                            Case "sum" '총계
                                SubTot4(xlApp, .Text("pay_bc", Row), _
                                       .ToDec("doc_amt", Row), _
                                       TotRow)
                                TotRow += 1

                            Case "sum2" '예상가용잔액
                                SubTot5(xlApp, .Text("pay_bc", Row), _
                                       .ToDec("doc_amt", Row), _
                                       TotRow)
                                TotRow += 1

                        End Select
                    End If
                Next
            End With

            xlSheet.Range("A1:A1").Select()
            xlApp.Visible = True
            'xlBook.Close()

            releaseObject(xlApp)
            releaseObject(xlBook)
            releaseObject(xlSheet)

        Catch ex As Exception

            xlBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlBook)
            releaseObject(xlSheet)

            KillExcel()
            MessageError(ex)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub RtpTitle(GetxlApp As Application)
        MainTitle(GetxlApp) '일일자급집행 계획서
        SubTitle(GetxlApp.Worksheets(1)) '조회기간
        Sign(GetxlApp) '결재란
    End Sub

#Region "Title"
    Private Sub SetCellWidth(GetSheet As Worksheet)
        Try
            GetSheet.Rows("1:1").rowheight = 21.75
            GetSheet.Rows("2:2").rowheight = 13.5
            GetSheet.Rows("3:3").rowheight = 12
            GetSheet.Rows("4:4").rowheight = 13.5
            GetSheet.Rows("5:5").rowheight = 9
            GetSheet.Rows("6:6").rowheight = 10.5
            GetSheet.Rows("7:7").rowheight = 21

            Dim GetRange As Range = GetSheet.Range("A1", "C1")
            GetRange.ColumnWidth = 2.75

            GetRange = GetSheet.Range("D1", "D1")
            GetRange.ColumnWidth = 2.0

            GetRange = GetSheet.Range("E1", "E1")
            GetRange.ColumnWidth = 2.75

            GetRange = GetSheet.Range("F1", "F1")
            GetRange.ColumnWidth = 6

            GetRange = GetSheet.Range("G1", "G1")
            GetRange.ColumnWidth = 0.69

            GetRange = GetSheet.Range("H1", "I1")
            GetRange.ColumnWidth = 6

            GetRange = GetSheet.Range("J1", "J1")
            GetRange.ColumnWidth = 8.25

            GetRange = GetSheet.Range("K1", "K1")
            GetRange.ColumnWidth = 7.13

            GetRange = GetSheet.Range("L1", "Q1")
            GetRange.ColumnWidth = 5.25

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub MainTitle(GetxlApp As Application)
        Try
            CellStyle(GetxlApp, "E3", "J4", GetxlApp.Worksheets(1).Name, True, True, , , "바탕체", 18)
        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Sub SubTitle(GetSheet As Worksheet)
        Try

            Dim GetRange As Range = GetSheet.Range("A7", "D7")
            GetRange.Merge()
            GetRange.FormulaR1C1 = std_dt.Text.Substring(0, 4) & "년 " & std_dt.Text.Substring(5, 2) & "월 " & std_dt.Text.Substring(8, 2) & "일"
            GetRange.HorizontalAlignment = 2 '4오른쪽정렬, 3 '중앙정렬, 2 '왼쪽정렬
            GetRange.Font.Name = "바탕체"
            GetRange.Font.Size = 8

            'CellMerge(GetSheet, "C5:D5")
            'GetRange = GetSheet.Range("C5", "D5")
            'GetRange.FormulaR1C1 = std_dt.Text.Substring(0, 4) & "년 " & std_dt.Text.Substring(5, 2) & "월 " & std_dt.Text.Substring(8, 2) & "일"
            'GetRange.HorizontalAlignment = 2 '왼쪽정렬

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Sign(GetxlApp As Application)
        Try

            CellStyle(GetxlApp, "L2", "M3", "기 안", True, True, True, , "바탕체", 11)
            CellStyle(GetxlApp, "L4", "M7", "", True, True, True)

            CellStyle(GetxlApp, "N2", "O3", "검 토", True, True, True, , "바탕체", 11)
            CellStyle(GetxlApp, "N4", "O7", "", True, True, True)

            CellStyle(GetxlApp, "P2", "Q3", "승 인", True, True, True, , "바탕체", 11)
            CellStyle(GetxlApp, "P4", "Q7", "", True, True, True)

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub
#End Region

#Region "Data Sheet"
    Private Sub DataHeader(GetApp As Application, Title As String, Row As Integer)
        Dim Cel1 As String = "A" & Row, Cel2 As String = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Title, True, True, True, 1, , 10)
    End Sub

#Region "현금과 예금 전일잔액"
    Private Sub Data(GetApp As Application, Dsc As String, Bank As String, No As String, _
                                    Amt As Double, _
                                    Row As Integer)

        Dim Cel1 As String = "A" & Row, Cel2 As String = "E" & Row

        '계정과목
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, , , 8)

        '계좌번호
        Cel1 = "F" & Row : Cel2 = "I" & Row
        CellStyle(GetApp, Cel1, Cel2, No, True, True, True, , , 8)

        '은행
        Cel1 = "J" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, Bank, True, , True, , , 8)

        '잔액
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, , True, , , 8)

    End Sub

    Private Sub SubTot(GetApp As Application, Dsc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "E" & Row

        '계정과목
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, 2, , 9)

        '계좌번호
        Cel1 = "F" & Row : Cel2 = "I" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '은행
        Cel1 = "J" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '잔액
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 2, , 9)

    End Sub
#End Region

#Region "받을어음 잔액 / 당일만기 지급어음"
    Private Sub Data2(GetApp As Application, Dsc As String, MngNo As String, EndDt As String, CustNm As String, _
                                    Amt As Double, _
                                    Row As Integer)

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '구분
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, , , 8)

        '어음번호
        Cel1 = "D" & Row : Cel2 = "G" & Row
        CellStyle(GetApp, Cel1, Cel2, MngNo, True, True, True, , , 8)

        '만기일
        Cel1 = "H" & Row : Cel2 = "I" & Row
        CellStyle(GetApp, Cel1, Cel2, EndDt, True, True, True, , , 8)

        '거래처
        Cel1 = "J" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, CustNm, True, , True, , , 8)

        '금액
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, , True, , , 8)

    End Sub

    Private Sub SubTot2(GetApp As Application, Dsc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '계정과목
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, 2, , 9)

        '어음번호
        Cel1 = "D" & Row : Cel2 = "G" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '만기일
        Cel1 = "H" & Row : Cel2 = "I" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '거래처
        Cel1 = "J" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '금액
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 2, , 9)

    End Sub
#End Region

#Region "입금 / 출금 계획"
    Private Sub Data3(GetApp As Application, PayBc As String, AccNm As String, Dsc As String, CustNm As String, _
                                    Amt As Double, _
                                    Row As Integer)

        Dim Cel1 As String = "A" & Row, Cel2 As String = "B" & Row

        '입출구분
        CellStyle(GetApp, Cel1, Cel2, PayBc, True, True, True, , , 8)

        '계정과목
        Cel1 = "C" & Row : Cel2 = "F" & Row
        CellStyle(GetApp, Cel1, Cel2, AccNm, True, True, True, , , 8)

        '적요
        Cel1 = "G" & Row : Cel2 = "K" & Row
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, , True, , , 8)

        '금액
        Cel1 = "L" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, , True, , , 8)

        '거래처
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, CustNm, True, , True, , , 8)

    End Sub

    Private Sub SubTot3(GetApp As Application, PayBc As String, Dsc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '입출구분
        CellStyle(GetApp, Cel1, Cel2, PayBc, True, True, True, 2, , 9)

        '계정과목
        Cel1 = "D" & Row : Cel2 = "G" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '적요
        Cel1 = "J" & Row : Cel2 = "H" & Row
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, 2, , 9)

        '금액
        Cel1 = "I" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 2)

        '거래처
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

    End Sub


    Private Sub SubTot3_2(GetApp As Application, PayBc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "K" & Row
        '계정과목
        CellStyle(GetApp, Cel1, Cel2, PayBc, True, True, True, 2, , 9)

        '금액
        Cel1 = "L" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 2, , 9)

        '거래처
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

    End Sub

    Private Sub SubTot4(GetApp As Application, PayBc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "K" & Row

        '계정과목
        CellStyle(GetApp, Cel1, Cel2, PayBc, True, True, True, 2, , 9)

        '금액
        Cel1 = "L" & Row : Cel2 = "N" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 2, , 9)

        '거래처
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)
    End Sub

    Private Sub SubTot5(GetApp As Application, Dsc As String, _
                                        Amt As Double, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "N" & Row

        '계정과목
        CellStyle(GetApp, Cel1, Cel2, Dsc, True, True, True, 1, , 10)

        '금액
        Cel1 = "O" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Amt, True, True, True, 1, , 10)

    End Sub
#End Region

#End Region

    Private Sub CellMerge(GetSheet As Worksheet, Across As String)
        'Merge some Cells (C6:E7) into a single C6 Cell.
        GetSheet.Range(Across).MergeCells = True
    End Sub

    Private Sub CellMerge(GetSheet As Worksheet, Row As Integer, Col As Integer, Row2 As Integer, Col2 As Integer)

        GetSheet.Range(GetSheet.Cells(Row, Col), GetSheet.Cells(Row2, Col2)).Merge()

    End Sub

    Private Sub CellStyle(GetApp As Application, _
                                Cell1 As String, Cell2 As String, _
                                Title As String, _
                                Optional MergeTy As Boolean = False, _
                                Optional CellCenter As Boolean = False, _
                                Optional Line As Boolean = False, _
                                Optional CellColorNo As Integer = 0, _
                                Optional FntNm As String = "바탕체", _
                                Optional FntSize As Single = 11, _
                                Optional FntBold As Boolean = False, _
                                Optional FntItalic As Boolean = False, _
                                Optional FomulaStr As String = "")

        Dim GetSheet As Worksheet = GetApp.Worksheets(1)
        Dim GetRange As Range = GetSheet.Range(Cell1, Cell2)
        Dim Cells As String = Cell1 & ":" & Cell2
        If MergeTy Then GetRange.Merge()

        If CellCenter Then
            GetRange.HorizontalAlignment = 3 '2:왼쪽정렬, 3:중앙정렬, 4:오른쪽정렬
            GetRange.VerticalAlignment = 2 '2:중앙정렬
        End If

        If Title <> "" Then
            GetRange.FormulaR1C1 = Title
            If IsNumeric(Title) Then
                GetRange.NumberFormat = "#,###"
                GetRange.HorizontalAlignment = 4
            End If
            If IsDate(Title) Then
                GetRange.NumberFormat = "yyyy년MM월dd일"
                'GetRange.HorizontalAlignment = 3
            End If
        End If

        If FntNm = "" Then FntNm = "Times New Roman"
        GetRange.Font.Name = FntNm
        If ToDec(FntSize) = 0 Then FntSize = 8
        GetRange.Font.Size = FntSize
        GetRange.Font.Bold = FntBold
        GetRange.Font.Italic = FntItalic

        If FomulaStr <> "" Then
            GetRange.FormulaR1C1 = FomulaStr
        End If

        If CellColorNo > 0 Then
            Dim ColorNo As Integer = 0

            Select Case CellColorNo
                Case 1
                    ColorNo = 15
                    'GetSheet.Range(Cell1).Borders.Color = Color.DarkGray
                Case 2
                    ColorNo = 40
                    'GetSheet.Range(Cell1).Borders.Color = Color.LightSalmon
                Case 3
                    ColorNo = 38
                    'GetSheet.Range(Cell1).Borders.Color = Color.Violet
            End Select

            GetSheet.Range(Cells).Select()
            With GetApp.Selection.Interior
                .ColorIndex = ColorNo 'red
                .Pattern = 1
                .PatternColorIndex = -4105
            End With

        End If

        If Line Then

            GetRange.BorderAround(Excel.XlLineStyle.xlContinuous, _
                                    Excel.XlBorderWeight.xlThin, _
                                    Excel.XlColorIndex.xlColorIndexAutomatic, _
                                    Excel.XlColorIndex.xlColorIndexAutomatic)


            ''Setting the line style of the top border
            ''GetStyle.Borders(BorderType.TopBorder).LineStyle = CellBorderType.Thick
            'GetStyle.Borders(3).LineStyle = 1

            ''Setting the color of the top border
            ''GetStyle.Borders(BorderType.TopBorder).Color = Color.Black

            ''Setting the line style of the bottom border
            ''GetStyle.Borders(BorderType.BottomBorder).LineStyle = CellBorderType.Thick
            'GetStyle.Borders(4).LineStyle = 1

            ''Setting the color of the bottom border
            ''GetStyle.Borders(BorderType.BottomBorder).Color = Color.Black

            ''Setting the line style of the left border
            ''GetStyle.Borders(BorderType.LeftBorder).LineStyle = CellBorderType.Thick
            'GetStyle.Borders(1).LineStyle = 1
            ''Setting the color of the left border
            ''GetStyle.Borders(BorderType.LeftBorder).Color = Color.Black

            ''Setting the line style of the right border
            ''GetStyle.Borders(BorderType.RightBorder).LineStyle = CellBorderType.Thick
            'GetStyle.Borders(2).LineStyle = 1
            ''Setting the color of the right border
            ''GetStyle.Borders(BorderType.RightBorder).Color = Color.Black
        End If

    End Sub

    Private Sub KillExcel()
        Try
            Dim Excel() As Process = Process.GetProcessesByName("excel")
            '[KILL ALL EXCEL PROCESSES]
            For Each Process As Process In Excel
                Process.Kill()
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub FAF510_Disposing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Disposing
        GC.Collect()
    End Sub
End Class
