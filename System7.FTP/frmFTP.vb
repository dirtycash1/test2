Imports Base7
Imports Base7.Shared

Imports System
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Net.Sockets

Public Class frmFTP

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadForm(Me)
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        CloseConnection()
    End Sub

    Public Sub Jump(ByVal GetHost As String, ByVal GetPath As String, _
                    ByVal GetUser As String, ByVal GetPass As String, _
                    ByVal GetPort As Integer)

        m_sRemoteHost = GetHost
        m_sRemotePath = GetPath
        m_sRemoteUser = GetUser
        m_sRemotePassword = GetPass
        m_iRemotePort = GetPort

    End Sub

#Region "Declarations"
    Private m_sRemoteHost, m_sRemotePath, m_sRemoteUser As String
    Private m_sRemotePassword, m_sMess As String
    Private m_iRemotePort, m_iBytes As Int32
    Private m_objClientSocket As Socket

    Private m_iRetValue As Int32
    Private m_bLoggedIn As Boolean = False    ' Change to loggedIn
    Private m_sMes, m_sReply As String

    ' Set the size of the packet that is used to read and
    '  write data to the FTP Server to the spcified size below.
    Public Const BLOCK_SIZE = 64
    Private m_aBuffer(BLOCK_SIZE) As Byte
    'Private ASCII As Encoding = Encoding.GetEncoding("EUC-KR")
    Private ASCII As Encoding = Encoding.GetEncoding("ks_c_5601-1987") 'utf-32
    'Private ASCII As Encoding = Encoding.ASCII
    Private MessageString As String
    ' General variables
    Private m_sMessageString As String
#End Region

#Region "Public Method"
    '
    ' Return a list of files within a string() array from the
    '  file system.
    Public Function GetFileList(ByVal sMask As String) As String()
        Dim cSocket As Socket
        Dim bytes As Int32
        Dim seperator As Char = ControlChars.Lf
        Dim mess() As String = Nothing
        Try
            m_sMes = ""
            If (Not (m_bLoggedIn)) Then
                Login()
            End If

            cSocket = CreateDataSocket()
            SendCommand("NLST " & sMask)

            'If m_iRetValue = 226 Then
            '    SendCommand("NLST " & sMask)
            'End If

            If (Not (m_iRetValue = 150 Or m_iRetValue = 125)) Then
                MessageString = m_sReply
                Throw New IOException("GetFileList(): " & vbLf & m_sReply) '.Substring(4))
            End If

            m_sMes = ""
            'Do While (True)
            '    m_aBuffer.Clear(m_aBuffer, 0, m_aBuffer.Length)
            '    bytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
            '    m_sMes += ASCII.GetString(m_aBuffer, 0, bytes)

            '    If (bytes < m_aBuffer.Length) Then
            '        Exit Do
            '    End If
            'Loop

            Do
                'm_aBuffer.Clear(m_aBuffer, 0, m_aBuffer.Length)
                Array.Clear(m_aBuffer, 0, m_aBuffer.Length)
                bytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                m_sMes += ASCII.GetString(m_aBuffer, 0, bytes)
            Loop While bytes > 0

            mess = m_sMes.Split(seperator)
            cSocket.Close()
            ReadReply()

            If (m_iRetValue <> 226) Then
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return mess
    End Function

    '
    ' Get the size of the file on the FTP Server.
    Public Function GetFileSize(ByVal sFileName As String) As Long
        Dim size As Long

        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("SIZE " & sFileName)
        size = 0

        If (m_iRetValue = 213) Then
            size = Int64.Parse(m_sReply.Substring(4))
        Else
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        Return size
    End Function

    '
    ' Log into the FTP Server.
    Public Function Login() As Boolean

        m_objClientSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        'Dim ep As New IPEndPoint(Dns.Resolve(m_sRemoteHost).AddressList(0), m_iRemotePort)
        Dim ep As New IPEndPoint(Dns.GetHostEntry(m_sRemoteHost).AddressList(0), m_iRemotePort)

        'Dim ad(3) As Byte
        'ad(0) = 211
        'ad(1) = 107
        'ad(2) = 133
        'ad(3) = 71
        'Dim ip As New System.Net.IPAddress(ad)
        'Dim ep As New IPEndPoint(ip, 2010)

        Try

            m_objClientSocket.Connect(ep)
            'MsgBox("FTP서버에 접속되었습니다.")

        Catch ex As Exception
            'MessageString = m_sReply
            'MessageWarning("Couldn't connect to remote server")
            Throw New IOException("Couldn't connect to remote server")
            'Return False
        End Try

        ReadReply()

        If (m_iRetValue <> 220) Then
            CloseConnection()
            MessageString = m_sReply
            'MsgWarning(MessageString)
            'Return False
            Throw New IOException(m_sReply.Substring(4))
        End If

        SendCommand("USER " & m_sRemoteUser)
        If (Not (m_iRetValue = 331 Or m_iRetValue = 230)) Then
            Cleanup()
            MessageString = m_sReply
            'MsgWarning(MessageString)
            'Return False
            Throw New IOException(m_sReply.Substring(4))
        End If

        If (m_iRetValue <> 230) Then
            SendCommand("PASS " & m_sRemotePassword)
            If (Not (m_iRetValue = 230 Or m_iRetValue = 202)) Then
                Cleanup()
                MessageString = m_sReply
                'MsgWarning(MessageString)
                'Return False
                Throw New IOException(m_sReply.Substring(4))
            End If
        End If

        m_bLoggedIn = True
        ChangeDirectory(m_sRemotePath)

        ' Return the end result.
        Return m_bLoggedIn


    End Function

    '
    ' If the value of mode is true, set binary mode for 
    '  downloads.
    ' Else, set Ascii mode.
    Public Sub SetBinaryMode(ByVal bMode As Boolean)

        If (bMode) Then
            SendCommand("TYPE I")
        Else
            SendCommand("TYPE A")
        End If

        If (m_iRetValue <> 200) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If
    End Sub

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
    '  include a path. The local file name will be created or 
    '  overwritten, but the path must exist.
    Public Sub DownloadFile(ByVal sFileName As String, _
                            ByVal sLocalFileName As String, _
                            ByVal sFileSize As Double)

        DownloadFile(sFileName, sLocalFileName, sFileSize, False)
    End Sub

    '
    ' Download a remote file to a local file name which can 
    '  include a path, and set the resume flag. The local file 
    '  name will be created or overwritten, but the path must 
    '  exist.
    Public Sub DownloadFile(ByVal sFileName As String, _
                            ByVal sLocalFileName As String, _
                            ByVal sFileSize As Double, _
                            ByVal bResume As Boolean)
        Dim st As Stream
        Dim output As FileStream
        Dim cSocket As Socket
        Dim offset, npos As Long

        'sFileSize = sFileSize / 1024

        If m_bLoggedIn = False Then
            Login()
            If Not m_bLoggedIn Then Me.Dispose()
        End If

        SetBinaryMode(True)

        If (sLocalFileName.Equals("")) Then
            sLocalFileName = sFileName
        End If

        If (Not (File.Exists(sLocalFileName))) Then
            st = File.Create(sLocalFileName)
            st.Close()
        End If

        output = New FileStream(sLocalFileName, FileMode.Open)
        cSocket = CreateDataSocket()
        offset = 0

        If (bResume) Then
            offset = output.Length
            If (offset > 0) Then
                SendCommand("REST " & offset)
                If (m_iRetValue <> 350) Then
                    'throw new IOException(reply.Substring(4));
                    'Some servers may not support resuming.
                    offset = 0
                End If
            End If

            If (offset > 0) Then
                npos = output.Seek(offset, SeekOrigin.Begin)
            End If
        End If

        SendCommand("RETR " & sFileName)

        If sFileSize >= 64 Then
            If (Not (m_iRetValue = 150 Or m_iRetValue = 125)) Then
                output.Close()
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If
            Dim BarValue As Double = 0

            If sFileSize >= 1 Then
                pBar1.Minimum = 1
                pBar1.Maximum = sFileSize
                pBar1.Step = 15
                pBar1.Visible = True
            End If

            Do While (True)
                If m_aBuffer.Length > 0 Then Array.Clear(m_aBuffer, 0, m_aBuffer.Length)
                'If m_aBuffer.Length > 0 Then m_aBuffer.Clear(m_aBuffer, 0, m_aBuffer.Length)
                m_iBytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                If sFileSize >= 64 Then
                    BarValue += m_iBytes
                    If pBar1.Visible Then pBar1.Value = BarValue
                Else
                    If pBar1.Visible Then pBar1.Value = sFileSize
                End If

                output.Write(m_aBuffer, 0, m_iBytes)

                If (m_iBytes <= 0) Then Exit Do
            Loop
            'pBar1.Value = 1
        Else

            Do While (True)
                If m_aBuffer.Length > 0 Then Array.Clear(m_aBuffer, 0, m_aBuffer.Length)
                'If m_aBuffer.Length > 0 Then m_aBuffer.Clear(m_aBuffer, 0, m_aBuffer.Length)
                m_iBytes = cSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                output.Write(m_aBuffer, 0, m_iBytes)

                If (m_iBytes <= 0) Then Exit Do
            Loop
        End If

        output.Close()
        If (cSocket.Connected) Then
            cSocket.Close()
        End If
        If sFileSize >= 64 Then
            ReadReply()
            If (Not (m_iRetValue = 226 Or m_iRetValue = 250)) Then
                MessageString = m_sReply
                Throw New IOException(m_sReply.Substring(4))
            End If
        End If


    End Sub

    '
    ' Upload a file.
    Public Sub UploadFile(ByVal sFileName As String, ByVal sFileSize As Double)
        UploadFile(sFileName, sFileSize, True)
    End Sub

    '
    ' Upload a file and set the resume flag.
    Public Sub UploadFile(ByVal sFileName As String, _
                          ByVal sFileSize As Double, _
                          ByVal bResume As Boolean)
        Dim cSocket As Socket
        Dim offset As Long
        Dim input As FileStream
        Dim bFileNotFound As Boolean

        'sFileSize = sFileSize / 1024

        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        cSocket = CreateDataSocket()
        offset = 0

        If (bResume) Then
            Try
                SetBinaryMode(True)
                offset = GetFileSize(sFileName)
            Catch ex As Exception
                offset = 0
            End Try
        End If

        If (offset > 0) Then

            SendCommand("REST " & offset)
            If (m_iRetValue <> 350) Then
                'throw new IOException(reply.Substring(4));
                'Remote server may not support resuming.
                offset = 0
            End If
        End If

        SendCommand("STOR " & Path.GetFileName(sFileName))
        If (Not (m_iRetValue = 125 Or m_iRetValue = 150)) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        ' Check to see if the file exists before the upload.
        bFileNotFound = False
        If (File.Exists(sFileName)) Then
            If sFileSize >= 1 Then
                pBar1.Minimum = 1
                pBar1.Maximum = sFileSize
                pBar1.Step = 1
                pBar1.Visible = True
            End If

            ' Open input stream to read source file
            input = New FileStream(sFileName, FileMode.Open)
            If (offset <> 0) Then
                input.Seek(offset, SeekOrigin.Begin)
            End If
            Dim BarValue As Double = 0
            ' Upload the file 
            m_iBytes = input.Read(m_aBuffer, 0, m_aBuffer.Length)
            Do While (m_iBytes > 0)
                cSocket.Send(m_aBuffer, m_iBytes, 0)
                m_iBytes = input.Read(m_aBuffer, 0, m_aBuffer.Length)
                If sFileSize >= 64 Then
                    BarValue += m_iBytes
                    If pBar1.Visible Then pBar1.Value = BarValue
                Else
                    If pBar1.Visible Then pBar1.Value = sFileSize
                End If
            Loop
            pBar1.Value = 1
            input.Close()
        Else
            bFileNotFound = True
        End If

        If (cSocket.Connected) Then
            cSocket.Close()
        End If

        ' No point in reading the return value if the file was
        '  not found.
        If (bFileNotFound) Then
            MessageString = m_sReply
            Throw New IOException("The file: " & sFileName & " was not found.  Can not upload the file to the FTP Site.")
        End If

        ReadReply()
        If (Not (m_iRetValue = 226 Or m_iRetValue = 250)) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If
    End Sub

    '
    ' Delete a file from the remote FTP server.
    Public Function DeleteFile(ByVal sFileName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("DELE " & sFileName)
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        ' Return the final result.
        Return bResult
    End Function

    '
    ' Rename a file on the remote FTP server.
    Public Function RenameFile(ByVal sOldFileName As String, _
                               ByVal sNewFileName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("RNFR " & sOldFileName)
        If (m_iRetValue <> 350) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        '  known problem
        '  rnto will not take care of existing file.
        '  i.e. It will overwrite if newFileName exist
        SendCommand("RNTO " & sNewFileName)
        If (m_iRetValue <> 250) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        Return bResult
    End Function

    '
    ' Create a directory on the remote FTP server.
    Public Function CreateDirectory(ByVal sDirName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("MKD " & sDirName)
        If (m_iRetValue <> 257) Then
            bResult = False
            MessageString = m_sReply
        End If

        ' Return the final result.
        Return bResult
    End Function

    '
    ' Delete a directory on the remote FTP server.
    Public Function RemoveDirectory(ByVal sDirName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("RMD " & sDirName)
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        ' Return the final result.
        Return bResult
    End Function

    '
    ' Change the current working directory on the remote FTP 
    '  server.
    Public Function ChangeDirectory(ByVal sDirName As String) As Boolean
        Dim bResult As Boolean

        bResult = True
        If (sDirName.Equals(".")) Then
            Exit Function
        End If

        If (Not (m_bLoggedIn)) Then
            Login()
        End If

        SendCommand("CWD " & sDirName)
        If (m_iRetValue <> 250) Then
            bResult = False
            MessageString = m_sReply
        End If

        Me.m_sRemotePath = sDirName

        ' Return the final result.
        Return bResult
    End Function

    '
    ' Close the FTP connection.
    Public Sub CloseConnection()

        If (Not (m_objClientSocket Is Nothing)) And m_bLoggedIn Then
            SendCommand("QUIT")
        End If

        Cleanup()

    End Sub

#End Region

#Region "Private Method"
    '
    ' Read the reply from the FTP Server
    Private Sub ReadReply()

        m_sMes = ""
        m_sReply = ReadLine()
        m_iRetValue = Int32.Parse(m_sReply.Substring(0, 3))

    End Sub

    '
    ' Clean up some variables.
    Private Sub Cleanup()
        Try
            If Not (m_objClientSocket Is Nothing) Then
                m_objClientSocket.Close()
                m_objClientSocket = Nothing
            End If

            m_bLoggedIn = False
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try

    End Sub

    '
    ' Read a line from the server.
    Private Function ReadLine(Optional ByVal bClearMes As Boolean = False) As String
        Dim seperator As Char = ControlChars.Lf
        Dim mess() As String

        If (bClearMes) Then m_sMes = ""

        Do While (True)
            Array.Clear(m_aBuffer, 0, BLOCK_SIZE)
            'm_aBuffer.Clear(m_aBuffer, 0, BLOCK_SIZE)
            If m_aBuffer.Length > 0 Then
                m_iBytes = m_objClientSocket.Receive(m_aBuffer, m_aBuffer.Length, 0)
                m_sMes += ASCII.GetString(m_aBuffer, 0, m_iBytes)
            End If
            If (m_iBytes < m_aBuffer.Length) Then
                Exit Do
            End If
        Loop

        mess = m_sMes.Split(seperator)
        If (m_sMes.Length > 2) Then
            m_sMes = mess(mess.Length - 2)
        Else
            m_sMes = mess(0)
        End If

        If (Not (m_sMes.Substring(3, 1).Equals(" "))) Then Return ReadLine(True)

        Return m_sMes

    End Function

    '
    ' Send a command to the FTP Server.
    Private Sub SendCommand(ByVal sCommand As String)
        Try
            sCommand = sCommand & ControlChars.CrLf
            Dim cmdbytes As Byte() = ASCII.GetBytes(sCommand)

            m_objClientSocket.Send(cmdbytes, cmdbytes.Length, 0)
            ReadReply()
        Catch ex As Exception

        End Try

    End Sub

    '
    ' Create a Data socket.
    Private Function CreateDataSocket() As Socket
        Dim index1, index2, len As Int32
        Dim partCount, i, port As Int32
        Dim ipData, buf, ipAddress As String
        Dim parts(6) As Int32
        Dim ch As Char
        Dim s As Socket
        Dim ep As IPEndPoint

        SendCommand("PASV")
        If (m_iRetValue <> 227) Then
            MessageString = m_sReply
            Throw New IOException(m_sReply.Substring(4))
        End If

        index1 = m_sReply.IndexOf("(")
        index2 = m_sReply.IndexOf(")")
        ipData = m_sReply.Substring(index1 + 1, index2 - index1 - 1)

        len = ipData.Length
        partCount = 0
        buf = ""

        For i = 0 To ((len - 1) And partCount <= 6)
            ch = Char.Parse(ipData.Substring(i, 1))
            If (Char.IsDigit(ch)) Then
                buf += ch
            ElseIf (ch <> ",") Then
                MessageString = m_sReply
                Throw New IOException("Malformed PASV reply: " & m_sReply)
            End If

            If ((ch = ",") Or (i + 1 = len)) Then
                Try
                    parts(partCount) = Int32.Parse(buf)
                    partCount += 1
                    buf = ""
                Catch ex As Exception
                    MessageString = m_sReply
                    Throw New IOException("Malformed PASV reply: " & m_sReply)
                End Try
            End If
        Next

        ipAddress = parts(0) & "." & parts(1) & "." & parts(2) & "." & parts(3)

        ' Make this call in VB.NET 2002.  We would like to 
        '  bitshift the number by 8 bits, so in VB.NET 2002 we
        '  multiply the number by 2 to the power of 8.
        port = parts(4) * (2 ^ 8)

        ' Make this call and comment out the above line for
        '  VB.NET 2003.
        'port = parts(4) << 8

        ' Determine the data port number.
        port = port + parts(5)

        s = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        'ep = New IPEndPoint(Dns.Resolve(ipAddress).AddressList(0), port)
        ep = New IPEndPoint(Dns.GetHostEntry(m_sRemoteHost).AddressList(0), port)

        'Dim ad(3) As Byte
        'ad(0) = 211
        'ad(1) = 107
        'ad(2) = 133
        'ad(3) = 71
        'Dim ip As New System.Net.IPAddress(ad)
        'ep = New IPEndPoint(ip, 2010)


        Try
            s.Connect(ep)
        Catch ex As Exception
            MessageString = m_sReply
            Throw New IOException("Can't connect to remote server")
        End Try

        Return s
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

