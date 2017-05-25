Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FMA200

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FTP Upload용
        g30.AllowDrop = True

        ''Drag & Drop으로 만 신규파일 추가가능
        ''Grid의 삭제 버턴으로만 삭제 가능
        g30.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g30.AllowDeleteRows = False '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다
    End Sub


    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                g20.AddNewRow()
            Case MenuType.Save
                If Me.Save() Then
                    Dim param As OpenParameters = New OpenParameters
                    param.Add("@fa_no", g10.Text("fa_no"))
                    Me.Open("fma200_g20", param)
                End If

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

#Region "FTP 관리"

    Private Sub g30_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g30.ButtonPressed
        Dim fileID As String = g30.Text("file_id")
        Dim fileNm As String = g30.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                'If [Shared].FileDelete(fileID, fileNm) = True Then
                ' 오류수정: fileID 가 없어도 행 삭제되게 해야한다
                If fileID = "" OrElse [Shared].FileDelete(fileID, fileNm) = True Then

                    g30.AllowDeleteRows = True
                    g30.DeleteRow(g30.RowIndex)
                    g30.AllowDeleteRows = False

                    Me.Save(g30.WorkSet)
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


    Private Sub g30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g30, fileNm) Then
                    If MessageYesNo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + _
                                    "그래도 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g30.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                'If fullPath <> "" Then
                ' 오류수정: fileID 가 없어면 저장 안되게 해야한다
                If FileID <> "" And fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g30.AddNewRow()
                    g30.Text("file_id") = FileID
                    g30.Text("file_nm") = fileNm
                    g30.Text("file_size") = f.Length.ToString
                End If

            Next
            g30.AllowAddRows = False

            Me.Save(g30.WorkSet)
            g30.Open()
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

    Private Sub g30_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region


End Class
