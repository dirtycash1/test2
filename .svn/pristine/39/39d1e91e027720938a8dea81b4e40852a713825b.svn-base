Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SCS100

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.NewForm()

        'SetEditRight()
        Me.req_no.CodeNo = "SCS100"
        Me.req_no.CodeDateField = req_dt

        req_img.SizeMode = ImageSizeMode.Squeeze

        opt_show.AddItem("1", "요청자")
        opt_show.AddItem("2", "조치자")
        opt_show.AddItem("9", "All")

        opt_show.Text = "1"

        opt_show.TextBackColor = Color.Transparent   'opt_show.TextBackColor 'p_req_nm.TitleBackColor
    End Sub

    Public Overrides Sub NewForm()

        req_id.Text = ""
        Me.OpenTrigger("scs100_g10")

    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            Dim reqDt As String = req_dt.Text
            Dim reqNo As String = req_no.Text

            MyBase.Open()

            Dim f(1) As String
            f(0) = "req_dt=" + reqDt
            f(1) = "req_no=" + reqNo
            g10.Find(f)
        End If
    End Function

    Public Overrides Sub Delete()

        If MyBase.Delete("scs100_f10") = ExcuteResult.Succeeded Then
            MyBase.Open()
        End If

    End Sub


    'Private Sub req_id_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles req_id.TextChanged
    '    SetControlEnabled(req_id.Text <> "")
    'End Sub

    'Private Sub SetControlEnabled(ByVal isOpend As Boolean)
    '    Dim enabled As Boolean = (isOpend = True)

    '    req_dt.ReadOnly = enabled
    '    req_nm.ReadOnly = enabled
    '    'user_nm.ReadOnly = enabled
    '    wset_cd.ReadOnly = enabled
    '    stat_bc.ReadOnly = enabled
    '    frm_cd.ReadOnly = enabled
    '    frm_nm.ReadOnly = enabled

    'End Sub

    ''개발자만 조치에 관한 데이터 입력가능.
    'Private Sub SetWorkerControlEnabled()
    '    Dim enabled As Boolean = (isDeveloper.Checked = False)

    '    plan_dt.ReadOnly = enabled
    '    work_dt.ReadOnly = enabled
    '    req_bc.ReadOnly = enabled
    '    work_nm.ReadOnly = enabled
    '    work_dsc.ReadOnly = enabled

    '    'p_req_userId.ReadOnly = enabled
    '    p_req_rid.ReadOnly = enabled
    'End Sub

    'Private Sub btn_callView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If req_img.Image Is Nothing Then
    '        Exit Sub
    '    End If
    '    Try
    '        'eImage 에 Image Property 추가
    '        Dim f As ImageView
    '        f = New ImageView
    '        f.LoadPicture(req_img.Image, frm_nm.Text)
    '        f.ShowDialog()

    '    Catch ex As Exception
    '        MessageError(ex)
    '    End Try
    'End Sub

    'Private Sub SetEditRight()
    '    Dim dataSet As Data.DataSet = Me.OpenDataSet("scs100_getRight")
    '    If dataSet.Tables(0).Rows.Count = 0 Then
    '        isDeveloper.Checked = False
    '    Else
    '        isDeveloper.Checked = True
    '    End If
    '    SetWorkerControlEnabled()
    'End Sub

    Private Sub EPanel2_SizeChanged(sender As Object, e As System.EventArgs) Handles EPanel2.SizeChanged
        req_img.Height = EPanel2.Height - req_img.Top - 10
    End Sub

    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String
        menuName = g10.Text("frm_cd")
        Parameter.MainFrame.Frame.CallMenuForm(menuName)
    End Sub

    Private Sub opt_show_TextChanged(sender As Object, oldValue As String) Handles opt_show.TextChanged
        MyBase.Open()
    End Sub

End Class
