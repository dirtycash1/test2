Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SCH100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AddHandler Me.WorkSet("sch100_f10").AfterOpen, AddressOf f10_AfterOpen

        If Parameter.Login.UserKd = "SC700300" Then '외부사용자만 제한하도록 수정함 2012-05-17 PARK 컨설턴트 이하 제한할 경우 SC700800
            dsc.ReadOnly = True
            title.ReadOnly = True
            dsc_img.ReadOnly = True
        End If

        'Me.Open()
    End Sub

    Public Sub Open2(ByVal frmCd As String)
        system_cd.ReadOnly = True
        frm_cd2.ReadOnly = True
        top_menu.Visible = False
        menu_nm.Visible = False
        btn_jump.Visible = False
        btn_save.Enabled = True  '메뉴에서 직접 수정하여 저장하도록 함. 제외할 경우 실행중지 처리 하세요
        SplitContainer1.Panel1Collapsed = True
        SplitContainer2.Panel1Collapsed = True

        frm_cd2.Text = frmCd

        Me.Open()

    End Sub

    Private Sub f10_AfterOpen(ByVal wSet As Frame7.WorkSet)
        title.Text = ""
        title.Text = wSet.GetValue("title")

        dsc.Text = ""
        dsc.Text = wSet.GetValue("dsc")
        'usr_dsc.Text = wSet.GetValue("usr_dsc")
        'title.SelectAll()
        'title.SelectionFont = New Drawing.Font("굴림체", 10)
    End Sub

    Private Function _Save() As Boolean

        Dim wSet As Frame7.WorkSet
        wSet = Me.WorkSets("sch100_f10")
        wSet.SaveDataRow()  '만약 Rowcount = 0 이면 Addnew한다
        wSet.SetValue("title", title.Text)
        wSet.SetValue("dsc", dsc.Text)
        'wSet.SetValue("usr_dsc", usr_dsc.Text)
        wSet.DataChanged = True

        If Me.Save() Then

            Dim no As String = g10.Text("menu_cd")

            Me.Open()

            g10.Find("menu_cd=" + no)

        End If

    End Function

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save
                Me._Save()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click
        Dim frm As String = g10.Text("frm_cd")
        If frm <> "" Then
            Parameter.MainFrame.Frame.CallMenuForm(frm)
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Me._Save()
    End Sub

End Class
