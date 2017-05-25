Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMG300

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                Me._Save()

            Case MenuType.Print

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Function _Save() As Boolean
        If Me.Save() Then

            Dim saveNo As String
            saveNo = g10.Text("bad_id")

            Me.Open()

            Dim find(0) As String
            find(0) = "bad_id=" + saveNo
            g10.Find(find)

            Return True
        End If
    End Function


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g20.AllowDrop = True
    End Sub

    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed
        Dim fileNm As String = g20.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                If [Shared].FileDelete(fileNm) = True Then
                    g20.AllowDeleteRows = True
                    g20.DeleteRow(g20.RowIndex)
                    g20.AllowDeleteRows = False

                    Me.Save("qmg300_g20")
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        End If

        If columnName = "show" Then
            [Shared].FileDownLoad(fileNm, , True)
        End If

        If columnName = "down" Then
            [Shared].FileDownLoad(fileNm)
        End If
    End Sub

    Private Sub g20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not Me.Save("qmg300_f10") Then
                Exit Sub
            End If

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
                fileNm = [Shared].FileUpload("", fileNm)
                If fileNm <> "" Then
                    Dim f As New System.IO.FileInfo(fullPath)
                    g20.AddNewRow()
                    g20.Text("file_nm") = fileNm
                    g20.Text("file_size") = f.Length.ToString
                End If

            Next
            g20.AllowAddRows = False

            Me.Save("qmg300_g20")
            g20.Open()


            'File 하나 일때
            'file_nm.Text = e.Data.GetData(DataFormats.FileDrop)(0)
            'If file_nm.Text <> "" Then
            '    Dim fileNm As String = [Shared].FileUpload("", file_nm.Text)
            '    If fileNm <> "" Then
            '        file_nm.Text = fileNm
            '        If Me.Save("qmg300_f20") Then
            '            Me.Open()
            '        End If
            '    End If
            'End If

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


    'Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click

    '    If g10.RowCount <= 0 Then
    '        Exit Sub
    '    End If

    '    Try
    '        Dim fileNm As String = [Shared].FileUpload()
    '        If fileNm <> "" Then
    '            file_nm.Text = fileNm
    '            If Me.Save("qmg300_f20") Then
    '                Me.Open()
    '            End If
    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
    '    [Shared].FileDownLoad(file_nm.Text)
    'End Sub

    'Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
    '    Try
    '        If [Shared].FileDelete(file_nm.Text) = True Then
    '            file_nm.Text = ""
    '            Me.Save("qmg300_f20")
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    file_nm.AllowDrop = True
    'End Sub

    'Private Sub file_nm_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles file_nm.DragDrop
    '    If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '        file_nm.Text = e.Data.GetData(DataFormats.FileDrop)(0)

    '        If file_nm.Text <> "" Then
    '            Dim fileNm As String = [Shared].FileUpload("", file_nm.Text)
    '            If fileNm <> "" Then
    '                file_nm.Text = fileNm
    '                If Me.Save("qmg300_f20") Then
    '                    Me.Open()
    '                End If
    '            End If
    '        End If

    '    End If
    'End Sub

    'Private Sub file_nm_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles file_nm.DragOver
    '    If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If
    'End Sub


End Class
