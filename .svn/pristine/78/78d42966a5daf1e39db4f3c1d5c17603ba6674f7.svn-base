Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.IO
Imports System.Net
Imports System.Data

Public Class REG_MASTER

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        New_Form()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                Open_Form()

            Case MenuType.Save
                Save_Form()

                'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)
                If mty = MenuType.Delete Then Me.Open()

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            std_dt.Text = ""
            cust_cd.Text = ""
            itm_id.Text = ""
            Dim Param As New OpenParameters
            Param.Add("@std_dt", "")
            Param.Add("@cust_cd", "")
            Param.Add("@itm_id", "")

            Me.Open("reg_master_f10", Param)    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회
            Me.Open("reg_master_g20", Param)    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

            std_dt.Focus()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Me.Open("reg_master_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

            std_dt.Focus()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form2()
        Try
            Me.Open("reg_master_g20")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try
            Dim MainChk As Integer = 0
            For Row As Integer = 0 To g20.RowCount - 1
                If g20.IsDataRow(Row) Then
                    If g20.Text("main_chk", Row) = "1" Then
                        MainChk += 1
                    End If
                End If
            Next
            If MainChk > 1 Then
                MessageWarning("[대표여부]는 1건만 등록할 수 있습니다.")
                Return False
            End If

            If MyBase.Save() Then
                If g20.DataChanged Then Save_Form2()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    Private Sub Save_Form2()

        Try
            Dim Params As New OpenParameters
            Params.Add("@std_dt", std_dt.Text)
            Params.Add("@cust_cd", cust_cd.Text)
            Params.Add("@itm_id", itm_id.Text)

            Dim dSet As DataSet = Me.OpenDataSet("reg_master_images", Params)
            If dSet Is Nothing Then Exit Sub

            'DataRow존재하면 기존자료 삭제
            Dim dRow As DataRow
            If Not IsDBNull(dSet) Then
                Dim dRows As DataRowCollection = dSet.Tables(0).Rows
                If Not (dRows Is Nothing) Then
                    For Each dRow In dRows
                        dRow.Delete()
                    Next

                    'For i As Integer = 1 To dRows.Count
                    '    dRows.RemoveAt(0)
                    'Next
                End If
            End If

            For Row As Integer = 0 To g20.RowCount - 1
                If g20.IsDataRow(Row) Then        'Data Row 만 작업한다 합계Row등은 제외
                    dRow = dSet.Tables(0).NewRow
                    dRow("std_dt") = std_dt.Text
                    dRow("cust_cd") = cust_cd.Text
                    dRow("itm_id") = itm_id.Text
                    dRow("file_nm") = g20.Text("file_nm", Row)
                    dRow("main_chk") = g20.Text("main_chk", Row)
                    dRow("rmks") = g20.Text("rmks", Row)
                    dSet.Tables(0).Rows.Add(dRow)
                End If
            Next
            Me.Save("reg_master_images")

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        Open_Form2()
        GetImageList()
    End Sub

    Private Sub g20_DoubleClick(sender As Object, e As System.EventArgs) Handles g20.DoubleClick
        With g20
            If .RowIndex >= 0 Then
                Dim dRow As DataRow = .DataSet.Tables(0).Rows(.RowIndex)
                If Not dRow("img") Is System.DBNull.Value Then
                    Dim img() As Byte = dRow("img")
                    Dim ms As New System.IO.MemoryStream(img)
                    master_img.Image = New Bitmap(ms)
                End If
            Else
                master_img.Image = Nothing
            End If
        End With
    End Sub


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Sub g20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            If CheckRequired(std_dt, cust_cd, itm_cd) = False Then Exit Sub

            If Save_Form() = False Then Exit Sub
            ''Grid내 같은 File명 체크
            'For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
            '    fileNm = System.IO.Path.GetFileName(fileNm)
            '    If Me._IsExists(g20, fileNm) Then

            '        MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
            '        Exit Sub
            '    End If
            'Next
            Dim dTbl As DataTable = g20.DataSet.Tables(0)
            Dim dRow As DataRow

            'Grid에 선택파일 추가
            Dim fullPath As String, SaveFileNm As String = "", Tm As String = ""
            g20.AllowAddRows = True
            'FTP PATH / (기준일) / (업체코드) / (품명코드) /
            Dim FtpPath As String = "\" & std_dt.Text.Substring(0, 10) & "\" & cust_cd.Text & "\" & itm_id.Text & "\"
            Dim FtpPath2 As String = "\thumb\" & std_dt.Text.Substring(0, 10) & "\" & cust_cd.Text & "\" & itm_id.Text & "\"
            Dim fullPath2 As String = ""

            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fullPath = fileNm
                'fileNm = [Shared].FileUpload("", fileNm, , False) '[Shared].FileUpload("", fileNm)
                'If fileNm <> "" Then
                '    Dim f As New System.IO.FileInfo(fullPath)
                '    g20.AddNewRow()
                '    g20.Text("file_nm") = fileNm
                'End If


                If fullPath <> "" Then
                    'Tm = Format(Now, "yyyyMMddHHmmss_")
                    'SaveFileNm = Tm & System.IO.Path.GetFileName(fileNm)
                    Tm = Format(Now, "yyyyMMddHHmmss")
                    SaveFileNm = System.IO.Path.GetFileName(fileNm)
                    SaveFileNm = Tm & SaveFileNm.Substring(SaveFileNm.IndexOf("."), SaveFileNm.Length - SaveFileNm.IndexOf("."))
                    Dim ThmPath As String = "c:\" & SaveFileNm
                    Dim ThmPath2 As String = "c:\org_" & SaveFileNm
                    Dim thmfileNm As String = SaveResizeImg(fileNm, ThmPath, 300, 300)
                    fullPath2 = SaveResizeImg(fileNm, ThmPath2)

                    If thmfileNm <> "" Then
                        fileNm = [Shared].FileUpload(FtpPath, fullPath2, SaveFileNm, , False)
                        fileNm = [Shared].FileUpload(FtpPath2, thmfileNm, SaveFileNm, , False)

                        If fileNm <> "" Then
                            System.IO.File.Delete(ThmPath) 'Local 임시 Thumbnail파일삭제
                            dRow = dTbl.NewRow()
                            dRow("std_dt") = std_dt.Text
                            dRow("cust_cd") = cust_cd.Text
                            dRow("itm_id") = itm_id.Text
                            dRow("file_nm") = fileNm
                            dRow("img") = GetImgByte(fullPath2)
                            dTbl.Rows.Add(dRow)
                            If fullPath2 <> fullPath Then System.IO.File.Delete(fullPath2) 'Local 임시 파일삭제
                        End If
                    End If
                End If
            Next
            g20.UpdateRow()
            Save_Form2()
            'g20.Open()

        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_nm", i) = fileNm Then
                    Return True
                End If
            Next
        End With
        Return False
    End Function

    Private Sub g20_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Function DownLoadFile(ByVal FileNm As String) As Byte()
        DownLoadFile = Nothing

        Dim SetUrl As String = ""

        If local_yn.Checked Then
            SetUrl = url.Text
        Else
            SetUrl = url2.Text
        End If

        Try
            'PATH / (기준일) / (업체코드) / (품명코드) /
            Dim Path As String = std_dt.Text.Substring(0, 10) & "/" & cust_cd.Text & "/" & itm_id.Text & "/"
            Dim wc As WebClient = New WebClient()
            Dim UrlFile As String = SetUrl & Path & FileNm
            Dim buffer As Byte() = wc.DownloadData(UrlFile)

            Return buffer

        Catch ex As Exception
            'If SetUrl = url.Text Then
            '    SetUrl = url2.Text
            'Else
            '    SetUrl = url.Text
            'End If
        End Try
    End Function

    Private Sub GetImageList()
        With g20
            If .RowCount <= 0 Then Exit Sub
            Dim Chg As Boolean = False
            For Row As Integer = 0 To .RowCount - 1
                Try
                    Dim dRow As DataRow = .DataSet.Tables(0).Rows(Row)
                    If dRow("img") Is System.DBNull.Value Then
                        dRow("img") = DownLoadFile(.Text("file_nm", Row))
                        If Not dRow("img") Is System.DBNull.Value Then
                            Chg = True
                            If .Text("main_chk", Row) = "1" Then '대표사진
                                If Not dRow("img") Is System.DBNull.Value Then
                                    Dim img() As Byte = dRow("img")
                                    Dim ms As New System.IO.MemoryStream(img)
                                    master_img.Image = New Bitmap(ms)
                                End If
                                'Else
                                '    If Not master_img.Image Is Nothing Then master_img.Image = Nothing
                            End If
                        End If
                    End If

                Catch ex As Exception

                End Try
            Next

            'If Chg Then
            '    g20.UpdateRow()
            '    g20.DataChanged = True
            '    Me.Save("reg_master_g20")
            '    g20.Open()
            'End If
        End With
    End Sub

    Private Function GetImg(ByVal FileNm As String) As Bitmap
        GetImg = Nothing
        Try
            Dim fr As System.IO.FileStream = New System.IO.FileStream(FileNm, FileMode.Open, FileAccess.Read)
            Dim bytBuffer(fr.Length - 1) As Byte
            fr.Read(bytBuffer, 0, fr.Length)
            fr.Close()
            Dim img() As Byte = bytBuffer
            Dim ms As New System.IO.MemoryStream(img)
            Return New Bitmap(ms)

        Catch ex As Exception

        End Try
    End Function

    Private Function GetImgByte(ByVal FileNm As String) As Byte()
        GetImgByte = Nothing
        Try
            Dim fr As System.IO.FileStream = New System.IO.FileStream(FileNm, FileMode.Open, FileAccess.Read)
            Dim bytBuffer(fr.Length - 1) As Byte
            fr.Read(bytBuffer, 0, fr.Length)
            fr.Close()
            Return bytBuffer

        Catch ex As Exception

        End Try
    End Function

    Private Function SaveResizeImg(FullPath As String, SaveName As String, _
                                   Optional W As Integer = 1024, Optional H As Integer = 768) As String
        SaveResizeImg = ""

        Try
            '**** Thumbnail 이미지 만들기 함수 ****

            ' width : thumbnail 이미지 폭
            ' height: thumbnail 이미지 높이
            ' srcurl: 원본 이미지 경로
            ' thmburl: thumbnail 이미지 경로
            ' imgfmt: thumbnail 이미지 포맷

            '원본 이미지 파일 생성
            Dim ImgOld As Image = New Bitmap(FullPath)
            If ImgOld.Width > W Then
                Dim img As Image = ResizeImage(ImgOld, New Size(W, H))
                'thumbnail 이미지 저장
                img.Save(SaveName, System.Drawing.Imaging.ImageFormat.Jpeg)
                Return SaveName
            Else
                Return FullPath
            End If


            'If img.Width > 300 Then
            '    Dim expansionRectangle As New Rectangle(0, 0, 300, 300)
            '    Dim myGraphics As System.Drawing.dr = New DrawImage(img, 10, 10)

            '    Return SaveName
            'Else
            '    Return FullPath
            'End If


            ''Callback 함수 생성
            ''Dim callback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            'Dim callback As New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            ''Thumbnail 이미지 생성
            'Dim pThumbnail As Image = img.GetThumbnailImage(300, 300, callback, New IntPtr())


            ''Dim tt As System.Drawing.Image = img.GetThumbnailImage(300, 300, callback, New IntPtr()) 'IntPtr.Zero)

            ''thumbnail 이미지 저장
            'pThumbnail.Save(SaveName, System.Drawing.Imaging.ImageFormat.Jpeg)
            ''pThumbnail.Save(SaveName)
            'Return SaveName

        Catch ex As Exception
            MessageWarning(ex.Message)
        End Try
    End Function

    'Public Sub DrawImage4Int(ByVal e As PaintEventArgs)

    '    ' Create image.
    '    Dim newImage As Image = Image.FromFile("SampImag.jpg")

    '    ' Create coordinates for upper-left corner

    '    ' of image and for size of image.
    '    ' Draw image to screen.
    '    e.Graphics.DrawImage(newImage, New Rectangle(0, 0, 300, 300))

    'End Sub

    Private Function ResizeImage(imgToResize As Image, size As Size) As Image
        ResizeImage = Nothing
        Try
            Dim sourceWidth As Integer = imgToResize.Width
            Dim sourceHeight As Integer = imgToResize.Height

            Dim nPercent As Double = 0
            Dim nPercentW As Double = 0
            Dim nPercentH As Double = 0

            nPercentW = (size.Width / sourceWidth)
            nPercentH = (size.Height / sourceHeight)

            If (nPercentH < nPercentW) Then
                nPercent = nPercentH
            Else
                nPercent = nPercentW
            End If

            Dim destWidth As Integer = (sourceWidth * nPercent)
            Dim destHeight As Integer = (sourceHeight * nPercent)

            Dim Img As Bitmap = New Bitmap(destWidth, destHeight)
            Dim g As Graphics = Graphics.FromImage(Img)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight)
            g.Dispose()

            Return Img

        Catch ex As Exception

        End Try

    End Function

    '**** Callback 함수 ****
    Private Function ThumbnailCallback() As Boolean
        Return False
    End Function

End Class
