Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QML100
    Private AftRow As Boolean

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        clm_no.CodeNo = "QMl100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        clm_no.CodeDateField = clm_dt
        g10.SelectRow = True

        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open("qml100_g10")

            Case MenuType.Save

                If Me.Save() Then
                    Try
                        AftRow = True
                        MyBase.Open("qml100_g10")
                        If clm_no.Text <> "" Then
                            g10.Find("clm_no=" & clm_no.Text)
                        End If
                    Catch ex As Exception
                    Finally
                        AftRow = False
                    End Try
                End If

            Case MenuType.New

                Me.New_Form()

            Case MenuType.Delete
                If clm_no.Text = "" Then Exit Sub
                If Delete("qml100_f10") = ExcuteResult.Succeeded Then
                    MyBase.Open("qml100_g10")
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()

        clm_no.Text = ""
        Open_Form()

    End Sub

    Private Sub Open_Form()
        Try
            MyBase.Open("qml100_f10")
            MyBase.Open("qml100_g20")

            If clm_no.Text = "" Then
                clm_dt.ReadOnly = False
            Else
                clm_dt.ReadOnly = True
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    Private Sub clm_no_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles clm_no.TextChanged

        'If clm_no.Text = "" Then
        '    clm_no.CodeNo = "QMl100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        '    clm_no.CodeDateField = clm_dt
        'End If

    End Sub

    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed
        Dim fileNm As String = g20.Text("file_add")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                If [Shared].FileDelete(fileNm) = True Then
                    g20.Text("file_add") = ""

                    Me.Save("qml100_g20")
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

    Private Sub g20_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub g20_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g20.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not Me.Save("qml100_f10") Then
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
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fullPath = fileNm
                fileNm = [Shared].FileUpload("", fileNm)
                If fileNm <> "" Then
                    Dim f As New System.IO.FileInfo(fullPath)
                    g20.Text("file_add") = fileNm
                    Me.Save("qml100_g20")
                    Exit For
                End If

            Next


            'g20.Open()

        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_add", i) = fileNm Then
                    Return True
                End If
            Next
        End With
        Return False
    End Function

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        If AftRow Then Exit Sub
        With g10
            clm_no.Text = g10.Text("clm_no")
            Open_Form()
        End With
    End Sub

End Class
