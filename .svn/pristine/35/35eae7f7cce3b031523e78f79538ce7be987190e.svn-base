Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class PAZ800

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyBase.Open("paz800_g10")
        fr_dt.Text = g10.Text("fr_dt", g10.RowIndex)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save

            Case MenuType.New
                fr_dt.Text = ""
                MyBase.Open("paz800_g20")

            Case MenuType.Save
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

        If g10.Text("fr_dt", g10.RowIndex) <> "" Then
            fr_dt.Text = g10.Text("fr_dt", g10.RowIndex)
            MyBase.Open("paz800_g20")
        End If

    End Sub

End Class
