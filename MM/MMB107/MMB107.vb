Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Public Class MMB107
    Dim CO_Excel As Microsoft.Office.Interop.Excel.Application
    Dim CO_Book As Microsoft.Office.Interop.Excel.Workbook
    Dim CO_Sheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim CO_Range As Microsoft.Office.Interop.Excel.Range
    Dim Excel_Active As Boolean = False
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SplitContainer2.Panel1MinSize = 25
        'Me.Init_Title()
        Me.File_Down()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            'Case MenuType.Save

            'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then

                Try
                    'MessageInfo("1")
                    'Me.Excel_Print()
                    'MessageInfo("2")
                    Dim Excel_Path(2) As String
                    'Dim   Sheet_NM As String
                    'MessageInfo("3")
                    Excel_Path(1) = "" ': Sheet_NM = "" : Excel_Active = False
                    'MessageInfo(Excel_Path(1))
                    Excel_Path(1) = "c:\ErpExcel\현품표.xls"
                    'MessageInfo(Excel_Path(1))
                    Excel_Path(2) = "c:\ErpExcel\현품표1.xls"
                    If Not FileExist(Excel_Path(2).Trim) Then
                        FileCopy(Excel_Path(1), Excel_Path(2))
                    Else
                        Kill(Excel_Path(2))
                        FileCopy(Excel_Path(1), Excel_Path(2))
                    End If
                    If CO_Excel Is Nothing Then
                        CO_Excel = CreateObject("Excel.Application", "")
                    Else
                        CO_Excel = GetObject("Execl.Application", "")
                    End If
                    Excel_Active = True
                    CO_Sheet = CO_Excel.Workbooks.Open(Excel_Path(2)).ActiveSheet
                    Me.Excel_Move(i)

                    CO_Excel.DisplayAlerts = True
                    CO_Excel.Visible = True


                    CO_Sheet = Nothing
                    CO_Excel = Nothing
                Catch ex As Exception
                    MessageInfo("발주서 엑셀 양식이 미 존재합니다")
                End Try
            End If
        Next
    End Sub
    'Private Sub Excel_Print()
    '    MessageInfo("2")
    '    Dim Excel_Path(2) As String
    '    'Dim   Sheet_NM As String
    '    MessageInfo("3")
    '    Excel_Path(1) = "" ': Sheet_NM = "" : Excel_Active = False
    '    MessageInfo(Excel_Path(1))
    '    Excel_Path(1) = "c:\ErpExcel\현품표.xls"
    '    MessageInfo(Excel_Path(1))
    '    Excel_Path(2) = "c:\ErpExcel\현품표1.xls"
    '    If Not FileExist(Excel_Path(2).Trim) Then
    '        FileCopy(Excel_Path(1), Excel_Path(2))
    '    Else
    '        Kill(Excel_Path(2))
    '        FileCopy(Excel_Path(1), Excel_Path(2))
    '    End If
    '    If CO_Excel Is Nothing Then
    '        CO_Excel = CreateObject("Excel.Application", "")
    '    Else
    '        CO_Excel = GetObject("Execl.Application", "")
    '    End If
    '    Excel_Active = True
    '    CO_Sheet = CO_Excel.Workbooks.Open(Excel_Path(2)).ActiveSheet
    '    Me.Excel_Move()

    '    CO_Excel.DisplayAlerts = True
    '    CO_Excel.Visible = True


    '    CO_Sheet = Nothing
    '    CO_Excel = Nothing

    'End Sub
    Private Sub Excel_Move(ByVal i As Integer)
        'Dim iRow, j, k As Integer

        Try
            With g10
                CO_Excel.Cells(2, 5) = .Text("dlv_dt", i)
                CO_Excel.Cells(3, 5) = .Text("itm_cd", i)
                CO_Excel.Cells(4, 5) = .Text("itm_nm", i)
                CO_Excel.Cells(5, 5) = .Text("cust_nm", i)
                CO_Excel.Cells(6, 5) = .Text("mng_no", i)

                'k = 0
                'For j = 33 To g10.ColumnCount - 1
                '    CO_Excel.Cells(9, 23 + k) = g10.ColumnTitle(j)
                '    k = k + 1
                'Next
                'For iRow = 0 To .RowCount - 1

                '    k = 0
                '    CO_Excel.Cells(iRow + 10, 1) = .Text("po_no", iRow)
                '    CO_Excel.Cells(iRow + 10, 6) = .Text("itm_cd", iRow)
                '    CO_Excel.Cells(iRow + 10, 10) = .Text("itm_nm", iRow)
                '    CO_Excel.Cells(iRow + 10, 17) = .Text("spec", iRow)
                '    CO_Excel.Cells(iRow + 10, 21) = .Text("dlv_um_nm", iRow)
                '    'CO_Excel.Cells(iRow + 10, 21) = .Text("title", iRow)
                '    g10.RowIndex = iRow
                '    For j = 33 To g10.ColumnCount - 1
                '        CO_Excel.Cells(iRow + 10, 23 + k) = g10.ToDec(g10.FieldName(j))
                '        k = k + 1
                '    Next
                'Next
            End With
        Catch ex As Exception
            If Excel_Active = True Then
                'CO_Book.Close()
                CO_Excel.Workbooks.Close()
                CO_Excel.Quit()
                Excel_Active = False
            End If
        End Try

    End Sub
    Function FileExist(ByVal P_FileName As String) As Boolean
        Dim File_Name As String
        FileExist = False
        Try
            File_Name = Dir(P_FileName)
            If Len(File_Name.Trim) > 0 Then
                FileExist = True
            Else
                FileExist = False
                'MessageBox.Show("파일명 : " & P_FileName & vbCrLf & "출력 파일이 존재하지 않습니다")
                Exit Function
            End If
        Catch ex As Exception

        End Try
    End Function
    Dim isBusy As Boolean
    Private Sub File_Down()
        Dim File_Name As String
        File_Name = Dir("c:\ErpExcel", FileAttribute.Directory)
        If Len(File_Name.Trim) > 0 Then

        Else
            MkDir("c:\ErpExcel")
        End If

        pgbDownload.Visible = True
        txtUrl.Text = "http://14.34.136.155/erp/현품표.xls"
        If isBusy Then
            WebClient1.CancelAsync()
            isBusy = False
        Else
            Try
                Dim strFileName = Me.txtUrl.Text.Split(New Char() {"/"})
                System.Array.Reverse(strFileName)
                Dim Uri As Uri = New Uri(Me.txtUrl.Text)
                Dim str = WebClient1.DownloadString(Uri)
                WebClient1.DownloadFileAsync(Uri, "c:\ErpExcel\현품표.xls")
                'WebClient1.DownloadFileAsync(Uri, "C:\inetpub\wwwroot\System7\발주서.xls")
                isBusy = True
            Catch ex As Exception
                MessageBox.Show("다운로드가 실패하였습니다", "에러", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        pgbDownload.Visible = False
    End Sub

    Private Sub WebClient1_DownloadDataCompleted(sender As Object, e As System.Net.DownloadDataCompletedEventArgs) Handles WebClient1.DownloadDataCompleted
        isBusy = False
        If e.Error Is Nothing Then
            MessageBox.Show("다운로드가 완료되었습니다", "알림", _
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("다운로드가 실패하였습니다" + e.Error.Message.ToString())
        End If
    End Sub
    Private Sub WebClient1_DownloadProgressChanged(sender As Object, e As System.Net.DownloadProgressChangedEventArgs) Handles WebClient1.DownloadProgressChanged
        Me.pgbDownload.Value = e.ProgressPercentage
    End Sub

    Private Sub but_tap_Click(sender As System.Object, e As System.EventArgs) Handles but_tap.Click


        For Row As Integer = 0 To g10.RowCount - 1
            If g10.Text("chk", Row) = "1" Then
                Print(g10.Text("dlv_no", Row), g10.Text("dlv_sq", Row), g10.Text("qty", Row))
            End If
        Next

    End Sub

    Private Sub Print(ByVal dlv_no As String, ByVal prt_cnt As String, ByVal qty As Decimal)

        If g10.Text("chk") = "1" Then

            Dim p As OpenParameters = New OpenParameters
            p.Add("@dlv_no", dlv_no)
            p.Add("@dlv_sq", prt_cnt)
            p.Add("@qty", qty)
           

            System7.ReportView.LoadView("MMB107_Tap", "", "mmb107_print_tap", p)

        Else
            Return
        End If

    End Sub
    Private Sub but_tap_2_Click(sender As System.Object, e As System.EventArgs) Handles but_tap_2.Click
        For Row As Integer = 0 To g10.RowCount - 1
            If g10.Text("chk", Row) = "1" Then
                Print2(g10.Text("dlv_no", Row), g10.Text("prt_cnt", Row), g10.Text("qty", Row))
            End If
        Next
    End Sub
    Private Sub Print2(ByVal dlv_no As String, ByVal prt_cnt As String, ByVal qty As Decimal)

        If g10.Text("chk") = "1" Then

            Dim p As OpenParameters = New OpenParameters
            p.Add("@dlv_no", dlv_no)
            p.Add("@dlv_sq", prt_cnt)
            p.Add("@qty", qty)
           

            System7.ReportView.LoadView("MMB107_Tap", "", "mmb107_print_tap", p, , False, prt_cnt)

        Else
            Return
        End If

    End Sub

    Private Sub but_print_Click(sender As System.Object, e As System.EventArgs) Handles but_print.Click
        With g10
            If .RowCount - 1 >= 0 Then
                If .CheckedRows("chk") = 0 Then
                    Exit Sub
                Else
                    Dim tb As DataTable, drow As DataRow
                    Dim dset As DataSet = Me.OpenDataSet("mmb107_temp")

                    tb = dset.Tables(0)

                    .UpdateRow()
                    tb.BeginLoadData()
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("chk", i) Then
                            drow = tb.NewRow()
                            drow("dlv_no") = .Text("dlv_no", i)

                            tb.Rows.Add(drow)
                        End If
                    Next
                    tb.EndLoadData()

                    MyBase.Save("mmb107_temp")

                    Dim pr As OpenParameters = New OpenParameters
                    pr.Add("@dlv_fr", dlv_fr.Text)
                    pr.Add("@dlv_to", dlv_to.Text)
                    pr.Add("@fac_cd", fac_cd.Text)
                    pr.Add("@wh_cd", wh_cd.Text)
                    pr.Add("@cust_cd", cust_cd.Text)
                    pr.Add("@req_dt", req_dt.Text)

                    System7.ReportView.LoadView("MMB107", "", "mmb107_print", pr)

                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub


    Private Sub but_tap_3_Click(sender As System.Object, e As System.EventArgs) Handles but_tap_3.Click
        If g10.Text("chk") = "1" Then

            Dim p As OpenParameters = New OpenParameters


            p.Add("@dlv_no", g10.Text("dlv_no"))
            p.Add("@dlv_sq", g10.Text("dlv_sq"))
            p.Add("@qty", g10.Text("qty"))
          

            System7.ReportView.LoadView("MMB107R_TabR", "", "mmb107_print_tap", p, )

        End If
    End Sub
End Class
