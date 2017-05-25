Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMA100_SB_BOM

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
                    g20.Open()
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


    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed

        Dim FileID As String = g20.Text("file_id")
        Dim FileNm As String = g20.Text("file_nm")


        If columnName = "show" Then

            '[Shared].FileDownLoad(FileID, FileNm, , True)
            [Shared].FileDownLoad(FileID, FileNm, , True, "DMA100_SB")

        ElseIf columnName = "down" Then

            [Shared].FileDownLoad(FileID, FileNm, , , "DMA100_SB")

            '[Shared].FileDownLoad(FileID, FileNm)

            'Try
            '    If [Shared].FileDelete(FileID, FileNm) = True Then
            '        g90.AllowDeleteRows = True
            '        g90.DeleteRow(g90.RowIndex)
            '        g90.AllowDeleteRows = False

            '        Me.Save("dma100_sb_g90")
            '    End If
            'Catch ex As Exception
            '    MessageInfo(ex)
            'End Try

            'ElseIf columnName = "del" Then
            'Try
            '    If [Shared].FileDelete(FileID, FileNm) = True Then
            '        g90.AllowDeleteRows = True
            '        g90.DeleteRow(g90.RowIndex)
            '        g90.AllowDeleteRows = False

            '        Me.Save("dma100_sb_g90")
            '    End If
            'Catch ex As Exception
            '    MessageInfo(ex)
            'End Try

            'ElseIf columnName = "upload" Then
            '    Call FileAdd()

        End If

    End Sub



End Class
