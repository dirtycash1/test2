Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMA100_DBN

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)


        Me.Form_New()
        '품목코드In 자동채번 설정
        itm_id.CodeNo = "DMA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다

        'itm_id.CodeDateField = out_dt

        img.Visible = False

        Me.XtraTabControl1.SelectedTabPageIndex = 1
        Me.XtraTabControl1.SelectedTabPageIndex = 0

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                Me.Form_Save()

            Case MenuType.New

                Me.Form_New()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub Form_New()

        f_itm_cd.Text = ""
        itm_id.Text = ""

        Me.OpenTrigger("dma100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

        itm_cd.Focus()

    End Sub

    Private Sub Form_Save()
        Try

            If MyBase.Save() Then

                Me.OpenTrigger("dma100_g10")

            End If

            itm_cd.Focus()

        Catch ex As Exception

            MessageError(ex)
        End Try

    End Sub

    Private Sub img_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        CallImageView(1)
    End Sub

    Private Sub CallImageView(ByVal GetID As String)
        If itm_cd.Text = "" Or GetID = "" Then Exit Sub
        If img.Image Is Nothing Then Exit Sub
        Try
            'eImage 에 Image Property 추가
            Dim f As ImageView
            f = New ImageView
            f.LoadPicture(img.Image, itm_cd.Text)
            f.ShowDialog()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub call_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CallImageView(1)
    End Sub

    Private Sub btn_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click
        If img.Visible Then
            img.Visible = False
            Me.SplitContainer4.SplitterDistance = 35
        Else
            img.Visible = True
            Me.SplitContainer4.SplitterDistance = 220
        End If
    End Sub

End Class
