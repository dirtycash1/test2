Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMA100_SB_LIST

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If
                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g10.ButtonPressed

        Dim FileID As String = g10.Text("file_id")
        Dim FileNm As String = g10.Text("file_nm")

        If columnName = "show" Then

            '[Shared].FileDownLoad(FileID, FileNm, , True) '기존
            [Shared].FileDownLoad(FileID, FileNm, , True, "DMA100_SB") '시방서등록 메뉴에서 이미지 가져오기 

        ElseIf columnName = "down" Then

            [Shared].FileDownLoad(FileID, FileNm, , , "DMA100_SB")

        End If

    End Sub

End Class
