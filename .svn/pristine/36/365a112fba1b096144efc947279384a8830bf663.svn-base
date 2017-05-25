Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Microsoft.Office.Interop
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel

Public Class FAF500_KRS

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Print
                ToExcel()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub ToExcel()
        If g10.RowCount <= 0 Then Exit Sub

        Dim xlApp As New Application
        xlApp.Application.SheetsInNewWorkbook = 1 '표현할 SHEET개수

        'Instantiating a Workbook object
        Dim xlBook As Workbook = xlApp.Workbooks.Add
        'Obtaining the reference of the first (default) worksheet by passing its sheet index
        Dim xlSheet As Worksheet = xlBook.ActiveSheet
        xlSheet.Name = g10.WorkSet.Name

        'Setting the scaling factor to 100
        xlSheet.PageSetup.Zoom = 88


        Try
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
            Cursor.Current = Cursors.WaitCursor

            SetCellWidth(xlApp.Sheets(1))
            RtpTitle(xlApp)

            With g10
                Dim Row2 As Integer = 8, DataStart As Integer = 0, DataEnd As Integer = 0, SubColums As String = "", TotColums As String = ""
                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        Select Case .Text("ty", Row)
                            Case "grp" 'Data MainTitle
                                DataHeader(xlApp, .Text("dsc", Row), Row + Row2)
                                Row2 += 1
                                DataStart = Row + Row2 + 1

                            Case "row" 'Data
                                Data(xlApp, .Text("dsc", Row), _
                                              .Text("dsc2", Row), _
                                              .ToDec("bas_amt", Row), _
                                              .ToDec("amt1", Row), _
                                              .ToDec("amt2", Row), _
                                              .ToDec("end_amt", Row), _
                                               Row + Row2)
                                DataEnd = Row + Row2

                            Case "sub" '소계
                                Data(xlApp, .Text("dsc", Row), _
                                              .Text("dsc2", Row), _
                                              .ToDec("bas_amt", Row), _
                                              .ToDec("amt1", Row), _
                                              .ToDec("amt2", Row), _
                                              .ToDec("end_amt", Row), _
                                               Row + Row2, 1)

                                'SubTot(xlSheet, .Text("dsc", Row), _
                                '        DataStart, DataEnd, Row + Row2)

                                'SubColums += "+I" & Row + Row2
                                'DataStart = Row + Row2 + 1

                            Case "sum" '총계
                                Data(xlApp, .Text("dsc", Row), _
                                              .Text("dsc2", Row), _
                                              .ToDec("bas_amt", Row), _
                                              .ToDec("amt1", Row), _
                                              .ToDec("amt2", Row), _
                                              .ToDec("end_amt", Row), _
                                               Row + Row2, 2)
                                'Tot(xlSheet, .Text("dsc", Row), SubColums, Row + Row2)
                                'SubColums = ""
                                'TotColums += "+I" & Row + Row2

                            Case "sum2" '예상가능잔액
                                Data(xlApp, .Text("dsc", Row), _
                                              .Text("dsc2", Row), _
                                              .ToDec("bas_amt", Row), _
                                              .ToDec("amt1", Row), _
                                              .ToDec("amt2", Row), _
                                              .ToDec("end_amt", Row), _
                                               Row + Row2, 3)
                                'Tot(xlSheet, .Text("dsc", Row), TotColums, Row + Row2, 3)

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
        MainTitle(GetxlApp) '자금현황표
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

            Dim GetRange As Range = GetSheet.Range("A1", "A1")
            GetRange.ColumnWidth = 6.5

            GetRange = GetSheet.Range("B1", "C1")
            GetRange.ColumnWidth = 2.75

            GetRange = GetSheet.Range("D1", "D1")
            GetRange.ColumnWidth = 2.0

            GetRange = GetSheet.Range("E1", "E1")
            GetRange.ColumnWidth = 2.75

            GetRange = GetSheet.Range("F1", "F1")
            GetRange.ColumnWidth = 6

            GetRange = GetSheet.Range("G1", "G1")
            GetRange.ColumnWidth = 7.57

            GetRange = GetSheet.Range("H1", "H1")
            GetRange.ColumnWidth = 6

            'GetRange = GetSheet.Range("G1", "G1")
            'GetRange.ColumnWidth = 0.69

            'GetRange = GetSheet.Range("H1", "I1")
            'GetRange.ColumnWidth = 6

            GetRange = GetSheet.Range("I1", "I1")
            GetRange.ColumnWidth = 2.75

            GetRange = GetSheet.Range("J1", "K1")
            GetRange.ColumnWidth = 4 '8.25

            'GetRange = GetSheet.Range("K1", "K1")
            'GetRange.ColumnWidth = 7.13

            GetRange = GetSheet.Range("L1", "Q1")
            GetRange.ColumnWidth = 5.25

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub MainTitle(GetxlApp As Application)
        Try
            CellStyle(GetxlApp, "F3", "H4", GetxlApp.Worksheets(1).Name, True, True, , , "바탕체", 18)
            'Setting the foreground color to blue

            'CellMerge(GetSheet, "F3:H4")
            ''CellMerge(GetSheet, 3, 6, 4, 8)
            'Dim TRange As Range = GetSheet.Range("F3", "H4")
            'TRange.Merge()
            'TRange.FormulaR1C1 = GetSheet.Name
            'TRange.HorizontalAlignment = 3
            'TRange.VerticalAlignment = 3




            'Input data into C6 Cell.
            'GetSheet.Cells(3, 6) = GetSheet.Name
            'GetSheet.Cells(3, 6).Style.Font.Name = "바탕체"
            'GetSheet.Cells(3, 6).Style.Font.Size = 19
            'GetSheet.Cells(3, 6).Style.Font.Bold = True
            ''Create a Style object to fetch the Style of C6 Cell.
            'Dim GetStyle As Style = CellStyle(GetSheet.Cells(3, 6).Style(), "바탕체", 19, True, , True)

            ''Setting the vertical alignment of the text
            'GetStyle.VerticalAlignment = XlVAlign.xlVAlignCenter

            ''Setting the horizontal alignment of the text
            'GetStyle.HorizontalAlignment = XlVAlign.xlVAlignCenter

            'Set the backgrond color of C6 Cell to Red
            'GetStyle.ForegroundColor = Color.Red


        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Sub SubTitle(GetSheet As Worksheet)
        Try
            'CellMerge(GetSheet, "B6:D6")
            'GetSheet.Cells(6, 2) = "조회기간 : "

            Dim GetRange As Range = GetSheet.Range("B6", "D6")
            GetRange.Merge()
            GetRange.FormulaR1C1 = "조회기간 : "
            GetRange.HorizontalAlignment = 4 '오른쪽정렬
            GetRange.Font.Size = 8
            GetRange.Font.Name = "바탕체"

            GetRange = GetSheet.Range("E6", "I6")
            GetRange.Merge()
            GetRange.FormulaR1C1 = fr_dt.Text.Substring(0, 4) & "년 " & fr_dt.Text.Substring(5, 2) & "월 " & fr_dt.Text.Substring(8, 2) & "일 ~ " & _
                                    to_dt.Text.Substring(0, 4) & "년 " & to_dt.Text.Substring(5, 2) & "월 " & to_dt.Text.Substring(8, 2) & "일"
            GetRange.HorizontalAlignment = 3 '중앙정렬
            GetRange.Font.Size = 8
            GetRange.Font.Name = "바탕체"

            'CellMerge(GetSheet, "E6:F6")
            'GetSheet.Cells(6, 5) = fr_dt.Text.Substring(0, 4) & "년 " & fr_dt.Text.Substring(5, 2) & "월 " & fr_dt.Text.Substring(8, 2) & "일"
            ''GetSheet.Cells(6, 7) = "~"
            'GetRange = GetSheet.Range("G6", "G6")
            'GetRange.FormulaR1C1 = "~"
            'GetRange.HorizontalAlignment = 3 '중앙정렬

            'GetRange = GetSheet.Range("H6", "I6")
            'GetRange.Merge()
            'GetRange.FormulaR1C1 = to_dt.Text.Substring(0, 4) & "년 " & to_dt.Text.Substring(5, 2) & "월 " & to_dt.Text.Substring(8, 2) & "일"
            'GetRange.HorizontalAlignment = 2 '왼쪽정렬

            'CellMerge(GetSheet, "H6:I6")

            ''Setting the width of the second column to 17.5
            ''GetSheet.Cells(6, 9).ColumnWidth = 0
            'GetSheet.Cells(6, 8) = to_dt.Text.Substring(0, 4) & "년 " & to_dt.Text.Substring(5, 2) & "월 " & to_dt.Text.Substring(8, 2) & "일"

            ''Create a Style object to fetch the Style of C6 Cell.
            'Dim GetStyle As Style = CellStyle(GetSheet.Cells(3, 6).Style(), "바탕체", 19, True, , True)

            ''Setting the vertical alignment of the text
            'GetStyle.VerticalAlignment = XlVAlign.xlVAlignCenter

            ''Setting the horizontal alignment of the text
            'GetStyle.HorizontalAlignment = XlVAlign.xlVAlignCenter

            'Set the backgrond color of C6 Cell to Red
            'GetStyle.ForegroundColor = Color.Red


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

            'CellMerge(GetSheet, "L2:M3")
            'GetSheet.Cells(2, 12) = "기 안"
            'CellMerge(GetSheet, "L4:M7")

            'CellMerge(GetSheet, "N2:O3")
            'GetSheet.Cells(2, 14) = "검 토"
            'CellMerge(GetSheet, "N4:O7")

            'CellMerge(GetSheet, "P2:Q3")
            'GetSheet.Cells(2, 16) = "승 인"
            'CellMerge(GetSheet, "P4:Q7")

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub
#End Region

#Region "Data Sheet"
    Private Sub DataHeader(GetApp As Application, Title As String, Row As Integer)
        Dim Cel1 As String = "A" & Row, Cel2 As String = "Q" & Row
        Row += 1

        CellStyle(GetApp, Cel1, Cel2, Title, True, True, True, 1)

        Cel1 = "A" & Row : Cel2 = "C" & Row
        CellStyle(GetApp, Cel1, Cel2, "적   요", True, True, True)

        Cel1 = "D" & Row : Cel2 = "H" & Row
        CellStyle(GetApp, Cel1, Cel2, "금융정보", True, True, True)

        Cel1 = "I" & Row : Cel2 = "K" & Row
        CellStyle(GetApp, Cel1, Cel2, "전일잔고", True, True, True)

        Cel1 = "L" & Row : Cel2 = "M" & Row
        CellStyle(GetApp, Cel1, Cel2, "금일입금", True, True, True)

        Cel1 = "N" & Row : Cel2 = "O" & Row
        CellStyle(GetApp, Cel1, Cel2, "금일출금", True, True, True)

        Cel1 = "P" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "금일잔고", True, True, True)

    End Sub

    Private Sub Data(GetApp As Application, Title As String, Title2 As String, _
                                            Value As Double, Value2 As Double, Value3 As Double, Value4 As Double, _
                                            Row As Integer, Optional ColNo As Integer = 0)

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '적요
        CellStyle(GetApp, Cel1, Cel2, Title, True, , True, ColNo, , 8)

        '금융정보
        Cel1 = "D" & Row : Cel2 = "H" & Row
        CellStyle(GetApp, Cel1, Cel2, Title2, True, , True, ColNo, , 7)

        '전일잔고
        Cel1 = "I" & Row : Cel2 = "K" & Row
        CellStyle(GetApp, Cel1, Cel2, Value, True, , True, ColNo, , 8)

        '금일입금
        Cel1 = "L" & Row : Cel2 = "M" & Row
        CellStyle(GetApp, Cel1, Cel2, Value2, True, , True, ColNo, , 8)

        '금일출금
        Cel1 = "N" & Row : Cel2 = "O" & Row
        CellStyle(GetApp, Cel1, Cel2, Value3, True, , True, ColNo, , 8)

        '금일잔고
        Cel1 = "P" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, Value4, True, , True, ColNo, , 8)

    End Sub

    Private Sub SubTot(GetApp As Application, Title As String, _
                                        FrCol As Integer, ToCol As Integer, _
                                        Row As Integer)

        Dim FolumaStr As String = ""

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '적요
        CellStyle(GetApp, Cel1, Cel2, Title, True, True, True, 2, , 8)

        '금융정보
        Cel1 = "D" & Row : Cel2 = "H" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, 2)

        '전일잔고
        If FrCol = ToCol Then
            FolumaStr = "=SUM(I" + FrCol.ToString + ")"
        Else
            FolumaStr = "=SUM(I" + FrCol.ToString + ":K" + ToCol.ToString + ")"
        End If
        Cel1 = "I" & Row : Cel2 = "K" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, 2, , 8, , , FolumaStr)

        '금일입금
        If FrCol = ToCol Then
            FolumaStr = "=SUM(L" + FrCol.ToString + ")"
        Else
            FolumaStr = "=SUM(L" + FrCol.ToString + ":M" + ToCol.ToString + ")"
        End If

        Cel1 = "L" & Row : Cel2 = "M" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, 2, , 8, , , FolumaStr)

        '금일출금
        If FrCol = ToCol Then
            FolumaStr = "=SUM(N" + FrCol.ToString + ")"
        Else
            FolumaStr = "=SUM(N" + FrCol.ToString + ":O" + ToCol.ToString + ")"
        End If
        Cel1 = "N" & Row : Cel2 = "O" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, 2, , 8, , , FolumaStr)

        '금일잔고
        If FrCol = ToCol Then
            FolumaStr = "=SUM(P" + FrCol.ToString + ")"
        Else
            FolumaStr = "=SUM(P" + FrCol.ToString + ":Q" + ToCol.ToString + ")"
        End If
        Cel1 = "P" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, 2, , 8, , , FolumaStr)

    End Sub

    Private Sub Tot(GetApp As Application, Title As String, _
                                    FolumaStr As String, _
                                    Row As Integer, Optional ColorNo As Integer = 2)

        Dim Cel1 As String = "A" & Row, Cel2 As String = "C" & Row

        '적요
        CellStyle(GetApp, Cel1, Cel2, Title, True, True, True, ColorNo, , 8)

        '금융정보
        Cel1 = "D" & Row : Cel2 = "H" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, True, True, ColorNo)

        If FolumaStr <> "" Then FolumaStr = "=" + FolumaStr

        '전일잔고
        Cel1 = "I" & Row : Cel2 = "K" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, ColorNo, , 8, , , FolumaStr)

        '금일입금
        FolumaStr = FolumaStr.Replace("I", "L")
        Cel1 = "L" & Row : Cel2 = "M" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, ColorNo, , 8, , , FolumaStr)

        '금일출금
        FolumaStr = FolumaStr.Replace("L", "N")
        Cel1 = "N" & Row : Cel2 = "O" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, ColorNo, , 8, , , FolumaStr)

        '금일잔고
        FolumaStr = FolumaStr.Replace("N", "P")
        Cel1 = "P" & Row : Cel2 = "Q" & Row
        CellStyle(GetApp, Cel1, Cel2, "", True, , True, ColorNo, , 8, , , FolumaStr)

    End Sub
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

    Private Sub FAF500_KRS_Disposing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Disposing
        GC.Collect()
    End Sub
End Class
