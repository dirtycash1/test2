Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports FTP_Tools

Public Class DMA320

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    'Dim ftp As FTP_Tools.FTP_Tools = New FTP_Tools.FTP_Tools

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BTN_Enable()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.New
                New_Form()

            Case MenuType.Delete
                Dim dr As DialogResult = MessageBox.Show("Project 명 : " + pjt_nm.Text + vbCr +
                                                         "Rev. : " + rev.EditText + vbCr +
                                                         "PSO단계 : " + pso.EditText + vbCr +
                                                         "성과물 : " + rslt.EditText + vbCr + vbCr +
                                                         "을(를) 삭제 하시겠습니까?" + vbCr +
                                                         "([예] 클릭시 데이터베이스에서 데이터가 삭제됩니다.)", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dr = DialogResult.Yes Then
                    Dim param As OpenParameters = New OpenParameters
                    param.Add("@pjt_id", g10.Text("pjt_id"))
                    param.Add("@rev", g10.Text("rev"))
                    param.Add("@rslt", g10.Text("rslt"))
                    Me.Open("dma320_delete", param)
                    Me.Open()
                    MessageBox.Show("데이터가 삭제 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

            Case MenuType.Open
                Me.Open()
                '  BTN_Enable()
            Case MenuType.Save
                ' SaveFTP()
                Save_Form()
            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            Dim param As OpenParameters = New OpenParameters
            param.Add("@pjt_id", "")
            param.Add("@rev", "")
            param.Add("@rslt", "")
            Me.Open("dma320_f10", param)
            BTN_Enable()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        Try
            If Me.Save() Then
                'Me.Open()
                'Dim param As OpenParameters = New OpenParameters
                'param.Add("@o_pjt_id", o_pjt_id.Text)
                'param.Add("@o_pjt_nm", o_pjt_nm.Text)
                'param.Add("@o_rev", o_rev.Text)
                'param.Add("@o_pso", o_pso.Text)
                'param.Add("@o_rslt", o_rslt.Text)
                'Me.Open("dma320_g10", param)
                New_Form()
            End If
            BTN_Enable()

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub btn_file_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_file_add.Click, btn_file_add3.Click, btn_file_add2.Click, btn_file_add1.Click
        'file.Text = FTP_Dialog.SelectDialogShow()
        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)

        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        Dim fileName As String
        Dim tempFileName As String

        If dialog.ShowDialog() = DialogResult.OK Then
            fileName = dialog.FileName.Replace(dialog.SafeFileName, pjt_nm.Text + "_" + pjt_id.Text + "_" + rev.Text + "_" + dialog.SafeFileName)
            System.IO.File.Copy(dialog.FileName, fileName, True)
            tempFileName = [Shared].FileUpload("", fileName, "DMA320")
            System.IO.File.Delete(fileName)
            If tempFileName = String.Empty Then
                Return
            End If
            If btn.Name = "btn_file_add" Then
                file.Text = tempFileName
            ElseIf btn.Name = "btn_file_add1" Then
                file1.Text = tempFileName
            ElseIf btn.Name = "btn_file_add2" Then
                file2.Text = tempFileName
            ElseIf btn.Name = "btn_file_add3" Then
                file3.Text = tempFileName
            End If

            MessageBox.Show("파일 첨부가 완료되었습니다. 저장 버튼을 눌러 실적을 등록하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Save_Form()
        End If


    End Sub

    Private Sub btn_file_view_Click(sender As System.Object, e As System.EventArgs) Handles btn_file_view.Click, btn_file_view3.Click, btn_file_view2.Click, btn_file_view1.Click
        'If file.Text = "" Then
        'Else
        '    Dim fileDir = FTP_Dialog.SaveDialogShow(file.Text)
        '    Dim FileDownOK As Boolean = ftp.download(file.Text, fileDir)
        '    If FileDownOK = True Then
        '        Try
        '            Diagnostics.Process.Start(fileDir + file.Text)
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message.ToString, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End Try
        '    End If
        'End If

        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)

        If btn.Name = "btn_file_view" Then
            [Shared].FileDownLoad(file.Text, "", True, "DMA320")
        ElseIf btn.Name = "btn_file_view1" Then
            [Shared].FileDownLoad(file1.Text, "", True, "DMA320")
        ElseIf btn.Name = "btn_file_view2" Then
            [Shared].FileDownLoad(file2.Text, "", True, "DMA320")
        ElseIf btn.Name = "btn_file_view3" Then
            [Shared].FileDownLoad(file3.Text, "", True, "DMA320")
        End If

    End Sub

    Private Sub btn_file_del_Click(sender As System.Object, e As System.EventArgs) Handles btn_file_del.Click, btn_file_del3.Click, btn_file_del2.Click, btn_file_del1.Click
        'Dim dlgResult = MessageBox.Show("FTP 파일을 삭제 하시겠습니까?", "FTP 파일 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        'If dlgResult = DialogResult.Yes Then
        '    ftp.DeleteFTP(file.Text)
        '    file.Text = String.Empty
        'End If
        'Me.Save()

        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)

        If btn.Name = "btn_file_del" Then

            If [Shared].FileDelete(file.Text, "DMA320") Then
                file.Text = ""
                MessageBox.Show("첨부파일 삭제가 완료되었습니다. 변경된 내용을 저장하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Save_Form()
            End If
            BTN_Enable()

        ElseIf btn.Name = "btn_file_del1" Then
            If [Shared].FileDelete(file1.Text, "DMA320") Then
                file1.Text = ""
                MessageBox.Show("첨부파일 삭제가 완료되었습니다. 변경된 내용을 저장하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Save_Form()
            End If
            BTN_Enable()

        ElseIf btn.Name = "btn_file_del2" Then
            If [Shared].FileDelete(file2.Text, "DMA320") Then
                file2.Text = ""
                MessageBox.Show("첨부파일 삭제가 완료되었습니다. 변경된 내용을 저장하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Save_Form()
            End If
            BTN_Enable()

        ElseIf btn.Name = "btn_file_del3" Then
            If [Shared].FileDelete(file3.Text, "DMA320") Then
                file3.Text = ""
                MessageBox.Show("첨부파일 삭제가 완료되었습니다. 변경된 내용을 저장하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Save_Form()
            End If
            BTN_Enable()
        End If

        
    End Sub

    'Private Sub SaveFTP()
    '    If file.Text = "" Or file.Text.Contains("\") = False Then
    '    Else
    '        Dim str1 As String() = file.Text.Split("\")
    '        Dim str = str1(str1.Length - 1).ToString()
    '        If ftp.Upload(file.Text) = True Then
    '            file.Text = str
    '        End If
    '    End If
    'End Sub

    Private Sub BTN_Enable()
        If file.Text = String.Empty Then
            btn_file_del.Enabled = False
            btn_file_view.Enabled = False
        Else
            btn_file_del.Enabled = True
            btn_file_view.Enabled = True
        End If

        If file1.Text = String.Empty Then
            btn_file_del1.Enabled = False
            btn_file_view1.Enabled = False
        Else
            btn_file_del1.Enabled = True
            btn_file_view1.Enabled = True
        End If

        If file2.Text = String.Empty Then
            btn_file_del2.Enabled = False
            btn_file_view2.Enabled = False
        Else
            btn_file_del2.Enabled = True
            btn_file_view2.Enabled = True
        End If

        If file3.Text = String.Empty Then
            btn_file_del3.Enabled = False
            btn_file_view3.Enabled = False
        Else
            btn_file_del3.Enabled = True
            btn_file_view3.Enabled = True
        End If

    End Sub

    Private Sub rslt_TextChanging(sender As System.Object, e As System.EventArgs) Handles rslt.TextChanging
        If Me.rslt.Text = "" Then
            Me.dept_nm.Text = ""
            Return
        End If
        Dim param As OpenParameters = New OpenParameters
        param.Add("@rslt_cd", rslt.Text)
        Dim ds = Me.OpenDataSet("dma320_sql", param)
        Me.dept_nm.Text = ds.Tables(0).Rows(0)("dept_nm").ToString()
    End Sub

    Private Sub g10_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g10.AfterMoveRow
        BTN_Enable()
    End Sub

    Public Sub Open2(ByVal pjt_id As Integer, ByVal rev As String, ByVal rslt As String, ByVal pso As String)
        Dim param As OpenParameters = New OpenParameters
        param.Add("@o_pjt_nm", "")
        param.Add("@o_pjt_id", pjt_id)
        param.Add("@o_rev", rev)
        param.Add("@o_pso", pso)
        param.Add("@o_rslt", rslt)
        Me.Open("dma320_g10", param)

        param.Add("@pjt_id", pjt_id)
        param.Add("@rev", rev)
        param.Add("@rslt", rslt)
        Me.Open("dma320_f10", param)
    End Sub

    Private Sub btn_app_Click(sender As System.Object, e As System.EventArgs) Handles btn_app.Click

        Dim dr As DialogResult = MessageBox.Show("Project 명 : " + pjt_nm.Text + vbCr +
                                                 "Rev. : " + rev.EditText + vbCr +
                                                 "PSO단계 : " + pso.EditText + vbCr +
                                                 "성과물 : " + rslt.EditText + vbCr + vbCr +
                                                 "의 결재를 요청 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.Yes Then
            Dim param As OpenParameters = New OpenParameters
            param.Add("@btn", "I")
            param.Add("@an_GWReqNo", pjt_id.Text + "," + rev.Text + "," + rslt.Text)
            param.Add("@an_appDt", Date.Now.Date)
            param.Add("@an_title", pjt_nm.Text)
            param.Add("@an_content", pso.EditText)
            param.Add("@an_rawfile1", file.Text)
            param.Add("@an_rawfile2", file1.Text)
            param.Add("@an_rawfile3", file2.Text)
            param.Add("@an_rawfile4", file3.Text)
            param.Add("@pjt_id", pjt_id.Text)
            param.Add("@rev", rev.Text)
            param.Add("@rslt", rslt.Text)
            Me.Open("dma320_gw", param)

            param = New OpenParameters
            param.Add("@pjt_id", g10.Text("pjt_id"))
            param.Add("@rev", g10.Text("rev"))
            param.Add("@rslt", g10.Text("rslt"))
            Me.Open("dma320_f10", param)
            MessageBox.Show("결재가 진행 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_app_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_app_cancel.Click
        
        If app_state.Text = "DMA3230" Then
            Dim dr As DialogResult = MessageBox.Show("Project 명 : " + pjt_nm.Text + vbCr +
                                                 "Rev. : " + rev.EditText + vbCr +
                                                 "PSO단계 : " + pso.EditText + vbCr +
                                                 "성과물 : " + rslt.EditText + vbCr + vbCr +
                                                 "의 결재를 취소 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dr = DialogResult.Yes Then
                Dim param As OpenParameters = New OpenParameters
                param.Add("@btn", "D")
                param.Add("@an_GWReqNo", pjt_id.Text + "," + rev.Text + "," + rslt.Text)
                param.Add("@an_appDt", Date.Now.Date)
                param.Add("@an_title", pjt_nm.Text)
                param.Add("@an_content", pso.EditText)
                param.Add("@an_rawfile1", file.Text)
                param.Add("@an_rawfile2", file1.Text)
                param.Add("@an_rawfile3", file2.Text)
                param.Add("@an_rawfile4", file3.Text)
                param.Add("@pjt_id", pjt_id.Text)
                param.Add("@rev", rev.Text)
                param.Add("@rslt", rslt.Text)
                Me.Open("dma320_gw", param)

                param = New OpenParameters
                param.Add("@pjt_id", g10.Text("pjt_id"))
                param.Add("@rev", g10.Text("rev"))
                param.Add("@rslt", g10.Text("rslt"))
                Me.Open("dma320_f10", param)
                MessageBox.Show("결재요청이 취소 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("이미 결재가 진행중이거나 요청되지 않은 경우 취소할 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
