Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class SCB200
    Private OldH As Long = 0, OldW As Long = 0
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        doc_no.CodeNo = "SCB200"
        EPanel2.BringToFront()

        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
        EPanel3.SetSplitter(SplitContainer2, SplitContainer2.Panel2)
        If Parameter.Login.UserKd <> "SC700300" Then
            SplitContainer1.SplitterDistance = EPanel1.Height * 0.65
        Else
            SplitContainer1.Orientation = Orientation.Vertical
            'EPanelChg()
        End If

        img.BringToFront()
        Dim FntNm As String = Parameter.Login.FontNm, Fntsz As Single = ToDec(Parameter.Login.FontSz)
        If Fntsz = 0 Then Fntsz = 9

        If FntNm = "" Then FntNm = "Tahoma"
        title.Font = New System.Drawing.Font(FntNm, Fntsz, FontStyle.Bold)
        g10.SelectRow = True
        g20.SelectRow = True

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
                'If Parameter.Login.UserKd = "SC700300" Then Exit Sub
                If doc_no.Text <> "" And Parameter.Login.RegId.ToString <> cid.Text Then Exit Sub '본인이 아닌경우 수정 불가
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

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            doc_no.Text = ""
            Open_Form2()
            Open_Form()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Open("scb200_g10")
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form2()
        Try
            Open("scb200_f10")
            g20.Open()
            img.ReadOnly = True
            If img.Image Is Nothing Then
                img.BringToFront()
                img.Visible = False
            Else
                img.Visible = True
            End If

            If doc_no.Text <> "" Then
                lbl_nm.Text = nm.Text
                lbl_dt.Text = cdt.Text & "   [ 열람 : " & read_cnt.ToDec & " ]"
                If cid.Text <> Parameter.Login.RegId.ToString Then
                    title.ReadOnly = True
                    rmks.ReadOnly = True
                    btn_up.Enabled = False
                Else
                    img.Visible = True
                    img.ReadOnly = False
                    title.ReadOnly = False
                    rmks.ReadOnly = False
                    btn_up.Enabled = True
                    rmks.Focus()
                End If
            Else
                img.Visible = True
                img.ReadOnly = False
                lbl_nm.Text = Parameter.Login.EmpNm
                lbl_dt.Text = ""
                title.ReadOnly = False
                rmks.ReadOnly = False
                btn_up.Enabled = True
                title.Focus()
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try
            If Save() = True Then
                Open_Form()
                Open_Form2()
                If doc_no.Text <> "" Then g10.Find("doc_no = " & doc_no.Text)
                Return True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    '열람정보저장
    Private Function Save_Form3() As Boolean

        '본인이 아닌 경우만 사용
        Try

            If Parameter.Login.RegId.ToString <> cid.Text Then
                Dim dSet As DataSet = Me.OpenDataSet("scb200_f30")    'test_workset이 WorkSet에 등록되어있어야 한다
                If dSet Is Nothing Then
                    Return True
                End If

                Dim dRow As DataRow

                dRow = dSet.Tables(0).NewRow
                dRow("doc_no") = doc_no.Text
                dRow("host_nm") = Parameter.System.HostName
                dRow("ip_addr") = Parameter.System.IPAddress
                dRow("mac_addr") = Parameter.System.MacAddress
                dRow("adap_nm") = Parameter.System.AdapterName
                dSet.Tables(0).Rows.Add(dRow)

                Return Me.Save("scb200_f30")
            Else
                Return True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function

    Private Function DocDelete() As Boolean
        If doc_no.Text = "" Then Return False
        If Parameter.Login.RegId.ToString <> cid.Text And Parameter.Login.UserKd = "SC700300" Then
            MessageInfo("문서 작성자만 삭제가 가능합니다.!")
            Return False '본인이 아닌 경우 삭제 불가
        End If

        If MessageYesNo("선택 게시물 정보를 삭제하시겠습니까?" & vbLf & vbLf & "(첨부 파일이 있는 경우 FileServer의 해당 파일 삭제 후 문서가 삭제됩니다.)") <> MsgBoxResult.Yes Then Return False

        If g10.ToDec("read_cnt") > 0 Then
            If MessageYesNo("게시물 열람 정보가 존재합니다. 그래도 삭제하시겠습니까?") <> MsgBoxResult.Yes Then Return False
        End If

        '첨부파일이 있는 경우 삭제처리
        If Not FilesDelete() Then Return False

        If Delete("scb200_f10", False) = ExcuteResult.Succeeded Then Return True
    End Function

    Private Function FilesDelete() As Boolean
        Try
            For Row As Integer = 0 To g20.RowCount - 1
                g20.RowIndex = 0
                If g20.IsDataRow(0) Then
                    If FileDelete(g20.Text("file_nm"), False) Then
                        g20.AllowDeleteRows = True
                        g20.DeleteRow(0)
                        Save("scb200_g20")
                    End If
                End If
            Next

            If g20.SelectRow <= 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
        Finally
            g20.AllowDeleteRows = False
        End Try

    End Function

    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g10_Click(sender As Object, e As System.EventArgs) Handles g10.Click
        If g10.RowCount <= 0 Then Exit Sub
        If doc_no.Text <> "" Then Save("scb200_f10")

        doc_no.Text = g10.Text("doc_no")
        Open_Form2()
        Save_Form3()
    End Sub

    Private Sub EPanel1_DoubleClick(sender As Object, e As System.EventArgs) Handles EPanel1.DoubleClick
        If g10.Top = 75 Then
            g10.Dock = DockStyle.Fill
        Else
            g10.Dock = DockStyle.None
            g10.Top = 75
            g10.Left = 0
            g10.Width = EPanel1.Width
            g10.Height = EPanel1.Height - 77
            g10.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles)
        End If
    End Sub

    Private Sub SplitContainer2Panel1Chg()
        Dim H As Long = SplitContainer2.Panel1.Height - 75, W As Long = SplitContainer2.Panel1.Width - 6

        If W > 6 Then
            rmks.Width = W
        Else
            rmks.Width = 0
        End If

        If H > 20 Then
            rmks.Height = H
        Else
            rmks.Height = 0
        End If
    End Sub

    Private Sub SplitContainer2_Resize(sender As Object, e As System.EventArgs) Handles SplitContainer2.Resize
        SplitContainer2Panel1Chg()
        OldH = SplitContainer2.Panel1.Height
        OldW = SplitContainer2.Panel1.Width
    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer2.SplitterMoved

        If OldH > SplitContainer2.Panel1.Height Or OldW > SplitContainer2.Panel1.Width Then
            rmks.Width = 0
            rmks.Height = 0
        End If

        SplitContainer2Panel1Chg()

        OldH = SplitContainer2.Panel1.Height
        OldW = SplitContainer2.Panel1.Width

    End Sub

    Private Sub FIleView(GetFileNm As String, GetSq As String, Optional Path As String = Nothing, Optional SHW As Boolean = True)
        Try
            [Shared].FileDownLoad(GetFileNm, , SHW, , Path)

        Catch ex As Exception

        End Try

    End Sub

    Private Function FileDelete(GetFileNm As String, Optional YesNo As Boolean = True) As Boolean
        If GetFileNm = "" Then Return True
        Try
            If [Shared].FileDelete(GetFileNm, , , YesNo) Then
                If YesNo Then
                    g20.AllowDeleteRows = True
                    g20.DeleteRow(g20.RowIndex)
                    Save("scb200_g20")
                End If
                Return True
            End If
        Catch ex As Exception
            MessageError(ex)
        Finally
            g20.AllowDeleteRows = False
        End Try

    End Function

    Private Sub FileUpLoad()
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        Dim RtnFileName As String

        If dialog.ShowDialog() = DialogResult.OK Then
            Try
                g20.AllowAddRows = True

                For Each FileName As String In dialog.FileNames
                    RtnFileName = ""
                    RtnFileName = [Shared].FileUpload("", FileName, , False)
                    DualChk(RtnFileName)
                Next

            Catch ex As Exception
            Finally
                g20.AllowAddRows = False
            End Try

        End If
    End Sub

    Private Sub DualChk(GetFileNm)
        If GetFileNm = "" Then Exit Sub
        With g20
            .Find("file_nm=" & GetFileNm)
            If .Text("file_nm") <> GetFileNm Then

                .AddNewRow()
                .Text("file_nm") = GetFileNm
                Save("scb200_g20")

            End If
        End With
    End Sub

    Private Sub btn_up_Click(sender As System.Object, e As System.EventArgs) Handles btn_up.Click
        Save_Form()
        If doc_no.Text = "" Then Exit Sub
        FileUpLoad()
    End Sub

    Private Sub g20_DoubleClick(sender As Object, e As System.EventArgs) Handles g20.DoubleClick
        If g20.RowCount <= 0 Then Exit Sub
        FIleView(g20.Text("file_nm"), g20.Text("sq"))
    End Sub

    Private Sub g20_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles g20.KeyDown
        If g20.RowCount <= 0 Or Parameter.Login.RegId.ToString <> cid.Text Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            FileDelete(g20.Text("file_nm"))
        End If
    End Sub

    Private Sub btn_dn_Click(sender As System.Object, e As System.EventArgs) Handles btn_dn.Click
        If g20.RowCount <= 0 Then Exit Sub
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

        For Row As Integer = 0 To g20.RowCount - 1
            If g20.IsDataRow(Row) Then
                FIleView(g20.Text("file_nm", Row), g20.Text("sq", Row), Path, False)
            End If
        Next
    End Sub

    Private Sub CallImageView()
        If doc_no.Text = "" Then Exit Sub
        If img.Image Is Nothing Then Exit Sub
        Try
            'eImage 에 Image Property 추가
            Dim f As ImageView
            f = New ImageView
            f.LoadPicture(img.Image, title.Text)
            f.ShowDialog()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub img_DoubleClick(sender As Object, e As System.EventArgs) Handles img.DoubleClick
        'CallImageView()
    End Sub

    Private Sub g20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragDrop
        If btn_up.Enabled = False Then Exit Sub
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            Save_Form()
            If doc_no.Text = "" Then Exit Sub

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g20, fileNm) Then

                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g20.AllowAddRows = True
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fullPath = fileNm
                fileNm = [Shared].FileUpload("", fileNm, , False) '[Shared].FileUpload("", fileNm)
                If fileNm <> "" Then
                    Dim f As New System.IO.FileInfo(fullPath)
                    g20.AddNewRow()
                    g20.Text("file_nm") = fileNm
                End If

            Next
            g20.AllowAddRows = False

            Me.Save("scb200_g20")
            g20.Open()

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
        If btn_up.Enabled = False Then Exit Sub
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
