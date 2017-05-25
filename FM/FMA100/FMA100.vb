Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FMA100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'fa_no.CodeNo = "FMA100"
        'fa_no.CodeDateField = set_dt
        fa_no.ReadOnly = True

        'MyBase.Open()

        photo.Visible = False

        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
        g50.RecordNavigator = True
        g60.RecordNavigator = True
        g70.RecordNavigator = True
        g80.RecordNavigator = True
        g90.RecordNavigator = True

        'FTP Upload용
        g90.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g90.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g90.AllowDeleteRows = False '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Delete

                Me.WorkSet("fma100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub NewForm()
        fa_no.Text = ""
        fa_no.ReadOnly = False

        Me.OpenTrigger("fma100_g10")

    End Sub

    Public Overrides Sub Open()
        MyBase.Open()


        'Me.OpenTrigger("fma100_g10")

        'Me.Open("fma100_g10")

    End Sub

    Public Overrides Function Save() As Boolean
        If prod_yn.Checked Then
            If Not CheckRequired(fac_cd, wc_cd) Then
                Return False
            End If
        End If

        If MyBase.Save() Then
            Dim saveID As String = fa_no.Text
            MyBase.Open()
            g10.Find("fa_no=" + saveID)
        End If
    End Function

    Private Sub btn_pic_Click(sender As System.Object, e As System.EventArgs) Handles btn_pic.Click
        If photo.Visible Then
            photo.Visible = False
            Me.SplitContainer4.SplitterDistance = 28
        Else
            photo.Visible = True
            Me.SplitContainer4.SplitterDistance = 300
        End If
    End Sub

    Private Sub prod_yn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles prod_yn.CheckedChanged
        If prod_yn.Checked Then
            CheckRequired(fac_cd, wc_cd)
        End If
    End Sub


    'Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
    '    Me.OpenTrigger("fma100_g10")

    '    Select Case XtraTabControl.SelectedTabPageIndex

    '        Case "0"
    '            Me.Open("fma100_g20")
    '        Case "1"
    '            Me.Open("fma100_g30")
    '        Case "2"
    '            Me.Open("fma100_g40")
    '        Case "3"
    '            Me.Open("fma100_g50")
    '        Case "4"
    '            Me.Open("fma100_g60")
    '        Case "5"
    '            Me.Open("fma100_g70")
    '        Case "6"
    '            Me.Open("fma100_g80")
    '        Case "7"
    '            Me.Open("fma100_g90")

    '    End Select

    'End Sub


    'Private Sub XtraTabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl.SelectedPageChanged
    '    Select Case XtraTabControl.SelectedTabPageIndex

    '        Case "0"
    '            Me.Open("fma100_g20")
    '        Case "1"
    '            Me.Open("fma100_g30")
    '        Case "2"
    '            Me.Open("fma100_g40")
    '        Case "3"
    '            Me.Open("fma100_g50")
    '        Case "4"
    '            Me.Open("fma100_g60")
    '        Case "5"
    '            Me.Open("fma100_g70")
    '        Case "6"
    '            Me.Open("fma100_g80")
    '        Case "7"
    '            Me.Open("fma100_g90")

    '    End Select
    'End Sub

#Region "FTP 관리"

    Private Sub g90_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g90.ButtonPressed
        Dim fileID As String = g90.Text("file_id")
        Dim fileNm As String = g90.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                'If [Shared].FileDelete(fileID, fileNm) = True Then
                ' 오류수정: fileID 가 없어도 행 삭제되게 해야한다
                If fileID = "" OrElse [Shared].FileDelete(fileID, fileNm) = True Then

                    g90.AllowDeleteRows = True
                    g90.DeleteRow(g90.RowIndex)
                    g90.AllowDeleteRows = False

                    Me.Save(g90.WorkSet)
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        End If

        If columnName = "show" Then
            [Shared].FileDownLoad(fileID, fileNm, , True)
        End If

        If columnName = "down" Then
            [Shared].FileDownLoad(fileID, fileNm)
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
                    If MessageYesNo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + _
                                    "그래도 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g90.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                'If fullPath <> "" Then
                ' 오류수정: fileID 가 없어면 저장 안되게 해야한다
                If FileID <> "" And fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g90.AddNewRow()
                    g90.Text("file_id") = FileID
                    g90.Text("file_nm") = fileNm
                    g90.Text("file_size") = f.Length.ToString
                End If

            Next
            g90.AllowAddRows = False

            Me.Save(g90.WorkSet)
            g90.Open()
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

    Private Sub g90_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g90.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region


End Class
