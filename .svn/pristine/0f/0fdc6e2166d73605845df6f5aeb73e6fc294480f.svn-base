Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class DMA100_CMMS
    Private MovRow As Boolean

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
        g10.SelectRow = True

        Me.Form_New()
        '품목코드In 자동채번 설정
        itm_id.CodeNo = "DMA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        img.Visible = False

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    Me.Open()
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

        Form_Open

    End Sub

    Private Sub Form_Open()

        'Me.OpenTrigger("dma100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회
        Dim P As New OpenParameters
        P.Add("@itm_id", itm_id.Text)

        Me.Open("dma100_f10", P)
        Me.Open("dma100_sql")
        Me.Open("dma100_f20")
        Me.Open("dma100_g20")
        Me.Open("dma100_g30")
        Me.Open("dma100_g50")
        Me.Open("dma100_g60")

        itm_cd.Focus()

    End Sub

    Private Sub Form_Save()

        Try

            If MyBase.Save() Then

                Try

                    MovRow = True
                    Me.Open("dma100_g10")
                    Me.Open("dma100_sql")

                    Dim finder(0) As String
                    finder(0) = "itm_cd=" + itm_cd.Text
                    g10.Find(finder)

                Catch ex As Exception

                Finally
                    MovRow = False
                End Try

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

            'Dim p As New OpenParameters

            'p.Add("@itm_id", itm_id.Text)
            'p.Add("@reg_id", GetID)

            'Dim dSet As DataSet = Me.OpenDataSet("dma100_sql", p)   'dma130 WorkSet이 등록되어있어야 한다

            'If Not IsEmpty(dSet) Then
            '    If dSet.Tables(0).Rows(0)("img").ToString <> "" Then
            '        Dim photo() As Byte = dSet.Tables(0).Rows(0)("img")
            '        Dim ms As New System.IO.MemoryStream(photo)

            '        Dim f As ImageView
            '        f = New ImageView
            '        f.LoadPicture(ms, itm_cd.Text)
            '        f.ShowDialog()
            '    End If
            'End If
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub call_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles call_img.Click
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

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If MovRow Then Exit Sub
        itm_id.Text = g10.Text("itm_id")
        Form_Open()
    End Sub
End Class
