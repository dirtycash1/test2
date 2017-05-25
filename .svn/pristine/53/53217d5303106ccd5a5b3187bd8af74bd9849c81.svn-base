Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class FAM790

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyBase.Open("fam790_g10")
        app_mon.Text = g10.Text("app_mon", g10.RowIndex)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save

            Case MenuType.New
                app_mon.Text = ""
                MyBase.Open("fam790_g20")

            Case MenuType.Save
                If app_mon.Text = "" Then
                    MsgBox("'적용년월' 선택은 필수입니다.")
                    Exit Sub
                End If
                Me.Save()
                Me.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        Me.Open()

    End Sub

    Private Sub g10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.Click

        If g10.Text("app_mon", g10.RowIndex) <> "" Then
            app_mon.Text = g10.Text("app_mon", g10.RowIndex)
            MyBase.Open("fam790_g20")
        End If

    End Sub

End Class
