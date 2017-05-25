Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PMB200

    Private dSet As DataSet

    Private Sub pmb200_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True

        'prj_cd.ReadOnly = True

        'FTP Upload용
        g30.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g30.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g30.AllowDeleteRows = False '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다 


    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Me.Open()

                Me.Tree_Open()

            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = g10.Text("prj_cd")

                    Me.Open()

                    'Me._Open()

                    g10.Find("prj_cd=" + saveID)

                End If

                'Case MenuType.New

                '    New_Form()

                'Case MenuType.Delete

                '    Me.WorkSet("pmb200_f10").DeleteRow()

                '    MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    'Private Sub New_Form()

    '    prj_cd.Text = ""

    '    prj_cd.ReadOnly = False


    '    'Me.OpenTrigger("pmb200_g10")

    'End Sub
    Private Sub Tree_Open()
        Try
            Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
            TreeView1.BeginUpdate()
            TreeView1.Nodes.Clear()

            'Dim P As New OpenParameters
            'P.Add("@prj_cd", prj_cd.Text)
            'P.Add("@doc_chk", doc_chk.Text)

            'Command 생성
            dSet = Me.OpenDataSet("pmb200_Tree")
            dRows = dSet.Tables(0).Rows
            Dim itm As TreeNode
            Dim accCd As String, accNm As String, sUp As String
            Dim docYn As String, mngYn As String, seqNo As String
            For Each dRow In dRows
                sUp = ToStr(dRow("up"))
                accCd = ToStr(dRow("code"))
                accNm = ToStr(dRow("name"))
                docYn = ToStr(dRow("use_yn"))
                mngYn = ToStr(dRow("mng_yn"))
                seqNo = ToStr(dRow("seq_no"))

                If sUp = "" Then
                    itm = TreeView1.Nodes.Add(accCd)
                    itm.Text = "[" & accCd & "] " & accNm
                    itm.Tag = accCd
                    itm.ImageIndex = 0
                    itm.ForeColor = Color.DarkViolet

                Else
                    itm = TreeItem(TreeView1.Nodes, sUp)
                    If Not IsNothing(itm) Then
                        itm = itm.Nodes.Add(accCd)
                        If mngYn = "0" Then
                            itm.Text = "[" & accCd & "] " & accNm
                        Else
                            itm.Text = "(" & seqNo & ") " & accNm
                        End If

                        itm.Tag = accCd

                        If docYn = "1" Then
                            itm.ForeColor = Color.Blue
                            itm.ImageIndex = 1
                            itm.SelectedImageIndex = 1
                        Else
                            If mngYn = "1" Then
                                itm.ForeColor = Color.DeepPink
                                itm.ImageIndex = 2
                                itm.SelectedImageIndex = 2
                                itm.Tag = sUp
                            Else
                                itm.ForeColor = Color.Green
                                itm.ImageIndex = 0
                            End If

                        End If

                    End If
                End If
            Next
            ExpandTreeView()
            TreeView1.EndUpdate()

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Sub
    Private Function TreeItem(ByRef nc As TreeNodeCollection, ByVal cd As String) As TreeNode
        Dim n As TreeNode, s As TreeNode
        If nc Is Nothing Then Return Nothing

        For Each n In nc
            If n.Tag = cd Then
                Return n
            End If
            If Not IsNothing(n.Nodes) Then
                s = TreeItem(n.Nodes, cd)
                If Not IsNothing(s) Then
                    Return s
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub ExpandTreeView()
        If exp_yn.Checked Then
            TreeView1.ExpandAll()
        Else
            TreeView1.CollapseAll()
        End If
    End Sub
    '[트리구조확장]
    Private Sub chk_expand_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles exp_yn.CheckedChanged
        Me.ExpandTreeView()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If ToStr(e.Node.Tag) <> "" Then
            g20.Find("step_no=" + e.Node.Tag)
        End If
    End Sub

    Private Sub doc_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doc_chk.CheckedChanged
        Me.Tree_Open()
    End Sub
    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow

        'prj_cd.ReadOnly = True

        g20.Open()
        g30.Open()

        Me.Tree_Open()

        'Me.OpenTrigger("pmb200_g10")

    End Sub
    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click

        Me.Tree_Open()

    End Sub

    Private Sub g20_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g20.AfterMoveRow
        Me.Open("pmb200_g30")

    End Sub

#Region "FTP 관리"

    Private Sub g30_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g30.ButtonPressed
        Dim docCd As String = g30.Text("doc_cd")
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
