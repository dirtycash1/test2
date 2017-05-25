Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMG101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        g50.RecordNavigator = True
        'FTP Upload용
        g50.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g50.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g50.AllowDeleteRows = True  '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다
    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

            Case MenuType.Save
                If Me.Save() Then

                    Dim saveNo As String
                    saveNo = g10.Text("bad_id")

                    Me.Open()

                    Dim find(0) As String
                    find(0) = "bad_id=" + saveNo
                    g10.Find(find)
                End If

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

#Region "FTP 관리"

    Private Sub g50_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g50.ButtonPressed
        Dim docCd As String = g50.Text("doc_cd")
        Dim fileID As String = g50.Text("file_id")
        Dim fileNm As String = g50.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                If [Shared].FileDelete(fileID, fileNm) = True Then
                    g50.AllowDeleteRows = True
                    g50.DeleteRow(g50.RowIndex)
                    g50.AllowDeleteRows = False

                    Me.Save(g50.WorkSet)
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


    Private Sub g50_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g50.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g50, fileNm) Then

                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g50.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                If fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g50.AddNewRow()
                    g50.Text("file_id") = FileID
                    g50.Text("file_nm") = fileNm
                    g50.Text("file_size") = f.Length.ToString
                End If

            Next
            g50.AllowAddRows = False

            Me.Save(g50.WorkSet)
            g50.Open()
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

    Private Sub g50_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g50.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region

End Class
