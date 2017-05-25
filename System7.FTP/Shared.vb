Imports System.Windows.Forms
'Imports Microsoft.Win32
Imports System.Net

Imports Base7.Shared
Imports Base7
Imports Base7.Parameter


Public Class [Shared]

#Region "FTP"

    Public Shared Function GetFtpInfo(ByRef ftp As String, ByRef port As String, ByRef id As String, ByRef pwd As String, ByRef path As String)
        Dim Param As New OpenParameters
        Param.Add("@frm_cd", Parameter.MainFrame.FormCd.Text)
        Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_login", Param)

        'dSet = Open("iPrime", "get_ftp_info")

        If IsEmpty(dSet) Then Return False

        ftp = DataValue(dSet, "ftp_ip")
        port = DataValue(dSet, "ftp_port")
        id = DataValue(dSet, "ftp_id")
        pwd = DataValue(dSet, "ftp_pwd")
        path = DataValue(dSet, "ftp_path")

        If ftp = "" Or port = "" Or id = "" Or pwd = "" Then Return False

        Return True
    End Function

    Public Shared Function FileUpload(Optional ByVal Path As String = "") As String
        'If Path = "" Then Return ""

        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "iFTP"), FileNm As String = ""

        Dim Modal As Object = New frmFTP, FileNm As String = ""
        Modal.Text = "FTP"
        Try

            Dim OpenDialog As New OpenFileDialog
            Dim srcFile As String, FileCnt As Integer = 0

            OpenDialog.Filter = "All files (*.*)|*.*"
            OpenDialog.Multiselect = False

            If OpenDialog.ShowDialog = DialogResult.OK Then
                Dim GetLoc As String = ""
                For Each srcFile In OpenDialog.FileNames
                    '파일명만 분리
                    Dim arr As String()
                    arr = Split(srcFile, "\")
                    GetLoc = srcFile
                    FileNm = arr(arr.Length - 1)
                Next

                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, path2 As String = ""
                GetFtpInfo(Url, Port, ID, PWD, path2)

                If Path = "" Then
                    Path = path2
                End If

                Modal.Jump(Url, Path, ID, PWD, Port)
                Modal.Text = FileNm
                If Not Modal.Login() Then
                    Return ""
                End If
                Modal.Show()

                Dim Size As Double = My.Computer.FileSystem.GetFileInfo(GetLoc).Length
                Dim RtnStr As String() = Modal.GetFileList(Path & "\" & FileNm)
                If Not RtnStr Is Nothing Then
                    If RtnStr.Length > 0 Then
                        Dim FileNm2 As String = RtnStr(0).Trim
                        '해당파일을 삭제

                        If FileNm2 = FileNm Then
                            'PutNote("Y3405") '선택한 파일이 FTP서버에 존재합니다.
                            MessageWarning("선택한 파일이 FTP서버에 존재합니다.")
                            FileDelete(Path, FileNm)
                            '    Modal.Dispose()
                            '    Return ""
                        End If
                    End If
                End If
                Modal.UploadFile(GetLoc, Size)
                FtpHistory(Path, FileNm, "C")
            End If

        Catch ex As Exception
            MessageInfo(ex)
            Modal.Dispose()
            FileNm = ""
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Modal.Dispose()
        End Try

        Return FileNm

    End Function

    'FTP파일 내려받기
    Public Shared Sub FileDownLoad(ByVal FileNm As String, Optional ByVal Path As String = "")

        If FileNm = "" Then Exit Sub
        'If FileNm = "" Or Path = "" Then Exit Sub
        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "iFTP")
        Dim Modal As Object = New frmFTP
        Modal.Text = "FTP"
        Try

            Dim FolderNm As String = TargetFolder()
            If FolderNm <> "" Then
                If System.IO.File.Exists(FolderNm & "\" & FileNm) Then
                    'PutNote("Y3401") '선택하신 폴더에 대상 파일이 있습니다.
                    MessageWarning("선택하신 폴더에 대상 파일이 있습니다.")
                    Open_Proc(FolderNm & "\" & FileNm)
                    Exit Sub
                End If
                Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, path2 As String = ""
                GetFtpInfo(Url, Port, ID, PWD, path2)

                If Path = "" Then
                    Path = path2
                End If

                Modal.Jump(Url, Path, ID, PWD, Port)
                Modal.Text = FileNm
                Modal.Login()

                Windows.Forms.Cursor.Current = Cursors.WaitCursor

                Modal.Show()
                Dim Size As Double = Modal.GetFileSize(FileNm)

                Modal.DownloadFile(FileNm, FolderNm & "\" & FileNm, Size)
                Modal.Dispose()
                FtpHistory(Path, FileNm, "R")
                Windows.Forms.Cursor.Current = Cursors.Default
                Open_Proc(FolderNm & "\" & FileNm)
            End If
            Modal.Dispose()

        Catch ex As Exception
            MessageWarning(ex)
            Modal.Dispose()
        Finally
            Modal.Dispose()
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub


    'FTP파일을 삭제한다
    Public Shared Function FileDelete(ByVal FileNm As String, Optional ByVal Path As String = "") As Boolean

        'If FileNm = "" Or Path = "" Then Return False
        If FileNm = "" Then Return False
        'If PutYesNo("Y3404") = MsgBoxResult.No Then Return False '선택한 파일을 FTP서버에서 삭제하시겠습니까?
        If MessageYesNo("선택한 파일을 FTP서버에서 삭제하시겠습니까?") = MsgBoxResult.No Then Return False
        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "DELETE")
        Dim Modal As Object = New frmFTP
        Modal.Text = "DELETE"
        Try
            Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, path2 As String = ""
            GetFtpInfo(Url, Port, ID, PWD, path2)

            If Path = "" Then
                Path = path2
            End If

            Modal.Jump(Url, Path, ID, PWD, Port)
            Modal.Login()

            Dim Rtn As Boolean = Modal.DeleteFile(FileNm)
            Modal.Dispose()

            If Rtn Then FtpHistory(Path, FileNm, "D")

            Return True
        Catch ex As Exception
            MessageWarning(ex)
            Modal.Dispose()
        Finally
            Modal.Dispose()
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Function

    'FTP History저장
    Private Shared Sub FtpHistory(ByVal path As String, ByVal fileNm As String, ByVal workTy As String)
        Try

            Dim Param As New OpenParameters

            Param.Add("@ftp_path", path)
            Param.Add("@file_nm", fileNm)
            Param.Add("@frm_cd", Parameter.MainFrame.FormCd.Text)
            Param.Add("@reg_id", Parameter.Login.ID)
            Param.Add("@work_ty", workTy)
            Param.Add("@host_nm", Dns.GetHostName())
            Param.Add("@host_ip", GetHostIP())

            Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_history", Param) 'Open("iPrime", "seve_ftp_history", Param)

        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Sub

    Public Shared Function TargetFolder() As String
        TargetFolder = ""
        Try
            Dim TargetDialog As New FolderBrowserDialog, FolderNm As String
            If TargetDialog.ShowDialog = DialogResult.OK Then
                FolderNm = TargetDialog.SelectedPath
                If FolderNm = "" Then
                    'PutWarning("Y3402") '저장될 폴더를 선택하세요
                    MessageWarning("저장될 폴더를 선택하세요")
                    Return ""
                End If
            Else
                Return ""
            End If

            Return FolderNm

        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function

    '다운로드된 파일을 실행한다.
    Public Shared Function Open_Proc(ByRef defPath As String)
        If Not System.IO.File.Exists(defPath) Then Return True
        Try
            Diagnostics.Process.Start(defPath)

        Catch ex As Exception
            MessageWarning(ex)
        Finally
            GC.Collect()
        End Try

        Return True
    End Function

    'Public Shared Function GetHostIP() As String

    '    GetHostIP = ""

    '    Dim Address As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName())
    '    For Each ip As IPAddress In Address
    '        If ip.AddressFamily.ToString = "InterNetwork" Then Return ip.ToString
    '    Next

    'End Function

#End Region
End Class
