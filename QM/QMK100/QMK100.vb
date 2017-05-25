Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class QMK100


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mng_no.ReadOnly = True

        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
     
        'FTP Upload용
        g40.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g40.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g40.AllowDeleteRows = True  '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Delete

                Me.WorkSet("qmk100_f10").DeleteRow()

                MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub NewForm()
        mng_no.Text = ""
        mng_no.ReadOnly = False

        Me.OpenTrigger("qmk100_g10")

    End Sub

    Public Overrides Sub Open()
        MyBase.Open()

    End Sub

    Public Overrides Function Save() As Boolean
        
        If MyBase.Save() Then
            Dim saveID As String = mng_no.Text
            MyBase.Open()
            g10.Find("mng_no=" + saveID)
        End If
    End Function


#Region "FTP 관리"

    Private Sub g40_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g40.ButtonPressed
        Dim fileID As String = g40.Text("file_id")
        Dim fileNm As String = g40.Text("file_nm")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                If [Shared].FileDelete(fileID, fileNm) = True Then
                    g40.AllowDeleteRows = True
                    g40.DeleteRow(g40.RowIndex)
                    g40.AllowDeleteRows = False

                    Me.Save(g40.WorkSet)
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


    Private Sub g40_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g40.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g40, fileNm) Then

                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g40.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                If fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g40.AddNewRow()
                    g40.Text("file_id") = FileID
                    g40.Text("file_nm") = fileNm
                    g40.Text("file_size") = f.Length.ToString
                End If

            Next
            g40.AllowAddRows = False

            Me.Save(g40.WorkSet)
            g40.Open()
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

    Private Sub g40_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g40.DragOver
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

#End Region


  
    
End Class
