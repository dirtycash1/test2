Imports Frame7
Imports Base7
Imports Base7.Shared
Imports DevExpress.XtraEditors

Public Class QMA300

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mgt_id.CodeNo = "QMA300"

        Me.New_Form()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                Me.New_Form()

            Case MenuType.Save

                If MyBase.Save() Then
                    MyBase.Open()  '저장에 성공후 Open한다
                End If

            Case MenuType.Delete
                If Me.Delete("qma300_f10") = ExcuteResult.Succeeded Then
                    Me.Open("qma300_f10")
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        mgt_id.Text = ""
        Me.OpenTrigger("qma300_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

        mgt_no.Focus()
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
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub ImgOpen_Click(sender As System.Object, e As System.EventArgs) Handles ImgOpen.Click
        Dim button As SimpleButton = CType(sender, SimpleButton)
        Dim dialog As New OpenFileDialog
        dialog.Filter = "JPG(*.JPG)|*.JPG|GIF(*.GIF)|*.GIF|BMP(*.BMP)|*.BMP|ALL file(*.*)|*.*"
        dialog.FilterIndex = 1
        dialog.Title = "이미지 불러오기" 'ChrW(51060) & ChrW(48120) & ChrW(51648) & " " & ChrW(49440) & ChrW(53469)
        dialog.RestoreDirectory = True
        dialog.CheckFileExists = True
        dialog.CheckPathExists = True
        If (dialog.ShowDialog = DialogResult.OK) Then
            Me.img.Image = Image.FromFile(dialog.FileName)
        End If
    End Sub

    Private Sub ImgDelete_Click(sender As System.Object, e As System.EventArgs) Handles ImgDelete.Click
        Dim button As SimpleButton = DirectCast(sender, SimpleButton)
        Me.img.Image = Nothing
    End Sub

 
End Class
