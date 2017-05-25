Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class DMA100
    Dim chg_yn As String = "0"
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.NewForm()
        '품목코드In 자동채번 설정
        itm_id.CodeNo = "DMA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'itm_id.CodeDateField = out_dt

        img.Visible = False

        g90.RecordNavigator = True

        'FTP Upload용
        g90.AllowDrop = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save

                save_mmv100_2(chg_yn)

                If Me.Save() Then
                    Dim saveID As String = g10.Text("itm_id")

                    Me.Open()

                    g10.Find("itm_id=" + saveID)
                End If

            Case MenuType.New

                Me.NewForm()

            Case MenuType.Delete

                Me.Delete_Form()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Public Overrides Sub NewForm()
        f_itm_cd.Text = ""
        itm_id.Text = ""

        Me.OpenTrigger("dma100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

        itm_cd.Focus()
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            'Me.Open("dma100_f10")
            Me.OpenTrigger("dma100_g10")
        End If

        itm_cd.Focus()
    End Function

    Private Function Delete_Form() As Boolean

        If Me.Delete("dma100_f10") = ExcuteResult.Succeeded Then
            Me.Open()
        End If

        itm_cd.Focus()

    End Function

    Private Sub img_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        CallImageView(1)
    End Sub

    Private Sub CallImageView(ByVal GetID As String)
        If itm_cd.Text = "" Or GetID = "" Then Exit Sub
        If img.Image Is Nothing Then Exit Sub
        Try
            'eImage 에 Image Property 추가
            '160225SMK잠깐막기
            'Dim f As ImageView
            'f = New ImageView
            'f.LoadPicture(img.Image, itm_cd.Text)
            'f.ShowDialog()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    'Private Sub call_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call_img.Click
    '    CallImageView(1)
    'End Sub

    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click
        If img.Visible Then
            img.Visible = False
            Me.SplitContainer4.SplitterDistance = 35
        Else
            img.Visible = True
            Me.SplitContainer4.SplitterDistance = 220
        End If
    End Sub

    '#Region "FTP 관리"

    '    Private Sub g90_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g90.ButtonPressed
    '        Dim fileID As String = g90.Text("file_id")
    '        Dim fileNm As String = g90.Text("file_nm")
    '        If fileNm = "" Then
    '            Exit Sub
    '        End If

    '        If columnName = "del" Then
    '            Try
    '                If [Shared].FileDelete(fileID, fileNm) = True Then
    '                    g90.AllowDeleteRows = True
    '                    g90.DeleteRow(g90.RowIndex)
    '                    g90.AllowDeleteRows = False

    '                    Me.Save(g90.WorkSet)
    '                End If
    '            Catch ex As Exception
    '                MessageInfo(ex)
    '            End Try

    '        End If

    '        If columnName = "show" Then
    '            [Shared].FileDownLoad(fileID, fileNm, , True)
    '        End If

    '        If columnName = "down" Then
    '            [Shared].FileDownLoad(fileID, fileNm)
    '        End If
    '    End Sub


    '    Private Sub g90_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g90.DragDrop
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

    '            If Not MyBase.Save() Then
    '                Exit Sub
    '            End If

    '            'Grid내 같은 File명 체크
    '            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
    '                fileNm = System.IO.Path.GetFileName(fileNm)
    '                If Me._IsExists(g90, fileNm) Then

    '                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
    '                    Exit Sub
    '                End If
    '            Next

    '            'Grid에 선택파일 추가
    '            Dim fullPath As String
    '            g90.AllowAddRows = True
    '            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

    '                Dim FileID As String = [Shared].FileUpload("", fullPath)
    '                If fullPath <> "" Then

    '                    '파일명만 분리
    '                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

    '                    Dim f As New System.IO.FileInfo(fullPath)
    '                    g90.AddNewRow()
    '                    g90.Text("file_id") = FileID
    '                    g90.Text("file_nm") = fileNm
    '                    g90.Text("file_size") = f.Length.ToString
    '                End If

    '            Next
    '            g90.AllowAddRows = False

    '            Me.Save(g90.WorkSet)
    '            g90.Open()
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

    '    Private Sub g90_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g90.DragOver
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '            e.Effect = DragDropEffects.Copy
    '        End If
    '    End Sub

    '#End Region


#Region "FTP관리"

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Call FileAdd()
    End Sub

    Private Sub FileDelete_All()
        Try
            g90.AllowDeleteRows = True

            For Row As Integer = 0 To g90.RowCount - 1
                g90.RowIndex = 0

                If [Shared].FileDelete(g90.Text("file_id"), g90.Text("file_nm"), , "DMA100", False) = True Then
                    g90.DeleteRow(0)

                End If

            Next

        Catch ex As Exception
        Finally
            g90.AllowDeleteRows = False
        End Try

    End Sub


    Private Sub FileAdd()
        Dim fileID As String = g90.Text("file_id")
        'Dim fileNm As String = g90.Text("file_nm")
        'If fileNm = "" Then
        '    Exit Sub
        'End If
        'Dim testm_no As String = ""

        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        'Dim FileID As String
        If dialog.ShowDialog() = DialogResult.OK Then

            If Not MyBase.Save("dma100_g90") Then
                '저장실패시 코드채번 취소
                Me.WorkSet("dma100_g90").RecoverCodeNo()
                Exit Sub
            Else

                'testm_no = estm_no.Text
                g90.Open()
            End If

            'Grid내 같은 File명 체크
            For Each FileNm As String In dialog.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g90, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
            Next

            g90.AllowAddRows = True

            Try
                For Each fullPath As String In dialog.FileNames

                    fileID = [Shared].FileUpload("", fullPath, "DMA100", False)

                    If fullPath <> "" Then
                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                        Dim f As New System.IO.FileInfo(fullPath)

                        If g10.Text("file_nm") = "" Then
                            g90.AddNewRow()
                            g90.Text("file_id") = fileID
                            g90.Text("file_nm") = fileNm
                            g90.Text("file_size") = f.Length.ToString
                        Else
                            g90.Text("file_id", g10.RowCount - 1) = fileID
                            g90.Text("file_nm", g10.RowCount - 1) = fileNm
                            g90.Text("file_size", g10.RowCount - 1) = f.Length.ToString
                        End If

                        'g90.AddNewRow()
                        'g90.Text("file_id") = fileID
                        'g90.Text("file_nm") = fileNm
                        'g90.Text("file_size") = f.Length.ToString
                    End If

                Next

                Me.Save("dma100_g90")

            Catch ex As Exception
                MessageInfo(ex)
            Finally
                g90.AllowAddRows = False
            End Try

        End If
    End Sub

    Private Sub g90_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g90.ButtonPressed
        Dim FileID As String = g90.Text("file_id")
        Dim FileNm As String = g90.Text("file_nm")

        If FileNm = "" Then
            Exit Sub
        End If

        Select Case columnName
            Case "del"

                Try
                    If [Shared].FileDelete(FileID, FileNm) = True Then
                        g90.AllowDeleteRows = True
                        g90.DeleteRow(g90.RowIndex)
                        g90.AllowDeleteRows = False

                        Me.Save("dma100_g90")
                    End If
                Catch ex As Exception
                    MessageInfo(ex)
                End Try

            Case "show"
                [Shared].FileDownLoad(FileID, FileNm, , True)

            Case "down"
                [Shared].FileDownLoad(FileID, FileNm)

        End Select
    End Sub

    Private Sub g90_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g90.CellValueChanged
        '20150909 smk
        If ColumnName = "dsg_no" Then
            chg_yn = "1"
            'com_row = RowIndex
            'MsgBox(ToStr(g30.RowCount))
        End If
    End Sub

    Public Sub save_mmv100_2(chg_yn) '20150909 smk 
        If chg_yn = "1" Then
            p.Clear()
            p.Add("@ITM_ID", itm_id.Text)
            p.Add("@ITM_CD", itm_cd.Text)
            p.Add("@CUST_CD", g30.Text("cust_cd", g30.RowCount - 1))
            p.Add("@ITM_NM", itm_nm.Text)
            p.Add("@SPEC", g90.Text("dsg_no", g90.RowCount - 1))
            p.Add("@UP", g30.ToDec("up", g30.RowCount - 1))
            p.Add("@RMK", g30.Text("remk", g30.RowCount - 1))
            p.Add("@MB_NM", g30.Text("mb_nm", g30.RowCount - 1))

            Me.Open("mmv110_qry_dma100", p)
        Else

        End If


    End Sub


    Private Sub g90_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g90.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g90, fileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            g90.AllowAddRows = True

            For Each fullPath As String In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath, "DMA100", False)

                If fullPath <> "" Then
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                    Dim f As New System.IO.FileInfo(fullPath)

                    g90.AddNewRow()
                    g90.Text("file_id") = FileID
                    g90.Text("file_nm") = fileNm
                    g90.Text("file_size") = f.Length.ToString
                End If

            Next

            g90.AllowAddRows = False

            Me.Save("dma100_g90")
            g90.Open()

        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g90
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_nm", i) = fileNm Then Return True
            Next
        End With
        Return False
    End Function

    Private Sub g90_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g90.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub
#End Region
End Class
