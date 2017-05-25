Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class PRT100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        'New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()

                End If

            Case MenuType.New
                emp_no.Text = ""
                emp_nm.Text = ""
                New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        'MyBase.Open("gat100_g10")

        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g10.AddNewRow()
        'g10.Find("")
    End Sub


    '그룹웨어 연동
    Private Sub go_gw_Click(sender As System.Object, e As System.EventArgs) Handles go_gw.Click
        Dim chkct As Integer = 0
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                chkct = chkct + 1
                If g10.Text("DOC_NO", i) = "" Then
                    MessageInfo("저장 후 결재상신을 해주세요.")
                    Exit Sub
                End If
                If g10.Text("result_status", i) = "기안" Then
                    MessageInfo("이미 결재 진행중인 문서입니다.")
                    Exit Sub
                ElseIf g10.Text("result_status", i) = "승인" Then
                    MessageInfo("결재 완료된 문서입니다.")
                    Exit Sub
                ElseIf g10.Text("result_status", i) = "반려" Then
                    MessageInfo("반려된 문서입니다. 새로 작성해 주세요.")
                    Exit Sub
                End If

                Me.make_html(i)
                Dim strUserid As String = ""

                Dim parameter As New Base7.Parameter
                strUserid = parameter.Login.EmpNo

                Dim Popup As New MMB100P

                Dim StdURL As String = "http://gw.interojo.com/ekp/user.do?cmd=goEappWrite&EMP_CODE=" + strUserid + "&LINK_ID=IFBUY08&APP_CODE=" + g10.Text("DOC_NO", i) + "&APP_KIND=1"

                Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)

                Exit Sub
            End If
        Next

        If chkct < 1 Then
            MessageInfo("선택된 행이 없습니다.")
        End If

    End Sub

    Private Sub make_html(row As Integer)

        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g10.Text("DOC_NO", row))
        p.Add("@re_dt", g10.Text("RE_DT", row))
        p.Add("@emp_no", g10.Text("EMP_NO", row))
        'p.Add("@fr_dt", g10.Text("fr_dt", row))

        Dim dSet As DataSet = Link.ReadDataSet("prt100_print", p)
        Dim dRow As DataRow

        If dSet Is Nothing Then
            MessageInfo("데이터가 없습니다.")
            Exit Sub
        End If

        dRow = dSet.Tables(0).Rows(0)

        Dim header As String = ""
        Dim body As String = ""
        Dim footer As String = ""

        Dim tot_amt As Integer = 0
        Dim fileID As String = g10.Text("FILE_ID")

        ' header = "" &
        header = "" &
        "<HTML>" &
"<TITLE></TITLE>" &
"<BODY BGCOLOR='FFFFFF' LEFTMARGIN=31 TOPMARGIN=31>" &
"<table width='100%' border='0'>" &
"</table>" &
"<table width='100%' border='1'>" &
    "<tr>" &
        "<td width='20%' height='20' align = 'center'>제품명</td>" &
        "<td width='30%' align = 'center'>" & dRow("GD_NM") & "</td>" &
        "<td width='20%' align = 'center'>DATE</td>" &
        "<td width='30%' align = 'center'>" & dRow("RE_DT") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td width='20%' height='20' align = 'center'>관리번호</td>" &
        "<td width='30%' align = 'center'>" & dRow("DOC_NO") & "</td>" &
        "<td width='20%' align = 'center'>제작처</td>" &
        "<td width='30%' align = 'center'>" & dRow("JE_NM") & "</td>" &
    "</tr>" &
    "<tr>" &
        "<td width='20%' height='20' align = 'center'>바이어</td>" &
        "<td width='30%' align = 'center'>" & dRow("BUY_NM") & "</td>" &
        "<td width='20%' align = 'center'>규격</td>" &
        "<td width='30%' align = 'center'>" & dRow("SPEC") & "</td>" &
    "<tr>" &
    "</tr>" &
        "<tr>" &
            "<td  colspan='4' height='500' align = 'left' >&nbsp;&nbsp;인쇄사양" & "<BR>&nbsp;&nbsp;" & "- 용지: " & dRow("PAPER") & "<BR>&nbsp;&nbsp;" & "- 인쇄: " & dRow("PRT") & "<BR>&nbsp;&nbsp;" &
            "- 별색: " & dRow("COL_NM") & "<BR>&nbsp;&nbsp;" & "- 코팅: " & dRow("COAT") & "<BR>&nbsp;&nbsp;" & "- 후가공: " & dRow("AFT_NM") & "<BR><BR>" &
            "<img src='\\192.168.2.150\인쇄시방서\PRT100\" & fileID & "'" & "width='300' height='300'>" &
            "</td>" &
        "</tr>" &
    "</tr>" &
    "<tr>" &
        "<td colspan='2' height='20' align = 'center'>특이사항</td>" &
        "<td colspan='2' align = 'center'>유의사항</td>" &
    "</tr>" &
    "<tr>" &
        "<td colspan='2'  height='70' align = 'left'>&nbsp;" & dRow("ETC_NM") & "</td>" &
        "<td colspan='2'  align = 'left'>&nbsp;&nbsp;" & "- 시방서의 내용, 인쇄색상, 규격이 Sample과 동일 할 것" & "<BR>&nbsp;&nbsp;" &
        "- COLOR는 지정된 INK 적용" & "<BR>&nbsp;&nbsp;" & "- 인쇄번짐이 없을 것" & "<BR>&nbsp;&nbsp;" & "- 인쇄위치와 치수는 기구도면과 인쇄도에 준함" &
        "<BR>&nbsp;&nbsp;" & "- 인쇄위치 허용공차 : 0.5mm" &
"</td>" &
    "</tr>" &
"</table>" &
"</BODY>" &
"</HTML>"

        '"<img src=" & "\\192.168.2.5\erp\File_Up\PRT100\" & fileID & "border=" & "0" & ">" &
        Dim parameter As New Base7.Parameter
        Dim strUserid As String = ""
        strUserid = parameter.Login.EmpNo

        Dim p2 As OpenParameters = New OpenParameters
        p2.Add("@app_code", g10.Text("DOC_NO", row))
        p2.Add("@emp_code", strUserid)
        p2.Add("@form_id", "")

        Dim dSet2 As DataSet
        dSet2 = Me.OpenDataSet("prt100_html", p2)

        Dim dRow1 As DataRow
        dRow1 = dSet2.Tables(0).NewRow
        dRow1("emp_code") = strUserid
        dRow1("form_id") = ""
        dRow1("app_code") = g10.Text("DOC_NO", row)
        dRow1("seq") = dSet2.Tables(0).Rows.Count
        dRow1("result_status") = "C"
        dRow1("app_kind") = "1"
        dRow1("form_html") = header & body & footer
        dSet2.Tables(0).Rows.Add(dRow1)

        Me.Save("prt100_html")
    End Sub

    Private Sub sh_gw_Click(sender As System.Object, e As System.EventArgs) Handles sh_gw.Click

        Dim strUserid As String = ""
        Dim chkct As Integer = 0
        strUserid = Parameter.Login.EmpNo

        Dim p As New OpenParameters
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" And g10.Text("DOC_NO", i) <> "" Then
                p.Add("@re_emp", g10.Text("EMP_NO", i))
                p.Add("@app_code", g10.Text("DOC_NO", i))
                chkct = chkct + 1
            Else

            End If
        Next

        If chkct < 1 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        Dim Popup As New MMB100P

        Dim StdURL As String

        Dim dSet As DataSet = OpenDataSet("prt100_get_url", p)

        If Not IsEmpty(dSet) Then
            StdURL = CStr(DataValue(dSet)) & "&EMP_CODE=" + strUserid
            Popup.WebBrowser1.Navigate(New System.Uri(StdURL), True)
        End If

    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        Dim chk As Integer = 0
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                chk = chk + 1
            End If
        Next

        If chk > 1 Then
            MessageInfo("하나만 선택해주세요.")
            g10.Text("chk", RowIndex) = ""
            Exit Sub
        End If
    End Sub


    Private Sub FileAdd()
        'Dim fileID As String = g10.Text("FILE_ID")
        Dim fileID As String = ""
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        If dialog.ShowDialog() = DialogResult.OK Then

            If Not MyBase.Save("prt100_g10") Then
                '저장실패시 코드채번 취소
                Me.WorkSet("prt100_g10").RecoverCodeNo()
                Exit Sub
            Else
                'g10.Open()
            End If

            'Grid내 같은 File명 체크
            For Each FileNm As String In dialog.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g10, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
            Next

            'g10.AllowAddRows = True

            Try
                For Each fullPath As String In dialog.FileNames

                    fileID = [Shared].FileUpload("", fullPath, "PRT100", False)

                    If fullPath <> "" Then
                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                        Dim f As New System.IO.FileInfo(fullPath)

                        'g10.AddNewRow()
                        g10.Focus()
                        g10.FocusedFieldName = "FILE_ID"
                        g10.Text("FILE_ID", g10.RowIndex) = fileID
                        g10.Text("FILE_NM", g10.RowIndex) = fileNm
                        g10.Text("FILE_SIZE", g10.RowIndex) = f.Length.ToString

                    End If

                Next

                Me.Save("prt100_g10")

            Catch ex As Exception
                MessageInfo(ex)
            Finally
                g10.AllowAddRows = False
            End Try

        End If
    End Sub

    Private Sub g10_ButtonPressed(sender As System.Object, columnName As System.String) Handles g10.ButtonPressed
        Dim FileID As String = g10.Text("FILE_ID")
        Dim FileNm As String = g10.Text("FILE_NM")

        If columnName = "upload" Then
            FileAdd()
            '[Shared].FileUpload(FileID, FileNm, , True)
        ElseIf columnName = "show" Then
            [Shared].FileDownLoad(FileID, FileNm, , True)
        End If

    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g10
            For i As Integer = 0 To .RowCount - 1
                If .Text("FILE_NM", i) = fileNm Then Return True
            Next
        End With
        Return False
    End Function

    ''Private Sub img_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    ''    CallImageView(1)
    ''End Sub

    'Private Sub CallImageView(ByVal GetID As String, ByVal FileNm As String)
    '    'If itm_cd.Text = "" Or GetID = "" Then Exit Sub
    '    If img.Image Is Nothing Then Exit Sub
    '    Try
    '        'eImage 에 Image Property 추가
    '        Dim f As ImageView
    '        f = New ImageView
    '        f.LoadPicture(img.Image, FileNm)
    '        f.ShowDialog()

    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub



    'Private Sub g10_ButtonPressed(sender As System.Object, columnName As System.String) Handles g10.ButtonPressed
    '    Dim obj As Frame7.eGrid = CType(sender, Frame7.eGrid)
    '    Dim fileName As String
    '    Dim tempFileName As String

    '    If columnName = "file_add" Then
    '        Dim dialog As OpenFileDialog = New OpenFileDialog()
    '        dialog.Filter = "모든파일(*.*)|*.*"
    '        dialog.Title = "업로드할 파일을 선택 하세요"
    '        If dialog.ShowDialog() = DialogResult.OK Then

    '            fileName = dialog.FileName.Replace(dialog.SafeFileName, g10.Text("DOC_NO") + "_" + dialog.SafeFileName)

    '            System.IO.File.Copy(dialog.FileName, fileName, True)
    '            'tempFileName = [Shared].FileUpload("", fileName, "QMA310")
    '            tempFileName = [Shared].FileUpload("")
    '            System.IO.File.Delete(fileName)
    '            If tempFileName = String.Empty Then
    '                Return
    '            End If

    '            g10.Text("file_add") = tempFileName
    '            g10.Text("file_view") = tempFileName
    '            g10.Text("file_del") = tempFileName
    '        End If

    '        'ElseIf columnName = "file_view" Then
    '        '    [Shared].FileDownLoad(g10.Text("file_view"), , True)

    '    ElseIf columnName = "file_del" Then
    '        If [Shared].FileDelete(g10.Text("file_view"), "QMA310") Then
    '            g10.Text("file_add") = ""
    '            g10.Text("file_view") = ""
    '            g10.Text("file_del") = ""
    '        End If
    '    End If

    '   End Sub



    '    Private Sub g10_ButtonPressed(sender As Object, columnName As String) Handles g10.ButtonPressed
    '        Dim obj As Frame7.eGrid = CType(sender, Frame7.eGrid)
    '        Dim fileName As String
    '        Dim tempFileName As String

    '        If columnName = "file_add" Then
    '            Dim dialog As OpenFileDialog = New OpenFileDialog()
    '            dialog.Filter = "모든파일(*.*)|*.*"
    '            dialog.Title = "업로드할 파일을 선택 하세요"
    '            If dialog.ShowDialog() = DialogResult.OK Then

    '                fileName = dialog.FileName.Replace(dialog.SafeFileName, g10.Text("DOC_NO") + "_" + dialog.SafeFileName)

    '                System.IO.File.Copy(dialog.FileName, fileName, True)
    '                'tempFileName = [Shared].FileUpload("", fileName, "QMA310")
    '                tempFileName = [Shared].FileUpload("")

    '                System.IO.File.Delete(fileName)
    '                If tempFileName = String.Empty Then
    '                    Return
    '                End If

    '                g10.Text("file_add") = tempFileName
    '                g10.Text("file_view") = tempFileName
    '                g10.Text("file_del") = tempFileName
    '            End If

    '            'ElseIf columnName = "file_view" Then
    '            '    [Shared].FileDownLoad(g20.Text("file_view"), , True)

    '        ElseIf columnName = "file_del" Then
    '            'If [Shared].FileDelete(g10.Text("file_view"), "QMA310") Then
    '            If [Shared].FileDelete(g10.Text("file_view"), "QMA310") Then
    '                g10.Text("file_add") = ""
    '                g10.Text("file_view") = ""
    '                g10.Text("file_del") = ""
    '            End If
    '        End If

    '        'Dim fileID As String = g10.Text("file_id")
    '        'Dim fileNm As String = g10.Text("file_nm")
    '        'If fileNm = "" Then
    '        '    Exit Sub
    '        'End If

    '        'If columnName = "del" Then
    '        '    MsgBox("del")
    '        '    Try
    '        '        'If [Shared].FileDelete(fileID, fileNm) = True Then
    '        '        ' 오류수정: fileID 가 없어도 행 삭제되게 해야한다
    '        '        If fileID = "" OrElse [Shared].FileDelete(fileID, fileNm) = True Then

    '        '            g10.AllowDeleteRows = True
    '        '            g10.DeleteRow(g10.RowIndex)
    '        '            g10.AllowDeleteRows = False

    '        '            Me.Save(g10.WorkSet)
    '        '        End If
    '        '    Catch ex As Exception
    '        '        MessageInfo(ex)
    '        '    End Try

    '        'End If

    '        'If columnName = "show" Then
    '        '    MsgBox("11")
    '        '    [Shared].FileDownLoad(fileID, fileNm, , True)
    '        'End If

    '        'If columnName = "down" Then
    '        '    [Shared].FileDownLoad(fileID, fileNm)
    '        'End If

    '        'If columnName = "upload" Then
    '        '    [Shared].FileUpload(fileID, fileNm)
    '        'End If
    '    End Sub

    '    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

    '        Dim chk As Integer = 0
    '        For i = 0 To g10.RowCount - 1
    '            If g10.Text("chk", i) = "1" Then
    '                chk = chk + 1
    '            End If
    '        Next

    '        If chk > 1 Then
    '            MessageInfo("하나만 선택해주세요.")
    '            g10.Text("chk", RowIndex) = ""
    '            Exit Sub
    '        End If
    '    End Sub


    '#Region "FTP 관리"

    '    Private Sub g10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g10.DragDrop
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

    '            If Not MyBase.Save() Then
    '                Exit Sub
    '            End If

    '            'Grid내 같은 File명 체크
    '            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
    '                fileNm = System.IO.Path.GetFileName(fileNm)
    '                If Me._IsExists(g10, fileNm) Then
    '                    If MessageYesNo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + _
    '                                    "그래도 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
    '                        Exit Sub
    '                    End If
    '                End If
    '            Next

    '            'Grid에 선택파일 추가
    '            Dim fullPath As String
    '            g10.AllowAddRows = True
    '            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

    '                Dim FileID As String = [Shared].FileUpload("", fullPath)
    '                'If fullPath <> "" Then
    '                ' 오류수정: fileID 가 없어면 저장 안되게 해야한다
    '                If FileID <> "" And fullPath <> "" Then

    '                    '파일명만 분리
    '                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

    '                    Dim f As New System.IO.FileInfo(fullPath)
    '                    g10.AddNewRow()
    '                    g10.Text("file_id") = FileID
    '                    g10.Text("file_nm") = fileNm
    '                    g10.Text("file_size") = f.Length.ToString
    '                End If

    '            Next
    '            g10.AllowAddRows = False

    '            Me.Save(g10.WorkSet)
    '            g10.Open()
    '        End If
    '    End Sub

    '    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
    '        With g
    '            For i As Integer = 0 To .RowCount - 1
    '                If .Text("file_nm", i) = fileNm Then
    '                    Return True
    '                End If
    '            Next
    '        End With
    '        Return False
    '    End Function

    '    Private Sub g10_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g10.DragOver
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '            e.Effect = DragDropEffects.Copy
    '        End If
    '    End Sub

    '#End Region


End Class
