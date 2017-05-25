Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Collections


Public Class MMA300
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        spc_1.Panel1Collapsed = False

        Me.Clear()

        'MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save
                If Not Saves() Then Exit Sub
            Case MenuType.New
                Me.Clear()
            Case MenuType.Find
                Me.Find()
            Case MenuType.Cancel
                Me.Clear()
            Case MenuType.Delete
                Me.Del()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

                'Open_Form()
                
                'Case MenuType.Cancel
                'Me.Clear()
                'Case MenuType.Confirm
                'If Not ConFrim() Then Exit Sub
                'Case MenuType.Deconfirm
                'If Not DeConFrim() Then Exit Sub
                'Case MenuType.Find
                'Me.Find()
                'Case MenuType.Delete
                'If Not Del() Then Exit Sub
                

        End Select

    End Sub
    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False
        End If
    End Sub

    Private Function Del() As Boolean

        If r_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        If MessageYesNo("이력번호 " & r_no.Text & "를 삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@R_NO", r_no.Text)

            Me.Open("mma300_del", p)

            Me.Clear()

            Me.Open()

        End If

        Return True
    End Function

    Private Sub Max_NO()
        ' od_no 번호 채번
        r_no.CodeNo = "MMA300"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        r_no.CodeDateField = r_dt
    End Sub

    Private Function Saves() As Boolean

        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            Max_NO()  '이력번호 채번

            If MyBase.Save() Then

            End If
            'stts.Text = "S"    '진행상태를 어떻게 할지 미결정으로 인해, 막아둠 
        End If

        Return True
    End Function


    Private Sub Clear()
        p.Clear()
        p.Add("@from_dt", "1900-01-01")
        p.Add("@to_dt", "1900-01-01")
        p.Add("@R_NO", "00")
        p.Add("@r_dept", "00")
        p.Add("@r_gu", "00")
        p.Add("@r_emp", "00")
        p.Add("@d_dept", "00")
        p.Add("@d_emp", "00")
        p.Add("@cs_cd", "00")
        p.Add("@stts", "00")
        p.Add("@t_nm", "00")
        p.Add("@t_gu", "00")

        Me.Open("mma300_head", p)
        Me.Open("mma300_g300_2", p)
        Me.Open("mma300_g301", p)
        Me.Open("mma300_g302", p)

    End Sub


    Private Sub g_list_DoubleClick(sender As Object, e As System.EventArgs) Handles g_list.DoubleClick
        'Me.Clear()

        'r_no.Text = g_list.Text("R_NO", g_list.RowIndex)
        'r_dt.Text = g_list.Text("R_DT", g_list.RowIndex)
        'r_dept.Text = g_list.Text("R_DEPT", g_list.RowIndex)
        'r_emp.Text = g_list.Text("R_EMP", g_list.RowIndex)
        'r_gu.Text = g_list.Text("R_GU", g_list.RowIndex)
        'd_dept.Text = g_list.Text("D_DEPT", g_list.RowIndex)
        'd_emp.Text = g_list.Text("D_EMP", g_list.RowIndex)
        'cs_cd.Text = g_list.Text("CS_CD", g_list.RowIndex)
        'stts.Text = g_list.Text("STTS", g_list.RowIndex)
        't_nm.Text = g_list.Text("T_NM", g_list.RowIndex)
        't_gu.Text = g_list.Text("T_GU", g_list.RowIndex)

        'Me.Open()

        Dim p As New OpenParameters

        p.Add("@R_NO", g_list.Text("R_NO", g_list.RowIndex))
        Me.Open("mma300_head", p)
        Me.Open("mma300_g301", p)
        Me.Open("mma300_g302", p)
        Me.Open("mma300_g300_2", p)


        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

    Private Sub btn_find_Click(sender As Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As System.EventArgs) Handles btn_cancel.Click
        find_Clear()
    End Sub

    Private Sub find_Clear()
        p.Clear()
        p.Add("@from_dt", from_dt.Text)
        p.Add("@to_dt", to_dt.Text)
        p.Add("@find_r_no", "XXX")
        p.Add("@find_r_dept", find_r_dept.Text)
        p.Add("@find_r_emp", find_r_emp.Text)
        p.Add("@find_cs_cd", find_cs_cd.Text)
        p.Add("@find_stts", find_stts.Text)
        p.Add("@find_t_nm", find_t_nm.Text)

        Me.Open("mma300_list", p)
    End Sub


#Region "FTP관리"

    'Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
    '    Call FileAdd()
    'End Sub


    Private Sub g30_ButtonPressed(sender As Object, columnName As String) Handles g30.ButtonPressed

        Dim FileID As String = g30.Text("FILE_ID")
        Dim FileNm As String = g30.Text("FILE_NM")

        'If FileNm = "" Then
        '    Exit Sub
        'End If

        If columnName = "del" Then

            Try
                If [Shared].FileDelete(FileID, FileNm) = True Then
                    g30.AllowDeleteRows = True
                    g30.DeleteRow(g30.RowIndex)
                    g30.AllowDeleteRows = False

                    Me.Save("mma300_g302")
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        ElseIf columnName = "show" Then
            [Shared].FileDownLoad(FileID, FileNm, , True)

        ElseIf columnName = "down" Then
            [Shared].FileDownLoad(FileID, FileNm)

        ElseIf columnName = "upload" Then
            Call FileAdd()

        End If

        'Select Case columnName
        '    Case "del"
        '        Try
        '            If [Shared].FileDelete(FileID, FileNm) = True Then
        '                g30.AllowDeleteRows = True
        '                g30.DeleteRow(g30.RowIndex)
        '                g30.AllowDeleteRows = False

        '                Me.Save("dma100_sb_g30")
        '            End If
        '        Catch ex As Exception
        '            MessageInfo(ex)
        '        End Try

        '    Case "show"
        '        MsgBox("show")
        '        [Shared].FileDownLoad(FileID, FileNm, , True)

        '    Case "down"
        '        [Shared].FileDownLoad(FileID, FileNm)

        '    Case "upload"
        '        MsgBox("upload")
        '        '[Shared].FileDownLoad(FileID, FileNm)
        '        Call FileAdd()

        'End Select
    End Sub


    Private Sub FileAdd()

        If r_no.Text = "" Then
            If Not Saves() Then Exit Sub
        End If


        Dim fileID As String = g30.Text("FILE_ID")

        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        dialog.Multiselect = True

        'Dim FileID As String
        If dialog.ShowDialog() = DialogResult.OK Then

            If Not MyBase.Save("mma300_g302") Then
                '저장실패시 코드채번 취소
                Me.WorkSet("mma300_g302").RecoverCodeNo()
                Exit Sub
            Else
                'testm_no = estm_no.Text
                g30.Open()
            End If

            'Grid내 같은 File명 체크
            For Each FileNm As String In dialog.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g30, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
            Next

            g30.AllowAddRows = True

            Try
                For Each fullPath As String In dialog.FileNames

                    fileID = [Shared].FileUpload("", fullPath, "MMA300", False)

                    If fullPath <> "" Then
                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                        Dim f As New System.IO.FileInfo(fullPath)

                        If g10.Text("FILE_NM") = "" Then
                            g30.AddNewRow()
                            g30.Text("FILE_ID") = fileID
                            g30.Text("FILE_NM") = fileNm
                            g30.Text("FILE_SIZE") = f.Length.ToString

                        Else
                            g30.Text("FILE_ID", g10.RowCount - 1) = fileID
                            g30.Text("FILE_NM", g10.RowCount - 1) = fileNm
                            g30.Text("FILE_SIZE", g10.RowCount - 1) = f.Length.ToString

                        End If

                        '사용여부 자동체크 
                        'For i = 0 To g30.RowCount - 1
                        '    g30.Text("stts", i) = "0"
                        'Next
                        'g30.Text("stts", g30.RowCount) = "1"

                    End If

                Next

                Me.Save("mma300_g302")

            Catch ex As Exception
                MessageInfo(ex)
            Finally
                g30.Open()
                'g30.AllowAddRows = False
            End Try

        End If
    End Sub


    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g30
            For i As Integer = 0 To .RowCount - 1
                If .Text("FILE_NM", i) = fileNm Then Return True
            Next
        End With
        Return False
    End Function



    Private Sub FileDelete_All()
        Try
            g30.AllowDeleteRows = True

            For Row As Integer = 0 To g30.RowCount - 1
                g30.RowIndex = 0

                If [Shared].FileDelete(g30.Text("file_id"), g30.Text("file_nm"), , "MMA300", False) = True Then
                    g30.DeleteRow(0)

                End If

            Next

        Catch ex As Exception
        Finally
            g30.AllowDeleteRows = False
        End Try

    End Sub



    '#Region "FTP 관리"

    '    Private Sub g30_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g30.ButtonPressed
    '        ''Dim docCd As String = g30.Text("doc_cd")
    '        'Dim fileID As String = g30.Text("FILE_ID")
    '        'Dim fileNm As String = g30.Text("FILE_NM")
    '        ''If fileNm = "" Then
    '        ''    Exit Sub
    '        ''End If

    '        'If columnName = "del" Then
    '        '    Try
    '        '        If [Shared].FileDelete(fileID, fileNm) = True Then
    '        '            g30.AllowDeleteRows = True
    '        '            g30.DeleteRow(g30.RowIndex)
    '        '            g30.AllowDeleteRows = False

    '        '            Me.Save(g30.WorkSet)
    '        '        End If
    '        '    Catch ex As Exception
    '        '        MessageInfo(ex)
    '        '    End Try

    '        'End If

    '        'If columnName = "show" Then
    '        '    [Shared].FileDownLoad(fileID, fileNm, , True)
    '        'End If

    '        'If columnName = "down" Then
    '        '    [Shared].FileDownLoad(fileID, fileNm)
    '        'End If

    '        If columnName = "down" Then
    '            MsgBox("11")
    '        End If


    '    End Sub


    '    Private Sub g30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragDrop
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

    '            If Not MyBase.Save() Then
    '                Exit Sub
    '            End If

    '            'Grid내 같은 File명 체크
    '            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
    '                fileNm = System.IO.Path.GetFileName(fileNm)
    '                If Me._IsExists(g30, fileNm) Then

    '                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
    '                    Exit Sub
    '                End If
    '            Next

    '            'Grid에 선택파일 추가
    '            Dim fullPath As String
    '            g30.AllowAddRows = True
    '            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

    '                Dim FileID As String = [Shared].FileUpload("", fullPath)
    '                If fullPath <> "" Then

    '                    '파일명만 분리
    '                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

    '                    Dim f As New System.IO.FileInfo(fullPath)
    '                    g30.AddNewRow()
    '                    g30.Text("FILE_ID") = FileID
    '                    g30.Text("FILE_NM") = fileNm
    '                    g30.Text("FILE_SIZE") = f.Length.ToString
    '                End If

    '            Next
    '            g30.AllowAddRows = False

    '            Me.Save(g30.WorkSet)
    '            g30.Open()
    '        End If
    '    End Sub

    '    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
    '        With g
    '            For i As Integer = 0 To .RowCount - 1
    '                If .Text("FILE_NM", i) = fileNm Then
    '                    Return True
    '                End If
    '            Next
    '        End With
    '        Return False
    '    End Function

    '    Private Sub g30_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragOver
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '            e.Effect = DragDropEffects.Copy
    '        End If
    '    End Sub

    '#End Region


    '    'Private Sub g30_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
    '    '    '20150909 smk
    '    '    If ColumnName = "dsg_no" Then
    '    '        chg_yn = "1"
    '    '        'com_row = RowIndex
    '    '        'MsgBox(ToStr(g30.RowCount))
    '    '    End If
    '    'End Sub


    '    Private Sub g30_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragDrop
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

    '            If Not MyBase.Save() Then
    '                Exit Sub
    '            End If

    '            'Grid내 같은 File명 체크
    '            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
    '                fileNm = System.IO.Path.GetFileName(fileNm)
    '                If Me._IsExists(g30, fileNm) Then
    '                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + _
    '                    vbLf + vbLf + "[" + fileNm + "]")
    '                    Exit Sub
    '                End If
    '            Next

    '            'Grid에 선택파일 추가
    '            g30.AllowAddRows = True

    '            For Each fullPath As String In e.Data.GetData(DataFormats.FileDrop)

    '                Dim FileID As String = [Shared].FileUpload("", fullPath, "MMA300", False)

    '                If fullPath <> "" Then
    '                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
    '                    Dim f As New System.IO.FileInfo(fullPath)

    '                    g30.AddNewRow()
    '                    g30.Text("FILE_ID") = FileID
    '                    g30.Text("FILE_NM") = fileNm
    '                    g30.Text("FILE_SIZE") = f.Length.ToString
    '                End If

    '            Next

    '            g30.AllowAddRows = False

    '            Me.Save("mma300_g302")
    '            g30.Open()

    '        End If
    '    End Sub


    '    Private Sub g30_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles g30.DragOver
    '        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '            e.Effect = DragDropEffects.Copy
    '        End If

    '    End Sub
#End Region

    Private Sub g_list_Load(sender As System.Object, e As System.EventArgs) Handles g_list.Load

    End Sub


End Class