Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_SA1120

    Private Sub WI_SA1120_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'SplitContainer1.Panel1Collapsed = False
        'SplitContainer1.Panel2Collapsed = False

        spc1.Panel1Collapsed = Not chk_show.Checked
        'spc1.Panel1Collapsed = False



        ep_head.SetSplitter(spc1, spc1.Panel2)


        '수주 번호 채번
        od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt

        Me.NewForm()



    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()


            Case MenuType.Save
                If Not Check_Save() Then
                    Exit Sub
                End If
                If MyBase.Save() Then
                    'MyBase.OpenTrigger("wi_sa1120_list")
                    g_list.Open()

                End If

            Case MenuType.Confirm
                If Not Check_Save() Then
                    Exit Sub
                End If

                If MessageYesNo("확인하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Me.Open("wi_sa1120_confirm")
                End If

            Case MenuType.Deconfirm

                If Not Check_Save() Then
                    Exit Sub
                End If

                If MessageYesNo("확인취소하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Me.Open("wi_sa1120_deconfirm")
                End If





            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        od_no.Text = ""
        Me.OpenTrigger("wi_sa1120_list")
        g_body.AddNewRow()
    End Sub

    Private Function Check_Save() As Boolean
        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function
    Private Function Check_CsCd() As Boolean
        Try

            '납품처코드 체크
            If nacs_cd.Text = "" Then
                nacs_cd.Focus()
                MessageInfo("납품처코드를 입력하세요")
                Return True
            End If
            '거래처코드 체크
            If cs_cd.Text = "" Then
                cs_cd.Focus()
                MessageInfo("거래처코드를 입력하세요")
                Return True
            End If
            '납품처명 체크
            If nacs_nm.Text = "" Then
                nacs_nm.Focus()
                MessageInfo("납품처명를 입력하세요")
                Return True
            End If
            '거래처명 체크
            If cs_nm.Text = "" Then
                cs_nm.Focus()
                MessageInfo("거래처명를 입력하세요")
                Return True
            End If



            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        ' 찾기 리스트 조회
        g_list.Open()
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        find_cs_cd.Text = ""
        find_cs_nm.Text = ""




    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged
        spc1.Panel1Collapsed = Not chk_show.Checked
    End Sub

End Class
