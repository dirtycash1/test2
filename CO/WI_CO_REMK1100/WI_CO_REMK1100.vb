Imports Frame7
Imports Base7
Imports Base7.Shared

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices

Public Class WI_CO_REMK1100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    Me.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '사용하려면 재정의 가능하다

            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

#Region "FTP관리"

    Private Sub sa_10_ButtonPressed(sender As Object, columnName As String) Handles sa_10.ButtonPressed
        Call button_press(sa_10, sender, columnName)
    End Sub
    Private Sub sa_20_ButtonPressed(sender As Object, columnName As String) Handles sa_20.ButtonPressed
        Call button_press(sa_20, sender, columnName)
    End Sub
    Private Sub b_10_ButtonPressed(sender As Object, columnName As String) Handles b_10.ButtonPressed
        Call button_press(b_10, sender, columnName)
    End Sub
    Private Sub b_20_ButtonPressed(sender As Object, columnName As String) Handles b_20.ButtonPressed
        Call button_press(b_20, sender, columnName)
    End Sub
    Private Sub j_10_ButtonPressed(sender As Object, columnName As String) Handles j_10.ButtonPressed
        Call button_press(j_10, sender, columnName)
    End Sub
    Private Sub j_20_ButtonPressed(sender As Object, columnName As String) Handles j_20.ButtonPressed
        Call button_press(j_20, sender, columnName)
    End Sub
    Private Sub sqc_10_ButtonPressed(sender As Object, columnName As String) Handles sqc_10.ButtonPressed
        Call button_press(sqc_10, sender, columnName)
    End Sub
    Private Sub sqc_20_ButtonPressed(sender As Object, columnName As String) Handles sqc_20.ButtonPressed
        Call button_press(sqc_20, sender, columnName)
    End Sub
    Private Sub jejo_10_ButtonPressed(sender As Object, columnName As String) Handles jejo_10.ButtonPressed
        Call button_press(jejo_10, sender, columnName)
    End Sub
    Private Sub jejo_20_ButtonPressed(sender As Object, columnName As String) Handles jejo_20.ButtonPressed
        Call button_press(jejo_20, sender, columnName)
    End Sub
    Private Sub ch_10_ButtonPressed(sender As Object, columnName As String) Handles ch_10.ButtonPressed
        Call button_press(ch_10, sender, columnName)
    End Sub
    Private Sub ch_20_ButtonPressed(sender As Object, columnName As String) Handles ch_20.ButtonPressed
        Call button_press(ch_20, sender, columnName)
    End Sub
    Private Sub g10_a_ButtonPressed(sender As Object, columnName As String) Handles g10_a.ButtonPressed
        Call button_press(g10_a, sender, columnName)
    End Sub
    Private Sub g10_b_ButtonPressed(sender As Object, columnName As String) Handles g10_b.ButtonPressed
        Call button_press(g10_b, sender, columnName)
    End Sub

    Private Sub gong_10_ButtonPressed(sender As Object, columnName As String) Handles gong_10.ButtonPressed
        Call button_press(gong_10, sender, columnName)
    End Sub

    Private Sub gong_20_ButtonPressed(sender As Object, columnName As String) Handles gong_20.ButtonPressed
        Call button_press(gong_20, sender, columnName)
    End Sub



    Private Sub button_press(ByVal g As eGrid, sender As Object, columnName As String)
        Dim FileID As String = g.Text("file_id")
        Dim FileNm As String = g.Text("file_nm")

        Select Case columnName
            Case "del"

                Try
                    'If [Shared].FileDelete(FileID, FileNm) = True Then
                    '    MsgBox("del")
                    '    g.AllowDeleteRows = True
                    '    g.DeleteRow(g.RowIndex)
                    '    g.AllowDeleteRows = False
                    '    g_save(g)
                    '    'Me.Save("co_remk1100_sa_10")
                    'End If

                    If [Shared].FileDelete(g.Text("file_id"), g.Text("file_nm"), , "WI_CO_REMK1100") = True Then
                        g.AllowDeleteRows = True
                        g.DeleteRow(g.RowIndex)
                        g.AllowDeleteRows = False
                        g_save(g)
                    End If

                Catch ex As Exception
                    MessageInfo(ex)
                End Try

            Case "show"
                'MsgBox("show")
                '[Shared].FileDownLoad(FileID, FileNm, "", True, "WI_CO_REMK1100")
                '[Shared].FileDownLoad(FileID, FileNm, "", True)
                [Shared].FileDownLoad(FileID, FileNm, , True, "WI_CO_REMK1100")

            Case "down"
                '[Shared].FileDownLoad2(FileID, FileNm, "", False, "WI_CO_REMK1100")
                Call FileSave(g, g.RowIndex)

            Case "upload"
                Call FileAdd(g, g.RowIndex)
        End Select
    End Sub

    Private Sub FileAdd(ByVal g As eGrid, RowIndex As Integer)
        'Dim fileID As String = sa_10.Text("file_id", RowIndex)
        'Dim fileNm As String = g90.Text("file_nm")
        'If fileNm = "" Then
        '    Exit Sub
        'End If

        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        'Dim FileID As String
        If dialog.ShowDialog() = DialogResult.OK Then

            'If Not MyBase.Save("co_remk1100_sa_10") Then
            '    '저장실패시 코드채번 취소
            '    Me.WorkSet("co_remk1100_sa_10").RecoverCodeNo()
            '    Exit Sub
            'Else
            '    g.Open()
            'End If

            'Grid내 같은 File명 체크
            For Each FileNm As String In dialog.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
            Next

            g.AllowAddRows = True
            Dim fileID As String
            Try
                For Each fullPath As String In dialog.FileNames

                    fileID = [Shared].FileUpload("", fullPath, "WI_CO_REMK1100", False)

                    If fullPath <> "" Then
                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                        Dim f As New System.IO.FileInfo(fullPath)
                        g.Text("file_id", RowIndex) = fileID
                        g.Text("file_nm", RowIndex) = fileNm
                        g.Text("file_size", RowIndex) = f.Length.ToString

                        'If g.Text("file_nm", RowIndex) = "" Then
                        '    g.AddNewRow()
                        '    g.Text("file_id", RowIndex) = fileID
                        '    g.Text("file_nm", RowIndex) = fileNm
                        '    g.Text("file_size", RowIndex) = f.Length.ToString
                        'Else
                        '    g.Text("file_id", RowIndex) = fileID
                        '    g.Text("file_nm", RowIndex) = fileNm
                        '    g.Text("file_size", RowIndex) = f.Length.ToString
                        'End If

                    End If

                Next

                Call g_save(g)
                'Me.Save("co_remk1100_sa_10")

            Catch ex As Exception
                MessageInfo(ex)
            Finally
                'sa_10.AllowAddRows = False
            End Try

        End If
    End Sub

    Private Sub FileSave(ByVal g As eGrid, RowIndex As Integer)   '160628 smk 새로생성
        Dim savefile As SaveFileDialog = New SaveFileDialog

        savefile.InitialDirectory = "C:\"
        savefile.Title = "첨부파일 저장"
        'savefile.DefaultExt = "jpg"
        savefile.Filter = "JPEG(*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|All Files (*.*)|*.*"
        savefile.FilterIndex = 0
        savefile.RestoreDirectory = True

        If savefile.ShowDialog() = DialogResult.OK Then
            Dim file_name As String

            'Grid내 같은 File명 체크
            For Each FileNm As String In savefile.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
                file_name = FileNm

            Next

            Try
                For Each fullPath As String In savefile.FileNames
                    '[Shared].FileDownLoad2(g.Text("file_id", RowIndex), g.Text("file_nm", RowIndex), "", True, "WI_CO_REMK1100", fullPath)

                    [Shared].FileDownLoad(g.Text("file_id", RowIndex), g.Text("file_nm", RowIndex), , True, "WI_CO_REMK1100")
                Next
            Catch ex As Exception
                MessageInfo(ex)
            Finally

            End Try


            'Select Case savefile.FileName.Substring(savefile.FileName.IndexOf("."))
            'Case ".jpg"
            '    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            'Case ".gif"
            '    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
            'Case ".bmp"
            '    ChartControl1.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            'Case Else
            '    MsgBox("지정된 그림파일 형식이 아니거나 잘못된 형식입니다.")
            'End Select
            'MsgBox(savefile.FileName + "에 저장되었습니다.")
            'g.ExportToImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            'Dim ppi() As Printing.PreviewPageInfo = g.GetPreviewPageInfo()

            'Dim w As New IO.StreamWriter(savefile.FileName)
            'Dim i As Integer
            'For i = 0 To g.RowCount - 1
            '    w.WriteLine(g.RowIndex)
            'Next
            'w.Close()

        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With sa_10
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_nm", i) = fileNm Then Return True
            Next
        End With
        Return False
    End Function

    Private Sub g_save(ByVal g As eGrid)
        If g.Name = "sa_10" Then
            Me.Save("remk1100_sa_10")
        ElseIf g.Name = "sa_20" Then
            Me.Save("remk1100_sa_20")
        ElseIf g.Name = "b_10" Then
            Me.Save("remk1100_b_10")
        ElseIf g.Name = "b_20" Then
            Me.Save("remk1100_b_20")
        ElseIf g.Name = "j_10" Then
            Me.Save("remk1100_j_10")
        ElseIf g.Name = "j_20" Then
            Me.Save("remk1100_j_20")
        ElseIf g.Name = "sqc_10" Then
            Me.Save("remk1100_sqc_10")
        ElseIf g.Name = "sqc_20" Then
            Me.Save("remk1100_sqc_20")
        ElseIf g.Name = "jejo_10" Then
            Me.Save("remk1100_jejo_10")
        ElseIf g.Name = "jejo_20" Then
            Me.Save("remk1100_jejo_20")
        ElseIf g.Name = "ch_10" Then
            Me.Save("remk1100_ch_10")
        ElseIf g.Name = "ch_20" Then
            Me.Save("remk1100_ch_20")
        ElseIf g.Name = "gong_10" Then
            Me.Save("remk1100_gong_10")
        ElseIf g.Name = "gong_20" Then
            Me.Save("remk1100_gong_20")

        ElseIf g.Name = "g10_a" Then
            Me.Save("remk1100_g10_a")
        ElseIf g.Name = "g10_b" Then
            Me.Save("remk1100_g10_b")

        End If
    End Sub

#End Region

  
End Class


