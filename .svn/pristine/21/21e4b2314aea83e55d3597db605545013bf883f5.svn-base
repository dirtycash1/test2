Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_TR1102A

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Me.NewForm()
        New_Form()


        '전표 찾기를 숨김다
        '찾기버튼 클릭 
        MenuButton_Click(MenuType.Find)
    End Sub



    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()


            Case MenuType.Save
                'If Not Check_Save() Then
                '    Exit Sub
                'End If

                If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    If MyBase.Save() Then
                        'MyBase.OpenTrigger("wi_sa1120_list")
                    End If
                End If

            Case MenuType.Confirm
                'If Not Check_ConFrim() Then
                '    Exit Sub
                'End If

                If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else

                    'Me.Open("wi_sa1120_confirm")
                End If

                'stts.Text = "C"

            Case MenuType.Deconfirm

                'If Not Check_DeConFrim() Then
                '    Exit Sub
                'End If

                If MessageYesNo("확인취소 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    'Me.Open("wi_sa1120_deconfirm")
                End If

                'stts.Text = "S"

            Case MenuType.Find

                '찾기 visible

                If spc_1.Panel1Collapsed = False Then
                    spc_1.Panel1Collapsed = True
                Else
                    spc_1.Panel1Collapsed = False

                End If

            Case MenuType.Delete

                'If Not Check_Delete() Then
                '    Exit Sub
                'End If



                Me.WorkSets("wi_tr1102a_single").DeleteRow()

            Case MenuType.New
                New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub New_Form()

        cs_cd.Text = ""

        'Me.OpenTrigger("wi_tr1102a_glist")
        Me.Open("wi_tr1102a_single")


    End Sub

    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        ' 찾기 리스트 조회
        g_list.Open()

    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        f_cs_nm.Text = ""
        f_ps_nm.Text = ""
        f_stts.Text = "%"



    End Sub




    Private Sub cs_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles cs_cd.TextChanged
        Me.Open("wi_tr1102a_single")
    End Sub
End Class
