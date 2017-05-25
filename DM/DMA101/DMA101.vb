Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class DMA101
    Private Sub MMB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''구매발주번호 자동채번 설정
        'po_no.CodeNo = "DMA101"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'po_no.CodeDateField = po_dt

        'Me.New_Form()

        SplitContainer2.Panel2Collapsed = True


        Select Case qr_itm_cd.ImeMode()
            Case Windows.Forms.ImeMode.Hangul
                qr_itm_cd.ImeMode = Windows.Forms.ImeMode.Alpha
        End Select

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            Me.Open_Form()

    '        Case MenuType.Save
    '            If MyBase.Save() Then
    '                Me.Open_Form()
    '            End If

    '        Case MenuType.Delete

    '        Case MenuType.New
    '            Me.New_Form()
    '        Case MenuType.Print
    '            Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub



    '20160613 smk 단가선택 기능
    Private m_StopEvent As Boolean

    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick
        'Dim cc As String
        'Dim row_i As Integer

        If m_StopEvent Then
            Return
        End If

        m_StopEvent = True

        Try
            Panel2_collapsed(g10.RowIndex, "1")
            g20_open(g10.RowIndex)

        Catch ex As Exception
        Finally
            m_StopEvent = False
        End Try

    End Sub

    'Private Sub g10_CellValueChanging1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

    '    Dim cc As String
    '    Dim row_i As Integer

    '    If m_StopEvent Then
    '        Return
    '    End If

    '    m_StopEvent = True

    '    Try
    '        If ColumnName = "echeck" Then

    '            If Value = "1" Then

    '                For i As Integer = 0 To g10.RowCount - 1
    '                    g10.Text("echeck") = "0"
    '                Next

    '                cc = "1"
    '                g10.Text("echeck") = cc
    '                row_i = RowIndex
    '            Else
    '                cc = "0"
    '                g10.Text("echeck") = cc
    '            End If
    '            Panel2_collapsed(RowIndex, cc)
    '            g20_open(RowIndex)

    '        End If

    '    Catch ex As Exception
    '    Finally
    '        m_StopEvent = False
    '    End Try

    'End Sub

    Private Sub Panel2_collapsed(RowIndex As Integer, cc As String)   'smk 160613
        If cc = "1" Then
            SplitContainer2.Panel2Collapsed = False '나타내기 
        Else
            SplitContainer2.Panel2Collapsed = True  '숨기기 
        End If

    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        SplitContainer2.Panel2Collapsed = True  '숨기기 
    End Sub

    Public Sub g20_open(RowIndex As Integer)
        Dim p20 As OpenParameters = New OpenParameters

        p20.Clear()
        p20.Add("@itm_id", g10.Text("itm_id", RowIndex))

        Me.Open("dma101_g20", p20)
    End Sub
    '20160613 smk 단가선택 기능 END 

    'Private Sub g20_ButtonPressed(sender As System.Object, columnName As System.String)
    '    If columnName = "up_save" Then
    '        g10.Text("po_up") = g20.Text("up")
    '    End If

    'End Sub


    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed
        Dim FileID As String = g20.Text("file_id")
        Dim FileNm As String = g20.Text("file_nm")

        If FileNm = "" Then
            Exit Sub
        End If

        Select Case columnName
            Case "delet"

                Try
                    If [Shared].FileDelete(FileID, FileNm) = True Then
                        g20.AllowDeleteRows = True
                        g20.DeleteRow(g20.RowIndex)
                        g20.AllowDeleteRows = False

                        Me.Save("dma101_g20")
                    End If
                Catch ex As Exception
                    MessageInfo(ex)
                End Try

            Case "showw"
                [Shared].FileDownLoad(FileID, FileNm, , True)

            Case "downn"
                [Shared].FileDownLoad(FileID, FileNm)



            Case "file_add"

        End Select
    End Sub

    Private Sub g10_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g10.ButtonPressed
        Dim FileID As String = g10.Text("file_id")
        Dim FileNm As String = g10.Text("file_nm")

        If FileNm = "" Then
            Exit Sub
        End If

        Select Case columnName
            'Case "del"

            '    Try
            '        If [Shared].FileDelete(FileID, FileNm) = True Then
            '            g20.AllowDeleteRows = True
            '            g20.DeleteRow(g20.RowIndex)
            '            g20.AllowDeleteRows = False

            '            Me.Save("dma100_g90")
            '        End If
            '    Catch ex As Exception
            '        MessageInfo(ex)
            '    End Try

            Case "show"
                [Shared].FileDownLoad(FileID, FileNm, , True)

            Case "down"
                [Shared].FileDownLoad(FileID, FileNm)

        End Select
    End Sub

    '파일 업로드 170414smk추가 
    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean
        With g20
            For i As Integer = 0 To .RowCount - 1
                If .Text("file_nm", i) = fileNm Then Return True
            Next
        End With
        Return False
    End Function


    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click    ' Add_Btn
        Call FileAdd()
    End Sub

    Private Sub FileAdd()
        Dim fileID As String = g20.Text("file_id")
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

            If Not MyBase.Save("dma101_g20") Then
                '저장실패시 코드채번 취소
                Me.WorkSet("dma101_g20").RecoverCodeNo()
                Exit Sub
            Else

                'testm_no = estm_no.Text
                g20.Open()
            End If

            'Grid내 같은 File명 체크
            For Each FileNm As String In dialog.FileNames
                FileNm = System.IO.Path.GetFileName(FileNm)
                If Me._IsExists(g20, FileNm) Then
                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." +
                    vbLf + vbLf + "[" + FileNm + "]")
                    Exit Sub
                End If
            Next

            g20.AllowAddRows = True

            Try
                For Each fullPath As String In dialog.FileNames

                    fileID = [Shared].FileUpload("", fullPath, "DMA100", False)

                    If fullPath <> "" Then
                        Dim fileNm As String = System.IO.Path.GetFileName(fullPath)
                        Dim f As New System.IO.FileInfo(fullPath)

                        'If g10.Text("file_nm") = "" Then
                        '    g20.AddNewRow()
                        '    g20.Text("file_id") = fileID
                        '    g20.Text("file_nm") = fileNm
                        '    g20.Text("file_size") = f.Length.ToString
                        'Else
                        '    g20.Text("file_id", g20.RowCount - 1) = fileID
                        '    g20.Text("file_nm", g20.RowCount - 1) = fileNm
                        '    g20.Text("file_size", g20.RowCount - 1) = f.Length.ToString
                        'End If

                        g20.AddNewRow()
                        g20.Text("file_id") = fileID
                        g20.Text("file_nm") = fileNm
                        g20.Text("file_size") = f.Length.ToString
                    End If

                Next

                Me.Save("dma101_g20")

            Catch ex As Exception
                MessageInfo(ex)
            Finally
                g20.AllowAddRows = False
            End Try

        End If
    End Sub

    Private Sub qr_itm_cd_TextChanged(sender As Object, oldValue As String) Handles qr_itm_cd.TextChanged
        itm_cd.Text = Mid(qr_itm_cd.Text, 1, 6)
        Me.Open()
    End Sub

    Private Sub qr_itm_cd_ImeModeChanged(sender As Object, e As EventArgs) Handles qr_itm_cd.ImeModeChanged  '한/영키 제어
        qr_itm_cd.ImeMode = Windows.Forms.ImeMode.Alpha
    End Sub

    Private Sub qr_itm_cd_KeyDown(sender As Object, e As KeyEventArgs) Handles qr_itm_cd.KeyDown
        'If (e.KeyCode < 65 Or e.KeyCode > 90) And (e.KeyCode < 97 Or e.KeyCode > 122) And e.KeyCode <> 229 And e.KeyCode <> 8 And e.KeyCode <> 13 Then
        'MsgBox("영문만 입력하세요")
        qr_itm_cd.ImeMode = Windows.Forms.ImeMode.Alpha
        'End If
    End Sub


End Class
