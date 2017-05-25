Imports Base7
Imports Base7.Shared

Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Net.Sockets
Imports System.Windows.Forms

Public Class frmFTP

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadForm(Me)
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub

    Public Sub Jump(ByVal GetHost As String, ByVal GetPath As String, _
                    ByVal GetUser As String, ByVal GetPass As String, _
                    ByVal GetPort As Integer)

        m_sRemoteHost = GetHost
        m_sRemotePath = GetPath.Replace("\", "")
        m_sRemoteUser = GetUser
        m_sRemotePassword = GetPass
        m_iRemotePort = GetPort

        m_Ftp_Uri = "ftp://" & GetHost & ":" & GetPort & GetPath.Replace("\", "/")
        pBar2.Properties.ShowTitle = True
        pBar2.Properties.Minimum = 0
        pBar2.Properties.Maximum = 100
        pBar2.Position = pBar2.Properties.Minimum

    End Sub

#Region "Declarations"
    Private m_sRemoteHost, m_sRemotePath, m_sRemoteUser As String
    Private m_sRemotePassword, m_sMess, m_Ftp_Uri As String
    Private m_iRemotePort, m_iBytes As Int32

    Private m_bLoggedIn As Boolean = False    ' Change to loggedIn
    Private Err As Boolean
    Private BLOCK_SIZE As Long = 1024 * 100
    Private BLOCK_SIZE2 As Long = 1024 * 100

    ' Set the size of the packet that is used to read and
    '  write data to the FTP Server to the spcified size below.
    'Public Const BLOCK_SIZE = 64
    'Private m_aBuffer(BLOCK_SIZE) As Byte
    'Private ASCII As Encoding = Encoding.GetEncoding("EUC-KR")
    'Private ASCII As Encoding = Encoding.GetEncoding("ks_c_5601-1987") 'utf-32
    'Private ASCII As Encoding = Encoding.ASCII
    'Private MessageString As String
    '' General variables
    'Private m_sMessageString As String = Nothing
#End Region

#Region "Public Method"
    '
    ' Return a list of files within a string() array from the
    '  file system.
    Public Function GetFileList() As String()
        Dim mess() As String = Nothing
        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri))
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.ListDirectory

            Dim sr As New StreamReader(request.GetResponse().GetResponseStream())
            Dim Path As String = m_sRemotePath & "/"
            If Not sr Is Nothing Then

                Dim str As String = sr.ReadLine()
                If str = "" Then Return mess

                Dim strS As String = str.Replace(Path, "")
                While (True)

                    str = sr.ReadLine()
                    If str = "" Then Exit While
                    If str.Replace(Path, "") <> "" Then strS &= "," & str.Replace(Path, "")
                End While
                mess = strS.Split(",")

            End If

            ' Return the final result.
            Return mess

        Catch ex As Exception
            MessageError(ex)
            Err = True
            Return mess
        End Try

    End Function

    '
    ' Get the size of the file on the FTP Server.
    Public Function GetFileSize(ByVal sFileName As String) As Long

        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(m_Ftp_Uri + "/" + sFileName)

            'Get the file size first (for progress bar)
            request.Method = WebRequestMethods.Ftp.GetFileSize
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False 'close the connection

            Dim size As Long = request.GetResponse().ContentLength
            Return size

        Catch ex As Exception
            MsgBox(ex.Message)
            Err = True
            Return 0
        End Try
    End Function

    '
    ' Log into the FTP Server.
    Public Function Login() As Boolean

    End Function

    '
    ' Download a file to the Assembly's local directory,
    ' keeping the same file name.
    'Public Sub DownloadFile(ByVal sFileName As String)
    '    DownloadFile(sFileName, "", False)
    'End Sub

    '
    ' Download a remote file to the Assembly's local 
    '  directory, keeping the same file name, and set 
    '  the resume flag.
    'Public Sub DownloadFile(ByVal sFileName As String, _
    '                        ByVal bResume As Boolean)
    '    DownloadFile(sFileName, "", bResume)
    'End Sub

    '
    ' Download a remote file to a local file name which can 
    '  include a path, and set the resume flag. The local file 
    '  name will be created or overwritten, but the path must 
    '  exist.
    'Public Sub DownloadFile(ByVal sFileName As String, _
    '                        ByVal sLocalFileName As String)

    '    Try
    '        Dim sFileSize As Integer = GetFileSize(sFileName)

    '        If Err Then Exit Sub

    '        Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))
    '        request.Method = WebRequestMethods.Ftp.DownloadFile
    '        request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
    '        request.UsePassive = True
    '        request.UseBinary = True
    '        request.KeepAlive = False
    '        Application.DoEvents() ' 'prevent application from crashing

    '        'Streams
    '        Dim Response As FtpWebResponse = request.GetResponse()
    '        Dim Reader As Stream = Response.GetResponseStream()
    '        Application.DoEvents() ' 'prevent application from crashing

    '        'Download to memory
    '        'Note: adjust the streams here to download directly to the hard drive
    '        Dim memStream As MemoryStream = New MemoryStream()
    '        'Dim buffer As Byte() = New Byte(CInt(reader.Length - 1)) {}
    '        'Dim buffer As Byte() = New Byte(1024) {} ' 'downloads in chuncks
    '        Dim buffer(BLOCK_SIZE2) As Byte 'downloads in chuncks
    '        Dim DownloadedData As Byte() = New Byte(0) {}
    '        Dim lngBytesProcessed As Long = 0 'running count of bytes processed

    '        Try
    '            While lngBytesProcessed < sFileSize
    '                'Application.DoEvents() ' 'prevent application from crashing
    '                'Try to read the data
    '                Dim bytesRead As Integer = Reader.Read(buffer, 0, BLOCK_SIZE2)
    '                'Write the upload data
    '                memStream.Write(buffer, 0, bytesRead)
    '                'Update lngBytesProcessed
    '                lngBytesProcessed += bytesRead
    '                'Update Progress Bar
    '                pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
    '                pBar2.Update()
    '                System.Threading.Thread.Sleep(100) '일정시간 지연



    '                'If bytesRead = 0 Then
    '                '    'Nothing was read, finished downloading
    '                '    pBar1.Value = pBar1.Maximum
    '                '    pBar1.Text = sFileSize.ToString() + "/" + sFileSize.ToString()
    '                '    pBar2.Position = pBar2.Properties.Maximum
    '                '    'pBar2.Update()
    '                '    Application.DoEvents()
    '                '    Exit While
    '                'Else
    '                '    'Write the downloaded data
    '                '    memStream.Write(buffer, 0, bytesRead)

    '                '    'Update the progress bar
    '                '    If (pBar1.Value + bytesRead <= pBar1.Maximum) Then
    '                '        pBar1.Value += bytesRead
    '                '        pBar1.Text = pBar1.Value.ToString() + "/" + dataLength.ToString()
    '                '        pBar1.Refresh()
    '                '        pBar2.Position += bytesRead
    '                '        'pBar2.Update()
    '                '        'Application.DoEvents()
    '                '    End If

    '                'End If
    '            End While

    '            'Convert the downloaded stream to a byte array
    '            DownloadedData = memStream.ToArray()

    '        Catch ex As Exception
    '        Finally
    '            'Clean up
    '            reader.Close()
    '            memStream.Close()
    '            response.Close()
    '        End Try

    '        If DownloadedData.Length <> 0 Then
    '            Application.DoEvents()

    '            'Write the bytes to a file
    '            Dim newFile As FileStream = New FileStream(sLocalFileName, FileMode.Create)
    '            Try
    '                newFile.Write(DownloadedData, 0, DownloadedData.Length)
    '            Catch ex As Exception
    '            Finally
    '                newFile.Close()
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    'End Sub

    'Public Sub DownloadFile(ByVal sFileName As String, _
    '                    ByVal sLocalFileName As String, _
    '                    ByVal sFileSize As Long)

    '    Try
    '        If ToDec(sFileSize) = 0 Then pBar2.Visible = False
    '        Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))
    '        request.Method = WebRequestMethods.Ftp.DownloadFile
    '        request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
    '        request.UsePassive = True
    '        request.UseBinary = True
    '        request.KeepAlive = False
    '        Application.DoEvents() ' 'prevent application from crashing

    '        'Streams
    '        Dim Response As FtpWebResponse = request.GetResponse()
    '        Dim Reader As Stream = Response.GetResponseStream()
    '        Application.DoEvents() ' 'prevent application from crashing

    '        'Download to memory
    '        'Note: adjust the streams here to download directly to the hard drive
    '        Dim memStream As MemoryStream = New MemoryStream()
    '        'Dim buffer As Byte() = New Byte(CInt(reader.Length - 1)) {}
    '        'Dim buffer As Byte() = New Byte(1024) {} ' 'downloads in chuncks
    '        Dim buffer As Byte() = New Byte(BLOCK_SIZE2) {}
    '        Dim lngBytesProcessed As Long = 0 'running count of bytes processed
    '        Dim DownloadedData As Byte() = New Byte(0) {}

    '        Try
    '            While (True)
    '                'Application.DoEvents() ' 'prevent application from crashing
    '                'Try to read the data
    '                Dim bytesRead As Integer = Reader.Read(buffer, 0, buffer.Length)
    '                If bytesRead = 0 Then Exit While
    '                'Write the upload data
    '                memStream.Write(buffer, 0, bytesRead)
    '                'Update lngBytesProcessed
    '                lngBytesProcessed += bytesRead
    '                'Update Progress Bar
    '                If sFileSize > 0 Then
    '                    pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
    '                    pBar2.Update()
    '                    System.Threading.Thread.Sleep(100) '일정시간 지연

    '                End If

    '            End While

    '            DownloadedData = memStream.ToArray()

    '        Catch ex As Exception
    '        Finally
    '            'Clean up
    '            Reader.Close()
    '            memStream.Close()
    '            Response.Close()
    '        End Try

    '        If DownloadedData.Length <> 0 Then
    '            Application.DoEvents()

    '            'Write the bytes to a file
    '            Dim newFile As FileStream = New FileStream(sLocalFileName, FileMode.Create)
    '            Try
    '                newFile.Write(DownloadedData, 0, DownloadedData.Length)
    '            Catch ex As Exception
    '            Finally
    '                newFile.Close()
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    'End Sub

    Public Sub DownloadFile(ByVal sFileName As String, _
                        ByVal sLocalFileName As String, _
                        ByVal sFileSize As Long)
        Try
            'Download to memory
            'Note: adjust the streams here to download directly to the hard drive
            Dim memStream As MemoryStream = DownloadStream(sFileName, sFileSize)
            Dim DownloadedData As Byte() = New Byte(0) {}

            'Convert the downloaded stream to a byte array
            DownloadedData = memStream.ToArray()
            'Clean up
            memStream.Close()

            If DownloadedData.Length <> 0 Then
                Application.DoEvents()

                'Write the bytes to a file
                Dim newFile As FileStream = New FileStream(sLocalFileName, FileMode.Create)
                Try
                    newFile.Write(DownloadedData, 0, DownloadedData.Length)
                Catch ex As Exception
                Finally
                    newFile.Close()
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function DownloadStream(ByVal sFileName As String, _
                        ByVal sFileSize As Long) As MemoryStream

        If ToDec(sFileSize) = 0 Then pBar2.Visible = False
        DownloadStream = Nothing
        Try
            'Dim sFileSize As Integer = GetFileSize(sFileName)

            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))
            request.Method = WebRequestMethods.Ftp.DownloadFile
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False
            Application.DoEvents() ' 'prevent application from crashing

            'Streams
            Dim Response As FtpWebResponse = request.GetResponse()
            Dim Reader As Stream = Response.GetResponseStream()
            Application.DoEvents() ' 'prevent application from crashing

            'Download to memory
            'Note: adjust the streams here to download directly to the hard drive
            Dim memStream As MemoryStream = New MemoryStream()
            'Dim buffer As Byte() = New Byte(CInt(reader.Length - 1)) {}
            'Dim buffer As Byte() = New Byte(1024) {} ' 'downloads in chuncks
            Dim buffer As Byte() = New Byte(BLOCK_SIZE2) {} 'downloads in chuncks
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed

            Try
                While (True)
                    'Application.DoEvents() ' 'prevent application from crashing
                    'Try to read the data
                    Dim bytesRead As Integer = Reader.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then Exit While
                    'Write the upload data
                    memStream.Write(buffer, 0, bytesRead)
                    'Update lngBytesProcessed
                    If sFileSize > 0 Then
                        lngBytesProcessed += bytesRead
                        'Update Progress Bar
                        pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
                        pBar2.Update()
                        System.Threading.Thread.Sleep(100) '일정시간 지연
                    End If

                    'If bytesRead = 0 Then
                    '    'Nothing was read, finished downloading
                    '    pBar1.Value = pBar1.Maximum
                    '    pBar1.Text = sFileSize.ToString() + "/" + sFileSize.ToString()
                    '    pBar2.Position = pBar2.Properties.Maximum
                    '    'pBar2.Update()
                    '    Application.DoEvents()
                    '    Exit While
                    'Else
                    '    'Write the downloaded data
                    '    memStream.Write(buffer, 0, bytesRead)

                    '    'Update the progress bar
                    '    If (pBar1.Value + bytesRead <= pBar1.Maximum) Then
                    '        pBar1.Value += bytesRead
                    '        pBar1.Text = pBar1.Value.ToString() + "/" + dataLength.ToString()
                    '        pBar1.Refresh()
                    '        pBar2.Position += bytesRead
                    '        'pBar2.Update()
                    '        'Application.DoEvents()
                    '    End If

                    'End If
                End While

                Return memStream

            Catch ex As Exception
            Finally
                'Clean up
                Reader.Close()
                Response.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    ' Upload a file and set the resume flag.
    Public Function UploadFile(ByVal sFullPath As String) As String

        UploadFile = ""
        If sFullPath = "" Then Return ""
        '파일명만 분리
        Dim FileNm As String = System.IO.Path.GetFileName(sFullPath)

        If FileNm = "" Then Return ""

        Try

            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & FileNm))

            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False
            Application.DoEvents() ' 'prevent application from crashing

            'Load the file         
            Dim GetStream As FileStream = File.OpenRead(sFullPath)
            Application.DoEvents() ' 'prevent application from crashing

            Dim sFileSize As Double = GetStream.Length

            'Upload file         
            Dim reqStream As Stream = request.GetRequestStream()
            Dim buffer(BLOCK_SIZE) As Byte
            'Dim buffer As Byte() = New Byte(CInt(GetStream.Length - 1)) {}
            ' Dim buffer As Byte() = New Byte(64) {}
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Try
                While (True)

                    'Application.DoEvents() ' 'prevent application from crashing
                    'Try to read the data
                    'Dim bytesRead As Integer = sFileStream.Read(buffer, 0, buffer.Length)
                    Dim bytesRead As Integer = GetStream.Read(buffer, 0, buffer.Length)
                    'Write the upload data
                    reqStream.Write(buffer, 0, buffer.Length)
                    'Update lngBytesProcessed
                    lngBytesProcessed += bytesRead
                    'Update Progress Bar
                    pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
                    pBar2.Update()
                    System.Threading.Thread.Sleep(100) '일정시간 지연


                    'Application.DoEvents() ' 'prevent application from crashing
                    ''Try to read the data
                    ''Dim bytesRead As Integer = GetStream.Read(buffer, 0, buffer.Length)
                    'Dim bytesRead As Integer = GetStream.Read(buffer, 0, BLOCK_SIZE)
                    'If bytesRead = 0 Then
                    '    'Nothing was read, finished uploading
                    '    'pBar1.Value = pBar1.Maximum
                    '    'pBar1.Text = sFileSize.ToString & "/" & sFileSize.ToString
                    '    pBar2.Position = pBar2.Properties.Maximum
                    '    Application.DoEvents()
                    '    Exit While
                    'Else
                    '    'Write the upload data
                    '    reqStream.Write(buffer, 0, buffer.Length)

                    '    'Update the progress bar
                    '    If (pBar1.Value + bytesRead <= pBar1.Maximum) Then
                    '        pBar1.Value += bytesRead
                    '        pBar1.Text = pBar1.Value.ToString & "/" & sFileSize.ToString()
                    '        pBar1.Refresh()
                    '        pBar2.Position += bytesRead
                    '        Application.DoEvents()
                    '    End If
                    'End If
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally '
                GetStream.Close()
                reqStream.Close()
            End Try

            Return FileNm

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    ' Upload a file and set the resume flag.
    Public Function UploadFile(ByVal sFullPath As String, _
                               ByVal FileNm As String,
                               sFileSize As Long) As String

        UploadFile = ""
        If sFullPath = "" Then Return ""
        ''파일명만 분리
        'Dim FileNm As String = System.IO.Path.GetFileName(sFullPath)

        If FileNm = "" Then Return ""

        Try

            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & FileNm))
            Dim fileInf As FileInfo = New FileInfo(sFullPath) '전송할 File을 설정

            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False
            'request.ContentLength = fileInf.Length

            'Application.DoEvents() ' 'prevent application from crashing

            'Load the file         
            Dim GetStream As FileStream = fileInf.OpenRead

            'Application.DoEvents() ' 'prevent application from crashing

            'Upload file         
            Dim reqStream As Stream = request.GetRequestStream()
            'Dim buffer(BLOCK_SIZE - 1) As Byte
            'Dim buffer As Byte() = New Byte(CInt(BLOCK_SIZE - 1)) {}
            If BLOCK_SIZE > GetStream.Length Then BLOCK_SIZE = GetStream.Length

            Dim buffer As Byte() = New Byte(CInt(BLOCK_SIZE - 1)) {}
            ' Dim buffer As Byte() = New Byte(64) {}
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Try
                While (True)

                    Application.DoEvents() ' 'prevent application from crashing
                    'Try to read the data
                    Dim bytesRead As Integer = GetStream.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then Exit While
                    'Write the upload data
                    reqStream.Write(buffer, 0, buffer.Length)
                    'Update lngBytesProcessed
                    lngBytesProcessed += bytesRead
                    'Update Progress Bar
                    pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
                    pBar2.Update()
                    'System.Threading.Thread.Sleep(100) '일정시간 지연
                    Application.DoEvents()
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally '
                GetStream.Close()
                reqStream.Close()
            End Try

            Return FileNm

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function UploadFile(ByVal sFileName As String, _
                                ByVal sFileStream As FileStream) As String
        UploadFile = ""
        If sFileStream Is Nothing Then Return ""
        Dim sFileSize As Double = sFileStream.Length
        If ToDec(sFileSize) <= 0 Then Return False
        Try


            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))

            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False
            Application.DoEvents() ' 'prevent application from crashing

            'Upload file         
            Dim reqStream As Stream = request.GetRequestStream()
            Dim buffer(BLOCK_SIZE) As Byte
            'Dim buffer As Byte() = New Byte(CInt(sFileStream.Length - 1)) {}
            ' Dim buffer As Byte() = New Byte(64) {}

            Dim lngBytesProcessed As Long = 0 'running count of bytes processed

            Try
                'Use While to loop until all of the file is processed.
                While (True)
                    Application.DoEvents() ' 'prevent application from crashing
                    'Try to read the data
                    'Dim bytesRead As Integer = sFileStream.Read(buffer, 0, buffer.Length)
                    Dim bytesRead As Integer = sFileStream.Read(buffer, 0, buffer.Length)
                    'Write the upload data
                    reqStream.Write(buffer, 0, buffer.Length)
                    'Update lngBytesProcessed
                    lngBytesProcessed += bytesRead
                    'Update Progress Bar
                    pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
                    pBar2.Update()
                    'System.Threading.Thread.Sleep(100)
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
                sFileName = ""
            Finally '
                sFileStream.Close()
                reqStream.Close()
            End Try

            Return sFileName

        Catch ex As Exception
            sFileName = ""
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function UploadFile(ByVal sFileName As String, _
                            ByVal sMemStream As MemoryStream) As String
        UploadFile = ""
        If sFileName = "" Then Return ""
        Dim sFileSize As Double = sMemStream.Length
        If ToDec(sMemStream.Length) <= 0 Then Return ""

        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))

            request.Method = WebRequestMethods.Ftp.UploadFile
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = False
            Application.DoEvents() ' 'prevent application from crashing

            'Upload file         
            Dim reqStream As Stream = request.GetRequestStream()
            Dim buffer(BLOCK_SIZE) As Byte
            'Dim buffer As Byte() = New Byte(CInt(sFileStream.Length - 1)) {}
            ' Dim buffer As Byte() = New Byte(64) {}

            Dim lngBytesProcessed As Long = 0 'running count of bytes processed

            Try
                'Use While to loop until all of the file is processed.
                While (True)
                    'Application.DoEvents() ' 'prevent application from crashing
                    'Try to read the data
                    'Dim bytesRead As Integer = sFileStream.Read(buffer, 0, buffer.Length)
                    Dim bytesRead As Integer = sMemStream.Read(buffer, 0, buffer.Length)
                    'Write the upload data
                    reqStream.Write(buffer, 0, buffer.Length)
                    'Update lngBytesProcessed
                    lngBytesProcessed += bytesRead
                    'Update Progress Bar
                    pBar2.Position = CInt((lngBytesProcessed / sFileSize) * 100)
                    pBar2.Update()
                    'System.Threading.Thread.Sleep(100)
                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
                sFileName = ""
            Finally '
                sMemStream.Close()
                reqStream.Close()
            End Try

            Return sFileName

        Catch ex As Exception
            sFileName = ""
            MsgBox(ex.ToString)
        End Try

    End Function

    ' Delete a file from the remote FTP server.
    Public Function DeleteFile(ByVal sFileName As String) As Boolean
        Dim bResult As Boolean = True

        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sFileName))
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.DeleteFile

            request.GetResponse()
            ' Return the final result.
            Return bResult

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    ' Rename a file on the remote FTP server.
    Public Function RenameFile(ByVal sOldFileName As String, _
                               ByVal sNewFileName As String) As Boolean
        Dim bResult As Boolean = True
        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sOldFileName))
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)
            request.Method = WebRequestMethods.Ftp.Rename
            request.UseBinary = False
            request.RenameTo = m_Ftp_Uri & "/" & sNewFileName
            request.GetResponse()

            Return bResult
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    '
    ' Create a directory on the remote FTP server.
    Public Function CreateDirectory(ByVal sDirName As String) As Boolean
        Dim bResult As Boolean = True
        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sDirName))
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.MakeDirectory

            request.GetResponse()
            ' Return the final result.
            Return bResult

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function

    '
    ' Delete a directory on the remote FTP server.
    Public Function RemoveDirectory(ByVal sDirName As String) As Boolean
        Dim bResult As Boolean = True

        Try
            Dim request As FtpWebRequest = FtpWebRequest.Create(New Uri(m_Ftp_Uri & "/" & sDirName))
            request.Credentials = New NetworkCredential(m_sRemoteUser, m_sRemotePassword)

            request.KeepAlive = False
            request.Method = WebRequestMethods.Ftp.RemoveDirectory

            request.GetResponse()
            ' Return the final result.
            Return bResult

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

#End Region

    '#Region "Form(Default, Clipboard) 끌기 기능"
    '    ' -----------------------------------------------------------------
    '    '   Panel(Default, Clipboard) 끌기 기능
    '    ' -----------------------------------------------------------------
    '    Dim saveX As Integer, saveY As Integer
    '    Dim isMove As Boolean

    '    Private Sub me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
    '        saveX = e.X
    '        saveY = e.Y
    '        isMove = True
    '    End Sub

    '    Private Sub me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnmelAdmin.MouseMove
    '        If isMove = True Then
    '            Me.Location = New Point((e.X - saveX + Me.Left), (e.Y - saveY + Me.Top))
    '        End If
    '    End Sub

    '    Private Sub me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
    '        isMove = False
    '    End Sub
    '#End Region

    Private Sub CopyWithProgress(ByVal ParamArray filenames As String())
        '' Display the ProgressBar control.
        'pBar1.Visible = True
        '' Set Minimum to 1 to represent the first file being copied.
        'pBar1.Minimum = 1
        '' Set Maximum to the total number of files to copy.
        'pBar1.Maximum = filenames.Length
        '' Set the initial value of the ProgressBar.
        'pBar1.Value = 1
        '' Set the Step property to a value of 1 to represent each file being copied.
        'pBar1.Step = 1

        '' Loop through all files to copy.
        'Dim x As Integer
        'For x = 1 To filenames.Length - 1
        '    ' Copy the file and increment the ProgressBar if successful.
        '    If CopyFile(filenames(x - 1)) = True Then
        '        ' Perform the increment on the ProgressBar.
        '        pBar1.PerformStep()
        '    End If
        'Next x
    End Sub

End Class

