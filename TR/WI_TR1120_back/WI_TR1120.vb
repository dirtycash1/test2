Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_TR1120

    Public chk As Boolean
    Public il_seq, il_buseq, il_preseq, il_prebuseq As Integer
    Dim p As New OpenParameters

    Private Property AllowMove As Boolean


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Clear()
        chk = True
        g_list.SelectRow = True
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        img.Visible = False
        Me.SplitContainer6.Panel2Collapsed = True

        'FTP Upload용
        g_body2.AllowDrop = True

        g10.AllowDrop = True

        'Drag & Drop으로 만 신규파일 추가가능
        'Grid의 삭제 버턴으로만 삭제 가능
        g10.AllowAddRows = False    'Drag & Drop으로 만 신규파일 추가가능
        g10.AllowDeleteRows = False '임의로 DB에서만 삭제되면 FTP와의 동기화가 끊어진다

        '20141222 SMK
        'p.Clear()
        'p.Add("@od_no", "501410020954")
        'Me.Open("wi_tr1120_body", p)

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Cancel

                Me.Clear()

            Case MenuType.Save

                If Not Saves() Then Exit Sub

            Case MenuType.Confirm

                If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm

                If Not DeConFrim() Then Exit Sub

            Case MenuType.Find

                Me.Find()
            Case MenuType.New
                New_Form()
            Case MenuType.Delete

                If Not Del() Then Exit Sub
 

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub Clear()
        p.Clear()
        p.Add("@od_no", "XXX")

        Me.Open("wi_tr1120_head", p)

        p.Add("@seq", "0")
        Me.Open("wi_tr1120_body02", p)
        Me.Open("wi_tr1120_body_01", p)
        Me.Open("wi_tr1120_body", p)

    End Sub

    Private Sub New_Form()
        'Me.Open()
        'od_no.Text = ""
        'Me.OpenTrigger("wi_tr1120_list")
        'g_body.AddNewRow()
        g_body.AddNewRow()
        g_body.Focus()
    End Sub

    Private Sub Find()
        If spc_1.Panel1Collapsed = False Then
            spc_1.Panel1Collapsed = True
        Else
            spc_1.Panel1Collapsed = False

        End If
    End Sub


    Private Function Check_Stts() As String
        p.Clear()
        p.Add("@od_no", od_no.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1120_stts", p)
        Dim stts As String = "S"

        If Not IsEmpty(dSet) Then stts = DataValue(dSet)

        Return stts

    End Function

    Private Sub Max_NO()
        ' od_no 번호 채번
        od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt
    End Sub

    Private Function Saves() As Boolean

        If Check_Stts() = "C" Then '상태값 CHECK
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("전송된 자료입니다.!")
            Return False
        End If


        If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
            Return False
            'Exit Function
        Else
            Max_NO()  '전표채번..

            If cs_cd.Text = "" Then    '20141222 SMK 추가
                MsgBox("<거래처>는 필수 입력정보입니다.")
                Return False
            Else

                If MyBase.Save() Then
                    stts1.Text = "S"
                Else
                    Return False
                End If

            End If
            
        End If
        Me.SumAmt()         ' 2014-10-01 SMK 

        Return True
    End Function

    Private Function ConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("전송된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            'Me.Open("wi_ku1120_confirm")

            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "A")

            Me.Open("wi_tr1120_confirm", p)
        End If

        stts1.Text = "A"

        'Me.Clear()

        Return True
    End Function

    Private Function DeConFrim() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() <> "A" Then
            MsgBox("전송된 자료가 아닙니다.!")
            Return False
        ElseIf Check_Stts() = "C" Then
            MsgBox("접수된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)
            p.Add("@stts", "S")

            Me.Open("wi_tr1120_confirm", p)

            stts1.Text = "S"
        End If

        Return True
    End Function

    Private Function Del() As Boolean

        If od_no.Text = Nothing Then
            MsgBox("자료를 확인하세요.!")
            Return False
        End If

        '상태값 CHECK
        If Check_Stts() = "C" Then
            MsgBox("접수된 자료입니다.!")
            Return False
        ElseIf Check_Stts() = "A" Then
            MsgBox("전송된 자료입니다.!")
            Return False
        End If

        If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
            Exit Function
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)

            Me.Open("wi_tr1120_delete", p)

            Me.Clear()

            g_list.Open()

        End If

        Return True
    End Function


    Private Sub g_body_aftereMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g_body.AfterMoveRow
        'MsgBox("1")
        If Me.DataChanged() Then

            If od_no.Text = "" Then
                Max_NO()  '전표채번..
            End If


            'For i = 0 To g_body.RowCount - 1     '20141222  SMK 주석처리
            '    If g_body.Text("GD_CD", i) = "" And g_body.Text("OD_QTY", i) = "" And g_body.Text("PACK_QTY", i) = "" And g_body.Text("OD_PRI", i) = "" Then
            '        g_body.DeleteRow(i)
            '    End If
            'Next

            'If Not Me.Save() Then         '20141222 SMK 주석처리 
            '    '저장에 실패 했으면 Move Row가 허용되면 안된다
            '    g_body.RowIndex = PrevRowIndex
            '    'AllowMove = False
            'End If

            If stts1.Text = "A" Then       '20141223 smk 추가
                'MsgBox("전송된 자료입니다. 수정할 수 없습니다.")
                Return
            ElseIf stts1.Text = "C" Then
                'MsgBox("접수된 자료입니다. 수정할 수 없습니다.")
                Return
            ElseIf odgu_cd.Text = "" Or bk_type.Text = "" Then
                MsgBox("거래유형과 은행정보는 필수 입력 정보 입니다.")
                Return
            ElseIf cs_cd.Text = "" Then
                MsgBox("거래처는 필수 입력 정보 입니다.")
            Else
                For i = 0 To g_body.RowCount - 1
                    If g_body.Text("GD_CD", i) = "" And g_body.Text("OD_QTY", i) = "" And g_body.Text("PACK_QTY", i) = "" And g_body.Text("OD_PRI", i) = "" Then
                        'MsgBox("<품목, 수량, 포장단위, 단가>는 필수로 입력해야 합니다.")
                        g_body.DeleteRow(i)
                        Return
                    Else
                        If Not Me.Save() Then
                            '저장에 실패 했으면 Move Row가 허용되면 안된다
                            AllowMove = False
                        End If
                    End If
                Next
            End If


            'Select Case MessageYesNoCancel("저장하시겠습니까 ?")    '원래 주석처리 
            '    Case MsgBoxResult.Yes
            '        If Not Me.Save() Then
            '            '저장에 실패 했으면 Move Row가 허용되면 안된다
            '            AllowMove = False
            '        End If
            '    Case MsgBoxResult.No
            '        'No를 눌렀으면 저장하지 않고 Row를 변경한다
            '        Exit Sub
            '    Case MsgBoxResult.Cancel
            '        '취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
            '        AllowMove = False
            'End Select

        End If
    End Sub


    ''Grid Row 가 바뀌기 전에 모든 Detail Form이나 Grid를 체크해서 저장 또는 Row이동허용을 제어 (행추가 할때 여기로 들어옴)
    Private Sub g_body_BeforeMoveRow(sender As Object, RowIndex As Integer, ByRef AllowMove As Boolean) Handles g_body.BeforeMoveRow
        'MsgBox("2")
        If Me.DataChanged() Then

            If od_no.Text = "" Then
                Max_NO()  '전표채번..
            End If
            'For i = 0 To g_body.RowCount - 1   ' 20141222 smk 주석처리 
            '    If g_body.Text("GD_CD", i) = "" And g_body.Text("OD_QTY", i) = "" And g_body.Text("PACK_QTY", i) = "" And g_body.Text("OD_PRI", i) = "" Then
            '        g_body.DeleteRow(i)
            '    End If
            'Next

            'If Not Me.Save() Then      ' 20141222 smk 주석처리
            '    '저장에 실패 했으면 Move Row가 허용되면 안된다
            '    AllowMove = False
            'End If


            If stts1.Text = "A" Then       '20141223 smk 추가
                'MsgBox("전송된 자료입니다. 수정할 수 없습니다.")
                Return
            ElseIf stts1.Text = "C" Then
                'MsgBox("접수된 자료입니다. 수정할 수 없습니다.")
                Return
            ElseIf odgu_cd.Text = "" Or bk_type.Text = "" Then
                MsgBox("거래유형과 은행정보는 필수 입력 정보 입니다.")
                Return
            ElseIf cs_cd.Text = "" Then
                MsgBox("거래처는 필수 입력 정보 입니다.")
            Else
                For i = 0 To g_body.RowCount - 1
                    If g_body.Text("GD_CD", i) = "" And g_body.Text("OD_QTY", i) = "" And g_body.Text("PACK_QTY", i) = "" And g_body.Text("OD_PRI", i) = "" Then
                        'MsgBox("<품목, 수량, 포장단위, 단가>는 필수로 입력해야 합니다.")
                        g_body.DeleteRow(i)
                        Return
                    Else
                        If Not Me.Save() Then
                            '저장에 실패 했으면 Move Row가 허용되면 안된다
                            AllowMove = False
                        End If
                    End If
                Next

            End If

            'Select Case MessageYesNoCancel("저장하시겠습니까 ?")    '원래 주석처리 
            '    Case MsgBoxResult.Yes
            '        If Not Me.Save() Then
            '            '저장에 실패 했으면 Move Row가 허용되면 안된다
            '            AllowMove = False
            '        End If
            '    Case MsgBoxResult.No
            '        'No를 눌렀으면 저장하지 않고 Row를 변경한다
            '        Exit Sub
            '    Case MsgBoxResult.Cancel
            '        '취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
            '        AllowMove = False
            'End Select
        End If
    End Sub

    Private Sub g_body_01_LostFocus(sender As Object, e As System.EventArgs) Handles g_body_01.LostFocus
        If g_body_01.DataChanged() Then

            If od_no.Text = "" Then
                Max_NO()  '전표채번..
            End If

            If Not Me.Save() Then
                MessageInfo("저장에 실패했습니다.")
                Exit Sub
            End If

            'Select Case MessageYesNoCancel("저장하시겠습니까 ?")
            '    Case MsgBoxResult.Yes
            '        If Not Me.Save() Then
            '            '저장에 실패 했으면 Move Row가 허용되면 안된다
            '            AllowMove = False
            '        End If
            '    Case MsgBoxResult.No
            '        'No를 눌렀으면 저장하지 않고 Row를 변경한다
            '        Exit Sub
            '    Case MsgBoxResult.Cancel
            '        '취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
            '        AllowMove = False
            'End Select
        End If
    End Sub

    'Private Sub g_body_01_BeforeMoveRow(sender As Object, RowIndex As Integer, ByRef AllowMove As Boolean) Handles g_body_01.BeforeMoveRow
    '    If g_body_01.DataChanged() Then

    '        If od_no.Text = "" Then
    '            Max_NO()  '전표채번..
    '        End If

    '        If Not Me.Save() Then
    '            '저장에 실패 했으면 Move Row가 허용되면 안된다
    '            AllowMove = False
    '        End If

    '        'Select Case MessageYesNoCancel("저장하시겠습니까 ?")
    '        '    Case MsgBoxResult.Yes
    '        '        If Not Me.Save() Then
    '        '            '저장에 실패 했으면 Move Row가 허용되면 안된다
    '        '            AllowMove = False
    '        '        End If
    '        '    Case MsgBoxResult.No
    '        '        'No를 눌렀으면 저장하지 않고 Row를 변경한다
    '        '        Exit Sub
    '        '    Case MsgBoxResult.Cancel
    '        '        '취소를 눌렀으면 Row이동을 취소 한다 (Row를 변경하지 않는다)
    '        '        AllowMove = False
    '        'End Select
    '    End If
    'End Sub


    '제품 등록된 금액을 합해서 HEAD 수주금액에 넣는다.
    Private Sub SumAmt()
        Dim sum_amt As Double

        With g_body
            '.UpdateRow()
            For i As Integer = 0 To .RowCount - 1
                sum_amt = sum_amt + .ToDec("OD_AMT", i)
                'sum_vat = sum_vat + .ToDec("so_vat", i)
            Next
        End With

        od_amt.Text = sum_amt

    End Sub


    Private Sub find_Clear()

        find_cs_nm.Text = ""
        find_od_no.Text = ""
        find_stts.Text = "%"
        find_odgu_cd.Text = "%"

        p.Clear()
        p.Add("@find_from", find_from.Text)
        p.Add("@find_to", find_to.Text)
        p.Add("@find_cs_nm", "XXX")
        p.Add("@find_od_no", find_od_no.Text)
        p.Add("@find_stts", find_stts.Text)
        p.Add("@find_odgu_cd", find_odgu_cd.Text)

        Me.Open("wi_tr1120_list", p)

    End Sub


    Private Sub g_body_01_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        chk = True
    End Sub

    Private Sub g_body_01_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32)
        If g_body2.RowIndex < 0 Then
            Return
        End If

        If g_body2.Text("SEQ", g_body2.RowIndex) = "" Then
            Return
        End If
        If g_body2.Text("BU_SEQ", g_body2.RowIndex) = "" Then
            Return
        End If

    End Sub

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.find_Clear()
    End Sub


    Private Sub g_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g_list.DoubleClick
        '더블클릭시 head, body를 조회한다.

        Dim p2 As New OpenParameters

        chk = False

        p2.Add("@od_no", g_list.Text("OD_NO", g_list.RowIndex))

        Me.Open("wi_tr1120_head", p2)
        Me.Open("wi_tr1120_body", p2)

        If g_body.RowCount <= 0 Then
            p2.Add("@seq", 1)
        Else
            p2.Add("@seq", g_body.Text("SEQ", 1))
        End If

        Me.OpenTrigger("wi_tr1120_body")
        'Me.Open("wi_tr1120_body_01", p2)
        'Me.Open("wi_tr1120_body02", p2)
        ''Me.Open("wi_tr1120_body_01_temp", p2)

        'g_body 의 첫줄을 g_body_01를 검색하다.
        ''g_body_AfterMoveRow(sender, 1, 1)

        '찾기 리스트에서 더블 클릭시 찾기를 없앤다.
        If find_visible.Checked Then MenuButton_Click(MenuType.Find)

        chk = True
    End Sub

    Private Sub g_body_CellValueChanged1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g_body.CellValueChanged
        With g_body

            If ColumnName = "OD_AMT" Then
                Me.SumAmt()

            ElseIf ColumnName = "GD_CD" Then
                Me.setPrice(.Text("GD_CD", RowIndex))
                Me.Setitem_Jacd(.Text("GD_CD", RowIndex))
            End If
        End With
    End Sub

    Private Sub g_body_DeletedRow(sender As Object, RowIndex As Integer) Handles g_body.DeletedRow  '2014-09-26 SMK
        Me.SumAmt()
    End Sub

    Private Sub g_body_DoubleClick1(sender As Object, e As System.EventArgs) Handles g_body.DoubleClick
        If g_body.FieldName(g_body.ColumnIndex) = "GD_CD" Then Exit Sub
        If g_body.FieldName(g_body.ColumnIndex) = "PR_NMCD" Then Exit Sub

        If g_body.DataChanged() Then
            'Select Case MessageYesNo("저장하시겠습니까 ?")
            '    Case MsgBoxResult.Yes
            If Not Me.Saves() Then
                Exit Sub
            End If
            '    Case MsgBoxResult.No
            'Exit Sub
            ''Case MsgBoxResult.Cancel
            ''    Exit Sub
            'End Select
        End If

        Dim popup As New Form1
        Dim fc As Integer
        For k = 0 To g_body.RowCount - 1
            If g_body.SelectRow Then
                fc = g_body.RowIndex
            End If
        Next
        'popup.InitPopup(Me.g_body.Text("GD_CD", -1), Me.g_body.Text("GD_NM", -1), Me.g_body.Text("SEQ", -1), Me.g_body.Text("OD_QTY", -1))
        popup.InitPopup(Me.g_body.Text("GD_CD"), Me.g_body.Text("GD_NM"), Me.g_body.Text("SEQ", fc), Me.g_body.Text("OD_QTY"), Me.od_no.Text)

        If ((popup.ShowDialog = DialogResult.OK) AndAlso (Not popup.ActiveControl.Tag Is Nothing)) Then
            Dim pReturn As DataSet = DirectCast(popup.ActiveControl.Tag, DataSet)

            g_body2.DeleteBlankRow()            'Data가 있는 Row만 작업하기위해 신규 빈Row삭제

            Dim dRow As DataRow
            'Dim ll_row As Integer

            'll_row = g_body2.RowCount

            For i = 0 To pReturn.Tables(0).Rows.Count - 1
                dRow = pReturn.Tables(0).Rows(i)

                'g_body2.AddNewRow()
                'g_body2.Text("GD_CD") = dRow("nm")
                'g_body2.Text("GD_NM") = dRow("gd_nm")
                'g_body2.Text("SPEC") = dRow("spec")
                'g_body2.Text("OD_QTY") = dRow("qty")


            Next
            Me.Open()
        End If
    End Sub

    Private Sub btn_bom_Click(sender As Object, e As System.EventArgs)
        If MessageYesNo("BOM을 생성하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else
            p.Clear()
            p.Add("@od_no", od_no.Text)

            Me.Open("wi_tr1120_bom_create", p)
        End If
    End Sub


#Region "FTP 관리"

    Private Sub g_body_01_ButtonPressed(ByVal sender As Object, ByVal columnName As String)
        Dim fileID As String = g_body_01.Text("FILE_ID")
        Dim fileNm As String = g_body_01.Text("FILE_NM")
        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "DEL" Then
            Try
                If [Shared].FileDelete(fileID, fileNm) = True Then
                    g_body_01.AllowDeleteRows = True
                    g_body_01.DeleteRow(g_body_01.RowIndex)
                    g_body_01.AllowDeleteRows = False

                    Me.Save(g_body_01.WorkSet)
                End If
            Catch ex As Exception
                MessageInfo(ex)
            End Try

        End If

        If columnName = "SHOW" Then
            [Shared].FileDownLoad(fileID, fileNm, , True)
        End If

        If columnName = "DOWN" Then
            [Shared].FileDownLoad(fileID, fileNm)
        End If
    End Sub


    Private Sub g_body_01_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g_body_01, fileNm) Then

                    MessageInfo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + "[" + fileNm + "]")
                    Exit Sub
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g_body_01.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                If fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g_body_01.AddNewRow()
                    g_body_01.Text("FILE_ID") = FileID
                    g_body_01.Text("FILE_NM") = fileNm
                    g_body_01.Text("FILE_SIZE") = f.Length.ToString
                End If

            Next
            g_body_01.AllowAddRows = False

            Me.Save(g_body_01.WorkSet)
            g_body_01.Open()
        End If
    End Sub

    Private Function _IsExists(ByVal g As eGrid, ByVal fileNm As String) As Boolean

        With g
            For i As Integer = 0 To .RowCount - 1
                If .Text("FILE_NM", i) = fileNm Then
                    Return True
                End If
            Next
        End With
        Return False

    End Function

    Private Sub g_body_01_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub g10_ButtonPressed(ByVal sender As Object, ByVal columnName As String)
        Dim fileID As String = g10.Text("file_id")
        Dim fileNm As String = g10.Text("FILE_NM")

        If fileNm = "" Then
            Exit Sub
        End If

        If columnName = "del" Then
            Try
                'If [Shared].FileDelete(fileID, fileNm) = True Then
                ' 오류수정: fileID 가 없어도 행 삭제되게 해야한다
                If fileID = "" OrElse [Shared].FileDelete(fileID, fileNm) = True Then
                    g10.AllowDeleteRows = True
                    g10.DeleteRow(g10.RowIndex)
                    g10.AllowDeleteRows = False

                    Me.Save(g10.WorkSet)
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


    Private Sub g10_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then

            If Not MyBase.Save() Then
                Exit Sub
            End If

            'Grid내 같은 File명 체크 
            For Each fileNm As String In e.Data.GetData(DataFormats.FileDrop)
                fileNm = System.IO.Path.GetFileName(fileNm)
                If Me._IsExists(g10, fileNm) Then
                    If MessageYesNo("이미 같은 파일명을 가진 파일이 존재합니다." + vbLf + vbLf + _
                                    "그래도 Upload 하시겠습니까 ?" + vbLf + vbLf + "[" + fileNm + "]") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next

            'Grid에 선택파일 추가
            Dim fullPath As String
            g10.AllowAddRows = True
            For Each fullPath In e.Data.GetData(DataFormats.FileDrop)

                Dim FileID As String = [Shared].FileUpload("", fullPath)
                'If fullPath <> "" Then
                ' 오류수정: fileID 가 없어면 저장 안되게 해야한다
                If FileID <> "" And fullPath <> "" Then

                    '파일명만 분리
                    Dim fileNm As String = System.IO.Path.GetFileName(fullPath)

                    Dim f As New System.IO.FileInfo(fullPath)
                    g10.AddNewRow()
                    g10.Text("file_id") = FileID
                    g10.Text("FILE_NM") = fileNm
                    g10.Text("file_size") = f.Length.ToString
                End If

            Next
            g10.AllowAddRows = False

            Me.Save(g10.WorkSet)
            g10.Open()
        End If

    End Sub

    Private Sub g10_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

        If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

#End Region

    Private Sub btn_pic_Click(sender As System.Object, e As System.EventArgs) Handles btn_pic.Click
        If Me.SplitContainer6.Panel2Collapsed = False Then
            img.Visible = False
            Me.SplitContainer6.Panel2Collapsed = True
        Else
            img.Visible = True
            Me.SplitContainer6.Panel2Collapsed = False
        End If

    End Sub

    Private Sub img_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        CallImageView(1)
    End Sub

    Private Sub CallImageView(ByVal GetID As String)
        ''If itm_cd.Text = "" Or GetID = "" Then Exit Sub
        'If img.Image Is Nothing Then Exit Sub
        'Try
        '    'eImage 에 Image Property 추가
        '    Dim f As ImageView
        '    f = New ImageView
        '    f.LoadPicture(img.Image, g_body_01.Text("gd_cd"))
        '    f.ShowDialog()

        'Catch ex As Exception
        '    MessageError(ex)
        'End Try
    End Sub

    Private Sub setPrice(a_gdcd As String)
        p.Clear()
        p.Add("@CS_CD", cs_cd.Text)
        p.Add("@CUR_CD", cur_cd.Text)
        p.Add("@GD_CD", a_gdcd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1120_price", p)
        Dim price As Decimal = 0

        Dim dRow As DataRow, dRows As DataRowCollection

        If IsEmpty(dSet) Then
            g_body.Text("OD_PRI", g_body.RowIndex) = ""
            Exit Sub
        End If

        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows
            g_body.Text("OD_PRI", g_body.RowIndex) = ToStr(dRow("price"))
        Next

    End Sub

    Private Sub setPrice1(a_curcd As String)
        Dim ls_gdcd As String

        g_body.RowIndex = 0

        For i As Integer = 0 To g_body.RowCount + 1
            ls_gdcd = g_body.Text("GD_CD", i)

            p.Clear()
            p.Add("@CS_CD", cs_cd.Text)
            p.Add("@CUR_CD", a_curcd)
            p.Add("@GD_CD", ls_gdcd)

            Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1120_price", p)
            Dim price As Decimal = 0

            Dim dRow As DataRow, dRows As DataRowCollection

            If IsEmpty(dSet) Then
                g_body.Text("OD_PRI", i) = ""
                Exit Sub
            End If

            dRows = dSet.Tables(0).Rows

            For Each dRow In dRows
                g_body.Text("OD_PRI", i) = ToStr(dRow("price"))
            Next
        Next
    End Sub

    'Private Sub cur_cd_TextChanged(sender As Object, e As System.EventArgs) Handles cur_cd.TextChanged
    '    If g_body.RowCount() > 0 Then
    '        Me.setPrice1(cur_cd.Text)
    '    End If
    'End Sub

    Private Sub Setitem_Jacd(a_gdcd As String)
        p.Clear()
        p.Add("@CS_CD", cs_cd.Text)
        p.Add("@GD_CD", a_gdcd)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wi_tr1120_set_jacd", p)

        If Not IsEmpty(dSet) Then
            With g_body_01
                Dim iRow As Integer = 0
                Dim dRow As DataRow, dRows As DataRowCollection
                dRows = dSet.Tables(0).Rows

                iRow = .RowIndex

                If .Text("GD_CD", .RowIndex) <> Nothing Then iRow += 1

                For Each dRow In dRows
                    .InsertNewRow(iRow)

                    .Text("GD_CD", iRow) = ToStr(dRow("GD_CD"))
                    .Text("GD_NM", iRow) = ToStr(dRow("GD_NM"))
                    .Text("SPEC", iRow) = ToStr(dRow("SPEC"))
                    .Text("UNIT_CD", iRow) = ToStr(dRow("UNIT_CD"))

                    iRow += 1
                Next
            End With
        End If
    End Sub
 
    Private Sub but_work_Click(sender As System.Object, e As System.EventArgs)
        If od_no.Text = "" Then
            MessageBox.Show("복사 대상 수주 정보를 조회 하세요")
            Exit Sub
        End If

        If MessageYesNo("수주정보를 복사 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else

            Dim p As New OpenParameters
            p.Add("@od_no", od_no.Text)
            Me.OpenDataSet("wi_tr1120_copy", p)
            ''Me.Find()       '원래 막힘
            g_list.Open()
            od_no.Text = g_list.Text("OD_NO", 0)
            g_body.Open()

            'Me.OpenTrigger("wi_tr1120_body")

        End If

    End Sub

    Private Sub but1_prt_Click(sender As System.Object, e As System.EventArgs)
        Dim pt As OpenParameters = New OpenParameters

        pt.Add("@od_no", od_no.Text)

        'Dim pt1 As OpenParameters = New OpenParameters

        'pt1.Add("@od_no", od_no.Text)
        'System7.ReportView.LoadView("WI_TR1120", "", "wi_tr1120_print1", pt, Nothing, True, 1, "sub", "wi_tr1120_print2", pt1)

        System7.ReportView.LoadView("WI_TR1120", "", "wi_tr1120_print1", pt)
    End Sub

    Private Sub but2_prt_Click(sender As System.Object, e As System.EventArgs)
        Dim p As OpenParameters = New OpenParameters

        p.Add("@od_no", od_no.Text)
        p.Add("@bk_type", bk_type.Text)

        System7.ReportView.LoadView("WI_TR1120_P", "", "wi_tr1120_proforma", p)

    End Sub

    Private Sub g_body_InsertedRow(sender As Object, RowIndex As Integer) Handles g_body.InsertedRow
        MsgBox("11")
        g_body.AddNewRow()
    End Sub
End Class

