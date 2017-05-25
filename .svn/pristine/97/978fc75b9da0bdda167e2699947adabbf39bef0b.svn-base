Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math
Imports System.Data

Public Class QOA720

    Private Sub QOA720_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '의사소통번호 채번
        com_no.CodeNo = "QOA700"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        com_no.CodeDateField = com_dt
        Init_Form()
        MyBase.Open()

    End Sub


    Public Sub Init_Form()

        '  If Parameter.Login.UserKd = "SC700300" Then
        ' SplitContainer1.SplitterDistance = EPanel1.Height * 0.65
        ' Else
        ' SplitContainer1.Orientation = Orientation.Vertical
        ' 'EPanelChg()
        ' End If

        ' img.BringToFront()
        Dim FntNm As String = Parameter.Login.FontNm, Fntsz As Single = ToDec(Parameter.Login.FontSz)
        If Fntsz = 0 Then Fntsz = 9
        If FntNm = "" Then FntNm = "Tahoma"
        'title.Font = New System.Drawing.Font(FntNm, Fntsz, FontStyle.Bold)
        g10.SelectRow = False
        ' g20.SelectRow = True

        New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                New_Form()

            Case MenuType.Open
                Open_Form()
                Open_Form2()
                g10.AllowDeleteRows = False

            Case MenuType.Save
                'If Parameter.Login.UserKd = "SC700300" Then Exit Sub
                'If com_no.Text <> "" And Parameter.Login.RegId.ToString <> cid.Text And Parameter.Login.UserKd = "SC700300" Then Exit Sub '본인이 아닌경우 수정 불가
                Save_Form()

                'Case MenuType.Delete
            Case MenuType.Delete
                If DocDelete() Then
                    New_Form()
                End If

            Case Else

                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Private Function DocDelete() As Boolean
        If com_no.Text = "" Then Return False
        'If Parameter.Login.UserKd = "SC700300" And Parameter.Login.RegId.ToString <> cid.Text Then
        ' MessageInfo("문서작성자만 삭제가 가능합니다.!")
        ' Return False '본인이 아닌 경우 삭제 불가
        'End If

        If MessageYesNo("선택 문서정보를 삭제하시겠습니까?" & vbLf & vbLf & "(첨부 파일이 있는 경우 FileServer의 해당 파일 삭제 후 문서가 삭제됩니다.)") <> MsgBoxResult.Yes Then Return False

        ' If g10.ToDec("read_cnt") > 0 Then
        ' If MessageYesNo("문서열람 정보가 존재합니다. 그래도 삭제하시겠습니까?") <> MsgBoxResult.Yes Then Return False
        ' End If

        '첨부파일이 있는 경우 삭제처리
        If Not FilesDelete() Then Return False

        If Delete("qoa720_g10", False) = ExcuteResult.Succeeded Then Return True
    End Function

    Private Function FilesDelete() As Boolean
        Try
            For Row As Integer = 0 To g10.RowCount - 1
                g10.RowIndex = 0
                If g10.IsDataRow(0) Then
                    If FileDelete(g10.Text("file_nm"), False) Then
                        g10.AllowDeleteRows = True
                        g10.DeleteRow(0)
                        Save("qoa720_g10")
                    End If
                End If
            Next

            If g10.SelectRow <= 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
        Finally
            g10.AllowDeleteRows = False
        End Try
    End Function


    Public Sub Open2(ByVal ComNo As String)


        com_no.Text = ComNo

        MyBase.Open()
        g10.AllowDeleteRows = False
    End Sub

    Private Sub FileUpLoad()
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        Dim RtnFileName As String

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                g10.AllowAddRows = True


                For Each FileName As String In dialog.FileNames
                    RtnFileName = ""
                    RtnFileName = [Shared].FileUpload("", FileName, "QOA700", False)
                    DualChk(RtnFileName)
                Next

            Catch ex As Exception
            Finally
                g10.AllowAddRows = False
            End Try

        End If
    End Sub
    Private Sub DualChk(ByVal GetFileNm)
        If GetFileNm = "" Then Exit Sub
        With g10
            .Find("file_nm=" & GetFileNm)
            If .Text("file_nm") <> GetFileNm Then

                .AddNewRow()
                .Text("com_no") = com_no.Text
                .Text("file_nm") = GetFileNm

                Save("qoa720_g10")

            End If
        End With
    End Sub

    Private Sub btn_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_up.Click
        If com_no.Text = "" Then Exit Sub
        FileUpLoad()
    End Sub

    Private Sub btn_dn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dn.Click

        If g10.RowCount <= 0 Then Exit Sub
        Dim Path As String = ""
        Dim TargetDialog As New FolderBrowserDialog
        If TargetDialog.ShowDialog = DialogResult.OK Then
            Path = TargetDialog.SelectedPath
            If Path = "" Then
                'PutWarning("Y3402") '저장될 폴더를 선택하세요
                MessageWarning("저장될 폴더를 선택하세요.")
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        For Row As Integer = 0 To g10.RowCount - 1
            If g10.IsDataRow(Row) Then
                FIleView(g10.Text("file_nm", Row), g10.Text("seq_no", Row), Path, False)
            End If
        Next

    End Sub
    Private Sub FIleView(ByVal GetFileNm As String, ByVal Seq As String, Optional ByVal Path As String = Nothing, Optional ByVal SHW As Boolean = True)
        Try
            [Shared].FileDownLoad(GetFileNm, "", SHW, "QOA700", Path)
            Save_Form4(Seq)

        Catch ex As Exception

        End Try

    End Sub
    Private Function FileDelete(ByVal GetFileNm As String, Optional ByVal YesNo As Boolean = True) As Boolean
        If GetFileNm = "" Then Return True
        Try
            If [Shared].FileDelete(GetFileNm, "", "QOA700", YesNo) Then
                If YesNo Then
                    g10.AllowDeleteRows = True
                    g10.DeleteRow(g10.RowIndex)
                    Save("qoa720_g10")
                End If
                Return True
            End If
        Catch ex As Exception
            MessageError(ex)
        Finally
            g10.AllowDeleteRows = False
        End Try

    End Function
    Private Function Save_Form() As Boolean

        Try
            If Save() = True Then
                Open_Form()
                Open_Form2()
                If com_no.Text <> "" Then g10.Find("com_no = " & com_no.Text)
                Return True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            com_no.Text = ""
            Open_Form2()
            Open_Form()
            g10.AllowDeleteRows = False
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Open("qoa720_f10")
            g10.AllowDeleteRows = False
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form2()
        Try
            Open("qoa720_g10")
            g10.AllowDeleteRows = False
            ' g10.Open()
            ' g20.Open()

            'img.ReadOnly = True
            'If img.Image Is Nothing Then
            '    img.BringToFront()
            '    img.Visible = False
            'Else
            '    img.Visible = True
            'End If

            If com_no.Text <> "" Then

                If cid.Text <> Parameter.Login.RegId.ToString Then
                    btn_up.Enabled = False
                Else
                    ' img.Visible = True
                    ' img.ReadOnly = False
                    btn_up.Enabled = True
                    use_rmk.Focus()
                End If
            Else
                ' img.Visible = True
                ' img.ReadOnly = False
                btn_up.Enabled = True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub
    '열람정보저장
    Private Function Save_Form3() As Boolean

        '본인이 아닌 경우만 사용
        Try

            If Parameter.Login.RegId.ToString <> cid.Text Then
                Dim dSet As DataSet = Me.OpenDataSet("qoa720_f20")    'test_workset이 WorkSet에 등록되어있어야 한다
                If dSet Is Nothing Then
                    Return True
                End If

                Dim dRow As DataRow

                dRow = dSet.Tables(0).NewRow
                dRow("com_no") = com_no.Text
                dRow("host_nm") = Parameter.System.HostName
                dRow("ip_addr") = Parameter.System.IPAddress
                dRow("mac_addr") = Parameter.System.MacAddress
                dRow("adap_nm") = Parameter.System.AdapterName
                dSet.Tables(0).Rows.Add(dRow)

                Return Me.Save("qoa720_f20")
            Else
                Return True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function
    '  FileDownLoad정보저장
    Private Function Save_Form4(ByVal Getseq As String) As Boolean

        '본인이 아닌 경우만 사용
        Try

            If Parameter.Login.RegId.ToString <> cid.Text Then
                Dim dSet As DataSet = Me.OpenDataSet("qoa720_f30")
                If dSet Is Nothing Then
                    Return True
                End If

                Dim dRow As DataRow

                dRow = dSet.Tables(0).NewRow
                dRow("com_no") = com_no.Text
                dRow("seq_no") = Getseq
                dSet.Tables(0).Rows.Add(dRow)

                Return Me.Save("qoa720_f30")
            Else
                Return True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                             ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click
        If g10.RowCount <= 0 Then Exit Sub
        If com_no.Text <> "" Then Save("qoa720_g10")

        ' com_no.Text = g10.Text("com_no")
        '  Open_Form2()
        Save_Form3()
    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        If g10.RowCount <= 0 Then Exit Sub

        FIleView(g10.Text("file_nm"), g10.Text("seq_no"))

    End Sub


    Private Sub img_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        '  CallImageView()
    End Sub

    Private Sub CallImageView()
        'If com_no.Text = "" Then Exit Sub
        'If img.Image Is Nothing Then Exit Sub
        'Try
        '    'eImage 에 Image Property 추가
        '    Dim f As ImageView
        '    f = New ImageView
        '    f.LoadPicture(img.Image, com_no.Text)
        '    f.ShowDialog()

        'Catch ex As Exception
        '    MessageError(ex)
        'End Try
    End Sub
    Private Sub g10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles g10.KeyDown
        If g10.RowCount <= 0 Or Parameter.Login.RegId.ToString <> cid.Text Then Exit Sub

        If e.KeyCode = Keys.Delete Then
            FileDelete(g10.Text("file_nm"))
        End If
    End Sub

    Private Sub g10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g10.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            Save_Form()
            If com_no.Text = "" Then Exit Sub

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g10, fileNm) Then

                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g10.AllowAddRows = True
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fullPath = fileNm
                fileNm = [Shared].FileUpload("", fileNm, "QOA700", False) '[Shared].FileUpload("", fileNm)
                '
                If fileNm <> "" Then
                    Dim f As New System.IO.FileInfo(fullPath)
                    g10.AddNewRow()
                    g10.Text("file_nm") = fileNm
                End If

            Next
            g10.AllowAddRows = False

            Me.Save("qoa720_g10")
            g10.Open()
            g10.AllowDeleteRows = False

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

    Private Sub g10_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g10.DragOver
        If btn_up.Enabled = False Then Exit Sub
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
