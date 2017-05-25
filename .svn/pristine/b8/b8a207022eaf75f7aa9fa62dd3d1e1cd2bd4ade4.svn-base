Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QML800

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        iss_no.CodeNo = "QMl800"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        iss_no.CodeDateField = iss_dt

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

    Private Sub btn_find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_find.Click
        If g10.RowCount <= 0 Then
            Exit Sub
        End If

        Try

            Dim Str As String = [Shared].FileUpload("")
            file_nm.Text = Str
            Me.Save("QML800_f10")

            Me.Open()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        [Shared].FileDownLoad(file_nm.Text)
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Try
            If [Shared].FileDelete(file_nm.Text) = True Then
                file_nm.Text = ""
                Me.Save("QML800_f10")
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
