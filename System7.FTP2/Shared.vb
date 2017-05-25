Imports System.Windows.Forms
'Imports Microsoft.Win32
Imports System.Net

Imports Base7.Shared
Imports Base7
Imports Base7.Parameter
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Net.Sockets
Imports System.Net.NetworkInformation

Imports System.Security
Imports System.Security.Cryptography

Public Class [Shared]

#Region "FTP"

    Public Shared Function GetFileInfo(ByVal FileID As String, _
                                       ByRef FileNm As String, _
                                       ByRef FileHash As String, _
                                       ByRef FileSize As Long, _
                                       Optional ByVal formCode As String = "")
        Try
            Dim Param As New OpenParameters
            If formCode = "" Then formCode = Parameter.MainFrame.FormCd.Text
            Param.Add("@co_cd", Parameter.Login.CoCd)
            Param.Add("@frm_cd", formCode)
            Param.Add("@file_id", FileID)

            Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_doc_info", Param)
            If Not IsEmpty(dSet) Then
                FileNm = DataValue(dSet, "file_nm")
                FileHash = DataValue(dSet, "file_hash")
                FileSize = ToDec(DataValue(dSet, "file_size"))
            Else
                Return False
            End If
        Catch ex As Exception
            MessageWarning(ex)
            Return False
        End Try
        Return True
    End Function

    Public Shared Function GetFtpInfo(ByVal formCode As String, _
                                      ByRef ftp As String, ByRef port As String, ByRef id As String, ByRef pwd As String, _
                                      ByRef path As String, ByRef TmpPath As String)

        If formCode = "" Then formCode = Parameter.MainFrame.FormCd.Text

        Dim Param As New OpenParameters
        Param.Add("@frm_cd", formCode)
        Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_login", Param)

        If IsEmpty(dSet) Then Return False

        ftp = DataValue(dSet, "ftp_ip")
        port = DataValue(dSet, "ftp_port")
        id = DataValue(dSet, "ftp_id")
        pwd = DataValue(dSet, "ftp_pwd")
        path = DataValue(dSet, "ftp_path")
        TmpPath = DataValue(dSet, "tmp_path")

        If DataValue(dSet, "ping_yn") = "1" Then
            If Ping_Test(ftp, port) = False Then
                MessageWarning("Site에 접속할 수 없습니다.")
                Return False
            End If
        End If

        'Dim m_Ftp_Uri As String = "ftp://" & ftp & ":" & port & path.Replace("\", "/")

        'If Path_Test(m_Ftp_Uri, id, pwd) = False Then
        '    MessageWarning("Site의 경로[" & path.Replace("\", "/") & "]에 접근할 수 없습니다.")
        '    Return False
        'End If

        If ftp = "" Or port = "" Or id = "" Or pwd = "" Then Return False

        Return True
    End Function

    'FTP파일 올리기
    Public Shared Function FileUpload(Optional ByVal ftpPath As String = "", _
                                      Optional ByVal localFileName As String = "", _
                                      Optional ByVal formCode As String = "", _
                                      Optional ByVal MsgYn As Boolean = True,
                                      Optional ByVal DualChk As Boolean = False) As String
        'If Path = "" Then Return ""

        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "iFTP"), FileNm As String = ""

        Dim fileNm As String = "", fileID As String = ""
        Try

            If localFileName = "" Then
                Dim OpenDialog As New OpenFileDialog
                OpenDialog.Filter = "All files (*.*)|*.*"
                OpenDialog.Multiselect = False

                If OpenDialog.ShowDialog = DialogResult.OK Then
                    For Each selectedPath As String In OpenDialog.FileNames
                        localFileName = selectedPath
                    Next
                End If
            End If

            If localFileName = "" Then
                Return ""
            End If

            '파일명만 분리
            fileNm = System.IO.Path.GetFileName(localFileName)

            If fileNm = "" Then
                Return ""
            End If

            If MsgYn Then
                If MessageYesNo("선택한 파일을 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
                    Return ""
                End If
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, ftpPath2 As String = ""
            If GetFtpInfo(formCode, Url, Port, ID, PWD, ftpPath2, "") = False Then Return ""

            If ftpPath = "" Then
                ftpPath = ftpPath2
            End If

            Dim Modal As Object = New frmFTP
            'Dim FileStm As FileStream = Nothing
            Try
                Modal.Text = "FTP"
                Modal.Jump(Url, ftpPath, ID, PWD, Port)
                Modal.Text = " Upload File - " + "[" + fileNm + "]"
                Modal.Show()

                'Dim RtnStr As String() = Modal.GetFileList()
                'If Not RtnStr Is Nothing Then
                '    If RtnStr.Length > 0 Then
                '        For Each FileNm2 As String In RtnStr
                '            '해당파일을 삭제
                '            If FileNm2.ToLower = fileNm.ToLower Then
                '                'PutNote("Y3405") '선택한 파일이 FTP서버에 존재합니다.
                '                MessageWarning("선택한 파일이 파일서버에 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                '                If Not FileDelete(ftpPath, fileNm) Then
                '                    Return ""
                '                End If
                '            End If
                '        Next
                '    End If
                'End If

                'GUID 생성
                Dim GetGUID As Guid = Guid.NewGuid()
                Dim FileStm2 As FileStream = File.OpenRead(localFileName)
                Dim HashStr As String = GetHashBase64(FileStm2)
                FileStm2.Close()
                'FileStm = File.OpenRead(localFileName)
                'Dim MemStream As MemoryStream = New MemoryStream()

                'MemStream = EncryptOrDecryptStream(FileStm, "ABCD", CryptoAction.ActionEncrypt)

                '중복확인
                If DualChk Then
                    If DualCheck(HashStr, formCode) <> "" Then
                        MessageWarning("선택한 파일이 파일서버에 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                        Return ""
                    End If
                End If

                Dim f As New System.IO.FileInfo(localFileName)
                Dim Sz As Long = f.Length
                'fileID = Modal.UploadFile(GetGUID.ToString, MemStream)
                'fileID = Modal.UploadFile(GetGUID.ToString, FileStm)
                fileID = Modal.UploadFile(localFileName, GetGUID.ToString, Sz)
                'fileID = Modal.UploadFile(localFileName, fileNm, Sz)

                If fileID <> "" Then FtpDoc(fileID, fileNm, HashStr, Sz, , , formCode)

            Catch ex As Exception

            Finally
                'If Not FileStm Is Nothing Then FileStm.Close()
                Modal.Dispose()
            End Try

        Catch ex As Exception
            MessageInfo(ex)
            fileID = ""
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default

        End Try

        Return fileID

    End Function

    'FTP파일 내려받기
    Public Shared Sub FileDownLoad(ByVal FileID As String, _
                                   Optional ByVal FileNm As String = "", _
                                   Optional ByVal Path As String = "", _
                                   Optional ByVal show As Boolean = False, _
                                   Optional ByVal formCode As String = "", _
                                   Optional ByVal LocalPath As String = "")

        If FileID = "" Then Exit Sub
        'If FileNm = "" Or Path = "" Then Exit Sub
        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "iFTP")
        Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, path2 As String = "", TmpPath As String = ""
        If GetFtpInfo(formCode, Url, Port, ID, PWD, path2, TmpPath) = False Then Exit Sub
        Dim FolderNm As String = ""
        Dim DelChk As Boolean = False '보안정책에 의한 삭제처리
        Dim FNm As String = "", FSz As Long
        GetFileInfo(FileID, FNm, "", FSz, formCode)

        If FileNm = "" Then FileNm = FNm

        Try

            If TmpPath <> "" Then
                LocalPath = TmpPath
                DelChk = True
            End If

            FolderNm = TargetFolder(show, LocalPath, DelChk)

            If FolderNm <> "" Then
                If File.Exists(FolderNm & "\" & FileNm) Then
                    'PutNote("Y3401") '선택하신 폴더에 대상 파일이 있습니다.
                    If MessageYesNo("선택하신 폴더에 대상 파일이 있습니다." + vbLf + _
                                    "기존파일을 삭제하고 다시 받으시겠습니까 ?" + vbLf + vbLf + _
                                    "[" + FileNm + "]") = MsgBoxResult.No Then
                        If show Then
                            Open_Proc(FolderNm & "\" & FileNm)
                        End If
                        Exit Sub
                    Else
                        If FileAvailable(FolderNm & "\" & FileNm) Then
                            File.Delete(FolderNm & "\" & FileNm)
                        Else
                            Exit Sub
                        End If
                    End If
                End If

                If Path = "" Then
                    Path = path2
                End If

                Dim Modal As Object = New frmFTP

                Try
                    Modal.Text = "FTP"
                    Modal.Jump(Url, Path, ID, PWD, Port)
                    Modal.Text = " Download File - " + "[" + FileNm + "]"

                    Windows.Forms.Cursor.Current = Cursors.WaitCursor

                    Modal.Show()
                    'Dim MemStream As MemoryStream = New MemoryStream()
                    'MemStream = EncryptOrDecryptStream(Modal.DownloadStream(FileID), "ABCD", CryptoAction.ActionDecrypt)
                    Modal.DownloadFile(FileID, FolderNm & "\" & FileNm, FSz)
                    Modal.Dispose()

                    'Dim DownloadedData As Byte() = New Byte(0) {}

                    ''Convert the downloaded stream to a byte array
                    'DownloadedData = MemStream.ToArray()
                    ''Clean up
                    'MemStream.Close()

                    'If DownloadedData.Length <> 0 Then
                    '    Application.DoEvents()

                    '    'Write the bytes to a file
                    '    Dim newFile As FileStream = New FileStream(FolderNm & "\" & FileNm, FileMode.Create)
                    '    Try
                    '        newFile.Write(DownloadedData, 0, DownloadedData.Length)
                    '    Catch ex As Exception
                    '    Finally
                    '        newFile.Close()
                    '    End Try
                    'End If

                    FtpHistory(Path, FileNm, "R", formCode)
                    Windows.Forms.Cursor.Current = Cursors.Default
                    If show Then
                        Open_Proc(FolderNm & "\" & FileNm)
                    End If

                Catch ex As Exception

                Finally
                    Modal.Dispose()
                End Try

            End If

        Catch ex As Exception
            MessageWarning(ex)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

        'Try
        '    path2 = path2.Replace("\", "/")
        '    '형식:ftp://ID:Password@Url:Port/path
        '    FolderNm = "ftp://" & ID & ":" & PWD & "@" & Url & ":" & Port & path2
        '    Open_Proc(FolderNm & "/" & FileNm)

        'Catch ex As Exception
        '    MessageWarning(ex)
        'End Try

    End Sub

    'FTP파일을 삭제한다
    Public Shared Function FileDelete(ByVal FileID As String, ByVal FileNm As String, _
                                      Optional ByVal Path As String = "", _
                                      Optional ByVal formCode As String = "", _
                                      Optional MsgYn As Boolean = True) As Boolean

        'If FileNm = "" Or Path = "" Then Return False
        If FileID = "" Then Return False
        'If PutYesNo("Y3404") = MsgBoxResult.No Then Return False '선택한 파일을 FTP서버에서 삭제하시겠습니까?

        If MsgYn Then
            If MessageYesNo("선택한 파일을 파일서버에서 삭제하시겠습니까?" + vbLf + vbLf + "[" + FileNm + "]") = MsgBoxResult.No Then
                Return False
            End If
        End If

        'Dim Modal As Object = iParams.ParentControl.LoadModalForm("iFTP", "DELETE")

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim Url As String = "", ID As String = "", PWD As String = "", Port As Integer = 0, path2 As String = ""
            If GetFtpInfo(formCode, Url, Port, ID, PWD, path2, "") = False Then Return False

            If Path = "" Then
                Path = path2
            End If
            Dim Modal As Object = New frmFTP

            Try
                Modal.Text = "DELETE"
                Modal.Jump(Url, Path, ID, PWD, Port)

                Dim RtnStr As String() = Modal.GetFileList()
                Dim Rtn As Boolean = False
                If Not RtnStr Is Nothing Then
                    If RtnStr.Length > 0 Then
                        For Each FileNm2 As String In RtnStr
                            '해당파일을 삭제
                            If FileNm2.ToLower = FileID.ToLower Then
                                Rtn = Modal.DeleteFile(FileID)
                                Modal.Dispose()

                                If Rtn Then
                                    FtpHistory(Path, FileNm, "D", formCode)
                                End If
                                'Return Rtn
                            End If
                        Next
                    End If
                Else
                    Rtn = True
                End If
                'FileList정보에서 파일삭제
                If Rtn Then FtpDoc(FileID, FileNm, "", 0, , True, formCode)
                Return Rtn

            Catch ex As Exception

            Finally
                Modal.Dispose()
            End Try

            Return True
        Catch ex As Exception
            MessageWarning(ex)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Function

    'FTP File정보 저장/삭제
    Private Shared Sub FtpDoc(ByVal fileId As String, _
                              ByVal fileNm As String, _
                              ByVal Hash As String, _
                              ByVal fileSz As Long, _
                              Optional ByVal Pwd As String = "", _
                              Optional DelYn As Boolean = False, _
                              Optional formCode As String = "")
        Try
            Dim DelChk As String = "0"
            If DelYn Then
                DelChk = "1"
            End If
            If formCode = "" Then formCode = Parameter.MainFrame.FormCd.Text
            Dim Param As New OpenParameters, Rmks As String = ""
            If formCode <> Parameter.MainFrame.FormCd.Text Then Rmks = Parameter.MainFrame.FormCd.Text
            Param.Add("@co_cd", Parameter.Login.CoCd)
            Param.Add("@frm_cd", formCode)
            Param.Add("@file_id", fileId)
            Param.Add("@file_nm", fileNm)
            Param.Add("@file_hash", Hash)
            Param.Add("@file_size", fileSz)
            Param.Add("@pwd", Pwd)
            Param.Add("@work_ty", DelChk)
            Param.Add("@rmks", Rmks)

            Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_doc", Param)

        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Sub

    'FTP File정보 중복확인
    Public Shared Function DualCheckPath(ByVal GetFullPath As String) As String
        DualCheckPath = ""
        Try
            Dim HashCode As String = GetHashBase64(File.OpenRead(GetFullPath))
            Return DualCheck(HashCode)
        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function

    Public Shared Function DualCheckStream(ByVal GetFileStream As FileStream) As String
        DualCheckStream = ""
        Try
            Dim HashCode As String = GetHashBase64(GetFileStream)
            Return DualCheck(HashCode)
        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function

    Private Shared Function DualCheck(ByVal HashCode As String, _
                                    Optional formCode As String = "") As String
        DualCheck = ""
        Try

            Dim dSet As DataSet = DualCheckdSet(HashCode, formCode)
            If Not IsEmpty(dSet) Then
                Return DataValue(dSet)
            End If
            Return ""
        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function

    Private Shared Function DualCheckdSet(ByVal HashCode As String, _
                                            Optional formCode As String = "") As DataSet
        DualCheckdSet = Nothing
        Try
            If formCode = "" Then formCode = Parameter.MainFrame.FormCd.Text
            Dim Param As New OpenParameters

            Param.Add("@co_cd", Parameter.Login.CoCd)
            Param.Add("@frm_cd", formCode)
            Param.Add("@file_hash", HashCode)

            Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_doc_check", Param)
            Return dSet
        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function


    'FTP History저장
    Private Shared Sub FtpHistory(ByVal path As String, ByVal fileNm As String, ByVal workTy As String, _
                              Optional formCode As String = "")
        Try

            Dim Param As New OpenParameters
            If formCode = "" Then formCode = Parameter.MainFrame.FormCd.Text
            Param.Add("@ftp_path", path)
            Param.Add("@file_nm", fileNm)
            Param.Add("@frm_cd", formCode)
            Param.Add("@reg_id", Parameter.Login.RegId)
            Param.Add("@work_ty", workTy)
            Param.Add("@host_nm", Dns.GetHostName())
            Param.Add("@host_ip", GetHostIP())

            Dim dSet As DataSet = Link.ReadDataSet("system_manager_ftp_history", Param) 'Open("iPrime", "seve_ftp_history", Param)

        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Sub

    Private Shared m_TargetFolder As String

    Public Shared Function TargetFolder(ByVal show As Boolean, Optional Path As String = "", Optional DelChk As Boolean = False) As String

        If Path <> "" Then
            '해당폴더가 없는 경우 생성
            If DelChk Then
                Try

                    If Directory.Exists(Path) Then
                        Try
                            Directory.Delete(Path, True)
                        Catch ex As Exception

                        End Try

                    End If

                    Try
                        Dim Dir As New DirectoryInfo(Path)

                        If Directory.Exists(Path) Then
                            For Each FileNm As String In Dir.GetFiles().ToString
                                If FileAvailable(FileNm) Then
                                    File.Delete(FileNm)
                                End If
                            Next
                        End If

                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                End Try

                If Not Directory.Exists(Path) Then MkDir(Path)
            End If

            m_TargetFolder = Path
            Return Path
        End If

        '파일보기만 할 때는 기존 선택된 폴더를 이용
        If show Then
            If m_TargetFolder <> "" Then
                Return m_TargetFolder
            End If
        End If

        'Download 할때는 폴더를 선택하게 한다
        TargetFolder = ""
        Try
            Dim TargetDialog As New FolderBrowserDialog, FolderNm As String
            If TargetDialog.ShowDialog = DialogResult.OK Then
                FolderNm = TargetDialog.SelectedPath
                If FolderNm = "" Then
                    'PutWarning("Y3402") '저장될 폴더를 선택하세요
                    MessageWarning("저장될 폴더를 선택하세요.")
                    Return ""
                End If
            Else
                Return ""
            End If

            m_TargetFolder = FolderNm
            Return FolderNm

        Catch ex As Exception
            MessageWarning(ex)
        End Try
    End Function

    '파일 사용여부 확인
    Public Shared Function FileAvailable(ByVal FileNm As String) As Boolean
        If Not File.Exists(FileNm) Then
            Return False
        End If
        Try
            Using inputStream As FileStream = File.Open(FileNm, FileMode.Open, FileAccess.Read, FileShare.None)
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    '다운로드된 파일을 실행한다.
    Public Shared Function Open_Proc(ByRef defPath As String)
        If Not System.IO.File.Exists(defPath) Then Return True
        Try
            Dim Ext As String = Microsoft.VisualBasic.Right(defPath, 3).ToLower
            If Ext = "msi" Or Ext = "exe" Or Ext = "bat" Then
                If MessageYesNo("실행파일을 실행하시겠습니까?") <> MsgBoxResult.Yes Then Return True
                Diagnostics.Process.Start(defPath)
            Else
                Diagnostics.Process.Start(defPath)
            End If
        Catch ex As Exception
            MessageWarning(ex)
        Finally
            GC.Collect()
        End Try

        Return True
    End Function

    Public Shared Function Ping_Test(ByRef IP As String, Port As Integer) As Boolean
        Try
            'IP Address 할당 
            Dim IP_Address = IPAddress.Parse(IP)

            'TCP Client 선언
            Dim Tcp_Client = New TcpClient(AddressFamily.InterNetwork)

            Dim PingSdr As Ping = New Ping()
            Dim Opt As PingOptions = New PingOptions()

            ' Use the default Ttl value which is 128,
            ' but change the fragmentation behavior.

            Opt.DontFragment = True

            ' Create a buffer of 32 bytes of data to be transmitted.
            Dim Str As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            Dim Buffer As Byte() = Encoding.ASCII.GetBytes(Str)
            Dim TimeOut As Integer = 120
            Dim Reply As PingReply = PingSdr.Send(IP_Address, TimeOut, Buffer, Opt)

            If Reply.Status = IPStatus.Success Then
                ' Ping 성공시 Connect 연결 시도
                Tcp_Client.NoDelay = True
                Tcp_Client.Connect(IP_Address, Port)

                Dim ntwStream As Stream = Tcp_Client.GetStream()
            Else
                ' Ping 실패시 강제 Exception
                Throw New Exception()
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Path_Test(Url As String, ID As String, Pwd As String) As Boolean
        Dim mess() As String = Nothing
        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(Url))
            request.Credentials = New NetworkCredential(ID, Pwd)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.ListDirectory

            Dim sr As New StreamReader(request.GetResponse().GetResponseStream())
            ' Return the final result.
            Return True

        Catch ex As Exception
            'MessageError(ex)
            Return False
        End Try

    End Function

    'Net Use를 실행한다.
    'NET USE \\Path PWD/user:ID
    'NET USE \\Path /d
    Public Shared Function NetUse(ByRef Path As String, ID As String, PWD As String, DelChk As Boolean)

        If Path.Substring(0, 2) <> "\\" Then
            Path = "\\" & Path
        End If

        Dim Cmd As String = "NET USE " & Path

        If DelChk Then
            Cmd &= "/d"
            Diagnostics.Process.Start(Cmd)
        Else
            Cmd &= PWD & "/user:" & ID
            Diagnostics.Process.Start(Cmd)
        End If

        Dim p As New Diagnostics.Process
        With p.StartInfo
            .WorkingDirectory = "%HOMEDRIVE%%HOMEPATH%"
            .UseShellExecute = True
            '.FileName = "mstsc.exe"
            .Arguments = Cmd
        End With

        If p.Start() Then
            p.WaitForExit()
        End If


        'If Not System.IO.File.Exists(defPath) Then Return True
        'Try
        '    Diagnostics.Process.Start(defPath)

        'Catch ex As Exception
        '    MessageWarning(ex)
        'Finally
        '    GC.Collect()
        'End Try

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

    'Hash를 생성한다.
    Public Shared Function GetHashBase64(ByVal GetBinary As Byte()) As String

        GetHashBase64 = ""

        Try
            If Not GetBinary Is Nothing Then
                '입력받은 Binary를 Hash로 변경
                Dim md5 As MD5 = New MD5CryptoServiceProvider()
                Dim Result As Byte() = md5.ComputeHash(GetBinary)

                Dim Base64Str As String = Convert.ToBase64String(Result, 0, Result.Length)

                Return Base64Str
            Else
                Return ""
            End If

        Catch ex As Exception

        End Try

    End Function

    'Hash를 생성한다.
    Public Shared Function GetHashBase64(ByVal GetFileStream As FileStream) As String

        GetHashBase64 = ""

        Try
            If Not GetFileStream Is Nothing Then
                '입력받은 FileStream을 Hash로 변경
                Dim md5 As MD5 = New MD5CryptoServiceProvider()
                Dim Result As Byte() = md5.ComputeHash(GetFileStream)

                Dim Base64Str As String = Convert.ToBase64String(Result, 0, Result.Length)

                Return Base64Str
            Else
                Return ""
            End If

        Catch ex As Exception

        End Try

    End Function

    'Hash를 생성한다.
    Public Shared Function GetHashBase64(ByVal GetMemStream As MemoryStream) As String

        GetHashBase64 = ""

        Try
            If Not GetMemStream Is Nothing Then
                '입력받은 MemoryStream을 Hash로 변경
                Dim md5 As MD5 = New MD5CryptoServiceProvider()
                Dim Result As Byte() = md5.ComputeHash(GetMemStream)

                Dim Base64Str As String = Convert.ToBase64String(Result, 0, Result.Length)

                Return Base64Str
            Else
                Return ""
            End If

        Catch ex As Exception

        End Try

    End Function

    '숫자형 문자를 입력받아 자리수에 맞는 값을 반환한다.
    'ex)0030300 DecDot(0030300,3) => 30.3
    Public Shared Function DecDot(ByVal GetVal As String, Optional ByVal Dot As Integer = 0) As Double
        GetVal = ToDec(GetVal)
        If GetVal = 0 Then Return 0

        If Dot > 0 Then
            Dim LVal As String = "", RVal As String = ""
            If Dot >= GetVal.Length Then
                LVal = "0"
                RVal = StrDup(Dot - GetVal.Length, "0") & GetVal
                Return (ToDec(LVal & "." & RVal))
            Else
                RVal = Microsoft.VisualBasic.Right(GetVal, Dot)
                LVal = GetVal.Substring(0, GetVal.Length - Dot)
            End If
            Return (ToDec(LVal & "." & RVal))
        Else
            Return GetVal
        End If

    End Function

    '숫자형을 입력받아 자리수에 맞는 문자열값을 반환한다.
    'ex)30.3 DotDec(30.3,5,3) => 30300
    'ex)30 DotDec(30,5,3) => 30000
    Public Function DotDec(ByVal GetVal As Double, ByVal TotLen As Integer, ByVal SubLen As Integer) As String
        DotDec = ""

        If ToDec(GetVal) = 0 Or ToDec(TotLen) = 0 Then Return ""
        Dim ValStr As String = GetVal.ToString

        Dim DimStr() As String = ValStr.Split(".")
        Dim RtnStrA As String = ToDec(DimStr(0)), RtnStrB As String = ""
        If DimStr.Length > 1 Then RtnStrB = ToDec(DimStr(1))

        Dim Dif As Integer = 0
        Dim RtnStr As String = ""

        If ToDec(RtnStrB) = 0 Then '순수정수
            RtnStr = ValStr & StrDup(SubLen - RtnStrB.Length, "0")
            Dif = TotLen - RtnStr.Length

            Select Case Dif
                Case Is > 0
                    RtnStr = StrDup(Dif, "0") & RtnStr
                    Return RtnStr
                Case Is = 0
                    Return RtnStr
                Case Is < 0
                    Return Microsoft.VisualBasic.Left(RtnStr, TotLen)
            End Select
        Else

            If TotLen = SubLen Then Return RtnStrB

            Dif = TotLen - SubLen - RtnStrA.Length

            Select Case Dif
                Case Is > 0
                    RtnStrA = StrDup(Dif, "0") & RtnStrA
                Case Is < 0
                    Return RtnStrA & RtnStrB
            End Select

            Dif = SubLen - RtnStrB.Length

            Select Case Dif
                Case Is > 0
                    RtnStrB &= StrDup(Dif, "0")
                Case Is < 0
                    RtnStrB = RtnStrB.Substring(0, SubLen)
            End Select

            RtnStr = RtnStrA & RtnStrB

            Return RtnStr
        End If

    End Function

    '2000-01-01 00:00:00부터 현재까지 지난초를 16진수로 변환
    Public Shared Function TM_SEC2HEX(Optional ByVal DateStr As String = "") As String

        TM_SEC2HEX = ""
        If DateStr = "" Then DateStr = "2000-01-01 00:00:00"
        Dim SrtData As Date = DateStr
        Return Hex(DateDiff(DateInterval.Second, SrtData, Now))

    End Function

    'DownLoadData From WebService
    Public Shared Function WebServiceDownLoadData(ByVal GetUrl As String, ByVal FileNm As String) As Byte()
        WebServiceDownLoadData = Nothing
        Try
            Dim wc As WebClient = New WebClient()
            Dim UrlFile As String = GetUrl & "/" & FileNm
            Dim buffer As Byte() = wc.DownloadData(UrlFile)

            Return buffer

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    'Image Resize
    Public Shared Function ImageResize(GetImage As System.Drawing.Image,
                                        Optional ResizeW As Long = 1024,
                                        Optional ResizeH As Long = 768) As System.Drawing.Image
        ImageResize = Nothing

        Try
            Dim OrgWidth As Integer = GetImage.Width
            Dim OrgHeight As Integer = GetImage.Height

            Dim nPercent As Double = 0, nPercentW As Double = 0, nPercentH As Double = 0

            nPercentW = (ResizeW / OrgWidth)
            nPercentH = (ResizeH / OrgHeight)

            'Resize비율 가져오기
            If (nPercentH < nPercentW) Then
                nPercent = nPercentH
            Else
                nPercent = nPercentW
            End If

            Dim NewWidth As Integer = (OrgWidth * nPercent)
            Dim NewHeight As Integer = (OrgHeight * nPercent)

            Dim Img As System.Drawing.Bitmap = New System.Drawing.Bitmap(NewWidth, NewHeight)
            Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(Img)

            'HighQualityBicubic : 고품질 이중 큐빅 보간을 지정합니다.
            '                     고품질 축소를 보장하기 위해 사전 필터링이 수행됩니다.
            '                     이 모드에서는 최고 품질의 변환 이미지가 만들어집니다.
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic

            g.DrawImage(GetImage, 0, 0, NewWidth, NewHeight)
            g.Dispose()

            Return Img

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Function

#Region "Thumbnail"
    'GetThumbnailImage 메서드는 요청된 축소판 그림 이미지의 크기가 120 x 120픽셀 정도인 경우 제대로 작동합니다.
    '포함된 축소판 그림이 있는 Image에서 300 x 300 정도의 큰 축소판 그림 이미지를 요청한 경우 축소판 그림 이미지의 화질이 크게 떨어질 수 있습니다. 
    '포함된 축소판 그림의 배율을 조정하는 것보다는 DrawImage 메서드를 호출하여 기본 이미지의 배율을 조정하는 것이 더 좋은 방법입니다. 
    Public Shared Function ImageThumbnail(GetImage As System.Drawing.Image,
                                Optional ResizeW As Long = 120,
                                Optional ResizeH As Long = 120) As System.Drawing.Image
        ImageThumbnail = Nothing

        Try
            If ResizeW > 120 Then ResizeW = 120
            If ResizeH > 120 Then ResizeH = 120

            'Callback 함수 생성
            Dim CallBack As New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            'Thumbnail 이미지 생성
            Dim Thumbnail As System.Drawing.Image = GetImage.GetThumbnailImage(ResizeW, ResizeH, CallBack, New IntPtr())
            Return Thumbnail

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Function

    '**** Callback 함수 ****
    Private Shared Function ThumbnailCallback() As Boolean
        Return False
    End Function
#End Region

#Region "EncryptDecrypt"
    '•The function receives a string (the password). 
    '•Converts the string to an array. 
    '•Converts the array to a byte. 
    '•Uses SHA512 to hash the byte. 
    '•Stores the first 256 bits of the hashed byte into a new byte (the key). 
    '•Returns the key. 

    '*************************
    '** Create A Key
    '*************************
    Public Shared Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

    '*************************
    '** Create An IV
    '*************************
    Public Shared Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of bytResult into bytIV.
        'The 0 To 30 for bytKey used the first 256 bits of the hashed password.
        'The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'Return the IV.
    End Function

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Public Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Public Shared Function EncryptOrDecryptStream(ByVal sFileStream As FileStream, _
                                                ByVal Password As String, _
                                                ByVal Direction As CryptoAction) As MemoryStream

        EncryptOrDecryptStream = Nothing

        Dim Msg As String = ""
        If Direction = CryptoAction.ActionEncrypt Then
            Msg = "암호화"
        Else
            Msg = "복호화"
        End If

        Dim bytKey() As Byte = CreateKey(Password)
        Dim bytIV() As Byte = CreateIV(Password)

        'Setup file streams to handle input and output.
        Dim memStream As MemoryStream = New MemoryStream()

        Try

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = sFileStream.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Dim csCryptoStream As CryptoStream = Nothing

            Try

                'Determine if ecryption or decryption and setup CryptoStream.
                Select Case Direction
                    Case CryptoAction.ActionEncrypt
                        csCryptoStream = New CryptoStream(memStream, _
                                                        cspRijndael.CreateEncryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Write)

                    Case CryptoAction.ActionDecrypt
                        csCryptoStream = New CryptoStream(memStream, _
                                                        cspRijndael.CreateDecryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Write)
                End Select

                'Use While to loop until all of the file is processed.
                While lngBytesProcessed < lngFileLength
                    'Read file with the input filestream.
                    intBytesInCurrentBlock = sFileStream.Read(bytBuffer, 0, 4096)
                    'Write output file with the cryptostream.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    'Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed + _
                                            CLng(intBytesInCurrentBlock)
                End While

            Catch ex As Exception

            Finally
                'Close FileStreams and CryptoStream.
                'If Not csCryptoStream Is Nothing Then csCryptoStream.Close()
            End Try

            Return memStream

        Catch ex As Exception
            MessageError(ex)
        Finally

        End Try

    End Function

    Public Shared Function EncryptOrDecryptStream(ByVal sFullPath As String, _
                                            ByVal Password As String, _
                                            ByVal Direction As CryptoAction) As MemoryStream

        EncryptOrDecryptStream = Nothing

        Dim Msg As String = ""
        If Direction = CryptoAction.ActionEncrypt Then
            Msg = "암호화"
        Else
            Msg = "복호화"
        End If

        Dim bytKey() As Byte = CreateKey(Password)
        Dim bytIV() As Byte = CreateIV(Password)

        'Setup file streams to handle input and output.

        Dim fsInput As System.IO.FileStream = New System.IO.FileStream(sFullPath, FileMode.Open, _
                                              FileAccess.Read)
        Dim memStream As MemoryStream = New MemoryStream()

        Try

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Dim csCryptoStream As CryptoStream = Nothing

            Try

                'Determine if ecryption or decryption and setup CryptoStream.
                Select Case Direction
                    Case CryptoAction.ActionEncrypt
                        csCryptoStream = New CryptoStream(memStream, _
                                                        cspRijndael.CreateEncryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Write)

                    Case CryptoAction.ActionDecrypt
                        csCryptoStream = New CryptoStream(memStream, _
                                                        cspRijndael.CreateDecryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Write)
                End Select

                'Use While to loop until all of the file is processed.
                While lngBytesProcessed < lngFileLength
                    'Read file with the input filestream.
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                    'Write output file with the cryptostream.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    'Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed + _
                                            CLng(intBytesInCurrentBlock)
                End While

            Catch ex As Exception

            Finally
                'Close FileStreams and CryptoStream.
                If Not csCryptoStream Is Nothing Then csCryptoStream.Close()
                fsInput.Close()
            End Try

            Return memStream

        Catch ex As Exception
            MessageError(ex)
        Finally

        End Try

    End Function

    Public Shared Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                                ByVal strOutputFile As String, _
                                                ByVal Password As String, _
                                                ByVal Direction As CryptoAction)

        Dim Msg As String = ""
        If Direction = CryptoAction.ActionEncrypt Then
            Msg = "암호화"
        Else
            Msg = "복호화"
        End If

        Dim bytKey() As Byte = CreateKey(Password)
        Dim bytIV() As Byte = CreateIV(Password)

        'Setup file streams to handle input and output.

        Dim fsInput As System.IO.FileStream = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                              FileAccess.Read)
        Dim fsOutput As System.IO.FileStream = New System.IO.FileStream(strOutputFile, _
                                               FileMode.OpenOrCreate, _
                                               FileAccess.Write)
        Try
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            Dim csCryptoStream As CryptoStream = Nothing

            Try

                'Determine if ecryption or decryption and setup CryptoStream.
                Select Case Direction
                    Case CryptoAction.ActionEncrypt
                        csCryptoStream = New CryptoStream(fsInput, _
                                                        cspRijndael.CreateEncryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Read)

                    Case CryptoAction.ActionDecrypt
                        csCryptoStream = New CryptoStream(fsInput, _
                                                        cspRijndael.CreateDecryptor(bytKey, bytIV), _
                                                        CryptoStreamMode.Read)
                End Select

                'Use While to loop until all of the file is processed.
                While lngBytesProcessed < lngFileLength
                    'Read file with the input filestream.
                    intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                    'Write output file with the cryptostream.
                    csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                    'Update lngBytesProcessed
                    lngBytesProcessed = lngBytesProcessed + _
                                            CLng(intBytesInCurrentBlock)
                    '    ''Update Progress Bar
                    '    'pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
                End While
            Catch ex As Exception

            Finally
                'Close FileStreams and CryptoStream.
                If Not csCryptoStream Is Nothing Then csCryptoStream.Close()
                fsInput.Close()
                fsOutput.Close()
            End Try
            'Return sReader

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

#End Region

#Region "CompressDecompress"
    'Gzip 을 사용해 문자열 압축
    '4GB보다 큰 파일을 압축하면 예외가 발생합니다.

    Public Shared Function CompressText(GetText As String) As String

        CompressText = ""
        Dim buffer As Byte() = Encoding.UTF8.GetBytes(GetText)
        Dim MemStream As MemoryStream = New MemoryStream()
        Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Compress, True)
        Try
            zip.Write(buffer, 0, buffer.Length)
            MemStream.Position = 0
            Dim compressed(MemStream.Length) As Byte
            MemStream.Read(compressed, 0, compressed.Length)

            Return Convert.ToBase64String(compressed)
            'Dim gzBuffer(compressed.Length + 4) As Byte
            'System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length)
            'System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4)
            'Return Convert.ToBase64String(gzBuffer)

        Catch ex As Exception
            MessageError(ex)
        Finally
            zip.Close()
            MemStream.Close()
        End Try
    End Function

    Public Shared Function CompressStream(GetStream As MemoryStream) As MemoryStream

        CompressStream = Nothing
        Dim buffer(GetStream.Length) As Byte
        Dim MemStream As MemoryStream = New MemoryStream()
        Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Compress)

        Try
            GetStream.Read(buffer, 0, buffer.Length)
            zip.Write(buffer, 0, buffer.Length)
            MemStream.Position = 0
            Return MemStream

        Catch ex As Exception
            MessageError(ex)
        Finally
            zip.Close()
            MemStream.Close()
        End Try
    End Function

    Public Shared Function CompressStream(GetStream As FileStream) As MemoryStream

        CompressStream = Nothing
        Dim buffer(1024 * 1000) As Byte
        Dim sFileSize As Double = GetStream.Length
        Dim MemStream As MemoryStream = New MemoryStream()
        Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Compress, True)
        Dim lngBytesProcessed As Long = 0 'running count of bytes processed

        Try
            While lngBytesProcessed < sFileSize
                Dim bytesRead As Integer = GetStream.Read(buffer, 0, buffer.Length)
                zip.Write(buffer, 0, buffer.Length)
                lngBytesProcessed += bytesRead
            End While

            MemStream.Position = 0
            Return MemStream

        Catch ex As Exception
            MessageError(ex)
        Finally
            zip.Close()
        End Try
    End Function

    'Gzip을 이용한 압축 해제
    Public Shared Function DecompressText(CompressedText As String) As String
        DecompressText = ""
        Dim MemStream As MemoryStream = New MemoryStream()
        Try
            Dim gzBuffer As Byte() = Convert.FromBase64String(CompressedText)
            Dim msgLength As Long = BitConverter.ToInt32(gzBuffer, 0)
            MemStream.Write(gzBuffer, 0, gzBuffer.Length)

            Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Decompress)

            Try
                zip.Read(gzBuffer, 0, gzBuffer.Length)
                Return Encoding.UTF8.GetString(gzBuffer)
            Catch ex As Exception
            Finally
                zip.Close()
                MemStream.Close()
            End Try

            'Dim msgLength As Long = BitConverter.ToInt32(GZBuffer, 0)
            'MemStream.Write(GZBuffer, 4, GZBuffer.Length - 4)
            'Dim buffer(msgLength) As Byte
            'MemStream.Position = 0

            'Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Decompress)

            'Try
            '    zip.Read(buffer, 0, buffer.Length)
            '    Return Encoding.UTF8.GetString(buffer)
            'Catch ex As Exception
            'Finally
            '    zip.Close()
            '    MemStream.Close()
            'End Try

        Catch ex As Exception
            MessageError(ex)
        Finally
        End Try
    End Function

    Public Shared Function DecompressStream(GetCompStream As MemoryStream) As MemoryStream
        DecompressStream = Nothing
        Dim MemStream As MemoryStream = New MemoryStream()
        Try
            Dim gzBuffer(GetCompStream.Length) As Byte
            Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Decompress)

            Try
                GetCompStream.Read(gzBuffer, 0, gzBuffer.Length)
                zip.Read(gzBuffer, 0, gzBuffer.Length)
                MemStream.Position = 0
                Return MemStream
            Catch ex As Exception
            Finally
                zip.Close()
            End Try

        Catch ex As Exception
            MessageError(ex)
        Finally

        End Try
    End Function

    Public Shared Function DecompressStream(GetCompStream As FileStream) As MemoryStream
        DecompressStream = Nothing
        Dim MemStream As MemoryStream = New MemoryStream()
        Try
            Dim gzBuffer(1024 * 1000) As Byte
            Dim sFileSize As Long = GetCompStream.Length
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed

            Dim zip As GZipStream = New GZipStream(MemStream, CompressionMode.Decompress)

            Try
                While lngBytesProcessed < sFileSize
                    Dim bytesRead As Integer = GetCompStream.Read(gzBuffer, 0, gzBuffer.Length)
                    zip.Read(gzBuffer, 0, gzBuffer.Length)
                    lngBytesProcessed += bytesRead
                End While
                MemStream.Position = 0
                Return MemStream
            Catch ex As Exception
            Finally
                zip.Close()
            End Try

        Catch ex As Exception
            MessageError(ex)
        Finally

        End Try
    End Function
#End Region
End Class
