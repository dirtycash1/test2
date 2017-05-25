Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports FTP_Tools

Public Class DMA300

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pjt_id.CodeNo = "DMA300"
        BTN_Enable()
    End Sub

    'Dim ftp As FTP_Tools.FTP_Tools = New FTP_Tools.FTP_Tools

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Delete
                If pjt_nm.Text = "" Then
                    Return
                Else
                    Dim dr As DialogResult = MessageBox.Show("현재 등록된 [" + pjt_nm.Text + "] Project를 삭제합니다. 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If dr = DialogResult.Yes Then
                        Dim param As OpenParameters = New OpenParameters
                        param.Add("@pjt_id", pjt_id.Text)
                        Me.Open("dma300_sql", param)
                        Me.Open()
                    End If
                End If
                
            Case MenuType.New
                Me.New_Form()

            Case MenuType.Open
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                Me.Open()

            Case MenuType.Save
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
            param.Add("@o_pjt_nm", o_pjt_nm.Text)
            param.Add("@o_item_no", o_item_no.Text)
            param.Add("@o_eng", o_eng.Text)
            param.Add("@o_model", o_model.Text)
            Me.Open("dma300_g10", param)

            param = New OpenParameters
            param.Add("@pjt_id", "")
            Me.Open("dma300_f10", param)
            Me.Open("dma300_g20", param)
            Me.Open("dma300_g30", param)

            g20.AddNewRow()
            g30.AddNewRow()
            BTN_Enable()
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            pjt_nm.Focus()

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
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                'Me.Open()

                New_Form()
            End If
            BTN_Enable()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub file_add_btn_Click(sender As System.Object, e As System.EventArgs) Handles btn_file1_open.Click, btn_file2_open.Click, btn_file3_open.Click, btn_file4_open.Click, btn_file5_open.Click
        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)

        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        Dim fileName As String
        Dim tempFileName As String

        If dialog.ShowDialog() = DialogResult.OK Then
            fileName = dialog.FileName.Replace(dialog.SafeFileName, pjt_nm.Text + "_" + item_no.Text + "_" + item_nm.Text + "_" + dialog.SafeFileName)
            System.IO.File.Copy(dialog.FileName, fileName, True)
            tempFileName = [Shared].FileUpload("", fileName, "DMA300")
            System.IO.File.Delete(fileName)
            If tempFileName = String.Empty Then
                Return
            End If
            If btn.Name = "btn_file1_open" Then
                file1.Text = tempFileName
            ElseIf btn.Name = "btn_file2_open" Then
                file2.Text = tempFileName
            ElseIf btn.Name = "btn_file3_open" Then
                file3.Text = tempFileName
            ElseIf btn.Name = "btn_file4_open" Then
                file4.Text = tempFileName
            ElseIf btn.Name = "btn_file5_open" Then
                file5.Text = tempFileName
            End If

            Save_Form()
        End If
    End Sub

    Private Sub file_view_btn_Click(sender As System.Object, e As System.EventArgs) Handles btn_file1_view.Click, btn_file2_view.Click, btn_file3_view.Click, btn_file4_view.Click, btn_file5_view.Click
        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
        Dim fileNm As String = String.Empty

        If btn.Name = "btn_file1_view" Then
            [Shared].FileDownLoad(file1.Text, "", True, "DMA300")
        ElseIf btn.Name = "btn_file2_view" Then
            [Shared].FileDownLoad(file2.Text, "", True, "DMA300")
        ElseIf btn.Name = "btn_file3_view" Then
            [Shared].FileDownLoad(file3.Text, "", True, "DMA300")
        ElseIf btn.Name = "btn_file4_view" Then
            [Shared].FileDownLoad(file4.Text, "", True, "DMA300")
        ElseIf btn.Name = "btn_file5_view" Then
            [Shared].FileDownLoad(file5.Text, "", True, "DMA300")
        End If
       
    End Sub

    Private Sub file1_del_btn_Click(sender As System.Object, e As System.EventArgs) Handles btn_file1_del.Click, btn_file2_del.Click, btn_file3_del.Click, btn_file4_del.Click, btn_file5_del.Click
        Dim btn As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)

        If btn.Name = "btn_file1_del" Then
            If [Shared].FileDelete(file1.Text, "DMA300") Then
                file1.Text = ""
                Save_Form()
            End If
        ElseIf btn.Name = "btn_file2_del" Then
            If [Shared].FileDelete(file2.Text, "DMA300") Then
                file2.Text = ""
                Save_Form()
            End If
        ElseIf btn.Name = "btn_file3_del" Then
            If [Shared].FileDelete(file3.Text, "DMA300") Then
                file3.Text = ""
                Save_Form()
            End If
        ElseIf btn.Name = "btn_file4_del" Then
            If [Shared].FileDelete(file4.Text, "DMA300") Then
                file4.Text = ""
                Save_Form()
            End If
        ElseIf btn.Name = "btn_file5_del" Then
            If [Shared].FileDelete(file5.Text, "DMA300") Then
                file5.Text = ""
                Save_Form()
            End If
        End If
    End Sub
 
    Private Sub g10_AfterMoveRow(sender As System.Object, PrevRowIndex As System.Int32, RowIndex As System.Int32) Handles g10.AfterMoveRow
        BTN_Enable()
    End Sub

    Private Sub BTN_Enable()
        If file1.Text = String.Empty Then
            btn_file1_del.Enabled = False
            btn_file1_view.Enabled = False
        Else
            btn_file1_del.Enabled = True
            btn_file1_view.Enabled = True
        End If

        If file2.Text = String.Empty Then
            btn_file2_del.Enabled = False
            btn_file2_view.Enabled = False
        Else
            btn_file2_del.Enabled = True
            btn_file2_view.Enabled = True
        End If

        If file3.Text = String.Empty Then
            btn_file3_del.Enabled = False
            btn_file3_view.Enabled = False
        Else
            btn_file3_del.Enabled = True
            btn_file3_view.Enabled = True
        End If

        If file4.Text = String.Empty Then
            btn_file4_del.Enabled = False
            btn_file4_view.Enabled = False
        Else
            btn_file4_del.Enabled = True
            btn_file4_view.Enabled = True
        End If

        If file5.Text = String.Empty Then
            btn_file5_del.Enabled = False
            btn_file5_view.Enabled = False
        Else
            btn_file5_del.Enabled = True
            btn_file5_view.Enabled = True
        End If
    End Sub
End Class
