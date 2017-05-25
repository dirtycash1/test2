Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports FTP_Tools

Public Class DMA340

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################
    'Dim ftp As FTP_Tools.FTP_Tools = New FTP_Tools.FTP_Tools()

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Save
            Case MenuType.Delete
            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

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

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

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

    Private Sub o_rev_TextChanging(sender As System.Object, e As System.EventArgs)
        'If o_rev.Text = "" Then
        '    TextBoxClear()
        '    Return
        'End If

        'Dim param As OpenParameters = New OpenParameters
        'param.Add("@rev", o_rev.Text)
        'param.Add("@pjt_id", o_pjt_id.Text)
        'Dim ds = Me.OpenDataSet("dma340_combo_sql", param)

        'o_cust_nm.Text = ds.Tables(0).Rows(0)("cust_nm").ToString()
        'o_eng.Text = ds.Tables(0).Rows(0)("eng").ToString()
        'o_item_nm.Text = ds.Tables(0).Rows(0)("item_nm").ToString()
        'o_item_no.Text = ds.Tables(0).Rows(0)("item_no").ToString()
        'o_model.Text = ds.Tables(0).Rows(0)("model").ToString()
    End Sub

    'Private Sub TextBoxClear()
    '    o_rev.Text = ""
    '    o_cust_nm.Text = ""
    '    o_eng.Text = ""
    '    o_item_nm.Text = ""
    '    o_item_no.Text = ""
    '    o_model.Text = ""
    'End Sub

    Private Sub g10_ButtonPressed(sender As System.Object, columnName As System.String) Handles g10.ButtonPressed

        'If columnName = "file" Then
        '    Dim fileNm As String = g10.Text(columnName)
        '    If fileNm = "" Then
        '    Else
        '        Dim fileDir = FTP_Dialog.SaveDialogShow(fileNm)
        '        ftp.download(fileNm, fileDir)
        '        Dim dr As DialogResult = MessageBox.Show("다운로드한 파일을 열까요?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '        If dr = DialogResult.Yes Then
        '            Try
        '                Diagnostics.Process.Start(fileDir + fileNm)
        '            Catch ex As Exception
        '                MessageBox.Show(ex.Message.ToString, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            End Try
        '        End If
        '    End If
        'End If

        [Shared].FileDownLoad(g10.Text("file"), , True)

    End Sub

    Private Function o_rev() As Object
        Throw New NotImplementedException
    End Function

    Private Sub g10_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = "DMA320"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open2(g10.Text("pjt_id"), g10.Text("rev"), g10.Text("rslt"), g10.Text("step"))
    End Sub

    Public Sub Open2(ByVal pjt_nm As String, ByVal pjt_id As String)
        Dim param As OpenParameters = New OpenParameters
        param.Add("@o_pjt_nm", pjt_nm)
        param.Add("@o_pjt_id", pjt_id)
        Me.Open("dma340_g20", param)

        param = New OpenParameters
        param.Add("@o_pjt_id", pjt_id)
        Me.Open("dma340_g10", param)
    End Sub

End Class
