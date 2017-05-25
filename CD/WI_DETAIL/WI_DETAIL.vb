Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_DETAIL

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '수주 번호 채번
        'od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'od_no.CodeDateField = od_dt

        Me.NewForm()
       
        'g_body.AddNewRow()                 'body 한줄을 넣어준다

        '전표 찾기를 숨김다
        '찾기버튼 클릭 
        MenuButton_Click(MenuType.Find)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()


            Case MenuType.Save
                If Not Check_Save() Then
                    Exit Sub
                End If

                If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    If MyBase.Save() Then
                        MyBase.OpenTrigger("wi_sa1120_list")
                    End If
                End If

            Case MenuType.Confirm
                If Not Check_ConFrim() Then
                    Exit Sub
                End If

                If MessageYesNo("확인 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                Else

                    'Me.Open("wi_sa1120_confirm")
                End If

                'stts.Text = "C"

            Case MenuType.Deconfirm

                If Not Check_DeConFrim() Then
                    Exit Sub
                End If

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

                If Not Check_Delete() Then
                    Exit Sub
                End If

                If MessageYesNo("삭제 하시겠습니까?") = MsgBoxResult.No Then
                    Exit Sub
                End If


            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub New_Form()

        'od_no.Text = ""
        'Me.OpenTrigger("wi_sa1120_list")
        'g_body.AddNewRow()
    End Sub


    Private Function Check_Save() As Boolean

        '상태값(CHECK)
        'If stts.Text = "C" Then
        '    MsgBox("확인 된 자료입니다.")
        '    Return False

        'End If




        Return True
    End Function

    Private Function Check_ConFrim() As Boolean

        '상태값 CHECK
        'If stts.Text <> "S" Then
        '    MsgBox("저장 상태인 전표만 확인처리 할 수 있습니다..")
        '    Return False

        'End If

        Return True
    End Function

    Private Function Check_DeConFrim() As Boolean

        '상태값 CHECK
        'If stts.Text <> "C" Then
        '    MsgBox("확인 상태인 전표만 확인취소 할 수 있습니다..")
        '    Return False
        'End If

        Return True
    End Function

    Private Function Check_Delete() As Boolean

        '상태값 CHECK
        'If stts.Text <> "S" Then
        '    MsgBox("저장 상태인 전표만 삭제 할 수 있습니다..")
        '    Return False

        'End If

        Return True
    End Function

    Private Sub g_list_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g_list.DoubleClick
        Dim p As New OpenParameters
        'p.Add("@bal_no", g_list.Text("BAL_NO", g_list.RowIndex))

        'Me.Open("wi_ku1120_head", p)
        'Me.Open("wi_ku1120_body", p)

        If find_visible.Checked Then MenuButton_Click(MenuType.Find)
    End Sub

End Class
